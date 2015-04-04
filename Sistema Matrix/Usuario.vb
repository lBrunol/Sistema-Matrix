Imports System.Data.OleDb

Public Class Usuario
    Public varUsuario As String
    Public varSenha As String
    Public varConfirmaSenha As String
    Public varAdm As Boolean
    Public varValorRetornado As Integer
    Public strSql As String
    Public valorCodUsuario As Integer
    Public objBanco As New ConexaoAccess
    Public tabela As DataTable
    Public leitor As OleDbDataReader


    Private Sub botCadastrar_Click(sender As Object, e As EventArgs) Handles botCadastrar.Click

        'Definição das variáveis
        varUsuario = txtUsuario.Text
        varSenha = txtSenha.Text
        varConfirmaSenha = txtConfirmaSenha.Text
        varAdm = chkAdministrador.Checked
        varValorRetornado = Funcoes.verificaVazio(Me)
        'Testes condicionais
        If varValorRetornado = 0 Then
            If varSenha = varConfirmaSenha Then
                Try
                    strSql = "INSERT INTO usuarios(usrCodigo, usrNome, ursSenha, usrAdministrador) VALUES (" & valorCodUsuario & " , '" & varUsuario & "', '" & varSenha & "', " & varAdm & ")"
                    objBanco.ExecutaQuery(strSql)
                    MsgBox("Usuário criado", vbInformation, "Sucesso")
                    Limpar(Me)
                    valorCodUsuario = atribuiCodigo("usrCodigo", "usuarios")
                    txtCodigoUsuario.Text = valorCodUsuario
                Catch exc As SqlClient.SqlException
                    MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
                Catch exc As Exception
                    MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
                Finally
                    objBanco.DesconectarBanco()
                    strSql = String.Empty
                End Try
            Else
                MsgBox("Digite a senha corretamente nas duas caixas de texto", vbExclamation, "Aviso")
                txtSenha.Focus()
            End If
        End If
    End Sub
    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        varUsuario = txtUsuario.Text
        If varUsuario <> "" Then
            Try
                strSql = "SELECT Count(usuarios.usrNome) FROM usuarios WHERE usuarios.usrNome = '" & varUsuario & "'"
                leitor = objBanco.ExecutaDataRead(strSql)
                'Le os resultados
                leitor.Read()
                If leitor.GetValue(0) <> 0 Then
                    MsgBox("Este usuário já esta cadastrado, por favor, escolha outro nome", vbExclamation, "Aviso")
                    txtUsuario.Focus()
                End If
            Catch exc As SqlClient.SqlException
                MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
            Catch exc As Exception
                MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
            Finally
                'Fecha a conexão
                objBanco.DesconectarBanco()
                strSql = String.Empty
                'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
                If leitor IsNot Nothing Then
                    leitor.Close()
                    leitor = Nothing
                End If
            End Try
        End If
    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valorCodUsuario = atribuiCodigo("usrCodigo", "usuarios")
        txtCodigoUsuario.Text = valorCodUsuario
    End Sub

    Private Sub Usuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Funcoes.HabilitaBotaoLogOff()
    End Sub
End Class