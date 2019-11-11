<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Gastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Gastos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Reporte = New System.Windows.Forms.Button()
        Me.Pct_Limpiar = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Rdb_Japones = New System.Windows.Forms.RadioButton()
        Me.Rdb_Español = New System.Windows.Forms.RadioButton()
        Me.Lbl_Año = New System.Windows.Forms.Label()
        Me.Cmb_Años = New System.Windows.Forms.ComboBox()
        Me.Lbl_Depto = New System.Windows.Forms.Label()
        Me.Lbl_Mes = New System.Windows.Forms.Label()
        Me.Cmb_Depto = New System.Windows.Forms.ComboBox()
        Me.Cmb_Meses = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Btn_Regresar = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Dgv_DesplegadoAcum = New System.Windows.Forms.DataGridView()
        Me.noCta3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cta3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentaje2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgv_GastosDepto = New System.Windows.Forms.DataGridView()
        Me.noCta2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cta2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masterP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.real2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dif2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cotizacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.po2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comp2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.poliza2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Dgv_GastosGlobal = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Lbl_TAPorcentaje = New System.Windows.Forms.Label()
        Me.Lbl_TADif = New System.Windows.Forms.Label()
        Me.Lbl_TAReal = New System.Windows.Forms.Label()
        Me.Lbl_TAPLan = New System.Windows.Forms.Label()
        Me.Lbl_TPorcentaje = New System.Windows.Forms.Label()
        Me.Lbl_TDif = New System.Windows.Forms.Label()
        Me.Lbl_TReal = New System.Windows.Forms.Label()
        Me.Lbl_TPlan = New System.Windows.Forms.Label()
        Me.Lbl_Totales = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Lbl_CotoTotal = New System.Windows.Forms.Label()
        Me.Lbl_CostoUnitTotal = New System.Windows.Forms.Label()
        Me.Lbl_CantidadTot = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_MontoMaster = New System.Windows.Forms.Label()
        Me.Lbl_MontoFF2 = New System.Windows.Forms.Label()
        Me.Lbl_MontoMF2 = New System.Windows.Forms.Label()
        Me.Lbl_MontoFF1 = New System.Windows.Forms.Label()
        Me.Lbl_MontoMF1 = New System.Windows.Forms.Label()
        Me.Lbl_CantMaster = New System.Windows.Forms.Label()
        Me.Lbl_CantFF2 = New System.Windows.Forms.Label()
        Me.Lbl_CantMF2 = New System.Windows.Forms.Label()
        Me.Lbl_CantFF1 = New System.Windows.Forms.Label()
        Me.Lbl_CantMF1 = New System.Windows.Forms.Label()
        Me.Lbl_FF1 = New System.Windows.Forms.Label()
        Me.Lbl_MF2 = New System.Windows.Forms.Label()
        Me.Lbl_FF2 = New System.Windows.Forms.Label()
        Me.Lbl_MP = New System.Windows.Forms.Label()
        Me.Lbl_MF1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_CantActualReal = New System.Windows.Forms.Label()
        Me.Lbl_CantDif = New System.Windows.Forms.Label()
        Me.Lbl_MontoDif = New System.Windows.Forms.Label()
        Me.Lbl_MontoActualReal = New System.Windows.Forms.Label()
        Me.Lbl_MontoPlan = New System.Windows.Forms.Label()
        Me.Lbl_CantPlan = New System.Windows.Forms.Label()
        Me.Lbl_Dif = New System.Windows.Forms.Label()
        Me.Lbl_PM = New System.Windows.Forms.Label()
        Me.Lbl_Cant = New System.Windows.Forms.Label()
        Me.Lbl_Monto = New System.Windows.Forms.Label()
        Me.Lbl_Ventas = New System.Windows.Forms.Label()
        Me.Lbl_Actual = New System.Windows.Forms.Label()
        Me.Lbl_Real = New System.Windows.Forms.Label()
        Me.noCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cosCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cosPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.segNeg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.Pct_Limpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.Dgv_DesplegadoAcum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_GastosDepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.Dgv_GastosGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Btn_Reporte)
        Me.Panel1.Controls.Add(Me.Pct_Limpiar)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Lbl_Año)
        Me.Panel1.Controls.Add(Me.Cmb_Años)
        Me.Panel1.Controls.Add(Me.Lbl_Depto)
        Me.Panel1.Controls.Add(Me.Lbl_Mes)
        Me.Panel1.Controls.Add(Me.Cmb_Depto)
        Me.Panel1.Controls.Add(Me.Cmb_Meses)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1269, 48)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Reporte
        '
        Me.Btn_Reporte.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Reporte.BackgroundImage = Global.Presentacion.My.Resources.Resources.report
        Me.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_Reporte.FlatAppearance.BorderSize = 0
        Me.Btn_Reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Btn_Reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue
        Me.Btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Reporte.Location = New System.Drawing.Point(534, 8)
        Me.Btn_Reporte.Name = "Btn_Reporte"
        Me.Btn_Reporte.Size = New System.Drawing.Size(33, 33)
        Me.Btn_Reporte.TabIndex = 9
        Me.Btn_Reporte.UseVisualStyleBackColor = False
        '
        'Pct_Limpiar
        '
        Me.Pct_Limpiar.Image = Global.Presentacion.My.Resources.Resources._New
        Me.Pct_Limpiar.Location = New System.Drawing.Point(477, 11)
        Me.Pct_Limpiar.Name = "Pct_Limpiar"
        Me.Pct_Limpiar.Size = New System.Drawing.Size(29, 30)
        Me.Pct_Limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pct_Limpiar.TabIndex = 8
        Me.Pct_Limpiar.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Rdb_Japones)
        Me.Panel10.Controls.Add(Me.Rdb_Español)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1134, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(135, 48)
        Me.Panel10.TabIndex = 6
        '
        'Rdb_Japones
        '
        Me.Rdb_Japones.AutoSize = True
        Me.Rdb_Japones.ForeColor = System.Drawing.Color.White
        Me.Rdb_Japones.Location = New System.Drawing.Point(20, 27)
        Me.Rdb_Japones.Name = "Rdb_Japones"
        Me.Rdb_Japones.Size = New System.Drawing.Size(61, 17)
        Me.Rdb_Japones.TabIndex = 1
        Me.Rdb_Japones.TabStop = True
        Me.Rdb_Japones.Text = "日本語"
        Me.Rdb_Japones.UseVisualStyleBackColor = True
        '
        'Rdb_Español
        '
        Me.Rdb_Español.AutoSize = True
        Me.Rdb_Español.ForeColor = System.Drawing.Color.White
        Me.Rdb_Español.Location = New System.Drawing.Point(20, 4)
        Me.Rdb_Español.Name = "Rdb_Español"
        Me.Rdb_Español.Size = New System.Drawing.Size(63, 17)
        Me.Rdb_Español.TabIndex = 0
        Me.Rdb_Español.TabStop = True
        Me.Rdb_Español.Text = "Español"
        Me.Rdb_Español.UseVisualStyleBackColor = True
        '
        'Lbl_Año
        '
        Me.Lbl_Año.AutoSize = True
        Me.Lbl_Año.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Año.Location = New System.Drawing.Point(352, 3)
        Me.Lbl_Año.Name = "Lbl_Año"
        Me.Lbl_Año.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Año.TabIndex = 5
        Me.Lbl_Año.Text = "Año"
        '
        'Cmb_Años
        '
        Me.Cmb_Años.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Años.FormattingEnabled = True
        Me.Cmb_Años.Location = New System.Drawing.Point(352, 21)
        Me.Cmb_Años.Name = "Cmb_Años"
        Me.Cmb_Años.Size = New System.Drawing.Size(82, 21)
        Me.Cmb_Años.TabIndex = 4
        '
        'Lbl_Depto
        '
        Me.Lbl_Depto.AutoSize = True
        Me.Lbl_Depto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Depto.Location = New System.Drawing.Point(12, 2)
        Me.Lbl_Depto.Name = "Lbl_Depto"
        Me.Lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Depto.TabIndex = 3
        Me.Lbl_Depto.Text = "Departamento"
        '
        'Lbl_Mes
        '
        Me.Lbl_Mes.AutoSize = True
        Me.Lbl_Mes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Mes.Location = New System.Drawing.Point(216, 3)
        Me.Lbl_Mes.Name = "Lbl_Mes"
        Me.Lbl_Mes.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_Mes.TabIndex = 2
        Me.Lbl_Mes.Text = "Mes"
        '
        'Cmb_Depto
        '
        Me.Cmb_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Depto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Depto.FormattingEnabled = True
        Me.Cmb_Depto.Location = New System.Drawing.Point(22, 21)
        Me.Cmb_Depto.Name = "Cmb_Depto"
        Me.Cmb_Depto.Size = New System.Drawing.Size(182, 21)
        Me.Cmb_Depto.TabIndex = 1
        '
        'Cmb_Meses
        '
        Me.Cmb_Meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Meses.FormattingEnabled = True
        Me.Cmb_Meses.Location = New System.Drawing.Point(216, 21)
        Me.Cmb_Meses.Name = "Cmb_Meses"
        Me.Cmb_Meses.Size = New System.Drawing.Size(112, 21)
        Me.Cmb_Meses.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1269, 461)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 75)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1269, 386)
        Me.Panel4.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1269, 357)
        Me.Panel6.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Btn_Regresar)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(625, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(6, 357)
        Me.Panel9.TabIndex = 2
        '
        'Btn_Regresar
        '
        Me.Btn_Regresar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Regresar.BackgroundImage = Global.Presentacion.My.Resources.Resources.go_back256_24856
        Me.Btn_Regresar.Enabled = False
        Me.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Regresar.Location = New System.Drawing.Point(28, 169)
        Me.Btn_Regresar.Name = "Btn_Regresar"
        Me.Btn_Regresar.Size = New System.Drawing.Size(50, 49)
        Me.Btn_Regresar.TabIndex = 9
        Me.Btn_Regresar.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Dgv_DesplegadoAcum)
        Me.Panel8.Controls.Add(Me.Dgv_GastosDepto)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(625, 357)
        Me.Panel8.TabIndex = 1
        '
        'Dgv_DesplegadoAcum
        '
        Me.Dgv_DesplegadoAcum.AllowUserToAddRows = False
        Me.Dgv_DesplegadoAcum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        Me.Dgv_DesplegadoAcum.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noCta3, Me.cta3, Me.plan, Me.actual, Me.dif, Me.porcentaje2})
        Me.Dgv_DesplegadoAcum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_DesplegadoAcum.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_DesplegadoAcum.Name = "Dgv_DesplegadoAcum"
        Me.Dgv_DesplegadoAcum.RowHeadersVisible = False
        Me.Dgv_DesplegadoAcum.Size = New System.Drawing.Size(625, 357)
        Me.Dgv_DesplegadoAcum.TabIndex = 2
        Me.Dgv_DesplegadoAcum.Visible = False
        '
        'noCta3
        '
        Me.noCta3.HeaderText = "No.Cuenta"
        Me.noCta3.Name = "noCta3"
        Me.noCta3.ReadOnly = True
        Me.noCta3.Width = 85
        '
        'cta3
        '
        Me.cta3.HeaderText = "Cuenta"
        Me.cta3.Name = "cta3"
        Me.cta3.ReadOnly = True
        Me.cta3.Width = 120
        '
        'plan
        '
        Me.plan.HeaderText = "Plan"
        Me.plan.Name = "plan"
        Me.plan.ReadOnly = True
        '
        'actual
        '
        Me.actual.HeaderText = "Real"
        Me.actual.Name = "actual"
        Me.actual.ReadOnly = True
        '
        'dif
        '
        Me.dif.HeaderText = "Diferencia"
        Me.dif.Name = "dif"
        Me.dif.ReadOnly = True
        '
        'porcentaje2
        '
        Me.porcentaje2.HeaderText = "Porcentaje"
        Me.porcentaje2.Name = "porcentaje2"
        Me.porcentaje2.ReadOnly = True
        Me.porcentaje2.Width = 60
        '
        'Dgv_GastosDepto
        '
        Me.Dgv_GastosDepto.AllowUserToAddRows = False
        Me.Dgv_GastosDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_GastosDepto.ColumnHeadersVisible = False
        Me.Dgv_GastosDepto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noCta2, Me.cta2, Me.masterP2, Me.plan2, Me.real2, Me.actual2, Me.dif2, Me.cotizacion2, Me.po2, Me.comp2, Me.poliza2, Me.porcentaje})
        Me.Dgv_GastosDepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_GastosDepto.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_GastosDepto.Name = "Dgv_GastosDepto"
        Me.Dgv_GastosDepto.RowHeadersVisible = False
        Me.Dgv_GastosDepto.Size = New System.Drawing.Size(625, 357)
        Me.Dgv_GastosDepto.TabIndex = 1
        '
        'noCta2
        '
        Me.noCta2.HeaderText = "No. Cuenta"
        Me.noCta2.Name = "noCta2"
        Me.noCta2.ReadOnly = True
        Me.noCta2.Width = 80
        '
        'cta2
        '
        Me.cta2.HeaderText = "Cuenta"
        Me.cta2.Name = "cta2"
        Me.cta2.ReadOnly = True
        Me.cta2.Width = 160
        '
        'masterP2
        '
        Me.masterP2.HeaderText = "Master"
        Me.masterP2.Name = "masterP2"
        Me.masterP2.ReadOnly = True
        Me.masterP2.Visible = False
        '
        'plan2
        '
        Me.plan2.HeaderText = "Plan"
        Me.plan2.Name = "plan2"
        Me.plan2.ReadOnly = True
        '
        'real2
        '
        Me.real2.HeaderText = "Real"
        Me.real2.Name = "real2"
        Me.real2.ReadOnly = True
        '
        'actual2
        '
        Me.actual2.HeaderText = "Actual"
        Me.actual2.Name = "actual2"
        Me.actual2.ReadOnly = True
        Me.actual2.Visible = False
        '
        'dif2
        '
        Me.dif2.HeaderText = "Diferencia"
        Me.dif2.Name = "dif2"
        Me.dif2.ReadOnly = True
        '
        'cotizacion2
        '
        Me.cotizacion2.HeaderText = "Cotización"
        Me.cotizacion2.Name = "cotizacion2"
        Me.cotizacion2.ReadOnly = True
        Me.cotizacion2.Visible = False
        '
        'po2
        '
        Me.po2.HeaderText = "OC"
        Me.po2.Name = "po2"
        Me.po2.ReadOnly = True
        Me.po2.Visible = False
        '
        'comp2
        '
        Me.comp2.HeaderText = "Compra"
        Me.comp2.Name = "comp2"
        Me.comp2.ReadOnly = True
        Me.comp2.Visible = False
        '
        'poliza2
        '
        Me.poliza2.HeaderText = "Poliza"
        Me.poliza2.Name = "poliza2"
        Me.poliza2.ReadOnly = True
        Me.poliza2.Visible = False
        '
        'porcentaje
        '
        Me.porcentaje.HeaderText = "Porcentaje"
        Me.porcentaje.Name = "porcentaje"
        Me.porcentaje.ReadOnly = True
        Me.porcentaje.Width = 65
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Dgv_GastosGlobal)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(631, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(638, 357)
        Me.Panel7.TabIndex = 0
        '
        'Dgv_GastosGlobal
        '
        Me.Dgv_GastosGlobal.AllowUserToAddRows = False
        Me.Dgv_GastosGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_GastosGlobal.ColumnHeadersVisible = False
        Me.Dgv_GastosGlobal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noCta, Me.cta, Me.idCompra, Me.cantCompra, Me.costoUnit, Me.cosCompra, Me.idPoliza, Me.cosPoliza, Me.cantPoliza, Me.segNeg})
        Me.Dgv_GastosGlobal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_GastosGlobal.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_GastosGlobal.Name = "Dgv_GastosGlobal"
        Me.Dgv_GastosGlobal.RowHeadersVisible = False
        Me.Dgv_GastosGlobal.RowHeadersWidth = 37
        Me.Dgv_GastosGlobal.Size = New System.Drawing.Size(638, 357)
        Me.Dgv_GastosGlobal.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel12)
        Me.Panel5.Controls.Add(Me.Panel11)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 357)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1269, 29)
        Me.Panel5.TabIndex = 0
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Lbl_TAPorcentaje)
        Me.Panel12.Controls.Add(Me.Lbl_TADif)
        Me.Panel12.Controls.Add(Me.Lbl_TAReal)
        Me.Panel12.Controls.Add(Me.Lbl_TAPLan)
        Me.Panel12.Controls.Add(Me.Lbl_TPorcentaje)
        Me.Panel12.Controls.Add(Me.Lbl_TDif)
        Me.Panel12.Controls.Add(Me.Lbl_TReal)
        Me.Panel12.Controls.Add(Me.Lbl_TPlan)
        Me.Panel12.Controls.Add(Me.Lbl_Totales)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(625, 29)
        Me.Panel12.TabIndex = 2
        '
        'Lbl_TAPorcentaje
        '
        Me.Lbl_TAPorcentaje.AutoSize = True
        Me.Lbl_TAPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TAPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TAPorcentaje.Location = New System.Drawing.Point(544, 8)
        Me.Lbl_TAPorcentaje.Name = "Lbl_TAPorcentaje"
        Me.Lbl_TAPorcentaje.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_TAPorcentaje.TabIndex = 14
        Me.Lbl_TAPorcentaje.Visible = False
        '
        'Lbl_TADif
        '
        Me.Lbl_TADif.AutoSize = True
        Me.Lbl_TADif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TADif.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TADif.Location = New System.Drawing.Point(446, 7)
        Me.Lbl_TADif.Name = "Lbl_TADif"
        Me.Lbl_TADif.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_TADif.TabIndex = 13
        Me.Lbl_TADif.Visible = False
        '
        'Lbl_TAReal
        '
        Me.Lbl_TAReal.AutoSize = True
        Me.Lbl_TAReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TAReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TAReal.Location = New System.Drawing.Point(342, 7)
        Me.Lbl_TAReal.Name = "Lbl_TAReal"
        Me.Lbl_TAReal.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_TAReal.TabIndex = 12
        Me.Lbl_TAReal.Visible = False
        '
        'Lbl_TAPLan
        '
        Me.Lbl_TAPLan.AutoSize = True
        Me.Lbl_TAPLan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TAPLan.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TAPLan.Location = New System.Drawing.Point(242, 8)
        Me.Lbl_TAPLan.Name = "Lbl_TAPLan"
        Me.Lbl_TAPLan.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_TAPLan.TabIndex = 11
        Me.Lbl_TAPLan.Visible = False
        '
        'Lbl_TPorcentaje
        '
        Me.Lbl_TPorcentaje.AutoSize = True
        Me.Lbl_TPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TPorcentaje.Location = New System.Drawing.Point(544, 8)
        Me.Lbl_TPorcentaje.Name = "Lbl_TPorcentaje"
        Me.Lbl_TPorcentaje.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_TPorcentaje.TabIndex = 10
        '
        'Lbl_TDif
        '
        Me.Lbl_TDif.AutoSize = True
        Me.Lbl_TDif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TDif.Location = New System.Drawing.Point(446, 7)
        Me.Lbl_TDif.Name = "Lbl_TDif"
        Me.Lbl_TDif.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_TDif.TabIndex = 9
        '
        'Lbl_TReal
        '
        Me.Lbl_TReal.AutoSize = True
        Me.Lbl_TReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TReal.Location = New System.Drawing.Point(342, 7)
        Me.Lbl_TReal.Name = "Lbl_TReal"
        Me.Lbl_TReal.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_TReal.TabIndex = 8
        '
        'Lbl_TPlan
        '
        Me.Lbl_TPlan.AutoSize = True
        Me.Lbl_TPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_TPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TPlan.Location = New System.Drawing.Point(242, 8)
        Me.Lbl_TPlan.Name = "Lbl_TPlan"
        Me.Lbl_TPlan.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_TPlan.TabIndex = 7
        '
        'Lbl_Totales
        '
        Me.Lbl_Totales.AutoSize = True
        Me.Lbl_Totales.Location = New System.Drawing.Point(12, 8)
        Me.Lbl_Totales.Name = "Lbl_Totales"
        Me.Lbl_Totales.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_Totales.TabIndex = 1
        Me.Lbl_Totales.Text = "TOTALES"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Lbl_CotoTotal)
        Me.Panel11.Controls.Add(Me.Lbl_CostoUnitTotal)
        Me.Panel11.Controls.Add(Me.Lbl_CantidadTot)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(911, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(358, 29)
        Me.Panel11.TabIndex = 1
        '
        'Lbl_CotoTotal
        '
        Me.Lbl_CotoTotal.AutoSize = True
        Me.Lbl_CotoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_CotoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CotoTotal.Location = New System.Drawing.Point(149, 8)
        Me.Lbl_CotoTotal.Name = "Lbl_CotoTotal"
        Me.Lbl_CotoTotal.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_CotoTotal.TabIndex = 6
        '
        'Lbl_CostoUnitTotal
        '
        Me.Lbl_CostoUnitTotal.AutoSize = True
        Me.Lbl_CostoUnitTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_CostoUnitTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CostoUnitTotal.Location = New System.Drawing.Point(74, 8)
        Me.Lbl_CostoUnitTotal.Name = "Lbl_CostoUnitTotal"
        Me.Lbl_CostoUnitTotal.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_CostoUnitTotal.TabIndex = 5
        '
        'Lbl_CantidadTot
        '
        Me.Lbl_CantidadTot.AutoSize = True
        Me.Lbl_CantidadTot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_CantidadTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CantidadTot.Location = New System.Drawing.Point(13, 8)
        Me.Lbl_CantidadTot.Name = "Lbl_CantidadTot"
        Me.Lbl_CantidadTot.Size = New System.Drawing.Size(2, 15)
        Me.Lbl_CantidadTot.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Lbl_MontoMaster)
        Me.Panel3.Controls.Add(Me.Lbl_MontoFF2)
        Me.Panel3.Controls.Add(Me.Lbl_MontoMF2)
        Me.Panel3.Controls.Add(Me.Lbl_MontoFF1)
        Me.Panel3.Controls.Add(Me.Lbl_MontoMF1)
        Me.Panel3.Controls.Add(Me.Lbl_CantMaster)
        Me.Panel3.Controls.Add(Me.Lbl_CantFF2)
        Me.Panel3.Controls.Add(Me.Lbl_CantMF2)
        Me.Panel3.Controls.Add(Me.Lbl_CantFF1)
        Me.Panel3.Controls.Add(Me.Lbl_CantMF1)
        Me.Panel3.Controls.Add(Me.Lbl_FF1)
        Me.Panel3.Controls.Add(Me.Lbl_MF2)
        Me.Panel3.Controls.Add(Me.Lbl_FF2)
        Me.Panel3.Controls.Add(Me.Lbl_MP)
        Me.Panel3.Controls.Add(Me.Lbl_MF1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Lbl_CantActualReal)
        Me.Panel3.Controls.Add(Me.Lbl_CantDif)
        Me.Panel3.Controls.Add(Me.Lbl_MontoDif)
        Me.Panel3.Controls.Add(Me.Lbl_MontoActualReal)
        Me.Panel3.Controls.Add(Me.Lbl_MontoPlan)
        Me.Panel3.Controls.Add(Me.Lbl_CantPlan)
        Me.Panel3.Controls.Add(Me.Lbl_Dif)
        Me.Panel3.Controls.Add(Me.Lbl_PM)
        Me.Panel3.Controls.Add(Me.Lbl_Cant)
        Me.Panel3.Controls.Add(Me.Lbl_Monto)
        Me.Panel3.Controls.Add(Me.Lbl_Ventas)
        Me.Panel3.Controls.Add(Me.Lbl_Actual)
        Me.Panel3.Controls.Add(Me.Lbl_Real)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1269, 75)
        Me.Panel3.TabIndex = 0
        '
        'Lbl_MontoMaster
        '
        Me.Lbl_MontoMaster.AutoSize = True
        Me.Lbl_MontoMaster.Location = New System.Drawing.Point(861, 29)
        Me.Lbl_MontoMaster.Name = "Lbl_MontoMaster"
        Me.Lbl_MontoMaster.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoMaster.TabIndex = 38
        Me.Lbl_MontoMaster.Text = "Label17"
        Me.Lbl_MontoMaster.Visible = False
        '
        'Lbl_MontoFF2
        '
        Me.Lbl_MontoFF2.AutoSize = True
        Me.Lbl_MontoFF2.Location = New System.Drawing.Point(761, 29)
        Me.Lbl_MontoFF2.Name = "Lbl_MontoFF2"
        Me.Lbl_MontoFF2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoFF2.TabIndex = 37
        Me.Lbl_MontoFF2.Text = "Label12"
        Me.Lbl_MontoFF2.Visible = False
        '
        'Lbl_MontoMF2
        '
        Me.Lbl_MontoMF2.AutoSize = True
        Me.Lbl_MontoMF2.Location = New System.Drawing.Point(661, 29)
        Me.Lbl_MontoMF2.Name = "Lbl_MontoMF2"
        Me.Lbl_MontoMF2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoMF2.TabIndex = 36
        Me.Lbl_MontoMF2.Text = "Label13"
        Me.Lbl_MontoMF2.Visible = False
        '
        'Lbl_MontoFF1
        '
        Me.Lbl_MontoFF1.AutoSize = True
        Me.Lbl_MontoFF1.Location = New System.Drawing.Point(561, 29)
        Me.Lbl_MontoFF1.Name = "Lbl_MontoFF1"
        Me.Lbl_MontoFF1.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoFF1.TabIndex = 35
        Me.Lbl_MontoFF1.Text = "Label11"
        Me.Lbl_MontoFF1.Visible = False
        '
        'Lbl_MontoMF1
        '
        Me.Lbl_MontoMF1.AutoSize = True
        Me.Lbl_MontoMF1.Location = New System.Drawing.Point(461, 29)
        Me.Lbl_MontoMF1.Name = "Lbl_MontoMF1"
        Me.Lbl_MontoMF1.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_MontoMF1.TabIndex = 34
        Me.Lbl_MontoMF1.Text = "Label9"
        Me.Lbl_MontoMF1.Visible = False
        '
        'Lbl_CantMaster
        '
        Me.Lbl_CantMaster.AutoSize = True
        Me.Lbl_CantMaster.Location = New System.Drawing.Point(861, 51)
        Me.Lbl_CantMaster.Name = "Lbl_CantMaster"
        Me.Lbl_CantMaster.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantMaster.TabIndex = 43
        Me.Lbl_CantMaster.Text = "Label21"
        Me.Lbl_CantMaster.Visible = False
        '
        'Lbl_CantFF2
        '
        Me.Lbl_CantFF2.AutoSize = True
        Me.Lbl_CantFF2.Location = New System.Drawing.Point(761, 51)
        Me.Lbl_CantFF2.Name = "Lbl_CantFF2"
        Me.Lbl_CantFF2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantFF2.TabIndex = 42
        Me.Lbl_CantFF2.Text = "Label22"
        Me.Lbl_CantFF2.Visible = False
        '
        'Lbl_CantMF2
        '
        Me.Lbl_CantMF2.AutoSize = True
        Me.Lbl_CantMF2.Location = New System.Drawing.Point(661, 51)
        Me.Lbl_CantMF2.Name = "Lbl_CantMF2"
        Me.Lbl_CantMF2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantMF2.TabIndex = 41
        Me.Lbl_CantMF2.Text = "Label23"
        Me.Lbl_CantMF2.Visible = False
        '
        'Lbl_CantFF1
        '
        Me.Lbl_CantFF1.AutoSize = True
        Me.Lbl_CantFF1.Location = New System.Drawing.Point(561, 51)
        Me.Lbl_CantFF1.Name = "Lbl_CantFF1"
        Me.Lbl_CantFF1.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantFF1.TabIndex = 40
        Me.Lbl_CantFF1.Text = "Label24"
        Me.Lbl_CantFF1.Visible = False
        '
        'Lbl_CantMF1
        '
        Me.Lbl_CantMF1.AutoSize = True
        Me.Lbl_CantMF1.Location = New System.Drawing.Point(461, 51)
        Me.Lbl_CantMF1.Name = "Lbl_CantMF1"
        Me.Lbl_CantMF1.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantMF1.TabIndex = 39
        Me.Lbl_CantMF1.Text = "Label25"
        Me.Lbl_CantMF1.Visible = False
        '
        'Lbl_FF1
        '
        Me.Lbl_FF1.AutoSize = True
        Me.Lbl_FF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_FF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FF1.Location = New System.Drawing.Point(561, 6)
        Me.Lbl_FF1.Name = "Lbl_FF1"
        Me.Lbl_FF1.Size = New System.Drawing.Size(91, 19)
        Me.Lbl_FF1.TabIndex = 33
        Me.Lbl_FF1.Text = "Fundición F1"
        Me.Lbl_FF1.Visible = False
        '
        'Lbl_MF2
        '
        Me.Lbl_MF2.AutoSize = True
        Me.Lbl_MF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_MF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MF2.Location = New System.Drawing.Point(661, 6)
        Me.Lbl_MF2.Name = "Lbl_MF2"
        Me.Lbl_MF2.Size = New System.Drawing.Size(100, 19)
        Me.Lbl_MF2.TabIndex = 32
        Me.Lbl_MF2.Text = "Maquinado F2"
        Me.Lbl_MF2.Visible = False
        '
        'Lbl_FF2
        '
        Me.Lbl_FF2.AutoSize = True
        Me.Lbl_FF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_FF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FF2.Location = New System.Drawing.Point(761, 6)
        Me.Lbl_FF2.Name = "Lbl_FF2"
        Me.Lbl_FF2.Size = New System.Drawing.Size(91, 19)
        Me.Lbl_FF2.TabIndex = 31
        Me.Lbl_FF2.Text = "Fundición F2"
        Me.Lbl_FF2.Visible = False
        '
        'Lbl_MP
        '
        Me.Lbl_MP.AutoSize = True
        Me.Lbl_MP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_MP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MP.Location = New System.Drawing.Point(861, 6)
        Me.Lbl_MP.Name = "Lbl_MP"
        Me.Lbl_MP.Size = New System.Drawing.Size(53, 19)
        Me.Lbl_MP.TabIndex = 30
        Me.Lbl_MP.Text = "Master"
        Me.Lbl_MP.Visible = False
        '
        'Lbl_MF1
        '
        Me.Lbl_MF1.AutoSize = True
        Me.Lbl_MF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_MF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MF1.Location = New System.Drawing.Point(461, 6)
        Me.Lbl_MF1.Name = "Lbl_MF1"
        Me.Lbl_MF1.Size = New System.Drawing.Size(100, 19)
        Me.Lbl_MF1.TabIndex = 29
        Me.Lbl_MF1.Text = "Maquinado F1"
        Me.Lbl_MF1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(937, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 27)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Productos Comprados"
        '
        'Lbl_CantActualReal
        '
        Me.Lbl_CantActualReal.AutoSize = True
        Me.Lbl_CantActualReal.Location = New System.Drawing.Point(214, 50)
        Me.Lbl_CantActualReal.Name = "Lbl_CantActualReal"
        Me.Lbl_CantActualReal.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantActualReal.TabIndex = 26
        Me.Lbl_CantActualReal.Text = "Label19"
        '
        'Lbl_CantDif
        '
        Me.Lbl_CantDif.AutoSize = True
        Me.Lbl_CantDif.Location = New System.Drawing.Point(314, 50)
        Me.Lbl_CantDif.Name = "Lbl_CantDif"
        Me.Lbl_CantDif.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantDif.TabIndex = 27
        Me.Lbl_CantDif.Text = "Label18"
        '
        'Lbl_MontoDif
        '
        Me.Lbl_MontoDif.AutoSize = True
        Me.Lbl_MontoDif.Location = New System.Drawing.Point(314, 28)
        Me.Lbl_MontoDif.Name = "Lbl_MontoDif"
        Me.Lbl_MontoDif.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoDif.TabIndex = 19
        Me.Lbl_MontoDif.Text = "Label14"
        '
        'Lbl_MontoActualReal
        '
        Me.Lbl_MontoActualReal.AutoSize = True
        Me.Lbl_MontoActualReal.Location = New System.Drawing.Point(214, 28)
        Me.Lbl_MontoActualReal.Name = "Lbl_MontoActualReal"
        Me.Lbl_MontoActualReal.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoActualReal.TabIndex = 18
        Me.Lbl_MontoActualReal.Text = "Label15"
        '
        'Lbl_MontoPlan
        '
        Me.Lbl_MontoPlan.AutoSize = True
        Me.Lbl_MontoPlan.Location = New System.Drawing.Point(114, 28)
        Me.Lbl_MontoPlan.Name = "Lbl_MontoPlan"
        Me.Lbl_MontoPlan.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoPlan.TabIndex = 17
        Me.Lbl_MontoPlan.Text = "Label16"
        '
        'Lbl_CantPlan
        '
        Me.Lbl_CantPlan.AutoSize = True
        Me.Lbl_CantPlan.Location = New System.Drawing.Point(114, 50)
        Me.Lbl_CantPlan.Name = "Lbl_CantPlan"
        Me.Lbl_CantPlan.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantPlan.TabIndex = 25
        Me.Lbl_CantPlan.Text = "Label20"
        '
        'Lbl_Dif
        '
        Me.Lbl_Dif.AutoSize = True
        Me.Lbl_Dif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Dif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Dif.Location = New System.Drawing.Point(314, 5)
        Me.Lbl_Dif.Name = "Lbl_Dif"
        Me.Lbl_Dif.Size = New System.Drawing.Size(74, 19)
        Me.Lbl_Dif.TabIndex = 9
        Me.Lbl_Dif.Text = "Diferencia"
        '
        'Lbl_PM
        '
        Me.Lbl_PM.AutoSize = True
        Me.Lbl_PM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_PM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_PM.Location = New System.Drawing.Point(114, 5)
        Me.Lbl_PM.Name = "Lbl_PM"
        Me.Lbl_PM.Size = New System.Drawing.Size(38, 19)
        Me.Lbl_PM.TabIndex = 4
        Me.Lbl_PM.Text = "Plan"
        '
        'Lbl_Cant
        '
        Me.Lbl_Cant.AutoSize = True
        Me.Lbl_Cant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cant.Location = New System.Drawing.Point(19, 50)
        Me.Lbl_Cant.Name = "Lbl_Cant"
        Me.Lbl_Cant.Size = New System.Drawing.Size(56, 15)
        Me.Lbl_Cant.TabIndex = 2
        Me.Lbl_Cant.Text = "Cantidad"
        '
        'Lbl_Monto
        '
        Me.Lbl_Monto.AutoSize = True
        Me.Lbl_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Monto.Location = New System.Drawing.Point(33, 28)
        Me.Lbl_Monto.Name = "Lbl_Monto"
        Me.Lbl_Monto.Size = New System.Drawing.Size(42, 15)
        Me.Lbl_Monto.TabIndex = 1
        Me.Lbl_Monto.Text = "Monto"
        '
        'Lbl_Ventas
        '
        Me.Lbl_Ventas.AutoSize = True
        Me.Lbl_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ventas.Location = New System.Drawing.Point(15, 3)
        Me.Lbl_Ventas.Name = "Lbl_Ventas"
        Me.Lbl_Ventas.Size = New System.Drawing.Size(75, 22)
        Me.Lbl_Ventas.TabIndex = 0
        Me.Lbl_Ventas.Text = "VENTAS"
        '
        'Lbl_Actual
        '
        Me.Lbl_Actual.AutoSize = True
        Me.Lbl_Actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Actual.Location = New System.Drawing.Point(214, 5)
        Me.Lbl_Actual.Name = "Lbl_Actual"
        Me.Lbl_Actual.Size = New System.Drawing.Size(49, 19)
        Me.Lbl_Actual.TabIndex = 10
        Me.Lbl_Actual.Text = "Actual"
        '
        'Lbl_Real
        '
        Me.Lbl_Real.AutoSize = True
        Me.Lbl_Real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Real.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Real.Location = New System.Drawing.Point(214, 5)
        Me.Lbl_Real.Name = "Lbl_Real"
        Me.Lbl_Real.Size = New System.Drawing.Size(39, 19)
        Me.Lbl_Real.TabIndex = 11
        Me.Lbl_Real.Text = "Real"
        '
        'noCta
        '
        Me.noCta.HeaderText = "No Cuenta"
        Me.noCta.Name = "noCta"
        Me.noCta.ReadOnly = True
        Me.noCta.Width = 60
        '
        'cta
        '
        Me.cta.HeaderText = "Cuenta"
        Me.cta.Name = "cta"
        Me.cta.ReadOnly = True
        Me.cta.Width = 170
        '
        'idCompra
        '
        Me.idCompra.HeaderText = "Compra"
        Me.idCompra.Name = "idCompra"
        Me.idCompra.ReadOnly = True
        Me.idCompra.Width = 45
        '
        'cantCompra
        '
        Me.cantCompra.HeaderText = "Cantidad Compra"
        Me.cantCompra.Name = "cantCompra"
        Me.cantCompra.ReadOnly = True
        Me.cantCompra.Width = 75
        '
        'costoUnit
        '
        Me.costoUnit.HeaderText = "Costo Unitario"
        Me.costoUnit.Name = "costoUnit"
        Me.costoUnit.ReadOnly = True
        Me.costoUnit.Width = 75
        '
        'cosCompra
        '
        Me.cosCompra.HeaderText = "Costo Compra"
        Me.cosCompra.Name = "cosCompra"
        Me.cosCompra.ReadOnly = True
        Me.cosCompra.Width = 75
        '
        'idPoliza
        '
        Me.idPoliza.HeaderText = "Poliza"
        Me.idPoliza.Name = "idPoliza"
        Me.idPoliza.ReadOnly = True
        Me.idPoliza.Visible = False
        Me.idPoliza.Width = 125
        '
        'cosPoliza
        '
        Me.cosPoliza.HeaderText = "Costo Poliza"
        Me.cosPoliza.Name = "cosPoliza"
        Me.cosPoliza.ReadOnly = True
        Me.cosPoliza.Visible = False
        Me.cosPoliza.Width = 125
        '
        'cantPoliza
        '
        Me.cantPoliza.HeaderText = "Cantidad Poliza"
        Me.cantPoliza.Name = "cantPoliza"
        Me.cantPoliza.ReadOnly = True
        Me.cantPoliza.Visible = False
        '
        'segNeg
        '
        Me.segNeg.HeaderText = "Segmento Negocio"
        Me.segNeg.Name = "segNeg"
        Me.segNeg.ReadOnly = True
        Me.segNeg.Width = 110
        '
        'Frm_Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 509)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Gastos"
        Me.ShowIcon = False
        Me.Text = "Gastos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pct_Limpiar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.Dgv_DesplegadoAcum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_GastosDepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.Dgv_GastosGlobal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Lbl_Mes As Label
    Friend WithEvents Cmb_Meses As ComboBox
    Friend WithEvents Lbl_Año As Label
    Friend WithEvents Cmb_Años As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Dgv_GastosDepto As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Dgv_GastosGlobal As DataGridView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Rdb_Japones As RadioButton
    Friend WithEvents Rdb_Español As RadioButton
    Friend WithEvents Pct_Limpiar As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_CantActualReal As Label
    Friend WithEvents Lbl_CantDif As Label
    Friend WithEvents Lbl_MontoDif As Label
    Friend WithEvents Lbl_MontoActualReal As Label
    Friend WithEvents Lbl_MontoPlan As Label
    Friend WithEvents Lbl_CantPlan As Label
    Friend WithEvents Lbl_Dif As Label
    Friend WithEvents Lbl_PM As Label
    Friend WithEvents Lbl_Cant As Label
    Friend WithEvents Lbl_Monto As Label
    Friend WithEvents Lbl_Ventas As Label
    Friend WithEvents Lbl_Actual As Label
    Friend WithEvents Lbl_Real As Label
    Friend WithEvents Lbl_Depto As Label
    Friend WithEvents Cmb_Depto As ComboBox
    Friend WithEvents Dgv_DesplegadoAcum As DataGridView
    Friend WithEvents Btn_Regresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_MontoMaster As Label
    Friend WithEvents Lbl_MontoFF2 As Label
    Friend WithEvents Lbl_MontoMF2 As Label
    Friend WithEvents Lbl_MontoFF1 As Label
    Friend WithEvents Lbl_MontoMF1 As Label
    Friend WithEvents Lbl_CantMaster As Label
    Friend WithEvents Lbl_CantFF2 As Label
    Friend WithEvents Lbl_CantMF2 As Label
    Friend WithEvents Lbl_CantFF1 As Label
    Friend WithEvents Lbl_CantMF1 As Label
    Friend WithEvents Lbl_FF1 As Label
    Friend WithEvents Lbl_MF2 As Label
    Friend WithEvents Lbl_FF2 As Label
    Friend WithEvents Lbl_MP As Label
    Friend WithEvents Lbl_MF1 As Label
    Friend WithEvents noCta3 As DataGridViewTextBoxColumn
    Friend WithEvents cta3 As DataGridViewTextBoxColumn
    Friend WithEvents plan As DataGridViewTextBoxColumn
    Friend WithEvents actual As DataGridViewTextBoxColumn
    Friend WithEvents dif As DataGridViewTextBoxColumn
    Friend WithEvents porcentaje2 As DataGridViewTextBoxColumn
    Friend WithEvents noCta2 As DataGridViewTextBoxColumn
    Friend WithEvents cta2 As DataGridViewTextBoxColumn
    Friend WithEvents masterP2 As DataGridViewTextBoxColumn
    Friend WithEvents plan2 As DataGridViewTextBoxColumn
    Friend WithEvents real2 As DataGridViewTextBoxColumn
    Friend WithEvents actual2 As DataGridViewTextBoxColumn
    Friend WithEvents dif2 As DataGridViewTextBoxColumn
    Friend WithEvents cotizacion2 As DataGridViewTextBoxColumn
    Friend WithEvents po2 As DataGridViewTextBoxColumn
    Friend WithEvents comp2 As DataGridViewTextBoxColumn
    Friend WithEvents poliza2 As DataGridViewTextBoxColumn
    Friend WithEvents porcentaje As DataGridViewTextBoxColumn
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Lbl_CotoTotal As Label
    Friend WithEvents Lbl_CostoUnitTotal As Label
    Friend WithEvents Lbl_CantidadTot As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Lbl_TDif As Label
    Friend WithEvents Lbl_TReal As Label
    Friend WithEvents Lbl_TPlan As Label
    Friend WithEvents Lbl_Totales As Label
    Friend WithEvents Lbl_TPorcentaje As Label
    Friend WithEvents Lbl_TAPorcentaje As Label
    Friend WithEvents Lbl_TADif As Label
    Friend WithEvents Lbl_TAReal As Label
    Friend WithEvents Lbl_TAPLan As Label
    Friend WithEvents Btn_Reporte As Button
    Friend WithEvents noCta As DataGridViewTextBoxColumn
    Friend WithEvents cta As DataGridViewTextBoxColumn
    Friend WithEvents idCompra As DataGridViewTextBoxColumn
    Friend WithEvents cantCompra As DataGridViewTextBoxColumn
    Friend WithEvents costoUnit As DataGridViewTextBoxColumn
    Friend WithEvents cosCompra As DataGridViewTextBoxColumn
    Friend WithEvents idPoliza As DataGridViewTextBoxColumn
    Friend WithEvents cosPoliza As DataGridViewTextBoxColumn
    Friend WithEvents cantPoliza As DataGridViewTextBoxColumn
    Friend WithEvents segNeg As DataGridViewTextBoxColumn
End Class
