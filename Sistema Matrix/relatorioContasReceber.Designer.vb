<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relatorioContasReceber
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Q_CONTAS_RECEBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.oracle = New Sistema_Matrix.oracle()
        Me.Q_CONTAS_RECEBERTableAdapter = New Sistema_Matrix.oracleTableAdapters.Q_CONTAS_RECEBERTableAdapter()
        CType(Me.Q_CONTAS_RECEBERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oracle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Q_CONTAS_RECEBERBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Matrix.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(919, 493)
        Me.ReportViewer1.TabIndex = 0
        '
        'Q_CONTAS_RECEBERBindingSource
        '
        Me.Q_CONTAS_RECEBERBindingSource.DataMember = "Q_CONTAS_RECEBER"
        Me.Q_CONTAS_RECEBERBindingSource.DataSource = Me.oracle
        '
        'oracle
        '
        Me.oracle.DataSetName = "oracle"
        Me.oracle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Q_CONTAS_RECEBERTableAdapter
        '
        Me.Q_CONTAS_RECEBERTableAdapter.ClearBeforeFill = True
        '
        'relatorioContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 493)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "relatorioContasReceber"
        Me.Text = "relatorioContasReceber"
        CType(Me.Q_CONTAS_RECEBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oracle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents oracle As Sistema_Matrix.oracle
    Friend WithEvents Q_CONTAS_RECEBERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Q_CONTAS_RECEBERTableAdapter As Sistema_Matrix.oracleTableAdapters.Q_CONTAS_RECEBERTableAdapter
End Class
