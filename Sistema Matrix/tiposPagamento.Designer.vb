<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tiposPagamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tiposPagamento))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCadastro = New System.Windows.Forms.TabPage()
        Me.tabConsulta = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lblInserir = New System.Windows.Forms.Label()
        Me.lblLimpar = New System.Windows.Forms.Label()
        Me.lblCadastrar = New System.Windows.Forms.Label()
        Me.botModoNovo = New System.Windows.Forms.Button()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.lblExcluir = New System.Windows.Forms.Label()
        Me.botAlterar = New System.Windows.Forms.Button()
        Me.botExcluir = New System.Windows.Forms.Button()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.botCadastrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tabCadastro.SuspendLayout()
        Me.tabConsulta.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(171, 21)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "Tipos de Pagamento"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCadastro)
        Me.TabControl1.Controls.Add(Me.tabConsulta)
        Me.TabControl1.Location = New System.Drawing.Point(16, 145)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 228)
        Me.TabControl1.TabIndex = 15
        '
        'tabCadastro
        '
        Me.tabCadastro.Controls.Add(Me.lblInserir)
        Me.tabCadastro.Controls.Add(Me.lblLimpar)
        Me.tabCadastro.Controls.Add(Me.lblCadastrar)
        Me.tabCadastro.Controls.Add(Me.botModoNovo)
        Me.tabCadastro.Controls.Add(Me.lblAlterar)
        Me.tabCadastro.Controls.Add(Me.lblExcluir)
        Me.tabCadastro.Controls.Add(Me.botAlterar)
        Me.tabCadastro.Controls.Add(Me.botExcluir)
        Me.tabCadastro.Controls.Add(Me.botLimpar)
        Me.tabCadastro.Controls.Add(Me.botCadastrar)
        Me.tabCadastro.Controls.Add(Me.lblDescricao)
        Me.tabCadastro.Controls.Add(Me.txtDescricao)
        Me.tabCadastro.Controls.Add(Me.lblCodigo)
        Me.tabCadastro.Controls.Add(Me.txtCodigo)
        Me.tabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tabCadastro.Name = "tabCadastro"
        Me.tabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastro.Size = New System.Drawing.Size(332, 202)
        Me.tabCadastro.TabIndex = 0
        Me.tabCadastro.Text = "Cadastro"
        Me.tabCadastro.UseVisualStyleBackColor = True
        '
        'tabConsulta
        '
        Me.tabConsulta.Controls.Add(Me.DataGridView1)
        Me.tabConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsulta.Size = New System.Drawing.Size(332, 202)
        Me.tabConsulta.TabIndex = 1
        Me.tabConsulta.Text = "Consulta"
        Me.tabConsulta.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Azure
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(320, 245)
        Me.DataGridView1.TabIndex = 16
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblCodigo.Location = New System.Drawing.Point(6, 90)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(58, 17)
        Me.lblCodigo.TabIndex = 16
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodigo.Location = New System.Drawing.Point(6, 110)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(320, 23)
        Me.txtCodigo.TabIndex = 15
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblDescricao.Location = New System.Drawing.Point(6, 141)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(72, 17)
        Me.lblDescricao.TabIndex = 18
        Me.lblDescricao.Text = "Descrição"
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDescricao.Location = New System.Drawing.Point(6, 161)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(320, 23)
        Me.txtDescricao.TabIndex = 17
        '
        'lblInserir
        '
        Me.lblInserir.AutoSize = True
        Me.lblInserir.Location = New System.Drawing.Point(264, 49)
        Me.lblInserir.Name = "lblInserir"
        Me.lblInserir.Size = New System.Drawing.Size(65, 13)
        Me.lblInserir.TabIndex = 69
        Me.lblInserir.Text = "Modo Inserir"
        Me.lblInserir.Visible = False
        '
        'lblLimpar
        '
        Me.lblLimpar.AutoSize = True
        Me.lblLimpar.Location = New System.Drawing.Point(174, 49)
        Me.lblLimpar.Name = "lblLimpar"
        Me.lblLimpar.Size = New System.Drawing.Size(66, 13)
        Me.lblLimpar.TabIndex = 67
        Me.lblLimpar.Text = "Limpar Tudo"
        '
        'lblCadastrar
        '
        Me.lblCadastrar.AutoSize = True
        Me.lblCadastrar.Location = New System.Drawing.Point(97, 49)
        Me.lblCadastrar.Name = "lblCadastrar"
        Me.lblCadastrar.Size = New System.Drawing.Size(52, 13)
        Me.lblCadastrar.TabIndex = 66
        Me.lblCadastrar.Text = "Cadastrar"
        '
        'botModoNovo
        '
        Me.botModoNovo.Image = Global.Sistema_Matrix.My.Resources.Resources.adicionar
        Me.botModoNovo.Location = New System.Drawing.Point(272, 6)
        Me.botModoNovo.Name = "botModoNovo"
        Me.botModoNovo.Size = New System.Drawing.Size(40, 40)
        Me.botModoNovo.TabIndex = 65
        Me.botModoNovo.UseVisualStyleBackColor = True
        Me.botModoNovo.Visible = False
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Location = New System.Drawing.Point(86, 49)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(79, 13)
        Me.lblAlterar.TabIndex = 70
        Me.lblAlterar.Text = "Alterar Registro"
        Me.lblAlterar.Visible = False
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Location = New System.Drawing.Point(174, 49)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(80, 13)
        Me.lblExcluir.TabIndex = 68
        Me.lblExcluir.Text = "Excluir Registro"
        Me.lblExcluir.Visible = False
        '
        'botAlterar
        '
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(102, 6)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(40, 40)
        Me.botAlterar.TabIndex = 63
        Me.botAlterar.UseVisualStyleBackColor = True
        Me.botAlterar.Visible = False
        '
        'botExcluir
        '
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(186, 6)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(40, 40)
        Me.botExcluir.TabIndex = 64
        Me.botExcluir.UseVisualStyleBackColor = True
        Me.botExcluir.Visible = False
        '
        'botLimpar
        '
        Me.botLimpar.Image = Global.Sistema_Matrix.My.Resources.Resources.limpar
        Me.botLimpar.Location = New System.Drawing.Point(186, 6)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(40, 40)
        Me.botLimpar.TabIndex = 62
        Me.botLimpar.UseVisualStyleBackColor = True
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botCadastrar.Location = New System.Drawing.Point(102, 6)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(40, 40)
        Me.botCadastrar.TabIndex = 61
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.Sistema_Matrix.My.Resources.Resources.nota_fiscal_eletronica
        Me.PictureBox1.Location = New System.Drawing.Point(16, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'tiposPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(368, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "tiposPagamento"
        Me.Text = "Tipos de Pagamento"
        Me.TabControl1.ResumeLayout(False)
        Me.tabCadastro.ResumeLayout(False)
        Me.tabCadastro.PerformLayout()
        Me.tabConsulta.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabCadastro As System.Windows.Forms.TabPage
    Friend WithEvents tabConsulta As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblInserir As System.Windows.Forms.Label
    Friend WithEvents lblLimpar As System.Windows.Forms.Label
    Friend WithEvents lblCadastrar As System.Windows.Forms.Label
    Friend WithEvents botModoNovo As System.Windows.Forms.Button
    Friend WithEvents lblAlterar As System.Windows.Forms.Label
    Friend WithEvents lblExcluir As System.Windows.Forms.Label
    Friend WithEvents botAlterar As System.Windows.Forms.Button
    Friend WithEvents botExcluir As System.Windows.Forms.Button
    Friend WithEvents botLimpar As System.Windows.Forms.Button
    Friend WithEvents botCadastrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
