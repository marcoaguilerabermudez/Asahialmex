<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorReporteEntradaSalidaTE
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
        Me.DataSet4 = New Presentacion.DataSet4()
        Me.Sp_reporteincidenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_reporteincidenciaTableAdapter = New Presentacion.DataSet4TableAdapters.Sp_reporteincidenciaTableAdapter()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_reporteincidenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_reporteincidenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteEntradaSalidaTE.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet4
        '
        Me.DataSet4.DataSetName = "DataSet4"
        Me.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_reporteincidenciaBindingSource
        '
        Me.Sp_reporteincidenciaBindingSource.DataMember = "Sp_reporteincidencia"
        Me.Sp_reporteincidenciaBindingSource.DataSource = Me.DataSet4
        '
        'Sp_reporteincidenciaTableAdapter
        '
        Me.Sp_reporteincidenciaTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReporteEntradaSalidaTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ContenedorReporteEntradaSalidaTE"
        Me.Text = "ContenedorReporteEntradaSalidaTE"
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_reporteincidenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_reporteincidenciaBindingSource As BindingSource
    Friend WithEvents DataSet4 As DataSet4
    Friend WithEvents Sp_reporteincidenciaTableAdapter As DataSet4TableAdapters.Sp_reporteincidenciaTableAdapter
End Class
