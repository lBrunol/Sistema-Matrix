Public Class DadosEmitente

    Public Function verificaVazio(ByVal nomeFormulario As Control)
        Dim i As Integer
        Dim j(90) As Integer
        Dim ctl As Control
        For Each ctl In nomeFormulario.Controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is RichTextBox Or TypeOf ctl Is ComboBox Then
                If ctl.Text = "" Then
                    j(i) = ctl.TabIndex()
                    j.Reverse()

                End If
                
            End If
        Next
        Return i


    End Function

    Private Sub botCadastrar_Click(sender As Object, e As EventArgs) Handles botCadastrar.Click
        verificaVazio(Me)

    End Sub

    Private Sub DadosEmitente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Funcoes.HabilitaBotaoLogOff()
    End Sub
End Class