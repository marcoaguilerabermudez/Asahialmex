﻿Imports Clases
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
            Dim query As New SqlCommand("SELECT Id_Escolaridad, Id_Idioma, Nivel FROM Dp_Info_Gral g LEFT JOIN Dp_Relacion_Dp_Escolaridad e ON g.Id = e.Id_Dp LEFT JOIN Dp_Relacion_Dp_Idioma i ON g.Id = i.Id_Dp WHERE g.Id = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdEstudios = Convert.ToInt32(dr("Id_Escolaridad").ToString)
                pues.IdIdioma = Convert.ToInt32(dr("Id_Idioma").ToString)
                pues.Nivel = Convert.ToInt32(dr("Nivel").ToString)
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
            Dim query As New SqlCommand("SELECT Cantidad,Id_Puesto,Funcion FROM Dp_Autoridad WHERE Id_Dp = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
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
    Public Function obtenerLstResponsabilidades(ByVal cadenaconex As String, ByVal idDp As Integer, ByVal idPuesto As Integer, ByVal idDpto As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT r.Id_Catalogo_Resp, rcr.Frecuencia, r.Id_Entregable FROM Dp_Responsabilidades r INNER JOIN Dp_Catalogo_Responsabilidad cr ON r.Id = cr.Id INNER JOIN Dp_Relacion_Catalogo_Resp rcr ON cr.Id = rcr.Id_Catalogo_Resp WHERE Id_Dp = " & idDp & " and rcr.Id_Puesto = " & idPuesto & " and Id_Depto = " & idDpto & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdResponsabilidades = Convert.ToInt32(dr("Id_Catalogo_Resp").ToString)
                pues.IdFrecuencia = Convert.ToInt32(dr("Frecuencia").ToString)
                pues.IdEntregable = Convert.ToInt32(dr("Id_Entregable").ToString)
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
    Public Function obtenerLstIndicadores(ByVal cadenaconex As String, ByVal idDp As Integer, ByVal idPuesto As Integer, ByVal idDpto As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT i.Id_Catalogo_Indicadores, i.Estandar, i.Formula, rci.Frecuencia, rci.Fuente FROM Dp_Indicadores i INNER JOIN Dp_Catalogo_Indicadores ci ON i.Id = ci.Id INNER JOIN Dp_Relacion_Catalogo_Indicadores rci ON ci.Id = rci.Id_Catalogo_Indicadores WHERE Id_Dp = " & idDp & " and rci.Id_Puesto = " & idPuesto & " and Id_Dpto = " & idDpto & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdIndicadores = Convert.ToInt32(dr("Id_Catalogo_Indicadores").ToString)
                pues.Estandar = dr("Estandar").ToString
                pues.Formula = dr("Formula").ToString
                pues.IdFrecuencia = Convert.ToInt32(dr("Frecuencia").ToString)
                pues.Fuente = dr("Fuente").ToString
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
    Public Function obtenerLstCompetencias(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT ISNULL(cca.Id,0)IdTec, ISNULL(ccb.Id,0)IdGrl, ISNULL(ccc.Id,0)IdMando FROM Dp_Competencias c LEFT JOIN Dp_Catalogo_Competencias cca ON c.Id_Catalogo_Competencias = cca.Id and cca.Tipo = 1 LEFT JOIN Dp_Catalogo_Competencias ccb ON c.Id_Catalogo_Competencias = ccb.Id and ccb.Tipo = 2 LEFT JOIN Dp_Catalogo_Competencias ccc ON c.Id_Catalogo_Competencias = ccc.Id and ccc.Tipo = 3 WHERE c.Id_Dp = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
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
    Public Function obtenerLstRelaciones(ByVal cadenaconex As String, ByVal idDp As Integer) As LPuestos
        Dim lstPues As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT ISNULL(Id_Puesto,0) Id_Puesto, ISNULL(Contacto,'') Contacto, Tipo, Motivos FROM Dp_Relaciones_Puesto WHERE Id_Dp = " & idDp & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim pues As New Puestos
                pues.IdPuesto = Convert.ToInt32(dr("Id_Puesto").ToString)
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
    Public Function ObtenerCatResponsabilidades(ByVal cadenaconex As String) As LPuestos
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Id, Descripcion from Dp_Catalogo_Responsabilidad", oCon)
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
    Public Function obtenerCatIndicadores(ByVal cadenaconex As String)
        Dim lstPuesto As New LPuestos()
        Dim oCon As New SqlConnection(cadenaconex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Id, Nombre from Dp_Catalogo_Indicadores", oCon)
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
    Public Function obtenerEntregables(ByVal cadenaconex As String) As LPuestos
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
    Public Function obtenerCompetenciasTecnicas(ByVal cadenaconex As String) As LPuestos
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
    Public Function obtenerCompetenciasGrl(ByVal cadenaconex As String) As LPuestos
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
    Public Function obtenerCompetenciasMando(ByVal cadenaconex As String) As LPuestos
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
End Class
