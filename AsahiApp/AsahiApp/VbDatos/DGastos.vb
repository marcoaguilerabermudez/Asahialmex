Imports Clases
Imports System.Data.SqlClient
Public Class DGastos
    Public Function RecuperarPlanGastos(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date,
                                        ByVal idCtg As Integer, ByVal idioma As Integer) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Ctrl_PlanGastos", oCon)
            query.Parameters.AddWithValue("@mes", mes)
            query.Parameters.AddWithValue("@año", año)
            query.Parameters.AddWithValue("@fi", fi)
            query.Parameters.AddWithValue("@ff", ff)
            query.Parameters.AddWithValue("@idcg", idCtg)
            query.Parameters.AddWithValue("@idioma", idioma)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 240
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gastos As New Gastos()
                gastos.Cuenta = dr("CuentaProducto").ToString
                gastos.NombreCuenta = dr("Nombre").ToString
                gastos.PlanMonto = Convert.ToDouble(dr("PlanM").ToString)
                gastos.Actual = Convert.ToDouble(dr("Actual").ToString)
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
    Public Function RecuperarPlanGastosDpto(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date,
                                            ByVal clave As Integer, ByVal idCtg As Integer, ByVal idioma As Integer) As LGastos
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
            query.Parameters.AddWithValue("@idcg", idCtg)
            query.Parameters.AddWithValue("@idioma", idioma)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gastos As New Gastos()
                gastos.Cuenta = dr("CuentaProducto").ToString
                gastos.NombreCuenta = dr("Nombre").ToString
                gastos.PlanMonto = Convert.ToDouble(dr("PlanM").ToString)
                gastos.Actual = Convert.ToDouble(dr("Actual").ToString)
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
    Public Function RecuperarPlanVentas(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("RecuperarPlanVtas", oCon)
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
                gastos.SegmNegocio = Convert.ToInt32(dr("SegmentoNegocio").ToString)
                gastos.Plan = Convert.ToDouble(dr("cantidad").ToString)
                gastos.PlanMonto = Convert.ToDouble(dr("monto").ToString)
                gastos.ActualMonto = Convert.ToDouble(dr("montoA").ToString)
                gastos.Actual = Convert.ToDouble(dr("cantiA").ToString)
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
    Public Function RecuperarPlanGastosAgrupado(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date,
                                        ByVal idioma As Integer, Optional ByVal sn As Integer = 0) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Ctrl_PlanGastosAgrupado", oCon)
            query.Parameters.AddWithValue("@mes", mes)
            query.Parameters.AddWithValue("@año", año)
            query.Parameters.AddWithValue("@fi", fi)
            query.Parameters.AddWithValue("@ff", ff)
            query.Parameters.AddWithValue("@idioma", idioma)
            If sn > 0 Then query.Parameters.AddWithValue("@sn", sn)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 240
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gastos As New Gastos()
                gastos.Cuenta = dr("Codigo").ToString
                gastos.NombreCuenta = dr("Descripcion").ToString
                gastos.PlanMonto = Convert.ToDouble(dr("PlanM").ToString)
                gastos.Actual = Convert.ToDouble(dr("Actual").ToString)
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
    Public Function RecuperarSegNegocio(ByVal cadenaConex As String, ByVal idioma As Integer) As LEmpleado
        Dim lstDep As New LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SegNeg_Obtener", oCon)
            query.Parameters.AddWithValue("@idioma", idioma)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim Emp As New Empleado
                Emp.IdDepartamento = dr("Id").ToString
                Emp.Departamento = dr("Descripcion").ToString
                lstDep.Add(Emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstDep
    End Function
    Public Function RecuperarDetallesGastos(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date,
                                            ByVal cuenta As String, ByVal idioma As Integer, Optional ByVal sn As Integer = 0) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Ctrl_DetallesGastos", oCon)
            query.Parameters.AddWithValue("@mes", mes)
            query.Parameters.AddWithValue("@año", año)
            query.Parameters.AddWithValue("@fi", fi)
            query.Parameters.AddWithValue("@ff", ff)
            query.Parameters.AddWithValue("@cuenta", cuenta)
            query.Parameters.AddWithValue("@idioma", idioma)
            If sn > 0 Then query.Parameters.AddWithValue("@sn", sn)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gastos As New Gastos()
                gastos.Cuenta = dr("Cuenta")
                gastos.NombreCuenta = dr("CNOMBREPRODUCTO")
                gastos.OrdenCompra = dr("Compra").ToString
                gastos.Compras = Convert.ToDouble(dr("CosCompra").ToString)
                gastos.CantCompra = Convert.ToDouble(dr("CantCompra").ToString)
                gastos.SegmNegocio = dr("SegNeg").ToString
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
    Public Function RecuperarCuentasGeneral(ByVal cadenaConex As String, ByVal idioma As Integer, ByVal mes As Integer, ByVal año As Integer,
                                            ByVal segNeg As Integer) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGst As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("CtaGral_Recuperar", oCon)
            query.Parameters.AddWithValue("@idioma", idioma)
            query.Parameters.AddWithValue("@mes", mes)
            query.Parameters.AddWithValue("@año", año)
            query.Parameters.AddWithValue("@segNeg", segNeg)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gst As New Gastos()
                gst.Cuenta = dr("Codigo").ToString
                gst.NombreCuenta = dr("Descripcion").ToString
                gst.MontoPesos = Convert.ToDouble(dr("Monto").ToString)
                lstGst.Add(gst)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstGst
    End Function
    Public Function RecuperarListaCtas(ByVal cadenaConex As String, ByVal cta As Integer, ByVal mes As Integer, ByVal año As Integer, ByVal segNeg As Integer,
                                       ByVal idioma As Integer) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGst As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Cta_RecuperarListaCtas", oCon)
            query.Parameters.AddWithValue("@CtaGrl", cta)
            query.Parameters.AddWithValue("@Mes", mes)
            query.Parameters.AddWithValue("@Año", año)
            query.Parameters.AddWithValue("@SegNeg", segNeg)
            query.Parameters.AddWithValue("@idioma", idioma)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gst As New Gastos()
                gst.Cuenta = dr("Codigo").ToString
                gst.NombreCuenta = dr("Nombre").ToString
                gst.PlanMonto = Convert.ToDouble(dr("PlanM").ToString)
                gst.Empresa = dr("Empresa").ToString
                'gst.Modif = dr("Modif").ToString
                lstGst.Add(gst)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstGst
    End Function
    Public Sub InsertarPlan(ByVal cadenaConex As String, ByVal objGst As Gastos)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Ctrl_InsertarPlanGastos", oCon)
            query.Parameters.AddWithValue("@XML", objGst.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar() 'En un Insert de XML, NO olvidar esta línea si no, no inserta mi madres

            MsgBox("Registros insertados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
End Class