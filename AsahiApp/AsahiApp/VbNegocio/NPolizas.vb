Imports Datos
Imports Clases
Public Class NPolizas
    Public Function RecuperarUltimoFolio(ByVal cadenaConex As String, ByVal fecha As Date, Optional ByVal subsi As String = "") As Polizas
        Dim DPol As New DPolizas()
        Return DPol.RecuperarUltimoFolio(cadenaConex, fecha, subsi)
    End Function
    Public Function RecuperarUltimoFolioEgresos(ByVal cadenaConex As String, Optional ByVal subsi As String = "") As Polizas
        Dim DPol As New DPolizas()
        Return DPol.RecuperarUltimoFolioEgresos(cadenaConex, subsi)
    End Function
End Class