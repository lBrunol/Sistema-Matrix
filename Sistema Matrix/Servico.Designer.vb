<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formServicos
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formServicos))
        Me.tabServico = New System.Windows.Forms.TabControl()
        Me.tabCadastroServicos = New System.Windows.Forms.TabPage()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtAliquota = New System.Windows.Forms.TextBox()
        Me.lblAliquota = New System.Windows.Forms.Label()
        Me.lblCodServico = New System.Windows.Forms.Label()
        Me.txtCodigoServico = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblCampoObrigatorio = New System.Windows.Forms.Label()
        Me.lblInserir = New System.Windows.Forms.Label()
        Me.lblLimpar = New System.Windows.Forms.Label()
        Me.lblCadastrar = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.RichTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.botModoNovo = New System.Windows.Forms.Button()
        Me.lblValorHora = New System.Windows.Forms.Label()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.lblExcluir = New System.Windows.Forms.Label()
        Me.botExcluir = New System.Windows.Forms.Button()
        Me.botCadastrar = New System.Windows.Forms.Button()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.botAlterar = New System.Windows.Forms.Button()
        Me.tabConsultaServicos = New System.Windows.Forms.TabPage()
        Me.dtgConsultaServicos = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tabServico.SuspendLayout()
        Me.tabCadastroServicos.SuspendLayout()
        Me.tabConsultaServicos.SuspendLayout()
        CType(Me.dtgConsultaServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabServico
        '
        Me.tabServico.Controls.Add(Me.tabCadastroServicos)
        Me.tabServico.Controls.Add(Me.tabConsultaServicos)
        Me.tabServico.Location = New System.Drawing.Point(12, 141)
        Me.tabServico.Name = "tabServico"
        Me.tabServico.SelectedIndex = 0
        Me.tabServico.Size = New System.Drawing.Size(402, 364)
        Me.tabServico.TabIndex = 0
        '
        'tabCadastroServicos
        '
        Me.tabCadastroServicos.AutoScroll = True
        Me.tabCadastroServicos.Controls.Add(Me.txtCodigo)
        Me.tabCadastroServicos.Controls.Add(Me.lblCodigo)
        Me.tabCadastroServicos.Controls.Add(Me.txtAliquota)
        Me.tabCadastroServicos.Controls.Add(Me.lblAliquota)
        Me.tabCadastroServicos.Controls.Add(Me.lblCodServico)
        Me.tabCadastroServicos.Controls.Add(Me.txtCodigoServico)
        Me.tabCadastroServicos.Controls.Add(Me.txtValor)
        Me.tabCadastroServicos.Controls.Add(Me.lblCampoObrigatorio)
        Me.tabCadastroServicos.Controls.Add(Me.lblInserir)
        Me.tabCadastroServicos.Controls.Add(Me.lblLimpar)
        Me.tabCadastroServicos.Controls.Add(Me.lblCadastrar)
        Me.tabCadastroServicos.Controls.Add(Me.lblDescricao)
        Me.tabCadastroServicos.Controls.Add(Me.txtDescricao)
        Me.tabCadastroServicos.Controls.Add(Me.txtNome)
        Me.tabCadastroServicos.Controls.Add(Me.lblNome)
        Me.tabCadastroServicos.Controls.Add(Me.botModoNovo)
        Me.tabCadastroServicos.Controls.Add(Me.lblValorHora)
        Me.tabCadastroServicos.Controls.Add(Me.lblAlterar)
        Me.tabCadastroServicos.Controls.Add(Me.lblExcluir)
        Me.tabCadastroServicos.Controls.Add(Me.botLimpar)
        Me.tabCadastroServicos.Controls.Add(Me.botAlterar)
        Me.tabCadastroServicos.Controls.Add(Me.botCadastrar)
        Me.tabCadastroServicos.Controls.Add(Me.botExcluir)
        Me.tabCadastroServicos.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tabCadastroServicos.Location = New System.Drawing.Point(4, 22)
        Me.tabCadastroServicos.Name = "tabCadastroServicos"
        Me.tabCadastroServicos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastroServicos.Size = New System.Drawing.Size(394, 338)
        Me.tabCadastroServicos.TabIndex = 1
        Me.tabCadastroServicos.Text = "Dados Cadastrais"
        Me.tabCadastroServicos.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodigo.Location = New System.Drawing.Point(10, 109)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(87, 23)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblCodigo.Location = New System.Drawing.Point(7, 89)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(64, 17)
        Me.lblCodigo.TabIndex = 70
        Me.lblCodigo.Text = "Código*"
        '
        'txtAliquota
        '
        Me.txtAliquota.Location = New System.Drawing.Point(268, 159)
        Me.txtAliquota.Name = "txtAliquota"
        Me.txtAliquota.Size = New System.Drawing.Size(91, 23)
        Me.txtAliquota.TabIndex = 4
        '
        'lblAliquota
        '
        Me.lblAliquota.AutoSize = True
        Me.lblAliquota.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblAliquota.Location = New System.Drawing.Point(266, 140)
        Me.lblAliquota.Name = "lblAliquota"
        Me.lblAliquota.Size = New System.Drawing.Size(69, 17)
        Me.lblAliquota.TabIndex = 68
        Me.lblAliquota.Text = "Aliquota*"
        '
        'lblCodServico
        '
        Me.lblCodServico.AutoSize = True
        Me.lblCodServico.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblCodServico.Location = New System.Drawing.Point(255, 6)
        Me.lblCodServico.Name = "lblCodServico"
        Me.lblCodServico.Size = New System.Drawing.Size(58, 17)
        Me.lblCodServico.TabIndex = 66
        Me.lblCodServico.Text = "Código"
        Me.lblCodServico.Visible = False
        '
        'txtCodigoServico
        '
        Me.txtCodigoServico.Location = New System.Drawing.Point(256, 25)
        Me.txtCodigoServico.Name = "txtCodigoServico"
        Me.txtCodigoServico.Size = New System.Drawing.Size(100, 23)
        Me.txtCodigoServico.TabIndex = 65
        Me.txtCodigoServico.Tag = "Não"
        Me.txtCodigoServico.Visible = False
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtValor.Location = New System.Drawing.Point(8, 159)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(139, 23)
        Me.txtValor.TabIndex = 3
        '
        'lblCampoObrigatorio
        '
        Me.lblCampoObrigatorio.AutoSize = True
        Me.lblCampoObrigatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObrigatorio.ForeColor = System.Drawing.Color.Red
        Me.lblCampoObrigatorio.Location = New System.Drawing.Point(7, 320)
        Me.lblCampoObrigatorio.Name = "lblCampoObrigatorio"
        Me.lblCampoObrigatorio.Size = New System.Drawing.Size(108, 13)
        Me.lblCampoObrigatorio.TabIndex = 61
        Me.lblCampoObrigatorio.Text = "*Campos Obrigatórios"
        '
        'lblInserir
        '
        Me.lblInserir.AutoSize = True
        Me.lblInserir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInserir.Location = New System.Drawing.Point(185, 60)
        Me.lblInserir.Name = "lblInserir"
        Me.lblInserir.Size = New System.Drawing.Size(73, 16)
        Me.lblInserir.TabIndex = 59
        Me.lblInserir.Text = "Modo Inserir"
        Me.lblInserir.Visible = False
        '
        'lblLimpar
        '
        Me.lblLimpar.AutoSize = True
        Me.lblLimpar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimpar.Location = New System.Drawing.Point(95, 60)
        Me.lblLimpar.Name = "lblLimpar"
        Me.lblLimpar.Size = New System.Drawing.Size(74, 16)
        Me.lblLimpar.TabIndex = 46
        Me.lblLimpar.Text = "Limpar Tudo"
        '
        'lblCadastrar
        '
        Me.lblCadastrar.AutoSize = True
        Me.lblCadastrar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadastrar.Location = New System.Drawing.Point(18, 60)
        Me.lblCadastrar.Name = "lblCadastrar"
        Me.lblCadastrar.Size = New System.Drawing.Size(63, 16)
        Me.lblCadastrar.TabIndex = 45
        Me.lblCadastrar.Text = "Cadastrar"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblDescricao.Location = New System.Drawing.Point(6, 195)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(78, 17)
        Me.lblDescricao.TabIndex = 42
        Me.lblDescricao.Text = "Descrição*"
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDescricao.Location = New System.Drawing.Point(8, 214)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(349, 94)
        Me.txtDescricao.TabIndex = 5
        Me.txtDescricao.Tag = ""
        Me.txtDescricao.Text = ""
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNome.Location = New System.Drawing.Point(107, 109)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(250, 23)
        Me.txtNome.TabIndex = 2
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblNome.Location = New System.Drawing.Point(104, 89)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(54, 17)
        Me.lblNome.TabIndex = 28
        Me.lblNome.Text = "Nome*"
        '
        'botModoNovo
        '
        Me.botModoNovo.Image = Global.Sistema_Matrix.My.Resources.Resources.adicionar
        Me.botModoNovo.Location = New System.Drawing.Point(193, 17)
        Me.botModoNovo.Name = "botModoNovo"
        Me.botModoNovo.Size = New System.Drawing.Size(40, 40)
        Me.botModoNovo.TabIndex = 8
        Me.botModoNovo.UseVisualStyleBackColor = True
        Me.botModoNovo.Visible = False
        '
        'lblValorHora
        '
        Me.lblValorHora.AutoSize = True
        Me.lblValorHora.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblValorHora.Location = New System.Drawing.Point(6, 140)
        Me.lblValorHora.Name = "lblValorHora"
        Me.lblValorHora.Size = New System.Drawing.Size(83, 17)
        Me.lblValorHora.TabIndex = 39
        Me.lblValorHora.Text = "Valor Hora*"
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlterar.Location = New System.Drawing.Point(7, 60)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(86, 16)
        Me.lblAlterar.TabIndex = 60
        Me.lblAlterar.Text = "Alterar Registro"
        Me.lblAlterar.Visible = False
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcluir.Location = New System.Drawing.Point(95, 60)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(85, 16)
        Me.lblExcluir.TabIndex = 58
        Me.lblExcluir.Text = "Excluir Registro"
        Me.lblExcluir.Visible = False
        '
        'botExcluir
        '
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(107, 17)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(40, 40)
        Me.botExcluir.TabIndex = 7
        Me.botExcluir.TabStop = False
        Me.botExcluir.UseVisualStyleBackColor = True
        Me.botExcluir.Visible = False
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botCadastrar.Location = New System.Drawing.Point(23, 17)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(40, 40)
        Me.botCadastrar.TabIndex = 6
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'botLimpar
        '
        Me.botLimpar.Image = Global.Sistema_Matrix.My.Resources.Resources.limpar
        Me.botLimpar.Location = New System.Drawing.Point(107, 17)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(40, 40)
        Me.botLimpar.TabIndex = 7
        Me.botLimpar.UseVisualStyleBackColor = True
        '
        'botAlterar
        '
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(23, 17)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(40, 40)
        Me.botAlterar.TabIndex = 7
        Me.botAlterar.UseVisualStyleBackColor = True
        Me.botAlterar.Visible = False
        '
        'tabConsultaServicos
        '
        Me.tabConsultaServicos.AutoScroll = True
        Me.tabConsultaServicos.Controls.Add(Me.dtgConsultaServicos)
        Me.tabConsultaServicos.Location = New System.Drawing.Point(4, 22)
        Me.tabConsultaServicos.Name = "tabConsultaServicos"
        Me.tabConsultaServicos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsultaServicos.Size = New System.Drawing.Size(394, 338)
        Me.tabConsultaServicos.TabIndex = 2
        Me.tabConsultaServicos.Text = "Consulta"
        Me.tabConsultaServicos.UseVisualStyleBackColor = True
        '
        'dtgConsultaServicos
        '
        Me.dtgConsultaServicos.AllowUserToAddRows = False
        Me.dtgConsultaServicos.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dtgConsultaServicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dtgConsultaServicos.BackgroundColor = System.Drawing.Color.Azure
        Me.dtgConsultaServicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgConsultaServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsultaServicos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgConsultaServicos.DefaultCellStyle = DataGridViewCellStyle12
        Me.dtgConsultaServicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgConsultaServicos.Location = New System.Drawing.Point(6, 16)
        Me.dtgConsultaServicos.MultiSelect = False
        Me.dtgConsultaServicos.Name = "dtgConsultaServicos"
        Me.dtgConsultaServicos.Size = New System.Drawing.Size(382, 316)
        Me.dtgConsultaServicos.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.Sistema_Matrix.My.Resources.Resources.nota_fiscal_eletronica
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(8, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(72, 21)
        Me.lblTitulo.TabIndex = 18
        Me.lblTitulo.Text = "Serviços"
        '
        'formServicos
        '
        Me.AcceptButton = Me.botCadastrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(427, 511)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tabServico)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formServicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Serviços"
        Me.tabServico.ResumeLayout(False)
        Me.tabCadastroServicos.ResumeLayout(False)
        Me.tabCadastroServicos.PerformLayout()
        Me.tabConsultaServicos.ResumeLayout(False)
        CType(Me.dtgConsultaServicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabServico As System.Windows.Forms.TabControl
    Friend WithEvents tabCadastroServicos As System.Windows.Forms.TabPage
    Friend WithEvents botCadastrar As System.Windows.Forms.Button
    Friend WithEvents botLimpar As System.Windows.Forms.Button
    Friend WithEvents botAlterar As System.Windows.Forms.Button
    Friend WithEvents botExcluir As System.Windows.Forms.Button
    Friend WithEvents botModoNovo As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.RichTextBox
    Friend WithEvents lblValorHora As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblLimpar As System.Windows.Forms.Label
    Friend WithEvents lblCadastrar As System.Windows.Forms.Label
    Friend WithEvents tabConsultaServicos As System.Windows.Forms.TabPage
    Friend WithEvents dtgConsultaServicos As System.Windows.Forms.DataGridView
    Friend WithEvents lblAlterar As System.Windows.Forms.Label
    Friend WithEvents lblInserir As System.Windows.Forms.Label
    Friend WithEvents lblExcluir As System.Windows.Forms.Label
    Friend WithEvents lblCampoObrigatorio As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lblCodServico As System.Windows.Forms.Label
    Friend WithEvents txtCodigoServico As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtAliquota As System.Windows.Forms.TextBox
    Friend WithEvents lblAliquota As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
End Class
