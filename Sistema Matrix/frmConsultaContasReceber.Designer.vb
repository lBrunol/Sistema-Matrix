<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaContasReceber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaContasReceber))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dtgContasReceber = New System.Windows.Forms.DataGridView()
        Me.lblCnpjCpfTomador = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblFaturarNotaFiscal = New System.Windows.Forms.Label()
        Me.chkEntreDatas = New System.Windows.Forms.CheckBox()
        Me.lblLancaPagamento = New System.Windows.Forms.Label()
        Me.mtxDataInicial = New System.Windows.Forms.MaskedTextBox()
        Me.mtxDataFinal = New System.Windows.Forms.MaskedTextBox()
        Me.botLancaPagamento = New System.Windows.Forms.Button()
        Me.botFaturarNotaFiscal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dtgContasReceber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(152, 21)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Contas a Receber"
        '
        'dtgContasReceber
        '
        Me.dtgContasReceber.BackgroundColor = System.Drawing.Color.Azure
        Me.dtgContasReceber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgContasReceber.Location = New System.Drawing.Point(16, 162)
        Me.dtgContasReceber.Name = "dtgContasReceber"
        Me.dtgContasReceber.Size = New System.Drawing.Size(980, 512)
        Me.dtgContasReceber.TabIndex = 12
        '
        'lblCnpjCpfTomador
        '
        Me.lblCnpjCpfTomador.AutoSize = True
        Me.lblCnpjCpfTomador.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblCnpjCpfTomador.Location = New System.Drawing.Point(141, 103)
        Me.lblCnpjCpfTomador.Name = "lblCnpjCpfTomador"
        Me.lblCnpjCpfTomador.Size = New System.Drawing.Size(54, 17)
        Me.lblCnpjCpfTomador.TabIndex = 14
        Me.lblCnpjCpfTomador.Text = "Cliente"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNomeCliente.Location = New System.Drawing.Point(144, 123)
        Me.txtNomeCliente.Multiline = True
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(248, 23)
        Me.txtNomeCliente.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(408, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Data Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(671, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Data Final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(849, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Atrasado", "Pendente", "Pago"})
        Me.cboStatus.Location = New System.Drawing.Point(852, 121)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(139, 25)
        Me.cboStatus.TabIndex = 21
        '
        'lblFaturarNotaFiscal
        '
        Me.lblFaturarNotaFiscal.AutoSize = True
        Me.lblFaturarNotaFiscal.Location = New System.Drawing.Point(925, 47)
        Me.lblFaturarNotaFiscal.Name = "lblFaturarNotaFiscal"
        Me.lblFaturarNotaFiscal.Size = New System.Drawing.Size(78, 13)
        Me.lblFaturarNotaFiscal.TabIndex = 65
        Me.lblFaturarNotaFiscal.Text = "Gerar Relatório"
        '
        'chkEntreDatas
        '
        Me.chkEntreDatas.AutoSize = True
        Me.chkEntreDatas.Font = New System.Drawing.Font("Century Gothic", 9.5!)
        Me.chkEntreDatas.Location = New System.Drawing.Point(569, 125)
        Me.chkEntreDatas.Name = "chkEntreDatas"
        Me.chkEntreDatas.Size = New System.Drawing.Size(100, 21)
        Me.chkEntreDatas.TabIndex = 66
        Me.chkEntreDatas.Text = "Entre datas"
        Me.chkEntreDatas.UseVisualStyleBackColor = True
        '
        'lblLancaPagamento
        '
        Me.lblLancaPagamento.AutoSize = True
        Me.lblLancaPagamento.Location = New System.Drawing.Point(822, 47)
        Me.lblLancaPagamento.Name = "lblLancaPagamento"
        Me.lblLancaPagamento.Size = New System.Drawing.Size(97, 13)
        Me.lblLancaPagamento.TabIndex = 68
        Me.lblLancaPagamento.Text = "Lançar Pagamento"
        '
        'mtxDataInicial
        '
        Me.mtxDataInicial.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.mtxDataInicial.Location = New System.Drawing.Point(411, 121)
        Me.mtxDataInicial.Mask = "00/00/0000"
        Me.mtxDataInicial.Name = "mtxDataInicial"
        Me.mtxDataInicial.Size = New System.Drawing.Size(133, 23)
        Me.mtxDataInicial.TabIndex = 69
        Me.mtxDataInicial.ValidatingType = GetType(Date)
        '
        'mtxDataFinal
        '
        Me.mtxDataFinal.Enabled = False
        Me.mtxDataFinal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.mtxDataFinal.Location = New System.Drawing.Point(674, 121)
        Me.mtxDataFinal.Mask = "00/00/0000"
        Me.mtxDataFinal.Name = "mtxDataFinal"
        Me.mtxDataFinal.Size = New System.Drawing.Size(133, 23)
        Me.mtxDataFinal.TabIndex = 70
        Me.mtxDataFinal.ValidatingType = GetType(Date)
        '
        'botLancaPagamento
        '
        Me.botLancaPagamento.Image = CType(resources.GetObject("botLancaPagamento.Image"), System.Drawing.Image)
        Me.botLancaPagamento.Location = New System.Drawing.Point(852, 4)
        Me.botLancaPagamento.Name = "botLancaPagamento"
        Me.botLancaPagamento.Size = New System.Drawing.Size(40, 40)
        Me.botLancaPagamento.TabIndex = 67
        Me.botLancaPagamento.UseVisualStyleBackColor = True
        '
        'botFaturarNotaFiscal
        '
        Me.botFaturarNotaFiscal.Image = CType(resources.GetObject("botFaturarNotaFiscal.Image"), System.Drawing.Image)
        Me.botFaturarNotaFiscal.Location = New System.Drawing.Point(941, 4)
        Me.botFaturarNotaFiscal.Name = "botFaturarNotaFiscal"
        Me.botFaturarNotaFiscal.Size = New System.Drawing.Size(40, 40)
        Me.botFaturarNotaFiscal.TabIndex = 64
        Me.botFaturarNotaFiscal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.Sistema_Matrix.My.Resources.Resources.nota_fiscal_eletronica
        Me.PictureBox1.Location = New System.Drawing.Point(16, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmConsultaContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1008, 686)
        Me.Controls.Add(Me.mtxDataFinal)
        Me.Controls.Add(Me.mtxDataInicial)
        Me.Controls.Add(Me.lblLancaPagamento)
        Me.Controls.Add(Me.botLancaPagamento)
        Me.Controls.Add(Me.chkEntreDatas)
        Me.Controls.Add(Me.lblFaturarNotaFiscal)
        Me.Controls.Add(Me.botFaturarNotaFiscal)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCnpjCpfTomador)
        Me.Controls.Add(Me.txtNomeCliente)
        Me.Controls.Add(Me.dtgContasReceber)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsultaContasReceber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Contas a Receber"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgContasReceber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtgContasReceber As System.Windows.Forms.DataGridView
    Friend WithEvents lblCnpjCpfTomador As System.Windows.Forms.Label
    Friend WithEvents txtNomeCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblFaturarNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents botFaturarNotaFiscal As System.Windows.Forms.Button
    Friend WithEvents chkEntreDatas As System.Windows.Forms.CheckBox
    Friend WithEvents lblLancaPagamento As System.Windows.Forms.Label
    Friend WithEvents botLancaPagamento As System.Windows.Forms.Button
    Friend WithEvents mtxDataInicial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxDataFinal As System.Windows.Forms.MaskedTextBox
End Class
