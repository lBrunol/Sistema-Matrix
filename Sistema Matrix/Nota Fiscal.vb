Public Class NotasFiscais
    Private Sub chkEntreDatas_CheckedChanged(sender As Object, e As EventArgs) Handles chkEntreDatas.CheckedChanged
        If txtDataFinal.Enabled = False Then
            txtDataFinal.Enabled = True
        Else
            txtDataFinal.Enabled = False
        End If
    End Sub

    Private Sub NotasFiscais_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Funcoes.HabilitaBotaoLogOff()
    End Sub
End Class