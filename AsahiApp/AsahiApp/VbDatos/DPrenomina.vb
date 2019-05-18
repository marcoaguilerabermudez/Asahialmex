Imports Clases
Imports System.Data.SqlClient
Public Class DPrenomina
    Public Function RecuperarDiasSemana(ByVal oCon As SqlConnection, ByVal fecha As Date) As Horarios
        Dim hrs As New Horarios()
        Try
            oCon.Open()
            Dim query As New SqlCommand("LRegresarFechas", oCon)
            query.Parameters.AddWithValue("@fecha", fecha)
            query.CommandType = CommandType.StoredProcedure

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                hrs.FechaI = Convert.ToDateTime(dr("fechaI").ToString)
                hrs.FechaF = Convert.ToDateTime(dr("fechaF").ToString)
                hrs.Semana = Convert.ToInt32(dr("semana").ToString)
                hrs.Año = Convert.ToInt32(dr("año").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return hrs
    End Function
    Public Function HorasChecadasSemanal() As Horarios
        Dim hrs As New Horarios()
        Return hrs
    End Function
End Class
