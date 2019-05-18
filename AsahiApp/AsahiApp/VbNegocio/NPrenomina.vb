Imports Clases
Imports Datos
Imports System.Data.SqlClient
Public Class NPrenomina
    Public Function RecuperarDiasSemana(ByVal oCon As SqlConnection, ByVal fecha As Date) As Horarios
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarDiasSemana(oCon, fecha)
    End Function
    Public Function EmpleadosRecuperar(ByVal oCon As SqlConnection, ByVal fecha As Date) As LEmpleado
        Dim DEmple As New DEmpleado()
        Return DEmple.EmpleadosRecuperar(oCon, fecha)
    End Function
End Class
