Imports Clases
Imports Datos
Imports System.Data.SqlClient
Public Class NHorasExtra
    Public Function ObtenerSemanas(ByVal cadenaConex As String, ByVal año As Integer) As LHorasExtra
        Dim DHrsEx As New DHorasExtra
        Return DHrsEx.ObtenerSemanas(cadenaConex, año)
    End Function
    Public Function ObtenerFechasSemana(ByVal cadenaConex As String, ByVal año As Integer, ByVal semana As Integer) As HorasExtra
        Dim DHrsEx As New DHorasExtra
        Return DHrsEx.ObtenerFechasSemana(cadenaConex, año, semana)
    End Function
    Public Sub InsertarPlanHrsExtra(ByVal cadenaConex As String, ByVal lstHrsEx As LHorasExtra)
        Dim DHrsEx As New DHorasExtra(), objHrsEx As New HorasExtra()
        objHrsEx = CreaXmlInsertaPlan(lstHrsEx)
        DHrsEx.InsertarPlanHrsExtra(cadenaConex, objHrsEx)
    End Sub
    Private Function CreaXmlInsertaPlan(ByVal lstHrsEx As LHorasExtra) As HorasExtra
        Dim objHrsEx As New HorasExtra()
        Dim i As Byte
        Dim str As String

        For i = 0 To lstHrsEx.Count - 1
            str = "<Info><clave>" & lstHrsEx.Item(i).IdEmpleado & "</clave><lunes>" & lstHrsEx.Item(i).Lunes & "</lunes><martes>" & lstHrsEx.Item(i).Martes &
                "</martes><miercoles>" & lstHrsEx.Item(i).Miercoles & "</miercoles><jueves>" & lstHrsEx.Item(i).Jueves &
                "</jueves><viernes>" & lstHrsEx.Item(i).Viernes & "</viernes><sabado>" & lstHrsEx.Item(i).Sabado &
                "</sabado><domingo>" & lstHrsEx.Item(i).Domingo & "</domingo><semana>" & lstHrsEx.Item(i).Semana &
                "</semana><año>" & lstHrsEx.Item(i).Año & "</año><totalDobles>" & lstHrsEx.Item(i).TotalDobles &
                "</totalDobles><totalTriples>" & lstHrsEx.Item(i).TotalTriples & "</totalTriples><bruto>" & lstHrsEx.Item(i).Bruto &
                "</bruto><neto>" & lstHrsEx.Item(i).Neto & "</neto></Info>"
            objHrsEx.Xml = objHrsEx.Xml & str
        Next

        objHrsEx.Xml = "<Extras>" & objHrsEx.Xml & "</Extras>"
        Return objHrsEx
    End Function
    Public Function RecuperarAños(ByVal cadenaConex As String) As LHorarios
        Dim DHrsEx As New DHorasExtra
        Return DHrsEx.RecuperarAños(cadenaConex)
    End Function
    Public Function RecuperarTotalSemanas(ByVal cadConex As String, ByVal mes As Integer, ByVal año As Integer) As Integer
        Dim DHrsEx As New DHorasExtra
        Return DHrsEx.RecuperarTotalSemanas(cadConex, mes, año)
    End Function
End Class
