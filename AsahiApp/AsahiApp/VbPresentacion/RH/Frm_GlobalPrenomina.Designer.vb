<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GlobalPrenomina
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
        Me.Btn_Excel = New System.Windows.Forms.Button()
        Me.Btn_Txt = New System.Windows.Forms.Button()
        Me.Lbl_SemaF = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_SemaI = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_año = New System.Windows.Forms.Label()
        Me.Lbl_Semana = New System.Windows.Forms.Label()
        Me.Cmb_Semanas = New System.Windows.Forms.ComboBox()
        Me.Dtp_FechaInicioSemana = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Mostrar = New System.Windows.Forms.Button()
        Me.Dgv_Prenomina_Global = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spBono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamentoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.turnoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurnoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.retardo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permisoSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.falta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.faltaJustificada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suspension = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permisoSinSueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permisoConSueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permisoMaternidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incapacidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vacaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ujap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dJap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.umex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dMex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jpMx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mxJp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.suma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_Dia7 = New System.Windows.Forms.Label()
        Me.lbl_Dia6 = New System.Windows.Forms.Label()
        Me.Lbl_Dia5 = New System.Windows.Forms.Label()
        Me.Lbl_Dia4 = New System.Windows.Forms.Label()
        Me.Lbl_Dia3 = New System.Windows.Forms.Label()
        Me.Lbl_Dia2 = New System.Windows.Forms.Label()
        Me.Lbl_Dia1 = New System.Windows.Forms.Label()
        Me.Dgv_Lista = New System.Windows.Forms.DataGridView()
        Me.idEmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrsAprobadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbl_FiltroId = New System.Windows.Forms.Label()
        Me.Txt_FiltroId = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv_Prenomina_Global, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Btn_Excel)
        Me.Panel1.Controls.Add(Me.Btn_Txt)
        Me.Panel1.Controls.Add(Me.Lbl_SemaF)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Lbl_SemaI)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Lbl_año)
        Me.Panel1.Controls.Add(Me.Lbl_Semana)
        Me.Panel1.Controls.Add(Me.Cmb_Semanas)
        Me.Panel1.Controls.Add(Me.Dtp_FechaInicioSemana)
        Me.Panel1.Controls.Add(Me.Btn_Mostrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1253, 54)
        Me.Panel1.TabIndex = 15
        '
        'Btn_Excel
        '
        Me.Btn_Excel.Image = Global.Presentacion.My.Resources.Resources.Excel1
        Me.Btn_Excel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Excel.Location = New System.Drawing.Point(439, 9)
        Me.Btn_Excel.Name = "Btn_Excel"
        Me.Btn_Excel.Size = New System.Drawing.Size(41, 39)
        Me.Btn_Excel.TabIndex = 27
        Me.Btn_Excel.Text = "Excel"
        Me.Btn_Excel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Excel.UseVisualStyleBackColor = True
        Me.Btn_Excel.Visible = False
        '
        'Btn_Txt
        '
        Me.Btn_Txt.Image = Global.Presentacion.My.Resources.Resources.txt1
        Me.Btn_Txt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Txt.Location = New System.Drawing.Point(494, 9)
        Me.Btn_Txt.Name = "Btn_Txt"
        Me.Btn_Txt.Size = New System.Drawing.Size(41, 39)
        Me.Btn_Txt.TabIndex = 26
        Me.Btn_Txt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Txt.UseVisualStyleBackColor = True
        Me.Btn_Txt.Visible = False
        '
        'Lbl_SemaF
        '
        Me.Lbl_SemaF.AutoSize = True
        Me.Lbl_SemaF.ForeColor = System.Drawing.Color.White
        Me.Lbl_SemaF.Location = New System.Drawing.Point(700, 25)
        Me.Lbl_SemaF.Name = "Lbl_SemaF"
        Me.Lbl_SemaF.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_SemaF.TabIndex = 25
        Me.Lbl_SemaF.Text = "00/00/2000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(687, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "a"
        '
        'Lbl_SemaI
        '
        Me.Lbl_SemaI.AutoSize = True
        Me.Lbl_SemaI.ForeColor = System.Drawing.Color.White
        Me.Lbl_SemaI.Location = New System.Drawing.Point(622, 25)
        Me.Lbl_SemaI.Name = "Lbl_SemaI"
        Me.Lbl_SemaI.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_SemaI.TabIndex = 23
        Me.Lbl_SemaI.Text = "00/00/2000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(561, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Semana del"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 26)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha inicio semana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lbl_año
        '
        Me.Lbl_año.AutoSize = True
        Me.Lbl_año.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_año.ForeColor = System.Drawing.Color.White
        Me.Lbl_año.Location = New System.Drawing.Point(134, 23)
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
        Me.Lbl_Semana.Location = New System.Drawing.Point(41, 6)
        Me.Lbl_Semana.Name = "Lbl_Semana"
        Me.Lbl_Semana.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Semana.TabIndex = 17
        Me.Lbl_Semana.Text = "Semana"
        '
        'Cmb_Semanas
        '
        Me.Cmb_Semanas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Semanas.Enabled = False
        Me.Cmb_Semanas.FormattingEnabled = True
        Me.Cmb_Semanas.Location = New System.Drawing.Point(40, 22)
        Me.Cmb_Semanas.Name = "Cmb_Semanas"
        Me.Cmb_Semanas.Size = New System.Drawing.Size(87, 21)
        Me.Cmb_Semanas.TabIndex = 16
        '
        'Dtp_FechaInicioSemana
        '
        Me.Dtp_FechaInicioSemana.Checked = False
        Me.Dtp_FechaInicioSemana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaInicioSemana.Location = New System.Drawing.Point(248, 19)
        Me.Dtp_FechaInicioSemana.Name = "Dtp_FechaInicioSemana"
        Me.Dtp_FechaInicioSemana.Size = New System.Drawing.Size(109, 20)
        Me.Dtp_FechaInicioSemana.TabIndex = 20
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__2_
        Me.Btn_Mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Mostrar.Location = New System.Drawing.Point(373, 9)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(50, 39)
        Me.Btn_Mostrar.TabIndex = 21
        Me.Btn_Mostrar.Text = "Mostrar"
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Dgv_Prenomina_Global
        '
        Me.Dgv_Prenomina_Global.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Prenomina_Global.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombreEmpleado, Me.lun, Me.te1, Me.cm1, Me.mar, Me.te2, Me.cm2, Me.mie, Me.te3, Me.cm3, Me.jue, Me.te4, Me.cm4, Me.vie, Me.te5, Me.cm5, Me.sab, Me.te6, Me.cm6, Me.dom, Me.te7, Me.cm7, Me.te, Me.com, Me.cm, Me.sp, Me.spBono, Me.departamentoEmpleado, Me.turnoEmpleado, Me.idTurnoEmpleado, Me.retardo, Me.permisoSalida, Me.falta, Me.faltaJustificada, Me.suspension, Me.permisoSinSueldo, Me.permisoConSueldo, Me.permisoMaternidad, Me.incapacidad, Me.vacaciones, Me.ujap, Me.dJap, Me.umex, Me.dMex, Me.jpMx, Me.mxJp, Me.suma, Me.diferencia, Me.grupo})
        Me.Dgv_Prenomina_Global.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Prenomina_Global.Enabled = False
        Me.Dgv_Prenomina_Global.GridColor = System.Drawing.Color.SteelBlue
        Me.Dgv_Prenomina_Global.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_Prenomina_Global.Name = "Dgv_Prenomina_Global"
        Me.Dgv_Prenomina_Global.RowHeadersVisible = False
        Me.Dgv_Prenomina_Global.RowTemplate.Height = 20
        Me.Dgv_Prenomina_Global.Size = New System.Drawing.Size(1253, 466)
        Me.Dgv_Prenomina_Global.TabIndex = 0
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
        Me.nombreEmpleado.Width = 230
        '
        'lun
        '
        Me.lun.HeaderText = "Lun"
        Me.lun.Name = "lun"
        Me.lun.ReadOnly = True
        Me.lun.Width = 35
        '
        'te1
        '
        Me.te1.HeaderText = "TE1"
        Me.te1.Name = "te1"
        Me.te1.ReadOnly = True
        Me.te1.Width = 35
        '
        'cm1
        '
        Me.cm1.HeaderText = "CM1"
        Me.cm1.Name = "cm1"
        Me.cm1.ReadOnly = True
        Me.cm1.Width = 35
        '
        'mar
        '
        Me.mar.HeaderText = "Mar"
        Me.mar.Name = "mar"
        Me.mar.ReadOnly = True
        Me.mar.Width = 35
        '
        'te2
        '
        Me.te2.HeaderText = "TE2"
        Me.te2.Name = "te2"
        Me.te2.ReadOnly = True
        Me.te2.Width = 35
        '
        'cm2
        '
        Me.cm2.HeaderText = "CM2"
        Me.cm2.Name = "cm2"
        Me.cm2.ReadOnly = True
        Me.cm2.Width = 35
        '
        'mie
        '
        Me.mie.HeaderText = "Mie"
        Me.mie.Name = "mie"
        Me.mie.ReadOnly = True
        Me.mie.Width = 35
        '
        'te3
        '
        Me.te3.HeaderText = "TE3"
        Me.te3.Name = "te3"
        Me.te3.ReadOnly = True
        Me.te3.Width = 35
        '
        'cm3
        '
        Me.cm3.HeaderText = "CM3"
        Me.cm3.Name = "cm3"
        Me.cm3.ReadOnly = True
        Me.cm3.Width = 35
        '
        'jue
        '
        Me.jue.HeaderText = "Jue"
        Me.jue.Name = "jue"
        Me.jue.ReadOnly = True
        Me.jue.Width = 35
        '
        'te4
        '
        Me.te4.HeaderText = "TE4"
        Me.te4.Name = "te4"
        Me.te4.ReadOnly = True
        Me.te4.Width = 35
        '
        'cm4
        '
        Me.cm4.HeaderText = "CM4"
        Me.cm4.Name = "cm4"
        Me.cm4.ReadOnly = True
        Me.cm4.Width = 35
        '
        'vie
        '
        Me.vie.HeaderText = "Vie"
        Me.vie.Name = "vie"
        Me.vie.ReadOnly = True
        Me.vie.Width = 35
        '
        'te5
        '
        Me.te5.HeaderText = "TE5"
        Me.te5.Name = "te5"
        Me.te5.ReadOnly = True
        Me.te5.Width = 35
        '
        'cm5
        '
        Me.cm5.HeaderText = "CM5"
        Me.cm5.Name = "cm5"
        Me.cm5.ReadOnly = True
        Me.cm5.Width = 35
        '
        'sab
        '
        Me.sab.HeaderText = "Sab"
        Me.sab.Name = "sab"
        Me.sab.ReadOnly = True
        Me.sab.Width = 35
        '
        'te6
        '
        Me.te6.HeaderText = "TE6"
        Me.te6.Name = "te6"
        Me.te6.ReadOnly = True
        Me.te6.Width = 35
        '
        'cm6
        '
        Me.cm6.HeaderText = "CM6"
        Me.cm6.Name = "cm6"
        Me.cm6.ReadOnly = True
        Me.cm6.Width = 35
        '
        'dom
        '
        Me.dom.HeaderText = "Dom"
        Me.dom.Name = "dom"
        Me.dom.ReadOnly = True
        Me.dom.Width = 35
        '
        'te7
        '
        Me.te7.HeaderText = "TE7"
        Me.te7.Name = "te7"
        Me.te7.ReadOnly = True
        Me.te7.Width = 35
        '
        'cm7
        '
        Me.cm7.HeaderText = "CM7"
        Me.cm7.Name = "cm7"
        Me.cm7.ReadOnly = True
        Me.cm7.Width = 35
        '
        'te
        '
        Me.te.HeaderText = "TE"
        Me.te.Name = "te"
        Me.te.ReadOnly = True
        Me.te.Width = 40
        '
        'com
        '
        Me.com.HeaderText = "COM"
        Me.com.Name = "com"
        Me.com.ReadOnly = True
        Me.com.Width = 40
        '
        'cm
        '
        Me.cm.HeaderText = "CM"
        Me.cm.Name = "cm"
        Me.cm.ReadOnly = True
        Me.cm.Width = 40
        '
        'sp
        '
        Me.sp.HeaderText = "$"
        Me.sp.Name = "sp"
        Me.sp.ReadOnly = True
        Me.sp.Width = 40
        '
        'spBono
        '
        Me.spBono.HeaderText = "$ Bono"
        Me.spBono.Name = "spBono"
        Me.spBono.ReadOnly = True
        Me.spBono.Width = 40
        '
        'departamentoEmpleado
        '
        Me.departamentoEmpleado.HeaderText = "Departamento"
        Me.departamentoEmpleado.Name = "departamentoEmpleado"
        Me.departamentoEmpleado.ReadOnly = True
        '
        'turnoEmpleado
        '
        Me.turnoEmpleado.HeaderText = "Turno"
        Me.turnoEmpleado.Name = "turnoEmpleado"
        Me.turnoEmpleado.ReadOnly = True
        '
        'idTurnoEmpleado
        '
        Me.idTurnoEmpleado.HeaderText = "IdTurno"
        Me.idTurnoEmpleado.Name = "idTurnoEmpleado"
        Me.idTurnoEmpleado.ReadOnly = True
        Me.idTurnoEmpleado.Width = 40
        '
        'retardo
        '
        Me.retardo.HeaderText = "R"
        Me.retardo.Name = "retardo"
        Me.retardo.ReadOnly = True
        Me.retardo.Width = 40
        '
        'permisoSalida
        '
        Me.permisoSalida.HeaderText = "PS"
        Me.permisoSalida.Name = "permisoSalida"
        Me.permisoSalida.ReadOnly = True
        Me.permisoSalida.Width = 40
        '
        'falta
        '
        Me.falta.HeaderText = "F"
        Me.falta.Name = "falta"
        Me.falta.ReadOnly = True
        Me.falta.Width = 40
        '
        'faltaJustificada
        '
        Me.faltaJustificada.HeaderText = "FJ"
        Me.faltaJustificada.Name = "faltaJustificada"
        Me.faltaJustificada.ReadOnly = True
        Me.faltaJustificada.Width = 40
        '
        'suspension
        '
        Me.suspension.HeaderText = "SUS"
        Me.suspension.Name = "suspension"
        Me.suspension.ReadOnly = True
        Me.suspension.Width = 40
        '
        'permisoSinSueldo
        '
        Me.permisoSinSueldo.HeaderText = "PSS"
        Me.permisoSinSueldo.Name = "permisoSinSueldo"
        Me.permisoSinSueldo.ReadOnly = True
        Me.permisoSinSueldo.Width = 40
        '
        'permisoConSueldo
        '
        Me.permisoConSueldo.HeaderText = "PCS"
        Me.permisoConSueldo.Name = "permisoConSueldo"
        Me.permisoConSueldo.ReadOnly = True
        Me.permisoConSueldo.Width = 40
        '
        'permisoMaternidad
        '
        Me.permisoMaternidad.HeaderText = "PM"
        Me.permisoMaternidad.Name = "permisoMaternidad"
        Me.permisoMaternidad.ReadOnly = True
        Me.permisoMaternidad.Width = 40
        '
        'incapacidad
        '
        Me.incapacidad.HeaderText = "INC"
        Me.incapacidad.Name = "incapacidad"
        Me.incapacidad.ReadOnly = True
        Me.incapacidad.Width = 40
        '
        'vacaciones
        '
        Me.vacaciones.HeaderText = "VAC"
        Me.vacaciones.Name = "vacaciones"
        Me.vacaciones.ReadOnly = True
        Me.vacaciones.Width = 40
        '
        'ujap
        '
        Me.ujap.HeaderText = "JP"
        Me.ujap.Name = "ujap"
        Me.ujap.ReadOnly = True
        Me.ujap.Width = 40
        '
        'dJap
        '
        Me.dJap.HeaderText = "2J"
        Me.dJap.Name = "dJap"
        Me.dJap.ReadOnly = True
        Me.dJap.Width = 40
        '
        'umex
        '
        Me.umex.HeaderText = "MX"
        Me.umex.Name = "umex"
        Me.umex.ReadOnly = True
        Me.umex.Width = 40
        '
        'dMex
        '
        Me.dMex.HeaderText = "2M"
        Me.dMex.Name = "dMex"
        Me.dMex.ReadOnly = True
        Me.dMex.Width = 40
        '
        'jpMx
        '
        Me.jpMx.HeaderText = "1J,1M"
        Me.jpMx.Name = "jpMx"
        Me.jpMx.ReadOnly = True
        Me.jpMx.Width = 40
        '
        'mxJp
        '
        Me.mxJp.HeaderText = "1M, 1J"
        Me.mxJp.Name = "mxJp"
        Me.mxJp.ReadOnly = True
        Me.mxJp.Width = 40
        '
        'suma
        '
        Me.suma.HeaderText = "SUM"
        Me.suma.Name = "suma"
        Me.suma.ReadOnly = True
        Me.suma.Width = 40
        '
        'diferencia
        '
        Me.diferencia.HeaderText = "DIF"
        Me.diferencia.Name = "diferencia"
        Me.diferencia.ReadOnly = True
        Me.diferencia.Width = 40
        '
        'grupo
        '
        Me.grupo.HeaderText = "g"
        Me.grupo.Name = "grupo"
        Me.grupo.ReadOnly = True
        Me.grupo.Visible = False
        '
        'lbl_Dia7
        '
        Me.lbl_Dia7.AutoSize = True
        Me.lbl_Dia7.Location = New System.Drawing.Point(913, 24)
        Me.lbl_Dia7.Name = "lbl_Dia7"
        Me.lbl_Dia7.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Dia7.TabIndex = 23
        Me.lbl_Dia7.Visible = False
        '
        'lbl_Dia6
        '
        Me.lbl_Dia6.AutoSize = True
        Me.lbl_Dia6.Location = New System.Drawing.Point(809, 24)
        Me.lbl_Dia6.Name = "lbl_Dia6"
        Me.lbl_Dia6.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Dia6.TabIndex = 22
        Me.lbl_Dia6.Visible = False
        '
        'Lbl_Dia5
        '
        Me.Lbl_Dia5.AutoSize = True
        Me.Lbl_Dia5.Location = New System.Drawing.Point(706, 24)
        Me.Lbl_Dia5.Name = "Lbl_Dia5"
        Me.Lbl_Dia5.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia5.TabIndex = 21
        Me.Lbl_Dia5.Visible = False
        '
        'Lbl_Dia4
        '
        Me.Lbl_Dia4.AutoSize = True
        Me.Lbl_Dia4.Location = New System.Drawing.Point(600, 24)
        Me.Lbl_Dia4.Name = "Lbl_Dia4"
        Me.Lbl_Dia4.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia4.TabIndex = 20
        Me.Lbl_Dia4.Visible = False
        '
        'Lbl_Dia3
        '
        Me.Lbl_Dia3.AutoSize = True
        Me.Lbl_Dia3.Location = New System.Drawing.Point(495, 24)
        Me.Lbl_Dia3.Name = "Lbl_Dia3"
        Me.Lbl_Dia3.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia3.TabIndex = 19
        Me.Lbl_Dia3.Visible = False
        '
        'Lbl_Dia2
        '
        Me.Lbl_Dia2.AutoSize = True
        Me.Lbl_Dia2.Location = New System.Drawing.Point(390, 24)
        Me.Lbl_Dia2.Name = "Lbl_Dia2"
        Me.Lbl_Dia2.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia2.TabIndex = 18
        Me.Lbl_Dia2.Visible = False
        '
        'Lbl_Dia1
        '
        Me.Lbl_Dia1.AutoSize = True
        Me.Lbl_Dia1.Location = New System.Drawing.Point(283, 24)
        Me.Lbl_Dia1.Name = "Lbl_Dia1"
        Me.Lbl_Dia1.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia1.TabIndex = 17
        Me.Lbl_Dia1.Visible = False
        '
        'Dgv_Lista
        '
        Me.Dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Lista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmp, Me.fecha, Me.inc, Me.tiempo, Me.hrsAprobadas})
        Me.Dgv_Lista.Location = New System.Drawing.Point(49, 19)
        Me.Dgv_Lista.Name = "Dgv_Lista"
        Me.Dgv_Lista.Size = New System.Drawing.Size(327, 310)
        Me.Dgv_Lista.TabIndex = 24
        Me.Dgv_Lista.Visible = False
        '
        'idEmp
        '
        Me.idEmp.HeaderText = "idEmp"
        Me.idEmp.Name = "idEmp"
        Me.idEmp.ReadOnly = True
        Me.idEmp.Width = 45
        '
        'fecha
        '
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'inc
        '
        Me.inc.HeaderText = "inc"
        Me.inc.Name = "inc"
        Me.inc.ReadOnly = True
        Me.inc.Width = 45
        '
        'tiempo
        '
        Me.tiempo.HeaderText = "tiempo"
        Me.tiempo.Name = "tiempo"
        Me.tiempo.ReadOnly = True
        Me.tiempo.Width = 45
        '
        'hrsAprobadas
        '
        Me.hrsAprobadas.HeaderText = "hrsAprobadas"
        Me.hrsAprobadas.Name = "hrsAprobadas"
        Me.hrsAprobadas.ReadOnly = True
        Me.hrsAprobadas.Width = 45
        '
        'Lbl_FiltroId
        '
        Me.Lbl_FiltroId.AutoSize = True
        Me.Lbl_FiltroId.Location = New System.Drawing.Point(23, 5)
        Me.Lbl_FiltroId.Name = "Lbl_FiltroId"
        Me.Lbl_FiltroId.Size = New System.Drawing.Size(16, 13)
        Me.Lbl_FiltroId.TabIndex = 26
        Me.Lbl_FiltroId.Text = "Id"
        '
        'Txt_FiltroId
        '
        Me.Txt_FiltroId.Enabled = False
        Me.Txt_FiltroId.Location = New System.Drawing.Point(14, 20)
        Me.Txt_FiltroId.Name = "Txt_FiltroId"
        Me.Txt_FiltroId.Size = New System.Drawing.Size(40, 20)
        Me.Txt_FiltroId.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1253, 518)
        Me.Panel2.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Dgv_Prenomina_Global)
        Me.Panel4.Controls.Add(Me.Dgv_Lista)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1253, 466)
        Me.Panel4.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Txt_FiltroId)
        Me.Panel3.Controls.Add(Me.lbl_Dia7)
        Me.Panel3.Controls.Add(Me.Lbl_FiltroId)
        Me.Panel3.Controls.Add(Me.lbl_Dia6)
        Me.Panel3.Controls.Add(Me.Lbl_Dia3)
        Me.Panel3.Controls.Add(Me.Lbl_Dia5)
        Me.Panel3.Controls.Add(Me.Lbl_Dia1)
        Me.Panel3.Controls.Add(Me.Lbl_Dia4)
        Me.Panel3.Controls.Add(Me.Lbl_Dia2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1253, 52)
        Me.Panel3.TabIndex = 0
        '
        'Frm_GlobalPrenomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 572)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_GlobalPrenomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Global Prenomina"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv_Prenomina_Global, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dgv_Prenomina_Global As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_año As Label
    Friend WithEvents Lbl_Semana As Label
    Friend WithEvents Cmb_Semanas As ComboBox
    Friend WithEvents Dtp_FechaInicioSemana As DateTimePicker
    Friend WithEvents Btn_Mostrar As Button
    Friend WithEvents lbl_Dia7 As Label
    Friend WithEvents lbl_Dia6 As Label
    Friend WithEvents Lbl_Dia5 As Label
    Friend WithEvents Lbl_Dia4 As Label
    Friend WithEvents Lbl_Dia3 As Label
    Friend WithEvents Lbl_Dia2 As Label
    Friend WithEvents Lbl_Dia1 As Label
    Friend WithEvents Lbl_SemaF As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_SemaI As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Txt As Button
    Friend WithEvents Dgv_Lista As DataGridView
    Friend WithEvents idEmp As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents inc As DataGridViewTextBoxColumn
    Friend WithEvents tiempo As DataGridViewTextBoxColumn
    Friend WithEvents hrsAprobadas As DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents lun As DataGridViewTextBoxColumn
    Friend WithEvents te1 As DataGridViewTextBoxColumn
    Friend WithEvents cm1 As DataGridViewTextBoxColumn
    Friend WithEvents mar As DataGridViewTextBoxColumn
    Friend WithEvents te2 As DataGridViewTextBoxColumn
    Friend WithEvents cm2 As DataGridViewTextBoxColumn
    Friend WithEvents mie As DataGridViewTextBoxColumn
    Friend WithEvents te3 As DataGridViewTextBoxColumn
    Friend WithEvents cm3 As DataGridViewTextBoxColumn
    Friend WithEvents jue As DataGridViewTextBoxColumn
    Friend WithEvents te4 As DataGridViewTextBoxColumn
    Friend WithEvents cm4 As DataGridViewTextBoxColumn
    Friend WithEvents vie As DataGridViewTextBoxColumn
    Friend WithEvents te5 As DataGridViewTextBoxColumn
    Friend WithEvents cm5 As DataGridViewTextBoxColumn
    Friend WithEvents sab As DataGridViewTextBoxColumn
    Friend WithEvents te6 As DataGridViewTextBoxColumn
    Friend WithEvents cm6 As DataGridViewTextBoxColumn
    Friend WithEvents dom As DataGridViewTextBoxColumn
    Friend WithEvents te7 As DataGridViewTextBoxColumn
    Friend WithEvents cm7 As DataGridViewTextBoxColumn
    Friend WithEvents te As DataGridViewTextBoxColumn
    Friend WithEvents com As DataGridViewTextBoxColumn
    Friend WithEvents cm As DataGridViewTextBoxColumn
    Friend WithEvents sp As DataGridViewTextBoxColumn
    Friend WithEvents spBono As DataGridViewTextBoxColumn
    Friend WithEvents departamentoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents turnoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents idTurnoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents retardo As DataGridViewTextBoxColumn
    Friend WithEvents permisoSalida As DataGridViewTextBoxColumn
    Friend WithEvents falta As DataGridViewTextBoxColumn
    Friend WithEvents faltaJustificada As DataGridViewTextBoxColumn
    Friend WithEvents suspension As DataGridViewTextBoxColumn
    Friend WithEvents permisoSinSueldo As DataGridViewTextBoxColumn
    Friend WithEvents permisoConSueldo As DataGridViewTextBoxColumn
    Friend WithEvents permisoMaternidad As DataGridViewTextBoxColumn
    Friend WithEvents incapacidad As DataGridViewTextBoxColumn
    Friend WithEvents vacaciones As DataGridViewTextBoxColumn
    Friend WithEvents ujap As DataGridViewTextBoxColumn
    Friend WithEvents dJap As DataGridViewTextBoxColumn
    Friend WithEvents umex As DataGridViewTextBoxColumn
    Friend WithEvents dMex As DataGridViewTextBoxColumn
    Friend WithEvents jpMx As DataGridViewTextBoxColumn
    Friend WithEvents mxJp As DataGridViewTextBoxColumn
    Friend WithEvents suma As DataGridViewTextBoxColumn
    Friend WithEvents diferencia As DataGridViewTextBoxColumn
    Friend WithEvents grupo As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Excel As Button
    Friend WithEvents Lbl_FiltroId As Label
    Friend WithEvents Txt_FiltroId As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
End Class
