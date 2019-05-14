<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RecursosHumanos
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
        Me.Btn_Prenomina = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Prenomina
        '
        Me.Btn_Prenomina.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.Btn_Prenomina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Prenomina.Location = New System.Drawing.Point(23, 30)
        Me.Btn_Prenomina.Name = "Btn_Prenomina"
        Me.Btn_Prenomina.Size = New System.Drawing.Size(68, 53)
        Me.Btn_Prenomina.TabIndex = 0
        Me.Btn_Prenomina.Text = "Prenomina"
        Me.Btn_Prenomina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Prenomina.UseVisualStyleBackColor = True
        '
        'Frm_RecursosHumanos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 304)
        Me.Controls.Add(Me.Btn_Prenomina)
        Me.Name = "Frm_RecursosHumanos"
        Me.Text = "Recursos Humanos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Prenomina As Button
End Class
