Imports Clases
Imports System.Data.SqlClient
Public Class DPrenomina
    Public Function RecuperarDiasSemana(ByVal oCon As SqlConnection, ByVal semana As Integer, ByVal año As Integer) As LHorarios
        Dim lst As New LHorarios()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select fechainicio, fechafin from ctAsahi_Aluminium.dbo.nom10002 where ejercicio = " + año + " and numeroperiodo = " + semana + "", oCon)
            'query.CommandType = CommandType.TableDirect
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim hrs As New Horarios()
                hrs.FechaI = Convert.ToDateTime(dr("fechainicio").ToString)
                hrs.FechaF = Convert.ToDateTime(dr("fechafin").ToString)
                lst.Add(hrs)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lst
    End Function
    Public Function EmpleadosRecuperar(ByVal cadenaConex As SqlConnection, ByVal fechaI As Date, ByVal fechaF As Date) As LEmpleado
        Dim lst As New LEmpleado()
        Dim empleados As New Empleado()
        Return lst
    End Function
    Public Function HorasChecadasSemanal() As LHorarios
        Dim lst As New LHorarios()
        Dim hrs As New Horarios()
        Return lst
    End Function
End Class
