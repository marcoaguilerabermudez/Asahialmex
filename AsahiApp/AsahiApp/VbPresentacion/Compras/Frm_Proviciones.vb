Imports Clases
Imports Negocio

Public Class Frm_Provisiones
#Region "Varianbles de clase"
    Dim cadenaConex As String
    Dim cadConex As String
    Dim userName As String
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_Provisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion()
        Me.cadenaConex = conex.cadenaConexExpress
        Me.cadConex = conex.conexion2008

        Dtp_Inicio.Value = DateAdd(DateInterval.Day, -14, Date.Now())
        Dgv_PorProvisionar.RowsDefaultCellStyle.BackColor = Color.LightGray
        Dgv_Provisionadas.RowsDefaultCellStyle.BackColor = Color.LightGray
        RecuperarCompras()
    End Sub
    Private Sub Btn_BuscarCompras_Click(sender As Object, e As EventArgs) Handles Btn_BuscarCompras.Click
        RecuperarCompras()
    End Sub
    Private Sub Btn_ActualizarXml_Click(sender As Object, e As EventArgs) Handles Btn_ActualizarXml.Click
        ActualizaXml()
    End Sub
    Private Sub Btn_Validar_Click(sender As Object, e As EventArgs) Handles Btn_Validar.Click
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()

        lstComp = RellenaObjetoCompras()

    End Sub
#End Region
#Region "Recuperar"
    Private Sub RecuperarCompras()
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim fi As Date = Dtp_Inicio.Value, ff As Date = Dtp_Final.Value
        lstComp = NComp.RecuperarLstPorProvicionar(Me.cadenaConex, fi, ff)
        RellenarDgvPorProvisionar(lstComp)
    End Sub
#End Region
#Region "Rellena Formulario"
    Private Sub RellenarDgvPorProvisionar(ByVal lstComp As LCompras)
        Dim fila As Integer = 0
        Dgv_PorProvisionar.DataSource = Nothing
        Dgv_PorProvisionar.Rows.Clear()

        For Each item In lstComp
            Dgv_PorProvisionar.Rows.Add()
            With Dgv_PorProvisionar.Rows(fila)
                .Cells("idProvision").Value = item.IdProvision
                .Cells("oc").Value = item.Oc
                .Cells("compra").Value = item.IdCompra
                .Cells("factura").Value = item.Factura
                .Cells("proveedor").Value = item.Proveedor
                .Cells("rfc").Value = item.Rfc
                .Cells("rfcEmisor").Value = item.RfcEmisor
                .Cells("moneda").Value = item.Moneda
                If item.MontoOC <> 0 Then .Cells("montoOc").Value = Format(item.MontoOC, "$ #,###,##0.00")
                If item.MontoCompra <> 0 Then .Cells("montoCompra").Value = Format(item.MontoCompra, "$ #,###,##0.00")
                If item.MontoFact <> 0 Then .Cells("montoFactura").Value = Format(item.MontoFact, "$ #,###,##0.00")
                If item.MontoPagar <> 0 Then .Cells("montoPago").Value = Format(item.MontoPagar, "$ #,###,##0.00")
                If item.FechaFact <> "1/1/1900 12:00:00 AM" Then .Cells("fechaFactura").Value = Format(item.FechaFact, "dd/MM/yyyy")
                If item.FechaPagoFact <> "1/1/1900 12:00:00 AM" Then .Cells("fechaPago").Value = Format(item.FechaPagoFact, "dd/MM/yyyy")
                .Cells("status").Value = item.Status
                .Cells("observacionCompra").Value = item.ObservaCompra
                .Cells("empresa").Value = item.Empresa
                .Cells("nombreEmisor").Value = item.NombreEmisor
                .Cells("serie").Value = item.Serie
                If item.FechaCompra <> "1/1/1900 12:00:00 AM" Then .Cells("fechaCompra").Value = Format(item.FechaCompra, "dd/MM/yyyy")
                If item.Status = "D" Then
                    .DefaultCellStyle.BackColor = Color.OrangeRed
                    .DefaultCellStyle.ForeColor = Color.White
                End If
            End With
            fila += 1
        Next
    End Sub
#End Region
#Region "Rellena Objetos"
    Private Function RellenaObjetoCompras() As LCompras
        Dim lstComp As New LCompras()
        Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count - 1, ctaSelect As Integer = 0

        For fila = 0 To totalFilas
            With Dgv_PorProvisionar.Rows(fila)
                If .Cells("seleccion").Value Then
                    ctaSelect += 1
                    Dim comp As New Compras()
                    comp.IdProvision = .Cells("idProvision").Value
                    comp.Factura = .Cells("factura").Value
                    comp.MontoFact = .Cells("montoFactura").Value
                    comp.FechaPagoFact = .Cells("fechaPago").Value
                    comp.Oc = .Cells("oc").Value
                    comp.Proveedor = .Cells("proveedor").Value
                    comp.Serie = .Cells("serie").Value
                    comp.Status = .Cells("status").Value
                    comp.RfcEmisor = .Cells("rfcEmisor").Value
                    comp.ObservaCompra = .Cells("observacionCompra").Value
                    comp.IdCompra = .Cells("compra").Value
                End If
            End With
        Next
        If ctaSelect = 0 Then
            MsgBox("No has seleccionado ningún campo")
        End If
        Return lstComp
    End Function
#End Region
#Region "Otros"
    Private Sub ActualizaXml()
        Dim NComp As New NCompras()
        NComp.ActualizarXml(Me.cadenaConex)
    End Sub
#End Region
End Class