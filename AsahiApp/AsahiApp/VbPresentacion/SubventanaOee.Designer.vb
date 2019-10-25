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
        Me.cbx_proceso = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_tipode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        'cbx_proceso
        '
        Me.cbx_proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_proceso.FormattingEnabled = True
        Me.cbx_proceso.Items.AddRange(New Object() {"FUNDICIÓN", "MAQUINADO", "N/A"})
        Me.cbx_proceso.Location = New System.Drawing.Point(12, 110)
        Me.cbx_proceso.Name = "cbx_proceso"
        Me.cbx_proceso.Size = New System.Drawing.Size(120, 21)
        Me.cbx_proceso.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Proceso"
        '
        'cbx_tipode
        '
        Me.cbx_tipode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tipode.FormattingEnabled = True
        Me.cbx_tipode.Items.AddRange(New Object() {"Defecto de fundición, maquinado, grabado", "Cambio de molde", "Tiempo muerto por máquina", "Loss por falta de control", "Tiempo de paro planeado"})
        Me.cbx_tipode.Location = New System.Drawing.Point(12, 59)
        Me.cbx_tipode.Name = "cbx_tipode"
        Me.cbx_tipode.Size = New System.Drawing.Size(267, 21)
        Me.cbx_tipode.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tipo de error"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(297, 111)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(85, 20)
        Me.txt_cantidad.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Cantidad"
        '
        'cbx_error
        '
        Me.cbx_error.FormattingEnabled = True
        Me.cbx_error.Location = New System.Drawing.Point(12, 158)
        Me.cbx_error.Name = "cbx_error"
        Me.cbx_error.Size = New System.Drawing.Size(322, 21)
        Me.cbx_error.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Error"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(13, 216)
        Me.txt_observaciones.MaxLength = 100
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(158, 41)
        Me.txt_observaciones.TabIndex = 67
        '
        'btn_1
        '
        Me.btn_1.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.btn_1.Location = New System.Drawing.Point(246, 201)
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
        'SubventanaOee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 281)
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
        Me.Controls.Add(Me.cbx_tipode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_proceso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_turno)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Name = "SubventanaOee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Error"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_turno As Label
    Friend WithEvents cbx_proceso As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_tipode As ComboBox
    Friend WithEvents Label4 As Label
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
End Class
