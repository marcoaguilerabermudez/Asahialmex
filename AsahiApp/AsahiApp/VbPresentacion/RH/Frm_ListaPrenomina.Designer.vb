<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ListaPrenomina
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
        Me.Dgv_ListaPrenomina = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horarioEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamentoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manual1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnl1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manual2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnl2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manual3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnl3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manual4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnl4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manual5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnl5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manual6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnl6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manual7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnl7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aplicaBono = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.modificaBono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idModificaBono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacional = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbl_Dia1 = New System.Windows.Forms.Label()
        Me.Lbl_Dia2 = New System.Windows.Forms.Label()
        Me.Lbl_Dia4 = New System.Windows.Forms.Label()
        Me.Lbl_Dia3 = New System.Windows.Forms.Label()
        Me.lbl_Dia7 = New System.Windows.Forms.Label()
        Me.lbl_Dia6 = New System.Windows.Forms.Label()
        Me.Lbl_Dia5 = New System.Windows.Forms.Label()
        Me.Lbl_año = New System.Windows.Forms.Label()
        Me.Cmb_Semanas = New System.Windows.Forms.ComboBox()
        Me.Lbl_Semana = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dtp_FechaInicioSemana = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_GuardarBono = New System.Windows.Forms.Button()
        Me.Btn_Reporte = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Excel = New System.Windows.Forms.Button()
        Me.Bgw_HiloSegundoPlano = New System.ComponentModel.BackgroundWorker()
        Me.Btn_Mostrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txt_FiltroDpto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_FiltroHorario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_FiltroNombre = New System.Windows.Forms.TextBox()
        Me.Lbl_FiltroId = New System.Windows.Forms.Label()
        Me.Txt_FiltroId = New System.Windows.Forms.TextBox()
        CType(Me.Dgv_ListaPrenomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_ListaPrenomina
        '
        Me.Dgv_ListaPrenomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaPrenomina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombreEmpleado, Me.horarioEmpleado, Me.departamentoEmpleado, Me.ingreso, Me.E, Me.S, Me.entrada1, Me.salida1, Me.manual1, Me.b1, Me.mnl1, Me.entrada2, Me.salida2, Me.manual2, Me.b2, Me.mnl2, Me.entrada3, Me.salida3, Me.manual3, Me.b3, Me.mnl3, Me.entrada4, Me.salida4, Me.manual4, Me.b4, Me.mnl4, Me.entrada5, Me.salida5, Me.manual5, Me.b5, Me.mnl5, Me.entrada6, Me.salida6, Me.manual6, Me.b6, Me.mnl6, Me.entrada7, Me.salida7, Me.manual7, Me.b7, Me.mnl7, Me.comentarios, Me.aplicaBono, Me.modificaBono, Me.idModificaBono, Me.idTurno, Me.nacional, Me.puesto, Me.manual})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListaPrenomina.DefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListaPrenomina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_ListaPrenomina.Enabled = False
        Me.Dgv_ListaPrenomina.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_ListaPrenomina.Name = "Dgv_ListaPrenomina"
        Me.Dgv_ListaPrenomina.RowHeadersVisible = False
        Me.Dgv_ListaPrenomina.RowHeadersWidth = 15
        Me.Dgv_ListaPrenomina.RowTemplate.Height = 50
        Me.Dgv_ListaPrenomina.Size = New System.Drawing.Size(1197, 439)
        Me.Dgv_ListaPrenomina.TabIndex = 0
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "Id"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Width = 40
        '
        'nombreEmpleado
        '
        Me.nombreEmpleado.HeaderText = "Nombre"
        Me.nombreEmpleado.Name = "nombreEmpleado"
        Me.nombreEmpleado.ReadOnly = True
        Me.nombreEmpleado.Width = 200
        '
        'horarioEmpleado
        '
        Me.horarioEmpleado.HeaderText = "Horario"
        Me.horarioEmpleado.Name = "horarioEmpleado"
        Me.horarioEmpleado.ReadOnly = True
        '
        'departamentoEmpleado
        '
        Me.departamentoEmpleado.HeaderText = "Departamento"
        Me.departamentoEmpleado.Name = "departamentoEmpleado"
        Me.departamentoEmpleado.ReadOnly = True
        '
        'ingreso
        '
        Me.ingreso.HeaderText = "Ingreso"
        Me.ingreso.Name = "ingreso"
        Me.ingreso.ReadOnly = True
        Me.ingreso.Visible = False
        '
        'E
        '
        Me.E.HeaderText = "E"
        Me.E.Name = "E"
        Me.E.ReadOnly = True
        Me.E.Visible = False
        '
        'S
        '
        Me.S.HeaderText = "S"
        Me.S.Name = "S"
        Me.S.ReadOnly = True
        Me.S.Visible = False
        '
        'entrada1
        '
        Me.entrada1.HeaderText = "E1"
        Me.entrada1.Name = "entrada1"
        Me.entrada1.Width = 38
        '
        'salida1
        '
        Me.salida1.HeaderText = "S1"
        Me.salida1.Name = "salida1"
        Me.salida1.Width = 38
        '
        'manual1
        '
        Me.manual1.HeaderText = "M1"
        Me.manual1.Name = "manual1"
        Me.manual1.Visible = False
        '
        'b1
        '
        Me.b1.HeaderText = "B1"
        Me.b1.Name = "b1"
        Me.b1.ReadOnly = True
        Me.b1.Visible = False
        '
        'mnl1
        '
        Me.mnl1.HeaderText = "ML1"
        Me.mnl1.Name = "mnl1"
        Me.mnl1.ReadOnly = True
        Me.mnl1.Visible = False
        '
        'entrada2
        '
        Me.entrada2.HeaderText = "E2"
        Me.entrada2.Name = "entrada2"
        Me.entrada2.Width = 38
        '
        'salida2
        '
        Me.salida2.HeaderText = "S2"
        Me.salida2.Name = "salida2"
        Me.salida2.Width = 38
        '
        'manual2
        '
        Me.manual2.HeaderText = "M2"
        Me.manual2.Name = "manual2"
        Me.manual2.Visible = False
        '
        'b2
        '
        Me.b2.HeaderText = "B2"
        Me.b2.Name = "b2"
        Me.b2.ReadOnly = True
        Me.b2.Visible = False
        '
        'mnl2
        '
        Me.mnl2.HeaderText = "ML2"
        Me.mnl2.Name = "mnl2"
        Me.mnl2.ReadOnly = True
        Me.mnl2.Visible = False
        '
        'entrada3
        '
        Me.entrada3.HeaderText = "E3"
        Me.entrada3.Name = "entrada3"
        Me.entrada3.Width = 38
        '
        'salida3
        '
        Me.salida3.HeaderText = "S3"
        Me.salida3.Name = "salida3"
        Me.salida3.Width = 38
        '
        'manual3
        '
        Me.manual3.HeaderText = "M3"
        Me.manual3.Name = "manual3"
        Me.manual3.Visible = False
        '
        'b3
        '
        Me.b3.HeaderText = "B3"
        Me.b3.Name = "b3"
        Me.b3.ReadOnly = True
        Me.b3.Visible = False
        '
        'mnl3
        '
        Me.mnl3.HeaderText = "ML3"
        Me.mnl3.Name = "mnl3"
        Me.mnl3.ReadOnly = True
        Me.mnl3.Visible = False
        '
        'entrada4
        '
        Me.entrada4.HeaderText = "E4"
        Me.entrada4.Name = "entrada4"
        Me.entrada4.Width = 38
        '
        'salida4
        '
        Me.salida4.HeaderText = "S4"
        Me.salida4.Name = "salida4"
        Me.salida4.Width = 38
        '
        'manual4
        '
        Me.manual4.HeaderText = "M4"
        Me.manual4.Name = "manual4"
        Me.manual4.Visible = False
        '
        'b4
        '
        Me.b4.HeaderText = "B4"
        Me.b4.Name = "b4"
        Me.b4.ReadOnly = True
        Me.b4.Visible = False
        '
        'mnl4
        '
        Me.mnl4.HeaderText = "ML4"
        Me.mnl4.Name = "mnl4"
        Me.mnl4.ReadOnly = True
        Me.mnl4.Visible = False
        '
        'entrada5
        '
        Me.entrada5.HeaderText = "E5"
        Me.entrada5.Name = "entrada5"
        Me.entrada5.Width = 38
        '
        'salida5
        '
        Me.salida5.HeaderText = "S5"
        Me.salida5.Name = "salida5"
        Me.salida5.Width = 38
        '
        'manual5
        '
        Me.manual5.HeaderText = "M5"
        Me.manual5.Name = "manual5"
        Me.manual5.Visible = False
        '
        'b5
        '
        Me.b5.HeaderText = "B5"
        Me.b5.Name = "b5"
        Me.b5.ReadOnly = True
        Me.b5.Visible = False
        '
        'mnl5
        '
        Me.mnl5.HeaderText = "ML5"
        Me.mnl5.Name = "mnl5"
        Me.mnl5.ReadOnly = True
        Me.mnl5.Visible = False
        '
        'entrada6
        '
        Me.entrada6.HeaderText = "E6"
        Me.entrada6.Name = "entrada6"
        Me.entrada6.Width = 38
        '
        'salida6
        '
        Me.salida6.HeaderText = "S6"
        Me.salida6.Name = "salida6"
        Me.salida6.Width = 38
        '
        'manual6
        '
        Me.manual6.HeaderText = "M6"
        Me.manual6.Name = "manual6"
        Me.manual6.Visible = False
        '
        'b6
        '
        Me.b6.HeaderText = "B6"
        Me.b6.Name = "b6"
        Me.b6.ReadOnly = True
        Me.b6.Visible = False
        '
        'mnl6
        '
        Me.mnl6.HeaderText = "ML6"
        Me.mnl6.Name = "mnl6"
        Me.mnl6.ReadOnly = True
        Me.mnl6.Visible = False
        '
        'entrada7
        '
        Me.entrada7.HeaderText = "E7"
        Me.entrada7.Name = "entrada7"
        Me.entrada7.Width = 38
        '
        'salida7
        '
        Me.salida7.HeaderText = "S7"
        Me.salida7.Name = "salida7"
        Me.salida7.Width = 38
        '
        'manual7
        '
        Me.manual7.HeaderText = "M7"
        Me.manual7.Name = "manual7"
        Me.manual7.Visible = False
        '
        'b7
        '
        Me.b7.HeaderText = "B7"
        Me.b7.Name = "b7"
        Me.b7.ReadOnly = True
        Me.b7.Visible = False
        '
        'mnl7
        '
        Me.mnl7.HeaderText = "ML7"
        Me.mnl7.Name = "mnl7"
        Me.mnl7.ReadOnly = True
        Me.mnl7.Visible = False
        '
        'comentarios
        '
        Me.comentarios.HeaderText = "Comentarios"
        Me.comentarios.Name = "comentarios"
        Me.comentarios.Width = 150
        '
        'aplicaBono
        '
        Me.aplicaBono.HeaderText = "Aplica bono"
        Me.aplicaBono.Name = "aplicaBono"
        Me.aplicaBono.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.aplicaBono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.aplicaBono.Width = 45
        '
        'modificaBono
        '
        Me.modificaBono.HeaderText = "MB"
        Me.modificaBono.Name = "modificaBono"
        Me.modificaBono.ReadOnly = True
        Me.modificaBono.Visible = False
        '
        'idModificaBono
        '
        Me.idModificaBono.HeaderText = "IMB"
        Me.idModificaBono.Name = "idModificaBono"
        Me.idModificaBono.ReadOnly = True
        Me.idModificaBono.Visible = False
        '
        'idTurno
        '
        Me.idTurno.HeaderText = "IdTurno"
        Me.idTurno.Name = "idTurno"
        Me.idTurno.Visible = False
        '
        'nacional
        '
        Me.nacional.HeaderText = "Nacional"
        Me.nacional.Name = "nacional"
        Me.nacional.ReadOnly = True
        Me.nacional.Visible = False
        '
        'puesto
        '
        Me.puesto.HeaderText = "Puesto"
        Me.puesto.Name = "puesto"
        Me.puesto.ReadOnly = True
        Me.puesto.Visible = False
        '
        'manual
        '
        Me.manual.HeaderText = "Manual"
        Me.manual.Name = "manual"
        Me.manual.ReadOnly = True
        Me.manual.Visible = False
        '
        'Lbl_Dia1
        '
        Me.Lbl_Dia1.AutoSize = True
        Me.Lbl_Dia1.Location = New System.Drawing.Point(464, 20)
        Me.Lbl_Dia1.Name = "Lbl_Dia1"
        Me.Lbl_Dia1.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia1.TabIndex = 4
        '
        'Lbl_Dia2
        '
        Me.Lbl_Dia2.AutoSize = True
        Me.Lbl_Dia2.Location = New System.Drawing.Point(541, 20)
        Me.Lbl_Dia2.Name = "Lbl_Dia2"
        Me.Lbl_Dia2.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia2.TabIndex = 5
        '
        'Lbl_Dia4
        '
        Me.Lbl_Dia4.AutoSize = True
        Me.Lbl_Dia4.Location = New System.Drawing.Point(693, 20)
        Me.Lbl_Dia4.Name = "Lbl_Dia4"
        Me.Lbl_Dia4.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia4.TabIndex = 7
        '
        'Lbl_Dia3
        '
        Me.Lbl_Dia3.AutoSize = True
        Me.Lbl_Dia3.Location = New System.Drawing.Point(617, 20)
        Me.Lbl_Dia3.Name = "Lbl_Dia3"
        Me.Lbl_Dia3.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia3.TabIndex = 6
        '
        'lbl_Dia7
        '
        Me.lbl_Dia7.AutoSize = True
        Me.lbl_Dia7.Location = New System.Drawing.Point(920, 20)
        Me.lbl_Dia7.Name = "lbl_Dia7"
        Me.lbl_Dia7.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Dia7.TabIndex = 10
        '
        'lbl_Dia6
        '
        Me.lbl_Dia6.AutoSize = True
        Me.lbl_Dia6.Location = New System.Drawing.Point(844, 20)
        Me.lbl_Dia6.Name = "lbl_Dia6"
        Me.lbl_Dia6.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Dia6.TabIndex = 9
        '
        'Lbl_Dia5
        '
        Me.Lbl_Dia5.AutoSize = True
        Me.Lbl_Dia5.Location = New System.Drawing.Point(769, 20)
        Me.Lbl_Dia5.Name = "Lbl_Dia5"
        Me.Lbl_Dia5.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia5.TabIndex = 8
        '
        'Lbl_año
        '
        Me.Lbl_año.AutoSize = True
        Me.Lbl_año.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_año.ForeColor = System.Drawing.Color.White
        Me.Lbl_año.Location = New System.Drawing.Point(108, 22)
        Me.Lbl_año.Name = "Lbl_año"
        Me.Lbl_año.Size = New System.Drawing.Size(25, 13)
        Me.Lbl_año.TabIndex = 3
        Me.Lbl_año.Text = "año"
        '
        'Cmb_Semanas
        '
        Me.Cmb_Semanas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Semanas.Enabled = False
        Me.Cmb_Semanas.FormattingEnabled = True
        Me.Cmb_Semanas.Location = New System.Drawing.Point(14, 21)
        Me.Cmb_Semanas.Name = "Cmb_Semanas"
        Me.Cmb_Semanas.Size = New System.Drawing.Size(87, 21)
        Me.Cmb_Semanas.TabIndex = 1
        '
        'Lbl_Semana
        '
        Me.Lbl_Semana.AutoSize = True
        Me.Lbl_Semana.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Semana.ForeColor = System.Drawing.Color.White
        Me.Lbl_Semana.Location = New System.Drawing.Point(15, 5)
        Me.Lbl_Semana.Name = "Lbl_Semana"
        Me.Lbl_Semana.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Semana.TabIndex = 2
        Me.Lbl_Semana.Text = "Semana"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(150, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha inicio semana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Dtp_FechaInicioSemana
        '
        Me.Dtp_FechaInicioSemana.Checked = False
        Me.Dtp_FechaInicioSemana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaInicioSemana.Location = New System.Drawing.Point(234, 18)
        Me.Dtp_FechaInicioSemana.Name = "Dtp_FechaInicioSemana"
        Me.Dtp_FechaInicioSemana.Size = New System.Drawing.Size(109, 20)
        Me.Dtp_FechaInicioSemana.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Btn_GuardarBono)
        Me.Panel1.Controls.Add(Me.Btn_Reporte)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Btn_Excel)
        Me.Panel1.Controls.Add(Me.Dtp_FechaInicioSemana)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1197, 60)
        Me.Panel1.TabIndex = 14
        '
        'Btn_GuardarBono
        '
        Me.Btn_GuardarBono.Enabled = False
        Me.Btn_GuardarBono.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GuardarBono.Image = Global.Presentacion.My.Resources.Resources.Acumulado
        Me.Btn_GuardarBono.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_GuardarBono.Location = New System.Drawing.Point(591, 5)
        Me.Btn_GuardarBono.Name = "Btn_GuardarBono"
        Me.Btn_GuardarBono.Size = New System.Drawing.Size(81, 41)
        Me.Btn_GuardarBono.TabIndex = 31
        Me.Btn_GuardarBono.Text = "Guardar Bono"
        Me.Btn_GuardarBono.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_GuardarBono.UseVisualStyleBackColor = True
        '
        'Btn_Reporte
        '
        Me.Btn_Reporte.Image = Global.Presentacion.My.Resources.Resources.reportes
        Me.Btn_Reporte.Location = New System.Drawing.Point(523, 6)
        Me.Btn_Reporte.Name = "Btn_Reporte"
        Me.Btn_Reporte.Size = New System.Drawing.Size(49, 40)
        Me.Btn_Reporte.TabIndex = 30
        Me.Btn_Reporte.UseVisualStyleBackColor = True
        Me.Btn_Reporte.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Btn_Guardar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1044, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(153, 60)
        Me.Panel5.TabIndex = 16
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(41, 8)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(53, 43)
        Me.Btn_Guardar.TabIndex = 14
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        Me.Btn_Guardar.Visible = False
        '
        'Btn_Excel
        '
        Me.Btn_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Excel.Image = Global.Presentacion.My.Resources.Resources.Excel1
        Me.Btn_Excel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Excel.Location = New System.Drawing.Point(436, 8)
        Me.Btn_Excel.Name = "Btn_Excel"
        Me.Btn_Excel.Size = New System.Drawing.Size(53, 40)
        Me.Btn_Excel.TabIndex = 15
        Me.Btn_Excel.Text = "Exp. Emp"
        Me.Btn_Excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Excel.UseVisualStyleBackColor = True
        '
        'Bgw_HiloSegundoPlano
        '
        Me.Bgw_HiloSegundoPlano.WorkerReportsProgress = True
        Me.Bgw_HiloSegundoPlano.WorkerSupportsCancellation = True
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__2_
        Me.Btn_Mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Mostrar.Location = New System.Drawing.Point(355, 8)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(50, 40)
        Me.Btn_Mostrar.TabIndex = 15
        Me.Btn_Mostrar.Text = "Mostrar"
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1197, 482)
        Me.Panel2.TabIndex = 16
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Dgv_ListaPrenomina)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1197, 439)
        Me.Panel4.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Txt_FiltroDpto)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Txt_FiltroHorario)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Txt_FiltroNombre)
        Me.Panel3.Controls.Add(Me.Lbl_FiltroId)
        Me.Panel3.Controls.Add(Me.Txt_FiltroId)
        Me.Panel3.Controls.Add(Me.Lbl_Dia3)
        Me.Panel3.Controls.Add(Me.Lbl_Dia4)
        Me.Panel3.Controls.Add(Me.lbl_Dia7)
        Me.Panel3.Controls.Add(Me.Lbl_Dia5)
        Me.Panel3.Controls.Add(Me.Lbl_Dia1)
        Me.Panel3.Controls.Add(Me.lbl_Dia6)
        Me.Panel3.Controls.Add(Me.Lbl_Dia2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1197, 43)
        Me.Panel3.TabIndex = 11
        '
        'Txt_FiltroDpto
        '
        Me.Txt_FiltroDpto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_FiltroDpto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_FiltroDpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FiltroDpto.Location = New System.Drawing.Point(345, 20)
        Me.Txt_FiltroDpto.Name = "Txt_FiltroDpto"
        Me.Txt_FiltroDpto.Size = New System.Drawing.Size(96, 18)
        Me.Txt_FiltroDpto.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 12)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "DEPARTAMENTO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "HORARIO:"
        '
        'Txt_FiltroHorario
        '
        Me.Txt_FiltroHorario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_FiltroHorario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_FiltroHorario.Enabled = False
        Me.Txt_FiltroHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FiltroHorario.Location = New System.Drawing.Point(244, 20)
        Me.Txt_FiltroHorario.Name = "Txt_FiltroHorario"
        Me.Txt_FiltroHorario.Size = New System.Drawing.Size(94, 18)
        Me.Txt_FiltroHorario.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "NOMBRE:"
        '
        'Txt_FiltroNombre
        '
        Me.Txt_FiltroNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_FiltroNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_FiltroNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_FiltroNombre.Enabled = False
        Me.Txt_FiltroNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FiltroNombre.Location = New System.Drawing.Point(46, 20)
        Me.Txt_FiltroNombre.Name = "Txt_FiltroNombre"
        Me.Txt_FiltroNombre.Size = New System.Drawing.Size(192, 18)
        Me.Txt_FiltroNombre.TabIndex = 13
        '
        'Lbl_FiltroId
        '
        Me.Lbl_FiltroId.AutoSize = True
        Me.Lbl_FiltroId.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FiltroId.Location = New System.Drawing.Point(1, 5)
        Me.Lbl_FiltroId.Name = "Lbl_FiltroId"
        Me.Lbl_FiltroId.Size = New System.Drawing.Size(40, 12)
        Me.Lbl_FiltroId.TabIndex = 12
        Me.Lbl_FiltroId.Text = "CLAVE:"
        '
        'Txt_FiltroId
        '
        Me.Txt_FiltroId.Enabled = False
        Me.Txt_FiltroId.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FiltroId.Location = New System.Drawing.Point(2, 20)
        Me.Txt_FiltroId.Name = "Txt_FiltroId"
        Me.Txt_FiltroId.Size = New System.Drawing.Size(40, 18)
        Me.Txt_FiltroId.TabIndex = 11
        '
        'Frm_ListaPrenomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 542)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btn_Mostrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_año)
        Me.Controls.Add(Me.Lbl_Semana)
        Me.Controls.Add(Me.Cmb_Semanas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_ListaPrenomina"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Prenomina"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dgv_ListaPrenomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_ListaPrenomina As DataGridView
    Friend WithEvents Lbl_Dia1 As Label
    Friend WithEvents Lbl_Dia2 As Label
    Friend WithEvents Lbl_Dia4 As Label
    Friend WithEvents Lbl_Dia3 As Label
    Friend WithEvents lbl_Dia7 As Label
    Friend WithEvents lbl_Dia6 As Label
    Friend WithEvents Lbl_Dia5 As Label
    Friend WithEvents Lbl_año As Label
    Friend WithEvents Cmb_Semanas As ComboBox
    Friend WithEvents Lbl_Semana As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Dtp_FechaInicioSemana As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Mostrar As Button
    Friend WithEvents Bgw_HiloSegundoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Excel As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Lbl_FiltroId As Label
    Friend WithEvents Txt_FiltroId As TextBox
    Friend WithEvents Btn_Reporte As Button
    Friend WithEvents Btn_GuardarBono As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_FiltroNombre As TextBox
    Friend WithEvents Txt_FiltroHorario As TextBox
    Friend WithEvents Txt_FiltroDpto As TextBox
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents horarioEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents departamentoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents ingreso As DataGridViewTextBoxColumn
    Friend WithEvents E As DataGridViewTextBoxColumn
    Friend WithEvents S As DataGridViewTextBoxColumn
    Friend WithEvents entrada1 As DataGridViewTextBoxColumn
    Friend WithEvents salida1 As DataGridViewTextBoxColumn
    Friend WithEvents manual1 As DataGridViewTextBoxColumn
    Friend WithEvents b1 As DataGridViewTextBoxColumn
    Friend WithEvents mnl1 As DataGridViewTextBoxColumn
    Friend WithEvents entrada2 As DataGridViewTextBoxColumn
    Friend WithEvents salida2 As DataGridViewTextBoxColumn
    Friend WithEvents manual2 As DataGridViewTextBoxColumn
    Friend WithEvents b2 As DataGridViewTextBoxColumn
    Friend WithEvents mnl2 As DataGridViewTextBoxColumn
    Friend WithEvents entrada3 As DataGridViewTextBoxColumn
    Friend WithEvents salida3 As DataGridViewTextBoxColumn
    Friend WithEvents manual3 As DataGridViewTextBoxColumn
    Friend WithEvents b3 As DataGridViewTextBoxColumn
    Friend WithEvents mnl3 As DataGridViewTextBoxColumn
    Friend WithEvents entrada4 As DataGridViewTextBoxColumn
    Friend WithEvents salida4 As DataGridViewTextBoxColumn
    Friend WithEvents manual4 As DataGridViewTextBoxColumn
    Friend WithEvents b4 As DataGridViewTextBoxColumn
    Friend WithEvents mnl4 As DataGridViewTextBoxColumn
    Friend WithEvents entrada5 As DataGridViewTextBoxColumn
    Friend WithEvents salida5 As DataGridViewTextBoxColumn
    Friend WithEvents manual5 As DataGridViewTextBoxColumn
    Friend WithEvents b5 As DataGridViewTextBoxColumn
    Friend WithEvents mnl5 As DataGridViewTextBoxColumn
    Friend WithEvents entrada6 As DataGridViewTextBoxColumn
    Friend WithEvents salida6 As DataGridViewTextBoxColumn
    Friend WithEvents manual6 As DataGridViewTextBoxColumn
    Friend WithEvents b6 As DataGridViewTextBoxColumn
    Friend WithEvents mnl6 As DataGridViewTextBoxColumn
    Friend WithEvents entrada7 As DataGridViewTextBoxColumn
    Friend WithEvents salida7 As DataGridViewTextBoxColumn
    Friend WithEvents manual7 As DataGridViewTextBoxColumn
    Friend WithEvents b7 As DataGridViewTextBoxColumn
    Friend WithEvents mnl7 As DataGridViewTextBoxColumn
    Friend WithEvents comentarios As DataGridViewTextBoxColumn
    Friend WithEvents aplicaBono As DataGridViewCheckBoxColumn
    Friend WithEvents modificaBono As DataGridViewTextBoxColumn
    Friend WithEvents idModificaBono As DataGridViewTextBoxColumn
    Friend WithEvents idTurno As DataGridViewTextBoxColumn
    Friend WithEvents nacional As DataGridViewTextBoxColumn
    Friend WithEvents puesto As DataGridViewTextBoxColumn
    Friend WithEvents manual As DataGridViewTextBoxColumn
End Class
