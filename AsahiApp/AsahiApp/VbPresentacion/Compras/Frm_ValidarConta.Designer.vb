<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ValidarConta
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
        Me.Btn_Validar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Monto = New System.Windows.Forms.Button()
        Me.Btn_MarcaStatus = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_FecPago = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_FechRecepcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Moneda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Serie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Status = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Empresa = New System.Windows.Forms.TextBox()
        Me.Txt_Proveedor = New System.Windows.Forms.TextBox()
        Me.Txt_Factura = New System.Windows.Forms.TextBox()
        Me.Txt_Oc = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.seleccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaValid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPovision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPagoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observaConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.add1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Btn_Validar)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1202, 92)
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
        Me.Btn_Validar.Location = New System.Drawing.Point(850, 19)
        Me.Btn_Validar.Name = "Btn_Validar"
        Me.Btn_Validar.Size = New System.Drawing.Size(43, 55)
        Me.Btn_Validar.TabIndex = 11
        Me.Btn_Validar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Monto)
        Me.GroupBox2.Controls.Add(Me.Btn_MarcaStatus)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(551, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 92)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status y Monto"
        '
        'Btn_Monto
        '
        Me.Btn_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Monto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_Monto.Location = New System.Drawing.Point(154, 50)
        Me.Btn_Monto.Name = "Btn_Monto"
        Me.Btn_Monto.Size = New System.Drawing.Size(86, 30)
        Me.Btn_Monto.TabIndex = 27
        Me.Btn_Monto.Text = "Monto"
        Me.Btn_Monto.UseVisualStyleBackColor = True
        '
        'Btn_MarcaStatus
        '
        Me.Btn_MarcaStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MarcaStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btn_MarcaStatus.Location = New System.Drawing.Point(25, 50)
        Me.Btn_MarcaStatus.Name = "Btn_MarcaStatus"
        Me.Btn_MarcaStatus.Size = New System.Drawing.Size(86, 31)
        Me.Btn_MarcaStatus.TabIndex = 26
        Me.Btn_MarcaStatus.Text = "Marcar Status"
        Me.Btn_MarcaStatus.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(148, 25)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(98, 20)
        Me.TextBox6.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(20, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(541, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 92)
        Me.Panel9.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_FecPago)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Txt_FechRecepcion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_Moneda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_Serie)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_Status)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Empresa)
        Me.GroupBox1.Controls.Add(Me.Txt_Proveedor)
        Me.GroupBox1.Controls.Add(Me.Txt_Factura)
        Me.GroupBox1.Controls.Add(Me.Txt_Oc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(10, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 92)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTROS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(329, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Fecha de Pago"
        '
        'Txt_FecPago
        '
        Me.Txt_FecPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FecPago.Location = New System.Drawing.Point(327, 61)
        Me.Txt_FecPago.Name = "Txt_FecPago"
        Me.Txt_FecPago.Size = New System.Drawing.Size(95, 20)
        Me.Txt_FecPago.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(206, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Fecha de Recepción"
        '
        'Txt_FechRecepcion
        '
        Me.Txt_FechRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FechRecepcion.Location = New System.Drawing.Point(219, 61)
        Me.Txt_FechRecepcion.Name = "Txt_FechRecepcion"
        Me.Txt_FechRecepcion.Size = New System.Drawing.Size(95, 20)
        Me.Txt_FechRecepcion.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(136, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Moneda"
        '
        'Txt_Moneda
        '
        Me.Txt_Moneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Moneda.Location = New System.Drawing.Point(114, 61)
        Me.Txt_Moneda.Name = "Txt_Moneda"
        Me.Txt_Moneda.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Moneda.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Serie"
        '
        'Txt_Serie
        '
        Me.Txt_Serie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Serie.Location = New System.Drawing.Point(7, 61)
        Me.Txt_Serie.Name = "Txt_Serie"
        Me.Txt_Serie.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Serie.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Status"
        '
        'Txt_Status
        '
        Me.Txt_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Status.Location = New System.Drawing.Point(114, 25)
        Me.Txt_Status.Name = "Txt_Status"
        Me.Txt_Status.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Status.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(443, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Empresa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "OC"
        '
        'Txt_Empresa
        '
        Me.Txt_Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Empresa.Location = New System.Drawing.Point(446, 61)
        Me.Txt_Empresa.Name = "Txt_Empresa"
        Me.Txt_Empresa.Size = New System.Drawing.Size(52, 20)
        Me.Txt_Empresa.TabIndex = 9
        '
        'Txt_Proveedor
        '
        Me.Txt_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Proveedor.Location = New System.Drawing.Point(327, 25)
        Me.Txt_Proveedor.Name = "Txt_Proveedor"
        Me.Txt_Proveedor.Size = New System.Drawing.Size(196, 20)
        Me.Txt_Proveedor.TabIndex = 4
        '
        'Txt_Factura
        '
        Me.Txt_Factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Factura.Location = New System.Drawing.Point(218, 25)
        Me.Txt_Factura.Name = "Txt_Factura"
        Me.Txt_Factura.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Factura.TabIndex = 3
        '
        'Txt_Oc
        '
        Me.Txt_Oc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Oc.Location = New System.Drawing.Point(7, 25)
        Me.Txt_Oc.Name = "Txt_Oc"
        Me.Txt_Oc.Size = New System.Drawing.Size(95, 20)
        Me.Txt_Oc.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 92)
        Me.Panel8.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1202, 10)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 581)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1202, 10)
        Me.Panel5.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1192, 102)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 479)
        Me.Panel4.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 479)
        Me.Panel3.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DataGridView1)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(10, 102)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1182, 479)
        Me.Panel6.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seleccion, Me.fechaValid, Me.idPovision, Me.oc, Me.factura, Me.proveedor, Me.montoCompra, Me.montoFactura, Me.montoPagar, Me.fechaFactura, Me.fechaPagoFactura, Me.observaCompra, Me.moneda, Me.status, Me.statusConta, Me.statusPago, Me.observaConta, Me.empresa, Me.add1})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1182, 469)
        Me.DataGridView1.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 469)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1182, 10)
        Me.Panel7.TabIndex = 5
        '
        'seleccion
        '
        Me.seleccion.HeaderText = ""
        Me.seleccion.Name = "seleccion"
        Me.seleccion.Width = 30
        '
        'fechaValid
        '
        Me.fechaValid.HeaderText = "Fecha Val"
        Me.fechaValid.Name = "fechaValid"
        '
        'idPovision
        '
        Me.idPovision.HeaderText = "Provision"
        Me.idPovision.Name = "idPovision"
        Me.idPovision.Visible = False
        '
        'oc
        '
        Me.oc.HeaderText = "Oc"
        Me.oc.Name = "oc"
        '
        'factura
        '
        Me.factura.HeaderText = "Factura"
        Me.factura.Name = "factura"
        '
        'proveedor
        '
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        '
        'montoCompra
        '
        Me.montoCompra.HeaderText = "Monto Compra"
        Me.montoCompra.Name = "montoCompra"
        '
        'montoFactura
        '
        Me.montoFactura.HeaderText = "Monto Factura"
        Me.montoFactura.Name = "montoFactura"
        '
        'montoPagar
        '
        Me.montoPagar.HeaderText = "Monto a pagar"
        Me.montoPagar.Name = "montoPagar"
        '
        'fechaFactura
        '
        Me.fechaFactura.HeaderText = "Fecha Factura"
        Me.fechaFactura.Name = "fechaFactura"
        '
        'fechaPagoFactura
        '
        Me.fechaPagoFactura.HeaderText = "Fecha pago factura"
        Me.fechaPagoFactura.Name = "fechaPagoFactura"
        '
        'observaCompra
        '
        Me.observaCompra.HeaderText = "Observa Compra"
        Me.observaCompra.Name = "observaCompra"
        '
        'moneda
        '
        Me.moneda.HeaderText = "Moneda"
        Me.moneda.Name = "moneda"
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        '
        'statusConta
        '
        Me.statusConta.HeaderText = "Status Conta"
        Me.statusConta.Name = "statusConta"
        '
        'statusPago
        '
        Me.statusPago.HeaderText = "Status Pago"
        Me.statusPago.Name = "statusPago"
        '
        'observaConta
        '
        Me.observaConta.HeaderText = "Observa Conta"
        Me.observaConta.Name = "observaConta"
        '
        'empresa
        '
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        '
        'add1
        '
        Me.add1.HeaderText = "Add"
        Me.add1.Name = "add1"
        '
        'Frm_ValidarConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 591)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_ValidarConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validar Conta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Empresa As TextBox
    Friend WithEvents Txt_Proveedor As TextBox
    Friend WithEvents Txt_Factura As TextBox
    Friend WithEvents Txt_Oc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Moneda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Serie As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Status As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_FecPago As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_FechRecepcion As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Btn_Validar As Button
    Friend WithEvents Btn_Monto As Button
    Friend WithEvents Btn_MarcaStatus As Button
    Friend WithEvents seleccion As DataGridViewTextBoxColumn
    Friend WithEvents fechaValid As DataGridViewTextBoxColumn
    Friend WithEvents idPovision As DataGridViewTextBoxColumn
    Friend WithEvents oc As DataGridViewTextBoxColumn
    Friend WithEvents factura As DataGridViewTextBoxColumn
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents montoCompra As DataGridViewTextBoxColumn
    Friend WithEvents montoFactura As DataGridViewTextBoxColumn
    Friend WithEvents montoPagar As DataGridViewTextBoxColumn
    Friend WithEvents fechaFactura As DataGridViewTextBoxColumn
    Friend WithEvents fechaPagoFactura As DataGridViewTextBoxColumn
    Friend WithEvents observaCompra As DataGridViewTextBoxColumn
    Friend WithEvents moneda As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents statusConta As DataGridViewTextBoxColumn
    Friend WithEvents statusPago As DataGridViewTextBoxColumn
    Friend WithEvents observaConta As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents add1 As DataGridViewTextBoxColumn
End Class
