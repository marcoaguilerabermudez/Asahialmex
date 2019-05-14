<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Btn_Rh = New System.Windows.Forms.Button()
        Me.Btn_ControlProduc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Rh
        '
        Me.Btn_Rh.Location = New System.Drawing.Point(68, 65)
        Me.Btn_Rh.Name = "Btn_Rh"
        Me.Btn_Rh.Size = New System.Drawing.Size(89, 55)
        Me.Btn_Rh.TabIndex = 0
        Me.Btn_Rh.Text = "Recursos Humanos"
        Me.Btn_Rh.UseVisualStyleBackColor = True
        '
        'Btn_ControlProduc
        '
        Me.Btn_ControlProduc.Location = New System.Drawing.Point(250, 65)
        Me.Btn_ControlProduc.Name = "Btn_ControlProduc"
        Me.Btn_ControlProduc.Size = New System.Drawing.Size(89, 55)
        Me.Btn_ControlProduc.TabIndex = 1
        Me.Btn_ControlProduc.Text = "Control de Producción"
        Me.Btn_ControlProduc.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 312)
        Me.Controls.Add(Me.Btn_ControlProduc)
        Me.Controls.Add(Me.Btn_Rh)
        Me.Name = "Frm_Principal"
        Me.Text = "AsahiApp"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Rh As Button
    Friend WithEvents Btn_ControlProduc As Button
End Class
