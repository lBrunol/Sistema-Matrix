<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancaPagamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLancaPagamento))
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.lblDataVencimento = New System.Windows.Forms.Label()
        Me.lblDataPagamento = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblFaturarNotaFiscal = New System.Windows.Forms.Label()
        Me.botSalvar = New System.Windows.Forms.Button()
        Me.lblCancelar = New System.Windows.Forms.Label()
        Me.botCancelar = New System.Windows.Forms.Button()
        Me.mtxDataVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.mtxDataPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.lblValorPago = New System.Windows.Forms.Label()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(12, 155)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(127, 17)
        Me.lblNumeroDocumento.TabIndex = 10
        Me.lblNumeroDocumento.Text = "Nº do Documento"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Enabled = False
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(15, 173)
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(87, 23)
        Me.txtNumeroDocumento.TabIndex = 9
        '
        'lblDataVencimento
        '
        Me.lblDataVencimento.AutoSize = True
        Me.lblDataVencimento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblDataVencimento.Location = New System.Drawing.Point(12, 209)
        Me.lblDataVencimento.Name = "lblDataVencimento"
        Me.lblDataVencimento.Size = New System.Drawing.Size(145, 17)
        Me.lblDataVencimento.TabIndex = 12
        Me.lblDataVencimento.Text = "Data de Vencimento"
        '
        'lblDataPagamento
        '
        Me.lblDataPagamento.AutoSize = True
        Me.lblDataPagamento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblDataPagamento.Location = New System.Drawing.Point(12, 265)
        Me.lblDataPagamento.Name = "lblDataPagamento"
        Me.lblDataPagamento.Size = New System.Drawing.Size(144, 17)
        Me.lblDataPagamento.TabIndex = 14
        Me.lblDataPagamento.Text = "Data de Pagamento"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.Sistema_Matrix.My.Resources.Resources.lancar_pagamento_maior
        Me.PictureBox1.Location = New System.Drawing.Point(16, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(240, 21)
        Me.lblTitulo.TabIndex = 16
        Me.lblTitulo.Text = "Lançamento de Pagamentos"
        '
        'lblFaturarNotaFiscal
        '
        Me.lblFaturarNotaFiscal.AutoSize = True
        Me.lblFaturarNotaFiscal.Location = New System.Drawing.Point(160, 87)
        Me.lblFaturarNotaFiscal.Name = "lblFaturarNotaFiscal"
        Me.lblFaturarNotaFiscal.Size = New System.Drawing.Size(37, 13)
        Me.lblFaturarNotaFiscal.TabIndex = 67
        Me.lblFaturarNotaFiscal.Text = "Salvar"
        '
        'botSalvar
        '
        Me.botSalvar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botSalvar.Location = New System.Drawing.Point(157, 44)
        Me.botSalvar.Name = "botSalvar"
        Me.botSalvar.Size = New System.Drawing.Size(40, 40)
        Me.botSalvar.TabIndex = 3
        Me.botSalvar.UseVisualStyleBackColor = True
        '
        'lblCancelar
        '
        Me.lblCancelar.AutoSize = True
        Me.lblCancelar.Location = New System.Drawing.Point(229, 87)
        Me.lblCancelar.Name = "lblCancelar"
        Me.lblCancelar.Size = New System.Drawing.Size(49, 13)
        Me.lblCancelar.TabIndex = 65
        Me.lblCancelar.Text = "Cancelar"
        '
        'botCancelar
        '
        Me.botCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botCancelar.Image = CType(resources.GetObject("botCancelar.Image"), System.Drawing.Image)
        Me.botCancelar.Location = New System.Drawing.Point(231, 44)
        Me.botCancelar.Name = "botCancelar"
        Me.botCancelar.Size = New System.Drawing.Size(40, 40)
        Me.botCancelar.TabIndex = 4
        Me.botCancelar.UseVisualStyleBackColor = True
        '
        'mtxDataVencimento
        '
        Me.mtxDataVencimento.Enabled = False
        Me.mtxDataVencimento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.mtxDataVencimento.Location = New System.Drawing.Point(16, 230)
        Me.mtxDataVencimento.Mask = "00/00/0000"
        Me.mtxDataVencimento.Name = "mtxDataVencimento"
        Me.mtxDataVencimento.Size = New System.Drawing.Size(140, 23)
        Me.mtxDataVencimento.TabIndex = 68
        Me.mtxDataVencimento.ValidatingType = GetType(Date)
        '
        'mtxDataPagamento
        '
        Me.mtxDataPagamento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.mtxDataPagamento.Location = New System.Drawing.Point(15, 285)
        Me.mtxDataPagamento.Mask = "00/00/0000"
        Me.mtxDataPagamento.Name = "mtxDataPagamento"
        Me.mtxDataPagamento.Size = New System.Drawing.Size(142, 23)
        Me.mtxDataPagamento.TabIndex = 1
        Me.mtxDataPagamento.ValidatingType = GetType(Date)
        '
        'lblValorPago
        '
        Me.lblValorPago.AutoSize = True
        Me.lblValorPago.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblValorPago.Location = New System.Drawing.Point(13, 328)
        Me.lblValorPago.Name = "lblValorPago"
        Me.lblValorPago.Size = New System.Drawing.Size(81, 17)
        Me.lblValorPago.TabIndex = 70
        Me.lblValorPago.Text = "Valor Pago"
        '
        'txtValorPago
        '
        Me.txtValorPago.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtValorPago.Location = New System.Drawing.Point(15, 348)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(141, 23)
        Me.txtValorPago.TabIndex = 2
        '
        'frmLancaPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(284, 379)
        Me.Controls.Add(Me.txtValorPago)
        Me.Controls.Add(Me.lblValorPago)
        Me.Controls.Add(Me.mtxDataPagamento)
        Me.Controls.Add(Me.mtxDataVencimento)
        Me.Controls.Add(Me.lblFaturarNotaFiscal)
        Me.Controls.Add(Me.botSalvar)
        Me.Controls.Add(Me.lblCancelar)
        Me.Controls.Add(Me.botCancelar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDataPagamento)
        Me.Controls.Add(Me.lblDataVencimento)
        Me.Controls.Add(Me.lblNumeroDocumento)
        Me.Controls.Add(Me.txtNumeroDocumento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLancaPagamento"
        Me.Text = "Lançamento de Pagamentos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Friend WithEvents txtNumeroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents lblDataVencimento As System.Windows.Forms.Label
    Friend WithEvents lblDataPagamento As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblFaturarNotaFiscal As System.Windows.Forms.Label
    Friend WithEvents botSalvar As System.Windows.Forms.Button
    Friend WithEvents lblCancelar As System.Windows.Forms.Label
    Friend WithEvents botCancelar As System.Windows.Forms.Button
    Friend WithEvents mtxDataVencimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxDataPagamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblValorPago As System.Windows.Forms.Label
    Friend WithEvents txtValorPago As System.Windows.Forms.TextBox
End Class
