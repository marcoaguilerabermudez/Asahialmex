<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContenedorReporteIndirecto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorReporteIndirecto))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet10 = New Presentacion.DataSet10()
        Me.Sp_reporteEvaluacionIndirectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_reporteEvaluacionIndirectoTableAdapter = New Presentacion.DataSet10TableAdapters.Sp_reporteEvaluacionIndirectoTableAdapter()
        CType(Me.DataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_reporteEvaluacionIndirectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_reporteEvaluacionIndirectoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteEvaIndirectoTest.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet10
        '
        Me.DataSet10.DataSetName = "DataSet10"
        Me.DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_reporteEvaluacionIndirectoBindingSource
        '
        Me.Sp_reporteEvaluacionIndirectoBindingSource.DataMember = "Sp_reporteEvaluacionIndirecto"
        Me.Sp_reporteEvaluacionIndirectoBindingSource.DataSource = Me.DataSet10
        '
        'Sp_reporteEvaluacionIndirectoTableAdapter
        '
        Me.Sp_reporteEvaluacionIndirectoTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReporteIndirecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorReporteIndirecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Indirecto"
        CType(Me.DataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_reporteEvaluacionIndirectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_reporteEvaluacionIndirectoBindingSource As BindingSource
    Friend WithEvents DataSet10 As DataSet10
    Friend WithEvents Sp_reporteEvaluacionIndirectoTableAdapter As DataSet10TableAdapters.Sp_reporteEvaluacionIndirectoTableAdapter
End Class
