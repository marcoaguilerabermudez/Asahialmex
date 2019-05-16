Imports Clases
Imports System.Data.SqlClient
Public Class DPrenomina
    Public Function RecuperarDíasSemana(ByVal cadenaConex As SqlConnection, ByVal semana As Integer) As Horarios
        Dim hrs As New Horarios()
        Return hrs
    End Function
    Public Function EmpleadosRecuperar(ByVal cadenaConex As SqlConnection, ByVal fechaI As Date, ByVal fechaF As Date) As Empleado
        Dim empleados As New Empleado()
        Return empleados
    End Function
    Public Function HorasChecadasSemanal() As Horarios
        Dim hrs As New Horarios()
        Return hrs
    End Function
End Class
