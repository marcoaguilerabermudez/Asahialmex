<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Provisiones
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Validar = New System.Windows.Forms.Button()
        Me.Btn_ActualizarXml = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Empresa = New System.Windows.Forms.TextBox()
        Me.Txt_Proveedor = New System.Windows.Forms.TextBox()
        Me.Txt_Factura = New System.Windows.Forms.TextBox()
        Me.Txt_Oc = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_BuscarCompras = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dtp_Final = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelP = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Dgv_Provisionadas = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_StatusCompra = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_Empresa2 = New System.Windows.Forms.TextBox()
        Me.Txt_Proveedor2 = New System.Windows.Forms.TextBox()
        Me.Txt_Factura2 = New System.Windows.Forms.TextBox()
        Me.Txt_Oc2 = New System.Windows.Forms.TextBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btn_BuscaProvisionadas = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Dtp_FinalProv = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_InicioProv = New System.Windows.Forms.DateTimePicker()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Dgv_PorProvisionar = New System.Windows.Forms.DataGridView()
        Me.seleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idProvision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcEmisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoOc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacionCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.selección = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pdf = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.idProvision2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oc2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idOc2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compra2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfc2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcEmisor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoOc2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoCompra2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoFactura2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFactura2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPagoFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmisor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fdp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelP.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.Dgv_Provisionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Dgv_PorProvisionar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Btn_Validar)
        Me.Panel1.Controls.Add(Me.Btn_ActualizarXml)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1229, 71)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Validar
        '
        Me.Btn_Validar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_Validar.FlatAppearance.BorderSize = 0
        Me.Btn_Validar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Validar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Validar.Image = Global.Presentacion.My.Resources.Resources.comprobado
        Me.Btn_Validar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Validar.Location = New System.Drawing.Point(750, 16)
        Me.Btn_Validar.Name = "Btn_Validar"
        Me.Btn_Validar.Size = New System.Drawing.Size(39, 40)
        Me.Btn_Validar.TabIndex = 9
        Me.Btn_Validar.UseVisualStyleBackColor = True
        '
        'Btn_ActualizarXml
        '
        Me.Btn_ActualizarXml.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_ActualizarXml.FlatAppearance.BorderSize = 0
        Me.Btn_ActualizarXml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_ActualizarXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ActualizarXml.Image = Global.Presentacion.My.Resources.Resources.xml
        Me.Btn_ActualizarXml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ActualizarXml.Location = New System.Drawing.Point(692, 16)
        Me.Btn_ActualizarXml.Name = "Btn_ActualizarXml"
        Me.Btn_ActualizarXml.Size = New System.Drawing.Size(39, 40)
        Me.Btn_ActualizarXml.TabIndex = 8
        Me.Btn_ActualizarXml.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(1049, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(164, 71)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "COMPLETO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "PROVISIÓN EXCEDIDA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "PARCIAL"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightGreen
        Me.PictureBox3.Location = New System.Drawing.Point(12, 49)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 17)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.OrangeRed
        Me.PictureBox2.Location = New System.Drawing.Point(12, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 17)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 17)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel14
        '
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel14.Location = New System.Drawing.Point(1213, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(16, 71)
        Me.Panel14.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Txt_Empresa)
        Me.GroupBox2.Controls.Add(Me.Txt_Proveedor)
        Me.GroupBox2.Controls.Add(Me.Txt_Factura)
        Me.GroupBox2.Controls.Add(Me.Txt_Oc)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(225, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 71)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Empresa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "OC"
        '
        'Txt_Empresa
        '
        Me.Txt_Empresa.AutoCompleteCustomSource.AddRange(New String() {"AAM", "AAMS"})
        Me.Txt_Empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_Empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Empresa.Location = New System.Drawing.Point(223, 40)
        Me.Txt_Empresa.Name = "Txt_Empresa"
        Me.Txt_Empresa.Size = New System.Drawing.Size(77, 20)
        Me.Txt_Empresa.TabIndex = 3
        '
        'Txt_Proveedor
        '
        Me.Txt_Proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_Proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Proveedor.Location = New System.Drawing.Point(223, 15)
        Me.Txt_Proveedor.Name = "Txt_Proveedor"
        Me.Txt_Proveedor.Size = New System.Drawing.Size(209, 20)
        Me.Txt_Proveedor.TabIndex = 2
        '
        'Txt_Factura
        '
        Me.Txt_Factura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_Factura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Factura.Location = New System.Drawing.Point(56, 40)
        Me.Txt_Factura.Name = "Txt_Factura"
        Me.Txt_Factura.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Factura.TabIndex = 1
        '
        'Txt_Oc
        '
        Me.Txt_Oc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_Oc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Oc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Oc.Location = New System.Drawing.Point(56, 15)
        Me.Txt_Oc.Name = "Txt_Oc"
        Me.Txt_Oc.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Oc.TabIndex = 0
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel13.Location = New System.Drawing.Point(215, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(10, 71)
        Me.Panel13.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_BuscarCompras)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dtp_Final)
        Me.GroupBox1.Controls.Add(Me.Dtp_Inicio)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 71)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas de Compra"
        '
        'Btn_BuscarCompras
        '
        Me.Btn_BuscarCompras.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_BuscarCompras.FlatAppearance.BorderSize = 0
        Me.Btn_BuscarCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_BuscarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscarCompras.Image = Global.Presentacion.My.Resources.Resources.lupa
        Me.Btn_BuscarCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BuscarCompras.Location = New System.Drawing.Point(152, 16)
        Me.Btn_BuscarCompras.Name = "Btn_BuscarCompras"
        Me.Btn_BuscarCompras.Size = New System.Drawing.Size(39, 40)
        Me.Btn_BuscarCompras.TabIndex = 5
        Me.Btn_BuscarCompras.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inicio"
        '
        'Dtp_Final
        '
        Me.Dtp_Final.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Final.Location = New System.Drawing.Point(60, 41)
        Me.Dtp_Final.Name = "Dtp_Final"
        Me.Dtp_Final.Size = New System.Drawing.Size(80, 20)
        Me.Dtp_Final.TabIndex = 1
        '
        'Dtp_Inicio
        '
        Me.Dtp_Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Inicio.Location = New System.Drawing.Point(60, 15)
        Me.Dtp_Inicio.Name = "Dtp_Inicio"
        Me.Dtp_Inicio.Size = New System.Drawing.Size(80, 20)
        Me.Dtp_Inicio.TabIndex = 0
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(10, 71)
        Me.Panel12.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1229, 10)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PanelP)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1229, 599)
        Me.Panel3.TabIndex = 2
        '
        'PanelP
        '
        Me.PanelP.Controls.Add(Me.Panel8)
        Me.PanelP.Controls.Add(Me.Panel7)
        Me.PanelP.Controls.Add(Me.Panel6)
        Me.PanelP.Controls.Add(Me.Panel4)
        Me.PanelP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelP.Location = New System.Drawing.Point(0, 0)
        Me.PanelP.Name = "PanelP"
        Me.PanelP.Size = New System.Drawing.Size(1229, 599)
        Me.PanelP.TabIndex = 5
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Dgv_Provisionadas)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 371)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1229, 223)
        Me.Panel8.TabIndex = 4
        '
        'Dgv_Provisionadas
        '
        Me.Dgv_Provisionadas.AllowUserToAddRows = False
        Me.Dgv_Provisionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Provisionadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selección, Me.pdf, Me.idProvision2, Me.oc2, Me.idOc2, Me.compra2, Me.factura2, Me.proveedor2, Me.rfc2, Me.rfcEmisor2, Me.moneda2, Me.montoOc2, Me.montoCompra2, Me.montoFactura2, Me.montoPagar, Me.fp, Me.fechaFactura2, Me.fechaPagoFact, Me.statusPago, Me.status2, Me.observaComp, Me.observaConta, Me.empresa2, Me.nombreEmisor2, Me.fdp, Me.serie2, Me.uuid, Me.ruta})
        Me.Dgv_Provisionadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Provisionadas.Location = New System.Drawing.Point(5, 0)
        Me.Dgv_Provisionadas.Name = "Dgv_Provisionadas"
        Me.Dgv_Provisionadas.RowHeadersVisible = False
        Me.Dgv_Provisionadas.Size = New System.Drawing.Size(1219, 223)
        Me.Dgv_Provisionadas.TabIndex = 6
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(1224, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 223)
        Me.Panel9.TabIndex = 3
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(5, 223)
        Me.Panel11.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 594)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1229, 5)
        Me.Panel7.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel19)
        Me.Panel6.Controls.Add(Me.Panel18)
        Me.Panel6.Controls.Add(Me.Panel17)
        Me.Panel6.Controls.Add(Me.Panel16)
        Me.Panel6.Controls.Add(Me.Panel15)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 296)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1229, 75)
        Me.Panel6.TabIndex = 2
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.GroupBox6)
        Me.Panel19.Controls.Add(Me.Panel22)
        Me.Panel19.Controls.Add(Me.GroupBox5)
        Me.Panel19.Controls.Add(Me.Panel21)
        Me.Panel19.Controls.Add(Me.GroupBox4)
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(5, 5)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1219, 65)
        Me.Panel19.TabIndex = 8
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.PictureBox4)
        Me.GroupBox6.Controls.Add(Me.PictureBox5)
        Me.GroupBox6.Controls.Add(Me.PictureBox6)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(1008, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(199, 63)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(30, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "NO VALIDADO POR COMPRAS"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(30, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "RECHAZADO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(30, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "ACEPTADO"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox4.Location = New System.Drawing.Point(12, 43)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 17)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(15, 17)
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox6.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(15, 17)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel22.Location = New System.Drawing.Point(1207, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(10, 63)
        Me.Panel22.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Txt_StatusCompra)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Txt_Empresa2)
        Me.GroupBox5.Controls.Add(Me.Txt_Proveedor2)
        Me.GroupBox5.Controls.Add(Me.Txt_Factura2)
        Me.GroupBox5.Controls.Add(Me.Txt_Oc2)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(225, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(451, 63)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Filtros"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(305, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 27)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Status Compra"
        '
        'Txt_StatusCompra
        '
        Me.Txt_StatusCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_StatusCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_StatusCompra.Location = New System.Drawing.Point(361, 35)
        Me.Txt_StatusCompra.Name = "Txt_StatusCompra"
        Me.Txt_StatusCompra.Size = New System.Drawing.Size(77, 20)
        Me.Txt_StatusCompra.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(165, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Empresa"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(157, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Proveedor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Factura"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "OC"
        '
        'Txt_Empresa2
        '
        Me.Txt_Empresa2.AutoCompleteCustomSource.AddRange(New String() {"AAM", "AAMS"})
        Me.Txt_Empresa2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_Empresa2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Empresa2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Empresa2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Empresa2.Location = New System.Drawing.Point(223, 35)
        Me.Txt_Empresa2.Name = "Txt_Empresa2"
        Me.Txt_Empresa2.Size = New System.Drawing.Size(77, 20)
        Me.Txt_Empresa2.TabIndex = 3
        '
        'Txt_Proveedor2
        '
        Me.Txt_Proveedor2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_Proveedor2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Proveedor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Proveedor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Proveedor2.Location = New System.Drawing.Point(223, 12)
        Me.Txt_Proveedor2.Name = "Txt_Proveedor2"
        Me.Txt_Proveedor2.Size = New System.Drawing.Size(214, 20)
        Me.Txt_Proveedor2.TabIndex = 2
        '
        'Txt_Factura2
        '
        Me.Txt_Factura2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_Factura2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Factura2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Factura2.Location = New System.Drawing.Point(56, 35)
        Me.Txt_Factura2.Name = "Txt_Factura2"
        Me.Txt_Factura2.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Factura2.TabIndex = 1
        '
        'Txt_Oc2
        '
        Me.Txt_Oc2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_Oc2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_Oc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Oc2.Location = New System.Drawing.Point(56, 12)
        Me.Txt_Oc2.Name = "Txt_Oc2"
        Me.Txt_Oc2.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Oc2.TabIndex = 0
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel21.Location = New System.Drawing.Point(215, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(10, 63)
        Me.Panel21.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_BuscaProvisionadas)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Dtp_FinalProv)
        Me.GroupBox4.Controls.Add(Me.Dtp_InicioProv)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 63)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fechas de Compra"
        '
        'Btn_BuscaProvisionadas
        '
        Me.Btn_BuscaProvisionadas.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_BuscaProvisionadas.FlatAppearance.BorderSize = 0
        Me.Btn_BuscaProvisionadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_BuscaProvisionadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BuscaProvisionadas.Image = Global.Presentacion.My.Resources.Resources.lupa
        Me.Btn_BuscaProvisionadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BuscaProvisionadas.Location = New System.Drawing.Point(152, 13)
        Me.Btn_BuscaProvisionadas.Name = "Btn_BuscaProvisionadas"
        Me.Btn_BuscaProvisionadas.Size = New System.Drawing.Size(39, 40)
        Me.Btn_BuscaProvisionadas.TabIndex = 5
        Me.Btn_BuscaProvisionadas.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Final"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Inicio"
        '
        'Dtp_FinalProv
        '
        Me.Dtp_FinalProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_FinalProv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FinalProv.Location = New System.Drawing.Point(60, 38)
        Me.Dtp_FinalProv.Name = "Dtp_FinalProv"
        Me.Dtp_FinalProv.Size = New System.Drawing.Size(80, 20)
        Me.Dtp_FinalProv.TabIndex = 1
        '
        'Dtp_InicioProv
        '
        Me.Dtp_InicioProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_InicioProv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_InicioProv.Location = New System.Drawing.Point(60, 15)
        Me.Dtp_InicioProv.Name = "Dtp_InicioProv"
        Me.Dtp_InicioProv.Size = New System.Drawing.Size(80, 20)
        Me.Dtp_InicioProv.TabIndex = 0
        '
        'Panel20
        '
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(10, 63)
        Me.Panel20.TabIndex = 4
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 5)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(5, 65)
        Me.Panel18.TabIndex = 7
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel17.Location = New System.Drawing.Point(1224, 5)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(5, 65)
        Me.Panel17.TabIndex = 6
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel16.Location = New System.Drawing.Point(0, 70)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1229, 5)
        Me.Panel16.TabIndex = 5
        '
        'Panel15
        '
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1229, 5)
        Me.Panel15.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Dgv_PorProvisionar)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1229, 296)
        Me.Panel4.TabIndex = 1
        '
        'Dgv_PorProvisionar
        '
        Me.Dgv_PorProvisionar.AllowUserToAddRows = False
        Me.Dgv_PorProvisionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_PorProvisionar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccion, Me.idProvision, Me.oc, Me.idOc, Me.compra, Me.factura, Me.proveedor, Me.rfc, Me.rfcEmisor, Me.moneda, Me.montoOc, Me.montoCompra, Me.montoFactura, Me.montoPago, Me.fechaFactura, Me.fechaPago, Me.status, Me.observacionCompra, Me.empresa, Me.nombreEmisor, Me.fechaCompra, Me.serie})
        Me.Dgv_PorProvisionar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_PorProvisionar.Location = New System.Drawing.Point(5, 0)
        Me.Dgv_PorProvisionar.Name = "Dgv_PorProvisionar"
        Me.Dgv_PorProvisionar.RowHeadersVisible = False
        Me.Dgv_PorProvisionar.Size = New System.Drawing.Size(1219, 296)
        Me.Dgv_PorProvisionar.TabIndex = 5
        '
        'seleccion
        '
        Me.seleccion.HeaderText = "           "
        Me.seleccion.Name = "seleccion"
        Me.seleccion.Width = 30
        '
        'idProvision
        '
        Me.idProvision.HeaderText = "Provisión"
        Me.idProvision.Name = "idProvision"
        Me.idProvision.ReadOnly = True
        Me.idProvision.Visible = False
        '
        'oc
        '
        Me.oc.HeaderText = "Oc"
        Me.oc.Name = "oc"
        Me.oc.Width = 60
        '
        'idOc
        '
        Me.idOc.HeaderText = "Id Oc"
        Me.idOc.Name = "idOc"
        Me.idOc.ReadOnly = True
        Me.idOc.Visible = False
        '
        'compra
        '
        Me.compra.HeaderText = "Compra"
        Me.compra.Name = "compra"
        Me.compra.Width = 60
        '
        'factura
        '
        Me.factura.HeaderText = "Factura"
        Me.factura.Name = "factura"
        Me.factura.Width = 65
        '
        'proveedor
        '
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Width = 150
        '
        'rfc
        '
        Me.rfc.HeaderText = "RFC"
        Me.rfc.Name = "rfc"
        '
        'rfcEmisor
        '
        Me.rfcEmisor.HeaderText = "RFC Emisor"
        Me.rfcEmisor.Name = "rfcEmisor"
        '
        'moneda
        '
        Me.moneda.HeaderText = "Moneda"
        Me.moneda.Name = "moneda"
        Me.moneda.Width = 50
        '
        'montoOc
        '
        Me.montoOc.HeaderText = "Monto OC"
        Me.montoOc.Name = "montoOc"
        Me.montoOc.Width = 75
        '
        'montoCompra
        '
        Me.montoCompra.HeaderText = "Monto Compra"
        Me.montoCompra.Name = "montoCompra"
        Me.montoCompra.Width = 75
        '
        'montoFactura
        '
        Me.montoFactura.HeaderText = "Monto Factura"
        Me.montoFactura.Name = "montoFactura"
        Me.montoFactura.Width = 75
        '
        'montoPago
        '
        Me.montoPago.HeaderText = "Monto Pago"
        Me.montoPago.Name = "montoPago"
        Me.montoPago.Width = 75
        '
        'fechaFactura
        '
        Me.fechaFactura.HeaderText = "Fecha Factura"
        Me.fechaFactura.Name = "fechaFactura"
        Me.fechaFactura.Width = 75
        '
        'fechaPago
        '
        Me.fechaPago.HeaderText = "Fecha Pago"
        Me.fechaPago.Name = "fechaPago"
        Me.fechaPago.Width = 75
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.Width = 50
        '
        'observacionCompra
        '
        Me.observacionCompra.HeaderText = "Observación Compra"
        Me.observacionCompra.Name = "observacionCompra"
        Me.observacionCompra.Width = 150
        '
        'empresa
        '
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.Width = 50
        '
        'nombreEmisor
        '
        Me.nombreEmisor.HeaderText = "Nombre Emisor"
        Me.nombreEmisor.Name = "nombreEmisor"
        Me.nombreEmisor.Width = 150
        '
        'fechaCompra
        '
        Me.fechaCompra.HeaderText = "Fecha Compra"
        Me.fechaCompra.Name = "fechaCompra"
        Me.fechaCompra.Width = 75
        '
        'serie
        '
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        Me.serie.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 296)
        Me.Panel5.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1224, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 296)
        Me.Panel10.TabIndex = 3
        '
        'selección
        '
        Me.selección.HeaderText = ""
        Me.selección.Name = "selección"
        Me.selección.Width = 30
        '
        'pdf
        '
        Me.pdf.HeaderText = "PDF"
        Me.pdf.Name = "pdf"
        Me.pdf.Width = 30
        '
        'idProvision2
        '
        Me.idProvision2.HeaderText = "Id Provision"
        Me.idProvision2.Name = "idProvision2"
        Me.idProvision2.ReadOnly = True
        Me.idProvision2.Visible = False
        '
        'oc2
        '
        Me.oc2.HeaderText = "OC"
        Me.oc2.Name = "oc2"
        Me.oc2.Width = 60
        '
        'idOc2
        '
        Me.idOc2.HeaderText = "IdOc"
        Me.idOc2.Name = "idOc2"
        Me.idOc2.ReadOnly = True
        Me.idOc2.Visible = False
        '
        'compra2
        '
        Me.compra2.HeaderText = "Compra"
        Me.compra2.Name = "compra2"
        Me.compra2.Width = 60
        '
        'factura2
        '
        Me.factura2.HeaderText = "Factura"
        Me.factura2.Name = "factura2"
        Me.factura2.Width = 65
        '
        'proveedor2
        '
        Me.proveedor2.HeaderText = "Proveedor"
        Me.proveedor2.Name = "proveedor2"
        Me.proveedor2.Width = 150
        '
        'rfc2
        '
        Me.rfc2.HeaderText = "RFC"
        Me.rfc2.Name = "rfc2"
        '
        'rfcEmisor2
        '
        Me.rfcEmisor2.HeaderText = "RFC Emisor"
        Me.rfcEmisor2.Name = "rfcEmisor2"
        '
        'moneda2
        '
        Me.moneda2.HeaderText = "Moneda"
        Me.moneda2.Name = "moneda2"
        Me.moneda2.Width = 60
        '
        'montoOc2
        '
        Me.montoOc2.HeaderText = "Monto OC"
        Me.montoOc2.Name = "montoOc2"
        Me.montoOc2.Width = 75
        '
        'montoCompra2
        '
        Me.montoCompra2.HeaderText = "Monto Compra"
        Me.montoCompra2.Name = "montoCompra2"
        Me.montoCompra2.Width = 75
        '
        'montoFactura2
        '
        Me.montoFactura2.HeaderText = "Monto Factura"
        Me.montoFactura2.Name = "montoFactura2"
        Me.montoFactura2.Width = 75
        '
        'montoPagar
        '
        Me.montoPagar.HeaderText = "Monto A Pagar"
        Me.montoPagar.Name = "montoPagar"
        Me.montoPagar.Width = 75
        '
        'fp
        '
        Me.fp.HeaderText = "FP"
        Me.fp.Name = "fp"
        Me.fp.Width = 75
        '
        'fechaFactura2
        '
        Me.fechaFactura2.HeaderText = "Fecha Factura"
        Me.fechaFactura2.Name = "fechaFactura2"
        Me.fechaFactura2.Width = 75
        '
        'fechaPagoFact
        '
        Me.fechaPagoFact.HeaderText = "Fecha Pago Fact"
        Me.fechaPagoFact.Name = "fechaPagoFact"
        Me.fechaPagoFact.Width = 80
        '
        'statusPago
        '
        Me.statusPago.HeaderText = "Status Pago"
        Me.statusPago.Name = "statusPago"
        Me.statusPago.Width = 55
        '
        'status2
        '
        Me.status2.HeaderText = "Status"
        Me.status2.Name = "status2"
        Me.status2.Width = 55
        '
        'observaComp
        '
        Me.observaComp.HeaderText = "Observa Compra"
        Me.observaComp.Name = "observaComp"
        Me.observaComp.Width = 200
        '
        'observaConta
        '
        Me.observaConta.HeaderText = "Observa Conta"
        Me.observaConta.Name = "observaConta"
        Me.observaConta.Width = 200
        '
        'empresa2
        '
        Me.empresa2.HeaderText = "Empresa"
        Me.empresa2.Name = "empresa2"
        Me.empresa2.Width = 60
        '
        'nombreEmisor2
        '
        Me.nombreEmisor2.HeaderText = "Nombre Emisor"
        Me.nombreEmisor2.Name = "nombreEmisor2"
        Me.nombreEmisor2.Width = 150
        '
        'fdp
        '
        Me.fdp.HeaderText = "FDP"
        Me.fdp.Name = "fdp"
        Me.fdp.Width = 80
        '
        'serie2
        '
        Me.serie2.HeaderText = "Serie"
        Me.serie2.Name = "serie2"
        Me.serie2.ReadOnly = True
        Me.serie2.Visible = False
        '
        'uuid
        '
        Me.uuid.HeaderText = "UUID"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        Me.uuid.Visible = False
        '
        'ruta
        '
        Me.ruta.HeaderText = "Ruta"
        Me.ruta.Name = "ruta"
        Me.ruta.ReadOnly = True
        Me.ruta.Visible = False
        '
        'Frm_Provisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 680)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Provisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Provisiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PanelP.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.Dgv_Provisionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Dgv_PorProvisionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelP As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Dgv_PorProvisionar As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Dgv_Provisionadas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Dtp_Final As DateTimePicker
    Friend WithEvents Dtp_Inicio As DateTimePicker
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Txt_Empresa As TextBox
    Friend WithEvents Txt_Proveedor As TextBox
    Friend WithEvents Txt_Factura As TextBox
    Friend WithEvents Txt_Oc As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Btn_BuscarCompras As Button
    Friend WithEvents Btn_Validar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Btn_BuscaProvisionadas As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Dtp_FinalProv As DateTimePicker
    Friend WithEvents Dtp_InicioProv As DateTimePicker
    Friend WithEvents Panel20 As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel22 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Txt_StatusCompra As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Txt_Empresa2 As TextBox
    Friend WithEvents Txt_Factura2 As TextBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Btn_ActualizarXml As Button
    Friend WithEvents Txt_Oc2 As TextBox
    Friend WithEvents seleccion As DataGridViewCheckBoxColumn
    Friend WithEvents idProvision As DataGridViewTextBoxColumn
    Friend WithEvents oc As DataGridViewTextBoxColumn
    Friend WithEvents idOc As DataGridViewTextBoxColumn
    Friend WithEvents compra As DataGridViewTextBoxColumn
    Friend WithEvents factura As DataGridViewTextBoxColumn
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents rfc As DataGridViewTextBoxColumn
    Friend WithEvents rfcEmisor As DataGridViewTextBoxColumn
    Friend WithEvents moneda As DataGridViewTextBoxColumn
    Friend WithEvents montoOc As DataGridViewTextBoxColumn
    Friend WithEvents montoCompra As DataGridViewTextBoxColumn
    Friend WithEvents montoFactura As DataGridViewTextBoxColumn
    Friend WithEvents montoPago As DataGridViewTextBoxColumn
    Friend WithEvents fechaFactura As DataGridViewTextBoxColumn
    Friend WithEvents fechaPago As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents observacionCompra As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmisor As DataGridViewTextBoxColumn
    Friend WithEvents fechaCompra As DataGridViewTextBoxColumn
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Proveedor2 As TextBox
    Friend WithEvents selección As DataGridViewCheckBoxColumn
    Friend WithEvents pdf As DataGridViewButtonColumn
    Friend WithEvents idProvision2 As DataGridViewTextBoxColumn
    Friend WithEvents oc2 As DataGridViewTextBoxColumn
    Friend WithEvents idOc2 As DataGridViewTextBoxColumn
    Friend WithEvents compra2 As DataGridViewTextBoxColumn
    Friend WithEvents factura2 As DataGridViewTextBoxColumn
    Friend WithEvents proveedor2 As DataGridViewTextBoxColumn
    Friend WithEvents rfc2 As DataGridViewTextBoxColumn
    Friend WithEvents rfcEmisor2 As DataGridViewTextBoxColumn
    Friend WithEvents moneda2 As DataGridViewTextBoxColumn
    Friend WithEvents montoOc2 As DataGridViewTextBoxColumn
    Friend WithEvents montoCompra2 As DataGridViewTextBoxColumn
    Friend WithEvents montoFactura2 As DataGridViewTextBoxColumn
    Friend WithEvents montoPagar As DataGridViewTextBoxColumn
    Friend WithEvents fp As DataGridViewTextBoxColumn
    Friend WithEvents fechaFactura2 As DataGridViewTextBoxColumn
    Friend WithEvents fechaPagoFact As DataGridViewTextBoxColumn
    Friend WithEvents statusPago As DataGridViewTextBoxColumn
    Friend WithEvents status2 As DataGridViewTextBoxColumn
    Friend WithEvents observaComp As DataGridViewTextBoxColumn
    Friend WithEvents observaConta As DataGridViewTextBoxColumn
    Friend WithEvents empresa2 As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmisor2 As DataGridViewTextBoxColumn
    Friend WithEvents fdp As DataGridViewTextBoxColumn
    Friend WithEvents serie2 As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents ruta As DataGridViewTextBoxColumn
End Class
