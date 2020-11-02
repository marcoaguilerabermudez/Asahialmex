Imports Clases
Imports Datos

Public Class NCompras
    Public Function RecuperarLstCompras(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date, Optional ByVal subsi As String = "") As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarLstCompras(cadenaConex, fi, ff, subsi)
    End Function
    Public Function VistaPoliza(ByVal cadenaConex As String, ByVal moneda As String, ByVal idFac As String, ByVal tc As Double, Optional subsi As String = "") As LCompras
        Dim DComp As New DCompras()
        Return DComp.VistaPoliza(cadenaConex, moneda, idFac, tc, subsi)
    End Function
    Public Function PolizaVenta(ByVal cadenaConex As String, ByVal moneda As String, ByVal idFac As String, ByVal tc As Double) As LVentas
        Dim DComp As New DCompras()
        Return DComp.PolizaVenta(cadenaConex, moneda, idFac, tc)
    End Function
    Public Function RecuperarListaProveedores(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date, Optional subsi As String = "") As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarListaProveedores(cadenaConex, fi, ff, subsi)
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
    Public Function RecuperarProvValidadas(ByVal cadenaConex As String) As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarProvValidadas(cadenaConex)
    End Function
    Public Function FacturasRecuperarUUID(ByVal cadenaConex As String, ByVal factura As String) As LCompras
        Dim DComp As New DCompras()
        Return DComp.FacturasRecuperarUUID(cadenaConex, factura)
    End Function
    Public Function ConsultarImpuestosExtra(ByVal cadenaConex As String, ByVal uuid As String, Optional subsi As String = "") As LCompras
        Dim DComp As New DCompras()
        Return DComp.ConsultarImpuestosExtra(cadenaConex, uuid, subsi)
    End Function
    Public Function RecuperarEgreso(ByVal cadenaConex As String, ByVal moneda As String, ByVal idFac As String, Optional subsi As String = "") As LCompras
        Dim DComp As New DCompras()
        Return DComp.RecuperarEgreso(cadenaConex, moneda, idFac, subsi)
    End Function
    Public Function RecuperaCtasBancos(ByVal cadenaConex As String, Optional ByVal subsi As String = "") As LBancos
        Dim DComp As New DCompras()
        Return DComp.RecuperarBancos(cadenaConex, subsi)
    End Function
    Public Function RecuperarIdBanco(ByVal cadenaConex As String, ByVal codigo As String, Optional ByVal subsi As String = "") As Integer
        Dim DComp As New DCompras()
        Return DComp.RecuperarIdBanco(cadenaConex, codigo, subsi)
    End Function
    Public Function RecuperaCategorias(ByVal cadenaConex As String, ByVal moneda As Integer) As String
        Dim DComp As New DCompras()
        Return DComp.RecuperaCategorias(cadenaConex, moneda)
    End Function
    Public Function RecuperaSubCategorias(ByVal cadenaConex As String, ByVal lstCompras As LCompras, ByVal cta As String, ByVal segneg As String) As String
        Dim DComp As New DCompras()
        Select Case segneg
            Case 11 : segneg = 4
        End Select
        Return DComp.RecuperaSubCategorias(cadenaConex, lstCompras, cta, segneg)
    End Function
    Public Sub AgregarBitacora(ByVal cadenaConex As String, ByVal lstComp As LCompras)
        Dim DComp As New DCompras
        Dim comp As New Compras

        comp = CreaXMLBitacora(lstComp)
        DComp.AgregarBitacora(cadenaConex, comp)
    End Sub
    Public Function ConsultaBitacoraCreados(ByVal cadenaConex As String, ByVal comp As Compras) As Compras
        Dim DComp As New DCompras()
        Return DComp.ConsultaBitacoraCreados(cadenaConex, comp)
    End Function
    Public Sub EmpatarDocumentosContablesBitacora(ByVal cadenaConex As String, ByVal subsid As String)
        Dim DCompras As New DCompras()
        DCompras.EmpatarDocumentosContablesBitacora(cadenaConex, subsid)
    End Sub
    Public Function RecuperarLstVentas(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LVentas
        Dim DVen As New DCompras()
        Return DVen.RecuperarLstVentas(cadenaConex, fi, ff)
    End Function
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
    Private Function CreaXMLBitacora(ByVal lstComp As LCompras) As Compras
        Dim comp As New Compras()
        Dim i As Byte
        Dim str As String

        For i = 0 To lstComp.Count - 1
            With lstComp.Item(i)
                str = "<Info><idProv>" & .IdProvision & "</idProv><oc>" & .IdOrdenCompra & "</oc><monto>" & .MontoFact & "</monto><montoTxt>" & .MontoFact &
                    "</montoTxt><folioDocTxt>" & .FolioDocCont & "</folioDocTxt><docContMonto></docContMonto><fechaDocConta>" & .FechaFactura &
                    "</fechaDocConta><fechaCreaDoc></fechaCreaDoc><subsid>" & .Empresa & "</subsid><tipoDoc>" & .Tipo & "</tipoDoc></Info>"
            End With
            comp.Xml = comp.Xml & str
        Next
        comp.Xml = "<DocCont>" & comp.Xml & "</DocCont>"
        Return comp
    End Function
End Class