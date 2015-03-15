<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabUsuarios = New System.Windows.Forms.TabControl()
        Me.tabAlteracao = New System.Windows.Forms.TabPage()
        Me.chkAdministrador = New System.Windows.Forms.CheckBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.lblExcluir = New System.Windows.Forms.Label()
        Me.botAlterar = New System.Windows.Forms.Button()
        Me.botExcluir = New System.Windows.Forms.Button()
        Me.tabConsultaUsuarios = New System.Windows.Forms.TabPage()
        Me.lblConsultaUsuarios = New System.Windows.Forms.Label()
        Me.dtgConsultaUsuarios = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSenha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabUsuarios.SuspendLayout()
        Me.tabAlteracao.SuspendLayout()
        Me.tabConsultaUsuarios.SuspendLayout()
        CType(Me.dtgConsultaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabUsuarios
        '
        Me.tabUsuarios.Controls.Add(Me.tabAlteracao)
        Me.tabUsuarios.Controls.Add(Me.tabConsultaUsuarios)
        Me.tabUsuarios.Location = New System.Drawing.Point(12, 12)
        Me.tabUsuarios.Name = "tabUsuarios"
        Me.tabUsuarios.SelectedIndex = 0
        Me.tabUsuarios.Size = New System.Drawing.Size(500, 297)
        Me.tabUsuarios.TabIndex = 1
        '
        'tabAlteracao
        '
        Me.tabAlteracao.AutoScroll = True
        Me.tabAlteracao.Controls.Add(Me.chkAdministrador)
        Me.tabAlteracao.Controls.Add(Me.txtSenha)
        Me.tabAlteracao.Controls.Add(Me.txtNome)
        Me.tabAlteracao.Controls.Add(Me.lblNome)
        Me.tabAlteracao.Controls.Add(Me.lblSenha)
        Me.tabAlteracao.Controls.Add(Me.lblAlterar)
        Me.tabAlteracao.Controls.Add(Me.lblExcluir)
        Me.tabAlteracao.Controls.Add(Me.botAlterar)
        Me.tabAlteracao.Controls.Add(Me.botExcluir)
        Me.tabAlteracao.Location = New System.Drawing.Point(4, 22)
        Me.tabAlteracao.Name = "tabAlteracao"
        Me.tabAlteracao.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAlteracao.Size = New System.Drawing.Size(492, 271)
        Me.tabAlteracao.TabIndex = 1
        Me.tabAlteracao.Text = "Alteração"
        Me.tabAlteracao.UseVisualStyleBackColor = True
        '
        'chkAdministrador
        '
        Me.chkAdministrador.AutoSize = True
        Me.chkAdministrador.Location = New System.Drawing.Point(163, 176)
        Me.chkAdministrador.Name = "chkAdministrador"
        Me.chkAdministrador.Size = New System.Drawing.Size(89, 17)
        Me.chkAdministrador.TabIndex = 67
        Me.chkAdministrador.Text = "Administrador"
        Me.chkAdministrador.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(8, 176)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(131, 20)
        Me.txtSenha.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(6, 122)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(353, 20)
        Me.txtNome.TabIndex = 1
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(4, 99)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(51, 20)
        Me.lblNome.TabIndex = 28
        Me.lblNome.Text = "Nome"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.Location = New System.Drawing.Point(6, 153)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(56, 20)
        Me.lblSenha.TabIndex = 39
        Me.lblSenha.Text = "Senha"
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Enabled = False
        Me.lblAlterar.Location = New System.Drawing.Point(7, 64)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(79, 13)
        Me.lblAlterar.TabIndex = 60
        Me.lblAlterar.Text = "Alterar Registro"
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Enabled = False
        Me.lblExcluir.Location = New System.Drawing.Point(95, 64)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(80, 13)
        Me.lblExcluir.TabIndex = 58
        Me.lblExcluir.Text = "Excluir Registro"
        '
        'botAlterar
        '
        Me.botAlterar.Enabled = False
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(21, 21)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(40, 40)
        Me.botAlterar.TabIndex = 6
        Me.botAlterar.UseVisualStyleBackColor = True
        '
        'botExcluir
        '
        Me.botExcluir.Enabled = False
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(112, 21)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(40, 40)
        Me.botExcluir.TabIndex = 7
        Me.botExcluir.UseVisualStyleBackColor = True
        '
        'tabConsultaUsuarios
        '
        Me.tabConsultaUsuarios.AutoScroll = True
        Me.tabConsultaUsuarios.Controls.Add(Me.lblConsultaUsuarios)
        Me.tabConsultaUsuarios.Controls.Add(Me.dtgConsultaUsuarios)
        Me.tabConsultaUsuarios.Location = New System.Drawing.Point(4, 22)
        Me.tabConsultaUsuarios.Name = "tabConsultaUsuarios"
        Me.tabConsultaUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsultaUsuarios.Size = New System.Drawing.Size(492, 271)
        Me.tabConsultaUsuarios.TabIndex = 2
        Me.tabConsultaUsuarios.Text = "Consulta"
        Me.tabConsultaUsuarios.UseVisualStyleBackColor = True
        '
        'lblConsultaUsuarios
        '
        Me.lblConsultaUsuarios.AutoSize = True
        Me.lblConsultaUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultaUsuarios.Location = New System.Drawing.Point(6, 3)
        Me.lblConsultaUsuarios.Name = "lblConsultaUsuarios"
        Me.lblConsultaUsuarios.Size = New System.Drawing.Size(161, 20)
        Me.lblConsultaUsuarios.TabIndex = 2
        Me.lblConsultaUsuarios.Text = "Consulta de Usuários"
        '
        'dtgConsultaUsuarios
        '
        Me.dtgConsultaUsuarios.AllowUserToAddRows = False
        Me.dtgConsultaUsuarios.AllowUserToDeleteRows = False
        Me.dtgConsultaUsuarios.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dtgConsultaUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgConsultaUsuarios.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgConsultaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgConsultaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsultaUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colUsuario, Me.colSenha})
        Me.dtgConsultaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgConsultaUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgConsultaUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgConsultaUsuarios.Location = New System.Drawing.Point(6, 39)
        Me.dtgConsultaUsuarios.MultiSelect = False
        Me.dtgConsultaUsuarios.Name = "dtgConsultaUsuarios"
        Me.dtgConsultaUsuarios.ReadOnly = True
        Me.dtgConsultaUsuarios.Size = New System.Drawing.Size(480, 213)
        Me.dtgConsultaUsuarios.TabIndex = 0
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Visible = False
        '
        'colUsuario
        '
        Me.colUsuario.FillWeight = 200.0!
        Me.colUsuario.HeaderText = "Usuário"
        Me.colUsuario.MinimumWidth = 200
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.ReadOnly = True
        Me.colUsuario.Width = 200
        '
        'colSenha
        '
        Me.colSenha.FillWeight = 150.0!
        Me.colSenha.HeaderText = "Senha"
        Me.colSenha.MinimumWidth = 150
        Me.colSenha.Name = "colSenha"
        Me.colSenha.ReadOnly = True
        Me.colSenha.Width = 150
        '
        'ConsultaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 327)
        Me.Controls.Add(Me.tabUsuarios)
        Me.Name = "ConsultaUsuarios"
        Me.Text = "ConsultaUsuarios"
        Me.tabUsuarios.ResumeLayout(False)
        Me.tabAlteracao.ResumeLayout(False)
        Me.tabAlteracao.PerformLayout()
        Me.tabConsultaUsuarios.ResumeLayout(False)
        Me.tabConsultaUsuarios.PerformLayout()
        CType(Me.dtgConsultaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabUsuarios As System.Windows.Forms.TabControl
    Friend WithEvents tabAlteracao As System.Windows.Forms.TabPage
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents lblAlterar As System.Windows.Forms.Label
    Friend WithEvents lblExcluir As System.Windows.Forms.Label
    Friend WithEvents botAlterar As System.Windows.Forms.Button
    Friend WithEvents botExcluir As System.Windows.Forms.Button
    Friend WithEvents tabConsultaUsuarios As System.Windows.Forms.TabPage
    Friend WithEvents lblConsultaUsuarios As System.Windows.Forms.Label
    Friend WithEvents dtgConsultaUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents chkAdministrador As System.Windows.Forms.CheckBox
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSenha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
