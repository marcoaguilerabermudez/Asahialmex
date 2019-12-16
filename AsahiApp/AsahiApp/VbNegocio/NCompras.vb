Imports Clases
Imports Datos

Public Class NCompras
    Public Function RecuperarLstCompras(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarLstCompras(cadenaConex, fi, ff)
    End Function
    Public Function VistaPoliza(ByVal cadenaConex As String, ByVal moneda As String, ByVal idFac As String, ByVal tc As Double) As LCompras
        Dim DComp As New DCompras()
        Return DComp.VistaPoliza(cadenaConex, moneda, idFac, tc)
    End Function
End Class