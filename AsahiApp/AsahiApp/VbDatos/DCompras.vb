Imports Clases
Imports System.Data.SqlClient

Public Class DCompras
    Public Function RecuperarLstCompras(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_previopoliza", oCon)
            query.Parameters.AddWithValue("@fechai", fi)
            query.Parameters.AddWithValue("@fechaf", ff)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.IdProvicion = Convert.ToInt32(dr("Id_provision").ToString)
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.IdOrdenCompra = Convert.ToInt32(dr("Oc").ToString)
                comp.Serie = dr("Serie").ToString
                comp.Factura = dr("Factura").ToString
                comp.Proveedor = dr("Proveedor").ToString
                comp.MontoOC = Convert.ToDouble(dr("MontoOc").ToString)
                comp.MontoFact = Convert.ToDouble(dr("MontoFact").ToString)
                comp.MontoPagar = Convert.ToDouble(dr("MontoaPagar").ToString)
                comp.MontoCompra = Convert.ToDouble(dr("MontoCompra").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("FechaFactura").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaPagoFact").ToString)
                comp.FechaPagoReal = Convert.ToDateTime(dr("FechaPagoReal").ToString)
                comp.Moneda = dr("Moneda").ToString
                comp.Empresa = dr("Empresa").ToString
                comp.FechaCompra = Convert.ToDateTime(dr("FechaCompra").ToString)
                comp.UUID = dr("idfact").ToString
                comp.TazaCambio = dr("tc").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function VistaPoliza(ByVal cadenaConex As String, ByVal moneda As String, ByVal idFac As String, ByVal tc As Double) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_vistaPrincipalPoliza", oCon)
            query.Parameters.AddWithValue("@variable", moneda)
            query.Parameters.AddWithValue("@uuid", idFac)
            query.Parameters.AddWithValue("@tc", tc)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.Pivote = Convert.ToInt32(dr("Pivote").ToString)
                comp.IdOrdenCompra = Convert.ToInt32(dr("OC").ToString)
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.Serie = (dr("Serie").ToString)
                comp.Factura = (dr("Factura").ToString)
                comp.Proveedor = (dr("Proveedor").ToString)
                comp.Rfc = (dr("RFC").ToString)
                comp.TotalFactura = Convert.ToDouble(dr("Total_Factura").ToString)
                comp.CompraTotal = Convert.ToDouble(dr("CompraTotal").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("Fecha_Factura").ToString)
                comp.Moneda = (dr("Moneda").ToString)
                comp.Empresa = (dr("Empresa").ToString)
                comp.RfcEmisor = (dr("RFCEmisor").ToString)
                comp.NombreEmisor = (dr("NombreEmisor").ToString)
                comp.UUID = (dr("UUID").ToString)
                comp.Total = Convert.ToDouble(dr("Total").ToString)
                comp.Area = (dr("Área").ToString)
                comp.Familia = (dr("Familia").ToString)
                comp.Cuenta = (dr("Cuenta").ToString)
                comp.Neto = Convert.ToDouble(dr("Neto").ToString)
                comp.CuentaIva = (dr("Cuenta_iva").ToString)
                comp.IvaT = Convert.ToDouble(dr("Iva_t").ToString)
                comp.CuentaP = (dr("CuentaP").ToString)
                comp.Impuesto = Convert.ToDouble(dr("Impuesto").ToString)
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaProveedores(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Proveedor FROM AsahiSystem.dbo.Provisiones_compras where (FechaFactura between '" & fi & "' and '" & ff & "') AND StatusConta = 1	AND Serie = 'A' and Empresa = 'AAM' group by Proveedor", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Proveedor = dr("Proveedor").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaFamilia(ByVal cadenaConex As String, ByVal uuid As String) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Familia FROM conta.[Asahi].[dbo].[VistaPolizaMx] where UUID = '" & uuid & "' group by Familia", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Familia = dr("Familia").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaSegNeg(ByVal cadenaConex As String, ByVal uuid As String) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Área FROM conta.[Asahi].[dbo].[VistaPolizaMx] where UUID = '" & uuid & "' group by Área", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Area = dr("Área").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
End Class