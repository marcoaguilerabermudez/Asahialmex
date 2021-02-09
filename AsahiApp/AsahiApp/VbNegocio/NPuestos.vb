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
    Public Function ObtenerLstResponsabilidades(ByVal cadenaconex As String, ByVal idDp As Integer, ByVal idPuesto As Integer, ByVal idDpto As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerLstResponsabilidades(cadenaconex, idDp, idPuesto, idDpto)
    End Function
    Public Function ObtenerLstIndicadores(ByVal cadenaconex As String, ByVal idDp As Integer, ByVal idPuesto As Integer, ByVal idDpto As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerLstIndicadores(cadenaconex, idDp, idPuesto, idDpto)
    End Function
    Public Function ObtenerLstCompetencias(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerLstCompetencias(cadenaconex, idDp)
    End Function
    Public Function ObtenerLstRelaciones(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerLstRelaciones(cadenaconex, idDp)
    End Function
    Public Function ObtenerLstPuestosExp(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerLstPuestosExp(cadenaconex, idDp)
    End Function
    Public Function ObtenerCatResponsabilidades(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerCatResponsabilidades(cadenaconex)
    End Function
    Public Function ObtenerFrecuencia(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerFrecuencia(cadenaconex)
    End Function
    Public Function ObtenerEntregables(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerEntregables(cadenaconex)
    End Function
    Public Function ObtenerCatIndicadores(ByVal cadenaconex As String)
        Dim DPues As New DPuestos

        Return DPues.ObtenerCatIndicadores(cadenaconex)
    End Function
    Public Function ObtenerCompetenciasTecnicas(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerCompetenciasTecnicas(cadenaconex)
    End Function
    Public Function ObtenerCompetenciasGrl(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerCompetenciasGrl(cadenaconex)
    End Function
    Public Function ObtenerCompetenciasMando(ByVal cadenaconex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerCompetenciasMando(cadenaconex)
    End Function
    Public Function ObtenerArea(ByVal cadenaConex As String) As LPuestos
        Dim DPues As New DPuestos

        Return DPues.ObtenerArea(cadenaConex)
    End Function
    Public Function InsertModifDP(ByVal cadenaConex As String, ByVal Puest As Puestos) As Puestos
        Dim DPues As New DPuestos()

        Puest = XmlInfoGrl(Puest)
        Return DPues.InsertModifDP(cadenaConex, Puest)
    End Function
    Public Function InsertModifEscolaridad(ByVal cadenaConex As String, ByVal lstPuest As LPuestos) As Puestos
        Dim pues As New Puestos()
        Dim DPues As New DPuestos()

        pues = XmlEscolaridad(lstPuest)
        Return DPues.InsertModifEscolaridad(cadenaConex, pues)
    End Function
    Public Function InsertModifPuestoExp(ByVal cadenaConex As String, ByVal lstPuest As LPuestos) As Puestos
        Dim pues As New Puestos()
        Dim DPues As New DPuestos()

        pues = XmlPuestoExp(lstPuest)
        Return DPues.InsertModifPuestoExp(cadenaConex, pues)
    End Function
    Public Function InsertModifObjetivo(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim DPues As New DPuestos()

        Return DPues.InsertModifObjetivo(cadenaConex, puest)
    End Function
    Public Function InsertModifAutoridad(ByVal cadenaConex As String, ByVal lstPuest As LPuestos) As Puestos
        Dim pues As New Puestos()
        Dim DPues As New DPuestos()

        pues = XmlAutoridad(lstPuest)
        Return DPues.InsertModifAutoridad(cadenaConex, pues)
    End Function
    Public Function InsertModifRelacionesPuesto(ByVal cadenaConex As String, ByVal lstPuest As LPuestos) As Puestos
        Dim pues As New Puestos()
        Dim DPues As New DPuestos()

        pues = XmlRelacionespuesto(lstPuest)
        Return DPues.InsertModifRelacionesPuesto(cadenaConex, pues)
    End Function
#Region "XML's"
    Private Function XmlInfoGrl(ByVal Pues As Puestos) As Puestos
        Dim str As String

        str = "<Info><id>" & Pues.IdDP & "</id><id_Puesto>" & Pues.IdPuesto & "</id_Puesto><nombre_Puesto>" & Pues.Puesto & "</nombre_Puesto><id_Dpto>" & Pues.IdDepto &
            "</id_Dpto><id_Area>" & Pues.IdArea & "</id_Area><id_Puesto_Reporta>" & Pues.IdPuestoReporta & "</id_Puesto_Reporta><tipo_Puesto>" & Pues.TipoPuesto &
            "</tipo_Puesto><sexo>" & Pues.Sexo & "</sexo><edad_Min>" & Pues.EdadMin & "</edad_Min><edad_Max>" & Pues.EdadMax & "</edad_Max><requiere_Exp>" & Pues.ReqExp &
            "</requiere_Exp><disp_Viajar>" & Pues.DispViajar & "</disp_Viajar><tipo_Viaje>" & Pues.TipoViaje & "</tipo_Viaje><justificacion>" & Pues.Justificacion &
            "</justificacion></Info>"
        Pues.Xml = Pues.Xml & str

        Pues.Xml = "<DP>" & Pues.Xml & "</DP>"
        Return pues
    End Function
    Private Function XmlEscolaridad(ByVal lstPues As LPuestos) As Puestos
        Dim pues As New Puestos()
        Dim i As Integer
        Dim str As String

        For i = 0 To lstPues.Count - 1
            str = "<Info><id_RE>" & lstPues.Item(i).IdRelacionEstudios & "</id_RE><id_Dp>" & lstPues.Item(i).IdDP & "</id_Dp><id_Escolaridad>" & lstPues.Item(i).IdEstudios &
                "</id_Escolaridad><activo>" & lstPues.Item(i).EdoEscolaridad & "</activo></Info>"
            pues.Xml = pues.Xml & str
        Next

        pues.Xml = "<Escolaridad>" & pues.Xml & "</Escolaridad>"
        Return Pues
    End Function
    Private Function XmlPuestoExp(ByVal lstPues As LPuestos) As Puestos
        Dim pues As New Puestos()
        Dim i As Integer
        Dim str As String

        For i = 0 To lstPues.Count - 1
            str = "<Info><id_PE>" & lstPues.Item(i).IdPuestoExp & "</id_PE><id_Dp>" & lstPues.Item(i).IdDP & "</id_Dp><puesto>" & lstPues.Item(i).PuestoExp &
                "</puesto><cantidad_Tiempo>" & lstPues.Item(i).CantidadTiempo & "</cantidad_Tiempo><tipo_Tiempo>" & lstPues.Item(i).TipoTiempo & "</tipo_Tiempo></Info>"
            pues.Xml = pues.Xml & str
        Next

        pues.Xml = "<PuestExp>" & pues.Xml & "</PuestExp>"
        Return pues
    End Function
    Private Function XmlAutoridad(ByVal lstPues As LPuestos) As Puestos
        Dim pues As New Puestos()
        Dim i As Integer
        Dim str As String

        For i = 0 To lstPues.Count - 1
            str = "<Info><id_Autor>" & lstPues.Item(i).IdAutoridad & "</id_Autor><id_Dp>" & lstPues.Item(i).IdDP & "</id_Dp><puestos_Reportan>" & lstPues.Item(i).PC_PuesRep &
                "</puestos_Reportan><ocupantes>" & lstPues.Item(i).PC_NOcup & "</ocupantes><funcion>" & lstPues.Item(i).PC_FuncPrinc & "</funcion></Info>"
            pues.Xml = pues.Xml & str
        Next

        pues.Xml = "<Autoridad>" & pues.Xml & "</Autoridad>"
        Return pues
    End Function
    Private Function XmlRelacionespuesto(ByVal lstPues As LPuestos) As Puestos
        Dim pues As New Puestos()
        Dim i As Integer
        Dim str As String

        For i = 0 To lstPues.Count - 1
            str = "<Info><id_Rp>" & lstPues.Item(i).IdRelacionPuesto & "</id_Rp><id_Dp>" & lstPues.Item(i).IdDP & "</id_Dp><id_Puesto>" & lstPues.Item(i).IdPuesto &
                "</id_Puesto><motivos>" & lstPues.Item(i).MotivoRelacion & "</motivos><tipo_Rel>" & lstPues.Item(i).TipoRelacion & "</tipo_Rel><contacto>" & lstPues.Item(i).Contacto &
                "</contacto></Info>"
            pues.Xml = pues.Xml & str
        Next

        pues.Xml = "<RelacionP>" & pues.Xml & "</RelacionP>"
        Return pues
    End Function
#End Region
End Class