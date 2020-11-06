<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_reportePCSGoce
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DatasetRh_Reportes = New Presentacion.DatasetRh_Reportes()
        Me.Sp_reporteincidenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_reporteincidenciaTableAdapter = New Presentacion.DatasetRh_ReportesTableAdapters.Sp_reporteincidenciaTableAdapter()
        CType(Me.DatasetRh_Reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_reporteincidenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_reporteincidenciaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportePermisoCSGoce.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DatasetRh_Reportes
        '
        Me.DatasetRh_Reportes.DataSetName = "DatasetRh_Reportes"
        Me.DatasetRh_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_reporteincidenciaBindingSource
        '
        Me.Sp_reporteincidenciaBindingSource.DataMember = "Sp_reporteincidencia"
        Me.Sp_reporteincidenciaBindingSource.DataSource = Me.DatasetRh_Reportes
        '
        'Sp_reporteincidenciaTableAdapter
        '
        Me.Sp_reporteincidenciaTableAdapter.ClearBeforeFill = True
        '
        'F_reportePCSGoce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "F_reportePCSGoce"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_reportePCSGoce"
        CType(Me.DatasetRh_Reportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_reporteincidenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_reporteincidenciaBindingSource As BindingSource
    Friend WithEvents DatasetRh_Reportes As DatasetRh_Reportes
    Friend WithEvents Sp_reporteincidenciaTableAdapter As DatasetRh_ReportesTableAdapters.Sp_reporteincidenciaTableAdapter
End Class
