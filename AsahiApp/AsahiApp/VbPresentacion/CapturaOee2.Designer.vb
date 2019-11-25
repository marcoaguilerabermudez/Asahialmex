<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturaOee2
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
        Me.cbx_cavidad = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbx_molde = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_turno = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_proceso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_maquina = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_pieza = New System.Windows.Forms.ComboBox()
        Me.lbl_pieza = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_utilizacion = New System.Windows.Forms.Label()
        Me.lbl_rendimiento = New System.Windows.Forms.Label()
        Me.lbl_calidad = New System.Windows.Forms.Label()
        Me.lbl_oee = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_tpo = New System.Windows.Forms.Label()
        Me.lbl_pp = New System.Windows.Forms.Label()
        Me.lbl_topp = New System.Windows.Forms.Label()
        Me.lbl_pnp = New System.Windows.Forms.Label()
        Me.lbl_topr = New System.Windows.Forms.Label()
        Me.lbl_png = New System.Windows.Forms.Label()
        Me.lbl_pc = New System.Windows.Forms.Label()
        Me.lbl_ct = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.Defecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefectoG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_error = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_tpza = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_ct2 = New System.Windows.Forms.Label()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbx_cavidad
        '
        Me.cbx_cavidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_cavidad.FormattingEnabled = True
        Me.cbx_cavidad.Location = New System.Drawing.Point(696, 29)
        Me.cbx_cavidad.Name = "cbx_cavidad"
        Me.cbx_cavidad.Size = New System.Drawing.Size(54, 21)
        Me.cbx_cavidad.TabIndex = 127
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(696, 11)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(46, 13)
        Me.Label38.TabIndex = 132
        Me.Label38.Text = "Cavidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 120
        '
        'cbx_molde
        '
        Me.cbx_molde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_molde.FormattingEnabled = True
        Me.cbx_molde.Location = New System.Drawing.Point(615, 29)
        Me.cbx_molde.Name = "cbx_molde"
        Me.cbx_molde.Size = New System.Drawing.Size(60, 21)
        Me.cbx_molde.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(617, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Molde"
        '
        'cbx_turno
        '
        Me.cbx_turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_turno.FormattingEnabled = True
        Me.cbx_turno.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbx_turno.Location = New System.Drawing.Point(775, 29)
        Me.cbx_turno.Name = "cbx_turno"
        Me.cbx_turno.Size = New System.Drawing.Size(58, 21)
        Me.cbx_turno.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(772, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Turno"
        '
        'cbx_proceso
        '
        Me.cbx_proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_proceso.FormattingEnabled = True
        Me.cbx_proceso.Items.AddRange(New Object() {"FUNDICION", "MAQUINADO", "LEAKTEST", "ENSAMBLE"})
        Me.cbx_proceso.Location = New System.Drawing.Point(129, 27)
        Me.cbx_proceso.Name = "cbx_proceso"
        Me.cbx_proceso.Size = New System.Drawing.Size(118, 21)
        Me.cbx_proceso.TabIndex = 121
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Proceso"
        '
        'cbx_maquina
        '
        Me.cbx_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_maquina.FormattingEnabled = True
        Me.cbx_maquina.Items.AddRange(New Object() {"XY", "CV", "NTC 2"})
        Me.cbx_maquina.Location = New System.Drawing.Point(277, 27)
        Me.cbx_maquina.Name = "cbx_maquina"
        Me.cbx_maquina.Size = New System.Drawing.Size(158, 21)
        Me.cbx_maquina.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(279, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Máquina"
        '
        'cbx_pieza
        '
        Me.cbx_pieza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_pieza.FormattingEnabled = True
        Me.cbx_pieza.Items.AddRange(New Object() {"11410-5R7A-0200", "31848-X421A", "31848-X420B", "31848-28X0A", "6H86030100", "6H86030400", "342511-31060", "342515-31020", "342511-32021-04", "342515-32021", "BJS7-39-011", "F2R5-25-740", "PEAR-15-17Z", "PEDD-10-121", "PEDD-10-131", "PEDD-10-141", "PEDD-10-161", "PEDD-14-311", "PEDD-15-17Z", "P54J-10-121", "P54G-10-141", "P54G-14-311", "BJS9-3908Y", "35652-TBG030", "35652-TBG040", "35621-TBG030", "35621-TBG040", "1094-375-032C", "49015-8010", "49015-8011", "11022-0044A", "11022-0045A", "11022-0046A", "11022-0047A", "11022-0048A", "31395-X421A", "6A7A", "6L59", "6L60", "6L61", "6L64", "6L66", "49015-8014", "6H4103000", "6H41030400", "31848-AB50A", "PEP9-10-190", "31395-X425A", "G2R5-25-740-C", "P5PW-10-190", "PEDD-10-190", "P54J-10-190", "P5", "PE", "197954-2220  (G2)"})
        Me.cbx_pieza.Location = New System.Drawing.Point(453, 28)
        Me.cbx_pieza.Name = "cbx_pieza"
        Me.cbx_pieza.Size = New System.Drawing.Size(148, 21)
        Me.cbx_pieza.TabIndex = 125
        '
        'lbl_pieza
        '
        Me.lbl_pieza.AutoSize = True
        Me.lbl_pieza.Location = New System.Drawing.Point(453, 11)
        Me.lbl_pieza.Name = "lbl_pieza"
        Me.lbl_pieza.Size = New System.Drawing.Size(33, 13)
        Me.lbl_pieza.TabIndex = 119
        Me.lbl_pieza.Text = "Pieza"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "% Utilización"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(242, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 18)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "% Rendimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(498, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 18)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "% Calidad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(735, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 18)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "% OEE"
        '
        'lbl_utilizacion
        '
        Me.lbl_utilizacion.AutoSize = True
        Me.lbl_utilizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_utilizacion.Location = New System.Drawing.Point(70, 104)
        Me.lbl_utilizacion.Name = "lbl_utilizacion"
        Me.lbl_utilizacion.Size = New System.Drawing.Size(16, 16)
        Me.lbl_utilizacion.TabIndex = 137
        Me.lbl_utilizacion.Text = "0"
        '
        'lbl_rendimiento
        '
        Me.lbl_rendimiento.AutoSize = True
        Me.lbl_rendimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rendimiento.Location = New System.Drawing.Point(288, 104)
        Me.lbl_rendimiento.Name = "lbl_rendimiento"
        Me.lbl_rendimiento.Size = New System.Drawing.Size(16, 16)
        Me.lbl_rendimiento.TabIndex = 138
        Me.lbl_rendimiento.Text = "0"
        '
        'lbl_calidad
        '
        Me.lbl_calidad.AutoSize = True
        Me.lbl_calidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calidad.Location = New System.Drawing.Point(522, 104)
        Me.lbl_calidad.Name = "lbl_calidad"
        Me.lbl_calidad.Size = New System.Drawing.Size(16, 16)
        Me.lbl_calidad.TabIndex = 139
        Me.lbl_calidad.Text = "0"
        '
        'lbl_oee
        '
        Me.lbl_oee.AutoSize = True
        Me.lbl_oee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_oee.Location = New System.Drawing.Point(749, 104)
        Me.lbl_oee.Name = "lbl_oee"
        Me.lbl_oee.Size = New System.Drawing.Size(16, 16)
        Me.lbl_oee.TabIndex = 140
        Me.lbl_oee.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 16)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "A        Tiempo Programado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 16)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "B        Paros Planeados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 16)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "D       Paros No Planeados"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(235, 16)
        Me.Label13.TabIndex = 143
        Me.Label13.Text = "C        Tiempo de Operación Planeado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 258)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(202, 16)
        Me.Label14.TabIndex = 145
        Me.Label14.Text = "E       Tiempo de Operación Real"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(486, 230)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 16)
        Me.Label15.TabIndex = 149
        Me.Label15.Text = "I            Producto NG"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(486, 201)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 16)
        Me.Label16.TabIndex = 148
        Me.Label16.Text = "H         Producto Conforme"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(486, 174)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(204, 16)
        Me.Label17.TabIndex = 147
        Me.Label17.Text = "G         Total de Pieza Producidas"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(486, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 16)
        Me.Label18.TabIndex = 146
        Me.Label18.Text = "F         CT por Pieza (min)"
        '
        'lbl_tpo
        '
        Me.lbl_tpo.AutoSize = True
        Me.lbl_tpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tpo.Location = New System.Drawing.Point(253, 145)
        Me.lbl_tpo.Name = "lbl_tpo"
        Me.lbl_tpo.Size = New System.Drawing.Size(0, 16)
        Me.lbl_tpo.TabIndex = 150
        '
        'lbl_pp
        '
        Me.lbl_pp.AutoSize = True
        Me.lbl_pp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pp.Location = New System.Drawing.Point(253, 174)
        Me.lbl_pp.Name = "lbl_pp"
        Me.lbl_pp.Size = New System.Drawing.Size(16, 16)
        Me.lbl_pp.TabIndex = 151
        Me.lbl_pp.Text = "0"
        '
        'lbl_topp
        '
        Me.lbl_topp.AutoSize = True
        Me.lbl_topp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_topp.Location = New System.Drawing.Point(253, 201)
        Me.lbl_topp.Name = "lbl_topp"
        Me.lbl_topp.Size = New System.Drawing.Size(16, 16)
        Me.lbl_topp.TabIndex = 152
        Me.lbl_topp.Text = "0"
        '
        'lbl_pnp
        '
        Me.lbl_pnp.AutoSize = True
        Me.lbl_pnp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pnp.Location = New System.Drawing.Point(253, 230)
        Me.lbl_pnp.Name = "lbl_pnp"
        Me.lbl_pnp.Size = New System.Drawing.Size(16, 16)
        Me.lbl_pnp.TabIndex = 153
        Me.lbl_pnp.Text = "0"
        '
        'lbl_topr
        '
        Me.lbl_topr.AutoSize = True
        Me.lbl_topr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_topr.Location = New System.Drawing.Point(253, 258)
        Me.lbl_topr.Name = "lbl_topr"
        Me.lbl_topr.Size = New System.Drawing.Size(0, 16)
        Me.lbl_topr.TabIndex = 154
        '
        'lbl_png
        '
        Me.lbl_png.AutoSize = True
        Me.lbl_png.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_png.Location = New System.Drawing.Point(719, 230)
        Me.lbl_png.Name = "lbl_png"
        Me.lbl_png.Size = New System.Drawing.Size(16, 16)
        Me.lbl_png.TabIndex = 158
        Me.lbl_png.Text = "0"
        '
        'lbl_pc
        '
        Me.lbl_pc.AutoSize = True
        Me.lbl_pc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pc.Location = New System.Drawing.Point(719, 201)
        Me.lbl_pc.Name = "lbl_pc"
        Me.lbl_pc.Size = New System.Drawing.Size(0, 16)
        Me.lbl_pc.TabIndex = 157
        '
        'lbl_ct
        '
        Me.lbl_ct.AutoSize = True
        Me.lbl_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ct.Location = New System.Drawing.Point(719, 145)
        Me.lbl_ct.Name = "lbl_ct"
        Me.lbl_ct.Size = New System.Drawing.Size(0, 16)
        Me.lbl_ct.TabIndex = 155
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToDeleteRows = False
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Defecto, Me.DefectoG, Me.Valor, Me.Valor2, Me.Cantidad, Me.id_error})
        Me.dtgvp.Location = New System.Drawing.Point(57, 7)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvp.Size = New System.Drawing.Size(657, 267)
        Me.dtgvp.TabIndex = 159
        '
        'Defecto
        '
        Me.Defecto.HeaderText = "Defecto"
        Me.Defecto.Name = "Defecto"
        Me.Defecto.Width = 70
        '
        'DefectoG
        '
        Me.DefectoG.HeaderText = "DefectoG"
        Me.DefectoG.Name = "DefectoG"
        Me.DefectoG.Width = 78
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.Visible = False
        Me.Valor.Width = 56
        '
        'Valor2
        '
        Me.Valor2.HeaderText = "Tipo"
        Me.Valor2.Name = "Valor2"
        Me.Valor2.Width = 53
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 74
        '
        'id_error
        '
        Me.id_error.HeaderText = "id_error"
        Me.id_error.Name = "id_error"
        Me.id_error.Visible = False
        Me.id_error.Width = 67
        '
        'btn_1
        '
        Me.btn_1.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.btn_1.Location = New System.Drawing.Point(720, 126)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(63, 56)
        Me.btn_1.TabIndex = 160
        Me.btn_1.Text = "Guardar"
        Me.btn_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__1_
        Me.btn_eliminar.Location = New System.Drawing.Point(10, 174)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(34, 43)
        Me.btn_eliminar.TabIndex = 161
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Silver
        Me.btn_agregar.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__1_
        Me.btn_agregar.Location = New System.Drawing.Point(10, 82)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(34, 43)
        Me.btn_agregar.TabIndex = 162
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'txt_tpza
        '
        Me.txt_tpza.Location = New System.Drawing.Point(720, 171)
        Me.txt_tpza.Name = "txt_tpza"
        Me.txt_tpza.Size = New System.Drawing.Size(36, 20)
        Me.txt_tpza.TabIndex = 163
        Me.txt_tpza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.btn_1)
        Me.Panel1.Controls.Add(Me.dtgvp)
        Me.Panel1.Location = New System.Drawing.Point(9, 282)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 282)
        Me.Panel1.TabIndex = 164
        '
        'lbl_ct2
        '
        Me.lbl_ct2.AutoSize = True
        Me.lbl_ct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ct2.Location = New System.Drawing.Point(791, 145)
        Me.lbl_ct2.Name = "lbl_ct2"
        Me.lbl_ct2.Size = New System.Drawing.Size(16, 16)
        Me.lbl_ct2.TabIndex = 165
        Me.lbl_ct2.Text = "0"
        '
        'CapturaOee2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 571)
        Me.Controls.Add(Me.lbl_ct2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_tpza)
        Me.Controls.Add(Me.lbl_png)
        Me.Controls.Add(Me.lbl_pc)
        Me.Controls.Add(Me.lbl_ct)
        Me.Controls.Add(Me.lbl_topr)
        Me.Controls.Add(Me.lbl_pnp)
        Me.Controls.Add(Me.lbl_topp)
        Me.Controls.Add(Me.lbl_pp)
        Me.Controls.Add(Me.lbl_tpo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_oee)
        Me.Controls.Add(Me.lbl_calidad)
        Me.Controls.Add(Me.lbl_rendimiento)
        Me.Controls.Add(Me.lbl_utilizacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbx_cavidad)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cbx_molde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_turno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbx_proceso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbx_maquina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbx_pieza)
        Me.Controls.Add(Me.lbl_pieza)
        Me.Name = "CapturaOee2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CapturaOee2"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_cavidad As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbx_molde As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_turno As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_proceso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_maquina As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_pieza As ComboBox
    Friend WithEvents lbl_pieza As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_utilizacion As Label
    Friend WithEvents lbl_rendimiento As Label
    Friend WithEvents lbl_calidad As Label
    Friend WithEvents lbl_oee As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_tpo As Label
    Friend WithEvents lbl_pp As Label
    Friend WithEvents lbl_topp As Label
    Friend WithEvents lbl_pnp As Label
    Friend WithEvents lbl_topr As Label
    Friend WithEvents lbl_png As Label
    Friend WithEvents lbl_pc As Label
    Friend WithEvents lbl_ct As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_tpza As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Defecto As DataGridViewTextBoxColumn
    Friend WithEvents DefectoG As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Valor2 As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents id_error As DataGridViewTextBoxColumn
    Friend WithEvents lbl_ct2 As Label
End Class
