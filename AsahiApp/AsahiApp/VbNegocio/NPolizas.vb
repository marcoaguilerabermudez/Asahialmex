Imports Datos
Imports Clases
Public Class NPolizas
    Public Function RecuperarUltimoFolio(ByVal cadenaConex As String, ByVal fecha As Date) As Polizas
        Dim DPol As New DPolizas()
        Return DPol.RecuperarUltimoFolio(cadenaConex, fecha)
    End Function
End Class