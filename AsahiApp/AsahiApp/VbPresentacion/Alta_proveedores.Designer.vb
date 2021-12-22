<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alta_proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alta_proveedores))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbx_nacionalidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_terminos = New System.Windows.Forms.ComboBox()
        Me.txt_curp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_rfc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_razonsocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_cp = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_detallecontacto = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbx_rolcontacto = New System.Windows.Forms.ComboBox()
        Me.txt_apellidocontacto = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_NombreContacto = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_tel2contacto = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_mailcontacto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_tel1contacto = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_tel2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_tel1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_interior = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbx_colonia = New System.Windows.Forms.ComboBox()
        Me.txt_municipio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_estado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btn_bloquear = New System.Windows.Forms.Button()
        Me.txt_banco = New System.Windows.Forms.ComboBox()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.txt_iban = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_swift = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_aba = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbx_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_clabe = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_cuenta = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbx_monedacuenta = New System.Windows.Forms.ComboBox()
        Me.dtgv_cuentas = New System.Windows.Forms.DataGridView()
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clabe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ABA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SWIFT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IBAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dtgv_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(824, 505)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cbx_nacionalidad)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cbx_terminos)
        Me.TabPage1.Controls.Add(Me.txt_curp)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_rfc)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_razonsocial)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_nombre)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(816, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(37, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 432
        Me.Label10.Text = " Nacionalidad"
        '
        'cbx_nacionalidad
        '
        Me.cbx_nacionalidad.BackColor = System.Drawing.Color.White
        Me.cbx_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_nacionalidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_nacionalidad.FormattingEnabled = True
        Me.cbx_nacionalidad.Items.AddRange(New Object() {"México", "USA", "Japón"})
        Me.cbx_nacionalidad.Location = New System.Drawing.Point(30, 344)
        Me.cbx_nacionalidad.Name = "cbx_nacionalidad"
        Me.cbx_nacionalidad.Size = New System.Drawing.Size(104, 21)
        Me.cbx_nacionalidad.TabIndex = 431
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(49, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 426
        Me.Label5.Text = "Términos"
        '
        'cbx_terminos
        '
        Me.cbx_terminos.BackColor = System.Drawing.Color.White
        Me.cbx_terminos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_terminos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_terminos.FormattingEnabled = True
        Me.cbx_terminos.Items.AddRange(New Object() {"15 días", "30 días", "Contado"})
        Me.cbx_terminos.Location = New System.Drawing.Point(31, 259)
        Me.cbx_terminos.Name = "cbx_terminos"
        Me.cbx_terminos.Size = New System.Drawing.Size(104, 21)
        Me.cbx_terminos.TabIndex = 425
        '
        'txt_curp
        '
        Me.txt_curp.BackColor = System.Drawing.SystemColors.Control
        Me.txt_curp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_curp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_curp.Location = New System.Drawing.Point(9, 192)
        Me.txt_curp.MaxLength = 18
        Me.txt_curp.Name = "txt_curp"
        Me.txt_curp.Size = New System.Drawing.Size(216, 20)
        Me.txt_curp.TabIndex = 137
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "CURP"
        '
        'txt_rfc
        '
        Me.txt_rfc.BackColor = System.Drawing.SystemColors.Control
        Me.txt_rfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_rfc.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_rfc.Location = New System.Drawing.Point(9, 136)
        Me.txt_rfc.MaxLength = 13
        Me.txt_rfc.Name = "txt_rfc"
        Me.txt_rfc.Size = New System.Drawing.Size(216, 20)
        Me.txt_rfc.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "RFC"
        '
        'txt_razonsocial
        '
        Me.txt_razonsocial.BackColor = System.Drawing.SystemColors.Control
        Me.txt_razonsocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_razonsocial.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_razonsocial.Location = New System.Drawing.Point(9, 83)
        Me.txt_razonsocial.MaxLength = 70
        Me.txt_razonsocial.Name = "txt_razonsocial"
        Me.txt_razonsocial.Size = New System.Drawing.Size(477, 20)
        Me.txt_razonsocial.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Razón social"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(9, 32)
        Me.txt_nombre.MaxLength = 70
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(477, 20)
        Me.txt_nombre.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Nombre del proveedor"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btn_cp)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.txt_email)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.txt_tel2)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txt_tel1)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txt_interior)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txt_numero)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txt_calle)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.cbx_colonia)
        Me.TabPage2.Controls.Add(Me.txt_municipio)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txt_estado)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_pais)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_cp)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(816, 479)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Domicilio y contactos"
        '
        'btn_cp
        '
        Me.btn_cp.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cp.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__1_
        Me.btn_cp.Location = New System.Drawing.Point(117, 54)
        Me.btn_cp.Name = "btn_cp"
        Me.btn_cp.Size = New System.Drawing.Size(34, 38)
        Me.btn_cp.TabIndex = 448
        Me.btn_cp.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_detallecontacto)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.cbx_rolcontacto)
        Me.GroupBox1.Controls.Add(Me.txt_apellidocontacto)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txt_NombreContacto)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txt_tel2contacto)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txt_mailcontacto)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txt_tel1contacto)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(466, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 467)
        Me.GroupBox1.TabIndex = 447
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contacto"
        '
        'txt_detallecontacto
        '
        Me.txt_detallecontacto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_detallecontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_detallecontacto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_detallecontacto.Location = New System.Drawing.Point(9, 188)
        Me.txt_detallecontacto.MaxLength = 50
        Me.txt_detallecontacto.Multiline = True
        Me.txt_detallecontacto.Name = "txt_detallecontacto"
        Me.txt_detallecontacto.Size = New System.Drawing.Size(244, 47)
        Me.txt_detallecontacto.TabIndex = 459
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(11, 171)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 13)
        Me.Label25.TabIndex = 460
        Me.Label25.Text = "Detalle"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(11, 119)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 13)
        Me.Label24.TabIndex = 458
        Me.Label24.Text = "Rol"
        '
        'cbx_rolcontacto
        '
        Me.cbx_rolcontacto.BackColor = System.Drawing.Color.White
        Me.cbx_rolcontacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_rolcontacto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_rolcontacto.FormattingEnabled = True
        Me.cbx_rolcontacto.Items.AddRange(New Object() {"", "Vendedor", "Comprador", "Gerente", "Atención al cliente"})
        Me.cbx_rolcontacto.Location = New System.Drawing.Point(9, 138)
        Me.cbx_rolcontacto.Name = "cbx_rolcontacto"
        Me.cbx_rolcontacto.Size = New System.Drawing.Size(243, 21)
        Me.cbx_rolcontacto.TabIndex = 457
        '
        'txt_apellidocontacto
        '
        Me.txt_apellidocontacto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_apellidocontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidocontacto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_apellidocontacto.Location = New System.Drawing.Point(8, 86)
        Me.txt_apellidocontacto.MaxLength = 50
        Me.txt_apellidocontacto.Name = "txt_apellidocontacto"
        Me.txt_apellidocontacto.Size = New System.Drawing.Size(244, 20)
        Me.txt_apellidocontacto.TabIndex = 455
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(10, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 456
        Me.Label22.Text = "Apellido"
        '
        'txt_NombreContacto
        '
        Me.txt_NombreContacto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_NombreContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_NombreContacto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_NombreContacto.Location = New System.Drawing.Point(9, 40)
        Me.txt_NombreContacto.MaxLength = 50
        Me.txt_NombreContacto.Name = "txt_NombreContacto"
        Me.txt_NombreContacto.Size = New System.Drawing.Size(243, 20)
        Me.txt_NombreContacto.TabIndex = 453
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(11, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 454
        Me.Label23.Text = "Nombre"
        '
        'txt_tel2contacto
        '
        Me.txt_tel2contacto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_tel2contacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tel2contacto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_tel2contacto.Location = New System.Drawing.Point(10, 349)
        Me.txt_tel2contacto.MaxLength = 15
        Me.txt_tel2contacto.Name = "txt_tel2contacto"
        Me.txt_tel2contacto.Size = New System.Drawing.Size(210, 20)
        Me.txt_tel2contacto.TabIndex = 451
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(12, 332)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 452
        Me.Label21.Text = "Teléfono 2"
        '
        'txt_mailcontacto
        '
        Me.txt_mailcontacto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_mailcontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_mailcontacto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_mailcontacto.Location = New System.Drawing.Point(10, 260)
        Me.txt_mailcontacto.MaxLength = 50
        Me.txt_mailcontacto.Name = "txt_mailcontacto"
        Me.txt_mailcontacto.Size = New System.Drawing.Size(210, 20)
        Me.txt_mailcontacto.TabIndex = 449
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(12, 243)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 13)
        Me.Label19.TabIndex = 450
        Me.Label19.Text = "Email"
        '
        'txt_tel1contacto
        '
        Me.txt_tel1contacto.BackColor = System.Drawing.SystemColors.Control
        Me.txt_tel1contacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tel1contacto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_tel1contacto.Location = New System.Drawing.Point(10, 304)
        Me.txt_tel1contacto.MaxLength = 15
        Me.txt_tel1contacto.Name = "txt_tel1contacto"
        Me.txt_tel1contacto.Size = New System.Drawing.Size(210, 20)
        Me.txt_tel1contacto.TabIndex = 447
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(12, 287)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 448
        Me.Label20.Text = "Teléfono 1"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.SystemColors.Control
        Me.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_email.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_email.Location = New System.Drawing.Point(7, 393)
        Me.txt_email.MaxLength = 50
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(210, 20)
        Me.txt_email.TabIndex = 445
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(9, 376)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 446
        Me.Label18.Text = "Email"
        '
        'txt_tel2
        '
        Me.txt_tel2.BackColor = System.Drawing.SystemColors.Control
        Me.txt_tel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tel2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_tel2.Location = New System.Drawing.Point(7, 343)
        Me.txt_tel2.MaxLength = 15
        Me.txt_tel2.Name = "txt_tel2"
        Me.txt_tel2.Size = New System.Drawing.Size(210, 20)
        Me.txt_tel2.TabIndex = 443
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(9, 326)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 444
        Me.Label17.Text = "Teléfono 2"
        '
        'txt_tel1
        '
        Me.txt_tel1.BackColor = System.Drawing.SystemColors.Control
        Me.txt_tel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_tel1.Location = New System.Drawing.Point(8, 290)
        Me.txt_tel1.MaxLength = 15
        Me.txt_tel1.Name = "txt_tel1"
        Me.txt_tel1.Size = New System.Drawing.Size(210, 20)
        Me.txt_tel1.TabIndex = 441
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(10, 273)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 442
        Me.Label16.Text = "Teléfono 1"
        '
        'txt_interior
        '
        Me.txt_interior.BackColor = System.Drawing.SystemColors.Control
        Me.txt_interior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_interior.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_interior.Location = New System.Drawing.Point(320, 247)
        Me.txt_interior.MaxLength = 5
        Me.txt_interior.Name = "txt_interior"
        Me.txt_interior.Size = New System.Drawing.Size(63, 20)
        Me.txt_interior.TabIndex = 439
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(322, 230)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 440
        Me.Label15.Text = "Interior"
        '
        'txt_numero
        '
        Me.txt_numero.BackColor = System.Drawing.SystemColors.Control
        Me.txt_numero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numero.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_numero.Location = New System.Drawing.Point(237, 247)
        Me.txt_numero.MaxLength = 5
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(63, 20)
        Me.txt_numero.TabIndex = 437
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(239, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 438
        Me.Label13.Text = "Número"
        '
        'txt_calle
        '
        Me.txt_calle.BackColor = System.Drawing.SystemColors.Control
        Me.txt_calle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_calle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_calle.Location = New System.Drawing.Point(7, 247)
        Me.txt_calle.MaxLength = 50
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(210, 20)
        Me.txt_calle.TabIndex = 435
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(9, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 436
        Me.Label14.Text = "Calle"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(9, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 434
        Me.Label12.Text = "Colonia"
        '
        'cbx_colonia
        '
        Me.cbx_colonia.BackColor = System.Drawing.Color.White
        Me.cbx_colonia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_colonia.FormattingEnabled = True
        Me.cbx_colonia.Location = New System.Drawing.Point(6, 199)
        Me.cbx_colonia.MaxLength = 50
        Me.cbx_colonia.Name = "cbx_colonia"
        Me.cbx_colonia.Size = New System.Drawing.Size(245, 21)
        Me.cbx_colonia.TabIndex = 433
        '
        'txt_municipio
        '
        Me.txt_municipio.BackColor = System.Drawing.SystemColors.Control
        Me.txt_municipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_municipio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_municipio.Location = New System.Drawing.Point(7, 156)
        Me.txt_municipio.MaxLength = 50
        Me.txt_municipio.Name = "txt_municipio"
        Me.txt_municipio.Size = New System.Drawing.Size(244, 20)
        Me.txt_municipio.TabIndex = 145
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(9, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 146
        Me.Label11.Text = "Municipio"
        '
        'txt_estado
        '
        Me.txt_estado.BackColor = System.Drawing.SystemColors.Control
        Me.txt_estado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_estado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_estado.Location = New System.Drawing.Point(8, 110)
        Me.txt_estado.MaxLength = 50
        Me.txt_estado.Name = "txt_estado"
        Me.txt_estado.Size = New System.Drawing.Size(243, 20)
        Me.txt_estado.TabIndex = 143
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Estado"
        '
        'txt_pais
        '
        Me.txt_pais.BackColor = System.Drawing.SystemColors.Control
        Me.txt_pais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pais.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_pais.Location = New System.Drawing.Point(9, 22)
        Me.txt_pais.MaxLength = 50
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(242, 20)
        Me.txt_pais.TabIndex = 141
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "País"
        '
        'txt_cp
        '
        Me.txt_cp.BackColor = System.Drawing.SystemColors.Control
        Me.txt_cp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_cp.Location = New System.Drawing.Point(12, 64)
        Me.txt_cp.MaxLength = 6
        Me.txt_cp.Name = "txt_cp"
        Me.txt_cp.Size = New System.Drawing.Size(97, 20)
        Me.txt_cp.TabIndex = 139
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "CP"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Panel7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.btn_bloquear)
        Me.TabPage3.Controls.Add(Me.txt_banco)
        Me.TabPage3.Controls.Add(Me.btn_quitar)
        Me.TabPage3.Controls.Add(Me.txt_iban)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.txt_swift)
        Me.TabPage3.Controls.Add(Me.Label31)
        Me.TabPage3.Controls.Add(Me.txt_aba)
        Me.TabPage3.Controls.Add(Me.Label32)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.cbx_tipo)
        Me.TabPage3.Controls.Add(Me.txt_clabe)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.txt_cuenta)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.cbx_monedacuenta)
        Me.TabPage3.Controls.Add(Me.dtgv_cuentas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(816, 479)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cuentas"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__1_
        Me.Button1.Location = New System.Drawing.Point(215, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 38)
        Me.Button1.TabIndex = 536
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Yellow
        Me.Panel7.Location = New System.Drawing.Point(441, 6)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(32, 13)
        Me.Panel7.TabIndex = 535
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(474, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 9)
        Me.Label6.TabIndex = 534
        Me.Label6.Text = "INACTIVA"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGreen
        Me.Panel3.Location = New System.Drawing.Point(278, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(32, 13)
        Me.Panel3.TabIndex = 533
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label34.Location = New System.Drawing.Point(312, 9)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(33, 9)
        Me.Label34.TabIndex = 532
        Me.Label34.Text = "ACTIVA"
        '
        'btn_bloquear
        '
        Me.btn_bloquear.BackColor = System.Drawing.Color.Yellow
        Me.btn_bloquear.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__1_
        Me.btn_bloquear.Location = New System.Drawing.Point(638, 185)
        Me.btn_bloquear.Name = "btn_bloquear"
        Me.btn_bloquear.Size = New System.Drawing.Size(34, 38)
        Me.btn_bloquear.TabIndex = 444
        Me.btn_bloquear.UseVisualStyleBackColor = False
        Me.btn_bloquear.Visible = False
        '
        'txt_banco
        '
        Me.txt_banco.BackColor = System.Drawing.Color.White
        Me.txt_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_banco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_banco.FormattingEnabled = True
        Me.txt_banco.Items.AddRange(New Object() {"MEX", "USD", "YEN"})
        Me.txt_banco.Location = New System.Drawing.Point(5, 56)
        Me.txt_banco.Name = "txt_banco"
        Me.txt_banco.Size = New System.Drawing.Size(632, 21)
        Me.txt_banco.TabIndex = 443
        '
        'btn_quitar
        '
        Me.btn_quitar.BackColor = System.Drawing.Color.Red
        Me.btn_quitar.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__1_
        Me.btn_quitar.Location = New System.Drawing.Point(395, 185)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(34, 38)
        Me.btn_quitar.TabIndex = 442
        Me.btn_quitar.UseVisualStyleBackColor = False
        '
        'txt_iban
        '
        Me.txt_iban.BackColor = System.Drawing.SystemColors.Control
        Me.txt_iban.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_iban.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_iban.Location = New System.Drawing.Point(553, 158)
        Me.txt_iban.MaxLength = 10
        Me.txt_iban.Name = "txt_iban"
        Me.txt_iban.Size = New System.Drawing.Size(236, 20)
        Me.txt_iban.TabIndex = 439
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(555, 141)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(36, 13)
        Me.Label33.TabIndex = 440
        Me.Label33.Text = "IBAN"
        '
        'txt_swift
        '
        Me.txt_swift.BackColor = System.Drawing.SystemColors.Control
        Me.txt_swift.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_swift.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_swift.Location = New System.Drawing.Point(278, 158)
        Me.txt_swift.MaxLength = 10
        Me.txt_swift.Name = "txt_swift"
        Me.txt_swift.Size = New System.Drawing.Size(236, 20)
        Me.txt_swift.TabIndex = 437
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(280, 141)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(46, 13)
        Me.Label31.TabIndex = 438
        Me.Label31.Text = "SWIFT"
        '
        'txt_aba
        '
        Me.txt_aba.BackColor = System.Drawing.SystemColors.Control
        Me.txt_aba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_aba.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_aba.Location = New System.Drawing.Point(4, 158)
        Me.txt_aba.MaxLength = 10
        Me.txt_aba.Name = "txt_aba"
        Me.txt_aba.Size = New System.Drawing.Size(236, 20)
        Me.txt_aba.TabIndex = 435
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(6, 135)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(31, 13)
        Me.Label32.TabIndex = 436
        Me.Label32.Text = "ABA"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(585, 92)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 13)
        Me.Label30.TabIndex = 434
        Me.Label30.Text = "Tipo"
        '
        'cbx_tipo
        '
        Me.cbx_tipo.BackColor = System.Drawing.Color.White
        Me.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_tipo.FormattingEnabled = True
        Me.cbx_tipo.Items.AddRange(New Object() {"Transferencia", "Depósito"})
        Me.cbx_tipo.Location = New System.Drawing.Point(588, 108)
        Me.cbx_tipo.Name = "cbx_tipo"
        Me.cbx_tipo.Size = New System.Drawing.Size(154, 21)
        Me.cbx_tipo.TabIndex = 433
        '
        'txt_clabe
        '
        Me.txt_clabe.BackColor = System.Drawing.SystemColors.Control
        Me.txt_clabe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_clabe.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_clabe.Location = New System.Drawing.Point(278, 109)
        Me.txt_clabe.MaxLength = 20
        Me.txt_clabe.Name = "txt_clabe"
        Me.txt_clabe.Size = New System.Drawing.Size(236, 20)
        Me.txt_clabe.TabIndex = 431
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(280, 92)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(39, 13)
        Me.Label29.TabIndex = 432
        Me.Label29.Text = "Clabe"
        '
        'txt_cuenta
        '
        Me.txt_cuenta.BackColor = System.Drawing.SystemColors.Control
        Me.txt_cuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cuenta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_cuenta.Location = New System.Drawing.Point(4, 109)
        Me.txt_cuenta.MaxLength = 18
        Me.txt_cuenta.Name = "txt_cuenta"
        Me.txt_cuenta.Size = New System.Drawing.Size(236, 20)
        Me.txt_cuenta.TabIndex = 429
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(6, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 13)
        Me.Label28.TabIndex = 430
        Me.Label28.Text = "Cuenta"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(6, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 13)
        Me.Label27.TabIndex = 428
        Me.Label27.Text = "Banco"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(706, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 426
        Me.Label26.Text = "Moneda"
        '
        'cbx_monedacuenta
        '
        Me.cbx_monedacuenta.BackColor = System.Drawing.Color.White
        Me.cbx_monedacuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_monedacuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_monedacuenta.FormattingEnabled = True
        Me.cbx_monedacuenta.Items.AddRange(New Object() {"MEX", "USD", "YEN"})
        Me.cbx_monedacuenta.Location = New System.Drawing.Point(699, 56)
        Me.cbx_monedacuenta.Name = "cbx_monedacuenta"
        Me.cbx_monedacuenta.Size = New System.Drawing.Size(68, 21)
        Me.cbx_monedacuenta.TabIndex = 425
        '
        'dtgv_cuentas
        '
        Me.dtgv_cuentas.AllowUserToAddRows = False
        Me.dtgv_cuentas.AllowUserToDeleteRows = False
        Me.dtgv_cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgv_cuentas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgv_cuentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_cuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Banco, Me.Cuenta, Me.Clabe, Me.Tipo, Me.ABA, Me.SWIFT, Me.IBAN, Me.Moneda})
        Me.dtgv_cuentas.Location = New System.Drawing.Point(3, 227)
        Me.dtgv_cuentas.Name = "dtgv_cuentas"
        Me.dtgv_cuentas.RowHeadersVisible = False
        Me.dtgv_cuentas.Size = New System.Drawing.Size(807, 239)
        Me.dtgv_cuentas.TabIndex = 424
        '
        'Banco
        '
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.Width = 63
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Width = 66
        '
        'Clabe
        '
        Me.Clabe.HeaderText = "Clabe"
        Me.Clabe.Name = "Clabe"
        Me.Clabe.Width = 59
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 53
        '
        'ABA
        '
        Me.ABA.HeaderText = "ABA"
        Me.ABA.Name = "ABA"
        Me.ABA.Width = 53
        '
        'SWIFT
        '
        Me.SWIFT.HeaderText = "SWIFT"
        Me.SWIFT.Name = "SWIFT"
        Me.SWIFT.Width = 66
        '
        'IBAN
        '
        Me.IBAN.HeaderText = "IBAN"
        Me.IBAN.Name = "IBAN"
        Me.IBAN.Width = 57
        '
        'Moneda
        '
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Width = 71
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_solicitar.Location = New System.Drawing.Point(342, 515)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(120, 35)
        Me.btn_solicitar.TabIndex = 425
        Me.btn_solicitar.Text = "Crear"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        '
        'Alta_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 552)
        Me.Controls.Add(Me.btn_solicitar)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Alta_proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de proveedores"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dtgv_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txt_curp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_rfc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_razonsocial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbx_terminos As ComboBox
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cbx_nacionalidad As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cbx_rolcontacto As ComboBox
    Friend WithEvents txt_apellidocontacto As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_NombreContacto As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_tel2contacto As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_mailcontacto As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_tel1contacto As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_tel2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_tel1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_interior As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbx_colonia As ComboBox
    Friend WithEvents txt_municipio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_estado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_cp As Button
    Friend WithEvents txt_detallecontacto As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_iban As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txt_swift As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_aba As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents cbx_tipo As ComboBox
    Friend WithEvents txt_clabe As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_cuenta As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents cbx_monedacuenta As ComboBox
    Friend WithEvents dtgv_cuentas As DataGridView
    Friend WithEvents txt_banco As ComboBox
    Friend WithEvents btn_quitar As Button
    Friend WithEvents Banco As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Clabe As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents ABA As DataGridViewTextBoxColumn
    Friend WithEvents SWIFT As DataGridViewTextBoxColumn
    Friend WithEvents IBAN As DataGridViewTextBoxColumn
    Friend WithEvents Moneda As DataGridViewTextBoxColumn
    Friend WithEvents btn_bloquear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label34 As Label
End Class
