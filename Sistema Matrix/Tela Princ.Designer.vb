<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class telaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(telaPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuCadastroCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastroFornecedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdemDeServiçoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdministrador = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuGerenciaUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCadastroUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAlteracaoUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSobre = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.botCadastro = New System.Windows.Forms.Button()
        Me.botServicos = New System.Windows.Forms.Button()
        Me.botFuncionario = New System.Windows.Forms.Button()
        Me.botOS = New System.Windows.Forms.Button()
        Me.botConsultaContasReceber = New System.Windows.Forms.Button()
        Me.botConsultaNotasFiscais = New System.Windows.Forms.Button()
        Me.botDadosEmitente = New System.Windows.Forms.Button()
        Me.botConfirmaNotasFiscais = New System.Windows.Forms.Button()
        Me.txtBoasVindas = New System.Windows.Forms.TextBox()
        Me.lblLogoff = New System.Windows.Forms.Label()
        Me.botLogoff = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastroCliente, Me.FaturamentoToolStripMenuItem, Me.menuAdministrador, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuCadastroCliente
        '
        Me.menuCadastroCliente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeClientesToolStripMenuItem, Me.menuCadastroFornecedor, Me.ServiçosToolStripMenuItem, Me.menuSair})
        Me.menuCadastroCliente.Name = "menuCadastroCliente"
        Me.menuCadastroCliente.Size = New System.Drawing.Size(46, 20)
        Me.menuCadastroCliente.Text = "Geral"
        '
        'CadastroDeClientesToolStripMenuItem
        '
        Me.CadastroDeClientesToolStripMenuItem.Name = "CadastroDeClientesToolStripMenuItem"
        Me.CadastroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CadastroDeClientesToolStripMenuItem.Text = "Clientes"
        '
        'menuCadastroFornecedor
        '
        Me.menuCadastroFornecedor.Name = "menuCadastroFornecedor"
        Me.menuCadastroFornecedor.Size = New System.Drawing.Size(142, 22)
        Me.menuCadastroFornecedor.Text = "Funcionários"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'menuSair
        '
        Me.menuSair.Name = "menuSair"
        Me.menuSair.Size = New System.Drawing.Size(142, 22)
        Me.menuSair.Text = "Sair"
        '
        'FaturamentoToolStripMenuItem
        '
        Me.FaturamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdemDeServiçoToolStripMenuItem})
        Me.FaturamentoToolStripMenuItem.Name = "FaturamentoToolStripMenuItem"
        Me.FaturamentoToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.FaturamentoToolStripMenuItem.Text = "Ordem de Serviço"
        '
        'OrdemDeServiçoToolStripMenuItem
        '
        Me.OrdemDeServiçoToolStripMenuItem.Name = "OrdemDeServiçoToolStripMenuItem"
        Me.OrdemDeServiçoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OrdemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço"
        '
        'menuAdministrador
        '
        Me.menuAdministrador.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuGerenciaUsuario})
        Me.menuAdministrador.Name = "menuAdministrador"
        Me.menuAdministrador.Size = New System.Drawing.Size(95, 20)
        Me.menuAdministrador.Text = "Administrador"
        '
        'menuGerenciaUsuario
        '
        Me.menuGerenciaUsuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCadastroUsuario, Me.menuAlteracaoUsuario})
        Me.menuGerenciaUsuario.Name = "menuGerenciaUsuario"
        Me.menuGerenciaUsuario.Size = New System.Drawing.Size(184, 22)
        Me.menuGerenciaUsuario.Text = "Gerencia de Usuários"
        '
        'menuCadastroUsuario
        '
        Me.menuCadastroUsuario.Name = "menuCadastroUsuario"
        Me.menuCadastroUsuario.Size = New System.Drawing.Size(124, 22)
        Me.menuCadastroUsuario.Text = "Cadastro"
        '
        'menuAlteracaoUsuario
        '
        Me.menuAlteracaoUsuario.Name = "menuAlteracaoUsuario"
        Me.menuAlteracaoUsuario.Size = New System.Drawing.Size(124, 22)
        Me.menuAlteracaoUsuario.Text = "Alteração"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSobre})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'menuSobre
        '
        Me.menuSobre.Name = "menuSobre"
        Me.menuSobre.Size = New System.Drawing.Size(158, 22)
        Me.menuSobre.Text = "Sobre o Sistema"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.botCadastro)
        Me.FlowLayoutPanel1.Controls.Add(Me.botServicos)
        Me.FlowLayoutPanel1.Controls.Add(Me.botFuncionario)
        Me.FlowLayoutPanel1.Controls.Add(Me.botOS)
        Me.FlowLayoutPanel1.Controls.Add(Me.botConsultaContasReceber)
        Me.FlowLayoutPanel1.Controls.Add(Me.botConsultaNotasFiscais)
        Me.FlowLayoutPanel1.Controls.Add(Me.botDadosEmitente)
        Me.FlowLayoutPanel1.Controls.Add(Me.botConfirmaNotasFiscais)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 35)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(673, 493)
        Me.FlowLayoutPanel1.TabIndex = 1
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
        Me.botCadastro.Location = New System.Drawing.Point(3, 3)
        Me.botCadastro.Name = "botCadastro"
        Me.botCadastro.Size = New System.Drawing.Size(215, 156)
        Me.botCadastro.TabIndex = 0
        Me.botCadastro.Text = "Cadastro de Cliente"
        Me.botCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botCadastro.UseVisualStyleBackColor = False
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
        Me.botServicos.Location = New System.Drawing.Point(224, 3)
        Me.botServicos.Name = "botServicos"
        Me.botServicos.Size = New System.Drawing.Size(215, 156)
        Me.botServicos.TabIndex = 1
        Me.botServicos.Text = "Cadastro de Serviços"
        Me.botServicos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botServicos.UseVisualStyleBackColor = False
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
        Me.botFuncionario.Location = New System.Drawing.Point(445, 3)
        Me.botFuncionario.Name = "botFuncionario"
        Me.botFuncionario.Size = New System.Drawing.Size(215, 156)
        Me.botFuncionario.TabIndex = 2
        Me.botFuncionario.Text = "Cadastro de Funcionário"
        Me.botFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botFuncionario.UseVisualStyleBackColor = False
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
        Me.botOS.Location = New System.Drawing.Point(3, 165)
        Me.botOS.Name = "botOS"
        Me.botOS.Size = New System.Drawing.Size(215, 156)
        Me.botOS.TabIndex = 3
        Me.botOS.Text = "Cadastro de Ordem de Serviço"
        Me.botOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botOS.UseVisualStyleBackColor = False
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
        Me.botConsultaContasReceber.Location = New System.Drawing.Point(224, 165)
        Me.botConsultaContasReceber.Name = "botConsultaContasReceber"
        Me.botConsultaContasReceber.Size = New System.Drawing.Size(215, 156)
        Me.botConsultaContasReceber.TabIndex = 4
        Me.botConsultaContasReceber.Text = "Consulta de Contas a Receber"
        Me.botConsultaContasReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botConsultaContasReceber.UseVisualStyleBackColor = False
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
        Me.botConsultaNotasFiscais.Location = New System.Drawing.Point(445, 165)
        Me.botConsultaNotasFiscais.Name = "botConsultaNotasFiscais"
        Me.botConsultaNotasFiscais.Size = New System.Drawing.Size(215, 156)
        Me.botConsultaNotasFiscais.TabIndex = 5
        Me.botConsultaNotasFiscais.Text = "Consulta de Notas Fiscais"
        Me.botConsultaNotasFiscais.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botConsultaNotasFiscais.UseVisualStyleBackColor = False
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
        Me.botDadosEmitente.Location = New System.Drawing.Point(3, 327)
        Me.botDadosEmitente.Name = "botDadosEmitente"
        Me.botDadosEmitente.Size = New System.Drawing.Size(215, 156)
        Me.botDadosEmitente.TabIndex = 6
        Me.botDadosEmitente.Text = "Cadastro do Emitente"
        Me.botDadosEmitente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botDadosEmitente.UseVisualStyleBackColor = False
        '
        'botConfirmaNotasFiscais
        '
        Me.botConfirmaNotasFiscais.BackColor = System.Drawing.Color.LightGreen
        Me.botConfirmaNotasFiscais.BackgroundImage = CType(resources.GetObject("botConfirmaNotasFiscais.BackgroundImage"), System.Drawing.Image)
        Me.botConfirmaNotasFiscais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.botConfirmaNotasFiscais.FlatAppearance.BorderSize = 0
        Me.botConfirmaNotasFiscais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botConfirmaNotasFiscais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botConfirmaNotasFiscais.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.botConfirmaNotasFiscais.Location = New System.Drawing.Point(224, 327)
        Me.botConfirmaNotasFiscais.Name = "botConfirmaNotasFiscais"
        Me.botConfirmaNotasFiscais.Size = New System.Drawing.Size(215, 156)
        Me.botConfirmaNotasFiscais.TabIndex = 7
        Me.botConfirmaNotasFiscais.Text = "Confirma Dados Notas Fiscais"
        Me.botConfirmaNotasFiscais.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botConfirmaNotasFiscais.UseVisualStyleBackColor = False
        '
        'txtBoasVindas
        '
        Me.txtBoasVindas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtBoasVindas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoasVindas.Enabled = False
        Me.txtBoasVindas.Location = New System.Drawing.Point(355, 617)
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
        Me.lblLogoff.BackColor = System.Drawing.Color.White
        Me.lblLogoff.Location = New System.Drawing.Point(613, 8)
        Me.lblLogoff.Name = "lblLogoff"
        Me.lblLogoff.Size = New System.Drawing.Size(37, 13)
        Me.lblLogoff.TabIndex = 4
        Me.lblLogoff.Text = "Logoff"
        '
        'botLogoff
        '
        Me.botLogoff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botLogoff.AutoSize = True
        Me.botLogoff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.botLogoff.Image = Global.Sistema_Matrix.My.Resources.Resources.logoff
        Me.botLogoff.Location = New System.Drawing.Point(653, 2)
        Me.botLogoff.Margin = New System.Windows.Forms.Padding(0)
        Me.botLogoff.MaximumSize = New System.Drawing.Size(32, 25)
        Me.botLogoff.Name = "botLogoff"
        Me.botLogoff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botLogoff.Size = New System.Drawing.Size(32, 25)
        Me.botLogoff.TabIndex = 3
        Me.botLogoff.TabStop = False
        Me.botLogoff.UseVisualStyleBackColor = True
        '
        'telaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(697, 540)
        Me.Controls.Add(Me.lblLogoff)
        Me.Controls.Add(Me.botLogoff)
        Me.Controls.Add(Me.txtBoasVindas)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "telaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matrix Systems - ME"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuCadastroCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCadastroFornecedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FaturamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdemDeServiçoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSobre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents botCadastro As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents botServicos As System.Windows.Forms.Button
    Friend WithEvents botFuncionario As System.Windows.Forms.Button
    Friend WithEvents botOS As System.Windows.Forms.Button
    Friend WithEvents menuAdministrador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuGerenciaUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtBoasVindas As System.Windows.Forms.TextBox
    Friend WithEvents botLogoff As System.Windows.Forms.Button
    Friend WithEvents lblLogoff As System.Windows.Forms.Label
    Friend WithEvents menuCadastroUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAlteracaoUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents botConsultaContasReceber As System.Windows.Forms.Button
    Friend WithEvents botConsultaNotasFiscais As System.Windows.Forms.Button
    Friend WithEvents botDadosEmitente As System.Windows.Forms.Button
    Friend WithEvents botConfirmaNotasFiscais As System.Windows.Forms.Button
End Class
