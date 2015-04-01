Imports Sistema_Matrix.ConexaoAccess
Module Funcoes
    Public i As Integer
    Public j As Integer
    Public Function verificaVazio(ByVal nomeFormulario As Control)
        Dim ctl As Control
        For Each ctl In nomeFormulario.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is RichTextBox Or TypeOf ctl Is ComboBox Then
                If ctl.Text = "" Then
                    If ctl.Tag = "" Then
                        MsgBox("Existem campos obrigatórios vazios", vbInformation, "Aviso")
                        ctl.Focus()
                        i = i + 1
                        Return i
                    End If
                Else
                    i = 0
                End If
            ElseIf TypeOf ctl Is MaskedTextBox Then
                If ctl.Tag = "" Then
                    If Not DirectCast(ctl, MaskedTextBox).MaskFull Then
                        MsgBox("Existem campos obrigatórios vazios", vbInformation, "Aviso")
                        ctl.Focus()
                        i = i + 1
                        Return i
                    Else
                        i = 0
                    End If
                End If
            ElseIf ctl.Controls.Count > 0 Then
                verificaVazio(ctl)
            End If
        Next
        Return i
    End Function
    Public Sub Limpar(ByVal nomeFormulario As Control)
        Dim ctl As Control
        For Each ctl In nomeFormulario.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = String.Empty
            ElseIf TypeOf ctl Is RichTextBox Then
                DirectCast(ctl, RichTextBox).Text = String.Empty
            ElseIf TypeOf ctl Is ComboBox Then
                DirectCast(ctl, ComboBox).ResetText()
            ElseIf TypeOf ctl Is MaskedTextBox Then
                DirectCast(ctl, MaskedTextBox).Text = String.Empty
            ElseIf ctl.Controls.Count > 0 Then
                Limpar(ctl)
            End If
        Next
    End Sub
    Function filtraTextbox(nomeDataset As DataGridView, nomeTextBox As TextBox, radio As RadioButton, campoFiltrado As String)
        nomeDataset.Rows.Clear()
        Dim conexao As New OleDb.OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = dados/banco.accdb")
        conexao.Open()
        Dim ds As DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim vStr As String

        ds = New DataSet()

        If radio.Checked = True Then
            If nomeTextBox.Text <> "" Then
                vStr = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaFisica.cliCPF FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo WHERE " & campoFiltrado & " LIKE '" & nomeTextBox.Text & "%' ORDER BY cliente.cliCodigo"
                da = New OleDb.OleDbDataAdapter(vStr, conexao)
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        nomeDataset.Rows.Add(ds.Tables(0).Rows(i)("cliCodigo"), ds.Tables(0).Rows(i)("cliNome"), ds.Tables(0).Rows(i)("cliCPF"))
                    Next
                End If
            Else
                vStr = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaFisica.cliCPF FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo ORDER BY cliente.cliCodigo"
                da = New OleDb.OleDbDataAdapter(vStr, conexao)
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        nomeDataset.Rows.Add(ds.Tables(0).Rows(i)("cliCodigo"), ds.Tables(0).Rows(i)("cliNome"), ds.Tables(0).Rows(i)("cliCPF"))
                    Next
                End If
            End If
            nomeDataset.Refresh()
            conexao.Close()
        Else
            If nomeTextBox.Text <> "" Then
                vStr = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaJuridica.cliCNPJ FROM cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo WHERE " & campoFiltrado & " LIKE '" & nomeTextBox.Text & "%' ORDER BY cliente.cliCodigo"
                da = New OleDb.OleDbDataAdapter(vStr, conexao)
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        nomeDataset.Rows.Add(ds.Tables(0).Rows(i)("cliCodigo"), ds.Tables(0).Rows(i)("cliNome"), ds.Tables(0).Rows(i)("cliCNPJ"))
                    Next
                End If
            Else
                vStr = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaJuridica.cliCNPJ FROM cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo ORDER BY cliente.cliCodigo"
                da = New OleDb.OleDbDataAdapter(vStr, conexao)
                da.Fill(ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        nomeDataset.Rows.Add(ds.Tables(0).Rows(i)("cliCodigo"), ds.Tables(0).Rows(i)("cliNome"), ds.Tables(0).Rows(i)("cliCNPJ"))
                    Next
                End If
            End If
            nomeDataset.Refresh()
            conexao.Close()
        End If
        Return True
    End Function
    Sub filtra(ByVal nomeTextBox As TextBox, ByVal strSql As String, ByVal nomeDataset As DataGridView, ByVal campo1 As String, ByVal campo2 As String, ByVal campo3 As String, ByVal nomeTabela As String)
        nomeDataset.Rows.Clear()
        Dim objBanco As New ConexaoAccess
        Dim tabela As DataTable
        tabela = New DataTable()
        Try
            If nomeTextBox.Text <> "" Then
                tabela = objBanco.ExecutaDataTable(strSql)
                If tabela.Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To tabela.Rows.Count - 1
                        nomeDataset.Rows.Add(tabela.Rows(i)(campo1), tabela.Rows(i)(campo2), tabela.Rows(i)(campo3))
                    Next
                End If
            Else
                strSql = "SELECT * FROM " & nomeTabela & ""
                tabela = objBanco.ExecutaDataTable(strSql)
                If tabela.Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To tabela.Rows.Count - 1
                        nomeDataset.Rows.Add(tabela.Rows(i)(campo1), tabela.Rows(i)(campo2), tabela.Rows(i)(campo3))
                    Next
                End If
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            'Fecha a conexão
            objBanco.DesconectarBanco()
            strSql = String.Empty
        End Try

        nomeDataset.Refresh()
    End Sub
    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function

    Function habilitaDesabilitaControles(nomeFormulario As Control, ByVal opcao As Boolean)

        Dim ctl As Control
        If opcao = True Then
            For Each ctl In nomeFormulario.Controls
                If TypeOf ctl Is TextBox Or TypeOf ctl Is RichTextBox Or TypeOf ctl Is MaskedTextBox Then
                    If ctl.Tag = "" Then
                        ctl.Enabled = False
                    End If
                ElseIf ctl.Controls.Count > 0 Then
                    habilitaDesabilitaControles(ctl, True)
                End If
            Next
        Else
            For Each ctl In nomeFormulario.Controls
                If TypeOf ctl Is TextBox Or TypeOf ctl Is RichTextBox Or TypeOf ctl Is MaskedTextBox Then
                    If ctl.Tag = "" Then
                        ctl.Enabled = True
                    End If
                ElseIf ctl.Controls.Count > 0 Then
                    habilitaDesabilitaControles(ctl, False)
                End If
            Next
        End If
        Return True
    End Function

    Function atribuiCodigo(ByVal nomeCampo As String, ByVal nomeTabela As String)
        'Atribui os códigos manualmente no banco, a função faz um select verificando o maior número e adiciona mais 1
        'a este gerando o código do novo registro.
        'Funciona através da passagem do nome do campo e da tabela
        Dim strsql As String
        Dim tabela As DataTable
        Dim objBanco As New ConexaoAccess
        Dim valorCod As Integer

        strsql = "SELECT MAX (" & nomeCampo & ") FROM " & nomeTabela & ""

        tabela = New DataTable
        'Executa o método para buscar no banco
        tabela = objBanco.ExecutaDataTable(strsql)
        'Verifica se a linha retornada é diferente de vazio
        If tabela.Rows(0)(0).ToString <> "" Then
            'Converte o código retornado em inteiro e adiciona mais 1
            valorCod = CInt(tabela.Rows(0)(0))
            valorCod = valorCod + 1
        Else
            valorCod = 1
        End If

        Return valorCod

    End Function
End Module
