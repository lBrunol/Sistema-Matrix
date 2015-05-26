<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupeRestauracao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnDestino = New System.Windows.Forms.Button()
        Me.btnBancoDeDados = New System.Windows.Forms.Button()
        Me.txtNomeBackup = New System.Windows.Forms.TextBox()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnDestinoRestaurar = New System.Windows.Forms.Button()
        Me.btnArquivoBackupRestaurar = New System.Windows.Forms.Button()
        Me.txtDestinoRestaurar = New System.Windows.Forms.TextBox()
        Me.txtArquivoBackupRestaurar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBackup)
        Me.GroupBox1.Controls.Add(Me.btnDestino)
        Me.GroupBox1.Controls.Add(Me.btnBancoDeDados)
        Me.GroupBox1.Controls.Add(Me.txtNomeBackup)
        Me.GroupBox1.Controls.Add(Me.txtDestino)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(743, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backup"
        '
        'btnBackup
        '
        Me.btnBackup.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Location = New System.Drawing.Point(260, 218)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(245, 66)
        Me.btnBackup.TabIndex = 8
        Me.btnBackup.Text = "Iniciar o Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnDestino
        '
        Me.btnDestino.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDestino.Location = New System.Drawing.Point(623, 120)
        Me.btnDestino.Name = "btnDestino"
        Me.btnDestino.Size = New System.Drawing.Size(75, 23)
        Me.btnDestino.TabIndex = 7
        Me.btnDestino.Text = "Procurar"
        Me.btnDestino.UseVisualStyleBackColor = True
        '
        'btnBancoDeDados
        '
        Me.btnBancoDeDados.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBancoDeDados.Location = New System.Drawing.Point(623, 54)
        Me.btnBancoDeDados.Name = "btnBancoDeDados"
        Me.btnBancoDeDados.Size = New System.Drawing.Size(75, 23)
        Me.btnBancoDeDados.TabIndex = 6
        Me.btnBancoDeDados.Text = "Procurar"
        Me.btnBancoDeDados.UseVisualStyleBackColor = True
        '
        'txtNomeBackup
        '
        Me.txtNomeBackup.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeBackup.Location = New System.Drawing.Point(133, 163)
        Me.txtNomeBackup.Name = "txtNomeBackup"
        Me.txtNomeBackup.Size = New System.Drawing.Size(565, 22)
        Me.txtNomeBackup.TabIndex = 5
        '
        'txtDestino
        '
        Me.txtDestino.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestino.Location = New System.Drawing.Point(129, 92)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(569, 22)
        Me.txtDestino.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(129, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(569, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome do Backup"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco de Dados"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRestaurar)
        Me.GroupBox2.Controls.Add(Me.btnDestinoRestaurar)
        Me.GroupBox2.Controls.Add(Me.btnArquivoBackupRestaurar)
        Me.GroupBox2.Controls.Add(Me.txtDestinoRestaurar)
        Me.GroupBox2.Controls.Add(Me.txtArquivoBackupRestaurar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(743, 285)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Restauracao"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurar.Location = New System.Drawing.Point(260, 194)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(245, 66)
        Me.btnRestaurar.TabIndex = 8
        Me.btnRestaurar.Text = "Iniciar a Restauração"
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnDestinoRestaurar
        '
        Me.btnDestinoRestaurar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDestinoRestaurar.Location = New System.Drawing.Point(623, 120)
        Me.btnDestinoRestaurar.Name = "btnDestinoRestaurar"
        Me.btnDestinoRestaurar.Size = New System.Drawing.Size(75, 23)
        Me.btnDestinoRestaurar.TabIndex = 7
        Me.btnDestinoRestaurar.Text = "Procurar"
        Me.btnDestinoRestaurar.UseVisualStyleBackColor = True
        '
        'btnArquivoBackupRestaurar
        '
        Me.btnArquivoBackupRestaurar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArquivoBackupRestaurar.Location = New System.Drawing.Point(623, 54)
        Me.btnArquivoBackupRestaurar.Name = "btnArquivoBackupRestaurar"
        Me.btnArquivoBackupRestaurar.Size = New System.Drawing.Size(75, 23)
        Me.btnArquivoBackupRestaurar.TabIndex = 6
        Me.btnArquivoBackupRestaurar.Text = "Procurar"
        Me.btnArquivoBackupRestaurar.UseVisualStyleBackColor = True
        '
        'txtDestinoRestaurar
        '
        Me.txtDestinoRestaurar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinoRestaurar.Location = New System.Drawing.Point(129, 92)
        Me.txtDestinoRestaurar.Name = "txtDestinoRestaurar"
        Me.txtDestinoRestaurar.Size = New System.Drawing.Size(569, 22)
        Me.txtDestinoRestaurar.TabIndex = 4
        '
        'txtArquivoBackupRestaurar
        '
        Me.txtArquivoBackupRestaurar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArquivoBackupRestaurar.Location = New System.Drawing.Point(129, 26)
        Me.txtArquivoBackupRestaurar.Name = "txtArquivoBackupRestaurar"
        Me.txtArquivoBackupRestaurar.Size = New System.Drawing.Size(569, 22)
        Me.txtArquivoBackupRestaurar.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Destino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Arquivo Backup"
        '
        'frmBackupeRestauracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 625)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBackupeRestauracao"
        Me.Text = "Backup e Restauraçao"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnDestino As System.Windows.Forms.Button
    Friend WithEvents btnBancoDeDados As System.Windows.Forms.Button
    Friend WithEvents txtNomeBackup As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents btnDestinoRestaurar As System.Windows.Forms.Button
    Friend WithEvents btnArquivoBackupRestaurar As System.Windows.Forms.Button
    Friend WithEvents txtDestinoRestaurar As System.Windows.Forms.TextBox
    Friend WithEvents txtArquivoBackupRestaurar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
