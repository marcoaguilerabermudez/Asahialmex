<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Prenomina
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
        Me.Btn_ListaPrenomina = New System.Windows.Forms.Button()
        Me.Btn_GlobalPrenomina = New System.Windows.Forms.Button()
        Me.Btn_Checadas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_ListaPrenomina
        '
        Me.Btn_ListaPrenomina.Location = New System.Drawing.Point(36, 63)
        Me.Btn_ListaPrenomina.Name = "Btn_ListaPrenomina"
        Me.Btn_ListaPrenomina.Size = New System.Drawing.Size(75, 35)
        Me.Btn_ListaPrenomina.TabIndex = 0
        Me.Btn_ListaPrenomina.Text = "Lista Prenomina"
        Me.Btn_ListaPrenomina.UseVisualStyleBackColor = True
        '
        'Btn_GlobalPrenomina
        '
        Me.Btn_GlobalPrenomina.Location = New System.Drawing.Point(157, 63)
        Me.Btn_GlobalPrenomina.Name = "Btn_GlobalPrenomina"
        Me.Btn_GlobalPrenomina.Size = New System.Drawing.Size(75, 35)
        Me.Btn_GlobalPrenomina.TabIndex = 1
        Me.Btn_GlobalPrenomina.Text = "Global Prenomina"
        Me.Btn_GlobalPrenomina.UseVisualStyleBackColor = True
        '
        'Btn_Checadas
        '
        Me.Btn_Checadas.Location = New System.Drawing.Point(288, 63)
        Me.Btn_Checadas.Name = "Btn_Checadas"
        Me.Btn_Checadas.Size = New System.Drawing.Size(75, 35)
        Me.Btn_Checadas.TabIndex = 2
        Me.Btn_Checadas.Text = "Checadas"
        Me.Btn_Checadas.UseVisualStyleBackColor = True
        '
        'Frm_Prenomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 178)
        Me.Controls.Add(Me.Btn_Checadas)
        Me.Controls.Add(Me.Btn_GlobalPrenomina)
        Me.Controls.Add(Me.Btn_ListaPrenomina)
        Me.Name = "Frm_Prenomina"
        Me.Text = "Prenomina"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_ListaPrenomina As Button
    Friend WithEvents Btn_GlobalPrenomina As Button
    Friend WithEvents Btn_Checadas As Button
End Class
