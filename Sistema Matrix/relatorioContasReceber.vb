Public Class relatorioContasReceber

    Private Sub relatorioContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'oracle.Q_CONTAS_RECEBER' table. You can move, or remove it, as needed.
        Me.Q_CONTAS_RECEBERTableAdapter.Fill(Me.oracle.Q_CONTAS_RECEBER)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class