Imports Clases
Imports System.Data.SqlClient
Public Class DEmpleado
    Public Function EmpleadosRecuperar(ByVal cadConex As String, ByVal fecha As Date) As LEmpleado
        Dim oCon As New SqlConnection(cadConex)
        Dim lstEmp As New LEmpleado()
        Try
            oCon.Open()
            Dim query As New SqlCommand("asahi16.dbo.LLInfoGralYChPrenomina", oCon)
            query.Parameters.AddWithValue("@fecha", fecha)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim empleados As New Empleado()
                empleados.IdEmpleado = Convert.ToInt32(dr("Id").ToString)
                empleados.Nombres = dr("NOMBRE").ToString
                empleados.ApellidoPaterno = dr("APELLIDOP").ToString
                empleados.ApellidoMaterno = dr("APELLIDOM").ToString
                empleados.IdTurno = Convert.ToInt32(dr("TURNO").ToString)
                empleados.Turno = dr("tur").ToString
                empleados.Departamento = dr("DEPARTAMENTO").ToString
                empleados.TP = dr("TP").ToString
                empleados.FechaBaja = Convert.ToDateTime(dr("BAJA").ToString)
                empleados.HoraEntrada = Convert.ToDateTime(dr("Entrada").ToString)
                empleados.HoraSalida = Convert.ToDateTime(dr("Salida").ToString)
                empleados.HoraEntradaReal0 = Convert.ToDateTime(dr("ERF0").ToString)
                empleados.HoraSalidaReal0 = Convert.ToDateTime(dr("SRF0").ToString)
                empleados.TipoRegistro0 = dr("TRF0").ToString
                empleados.HoraEntradaReal1 = Convert.ToDateTime(dr("ERF1").ToString)
                empleados.HoraSalidaReal1 = Convert.ToDateTime(dr("SRF1").ToString)
                empleados.TipoRegistro1 = dr("TRF1").ToString
                empleados.HoraEntradaReal2 = Convert.ToDateTime(dr("ERF2").ToString)
                empleados.HoraSalidaReal2 = Convert.ToDateTime(dr("SRF2").ToString)
                empleados.TipoRegistro2 = dr("TRF2").ToString
                empleados.HoraEntradaReal3 = Convert.ToDateTime(dr("ERF3").ToString)
                empleados.HoraSalidaReal3 = Convert.ToDateTime(dr("SRF3").ToString)
                empleados.TipoRegistro3 = dr("TRF3").ToString
                empleados.HoraEntradaReal4 = Convert.ToDateTime(dr("ERF4").ToString)
                empleados.HoraSalidaReal4 = Convert.ToDateTime(dr("SRF4").ToString)
                empleados.TipoRegistro4 = dr("TRF4").ToString
                empleados.HoraEntradaReal5 = Convert.ToDateTime(dr("ERF5").ToString)
                empleados.HoraSalidaReal5 = Convert.ToDateTime(dr("SRF5").ToString)
                empleados.TipoRegistro5 = dr("TRF5").ToString
                empleados.HoraEntradaReal6 = Convert.ToDateTime(dr("ERF6").ToString)
                empleados.HoraSalidaReal6 = Convert.ToDateTime(dr("SRF6").ToString)
                empleados.TipoRegistro6 = dr("TRF6").ToString
                empleados.HoraEntradaReal7 = Convert.ToDateTime(dr("ERF7").ToString)
                empleados.HoraSalidaReal7 = Convert.ToDateTime(dr("SRF7").ToString)
                empleados.TipoRegistro7 = dr("TRF7").ToString
                empleados.HoraEntradaReal8 = Convert.ToDateTime(dr("ERF8").ToString)
                empleados.HoraSalidaReal8 = Convert.ToDateTime(dr("SRF8").ToString)
                empleados.TipoRegistro8 = dr("TRF8").ToString
                lstEmp.Add(empleados)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            Dim empleados As New Empleado
            empleados.Err = True
            lstEmp.Add(empleados)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstEmp
    End Function
End Class