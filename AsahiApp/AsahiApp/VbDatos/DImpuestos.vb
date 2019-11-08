Imports Clases
Imports System.Data.SqlClient
Public Class DImpuestos
    Public Function RecuperarIsr(ByVal cadenaConex As String, ByVal sueldo As Double) As Impuestos
        Dim imp As New Impuestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("select top 1 LimiteInferior,CuotaFija,PorcentajeExcedente from RetencionISR where LimiteInferior < " & sueldo & " order by LimiteInferior desc", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                imp.LimiteInf = Convert.ToDouble(dr("LimiteInferior").ToString)
                imp.CuotaFija = Convert.ToDouble(dr("CuotaFija").ToString)
                imp.PorcentajeEx = Convert.ToString(dr("PorcentajeExcedente").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return imp
    End Function


    Public Sub GeneralOee(ByVal cadenaConex As String, ByVal fecha As Date, ByVal id_proceso As String, ByVal maquina As String, ByVal pieza As String, ByVal molde As String,
                        ByVal cavidad As Integer, ByVal turno As Integer, ByVal tpok As Integer, ByVal tpo As Integer, ByVal tpp As Integer, ByVal ct As Double, ByVal cantidadtotal As Integer,
                        ByVal inypru As Integer, ByVal dfundicion As Integer, ByVal dmaquinado As Integer, ByVal insmuestra As Integer, ByVal pconforme As Integer, ByVal ttotal As Integer, ByVal cjig As Integer,
                        ByVal tmmolde As Integer, ByVal tmmaquina As Integer, ByVal loosf As Integer, ByVal toperacion As Integer)
        Dim oCon As New SqlConnection(cadenaConex)
        'Dim lstGastos As New LGastos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_insertageneraloee", oCon)
            query.Parameters.AddWithValue("@fecha", fecha)
            query.Parameters.AddWithValue("@id_proceso", id_proceso)
            query.Parameters.AddWithValue("@maquina", maquina)
            query.Parameters.AddWithValue("@pieza", pieza)
            query.Parameters.AddWithValue("@molde", molde)
            query.Parameters.AddWithValue("@cavidad", cavidad)
            query.Parameters.AddWithValue("@turno", turno)
            query.Parameters.AddWithValue("@tpok", tpok)
            query.Parameters.AddWithValue("@tpo", tpo)
            query.Parameters.AddWithValue("@tpp", tpp)
            query.Parameters.AddWithValue("@ct", ct)
            query.Parameters.AddWithValue("@cantidadtotal", cantidadtotal)
            query.Parameters.AddWithValue("@inypru", inypru)
            query.Parameters.AddWithValue("@dfundicion", dfundicion)
            query.Parameters.AddWithValue("@dmaquinado", dmaquinado)
            query.Parameters.AddWithValue("@insmuestra", insmuestra)
            query.Parameters.AddWithValue("@pconforme", pconforme)
            query.Parameters.AddWithValue("@ttotal", ttotal)
            query.Parameters.AddWithValue("@cjig", cjig)
            query.Parameters.AddWithValue("@tmmolde", tmmolde)
            query.Parameters.AddWithValue("@tmmaquina", tmmaquina)
            query.Parameters.AddWithValue("@loosf", loosf)
            query.Parameters.AddWithValue("@toperacion", toperacion)


            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 240
            query.ExecuteNonQuery()


            'Dim dr As SqlDataReader
            'dr = query.ExecuteReader
            'While (dr.Read)
            '    Dim gastos As New Gastos()
            '    gastos.Cuenta = dr("CuentaProducto").ToString
            '    gastos.NombreCuenta = dr("Nombre").ToString
            '    gastos.PlanMonto = Convert.ToDouble(dr("PlanM").ToString)
            '    gastos.Actual = Convert.ToDouble(dr("Actual").ToString)
            '    lstGastos.Add(gastos)
            'End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        'Return lstGastos

    End Sub



End Class
