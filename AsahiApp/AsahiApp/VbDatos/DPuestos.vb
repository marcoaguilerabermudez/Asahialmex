Imports Clases
Imports System.Data.SqlClient
Public Class DPuestos
    Public Function ObtenerDpInfoGral(ByVal cadenaConex As String, Puesto As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("AsahiSystem.dbo.Dp_RecuperarInfoGral", oCon)
            query.Parameters.AddWithValue("@idP", Puesto.IdPuesto)
            query.Parameters.AddWithValue("@idD", Puesto.IdDepto)
            query.Parameters.AddWithValue("@idA", Puesto.IdArea)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Puesto.IdDP = Convert.ToInt32(dr("Id").ToString)
                Puesto.IdPuestoReporta = Convert.ToInt32(dr("Id_Puesto_Reporta").ToString)
                Puesto.TipoPuesto = Convert.ToInt32(dr("Tipo_Puesto").ToString)
                Puesto.Sexo = Convert.ToInt32(dr("Sexo").ToString)
                Puesto.EdadMin = Convert.ToInt32(dr("Edad_Min").ToString)
                Puesto.EdadMax = Convert.ToInt32(dr("Edad_Max").ToString)
                Puesto.IdEstudios = Convert.ToInt32(dr("Id_Estudios").ToString)
                Puesto.ReqExp = Convert.ToBoolean(dr("Requiere_Exp").ToString)
                Puesto.DispViajar = Convert.ToBoolean(dr("Disp_Viajar").ToString)
                Puesto.TipoViaje = Convert.ToInt32(dr("Tipo_Viaje").ToString)
                Puesto.Justificacion = dr("Justificacion").ToString
                Puesto.ObjetivoPuestoGrl = dr("Objetivo_Puesto").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return Puesto
    End Function
    Public Function ObtenerListas(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT e.Id IdE, e.Id_Escolaridad, Activo, i.Id IdI, Id_Idioma, Nivel FROM Dp_Info_Gral g LEFT JOIN Dp_Relacion_Dp_Escolaridad e ON g.Id = e.Id_Dp LEFT JOIN Dp_Relacion_Dp_Idioma i ON g.Id = i.Id_Dp WHERE g.Id = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdRelacionEstudios = Convert.ToInt32(dr("IdE").ToString)
                pues.IdEstudios = Convert.ToInt32(dr("Id_Escolaridad").ToString)
                pues.IdRelacionIdioma = Convert.ToInt32(dr("IdI").ToString)
                pues.IdIdioma = Convert.ToInt32(dr("Id_Idioma").ToString)
                pues.Nivel = Convert.ToInt32(dr("Nivel").ToString)
                pues.EdoEscolaridad = Convert.ToBoolean(dr("Activo").ToString)
                lstPues.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPues
    End Function
    Public Function ObtenerAutoridades(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Id, Cantidad,Id_Puesto,Funcion FROM Dp_Autoridad WHERE Id_Dp = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdAutoridad = Convert.ToInt32(dr("Id").ToString)
                pues.PC_NOcup = Convert.ToInt32(dr("Cantidad").ToString)
                pues.PC_PuesRep = Convert.ToInt32(dr("Id_Puesto").ToString)
                pues.PC_FuncPrinc = dr("Funcion").ToString
                lstPues.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPues
    End Function
    Public Function ObtenerLstResponsabilidades(ByVal cadenaconex As String, ByVal idDp As Integer, ByVal idPuesto As Integer, ByVal idDpto As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT rcr.Id_Catalogo_Resp, rcr.Frecuencia, r.Id_Entregable, r.Id Id_Resp, rcr.Id Id_Rel_Cat_Res, rcr.Tipo FROM Dp_Responsabilidades r INNER JOIN Dp_Relacion_Catalogo_Resp rcr ON r.Id_Rel_Resp  = rcr.Id WHERE Id_Dp = " & idDp & " and rcr.Id_Puesto = " & idPuesto & " and Id_Depto = " & idDpto & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdCatalogoResp = Convert.ToInt32(dr("Id_Catalogo_Resp").ToString)
                pues.IdFrecuencia = Convert.ToInt32(dr("Frecuencia").ToString)
                pues.IdEntregable = Convert.ToInt32(dr("Id_Entregable").ToString)
                pues.IdResponsabilidades = Convert.ToInt32(dr("Id_Resp").ToString)
                pues.IdRelacionRespo = Convert.ToInt32(dr("Id_Rel_Cat_Res").ToString)
                pues.TipoRelacion = Convert.ToInt32(dr("Tipo"))
                lstPues.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPues
    End Function
    Public Function ObtenerLstIndicadores(ByVal cadenaconex As String, ByVal idDp As Integer, ByVal idPuesto As Integer, ByVal idDpto As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT i.Id IdIndica, i.Id_Relacion_Indicadores, rci.Id_Catalogo_Indicadores,i.Estandar, i.Formula, rci.Frecuencia, rci.Fuente, rci.Tipo FROM Dp_Indicadores i INNER JOIN Dp_Relacion_Catalogo_Indicadores rci ON i.Id_Relacion_Indicadores = rci.Id INNER JOIN Dp_Catalogo_Indicadores ci ON rci.Id_Catalogo_Indicadores = ci.Id WHERE Id_Dp = " & idDp & " and rci.Id_Puesto = " & idPuesto & " and Id_Dpto = " & idDpto & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdIndicadores = Convert.ToInt32(dr("IdIndica").ToString)
                pues.IdRelacionIndica = Convert.ToInt32(dr("Id_Relacion_Indicadores").ToString)
                pues.IdCatalogoIndica = Convert.ToInt32(dr("Id_Catalogo_Indicadores").ToString)
                pues.Estandar = dr("Estandar").ToString
                pues.Formula = dr("Formula").ToString
                pues.IdFrecuencia = Convert.ToInt32(dr("Frecuencia").ToString)
                pues.Fuente = dr("Fuente").ToString
                pues.TipoIndica = Convert.ToBoolean(dr("Tipo").ToString)
                lstPues.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPues
    End Function
    Public Function ObtenerLstCompetencias(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT c.Id IdCompe, ISNULL(cca.Id,0)IdTec, ISNULL(ccb.Id,0)IdGrl, ISNULL(ccc.Id,0)IdMando FROM Dp_Competencias c LEFT JOIN Dp_Catalogo_Competencias cca ON c.Id_Catalogo_Competencias = cca.Id and cca.Tipo = 1 LEFT JOIN Dp_Catalogo_Competencias ccb ON c.Id_Catalogo_Competencias = ccb.Id and ccb.Tipo = 2 LEFT JOIN Dp_Catalogo_Competencias ccc ON c.Id_Catalogo_Competencias = ccc.Id and ccc.Tipo = 3 WHERE c.Id_Dp = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdCompetencia = Convert.ToInt32(dr("IdCompe").ToString)
                pues.IdCompeTecnicas = Convert.ToInt32(dr("IdTec").ToString)
                pues.IdCompeGrl = Convert.ToInt32(dr("IdGrl").ToString)
                pues.IdCompePersoMando = Convert.ToInt32(dr("IdMando").ToString)
                lstPues.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPues
    End Function
    Public Function ObtenerLstRelaciones(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Id, ISNULL(Id_Puesto,0) Id_Puesto, ISNULL(Id_Dpto,0) Id_Dpto, ISNULL(Contacto,'') Contacto, Tipo, Motivos FROM Dp_Relaciones_Puesto WHERE Id_Dp = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdRelacionPuesto = Convert.ToInt32(dr("Id").ToString)
                pues.IdPuesto = Convert.ToInt32(dr("Id_Puesto").ToString)
                pues.IdDepto = Convert.ToInt32(dr("Id_Dpto").ToString)
                pues.Contacto = dr("Contacto").ToString
                pues.TipoRelacion = Convert.ToInt32(dr("Tipo").ToString)
                pues.MotivoRelacion = dr("Motivos").ToString
                lstPues.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPues
    End Function
    Public Function ObtenerLstPuestosExp(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Id, Puesto, cantidadTiempo, tipoTiempo FROM Dp_Puestos_Experiencia WHERE Id_Dp = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdPuestoExp = Convert.ToInt32(dr("Id").ToString)
                pues.PuestoExp = dr("Puesto").ToString
                pues.CantidadTiempo = Convert.ToInt32(dr("cantidadTiempo").ToString)
                pues.TipoTiempo = dr("tipoTiempo").ToString
                lstPues.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPues
    End Function
    Public Function ObtenerCatResponsabilidades(ByVal cadenaconex As String) As LPuestos
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Id, Descripcion from Dp_Catalogo_Responsabilidad order by Descripcion", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdResponsabilidades = Convert.ToInt32(dr("Id").ToString)
                pues.Responsabilidades = dr("Descripcion").ToString
                lstPuesto.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPuesto
    End Function
    Public Function ObtenerCatIndicadores(ByVal cadenaconex As String) As LPuestos
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Id, Nombre from Dp_Catalogo_Indicadores Order by Nombre", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdIndicadores = Convert.ToInt32(dr("Id").ToString)
                pues.Indicadores = dr("Nombre").ToString
                lstPuesto.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPuesto
    End Function
    Public Function ObtenerFrecuencia(ByVal cadenaconex As String) As LPuestos
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Id, Nombre from Dp_Frecuencia", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdFrecuencia = Convert.ToInt32(dr("Id").ToString)
                pues.Frecuencia = dr("Nombre").ToString
                lstPuesto.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPuesto
    End Function
    Public Function ObtenerEntregables(ByVal cadenaconex As String) As LPuestos
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Id, Descripcion from Dp_Catalogo_Entregables", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdEntregable = Convert.ToInt32(dr("Id").ToString)
                pues.Entregable = dr("Descripcion").ToString
                lstPuesto.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPuesto
    End Function
    Public Function ObtenerCompetenciasTecnicas(ByVal cadenaconex As String) As LPuestos
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Id, Descripcion FROM Dp_Catalogo_Competencias WHERE Tipo = 1", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdCompeTecnicas = Convert.ToInt32(dr("Id").ToString)
                pues.CompeTecnicas = dr("Descripcion").ToString
                lstPuesto.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPuesto
    End Function
    Public Function ObtenerCompetenciasGrl(ByVal cadenaconex As String) As LPuestos
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Id, Descripcion FROM Dp_Catalogo_Competencias WHERE Tipo = 2", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdCompeGrl = Convert.ToInt32(dr("Id").ToString)
                pues.CompeGrl = dr("Descripcion").ToString
                lstPuesto.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPuesto
    End Function
    Public Function ObtenerCompetenciasMando(ByVal cadenaconex As String) As LPuestos
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Id, Descripcion FROM Dp_Catalogo_Competencias WHERE Tipo = 3", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdCompePersoMando = Convert.ToInt32(dr("Id").ToString)
                pues.CompePersoMando = dr("Descripcion").ToString
                lstPuesto.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPuesto
    End Function
    Public Function ObtenerArea(ByVal cadenaConex As String) As LPuestos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LstPues As New LPuestos
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Id, Area FROM Dp_Areas", oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos()
                pues.IdArea = Convert.ToInt32(dr("Id").ToString)
                pues.Area = dr("Area").ToString
                LstPues.Add(pues)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LstPues
    End Function
    Public Function InsertModifDP(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaInfoGrl", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure

            'Ejecuto la consulta y obtengo el valor devuelto por la misma
            puest.IdDP = query.ExecuteScalar()
            MsgBox("DP " & puest.IdDP & " afectado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifEscolaridad(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaEscolaridad", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifIdioma(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaIdiomas", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifPuestoExp(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaPuestosExp", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifObjetivo(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaObjetivoPuesto", oCon)
            query.Parameters.AddWithValue("@IdDp", puest.IdDP)
            query.Parameters.AddWithValue("@Objetivo", puest.ObjetivoPuestoGrl)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifAutoridad(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaAutoridad", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifRelacionesPuesto(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaRelacionPuesto", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifRelacionResponsaDp(ByVal cadenaConex As String, ByVal puest As Puestos) As LPuestos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LPues As New LPuestos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaRelacionResponsaDp", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure

            'Ejecuto la consulta y obtengo el valor devuelto por la misma
            Dim dr As SqlDataReader
            'query.ExecuteScalar()
            dr = query.ExecuteReader()
            While (dr.Read)
                Dim pts As New Puestos()
                pts.IdRelacionRespo = Convert.ToInt32(dr("Id").ToString)
                pts.IdCatalogoResp = Convert.ToInt32(dr("Id_Catalogo_Resp").ToString)
                LPues.Add(pts)
            End While
            'MsgBox("DP " & puest.IdDP & "afectado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LPues
    End Function
    Public Function InsertModifResponsabilidades(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LPues As New LPuestos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaResponsabilidades", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifRelacionIndicadores(ByVal cadenaConex As String, ByVal puest As Puestos) As LPuestos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LPues As New LPuestos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaRelacionIndicadores", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure

            'Ejecuto la consulta y obtengo el valor devuelto por la misma
            Dim dr As SqlDataReader
            'query.ExecuteScalar()
            dr = query.ExecuteReader()
            While (dr.Read)
                Dim pts As New Puestos()
                pts.IdRelacionIndica = Convert.ToInt32(dr("Id").ToString)
                pts.IdCatalogoIndica = Convert.ToInt32(dr("Id_Catalogo_Indicadores").ToString)
                LPues.Add(pts)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LPues
    End Function
    Public Function InsertModifIndicadores(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LPues As New LPuestos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaIndicadores", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
    Public Function InsertModifCompetencias(ByVal cadenaConex As String, ByVal puest As Puestos) As Puestos
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LPues As New LPuestos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Dp_InsertaModificaCompetencias", oCon)
            query.Parameters.AddWithValue("@xml", puest.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return puest
    End Function
End Class
