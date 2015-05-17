<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relOrdensServico
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relOrdensServico))
        Me.relOrdensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bancoMatrixDataSet = New Sistema_Matrix.bancoMatrixDataSet()
        Me.relatorio = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.relOrdensTableAdapter = New Sistema_Matrix.bancoMatrixDataSetTableAdapters.relOrdensTableAdapter()
        CType(Me.relOrdensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bancoMatrixDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'relOrdensBindingSource
        '
        Me.relOrdensBindingSource.DataMember = "relOrdens"
        Me.relOrdensBindingSource.DataSource = Me.bancoMatrixDataSet
        '
        'bancoMatrixDataSet
        '
        Me.bancoMatrixDataSet.DataSetName = "bancoMatrixDataSet"
        Me.bancoMatrixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'relatorio
        '
        Me.relatorio.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "relOrdens"
        ReportDataSource1.Value = Me.relOrdensBindingSource
        Me.relatorio.LocalReport.DataSources.Add(ReportDataSource1)
        Me.relatorio.LocalReport.ReportEmbeddedResource = "Sistema_Matrix.rltOrdensServico.rdlc"
        Me.relatorio.Location = New System.Drawing.Point(0, 0)
        Me.relatorio.Name = "relatorio"
        Me.relatorio.Size = New System.Drawing.Size(1008, 684)
        Me.relatorio.TabIndex = 0
        '
        'relOrdensTableAdapter
        '
        Me.relOrdensTableAdapter.ClearBeforeFill = True
        '
        'relOrdensServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 684)
        Me.Controls.Add(Me.relatorio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "relOrdensServico"
        Me.Text = "Relatório de Ordens de Serviço"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.relOrdensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bancoMatrixDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents relatorio As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents relOrdensBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bancoMatrixDataSet As Sistema_Matrix.bancoMatrixDataSet
    Friend WithEvents relOrdensTableAdapter As Sistema_Matrix.bancoMatrixDataSetTableAdapters.relOrdensTableAdapter
End Class
