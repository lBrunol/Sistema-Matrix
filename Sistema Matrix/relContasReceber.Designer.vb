<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relContasReceber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relContasReceber))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bancoMatrixDataSet = New Sistema_Matrix.bancoMatrixDataSet()
        Me.relContasReceberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.relContasReceberTableAdapter = New Sistema_Matrix.bancoMatrixDataSetTableAdapters.relContasReceberTableAdapter()
        CType(Me.bancoMatrixDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relContasReceberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "relContasReceber"
        ReportDataSource1.Value = Me.relContasReceberBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Matrix.rltContasReceber.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1008, 684)
        Me.ReportViewer1.TabIndex = 0
        '
        'bancoMatrixDataSet
        '
        Me.bancoMatrixDataSet.DataSetName = "bancoMatrixDataSet"
        Me.bancoMatrixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'relContasReceberBindingSource
        '
        Me.relContasReceberBindingSource.DataMember = "relContasReceber"
        Me.relContasReceberBindingSource.DataSource = Me.bancoMatrixDataSet
        '
        'relContasReceberTableAdapter
        '
        Me.relContasReceberTableAdapter.ClearBeforeFill = True
        '
        'relContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 684)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "relContasReceber"
        Me.Text = "Relatório de Contas a Receber"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bancoMatrixDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relContasReceberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents relContasReceberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bancoMatrixDataSet As Sistema_Matrix.bancoMatrixDataSet
    Friend WithEvents relContasReceberTableAdapter As Sistema_Matrix.bancoMatrixDataSetTableAdapters.relContasReceberTableAdapter
End Class
