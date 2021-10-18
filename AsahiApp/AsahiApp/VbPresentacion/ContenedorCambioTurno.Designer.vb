<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenedorCambioTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenedorCambioTurno))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet34 = New Presentacion.DataSet34()
        Me.Sp_ReporteCambioTurnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_ReporteCambioTurnoTableAdapter = New Presentacion.DataSet34TableAdapters.Sp_ReporteCambioTurnoTableAdapter()
        CType(Me.DataSet34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_ReporteCambioTurnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_ReporteCambioTurnoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.ReporteCambioTurno.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet34
        '
        Me.DataSet34.DataSetName = "DataSet34"
        Me.DataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_ReporteCambioTurnoBindingSource
        '
        Me.Sp_ReporteCambioTurnoBindingSource.DataMember = "Sp_ReporteCambioTurno"
        Me.Sp_ReporteCambioTurnoBindingSource.DataSource = Me.DataSet34
        '
        'Sp_ReporteCambioTurnoTableAdapter
        '
        Me.Sp_ReporteCambioTurnoTableAdapter.ClearBeforeFill = True
        '
        'ContenedorCambioTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ContenedorCambioTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Turno"
        CType(Me.DataSet34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_ReporteCambioTurnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_ReporteCambioTurnoBindingSource As BindingSource
    Friend WithEvents DataSet34 As DataSet34
    Friend WithEvents Sp_ReporteCambioTurnoTableAdapter As DataSet34TableAdapters.Sp_ReporteCambioTurnoTableAdapter
End Class
