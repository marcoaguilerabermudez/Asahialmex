<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_terminavale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_terminavale))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.txt_empleado = New System.Windows.Forms.TextBox()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.btn_terminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Comentario"
        '
        'txt_comentario
        '
        Me.txt_comentario.BackColor = System.Drawing.SystemColors.Control
        Me.txt_comentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comentario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_comentario.Location = New System.Drawing.Point(17, 30)
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(281, 52)
        Me.txt_comentario.TabIndex = 153
        '
        'txt_empleado
        '
        Me.txt_empleado.BackColor = System.Drawing.SystemColors.Control
        Me.txt_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empleado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_empleado.Location = New System.Drawing.Point(20, 126)
        Me.txt_empleado.Name = "txt_empleado"
        Me.txt_empleado.Size = New System.Drawing.Size(79, 18)
        Me.txt_empleado.TabIndex = 155
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_empleado.ForeColor = System.Drawing.Color.Black
        Me.lbl_empleado.Location = New System.Drawing.Point(22, 109)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(57, 13)
        Me.lbl_empleado.TabIndex = 156
        Me.lbl_empleado.Text = "Supervisor"
        '
        'btn_terminar
        '
        Me.btn_terminar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_terminar.ForeColor = System.Drawing.Color.Green
        Me.btn_terminar.Location = New System.Drawing.Point(318, 207)
        Me.btn_terminar.Name = "btn_terminar"
        Me.btn_terminar.Size = New System.Drawing.Size(90, 35)
        Me.btn_terminar.TabIndex = 157
        Me.btn_terminar.Text = "Terminar"
        Me.btn_terminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Location = New System.Drawing.Point(9, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 35)
        Me.Button1.TabIndex = 158
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_terminavale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_terminar)
        Me.Controls.Add(Me.lbl_empleado)
        Me.Controls.Add(Me.txt_empleado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_comentario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_terminavale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terminar vale"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txt_comentario As TextBox
    Friend WithEvents txt_empleado As TextBox
    Friend WithEvents lbl_empleado As Label
    Friend WithEvents btn_terminar As Button
    Friend WithEvents Button1 As Button
End Class
