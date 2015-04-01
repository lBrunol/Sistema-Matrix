Public Class ContasReceber

    Private Sub chkEntreDatas_CheckedChanged(sender As Object, e As EventArgs) Handles chkEntreDatas.CheckedChanged
        If txtDataFinal.Enabled = False Then
            txtDataFinal.Enabled = True
        Else
            txtDataFinal.Enabled = False
        End If
    End Sub

    Private Sub ContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class