Public Class relContasReceber

    Private Sub relContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bancoMatrixDataSet.relContasReceber' table. You can move, or remove it, as needed.
        Me.relContasReceberTableAdapter.Fill(Me.bancoMatrixDataSet.relContasReceber)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class