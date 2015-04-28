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
        Me.lstServicos = New System.Windows.Forms.ListBox()
        Me.grpValores = New System.Windows.Forms.GroupBox()
        Me.lblOutrasInformacoes = New System.Windows.Forms.Label()
        Me.txtOutrasInformacoes = New System.Windows.Forms.RichTextBox()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.lblCodigoServico = New System.Windows.Forms.Label()
        Me.txtCodigoServico = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblCancelar = New System.Windows.Forms.Label()
        Me.lblFaturarNotaFiscal = New System.Windows.Forms.Label()
        Me.botFaturarNotaFiscal = New System.Windows.Forms.Button()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpPrestadorServico.SuspendLayout()
        Me.grpTomadorServico.SuspendLayout()
        Me.grpServicos.SuspendLayout()
        Me.grpValores.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpServicos.Controls.Add(Me.lstServicos)
        Me.grpServicos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServicos.Location = New System.Drawing.Point(12, 371)
        Me.grpServicos.Name = "grpServicos"
        Me.grpServicos.Size = New System.Drawing.Size(640, 142)
        Me.grpServicos.TabIndex = 16
        Me.grpServicos.TabStop = False
        Me.grpServicos.Text = "Discriminação dos Serviços"
        '
        'lstServicos
        '
        Me.lstServicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstServicos.FormattingEnabled = True
        Me.lstServicos.ItemHeight = 17
        Me.lstServicos.Location = New System.Drawing.Point(9, 22)
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
        Me.grpValores.Controls.Add(Me.TextBox3)
        Me.grpValores.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpValores.Location = New System.Drawing.Point(12, 521)
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(9, 45)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(129, 23)
        Me.TextBox3.TabIndex = 15
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
        'confirmaNotaFiscal
        '
        Me.AcceptButton = Me.botFaturarNotaFiscal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.botCancelar
        Me.ClientSize = New System.Drawing.Size(735, 686)
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
        Me.KeyPreview = True
        Me.Name = "confirmaNotaFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar dados da Nota Fiscal"
        Me.grpPrestadorServico.ResumeLayout(False)
        Me.grpPrestadorServico.PerformLayout()
        Me.grpTomadorServico.ResumeLayout(False)
        Me.grpTomadorServico.PerformLayout()
        Me.grpServicos.ResumeLayout(False)
        Me.grpValores.ResumeLayout(False)
        Me.grpValores.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblCancelar As System.Windows.Forms.Label
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents lblFaturarNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents botFaturarNotaFiscal As System.Windows.Forms.Button
End Class
