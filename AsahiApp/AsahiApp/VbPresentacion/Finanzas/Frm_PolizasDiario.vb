Imports Clases
Imports Negocio

Public Class Frm_PolizasDiario
#Region "Varianbles de clase"
    Dim cadenaConex As String
    Dim cadConex As String
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_PolizasDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion()
        Me.cadenaConex = conex.cadenaConexExpress
        Me.cadConex = conex.conexion2008
        Dtp_Inicio.Value = DateAdd(DateInterval.Day, -7, Date.Now())
        Dgv_Compras.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        Dgv_Prepolizas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        RecuperarCompras()
    End Sub
    Private Sub Dgv_Compras_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_Compras.DoubleClick
        Dim uuid As String, moneda As String, tc As Double
        Dim fila As Integer
        fila = Dgv_Compras.CurrentRow.Index
        Dgv_Compras.Rows(fila).Cells("seleccion").Value = 1
        uuid = Dgv_Compras.Rows(fila).Cells("uuid").Value
        moneda = Dgv_Compras.Rows(fila).Cells("moneda").Value
        tc = Dgv_Compras.Rows(fila).Cells("tazaCambio").Value
        RecuperarPolizas(moneda, uuid, tc)
    End Sub
    Private Sub Dtp_Inicio_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Inicio.ValueChanged
        RecuperarCompras()
        Dgv_Prepolizas.DataSource = Nothing
        Dgv_Prepolizas.Rows.Clear()
    End Sub
    Private Sub Dtp_Fin_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fin.ValueChanged
        RecuperarCompras()
        Dgv_Prepolizas.DataSource = Nothing
        Dgv_Prepolizas.Rows.Clear()
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
    Private Sub RecuperarPolizas(ByVal moneda As String, ByVal uuid As String, ByVal tc As Double)
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        lstComp = NComp.VistaPoliza(Me.cadenaConex, moneda, uuid, tc)
        RellenarDgvVistaPolizas(lstComp)
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
                .Cells("provision").Value = item.IdProvicion
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
            End With
            fila += 1
        Next
    End Sub
    Private Sub RellenarDgvVistaPolizas(ByVal lstComp As LCompras)
        Dim fila As Integer = Dgv_Prepolizas.Rows.Count()

        For Each item In lstComp
            Dgv_Prepolizas.Rows.Add()
            'Dgv_Prepolizas.Columns("acum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
                .Cells("monedaVP").Value = item.Moneda
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
            End With
            fila += 1
        Next
    End Sub
#End Region
End Class