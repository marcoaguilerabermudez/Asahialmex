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
    Public Function RecuperarTxtNominas(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LTxtNominas
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarTxtNominas(cadConex, fechaI, fechaF)
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
        Dim he
        Dim hs

        fechor = Now

        For i = 0 To lstEmp.Count - 1
            he = lstEmp.Item(i).HoraEntrada
            hs = lstEmp.Item(i).HoraSalida
            str = "<Info><IdEmpleado>" & lstEmp.Item(i).IdEmpleado & "</IdEmpleado><fechaModif>" & Format(fechor, "dd/MM/yyyy") &
                "</fechaModif><horaModif>" & Format(fechor, "HH:mm:ss") & "</horaModif><fecha>" & lstEmp.Item(i).Fecha1 &
                "</fecha><semana>" & sem & "</semana><incidencia1>" & lstEmp.Item(i).Incidencia1 & "</incidencia1><incidencia2>" & lstEmp.Item(i).Incidencia2 &
                "</incidencia2><tipoModificacion1>" & lstEmp.Item(i).TipoIncidencia1 & "</tipoModificacion1><tipoModificacion2>" & lstEmp.Item(i).TipoIncidencia2 &
                "</tipoModificacion2><horaEntrada>" & Format(Convert.ToDateTime(he), "yyyy/MM/dd HH:mm:ss") &
                "</horaEntrada><horaSalida>" & Format(Convert.ToDateTime(hs), "yyyy/MM/dd HH:mm:ss") &
                "</horaSalida><turno>" & lstEmp.Item(i).IdTurno & "</turno></Info>"
            objEmp.Xml = objEmp.Xml & str
        Next

        objEmp.Xml = "<Incidencias>" & objEmp.Xml & "</Incidencias>"
        Return objEmp
    End Function
    Public Function RecuperarInc(ByVal cadenaConex As String, ByVal tipoM As String, ByVal sem As Integer, ByVal fechaI As Date, ByVal fechaF As Date) As LEmpleado
        Dim DPrenomina As New DPrenomina()
        Return DPrenomina.RecuperarInc(cadenaConex, tipoM, sem, fechaI, fechaF)
    End Function
    Public Sub InsertarModificacionesAusentismo(ByVal cadenaConex As String, ByVal lstEmp As LEmpleado)
        Dim DPrenom As New DPrenomina()
        Dim objEmp As New Empleado

        objEmp = CrearXmlAusentismo(lstEmp)
        DPrenom.InsertarModificacionesAusentismo(cadenaConex, objEmp)
    End Sub
    Private Function CrearXmlAusentismo(ByVal lstEmp As LEmpleado) As Empleado
        Dim objEmp As New Empleado()
        Dim i As Byte
        Dim str As String

        For i = 0 To lstEmp.Count - 1
            str = "<Info><Clave>" & String.Format("{0:00000}", lstEmp.Item(i).IdEmpleado) & "</Clave><FechaI>" & Format(lstEmp(i).Fecha1, "dd/MM/yyyy") &
                "</FechaI><FechaF>" & Format(lstEmp(i).Fecha1, "dd/MM/yyyy") & "</FechaF><tipo>" & lstEmp.Item(i).Incidencia1 & "</tipo><FechaCap>" & Format(lstEmp(i).Fecha2, "dd/MM/yyyy") &
                "</FechaCap><FechaApl>" & Format(lstEmp(i).Fecha1, "dd/MM/yyyy") & "</FechaApl></Info>"
            objEmp.Xml = objEmp.Xml & str
        Next

        objEmp.Xml = "<Incidencias>" & objEmp.Xml & "</Incidencias>"
        Return objEmp
    End Function
    Public Sub InsertarModificacionesHE(ByVal cadenaConex As String, ByVal lstEmp As LEmpleado)
        Dim DPrenom As New DPrenomina()
        Dim objEmp As New Empleado

        objEmp = CrearXmlHe(lstEmp)
        DPrenom.InsertarModificacionesHE(cadenaConex, objEmp)
    End Sub
    Private Function CrearXmlHe(ByVal lstEmp As LEmpleado) As Empleado
        Dim objEmp As New Empleado()
        Dim i As Byte
        Dim str As String

        For i = 0 To lstEmp.Count - 1
            str = "<Info><clave>" & String.Format("{0:00000}", lstEmp.Item(i).IdEmpleado) & "</clave><fecha>" & Format(lstEmp(i).Fecha1, "dd/MM/yyyy") &
                "</fecha><tipo>" & lstEmp(i).Incidencia1 & "</tipo><monto>0</monto><autorizado>0</autorizado><tipoPerm>" & Format(lstEmp(i).Fecha1, "dd/MM/yyyy") &
                "</tipoPerm></Info>"
            objEmp.Xml = objEmp.Xml & str
        Next

        objEmp.Xml = "<Incidencias>" & objEmp.Xml & "</Incidencias>"
        Return objEmp
    End Function
    Public Sub InsertarModificacionesChecadas(ByVal cadenaConex As String, ByVal lstEmp As LEmpleado)
        Dim DPrenom As New DPrenomina()
        Dim objEmp As New Empleado

        objEmp = CrearXmlChecadas(lstEmp)
        DPrenom.InsertarModificacionesChecadas(cadenaConex, objEmp)
    End Sub
    Private Function CrearXmlChecadas(ByVal lstEmp As LEmpleado) As Empleado
        Dim objEmp As New Empleado()
        Dim i As Byte
        Dim str As String

        For i = 1 To lstEmp.Count - 1
            str = "<Info><clave>" & String.Format("{0:00000}", lstEmp.Item(i).IdEmpleado) &
                "</clave><fecha>" & Format(Convert.ToDateTime(lstEmp(i).Fecha1), "dd/MM/yyyy HH:mm:ss") &
                "</fecha><entrada>" & Format(Convert.ToDateTime(lstEmp(i).HoraEntrada), "yyyy/MM/dd HH:mm:ss") &
                "</entrada><salida>" & Format(Convert.ToDateTime(lstEmp(i).HoraSalida), "yyyy/MM/dd HH:mm:ss") &
                "</salida><entradaReal>" & Format(Convert.ToDateTime(lstEmp(i).Incidencia1), "dd/MM/yyyy HH:mm:ss") &
                "</entradaReal><salidaReal>" & Format(Convert.ToDateTime(lstEmp(i).Incidencia2), "dd/MM/yyyy HH:mm:ss") &
                "</salidaReal><turno>" & lstEmp(i).IdTurno & "</turno></Info>"
            objEmp.Xml = objEmp.Xml & str
        Next

        objEmp.Xml = "<Incidencias>" & objEmp.Xml & "</Incidencias>"
        Return objEmp
    End Function
    Public Function EmpleadoGlobalRecuperar(ByVal cadConex As String, ByVal fecha As Date) As LEmpleado
        Dim DEmp As New DEmpleado()
        Return DEmp.EmpleadoGlobalRecuperar(cadConex, fecha)
    End Function
    Public Function RecuperarMotivosRetardo(ByVal cadenaConex As String) As LHorarios
        Dim dPren As New DPrenomina()
        Return dPren.RecuperarMotivosRetardo(cadenaConex)
    End Function
    Public Sub InsertarMotivoRetardoChecadas(ByVal cadenaConex As String, ByVal emp As Empleado)
        Dim DPrenom As New DPrenomina()

        emp = CrearXmlMotivoRetardo(emp)
        DPrenom.InsertarMotivoRetardoChecadas(cadenaConex, emp)
    End Sub
    Private Function CrearXmlMotivoRetardo(ByVal emp As Empleado) As Empleado
        Dim objEmp As New Empleado()
        Dim str As String


        str = "<Info><clave>" & String.Format("{0:00000}", emp.IdEmpleado) &
                "</clave><fecha>" & Format(Convert.ToDateTime(emp.Fecha1), "dd/MM/yyyy HH:mm:ss") &
                "</fecha><nota>" & emp.Nota0 & "</nota><turno>" & emp.IdTurno & "</turno></Info>"
        objEmp.Xml = objEmp.Xml & str

        objEmp.Xml = "<Motivo>" & objEmp.Xml & "</Motivo>"
        Return objEmp
    End Function
End Class
'String.Format("{0:000}", valor)