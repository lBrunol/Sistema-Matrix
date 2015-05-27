Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMenuPrincipal
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

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abreFormularios(frmGerenciamentoClientes)
    End Sub

    Private Sub menuCadastroFornecedor_Click(sender As Object, e As EventArgs)
        abreFormularios(frmGerenciamentoFuncionarios)
    End Sub

    Private Sub menuCadastroFuncionario_Click(sender As Object, e As EventArgs)
        abreFormularios(frmGerenciamentoFuncionarios)
    End Sub
    Private Sub botCadastro_Click(sender As Object, e As EventArgs) Handles botCadastro.Click
        abreFormularios(frmGerenciamentoClientes)
    End Sub

    Private Sub botServicos_Click(sender As Object, e As EventArgs) Handles botServicos.Click
        abreFormularios(frmGerenciamentoServicos)
    End Sub

    Private Sub botFuncionario_Click(sender As Object, e As EventArgs) Handles botFuncionario.Click
        abreFormularios(frmGerenciamentoFuncionarios)
    End Sub

    Private Sub botOS_Click(sender As Object, e As EventArgs) Handles botOS.Click
        abreFormularios(frmGerenciamentoOrdensServico)
    End Sub

    Private Sub OrdemDeServiçoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abreFormularios(frmGerenciamentoOrdensServico)
    End Sub

    Private Sub menuSobre_Click(sender As Object, e As EventArgs)
        MsgBox("Em Construção", vbInformation, "Aviso")
    End Sub
    Private Sub telaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Atribui o nome do usuário logado na label e verifica se o usuário que logou é administrador
        txtBoasVindas.Text = "Olá " & frmLogin.strUsuario
        If frmLogin.varUsuarioAdm = True Then
            menUsuarios.Visible = True
        Else
            menUsuarios.Visible = False
        End If
    End Sub

    Private Sub botLogoff_Click(sender As Object, e As EventArgs) Handles botLogoff.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        abreFormularios(frmCadastroUsuarios)
    End Sub

    Private Sub ServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        abreFormularios(frmGerenciamentoServicos)
    End Sub

    Private Sub menuAlteracaoUsuario_Click(sender As Object, e As EventArgs)
        abreFormularios(frmGerenciamentoUsuarios)
    End Sub

    Private Sub botConsultaContasReceber_Click(sender As Object, e As EventArgs) Handles botConsultaContasReceber.Click
        abreFormularios(frmConsultaContasReceber)
    End Sub

    Private Sub botConsultaNotasFiscais_Click(sender As Object, e As EventArgs) Handles botConsultaNotasFiscais.Click
        abreFormularios(frmConsultaNotasFiscais)
    End Sub

    Private Sub botDadosEmitente_Click(sender As Object, e As EventArgs) Handles botDadosEmitente.Click
        abreFormularios(frmCadastroEmitente)
    End Sub

    Private Sub botConfirmaNotasFiscais_Click(sender As Object, e As EventArgs)
        abreFormularios(frmConfirmaNotaFiscal)
    End Sub

    Private Sub botRelatorio_Click(sender As Object, e As EventArgs) Handles botRelatorio.Click
        abreFormularios(relOrdensServico)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abreFormularios(relContasReceber)
    End Sub
    Private Sub AlteraçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlteraçãoToolStripMenuItem.Click
        abreFormularios(frmGerenciamentoUsuarios)
    End Sub

    Private Sub CriaçãoDeUsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriaçãoDeUsuáriosToolStripMenuItem.Click
        abreFormularios(frmCadastroUsuarios)
    End Sub

    Private Sub frmMenuPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub frmMenuPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'Atribui o nome do usuário logado na label e verifica se o usuário que logou é administrador
        txtBoasVindas.Text = "Olá " & frmLogin.strUsuario
        If frmLogin.varUsuarioAdm = True Then
            menUsuarios.Visible = True
        Else
            menUsuarios.Visible = False
        End If
    End Sub
    Private Sub botBackupeRestauracao_Click(sender As Object, e As EventArgs) Handles botBackupeRestauracao.Click
        abreFormularios(frmBackupeRestauracao)
    End Sub
End Class