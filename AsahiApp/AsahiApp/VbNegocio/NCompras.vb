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
    Public Function RecuperarLstPorProvisionar(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarLstPorProvisionar(cadenaConex, fi, ff)
    End Function
    Public Function RecuperarLstProvisionadas(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarLstProvisionadas(cadenaConex, fi, ff)
    End Function
    Public Sub ActualizarXml(ByVal cadenaConex As String)
        Dim DComp As New DCompras
        DComp.ActualizarXml(cadenaConex)
    End Sub
    Public Sub ProcesoProviciones(ByVal cadenaConex As String, ByVal comp As Compras)
        Dim DComp As New DCompras
        DComp.ProcesoProviciones(cadenaConex, comp)
    End Sub
    Public Sub InsertarRuta(ByVal cadenaConex As String, ByVal lstComp As LCompras)
        Dim comp As New Compras(), DComp As New DCompras()
        comp = CreaXmlRuta(lstComp)

        DComp.InsertarRuta(cadenaConex, comp)
    End Sub
    Private Function CreaXmlRuta(ByVal lstComp As LCompras) As Compras
        Dim comp As New Compras()
        Dim i As Byte
        Dim str As String

        For i = 0 To lstComp.Count - 1
            str = "<Info><IdProv>" & lstComp.Item(i).IdProvision & "</IdProv><Ruta>" & lstComp(i).Ruta & "</Ruta></Info>"
            comp.Xml = comp.Xml & str
        Next

        comp.Xml = "<Provisiones>" & comp.Xml & "</Provisiones>"
        Return comp
    End Function
End Class