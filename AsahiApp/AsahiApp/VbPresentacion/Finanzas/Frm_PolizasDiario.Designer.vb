<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PolizasDiario
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Dgv_Prepolizas = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Dgv_Compras = New System.Windows.Forms.DataGridView()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Dtp_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Fin = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pivot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ordenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serieF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compraTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monedaVP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresaVP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcEmisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuidFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.familia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ivaT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoOc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPagoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPagoReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tazaCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.Dgv_Prepolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 21)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(950, 542)
        Me.Panel3.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Dgv_Prepolizas)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 322)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(950, 210)
        Me.Panel7.TabIndex = 3
        '
        'Dgv_Prepolizas
        '
        Me.Dgv_Prepolizas.AllowUserToAddRows = False
        Me.Dgv_Prepolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Prepolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pivot, Me.ordenCompra, Me.idCompra, Me.serieF, Me.idFactura, Me.nombreProveedor, Me.rfcProveedor, Me.totalFactura, Me.compraTotal, Me.fechaFact, Me.monedaVP, Me.empresaVP, Me.rfcEmisor, Me.nombreEmisor, Me.uuidFactura, Me.total, Me.area, Me.familia, Me.cuenta, Me.neto, Me.cuentaIva, Me.ivaT, Me.cuentaP, Me.impuesto})
        Me.Dgv_Prepolizas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Prepolizas.Location = New System.Drawing.Point(10, 0)
        Me.Dgv_Prepolizas.Name = "Dgv_Prepolizas"
        Me.Dgv_Prepolizas.RowHeadersVisible = False
        Me.Dgv_Prepolizas.Size = New System.Drawing.Size(930, 210)
        Me.Dgv_Prepolizas.TabIndex = 6
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(940, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 210)
        Me.Panel9.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 210)
        Me.Panel8.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 532)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(950, 10)
        Me.Panel6.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 296)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(950, 26)
        Me.Panel5.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Dgv_Compras)
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(950, 296)
        Me.Panel4.TabIndex = 0
        '
        'Dgv_Compras
        '
        Me.Dgv_Compras.AllowUserToAddRows = False
        Me.Dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.provision, Me.compra, Me.oc, Me.serie, Me.factura, Me.proveedor, Me.montoOc, Me.montoFact, Me.montoPagar, Me.montoCompra, Me.fechaFactura, Me.fechaPagoFactura, Me.fechaPagoReal, Me.moneda, Me.empresa, Me.fechaCompra, Me.uuid, Me.tazaCambio, Me.seleccion})
        Me.Dgv_Compras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Compras.Location = New System.Drawing.Point(10, 0)
        Me.Dgv_Compras.Name = "Dgv_Compras"
        Me.Dgv_Compras.RowHeadersVisible = False
        Me.Dgv_Compras.Size = New System.Drawing.Size(930, 296)
        Me.Dgv_Compras.TabIndex = 5
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(10, 296)
        Me.Panel11.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(940, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 296)
        Me.Panel10.TabIndex = 3
        '
        'Dtp_Inicio
        '
        Me.Dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Inicio.Location = New System.Drawing.Point(93, 15)
        Me.Dtp_Inicio.Name = "Dtp_Inicio"
        Me.Dtp_Inicio.Size = New System.Drawing.Size(96, 20)
        Me.Dtp_Inicio.TabIndex = 0
        '
        'Dtp_Fin
        '
        Me.Dtp_Fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Fin.Location = New System.Drawing.Point(274, 15)
        Me.Dtp_Fin.Name = "Dtp_Fin"
        Me.Dtp_Fin.Size = New System.Drawing.Size(95, 20)
        Me.Dtp_Fin.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Dtp_Fin)
        Me.Panel1.Controls.Add(Me.Dtp_Inicio)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(195, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicial"
        '
        'pivot
        '
        Me.pivot.HeaderText = "Pivote"
        Me.pivot.Name = "pivot"
        Me.pivot.ReadOnly = True
        Me.pivot.Width = 45
        '
        'ordenCompra
        '
        Me.ordenCompra.HeaderText = "OC"
        Me.ordenCompra.Name = "ordenCompra"
        Me.ordenCompra.ReadOnly = True
        Me.ordenCompra.Width = 40
        '
        'idCompra
        '
        Me.idCompra.HeaderText = "Compra"
        Me.idCompra.Name = "idCompra"
        Me.idCompra.ReadOnly = True
        Me.idCompra.Width = 50
        '
        'serieF
        '
        Me.serieF.HeaderText = "Serie"
        Me.serieF.Name = "serieF"
        Me.serieF.ReadOnly = True
        Me.serieF.Width = 40
        '
        'idFactura
        '
        Me.idFactura.HeaderText = "Factura"
        Me.idFactura.Name = "idFactura"
        Me.idFactura.ReadOnly = True
        Me.idFactura.Width = 50
        '
        'nombreProveedor
        '
        Me.nombreProveedor.HeaderText = "Proveedor"
        Me.nombreProveedor.Name = "nombreProveedor"
        Me.nombreProveedor.ReadOnly = True
        Me.nombreProveedor.Width = 170
        '
        'rfcProveedor
        '
        Me.rfcProveedor.HeaderText = "RFC"
        Me.rfcProveedor.Name = "rfcProveedor"
        Me.rfcProveedor.ReadOnly = True
        '
        'totalFactura
        '
        Me.totalFactura.HeaderText = "Total Factura"
        Me.totalFactura.Name = "totalFactura"
        Me.totalFactura.ReadOnly = True
        Me.totalFactura.Width = 80
        '
        'compraTotal
        '
        Me.compraTotal.HeaderText = "Compra Total"
        Me.compraTotal.Name = "compraTotal"
        Me.compraTotal.ReadOnly = True
        Me.compraTotal.Width = 80
        '
        'fechaFact
        '
        Me.fechaFact.HeaderText = "Fecha Factura"
        Me.fechaFact.Name = "fechaFact"
        Me.fechaFact.ReadOnly = True
        Me.fechaFact.Width = 80
        '
        'monedaVP
        '
        Me.monedaVP.HeaderText = "Moneda"
        Me.monedaVP.Name = "monedaVP"
        Me.monedaVP.ReadOnly = True
        Me.monedaVP.Width = 55
        '
        'empresaVP
        '
        Me.empresaVP.HeaderText = "Empresa"
        Me.empresaVP.Name = "empresaVP"
        Me.empresaVP.ReadOnly = True
        Me.empresaVP.Width = 55
        '
        'rfcEmisor
        '
        Me.rfcEmisor.HeaderText = "RFC Emisor"
        Me.rfcEmisor.Name = "rfcEmisor"
        Me.rfcEmisor.ReadOnly = True
        '
        'nombreEmisor
        '
        Me.nombreEmisor.HeaderText = "Emisor"
        Me.nombreEmisor.Name = "nombreEmisor"
        Me.nombreEmisor.ReadOnly = True
        Me.nombreEmisor.Width = 170
        '
        'uuidFactura
        '
        Me.uuidFactura.HeaderText = "UUID"
        Me.uuidFactura.Name = "uuidFactura"
        Me.uuidFactura.ReadOnly = True
        Me.uuidFactura.Width = 215
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'area
        '
        Me.area.HeaderText = "Área"
        Me.area.Name = "area"
        Me.area.ReadOnly = True
        '
        'familia
        '
        Me.familia.HeaderText = "Familia"
        Me.familia.Name = "familia"
        Me.familia.ReadOnly = True
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 70
        '
        'neto
        '
        Me.neto.HeaderText = "Neto"
        Me.neto.Name = "neto"
        Me.neto.ReadOnly = True
        Me.neto.Width = 80
        '
        'cuentaIva
        '
        Me.cuentaIva.HeaderText = "Cuenta IVA"
        Me.cuentaIva.Name = "cuentaIva"
        Me.cuentaIva.ReadOnly = True
        Me.cuentaIva.Width = 70
        '
        'ivaT
        '
        Me.ivaT.HeaderText = "IVA"
        Me.ivaT.Name = "ivaT"
        Me.ivaT.ReadOnly = True
        Me.ivaT.Width = 80
        '
        'cuentaP
        '
        Me.cuentaP.HeaderText = "Cuenta P"
        Me.cuentaP.Name = "cuentaP"
        Me.cuentaP.ReadOnly = True
        Me.cuentaP.Width = 70
        '
        'impuesto
        '
        Me.impuesto.HeaderText = "Impuesto"
        Me.impuesto.Name = "impuesto"
        Me.impuesto.ReadOnly = True
        Me.impuesto.Width = 80
        '
        'provision
        '
        Me.provision.HeaderText = "Provisión"
        Me.provision.Name = "provision"
        Me.provision.ReadOnly = True
        Me.provision.Width = 60
        '
        'compra
        '
        Me.compra.HeaderText = "Compra"
        Me.compra.Name = "compra"
        Me.compra.ReadOnly = True
        Me.compra.Width = 50
        '
        'oc
        '
        Me.oc.HeaderText = "OC"
        Me.oc.Name = "oc"
        Me.oc.ReadOnly = True
        Me.oc.Width = 40
        '
        'serie
        '
        Me.serie.HeaderText = "Serie"
        Me.serie.Name = "serie"
        Me.serie.ReadOnly = True
        Me.serie.Width = 40
        '
        'factura
        '
        Me.factura.HeaderText = "Factutra"
        Me.factura.Name = "factura"
        Me.factura.ReadOnly = True
        Me.factura.Width = 50
        '
        'proveedor
        '
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        Me.proveedor.ReadOnly = True
        Me.proveedor.Width = 170
        '
        'montoOc
        '
        Me.montoOc.HeaderText = "Monto OC"
        Me.montoOc.Name = "montoOc"
        Me.montoOc.ReadOnly = True
        Me.montoOc.Width = 80
        '
        'montoFact
        '
        Me.montoFact.HeaderText = "Monto Factura"
        Me.montoFact.Name = "montoFact"
        Me.montoFact.ReadOnly = True
        Me.montoFact.Width = 80
        '
        'montoPagar
        '
        Me.montoPagar.HeaderText = "Monto a Pagar"
        Me.montoPagar.Name = "montoPagar"
        Me.montoPagar.ReadOnly = True
        Me.montoPagar.Width = 80
        '
        'montoCompra
        '
        Me.montoCompra.HeaderText = "Monto Compra"
        Me.montoCompra.Name = "montoCompra"
        Me.montoCompra.ReadOnly = True
        Me.montoCompra.Width = 80
        '
        'fechaFactura
        '
        Me.fechaFactura.HeaderText = "Fecha Factura"
        Me.fechaFactura.Name = "fechaFactura"
        Me.fechaFactura.ReadOnly = True
        Me.fechaFactura.Width = 70
        '
        'fechaPagoFactura
        '
        Me.fechaPagoFactura.HeaderText = "Fecha Pago Factura"
        Me.fechaPagoFactura.Name = "fechaPagoFactura"
        Me.fechaPagoFactura.ReadOnly = True
        Me.fechaPagoFactura.Width = 70
        '
        'fechaPagoReal
        '
        Me.fechaPagoReal.HeaderText = "Fecha Pago Real"
        Me.fechaPagoReal.Name = "fechaPagoReal"
        Me.fechaPagoReal.ReadOnly = True
        Me.fechaPagoReal.Width = 70
        '
        'moneda
        '
        Me.moneda.HeaderText = "Moneda"
        Me.moneda.Name = "moneda"
        Me.moneda.ReadOnly = True
        Me.moneda.Width = 55
        '
        'empresa
        '
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        Me.empresa.Width = 55
        '
        'fechaCompra
        '
        Me.fechaCompra.HeaderText = "Fecha Compra"
        Me.fechaCompra.Name = "fechaCompra"
        Me.fechaCompra.ReadOnly = True
        Me.fechaCompra.Width = 70
        '
        'uuid
        '
        Me.uuid.HeaderText = "Id Factura"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        Me.uuid.Width = 215
        '
        'tazaCambio
        '
        Me.tazaCambio.HeaderText = "TC"
        Me.tazaCambio.Name = "tazaCambio"
        Me.tazaCambio.ReadOnly = True
        Me.tazaCambio.Width = 60
        '
        'seleccion
        '
        Me.seleccion.HeaderText = "seleccion"
        Me.seleccion.Name = "seleccion"
        Me.seleccion.ReadOnly = True
        Me.seleccion.Visible = False
        '
        'Frm_PolizasDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 614)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_PolizasDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polizas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.Dgv_Prepolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Dgv_Prepolizas As DataGridView
    Friend WithEvents Dgv_Compras As DataGridView
    Friend WithEvents Dtp_Inicio As DateTimePicker
    Friend WithEvents Dtp_Fin As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pivot As DataGridViewTextBoxColumn
    Friend WithEvents ordenCompra As DataGridViewTextBoxColumn
    Friend WithEvents idCompra As DataGridViewTextBoxColumn
    Friend WithEvents serieF As DataGridViewTextBoxColumn
    Friend WithEvents idFactura As DataGridViewTextBoxColumn
    Friend WithEvents nombreProveedor As DataGridViewTextBoxColumn
    Friend WithEvents rfcProveedor As DataGridViewTextBoxColumn
    Friend WithEvents totalFactura As DataGridViewTextBoxColumn
    Friend WithEvents compraTotal As DataGridViewTextBoxColumn
    Friend WithEvents fechaFact As DataGridViewTextBoxColumn
    Friend WithEvents monedaVP As DataGridViewTextBoxColumn
    Friend WithEvents empresaVP As DataGridViewTextBoxColumn
    Friend WithEvents rfcEmisor As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmisor As DataGridViewTextBoxColumn
    Friend WithEvents uuidFactura As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents area As DataGridViewTextBoxColumn
    Friend WithEvents familia As DataGridViewTextBoxColumn
    Friend WithEvents cuenta As DataGridViewTextBoxColumn
    Friend WithEvents neto As DataGridViewTextBoxColumn
    Friend WithEvents cuentaIva As DataGridViewTextBoxColumn
    Friend WithEvents ivaT As DataGridViewTextBoxColumn
    Friend WithEvents cuentaP As DataGridViewTextBoxColumn
    Friend WithEvents impuesto As DataGridViewTextBoxColumn
    Friend WithEvents provision As DataGridViewTextBoxColumn
    Friend WithEvents compra As DataGridViewTextBoxColumn
    Friend WithEvents oc As DataGridViewTextBoxColumn
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents factura As DataGridViewTextBoxColumn
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents montoOc As DataGridViewTextBoxColumn
    Friend WithEvents montoFact As DataGridViewTextBoxColumn
    Friend WithEvents montoPagar As DataGridViewTextBoxColumn
    Friend WithEvents montoCompra As DataGridViewTextBoxColumn
    Friend WithEvents fechaFactura As DataGridViewTextBoxColumn
    Friend WithEvents fechaPagoFactura As DataGridViewTextBoxColumn
    Friend WithEvents fechaPagoReal As DataGridViewTextBoxColumn
    Friend WithEvents moneda As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents fechaCompra As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents tazaCambio As DataGridViewTextBoxColumn
    Friend WithEvents seleccion As DataGridViewTextBoxColumn
End Class
