Imports Sistema_Matrix.ConexaoAccess
Imports System.Data
Imports System.Data.OleDb
Public Class ConsultaUsuarios
    'Declaração de variáveis públicas
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public valorCodUsuario As Integer
    Public objBanco As New ConexaoAccess
    Public usrAtual As String

    Private Sub tabConsultaUsuarios_Enter(sender As Object, e As EventArgs) Handles tabConsultaUsuarios.Enter
        dtgConsultaUsuarios.Rows.Clear()
        Try
            tabela = New DataTable()

            strsql = "SELECT * FROM usuarios"
            tabela = objBanco.ExecutaDataTable(strsql)

            If tabela.Rows.Count > 0 Then
                Dim i As Integer = 0
                For i = 0 To tabela.Rows.Count - 1
                    dtgConsultaUsuarios.Rows.Add(tabela.Rows(i)("usrCodigo"), tabela.Rows(i)("usrNome"), tabela.Rows(i)("ursSenha"))
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

    Private Sub dtgConsultaUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgConsultaUsuarios.CellDoubleClick

        tabUsuarios.SelectTab(0)
        Try
            'Armazena o valor da matricula da linha atual
            valorCodUsuario = dtgConsultaUsuarios.CurrentRow.Cells(0).Value
            'Exibe os botões de alteração e exclusão e oculta os de adição
            botAlterar.Enabled = True
            lblAlterar.Enabled = True
            botExcluir.Enabled = True
            lblExcluir.Enabled = True


            'String que armazena o comando SQL
            strsql = "SELECT * FROM usuarios WHERE usrCodigo = " & valorCodUsuario
            'Executa a consulta
            leitor = objBanco.ExecutaDataRead(strsql)
            'Le os dados retornados
            leitor.Read()

            txtNome.Text = leitor.Item(1).ToString
            usrAtual = leitor.Item(1).ToString
            txtSenha.Text = leitor.Item(2).ToString
            chkAdministrador.Checked = leitor.GetBoolean(3)
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


    Private Sub botAlterar_Click(sender As Object, e As EventArgs) Handles botAlterar.Click
        Dim valRetornado As Integer

        valRetornado = Funcoes.verificaVazio(Me)
        Try
            If valRetornado = 0 Then
                strsql = "UPDATE usuarios SET usrNome = '" & txtNome.Text & "', ursSenha = '" & txtSenha.Text & "', usrAdministrador = " & chkAdministrador.Checked & " WHERE usrCodigo = " & valorCodUsuario
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados Alterados com Sucesso", vbInformation, "Aviso")
                Funcoes.Limpar(Me)
                botAlterar.Enabled = False
                lblAlterar.Enabled = False
                botExcluir.Enabled = False
                lblExcluir.Enabled = False
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Number & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
        End Try
    End Sub

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click
        Try
            If MsgBox("Deseja excluir o registro selecionado?", vbQuestion + vbYesNo, "Confirme") = vbYes Then
                strsql = "DELETE FROM usuarios WHERE usrCodigo = " & valorCodUsuario
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados excluídos com sucesso", vbInformation, "Aviso")
                Funcoes.Limpar(Me)
                botAlterar.Enabled = False
                lblAlterar.Enabled = False
                botExcluir.Enabled = False
                lblExcluir.Enabled = False
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
    Private Sub txtNome_LostFocus(sender As Object, e As EventArgs) Handles txtNome.LostFocus

        If txtNome.Text <> "" Then
            Try
                strsql = "SELECT Count(usuarios.usrNome) FROM usuarios WHERE usuarios.usrNome = '" & txtNome.Text & "'"
                leitor = objBanco.ExecutaDataRead(strsql)
                'Le os resultados
                leitor.Read()
                If leitor.GetValue(0) >= 1 And txtNome.Text <> usrAtual Then
                    MsgBox("Este usuário já esta cadastrado, por favor, escolha outro nome", vbExclamation, "Aviso")
                    txtNome.Focus()
                End If
            Catch exc As SqlClient.SqlException
                MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
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
End Class