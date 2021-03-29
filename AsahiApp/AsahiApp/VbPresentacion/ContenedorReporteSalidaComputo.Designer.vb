<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorReporteSalidaComputo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorReporteSalidaComputo))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DatasetEquipoComputo = New Presentacion.DatasetEquipoComputo()
        Me.Sp_imprimeReporteSalidaComputoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_imprimeReporteSalidaComputoTableAdapter = New Presentacion.DatasetEquipoComputoTableAdapters.Sp_imprimeReporteSalidaComputoTableAdapter()
        CType(Me.DatasetEquipoComputo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_imprimeReporteSalidaComputoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_imprimeReporteSalidaComputoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteSalidaEquipoComputo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DatasetEquipoComputo
        '
        Me.DatasetEquipoComputo.DataSetName = "DatasetEquipoComputo"
        Me.DatasetEquipoComputo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_imprimeReporteSalidaComputoBindingSource
        '
        Me.Sp_imprimeReporteSalidaComputoBindingSource.DataMember = "Sp_imprimeReporteSalidaComputo"
        Me.Sp_imprimeReporteSalidaComputoBindingSource.DataSource = Me.DatasetEquipoComputo
        '
        'Sp_imprimeReporteSalidaComputoTableAdapter
        '
        Me.Sp_imprimeReporteSalidaComputoTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReporteSalidaComputo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorReporteSalidaComputo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte para salida de equipo de cómputo"
        CType(Me.DatasetEquipoComputo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_imprimeReporteSalidaComputoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_imprimeReporteSalidaComputoBindingSource As BindingSource
    Friend WithEvents DatasetEquipoComputo As DatasetEquipoComputo
    Friend WithEvents Sp_imprimeReporteSalidaComputoTableAdapter As DatasetEquipoComputoTableAdapters.Sp_imprimeReporteSalidaComputoTableAdapter
End Class
