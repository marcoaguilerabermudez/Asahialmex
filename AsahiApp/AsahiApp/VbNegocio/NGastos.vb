Imports Clases
Imports Datos
Public Class NGastos
    Public Function RecuperarPlanGastos(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date) As LGastos
        Dim dGast As New DGastos()
        Return dGast.RecuperarPlanGastos(cadenaConex, mes, año, fi, ff)
    End Function
    Public Function RecuperarPlanGastosDpto(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer, ByVal fi As Date, ByVal ff As Date, ByVal clave As Integer) As LGastos
        Dim dGast As New DGastos()
        Return dGast.RecuperarPlanGastosDpto(cadenaConex, mes, año, fi, ff, clave)
    End Function
    Public Function RecuperarPlanVentas(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer) As LGastos
        Dim dGast As New DGastos()
        Return dGast.RecuperarPlanVentas(cadenaConex, mes, año)
    End Function
End Class