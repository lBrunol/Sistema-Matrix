Public Class relOrdensServico

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bancoMatrixDataSet.relOrdens' table. You can move, or remove it, as needed.
        Me.relOrdensTableAdapter.Fill(Me.bancoMatrixDataSet.relOrdens)

        Me.relatorio.RefreshReport()

    End Sub
    Private Sub relOrdensServico_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        modFuncoes.HabilitaBotaoLogOff()
    End Sub
End Class