<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedidasDisciplinarias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedidasDisciplinarias))
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_articulo = New System.Windows.Forms.TextBox()
        Me.cbx_tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_articuloinfracionado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_faltacometida = New System.Windows.Forms.TextBox()
        Me.txt_antecedente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbt_rescisión = New System.Windows.Forms.RadioButton()
        Me.rbt_suspensión = New System.Windows.Forms.RadioButton()
        Me.rbt_verbal = New System.Windows.Forms.RadioButton()
        Me.rbt_escrita = New System.Windows.Forms.RadioButton()
        Me.dtp_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dtgv_fechas = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgv_fechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.dtp1)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Location = New System.Drawing.Point(0, 1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1106, 50)
        Me.panel1.TabIndex = 146
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(1000, 13)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(831, 13)
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
        Me.GroupBox1.Location = New System.Drawing.Point(3, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 189)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleado"
        '
        'pbx
        '
        Me.pbx.ErrorImage = CType(resources.GetObject("pbx.ErrorImage"), System.Drawing.Image)
        Me.pbx.Location = New System.Drawing.Point(433, 19)
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
        Me.Label3.Location = New System.Drawing.Point(58, 101)
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
        Me.lbl1.Location = New System.Drawing.Point(62, 17)
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
        Me.lbl2.Location = New System.Drawing.Point(54, 44)
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
        Me.txt_puesto.Location = New System.Drawing.Point(123, 98)
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
        Me.txt_depto.Location = New System.Drawing.Point(123, 70)
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
        Me.txt_nombre.Location = New System.Drawing.Point(122, 41)
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
        Me.Label2.Location = New System.Drawing.Point(9, 158)
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
        Me.Label8.Location = New System.Drawing.Point(25, 73)
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
        Me.txt_clave.Location = New System.Drawing.Point(121, 14)
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
        Me.txt_ingreso.Location = New System.Drawing.Point(123, 155)
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
        Me.txt_turno.Location = New System.Drawing.Point(123, 126)
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
        Me.lbl4.Location = New System.Drawing.Point(64, 132)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(35, 13)
        Me.lbl4.TabIndex = 129
        Me.lbl4.Text = "Turno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(236, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "Artículo Infracionado"
        Me.Label4.Visible = False
        '
        'txt_articulo
        '
        Me.txt_articulo.BackColor = System.Drawing.SystemColors.Control
        Me.txt_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_articulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_articulo.Location = New System.Drawing.Point(249, 275)
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Size = New System.Drawing.Size(98, 20)
        Me.txt_articulo.TabIndex = 155
        Me.txt_articulo.Tag = "0"
        Me.txt_articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_articulo.Visible = False
        '
        'cbx_tipo
        '
        Me.cbx_tipo.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tipo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_tipo.FormattingEnabled = True
        Me.cbx_tipo.Items.AddRange(New Object() {"--Seleccionar--", "Obligaciones", "Prohibiciones"})
        Me.cbx_tipo.Location = New System.Drawing.Point(27, 275)
        Me.cbx_tipo.Name = "cbx_tipo"
        Me.cbx_tipo.Size = New System.Drawing.Size(136, 21)
        Me.cbx_tipo.TabIndex = 159
        Me.cbx_tipo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(70, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Tipo:"
        Me.Label5.Visible = False
        '
        'txt_articuloinfracionado
        '
        Me.txt_articuloinfracionado.BackColor = System.Drawing.SystemColors.Control
        Me.txt_articuloinfracionado.Enabled = False
        Me.txt_articuloinfracionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_articuloinfracionado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_articuloinfracionado.Location = New System.Drawing.Point(3, 303)
        Me.txt_articuloinfracionado.Multiline = True
        Me.txt_articuloinfracionado.Name = "txt_articuloinfracionado"
        Me.txt_articuloinfracionado.Size = New System.Drawing.Size(608, 80)
        Me.txt_articuloinfracionado.TabIndex = 160
        Me.txt_articuloinfracionado.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Falta Cometida"
        Me.Label6.Visible = False
        '
        'txt_faltacometida
        '
        Me.txt_faltacometida.BackColor = System.Drawing.SystemColors.Control
        Me.txt_faltacometida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_faltacometida.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_faltacometida.Location = New System.Drawing.Point(3, 410)
        Me.txt_faltacometida.MaxLength = 200
        Me.txt_faltacometida.Multiline = True
        Me.txt_faltacometida.Name = "txt_faltacometida"
        Me.txt_faltacometida.Size = New System.Drawing.Size(608, 53)
        Me.txt_faltacometida.TabIndex = 162
        Me.txt_faltacometida.Visible = False
        '
        'txt_antecedente
        '
        Me.txt_antecedente.BackColor = System.Drawing.SystemColors.Control
        Me.txt_antecedente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antecedente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_antecedente.Location = New System.Drawing.Point(3, 493)
        Me.txt_antecedente.MaxLength = 200
        Me.txt_antecedente.Multiline = True
        Me.txt_antecedente.Name = "txt_antecedente"
        Me.txt_antecedente.Size = New System.Drawing.Size(608, 49)
        Me.txt_antecedente.TabIndex = 164
        Me.txt_antecedente.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Antecedentes"
        Me.Label7.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 555)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 13)
        Me.Label9.TabIndex = 165
        Me.Label9.Text = "Tipo de Amonestación"
        Me.Label9.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbt_rescisión)
        Me.Panel2.Controls.Add(Me.rbt_suspensión)
        Me.Panel2.Controls.Add(Me.rbt_verbal)
        Me.Panel2.Controls.Add(Me.rbt_escrita)
        Me.Panel2.Location = New System.Drawing.Point(3, 571)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 36)
        Me.Panel2.TabIndex = 166
        Me.Panel2.Visible = False
        '
        'rbt_rescisión
        '
        Me.rbt_rescisión.AutoSize = True
        Me.rbt_rescisión.Location = New System.Drawing.Point(519, 9)
        Me.rbt_rescisión.Name = "rbt_rescisión"
        Me.rbt_rescisión.Size = New System.Drawing.Size(71, 17)
        Me.rbt_rescisión.TabIndex = 3
        Me.rbt_rescisión.TabStop = True
        Me.rbt_rescisión.Text = "Rescisión"
        Me.rbt_rescisión.UseVisualStyleBackColor = True
        '
        'rbt_suspensión
        '
        Me.rbt_suspensión.AutoSize = True
        Me.rbt_suspensión.Location = New System.Drawing.Point(313, 9)
        Me.rbt_suspensión.Name = "rbt_suspensión"
        Me.rbt_suspensión.Size = New System.Drawing.Size(80, 17)
        Me.rbt_suspensión.TabIndex = 2
        Me.rbt_suspensión.TabStop = True
        Me.rbt_suspensión.Text = "Suspensión"
        Me.rbt_suspensión.UseVisualStyleBackColor = True
        '
        'rbt_verbal
        '
        Me.rbt_verbal.AutoSize = True
        Me.rbt_verbal.Location = New System.Drawing.Point(13, 9)
        Me.rbt_verbal.Name = "rbt_verbal"
        Me.rbt_verbal.Size = New System.Drawing.Size(55, 17)
        Me.rbt_verbal.TabIndex = 1
        Me.rbt_verbal.TabStop = True
        Me.rbt_verbal.Text = "Verbal"
        Me.rbt_verbal.UseVisualStyleBackColor = True
        '
        'rbt_escrita
        '
        Me.rbt_escrita.AutoSize = True
        Me.rbt_escrita.Location = New System.Drawing.Point(162, 9)
        Me.rbt_escrita.Name = "rbt_escrita"
        Me.rbt_escrita.Size = New System.Drawing.Size(57, 17)
        Me.rbt_escrita.TabIndex = 0
        Me.rbt_escrita.TabStop = True
        Me.rbt_escrita.Text = "Escrita"
        Me.rbt_escrita.UseVisualStyleBackColor = True
        '
        'dtp_desde
        '
        Me.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_desde.Location = New System.Drawing.Point(16, 34)
        Me.dtp_desde.Name = "dtp_desde"
        Me.dtp_desde.Size = New System.Drawing.Size(100, 20)
        Me.dtp_desde.TabIndex = 167
        Me.dtp_desde.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(5, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 13)
        Me.Label10.TabIndex = 169
        Me.Label10.Text = "Fecha de Suspensión"
        Me.Label10.Visible = False
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.Enabled = False
        Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_solicitar.Location = New System.Drawing.Point(460, 681)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(133, 54)
        Me.btn_solicitar.TabIndex = 182
        Me.btn_solicitar.Text = "GUARDAR"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        Me.btn_solicitar.Visible = False
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToDeleteRows = False
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvp.Location = New System.Drawing.Point(617, 57)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(483, 740)
        Me.dtgvp.TabIndex = 183
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.btn_guardar.Location = New System.Drawing.Point(34, 93)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(63, 44)
        Me.btn_guardar.TabIndex = 184
        Me.btn_guardar.Text = "Agregar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'dtgv_fechas
        '
        Me.dtgv_fechas.AllowUserToAddRows = False
        Me.dtgv_fechas.AllowUserToDeleteRows = False
        Me.dtgv_fechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgv_fechas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgv_fechas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv_fechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_fechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha})
        Me.dtgv_fechas.Location = New System.Drawing.Point(174, 5)
        Me.dtgv_fechas.Name = "dtgv_fechas"
        Me.dtgv_fechas.RowHeadersVisible = False
        Me.dtgv_fechas.Size = New System.Drawing.Size(141, 182)
        Me.dtgv_fechas.TabIndex = 185
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Días de Suspención"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 118
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.dtp_desde)
        Me.Panel3.Controls.Add(Me.dtgv_fechas)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.btn_guardar)
        Me.Panel3.Location = New System.Drawing.Point(4, 610)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(450, 190)
        Me.Panel3.TabIndex = 186
        Me.Panel3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__1_
        Me.Button1.Location = New System.Drawing.Point(403, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 43)
        Me.Button1.TabIndex = 186
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MedidasDisciplinarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 802)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.btn_solicitar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_antecedente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_faltacometida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_articuloinfracionado)
        Me.Controls.Add(Me.cbx_tipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_articulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MedidasDisciplinarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicación de Medidas Disciplinarias"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgv_fechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbx As PictureBox
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
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_articulo As TextBox
    Friend WithEvents cbx_tipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_articuloinfracionado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_faltacometida As TextBox
    Friend WithEvents txt_antecedente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbt_rescisión As RadioButton
    Friend WithEvents rbt_suspensión As RadioButton
    Friend WithEvents rbt_verbal As RadioButton
    Friend WithEvents rbt_escrita As RadioButton
    Friend WithEvents dtp_desde As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents btn_guardar As Button
    Friend WithEvents dtgv_fechas As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
End Class
