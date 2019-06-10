Imports Datos
Imports Clases
Public Class NEmpleado
    Public Function EmpleadoLogin(ByVal cadConex As String, ByVal us As String, ByVal pass As String) As Integer
        Dim DEmp As New DEmpleado()
        Return DEmp.EmpleadoLogin(cadConex, us, pass)
    End Function
End Class
