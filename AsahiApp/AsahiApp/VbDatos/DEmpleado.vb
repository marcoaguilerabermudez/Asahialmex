Imports Clases
Imports System.Data.SqlClient
Public Class DEmpleado
    Public Function EmpleadosRecuperar(ByVal cadConex As String, ByVal fecha As Date, ByVal semana As Integer, ByVal año As Integer) As LEmpleado
        Dim oCon As New SqlConnection(cadConex)
        Dim lstEmp As New LEmpleado()
        Try
            oCon.Open()
            Dim query As New SqlCommand("LLInfoGralYChPrenomina", oCon)
            query.Parameters.AddWithValue("@fecha", fecha)
            query.Parameters.AddWithValue("@año", año)
            query.Parameters.AddWithValue("@semana", semana)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 480
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
                empleados.Nacional = Convert.ToBoolean(dr("AVISO").ToString)
                empleados.Puesto = dr("PUESTO").ToString
                empleados.HoraEntrada = Convert.ToDateTime(dr("Entrada").ToString)
                empleados.HoraSalida = Convert.ToDateTime(dr("Salida").ToString)
                'empleados.HoraEntradaReal0 = Convert.ToDateTime(dr("ERF0").ToString)
                'empleados.HoraSalidaReal0 = Convert.ToDateTime(dr("SRF0").ToString)
                empleados.TipoRegistro0 = dr("TRF0").ToString
                empleados.Nota0 = dr("NTF0").ToString
                empleados.HoraEntradaReal1 = Convert.ToDateTime(dr("ERF1").ToString)
                empleados.HoraSalidaReal1 = Convert.ToDateTime(dr("SRF1").ToString)
                empleados.TipoRegistro1 = dr("TRF1").ToString
                empleados.Nota1 = dr("NTF1").ToString
                empleados.HoraEntradaReal2 = Convert.ToDateTime(dr("ERF2").ToString)
                empleados.HoraSalidaReal2 = Convert.ToDateTime(dr("SRF2").ToString)
                empleados.TipoRegistro2 = dr("TRF2").ToString
                empleados.Nota2 = dr("NTF2").ToString
                empleados.HoraEntradaReal3 = Convert.ToDateTime(dr("ERF3").ToString)
                empleados.HoraSalidaReal3 = Convert.ToDateTime(dr("SRF3").ToString)
                empleados.TipoRegistro3 = dr("TRF3").ToString
                empleados.Nota3 = dr("NTF3").ToString
                empleados.HoraEntradaReal4 = Convert.ToDateTime(dr("ERF4").ToString)
                empleados.HoraSalidaReal4 = Convert.ToDateTime(dr("SRF4").ToString)
                empleados.TipoRegistro4 = dr("TRF4").ToString
                empleados.Nota4 = dr("NTF4").ToString
                empleados.HoraEntradaReal5 = Convert.ToDateTime(dr("ERF5").ToString)
                empleados.HoraSalidaReal5 = Convert.ToDateTime(dr("SRF5").ToString)
                empleados.TipoRegistro5 = dr("TRF5").ToString
                empleados.Nota5 = dr("NTF5").ToString
                empleados.HoraEntradaReal6 = Convert.ToDateTime(dr("ERF6").ToString)
                empleados.HoraSalidaReal6 = Convert.ToDateTime(dr("SRF6").ToString)
                empleados.TipoRegistro6 = dr("TRF6").ToString
                empleados.Nota6 = dr("NTF6").ToString
                empleados.HoraEntradaReal7 = Convert.ToDateTime(dr("ERF7").ToString)
                empleados.HoraSalidaReal7 = Convert.ToDateTime(dr("SRF7").ToString)
                empleados.TipoRegistro7 = dr("TRF7").ToString
                empleados.Nota7 = dr("NTF7").ToString
                empleados.Bono = Convert.ToBoolean(dr("Bono").ToString)
                empleados.Semana = Convert.ToInt32(dr("sem").ToString)
                empleados.Año = Convert.ToInt32(dr("año").ToString)
                empleados.ComenBono = dr("comen").ToString
                empleados.ComenBonoExt = dr("comenExt").ToString
                empleados.FechaIngreso = Convert.ToDateTime(dr("INGRESO").ToString)
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
    Public Function EmpleadoGlobalRecuperar(ByVal cadConex As String, ByVal fecha As Date, ByVal semana As Integer, ByVal año As Integer) As LEmpleado
        Dim lstEmp As New LEmpleado
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT ID,NOMBRE,APELLIDOP,APELLIDOM,isnull(VEB.TURNO,0) as TURNO,tur,DEPARTAMENTO, (SELECT TOP 1 P.DESCRIPCION from asahi16.Supervisor_giro.Emppues EPP LEFT JOIN asahi16.Supervisor_giro.Puesto P on EPP.CATALOGO = P.CLAVE WHERE VEB.ID = EPP.CLAVE ORDER BY EPP.CLAVE desc) as PUESTO,TP,EP.INGRESO as INGRESO,isnull(BAJA,'') as BAJA, ISNULL(BP.bono,0) AS BONO FROM Vista_InfoEmpleadosBasica VEB LEFT JOIN asahi16.Supervisor_giro.Empprin EP on VEB.ID = EP.CLAVE LEFT JOIN Bono_Puntualidad BP on VEB.ID = BP.empleado and BP.semana = " & semana & " and BP.año = " & año & " WHERE TP in ('A','R') or (TP = 'B' and BAJA > '" & Format(fecha, "dd/MM/yyyy") & "')", oCon)
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
                emp.Puesto = dr("PUESTO").ToString
                emp.TP = dr("TP").ToString
                emp.FechaIngreso = Convert.ToDateTime(dr("INGRESO").ToString)
                emp.FechaBaja = Convert.ToDateTime(dr("BAJA").ToString)
                emp.Bono = Convert.ToBoolean(dr("BONO").ToString)
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
    Public Function EmpleadoLogin(ByVal cadConex As String, ByVal us As String, ByVal pass As String) As Empleado
        Dim oCon As New SqlConnection(cadConex)
        Dim emp As New Empleado()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Usuario, Contraseña, ams.Clave, tipoUsuario, departamento, rh_permisos, evaluaciones_permisos, puesto FROM AsahiSystem.dbo.Usuarios_saam ams
join giro.[asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] vig on convert(int,vig.clave) = ams.clave
join [AsahiSystem].[dbo].[Req_permisos] per on per.Clave = vig.Clave
where usuario = '" & us & "'", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                emp.Usuario = dr("Usuario").ToString
                emp.Contraseña = dr("Contraseña").ToString
                emp.IdDepartamento = dr("departamento").ToString
                emp.IdEmpleado = Convert.ToInt32(dr("Clave").ToString)
                emp.TipoUsuario = Convert.ToInt32(dr("tipoUsuario").ToString)
                emp.rh_permiso = Convert.ToInt32(dr("rh_permisos").ToString)
                emp.rh_evaluacion = Convert.ToInt32(dr("evaluaciones_permisos").ToString)
                emp.Id_puesto = Convert.ToInt32(dr("puesto").ToString)
            End While
            If us = emp.Usuario Then
                If pass = emp.Contraseña Then
                    emp.Respuesta = 2
                Else
                    emp.Respuesta = 1
                End If
            Else
                emp.Respuesta = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return emp
    End Function
    Public Function EmpleadoLoginDominio(ByVal cadConex As String, ByVal noEmp As Integer, ByVal nomb As String) As Empleado
        Dim oCon As New SqlConnection(cadConex)
        Dim emp As New Empleado()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT top 1 (vig.Clave*1)Clave, tipoUsuario = CASE WHEN vig.DEPARTAMENTO = 19 THEN 1 WHEN vig.Clave = 5141 THEN 1 ELSE 0 END, departamento, rh_permisos, evaluaciones_permisos, puesto,
 Empleado = RTRIM(LTRIM(vig.NOMBREN)) + ' ' + RTRIM(LTRIM(vig.NOMBREP)) + ' ' + RTRIM(LTRIM(vig.NOMBREM)) , t_vales = u.Permiso_vales 
FROM  giro.[asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] vig
inner join [AsahiSystem].[dbo].[Req_permisos] per on per.Clave = vig.Clave
join [AsahiSystem].[dbo].[Usuarios_saam] u
on u.clave = vig.clave
where vig.Clave = " & noEmp, oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                emp.NombreCompleto = nomb
                emp.IdDepartamento = dr("departamento").ToString
                emp.IdEmpleado = Convert.ToInt32(dr("Clave").ToString)
                emp.TipoUsuario = Convert.ToInt32(dr("tipoUsuario").ToString)
                emp.rh_permiso = Convert.ToInt32(dr("rh_permisos").ToString)
                emp.rh_evaluacion = Convert.ToInt32(dr("evaluaciones_permisos").ToString)
                emp.Id_puesto = Convert.ToInt32(dr("puesto").ToString)
                emp.NombreCompletoGiro = dr("Empleado").ToString
                emp.IdPermisoV = Convert.ToInt32(dr("t_vales").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return emp
    End Function
    Public Function RecuperarDepartamentos(ByVal cadenaConex As String) As LEmpleado
        Dim lstDep As New LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT CLAVE, DESCRIPCION FROM asahi16.Supervisor_giro.DEPTO WHERE CENTRO_COSTO <> 16 and (Clave <> 02 and Clave <> 17 and Clave <> 44 and Clave <> 45) order by DESCRIPCION", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim Emp As New Empleado
                Emp.IdDepartamento = dr("CLAVE").ToString
                Emp.Departamento = dr("DESCRIPCION").ToString
                lstDep.Add(Emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstDep
    End Function
    Public Function RecuperarDepartamentosJP(ByVal cadenaConex As String) As LEmpleado
        Dim lstDep As New LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT CLAVE, DESCRIPCION FROM asahi16.dbo.DeptoJp WHERE CENTRO_COSTO <> 16 and (Clave <> 02 and Clave <> 17 and Clave <> 44 and Clave <> 45) order by DESCRIPCION", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim Emp As New Empleado
                Emp.IdDepartamento = dr("CLAVE").ToString
                Emp.Departamento = dr("DESCRIPCION").ToString
                lstDep.Add(Emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstDep
    End Function
    Public Function RecuperarEmpleadosDepto(ByVal cadenaConex As String, ByVal idDepto As Integer, ByVal fecha As Date, ByVal semana As Integer, ByVal año As Integer) As LEmpleado
        Dim lstEmp As New LEmpleado()
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("HE_RecuperarEmpleadosDepto", oCon)
            query.Parameters.AddWithValue("@idDepto", idDepto)
            query.Parameters.AddWithValue("@fecha", fecha)
            query.Parameters.AddWithValue("@semana", semana)
            query.Parameters.AddWithValue("@año", año)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                emp.Nombres = dr("NOMBRE").ToString
                emp.ApellidoPaterno = dr("APELLIDOP").ToString
                emp.ApellidoMaterno = dr("APELLIDOM").ToString
                emp.Departamento = dr("DEPARTAMENTO").ToString
                emp.SueldoBruto = Convert.ToDouble(dr("sueldoBruto").ToString)
                emp.SueldoNeto = Convert.ToDouble(dr("sueldoNeto").ToString)
                emp.IdTurno = Convert.ToInt32(dr("idTurno").ToString)
                emp.Lunes = Convert.ToDouble(dr("Lunes").ToString)
                emp.Martes = Convert.ToDouble(dr("Martes").ToString)
                emp.Miercoles = Convert.ToDouble(dr("Miercoles").ToString)
                emp.Jueves = Convert.ToDouble(dr("Jueves").ToString)
                emp.Viernes = Convert.ToDouble(dr("Viernes").ToString)
                emp.Sabado = Convert.ToDouble(dr("Sabado").ToString)
                emp.Domingo = Convert.ToDouble(dr("Domingo").ToString)
                emp.DomingoHrsEx = Convert.ToDouble(dr("DomingoHrsEx").ToString)
                emp.TotalDobles = Convert.ToDouble(dr("TDobles").ToString)
                emp.TotalTriples = Convert.ToDouble(dr("TTriples").ToString)
                emp.TotalDescLab = Convert.ToDouble(dr("TDescLaborado").ToString)
                emp.Bruto = Convert.ToDouble(dr("Bruto").ToString)
                emp.Neto = Convert.ToDouble(dr("Neto").ToString)
                lstEmp.Add(emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstEmp
    End Function
    Public Function RecuperarPermisosUsuario(ByVal cadenaConex As String, ByVal emp As Empleado) As LPermisos
        Dim lstPermiso As New LPermisos()
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select idEmpleado, ms.nombreModulo, rangoPermiso from Permisos_saam ps left join Modulos_saam ms on ps.idModulo = ms.idModulo where ps.idEmpleado = " & emp.IdEmpleado & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim per As New Permisos
                per.IdEmpleado = Convert.ToInt32(dr("idEmpleado").ToString)
                per.NombreModulo = dr("nombreModulo").ToString
                per.RangoPermiso = Convert.ToByte(dr("rangoPermiso").ToString)
                lstPermiso.Add(per)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstPermiso
    End Function
    Public Function RecuperarEmpleadosExportar(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LEmpleado
        Dim lstEmp As New LEmpleado()
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("ExportarEmpleados", oCon)
            query.Parameters.AddWithValue("@fechai", fi)
            query.Parameters.AddWithValue("@fechaf", ff)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                emp.Fecha1 = Convert.ToDateTime(dr("FECHAALTA").ToString)
                emp.ApellidoPaterno = dr("APELLIDOP").ToString
                emp.ApellidoMaterno = dr("APELLIDOM").ToString
                emp.Nombres = dr("NOMBRE").ToString
                emp.SueldoDiario = Convert.ToDouble(dr("SD").ToString)
                emp.SueldoBase = Convert.ToDouble(dr("SBC").ToString)
                emp.Departamento = dr("DEPARTAMENTO").ToString
                emp.EdoSindical = dr("SINDICALIZADO").ToString
                emp.Turno = dr("TURNO").ToString
                emp.Nss = dr("NSS").ToString
                emp.Rfc = dr("RFC").ToString
                emp.Curp = dr("Curp").ToString
                emp.Sexo = dr("SEXO").ToString
                emp.Ciudad = dr("CIUDAD").ToString
                emp.FechaNac = Convert.ToDateTime(dr("FECHANAC").ToString)
                emp.Padre = dr("PADRE").ToString
                emp.Madre = dr("MADRE").ToString
                emp.Domicilio = dr("DOMICILIO").ToString
                emp.Puesto = dr("PUESTO").ToString
                emp.Municipio = dr("MUNICIPIO").ToString
                emp.EntidadFed = dr("ENTFED").ToString
                emp.CodigoPostal = Convert.ToInt32(dr("CP").ToString)
                emp.EdoCivil = dr("EC").ToString
                emp.Telefono = dr("TEL").ToString
                emp.Extras = dr("CampExtNum5").ToString
                emp.EMail = dr("EMAIL").ToString
                emp.EntidadFedNac = dr("EntFedNac").ToString
                lstEmp.Add(emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstEmp
    End Function
    Public Function EmpleadosRecuperarSG(ByVal cadConex As String, ByVal objEmp As Empleado) As Empleado
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("RecuperarSegNegEmpleado", oCon)
            query.Parameters.AddWithValue("@idEmp", objEmp.IdEmpleado)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                objEmp.IdDepartamento = Convert.ToInt32(dr("SegNeg").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return objEmp
    End Function
    Public Function DptosRecuperar(ByVal cadenaConex As String, ByVal fecha As Date) As LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstDep As New LEmpleado()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select IEB.DEPARTAMENTO From asahi16.dbo.Vista_InfoEmpleadosBasica IEB where TP = 'A' or TP = 'R' or (TP='B' and (IEB.BAJA >= '" & fecha & "')) Group by DEPARTAMENTO", oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.Departamento = dr("DEPARTAMENTO").ToString
                lstDep.Add(emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstDep
    End Function
    Public Function HorariosRecuperar(ByVal cadenaConex As String) As LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstHr As New LEmpleado()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT 'MAÑANA 6:55 a 15:25' as Horario union SELECT 'TARDE 15:25 a 11:25' union SELECT 'NOCHE 11:25 a 7:00' union SELECT 'ADMINISTRATIVO 8:00 a 17:00' union SELECT 'MAZDA DIA 6:00 a 18:00' union SELECT 'MAZDA NOCHE 18:00 a 6:00' union SELECT 'DIA 7:00 a 19:00' union SELECT 'NOCHE 19:00 a 7:00'", oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.Horario = dr("Horario").ToString
                lstHr.Add(emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstHr
    End Function
    Public Function RevisarRangoPermisos(ByVal cadenaConex As String, ByVal idEmp As Integer, ByVal nModulo As String) As Integer
        Dim oCon As New SqlConnection(cadenaConex)
        Dim per As New Permisos()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT rangoPermiso FROM Permisos_saam ps left join Modulos_saam ms on ps.idModulo = ms.idModulo WHERE idEmpleado = " & idEmp & " and ms.nombreModulo = '" & nModulo & "'", oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                per.RangoPermiso = Convert.ToInt32(dr("rangoPermiso").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return per.RangoPermiso
    End Function
    Public Function RecuperarPuestos(ByVal cadenaConex As String) As LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LstEmp As New LEmpleado
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT RTRIM(CLAVE) CLAVE, RTRIM(DESCRIPCION) DESCRIPCION FROM asahi16.Supervisor_giro.Puesto", oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.idPuesto = Convert.ToInt32(dr("CLAVE").ToString)
                emp.Puesto = dr("DESCRIPCION").ToString
                LstEmp.Add(emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LstEmp
    End Function
    Public Function RecuperarPuestosRelaciones(ByVal cadenaConex As String) As LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LstEmp As New LEmpleado
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT RTRIM(CLAVE) CLAVE, RTRIM(DESCRIPCION) DESCRIPCION, 'a' DIST FROM asahi16.Supervisor_giro.Puesto union SELECT RTRIM(CLAVE) CLAVE, RTRIM(DESCRIPCION) DESCRIPCION,'b' FROM asahi16.Supervisor_giro.Depto Where centro_costo <> 16", oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.IdPuesto = Convert.ToInt32(dr("CLAVE").ToString)
                emp.Puesto = dr("DESCRIPCION").ToString
                emp.ConcatPuesto = dr("DIST").ToString + Convert.ToString(emp.IdPuesto)
                LstEmp.Add(emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LstEmp
    End Function
    Public Function RecuperarDepto(ByVal cadenaConex As String) As LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LstEmp As New LEmpleado
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT RTRIM(CLAVE) CLAVE, RTRIM(DESCRIPCION) DESCRIPCION FROM asahi16.Supervisor_giro.DEPTO WHERE CENTRO_COSTO <> 16", oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.IdDepartamento = Convert.ToInt32(dr("CLAVE").ToString)
                emp.Departamento = dr("DESCRIPCION").ToString
                LstEmp.Add(emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LstEmp
    End Function
    Public Function RecuperarArea(ByVal cadenaConex As String) As LEmpleado
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LstEmp As New LEmpleado
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT RTRIM(CLAVE) CLAVE, RTRIM(DESCRIPCION) DESCRIPCION FROM asahi16.Supervisor_giro.CENTROC WHERE CLAVE <> 16", oCon)
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado()
                emp.IdArea = Convert.ToInt32(dr("CLAVE").ToString)
                emp.Area = dr("DESCRIPCION").ToString
                LstEmp.Add(emp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LstEmp
    End Function
    Public Function AccesoJapo(ByVal cadenaConex As String, ByVal nombre As String) As Boolean
        Dim oCon As New SqlConnection(cadenaConex)
        Dim Resp As Boolean
        Try
            oCon.Open()
            Dim query As New SqlCommand("If exists(Select Acceso from AAMS_Acceso_Jap where Nombre like '" & nombre & "%') begin Select 1 as Acceso end Else begin Select 0 as Acceso end", oCon)
            query.CommandTimeout = 120
            Resp = query.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return Resp
    End Function
End Class