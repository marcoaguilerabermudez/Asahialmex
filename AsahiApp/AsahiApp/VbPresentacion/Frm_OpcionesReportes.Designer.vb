<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OpcionesReportes
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
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Btn_RepMensual = New System.Windows.Forms.Button()
        Me.Btn_RepSemanal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Location = New System.Drawing.Point(24, 32)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(180, 13)
        Me.Lbl_Titulo.TabIndex = 0
        Me.Lbl_Titulo.Text = "REPORTES PLAN TIEMPO EXTRA"
        '
        'Btn_RepMensual
        '
        Me.Btn_RepMensual.Location = New System.Drawing.Point(33, 65)
        Me.Btn_RepMensual.Name = "Btn_RepMensual"
        Me.Btn_RepMensual.Size = New System.Drawing.Size(75, 38)
        Me.Btn_RepMensual.TabIndex = 1
        Me.Btn_RepMensual.Text = "Reporte Mensual"
        Me.Btn_RepMensual.UseVisualStyleBackColor = True
        Me.Btn_RepMensual.Visible = False
        '
        'Btn_RepSemanal
        '
        Me.Btn_RepSemanal.Location = New System.Drawing.Point(125, 65)
        Me.Btn_RepSemanal.Name = "Btn_RepSemanal"
        Me.Btn_RepSemanal.Size = New System.Drawing.Size(75, 38)
        Me.Btn_RepSemanal.TabIndex = 2
        Me.Btn_RepSemanal.Text = "Reporte Semanal"
        Me.Btn_RepSemanal.UseVisualStyleBackColor = True
        Me.Btn_RepSemanal.Visible = False
        '
        'Frm_OpcionesReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 128)
        Me.Controls.Add(Me.Btn_RepSemanal)
        Me.Controls.Add(Me.Btn_RepMensual)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Name = "Frm_OpcionesReportes"
        Me.ShowIcon = False
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Btn_RepMensual As Button
    Friend WithEvents Btn_RepSemanal As Button
End Class
