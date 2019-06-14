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
    Public Function EmpleadoGlobalRecuperar(ByVal cadConex As String, ByVal fecha As Date) As LEmpleado
        Dim lstEmp As New LEmpleado
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("select ID,NOMBRE,APELLIDOP,APELLIDOM,isnull(TURNO,0) as TURNO,tur,DEPARTAMENTO,TP,isnull(BAJA,'') as BAJA from Vista_InfoEmpleadosBasica where TP in ('A','R') or (TP = 'B' and BAJA >= '" & Format(fecha, "dd/MM/yyyy") & "')", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                emp.Nombres = dr("NOMBRE").ToString
                emp.ApellidoPaterno = dr("APELLIDOP").ToString
                emp.ApellidoMaterno = dr("APELLIDOM").ToString
                emp.IdTurno = Convert.ToInt32(dr("TURNO").ToString)
                emp.Turno = dr("tur").ToString
                emp.Departamento = dr("DEPARTAMENTO").ToString
                emp.TP = dr("TP").ToString
                emp.FechaBaja = Convert.ToDateTime(dr("BAJA").ToString)
                lstEmp.Add(emp)
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
    Public Function EmpleadoLogin(ByVal cadConex As String, ByVal us As String, ByVal pass As String) As Integer
        Dim oCon As New SqlConnection(cadConex)
        Dim res As Integer
        Dim emp As New Empleado
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Usuario, Contraseña FROM AsahiSystem.dbo.Usuarios_saam where usuario = '" & us & "'", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                emp.Usuario = dr("Usuario").ToString
                emp.Contraseña = dr("Contraseña").ToString
            End While
            If us = emp.Usuario Then
                If pass = emp.Contraseña Then
                    res = 2
                Else
                    res = 1
                End If
            Else
                res = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return res
    End Function
End Class