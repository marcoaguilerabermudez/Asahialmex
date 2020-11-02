<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SolicitudTE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolicitudTE))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_horas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_textra = New System.Windows.Forms.ComboBox()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_depto = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txt_turno = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.x = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Btn_autorizar = New System.Windows.Forms.Button()
        Me.btn_preautorizar = New System.Windows.Forms.Button()
        Me.lbl_depto1 = New System.Windows.Forms.Label()
        Me.lbl_depto2 = New System.Windows.Forms.Label()
        Me.lbl_depto3 = New System.Windows.Forms.Label()
        Me.hs3 = New System.Windows.Forms.Label()
        Me.hs2 = New System.Windows.Forms.Label()
        Me.hs1 = New System.Windows.Forms.Label()
        Me.hd3 = New System.Windows.Forms.Label()
        Me.hd2 = New System.Windows.Forms.Label()
        Me.hd1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.hd4 = New System.Windows.Forms.Label()
        Me.hs4 = New System.Windows.Forms.Label()
        Me.lbl_depto4 = New System.Windows.Forms.Label()
        Me.di4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.di3 = New System.Windows.Forms.Label()
        Me.di2 = New System.Windows.Forms.Label()
        Me.di1 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.dtp1)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.Panel2)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.Panel3)
        Me.panel1.Controls.Add(Me.Label6)
        Me.panel1.Location = New System.Drawing.Point(1, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1013, 41)
        Me.panel1.TabIndex = 144
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(299, 9)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 20)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Solicitud de tiempo extra para el día:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.Panel2.Location = New System.Drawing.Point(737, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 22)
        Me.Panel2.TabIndex = 156
        Me.Panel2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(770, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Preautorizado"
        Me.Label2.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Green
        Me.Panel3.Location = New System.Drawing.Point(905, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(32, 22)
        Me.Panel3.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(938, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Autorizado"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_horas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_motivo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbx_textra)
        Me.GroupBox1.Controls.Add(Me.btn_solicitar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_depto)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Controls.Add(Me.txt_turno)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_clave)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(4, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 205)
        Me.GroupBox1.TabIndex = 152
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solicitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(428, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Horas"
        '
        'txt_horas
        '
        Me.txt_horas.BackColor = System.Drawing.SystemColors.Control
        Me.txt_horas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_horas.Location = New System.Drawing.Point(417, 87)
        Me.txt_horas.Name = "txt_horas"
        Me.txt_horas.Size = New System.Drawing.Size(62, 20)
        Me.txt_horas.TabIndex = 153
        Me.txt_horas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(39, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Motivo"
        '
        'txt_motivo
        '
        Me.txt_motivo.BackColor = System.Drawing.SystemColors.Control
        Me.txt_motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_motivo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_motivo.Location = New System.Drawing.Point(89, 140)
        Me.txt_motivo.Multiline = True
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(281, 52)
        Me.txt_motivo.TabIndex = 151
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(412, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Turno Extra"
        '
        'cbx_textra
        '
        Me.cbx_textra.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_textra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_textra.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_textra.FormattingEnabled = True
        Me.cbx_textra.Location = New System.Drawing.Point(379, 32)
        Me.cbx_textra.Name = "cbx_textra"
        Me.cbx_textra.Size = New System.Drawing.Size(142, 21)
        Me.cbx_textra.TabIndex = 148
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.ForeColor = System.Drawing.Color.Green
        Me.btn_solicitar.Location = New System.Drawing.Point(405, 165)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(90, 35)
        Me.btn_solicitar.TabIndex = 145
        Me.btn_solicitar.Text = "Solicitar"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(9, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Departamento"
        '
        'txt_depto
        '
        Me.txt_depto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_depto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_depto.Location = New System.Drawing.Point(89, 112)
        Me.txt_depto.Name = "txt_depto"
        Me.txt_depto.Size = New System.Drawing.Size(221, 20)
        Me.txt_depto.TabIndex = 130
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.SystemColors.Control
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(48, 86)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(35, 13)
        Me.lbl4.TabIndex = 129
        Me.lbl4.Text = "Turno"
        '
        'txt_turno
        '
        Me.txt_turno.BackColor = System.Drawing.SystemColors.Control
        Me.txt_turno.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_turno.Location = New System.Drawing.Point(89, 79)
        Me.txt_turno.Name = "txt_turno"
        Me.txt_turno.Size = New System.Drawing.Size(120, 20)
        Me.txt_turno.TabIndex = 128
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(39, 55)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(44, 13)
        Me.lbl2.TabIndex = 127
        Me.lbl2.Text = "Nombre"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(48, 22)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 126
        Me.lbl1.Text = "Clave"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(89, 50)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(281, 20)
        Me.txt_nombre.TabIndex = 125
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.SystemColors.Control
        Me.txt_clave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_clave.Location = New System.Drawing.Point(89, 19)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(98, 20)
        Me.txt_clave.TabIndex = 124
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToOrderColumns = True
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvp.Location = New System.Drawing.Point(7, 264)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(913, 276)
        Me.dtgvp.TabIndex = 159
        '
        'x
        '
        Me.x.HeaderText = "x"
        Me.x.Name = "x"
        Me.x.Width = 18
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.LightGray
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_eliminar.Location = New System.Drawing.Point(926, 429)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(77, 35)
        Me.btn_eliminar.TabIndex = 162
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Btn_autorizar
        '
        Me.Btn_autorizar.BackColor = System.Drawing.Color.LightGray
        Me.Btn_autorizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_autorizar.ForeColor = System.Drawing.Color.Green
        Me.Btn_autorizar.Location = New System.Drawing.Point(926, 496)
        Me.Btn_autorizar.Name = "Btn_autorizar"
        Me.Btn_autorizar.Size = New System.Drawing.Size(79, 35)
        Me.Btn_autorizar.TabIndex = 161
        Me.Btn_autorizar.Text = "Autorizar"
        Me.Btn_autorizar.UseVisualStyleBackColor = False
        '
        'btn_preautorizar
        '
        Me.btn_preautorizar.BackColor = System.Drawing.Color.LightGray
        Me.btn_preautorizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_preautorizar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_preautorizar.Location = New System.Drawing.Point(926, 388)
        Me.btn_preautorizar.Name = "btn_preautorizar"
        Me.btn_preautorizar.Size = New System.Drawing.Size(79, 35)
        Me.btn_preautorizar.TabIndex = 160
        Me.btn_preautorizar.Text = "Preautorizar"
        Me.btn_preautorizar.UseVisualStyleBackColor = False
        Me.btn_preautorizar.Visible = False
        '
        'lbl_depto1
        '
        Me.lbl_depto1.AutoSize = True
        Me.lbl_depto1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_depto1.ForeColor = System.Drawing.Color.Black
        Me.lbl_depto1.Location = New System.Drawing.Point(542, 90)
        Me.lbl_depto1.Name = "lbl_depto1"
        Me.lbl_depto1.Size = New System.Drawing.Size(0, 13)
        Me.lbl_depto1.TabIndex = 163
        '
        'lbl_depto2
        '
        Me.lbl_depto2.AutoSize = True
        Me.lbl_depto2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_depto2.ForeColor = System.Drawing.Color.Black
        Me.lbl_depto2.Location = New System.Drawing.Point(542, 120)
        Me.lbl_depto2.Name = "lbl_depto2"
        Me.lbl_depto2.Size = New System.Drawing.Size(0, 13)
        Me.lbl_depto2.TabIndex = 164
        '
        'lbl_depto3
        '
        Me.lbl_depto3.AutoSize = True
        Me.lbl_depto3.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_depto3.ForeColor = System.Drawing.Color.Black
        Me.lbl_depto3.Location = New System.Drawing.Point(542, 151)
        Me.lbl_depto3.Name = "lbl_depto3"
        Me.lbl_depto3.Size = New System.Drawing.Size(0, 13)
        Me.lbl_depto3.TabIndex = 165
        '
        'hs3
        '
        Me.hs3.AutoSize = True
        Me.hs3.BackColor = System.Drawing.SystemColors.Control
        Me.hs3.ForeColor = System.Drawing.Color.Black
        Me.hs3.Location = New System.Drawing.Point(799, 151)
        Me.hs3.Name = "hs3"
        Me.hs3.Size = New System.Drawing.Size(0, 13)
        Me.hs3.TabIndex = 168
        '
        'hs2
        '
        Me.hs2.AutoSize = True
        Me.hs2.BackColor = System.Drawing.SystemColors.Control
        Me.hs2.ForeColor = System.Drawing.Color.Black
        Me.hs2.Location = New System.Drawing.Point(799, 120)
        Me.hs2.Name = "hs2"
        Me.hs2.Size = New System.Drawing.Size(0, 13)
        Me.hs2.TabIndex = 167
        '
        'hs1
        '
        Me.hs1.AutoSize = True
        Me.hs1.BackColor = System.Drawing.SystemColors.Control
        Me.hs1.ForeColor = System.Drawing.Color.Black
        Me.hs1.Location = New System.Drawing.Point(799, 90)
        Me.hs1.Name = "hs1"
        Me.hs1.Size = New System.Drawing.Size(0, 13)
        Me.hs1.TabIndex = 166
        '
        'hd3
        '
        Me.hd3.AutoSize = True
        Me.hd3.BackColor = System.Drawing.SystemColors.Control
        Me.hd3.ForeColor = System.Drawing.Color.Black
        Me.hd3.Location = New System.Drawing.Point(894, 151)
        Me.hd3.Name = "hd3"
        Me.hd3.Size = New System.Drawing.Size(0, 13)
        Me.hd3.TabIndex = 171
        '
        'hd2
        '
        Me.hd2.AutoSize = True
        Me.hd2.BackColor = System.Drawing.SystemColors.Control
        Me.hd2.ForeColor = System.Drawing.Color.Black
        Me.hd2.Location = New System.Drawing.Point(894, 120)
        Me.hd2.Name = "hd2"
        Me.hd2.Size = New System.Drawing.Size(0, 13)
        Me.hd2.TabIndex = 170
        '
        'hd1
        '
        Me.hd1.AutoSize = True
        Me.hd1.BackColor = System.Drawing.SystemColors.Control
        Me.hd1.ForeColor = System.Drawing.Color.Black
        Me.hd1.Location = New System.Drawing.Point(894, 90)
        Me.hd1.Name = "hd1"
        Me.hd1.Size = New System.Drawing.Size(0, 13)
        Me.hd1.TabIndex = 169
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(542, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 172
        Me.Label14.Text = "Departamento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(855, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 173
        Me.Label15.Text = "Horas Solicitadas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(755, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 174
        Me.Label16.Text = "Horas Planeadas"
        '
        'hd4
        '
        Me.hd4.AutoSize = True
        Me.hd4.BackColor = System.Drawing.SystemColors.Control
        Me.hd4.ForeColor = System.Drawing.Color.Black
        Me.hd4.Location = New System.Drawing.Point(894, 180)
        Me.hd4.Name = "hd4"
        Me.hd4.Size = New System.Drawing.Size(0, 13)
        Me.hd4.TabIndex = 177
        '
        'hs4
        '
        Me.hs4.AutoSize = True
        Me.hs4.BackColor = System.Drawing.SystemColors.Control
        Me.hs4.ForeColor = System.Drawing.Color.Black
        Me.hs4.Location = New System.Drawing.Point(799, 180)
        Me.hs4.Name = "hs4"
        Me.hs4.Size = New System.Drawing.Size(0, 13)
        Me.hs4.TabIndex = 176
        '
        'lbl_depto4
        '
        Me.lbl_depto4.AutoSize = True
        Me.lbl_depto4.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_depto4.ForeColor = System.Drawing.Color.Black
        Me.lbl_depto4.Location = New System.Drawing.Point(542, 180)
        Me.lbl_depto4.Name = "lbl_depto4"
        Me.lbl_depto4.Size = New System.Drawing.Size(0, 13)
        Me.lbl_depto4.TabIndex = 175
        '
        'di4
        '
        Me.di4.AutoSize = True
        Me.di4.BackColor = System.Drawing.SystemColors.Control
        Me.di4.ForeColor = System.Drawing.Color.Black
        Me.di4.Location = New System.Drawing.Point(972, 181)
        Me.di4.Name = "di4"
        Me.di4.Size = New System.Drawing.Size(0, 13)
        Me.di4.TabIndex = 182
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(953, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "Disponible"
        '
        'di3
        '
        Me.di3.AutoSize = True
        Me.di3.BackColor = System.Drawing.SystemColors.Control
        Me.di3.ForeColor = System.Drawing.Color.Black
        Me.di3.Location = New System.Drawing.Point(972, 152)
        Me.di3.Name = "di3"
        Me.di3.Size = New System.Drawing.Size(0, 13)
        Me.di3.TabIndex = 180
        '
        'di2
        '
        Me.di2.AutoSize = True
        Me.di2.BackColor = System.Drawing.SystemColors.Control
        Me.di2.ForeColor = System.Drawing.Color.Black
        Me.di2.Location = New System.Drawing.Point(972, 121)
        Me.di2.Name = "di2"
        Me.di2.Size = New System.Drawing.Size(0, 13)
        Me.di2.TabIndex = 179
        '
        'di1
        '
        Me.di1.AutoSize = True
        Me.di1.BackColor = System.Drawing.SystemColors.Control
        Me.di1.ForeColor = System.Drawing.Color.Black
        Me.di1.Location = New System.Drawing.Point(972, 91)
        Me.di1.Name = "di1"
        Me.di1.Size = New System.Drawing.Size(0, 13)
        Me.di1.TabIndex = 178
        '
        'SolicitudTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 541)
        Me.Controls.Add(Me.di4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.di3)
        Me.Controls.Add(Me.di2)
        Me.Controls.Add(Me.di1)
        Me.Controls.Add(Me.hd4)
        Me.Controls.Add(Me.hs4)
        Me.Controls.Add(Me.lbl_depto4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.hd3)
        Me.Controls.Add(Me.hd2)
        Me.Controls.Add(Me.hd1)
        Me.Controls.Add(Me.hs3)
        Me.Controls.Add(Me.hs2)
        Me.Controls.Add(Me.hs1)
        Me.Controls.Add(Me.lbl_depto3)
        Me.Controls.Add(Me.lbl_depto2)
        Me.Controls.Add(Me.lbl_depto1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.Btn_autorizar)
        Me.Controls.Add(Me.btn_preautorizar)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SolicitudTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Tiempo Extra"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_motivo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_textra As ComboBox
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_depto As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txt_turno As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Btn_autorizar As Button
    Friend WithEvents btn_preautorizar As Button
    Friend WithEvents x As DataGridViewCheckBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_horas As TextBox
    Friend WithEvents lbl_depto1 As Label
    Friend WithEvents lbl_depto2 As Label
    Friend WithEvents lbl_depto3 As Label
    Friend WithEvents hs3 As Label
    Friend WithEvents hs2 As Label
    Friend WithEvents hs1 As Label
    Friend WithEvents hd3 As Label
    Friend WithEvents hd2 As Label
    Friend WithEvents hd1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents hd4 As Label
    Friend WithEvents hs4 As Label
    Friend WithEvents lbl_depto4 As Label
    Friend WithEvents di4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents di3 As Label
    Friend WithEvents di2 As Label
    Friend WithEvents di1 As Label
End Class
