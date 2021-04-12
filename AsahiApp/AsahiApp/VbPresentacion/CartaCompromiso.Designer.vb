<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartaCompromiso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CartaCompromiso))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txt_puesto = New System.Windows.Forms.TextBox()
        Me.txt_depto = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.txt_ingreso = New System.Windows.Forms.TextBox()
        Me.txt_turno = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_fechainjustificada = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_motivo = New System.Windows.Forms.ComboBox()
        Me.btn_anteriores = New System.Windows.Forms.Button()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.dtp1)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Location = New System.Drawing.Point(2, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(846, 50)
        Me.panel1.TabIndex = 145
        '
        'dtp1
        '
        Me.dtp1.Enabled = False
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(736, 13)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(567, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Fecha de aplicación:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.pbx)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.txt_puesto)
        Me.GroupBox1.Controls.Add(Me.txt_depto)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_clave)
        Me.GroupBox1.Controls.Add(Me.txt_ingreso)
        Me.GroupBox1.Controls.Add(Me.txt_turno)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(823, 211)
        Me.GroupBox1.TabIndex = 153
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleado"
        '
        'pbx
        '
        Me.pbx.ErrorImage = CType(resources.GetObject("pbx.ErrorImage"), System.Drawing.Image)
        Me.pbx.Location = New System.Drawing.Point(599, 37)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(132, 138)
        Me.pbx.TabIndex = 196
        Me.pbx.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(66, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Puesto"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(71, 25)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 126
        Me.lbl1.Text = "Clave"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2.Enabled = False
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(62, 56)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(44, 13)
        Me.lbl2.TabIndex = 127
        Me.lbl2.Text = "Nombre"
        '
        'txt_puesto
        '
        Me.txt_puesto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_puesto.Enabled = False
        Me.txt_puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_puesto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_puesto.Location = New System.Drawing.Point(131, 117)
        Me.txt_puesto.Name = "txt_puesto"
        Me.txt_puesto.Size = New System.Drawing.Size(221, 20)
        Me.txt_puesto.TabIndex = 134
        '
        'txt_depto
        '
        Me.txt_depto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_depto.Enabled = False
        Me.txt_depto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_depto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_depto.Location = New System.Drawing.Point(130, 85)
        Me.txt_depto.Name = "txt_depto"
        Me.txt_depto.Size = New System.Drawing.Size(221, 20)
        Me.txt_depto.TabIndex = 130
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(130, 53)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(281, 20)
        Me.txt_nombre.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Fecha de Ingreso"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(32, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Departamento"
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.SystemColors.Control
        Me.txt_clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_clave.Location = New System.Drawing.Point(130, 22)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(98, 20)
        Me.txt_clave.TabIndex = 0
        Me.txt_clave.Tag = "0"
        '
        'txt_ingreso
        '
        Me.txt_ingreso.BackColor = System.Drawing.SystemColors.Control
        Me.txt_ingreso.Enabled = False
        Me.txt_ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ingreso.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_ingreso.Location = New System.Drawing.Point(130, 177)
        Me.txt_ingreso.Name = "txt_ingreso"
        Me.txt_ingreso.Size = New System.Drawing.Size(221, 20)
        Me.txt_ingreso.TabIndex = 132
        '
        'txt_turno
        '
        Me.txt_turno.BackColor = System.Drawing.SystemColors.Control
        Me.txt_turno.Enabled = False
        Me.txt_turno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_turno.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_turno.Location = New System.Drawing.Point(130, 146)
        Me.txt_turno.Name = "txt_turno"
        Me.txt_turno.Size = New System.Drawing.Size(120, 20)
        Me.txt_turno.TabIndex = 128
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.SystemColors.Control
        Me.lbl4.Enabled = False
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(71, 152)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(35, 13)
        Me.lbl4.TabIndex = 129
        Me.lbl4.Text = "Turno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Motivo de falta injustificada:"
        '
        'txt_motivo
        '
        Me.txt_motivo.BackColor = System.Drawing.SystemColors.Control
        Me.txt_motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_motivo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_motivo.Location = New System.Drawing.Point(13, 156)
        Me.txt_motivo.Multiline = True
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(281, 52)
        Me.txt_motivo.TabIndex = 151
        Me.txt_motivo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "Fecha de Falta Injustificada"
        '
        'txt_fechainjustificada
        '
        Me.txt_fechainjustificada.BackColor = System.Drawing.SystemColors.Control
        Me.txt_fechainjustificada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fechainjustificada.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_fechainjustificada.Location = New System.Drawing.Point(15, 31)
        Me.txt_fechainjustificada.Name = "txt_fechainjustificada"
        Me.txt_fechainjustificada.Size = New System.Drawing.Size(221, 20)
        Me.txt_fechainjustificada.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Enabled = False
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "Especifique:"
        Me.Label6.Visible = False
        '
        'cbx_motivo
        '
        Me.cbx_motivo.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_motivo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_motivo.FormattingEnabled = True
        Me.cbx_motivo.Location = New System.Drawing.Point(15, 94)
        Me.cbx_motivo.Name = "cbx_motivo"
        Me.cbx_motivo.Size = New System.Drawing.Size(436, 21)
        Me.cbx_motivo.TabIndex = 157
        '
        'btn_anteriores
        '
        Me.btn_anteriores.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_anteriores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anteriores.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_anteriores.Location = New System.Drawing.Point(756, 443)
        Me.btn_anteriores.Name = "btn_anteriores"
        Me.btn_anteriores.Size = New System.Drawing.Size(83, 42)
        Me.btn_anteriores.TabIndex = 182
        Me.btn_anteriores.Text = "Imprimir Anteriores"
        Me.btn_anteriores.UseVisualStyleBackColor = False
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.Enabled = False
        Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_solicitar.Location = New System.Drawing.Point(559, 347)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(133, 54)
        Me.btn_solicitar.TabIndex = 181
        Me.btn_solicitar.Text = "GUARDAR"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbx_motivo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_fechainjustificada)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_motivo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(7, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 212)
        Me.GroupBox2.TabIndex = 183
        Me.GroupBox2.TabStop = False
        '
        'CartaCompromiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 495)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_anteriores)
        Me.Controls.Add(Me.btn_solicitar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CartaCompromiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carta Compromiso para mejora de asistencia"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txt_puesto As TextBox
    Friend WithEvents txt_depto As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents txt_ingreso As TextBox
    Friend WithEvents txt_turno As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_motivo As TextBox
    Friend WithEvents pbx As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_fechainjustificada As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbx_motivo As ComboBox
    Friend WithEvents btn_anteriores As Button
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
