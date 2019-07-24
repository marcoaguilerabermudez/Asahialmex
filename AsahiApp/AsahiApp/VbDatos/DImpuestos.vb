Imports Clases
Imports System.Data.SqlClient
Public Class DImpuestos
    Public Function RecuperarIsr(ByVal cadenaConex As String, ByVal sueldo As Double) As Impuestos
        Dim imp As New Impuestos
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("select top 1 LimiteInferior,CuotaFija,PorcentajeExcedente from RetencionISR where LimiteInferior < " & sueldo & " order by LimiteInferior desc", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                imp.LimiteInf = Convert.ToDouble(dr("LimiteInferior").ToString)
                imp.CuotaFija = Convert.ToDouble(dr("CuotaFija").ToString)
                imp.PorcentajeEx = Convert.ToString(dr("PorcentajeExcedente").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return imp
    End Function
End Class
