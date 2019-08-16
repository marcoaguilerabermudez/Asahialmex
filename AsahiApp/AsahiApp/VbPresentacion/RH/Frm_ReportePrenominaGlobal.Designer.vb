<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReportePrenominaGlobal
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
        Me.Dts_PrenominaGlobal = New Presentacion.Dts_PrenominaGlobal()
        Me.Dtb_PrenominaGlobalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Dts_PrenominaGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtb_PrenominaGlobalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Dtb_PrenominaGlobalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Rpt_PrenominaGlobal.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Dts_PrenominaGlobal
        '
        Me.Dts_PrenominaGlobal.DataSetName = "Dts_PrenominaGlobal"
        Me.Dts_PrenominaGlobal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dtb_PrenominaGlobalBindingSource
        '
        Me.Dtb_PrenominaGlobalBindingSource.DataMember = "Dtb_PrenominaGlobal"
        Me.Dtb_PrenominaGlobalBindingSource.DataSource = Me.Dts_PrenominaGlobal
        '
        'Frm_ReportePrenominaGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Frm_ReportePrenominaGlobal"
        Me.Text = "Reporte Pre Nomina Global"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dts_PrenominaGlobal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtb_PrenominaGlobalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Dtb_PrenominaGlobalBindingSource As BindingSource
    Friend WithEvents Dts_PrenominaGlobal As Dts_PrenominaGlobal
End Class
