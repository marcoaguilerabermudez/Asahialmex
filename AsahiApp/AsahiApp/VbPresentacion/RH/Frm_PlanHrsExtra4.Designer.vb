<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PlanHrsExtra4
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
        Me.Dts_PlanHrsExt4 = New Presentacion.Dts_PlanHrsExt4()
        Me.Rh_RptPlanHrsExtraMensual4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rh_RptPlanHrsExtraMensual4TableAdapter = New Presentacion.Dts_PlanHrsExt4TableAdapters.Rh_RptPlanHrsExtraMensual4TableAdapter()
        CType(Me.Dts_PlanHrsExt4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rh_RptPlanHrsExtraMensual4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Rh_RptPlanHrsExtraMensual4BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Rpt_PlanHorasExtra4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1323, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'Dts_PlanHrsExt4
        '
        Me.Dts_PlanHrsExt4.DataSetName = "Dts_PlanHrsExt4"
        Me.Dts_PlanHrsExt4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Rh_RptPlanHrsExtraMensual4BindingSource
        '
        Me.Rh_RptPlanHrsExtraMensual4BindingSource.DataMember = "Rh_RptPlanHrsExtraMensual4"
        Me.Rh_RptPlanHrsExtraMensual4BindingSource.DataSource = Me.Dts_PlanHrsExt4
        '
        'Rh_RptPlanHrsExtraMensual4TableAdapter
        '
        Me.Rh_RptPlanHrsExtraMensual4TableAdapter.ClearBeforeFill = True
        '
        'Frm_PlanHrsExtra4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Frm_PlanHrsExtra4"
        Me.Text = "Frm_PlanHrsExtra4"
        CType(Me.Dts_PlanHrsExt4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rh_RptPlanHrsExtraMensual4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Rh_RptPlanHrsExtraMensual4BindingSource As BindingSource
    Friend WithEvents Dts_PlanHrsExt4 As Dts_PlanHrsExt4
    Friend WithEvents Rh_RptPlanHrsExtraMensual4TableAdapter As Dts_PlanHrsExt4TableAdapters.Rh_RptPlanHrsExtraMensual4TableAdapter
End Class
