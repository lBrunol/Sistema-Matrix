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
        Me.relatorio = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bancoDataSet = New Sistema_Matrix.bancoDataSet()
        Me.relOrdensServicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.relOrdensServicoTableAdapter = New Sistema_Matrix.bancoDataSetTableAdapters.relOrdensServicoTableAdapter()
        CType(Me.bancoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relOrdensServicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'relatorio
        '
        Me.relatorio.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.relOrdensServicoBindingSource
        Me.relatorio.LocalReport.DataSources.Add(ReportDataSource1)
        Me.relatorio.LocalReport.ReportEmbeddedResource = "Sistema_Matrix.Report3.rdlc"
        Me.relatorio.Location = New System.Drawing.Point(0, 0)
        Me.relatorio.Name = "relatorio"
        Me.relatorio.Size = New System.Drawing.Size(925, 494)
        Me.relatorio.TabIndex = 0
        '
        'bancoDataSet
        '
        Me.bancoDataSet.DataSetName = "bancoDataSet"
        Me.bancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'relOrdensServicoBindingSource
        '
        Me.relOrdensServicoBindingSource.DataMember = "relOrdensServico"
        Me.relOrdensServicoBindingSource.DataSource = Me.bancoDataSet
        '
        'relOrdensServicoTableAdapter
        '
        Me.relOrdensServicoTableAdapter.ClearBeforeFill = True
        '
        'relOrdensServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 494)
        Me.Controls.Add(Me.relatorio)
        Me.Name = "relOrdensServico"
        Me.Text = "relOrdensServico"
        CType(Me.bancoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relOrdensServicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents relatorio As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents relOrdensServicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bancoDataSet As Sistema_Matrix.bancoDataSet
    Friend WithEvents relOrdensServicoTableAdapter As Sistema_Matrix.bancoDataSetTableAdapters.relOrdensServicoTableAdapter
End Class
