<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReportePrenominaLista
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
        Me.Dtb_PrenominaListadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dts_PrenominaLista = New Presentacion.Dts_PrenominaLista()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Dtb_PrenominaListadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dts_PrenominaLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtb_PrenominaListadoBindingSource
        '
        Me.Dtb_PrenominaListadoBindingSource.DataMember = "Dtb_PrenominaListado"
        Me.Dtb_PrenominaListadoBindingSource.DataSource = Me.Dts_PrenominaLista
        '
        'Dts_PrenominaLista
        '
        Me.Dts_PrenominaLista.DataSetName = "Dts_PrenominaLista"
        Me.Dts_PrenominaLista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Dtb_PrenominaListadoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Rpt_PrenominaListado.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Frm_ReportePrenominaLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Frm_ReportePrenominaLista"
        Me.Text = "Reporte Pre Nomina Listado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dtb_PrenominaListadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dts_PrenominaLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Dtb_PrenominaListadoBindingSource As BindingSource
    Friend WithEvents Dts_PrenominaLista As Dts_PrenominaLista
End Class
