Imports System.IO
Public Class frmBackupRestauracao

    Private Sub btnBancodeDados_Click(sender As Object, e As EventArgs) Handles btnBancodeDados.Click
        Try
            Dim dlg As New OpenFileDialog

            dlg.Filter = "Microsoft Access Database(2007-2009) (*.accdb)|*.accdb"
            ' para definir a extensão *.mdb como padrão use FilterIndex = 1 , para extensão *.accdb use FilterIndex=2
            dlg.InitialDirectory = My.Settings.PastaOrigem
            dlg.FilterIndex = 1

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtBancoDeDados.Text = dlg.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDestino_Click(sender As Object, e As EventArgs) Handles btnDestino.Click
        Try
            Dim pasta As New FolderBrowserDialog
            If pasta.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtDestino.Text = pasta.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            If txtBancoDeDados.Text = "" Then
                MessageBox.Show("Selecione o banco de dados de Origem.")
                btnBancodeDados.Focus()
                Exit Sub
            End If
            If txtDestino.Text = "" Then
                MessageBox.Show("Selecione o banco de dados de destino.")
                btnDestino.Focus()
                Exit Sub
            End If
            If txtNomeBackup.Text = "" Then
                MessageBox.Show("Informe o nome do arquivo de Backup.")
                txtNomeBackup.Focus()
                Exit Sub
            End If

            Dim ext As String
            ext = txtBancoDeDados.Text.Substring(txtBancoDeDados.Text.IndexOf(".") + 1)

            File.Copy(txtBancoDeDados.Text, txtDestino.Text & "\" & txtNomeBackup.Text & "." & ext)

            MessageBox.Show("Backup realizado com sucesso.", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnArquivoBackupRestaurar_Click(sender As Object, e As EventArgs) Handles btnArquivoBackupRestaurar.Click
        Try
            Dim dlg As New OpenFileDialog
            dlg.Filter = "Microsoft Access Database(2007-2009) (*.accdb)|*.accdb"
            ' para definir a extensão *.mdb como padrão use FilterIndex = 1 , para extensão *.accdb use FilterIndex=2
            Dim reader As New System.Configuration.AppSettingsReader
            ' dlg.InitialDirectory = reader.GetValue("PastaDestino", GetType(String))
            dlg.InitialDirectory = My.Settings.PastaDestino
            dlg.FilterIndex = 1

            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtArquivoBackupRestaurar.Text = dlg.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDestinoRestaurar_Click(sender As Object, e As EventArgs) Handles btnDestinoRestaurar.Click
        Try
            Dim pasta As New FolderBrowserDialog
            If pasta.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtDestinoRestaurar.Text = pasta.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Try
            Dim resultado As DialogResult = MessageBox.Show("Deseja Restaurar este Banco de dados ?", "Tem Certeza ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim nomeArquivo As String
            nomeArquivo = txtArquivoBackupRestaurar.Text.Substring(InStrRev(txtArquivoBackupRestaurar.Text, "\"))
            If resultado = Windows.Forms.DialogResult.Yes Then
                If File.Exists(txtDestinoRestaurar.Text & "\" & nomeArquivo) Then
                    Dim resultadoReplace As DialogResult = MessageBox.Show("Este arquivo já existe na pasta de destino. Deseja substituir este Banco de Dados ?", " Tem Certeza ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If resultadoReplace = Windows.Forms.DialogResult.Yes Then
                        File.Delete(txtDestinoRestaurar.Text & "\" & nomeArquivo)
                        File.Copy(txtArquivoBackupRestaurar.Text, txtDestinoRestaurar.Text & "\" & nomeArquivo)
                        MessageBox.Show("Restauração realizada com sucesso.", "RESTAURAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    File.Copy(txtArquivoBackupRestaurar.Text, txtDestinoRestaurar.Text & "\" & nomeArquivo)
                    MessageBox.Show("Restauração realizada com sucesso.", "RESTAURAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
