<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PlanHorasExtra
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Rdb_Jpn = New System.Windows.Forms.RadioButton()
        Me.Rdb_Esp = New System.Windows.Forms.RadioButton()
        Me.Lbl_Depto = New System.Windows.Forms.Label()
        Me.Cmb_Departamento = New System.Windows.Forms.ComboBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lbl_año = New System.Windows.Forms.Label()
        Me.Lbl_Semana = New System.Windows.Forms.Label()
        Me.Cmb_Semanas = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_Dia3 = New System.Windows.Forms.Label()
        Me.Lbl_Dia4 = New System.Windows.Forms.Label()
        Me.Lbl_Dia7 = New System.Windows.Forms.Label()
        Me.Lbl_Dia5 = New System.Windows.Forms.Label()
        Me.Lbl_Dia1 = New System.Windows.Forms.Label()
        Me.Lbl_Dia6 = New System.Windows.Forms.Label()
        Me.Lbl_Dia2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Dgv_HorasExtra = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lbl_TotalDescLabSuma = New System.Windows.Forms.Label()
        Me.Lbl_DescLaborado = New System.Windows.Forms.Label()
        Me.Lbl_SueldoNetoSuma = New System.Windows.Forms.Label()
        Me.Lbl_SueldoBrutoSuma = New System.Windows.Forms.Label()
        Me.Lbl_TotalTriplesSum = New System.Windows.Forms.Label()
        Me.Lbl_TotalDoblesSum = New System.Windows.Forms.Label()
        Me.Lbl_HrsTriplesSum = New System.Windows.Forms.Label()
        Me.Lbl_HrsDoblesSum = New System.Windows.Forms.Label()
        Me.Lbl_Totales = New System.Windows.Forms.Label()
        Me.Lbl_SumMiercoles = New System.Windows.Forms.Label()
        Me.Lbl_SumJueves = New System.Windows.Forms.Label()
        Me.Lbl_SumDomingo = New System.Windows.Forms.Label()
        Me.Lbl_SumViernes = New System.Windows.Forms.Label()
        Me.Lbl_SumLunes = New System.Windows.Forms.Label()
        Me.Lbl_SumSabado = New System.Windows.Forms.Label()
        Me.Lbl_SumMartes = New System.Windows.Forms.Label()
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sueldoBruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sueldoNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lunes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.martes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.miercoles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jueves = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viernes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sabado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domingo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dobles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.triples = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descansoLaborado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalDobles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalTriples = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalDescLaborado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalBruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Dgv_HorasExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Lbl_Depto)
        Me.Panel1.Controls.Add(Me.Cmb_Departamento)
        Me.Panel1.Controls.Add(Me.Btn_Guardar)
        Me.Panel1.Controls.Add(Me.Lbl_año)
        Me.Panel1.Controls.Add(Me.Lbl_Semana)
        Me.Panel1.Controls.Add(Me.Cmb_Semanas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1341, 59)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Rdb_Jpn)
        Me.Panel6.Controls.Add(Me.Rdb_Esp)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1155, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(186, 59)
        Me.Panel6.TabIndex = 22
        '
        'Rdb_Jpn
        '
        Me.Rdb_Jpn.AutoSize = True
        Me.Rdb_Jpn.ForeColor = System.Drawing.Color.White
        Me.Rdb_Jpn.Location = New System.Drawing.Point(20, 33)
        Me.Rdb_Jpn.Name = "Rdb_Jpn"
        Me.Rdb_Jpn.Size = New System.Drawing.Size(61, 17)
        Me.Rdb_Jpn.TabIndex = 1
        Me.Rdb_Jpn.TabStop = True
        Me.Rdb_Jpn.Text = "日本語"
        Me.Rdb_Jpn.UseVisualStyleBackColor = True
        '
        'Rdb_Esp
        '
        Me.Rdb_Esp.AutoSize = True
        Me.Rdb_Esp.ForeColor = System.Drawing.Color.White
        Me.Rdb_Esp.Location = New System.Drawing.Point(20, 11)
        Me.Rdb_Esp.Name = "Rdb_Esp"
        Me.Rdb_Esp.Size = New System.Drawing.Size(63, 17)
        Me.Rdb_Esp.TabIndex = 0
        Me.Rdb_Esp.TabStop = True
        Me.Rdb_Esp.Text = "Español"
        Me.Rdb_Esp.UseVisualStyleBackColor = True
        '
        'Lbl_Depto
        '
        Me.Lbl_Depto.AutoSize = True
        Me.Lbl_Depto.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Depto.ForeColor = System.Drawing.Color.White
        Me.Lbl_Depto.Location = New System.Drawing.Point(133, 7)
        Me.Lbl_Depto.Name = "Lbl_Depto"
        Me.Lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Depto.TabIndex = 21
        Me.Lbl_Depto.Text = "Departamento"
        '
        'Cmb_Departamento
        '
        Me.Cmb_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Departamento.FormattingEnabled = True
        Me.Cmb_Departamento.Location = New System.Drawing.Point(136, 23)
        Me.Cmb_Departamento.Name = "Cmb_Departamento"
        Me.Cmb_Departamento.Size = New System.Drawing.Size(190, 21)
        Me.Cmb_Departamento.TabIndex = 20
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Enabled = False
        Me.Btn_Guardar.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(332, 7)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(56, 45)
        Me.Btn_Guardar.TabIndex = 19
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Lbl_año
        '
        Me.Lbl_año.AutoSize = True
        Me.Lbl_año.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_año.ForeColor = System.Drawing.Color.White
        Me.Lbl_año.Location = New System.Drawing.Point(101, 23)
        Me.Lbl_año.Name = "Lbl_año"
        Me.Lbl_año.Size = New System.Drawing.Size(25, 13)
        Me.Lbl_año.TabIndex = 18
        Me.Lbl_año.Text = "año"
        '
        'Lbl_Semana
        '
        Me.Lbl_Semana.AutoSize = True
        Me.Lbl_Semana.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Semana.ForeColor = System.Drawing.Color.White
        Me.Lbl_Semana.Location = New System.Drawing.Point(26, 7)
        Me.Lbl_Semana.Name = "Lbl_Semana"
        Me.Lbl_Semana.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Semana.TabIndex = 17
        Me.Lbl_Semana.Text = "Semana"
        '
        'Cmb_Semanas
        '
        Me.Cmb_Semanas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Semanas.FormattingEnabled = True
        Me.Cmb_Semanas.Location = New System.Drawing.Point(25, 23)
        Me.Cmb_Semanas.Name = "Cmb_Semanas"
        Me.Cmb_Semanas.Size = New System.Drawing.Size(70, 21)
        Me.Cmb_Semanas.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_Dia3)
        Me.Panel2.Controls.Add(Me.Lbl_Dia4)
        Me.Panel2.Controls.Add(Me.Lbl_Dia7)
        Me.Panel2.Controls.Add(Me.Lbl_Dia5)
        Me.Panel2.Controls.Add(Me.Lbl_Dia1)
        Me.Panel2.Controls.Add(Me.Lbl_Dia6)
        Me.Panel2.Controls.Add(Me.Lbl_Dia2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1341, 35)
        Me.Panel2.TabIndex = 1
        '
        'Lbl_Dia3
        '
        Me.Lbl_Dia3.AutoSize = True
        Me.Lbl_Dia3.Location = New System.Drawing.Point(555, 11)
        Me.Lbl_Dia3.Name = "Lbl_Dia3"
        Me.Lbl_Dia3.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia3.TabIndex = 13
        '
        'Lbl_Dia4
        '
        Me.Lbl_Dia4.AutoSize = True
        Me.Lbl_Dia4.Location = New System.Drawing.Point(610, 11)
        Me.Lbl_Dia4.Name = "Lbl_Dia4"
        Me.Lbl_Dia4.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia4.TabIndex = 14
        '
        'Lbl_Dia7
        '
        Me.Lbl_Dia7.AutoSize = True
        Me.Lbl_Dia7.Location = New System.Drawing.Point(773, 11)
        Me.Lbl_Dia7.Name = "Lbl_Dia7"
        Me.Lbl_Dia7.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia7.TabIndex = 17
        '
        'Lbl_Dia5
        '
        Me.Lbl_Dia5.AutoSize = True
        Me.Lbl_Dia5.Location = New System.Drawing.Point(665, 11)
        Me.Lbl_Dia5.Name = "Lbl_Dia5"
        Me.Lbl_Dia5.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia5.TabIndex = 15
        '
        'Lbl_Dia1
        '
        Me.Lbl_Dia1.AutoSize = True
        Me.Lbl_Dia1.Location = New System.Drawing.Point(445, 11)
        Me.Lbl_Dia1.Name = "Lbl_Dia1"
        Me.Lbl_Dia1.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia1.TabIndex = 11
        '
        'Lbl_Dia6
        '
        Me.Lbl_Dia6.AutoSize = True
        Me.Lbl_Dia6.Location = New System.Drawing.Point(720, 11)
        Me.Lbl_Dia6.Name = "Lbl_Dia6"
        Me.Lbl_Dia6.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia6.TabIndex = 16
        '
        'Lbl_Dia2
        '
        Me.Lbl_Dia2.AutoSize = True
        Me.Lbl_Dia2.Location = New System.Drawing.Point(500, 11)
        Me.Lbl_Dia2.Name = "Lbl_Dia2"
        Me.Lbl_Dia2.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1341, 482)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Dgv_HorasExtra)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1341, 446)
        Me.Panel5.TabIndex = 3
        '
        'Dgv_HorasExtra
        '
        Me.Dgv_HorasExtra.AllowUserToAddRows = False
        Me.Dgv_HorasExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_HorasExtra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clave, Me.nombre, Me.departamento, Me.idTurno, Me.sueldoBruto, Me.sueldoNeto, Me.lunes, Me.martes, Me.miercoles, Me.jueves, Me.viernes, Me.sabado, Me.domingo, Me.dobles, Me.triples, Me.descansoLaborado, Me.totalDobles, Me.totalTriples, Me.totalDescLaborado, Me.totalBruto, Me.TotalNeto})
        Me.Dgv_HorasExtra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_HorasExtra.Enabled = False
        Me.Dgv_HorasExtra.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_HorasExtra.Name = "Dgv_HorasExtra"
        Me.Dgv_HorasExtra.RowHeadersVisible = False
        Me.Dgv_HorasExtra.RowHeadersWidth = 25
        Me.Dgv_HorasExtra.Size = New System.Drawing.Size(1341, 446)
        Me.Dgv_HorasExtra.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Lbl_TotalDescLabSuma)
        Me.Panel4.Controls.Add(Me.Lbl_DescLaborado)
        Me.Panel4.Controls.Add(Me.Lbl_SueldoNetoSuma)
        Me.Panel4.Controls.Add(Me.Lbl_SueldoBrutoSuma)
        Me.Panel4.Controls.Add(Me.Lbl_TotalTriplesSum)
        Me.Panel4.Controls.Add(Me.Lbl_TotalDoblesSum)
        Me.Panel4.Controls.Add(Me.Lbl_HrsTriplesSum)
        Me.Panel4.Controls.Add(Me.Lbl_HrsDoblesSum)
        Me.Panel4.Controls.Add(Me.Lbl_Totales)
        Me.Panel4.Controls.Add(Me.Lbl_SumMiercoles)
        Me.Panel4.Controls.Add(Me.Lbl_SumJueves)
        Me.Panel4.Controls.Add(Me.Lbl_SumDomingo)
        Me.Panel4.Controls.Add(Me.Lbl_SumViernes)
        Me.Panel4.Controls.Add(Me.Lbl_SumLunes)
        Me.Panel4.Controls.Add(Me.Lbl_SumSabado)
        Me.Panel4.Controls.Add(Me.Lbl_SumMartes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 446)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1341, 36)
        Me.Panel4.TabIndex = 2
        '
        'Lbl_TotalDescLabSuma
        '
        Me.Lbl_TotalDescLabSuma.AutoSize = True
        Me.Lbl_TotalDescLabSuma.Location = New System.Drawing.Point(1140, 11)
        Me.Lbl_TotalDescLabSuma.Name = "Lbl_TotalDescLabSuma"
        Me.Lbl_TotalDescLabSuma.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TotalDescLabSuma.TabIndex = 26
        Me.Lbl_TotalDescLabSuma.Text = "Label8"
        Me.Lbl_TotalDescLabSuma.Visible = False
        '
        'Lbl_DescLaborado
        '
        Me.Lbl_DescLaborado.AutoSize = True
        Me.Lbl_DescLaborado.Location = New System.Drawing.Point(955, 11)
        Me.Lbl_DescLaborado.Name = "Lbl_DescLaborado"
        Me.Lbl_DescLaborado.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_DescLaborado.TabIndex = 25
        Me.Lbl_DescLaborado.Text = "Label7"
        '
        'Lbl_SueldoNetoSuma
        '
        Me.Lbl_SueldoNetoSuma.AutoSize = True
        Me.Lbl_SueldoNetoSuma.Location = New System.Drawing.Point(1270, 11)
        Me.Lbl_SueldoNetoSuma.Name = "Lbl_SueldoNetoSuma"
        Me.Lbl_SueldoNetoSuma.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_SueldoNetoSuma.TabIndex = 24
        Me.Lbl_SueldoNetoSuma.Text = "Label6"
        Me.Lbl_SueldoNetoSuma.Visible = False
        '
        'Lbl_SueldoBrutoSuma
        '
        Me.Lbl_SueldoBrutoSuma.AutoSize = True
        Me.Lbl_SueldoBrutoSuma.Location = New System.Drawing.Point(1205, 11)
        Me.Lbl_SueldoBrutoSuma.Name = "Lbl_SueldoBrutoSuma"
        Me.Lbl_SueldoBrutoSuma.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_SueldoBrutoSuma.TabIndex = 23
        Me.Lbl_SueldoBrutoSuma.Text = "Label5"
        Me.Lbl_SueldoBrutoSuma.Visible = False
        '
        'Lbl_TotalTriplesSum
        '
        Me.Lbl_TotalTriplesSum.AutoSize = True
        Me.Lbl_TotalTriplesSum.Location = New System.Drawing.Point(1075, 11)
        Me.Lbl_TotalTriplesSum.Name = "Lbl_TotalTriplesSum"
        Me.Lbl_TotalTriplesSum.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TotalTriplesSum.TabIndex = 22
        Me.Lbl_TotalTriplesSum.Text = "Label4"
        Me.Lbl_TotalTriplesSum.Visible = False
        '
        'Lbl_TotalDoblesSum
        '
        Me.Lbl_TotalDoblesSum.AutoSize = True
        Me.Lbl_TotalDoblesSum.Location = New System.Drawing.Point(1010, 11)
        Me.Lbl_TotalDoblesSum.Name = "Lbl_TotalDoblesSum"
        Me.Lbl_TotalDoblesSum.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_TotalDoblesSum.TabIndex = 21
        Me.Lbl_TotalDoblesSum.Text = "Label3"
        Me.Lbl_TotalDoblesSum.Visible = False
        '
        'Lbl_HrsTriplesSum
        '
        Me.Lbl_HrsTriplesSum.AutoSize = True
        Me.Lbl_HrsTriplesSum.Location = New System.Drawing.Point(893, 11)
        Me.Lbl_HrsTriplesSum.Name = "Lbl_HrsTriplesSum"
        Me.Lbl_HrsTriplesSum.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_HrsTriplesSum.TabIndex = 20
        Me.Lbl_HrsTriplesSum.Text = "Label2"
        '
        'Lbl_HrsDoblesSum
        '
        Me.Lbl_HrsDoblesSum.AutoSize = True
        Me.Lbl_HrsDoblesSum.Location = New System.Drawing.Point(831, 11)
        Me.Lbl_HrsDoblesSum.Name = "Lbl_HrsDoblesSum"
        Me.Lbl_HrsDoblesSum.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_HrsDoblesSum.TabIndex = 19
        Me.Lbl_HrsDoblesSum.Text = "Label1"
        '
        'Lbl_Totales
        '
        Me.Lbl_Totales.AutoSize = True
        Me.Lbl_Totales.Location = New System.Drawing.Point(337, 11)
        Me.Lbl_Totales.Name = "Lbl_Totales"
        Me.Lbl_Totales.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_Totales.TabIndex = 18
        Me.Lbl_Totales.Text = "TOTALES:"
        '
        'Lbl_SumMiercoles
        '
        Me.Lbl_SumMiercoles.AutoSize = True
        Me.Lbl_SumMiercoles.Location = New System.Drawing.Point(555, 11)
        Me.Lbl_SumMiercoles.Name = "Lbl_SumMiercoles"
        Me.Lbl_SumMiercoles.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_SumMiercoles.TabIndex = 13
        '
        'Lbl_SumJueves
        '
        Me.Lbl_SumJueves.AutoSize = True
        Me.Lbl_SumJueves.Location = New System.Drawing.Point(608, 11)
        Me.Lbl_SumJueves.Name = "Lbl_SumJueves"
        Me.Lbl_SumJueves.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_SumJueves.TabIndex = 14
        '
        'Lbl_SumDomingo
        '
        Me.Lbl_SumDomingo.AutoSize = True
        Me.Lbl_SumDomingo.Location = New System.Drawing.Point(775, 11)
        Me.Lbl_SumDomingo.Name = "Lbl_SumDomingo"
        Me.Lbl_SumDomingo.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_SumDomingo.TabIndex = 17
        '
        'Lbl_SumViernes
        '
        Me.Lbl_SumViernes.AutoSize = True
        Me.Lbl_SumViernes.Location = New System.Drawing.Point(664, 11)
        Me.Lbl_SumViernes.Name = "Lbl_SumViernes"
        Me.Lbl_SumViernes.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_SumViernes.TabIndex = 15
        '
        'Lbl_SumLunes
        '
        Me.Lbl_SumLunes.AutoSize = True
        Me.Lbl_SumLunes.Location = New System.Drawing.Point(445, 11)
        Me.Lbl_SumLunes.Name = "Lbl_SumLunes"
        Me.Lbl_SumLunes.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_SumLunes.TabIndex = 11
        '
        'Lbl_SumSabado
        '
        Me.Lbl_SumSabado.AutoSize = True
        Me.Lbl_SumSabado.Location = New System.Drawing.Point(721, 11)
        Me.Lbl_SumSabado.Name = "Lbl_SumSabado"
        Me.Lbl_SumSabado.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_SumSabado.TabIndex = 16
        '
        'Lbl_SumMartes
        '
        Me.Lbl_SumMartes.AutoSize = True
        Me.Lbl_SumMartes.Location = New System.Drawing.Point(499, 11)
        Me.Lbl_SumMartes.Name = "Lbl_SumMartes"
        Me.Lbl_SumMartes.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_SumMartes.TabIndex = 12
        '
        'clave
        '
        Me.clave.HeaderText = "Clave"
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        Me.clave.Width = 45
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'departamento
        '
        Me.departamento.HeaderText = "Departamento"
        Me.departamento.Name = "departamento"
        Me.departamento.ReadOnly = True
        Me.departamento.Width = 185
        '
        'idTurno
        '
        Me.idTurno.HeaderText = "IdTurno"
        Me.idTurno.Name = "idTurno"
        Me.idTurno.ReadOnly = True
        Me.idTurno.Visible = False
        '
        'sueldoBruto
        '
        Me.sueldoBruto.HeaderText = "Sueldo Bruto"
        Me.sueldoBruto.Name = "sueldoBruto"
        Me.sueldoBruto.ReadOnly = True
        Me.sueldoBruto.Visible = False
        '
        'sueldoNeto
        '
        Me.sueldoNeto.HeaderText = "Sueldo Neto"
        Me.sueldoNeto.Name = "sueldoNeto"
        Me.sueldoNeto.ReadOnly = True
        Me.sueldoNeto.Visible = False
        '
        'lunes
        '
        Me.lunes.HeaderText = "Lunes"
        Me.lunes.Name = "lunes"
        Me.lunes.Width = 55
        '
        'martes
        '
        Me.martes.HeaderText = "Martes"
        Me.martes.Name = "martes"
        Me.martes.Width = 55
        '
        'miercoles
        '
        Me.miercoles.HeaderText = "Miércoles"
        Me.miercoles.Name = "miercoles"
        Me.miercoles.Width = 55
        '
        'jueves
        '
        Me.jueves.HeaderText = "Jueves"
        Me.jueves.Name = "jueves"
        Me.jueves.Width = 55
        '
        'viernes
        '
        Me.viernes.HeaderText = "Viernes"
        Me.viernes.Name = "viernes"
        Me.viernes.Width = 55
        '
        'sabado
        '
        Me.sabado.HeaderText = "Sábado"
        Me.sabado.Name = "sabado"
        Me.sabado.Width = 55
        '
        'domingo
        '
        Me.domingo.HeaderText = "Domingo"
        Me.domingo.Name = "domingo"
        Me.domingo.Width = 55
        '
        'dobles
        '
        Me.dobles.HeaderText = "Horas Dobles"
        Me.dobles.Name = "dobles"
        Me.dobles.ReadOnly = True
        Me.dobles.Width = 60
        '
        'triples
        '
        Me.triples.HeaderText = "Horas Triples"
        Me.triples.Name = "triples"
        Me.triples.ReadOnly = True
        Me.triples.Width = 60
        '
        'descansoLaborado
        '
        Me.descansoLaborado.HeaderText = "Descanso Laborado"
        Me.descansoLaborado.Name = "descansoLaborado"
        Me.descansoLaborado.ReadOnly = True
        Me.descansoLaborado.Width = 60
        '
        'totalDobles
        '
        Me.totalDobles.HeaderText = "Total Dobles"
        Me.totalDobles.Name = "totalDobles"
        Me.totalDobles.ReadOnly = True
        Me.totalDobles.Visible = False
        Me.totalDobles.Width = 65
        '
        'totalTriples
        '
        Me.totalTriples.HeaderText = "Total Triples"
        Me.totalTriples.Name = "totalTriples"
        Me.totalTriples.ReadOnly = True
        Me.totalTriples.Visible = False
        Me.totalTriples.Width = 65
        '
        'totalDescLaborado
        '
        Me.totalDescLaborado.HeaderText = "Total Desc Laborado"
        Me.totalDescLaborado.Name = "totalDescLaborado"
        Me.totalDescLaborado.ReadOnly = True
        Me.totalDescLaborado.Visible = False
        Me.totalDescLaborado.Width = 65
        '
        'totalBruto
        '
        Me.totalBruto.HeaderText = "Bruto"
        Me.totalBruto.Name = "totalBruto"
        Me.totalBruto.ReadOnly = True
        Me.totalBruto.Visible = False
        Me.totalBruto.Width = 65
        '
        'TotalNeto
        '
        Me.TotalNeto.HeaderText = "Neto"
        Me.TotalNeto.Name = "TotalNeto"
        Me.TotalNeto.ReadOnly = True
        Me.TotalNeto.Visible = False
        Me.TotalNeto.Width = 65
        '
        'Frm_PlanHorasExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1341, 576)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_PlanHorasExtra"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan Tiempo Extra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.Dgv_HorasExtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Dgv_HorasExtra As DataGridView
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Lbl_año As Label
    Friend WithEvents Lbl_Semana As Label
    Friend WithEvents Cmb_Semanas As ComboBox
    Friend WithEvents Lbl_Depto As Label
    Friend WithEvents Cmb_Departamento As ComboBox
    Friend WithEvents Lbl_Dia3 As Label
    Friend WithEvents Lbl_Dia4 As Label
    Friend WithEvents Lbl_Dia7 As Label
    Friend WithEvents Lbl_Dia5 As Label
    Friend WithEvents Lbl_Dia1 As Label
    Friend WithEvents Lbl_Dia6 As Label
    Friend WithEvents Lbl_Dia2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Lbl_SumMiercoles As Label
    Friend WithEvents Lbl_SumJueves As Label
    Friend WithEvents Lbl_SumDomingo As Label
    Friend WithEvents Lbl_SumViernes As Label
    Friend WithEvents Lbl_SumLunes As Label
    Friend WithEvents Lbl_SumSabado As Label
    Friend WithEvents Lbl_SumMartes As Label
    Friend WithEvents Lbl_Totales As Label
    Friend WithEvents Lbl_SueldoNetoSuma As Label
    Friend WithEvents Lbl_SueldoBrutoSuma As Label
    Friend WithEvents Lbl_TotalTriplesSum As Label
    Friend WithEvents Lbl_TotalDoblesSum As Label
    Friend WithEvents Lbl_HrsTriplesSum As Label
    Friend WithEvents Lbl_HrsDoblesSum As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Lbl_DescLaborado As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Rdb_Jpn As RadioButton
    Friend WithEvents Rdb_Esp As RadioButton
    Friend WithEvents Lbl_TotalDescLabSuma As Label
    Friend WithEvents clave As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents departamento As DataGridViewTextBoxColumn
    Friend WithEvents idTurno As DataGridViewTextBoxColumn
    Friend WithEvents sueldoBruto As DataGridViewTextBoxColumn
    Friend WithEvents sueldoNeto As DataGridViewTextBoxColumn
    Friend WithEvents lunes As DataGridViewTextBoxColumn
    Friend WithEvents martes As DataGridViewTextBoxColumn
    Friend WithEvents miercoles As DataGridViewTextBoxColumn
    Friend WithEvents jueves As DataGridViewTextBoxColumn
    Friend WithEvents viernes As DataGridViewTextBoxColumn
    Friend WithEvents sabado As DataGridViewTextBoxColumn
    Friend WithEvents domingo As DataGridViewTextBoxColumn
    Friend WithEvents dobles As DataGridViewTextBoxColumn
    Friend WithEvents triples As DataGridViewTextBoxColumn
    Friend WithEvents descansoLaborado As DataGridViewTextBoxColumn
    Friend WithEvents totalDobles As DataGridViewTextBoxColumn
    Friend WithEvents totalTriples As DataGridViewTextBoxColumn
    Friend WithEvents totalDescLaborado As DataGridViewTextBoxColumn
    Friend WithEvents totalBruto As DataGridViewTextBoxColumn
    Friend WithEvents TotalNeto As DataGridViewTextBoxColumn
End Class
