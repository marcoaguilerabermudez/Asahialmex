<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContenedorReporteRequerimiento
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorReporteRequerimiento))
        Me.Sp_ReporteComprasRequerimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet35 = New Presentacion.DataSet35()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Sp_ReporteComprasRequerimientoTableAdapter = New Presentacion.DataSet35TableAdapters.Sp_ReporteComprasRequerimientoTableAdapter()
        CType(Me.Sp_ReporteComprasRequerimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet35, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sp_ReporteComprasRequerimientoBindingSource
        '
        Me.Sp_ReporteComprasRequerimientoBindingSource.DataMember = "Sp_ReporteComprasRequerimiento"
        Me.Sp_ReporteComprasRequerimientoBindingSource.DataSource = Me.DataSet35
        '
        'DataSet35
        '
        Me.DataSet35.DataSetName = "DataSet35"
        Me.DataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_ReporteComprasRequerimientoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteReqCompra.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Sp_ReporteComprasRequerimientoTableAdapter
        '
        Me.Sp_ReporteComprasRequerimientoTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReporteRequerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorReporteRequerimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requerimiento"
        CType(Me.Sp_ReporteComprasRequerimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet35, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_ReporteComprasRequerimientoBindingSource As BindingSource
    Friend WithEvents DataSet35 As DataSet35
    Friend WithEvents Sp_ReporteComprasRequerimientoTableAdapter As DataSet35TableAdapters.Sp_ReporteComprasRequerimientoTableAdapter
End Class
