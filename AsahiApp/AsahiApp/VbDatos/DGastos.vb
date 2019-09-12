Imports Clases
Imports System.Data.SqlClient
Public Class DGastos
    Public Function RecuperarPlanGastos(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer) As LGastos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT [CuentaProducto],ct.[Nombre],SUM([CostoPesos]) MasterP, ISNULL((SELECT Sum([Importe]) FROM [CONTA].[ctAAM].[dbo].[Afectaciones] af where ct.[Id] = af.[IdCuenta] and ([Periodo] = " & mes & " and [Ejercicio] = " & año & ") Group by af.[IdCuenta] union all SELECT Sum([Importe]) FROM [CONTA].[ctAAMS].[dbo].[Afectaciones] afs where cts.[Id] = afs.[IdCuenta] and ([Periodo] = " & mes & " and [Ejercicio] = " & año & ") Group by afs.[IdCuenta]),0)[Actual] FROM [AsahiSystem].[dbo].[CtrlGastos_Planes] gp inner join [CONTA].[ctAAM].[dbo].[Cuentas] ct On gp.[CuentaProducto] = ct.[Codigo] COLLATE SQL_Latin1_General_CP437_BIN left join [CONTA].[ctAAMS].[dbo].[Cuentas] cts On gp.[CuentaProducto] = cts.[Codigo] COLLATE SQL_Latin1_General_CP437_BIN where (gp.Bloqueo = 0 and gp.Estado = 0) and (mes = " & mes & " and año = " & año & ") Group by gp.[CuentaProducto],ct.[Nombre], ct.[Id], cts.[Id] order by gp.[CuentaProducto]", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim gastos As New Gastos()
                gastos.Cuenta = dr("CuentaProducto").ToString
                gastos.NombreCuenta = dr("Nombre").ToString
                gastos.MasterP = Convert.ToDouble(dr("MasterP").ToString)
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
