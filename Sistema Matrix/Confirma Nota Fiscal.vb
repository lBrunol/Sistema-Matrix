Public Class confirmaNotaFiscal

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub Nota_Fiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblUFTomador_Click(sender As Object, e As EventArgs) Handles lblUFTomador.Click

    End Sub

    Private Sub confirmaNotaFiscal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Funcoes.HabilitaBotaoLogOff()
    End Sub
End Class