Imports Sistema_Matrix.bancoDataSet
Public Class relOrdensServico

    Private Sub relOrdensServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bancoDataSet.relOrdensServico' table. You can move, or remove it, as needed.
        Me.relOrdensServicoTableAdapter.Fill(Me.bancoDataSet.relOrdensServico)
        Me.relatorio.RefreshReport()
    End Sub
End Class