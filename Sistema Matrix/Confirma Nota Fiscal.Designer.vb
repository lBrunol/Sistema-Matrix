<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmaNotaFiscal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(confirmaNotaFiscal))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grpPrestadorServico = New System.Windows.Forms.GroupBox()
        Me.lblUFTomador = New System.Windows.Forms.Label()
        Me.lblEnderecoTomador = New System.Windows.Forms.Label()
        Me.lblRazaoSocialNomeTomador = New System.Windows.Forms.Label()
        Me.lblInscricaoMunicipalTomador = New System.Windows.Forms.Label()
        Me.lblMunicipioTomador = New System.Windows.Forms.Label()
        Me.lblCnpjCpfTomador = New System.Windows.Forms.Label()
        Me.txtCnpjCpfTomador = New System.Windows.Forms.TextBox()
        Me.txtMunicipioTomador = New System.Windows.Forms.TextBox()
        Me.txtUFTomador = New System.Windows.Forms.TextBox()
        Me.txtEnderecoTomador = New System.Windows.Forms.TextBox()
        Me.txtRazaoSocialNomeTomador = New System.Windows.Forms.TextBox()
        Me.txtInscricaoMunicipalTomador = New System.Windows.Forms.TextBox()
        Me.grpTomadorServico = New System.Windows.Forms.GroupBox()
        Me.lblUFPrestador = New System.Windows.Forms.Label()
        Me.txtUFPrestador = New System.Windows.Forms.TextBox()
        Me.lblEmailPrestador = New System.Windows.Forms.Label()
        Me.lblEnderecoPrestador = New System.Windows.Forms.Label()
        Me.lblRazaoSocialNomePrestador = New System.Windows.Forms.Label()
        Me.lblInscricaoMunicipalPrestador = New System.Windows.Forms.Label()
        Me.lblMunicipioPrestador = New System.Windows.Forms.Label()
        Me.lblCpfCnpjPrestador = New System.Windows.Forms.Label()
        Me.txtCnpjCpfPrestador = New System.Windows.Forms.TextBox()
        Me.txtMunicipioPrestador = New System.Windows.Forms.TextBox()
        Me.txtEmailPrestador = New System.Windows.Forms.TextBox()
        Me.txtEnderecoPrestador = New System.Windows.Forms.TextBox()
        Me.txtRazaoSocialNomePrestador = New System.Windows.Forms.TextBox()
        Me.txtInscricaoMunicipalPrestador = New System.Windows.Forms.TextBox()
        Me.grpServicos = New System.Windows.Forms.GroupBox()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.lblCódigo = New System.Windows.Forms.Label()
        Me.lstServicos = New System.Windows.Forms.ListBox()
        Me.grpValores = New System.Windows.Forms.GroupBox()
        Me.lblOutrasInformacoes = New System.Windows.Forms.Label()
        Me.txtOutrasInformacoes = New System.Windows.Forms.RichTextBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.lblCodigoServico = New System.Windows.Forms.Label()
        Me.txtCodigoServico = New System.Windows.Forms.TextBox()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.lblCancelar = New System.Windows.Forms.Label()
        Me.lblFaturarNotaFiscal = New System.Windows.Forms.Label()
        Me.botFaturarNotaFiscal = New System.Windows.Forms.Button()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblParcelas = New System.Windows.Forms.Label()
        Me.cdbParcelas = New System.Windows.Forms.ComboBox()
        Me.lblNomeTitular = New System.Windows.Forms.Label()
        Me.txtNomeTitular = New System.Windows.Forms.TextBox()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.lblNumCartao = New System.Windows.Forms.Label()
        Me.txtNumCartao = New System.Windows.Forms.TextBox()
        Me.lblBandeira = New System.Windows.Forms.Label()
        Me.lblSelecioneDias = New System.Windows.Forms.Label()
        Me.rdbCartaoCredito = New System.Windows.Forms.RadioButton()
        Me.rdbBoleto = New System.Windows.Forms.RadioButton()
        Me.rdbAvista = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdbBoleto = New System.Windows.Forms.ComboBox()
        Me.cdbCartao = New System.Windows.Forms.ComboBox()
        Me.grpPrestadorServico.SuspendLayout()
        Me.grpTomadorServico.SuspendLayout()
        Me.grpServicos.SuspendLayout()
        Me.grpValores.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(255, 21)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Confirmar dados da Nota Fiscal"
        '
        'grpPrestadorServico
        '
        Me.grpPrestadorServico.Controls.Add(Me.lblUFTomador)
        Me.grpPrestadorServico.Controls.Add(Me.lblEnderecoTomador)
        Me.grpPrestadorServico.Controls.Add(Me.lblRazaoSocialNomeTomador)
        Me.grpPrestadorServico.Controls.Add(Me.lblInscricaoMunicipalTomador)
        Me.grpPrestadorServico.Controls.Add(Me.lblMunicipioTomador)
        Me.grpPrestadorServico.Controls.Add(Me.lblCnpjCpfTomador)
        Me.grpPrestadorServico.Controls.Add(Me.txtCnpjCpfTomador)
        Me.grpPrestadorServico.Controls.Add(Me.txtMunicipioTomador)
        Me.grpPrestadorServico.Controls.Add(Me.txtUFTomador)
        Me.grpPrestadorServico.Controls.Add(Me.txtEnderecoTomador)
        Me.grpPrestadorServico.Controls.Add(Me.txtRazaoSocialNomeTomador)
        Me.grpPrestadorServico.Controls.Add(Me.txtInscricaoMunicipalTomador)
        Me.grpPrestadorServico.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrestadorServico.Location = New System.Drawing.Point(128, 57)
        Me.grpPrestadorServico.Name = "grpPrestadorServico"
        Me.grpPrestadorServico.Size = New System.Drawing.Size(524, 178)
        Me.grpPrestadorServico.TabIndex = 10
        Me.grpPrestadorServico.TabStop = False
        Me.grpPrestadorServico.Text = "Prestador de Serviço"
        '
        'lblUFTomador
        '
        Me.lblUFTomador.AutoSize = True
        Me.lblUFTomador.Location = New System.Drawing.Point(460, 123)
        Me.lblUFTomador.Name = "lblUFTomador"
        Me.lblUFTomador.Size = New System.Drawing.Size(22, 17)
        Me.lblUFTomador.TabIndex = 13
        Me.lblUFTomador.Text = "UF"
        '
        'lblEnderecoTomador
        '
        Me.lblEnderecoTomador.AutoSize = True
        Me.lblEnderecoTomador.Location = New System.Drawing.Point(200, 73)
        Me.lblEnderecoTomador.Name = "lblEnderecoTomador"
        Me.lblEnderecoTomador.Size = New System.Drawing.Size(69, 17)
        Me.lblEnderecoTomador.TabIndex = 12
        Me.lblEnderecoTomador.Text = "Endereço"
        '
        'lblRazaoSocialNomeTomador
        '
        Me.lblRazaoSocialNomeTomador.AutoSize = True
        Me.lblRazaoSocialNomeTomador.Location = New System.Drawing.Point(200, 25)
        Me.lblRazaoSocialNomeTomador.Name = "lblRazaoSocialNomeTomador"
        Me.lblRazaoSocialNomeTomador.Size = New System.Drawing.Size(137, 17)
        Me.lblRazaoSocialNomeTomador.TabIndex = 11
        Me.lblRazaoSocialNomeTomador.Text = "Razão Social/Nome"
        '
        'lblInscricaoMunicipalTomador
        '
        Me.lblInscricaoMunicipalTomador.AutoSize = True
        Me.lblInscricaoMunicipalTomador.Location = New System.Drawing.Point(6, 73)
        Me.lblInscricaoMunicipalTomador.Name = "lblInscricaoMunicipalTomador"
        Me.lblInscricaoMunicipalTomador.Size = New System.Drawing.Size(131, 17)
        Me.lblInscricaoMunicipalTomador.TabIndex = 10
        Me.lblInscricaoMunicipalTomador.Text = "Inscrição Municipal"
        '
        'lblMunicipioTomador
        '
        Me.lblMunicipioTomador.AutoSize = True
        Me.lblMunicipioTomador.Location = New System.Drawing.Point(6, 123)
        Me.lblMunicipioTomador.Name = "lblMunicipioTomador"
        Me.lblMunicipioTomador.Size = New System.Drawing.Size(70, 17)
        Me.lblMunicipioTomador.TabIndex = 9
        Me.lblMunicipioTomador.Text = "Munícipio"
        '
        'lblCnpjCpfTomador
        '
        Me.lblCnpjCpfTomador.AutoSize = True
        Me.lblCnpjCpfTomador.Location = New System.Drawing.Point(6, 25)
        Me.lblCnpjCpfTomador.Name = "lblCnpjCpfTomador"
        Me.lblCnpjCpfTomador.Size = New System.Drawing.Size(74, 17)
        Me.lblCnpjCpfTomador.TabIndex = 8
        Me.lblCnpjCpfTomador.Text = "CNPJ/CPF"
        '
        'txtCnpjCpfTomador
        '
        Me.txtCnpjCpfTomador.Location = New System.Drawing.Point(9, 43)
        Me.txtCnpjCpfTomador.Name = "txtCnpjCpfTomador"
        Me.txtCnpjCpfTomador.Size = New System.Drawing.Size(150, 23)
        Me.txtCnpjCpfTomador.TabIndex = 2
        '
        'txtMunicipioTomador
        '
        Me.txtMunicipioTomador.Location = New System.Drawing.Point(9, 142)
        Me.txtMunicipioTomador.Name = "txtMunicipioTomador"
        Me.txtMunicipioTomador.Size = New System.Drawing.Size(198, 23)
        Me.txtMunicipioTomador.TabIndex = 5
        '
        'txtUFTomador
        '
        Me.txtUFTomador.Location = New System.Drawing.Point(462, 142)
        Me.txtUFTomador.Name = "txtUFTomador"
        Me.txtUFTomador.Size = New System.Drawing.Size(47, 23)
        Me.txtUFTomador.TabIndex = 6
        '
        'txtEnderecoTomador
        '
        Me.txtEnderecoTomador.Location = New System.Drawing.Point(203, 93)
        Me.txtEnderecoTomador.Name = "txtEnderecoTomador"
        Me.txtEnderecoTomador.Size = New System.Drawing.Size(315, 23)
        Me.txtEnderecoTomador.TabIndex = 4
        '
        'txtRazaoSocialNomeTomador
        '
        Me.txtRazaoSocialNomeTomador.Location = New System.Drawing.Point(203, 43)
        Me.txtRazaoSocialNomeTomador.Name = "txtRazaoSocialNomeTomador"
        Me.txtRazaoSocialNomeTomador.Size = New System.Drawing.Size(315, 23)
        Me.txtRazaoSocialNomeTomador.TabIndex = 2
        '
        'txtInscricaoMunicipalTomador
        '
        Me.txtInscricaoMunicipalTomador.Location = New System.Drawing.Point(9, 93)
        Me.txtInscricaoMunicipalTomador.Name = "txtInscricaoMunicipalTomador"
        Me.txtInscricaoMunicipalTomador.Size = New System.Drawing.Size(150, 23)
        Me.txtInscricaoMunicipalTomador.TabIndex = 3
        '
        'grpTomadorServico
        '
        Me.grpTomadorServico.Controls.Add(Me.lblUFPrestador)
        Me.grpTomadorServico.Controls.Add(Me.txtUFPrestador)
        Me.grpTomadorServico.Controls.Add(Me.lblEmailPrestador)
        Me.grpTomadorServico.Controls.Add(Me.lblEnderecoPrestador)
        Me.grpTomadorServico.Controls.Add(Me.lblRazaoSocialNomePrestador)
        Me.grpTomadorServico.Controls.Add(Me.lblInscricaoMunicipalPrestador)
        Me.grpTomadorServico.Controls.Add(Me.lblMunicipioPrestador)
        Me.grpTomadorServico.Controls.Add(Me.lblCpfCnpjPrestador)
        Me.grpTomadorServico.Controls.Add(Me.txtCnpjCpfPrestador)
        Me.grpTomadorServico.Controls.Add(Me.txtMunicipioPrestador)
        Me.grpTomadorServico.Controls.Add(Me.txtEmailPrestador)
        Me.grpTomadorServico.Controls.Add(Me.txtEnderecoPrestador)
        Me.grpTomadorServico.Controls.Add(Me.txtRazaoSocialNomePrestador)
        Me.grpTomadorServico.Controls.Add(Me.txtInscricaoMunicipalPrestador)
        Me.grpTomadorServico.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTomadorServico.Location = New System.Drawing.Point(12, 238)
        Me.grpTomadorServico.Name = "grpTomadorServico"
        Me.grpTomadorServico.Size = New System.Drawing.Size(640, 127)
        Me.grpTomadorServico.TabIndex = 11
        Me.grpTomadorServico.TabStop = False
        Me.grpTomadorServico.Text = "Tomador do Serviço"
        '
        'lblUFPrestador
        '
        Me.lblUFPrestador.AutoSize = True
        Me.lblUFPrestador.Location = New System.Drawing.Point(404, 75)
        Me.lblUFPrestador.Name = "lblUFPrestador"
        Me.lblUFPrestador.Size = New System.Drawing.Size(22, 17)
        Me.lblUFPrestador.TabIndex = 15
        Me.lblUFPrestador.Text = "UF"
        '
        'txtUFPrestador
        '
        Me.txtUFPrestador.Location = New System.Drawing.Point(407, 96)
        Me.txtUFPrestador.Name = "txtUFPrestador"
        Me.txtUFPrestador.Size = New System.Drawing.Size(36, 23)
        Me.txtUFPrestador.TabIndex = 12
        '
        'lblEmailPrestador
        '
        Me.lblEmailPrestador.AutoSize = True
        Me.lblEmailPrestador.Location = New System.Drawing.Point(446, 75)
        Me.lblEmailPrestador.Name = "lblEmailPrestador"
        Me.lblEmailPrestador.Size = New System.Drawing.Size(47, 17)
        Me.lblEmailPrestador.TabIndex = 13
        Me.lblEmailPrestador.Text = "E-mail"
        '
        'lblEnderecoPrestador
        '
        Me.lblEnderecoPrestador.AutoSize = True
        Me.lblEnderecoPrestador.Location = New System.Drawing.Point(6, 75)
        Me.lblEnderecoPrestador.Name = "lblEnderecoPrestador"
        Me.lblEnderecoPrestador.Size = New System.Drawing.Size(69, 17)
        Me.lblEnderecoPrestador.TabIndex = 12
        Me.lblEnderecoPrestador.Text = "Endereço"
        '
        'lblRazaoSocialNomePrestador
        '
        Me.lblRazaoSocialNomePrestador.AutoSize = True
        Me.lblRazaoSocialNomePrestador.Location = New System.Drawing.Point(180, 27)
        Me.lblRazaoSocialNomePrestador.Name = "lblRazaoSocialNomePrestador"
        Me.lblRazaoSocialNomePrestador.Size = New System.Drawing.Size(137, 17)
        Me.lblRazaoSocialNomePrestador.TabIndex = 11
        Me.lblRazaoSocialNomePrestador.Text = "Razão Social/Nome"
        '
        'lblInscricaoMunicipalPrestador
        '
        Me.lblInscricaoMunicipalPrestador.AutoSize = True
        Me.lblInscricaoMunicipalPrestador.Location = New System.Drawing.Point(446, 27)
        Me.lblInscricaoMunicipalPrestador.Name = "lblInscricaoMunicipalPrestador"
        Me.lblInscricaoMunicipalPrestador.Size = New System.Drawing.Size(131, 17)
        Me.lblInscricaoMunicipalPrestador.TabIndex = 10
        Me.lblInscricaoMunicipalPrestador.Text = "Inscrição Municipal"
        '
        'lblMunicipioPrestador
        '
        Me.lblMunicipioPrestador.AutoSize = True
        Me.lblMunicipioPrestador.Location = New System.Drawing.Point(248, 75)
        Me.lblMunicipioPrestador.Name = "lblMunicipioPrestador"
        Me.lblMunicipioPrestador.Size = New System.Drawing.Size(70, 17)
        Me.lblMunicipioPrestador.TabIndex = 9
        Me.lblMunicipioPrestador.Text = "Munícipio"
        '
        'lblCpfCnpjPrestador
        '
        Me.lblCpfCnpjPrestador.AutoSize = True
        Me.lblCpfCnpjPrestador.Location = New System.Drawing.Point(6, 27)
        Me.lblCpfCnpjPrestador.Name = "lblCpfCnpjPrestador"
        Me.lblCpfCnpjPrestador.Size = New System.Drawing.Size(74, 17)
        Me.lblCpfCnpjPrestador.TabIndex = 8
        Me.lblCpfCnpjPrestador.Text = "CNPJ/CPF"
        '
        'txtCnpjCpfPrestador
        '
        Me.txtCnpjCpfPrestador.Location = New System.Drawing.Point(9, 47)
        Me.txtCnpjCpfPrestador.Name = "txtCnpjCpfPrestador"
        Me.txtCnpjCpfPrestador.Size = New System.Drawing.Size(150, 23)
        Me.txtCnpjCpfPrestador.TabIndex = 7
        '
        'txtMunicipioPrestador
        '
        Me.txtMunicipioPrestador.Location = New System.Drawing.Point(251, 96)
        Me.txtMunicipioPrestador.Name = "txtMunicipioPrestador"
        Me.txtMunicipioPrestador.Size = New System.Drawing.Size(150, 23)
        Me.txtMunicipioPrestador.TabIndex = 11
        '
        'txtEmailPrestador
        '
        Me.txtEmailPrestador.Location = New System.Drawing.Point(449, 96)
        Me.txtEmailPrestador.Name = "txtEmailPrestador"
        Me.txtEmailPrestador.Size = New System.Drawing.Size(185, 23)
        Me.txtEmailPrestador.TabIndex = 13
        '
        'txtEnderecoPrestador
        '
        Me.txtEnderecoPrestador.Location = New System.Drawing.Point(9, 96)
        Me.txtEnderecoPrestador.Name = "txtEnderecoPrestador"
        Me.txtEnderecoPrestador.Size = New System.Drawing.Size(231, 23)
        Me.txtEnderecoPrestador.TabIndex = 10
        '
        'txtRazaoSocialNomePrestador
        '
        Me.txtRazaoSocialNomePrestador.Location = New System.Drawing.Point(183, 47)
        Me.txtRazaoSocialNomePrestador.Name = "txtRazaoSocialNomePrestador"
        Me.txtRazaoSocialNomePrestador.Size = New System.Drawing.Size(247, 23)
        Me.txtRazaoSocialNomePrestador.TabIndex = 8
        '
        'txtInscricaoMunicipalPrestador
        '
        Me.txtInscricaoMunicipalPrestador.Location = New System.Drawing.Point(449, 47)
        Me.txtInscricaoMunicipalPrestador.Name = "txtInscricaoMunicipalPrestador"
        Me.txtInscricaoMunicipalPrestador.Size = New System.Drawing.Size(185, 23)
        Me.txtInscricaoMunicipalPrestador.TabIndex = 9
        Me.txtInscricaoMunicipalPrestador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpServicos
        '
        Me.grpServicos.Controls.Add(Me.lblServico)
        Me.grpServicos.Controls.Add(Me.lblCódigo)
        Me.grpServicos.Controls.Add(Me.lstServicos)
        Me.grpServicos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServicos.Location = New System.Drawing.Point(12, 371)
        Me.grpServicos.Name = "grpServicos"
        Me.grpServicos.Size = New System.Drawing.Size(640, 151)
        Me.grpServicos.TabIndex = 16
        Me.grpServicos.TabStop = False
        Me.grpServicos.Text = "Discriminação dos Serviços"
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServico.Location = New System.Drawing.Point(67, 19)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(48, 16)
        Me.lblServico.TabIndex = 17
        Me.lblServico.Text = "Serviço"
        '
        'lblCódigo
        '
        Me.lblCódigo.AutoSize = True
        Me.lblCódigo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCódigo.Location = New System.Drawing.Point(6, 19)
        Me.lblCódigo.Name = "lblCódigo"
        Me.lblCódigo.Size = New System.Drawing.Size(40, 16)
        Me.lblCódigo.TabIndex = 16
        Me.lblCódigo.Text = "Qtde."
        '
        'lstServicos
        '
        Me.lstServicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstServicos.FormattingEnabled = True
        Me.lstServicos.ItemHeight = 17
        Me.lstServicos.Location = New System.Drawing.Point(9, 36)
        Me.lstServicos.Name = "lstServicos"
        Me.lstServicos.Size = New System.Drawing.Size(625, 104)
        Me.lstServicos.TabIndex = 14
        Me.lstServicos.TabStop = False
        '
        'grpValores
        '
        Me.grpValores.Controls.Add(Me.lblOutrasInformacoes)
        Me.grpValores.Controls.Add(Me.txtOutrasInformacoes)
        Me.grpValores.Controls.Add(Me.lblValorTotal)
        Me.grpValores.Controls.Add(Me.lblCodigoServico)
        Me.grpValores.Controls.Add(Me.txtCodigoServico)
        Me.grpValores.Controls.Add(Me.txtValorTotal)
        Me.grpValores.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpValores.Location = New System.Drawing.Point(12, 528)
        Me.grpValores.Name = "grpValores"
        Me.grpValores.Size = New System.Drawing.Size(640, 169)
        Me.grpValores.TabIndex = 17
        Me.grpValores.TabStop = False
        Me.grpValores.Text = "Valores e Outras informações"
        '
        'lblOutrasInformacoes
        '
        Me.lblOutrasInformacoes.AutoSize = True
        Me.lblOutrasInformacoes.Location = New System.Drawing.Point(6, 74)
        Me.lblOutrasInformacoes.Name = "lblOutrasInformacoes"
        Me.lblOutrasInformacoes.Size = New System.Drawing.Size(134, 17)
        Me.lblOutrasInformacoes.TabIndex = 20
        Me.lblOutrasInformacoes.Text = "Outras Informações"
        '
        'txtOutrasInformacoes
        '
        Me.txtOutrasInformacoes.AutoWordSelection = True
        Me.txtOutrasInformacoes.BackColor = System.Drawing.SystemColors.Window
        Me.txtOutrasInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutrasInformacoes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOutrasInformacoes.Location = New System.Drawing.Point(9, 94)
        Me.txtOutrasInformacoes.Name = "txtOutrasInformacoes"
        Me.txtOutrasInformacoes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtOutrasInformacoes.Size = New System.Drawing.Size(609, 68)
        Me.txtOutrasInformacoes.TabIndex = 1
        Me.txtOutrasInformacoes.Text = ""
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(6, 25)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(77, 17)
        Me.lblValorTotal.TabIndex = 18
        Me.lblValorTotal.Text = "Valor Total"
        '
        'lblCodigoServico
        '
        Me.lblCodigoServico.AutoSize = True
        Me.lblCodigoServico.Location = New System.Drawing.Point(155, 25)
        Me.lblCodigoServico.Name = "lblCodigoServico"
        Me.lblCodigoServico.Size = New System.Drawing.Size(129, 17)
        Me.lblCodigoServico.TabIndex = 17
        Me.lblCodigoServico.Text = "Código de Serviço"
        '
        'txtCodigoServico
        '
        Me.txtCodigoServico.Location = New System.Drawing.Point(158, 46)
        Me.txtCodigoServico.Name = "txtCodigoServico"
        Me.txtCodigoServico.Size = New System.Drawing.Size(460, 23)
        Me.txtCodigoServico.TabIndex = 16
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Location = New System.Drawing.Point(9, 45)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(129, 23)
        Me.txtValorTotal.TabIndex = 15
        '
        'lblCancelar
        '
        Me.lblCancelar.AutoSize = True
        Me.lblCancelar.Location = New System.Drawing.Point(588, 48)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Size = New System.Drawing.Size(49, 13)
        Me.lblCancelar.TabIndex = 61
        Me.lblCancelar.Text = "Cancelar"
        '
        'lblFaturarNotaFiscal
        '
        Me.lblFaturarNotaFiscal.AutoSize = True
        Me.lblFaturarNotaFiscal.Location = New System.Drawing.Point(489, 48)
        Me.lblFaturarNotaFiscal.Name = "lblFaturarNotaFiscal"
        Me.lblFaturarNotaFiscal.Size = New System.Drawing.Size(96, 13)
        Me.lblFaturarNotaFiscal.TabIndex = 63
        Me.lblFaturarNotaFiscal.Text = "Faturar Nota Fiscal"
        '
        'botFaturarNotaFiscal
        '
        Me.botFaturarNotaFiscal.Image = CType(resources.GetObject("botFaturarNotaFiscal.Image"), System.Drawing.Image)
        Me.botFaturarNotaFiscal.Location = New System.Drawing.Point(515, 5)
        Me.botFaturarNotaFiscal.Name = "botFaturarNotaFiscal"
        Me.botFaturarNotaFiscal.Size = New System.Drawing.Size(40, 40)
        Me.botFaturarNotaFiscal.TabIndex = 62
        Me.botFaturarNotaFiscal.UseVisualStyleBackColor = True
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.Location = New System.Drawing.Point(590, 5)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(40, 40)
        Me.botCancelar.TabIndex = 60
        Me.botCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.Sistema_Matrix.My.Resources.Resources.nota_fiscal_eletronica
        Me.PictureBox1.Location = New System.Drawing.Point(12, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblParcelas)
        Me.GroupBox1.Controls.Add(Me.cdbParcelas)
        Me.GroupBox1.Controls.Add(Me.lblNomeTitular)
        Me.GroupBox1.Controls.Add(Me.txtNomeTitular)
        Me.GroupBox1.Controls.Add(Me.lblSSN)
        Me.GroupBox1.Controls.Add(Me.txtSSN)
        Me.GroupBox1.Controls.Add(Me.lblNumCartao)
        Me.GroupBox1.Controls.Add(Me.txtNumCartao)
        Me.GroupBox1.Controls.Add(Me.lblBandeira)
        Me.GroupBox1.Controls.Add(Me.lblSelecioneDias)
        Me.GroupBox1.Controls.Add(Me.rdbCartaoCredito)
        Me.GroupBox1.Controls.Add(Me.rdbBoleto)
        Me.GroupBox1.Controls.Add(Me.rdbAvista)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cdbBoleto)
        Me.GroupBox1.Controls.Add(Me.cdbCartao)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 703)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 190)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações de Pagamento"
        '
        'lblParcelas
        '
        Me.lblParcelas.AutoSize = True
        Me.lblParcelas.Location = New System.Drawing.Point(530, 133)
        Me.lblParcelas.Name = "lblParcelas"
        Me.lblParcelas.Size = New System.Drawing.Size(62, 17)
        Me.lblParcelas.TabIndex = 33
        Me.lblParcelas.Text = "Parcelas"
        Me.lblParcelas.Visible = False
        '
        'cdbParcelas
        '
        Me.cdbParcelas.FormattingEnabled = True
        Me.cdbParcelas.Items.AddRange(New Object() {"1", "2", "3", "6"})
        Me.cdbParcelas.Location = New System.Drawing.Point(533, 151)
        Me.cdbParcelas.Name = "cdbParcelas"
        Me.cdbParcelas.Size = New System.Drawing.Size(85, 25)
        Me.cdbParcelas.TabIndex = 7
        Me.cdbParcelas.Visible = False
        '
        'lblNomeTitular
        '
        Me.lblNomeTitular.AutoSize = True
        Me.lblNomeTitular.Location = New System.Drawing.Point(288, 133)
        Me.lblNomeTitular.Name = "lblNomeTitular"
        Me.lblNomeTitular.Size = New System.Drawing.Size(111, 17)
        Me.lblNomeTitular.TabIndex = 31
        Me.lblNomeTitular.Text = "Nome do titular"
        Me.lblNomeTitular.Visible = False
        '
        'txtNomeTitular
        '
        Me.txtNomeTitular.Location = New System.Drawing.Point(291, 153)
        Me.txtNomeTitular.Name = "txtNomeTitular"
        Me.txtNomeTitular.Size = New System.Drawing.Size(226, 23)
        Me.txtNomeTitular.TabIndex = 6
        Me.txtNomeTitular.Visible = False
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(198, 133)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(30, 17)
        Me.lblSSN.TabIndex = 29
        Me.lblSSN.Text = "SSN"
        Me.lblSSN.Visible = False
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(201, 153)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(70, 23)
        Me.txtSSN.TabIndex = 5
        Me.txtSSN.Visible = False
        '
        'lblNumCartao
        '
        Me.lblNumCartao.AutoSize = True
        Me.lblNumCartao.Location = New System.Drawing.Point(6, 133)
        Me.lblNumCartao.Name = "lblNumCartao"
        Me.lblNumCartao.Size = New System.Drawing.Size(133, 17)
        Me.lblNumCartao.TabIndex = 27
        Me.lblNumCartao.Text = "Número do Cartão"
        Me.lblNumCartao.Visible = False
        '
        'txtNumCartao
        '
        Me.txtNumCartao.Location = New System.Drawing.Point(9, 153)
        Me.txtNumCartao.Name = "txtNumCartao"
        Me.txtNumCartao.Size = New System.Drawing.Size(171, 23)
        Me.txtNumCartao.TabIndex = 4
        Me.txtNumCartao.Visible = False
        '
        'lblBandeira
        '
        Me.lblBandeira.AutoSize = True
        Me.lblBandeira.Location = New System.Drawing.Point(6, 84)
        Me.lblBandeira.Name = "lblBandeira"
        Me.lblBandeira.Size = New System.Drawing.Size(65, 17)
        Me.lblBandeira.TabIndex = 25
        Me.lblBandeira.Text = "Bandeira"
        Me.lblBandeira.Visible = False
        '
        'lblSelecioneDias
        '
        Me.lblSelecioneDias.AutoSize = True
        Me.lblSelecioneDias.Location = New System.Drawing.Point(6, 81)
        Me.lblSelecioneDias.Name = "lblSelecioneDias"
        Me.lblSelecioneDias.Size = New System.Drawing.Size(214, 17)
        Me.lblSelecioneDias.TabIndex = 24
        Me.lblSelecioneDias.Text = "Selecione a quantidade de dias"
        Me.lblSelecioneDias.Visible = False
        '
        'rdbCartaoCredito
        '
        Me.rdbCartaoCredito.AutoSize = True
        Me.rdbCartaoCredito.Location = New System.Drawing.Point(183, 52)
        Me.rdbCartaoCredito.Name = "rdbCartaoCredito"
        Me.rdbCartaoCredito.Size = New System.Drawing.Size(147, 21)
        Me.rdbCartaoCredito.TabIndex = 21
        Me.rdbCartaoCredito.TabStop = True
        Me.rdbCartaoCredito.Text = "Cartão de Crédito"
        Me.rdbCartaoCredito.UseVisualStyleBackColor = True
        '
        'rdbBoleto
        '
        Me.rdbBoleto.AutoSize = True
        Me.rdbBoleto.Location = New System.Drawing.Point(102, 52)
        Me.rdbBoleto.Name = "rdbBoleto"
        Me.rdbBoleto.Size = New System.Drawing.Size(67, 21)
        Me.rdbBoleto.TabIndex = 20
        Me.rdbBoleto.TabStop = True
        Me.rdbBoleto.Text = "Boleto"
        Me.rdbBoleto.UseVisualStyleBackColor = True
        '
        'rdbAvista
        '
        Me.rdbAvista.AutoSize = True
        Me.rdbAvista.Location = New System.Drawing.Point(9, 52)
        Me.rdbAvista.Name = "rdbAvista"
        Me.rdbAvista.Size = New System.Drawing.Size(70, 21)
        Me.rdbAvista.TabIndex = 19
        Me.rdbAvista.TabStop = True
        Me.rdbAvista.Text = "A Vista"
        Me.rdbAvista.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tipo de Pagamento*"
        '
        'cdbBoleto
        '
        Me.cdbBoleto.FormattingEnabled = True
        Me.cdbBoleto.Items.AddRange(New Object() {"30", "60", "90"})
        Me.cdbBoleto.Location = New System.Drawing.Point(9, 104)
        Me.cdbBoleto.Name = "cdbBoleto"
        Me.cdbBoleto.Size = New System.Drawing.Size(134, 25)
        Me.cdbBoleto.TabIndex = 2
        Me.cdbBoleto.Visible = False
        '
        'cdbCartao
        '
        Me.cdbCartao.FormattingEnabled = True
        Me.cdbCartao.Items.AddRange(New Object() {"Master", "Visa"})
        Me.cdbCartao.Location = New System.Drawing.Point(9, 104)
        Me.cdbCartao.Name = "cdbCartao"
        Me.cdbCartao.Size = New System.Drawing.Size(134, 25)
        Me.cdbCartao.TabIndex = 3
        Me.cdbCartao.Visible = False
        '
        'confirmaNotaFiscal
        '
        Me.AcceptButton = Me.botFaturarNotaFiscal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.botCancelar
        Me.ClientSize = New System.Drawing.Size(735, 642)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFaturarNotaFiscal)
        Me.Controls.Add(Me.botFaturarNotaFiscal)
        Me.Controls.Add(Me.lblCancelar)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.grpValores)
        Me.Controls.Add(Me.grpServicos)
        Me.Controls.Add(Me.grpTomadorServico)
        Me.Controls.Add(Me.grpPrestadorServico)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "confirmaNotaFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar dados da Nota Fiscal"
        Me.grpPrestadorServico.ResumeLayout(False)
        Me.grpPrestadorServico.PerformLayout()
        Me.grpTomadorServico.ResumeLayout(False)
        Me.grpTomadorServico.PerformLayout()
        Me.grpServicos.ResumeLayout(False)
        Me.grpServicos.PerformLayout()
        Me.grpValores.ResumeLayout(False)
        Me.grpValores.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grpPrestadorServico As System.Windows.Forms.GroupBox
    Friend WithEvents lblUFTomador As System.Windows.Forms.Label
    Friend WithEvents lblEnderecoTomador As System.Windows.Forms.Label
    Friend WithEvents lblRazaoSocialNomeTomador As System.Windows.Forms.Label
    Friend WithEvents lblInscricaoMunicipalTomador As System.Windows.Forms.Label
    Friend WithEvents lblMunicipioTomador As System.Windows.Forms.Label
    Friend WithEvents lblCnpjCpfTomador As System.Windows.Forms.Label
    Friend WithEvents txtCnpjCpfTomador As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipioTomador As System.Windows.Forms.TextBox
    Friend WithEvents txtUFTomador As System.Windows.Forms.TextBox
    Friend WithEvents txtEnderecoTomador As System.Windows.Forms.TextBox
    Friend WithEvents txtRazaoSocialNomeTomador As System.Windows.Forms.TextBox
    Friend WithEvents txtInscricaoMunicipalTomador As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grpTomadorServico As System.Windows.Forms.GroupBox
    Friend WithEvents lblUFPrestador As System.Windows.Forms.Label
    Friend WithEvents txtUFPrestador As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailPrestador As System.Windows.Forms.Label
    Friend WithEvents lblEnderecoPrestador As System.Windows.Forms.Label
    Friend WithEvents lblRazaoSocialNomePrestador As System.Windows.Forms.Label
    Friend WithEvents lblInscricaoMunicipalPrestador As System.Windows.Forms.Label
    Friend WithEvents lblMunicipioPrestador As System.Windows.Forms.Label
    Friend WithEvents lblCpfCnpjPrestador As System.Windows.Forms.Label
    Friend WithEvents txtCnpjCpfPrestador As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicipioPrestador As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailPrestador As System.Windows.Forms.TextBox
    Friend WithEvents txtEnderecoPrestador As System.Windows.Forms.TextBox
    Friend WithEvents txtRazaoSocialNomePrestador As System.Windows.Forms.TextBox
    Friend WithEvents txtInscricaoMunicipalPrestador As System.Windows.Forms.TextBox
    Friend WithEvents grpServicos As System.Windows.Forms.GroupBox
    Friend WithEvents lstServicos As System.Windows.Forms.ListBox
    Friend WithEvents grpValores As System.Windows.Forms.GroupBox
    Friend WithEvents lblOutrasInformacoes As System.Windows.Forms.Label
    Friend WithEvents txtOutrasInformacoes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents lblCodigoServico As System.Windows.Forms.Label
    Friend WithEvents txtCodigoServico As System.Windows.Forms.TextBox
    Friend WithEvents txtValorTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblCancelar As System.Windows.Forms.Label
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents lblFaturarNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents botFaturarNotaFiscal As System.Windows.Forms.Button
    Friend WithEvents lblServico As System.Windows.Forms.Label
    Friend WithEvents lblCódigo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblParcelas As System.Windows.Forms.Label
    Friend WithEvents cdbParcelas As System.Windows.Forms.ComboBox
    Friend WithEvents lblNomeTitular As System.Windows.Forms.Label
    Friend WithEvents txtNomeTitular As System.Windows.Forms.TextBox
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents lblNumCartao As System.Windows.Forms.Label
    Friend WithEvents txtNumCartao As System.Windows.Forms.TextBox
    Friend WithEvents lblBandeira As System.Windows.Forms.Label
    Friend WithEvents lblSelecioneDias As System.Windows.Forms.Label
    Friend WithEvents cdbCartao As System.Windows.Forms.ComboBox
    Friend WithEvents cdbBoleto As System.Windows.Forms.ComboBox
    Friend WithEvents rdbCartaoCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBoleto As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAvista As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
