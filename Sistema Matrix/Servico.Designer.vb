<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConsultaUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabServico = New System.Windows.Forms.TabControl()
        Me.tabCadastroServicos = New System.Windows.Forms.TabPage()
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
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.lblExcluir = New System.Windows.Forms.Label()
        Me.botAlterar = New System.Windows.Forms.Button()
        Me.botExcluir = New System.Windows.Forms.Button()
        Me.botCadastrar = New System.Windows.Forms.Button()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.tabConsultaServicos = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgConsultaServicos = New System.Windows.Forms.DataGridView()
        Me.tabServico.SuspendLayout()
        Me.tabCadastroServicos.SuspendLayout()
        Me.tabConsultaServicos.SuspendLayout()
        CType(Me.dtgConsultaServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabServico
        '
        Me.tabServico.Controls.Add(Me.tabCadastroServicos)
        Me.tabServico.Controls.Add(Me.tabConsultaServicos)
        Me.tabServico.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tabServico.Location = New System.Drawing.Point(16, 16)
        Me.tabServico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabServico.Name = "tabServico"
        Me.tabServico.SelectedIndex = 0
        Me.tabServico.Size = New System.Drawing.Size(666, 539)
        Me.tabServico.TabIndex = 0
        '
        'tabCadastroServicos
        '
        Me.tabCadastroServicos.AutoScroll = True
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
        Me.tabCadastroServicos.Controls.Add(Me.lblValor)
        Me.tabCadastroServicos.Controls.Add(Me.lblAlterar)
        Me.tabCadastroServicos.Controls.Add(Me.lblExcluir)
        Me.tabCadastroServicos.Controls.Add(Me.botAlterar)
        Me.tabCadastroServicos.Controls.Add(Me.botExcluir)
        Me.tabCadastroServicos.Controls.Add(Me.botCadastrar)
        Me.tabCadastroServicos.Controls.Add(Me.botLimpar)
        Me.tabCadastroServicos.Location = New System.Drawing.Point(4, 26)
        Me.tabCadastroServicos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabCadastroServicos.Name = "tabCadastroServicos"
        Me.tabCadastroServicos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabCadastroServicos.Size = New System.Drawing.Size(658, 509)
        Me.tabCadastroServicos.TabIndex = 1
        Me.tabCadastroServicos.Text = "Dados Cadastrais"
        Me.tabCadastroServicos.UseVisualStyleBackColor = True
        '
        'lblCodServico
        '
        Me.lblCodServico.AutoSize = True
        Me.lblCodServico.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblCodServico.Location = New System.Drawing.Point(417, 27)
        Me.lblCodServico.Name = "lblCodServico"
        Me.lblCodServico.Size = New System.Drawing.Size(58, 17)
        Me.lblCodServico.TabIndex = 66
        Me.lblCodServico.Text = "Código"
        Me.lblCodServico.Visible = False
        '
        'txtCodigoServico
        '
        Me.txtCodigoServico.Location = New System.Drawing.Point(418, 61)
        Me.txtCodigoServico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoServico.Name = "txtCodigoServico"
        Me.txtCodigoServico.Size = New System.Drawing.Size(132, 23)
        Me.txtCodigoServico.TabIndex = 65
        Me.txtCodigoServico.Tag = "Não"
        Me.txtCodigoServico.Visible = False
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(10, 214)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(203, 23)
        Me.txtValor.TabIndex = 2
        '
        'lblCampoObrigatorio
        '
        Me.lblCampoObrigatorio.AutoSize = True
        Me.lblCampoObrigatorio.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblCampoObrigatorio.ForeColor = System.Drawing.Color.Red
        Me.lblCampoObrigatorio.Location = New System.Drawing.Point(9, 428)
        Me.lblCampoObrigatorio.Name = "lblCampoObrigatorio"
        Me.lblCampoObrigatorio.Size = New System.Drawing.Size(154, 17)
        Me.lblCampoObrigatorio.TabIndex = 61
        Me.lblCampoObrigatorio.Text = "*Campos Obrigatórios"
        '
        'lblInserir
        '
        Me.lblInserir.AutoSize = True
        Me.lblInserir.Location = New System.Drawing.Point(247, 84)
        Me.lblInserir.Name = "lblInserir"
        Me.lblInserir.Size = New System.Drawing.Size(85, 17)
        Me.lblInserir.TabIndex = 59
        Me.lblInserir.Text = "Modo Inserir"
        Me.lblInserir.Visible = False
        '
        'lblLimpar
        '
        Me.lblLimpar.AutoSize = True
        Me.lblLimpar.Location = New System.Drawing.Point(127, 84)
        Me.lblLimpar.Name = "lblLimpar"
        Me.lblLimpar.Size = New System.Drawing.Size(87, 17)
        Me.lblLimpar.TabIndex = 46
        Me.lblLimpar.Text = "Limpar Tudo"
        '
        'lblCadastrar
        '
        Me.lblCadastrar.AutoSize = True
        Me.lblCadastrar.Location = New System.Drawing.Point(24, 84)
        Me.lblCadastrar.Name = "lblCadastrar"
        Me.lblCadastrar.Size = New System.Drawing.Size(73, 17)
        Me.lblCadastrar.TabIndex = 45
        Me.lblCadastrar.Text = "Cadastrar"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblDescricao.Location = New System.Drawing.Point(8, 256)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(78, 17)
        Me.lblDescricao.TabIndex = 42
        Me.lblDescricao.Text = "Descrição*"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(10, 286)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(463, 122)
        Me.txtDescricao.TabIndex = 3
        Me.txtDescricao.Tag = ""
        Me.txtDescricao.Text = ""
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(8, 144)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(469, 23)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblNome.Location = New System.Drawing.Point(6, 114)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(54, 17)
        Me.lblNome.TabIndex = 28
        Me.lblNome.Text = "Nome*"
        '
        'botModoNovo
        '
        Me.botModoNovo.Image = Global.Sistema_Matrix.My.Resources.Resources.adicionar
        Me.botModoNovo.Location = New System.Drawing.Point(257, 27)
        Me.botModoNovo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botModoNovo.Name = "botModoNovo"
        Me.botModoNovo.Size = New System.Drawing.Size(54, 52)
        Me.botModoNovo.TabIndex = 8
        Me.botModoNovo.UseVisualStyleBackColor = True
        Me.botModoNovo.Visible = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblValor.Location = New System.Drawing.Point(8, 184)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(48, 17)
        Me.lblValor.TabIndex = 39
        Me.lblValor.Text = "Valor*"
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Location = New System.Drawing.Point(9, 84)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(105, 17)
        Me.lblAlterar.TabIndex = 60
        Me.lblAlterar.Text = "Alterar Registro"
        Me.lblAlterar.Visible = False
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Location = New System.Drawing.Point(127, 84)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(102, 17)
        Me.lblExcluir.TabIndex = 58
        Me.lblExcluir.Text = "Excluir Registro"
        Me.lblExcluir.Visible = False
        '
        'botAlterar
        '
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(31, 27)
        Me.botAlterar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(54, 52)
        Me.botAlterar.TabIndex = 6
        Me.botAlterar.UseVisualStyleBackColor = True
        Me.botAlterar.Visible = False
        '
        'botExcluir
        '
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(143, 27)
        Me.botExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(54, 52)
        Me.botExcluir.TabIndex = 7
        Me.botExcluir.UseVisualStyleBackColor = True
        Me.botExcluir.Visible = False
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botCadastrar.Location = New System.Drawing.Point(31, 27)
        Me.botCadastrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(54, 52)
        Me.botCadastrar.TabIndex = 4
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'botLimpar
        '
        Me.botLimpar.Image = Global.Sistema_Matrix.My.Resources.Resources.limpar
        Me.botLimpar.Location = New System.Drawing.Point(143, 27)
        Me.botLimpar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(54, 52)
        Me.botLimpar.TabIndex = 5
        Me.botLimpar.UseVisualStyleBackColor = True
        '
        'tabConsultaServicos
        '
        Me.tabConsultaServicos.AutoScroll = True
        Me.tabConsultaServicos.Controls.Add(Me.Label1)
        Me.tabConsultaServicos.Controls.Add(Me.dtgConsultaServicos)
        Me.tabConsultaServicos.Location = New System.Drawing.Point(4, 26)
        Me.tabConsultaServicos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabConsultaServicos.Name = "tabConsultaServicos"
        Me.tabConsultaServicos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabConsultaServicos.Size = New System.Drawing.Size(658, 509)
        Me.tabConsultaServicos.TabIndex = 2
        Me.tabConsultaServicos.Text = "Consulta"
        Me.tabConsultaServicos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Consulta de Serviços"
        '
        'dtgConsultaServicos
        '
        Me.dtgConsultaServicos.AllowUserToAddRows = False
        Me.dtgConsultaServicos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dtgConsultaServicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgConsultaServicos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgConsultaServicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgConsultaServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsultaServicos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgConsultaServicos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgConsultaServicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgConsultaServicos.Location = New System.Drawing.Point(8, 51)
        Me.dtgConsultaServicos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtgConsultaServicos.MultiSelect = False
        Me.dtgConsultaServicos.Name = "dtgConsultaServicos"
        Me.dtgConsultaServicos.Size = New System.Drawing.Size(640, 446)
        Me.dtgConsultaServicos.TabIndex = 0
        '
        'formConsultaUsuarios
        '
        Me.AcceptButton = Me.botCadastrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 570)
        Me.Controls.Add(Me.tabServico)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "formConsultaUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviços"
        Me.tabServico.ResumeLayout(False)
        Me.tabCadastroServicos.ResumeLayout(False)
        Me.tabCadastroServicos.PerformLayout()
        Me.tabConsultaServicos.ResumeLayout(False)
        Me.tabConsultaServicos.PerformLayout()
        CType(Me.dtgConsultaServicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents lblValor As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCodServico As System.Windows.Forms.Label
    Friend WithEvents txtCodigoServico As System.Windows.Forms.TextBox
End Class
