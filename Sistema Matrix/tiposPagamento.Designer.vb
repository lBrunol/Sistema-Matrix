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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tiposPagamento))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.abaTiposPagamento = New System.Windows.Forms.TabControl()
        Me.tabCadastro = New System.Windows.Forms.TabPage()
        Me.lblInserir = New System.Windows.Forms.Label()
        Me.lblLimpar = New System.Windows.Forms.Label()
        Me.lblCadastrar = New System.Windows.Forms.Label()
        Me.botModoNovo = New System.Windows.Forms.Button()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.lblExcluir = New System.Windows.Forms.Label()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.botAlterar = New System.Windows.Forms.Button()
        Me.botExcluir = New System.Windows.Forms.Button()
        Me.botCadastrar = New System.Windows.Forms.Button()
        Me.tabConsulta = New System.Windows.Forms.TabPage()
        Me.dtgConsultaTiposPagamento = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TiposPagamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BancoDataSet = New Sistema_Matrix.bancoDataSet()
        Me.TiposPagamentoTableAdapter = New Sistema_Matrix.bancoDataSetTableAdapters.tiposPagamentoTableAdapter()
        Me.abaTiposPagamento.SuspendLayout()
        Me.tabCadastro.SuspendLayout()
        Me.tabConsulta.SuspendLayout()
        CType(Me.dtgConsultaTiposPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposPagamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'abaTiposPagamento
        '
        Me.abaTiposPagamento.Controls.Add(Me.tabCadastro)
        Me.abaTiposPagamento.Controls.Add(Me.tabConsulta)
        Me.abaTiposPagamento.Location = New System.Drawing.Point(16, 145)
        Me.abaTiposPagamento.Name = "abaTiposPagamento"
        Me.abaTiposPagamento.SelectedIndex = 0
        Me.abaTiposPagamento.Size = New System.Drawing.Size(340, 228)
        Me.abaTiposPagamento.TabIndex = 15
        '
        'tabCadastro
        '
        Me.tabCadastro.Controls.Add(Me.lblInserir)
        Me.tabCadastro.Controls.Add(Me.lblLimpar)
        Me.tabCadastro.Controls.Add(Me.lblCadastrar)
        Me.tabCadastro.Controls.Add(Me.botModoNovo)
        Me.tabCadastro.Controls.Add(Me.lblAlterar)
        Me.tabCadastro.Controls.Add(Me.lblExcluir)
        Me.tabCadastro.Controls.Add(Me.lblDescricao)
        Me.tabCadastro.Controls.Add(Me.txtDescricao)
        Me.tabCadastro.Controls.Add(Me.lblCodigo)
        Me.tabCadastro.Controls.Add(Me.txtCodigo)
        Me.tabCadastro.Controls.Add(Me.botAlterar)
        Me.tabCadastro.Controls.Add(Me.botExcluir)
        Me.tabCadastro.Controls.Add(Me.botCadastrar)
        Me.tabCadastro.Controls.Add(Me.botLimpar)
        Me.tabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tabCadastro.Name = "tabCadastro"
        Me.tabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastro.Size = New System.Drawing.Size(332, 202)
        Me.tabCadastro.TabIndex = 0
        Me.tabCadastro.Text = "Cadastro"
        Me.tabCadastro.UseVisualStyleBackColor = True
        '
        'lblInserir
        '
        Me.lblInserir.AutoSize = True
        Me.lblInserir.Location = New System.Drawing.Point(91, 49)
        Me.lblInserir.Name = "lblInserir"
        Me.lblInserir.Size = New System.Drawing.Size(65, 13)
        Me.lblInserir.TabIndex = 69
        Me.lblInserir.Text = "Modo Inserir"
        Me.lblInserir.Visible = False
        '
        'lblLimpar
        '
        Me.lblLimpar.AutoSize = True
        Me.lblLimpar.Location = New System.Drawing.Point(248, 46)
        Me.lblLimpar.Name = "lblLimpar"
        Me.lblLimpar.Size = New System.Drawing.Size(66, 13)
        Me.lblLimpar.TabIndex = 67
        Me.lblLimpar.Text = "Limpar Tudo"
        '
        'lblCadastrar
        '
        Me.lblCadastrar.AutoSize = True
        Me.lblCadastrar.Location = New System.Drawing.Point(171, 49)
        Me.lblCadastrar.Name = "lblCadastrar"
        Me.lblCadastrar.Size = New System.Drawing.Size(52, 13)
        Me.lblCadastrar.TabIndex = 66
        Me.lblCadastrar.Text = "Cadastrar"
        '
        'botModoNovo
        '
        Me.botModoNovo.Image = Global.Sistema_Matrix.My.Resources.Resources.adicionar
        Me.botModoNovo.Location = New System.Drawing.Point(99, 6)
        Me.botModoNovo.Name = "botModoNovo"
        Me.botModoNovo.Size = New System.Drawing.Size(40, 40)
        Me.botModoNovo.TabIndex = 65
        Me.botModoNovo.UseVisualStyleBackColor = True
        Me.botModoNovo.Visible = False
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Location = New System.Drawing.Point(160, 49)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(79, 13)
        Me.lblAlterar.TabIndex = 70
        Me.lblAlterar.Text = "Alterar Registro"
        Me.lblAlterar.Visible = False
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Location = New System.Drawing.Point(248, 49)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(80, 13)
        Me.lblExcluir.TabIndex = 68
        Me.lblExcluir.Text = "Excluir Registro"
        Me.lblExcluir.Visible = False
        '
        'botLimpar
        '
        Me.botLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botLimpar.Image = Global.Sistema_Matrix.My.Resources.Resources.limpar
        Me.botLimpar.Location = New System.Drawing.Point(260, 3)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(40, 40)
        Me.botLimpar.TabIndex = 62
        Me.botLimpar.UseVisualStyleBackColor = True
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
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodigo.Location = New System.Drawing.Point(6, 110)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(320, 23)
        Me.txtCodigo.TabIndex = 15
        '
        'botAlterar
        '
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(176, 6)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(40, 40)
        Me.botAlterar.TabIndex = 63
        Me.botAlterar.UseVisualStyleBackColor = True
        Me.botAlterar.Visible = False
        '
        'botExcluir
        '
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(260, 4)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(40, 40)
        Me.botExcluir.TabIndex = 64
        Me.botExcluir.UseVisualStyleBackColor = True
        Me.botExcluir.Visible = False
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botCadastrar.Location = New System.Drawing.Point(176, 6)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(40, 40)
        Me.botCadastrar.TabIndex = 61
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'tabConsulta
        '
        Me.tabConsulta.Controls.Add(Me.dtgConsultaTiposPagamento)
        Me.tabConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsulta.Size = New System.Drawing.Size(332, 202)
        Me.tabConsulta.TabIndex = 1
        Me.tabConsulta.Text = "Consulta"
        Me.tabConsulta.UseVisualStyleBackColor = True
        '
        'dtgConsultaTiposPagamento
        '
        Me.dtgConsultaTiposPagamento.AllowUserToAddRows = False
        Me.dtgConsultaTiposPagamento.BackgroundColor = System.Drawing.Color.Azure
        Me.dtgConsultaTiposPagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgConsultaTiposPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsultaTiposPagamento.Location = New System.Drawing.Point(6, 13)
        Me.dtgConsultaTiposPagamento.Name = "dtgConsultaTiposPagamento"
        Me.dtgConsultaTiposPagamento.Size = New System.Drawing.Size(320, 183)
        Me.dtgConsultaTiposPagamento.TabIndex = 16
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
        'TiposPagamentoBindingSource
        '
        Me.TiposPagamentoBindingSource.DataMember = "tiposPagamento"
        Me.TiposPagamentoBindingSource.DataSource = Me.BancoDataSet
        '
        'BancoDataSet
        '
        Me.BancoDataSet.DataSetName = "bancoDataSet"
        Me.BancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiposPagamentoTableAdapter
        '
        Me.TiposPagamentoTableAdapter.ClearBeforeFill = True
        '
        'tiposPagamento
        '
        Me.AcceptButton = Me.botCadastrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.botLimpar
        Me.ClientSize = New System.Drawing.Size(368, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.abaTiposPagamento)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "tiposPagamento"
        Me.Text = "Tipos de Pagamento"
        Me.abaTiposPagamento.ResumeLayout(False)
        Me.tabCadastro.ResumeLayout(False)
        Me.tabCadastro.PerformLayout()
        Me.tabConsulta.ResumeLayout(False)
        CType(Me.dtgConsultaTiposPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposPagamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents abaTiposPagamento As System.Windows.Forms.TabControl
    Friend WithEvents tabCadastro As System.Windows.Forms.TabPage
    Friend WithEvents tabConsulta As System.Windows.Forms.TabPage
    Friend WithEvents dtgConsultaTiposPagamento As System.Windows.Forms.DataGridView
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
    Friend WithEvents BancoDataSet As Sistema_Matrix.bancoDataSet
    Friend WithEvents TiposPagamentoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposPagamentoTableAdapter As Sistema_Matrix.bancoDataSetTableAdapters.tiposPagamentoTableAdapter
End Class
