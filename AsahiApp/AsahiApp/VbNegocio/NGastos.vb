Imports Clases
Imports Datos
Public Class NGastos
    Public Function RecuperarPlanGastos(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date,
                                        ByVal idCtg As Integer, ByVal idioma As Integer) As LGastos
        Dim dGast As New DGastos()
        Return dGast.RecuperarPlanGastos(cadenaConex, mes, año, fi, ff, idCtg, idioma)
    End Function
    Public Function RecuperarPlanGastosDpto(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date,
                                        ByVal clave As Integer, ByVal idCtg As Integer, ByVal idioma As Integer) As LGastos
        Dim dGast As New DGastos()
        Return dGast.RecuperarPlanGastosDpto(cadenaConex, mes, año, fi, ff, clave, idCtg, idioma)
    End Function
    Public Function RecuperarPlanVentas(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date) As LGastos
        Dim dGast As New DGastos()
        Return dGast.RecuperarPlanVentas(cadenaConex, mes, año, fi, ff)
    End Function
    Public Function RecuperarPlanGastosAgrupado(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date,
                                        ByVal idioma As Integer, Optional ByVal sn As Integer = 0) As LGastos
        Dim dGast As New DGastos()
        If sn = 0 Then
            Return dGast.RecuperarPlanGastosAgrupado(cadenaConex, mes, año, fi, ff, idioma)
        Else
            Return dGast.RecuperarPlanGastosAgrupado(cadenaConex, mes, año, fi, ff, idioma, sn)
        End If
    End Function
    Public Function RecuperarSegNegocio(ByVal cadenaConex As String, ByVal idioma As Integer) As LEmpleado
        Dim dGast As New DGastos()
        Return dGast.RecuperarSegNegocio(cadenaConex, idioma)
    End Function
    Public Function RecuperarDetallesGastos(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date,
                                            ByVal cuenta As String, ByVal idioma As Integer, Optional ByVal sn As Integer = 0) As LGastos
        Dim dGast As New DGastos()
        If sn = 0 Then
            Return dGast.RecuperarDetallesGastos(cadenaConex, mes, año, fi, ff, cuenta, idioma)
        Else
            Return dGast.RecuperarDetallesGastos(cadenaConex, mes, año, fi, ff, cuenta, idioma, sn)
        End If
    End Function
    Public Function RecuperarCuentasGeneral(ByVal cadenaConex As String, ByVal idioma As Integer, ByVal mes As Integer, ByVal año As Integer,
                                            ByVal segNeg As Integer) As LGastos
        Dim DGast As New DGastos()
        Return DGast.RecuperarCuentasGeneral(cadenaConex, idioma, mes, año, segNeg)
    End Function
    Public Function RecuperarListaCtas(ByVal cadenaConex As String, ByVal cta As Integer, ByVal mes As Integer, ByVal año As Integer, ByVal segNeg As Integer,
                                       ByVal idioma As Integer) As LGastos
        Dim DGast As New DGastos()
        Return DGast.RecuperarListaCtas(cadenaConex, cta, mes, año, segNeg, idioma)
    End Function
    Public Sub InsertarPlan(ByVal cadenaConex As String, ByVal lstGst As LGastos)
        Dim objGst As New Gastos()
        Dim DGst As New DGastos()

        objGst = CreaXml(lstGst)
        DGst.InsertarPlan(cadenaConex, objGst)
    End Sub
    Private Function CreaXml(ByVal lstGst As LGastos) As Gastos
        Dim objGst As New Gastos()
        Dim i As Byte
        Dim str As String
        'Dim fi

        For i = 0 To lstGst.Count - 1
            'fi = lstGst.Item(i).FechaInsert
            str = "<Info><IdSis>" & lstGst.Item(i).IdSistema & "</IdSis><TipoMov>" & lstGst.Item(i).TipoMovimiento &
                "</TipoMov><CtaProd>" & lstGst.Item(i).Cuenta & "</CtaProd><SegNeg>" & lstGst.Item(i).SegmNegocio &
                "</SegNeg><Cant>" & lstGst.Item(i).CantCompra & "</Cant><CtoDls>" & lstGst.Item(i).MontoDls &
                "</CtoDls><CtoPesos>" & lstGst.Item(i).MontoPesos & "</CtoPesos><MonedaReal>" & lstGst.Item(i).Moneda &
                "</MonedaReal><Fecha>" & Format(lstGst.Item(i).FechaInsert, "dd/MM/yyyy") & "</Fecha><Mes>" & lstGst.Item(i).Mes &
                "</Mes><Año>" & lstGst.Item(i).Año & "</Año><Bloqueo>" & 0 & "</Bloqueo><Estado>" & 0 & "</Estado></Info>"
            objGst.Xml = objGst.Xml & str
        Next

        objGst.Xml = "<PlanG>" & objGst.Xml & "</PlanG>"
        Return objGst
    End Function
End Class