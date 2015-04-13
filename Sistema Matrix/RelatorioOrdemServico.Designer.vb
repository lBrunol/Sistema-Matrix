<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelatorioOrdemServico
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Q_ORDEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.oracle = New Sistema_Matrix.oracle()
        Me.relOrdemServico = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Q_ORDEMTableAdapter = New Sistema_Matrix.oracleTableAdapters.Q_ORDEMTableAdapter()
        CType(Me.Q_ORDEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Q_ORDEMBindingSource
        '
        Me.Q_ORDEMBindingSource.DataMember = "Q_ORDEM"
        Me.Q_ORDEMBindingSource.DataSource = Me.oracle
        '
        'oracle
        '
        Me.oracle.DataSetName = "oracle"
        Me.oracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'relOrdemServico
        '
        Me.relOrdemServico.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "rela"
        ReportDataSource2.Value = Me.Q_ORDEMBindingSource
        Me.relOrdemServico.LocalReport.DataSources.Add(ReportDataSource2)
        Me.relOrdemServico.LocalReport.ReportEmbeddedResource = "Sistema_Matrix.Report1.rdlc"
        Me.relOrdemServico.Location = New System.Drawing.Point(0, 0)
        Me.relOrdemServico.Name = "relOrdemServico"
        Me.relOrdemServico.Size = New System.Drawing.Size(958, 406)
        Me.relOrdemServico.TabIndex = 0
        '
        'Q_ORDEMTableAdapter
        '
        Me.Q_ORDEMTableAdapter.ClearBeforeFill = True
        '
        'Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 406)
        Me.Controls.Add(Me.relOrdemServico)
        Me.Name = "Relatorio"
        Me.Text = "Relatorio"
        CType(Me.Q_ORDEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oracle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents relOrdemServico As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents oracle As Sistema_Matrix.oracle
    Friend WithEvents Q_ORDEMTableAdapter As Sistema_Matrix.oracleTableAdapters.Q_ORDEMTableAdapter
    Friend WithEvents Q_ORDEMBindingSource As System.Windows.Forms.BindingSource
End Class
