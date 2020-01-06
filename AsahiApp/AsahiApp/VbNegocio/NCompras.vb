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
    Public Function RecuperarListaProveedores(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarListaProveedores(cadenaConex, fi, ff)
    End Function
    Public Function RecuperarListaFamilia(ByVal cadenaConex As String, ByVal uuid As String) As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarListaFamilia(cadenaConex, uuid)
    End Function
    Public Function RecuperarListaSegNeg(ByVal cadenaConex As String, ByVal uuid As String) As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarListaSegNeg(cadenaConex, uuid)
    End Function
    Public Function RecuperarLstPorProvicionar(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarLstPorProvicionar(cadenaConex, fi, ff)
    End Function
    Public Sub ActualizarXml(ByVal cadenaConex As String)
        Dim DComp As New DCompras
        DComp.ActualizarXml(cadenaConex)
    End Sub
End Class