<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorReportePersonal2
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
        Me.DataSet10 = New Presentacion.DataSet10()
        Me.Sp_reporteEvaluacionIndirectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_reporteEvaluacionIndirectoTableAdapter = New Presentacion.DataSet10TableAdapters.Sp_reporteEvaluacionIndirectoTableAdapter()
        Me.DataSet14 = New Presentacion.DataSet14()
        Me.Sp_reportesemanalempleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_reportesemanalempleadosTableAdapter = New Presentacion.DataSet14TableAdapters.Sp_reportesemanalempleadosTableAdapter()
        CType(Me.DataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_reporteEvaluacionIndirectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_reportesemanalempleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_reportesemanalempleadosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportePersonalSemanal2.rdlc"
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
        'DataSet14
        '
        Me.DataSet14.DataSetName = "DataSet14"
        Me.DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_reportesemanalempleadosBindingSource
        '
        Me.Sp_reportesemanalempleadosBindingSource.DataMember = "Sp_reportesemanalempleados"
        Me.Sp_reportesemanalempleadosBindingSource.DataSource = Me.DataSet14
        '
        'Sp_reportesemanalempleadosTableAdapter
        '
        Me.Sp_reportesemanalempleadosTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReportePersonal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ContenedorReportePersonal2"
        Me.Text = "ContenedorReportePersonal2"
        CType(Me.DataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_reporteEvaluacionIndirectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_reportesemanalempleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_reporteEvaluacionIndirectoBindingSource As BindingSource
    Friend WithEvents DataSet10 As DataSet10
    Friend WithEvents Sp_reporteEvaluacionIndirectoTableAdapter As DataSet10TableAdapters.Sp_reporteEvaluacionIndirectoTableAdapter
    Friend WithEvents Sp_reportesemanalempleadosBindingSource As BindingSource
    Friend WithEvents DataSet14 As DataSet14
    Friend WithEvents Sp_reportesemanalempleadosTableAdapter As DataSet14TableAdapters.Sp_reportesemanalempleadosTableAdapter
End Class
