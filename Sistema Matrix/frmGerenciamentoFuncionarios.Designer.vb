<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGerenciamentoFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGerenciamentoFuncionarios))
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.lblDataAdmissao = New System.Windows.Forms.Label()
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
        Me.tabFuncionarios = New System.Windows.Forms.TabControl()
        Me.tabCadastroFuncionarios = New System.Windows.Forms.TabPage()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.botHoje = New System.Windows.Forms.Button()
        Me.mtxDataAdmissao = New System.Windows.Forms.MaskedTextBox()
        Me.lblCampoObrigatorio = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.tabConsultaFuncionarios = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConCargo = New System.Windows.Forms.Label()
        Me.lblConNome = New System.Windows.Forms.Label()
        Me.lblConMatricula = New System.Windows.Forms.Label()
        Me.txtConCargo = New System.Windows.Forms.TextBox()
        Me.txtConNome = New System.Windows.Forms.TextBox()
        Me.txtConMatricula = New System.Windows.Forms.TextBox()
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.dtgFuncionarios = New System.Windows.Forms.DataGridView()
        Me.tabFuncionarios.SuspendLayout()
        Me.tabCadastroFuncionarios.SuspendLayout()
        Me.tabConsultaFuncionarios.SuspendLayout()
        CType(Me.dtgFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(8, 133)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(63, 20)
        Me.lblNome.TabIndex = 23
        Me.lblNome.Text = "Nome *"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(12, 156)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(360, 20)
        Me.txtNome.TabIndex = 2
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.Location = New System.Drawing.Point(7, 303)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(66, 20)
        Me.lblCargo.TabIndex = 40
        Me.lblCargo.Text = "Cargo *"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(12, 326)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(132, 20)
        Me.txtCargo.TabIndex = 3
        '
        'lblDataAdmissao
        '
        Me.lblDataAdmissao.AutoSize = True
        Me.lblDataAdmissao.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataAdmissao.Location = New System.Drawing.Point(8, 362)
        Me.lblDataAdmissao.Name = "lblDataAdmissao"
        Me.lblDataAdmissao.Size = New System.Drawing.Size(152, 20)
        Me.lblDataAdmissao.TabIndex = 42
        Me.lblDataAdmissao.Text = "Data de Admissão *"
        '
        'lblInserir
        '
        Me.lblInserir.AutoSize = True
        Me.lblInserir.Location = New System.Drawing.Point(9, 53)
        Me.lblInserir.Name = "lblInserir"
        Me.lblInserir.Size = New System.Drawing.Size(75, 13)
        Me.lblInserir.TabIndex = 69
        Me.lblInserir.Text = "Novo Registro"
        Me.lblInserir.Visible = False
        '
        'lblLimpar
        '
        Me.lblLimpar.AutoSize = True
        Me.lblLimpar.Location = New System.Drawing.Point(9, 495)
        Me.lblLimpar.Name = "lblLimpar"
        Me.lblLimpar.Size = New System.Drawing.Size(66, 13)
        Me.lblLimpar.TabIndex = 67
        Me.lblLimpar.Text = "Limpar Tudo"
        '
        'lblCadastrar
        '
        Me.lblCadastrar.AutoSize = True
        Me.lblCadastrar.Location = New System.Drawing.Point(514, 53)
        Me.lblCadastrar.Name = "lblCadastrar"
        Me.lblCadastrar.Size = New System.Drawing.Size(52, 13)
        Me.lblCadastrar.TabIndex = 66
        Me.lblCadastrar.Text = "Cadastrar"
        '
        'botModoNovo
        '
        Me.botModoNovo.Image = Global.Sistema_Matrix.My.Resources.Resources.adicionar
        Me.botModoNovo.Location = New System.Drawing.Point(23, 10)
        Me.botModoNovo.Name = "botModoNovo"
        Me.botModoNovo.Size = New System.Drawing.Size(40, 40)
        Me.botModoNovo.TabIndex = 10
        Me.botModoNovo.UseVisualStyleBackColor = True
        Me.botModoNovo.Visible = False
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Location = New System.Drawing.Point(90, 53)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(79, 13)
        Me.lblAlterar.TabIndex = 70
        Me.lblAlterar.Text = "Alterar Registro"
        Me.lblAlterar.Visible = False
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Location = New System.Drawing.Point(428, 53)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(80, 13)
        Me.lblExcluir.TabIndex = 68
        Me.lblExcluir.Text = "Excluir Registro"
        Me.lblExcluir.Visible = False
        '
        'botAlterar
        '
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(111, 10)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(40, 40)
        Me.botAlterar.TabIndex = 8
        Me.botAlterar.UseVisualStyleBackColor = True
        Me.botAlterar.Visible = False
        '
        'botExcluir
        '
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(443, 10)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(40, 40)
        Me.botExcluir.TabIndex = 9
        Me.botExcluir.UseVisualStyleBackColor = True
        Me.botExcluir.Visible = False
        '
        'botLimpar
        '
        Me.botLimpar.Image = Global.Sistema_Matrix.My.Resources.Resources.limpar
        Me.botLimpar.Location = New System.Drawing.Point(19, 452)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(40, 40)
        Me.botLimpar.TabIndex = 6
        Me.botLimpar.UseVisualStyleBackColor = True
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botCadastrar.Location = New System.Drawing.Point(517, 10)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(40, 40)
        Me.botCadastrar.TabIndex = 5
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'tabFuncionarios
        '
        Me.tabFuncionarios.Controls.Add(Me.tabCadastroFuncionarios)
        Me.tabFuncionarios.Controls.Add(Me.tabConsultaFuncionarios)
        Me.tabFuncionarios.Location = New System.Drawing.Point(15, 12)
        Me.tabFuncionarios.Name = "tabFuncionarios"
        Me.tabFuncionarios.SelectedIndex = 0
        Me.tabFuncionarios.Size = New System.Drawing.Size(589, 545)
        Me.tabFuncionarios.TabIndex = 71
        '
        'tabCadastroFuncionarios
        '
        Me.tabCadastroFuncionarios.Controls.Add(Me.txtSalario)
        Me.tabCadastroFuncionarios.Controls.Add(Me.Label6)
        Me.tabCadastroFuncionarios.Controls.Add(Me.txtTelefone)
        Me.tabCadastroFuncionarios.Controls.Add(Me.Label5)
        Me.tabCadastroFuncionarios.Controls.Add(Me.txtCidade)
        Me.tabCadastroFuncionarios.Controls.Add(Me.Label4)
        Me.tabCadastroFuncionarios.Controls.Add(Me.txtBairro)
        Me.tabCadastroFuncionarios.Controls.Add(Me.Label3)
        Me.tabCadastroFuncionarios.Controls.Add(Me.Label2)
        Me.tabCadastroFuncionarios.Controls.Add(Me.txtEndereco)
        Me.tabCadastroFuncionarios.Controls.Add(Me.botHoje)
        Me.tabCadastroFuncionarios.Controls.Add(Me.mtxDataAdmissao)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblCampoObrigatorio)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblInserir)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblMatricula)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblLimpar)
        Me.tabCadastroFuncionarios.Controls.Add(Me.txtMatricula)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblCadastrar)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblNome)
        Me.tabCadastroFuncionarios.Controls.Add(Me.botModoNovo)
        Me.tabCadastroFuncionarios.Controls.Add(Me.txtNome)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblAlterar)
        Me.tabCadastroFuncionarios.Controls.Add(Me.txtCargo)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblExcluir)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblCargo)
        Me.tabCadastroFuncionarios.Controls.Add(Me.lblDataAdmissao)
        Me.tabCadastroFuncionarios.Controls.Add(Me.botExcluir)
        Me.tabCadastroFuncionarios.Controls.Add(Me.botCadastrar)
        Me.tabCadastroFuncionarios.Controls.Add(Me.botLimpar)
        Me.tabCadastroFuncionarios.Controls.Add(Me.botAlterar)
        Me.tabCadastroFuncionarios.Location = New System.Drawing.Point(4, 22)
        Me.tabCadastroFuncionarios.Name = "tabCadastroFuncionarios"
        Me.tabCadastroFuncionarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastroFuncionarios.Size = New System.Drawing.Size(581, 519)
        Me.tabCadastroFuncionarios.TabIndex = 0
        Me.tabCadastroFuncionarios.Text = "Funcionários"
        Me.tabCadastroFuncionarios.UseVisualStyleBackColor = True
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(193, 326)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(133, 20)
        Me.txtSalario.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Salário"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(300, 267)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(133, 20)
        Me.txtTelefone.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Telefone"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(300, 207)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(187, 20)
        Me.txtCidade.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Cidade"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(12, 267)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(227, 20)
        Me.txtBairro.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Bairro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Endereço *"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(12, 207)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(256, 20)
        Me.txtEndereco.TabIndex = 74
        '
        'botHoje
        '
        Me.botHoje.Location = New System.Drawing.Point(86, 382)
        Me.botHoje.Name = "botHoje"
        Me.botHoje.Size = New System.Drawing.Size(47, 23)
        Me.botHoje.TabIndex = 73
        Me.botHoje.TabStop = False
        Me.botHoje.Text = "Hoje"
        Me.botHoje.UseVisualStyleBackColor = True
        '
        'mtxDataAdmissao
        '
        Me.mtxDataAdmissao.Location = New System.Drawing.Point(12, 385)
        Me.mtxDataAdmissao.Mask = "00/00/0000"
        Me.mtxDataAdmissao.Name = "mtxDataAdmissao"
        Me.mtxDataAdmissao.Size = New System.Drawing.Size(68, 20)
        Me.mtxDataAdmissao.TabIndex = 4
        Me.mtxDataAdmissao.ValidatingType = GetType(Date)
        '
        'lblCampoObrigatorio
        '
        Me.lblCampoObrigatorio.AutoSize = True
        Me.lblCampoObrigatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampoObrigatorio.ForeColor = System.Drawing.Color.Red
        Me.lblCampoObrigatorio.Location = New System.Drawing.Point(449, 495)
        Me.lblCampoObrigatorio.Name = "lblCampoObrigatorio"
        Me.lblCampoObrigatorio.Size = New System.Drawing.Size(108, 13)
        Me.lblCampoObrigatorio.TabIndex = 71
        Me.lblCampoObrigatorio.Text = "*Campos Obrigatórios"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(8, 82)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(89, 20)
        Me.lblMatricula.TabIndex = 1
        Me.lblMatricula.Text = "Matrícula *"
        '
        'txtMatricula
        '
        Me.txtMatricula.Enabled = False
        Me.txtMatricula.Location = New System.Drawing.Point(12, 105)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(94, 20)
        Me.txtMatricula.TabIndex = 1
        Me.txtMatricula.Tag = "Não"
        '
        'tabConsultaFuncionarios
        '
        Me.tabConsultaFuncionarios.Controls.Add(Me.Label1)
        Me.tabConsultaFuncionarios.Controls.Add(Me.lblConCargo)
        Me.tabConsultaFuncionarios.Controls.Add(Me.lblConNome)
        Me.tabConsultaFuncionarios.Controls.Add(Me.lblConMatricula)
        Me.tabConsultaFuncionarios.Controls.Add(Me.txtConCargo)
        Me.tabConsultaFuncionarios.Controls.Add(Me.txtConNome)
        Me.tabConsultaFuncionarios.Controls.Add(Me.txtConMatricula)
        Me.tabConsultaFuncionarios.Controls.Add(Me.lblMensagem)
        Me.tabConsultaFuncionarios.Controls.Add(Me.dtgFuncionarios)
        Me.tabConsultaFuncionarios.Location = New System.Drawing.Point(4, 22)
        Me.tabConsultaFuncionarios.Name = "tabConsultaFuncionarios"
        Me.tabConsultaFuncionarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsultaFuncionarios.Size = New System.Drawing.Size(581, 519)
        Me.tabConsultaFuncionarios.TabIndex = 1
        Me.tabConsultaFuncionarios.Text = "Consulta"
        Me.tabConsultaFuncionarios.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Consulta de Funcionários"
        '
        'lblConCargo
        '
        Me.lblConCargo.AutoSize = True
        Me.lblConCargo.Location = New System.Drawing.Point(255, 38)
        Me.lblConCargo.Name = "lblConCargo"
        Me.lblConCargo.Size = New System.Drawing.Size(35, 13)
        Me.lblConCargo.TabIndex = 6
        Me.lblConCargo.Text = "Cargo"
        '
        'lblConNome
        '
        Me.lblConNome.AutoSize = True
        Me.lblConNome.Location = New System.Drawing.Point(106, 38)
        Me.lblConNome.Name = "lblConNome"
        Me.lblConNome.Size = New System.Drawing.Size(35, 13)
        Me.lblConNome.TabIndex = 5
        Me.lblConNome.Text = "Nome"
        '
        'lblConMatricula
        '
        Me.lblConMatricula.AutoSize = True
        Me.lblConMatricula.Location = New System.Drawing.Point(42, 38)
        Me.lblConMatricula.Name = "lblConMatricula"
        Me.lblConMatricula.Size = New System.Drawing.Size(52, 13)
        Me.lblConMatricula.TabIndex = 4
        Me.lblConMatricula.Text = "Matrícula"
        '
        'txtConCargo
        '
        Me.txtConCargo.Location = New System.Drawing.Point(258, 57)
        Me.txtConCargo.Name = "txtConCargo"
        Me.txtConCargo.Size = New System.Drawing.Size(122, 20)
        Me.txtConCargo.TabIndex = 3
        Me.txtConCargo.Tag = "Não"
        '
        'txtConNome
        '
        Me.txtConNome.Location = New System.Drawing.Point(109, 57)
        Me.txtConNome.Name = "txtConNome"
        Me.txtConNome.Size = New System.Drawing.Size(143, 20)
        Me.txtConNome.TabIndex = 2
        Me.txtConNome.Tag = "Não"
        '
        'txtConMatricula
        '
        Me.txtConMatricula.Location = New System.Drawing.Point(42, 57)
        Me.txtConMatricula.Name = "txtConMatricula"
        Me.txtConMatricula.Size = New System.Drawing.Size(61, 20)
        Me.txtConMatricula.TabIndex = 1
        Me.txtConMatricula.Tag = "Não"
        '
        'lblMensagem
        '
        Me.lblMensagem.AutoSize = True
        Me.lblMensagem.Location = New System.Drawing.Point(155, 361)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(225, 13)
        Me.lblMensagem.TabIndex = 12
        Me.lblMensagem.Text = "Dê um duplo clique na linha que deseja alterar"
        '
        'dtgFuncionarios
        '
        Me.dtgFuncionarios.AllowUserToAddRows = False
        Me.dtgFuncionarios.AllowUserToDeleteRows = False
        Me.dtgFuncionarios.AllowUserToOrderColumns = True
        Me.dtgFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgFuncionarios.Location = New System.Drawing.Point(3, 87)
        Me.dtgFuncionarios.Name = "dtgFuncionarios"
        Me.dtgFuncionarios.ReadOnly = True
        Me.dtgFuncionarios.Size = New System.Drawing.Size(384, 270)
        Me.dtgFuncionarios.TabIndex = 0
        '
        'frmGerenciamentoFuncionarios
        '
        Me.AcceptButton = Me.botCadastrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 567)
        Me.Controls.Add(Me.tabFuncionarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGerenciamentoFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Funcionários"
        Me.tabFuncionarios.ResumeLayout(False)
        Me.tabCadastroFuncionarios.ResumeLayout(False)
        Me.tabCadastroFuncionarios.PerformLayout()
        Me.tabConsultaFuncionarios.ResumeLayout(False)
        Me.tabConsultaFuncionarios.PerformLayout()
        CType(Me.dtgFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents lblDataAdmissao As System.Windows.Forms.Label
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
    Friend WithEvents tabFuncionarios As System.Windows.Forms.TabControl
    Friend WithEvents tabCadastroFuncionarios As System.Windows.Forms.TabPage
    Friend WithEvents tabConsultaFuncionarios As System.Windows.Forms.TabPage
    Friend WithEvents lblCampoObrigatorio As System.Windows.Forms.Label
    Friend WithEvents dtgFuncionarios As System.Windows.Forms.DataGridView
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents lblConCargo As System.Windows.Forms.Label
    Friend WithEvents lblConNome As System.Windows.Forms.Label
    Friend WithEvents lblConMatricula As System.Windows.Forms.Label
    Friend WithEvents txtConCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtConNome As System.Windows.Forms.TextBox
    Friend WithEvents txtConMatricula As System.Windows.Forms.TextBox
    Friend WithEvents mtxDataAdmissao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents botHoje As System.Windows.Forms.Button
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
End Class
