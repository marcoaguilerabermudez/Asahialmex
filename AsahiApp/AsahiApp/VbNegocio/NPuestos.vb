Imports Datos
Imports Clases
Public Class NPuestos
    Public Function ObtenerDpInfoGral(ByVal cadenaConex As String, Puesto As Puestos) As Puestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerDpInfoGral(cadenaConex, Puesto)
    End Function
    Public Function ObtenerListas(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerListas(cadenaconex, idDp)
    End Function
    Public Function ObtenerAutoridades(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerAutoridades(cadenaconex, idDp)
    End Function
    Public Function obtenerLstResponsabilidades(ByVal cadenaconex As String, ByVal idDp As Integer, ByVal idPuesto As Integer, ByVal idDpto As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.obtenerLstResponsabilidades(cadenaconex, idDp, idPuesto, idDpto)
    End Function
    Public Function obtenerLstIndicadores(ByVal cadenaconex As String, ByVal idDp As Integer, ByVal idPuesto As Integer, ByVal idDpto As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.obtenerLstIndicadores(cadenaconex, idDp, idPuesto, idDpto)
    End Function
    Public Function obtenerLstCompetencias(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.obtenerLstCompetencias(cadenaconex, idDp)
    End Function
    Public Function obtenerLstRelaciones(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.obtenerLstRelaciones(cadenaconex, idDp)
    End Function
    Public Function ObtenerCatResponsabilidades(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerCatResponsabilidades(cadenaconex)
    End Function
    Public Function ObtenerFrecuencia(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerFrecuencia(cadenaconex)
    End Function
    Public Function obtenerEntregables(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.obtenerEntregables(cadenaconex)
    End Function
    Public Function obtenerCatIndicadores(ByVal cadenaconex As String)
        Dim DPues As New DPuestos

        Return DPues.obtenerCatIndicadores(cadenaconex)
    End Function
    Public Function obtenerCompetenciasTecnicas(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.obtenerCompetenciasTecnicas(cadenaconex)
    End Function
    Public Function obtenerCompetenciasGrl(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.obtenerCompetenciasGrl(cadenaconex)
    End Function
    Public Function obtenerCompetenciasMando(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.obtenerCompetenciasMando(cadenaconex)
    End Function
End Class
