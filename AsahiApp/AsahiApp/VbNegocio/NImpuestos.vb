Imports Clases
Imports Datos
Imports System.Data.SqlClient
Public Class NImpuestos
    Public Function RecuperarIsr(ByVal cadenaConex As String, ByVal sueldo As Double) As Impuestos
        Dim DImp As New DImpuestos()
        Return DImp.RecuperarIsr(cadenaConex, sueldo)
    End Function
End Class
