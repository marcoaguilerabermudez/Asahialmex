<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RepPlanHrsExtra5
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Rh_RptPlanHrsExtraMensual5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dts_PlanHrsExt5 = New Presentacion.Dts_PlanHrsExt5()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Rh_RptPlanHrsExtraMensual5TableAdapter = New Presentacion.Dts_PlanHrsExt5TableAdapters.Rh_RptPlanHrsExtraMensual5TableAdapter()
        CType(Me.Rh_RptPlanHrsExtraMensual5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dts_PlanHrsExt5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rh_RptPlanHrsExtraMensual5BindingSource
        '
        Me.Rh_RptPlanHrsExtraMensual5BindingSource.DataMember = "Rh_RptPlanHrsExtraMensual5"
        Me.Rh_RptPlanHrsExtraMensual5BindingSource.DataSource = Me.Dts_PlanHrsExt5
        '
        'Dts_PlanHrsExt5
        '
        Me.Dts_PlanHrsExt5.DataSetName = "Dts_PlanHrsExt5"
        Me.Dts_PlanHrsExt5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Dts_PlanHrsExt5"
        ReportDataSource2.Value = Me.Rh_RptPlanHrsExtraMensual5BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Rpt_PlanHorasExtra5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'Rh_RptPlanHrsExtraMensual5TableAdapter
        '
        Me.Rh_RptPlanHrsExtraMensual5TableAdapter.ClearBeforeFill = True
        '
        'Frm_RepPlanHrsExtra5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Frm_RepPlanHrsExtra5"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rep Plan Hrs Extra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Rh_RptPlanHrsExtraMensual5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dts_PlanHrsExt5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Rh_RptPlanHrsExtraMensual5BindingSource As BindingSource
    Friend WithEvents Dts_PlanHrsExt5 As Dts_PlanHrsExt5
    Friend WithEvents Rh_RptPlanHrsExtraMensual5TableAdapter As Dts_PlanHrsExt5TableAdapters.Rh_RptPlanHrsExtraMensual5TableAdapter
End Class
