Imports Datos
Imports Clases
Public Class NEmpleado
    Public Function EmpleadoLogin(ByVal cadConex As String, ByVal us As String, ByVal pass As String) As Empleado
        Dim DEmp As New DEmpleado()
        Return DEmp.EmpleadoLogin(cadConex, us, pass)
    End Function
    Public Function RecuperarDepartamentos(ByVal cadenaConex As String, ByVal idioma As Integer) As LEmpleado
        Dim DEmp As New DEmpleado()
        If idioma = 1 Then
            Return DEmp.RecuperarDepartamentos(cadenaConex)
        Else
            Return DEmp.RecuperarDepartamentosJP(cadenaConex)
        End If
    End Function
    Public Function RecuperarEmpleadosDepto(ByVal cadenaConex As String, ByVal idDepto As Integer, ByVal fecha As Date, ByVal semana As Integer, ByVal año As Integer) As LEmpleado
        Dim DEmp As New DEmpleado()
        Return DEmp.RecuperarEmpleadosDepto(cadenaConex, idDepto, fecha, semana, año)
    End Function
    Public Function RecuperarPermisosUsuario(ByVal cadenaConex As String, ByVal emp As Empleado) As LPermisos
        Dim DEmp As New DEmpleado()
        Return DEmp.RecuperarPermisosUsuario(cadenaConex, emp)
    End Function
    Public Function RecuperarEmpleadosExportar(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LEmpleado
        Dim DEmp As New DEmpleado()
        Return DEmp.RecuperarEmpleadosExportar(cadenaConex, fi, ff)
    End Function
    Public Function EmpleadosRecuperar(ByVal cadConex As String, ByVal objEmp As Empleado) As Empleado
        Dim DEmp As New DEmpleado()
        Return DEmp.EmpleadosRecuperarSG(cadConex, objEmp)
    End Function
    Public Function DptosRecuperar(ByVal cadenaConex As String, ByVal fecha As Date) As LEmpleado
        Dim DEmp As New DEmpleado()
        Return DEmp.DptosRecuperar(cadenaConex, fecha)
    End Function
    Public Function HorariosRecuperar(ByVal cadenaConex As String) As LEmpleado
        Dim DEmp As New DEmpleado()
        Return DEmp.HorariosRecuperar(cadenaConex)
    End Function
    Public Function RevisarRangoPermisos(ByVal cadenaConex As String, ByVal idEmp As Integer, ByVal nModulo As String) As Integer
        Dim DEmp As New DEmpleado()
        Return DEmp.RevisarRangoPermisos(cadenaConex, idEmp, nModulo)
    End Function
End Class
