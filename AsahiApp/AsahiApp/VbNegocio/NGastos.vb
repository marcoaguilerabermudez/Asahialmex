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
    Public Function RecuperarCuentasGeneral(ByVal cadenaConex As String, ByVal idioma As Integer) As LGastos
        Dim DGast As New DGastos()
        Return DGast.RecuperarCuentasGeneral(cadenaConex, idioma)
    End Function
    Public Function RecuperarListaCtas(ByVal cadenaConex As String, ByVal cta As Integer) As LGastos
        Dim DGast As New DGastos()
        Return DGast.RecuperarListaCtas(cadenaConex, cta)
    End Function
End Class