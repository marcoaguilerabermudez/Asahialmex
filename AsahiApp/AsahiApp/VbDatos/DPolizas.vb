Imports Clases
Imports System.Data.SqlClient
Public Class DPolizas
    Public Function RecuperarUltimoFolio(ByVal cadenaConex As String, ByVal fecha As Date, Optional ByVal subsi As String = "") As Polizas
        Dim oCon As New SqlConnection(cadenaConex)
        Dim pol As New Polizas
        Try
            oCon.Open()
            Dim query As New SqlCommand("UltimoFolioPolizas", oCon)
            query.Parameters.AddWithValue("@fecha", fecha)
            query.Parameters.AddWithValue("@subsid", subsi)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                pol.FolioPoliza = Convert.ToInt32(dr("Folio").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return pol
    End Function
    Public Function RecuperarUltimoFolioEgresos(ByVal cadenaConex As String, Optional ByVal subsi As String = "") As Polizas
        Dim oCon As New SqlConnection(cadenaConex)
        Dim pol As New Polizas
        Dim querytxt As String = ""
        If subsi = "MEX" Then
            querytxt = "SELECT FolioActual FROM conta.ctAAM.dbo.Folios where Codigo = 48"
        ElseIf subsi = "SERV" Then
            querytxt = "SELECT FolioActual FROM conta.ctAAMS.dbo.Folios where Codigo = 48"
        End If
        Try
            oCon.Open()
            Dim query As New SqlCommand(querytxt, oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                pol.FolioPolizaEgreso = Convert.ToInt64(dr("FolioActual").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return pol
    End Function
End Class
