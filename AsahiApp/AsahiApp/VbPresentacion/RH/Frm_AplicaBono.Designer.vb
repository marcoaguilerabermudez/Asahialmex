<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AplicaBono
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
        Me.Lbl_IdEmpleado = New System.Windows.Forms.Label()
        Me.Lbl_NombreEmpleado = New System.Windows.Forms.Label()
        Me.Lbl_IdTurno = New System.Windows.Forms.Label()
        Me.Lbl_Horario = New System.Windows.Forms.Label()
        Me.Cmb_Motivo = New System.Windows.Forms.ComboBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lbl_Checada = New System.Windows.Forms.Label()
        Me.Lbl_5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_IdEmpleado
        '
        Me.Lbl_IdEmpleado.AutoSize = True
        Me.Lbl_IdEmpleado.Location = New System.Drawing.Point(19, 13)
        Me.Lbl_IdEmpleado.Name = "Lbl_IdEmpleado"
        Me.Lbl_IdEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_IdEmpleado.TabIndex = 0
        Me.Lbl_IdEmpleado.Text = "Label1"
        '
        'Lbl_NombreEmpleado
        '
        Me.Lbl_NombreEmpleado.AutoSize = True
        Me.Lbl_NombreEmpleado.Location = New System.Drawing.Point(56, 13)
        Me.Lbl_NombreEmpleado.Name = "Lbl_NombreEmpleado"
        Me.Lbl_NombreEmpleado.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_NombreEmpleado.TabIndex = 1
        Me.Lbl_NombreEmpleado.Text = "Label2"
        '
        'Lbl_IdTurno
        '
        Me.Lbl_IdTurno.AutoSize = True
        Me.Lbl_IdTurno.Location = New System.Drawing.Point(19, 44)
        Me.Lbl_IdTurno.Name = "Lbl_IdTurno"
        Me.Lbl_IdTurno.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_IdTurno.TabIndex = 2
        Me.Lbl_IdTurno.Text = "Label3"
        '
        'Lbl_Horario
        '
        Me.Lbl_Horario.AutoSize = True
        Me.Lbl_Horario.Location = New System.Drawing.Point(56, 44)
        Me.Lbl_Horario.Name = "Lbl_Horario"
        Me.Lbl_Horario.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Horario.TabIndex = 3
        Me.Lbl_Horario.Text = "Label4"
        '
        'Cmb_Motivo
        '
        Me.Cmb_Motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Motivo.FormattingEnabled = True
        Me.Cmb_Motivo.Location = New System.Drawing.Point(59, 95)
        Me.Cmb_Motivo.Name = "Cmb_Motivo"
        Me.Cmb_Motivo.Size = New System.Drawing.Size(154, 21)
        Me.Cmb_Motivo.TabIndex = 4
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_Guardar.Location = New System.Drawing.Point(107, 122)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(44, 36)
        Me.Btn_Guardar.TabIndex = 5
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        Me.Btn_Guardar.Visible = False
        '
        'Lbl_Checada
        '
        Me.Lbl_Checada.AutoSize = True
        Me.Lbl_Checada.Location = New System.Drawing.Point(64, 70)
        Me.Lbl_Checada.Name = "Lbl_Checada"
        Me.Lbl_Checada.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Checada.TabIndex = 7
        Me.Lbl_Checada.Text = "Label6"
        '
        'Lbl_5
        '
        Me.Lbl_5.AutoSize = True
        Me.Lbl_5.Location = New System.Drawing.Point(15, 70)
        Me.Lbl_5.Name = "Lbl_5"
        Me.Lbl_5.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_5.TabIndex = 6
        Me.Lbl_5.Text = "Checada"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hrs."
        '
        'Frm_AplicaBono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 168)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Checada)
        Me.Controls.Add(Me.Lbl_5)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Cmb_Motivo)
        Me.Controls.Add(Me.Lbl_Horario)
        Me.Controls.Add(Me.Lbl_IdTurno)
        Me.Controls.Add(Me.Lbl_NombreEmpleado)
        Me.Controls.Add(Me.Lbl_IdEmpleado)
        Me.Name = "Frm_AplicaBono"
        Me.ShowIcon = False
        Me.Text = "Motivo Aplicar Bono"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_IdEmpleado As Label
    Friend WithEvents Lbl_NombreEmpleado As Label
    Friend WithEvents Lbl_IdTurno As Label
    Friend WithEvents Lbl_Horario As Label
    Friend WithEvents Cmb_Motivo As ComboBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Lbl_Checada As Label
    Friend WithEvents Lbl_5 As Label
    Friend WithEvents Label1 As Label
End Class
