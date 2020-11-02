<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Subsidiaria
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
        Me.Btn_Serv = New System.Windows.Forms.Button()
        Me.Btn_Mx = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Serv
        '
        Me.Btn_Serv.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Serv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Serv.Image = Global.Presentacion.My.Resources.Resources.customer
        Me.Btn_Serv.Location = New System.Drawing.Point(132, 14)
        Me.Btn_Serv.Name = "Btn_Serv"
        Me.Btn_Serv.Size = New System.Drawing.Size(75, 71)
        Me.Btn_Serv.TabIndex = 1
        Me.Btn_Serv.UseVisualStyleBackColor = True
        '
        'Btn_Mx
        '
        Me.Btn_Mx.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Mx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Mx.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Mx.Image = Global.Presentacion.My.Resources.Resources.mexico
        Me.Btn_Mx.Location = New System.Drawing.Point(22, 14)
        Me.Btn_Mx.Name = "Btn_Mx"
        Me.Btn_Mx.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Mx.Size = New System.Drawing.Size(75, 71)
        Me.Btn_Mx.TabIndex = 0
        Me.Btn_Mx.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "México"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Servicios"
        '
        'Frm_Subsidiaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(228, 127)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Serv)
        Me.Controls.Add(Me.Btn_Mx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Frm_Subsidiaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subsidiaria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Mx As Button
    Friend WithEvents Btn_Serv As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
