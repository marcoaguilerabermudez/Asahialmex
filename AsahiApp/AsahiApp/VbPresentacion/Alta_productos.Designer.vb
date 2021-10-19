<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alta_productos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_numeroparte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_ucompra = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_uconsumo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_fam = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_inventario = New System.Windows.Forms.ComboBox()
        Me.txt_descr = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbx_anaquel = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbx_pasillo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_nivel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbx_ualmacen = New System.Windows.Forms.ComboBox()
        Me.lbl_código = New System.Windows.Forms.Label()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Nombre del producto"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(8, 56)
        Me.txt_nombre.MaxLength = 99
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(392, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_numeroparte
        '
        Me.txt_numeroparte.BackColor = System.Drawing.SystemColors.Control
        Me.txt_numeroparte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numeroparte.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_numeroparte.Location = New System.Drawing.Point(8, 100)
        Me.txt_numeroparte.MaxLength = 99
        Me.txt_numeroparte.Name = "txt_numeroparte"
        Me.txt_numeroparte.Size = New System.Drawing.Size(392, 20)
        Me.txt_numeroparte.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Número de parte"
        '
        'cbx_ucompra
        '
        Me.cbx_ucompra.BackColor = System.Drawing.Color.White
        Me.cbx_ucompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_ucompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_ucompra.FormattingEnabled = True
        Me.cbx_ucompra.Items.AddRange(New Object() {"Pieza", "Kilogramo", "Litro", "Par", "Galon", "Caja", "Metro", "Pulgada", "centímetro", "Yarda", "Kilómetro", "Gramo", "Onza", "Libra", "Tonelada", "Milla", "ROLLO", "BOLSA", "SET", "Hora", "Paquete", "Tambo", "Noche", "Servicio", "Millar", "Cilindro", "Cubeta"})
        Me.cbx_ucompra.Location = New System.Drawing.Point(15, 204)
        Me.cbx_ucompra.Name = "cbx_ucompra"
        Me.cbx_ucompra.Size = New System.Drawing.Size(146, 21)
        Me.cbx_ucompra.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 13)
        Me.Label3.TabIndex = 413
        Me.Label3.Text = "Unidad de medida (compra)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(229, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 13)
        Me.Label4.TabIndex = 415
        Me.Label4.Text = "Unidad de medida (consumo)"
        '
        'cbx_uconsumo
        '
        Me.cbx_uconsumo.BackColor = System.Drawing.Color.White
        Me.cbx_uconsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_uconsumo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_uconsumo.FormattingEnabled = True
        Me.cbx_uconsumo.Items.AddRange(New Object() {"Pieza", "Kilogramo", "Litro", "Par", "Galon", "Caja", "Metro", "Pulgada", "centímetro", "Yarda", "Kilómetro", "Gramo", "Onza", "Libra", "Tonelada", "Milla", "ROLLO", "BOLSA", "SET", "Hora", "Paquete", "Tambo", "Noche", "Servicio", "Millar", "Cilindro", "Cubeta"})
        Me.cbx_uconsumo.Location = New System.Drawing.Point(237, 204)
        Me.cbx_uconsumo.Name = "cbx_uconsumo"
        Me.cbx_uconsumo.Size = New System.Drawing.Size(146, 21)
        Me.cbx_uconsumo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Familia"
        '
        'cbx_fam
        '
        Me.cbx_fam.BackColor = System.Drawing.Color.White
        Me.cbx_fam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_fam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_fam.FormattingEnabled = True
        Me.cbx_fam.Items.AddRange(New Object() {"SUBENSAMBLE-ACABADO", "AJUSTE AL NETO", "SUBENSAMBLE-FUNDICIÓN", "SUBENSAMBLE-CASTING", "REPARACIÓN Y MANTENIMIENTO", "REFACCIONES", "INSUMOS", "SERVICIO Y ARTÍCULO DE LIMPIEZA", "HERRAMIENTAS", "EQUIPO DE SEGURIDAD", "MATERIAL DE EMPAQUE", "ACEITES Y LUBRICANTES", "PERNOS", "ADHESIVOS", "CONSUMIBLES (GASES)", "GAS LP", "UNIFORMES", "EQUIPO DE PLANTA", "PAPELERÍA Y UTILES", "HERRAMIENTAS DE CORTE", "COOLANT", "DIESEL", "ACTIVO FIJO", "SEGURIDAD E HIGIENE", "DAP", "SORTEOS", "ACCESORIOS EQUIPO DE COMPUTO", "MANTENIMIENTO DE PLANTA", "ATENCIÓN AL CLIENTE", "HONORARIOS PERSONAS FISICAS", "MEDICO", "RENTAS DE DEPARTAMENTOS", "OTROS GASTOS", "OTROS GASTOS DEDUCIBLES", "MANTENIMIENTO DE MAQUINARIA", "SOFTWARE Y LICENCIAS", "SEVICIOS ADMINISTRATIVOS HALMEX", "HOSPEDAJE", "VALES DE DESPENSA", "GASOLINA", "SEGURIDAD Y VIGILANCIA", "GASTOS POR DEFECTOS / REWORKS", "FARMACIA", "RECARGOS", "MANTENIMIENTO Y SERVICIOS DE AUTOMOVIL", "INSTALACIÓN DE MAQUINARIA", "GAS NATURAL", "RENTA DE IMPRESORA", "RECOLECCIÓN DE BASURA", "RECOLECCIÓN DE AGUAS RESIDUALES", "COMEDOR", "AGUA", "ENERGIA ELECTRICA", "MANIOBRAS Y FLETES", "GASTOS ADUANALES", "PRIMAS DE SEGUROS", "CAPACITACION", "EQUIPO DE COMPUTO / COMPUTER EQUIPMENT", "PARTES DE ENSAMBLE", "LAVANDERIA", "TELFONO CELULAR", "MANTENIMIENTO DE INSTRUMENTOS DE MEDICIÓN", "AGUA PARA CONSUMO", "HONORARIOS PERSONAS MORALES", "MATERIA PRIMA", "ARRENDAMIENTO DE AUTOMOVILES", "MANIOBRAS Y FLETES EXPEDITADOS", "EQUIPO DE CARGA", "GASTOS DE VIAJE", "GASTOS DE CERTIFICACIÓN", "CUOTAS Y SUSCRIPCIONES", "PROPAGANDA Y PUBLICIDAD", "GASTOS MIGRATORIOS", "CASETAS", "IMPUESTO PREDIAL / LAND TAX", "PROCESOS EXTERNOS", "COMISIONES BANCARIAS", "DESCUENTOS/ DEVOLUCIONES SOBRE COMPRA", "DESPERDICIO", "SUBENSAMBLE-ENSAMBLE", "DTA", "PRV", "SUBENSAMBLE-INSPECCIÓN", "INTERESES PAGADOS", "SUBENSABLE-MAQUINADO", "MULTAS, ACTUALIZACIONES Y RECARGOS", "REGALIAS 5%", "SERVICIOS ADMIN. DE NOMINA", "PRODUCTO TERMINADO"})
        Me.cbx_fam.Location = New System.Drawing.Point(10, 148)
        Me.cbx_fam.Name = "cbx_fam"
        Me.cbx_fam.Size = New System.Drawing.Size(390, 21)
        Me.cbx_fam.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(130, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 13)
        Me.Label6.TabIndex = 419
        Me.Label6.Text = "Es artículo de inventario"
        '
        'cbx_inventario
        '
        Me.cbx_inventario.BackColor = System.Drawing.Color.White
        Me.cbx_inventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_inventario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_inventario.FormattingEnabled = True
        Me.cbx_inventario.Items.AddRange(New Object() {"Sí", "No"})
        Me.cbx_inventario.Location = New System.Drawing.Point(165, 262)
        Me.cbx_inventario.Name = "cbx_inventario"
        Me.cbx_inventario.Size = New System.Drawing.Size(68, 21)
        Me.cbx_inventario.TabIndex = 5
        '
        'txt_descr
        '
        Me.txt_descr.BackColor = System.Drawing.SystemColors.Control
        Me.txt_descr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_descr.Location = New System.Drawing.Point(8, 323)
        Me.txt_descr.MaxLength = 149
        Me.txt_descr.Multiline = True
        Me.txt_descr.Name = "txt_descr"
        Me.txt_descr.Size = New System.Drawing.Size(392, 56)
        Me.txt_descr.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 422
        Me.Label8.Text = "Descripción"
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_solicitar.Location = New System.Drawing.Point(163, 421)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(120, 35)
        Me.btn_solicitar.TabIndex = 424
        Me.btn_solicitar.Text = "Crear"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cbx_anaquel)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbx_pasillo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbx_nivel)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbx_ualmacen)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(406, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 221)
        Me.GroupBox2.TabIndex = 426
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 421
        Me.Label11.Text = "Anaquel"
        '
        'cbx_anaquel
        '
        Me.cbx_anaquel.BackColor = System.Drawing.Color.White
        Me.cbx_anaquel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_anaquel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_anaquel.FormattingEnabled = True
        Me.cbx_anaquel.Items.AddRange(New Object() {"N/A", "TEST"})
        Me.cbx_anaquel.Location = New System.Drawing.Point(16, 142)
        Me.cbx_anaquel.Name = "cbx_anaquel"
        Me.cbx_anaquel.Size = New System.Drawing.Size(246, 21)
        Me.cbx_anaquel.TabIndex = 420
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 419
        Me.Label10.Text = "Pasillo"
        '
        'cbx_pasillo
        '
        Me.cbx_pasillo.BackColor = System.Drawing.Color.White
        Me.cbx_pasillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_pasillo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_pasillo.FormattingEnabled = True
        Me.cbx_pasillo.Items.AddRange(New Object() {"N/A", "TEST"})
        Me.cbx_pasillo.Location = New System.Drawing.Point(16, 92)
        Me.cbx_pasillo.Name = "cbx_pasillo"
        Me.cbx_pasillo.Size = New System.Drawing.Size(246, 21)
        Me.cbx_pasillo.TabIndex = 418
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 417
        Me.Label7.Text = "Nivel"
        '
        'cbx_nivel
        '
        Me.cbx_nivel.BackColor = System.Drawing.Color.White
        Me.cbx_nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_nivel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_nivel.FormattingEnabled = True
        Me.cbx_nivel.Items.AddRange(New Object() {"N/A", "TEST"})
        Me.cbx_nivel.Location = New System.Drawing.Point(16, 190)
        Me.cbx_nivel.Name = "cbx_nivel"
        Me.cbx_nivel.Size = New System.Drawing.Size(246, 21)
        Me.cbx_nivel.TabIndex = 416
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 415
        Me.Label9.Text = "Almacén"
        '
        'cbx_ualmacen
        '
        Me.cbx_ualmacen.BackColor = System.Drawing.Color.White
        Me.cbx_ualmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_ualmacen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_ualmacen.FormattingEnabled = True
        Me.cbx_ualmacen.Items.AddRange(New Object() {"N/A", "TEST"})
        Me.cbx_ualmacen.Location = New System.Drawing.Point(16, 45)
        Me.cbx_ualmacen.Name = "cbx_ualmacen"
        Me.cbx_ualmacen.Size = New System.Drawing.Size(246, 21)
        Me.cbx_ualmacen.TabIndex = 7
        '
        'lbl_código
        '
        Me.lbl_código.AutoSize = True
        Me.lbl_código.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_código.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_código.ForeColor = System.Drawing.Color.Black
        Me.lbl_código.Location = New System.Drawing.Point(6, 12)
        Me.lbl_código.Name = "lbl_código"
        Me.lbl_código.Size = New System.Drawing.Size(125, 13)
        Me.lbl_código.TabIndex = 427
        Me.lbl_código.Text = "Nombre del producto"
        Me.lbl_código.Visible = False
        '
        'pbx
        '
        Me.pbx.ErrorImage = Global.Presentacion.My.Resources.Resources.Logo
        Me.pbx.Location = New System.Drawing.Point(467, 28)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(174, 172)
        Me.pbx.TabIndex = 428
        Me.pbx.TabStop = False
        '
        'Alta_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 464)
        Me.Controls.Add(Me.pbx)
        Me.Controls.Add(Me.lbl_código)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_solicitar)
        Me.Controls.Add(Me.txt_descr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbx_inventario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbx_fam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_uconsumo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbx_ucompra)
        Me.Controls.Add(Me.txt_numeroparte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Alta_productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de productos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_numeroparte As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_ucompra As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_uconsumo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbx_fam As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbx_inventario As ComboBox
    Friend WithEvents txt_descr As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbx_ualmacen As ComboBox
    Friend WithEvents lbl_código As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbx_anaquel As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbx_pasillo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbx_nivel As ComboBox
    Friend WithEvents pbx As PictureBox
End Class
