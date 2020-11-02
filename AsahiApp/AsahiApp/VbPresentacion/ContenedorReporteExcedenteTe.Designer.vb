<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorReporteExcedenteTe
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
        Me.DataSet2 = New Presentacion.DataSet2()
        Me.Sp_reporteExcedidoTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_reporteExcedidoTETableAdapter = New Presentacion.DataSet2TableAdapters.Sp_reporteExcedidoTETableAdapter()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_reporteExcedidoTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_reporteExcedidoTEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteExcedidoTE.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_reporteExcedidoTEBindingSource
        '
        Me.Sp_reporteExcedidoTEBindingSource.DataMember = "Sp_reporteExcedidoTE"
        Me.Sp_reporteExcedidoTEBindingSource.DataSource = Me.DataSet2
        '
        'Sp_reporteExcedidoTETableAdapter
        '
        Me.Sp_reporteExcedidoTETableAdapter.ClearBeforeFill = True
        '
        'ContenedorReporteExcedenteTe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ContenedorReporteExcedenteTe"
        Me.Text = "ContenedorReporteExcedenteTe"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_reporteExcedidoTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_reporteExcedidoTEBindingSource As BindingSource
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents Sp_reporteExcedidoTETableAdapter As DataSet2TableAdapters.Sp_reporteExcedidoTETableAdapter
End Class
