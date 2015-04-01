Public Class telaPrincipal
    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        Clientes.Show()
    End Sub

    Private Sub menuCadastroFornecedor_Click(sender As Object, e As EventArgs) Handles menuCadastroFornecedor.Click
        Funcionarios.Show()
    End Sub

    Private Sub menuCadastroFuncionario_Click(sender As Object, e As EventArgs)
        Funcionarios.Show()
    End Sub

    Private Sub menuSair_Click(sender As Object, e As EventArgs) Handles menuSair.Click

        If (MsgBox("Deseja realmente encerrar o sistema?", vbQuestion + vbYesNo, "Confirme") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub botCadastro_Click(sender As Object, e As EventArgs) Handles botCadastro.Click
        Clientes.Show()
    End Sub

    Private Sub botServicos_Click(sender As Object, e As EventArgs) Handles botServicos.Click
        formConsultaUsuarios.Show()
    End Sub

    Private Sub botFuncionario_Click(sender As Object, e As EventArgs) Handles botFuncionario.Click
        Funcionarios.Show()
    End Sub

    Private Sub botOS_Click(sender As Object, e As EventArgs) Handles botOS.Click
        Form6.Show()
    End Sub

    Private Sub OrdemDeServiçoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdemDeServiçoToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub menuSobre_Click(sender As Object, e As EventArgs) Handles menuSobre.Click
        MsgBox("Em Construção", vbInformation, "Aviso")
    End Sub

    Private Sub telaPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Login.Show()
    End Sub

    Private Sub telaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoasVindas.Text = "Olá " & Login.strUsuario
        If Login.varUsuarioAdm = False Then
            menuAdministrador.Visible = False
        Else
            menuAdministrador.Visible = True
        End If
    End Sub

    Private Sub botLogoff_Click(sender As Object, e As EventArgs) Handles botLogoff.Click
        ActiveForm.Close()
        Login.Show()
        Limpar(Me)

    End Sub

    Private Sub CadastroToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles menuCadastroUsuario.Click
        Usuario.Show()
    End Sub

    Private Sub ServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiçosToolStripMenuItem.Click
        formConsultaUsuarios.Show()
    End Sub

    Private Sub menuAlteracaoUsuario_Click(sender As Object, e As EventArgs) Handles menuAlteracaoUsuario.Click
        ConsultaUsuarios.Show()
    End Sub

    Private Sub botConsultaContasReceber_Click(sender As Object, e As EventArgs) Handles botConsultaContasReceber.Click
        ContasReceber.Show()
    End Sub

    Private Sub botConsultaNotasFiscais_Click(sender As Object, e As EventArgs) Handles botConsultaNotasFiscais.Click
        NotasFiscais.Show()
    End Sub

    Private Sub botDadosEmitente_Click(sender As Object, e As EventArgs) Handles botDadosEmitente.Click
        DadosEmitente.Show()
    End Sub

    Private Sub botConfirmaNotasFiscais_Click(sender As Object, e As EventArgs) Handles botConfirmaNotasFiscais.Click
        confirmaNotaFiscal.Show()
    End Sub
End Class