Imports System.Data
Imports System.Data.OleDb
Public Class Login
    Public strUsuario As String
    Public varUsuarioAdm As Boolean
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public objBanco As New ConexaoAccess
    Private Sub botOk_Click(sender As Object, e As EventArgs) Handles botOk.Click
        'Declaração de variáveis
        Dim strSenha As String

        'Captura os valores das caixas de texto
        strUsuario = txtUsuario.Text
        strSenha = txtSenha.Text
        Try
            If (strSenha = "" Or strUsuario = "") Then
                MsgBox("Preencha os campos", MsgBoxStyle.Exclamation)
            Else
                'Instrução SQL
                strsql = "SELECT usuarios.usrNome, usuarios.ursSenha, usuarios.usrAdministrador FROM usuarios WHERE usuarios.usrNome = '" & strUsuario & "' and usuarios.ursSenha = '" & strSenha & "'"
                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()
                'Verifica se a consulta retornou algo
                If (Not leitor.HasRows = True) Then
                    MsgBox("Usuário ou senha incorreto(s)", vbCritical)
                Else
                    If leitor.GetString(0).ToString = strUsuario And leitor.GetString(1).ToString = strSenha Then
                        Me.Hide()
                        varUsuarioAdm = leitor.GetBoolean(2)
                        telaPrincipal.Show()
                        Limpar(Me)
                    Else
                        MsgBox("Erro desconhecido", vbCritical, "Erro")
                    End If
                End If
            End If

            'Tratamento dos erros
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description)
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description)
        Finally
            objBanco.DesconectarBanco()
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
            If leitor IsNot Nothing Then leitor.Close()
        End Try
    End Sub
    Private Sub botLimpar_Click(sender As Object, e As EventArgs) Handles botLimpar.Click
        Funcoes.Limpar(Me)
    End Sub
End Class
