Imports Clases
Imports System.Data.SqlClient
Public Class DHorasExtra
    Public Function ObtenerSemanas(ByVal cadenaConex As String, ByVal año As Integer) As LHorasExtra
        Dim lstHrsEx As New LHorasExtra
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT numeroperiodo FROM asahi16.dbo.periodos WHERE ejercicio = " & año & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim hrsEx As New HorasExtra
                hrsEx.Semanas = Convert.ToInt32(dr("numeroperiodo").ToString)
                lstHrsEx.Add(hrsEx)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstHrsEx
    End Function
    Public Function ObtenerFechasSemana(ByVal cadenaConex As String, ByVal año As Integer, ByVal semana As Integer) As HorasExtra
        Dim hrsEx As New HorasExtra
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT fecinicio, fecfin, mes FROM asahi16.dbo.periodos WHERE ejercicio = " & año & "and numeroperiodo = " & semana & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                hrsEx.FechaI = Convert.ToDateTime(dr("fecinicio").ToString)
                hrsEx.FechaF = Convert.ToDateTime(dr("fecfin").ToString)
                hrsEx.Mes = Convert.ToInt32(dr("mes").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return hrsEx
    End Function
    Public Sub InsertarPlanHrsExtra(ByVal cadenaConex As String, ByVal objHrsEx As HorasExtra)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Rh_PlanHorasExtraInsertar", oCon)
            query.Parameters.AddWithValue("@XML", objHrsEx.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            query.ExecuteScalar() 'En un Insert de XML, NO olvidar esta línea si no, no insertará

            MsgBox("Registros insertados correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Function RecuperarAños(ByVal cadenaConex As String) As LHorarios
        Dim lstHrs As New LHorarios()
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("select ejercicio from periodos group by ejercicio", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim hrs As New Horarios()
                hrs.Año = Convert.ToInt32(dr("ejercicio").ToString)
                lstHrs.Add(hrs)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstHrs
    End Function
    Public Function RecuperarTotalSemanas(ByVal cadConex As String, ByVal mes As Integer, ByVal año As Integer) As Integer
        Dim tSemanas As Integer
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("select count(mes) as mes from periodos where mes = " & mes & " and ejercicio = " & año & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                tSemanas = Convert.ToInt32(dr("mes").ToString)
            End While
        Catch ex As Exception
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Close()
        End Try
        Return tSemanas
    End Function



End Class
