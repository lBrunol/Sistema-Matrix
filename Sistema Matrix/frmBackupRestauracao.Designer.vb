<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupRestauracao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackupRestauracao))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDestinoRestaurar = New System.Windows.Forms.Button()
        Me.btnArquivoBackupRestaurar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArquivoBackupRestaurar = New System.Windows.Forms.TextBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.txtDestinoRestaurar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeBackup = New System.Windows.Forms.TextBox()
        Me.btnDestino = New System.Windows.Forms.Button()
        Me.btnBancodeDados = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBancoDeDados = New System.Windows.Forms.TextBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDestinoRestaurar)
        Me.GroupBox2.Controls.Add(Me.btnArquivoBackupRestaurar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtArquivoBackupRestaurar)
        Me.GroupBox2.Controls.Add(Me.btnRestaurar)
        Me.GroupBox2.Controls.Add(Me.txtDestinoRestaurar)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 202)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Restauração"
        '
        'btnDestinoRestaurar
        '
        Me.btnDestinoRestaurar.BackColor = System.Drawing.Color.White
        Me.btnDestinoRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDestinoRestaurar.Image = CType(resources.GetObject("btnDestinoRestaurar.Image"), System.Drawing.Image)
        Me.btnDestinoRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDestinoRestaurar.Location = New System.Drawing.Point(451, 108)
        Me.btnDestinoRestaurar.Name = "btnDestinoRestaurar"
        Me.btnDestinoRestaurar.Size = New System.Drawing.Size(87, 23)
        Me.btnDestinoRestaurar.TabIndex = 6
        Me.btnDestinoRestaurar.Text = "Procurar"
        Me.btnDestinoRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDestinoRestaurar.UseVisualStyleBackColor = False
        '
        'btnArquivoBackupRestaurar
        '
        Me.btnArquivoBackupRestaurar.BackColor = System.Drawing.Color.White
        Me.btnArquivoBackupRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArquivoBackupRestaurar.Image = CType(resources.GetObject("btnArquivoBackupRestaurar.Image"), System.Drawing.Image)
        Me.btnArquivoBackupRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArquivoBackupRestaurar.Location = New System.Drawing.Point(451, 50)
        Me.btnArquivoBackupRestaurar.Name = "btnArquivoBackupRestaurar"
        Me.btnArquivoBackupRestaurar.Size = New System.Drawing.Size(87, 23)
        Me.btnArquivoBackupRestaurar.TabIndex = 5
        Me.btnArquivoBackupRestaurar.Text = "Procurar"
        Me.btnArquivoBackupRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnArquivoBackupRestaurar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Destino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Arquivo Backup"
        '
        'txtArquivoBackupRestaurar
        '
        Me.txtArquivoBackupRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtArquivoBackupRestaurar.Location = New System.Drawing.Point(146, 23)
        Me.txtArquivoBackupRestaurar.Name = "txtArquivoBackupRestaurar"
        Me.txtArquivoBackupRestaurar.ReadOnly = True
        Me.txtArquivoBackupRestaurar.Size = New System.Drawing.Size(392, 23)
        Me.txtArquivoBackupRestaurar.TabIndex = 1
        '
        'btnRestaurar
        '
        Me.btnRestaurar.BackColor = System.Drawing.Color.White
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestaurar.Location = New System.Drawing.Point(205, 129)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(166, 56)
        Me.btnRestaurar.TabIndex = 0
        Me.btnRestaurar.Text = "Iniciar Restauração"
        Me.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRestaurar.UseVisualStyleBackColor = False
        '
        'txtDestinoRestaurar
        '
        Me.txtDestinoRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDestinoRestaurar.Location = New System.Drawing.Point(146, 79)
        Me.txtDestinoRestaurar.Name = "txtDestinoRestaurar"
        Me.txtDestinoRestaurar.ReadOnly = True
        Me.txtDestinoRestaurar.Size = New System.Drawing.Size(392, 23)
        Me.txtDestinoRestaurar.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNomeBackup)
        Me.GroupBox1.Controls.Add(Me.btnDestino)
        Me.GroupBox1.Controls.Add(Me.btnBancodeDados)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBancoDeDados)
        Me.GroupBox1.Controls.Add(Me.btnBackup)
        Me.GroupBox1.Controls.Add(Me.txtDestino)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 207)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backup"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nome do Backup"
        '
        'txtNomeBackup
        '
        Me.txtNomeBackup.Location = New System.Drawing.Point(146, 102)
        Me.txtNomeBackup.Name = "txtNomeBackup"
        Me.txtNomeBackup.Size = New System.Drawing.Size(286, 23)
        Me.txtNomeBackup.TabIndex = 7
        '
        'btnDestino
        '
        Me.btnDestino.BackColor = System.Drawing.Color.White
        Me.btnDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDestino.Image = CType(resources.GetObject("btnDestino.Image"), System.Drawing.Image)
        Me.btnDestino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDestino.Location = New System.Drawing.Point(451, 103)
        Me.btnDestino.Name = "btnDestino"
        Me.btnDestino.Size = New System.Drawing.Size(87, 23)
        Me.btnDestino.TabIndex = 6
        Me.btnDestino.Text = "Procurar"
        Me.btnDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDestino.UseVisualStyleBackColor = False
        '
        'btnBancodeDados
        '
        Me.btnBancodeDados.BackColor = System.Drawing.Color.White
        Me.btnBancodeDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBancodeDados.Image = CType(resources.GetObject("btnBancodeDados.Image"), System.Drawing.Image)
        Me.btnBancodeDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBancodeDados.Location = New System.Drawing.Point(451, 47)
        Me.btnBancodeDados.Name = "btnBancodeDados"
        Me.btnBancodeDados.Size = New System.Drawing.Size(87, 23)
        Me.btnBancodeDados.TabIndex = 5
        Me.btnBancodeDados.Text = "Procurar"
        Me.btnBancodeDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBancodeDados.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Destino"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Banco de Dados"
        '
        'txtBancoDeDados
        '
        Me.txtBancoDeDados.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBancoDeDados.Location = New System.Drawing.Point(146, 19)
        Me.txtBancoDeDados.Name = "txtBancoDeDados"
        Me.txtBancoDeDados.ReadOnly = True
        Me.txtBancoDeDados.Size = New System.Drawing.Size(392, 23)
        Me.txtBancoDeDados.TabIndex = 1
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(222, 142)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(135, 48)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Iniciar Backup"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'txtDestino
        '
        Me.txtDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDestino.Location = New System.Drawing.Point(146, 73)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.ReadOnly = True
        Me.txtDestino.Size = New System.Drawing.Size(392, 23)
        Me.txtDestino.TabIndex = 2
        '
        'frmBackupRestauracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(579, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBackupRestauracao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "6"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDestinoRestaurar As System.Windows.Forms.Button
    Friend WithEvents btnArquivoBackupRestaurar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtArquivoBackupRestaurar As System.Windows.Forms.TextBox
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents txtDestinoRestaurar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNomeBackup As System.Windows.Forms.TextBox
    Friend WithEvents btnDestino As System.Windows.Forms.Button
    Friend WithEvents btnBancodeDados As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBancoDeDados As System.Windows.Forms.TextBox
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox

End Class
