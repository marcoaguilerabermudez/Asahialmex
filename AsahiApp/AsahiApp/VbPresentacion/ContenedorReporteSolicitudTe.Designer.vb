<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorReporteSolicitudTe
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorReporteSolicitudTe))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet27 = New Presentacion.DataSet27()
        Me.Sp_MuestraReporteSolicitudTeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_MuestraReporteSolicitudTeTableAdapter = New Presentacion.DataSet27TableAdapters.Sp_MuestraReporteSolicitudTeTableAdapter()
        CType(Me.DataSet27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MuestraReporteSolicitudTeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_MuestraReporteSolicitudTeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteSolicitudTe.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet27
        '
        Me.DataSet27.DataSetName = "DataSet27"
        Me.DataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_MuestraReporteSolicitudTeBindingSource
        '
        Me.Sp_MuestraReporteSolicitudTeBindingSource.DataMember = "Sp_MuestraReporteSolicitudTe"
        Me.Sp_MuestraReporteSolicitudTeBindingSource.DataSource = Me.DataSet27
        '
        'Sp_MuestraReporteSolicitudTeTableAdapter
        '
        Me.Sp_MuestraReporteSolicitudTeTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReporteSolicitudTe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorReporteSolicitudTe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Tiempo Extra"
        CType(Me.DataSet27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MuestraReporteSolicitudTeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_MuestraReporteSolicitudTeBindingSource As BindingSource
    Friend WithEvents DataSet27 As DataSet27
    Friend WithEvents Sp_MuestraReporteSolicitudTeTableAdapter As DataSet27TableAdapters.Sp_MuestraReporteSolicitudTeTableAdapter
End Class
