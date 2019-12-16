Imports Clases
Imports Negocio
Imports System.IO
Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms

Public Class Frm_PolizasDiario
#Region "Varianbles de clase"
    Dim cadenaConex As String
    Dim cadConex As String
    Dim userName As String
    Dim ruta As String
    Dim archivo As String
    Dim fechaPago As Date
    Dim tCamb As Double
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
        Dim uuid As String, moneda As String, tc As Double, oc As Integer
        Dim fila As Integer
        If Dgv_Compras.Rows(fila).Cells("seleccion").Value = 1 Then
            fila = Dgv_Compras.CurrentRow.Index
            Dgv_Compras.Rows(fila).Cells("seleccion").Value = 1
            uuid = Dgv_Compras.Rows(fila).Cells("uuid").Value
            moneda = Dgv_Compras.Rows(fila).Cells("moneda").Value
            tc = Dgv_Compras.Rows(fila).Cells("tazaCambio").Value
            Me.tCamb = Dgv_Compras.Rows(fila).Cells("tazaCambio").Value
            oc = Dgv_Compras.Rows(fila).Cells("oc").Value
            Me.fechaPago = Dgv_Compras.Rows(fila).Cells("fechaPagoFactura").Value
            RecuperarPolizas(moneda, uuid, tc, oc)
        End If
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
    Private Sub Btn_Txt_Click(sender As Object, e As EventArgs) Handles Btn_Txt.Click
        CrearTxt()
        EscribirArchivo()
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
    Private Sub RecuperarPolizas(ByVal moneda As String, ByVal uuid As String, ByVal tc As Double, ByVal oc As Integer)
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        lstComp = NComp.VistaPoliza(Me.cadenaConex, moneda, uuid, tc)
        RellenarDgvVistaPolizas(lstComp, oc)
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
    Private Sub RellenarDgvVistaPolizas(ByVal lstComp As LCompras, ByVal oc As Integer)
        Dim fila As Integer = Dgv_Prepolizas.Rows.Count()
        Dim frm As New Frm_ConceptoPoliza("PO " & oc & " PROVISION ")

        If frm.ShowDialog() = DialogResult.OK Then
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
        End If
    End Sub
#End Region
#Region "Otros"
    Private Sub CrearTxt()
        Me.userName = Environment.UserName
        Me.ruta = "C:\Users\" & Me.userName & "\Desktop\Polizas Diario\"
        Me.archivo = "Polizas" & 12 & ".txt"
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
                    If .Cells("familia").Value = "Cargo" Or .Cells("familia").Value = "ProveedorUSD" Or .Cells("familia").Value = "ComplementariaUSD" Then
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
                    If (.Cells("monedaVP").Value = "MXN" And .Cells("pivot").Value = "3") Or (.Cells("monedaVP").Value = "USD" And .Cells("pivot").Value = "4") Then
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
            Case "ARTICULOS DE LIMPIEZA" : Return "7"
            Case "ASEGURAMIENTO DE CALIDAD" : Return "2"
            Case "ASUNTOS GENERALES" : Return "7"
            Case "ASUNTOS GENERALES." : Return "7"
            Case "CALIDAD" : Return "2"
            Case "COMPRAS" : Return "8"
            Case "COMPRAS." : Return "8"
            Case "CONTABILIDAD" : Return "1"
            Case "Control" : Return "3"
            Case "CONTROL DE PRODUCCIÓN" : Return "3"
            Case "FUNCICIÓN F2" : Return "11"
            Case "FUNDICION" : Return "4"
            Case "FUNDICIÓN" : Return "4"
            Case "FUNDICION 1" : Return "4"
            Case "FUNDICIÓN 1" : Return "4"
            Case "FUNDICION 1 Y 2" : Return "4, 11"
            Case "FUNDICION 2" : Return "11"
            Case "FUNDICIÓN 2" : Return "11"
            Case "FUNDICION F1" : Return "4"
            Case "FUNDICIÓN F1" : Return "4"
            Case "FUNDICION F2" : Return "11"
            Case "Fundición F2" : Return "11"
            Case "FUNDICIÓN F2" : Return "11"
            Case "GESTION" : Return "10"
            Case "GESTIÓN" : Return "10"
            Case "GESTIÓN/ FACILITIES" : Return "10"
            Case "GESTION/FACILITIES" : Return "10"
            Case "GESTIÓN/FACILITIES" : Return "10"
            Case "INGENIERIA" : Return "9"
            Case "INGENIERÍA" : Return "9"
            Case "INSPECCION DE CALIDAD" : Return "13"
            Case "INSPECCIÓN DE CALIDAD" : Return "13"
            Case "MAQUINADO" : Return "6"
            Case "MAQUINADO 2" : Return "12"
            Case "Maquinado F1" : Return "6"
            Case "Maquinado F2" : Return "12"
            Case "MAQUINADO F1" : Return "6"
            Case "MAQUINADO F2" : Return "12"
            Case "MAQUINADOF1" : Return "6"
            Case "MOLDES" : Return "5"
            Case "MOLDES." : Return "5"
            Case "RECURSOS HUMANOS" : Return "7"
            Case "SEGURIDAD" : Return "7"
            Case "SEGURIDAD E HIGIENE" : Return "7"
            Case "SEGURIDAD E HIGIENE." : Return "7"
            Case "SISTEMAS IT" : Return "7"
            Case "VENTAS/ CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/C PRODUCCIÓN" : Return "3"
            Case "VENTAS/CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/CPRODUCCIION" : Return "3"
            Case "VENTAS/CPRODUCCION" : Return "3"
            Case "Ventas/CProducción" : Return "3"
            Case Else : Return "1"
        End Select
    End Function
#End Region
End Class