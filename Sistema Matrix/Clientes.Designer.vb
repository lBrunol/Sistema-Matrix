<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabClientes = New System.Windows.Forms.TabControl()
        Me.tabCadastroClientes = New System.Windows.Forms.TabPage()
        Me.lblCodCliente = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtIM = New System.Windows.Forms.TextBox()
        Me.lblIM = New System.Windows.Forms.Label()
        Me.lblCampoObrigatorio = New System.Windows.Forms.Label()
        Me.lblInserir = New System.Windows.Forms.Label()
        Me.mtxCelular = New System.Windows.Forms.MaskedTextBox()
        Me.mtxTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mtxCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblLimpar = New System.Windows.Forms.Label()
        Me.lblCadastrar = New System.Windows.Forms.Label()
        Me.cboUF = New System.Windows.Forms.ComboBox()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblWebSite = New System.Windows.Forms.Label()
        Me.lblObservacao = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.RichTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.botModoNovo = New System.Windows.Forms.Button()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtNumEndereco = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.grpTipoCliente = New System.Windows.Forms.GroupBox()
        Me.rdbJuridica = New System.Windows.Forms.RadioButton()
        Me.rdbFisica = New System.Windows.Forms.RadioButton()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.lblNumEndereco = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.lblExcluir = New System.Windows.Forms.Label()
        Me.mtxIE = New System.Windows.Forms.MaskedTextBox()
        Me.botAlterar = New System.Windows.Forms.Button()
        Me.botExcluir = New System.Windows.Forms.Button()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.botCadastrar = New System.Windows.Forms.Button()
        Me.mtxCPF = New System.Windows.Forms.MaskedTextBox()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.mtxCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.mtxRG = New System.Windows.Forms.MaskedTextBox()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.tabConsultaClientes = New System.Windows.Forms.TabPage()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbConJuridica = New System.Windows.Forms.RadioButton()
        Me.rdbConFisica = New System.Windows.Forms.RadioButton()
        Me.lblConCPF = New System.Windows.Forms.Label()
        Me.lblConNome = New System.Windows.Forms.Label()
        Me.txtConNome = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtConCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgConsultaClientes = New System.Windows.Forms.DataGridView()
        Me.lblConCNPJ = New System.Windows.Forms.Label()
        Me.txtConCpf = New System.Windows.Forms.TextBox()
        Me.txtConCNPJ = New System.Windows.Forms.TextBox()
        Me.tabClientes.SuspendLayout()
        Me.tabCadastroClientes.SuspendLayout()
        Me.grpTipoCliente.SuspendLayout()
        Me.tabConsultaClientes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgConsultaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabClientes
        '
        Me.tabClientes.Controls.Add(Me.tabCadastroClientes)
        Me.tabClientes.Controls.Add(Me.tabConsultaClientes)
        Me.tabClientes.Location = New System.Drawing.Point(12, 12)
        Me.tabClientes.Name = "tabClientes"
        Me.tabClientes.SelectedIndex = 0
        Me.tabClientes.Size = New System.Drawing.Size(705, 554)
        Me.tabClientes.TabIndex = 0
        '
        'tabCadastroClientes
        '
        Me.tabCadastroClientes.AutoScroll = True
        Me.tabCadastroClientes.Controls.Add(Me.lblCodCliente)
        Me.tabCadastroClientes.Controls.Add(Me.txtCodigoCliente)
        Me.tabCadastroClientes.Controls.Add(Me.txtIM)
        Me.tabCadastroClientes.Controls.Add(Me.lblIM)
        Me.tabCadastroClientes.Controls.Add(Me.lblCampoObrigatorio)
        Me.tabCadastroClientes.Controls.Add(Me.lblInserir)
        Me.tabCadastroClientes.Controls.Add(Me.mtxCelular)
        Me.tabCadastroClientes.Controls.Add(Me.mtxTelefone)
        Me.tabCadastroClientes.Controls.Add(Me.mtxCEP)
        Me.tabCadastroClientes.Controls.Add(Me.lblLimpar)
        Me.tabCadastroClientes.Controls.Add(Me.lblCadastrar)
        Me.tabCadastroClientes.Controls.Add(Me.cboUF)
        Me.tabCadastroClientes.Controls.Add(Me.txtRazaoSocial)
        Me.tabCadastroClientes.Controls.Add(Me.lblRazaoSocial)
        Me.tabCadastroClientes.Controls.Add(Me.lblCelular)
        Me.tabCadastroClientes.Controls.Add(Me.txtWebsite)
        Me.tabCadastroClientes.Controls.Add(Me.lblWebSite)
        Me.tabCadastroClientes.Controls.Add(Me.lblObservacao)
        Me.tabCadastroClientes.Controls.Add(Me.txtObservacao)
        Me.tabCadastroClientes.Controls.Add(Me.txtEmail)
        Me.tabCadastroClientes.Controls.Add(Me.lblEmail)
        Me.tabCadastroClientes.Controls.Add(Me.txtNome)
        Me.tabCadastroClientes.Controls.Add(Me.lblNome)
        Me.tabCadastroClientes.Controls.Add(Me.lblTelefone)
        Me.tabCadastroClientes.Controls.Add(Me.txtBairro)
        Me.tabCadastroClientes.Controls.Add(Me.botModoNovo)
        Me.tabCadastroClientes.Controls.Add(Me.lblComplemento)
        Me.tabCadastroClientes.Controls.Add(Me.txtCidade)
        Me.tabCadastroClientes.Controls.Add(Me.txtNumEndereco)
        Me.tabCadastroClientes.Controls.Add(Me.txtComplemento)
        Me.tabCadastroClientes.Controls.Add(Me.txtEndereco)
        Me.tabCadastroClientes.Controls.Add(Me.grpTipoCliente)
        Me.tabCadastroClientes.Controls.Add(Me.lblUF)
        Me.tabCadastroClientes.Controls.Add(Me.lblCidade)
        Me.tabCadastroClientes.Controls.Add(Me.lblCEP)
        Me.tabCadastroClientes.Controls.Add(Me.lblNumEndereco)
        Me.tabCadastroClientes.Controls.Add(Me.lblBairro)
        Me.tabCadastroClientes.Controls.Add(Me.lblEndereco)
        Me.tabCadastroClientes.Controls.Add(Me.lblCNPJ)
        Me.tabCadastroClientes.Controls.Add(Me.lblIE)
        Me.tabCadastroClientes.Controls.Add(Me.lblAlterar)
        Me.tabCadastroClientes.Controls.Add(Me.lblExcluir)
        Me.tabCadastroClientes.Controls.Add(Me.mtxIE)
        Me.tabCadastroClientes.Controls.Add(Me.botAlterar)
        Me.tabCadastroClientes.Controls.Add(Me.botExcluir)
        Me.tabCadastroClientes.Controls.Add(Me.botLimpar)
        Me.tabCadastroClientes.Controls.Add(Me.botCadastrar)
        Me.tabCadastroClientes.Controls.Add(Me.mtxCPF)
        Me.tabCadastroClientes.Controls.Add(Me.lblCPF)
        Me.tabCadastroClientes.Controls.Add(Me.mtxCNPJ)
        Me.tabCadastroClientes.Controls.Add(Me.mtxRG)
        Me.tabCadastroClientes.Controls.Add(Me.lblRG)
        Me.tabCadastroClientes.Location = New System.Drawing.Point(4, 22)
        Me.tabCadastroClientes.Name = "tabCadastroClientes"
        Me.tabCadastroClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastroClientes.Size = New System.Drawing.Size(697, 528)
        Me.tabCadastroClientes.TabIndex = 1
        Me.tabCadastroClientes.Text = "Dados Cadastrais"
        Me.tabCadastroClientes.UseVisualStyleBackColor = True
        '
        'lblCodCliente
        '
        Me.lblCodCliente.AutoSize = True
        Me.lblCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodCliente.Location = New System.Drawing.Point(367, 30)
        Me.lblCodCliente.Name = "lblCodCliente"
        Me.lblCodCliente.Size = New System.Drawing.Size(59, 20)
        Me.lblCodCliente.TabIndex = 64
        Me.lblCodCliente.Text = "Código"
        Me.lblCodCliente.Visible = False
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(368, 56)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoCliente.TabIndex = 63
        Me.txtCodigoCliente.Tag = "Não"
        Me.txtCodigoCliente.Visible = False
        '
        'txtIM
        '
        Me.txtIM.Location = New System.Drawing.Point(515, 156)
        Me.txtIM.Name = "txtIM"
        Me.txtIM.Size = New System.Drawing.Size(149, 20)
        Me.txtIM.TabIndex = 10
        Me.txtIM.Visible = False
        '
        'lblIM
        '
        Me.lblIM.AutoSize = True
        Me.lblIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIM.Location = New System.Drawing.Point(511, 133)
        Me.lblIM.Name = "lblIM"
        Me.lblIM.Size = New System.Drawing.Size(33, 20)
        Me.lblIM.TabIndex = 62
        Me.lblIM.Text = "IM*"
        Me.lblIM.Visible = False
        '
        'lblCampoObrigatorio
        '
        Me.lblCampoObrigatorio.AutoSize = True
        Me.lblCampoObrigatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObrigatorio.ForeColor = System.Drawing.Color.Red
        Me.lblCampoObrigatorio.Location = New System.Drawing.Point(565, 504)
        Me.lblCampoObrigatorio.Name = "lblCampoObrigatorio"
        Me.lblCampoObrigatorio.Size = New System.Drawing.Size(108, 13)
        Me.lblCampoObrigatorio.TabIndex = 61
        Me.lblCampoObrigatorio.Text = "*Campos Obrigatórios"
        '
        'lblInserir
        '
        Me.lblInserir.AutoSize = True
        Me.lblInserir.Location = New System.Drawing.Point(185, 64)
        Me.lblInserir.Name = "lblInserir"
        Me.lblInserir.Size = New System.Drawing.Size(65, 13)
        Me.lblInserir.TabIndex = 59
        Me.lblInserir.Text = "Modo Inserir"
        Me.lblInserir.Visible = False
        '
        'mtxCelular
        '
        Me.mtxCelular.Location = New System.Drawing.Point(8, 317)
        Me.mtxCelular.Name = "mtxCelular"
        Me.mtxCelular.Size = New System.Drawing.Size(181, 20)
        Me.mtxCelular.TabIndex = 18
        '
        'mtxTelefone
        '
        Me.mtxTelefone.Location = New System.Drawing.Point(493, 270)
        Me.mtxTelefone.Name = "mtxTelefone"
        Me.mtxTelefone.RejectInputOnFirstFailure = True
        Me.mtxTelefone.Size = New System.Drawing.Size(170, 20)
        Me.mtxTelefone.SkipLiterals = False
        Me.mtxTelefone.TabIndex = 17
        '
        'mtxCEP
        '
        Me.mtxCEP.Location = New System.Drawing.Point(552, 225)
        Me.mtxCEP.Name = "mtxCEP"
        Me.mtxCEP.Size = New System.Drawing.Size(112, 20)
        Me.mtxCEP.TabIndex = 13
        '
        'lblLimpar
        '
        Me.lblLimpar.AutoSize = True
        Me.lblLimpar.Location = New System.Drawing.Point(95, 64)
        Me.lblLimpar.Name = "lblLimpar"
        Me.lblLimpar.Size = New System.Drawing.Size(66, 13)
        Me.lblLimpar.TabIndex = 46
        Me.lblLimpar.Text = "Limpar Tudo"
        '
        'lblCadastrar
        '
        Me.lblCadastrar.AutoSize = True
        Me.lblCadastrar.Location = New System.Drawing.Point(18, 64)
        Me.lblCadastrar.Name = "lblCadastrar"
        Me.lblCadastrar.Size = New System.Drawing.Size(52, 13)
        Me.lblCadastrar.TabIndex = 45
        Me.lblCadastrar.Text = "Cadastrar"
        '
        'cboUF
        '
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Items.AddRange(New Object() {"SP"})
        Me.cboUF.Location = New System.Drawing.Point(440, 270)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(46, 21)
        Me.cboUF.TabIndex = 16
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Location = New System.Drawing.Point(366, 110)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(297, 20)
        Me.txtRazaoSocial.TabIndex = 2
        Me.txtRazaoSocial.Tag = "Não"
        Me.txtRazaoSocial.Visible = False
        '
        'lblRazaoSocial
        '
        Me.lblRazaoSocial.AutoSize = True
        Me.lblRazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaoSocial.Location = New System.Drawing.Point(364, 87)
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        Me.lblRazaoSocial.Size = New System.Drawing.Size(109, 20)
        Me.lblRazaoSocial.TabIndex = 42
        Me.lblRazaoSocial.Text = "Razão Social*"
        Me.lblRazaoSocial.Visible = False
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(6, 294)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(64, 20)
        Me.lblCelular.TabIndex = 41
        Me.lblCelular.Text = "Celular*"
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(426, 317)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(237, 20)
        Me.txtWebsite.TabIndex = 20
        Me.txtWebsite.Tag = "Não"
        '
        'lblWebSite
        '
        Me.lblWebSite.AutoSize = True
        Me.lblWebSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebSite.Location = New System.Drawing.Point(422, 294)
        Me.lblWebSite.Name = "lblWebSite"
        Me.lblWebSite.Size = New System.Drawing.Size(70, 20)
        Me.lblWebSite.TabIndex = 34
        Me.lblWebSite.Tag = "Não"
        Me.lblWebSite.Text = "WebSite"
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacao.Location = New System.Drawing.Point(8, 340)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(94, 20)
        Me.lblObservacao.TabIndex = 33
        Me.lblObservacao.Text = "Observação"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(10, 363)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(653, 94)
        Me.txtObservacao.TabIndex = 21
        Me.txtObservacao.Tag = "Não"
        Me.txtObservacao.Text = ""
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(202, 317)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(210, 20)
        Me.txtEmail.TabIndex = 19
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(198, 294)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(59, 20)
        Me.lblEmail.TabIndex = 30
        Me.lblEmail.Text = "E-mail*"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(6, 110)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(353, 20)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(4, 87)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(57, 20)
        Me.lblNome.TabIndex = 28
        Me.lblNome.Text = "Nome*"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(489, 248)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(77, 20)
        Me.lblTelefone.TabIndex = 24
        Me.lblTelefone.Text = "Telefone*"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(8, 271)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(181, 20)
        Me.txtBairro.TabIndex = 14
        '
        'botModoNovo
        '
        Me.botModoNovo.Image = Global.Sistema_Matrix.My.Resources.Resources.adicionar
        Me.botModoNovo.Location = New System.Drawing.Point(193, 21)
        Me.botModoNovo.Name = "botModoNovo"
        Me.botModoNovo.Size = New System.Drawing.Size(40, 40)
        Me.botModoNovo.TabIndex = 26
        Me.botModoNovo.UseVisualStyleBackColor = True
        Me.botModoNovo.Visible = False
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(362, 202)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(108, 20)
        Me.lblComplemento.TabIndex = 19
        Me.lblComplemento.Text = "Complemento"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(202, 271)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(233, 20)
        Me.txtCidade.TabIndex = 15
        '
        'txtNumEndereco
        '
        Me.txtNumEndereco.Location = New System.Drawing.Point(310, 225)
        Me.txtNumEndereco.Name = "txtNumEndereco"
        Me.txtNumEndereco.Size = New System.Drawing.Size(49, 20)
        Me.txtNumEndereco.TabIndex = 11
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(366, 225)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(179, 20)
        Me.txtComplemento.TabIndex = 12
        Me.txtComplemento.Tag = "Não"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(8, 225)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(296, 20)
        Me.txtEndereco.TabIndex = 10
        '
        'grpTipoCliente
        '
        Me.grpTipoCliente.Controls.Add(Me.rdbJuridica)
        Me.grpTipoCliente.Controls.Add(Me.rdbFisica)
        Me.grpTipoCliente.Location = New System.Drawing.Point(8, 136)
        Me.grpTipoCliente.Name = "grpTipoCliente"
        Me.grpTipoCliente.Size = New System.Drawing.Size(177, 63)
        Me.grpTipoCliente.TabIndex = 0
        Me.grpTipoCliente.TabStop = False
        Me.grpTipoCliente.Text = "Pessoa"
        '
        'rdbJuridica
        '
        Me.rdbJuridica.AutoSize = True
        Me.rdbJuridica.Location = New System.Drawing.Point(102, 28)
        Me.rdbJuridica.Name = "rdbJuridica"
        Me.rdbJuridica.Size = New System.Drawing.Size(63, 17)
        Me.rdbJuridica.TabIndex = 4
        Me.rdbJuridica.Text = "Jurídica"
        Me.rdbJuridica.UseVisualStyleBackColor = True
        '
        'rdbFisica
        '
        Me.rdbFisica.AutoSize = True
        Me.rdbFisica.Checked = True
        Me.rdbFisica.Location = New System.Drawing.Point(6, 28)
        Me.rdbFisica.Name = "rdbFisica"
        Me.rdbFisica.Size = New System.Drawing.Size(54, 17)
        Me.rdbFisica.TabIndex = 3
        Me.rdbFisica.TabStop = True
        Me.rdbFisica.Text = "Física"
        Me.rdbFisica.UseVisualStyleBackColor = True
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUF.Location = New System.Drawing.Point(437, 248)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(37, 20)
        Me.lblUF.TabIndex = 7
        Me.lblUF.Text = "UF*"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(198, 248)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(65, 20)
        Me.lblCidade.TabIndex = 6
        Me.lblCidade.Text = "Cidade*"
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEP.Location = New System.Drawing.Point(547, 202)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(44, 20)
        Me.lblCEP.TabIndex = 5
        Me.lblCEP.Text = "Cep*"
        '
        'lblNumEndereco
        '
        Me.lblNumEndereco.AutoSize = True
        Me.lblNumEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumEndereco.Location = New System.Drawing.Point(306, 202)
        Me.lblNumEndereco.Name = "lblNumEndereco"
        Me.lblNumEndereco.Size = New System.Drawing.Size(32, 20)
        Me.lblNumEndereco.TabIndex = 4
        Me.lblNumEndereco.Text = "Nº*"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(4, 248)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(57, 20)
        Me.lblBairro.TabIndex = 3
        Me.lblBairro.Text = "Bairro*"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(6, 202)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(84, 20)
        Me.lblEndereco.TabIndex = 2
        Me.lblEndereco.Text = "Endereço*"
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPJ.Location = New System.Drawing.Point(191, 133)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(55, 20)
        Me.lblCNPJ.TabIndex = 38
        Me.lblCNPJ.Text = "CNPJ*"
        Me.lblCNPJ.Visible = False
        '
        'lblIE
        '
        Me.lblIE.AutoSize = True
        Me.lblIE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIE.Location = New System.Drawing.Point(376, 136)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.Size = New System.Drawing.Size(25, 20)
        Me.lblIE.TabIndex = 39
        Me.lblIE.Text = "IE"
        Me.lblIE.Visible = False
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Location = New System.Drawing.Point(7, 64)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(79, 13)
        Me.lblAlterar.TabIndex = 60
        Me.lblAlterar.Text = "Alterar Registro"
        Me.lblAlterar.Visible = False
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Location = New System.Drawing.Point(95, 64)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(80, 13)
        Me.lblExcluir.TabIndex = 58
        Me.lblExcluir.Text = "Excluir Registro"
        Me.lblExcluir.Visible = False
        '
        'mtxIE
        '
        Me.mtxIE.Location = New System.Drawing.Point(371, 156)
        Me.mtxIE.Name = "mtxIE"
        Me.mtxIE.Size = New System.Drawing.Size(129, 20)
        Me.mtxIE.TabIndex = 9
        Me.mtxIE.Tag = "Não"
        Me.mtxIE.Visible = False
        '
        'botAlterar
        '
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(23, 21)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(40, 40)
        Me.botAlterar.TabIndex = 24
        Me.botAlterar.UseVisualStyleBackColor = True
        Me.botAlterar.Visible = False
        '
        'botExcluir
        '
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(107, 21)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(40, 40)
        Me.botExcluir.TabIndex = 25
        Me.botExcluir.UseVisualStyleBackColor = True
        Me.botExcluir.Visible = False
        '
        'botLimpar
        '
        Me.botLimpar.Image = Global.Sistema_Matrix.My.Resources.Resources.limpar
        Me.botLimpar.Location = New System.Drawing.Point(107, 21)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(40, 40)
        Me.botLimpar.TabIndex = 23
        Me.botLimpar.UseVisualStyleBackColor = True
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botCadastrar.Location = New System.Drawing.Point(23, 21)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(40, 40)
        Me.botCadastrar.TabIndex = 22
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'mtxCPF
        '
        Me.mtxCPF.Location = New System.Drawing.Point(195, 156)
        Me.mtxCPF.Name = "mtxCPF"
        Me.mtxCPF.Size = New System.Drawing.Size(143, 20)
        Me.mtxCPF.TabIndex = 5
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(191, 133)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(46, 20)
        Me.lblCPF.TabIndex = 9
        Me.lblCPF.Text = "CPF*"
        '
        'mtxCNPJ
        '
        Me.mtxCNPJ.Location = New System.Drawing.Point(195, 156)
        Me.mtxCNPJ.Name = "mtxCNPJ"
        Me.mtxCNPJ.Size = New System.Drawing.Size(164, 20)
        Me.mtxCNPJ.TabIndex = 6
        Me.mtxCNPJ.Tag = "Não"
        '
        'mtxRG
        '
        Me.mtxRG.Location = New System.Drawing.Point(354, 156)
        Me.mtxRG.Name = "mtxRG"
        Me.mtxRG.Size = New System.Drawing.Size(132, 20)
        Me.mtxRG.TabIndex = 8
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRG.Location = New System.Drawing.Point(361, 133)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(40, 20)
        Me.lblRG.TabIndex = 10
        Me.lblRG.Text = "RG*"
        '
        'tabConsultaClientes
        '
        Me.tabConsultaClientes.AutoScroll = True
        Me.tabConsultaClientes.Controls.Add(Me.lblMensagem)
        Me.tabConsultaClientes.Controls.Add(Me.GroupBox1)
        Me.tabConsultaClientes.Controls.Add(Me.lblConCPF)
        Me.tabConsultaClientes.Controls.Add(Me.lblConNome)
        Me.tabConsultaClientes.Controls.Add(Me.txtConNome)
        Me.tabConsultaClientes.Controls.Add(Me.lblCodigo)
        Me.tabConsultaClientes.Controls.Add(Me.txtConCodigo)
        Me.tabConsultaClientes.Controls.Add(Me.Label1)
        Me.tabConsultaClientes.Controls.Add(Me.dtgConsultaClientes)
        Me.tabConsultaClientes.Controls.Add(Me.lblConCNPJ)
        Me.tabConsultaClientes.Controls.Add(Me.txtConCpf)
        Me.tabConsultaClientes.Controls.Add(Me.txtConCNPJ)
        Me.tabConsultaClientes.Location = New System.Drawing.Point(4, 22)
        Me.tabConsultaClientes.Name = "tabConsultaClientes"
        Me.tabConsultaClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsultaClientes.Size = New System.Drawing.Size(697, 528)
        Me.tabConsultaClientes.TabIndex = 2
        Me.tabConsultaClientes.Text = "Consulta"
        Me.tabConsultaClientes.UseVisualStyleBackColor = True
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Location = New System.Drawing.Point(452, 504)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(225, 13)
        Me.lblMensagem.TabIndex = 11
        Me.lblMensagem.Text = "Dê um duplo clique na linha que deseja alterar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbConJuridica)
        Me.GroupBox1.Controls.Add(Me.rdbConFisica)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(533, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 40)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pessoa"
        '
        'rdbConJuridica
        '
        Me.rdbConJuridica.AutoSize = True
        Me.rdbConJuridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbConJuridica.Location = New System.Drawing.Point(70, 16)
        Me.rdbConJuridica.Name = "rdbConJuridica"
        Me.rdbConJuridica.Size = New System.Drawing.Size(63, 17)
        Me.rdbConJuridica.TabIndex = 1
        Me.rdbConJuridica.Tag = "Não"
        Me.rdbConJuridica.Text = "Jurídica"
        Me.rdbConJuridica.UseVisualStyleBackColor = True
        '
        'rdbConFisica
        '
        Me.rdbConFisica.AutoSize = True
        Me.rdbConFisica.Checked = True
        Me.rdbConFisica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbConFisica.Location = New System.Drawing.Point(6, 16)
        Me.rdbConFisica.Name = "rdbConFisica"
        Me.rdbConFisica.Size = New System.Drawing.Size(54, 17)
        Me.rdbConFisica.TabIndex = 0
        Me.rdbConFisica.TabStop = True
        Me.rdbConFisica.Tag = "Não"
        Me.rdbConFisica.Text = "Física"
        Me.rdbConFisica.UseVisualStyleBackColor = True
        '
        'lblConCPF
        '
        Me.lblConCPF.AutoSize = True
        Me.lblConCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConCPF.Location = New System.Drawing.Point(331, 40)
        Me.lblConCPF.Name = "lblConCPF"
        Me.lblConCPF.Size = New System.Drawing.Size(34, 17)
        Me.lblConCPF.TabIndex = 6
        Me.lblConCPF.Text = "CPF"
        '
        'lblConNome
        '
        Me.lblConNome.AutoSize = True
        Me.lblConNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConNome.Location = New System.Drawing.Point(103, 40)
        Me.lblConNome.Name = "lblConNome"
        Me.lblConNome.Size = New System.Drawing.Size(45, 17)
        Me.lblConNome.TabIndex = 5
        Me.lblConNome.Text = "Nome"
        '
        'txtConNome
        '
        Me.txtConNome.Location = New System.Drawing.Point(106, 61)
        Me.txtConNome.Name = "txtConNome"
        Me.txtConNome.Size = New System.Drawing.Size(220, 20)
        Me.txtConNome.TabIndex = 4
        Me.txtConNome.Tag = "Não"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(45, 41)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Código"
        '
        'txtConCodigo
        '
        Me.txtConCodigo.Location = New System.Drawing.Point(48, 61)
        Me.txtConCodigo.Name = "txtConCodigo"
        Me.txtConCodigo.Size = New System.Drawing.Size(50, 20)
        Me.txtConCodigo.TabIndex = 2
        Me.txtConCodigo.Tag = "Não"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consulta de Clientes"
        '
        'dtgConsultaClientes
        '
        Me.dtgConsultaClientes.AllowUserToAddRows = False
        Me.dtgConsultaClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dtgConsultaClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgConsultaClientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgConsultaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsultaClientes.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgConsultaClientes.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgConsultaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgConsultaClientes.Location = New System.Drawing.Point(7, 91)
        Me.dtgConsultaClientes.MultiSelect = False
        Me.dtgConsultaClientes.Name = "dtgConsultaClientes"
        Me.dtgConsultaClientes.Size = New System.Drawing.Size(663, 405)
        Me.dtgConsultaClientes.TabIndex = 0
        '
        'lblConCNPJ
        '
        Me.lblConCNPJ.AutoSize = True
        Me.lblConCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConCNPJ.Location = New System.Drawing.Point(331, 40)
        Me.lblConCNPJ.Name = "lblConCNPJ"
        Me.lblConCNPJ.Size = New System.Drawing.Size(43, 17)
        Me.lblConCNPJ.TabIndex = 9
        Me.lblConCNPJ.Text = "CNPJ"
        Me.lblConCNPJ.Visible = False
        '
        'txtConCpf
        '
        Me.txtConCpf.Location = New System.Drawing.Point(334, 61)
        Me.txtConCpf.Name = "txtConCpf"
        Me.txtConCpf.Size = New System.Drawing.Size(180, 20)
        Me.txtConCpf.TabIndex = 7
        Me.txtConCpf.Tag = "Não"
        '
        'txtConCNPJ
        '
        Me.txtConCNPJ.Location = New System.Drawing.Point(334, 61)
        Me.txtConCNPJ.Name = "txtConCNPJ"
        Me.txtConCNPJ.Size = New System.Drawing.Size(180, 20)
        Me.txtConCNPJ.TabIndex = 10
        Me.txtConCNPJ.Tag = "Não"
        Me.txtConCNPJ.Visible = False
        '
        'Clientes
        '
        Me.AcceptButton = Me.botCadastrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 578)
        Me.Controls.Add(Me.tabClientes)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(725, 616)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.tabClientes.ResumeLayout(False)
        Me.tabCadastroClientes.ResumeLayout(False)
        Me.tabCadastroClientes.PerformLayout()
        Me.grpTipoCliente.ResumeLayout(False)
        Me.grpTipoCliente.PerformLayout()
        Me.tabConsultaClientes.ResumeLayout(False)
        Me.tabConsultaClientes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgConsultaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabClientes As System.Windows.Forms.TabControl
    Friend WithEvents tabCadastroClientes As System.Windows.Forms.TabPage
    Friend WithEvents botCadastrar As System.Windows.Forms.Button
    Friend WithEvents botLimpar As System.Windows.Forms.Button
    Friend WithEvents botAlterar As System.Windows.Forms.Button
    Friend WithEvents botExcluir As System.Windows.Forms.Button
    Friend WithEvents botModoNovo As System.Windows.Forms.Button
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtNumEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents lblRG As System.Windows.Forms.Label
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents grpTipoCliente As System.Windows.Forms.GroupBox
    Friend WithEvents rdbJuridica As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFisica As System.Windows.Forms.RadioButton
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents lblNumEndereco As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblObservacao As System.Windows.Forms.Label
    Friend WithEvents txtObservacao As System.Windows.Forms.RichTextBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents lblWebSite As System.Windows.Forms.Label
    Friend WithEvents lblIE As System.Windows.Forms.Label
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocial As System.Windows.Forms.TextBox
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents cboUF As System.Windows.Forms.ComboBox
    Friend WithEvents lblLimpar As System.Windows.Forms.Label
    Friend WithEvents lblCadastrar As System.Windows.Forms.Label
    Friend WithEvents mtxCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxIE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tabConsultaClientes As System.Windows.Forms.TabPage
    Friend WithEvents txtConCpf As System.Windows.Forms.TextBox
    Friend WithEvents lblConCPF As System.Windows.Forms.Label
    Friend WithEvents lblConNome As System.Windows.Forms.Label
    Friend WithEvents txtConNome As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtConCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgConsultaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbConJuridica As System.Windows.Forms.RadioButton
    Friend WithEvents rdbConFisica As System.Windows.Forms.RadioButton
    Friend WithEvents txtConCNPJ As System.Windows.Forms.TextBox
    Friend WithEvents lblConCNPJ As System.Windows.Forms.Label
    Friend WithEvents lblAlterar As System.Windows.Forms.Label
    Friend WithEvents lblInserir As System.Windows.Forms.Label
    Friend WithEvents lblExcluir As System.Windows.Forms.Label
    Friend WithEvents lblCampoObrigatorio As System.Windows.Forms.Label
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents lblIM As System.Windows.Forms.Label
    Friend WithEvents txtIM As System.Windows.Forms.TextBox
    Friend WithEvents lblCodCliente As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
End Class
