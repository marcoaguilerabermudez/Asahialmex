<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorReporteSemanalPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorReporteSemanalPrincipal))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet14 = New Presentacion.DataSet14()
        Me.Sp_MuestraReporteSemanalEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_MuestraReporteSemanalEmpleadosTableAdapter = New Presentacion.DataSet14TableAdapters.Sp_MuestraReporteSemanalEmpleadosTableAdapter()
        CType(Me.DataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MuestraReporteSemanalEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Sp_MuestraReporteSemanalEmpleadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportesemanalempleadoGeneral.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet14
        '
        Me.DataSet14.DataSetName = "DataSet14"
        Me.DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_MuestraReporteSemanalEmpleadosBindingSource
        '
        Me.Sp_MuestraReporteSemanalEmpleadosBindingSource.DataMember = "Sp_MuestraReporteSemanalEmpleados"
        Me.Sp_MuestraReporteSemanalEmpleadosBindingSource.DataSource = Me.DataSet14
        '
        'Sp_MuestraReporteSemanalEmpleadosTableAdapter
        '
        Me.Sp_MuestraReporteSemanalEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReporteSemanalPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorReporteSemanalPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de plan de personal semanal"
        CType(Me.DataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MuestraReporteSemanalEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_MuestraReporteSemanalEmpleadosBindingSource As BindingSource
    Friend WithEvents DataSet14 As DataSet14
    Friend WithEvents Sp_MuestraReporteSemanalEmpleadosTableAdapter As DataSet14TableAdapters.Sp_MuestraReporteSemanalEmpleadosTableAdapter
End Class
