<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotasFiscais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotasFiscais))
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
        Me.mskDataInicial = New System.Windows.Forms.MaskedTextBox()
        Me.mskDataFinal = New System.Windows.Forms.MaskedTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgNotaFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(107, 21)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Notas Fiscais"
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
        'dtgNotaFiscal
        '
        Me.dtgNotaFiscal.BackgroundColor = System.Drawing.Color.Azure
        Me.dtgNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgNotaFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgNotaFiscal.Location = New System.Drawing.Point(16, 162)
        Me.dtgNotaFiscal.Name = "dtgNotaFiscal"
        Me.dtgNotaFiscal.Size = New System.Drawing.Size(876, 512)
        Me.dtgNotaFiscal.TabIndex = 12
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
        'txtCnpjCpfTomador
        '
        Me.txtCnpjCpfTomador.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCnpjCpfTomador.Location = New System.Drawing.Point(144, 123)
        Me.txtCnpjCpfTomador.Multiline = True
        Me.txtCnpjCpfTomador.Name = "txtCnpjCpfTomador"
        Me.txtCnpjCpfTomador.Size = New System.Drawing.Size(150, 23)
        Me.txtCnpjCpfTomador.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(309, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Data Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(572, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Data Final"
        '
        'lblFaturarNotaFiscal
        '
        Me.lblFaturarNotaFiscal.AutoSize = True
        Me.lblFaturarNotaFiscal.Location = New System.Drawing.Point(744, 47)
        Me.lblFaturarNotaFiscal.Name = "lblFaturarNotaFiscal"
        Me.lblFaturarNotaFiscal.Size = New System.Drawing.Size(78, 13)
        Me.lblFaturarNotaFiscal.TabIndex = 65
        Me.lblFaturarNotaFiscal.Text = "Gerar Relatório"
        '
        'botFaturarNotaFiscal
        '
        Me.botFaturarNotaFiscal.Image = CType(resources.GetObject("botFaturarNotaFiscal.Image"), System.Drawing.Image)
        Me.botFaturarNotaFiscal.Location = New System.Drawing.Point(760, 4)
        Me.botFaturarNotaFiscal.Name = "botFaturarNotaFiscal"
        Me.botFaturarNotaFiscal.Size = New System.Drawing.Size(40, 40)
        Me.botFaturarNotaFiscal.TabIndex = 64
        Me.botFaturarNotaFiscal.UseVisualStyleBackColor = True
        '
        'chkEntreDatas
        '
        Me.chkEntreDatas.AutoSize = True
        Me.chkEntreDatas.Font = New System.Drawing.Font("Century Gothic", 9.5!)
        Me.chkEntreDatas.Location = New System.Drawing.Point(470, 125)
        Me.chkEntreDatas.Name = "chkEntreDatas"
        Me.chkEntreDatas.Size = New System.Drawing.Size(100, 21)
        Me.chkEntreDatas.TabIndex = 66
        Me.chkEntreDatas.Text = "Entre datas"
        Me.chkEntreDatas.UseVisualStyleBackColor = True
        '
        'mskDataInicial
        '
        Me.mskDataInicial.Location = New System.Drawing.Point(312, 126)
        Me.mskDataInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.mskDataInicial.Mask = "00/00/0000"
        Me.mskDataInicial.Name = "mskDataInicial"
        Me.mskDataInicial.Size = New System.Drawing.Size(150, 20)
        Me.mskDataInicial.TabIndex = 68
        Me.mskDataInicial.ValidatingType = GetType(Date)
        '
        'mskDataFinal
        '
        Me.mskDataFinal.Location = New System.Drawing.Point(575, 126)
        Me.mskDataFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.mskDataFinal.Mask = "00/00/0000"
        Me.mskDataFinal.Name = "mskDataFinal"
        Me.mskDataFinal.Size = New System.Drawing.Size(150, 20)
        Me.mskDataFinal.TabIndex = 69
        Me.mskDataFinal.ValidatingType = GetType(Date)
        '
        'NotasFiscais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(765, 603)
        Me.Controls.Add(Me.mskDataFinal)
        Me.Controls.Add(Me.mskDataInicial)
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
        Me.Name = "NotasFiscais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas Fiscais"
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
    Friend WithEvents mskDataInicial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskDataFinal As System.Windows.Forms.MaskedTextBox
End Class
