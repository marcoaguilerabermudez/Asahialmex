<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubventanaOee
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
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_turno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_error = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_piezas = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_proceso = New System.Windows.Forms.Label()
        Me.rbt_cantidad = New System.Windows.Forms.RadioButton()
        Me.rbt_tiempo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbt_g1 = New System.Windows.Forms.RadioButton()
        Me.rbtn_g2 = New System.Windows.Forms.RadioButton()
        Me.rbtn_g3 = New System.Windows.Forms.RadioButton()
        Me.rbtn_g4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtn_fundi = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(4, 20)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 12
        Me.lbl_fecha.Text = "Fecha"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Location = New System.Drawing.Point(102, 21)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(30, 13)
        Me.lbl_hora.TabIndex = 13
        Me.lbl_hora.Text = "Hora"
        '
        'lbl_turno
        '
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.Location = New System.Drawing.Point(223, 22)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(35, 13)
        Me.lbl_turno.TabIndex = 14
        Me.lbl_turno.Text = "Turno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Proceso"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(408, 204)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(85, 20)
        Me.txt_cantidad.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(426, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Valor"
        '
        'cbx_error
        '
        Me.cbx_error.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_error.FormattingEnabled = True
        Me.cbx_error.Location = New System.Drawing.Point(12, 206)
        Me.cbx_error.Name = "cbx_error"
        Me.cbx_error.Size = New System.Drawing.Size(322, 21)
        Me.cbx_error.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Tipo de Error"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(16, 332)
        Me.txt_observaciones.MaxLength = 100
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(158, 41)
        Me.txt_observaciones.TabIndex = 67
        '
        'btn_1
        '
        Me.btn_1.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.btn_1.Location = New System.Drawing.Point(461, 317)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(63, 56)
        Me.btn_1.TabIndex = 108
        Me.btn_1.Text = "Guardar"
        Me.btn_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Hora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(223, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Turno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(298, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "Cantidad de piezas"
        '
        'lbl_piezas
        '
        Me.lbl_piezas.AutoSize = True
        Me.lbl_piezas.Location = New System.Drawing.Point(326, 22)
        Me.lbl_piezas.Name = "lbl_piezas"
        Me.lbl_piezas.Size = New System.Drawing.Size(35, 13)
        Me.lbl_piezas.TabIndex = 112
        Me.lbl_piezas.Text = "Turno"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(458, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Proceso"
        '
        'lbl_proceso
        '
        Me.lbl_proceso.AutoSize = True
        Me.lbl_proceso.Location = New System.Drawing.Point(462, 22)
        Me.lbl_proceso.Name = "lbl_proceso"
        Me.lbl_proceso.Size = New System.Drawing.Size(35, 13)
        Me.lbl_proceso.TabIndex = 114
        Me.lbl_proceso.Text = "Turno"
        '
        'rbt_cantidad
        '
        Me.rbt_cantidad.AutoSize = True
        Me.rbt_cantidad.Location = New System.Drawing.Point(6, 19)
        Me.rbt_cantidad.Name = "rbt_cantidad"
        Me.rbt_cantidad.Size = New System.Drawing.Size(101, 17)
        Me.rbt_cantidad.TabIndex = 116
        Me.rbt_cantidad.Text = "Cantidad (pieza)"
        Me.rbt_cantidad.UseVisualStyleBackColor = True
        '
        'rbt_tiempo
        '
        Me.rbt_tiempo.AutoSize = True
        Me.rbt_tiempo.Checked = True
        Me.rbt_tiempo.Location = New System.Drawing.Point(6, 45)
        Me.rbt_tiempo.Name = "rbt_tiempo"
        Me.rbt_tiempo.Size = New System.Drawing.Size(100, 17)
        Me.rbt_tiempo.TabIndex = 117
        Me.rbt_tiempo.TabStop = True
        Me.rbt_tiempo.Text = "Tiempo (minuto)"
        Me.rbt_tiempo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt_cantidad)
        Me.GroupBox1.Controls.Add(Me.rbt_tiempo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 72)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtn_g4)
        Me.GroupBox2.Controls.Add(Me.rbtn_g3)
        Me.GroupBox2.Controls.Add(Me.rbt_g1)
        Me.GroupBox2.Controls.Add(Me.rbtn_g2)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 117)
        Me.GroupBox2.TabIndex = 119
        Me.GroupBox2.TabStop = False
        '
        'rbt_g1
        '
        Me.rbt_g1.AutoSize = True
        Me.rbt_g1.Checked = True
        Me.rbt_g1.Location = New System.Drawing.Point(6, 12)
        Me.rbt_g1.Name = "rbt_g1"
        Me.rbt_g1.Size = New System.Drawing.Size(106, 17)
        Me.rbt_g1.TabIndex = 116
        Me.rbt_g1.TabStop = True
        Me.rbt_g1.Text = "Cambio de molde"
        Me.rbt_g1.UseVisualStyleBackColor = True
        '
        'rbtn_g2
        '
        Me.rbtn_g2.AutoSize = True
        Me.rbtn_g2.Location = New System.Drawing.Point(6, 35)
        Me.rbtn_g2.Name = "rbtn_g2"
        Me.rbtn_g2.Size = New System.Drawing.Size(156, 17)
        Me.rbtn_g2.TabIndex = 117
        Me.rbtn_g2.Text = "Tiempo muerto por máquina"
        Me.rbtn_g2.UseVisualStyleBackColor = True
        '
        'rbtn_g3
        '
        Me.rbtn_g3.AutoSize = True
        Me.rbtn_g3.Location = New System.Drawing.Point(6, 59)
        Me.rbtn_g3.Name = "rbtn_g3"
        Me.rbtn_g3.Size = New System.Drawing.Size(138, 17)
        Me.rbtn_g3.TabIndex = 118
        Me.rbtn_g3.Text = "Loss por falta de control"
        Me.rbtn_g3.UseVisualStyleBackColor = True
        '
        'rbtn_g4
        '
        Me.rbtn_g4.AutoSize = True
        Me.rbtn_g4.Location = New System.Drawing.Point(7, 83)
        Me.rbtn_g4.Name = "rbtn_g4"
        Me.rbtn_g4.Size = New System.Drawing.Size(146, 17)
        Me.rbtn_g4.TabIndex = 119
        Me.rbtn_g4.Text = "Tiempo de paro planeado"
        Me.rbtn_g4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtn_fundi)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(159, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(137, 92)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        '
        'rbtn_fundi
        '
        Me.rbtn_fundi.AutoSize = True
        Me.rbtn_fundi.Checked = True
        Me.rbtn_fundi.Location = New System.Drawing.Point(8, 37)
        Me.rbtn_fundi.Name = "rbtn_fundi"
        Me.rbtn_fundi.Size = New System.Drawing.Size(73, 17)
        Me.rbtn_fundi.TabIndex = 118
        Me.rbtn_fundi.TabStop = True
        Me.rbtn_fundi.Text = "Funidición"
        Me.rbtn_fundi.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 60)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton2.TabIndex = 119
        Me.RadioButton2.Text = "Maquinado"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'SubventanaOee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 399)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_proceso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_piezas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.cbx_error)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.lbl_turno)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Name = "SubventanaOee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Error"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_turno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbx_error As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_observaciones As TextBox
    Friend WithEvents btn_1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_piezas As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_proceso As Label
    Friend WithEvents rbt_cantidad As RadioButton
    Friend WithEvents rbt_tiempo As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtn_g4 As RadioButton
    Friend WithEvents rbtn_g3 As RadioButton
    Friend WithEvents rbt_g1 As RadioButton
    Friend WithEvents rbtn_g2 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbtn_fundi As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
