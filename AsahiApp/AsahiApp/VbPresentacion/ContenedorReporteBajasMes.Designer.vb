<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorReporteBajasMes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorReporteBajasMes))
        Me.Sp_reporte_bajas_mesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet7 = New Presentacion.DataSet7()
        Me.Sp_reporte_bajas_mesTableAdapter = New Presentacion.DataSet7TableAdapters.Sp_reporte_bajas_mesTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet8 = New Presentacion.DataSet8()
        CType(Me.Sp_reporte_bajas_mesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sp_reporte_bajas_mesBindingSource
        '
        Me.Sp_reporte_bajas_mesBindingSource.DataMember = "Sp_reporte_bajas_mes"
        Me.Sp_reporte_bajas_mesBindingSource.DataSource = Me.DataSet7
        '
        'DataSet7
        '
        Me.DataSet7.DataSetName = "DataSet7"
        Me.DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_reporte_bajas_mesTableAdapter
        '
        Me.Sp_reporte_bajas_mesTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_reporte_bajas_mesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportE_bajas_mes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet8
        '
        Me.DataSet8.DataSetName = "DataSet8"
        Me.DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContenedorReporteBajasMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorReporteBajasMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de bajas por mes"
        CType(Me.Sp_reporte_bajas_mesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sp_reporte_bajas_mesBindingSource As BindingSource
    Friend WithEvents DataSet7 As DataSet7
    Friend WithEvents Sp_reporte_bajas_mesTableAdapter As DataSet7TableAdapters.Sp_reporte_bajas_mesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet8 As DataSet8
End Class
