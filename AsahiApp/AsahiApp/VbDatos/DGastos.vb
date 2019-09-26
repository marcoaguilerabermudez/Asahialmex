Imports Clases
Imports System.Data.SqlClient
Public Class DGastos
    Public Function RecuperarPlanGastos(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Ctrl_PlanGastos", oCon)
            query.Parameters.AddWithValue("@mes", mes)
            query.Parameters.AddWithValue("@año", año)
            query.Parameters.AddWithValue("@fi", fi)
            query.Parameters.AddWithValue("@ff", ff)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gastos As New Gastos()
                gastos.Cuenta = dr("CuentaProducto").ToString
                gastos.NombreCuenta = dr("Nombre").ToString
                gastos.MasterP = Convert.ToDouble(dr("MasterP").ToString)
                gastos.Actual = Convert.ToDouble(dr("Actual").ToString)
                gastos.Cotizacion = Convert.ToDouble(dr("Cotizacion").ToString)
                gastos.OC = Convert.ToDouble(dr("Oc").ToString)
                gastos.Compras = Convert.ToDouble(dr("Compras").ToString)
                gastos.Poliza = Convert.ToDouble(dr("Poliza").ToString)
                lstGastos.Add(gastos)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstGastos
    End Function
    Public Function RecuperarPlanGastosDpto(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date, ByVal clave As Integer) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Ctrl_PlanGastosSegNegocio", oCon)
            query.Parameters.AddWithValue("@mes", mes)
            query.Parameters.AddWithValue("@año", año)
            query.Parameters.AddWithValue("@fi", fi)
            query.Parameters.AddWithValue("@ff", ff)
            query.Parameters.AddWithValue("@segneg", clave)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gastos As New Gastos()
                gastos.Cuenta = dr("CuentaProducto").ToString
                gastos.NombreCuenta = dr("Nombre").ToString
                gastos.MasterP = Convert.ToDouble(dr("MasterP").ToString)
                gastos.Actual = Convert.ToDouble(dr("Actual").ToString)
                gastos.Cotizacion = Convert.ToDouble(dr("Cotizacion").ToString)
                gastos.OC = Convert.ToDouble(dr("Oc").ToString)
                gastos.Compras = Convert.ToDouble(dr("Compras").ToString)
                gastos.Poliza = Convert.ToDouble(dr("Poliza").ToString)
                lstGastos.Add(gastos)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstGastos
    End Function
    Public Function RecuperarPlanVentas(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("RecuperarPlanVtas", oCon)
            query.Parameters.AddWithValue("@mes", mes)
            query.Parameters.AddWithValue("@año", año)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gastos As New Gastos()
                gastos.SegmNegocio = Convert.ToInt32(dr("SegmentoNegocio").ToString)
                gastos.Plan = Convert.ToDouble(dr("cantidad").ToString)
                gastos.PlanMonto = Convert.ToDouble(dr("monto").ToString)
                lstGastos.Add(gastos)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstGastos
    End Function
End Class