Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class telaPrincipal
    Private Sub abreFormularios(nomeForm As Form)
        'Esse procedimento recebe o resultado da função que verifica quantos forms estão abertos e realiza o tratamento
        Dim numFormsAbertos As Integer
        numFormsAbertos = quantFormsAbertos()
        If numFormsAbertos > 3 Then
            MsgBox("Você excedeu o limite de telas abertas", vbExclamation, "Atenção")
        Else
            Me.botLogoff.Enabled = False
            nomeForm.Show()
        End If
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        abreFormularios(Clientes)
    End Sub

    Private Sub menuCadastroFornecedor_Click(sender As Object, e As EventArgs) Handles menuCadastroFornecedor.Click
        abreFormularios(Funcionarios)
    End Sub

    Private Sub menuCadastroFuncionario_Click(sender As Object, e As EventArgs)
        abreFormularios(Funcionarios)
    End Sub

    Private Sub menuSair_Click(sender As Object, e As EventArgs) Handles menuSair.Click

        If (MsgBox("Deseja realmente encerrar o sistema?", vbQuestion + vbYesNo, "Confirme") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub botCadastro_Click(sender As Object, e As EventArgs) Handles botCadastro.Click
        abreFormularios(Clientes)
    End Sub

    Private Sub botServicos_Click(sender As Object, e As EventArgs) Handles botServicos.Click
        abreFormularios(formConsultaUsuarios)
    End Sub

    Private Sub botFuncionario_Click(sender As Object, e As EventArgs) Handles botFuncionario.Click
        abreFormularios(Funcionarios)
    End Sub

    Private Sub botOS_Click(sender As Object, e As EventArgs) Handles botOS.Click
        abreFormularios(Form6)
    End Sub

    Private Sub OrdemDeServiçoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdemDeServiçoToolStripMenuItem.Click
        abreFormularios(Form6)
    End Sub

    Private Sub menuSobre_Click(sender As Object, e As EventArgs) Handles menuSobre.Click
        MsgBox("Em Construção", vbInformation, "Aviso")
    End Sub

    Private Sub telaPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Login.Show()
    End Sub

    Private Sub telaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Atribui o nome do usuário logado na label e verifica se o usuário que logou é administrador
        txtBoasVindas.Text = "Olá " & Login.strUsuario
        If Login.varUsuarioAdm = "true" Then
            menuAdministrador.Visible = False
        Else
            menuAdministrador.Visible = True
        End If
    End Sub

    Private Sub botLogoff_Click(sender As Object, e As EventArgs) Handles botLogoff.Click
        ActiveForm.Close()
        Login.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles menuCadastroUsuario.Click
        abreFormularios(Usuario)
    End Sub

    Private Sub ServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiçosToolStripMenuItem.Click
        abreFormularios(formConsultaUsuarios)
    End Sub

    Private Sub menuAlteracaoUsuario_Click(sender As Object, e As EventArgs) Handles menuAlteracaoUsuario.Click
        abreFormularios(ConsultaUsuarios)
    End Sub

    Private Sub botConsultaContasReceber_Click(sender As Object, e As EventArgs) Handles botConsultaContasReceber.Click
        abreFormularios(ContasReceber)
    End Sub

    Private Sub botConsultaNotasFiscais_Click(sender As Object, e As EventArgs) Handles botConsultaNotasFiscais.Click
        abreFormularios(NotasFiscais)
    End Sub

    Private Sub botDadosEmitente_Click(sender As Object, e As EventArgs) Handles botDadosEmitente.Click
        abreFormularios(DadosEmitente)
    End Sub

    Private Sub botConfirmaNotasFiscais_Click(sender As Object, e As EventArgs) Handles botConfirmaNotasFiscais.Click
        abreFormularios(confirmaNotaFiscal)
    End Sub

    Private Sub botRelatorio_Click(sender As Object, e As EventArgs) Handles botRelatorio.Click
        abreFormularios(RelatorioOrdemServico)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abreFormularios(relatorioContasReceber)
    End Sub
End Class