Imports Clases
Imports Datos
Imports System.Data.SqlClient
Public Class NPrenomina
    Public Function RecuperarDiasSemana(ByVal cadConex As SqlConnection, ByVal fecha As Date) As Horarios
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarDiasSemana(cadConex, fecha)
    End Function
    Public Function EmpleadosRecuperar(ByVal cadConex As String, ByVal fecha As Date) As LEmpleado
        Dim DEmpleado As New DEmpleado()
        Return DEmpleado.EmpleadosRecuperar(cadConex, fecha)
    End Function
    Public Function RecuperarAusentismo(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LAusentismo
        Dim DPrenomina As New DPrenomina
        Return DPrenomina.RecuperarAusentismo(cadConex, fechaI, fechaF)
    End Function
    Public Function RecuperarVacaciones(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LVacaciones
        Dim DPrenomina As New DPrenomina
        Return DPrenomina.RecuperarVacaciones(cadConex, fechaI, fechaF)
    End Function
    Public Function RecuperarIncapacidades(ByVal cadConex As String) As LIncapacidad
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarIncapacidades(cadConex)
    End Function
    Public Function RecuperarHorasExtra(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LHorasExtra
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarHorasExtra(cadConex, fechaI, fechaF)
    End Function
    Public Function RecuperarBajas(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LBaja
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarBajas(cadConex, fechaI, fechaF)
    End Function
End Class
