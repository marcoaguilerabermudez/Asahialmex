<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidaIncidenciaMultiple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValidaIncidenciaMultiple))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_autorizar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.lbl_turno = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_tipop = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_motivop = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Empleado = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_ES = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_retardo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbx_inicidencia = New System.Windows.Forms.GroupBox()
        Me.lbl_hasta = New System.Windows.Forms.DateTimePicker()
        Me.lbl_desde = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtgvi = New System.Windows.Forms.DataGridView()
        Me.lbl_hora = New System.Windows.Forms.DateTimePicker()
        Me.panel1.SuspendLayout()
        Me.Empleado.SuspendLayout()
        Me.gbx_inicidencia.SuspendLayout()
        CType(Me.dtgvi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.lbl_tipo)
        Me.panel1.Controls.Add(Me.txt_folio)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Location = New System.Drawing.Point(1, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(801, 48)
        Me.panel1.TabIndex = 145
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.lbl_tipo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_tipo.Location = New System.Drawing.Point(654, 14)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(0, 20)
        Me.lbl_tipo.TabIndex = 142
        '
        'txt_folio
        '
        Me.txt_folio.BackColor = System.Drawing.Color.SteelBlue
        Me.txt_folio.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_folio.Location = New System.Drawing.Point(139, 9)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(83, 20)
        Me.txt_folio.TabIndex = 141
        Me.txt_folio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Número de Folio"
        '
        'Btn_autorizar
        '
        Me.Btn_autorizar.BackColor = System.Drawing.Color.LightGray
        Me.Btn_autorizar.Enabled = False
        Me.Btn_autorizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_autorizar.ForeColor = System.Drawing.Color.SteelBlue
        Me.Btn_autorizar.Location = New System.Drawing.Point(713, 458)
        Me.Btn_autorizar.Name = "Btn_autorizar"
        Me.Btn_autorizar.Size = New System.Drawing.Size(79, 35)
        Me.Btn_autorizar.TabIndex = 162
        Me.Btn_autorizar.Text = "Validar"
        Me.Btn_autorizar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(29, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "Departamento"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.SystemColors.Control
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(73, 61)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(40, 13)
        Me.lbl4.TabIndex = 171
        Me.lbl4.Text = "Turno"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(64, 38)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(50, 13)
        Me.lbl2.TabIndex = 169
        Me.lbl2.Text = "Nombre"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(73, 16)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(39, 13)
        Me.lbl1.TabIndex = 168
        Me.lbl1.Text = "Clave"
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_depto.ForeColor = System.Drawing.Color.Black
        Me.lbl_depto.Location = New System.Drawing.Point(134, 83)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(74, 13)
        Me.lbl_depto.TabIndex = 177
        Me.lbl_depto.Text = "Departamento"
        '
        'lbl_turno
        '
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_turno.ForeColor = System.Drawing.Color.Black
        Me.lbl_turno.Location = New System.Drawing.Point(134, 61)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(35, 13)
        Me.lbl_turno.TabIndex = 176
        Me.lbl_turno.Text = "Turno"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(134, 38)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 175
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_clave.ForeColor = System.Drawing.Color.Black
        Me.lbl_clave.Location = New System.Drawing.Point(134, 16)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_clave.TabIndex = 174
        Me.lbl_clave.Text = "Clave"
        '
        'lbl_tipop
        '
        Me.lbl_tipop.AutoSize = True
        Me.lbl_tipop.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_tipop.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipop.Location = New System.Drawing.Point(134, 105)
        Me.lbl_tipop.Name = "lbl_tipop"
        Me.lbl_tipop.Size = New System.Drawing.Size(74, 13)
        Me.lbl_tipop.TabIndex = 179
        Me.lbl_tipop.Text = "Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(36, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Tipo permiso"
        '
        'lbl_motivop
        '
        Me.lbl_motivop.AutoSize = True
        Me.lbl_motivop.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_motivop.ForeColor = System.Drawing.Color.Black
        Me.lbl_motivop.Location = New System.Drawing.Point(134, 129)
        Me.lbl_motivop.Name = "lbl_motivop"
        Me.lbl_motivop.Size = New System.Drawing.Size(74, 13)
        Me.lbl_motivop.TabIndex = 181
        Me.lbl_motivop.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Motivo de permiso"
        '
        'Empleado
        '
        Me.Empleado.Controls.Add(Me.lbl_depto)
        Me.Empleado.Controls.Add(Me.lbl_turno)
        Me.Empleado.Controls.Add(Me.lbl_nombre)
        Me.Empleado.Controls.Add(Me.lbl_clave)
        Me.Empleado.Controls.Add(Me.lbl_motivop)
        Me.Empleado.Controls.Add(Me.Label8)
        Me.Empleado.Controls.Add(Me.Label4)
        Me.Empleado.Controls.Add(Me.lbl4)
        Me.Empleado.Controls.Add(Me.lbl_tipop)
        Me.Empleado.Controls.Add(Me.lbl2)
        Me.Empleado.Controls.Add(Me.Label3)
        Me.Empleado.Controls.Add(Me.lbl1)
        Me.Empleado.Location = New System.Drawing.Point(3, 48)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(689, 151)
        Me.Empleado.TabIndex = 182
        Me.Empleado.TabStop = False
        Me.Empleado.Text = "Empleado"
        Me.Empleado.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(53, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "al:"
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 182
        Me.Label5.Text = "Fecha del:"
        Me.Label5.Visible = False
        '
        'lbl_ES
        '
        Me.lbl_ES.AutoSize = True
        Me.lbl_ES.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_ES.ForeColor = System.Drawing.Color.Black
        Me.lbl_ES.Location = New System.Drawing.Point(199, 37)
        Me.lbl_ES.Name = "lbl_ES"
        Me.lbl_ES.Size = New System.Drawing.Size(14, 13)
        Me.lbl_ES.TabIndex = 186
        Me.lbl_ES.Text = "X"
        Me.lbl_ES.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(366, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Retardo por:"
        Me.Label2.Visible = False
        '
        'txt_retardo
        '
        Me.txt_retardo.BackColor = System.Drawing.SystemColors.Control
        Me.txt_retardo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_retardo.Location = New System.Drawing.Point(369, 38)
        Me.txt_retardo.Name = "txt_retardo"
        Me.txt_retardo.Size = New System.Drawing.Size(62, 20)
        Me.txt_retardo.TabIndex = 188
        Me.txt_retardo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_retardo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(437, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 190
        Me.Label6.Text = "Minutos."
        Me.Label6.Visible = False
        '
        'gbx_inicidencia
        '
        Me.gbx_inicidencia.Controls.Add(Me.lbl_hora)
        Me.gbx_inicidencia.Controls.Add(Me.lbl_hasta)
        Me.gbx_inicidencia.Controls.Add(Me.lbl_desde)
        Me.gbx_inicidencia.Controls.Add(Me.dtp1)
        Me.gbx_inicidencia.Controls.Add(Me.Label9)
        Me.gbx_inicidencia.Controls.Add(Me.Label5)
        Me.gbx_inicidencia.Controls.Add(Me.Label6)
        Me.gbx_inicidencia.Controls.Add(Me.Label2)
        Me.gbx_inicidencia.Controls.Add(Me.Label7)
        Me.gbx_inicidencia.Controls.Add(Me.txt_retardo)
        Me.gbx_inicidencia.Controls.Add(Me.lbl_ES)
        Me.gbx_inicidencia.Location = New System.Drawing.Point(3, 212)
        Me.gbx_inicidencia.Name = "gbx_inicidencia"
        Me.gbx_inicidencia.Size = New System.Drawing.Size(689, 100)
        Me.gbx_inicidencia.TabIndex = 191
        Me.gbx_inicidencia.TabStop = False
        Me.gbx_inicidencia.Text = "Incidencia"
        Me.gbx_inicidencia.Visible = False
        '
        'lbl_hasta
        '
        Me.lbl_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.lbl_hasta.Location = New System.Drawing.Point(76, 62)
        Me.lbl_hasta.Name = "lbl_hasta"
        Me.lbl_hasta.Size = New System.Drawing.Size(100, 20)
        Me.lbl_hasta.TabIndex = 196
        '
        'lbl_desde
        '
        Me.lbl_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.lbl_desde.Location = New System.Drawing.Point(76, 34)
        Me.lbl_desde.Name = "lbl_desde"
        Me.lbl_desde.Size = New System.Drawing.Size(100, 20)
        Me.lbl_desde.TabIndex = 195
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "HH:mm:ss"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(245, 35)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.ShowUpDown = True
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 194
        Me.dtp1.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(513, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 192
        Me.Label9.Text = "Hora Real"
        Me.Label9.Visible = False
        '
        'dtgvi
        '
        Me.dtgvi.AllowUserToAddRows = False
        Me.dtgvi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvi.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvi.Location = New System.Drawing.Point(5, 316)
        Me.dtgvi.Name = "dtgvi"
        Me.dtgvi.RowHeadersVisible = False
        Me.dtgvi.Size = New System.Drawing.Size(323, 186)
        Me.dtgvi.TabIndex = 192
        '
        'lbl_hora
        '
        Me.lbl_hora.CustomFormat = "HH:mm:ss"
        Me.lbl_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.lbl_hora.Location = New System.Drawing.Point(516, 41)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.ShowUpDown = True
        Me.lbl_hora.Size = New System.Drawing.Size(100, 20)
        Me.lbl_hora.TabIndex = 197
        Me.lbl_hora.Visible = False
        '
        'ValidaIncidenciaMultiple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 505)
        Me.Controls.Add(Me.dtgvi)
        Me.Controls.Add(Me.gbx_inicidencia)
        Me.Controls.Add(Me.Empleado)
        Me.Controls.Add(Me.Btn_autorizar)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ValidaIncidenciaMultiple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validación de Incidencia Múltiple"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.Empleado.ResumeLayout(False)
        Me.Empleado.PerformLayout()
        Me.gbx_inicidencia.ResumeLayout(False)
        Me.gbx_inicidencia.PerformLayout()
        CType(Me.dtgvi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents Btn_autorizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_folio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl_depto As Label
    Friend WithEvents lbl_turno As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_tipop As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_motivop As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Empleado As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_ES As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_retardo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gbx_inicidencia As GroupBox
    Friend WithEvents dtgvi As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents lbl_hasta As DateTimePicker
    Friend WithEvents lbl_desde As DateTimePicker
    Friend WithEvents lbl_hora As DateTimePicker
End Class
