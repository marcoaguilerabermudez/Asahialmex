Imports Clases
Imports Datos
Public Class NGastos
    Public Function RecuperarPlanGastos(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer) As LGastos
        Dim dGast As New DGastos()
        Return dGast.RecuperarPlanGastos(cadenaConex, mes, año)
    End Function
    Public Function RecuperarPlanVentas(ByVal cadenaConex As String, ByVal mes As Integer, ByVal año As Integer) As LGastos
        Dim dGast As New DGastos()
        Return dGast.RecuperarPlanVentas(cadenaConex, mes, año)
    End Function
End Class
