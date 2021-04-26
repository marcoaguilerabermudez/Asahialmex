<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorReportePlanPersonalTe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorReportePlanPersonalTe))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet19 = New Presentacion.DataSet19()
        Me.Sp_reportePlanPersonalTiempoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_reportePlanPersonalTiempoTableAdapter = New Presentacion.DataSet19TableAdapters.Sp_reportePlanPersonalTiempoTableAdapter()
        CType(Me.DataSet19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_reportePlanPersonalTiempoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_reportePlanPersonalTiempoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReportePlanPersonalTE.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet19
        '
        Me.DataSet19.DataSetName = "DataSet19"
        Me.DataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_reportePlanPersonalTiempoBindingSource
        '
        Me.Sp_reportePlanPersonalTiempoBindingSource.DataMember = "Sp_reportePlanPersonalTiempo"
        Me.Sp_reportePlanPersonalTiempoBindingSource.DataSource = Me.DataSet19
        '
        'Sp_reportePlanPersonalTiempoTableAdapter
        '
        Me.Sp_reportePlanPersonalTiempoTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReportePlanPersonalTe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorReportePlanPersonalTe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Plan de Personal"
        CType(Me.DataSet19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_reportePlanPersonalTiempoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_reportePlanPersonalTiempoBindingSource As BindingSource
    Friend WithEvents DataSet19 As DataSet19
    Friend WithEvents Sp_reportePlanPersonalTiempoTableAdapter As DataSet19TableAdapters.Sp_reportePlanPersonalTiempoTableAdapter
End Class
