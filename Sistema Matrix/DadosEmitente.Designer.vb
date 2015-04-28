<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DadosEmitente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DadosEmitente))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCnpjCpfTomador = New System.Windows.Forms.Label()
        Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCadastrar = New System.Windows.Forms.Label()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.botAlterar = New System.Windows.Forms.Button()
        Me.botCadastrar = New System.Windows.Forms.Button()
        Me.lblLimpar = New System.Windows.Forms.Label()
        Me.lblExcluir = New System.Windows.Forms.Label()
        Me.botExcluir = New System.Windows.Forms.Button()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.mtxCep = New System.Windows.Forms.MaskedTextBox()
        Me.mtxTelefone = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(11, 11)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(198, 23)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Dados do Emitente"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lblCnpjCpfTomador
        '
        Me.lblCnpjCpfTomador.AutoSize = True
        Me.lblCnpjCpfTomador.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblCnpjCpfTomador.Location = New System.Drawing.Point(12, 177)
        Me.lblCnpjCpfTomador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCnpjCpfTomador.Name = "lblCnpjCpfTomador"
        Me.lblCnpjCpfTomador.Size = New System.Drawing.Size(136, 21)
        Me.lblCnpjCpfTomador.TabIndex = 16
        Me.lblCnpjCpfTomador.Text = "Nome Fantasia"
        '
        'txtNomeFantasia
        '
        Me.txtNomeFantasia.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNomeFantasia.Location = New System.Drawing.Point(16, 202)
        Me.txtNomeFantasia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNomeFantasia.Multiline = True
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        Me.txtNomeFantasia.Size = New System.Drawing.Size(421, 27)
        Me.txtNomeFantasia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 240)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Razão Social"
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRazaoSocial.Location = New System.Drawing.Point(16, 265)
        Me.txtRazaoSocial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRazaoSocial.Multiline = True
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(421, 27)
        Me.txtRazaoSocial.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(12, 306)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Inscrição Municipal"
        '
        'txtIM
        '
        Me.txtIM.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIM.Location = New System.Drawing.Point(16, 331)
        Me.txtIM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIM.Multiline = True
        Me.txtIM.Name = "txtIM"
        Me.txtIM.Size = New System.Drawing.Size(207, 27)
        Me.txtIM.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(244, 306)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Inscrição Estadual"
        '
        'txtIE
        '
        Me.txtIE.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIE.Location = New System.Drawing.Point(248, 331)
        Me.txtIE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIE.Multiline = True
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Size = New System.Drawing.Size(189, 27)
        Me.txtIE.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(12, 374)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Endereço"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEndereco.Location = New System.Drawing.Point(16, 399)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEndereco.Multiline = True
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(421, 27)
        Me.txtEndereco.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(244, 443)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(12, 443)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "CEP"
        '
        'lblCadastrar
        '
        Me.lblCadastrar.AutoSize = True
        Me.lblCadastrar.Location = New System.Drawing.Point(265, 64)
        Me.lblCadastrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCadastrar.Name = "lblCadastrar"
        Me.lblCadastrar.Size = New System.Drawing.Size(70, 17)
        Me.lblCadastrar.TabIndex = 63
        Me.lblCadastrar.Text = "Cadastrar"
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Location = New System.Drawing.Point(345, 64)
        Me.lblAlterar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(107, 17)
        Me.lblAlterar.TabIndex = 64
        Me.lblAlterar.Text = "Alterar Registro"
        Me.lblAlterar.Visible = False
        '
        'botAlterar
        '
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(371, 11)
        Me.botAlterar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(53, 49)
        Me.botAlterar.TabIndex = 62
        Me.botAlterar.UseVisualStyleBackColor = True
        Me.botAlterar.Visible = False
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botCadastrar.Location = New System.Drawing.Point(272, 11)
        Me.botCadastrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(53, 49)
        Me.botCadastrar.TabIndex = 61
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'lblLimpar
        '
        Me.lblLimpar.AutoSize = True
        Me.lblLimpar.Location = New System.Drawing.Point(351, 64)
        Me.lblLimpar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLimpar.Name = "lblLimpar"
        Me.lblLimpar.Size = New System.Drawing.Size(88, 17)
        Me.lblLimpar.TabIndex = 67
        Me.lblLimpar.Text = "Limpar Tudo"
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Location = New System.Drawing.Point(345, 151)
        Me.lblExcluir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(106, 17)
        Me.lblExcluir.TabIndex = 68
        Me.lblExcluir.Text = "Excluir Registro"
        Me.lblExcluir.Visible = False
        '
        'botExcluir
        '
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(371, 98)
        Me.botExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(53, 49)
        Me.botExcluir.TabIndex = 66
        Me.botExcluir.UseVisualStyleBackColor = True
        Me.botExcluir.Visible = False
        '
        'botLimpar
        '
        Me.botLimpar.Image = Global.Sistema_Matrix.My.Resources.Resources.limpar
        Me.botLimpar.Location = New System.Drawing.Point(371, 11)
        Me.botLimpar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(53, 49)
        Me.botLimpar.TabIndex = 65
        Me.botLimpar.UseVisualStyleBackColor = True
        '
        'mtxCep
        '
        Me.mtxCep.Location = New System.Drawing.Point(16, 468)
        Me.mtxCep.Name = "mtxCep"
        Me.mtxCep.Size = New System.Drawing.Size(189, 22)
        Me.mtxCep.TabIndex = 69
        '
        'mtxTelefone
        '
        Me.mtxTelefone.Location = New System.Drawing.Point(248, 468)
        Me.mtxTelefone.Name = "mtxTelefone"
        Me.mtxTelefone.Size = New System.Drawing.Size(189, 22)
        Me.mtxTelefone.TabIndex = 70
        '
        'DadosEmitente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(452, 517)
        Me.Controls.Add(Me.mtxTelefone)
        Me.Controls.Add(Me.mtxCep)
        Me.Controls.Add(Me.lblLimpar)
        Me.Controls.Add(Me.lblExcluir)
        Me.Controls.Add(Me.botExcluir)
        Me.Controls.Add(Me.botLimpar)
        Me.Controls.Add(Me.lblCadastrar)
        Me.Controls.Add(Me.lblAlterar)
        Me.Controls.Add(Me.botAlterar)
        Me.Controls.Add(Me.botCadastrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRazaoSocial)
        Me.Controls.Add(Me.lblCnpjCpfTomador)
        Me.Controls.Add(Me.txtNomeFantasia)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DadosEmitente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados do Emitente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblCnpjCpfTomador As System.Windows.Forms.Label
    Friend WithEvents txtNomeFantasia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIM As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCadastrar As System.Windows.Forms.Label
    Friend WithEvents lblAlterar As System.Windows.Forms.Label
    Friend WithEvents botAlterar As System.Windows.Forms.Button
    Friend WithEvents botCadastrar As System.Windows.Forms.Button
    Friend WithEvents lblLimpar As System.Windows.Forms.Label
    Friend WithEvents lblExcluir As System.Windows.Forms.Label
    Friend WithEvents botExcluir As System.Windows.Forms.Button
    Friend WithEvents botLimpar As System.Windows.Forms.Button
    Friend WithEvents mtxCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxTelefone As System.Windows.Forms.MaskedTextBox
End Class
