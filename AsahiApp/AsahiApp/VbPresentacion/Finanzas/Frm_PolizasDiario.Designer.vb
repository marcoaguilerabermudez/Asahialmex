﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Dgv_Egresos = New System.Windows.Forms.DataGridView()
        Me.pivote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ejercicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ejercicioPag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodoPag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuidE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.conceptoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaClabe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codBanco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuentaS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folioProyeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folioProvisionProy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Dgv_Prepolizas = New System.Windows.Forms.DataGridView()
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
        Me.fechaPagoFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monedaVP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folioPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folioProvisionPol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Dgv_Compras = New System.Windows.Forms.DataGridView()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Dtp_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Fin = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Enviar = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Cmb_BancoMoneda = New System.Windows.Forms.ComboBox()
        Me.Btn_LimpiarFiltros = New System.Windows.Forms.Button()
        Me.Lbl_BancoMoneda = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Filtros = New System.Windows.Forms.Label()
        Me.Txt_FiltroFactura = New System.Windows.Forms.TextBox()
        Me.Txt_FiltroOC = New System.Windows.Forms.TextBox()
        Me.Txt_FiltroProveedor = New System.Windows.Forms.TextBox()
        Me.Txt_FiltroCompras = New System.Windows.Forms.TextBox()
        Me.Btn_Txt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectItm = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.provision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoOc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.montoPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPagoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaPagoReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tazaCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccionPol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccionPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.Dgv_Egresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.Dgv_Prepolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1260, 16)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1260, 680)
        Me.Panel3.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Dgv_Egresos)
        Me.Panel7.Controls.Add(Me.Panel13)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 306)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1260, 364)
        Me.Panel7.TabIndex = 3
        '
        'Dgv_Egresos
        '
        Me.Dgv_Egresos.AllowUserToAddRows = False
        Me.Dgv_Egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Egresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pivote, Me.fechaFac, Me.ejercicio, Me.periodo, Me.fechaPag, Me.ejercicioPag, Me.periodoPag, Me.idProv, Me.prov, Me.moneda2, Me.tipCambio, Me.total2, Me.oCompra, Me.uuidE, Me.conceptoCuenta, Me.cuentaClabe, Me.codBanco, Me.banco, Me.sc, Me.cuentaS, Me.folioProyeccion, Me.folioProvisionProy})
        Me.Dgv_Egresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Egresos.Location = New System.Drawing.Point(10, 174)
        Me.Dgv_Egresos.Name = "Dgv_Egresos"
        Me.Dgv_Egresos.RowHeadersVisible = False
        Me.Dgv_Egresos.Size = New System.Drawing.Size(1240, 190)
        Me.Dgv_Egresos.TabIndex = 6
        Me.Dgv_Egresos.Visible = False
        '
        'pivote
        '
        Me.pivote.HeaderText = "Pivote"
        Me.pivote.Name = "pivote"
        Me.pivote.ReadOnly = True
        Me.pivote.Width = 55
        '
        'fechaFac
        '
        Me.fechaFac.HeaderText = "Fecha"
        Me.fechaFac.Name = "fechaFac"
        Me.fechaFac.ReadOnly = True
        Me.fechaFac.Width = 65
        '
        'ejercicio
        '
        Me.ejercicio.HeaderText = "Ejercicio"
        Me.ejercicio.Name = "ejercicio"
        Me.ejercicio.ReadOnly = True
        Me.ejercicio.Width = 50
        '
        'periodo
        '
        Me.periodo.HeaderText = "Periodo"
        Me.periodo.Name = "periodo"
        Me.periodo.ReadOnly = True
        Me.periodo.Width = 50
        '
        'fechaPag
        '
        Me.fechaPag.HeaderText = "Fecha Pago"
        Me.fechaPag.Name = "fechaPag"
        Me.fechaPag.ReadOnly = True
        Me.fechaPag.Width = 65
        '
        'ejercicioPag
        '
        Me.ejercicioPag.HeaderText = "Ejercicio Pago"
        Me.ejercicioPag.Name = "ejercicioPag"
        Me.ejercicioPag.ReadOnly = True
        Me.ejercicioPag.Width = 50
        '
        'periodoPag
        '
        Me.periodoPag.HeaderText = "Periodo Pago"
        Me.periodoPag.Name = "periodoPag"
        Me.periodoPag.ReadOnly = True
        Me.periodoPag.Width = 50
        '
        'idProv
        '
        Me.idProv.HeaderText = "Cod Proveedor"
        Me.idProv.Name = "idProv"
        Me.idProv.ReadOnly = True
        Me.idProv.Width = 60
        '
        'prov
        '
        Me.prov.HeaderText = "Proveedor"
        Me.prov.Name = "prov"
        Me.prov.ReadOnly = True
        Me.prov.Width = 170
        '
        'moneda2
        '
        Me.moneda2.HeaderText = "Moneda"
        Me.moneda2.Name = "moneda2"
        Me.moneda2.ReadOnly = True
        Me.moneda2.Width = 75
        '
        'tipCambio
        '
        Me.tipCambio.HeaderText = "TC"
        Me.tipCambio.Name = "tipCambio"
        Me.tipCambio.ReadOnly = True
        Me.tipCambio.Width = 75
        '
        'total2
        '
        Me.total2.HeaderText = "Total"
        Me.total2.Name = "total2"
        Me.total2.ReadOnly = True
        Me.total2.Width = 75
        '
        'oCompra
        '
        Me.oCompra.HeaderText = "OC"
        Me.oCompra.Name = "oCompra"
        Me.oCompra.ReadOnly = True
        Me.oCompra.Width = 75
        '
        'uuidE
        '
        Me.uuidE.HeaderText = "UUID"
        Me.uuidE.Name = "uuidE"
        Me.uuidE.ReadOnly = True
        '
        'conceptoCuenta
        '
        Me.conceptoCuenta.HeaderText = "Concepto"
        Me.conceptoCuenta.Name = "conceptoCuenta"
        Me.conceptoCuenta.ReadOnly = True
        Me.conceptoCuenta.Width = 170
        '
        'cuentaClabe
        '
        Me.cuentaClabe.HeaderText = "CLABE"
        Me.cuentaClabe.Name = "cuentaClabe"
        Me.cuentaClabe.ReadOnly = True
        '
        'codBanco
        '
        Me.codBanco.HeaderText = "Código Banco"
        Me.codBanco.Name = "codBanco"
        Me.codBanco.ReadOnly = True
        '
        'banco
        '
        Me.banco.HeaderText = "Banco"
        Me.banco.Name = "banco"
        Me.banco.ReadOnly = True
        '
        'sc
        '
        Me.sc.HeaderText = "SC"
        Me.sc.Name = "sc"
        Me.sc.ReadOnly = True
        Me.sc.Width = 70
        '
        'cuentaS
        '
        Me.cuentaS.HeaderText = "Cuenta"
        Me.cuentaS.Name = "cuentaS"
        Me.cuentaS.ReadOnly = True
        Me.cuentaS.Width = 70
        '
        'folioProyeccion
        '
        Me.folioProyeccion.HeaderText = "FolioProyeccion"
        Me.folioProyeccion.Name = "folioProyeccion"
        Me.folioProyeccion.ReadOnly = True
        Me.folioProyeccion.Visible = False
        '
        'folioProvisionProy
        '
        Me.folioProvisionProy.HeaderText = "FolioProvisionProy"
        Me.folioProvisionProy.Name = "folioProvisionProy"
        Me.folioProvisionProy.ReadOnly = True
        Me.folioProvisionProy.Visible = False
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Dgv_Prepolizas)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(10, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1240, 174)
        Me.Panel13.TabIndex = 4
        '
        'Dgv_Prepolizas
        '
        Me.Dgv_Prepolizas.AllowUserToAddRows = False
        Me.Dgv_Prepolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Prepolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pivot, Me.ordenCompra, Me.idCompra, Me.serieF, Me.idFactura, Me.nombreProveedor, Me.rfcProveedor, Me.totalFactura, Me.compraTotal, Me.fechaFact, Me.fechaPagoFact, Me.monedaVP, Me.tc, Me.empresaVP, Me.rfcEmisor, Me.nombreEmisor, Me.uuidFactura, Me.total, Me.area, Me.familia, Me.cuenta, Me.neto, Me.cuentaIva, Me.ivaT, Me.cuentaP, Me.impuesto, Me.concepto, Me.folioPoliza, Me.folioProvisionPol})
        Me.Dgv_Prepolizas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Prepolizas.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_Prepolizas.Name = "Dgv_Prepolizas"
        Me.Dgv_Prepolizas.RowHeadersVisible = False
        Me.Dgv_Prepolizas.Size = New System.Drawing.Size(1240, 174)
        Me.Dgv_Prepolizas.TabIndex = 6
        Me.Dgv_Prepolizas.Visible = False
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
        'fechaPagoFact
        '
        Me.fechaPagoFact.HeaderText = "Fecha Pago"
        Me.fechaPagoFact.Name = "fechaPagoFact"
        Me.fechaPagoFact.ReadOnly = True
        '
        'monedaVP
        '
        Me.monedaVP.HeaderText = "Moneda"
        Me.monedaVP.Name = "monedaVP"
        Me.monedaVP.ReadOnly = True
        Me.monedaVP.Width = 55
        '
        'tc
        '
        Me.tc.HeaderText = "Tipo Cambio"
        Me.tc.Name = "tc"
        Me.tc.ReadOnly = True
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
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.ReadOnly = True
        '
        'folioPoliza
        '
        Me.folioPoliza.HeaderText = "FolioPoliza"
        Me.folioPoliza.Name = "folioPoliza"
        Me.folioPoliza.ReadOnly = True
        Me.folioPoliza.Visible = False
        '
        'folioProvisionPol
        '
        Me.folioProvisionPol.HeaderText = "FolioProvisionPol"
        Me.folioProvisionPol.Name = "folioProvisionPol"
        Me.folioProvisionPol.ReadOnly = True
        Me.folioProvisionPol.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(10, 364)
        Me.Panel8.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(1250, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(10, 364)
        Me.Panel9.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 670)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1260, 10)
        Me.Panel6.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 280)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1260, 26)
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
        Me.Panel4.Size = New System.Drawing.Size(1260, 280)
        Me.Panel4.TabIndex = 0
        '
        'Dgv_Compras
        '
        Me.Dgv_Compras.AllowUserToAddRows = False
        Me.Dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selectItm, Me.provision, Me.compra, Me.oc, Me.serie, Me.factura, Me.proveedor, Me.montoOc, Me.montoCompra, Me.montoFact, Me.montoPagar, Me.fechaFactura, Me.fechaPagoFactura, Me.fechaPagoReal, Me.moneda, Me.empresa, Me.fechaCompra, Me.uuid, Me.tazaCambio, Me.seleccionPol, Me.seleccionPro})
        Me.Dgv_Compras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Compras.Location = New System.Drawing.Point(10, 0)
        Me.Dgv_Compras.Name = "Dgv_Compras"
        Me.Dgv_Compras.RowHeadersVisible = False
        Me.Dgv_Compras.Size = New System.Drawing.Size(1240, 280)
        Me.Dgv_Compras.TabIndex = 5
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(10, 280)
        Me.Panel11.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1250, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 280)
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
        Me.Panel1.Controls.Add(Me.Btn_Enviar)
        Me.Panel1.Controls.Add(Me.Btn_Limpiar)
        Me.Panel1.Controls.Add(Me.Btn_Actualizar)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Btn_Txt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Dtp_Fin)
        Me.Panel1.Controls.Add(Me.Dtp_Inicio)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 51)
        Me.Panel1.TabIndex = 0
        '
        'Btn_Enviar
        '
        Me.Btn_Enviar.AllowDrop = True
        Me.Btn_Enviar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_Enviar.FlatAppearance.BorderSize = 0
        Me.Btn_Enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Enviar.Image = Global.Presentacion.My.Resources.Resources.enviar
        Me.Btn_Enviar.Location = New System.Drawing.Point(512, 1)
        Me.Btn_Enviar.Name = "Btn_Enviar"
        Me.Btn_Enviar.Size = New System.Drawing.Size(49, 38)
        Me.Btn_Enviar.TabIndex = 20
        Me.Btn_Enviar.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.AllowDrop = True
        Me.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_Limpiar.FlatAppearance.BorderSize = 0
        Me.Btn_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Limpiar.Image = Global.Presentacion.My.Resources.Resources.pagina_blanca_de_origami
        Me.Btn_Limpiar.Location = New System.Drawing.Point(471, 0)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(39, 40)
        Me.Btn_Limpiar.TabIndex = 19
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.AllowDrop = True
        Me.Btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_Actualizar.FlatAppearance.BorderSize = 0
        Me.Btn_Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Actualizar.Image = Global.Presentacion.My.Resources.Resources.actualizar
        Me.Btn_Actualizar.Location = New System.Drawing.Point(430, 0)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(39, 40)
        Me.Btn_Actualizar.TabIndex = 18
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Cmb_BancoMoneda)
        Me.Panel12.Controls.Add(Me.Btn_LimpiarFiltros)
        Me.Panel12.Controls.Add(Me.Lbl_BancoMoneda)
        Me.Panel12.Controls.Add(Me.Label6)
        Me.Panel12.Controls.Add(Me.Label5)
        Me.Panel12.Controls.Add(Me.Label4)
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Controls.Add(Me.Lbl_Filtros)
        Me.Panel12.Controls.Add(Me.Txt_FiltroFactura)
        Me.Panel12.Controls.Add(Me.Txt_FiltroOC)
        Me.Panel12.Controls.Add(Me.Txt_FiltroProveedor)
        Me.Panel12.Controls.Add(Me.Txt_FiltroCompras)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(596, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(664, 51)
        Me.Panel12.TabIndex = 5
        '
        'Cmb_BancoMoneda
        '
        Me.Cmb_BancoMoneda.BackColor = System.Drawing.Color.White
        Me.Cmb_BancoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_BancoMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmb_BancoMoneda.FormattingEnabled = True
        Me.Cmb_BancoMoneda.Location = New System.Drawing.Point(420, 21)
        Me.Cmb_BancoMoneda.Name = "Cmb_BancoMoneda"
        Me.Cmb_BancoMoneda.Size = New System.Drawing.Size(176, 21)
        Me.Cmb_BancoMoneda.TabIndex = 18
        Me.Cmb_BancoMoneda.Visible = False
        '
        'Btn_LimpiarFiltros
        '
        Me.Btn_LimpiarFiltros.AllowDrop = True
        Me.Btn_LimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_LimpiarFiltros.FlatAppearance.BorderSize = 0
        Me.Btn_LimpiarFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_LimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_LimpiarFiltros.Image = Global.Presentacion.My.Resources.Resources.pagina_blanca_de_origami
        Me.Btn_LimpiarFiltros.Location = New System.Drawing.Point(613, 6)
        Me.Btn_LimpiarFiltros.Name = "Btn_LimpiarFiltros"
        Me.Btn_LimpiarFiltros.Size = New System.Drawing.Size(39, 40)
        Me.Btn_LimpiarFiltros.TabIndex = 17
        Me.Btn_LimpiarFiltros.UseVisualStyleBackColor = True
        '
        'Lbl_BancoMoneda
        '
        Me.Lbl_BancoMoneda.AutoSize = True
        Me.Lbl_BancoMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BancoMoneda.ForeColor = System.Drawing.Color.White
        Me.Lbl_BancoMoneda.Location = New System.Drawing.Point(421, 4)
        Me.Lbl_BancoMoneda.Name = "Lbl_BancoMoneda"
        Me.Lbl_BancoMoneda.Size = New System.Drawing.Size(92, 13)
        Me.Lbl_BancoMoneda.TabIndex = 16
        Me.Lbl_BancoMoneda.Text = "Banco Moneda"
        Me.Lbl_BancoMoneda.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(241, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Proveedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(186, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Factura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(138, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "OC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Compra"
        '
        'Lbl_Filtros
        '
        Me.Lbl_Filtros.AutoSize = True
        Me.Lbl_Filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Filtros.ForeColor = System.Drawing.Color.White
        Me.Lbl_Filtros.Location = New System.Drawing.Point(4, 4)
        Me.Lbl_Filtros.Name = "Lbl_Filtros"
        Me.Lbl_Filtros.Size = New System.Drawing.Size(74, 15)
        Me.Lbl_Filtros.TabIndex = 10
        Me.Lbl_Filtros.Text = "Filtrar por:"
        '
        'Txt_FiltroFactura
        '
        Me.Txt_FiltroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_FiltroFactura.Location = New System.Drawing.Point(189, 22)
        Me.Txt_FiltroFactura.Name = "Txt_FiltroFactura"
        Me.Txt_FiltroFactura.Size = New System.Drawing.Size(47, 20)
        Me.Txt_FiltroFactura.TabIndex = 9
        '
        'Txt_FiltroOC
        '
        Me.Txt_FiltroOC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_FiltroOC.Location = New System.Drawing.Point(136, 22)
        Me.Txt_FiltroOC.Name = "Txt_FiltroOC"
        Me.Txt_FiltroOC.Size = New System.Drawing.Size(47, 20)
        Me.Txt_FiltroOC.TabIndex = 8
        '
        'Txt_FiltroProveedor
        '
        Me.Txt_FiltroProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_FiltroProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_FiltroProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_FiltroProveedor.Location = New System.Drawing.Point(242, 22)
        Me.Txt_FiltroProveedor.Name = "Txt_FiltroProveedor"
        Me.Txt_FiltroProveedor.Size = New System.Drawing.Size(172, 20)
        Me.Txt_FiltroProveedor.TabIndex = 7
        '
        'Txt_FiltroCompras
        '
        Me.Txt_FiltroCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_FiltroCompras.Location = New System.Drawing.Point(83, 22)
        Me.Txt_FiltroCompras.Name = "Txt_FiltroCompras"
        Me.Txt_FiltroCompras.Size = New System.Drawing.Size(47, 20)
        Me.Txt_FiltroCompras.TabIndex = 6
        '
        'Btn_Txt
        '
        Me.Btn_Txt.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_Txt.FlatAppearance.BorderSize = 0
        Me.Btn_Txt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Txt.Image = Global.Presentacion.My.Resources.Resources.txt
        Me.Btn_Txt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Txt.Location = New System.Drawing.Point(384, 0)
        Me.Btn_Txt.Name = "Btn_Txt"
        Me.Btn_Txt.Size = New System.Drawing.Size(39, 40)
        Me.Btn_Txt.TabIndex = 4
        Me.Btn_Txt.UseVisualStyleBackColor = True
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
        'selectItm
        '
        Me.selectItm.HeaderText = ""
        Me.selectItm.Name = "selectItm"
        Me.selectItm.ReadOnly = True
        Me.selectItm.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.selectItm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.selectItm.Width = 30
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
        'montoCompra
        '
        Me.montoCompra.HeaderText = "Monto Compra"
        Me.montoCompra.Name = "montoCompra"
        Me.montoCompra.ReadOnly = True
        Me.montoCompra.Width = 80
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
        'seleccionPol
        '
        Me.seleccionPol.HeaderText = "seleccionPol"
        Me.seleccionPol.Name = "seleccionPol"
        Me.seleccionPol.ReadOnly = True
        Me.seleccionPol.Visible = False
        '
        'seleccionPro
        '
        Me.seleccionPro.HeaderText = "seleccionPro"
        Me.seleccionPro.Name = "seleccionPro"
        Me.seleccionPro.ReadOnly = True
        Me.seleccionPro.Visible = False
        '
        'Frm_PolizasDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 747)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_PolizasDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polizas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.Dgv_Egresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        CType(Me.Dgv_Prepolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
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
    Friend WithEvents Btn_Txt As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_Filtros As Label
    Friend WithEvents Txt_FiltroFactura As TextBox
    Friend WithEvents Txt_FiltroOC As TextBox
    Friend WithEvents Txt_FiltroCompras As TextBox
    Friend WithEvents Lbl_BancoMoneda As Label
    Friend WithEvents Txt_FiltroProveedor As TextBox
    Friend WithEvents Btn_LimpiarFiltros As Button
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Cmb_BancoMoneda As ComboBox
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
    Friend WithEvents fechaPagoFact As DataGridViewTextBoxColumn
    Friend WithEvents monedaVP As DataGridViewTextBoxColumn
    Friend WithEvents tc As DataGridViewTextBoxColumn
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
    Friend WithEvents concepto As DataGridViewTextBoxColumn
    Friend WithEvents folioPoliza As DataGridViewTextBoxColumn
    Friend WithEvents folioProvisionPol As DataGridViewTextBoxColumn
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Dgv_Egresos As DataGridView
    Friend WithEvents pivote As DataGridViewTextBoxColumn
    Friend WithEvents fechaFac As DataGridViewTextBoxColumn
    Friend WithEvents ejercicio As DataGridViewTextBoxColumn
    Friend WithEvents periodo As DataGridViewTextBoxColumn
    Friend WithEvents fechaPag As DataGridViewTextBoxColumn
    Friend WithEvents ejercicioPag As DataGridViewTextBoxColumn
    Friend WithEvents periodoPag As DataGridViewTextBoxColumn
    Friend WithEvents idProv As DataGridViewTextBoxColumn
    Friend WithEvents prov As DataGridViewTextBoxColumn
    Friend WithEvents moneda2 As DataGridViewTextBoxColumn
    Friend WithEvents tipCambio As DataGridViewTextBoxColumn
    Friend WithEvents total2 As DataGridViewTextBoxColumn
    Friend WithEvents oCompra As DataGridViewTextBoxColumn
    Friend WithEvents uuidE As DataGridViewTextBoxColumn
    Friend WithEvents conceptoCuenta As DataGridViewTextBoxColumn
    Friend WithEvents cuentaClabe As DataGridViewTextBoxColumn
    Friend WithEvents codBanco As DataGridViewTextBoxColumn
    Friend WithEvents banco As DataGridViewTextBoxColumn
    Friend WithEvents sc As DataGridViewTextBoxColumn
    Friend WithEvents cuentaS As DataGridViewTextBoxColumn
    Friend WithEvents folioProyeccion As DataGridViewTextBoxColumn
    Friend WithEvents folioProvisionProy As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Enviar As Button
    Friend WithEvents selectItm As DataGridViewCheckBoxColumn
    Friend WithEvents provision As DataGridViewTextBoxColumn
    Friend WithEvents compra As DataGridViewTextBoxColumn
    Friend WithEvents oc As DataGridViewTextBoxColumn
    Friend WithEvents serie As DataGridViewTextBoxColumn
    Friend WithEvents factura As DataGridViewTextBoxColumn
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents montoOc As DataGridViewTextBoxColumn
    Friend WithEvents montoCompra As DataGridViewTextBoxColumn
    Friend WithEvents montoFact As DataGridViewTextBoxColumn
    Friend WithEvents montoPagar As DataGridViewTextBoxColumn
    Friend WithEvents fechaFactura As DataGridViewTextBoxColumn
    Friend WithEvents fechaPagoFactura As DataGridViewTextBoxColumn
    Friend WithEvents fechaPagoReal As DataGridViewTextBoxColumn
    Friend WithEvents moneda As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents fechaCompra As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents tazaCambio As DataGridViewTextBoxColumn
    Friend WithEvents seleccionPol As DataGridViewTextBoxColumn
    Friend WithEvents seleccionPro As DataGridViewTextBoxColumn
End Class
