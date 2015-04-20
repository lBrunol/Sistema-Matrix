Imports System.Data
Imports System.Data.OleDb
Imports System.Data.OracleClient
Public Class Login
    Public strUsuario As String
    Public varUsuarioAdm As Boolean
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public objBanco As New ConexaoAccess
    'Armazena o número de tentativas erradas de se logar no sistema
    Dim numTentativas As Integer = 0
    Private Sub botOk_Click(sender As Object, e As EventArgs) Handles botOk.Click

        'Armazena a senha
        Dim strSenha As String

        'Captura os valores das caixas de texto
        strUsuario = txtUsuario.Text
        strSenha = txtSenha.Text
        Try
            If (strUsuario = "") Then
                MsgBox("Preencha os campos", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            ElseIf (strSenha = "") Then
                MsgBox("Preencha os campos", MsgBoxStyle.Exclamation)
                txtSenha.Focus()
            ElseIf (numTentativas < 3) Then
                'Instrução SQL
                strsql = "SELECT usuarios.usrNome, usuarios.ursSenha, usuarios.usrAdministrador FROM usuarios WHERE usuarios.usrNome = '" & strUsuario & "' and usuarios.ursSenha = '" & strSenha & "'"
                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()
                'Verifica se a consulta retornou algo
                If (Not leitor.HasRows = True) Then
                    MsgBox("Usuário ou senha incorreto(s)", vbCritical)
                    'Incrementa o número de tentativas
                    numTentativas = numTentativas + 1
                    Funcoes.Limpar(Me)
                    txtUsuario.Focus()
                Else
                    If leitor.GetString(0).ToString = strUsuario And leitor.GetString(1).ToString = strSenha Then
                        'Zera os números de tentativas
                        numTentativas = 0
                        'Oculta o formulário de login
                        Me.Hide()
                        'Verifica se o usuário que logou é administrador
                        varUsuarioAdm = leitor.GetBoolean(2)
                        'Mostra a tela principal
                        telaPrincipal.Show()
                        'Limpa os campos do formulário
                        Funcoes.Limpar(Me)
                    Else
                        MsgBox("Erro desconhecido", vbCritical, "Erro")
                    End If
                End If
            Else
                MsgBox("Você atingiu o limite máximo de tentativas para logar no sistema", vbCritical)
                End
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

    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
