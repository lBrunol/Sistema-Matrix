Imports Sistema_Matrix.clsConexaoBanco
Imports System.Data
Imports System.Data.OleDb
Public Class frmGerenciamentoFuncionarios
    'Declaração de variáveis públicas
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public valorMatricula As Integer
    Public objBanco As New clsConexaoBanco
    Private Sub botCadastrar_Click(sender As Object, e As EventArgs) Handles botCadastrar.Click
        Dim valRetornado As Integer

        valRetornado = modFuncoes.verificaVazio(Me)

        If valRetornado = 0 Then
            Try
                'String que armazena o comando SQL
                strsql = "INSERT INTO funcionarios( funMatricula, funNome, funCargo, funAdmissao) VALUES (" & valorMatricula & " , '" & txtNome.Text & "', '" & txtCargo.Text & "' , '" & mtxDataAdmissao.Text & "')"
                'Chama o método para executar o comando
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados inseridos com Sucesso", vbInformation, "Aviso")
                'Limpa as caixas de texto
                modFuncoes.Limpar(Me)
                valorMatricula = atribuiCodigo("funMatricula", "funcionarios")
                txtMatricula.Text = valorMatricula
            Catch exc As SqlClient.SqlException
                MsgBox("Erro com banco de dados" & vbCrLf & Err.Number & Err.Description, vbCritical, "Erro com Banco de dados")
            Catch exc As Exception
                MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
            Finally
                'Fecha a conexão
                objBanco.DesconectarBanco()
                strsql = String.Empty
                'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
                If leitor IsNot Nothing Then
                    leitor.Close()
                    leitor = Nothing
                End If
            End Try
        End If
    End Sub

    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNome.Focus()
        valorMatricula = atribuiCodigo("funMatricula", "funcionarios")
        txtMatricula.Text = valorMatricula
    End Sub

    Private Sub botHoje_Click(sender As Object, e As EventArgs) Handles botHoje.Click
        mtxDataAdmissao.Text = Today
    End Sub

    Private Sub botLimpar_Click(sender As Object, e As EventArgs) Handles botLimpar.Click
        modFuncoes.Limpar(Me)
        valorMatricula = atribuiCodigo("funMatricula", "funcionarios")
        txtMatricula.Text = valorMatricula
    End Sub
    Private Sub dtgFuncionarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgFuncionarios.CellDoubleClick

        tabFuncionarios.SelectTab(0)
        Try
            'Armazena o valor da matricula da linha atual
            valorMatricula = dtgFuncionarios.CurrentRow.Cells(0).Value

            'Exibe os botões de alteração e exclusão e oculta os de adição
            botCadastrar.Visible = False
            lblCadastrar.Visible = False
            botLimpar.Visible = False
            lblLimpar.Visible = False

            botAlterar.Visible = True
            lblAlterar.Visible = True
            botExcluir.Visible = True
            lblExcluir.Visible = True
            botModoNovo.Visible = True
            lblInserir.Visible = True
            txtMatricula.Enabled = False

            'String que armazena o comando SQL
            strsql = "SELECT * FROM funcionarios WHERE funMatricula = " & valorMatricula
            'Executa a consulta
            leitor = objBanco.ExecutaDataRead(strsql)
            'Le os dados retornados
            leitor.Read()

            txtMatricula.Text = leitor.Item(0).ToString
            txtNome.Text = leitor.Item(1).ToString
            txtCargo.Text = leitor.Item(2).ToString
            mtxDataAdmissao.Text = leitor.Item(3).ToString
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Number & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            'Fecha a conexão
            objBanco.DesconectarBanco()
            If leitor IsNot Nothing Then
                leitor.Close()
                leitor = Nothing
            End If
            strsql = String.Empty
        End Try
    End Sub

    Private Sub botModoNovo_Click(sender As Object, e As EventArgs) Handles botModoNovo.Click
        modoInserir()
        modFuncoes.Limpar(Me)
        valorMatricula = atribuiCodigo("funMatricula", "funcionarios")
        txtMatricula.Text = valorMatricula
    End Sub

    Private Sub txtConMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConMatricula.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtConMatricula_TextChanged(sender As Object, e As EventArgs) Handles txtConMatricula.TextChanged
        strsql = "SELECT * FROM funcionarios WHERE funMatricula LIKE " & txtConMatricula.Text & " ORDER BY funMatricula"
        modFuncoes.filtra(txtConMatricula, strsql, dtgFuncionarios, "funMatricula", "funNome", "funCargo", "funcionarios")
    End Sub

    Private Sub botAlterar_Click(sender As Object, e As EventArgs) Handles botAlterar.Click
        Dim valRetornado As Integer

        valRetornado = modFuncoes.verificaVazio(Me)
        Try
            If valRetornado = 0 Then
                strsql = "UPDATE Funcionarios SET funNome ='" & txtNome.Text & "', funCargo = '" & txtCargo.Text & "', funAdmissao = '" & mtxDataAdmissao.Text & "' WHERE funMatricula = " & valorMatricula
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados Alterados com Sucesso", vbInformation, "Aviso")
                modFuncoes.Limpar(Me)
                modoInserir()
                valorMatricula = atribuiCodigo("funMatricula", "funcionarios")
                txtMatricula.Text = valorMatricula
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Number & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
        End Try
    End Sub
    Private Sub txtConNome_TextChanged(sender As Object, e As EventArgs) Handles txtConNome.TextChanged
        strsql = "SELECT * FROM funcionarios WHERE funNome LIKE '" & txtConNome.Text & "%' ORDER BY funNome"
        modFuncoes.filtra(txtConNome, strsql, dtgFuncionarios, "funMatricula", "funNome", "funCargo", "funcionarios")
    End Sub

    Private Sub txtConCargo_TextChanged(sender As Object, e As EventArgs) Handles txtConCargo.TextChanged
        strsql = "SELECT * FROM funcionarios WHERE funCargo LIKE '" & txtConCargo.Text & "%' ORDER BY funCargo"
        modFuncoes.filtra(txtConCargo, strsql, dtgFuncionarios, "funMatricula", "funNome", "funCargo", "funcionarios")
    End Sub

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click
        Try
            If MsgBox("Deseja excluir o registro selecionado?", vbQuestion + vbYesNo, "Confirme") = vbYes Then
                strsql = "DELETE FROM funcionarios WHERE funMatricula = " & valorMatricula
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados excluídos com sucesso", vbInformation, "Aviso")
                modFuncoes.Limpar(Me)
                modoInserir()
                valorMatricula = atribuiCodigo("funMatricula", "funcionarios")
                txtMatricula.Text = valorMatricula
            Else
                End
            End If

        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Number & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
        End Try
    End Sub

    Private Sub tabConsultaFuncionarios_Enter(sender As Object, e As EventArgs) Handles tabConsultaFuncionarios.Enter
        dtgFuncionarios.Rows.Clear()
        Try
            tabela = New DataTable()

            strsql = "SELECT * FROM funcionarios"
            tabela = objBanco.ExecutaDataTable(strsql)

            If tabela.Rows.Count > 0 Then
                Dim i As Integer = 0
                For i = 0 To tabela.Rows.Count - 1
                    dtgFuncionarios.Rows.Add(tabela.Rows(i)("funMatricula"), tabela.Rows(i)("funNome"), tabela.Rows(i)("funCargo"))
                Next
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Number & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            'Fecha a conexão
            objBanco.DesconectarBanco()
            strsql = String.Empty
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
            tabela = Nothing
        End Try
    End Sub
    Sub modoInserir()
        botCadastrar.Visible = True
        lblCadastrar.Visible = True
        botLimpar.Visible = True
        lblLimpar.Visible = True
        botAlterar.Visible = False
        lblAlterar.Visible = False
        botExcluir.Visible = False
        lblExcluir.Visible = False
        botModoNovo.Visible = False
        lblInserir.Visible = False
    End Sub

    Private Sub Funcionarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        modFuncoes.HabilitaBotaoLogOff()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub tabCadastroFuncionarios_Click(sender As Object, e As EventArgs) Handles tabCadastroFuncionarios.Click

    End Sub
End Class