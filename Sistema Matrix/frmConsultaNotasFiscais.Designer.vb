<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaNotasFiscais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaNotasFiscais))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtgNotaFiscal = New System.Windows.Forms.DataGridView()
        Me.lblCnpjCpfTomador = New System.Windows.Forms.Label()
        Me.txtCnpjCpfTomador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFaturarNotaFiscal = New System.Windows.Forms.Label()
        Me.botFaturarNotaFiscal = New System.Windows.Forms.Button()
        Me.chkEntreDatas = New System.Windows.Forms.CheckBox()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.notCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notCodVer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notOutrasInformacoes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ordCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.demCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(16, 28)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(132, 23)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Notas Fiscais"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.Sistema_Matrix.My.Resources.Resources.nota_fiscal_eletronica
        Me.PictureBox1.Location = New System.Drawing.Point(21, 69)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'dtgNotaFiscal
        '
        Me.dtgNotaFiscal.BackgroundColor = System.Drawing.Color.Azure
        Me.dtgNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgNotaFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgNotaFiscal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.notCodigo, Me.notHora, Me.notValor, Me.notData, Me.notCodVer, Me.notOutrasInformacoes, Me.ordCodigo, Me.demCodigo, Me.cliCodigo, Me.cliNome})
        Me.dtgNotaFiscal.Location = New System.Drawing.Point(21, 199)
        Me.dtgNotaFiscal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgNotaFiscal.Name = "dtgNotaFiscal"
        Me.dtgNotaFiscal.Size = New System.Drawing.Size(1168, 630)
        Me.dtgNotaFiscal.TabIndex = 12
        '
        'lblCnpjCpfTomador
        '
        Me.lblCnpjCpfTomador.AutoSize = True
        Me.lblCnpjCpfTomador.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblCnpjCpfTomador.Location = New System.Drawing.Point(188, 127)
        Me.lblCnpjCpfTomador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCnpjCpfTomador.Name = "lblCnpjCpfTomador"
        Me.lblCnpjCpfTomador.Size = New System.Drawing.Size(69, 21)
        Me.lblCnpjCpfTomador.TabIndex = 14
        Me.lblCnpjCpfTomador.Text = "Cliente"
        '
        'txtCnpjCpfTomador
        '
        Me.txtCnpjCpfTomador.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCnpjCpfTomador.Location = New System.Drawing.Point(192, 151)
        Me.txtCnpjCpfTomador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCnpjCpfTomador.Multiline = True
        Me.txtCnpjCpfTomador.Name = "txtCnpjCpfTomador"
        Me.txtCnpjCpfTomador.Size = New System.Drawing.Size(199, 27)
        Me.txtCnpjCpfTomador.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(412, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Data Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(749, 127)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Data Final"
        '
        'lblFaturarNotaFiscal
        '
        Me.lblFaturarNotaFiscal.AutoSize = True
        Me.lblFaturarNotaFiscal.Location = New System.Drawing.Point(992, 58)
        Me.lblFaturarNotaFiscal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFaturarNotaFiscal.Name = "lblFaturarNotaFiscal"
        Me.lblFaturarNotaFiscal.Size = New System.Drawing.Size(106, 17)
        Me.lblFaturarNotaFiscal.TabIndex = 65
        Me.lblFaturarNotaFiscal.Text = "Gerar Relatório"
        '
        'botFaturarNotaFiscal
        '
        Me.botFaturarNotaFiscal.Image = CType(resources.GetObject("botFaturarNotaFiscal.Image"), System.Drawing.Image)
        Me.botFaturarNotaFiscal.Location = New System.Drawing.Point(1013, 5)
        Me.botFaturarNotaFiscal.Margin = New System.Windows.Forms.Padding(4)
        Me.botFaturarNotaFiscal.Name = "botFaturarNotaFiscal"
        Me.botFaturarNotaFiscal.Size = New System.Drawing.Size(53, 49)
        Me.botFaturarNotaFiscal.TabIndex = 64
        Me.botFaturarNotaFiscal.UseVisualStyleBackColor = True
        '
        'chkEntreDatas
        '
        Me.chkEntreDatas.AutoSize = True
        Me.chkEntreDatas.Font = New System.Drawing.Font("Century Gothic", 9.5!)
        Me.chkEntreDatas.Location = New System.Drawing.Point(623, 153)
        Me.chkEntreDatas.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEntreDatas.Name = "chkEntreDatas"
        Me.chkEntreDatas.Size = New System.Drawing.Size(123, 25)
        Me.chkEntreDatas.TabIndex = 66
        Me.chkEntreDatas.Text = "Entre datas"
        Me.chkEntreDatas.UseVisualStyleBackColor = True
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataInicial.Location = New System.Drawing.Point(416, 153)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(200, 22)
        Me.dtpDataInicial.TabIndex = 70
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataFinal.Location = New System.Drawing.Point(753, 153)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(200, 22)
        Me.dtpDataFinal.TabIndex = 71
        '
        'notCodigo
        '
        Me.notCodigo.HeaderText = "Código"
        Me.notCodigo.Name = "notCodigo"
        '
        'notHora
        '
        Me.notHora.HeaderText = "Hora"
        Me.notHora.Name = "notHora"
        '
        'notValor
        '
        Me.notValor.HeaderText = "Valor"
        Me.notValor.Name = "notValor"
        '
        'notData
        '
        Me.notData.HeaderText = "Data"
        Me.notData.Name = "notData"
        '
        'notCodVer
        '
        Me.notCodVer.HeaderText = "Código de Verificação"
        Me.notCodVer.Name = "notCodVer"
        '
        'notOutrasInformacoes
        '
        Me.notOutrasInformacoes.HeaderText = "Outras Informacoes"
        Me.notOutrasInformacoes.Name = "notOutrasInformacoes"
        '
        'ordCodigo
        '
        Me.ordCodigo.HeaderText = "Código da Ordem de Serviço"
        Me.ordCodigo.Name = "ordCodigo"
        '
        'demCodigo
        '
        Me.demCodigo.HeaderText = "Código dos Dados Emitentes"
        Me.demCodigo.Name = "demCodigo"
        '
        'cliCodigo
        '
        Me.cliCodigo.HeaderText = "Código do Cliente"
        Me.cliCodigo.Name = "cliCodigo"
        '
        'cliNome
        '
        Me.cliNome.HeaderText = "Nome do Cliente"
        Me.cliNome.Name = "cliNome"
        '
        'frmConsultaNotasFiscais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1135, 742)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.chkEntreDatas)
        Me.Controls.Add(Me.lblFaturarNotaFiscal)
        Me.Controls.Add(Me.botFaturarNotaFiscal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCnpjCpfTomador)
        Me.Controls.Add(Me.txtCnpjCpfTomador)
        Me.Controls.Add(Me.dtgNotaFiscal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConsultaNotasFiscais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Notas Fiscais"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgNotaFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtgNotaFiscal As System.Windows.Forms.DataGridView
    Friend WithEvents lblCnpjCpfTomador As System.Windows.Forms.Label
    Friend WithEvents txtCnpjCpfTomador As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFaturarNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents botFaturarNotaFiscal As System.Windows.Forms.Button
    Friend WithEvents chkEntreDatas As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDataInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents notCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notCodVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents notOutrasInformacoes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ordCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents demCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliNome As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
