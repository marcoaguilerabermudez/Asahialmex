<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EvaluacionPersonal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EvaluacionPersonal))
        Me.lbl_puesto = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl_evaluacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gpx_incidencias = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_r = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_v = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_n = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_p = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_g = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_f = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_u = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_puntosd = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.btn_evaluar = New System.Windows.Forms.Button()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.lbl_puntajetotal = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_puntajm = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gpx_incidencias.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_puesto
        '
        Me.lbl_puesto.AutoSize = True
        Me.lbl_puesto.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_puesto.ForeColor = System.Drawing.Color.White
        Me.lbl_puesto.Location = New System.Drawing.Point(114, 86)
        Me.lbl_puesto.Name = "lbl_puesto"
        Me.lbl_puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_puesto.TabIndex = 193
        Me.lbl_puesto.Text = "Puesto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(49, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "Puesto"
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_depto.ForeColor = System.Drawing.Color.White
        Me.lbl_depto.Location = New System.Drawing.Point(114, 63)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(74, 13)
        Me.lbl_depto.TabIndex = 191
        Me.lbl_depto.Text = "Departamento"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_nombre.ForeColor = System.Drawing.Color.White
        Me.lbl_nombre.Location = New System.Drawing.Point(114, 41)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nombre.TabIndex = 189
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_clave.ForeColor = System.Drawing.Color.White
        Me.lbl_clave.Location = New System.Drawing.Point(114, 20)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_clave.TabIndex = 188
        Me.lbl_clave.Text = "Clave"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 187
        Me.Label8.Text = "Departamento"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(45, 41)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(50, 13)
        Me.lbl2.TabIndex = 185
        Me.lbl2.Text = "Nombre"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(55, 20)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(39, 13)
        Me.lbl1.TabIndex = 184
        Me.lbl1.Text = "Clave"
        '
        'lbl_evaluacion
        '
        Me.lbl_evaluacion.AutoSize = True
        Me.lbl_evaluacion.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_evaluacion.ForeColor = System.Drawing.Color.White
        Me.lbl_evaluacion.Location = New System.Drawing.Point(114, 108)
        Me.lbl_evaluacion.Name = "lbl_evaluacion"
        Me.lbl_evaluacion.Size = New System.Drawing.Size(60, 13)
        Me.lbl_evaluacion.TabIndex = 196
        Me.lbl_evaluacion.Text = "Evaluacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "Evaluación"
        '
        'gpx_incidencias
        '
        Me.gpx_incidencias.Controls.Add(Me.Button1)
        Me.gpx_incidencias.Controls.Add(Me.lbl_r)
        Me.gpx_incidencias.Controls.Add(Me.Label4)
        Me.gpx_incidencias.Controls.Add(Me.lbl_v)
        Me.gpx_incidencias.Controls.Add(Me.Label16)
        Me.gpx_incidencias.Controls.Add(Me.Label13)
        Me.gpx_incidencias.Controls.Add(Me.lbl_n)
        Me.gpx_incidencias.Controls.Add(Me.Label15)
        Me.gpx_incidencias.Controls.Add(Me.lbl_p)
        Me.gpx_incidencias.Controls.Add(Me.Label7)
        Me.gpx_incidencias.Controls.Add(Me.lbl_g)
        Me.gpx_incidencias.Controls.Add(Me.Label10)
        Me.gpx_incidencias.Controls.Add(Me.lbl_f)
        Me.gpx_incidencias.Controls.Add(Me.Label5)
        Me.gpx_incidencias.Controls.Add(Me.lbl_u)
        Me.gpx_incidencias.Controls.Add(Me.Label3)
        Me.gpx_incidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpx_incidencias.ForeColor = System.Drawing.SystemColors.Control
        Me.gpx_incidencias.Location = New System.Drawing.Point(398, 4)
        Me.gpx_incidencias.Name = "gpx_incidencias"
        Me.gpx_incidencias.Size = New System.Drawing.Size(334, 152)
        Me.gpx_incidencias.TabIndex = 197
        Me.gpx_incidencias.TabStop = False
        Me.gpx_incidencias.Text = "Kárdex de incidencias"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Button1.Location = New System.Drawing.Point(235, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 42)
        Me.Button1.TabIndex = 246
        Me.Button1.Text = "Revisión"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbl_r
        '
        Me.lbl_r.AutoSize = True
        Me.lbl_r.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_r.ForeColor = System.Drawing.Color.White
        Me.lbl_r.Location = New System.Drawing.Point(305, 66)
        Me.lbl_r.Name = "lbl_r"
        Me.lbl_r.Size = New System.Drawing.Size(13, 13)
        Me.lbl_r.TabIndex = 203
        Me.lbl_r.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(225, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 202
        Me.Label4.Text = "Retardos"
        '
        'lbl_v
        '
        Me.lbl_v.AutoSize = True
        Me.lbl_v.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_v.ForeColor = System.Drawing.Color.White
        Me.lbl_v.Location = New System.Drawing.Point(137, 92)
        Me.lbl_v.Name = "lbl_v"
        Me.lbl_v.Size = New System.Drawing.Size(13, 13)
        Me.lbl_v.TabIndex = 201
        Me.lbl_v.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(43, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 200
        Me.Label16.Text = "Vacaciones"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(11, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 199
        '
        'lbl_n
        '
        Me.lbl_n.AutoSize = True
        Me.lbl_n.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_n.ForeColor = System.Drawing.Color.White
        Me.lbl_n.Location = New System.Drawing.Point(137, 67)
        Me.lbl_n.Name = "lbl_n"
        Me.lbl_n.Size = New System.Drawing.Size(13, 13)
        Me.lbl_n.TabIndex = 198
        Me.lbl_n.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(43, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 197
        Me.Label15.Text = "Suspensión"
        '
        'lbl_p
        '
        Me.lbl_p.AutoSize = True
        Me.lbl_p.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_p.ForeColor = System.Drawing.Color.White
        Me.lbl_p.Location = New System.Drawing.Point(305, 43)
        Me.lbl_p.Name = "lbl_p"
        Me.lbl_p.Size = New System.Drawing.Size(13, 13)
        Me.lbl_p.TabIndex = 196
        Me.lbl_p.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(178, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "Permiso sin Goce"
        '
        'lbl_g
        '
        Me.lbl_g.AutoSize = True
        Me.lbl_g.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_g.ForeColor = System.Drawing.Color.White
        Me.lbl_g.Location = New System.Drawing.Point(305, 19)
        Me.lbl_g.Name = "lbl_g"
        Me.lbl_g.Size = New System.Drawing.Size(13, 13)
        Me.lbl_g.TabIndex = 194
        Me.lbl_g.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(173, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 193
        Me.Label10.Text = "Permiso con Goce"
        '
        'lbl_f
        '
        Me.lbl_f.AutoSize = True
        Me.lbl_f.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_f.ForeColor = System.Drawing.Color.White
        Me.lbl_f.Location = New System.Drawing.Point(137, 44)
        Me.lbl_f.Name = "lbl_f"
        Me.lbl_f.Size = New System.Drawing.Size(13, 13)
        Me.lbl_f.TabIndex = 192
        Me.lbl_f.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 191
        Me.Label5.Text = "Falta Injustificada"
        '
        'lbl_u
        '
        Me.lbl_u.AutoSize = True
        Me.lbl_u.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl_u.ForeColor = System.Drawing.Color.White
        Me.lbl_u.Location = New System.Drawing.Point(137, 20)
        Me.lbl_u.Name = "lbl_u"
        Me.lbl_u.Size = New System.Drawing.Size(13, 13)
        Me.lbl_u.TabIndex = 190
        Me.lbl_u.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "Falta Justificada"
        '
        'lbl_puntosd
        '
        Me.lbl_puntosd.AutoSize = True
        Me.lbl_puntosd.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_puntosd.ForeColor = System.Drawing.Color.Black
        Me.lbl_puntosd.Location = New System.Drawing.Point(229, 137)
        Me.lbl_puntosd.Name = "lbl_puntosd"
        Me.lbl_puntosd.Size = New System.Drawing.Size(13, 13)
        Me.lbl_puntosd.TabIndex = 205
        Me.lbl_puntosd.Text = "0"
        Me.lbl_puntosd.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.SystemColors.Control
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(149, 137)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(57, 13)
        Me.Label44.TabIndex = 204
        Me.Label44.Text = "Puntos d"
        Me.Label44.Visible = False
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToDeleteRows = False
        Me.dtgvp.AllowUserToOrderColumns = True
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgvp.Location = New System.Drawing.Point(4, 170)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(456, 332)
        Me.dtgvp.TabIndex = 244
        '
        'btn_evaluar
        '
        Me.btn_evaluar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_evaluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_evaluar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_evaluar.Location = New System.Drawing.Point(775, 514)
        Me.btn_evaluar.Name = "btn_evaluar"
        Me.btn_evaluar.Size = New System.Drawing.Size(83, 42)
        Me.btn_evaluar.TabIndex = 245
        Me.btn_evaluar.Text = "Evaluar"
        Me.btn_evaluar.UseVisualStyleBackColor = False
        '
        'pbx
        '
        Me.pbx.ErrorImage = CType(resources.GetObject("pbx.ErrorImage"), System.Drawing.Image)
        Me.pbx.Location = New System.Drawing.Point(739, 11)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(132, 138)
        Me.pbx.TabIndex = 194
        Me.pbx.TabStop = False
        '
        'lbl_puntajetotal
        '
        Me.lbl_puntajetotal.AutoSize = True
        Me.lbl_puntajetotal.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_puntajetotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_puntajetotal.Location = New System.Drawing.Point(727, 541)
        Me.lbl_puntajetotal.Name = "lbl_puntajetotal"
        Me.lbl_puntajetotal.Size = New System.Drawing.Size(13, 13)
        Me.lbl_puntajetotal.TabIndex = 247
        Me.lbl_puntajetotal.Text = "0"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.SystemColors.Control
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(615, 541)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(83, 13)
        Me.Label45.TabIndex = 246
        Me.Label45.Text = "Puntaje Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 526)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.BackColor = System.Drawing.SystemColors.Control
        Me.txt_observaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observaciones.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_observaciones.Location = New System.Drawing.Point(100, 507)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(362, 50)
        Me.txt_observaciones.TabIndex = 248
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.lbl_depto)
        Me.Panel1.Controls.Add(Me.lbl_puntosd)
        Me.Panel1.Controls.Add(Me.lbl_nombre)
        Me.Panel1.Controls.Add(Me.lbl_clave)
        Me.Panel1.Controls.Add(Me.Label44)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbl2)
        Me.Panel1.Controls.Add(Me.lbl1)
        Me.Panel1.Controls.Add(Me.gpx_incidencias)
        Me.Panel1.Controls.Add(Me.pbx)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 161)
        Me.Panel1.TabIndex = 250
        '
        'lbl_puntajm
        '
        Me.lbl_puntajm.AutoSize = True
        Me.lbl_puntajm.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_puntajm.ForeColor = System.Drawing.Color.Black
        Me.lbl_puntajm.Location = New System.Drawing.Point(727, 514)
        Me.lbl_puntajm.Name = "lbl_puntajm"
        Me.lbl_puntajm.Size = New System.Drawing.Size(13, 13)
        Me.lbl_puntajm.TabIndex = 252
        Me.lbl_puntajm.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(606, 514)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 251
        Me.Label9.Text = "Puntaje Máximo"
        '
        'EvaluacionPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 561)
        Me.Controls.Add(Me.lbl_puntajm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.lbl_puntajetotal)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.btn_evaluar)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.lbl_evaluacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_puesto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EvaluacionPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluación Personal"
        Me.gpx_incidencias.ResumeLayout(False)
        Me.gpx_incidencias.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_puesto As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_depto As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_clave As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents pbx As PictureBox
    Friend WithEvents lbl_evaluacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gpx_incidencias As GroupBox
    Friend WithEvents lbl_v As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_n As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_p As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_g As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_f As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_u As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_r As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_puntosd As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents btn_evaluar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_puntajetotal As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_observaciones As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_puntajm As Label
    Friend WithEvents Label9 As Label
End Class
