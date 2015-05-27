<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlteraçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriaçãoDeUsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBoasVindas = New System.Windows.Forms.TextBox()
        Me.lblLogoff = New System.Windows.Forms.Label()
        Me.lblAjuda = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botBackupeRestauracao = New System.Windows.Forms.Button()
        Me.botCadastro = New System.Windows.Forms.Button()
        Me.botOS = New System.Windows.Forms.Button()
        Me.botServicos = New System.Windows.Forms.Button()
        Me.botAjuda = New System.Windows.Forms.Button()
        Me.botFuncionario = New System.Windows.Forms.Button()
        Me.botConsultaContasReceber = New System.Windows.Forms.Button()
        Me.botDadosEmitente = New System.Windows.Forms.Button()
        Me.botLogoff = New System.Windows.Forms.Button()
        Me.botConsultaNotasFiscais = New System.Windows.Forms.Button()
        Me.botRelatorio = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menUsuarios})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(573, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menUsuarios
        '
        Me.menUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlteraçãoToolStripMenuItem, Me.CriaçãoDeUsuáriosToolStripMenuItem})
        Me.menUsuarios.Name = "menUsuarios"
        Me.menUsuarios.Size = New System.Drawing.Size(64, 20)
        Me.menUsuarios.Text = "Usuários"
        Me.menUsuarios.Visible = False
        '
        'AlteraçãoToolStripMenuItem
        '
        Me.AlteraçãoToolStripMenuItem.Name = "AlteraçãoToolStripMenuItem"
        Me.AlteraçãoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AlteraçãoToolStripMenuItem.Text = "Alteração de Usuários"
        '
        'CriaçãoDeUsuáriosToolStripMenuItem
        '
        Me.CriaçãoDeUsuáriosToolStripMenuItem.Name = "CriaçãoDeUsuáriosToolStripMenuItem"
        Me.CriaçãoDeUsuáriosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CriaçãoDeUsuáriosToolStripMenuItem.Text = "Criação de Usuários"
        '
        'txtBoasVindas
        '
        Me.txtBoasVindas.BackColor = System.Drawing.SystemColors.Window
        Me.txtBoasVindas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoasVindas.Enabled = False
        Me.txtBoasVindas.Location = New System.Drawing.Point(421, 595)
        Me.txtBoasVindas.Multiline = True
        Me.txtBoasVindas.Name = "txtBoasVindas"
        Me.txtBoasVindas.Size = New System.Drawing.Size(142, 20)
        Me.txtBoasVindas.TabIndex = 2
        Me.txtBoasVindas.TabStop = False
        Me.txtBoasVindas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLogoff
        '
        Me.lblLogoff.AutoSize = True
        Me.lblLogoff.BackColor = System.Drawing.SystemColors.Window
        Me.lblLogoff.Location = New System.Drawing.Point(470, 8)
        Me.lblLogoff.Name = "lblLogoff"
        Me.lblLogoff.Size = New System.Drawing.Size(37, 13)
        Me.lblLogoff.TabIndex = 4
        Me.lblLogoff.Text = "Logoff"
        '
        'lblAjuda
        '
        Me.lblAjuda.AutoSize = True
        Me.lblAjuda.BackColor = System.Drawing.SystemColors.Window
        Me.lblAjuda.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjuda.Location = New System.Drawing.Point(384, 6)
        Me.lblAjuda.Name = "lblAjuda"
        Me.lblAjuda.Size = New System.Drawing.Size(43, 17)
        Me.lblAjuda.TabIndex = 6
        Me.lblAjuda.Text = "Ajuda"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 386)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(85, 21)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "Relatórios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Gerenciamento"
        '
        'botBackupeRestauracao
        '
        Me.botBackupeRestauracao.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botBackupeRestauracao.BackgroundImage = CType(resources.GetObject("botBackupeRestauracao.BackgroundImage"), System.Drawing.Image)
        Me.botBackupeRestauracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botBackupeRestauracao.FlatAppearance.BorderSize = 0
        Me.botBackupeRestauracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botBackupeRestauracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botBackupeRestauracao.ForeColor = System.Drawing.Color.White
        Me.botBackupeRestauracao.Location = New System.Drawing.Point(456, 305)
        Me.botBackupeRestauracao.Name = "botBackupeRestauracao"
        Me.botBackupeRestauracao.Size = New System.Drawing.Size(107, 74)
        Me.botBackupeRestauracao.TabIndex = 15
        Me.botBackupeRestauracao.Text = "Backup e Restauração"
        Me.botBackupeRestauracao.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botBackupeRestauracao.UseVisualStyleBackColor = False
        '
        'botCadastro
        '
        Me.botCadastro.BackColor = System.Drawing.Color.Maroon
        Me.botCadastro.BackgroundImage = CType(resources.GetObject("botCadastro.BackgroundImage"), System.Drawing.Image)
        Me.botCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botCadastro.FlatAppearance.BorderSize = 0
        Me.botCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botCadastro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.botCadastro.Location = New System.Drawing.Point(12, 61)
        Me.botCadastro.Name = "botCadastro"
        Me.botCadastro.Size = New System.Drawing.Size(215, 156)
        Me.botCadastro.TabIndex = 0
        Me.botCadastro.Text = "Cliente"
        Me.botCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botCadastro.UseVisualStyleBackColor = False
        '
        'botOS
        '
        Me.botOS.BackColor = System.Drawing.Color.LightBlue
        Me.botOS.BackgroundImage = Global.Sistema_Matrix.My.Resources.Resources.os
        Me.botOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botOS.FlatAppearance.BorderSize = 0
        Me.botOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botOS.ForeColor = System.Drawing.Color.White
        Me.botOS.Location = New System.Drawing.Point(348, 61)
        Me.botOS.Name = "botOS"
        Me.botOS.Size = New System.Drawing.Size(215, 156)
        Me.botOS.TabIndex = 3
        Me.botOS.Text = "Ordem de Serviço"
        Me.botOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botOS.UseVisualStyleBackColor = False
        '
        'botServicos
        '
        Me.botServicos.BackColor = System.Drawing.Color.DodgerBlue
        Me.botServicos.BackgroundImage = Global.Sistema_Matrix.My.Resources.Resources.servicos
        Me.botServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botServicos.FlatAppearance.BorderSize = 0
        Me.botServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botServicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botServicos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.botServicos.Location = New System.Drawing.Point(233, 143)
        Me.botServicos.Name = "botServicos"
        Me.botServicos.Size = New System.Drawing.Size(107, 74)
        Me.botServicos.TabIndex = 1
        Me.botServicos.Text = "Serviços"
        Me.botServicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botServicos.UseVisualStyleBackColor = False
        '
        'botAjuda
        '
        Me.botAjuda.BackgroundImage = Global.Sistema_Matrix.My.Resources.Resources.botao_ajuda
        Me.botAjuda.Location = New System.Drawing.Point(433, -2)
        Me.botAjuda.Name = "botAjuda"
        Me.botAjuda.Size = New System.Drawing.Size(31, 32)
        Me.botAjuda.TabIndex = 7
        '
        'botFuncionario
        '
        Me.botFuncionario.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.botFuncionario.BackgroundImage = CType(resources.GetObject("botFuncionario.BackgroundImage"), System.Drawing.Image)
        Me.botFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botFuncionario.FlatAppearance.BorderSize = 0
        Me.botFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.botFuncionario.Location = New System.Drawing.Point(233, 61)
        Me.botFuncionario.Name = "botFuncionario"
        Me.botFuncionario.Size = New System.Drawing.Size(107, 74)
        Me.botFuncionario.TabIndex = 2
        Me.botFuncionario.Text = "Funcionário"
        Me.botFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botFuncionario.UseVisualStyleBackColor = False
        '
        'botConsultaContasReceber
        '
        Me.botConsultaContasReceber.BackColor = System.Drawing.Color.DarkGreen
        Me.botConsultaContasReceber.BackgroundImage = CType(resources.GetObject("botConsultaContasReceber.BackgroundImage"), System.Drawing.Image)
        Me.botConsultaContasReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botConsultaContasReceber.FlatAppearance.BorderSize = 0
        Me.botConsultaContasReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botConsultaContasReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botConsultaContasReceber.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.botConsultaContasReceber.Location = New System.Drawing.Point(12, 223)
        Me.botConsultaContasReceber.Name = "botConsultaContasReceber"
        Me.botConsultaContasReceber.Size = New System.Drawing.Size(215, 156)
        Me.botConsultaContasReceber.TabIndex = 4
        Me.botConsultaContasReceber.Text = "Contas a Receber"
        Me.botConsultaContasReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botConsultaContasReceber.UseVisualStyleBackColor = False
        '
        'botDadosEmitente
        '
        Me.botDadosEmitente.BackColor = System.Drawing.Color.DarkSlateGray
        Me.botDadosEmitente.BackgroundImage = CType(resources.GetObject("botDadosEmitente.BackgroundImage"), System.Drawing.Image)
        Me.botDadosEmitente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botDadosEmitente.FlatAppearance.BorderSize = 0
        Me.botDadosEmitente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botDadosEmitente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botDadosEmitente.ForeColor = System.Drawing.Color.White
        Me.botDadosEmitente.Location = New System.Drawing.Point(456, 223)
        Me.botDadosEmitente.Name = "botDadosEmitente"
        Me.botDadosEmitente.Size = New System.Drawing.Size(107, 74)
        Me.botDadosEmitente.TabIndex = 6
        Me.botDadosEmitente.Text = "Emitente"
        Me.botDadosEmitente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botDadosEmitente.UseVisualStyleBackColor = False
        '
        'botLogoff
        '
        Me.botLogoff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botLogoff.AutoSize = True
        Me.botLogoff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.botLogoff.Image = Global.Sistema_Matrix.My.Resources.Resources.logoff
        Me.botLogoff.Location = New System.Drawing.Point(510, 2)
        Me.botLogoff.Margin = New System.Windows.Forms.Padding(0)
        Me.botLogoff.MaximumSize = New System.Drawing.Size(32, 25)
        Me.botLogoff.Name = "botLogoff"
        Me.botLogoff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botLogoff.Size = New System.Drawing.Size(32, 25)
        Me.botLogoff.TabIndex = 3
        Me.botLogoff.TabStop = False
        Me.botLogoff.UseVisualStyleBackColor = True
        '
        'botConsultaNotasFiscais
        '
        Me.botConsultaNotasFiscais.BackColor = System.Drawing.Color.Gainsboro
        Me.botConsultaNotasFiscais.BackgroundImage = CType(resources.GetObject("botConsultaNotasFiscais.BackgroundImage"), System.Drawing.Image)
        Me.botConsultaNotasFiscais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botConsultaNotasFiscais.FlatAppearance.BorderSize = 0
        Me.botConsultaNotasFiscais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botConsultaNotasFiscais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botConsultaNotasFiscais.ForeColor = System.Drawing.Color.White
        Me.botConsultaNotasFiscais.Location = New System.Drawing.Point(233, 223)
        Me.botConsultaNotasFiscais.Name = "botConsultaNotasFiscais"
        Me.botConsultaNotasFiscais.Size = New System.Drawing.Size(215, 156)
        Me.botConsultaNotasFiscais.TabIndex = 5
        Me.botConsultaNotasFiscais.Text = "Notas Fiscais"
        Me.botConsultaNotasFiscais.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botConsultaNotasFiscais.UseVisualStyleBackColor = False
        '
        'botRelatorio
        '
        Me.botRelatorio.BackColor = System.Drawing.Color.Orange
        Me.botRelatorio.BackgroundImage = CType(resources.GetObject("botRelatorio.BackgroundImage"), System.Drawing.Image)
        Me.botRelatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botRelatorio.FlatAppearance.BorderSize = 0
        Me.botRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRelatorio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.botRelatorio.Location = New System.Drawing.Point(233, 410)
        Me.botRelatorio.Name = "botRelatorio"
        Me.botRelatorio.Size = New System.Drawing.Size(215, 156)
        Me.botRelatorio.TabIndex = 8
        Me.botRelatorio.Text = "Relatório de Ordem de Serviço"
        Me.botRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botRelatorio.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(12, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 156)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Relatório de Contas a Receber"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(573, 625)
        Me.Controls.Add(Me.botBackupeRestauracao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.botCadastro)
        Me.Controls.Add(Me.lblAjuda)
        Me.Controls.Add(Me.botOS)
        Me.Controls.Add(Me.botServicos)
        Me.Controls.Add(Me.botAjuda)
        Me.Controls.Add(Me.botFuncionario)
        Me.Controls.Add(Me.botConsultaContasReceber)
        Me.Controls.Add(Me.lblLogoff)
        Me.Controls.Add(Me.botDadosEmitente)
        Me.Controls.Add(Me.botLogoff)
        Me.Controls.Add(Me.txtBoasVindas)
        Me.Controls.Add(Me.botConsultaNotasFiscais)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.botRelatorio)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal - Matrix OS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents txtBoasVindas As System.Windows.Forms.TextBox
    Friend WithEvents botLogoff As System.Windows.Forms.Button
    Friend WithEvents lblLogoff As System.Windows.Forms.Label
    Friend WithEvents botAjuda As System.Windows.Forms.Button
    Friend WithEvents lblAjuda As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents botRelatorio As System.Windows.Forms.Button
    Friend WithEvents botDadosEmitente As System.Windows.Forms.Button
    Friend WithEvents botConsultaNotasFiscais As System.Windows.Forms.Button
    Friend WithEvents botConsultaContasReceber As System.Windows.Forms.Button
    Friend WithEvents botOS As System.Windows.Forms.Button
    Friend WithEvents botFuncionario As System.Windows.Forms.Button
    Friend WithEvents botServicos As System.Windows.Forms.Button
    Friend WithEvents botCadastro As System.Windows.Forms.Button
    Friend WithEvents menUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlteraçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriaçãoDeUsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents botBackupeRestauracao As System.Windows.Forms.Button
End Class
