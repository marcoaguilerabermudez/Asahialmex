Imports Clases
Imports System.Data.SqlClient
Public Class DPolizas
    Public Function RecuperarUltimoFolio(ByVal cadenaConex As String, ByVal fecha As Date) As Polizas
        Dim oCon As New SqlConnection(cadenaConex)
        Dim pol As New Polizas
        Try
            oCon.Open()
            Dim query As New SqlCommand("UltimoFolioPolizas", oCon)
            query.Parameters.AddWithValue("@fecha", fecha)
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
End Class
