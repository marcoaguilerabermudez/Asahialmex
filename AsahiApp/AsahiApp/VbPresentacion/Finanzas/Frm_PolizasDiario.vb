Imports Clases
Imports Negocio
Imports System.IO
Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms

Public Class Frm_PolizasDiario
#Region "Varianbles de clase"
    Dim origen As Integer '1:Diario, 2:Egresos
    Dim conex As New conexion()
    Dim cadenaConex As String
    Dim cadConex As String
    Dim cadConexCont As String
    Dim userName As String
    Dim ruta As String
    Dim archivo As String
    Dim fechaPago As Date
    Dim tCamb As Double
    Dim pasoPol As String
    Dim pasoEgre As String
    Dim ip As String = Strings.Left(Me.conex.getIp(), 6)
    Dim emp As New Empleado()
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal emp As Empleado, ByVal origen As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.emp = emp
        Me.origen = origen
    End Sub
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_PolizasDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim conex As New conexion()
        If Me.ip = "172.16" Then
            Me.cadenaConex = Me.conex.cadenaConexExpress
            Me.cadConex = Me.conex.conexion2008
            Me.cadConexCont = Me.conex.conexionCont
        Else
            Me.cadenaConex = Me.conex.cadenaConexExpressFor
            Me.cadConex = Me.conex.conexion2008For
            Me.cadConexCont = Me.conex.conexionContFor
        End If
        If origen = 1 Then
            Dgv_Prepolizas.Visible = True
        ElseIf origen = 2 Then
            Dgv_Egresos.Visible = True
        End If
        Dtp_Inicio.Value = DateAdd(DateInterval.Day, -7, Date.Now())
        Dgv_Compras.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        Dgv_Prepolizas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        'Dgv_Compras.colu
        'Dgv_Prepolizas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        RecuperarCompras()
        RecuperarProveedores()
    End Sub
    Private Sub Dgv_Compras_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_Compras.DoubleClick
        Dim uuid As String, moneda As String, tc As Double, oc As Integer
        Dim fila As Integer
        fila = Dgv_Compras.CurrentRow.Index
        If Dgv_Compras.Rows(fila).DefaultCellStyle.BackColor <> Color.DarkRed Then
            If Me.origen = 1 Then
                If Dgv_Compras.Rows(fila).Cells("seleccion").Value = 0 Then

                    Me.pasoPol = ""
                    uuid = Dgv_Compras.Rows(fila).Cells("uuid").Value
                    moneda = Dgv_Compras.Rows(fila).Cells("moneda").Value
                    tc = Dgv_Compras.Rows(fila).Cells("tazaCambio").Value
                    Me.tCamb = Dgv_Compras.Rows(fila).Cells("tazaCambio").Value
                    oc = Dgv_Compras.Rows(fila).Cells("oc").Value
                    Me.fechaPago = Dgv_Compras.Rows(fila).Cells("fechaPagoFactura").Value
                    RecuperarPolizas(moneda, uuid, tc, oc)
                    If Me.pasoPol = "Ok" Then Dgv_Compras.Rows(fila).Cells("seleccion").Value = 1
                Else
                    MsgBox("ESTA PROVICION YA ESTA PREPARADA PARA CONVERSIÓN A TXT", MsgBoxStyle.Exclamation, "")
                End If
            ElseIf Me.origen = 2 Then
                If Dgv_Compras.Rows(fila).Cells("seleccion").Value = 0 Then
                    Me.pasoPol = ""
                    uuid = Dgv_Compras.Rows(fila).Cells("uuid").Value
                    moneda = Dgv_Compras.Rows(fila).Cells("moneda").Value
                    oc = Dgv_Compras.Rows(fila).Cells("oc").Value
                    RecuperarEgreso(moneda, uuid, oc)
                    If Me.pasoPol = "Ok" Then Dgv_Compras.Rows(fila).Cells("seleccion").Value = 1
                Else
                    MsgBox("ESTE EGRESO YA ESTA PREPARADO PARA CONVERSIÓN A TXT", MsgBoxStyle.Exclamation, "")
                End If
            End If
        Else
            MsgBox("NO COINCIDEN MONTOS DE COMPRA Y DE FACTURA", MsgBoxStyle.Critical, "")
        End If
    End Sub
    Private Sub Dtp_Inicio_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Inicio.ValueChanged
        'If Me.origen = 1 Then
        RecuperarCompras()
        RecuperarProveedores()
        Dgv_Prepolizas.DataSource = Nothing
        Dgv_Prepolizas.Rows.Clear()
        'Else
        'End If
    End Sub
    Private Sub Dtp_Fin_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fin.ValueChanged
        'If Me.origen = 1 Then
        RecuperarCompras()
        RecuperarProveedores()
        Dgv_Prepolizas.DataSource = Nothing
        Dgv_Prepolizas.Rows.Clear()
        'Else
        'End If
    End Sub
    Private Sub Btn_Txt_Click(sender As Object, e As EventArgs) Handles Btn_Txt.Click
        CrearTxt()
        EscribirArchivo()
    End Sub
    Private Sub Txt_FiltroCompras_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroCompras.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count, folio As Integer
        If IsNumeric(Txt_FiltroCompras.Text) Then
            If Txt_FiltroCompras.Text <> "" Then
                Txt_FiltroOC.Text = ""
                Txt_FiltroFactura.Text = ""
                Txt_FiltroProveedor.Text = ""
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        folio = .Cells("compra").Value
                        If Not (folio Like Txt_FiltroCompras.Text) And folio <> 0 Then
                            .Visible = True
                        End If
                        If Not (folio Like Txt_FiltroCompras.Text) And folio <> 0 Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        Else
            Txt_FiltroCompras.Text = ""

            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Txt_FiltroOC_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroOC.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count, folio As Integer
        If IsNumeric(Txt_FiltroOC.Text) Then
            If Txt_FiltroOC.Text <> "" Then
                Txt_FiltroCompras.Text = ""
                Txt_FiltroFactura.Text = ""
                Txt_FiltroProveedor.Text = ""
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        folio = .Cells("oc").Value
                        If Not (folio Like Txt_FiltroOC.Text) And folio <> 0 Then
                            .Visible = True
                        End If
                        If Not (folio Like Txt_FiltroOC.Text) And folio <> 0 Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        Else
            Txt_FiltroOC.Text = ""

            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Txt_FiltroFactura_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroFactura.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count, folio As String
        If Txt_FiltroFactura.Text <> "" Then
            Txt_FiltroOC.Text = ""
            Txt_FiltroCompras.Text = ""
            Txt_FiltroProveedor.Text = ""
            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    .Visible = True
                End With
            Next
            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    folio = .Cells("factura").Value
                    If Not (folio Like Txt_FiltroFactura.Text) And folio <> "" Then
                        .Visible = True
                    End If
                    If Not (folio Like Txt_FiltroFactura.Text) And folio <> "" Then
                        .Visible = False
                    End If
                End With
            Next
        Else
            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Txt_FiltroProveedor_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroProveedor.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count, proveedor As String
        If Len(Txt_FiltroProveedor.Text) > 4 Or Len(Txt_FiltroProveedor.Text) = 0 Then
            Txt_FiltroOC.Text = ""
            Txt_FiltroCompras.Text = ""
            Txt_FiltroFactura.Text = ""
            If Txt_FiltroProveedor.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        proveedor = .Cells("proveedor").Value
                        If Not (proveedor Like Txt_FiltroProveedor.Text) And proveedor <> "" Then
                            .Visible = True
                        End If
                        If Not (proveedor Like Txt_FiltroProveedor.Text) And proveedor <> "" Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Dtp_FiltroFechaFactura_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_FiltroFechaFactura.ValueChanged
    End Sub
    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        LimpiarDgv()
        LimpiarFiltros()
        RecuperarCompras()
        RecuperarProveedores()
    End Sub
    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        LimpiarDgv()
        LimpiarFiltros()
    End Sub
    Private Sub Btn_LimpiarFiltros_Click(sender As Object, e As EventArgs) Handles Btn_LimpiarFiltros.Click
        LimpiarFiltros()
    End Sub
#End Region
#Region "Recuperar"
    Private Sub RecuperarCompras()
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim fi As Date = Dtp_Inicio.Value, ff As Date = Dtp_Fin.Value
        lstComp = NComp.RecuperarLstCompras(Me.cadenaConex, fi, ff)
        RellenarDgvCompras(lstComp)
    End Sub
    Private Sub RecuperarProveedores()
        Dim lstComp As New LCompras()
        Dim NComp As New NCompras()
        Dim prov As New Compras()
        Dim fi As Date = Format(Dtp_Inicio.Value, "dd/MM/yyyy"), ff As Date = Format(Dtp_Fin.Value, "dd/MM/yyyy")

        lstComp = NComp.RecuperarListaProveedores(Me.cadenaConex, fi, ff)
        prov.Proveedor = ""
        lstComp.Add(prov)
        For Each item In lstComp
            Txt_FiltroProveedor.AutoCompleteCustomSource.Add(item.Proveedor)
        Next
    End Sub
    Private Sub RecuperarPolizas(ByVal moneda As String, ByVal uuid As String, ByVal tc As Double, ByVal oc As Integer)
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim cuenta As Integer

        lstComp = NComp.ConsultarImpuestosExtra(Me.cadConexCont, uuid)
        cuenta = lstComp.Count
        lstComp = NComp.VistaPoliza(Me.cadenaConex, moneda, uuid, tc)
        RellenarDgvVistaPolizas(lstComp, oc)
    End Sub
    Private Sub RecuperarEgreso(ByVal moneda As String, ByVal uuid As String, ByVal oc As Integer)
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim cuenta As Integer

        lstComp = NComp.ConsultarImpuestosExtra(Me.cadConexCont, uuid)
        cuenta = lstComp.Count
        lstComp = NComp.RecuperarEgreso(Me.cadenaConex, moneda, uuid)
        RellenaDGVPolizasEgresos(lstComp)
    End Sub
#End Region
#Region "Rellenar Dgv"
    Private Sub RellenarDgvCompras(ByVal lstComp As LCompras)
        Dim fila As Integer = 0
        Dgv_Compras.DataSource = Nothing
        Dgv_Compras.Rows.Clear()

        For Each item In lstComp
            Dgv_Compras.Rows.Add()
            'Dgv_Compras.Columns("acum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_Compras.Rows(fila)
                .Cells("provision").Value = item.IdProvision
                .Cells("compra").Value = item.IdCompra
                .Cells("oc").Value = item.IdOrdenCompra
                .Cells("serie").Value = item.Serie
                .Cells("factura").Value = item.Factura
                .Cells("proveedor").Value = item.Proveedor
                .Cells("montoOc").Value = Format(item.MontoOC, "$ #,###,##0.00")
                .Cells("montoFact").Value = Format(item.MontoFact, "$ #,###,##0.00")
                .Cells("montoPagar").Value = Format(item.MontoPagar, "$ #,###,##0.00")
                .Cells("montoCompra").Value = Format(item.MontoCompra, "$ #,###,##0.00")
                .Cells("fechaFactura").Value = Format(item.FechaFact, "dd/MM/yyyy")
                .Cells("fechaPagoFactura").Value = Format(item.FechaPagoFact, "dd/MM/yyyy")
                .Cells("fechaPagoReal").Value = Format(item.FechaPagoReal, "dd/MM/yyyy")
                .Cells("moneda").Value = item.Moneda
                .Cells("empresa").Value = item.Empresa
                .Cells("fechaCompra").Value = Format(item.FechaCompra, "dd/MM/yyyy")
                .Cells("uuid").Value = item.UUID
                .Cells("tazaCambio").Value = Format(item.TazaCambio, "$ #,###,##0.0000")
                Dim res = .Cells("montoCompra").Value - .Cells("montoFact").Value
                If res >= 0.05 Or res <= -0.05 Then
                    .DefaultCellStyle.BackColor = Color.DarkRed
                    .DefaultCellStyle.ForeColor = Color.White
                End If
            End With
            fila += 1
        Next
    End Sub
    Private Sub RellenarDgvVistaPolizas(ByVal lstComp As LCompras, ByVal oc As Integer)
        Dim fila As Integer = Dgv_Prepolizas.Rows.Count(), pfila As Integer = fila
        Dim sum As Double, sumCargo As Double, sumRet As Double, t As Double
        Dim frm As New Frm_ConceptoPoliza("" & oc & "", lstComp)

        If frm.ShowDialog() = DialogResult.OK Then
            For Each item In lstComp
                Dgv_Prepolizas.Rows.Add()
                'Dgv_Prepolizas.Columns("acum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                If item.Pivote = 1 Or item.Pivote = 2 Then
                    sum = sum + item.Total
                ElseIf item.Pivote = 3 Then
                    sumRet = sumRet + item.Total
                ElseIf item.Pivote = 4 Or item.Pivote = 5 Then
                    sumCargo = sumCargo + item.Total
                End If
                With Dgv_Prepolizas.Rows(fila)
                    .Cells("pivot").Value = item.Pivote
                    .Cells("ordenCompra").Value = item.IdOrdenCompra
                    .Cells("idCompra").Value = item.IdCompra
                    .Cells("serieF").Value = item.Serie
                    .Cells("idFactura").Value = item.Factura
                    .Cells("nombreProveedor").Value = item.Proveedor
                    .Cells("rfcProveedor").Value = item.Rfc
                    .Cells("totalFactura").Value = Format(item.TotalFactura, "$ #,###,##0.00")
                    .Cells("compraTotal").Value = Format(item.CompraTotal, "$ #,###,##0.00")
                    .Cells("fechaFact").Value = Format(item.FechaFact, "dd/MM/yyyy")
                    .Cells("fechaPagoFact").Value = Format(Me.fechaPago, "dd/MM/yyyy")
                    .Cells("monedaVP").Value = item.Moneda
                    .Cells("tc").Value = Format(Me.tCamb, "$ #,###,##0.0000")
                    .Cells("empresaVP").Value = item.Empresa
                    .Cells("rfcEmisor").Value = item.RfcEmisor
                    .Cells("nombreEmisor").Value = item.NombreEmisor
                    .Cells("uuidFactura").Value = item.UUID
                    .Cells("total").Value = Format(item.Total, "$ #,###,##0.00")
                    .Cells("area").Value = item.Area
                    .Cells("familia").Value = item.Familia
                    .Cells("cuenta").Value = item.Cuenta
                    .Cells("neto").Value = Format(item.Neto, "$ #,###,##0.00")
                    .Cells("cuentaIva").Value = item.CuentaIva
                    .Cells("ivaT").Value = Format(item.IvaT, "$ #,###,##0.00")
                    .Cells("cuentaP").Value = item.CuentaP
                    .Cells("impuesto").Value = Format(item.Impuesto, "$ #,###,##0.00")
                    .Cells("concepto").Value = frm.Concepto
                End With
                fila += 1
            Next
            Me.pasoPol = "Ok"
            t = sum - sumCargo
            If Dgv_Prepolizas.Rows(pfila).Cells("total").Value > 0 Then
                Dgv_Prepolizas.Rows(pfila).Cells("total").Value = Format((Dgv_Prepolizas.Rows(pfila).Cells("total").Value - t) + sumRet, "$ #,###,##0.00")
            Else
                pfila += 1
                Dgv_Prepolizas.Rows(pfila).Cells("total").Value = Format((Dgv_Prepolizas.Rows(pfila).Cells("total").Value - t) + sumRet, "$ #,###,##0.00")
            End If
        End If
    End Sub
    Private Sub RellenaDGVPolizasEgresos(ByVal lstComp As LCompras)
        Dim fila As Integer = Dgv_Egresos.Rows.Count(), pfila As Integer = fila
        Dim sNeg As String = ""
        'Dim sum As Double, sumCargo As Double, sumRet As Double, t As Double
        Dim frm As New Frm_ConceptoEgreso(lstComp), NComp As New NCompras()

        If frm.ShowDialog() = DialogResult.OK Then
            For Each item In lstComp
                Dgv_Egresos.Rows.Add()
                If item.Pivote = 2 Then sNeg = NComp.RecuperaCategorias(Me.cadenaConex, lstComp, item.Cuenta, idSegNeg(item.Area))

                With Dgv_Egresos.Rows(fila)
                    .Cells("pivote").Value = item.Pivote
                    .Cells("fechaFac").Value = item.FechaFactura
                    .Cells("ejercicio").Value = item.Ejercicio
                    .Cells("periodo").Value = item.Periodo
                    .Cells("fechaPag").Value = item.FechaPagoFact
                    .Cells("ejercicioPag").Value = item.EjercicioPago
                    .Cells("periodoPag").Value = item.PeriodoPago
                    .Cells("idProv").Value = item.IdProveedor
                    .Cells("prov").Value = item.Proveedor
                    .Cells("moneda2").Value = item.Moneda
                    .Cells("tipCambio").Value = item.TazaCambio
                    .Cells("total2").Value = item.TotalFactura
                    .Cells("oCompra").Value = item.IdOrdenCompra
                    .Cells("conceptoCuenta").Value = frm.Concepto
                    .Cells("cuentaClabe").Value = item.CuentaClabe
                    .Cells("idBanco").Value = frm.IdBanco
                    .Cells("banco").Value = frm.Banco
                    .Cells("codBanco").Value = frm.CodigoBanco
                    .Cells("sc").Value = sNeg
                    .Cells("cuentaS").Value = item.Cuenta
                End With
                fila += 1
            Next
        End If
    End Sub
#End Region
#Region "Otros"
    Private Sub CrearTxt()
        Me.userName = Environment.UserName
        Me.ruta = "C:\Users\" & Me.userName & "\Desktop\Polizas Diario\"
        Me.archivo = "Polizas" & Format(Date.Now(), "yyyyMMddHHmmss") & ".txt"
        Dim fs As FileStream

        'Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If File.Exists(ruta) Then

                'Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "")
            Else

                'Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)

                'Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                'MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            fs.Close()
        End Try
    End Sub
    Private Sub EscribirArchivo()
        Dim tx As New StreamWriter(Me.ruta & Me.archivo)
        Dim fila As Integer, pivot As Integer, idX As Integer = 0, e As Integer
        Dim total As Double, tc As Double
        Dim fecha As Date
        Dim folio As String = "", uuid As String = "", sn As String
        Dim totalFilas As Integer = Dgv_Prepolizas.Rows.Count
        Dim NPol As New NPolizas(), pol As New Polizas()
        Try
            fecha = Dgv_Prepolizas.Rows(0).Cells("fechaFact").Value
            pol = NPol.RecuperarUltimoFolio(Me.cadenaConex, fecha)
            e = pol.FolioPoliza
            For fila = 0 To totalFilas - 1
                Dim cargo As Integer = 0
                pivot = Dgv_Prepolizas.Rows(fila).Cells("pivot").Value
                With Dgv_Prepolizas.Rows(fila)
                    If pivot = 1 And uuid <> Dgv_Prepolizas.Rows(fila).Cells("uuidFactura").Value Then
                        'Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
                        e += 1
                        tx.Write("P  ")
                        tx.Write(CDate(.Cells("fechaFact").Value).ToString("yyyyMMdd") & " ") 'ToString("yyyyMMdd", .Cells("fechaFact").Value))
                        tx.Write("   3 ")
                        tx.Write(String.Format("{0,9}", e) & " ")
                        tx.Write("1 ")
                        tx.Write("0          ")
                        tx.Write(String.Format("{0,-100}", .Cells("concepto").Value))
                        tx.Write("11 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(String.Format("{0,-37}", ""))
                        tx.WriteLine()
                        uuid = Dgv_Prepolizas.Rows(fila).Cells("uuidFactura").Value
                    End If
                    If DatePart("m", .Cells("fechaFact").Value) = DatePart("m", .Cells("fechaPagoFact").Value) And
                            DatePart("yyyy", .Cells("fechaFact").Value) = DatePart("yyyy", .Cells("fechaPagoFact").Value) Then
                        If .Cells("monedaVP").Value = "MXN" Then folio = "F-" & .Cells("idFactura").Value
                        If .Cells("monedaVP").Value = "USD" Then
                            tc = .Cells("tc").Value
                            folio = "F-" & .Cells("idFactura").Value & " TC " & tc
                        End If
                    Else
                        If .Cells("monedaVP").Value = "MXN" Then folio = "F/" & .Cells("idFactura").Value
                        If .Cells("monedaVP").Value = "USD" Then
                            tc = .Cells("tc").Value
                            folio = "F/" & .Cells("idFactura").Value & " TC " & tc
                        End If
                    End If
                    If .Cells("familia").Value = "Cargo" Or .Cells("familia").Value = "ProveedorUSD" Or .Cells("familia").Value = "ComplementariaUSD" Or .Cells("familia").Value = "Retencion de IVA" Or
                        .Cells("familia").Value = "Traslado" Then
                        cargo = 1
                    End If
                    sn = idSegNeg(.Cells("area").Value)
                    total = .Cells("total").Value
                    tx.Write("M1 ")
                    tx.Write(String.Format("{0,-30}", .Cells("cuenta").Value) & " ")
                    tx.Write(String.Format("{0,-20}", folio) & " ")
                    tx.Write(cargo & " ")
                    tx.Write(String.Format("{0,-20}", total) & " ")
                    tx.Write("0          ")
                    tx.Write("0.0                  ")
                    tx.Write(String.Format("{0,-101}", ""))
                    tx.Write(String.Format("{0,4}", sn) & " ")
                    tx.Write(String.Format("{0,-37}", ""))
                    tx.WriteLine()
                    tx.Write("AM ")
                    tx.Write(String.Format("{0,-30}", .Cells("uuidFactura").Value) & " ")
                    tx.WriteLine()
                    If (.Cells("monedaVP").Value = "MXN" And .Cells("pivot").Value = "4") Or (.Cells("monedaVP").Value = "USD" And .Cells("pivot").Value = "5") Then
                        tx.Write("AD ")
                        tx.Write(String.Format("{0,-30}", .Cells("uuidFactura").Value) & " ")
                        tx.WriteLine()
                    End If
                End With
            Next
            MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "")
            tx.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            tx.Close()
        End Try
    End Sub
    Private Function idSegNeg(ByVal segneg As String) As String
        Select Case segneg
            Case "CONTABILIDAD" : Return "1"
            Case "CALIDAD" : Return "2"
            Case "ASEGURAMIENTO DE CALIDAD" : Return "2"
            Case "Control" : Return "3"
            Case "CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/ CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/C PRODUCCIÓN" : Return "3"
            Case "VENTAS/CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/CPRODUCCIION" : Return "3"
            Case "VENTAS/CPRODUCCION" : Return "3"
            Case "VENTAS/CPRODUCCIÓN" : Return "3"
            Case "FUNDICION" : Return "4"
            Case "FUNDICIÓN" : Return "4"
            Case "FUNDICION 1" : Return "4"
            Case "FUNDICIÓN 1" : Return "4"
            Case "FUNDICION F1" : Return "4"
            Case "FUNDICIÓN F1" : Return "4"
            Case "FUNDICION 1 Y 2" : Return "4, 11"
            Case "MOLDES" : Return "5"
            Case "MOLDES." : Return "5"
            Case "MAQUINADO" : Return "6"
            Case "Maquinado F1" : Return "6"
            Case "MAQUINADO F1" : Return "6"
            Case "MAQUINADOF1" : Return "6"
            Case "ARTICULOS DE LIMPIEZA" : Return "7"
            Case "ASUNTOS GENERALES" : Return "7"
            Case "ASUNTOS GENERALES." : Return "7"
            Case "RECURSOS HUMANOS" : Return "7"
            Case "SEGURIDAD" : Return "7"
            Case "SEGURIDAD E HIGIENE" : Return "7"
            Case "SEGURIDAD E HIGIENE." : Return "7"
            Case "SISTEMAS IT" : Return "7"
            Case "COMPRAS" : Return "8"
            Case "COMPRAS." : Return "8"
            Case "INGENIERIA" : Return "9"
            Case "INGENIERÍA" : Return "9"
            Case "GESTION" : Return "10"
            Case "GESTIÓN" : Return "10"
            Case "GESTIÓN/ FACILITIES" : Return "10"
            Case "GESTION/FACILITIES" : Return "10"
            Case "GESTIÓN/FACILITIES" : Return "10"
            Case "FUNCICIÓN F2" : Return "11"
            Case "FUNDICION 2" : Return "11"
            Case "FUNDICIÓN 2" : Return "11"
            Case "FUNDICION F2" : Return "11"
            Case "Fundición F2" : Return "11"
            Case "FUNDICIÓN F2" : Return "11"
            Case "MAQUINADO 2" : Return "12"
            Case "Maquinado F2" : Return "12"
            Case "MAQUINADO F2" : Return "12"
            Case "INSPECCION DE CALIDAD" : Return "13"
            Case "INSPECCIÓN DE CALIDAD" : Return "13"
            Case Else : Return "1"
        End Select
    End Function
    Private Sub LimpiarFiltros()
        Txt_FiltroOC.Text = ""
        Txt_FiltroCompras.Text = ""
        Txt_FiltroFactura.Text = ""
        Txt_FiltroProveedor.Text = ""
    End Sub
    Private Sub LimpiarDgv()
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count()
        Dim var
        Dgv_Prepolizas.DataSource = Nothing
        Dgv_Prepolizas.Rows.Clear()
        For fila = 0 To totalFilas - 1
            With Dgv_Compras.Rows(fila)
                var = .Cells("seleccion").Value
                If .Cells("seleccion").Value = 1 Then
                    .Cells("seleccion").Value = 0
                End If
            End With
        Next
    End Sub
#End Region
End Class