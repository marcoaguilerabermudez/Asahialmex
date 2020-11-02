<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteTest
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
        Me.DtstReporteTest = New Presentacion.DtstReporteTest()
        Me.Sp_ValeboxluchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_ValeboxluchTableAdapter = New Presentacion.DtstReporteTestTableAdapters.Sp_ValeboxluchTableAdapter()
        CType(Me.DtstReporteTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_ValeboxluchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Sp_ValeboxluchBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Reportetesterik.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 6)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(790, 438)
        Me.ReportViewer1.TabIndex = 0
        '
        'DtstReporteTest
        '
        Me.DtstReporteTest.DataSetName = "DtstReporteTest"
        Me.DtstReporteTest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_ValeboxluchBindingSource
        '
        Me.Sp_ValeboxluchBindingSource.DataMember = "Sp_Valeboxluch"
        Me.Sp_ValeboxluchBindingSource.DataSource = Me.DtstReporteTest
        '
        'Sp_ValeboxluchTableAdapter
        '
        Me.Sp_ValeboxluchTableAdapter.ClearBeforeFill = True
        '
        'ReporteTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteTest"
        Me.Text = "ReporteTest"
        CType(Me.DtstReporteTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_ValeboxluchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Sp_ValeboxluchBindingSource As BindingSource
    Friend WithEvents DtstReporteTest As DtstReporteTest
    Friend WithEvents Sp_ValeboxluchTableAdapter As DtstReporteTestTableAdapters.Sp_ValeboxluchTableAdapter
End Class
