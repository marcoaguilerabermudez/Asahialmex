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
    Public Function RecuperarComedor(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LComedor
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarComedor(cadConex, fechaI, fechaF)
    End Function
    Public Sub InsertarModificacionesIncidencias(ByVal cadenaConex As String, ByVal lstEmp As LEmpleado, ByVal sem As Integer)
        Dim objEmp As New Empleado()
        Dim DPrenom As New DPrenomina()

        objEmp = CreaXml(lstEmp, sem)
        DPrenom.InsertarModificacionesIncidencias(cadenaConex, objEmp)
    End Sub
    Private Function CreaXml(ByVal lstEmp As LEmpleado, ByVal sem As Integer) As Empleado
        Dim objEmp As New Empleado()
        Dim i As Byte
        Dim str As String
        Dim fechor As Date

        fechor = Now

        For i = 0 To lstEmp.Count - 1
            str = "<Info><IdEmpleado>" & lstEmp.Item(i).IdEmpleado & "</IdEmpleado><fechaModif>" & Format(fechor, "dd/MM/yyyy") &
                "</fechaModif><horaModif>" & Format(fechor, "HH:mm:ss") & "</horaModif><fecha>" & lstEmp.Item(i).Fecha1 &
                "</fecha><semana>" & sem & "</semana><incidencia1>" & lstEmp.Item(i).Incidencia1 & "</incidencia1><incidencia2>" & lstEmp.Item(i).Incidencia2 &
                "</incidencia2><tipoModificacion1>" & lstEmp.Item(i).TipoIncidencia1 & "</tipoModificacion1><tipoModificacion2>" & lstEmp.Item(i).TipoIncidencia2 &
                "</tipoModificacion2></Info>"
            objEmp.Xml = objEmp.Xml & str
        Next

        objEmp.Xml = "<Incidencias>" & objEmp.Xml & "</Incidencias>"
        Return objEmp
    End Function
    Private Function RecuperarInc(ByVal cadenaConex As String, ByVal tipoM As String, ByVal sem As Integer, ByVal fechaI As Date, ByVal fechaF As Date) As LEmpleado
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarInc(cadenaConex, tipoM, sem, fechaI, fechaF)
    End Function
End Class