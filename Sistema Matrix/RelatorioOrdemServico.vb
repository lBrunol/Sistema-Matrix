Imports System.Data.OracleClient

Public Class RelatorioOrdemServico

    Private Sub Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'oracle.Q_ORDEM' table. You can move, or remove it, as needed.
        Me.Q_ORDEMTableAdapter.Fill(Me.oracle.Q_ORDEM)
        Me.relOrdemServico.RefreshReport()
    End Sub

    Private Sub Relatorio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Funcoes.HabilitaBotaoLogOff()
    End Sub
End Class