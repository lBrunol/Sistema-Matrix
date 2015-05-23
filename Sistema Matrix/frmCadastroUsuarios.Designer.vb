<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroUsuarios))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtConfirmaSenha = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblConfirmaSenha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.botCadastrar = New System.Windows.Forms.Button()
        Me.chkAdministrador = New System.Windows.Forms.CheckBox()
        Me.lblCodUsuario = New System.Windows.Forms.Label()
        Me.txtCodigoUsuario = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsuario.Location = New System.Drawing.Point(230, 9)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(230, 39)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 2
        '
        'txtConfirmaSenha
        '
        Me.txtConfirmaSenha.Location = New System.Drawing.Point(230, 69)
        Me.txtConfirmaSenha.Name = "txtConfirmaSenha"
        Me.txtConfirmaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmaSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmaSenha.TabIndex = 3
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(125, 9)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(47, 16)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuário"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.Location = New System.Drawing.Point(125, 39)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(43, 16)
        Me.lblSenha.TabIndex = 4
        Me.lblSenha.Text = "Senha"
        '
        'lblConfirmaSenha
        '
        Me.lblConfirmaSenha.AutoSize = True
        Me.lblConfirmaSenha.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmaSenha.Location = New System.Drawing.Point(125, 72)
        Me.lblConfirmaSenha.Name = "lblConfirmaSenha"
        Me.lblConfirmaSenha.Size = New System.Drawing.Size(105, 16)
        Me.lblConfirmaSenha.TabIndex = 5
        Me.lblConfirmaSenha.Text = "Confirme a Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cadastrar Usuário"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistema_Matrix.My.Resources.Resources.adiciona_usuario
        Me.PictureBox1.InitialImage = Global.Sistema_Matrix.My.Resources.Resources.adiciona_usuario
        Me.PictureBox1.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.Location = New System.Drawing.Point(259, 102)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(40, 40)
        Me.botCadastrar.TabIndex = 5
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'chkAdministrador
        '
        Me.chkAdministrador.AutoSize = True
        Me.chkAdministrador.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdministrador.Location = New System.Drawing.Point(128, 102)
        Me.chkAdministrador.Name = "chkAdministrador"
        Me.chkAdministrador.Size = New System.Drawing.Size(100, 20)
        Me.chkAdministrador.TabIndex = 4
        Me.chkAdministrador.Text = "Administrador"
        Me.chkAdministrador.UseVisualStyleBackColor = True
        '
        'lblCodUsuario
        '
        Me.lblCodUsuario.AutoSize = True
        Me.lblCodUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodUsuario.Location = New System.Drawing.Point(7, 126)
        Me.lblCodUsuario.Name = "lblCodUsuario"
        Me.lblCodUsuario.Size = New System.Drawing.Size(40, 13)
        Me.lblCodUsuario.TabIndex = 66
        Me.lblCodUsuario.Text = "Código"
        Me.lblCodUsuario.Visible = False
        '
        'txtCodigoUsuario
        '
        Me.txtCodigoUsuario.Location = New System.Drawing.Point(9, 142)
        Me.txtCodigoUsuario.Name = "txtCodigoUsuario"
        Me.txtCodigoUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoUsuario.TabIndex = 65
        Me.txtCodigoUsuario.Tag = "Não"
        Me.txtCodigoUsuario.Visible = False
        '
        'frmCadastroUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(339, 169)
        Me.Controls.Add(Me.lblCodUsuario)
        Me.Controls.Add(Me.txtCodigoUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAdministrador)
        Me.Controls.Add(Me.botCadastrar)
        Me.Controls.Add(Me.lblConfirmaSenha)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtConfirmaSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastroUsuarios"
        Me.Text = "Cadastro de Usuários"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmaSenha As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents lblConfirmaSenha As System.Windows.Forms.Label
    Friend WithEvents botCadastrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkAdministrador As System.Windows.Forms.CheckBox
    Friend WithEvents lblCodUsuario As System.Windows.Forms.Label
    Friend WithEvents txtCodigoUsuario As System.Windows.Forms.TextBox
End Class
