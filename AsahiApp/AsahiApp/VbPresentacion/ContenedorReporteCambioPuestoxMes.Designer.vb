<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContenedorReporteCambioPuestoxMes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorReporteCambioPuestoxMes))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet21 = New Presentacion.DataSet21()
        Me.Sp_reportecambiodepuestoxmesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_reportecambiodepuestoxmesTableAdapter = New Presentacion.DataSet21TableAdapters.Sp_reportecambiodepuestoxmesTableAdapter()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_reportecambiodepuestoxmesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_reportecambiodepuestoxmesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteXmesCambioDePuesto.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(901, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet21"
        Me.DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_reportecambiodepuestoxmesBindingSource
        '
        Me.Sp_reportecambiodepuestoxmesBindingSource.DataMember = "Sp_reportecambiodepuestoxmes"
        Me.Sp_reportecambiodepuestoxmesBindingSource.DataSource = Me.DataSet21
        '
        'Sp_reportecambiodepuestoxmesTableAdapter
        '
        Me.Sp_reportecambiodepuestoxmesTableAdapter.ClearBeforeFill = True
        '
        'ContenedorReporteCambioPuestoxMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorReporteCambioPuestoxMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de puesto por mes"
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_reportecambiodepuestoxmesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_reportecambiodepuestoxmesBindingSource As BindingSource
    Friend WithEvents DataSet21 As DataSet21
    Friend WithEvents Sp_reportecambiodepuestoxmesTableAdapter As DataSet21TableAdapters.Sp_reportecambiodepuestoxmesTableAdapter
End Class
