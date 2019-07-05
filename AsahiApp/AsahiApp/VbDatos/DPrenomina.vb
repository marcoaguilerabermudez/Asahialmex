Imports Clases
Imports System.Data.SqlClient
Imports System
Public Class DPrenomina
    Public Function RecuperarDiasSemana(ByVal oCon As SqlConnection, ByVal fecha As Date) As Horarios
        Dim hrs As New Horarios()
        Try
            oCon.Open()
            Dim query As New SqlCommand("LRegresarFechas", oCon)
            query.Parameters.AddWithValue("@fecha", fecha)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                hrs.FechaI = Convert.ToDateTime(dr("fechaI").ToString)
                hrs.FechaF = Convert.ToDateTime(dr("fechaF").ToString)
                hrs.Semana = Convert.ToInt32(dr("semana").ToString)
                hrs.Año = Convert.ToInt32(dr("año").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return hrs
    End Function
    Public Function HorasChecadasSemanal() As Horarios
        Dim hrs As New Horarios()
        Return hrs
    End Function
    Public Function RecuperarAusentismo(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LAusentismo
        Dim oCon As New SqlConnection(cadConex)
        Dim lstAus As New LAusentismo()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Empaus.CLAVE /1 ID, Empaus.DURACION, Empaus.FECHAI, Empaus.FECHAF, Empaus.TIPO FROM asahi16.Supervisor_giro.Empaus Empaus WHERE (Empaus.FECHAI>= " + "'" + fechaI + "'" + ") and (Empaus.FECHAI<= " + "'" + fechaF + "'" + ")", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim aus As New Ausentismo
                aus.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                aus.Duracion = Convert.ToInt32(dr("DURACION").ToString)
                aus.FechaI = Convert.ToDateTime(dr("FECHAI").ToString)
                aus.FechaF = Convert.ToDateTime(dr("FECHAF").ToString)
                aus.TipoAusentismo = dr("TIPO").ToString
                lstAus.Add(aus)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstAus
    End Function
    Public Function RecuperarVacaciones(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LVacaciones
        Dim oCon As New SqlConnection(cadConex)
        Dim lstVac As New LVacaciones()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Empvaca.CLAVE/1 AS ID, Empvaca.FECHA, Empvaca.DURACION, Empvaca.FECHA_FINAL FROM asahi16.Supervisor_giro.Empvaca Empvaca WHERE (Empvaca.FECHA>= " + "'" + fechaI + "'" + ") and (Empvaca.FECHA<= " + "'" + fechaF + "'" + ")", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim vac As New Vacaciones
                vac.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                vac.Duracion = Convert.ToInt32(dr("DURACION").ToString)
                vac.FechaI = Convert.ToDateTime(dr("FECHA").ToString)
                vac.FechaF = Convert.ToDateTime(dr("FECHA_FINAL").ToString)
                lstVac.Add(vac)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstVac
    End Function
    Public Function RecuperarIncapacidades(ByVal cadConex As String) As LIncapacidad
        Dim oCon As New SqlConnection(cadConex)
        Dim lstInc As New LIncapacidad()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT CLAVE/1 ID,FECHA,ID NUM,DURACION,NUMERO,TIPO,CASO,FECHA_TERMINO FECHAF, isnull(SECUELA,'') SECUELA FROM asahi16.Supervisor_giro.Empinc ORDER BY CLAVE, FECHA DESC", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim inc As New Incapacidad()
                inc.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                inc.FechaI = Convert.ToDateTime(dr("FECHA").ToString)
                inc.Num = Convert.ToInt32(dr("NUM").ToString)
                inc.Duracion = Convert.ToInt32(dr("DURACION").ToString)
                inc.Numero = dr("NUMERO").ToString
                inc.Tipo = dr("TIPO").ToString
                inc.Caso = dr("CASO").ToString
                inc.FechaF = Convert.ToDateTime(dr("FECHAF").ToString)
                inc.Secuela = dr("SECUELA").ToString
                lstInc.Add(inc)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstInc
    End Function
    Public Function RecuperarHorasExtra(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LHorasExtra
        Dim oCon As New SqlConnection(cadConex)
        Dim lstHrsEx As New LHorasExtra()
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT EmpHE.CLAVE/1 ID, EmpHE.TIPO, EmpHE.MONTO, ISNULL(EmpHE.AUTORIZADO,'') AUTORIZADO, EmpHE.FECHA, ISNULL(EmpHE.TIPO_PERMISO,'') TIPOPERMISO FROM asahi16.Supervisor_giro.EmpHE EmpHE WHERE (EmpHE.FECHA>= " + "'" + fechaI + "'" + " and EmpHE.FECHA<= " + "'" + fechaF + "'" + ") ORDER BY TIPO, ID", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim hrsExt As New HorasExtra()
                hrsExt.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                hrsExt.Tipo = dr("TIPO").ToString
                hrsExt.Monto = Convert.ToInt32(dr("MONTO").ToString)
                hrsExt.Autorizado = Convert.ToInt32(dr("AUTORIZADO").ToString)
                hrsExt.Fecha = Convert.ToDateTime(dr("FECHA").ToString)
                hrsExt.TipoPermiso = dr("TIPOPERMISO").ToString
                lstHrsEx.Add(hrsExt)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstHrsEx
    End Function
    Public Function RecuperarBajas(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LBaja
        Dim lstBja As New LBaja()
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Empsdo.CLAVE/1 AS ID, Empsdo.FECHA, Empsdo.TIPO, Empsdo.CAUSA_BAJA CAUSABAJA FROM asahi16.Supervisor_giro.Empsdo Empsdo WHERE (Empsdo.FECHA>= " + "'" + fechaI + "'" + "  And Empsdo.FECHA<= " + "'" + fechaF + "'" + ") AND (Empsdo.TIPO='B') ORDER BY Empsdo.CLAVE", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim baja As New Baja()
                baja.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                baja.Fecha = Convert.ToDateTime(dr("FECHA").ToString)
                baja.TipoBaja = dr("TIPO").ToString
                baja.CausaBaja = dr("CAUSABAJA").ToString
                lstBja.Add(baja)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstBja
    End Function
    Public Function RecuperarComedor(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LComedor
        Dim lstCom As New LComedor()
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Empcome.CLAVE/1 ID, Empcome.FECHA, Empcome.HORA, ISNULL(Empcome.TIPO,'') TIPO FROM asahi16.Supervisor_giro.Empcome Empcome WHERE (Empcome.FECHA>= " + "'" + fechaI + "'" + " And Empcome.FECHA<= " + "'" + fechaF + "'" + ")", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim come As New Comedor()
                come.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                come.FechaComedor = Convert.ToDateTime(dr("FECHA").ToString)
                come.HoraComedor = Convert.ToDateTime(dr("HORA").ToString)
                come.TipoComida = Convert.ToInt32(dr("TIPO").ToString)
                lstCom.Add(come)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstCom
    End Function
    Public Function RecuperarChecadas(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LHorarios
        Dim lstHrs As New LHorarios()
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT (CLAVE/1) ID, FECHA, ISNULL(ENTRADA_REAL_P,'') EntradaReal, ISNULL(SALIDA_REAL_P,'') SalidaReal, ISNULL(ENTRADA_P,'') Entrada, ISNULL(SALIDA_P,'') Salida, ISNULL(TIPO_REG,'') TipoRegistro, ISNULL(NOTA,'') Nota, TURNO FROM asahi16.Supervisor_giro.EmpReloj WHERE FECHA >= '" + fechaI + "' and FECHA <= '" + fechaF + "'", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim hrs As New Horarios()
                hrs.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                hrs.Fecha = Convert.ToDateTime(dr("FECHA").ToString)
                hrs.HoraEntradaReal0 = Convert.ToDateTime(dr("EntradaReal").ToString)
                hrs.HoraSalidaReal0 = Convert.ToDateTime(dr("SalidaReal").ToString)
                hrs.HoraEntrada = Convert.ToDateTime(dr("Entrada").ToString)
                hrs.HoraSalida = Convert.ToDateTime(dr("Salida").ToString)
                hrs.TipoRegistro0 = dr("TipoRegistro").ToString
                hrs.Nota0 = dr("Nota").ToString
                hrs.IdTurno = Convert.ToInt32(dr("TURNO").ToString)
                lstHrs.Add(hrs)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstHrs
    End Function
    Public Function RecuperarTxtNominas(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LTxtNominas
        Dim oCon As New SqlConnection(cadConex)
        Dim lstTxtNom As New LTxtNominas()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Rh_RecuperarIncidenciasParaTxt", oCon)
            query.Parameters.AddWithValue("@fechai", fechaI)
            query.Parameters.AddWithValue("@fechaf", fechaF)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim txtNom As New TxtNominas
                txtNom.IdEmpleado = Convert.ToInt32(dr("ID").ToString)
                txtNom.Tipo = dr("TIPO").ToString
                txtNom.Monto = Convert.ToInt32(dr("MONTO").ToString)
                txtNom.Autorizado = Convert.ToInt32(dr("AUTORIZADO").ToString)
                txtNom.Fecha = Convert.ToDateTime(dr("FECHA").ToString)
                txtNom.Duracion = Convert.ToInt32(dr("DURACION").ToString)
                'txtNom.FechaI = Convert.ToDateTime(dr("FECHAI").ToString)
                txtNom.FechaF = Convert.ToDateTime(dr("FECHAF").ToString)
                txtNom.Tabla = Convert.ToInt32(dr("T").ToString)
                lstTxtNom.Add(txtNom)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstTxtNom
    End Function
    Public Function VerificarDiaHabil(ByVal cadConex As String, ByVal año As Integer, ByVal mes As Integer, ByVal dia As Integer, ByVal idEmp As Integer) As Integer
        Dim valor As Integer
        Dim oCon As New SqlConnection(cadConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("VerificarDiaHabil", oCon)
            query.Parameters.AddWithValue("@año", año)
            query.Parameters.AddWithValue("@mes", mes)
            query.Parameters.AddWithValue("@dia", dia)
            query.Parameters.AddWithValue("@idEmp", idEmp)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 60

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                valor = Convert.ToInt32(dr("valor").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return valor
    End Function
    Public Sub InsertarModificacionesIncidencias(ByVal cadenaConex As String, ByVal objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Insertar_Incidencias_Modificadas", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar() 'En un Insert de XML, NO olvidar esta línea si no, no inserta mi madres

            MsgBox("Registros insertados en temporal")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Function RecuperarInc(ByVal cadenaConex As String, ByVal tipoM As String, ByVal sem As Integer, ByVal fechaI As Date, ByVal fechaF As Date) As LEmpleado
        Dim LstEmp As New LEmpleado()
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            Dim empleados As New Empleado
            empleados.Err = True
            LstEmp.Add(empleados)
            oCon.Open()
            Dim query As New SqlCommand("select rim.IdEmpleado,rim.fecha,rim.fechaModif,rim.incidencia1,rim.incidencia2,rim.tipoModificacion1,rim.tipoModificacion2,rim.horaEntrada,rim.horaSalida,rim.turno from rh_incidencias_Modificadas rim where rim.tipoModificacion1 = '" & tipoM & "' and (rim.semana = " & sem & " and (rim.fecha >= '" & fechaI & "' and rim.fecha <= '" & fechaF & "'))", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim emp As New Empleado
                emp.IdEmpleado = Convert.ToInt32(dr("IdEmpleado").ToString)
                emp.Fecha1 = Convert.ToDateTime(dr("fecha").ToString)
                emp.Fecha2 = Convert.ToDateTime(dr("fechaModif").ToString)
                emp.Incidencia1 = dr("incidencia1").ToString
                emp.Incidencia2 = dr("incidencia2").ToString
                emp.TipoIncidencia1 = dr("tipoModificacion1").ToString
                emp.TipoIncidencia2 = dr("tipoModificacion2").ToString
                emp.HoraEntrada = Convert.ToDateTime(dr("horaEntrada").ToString)
                emp.HoraSalida = Convert.ToDateTime(dr("horaSalida").ToString)
                emp.IdTurno = Convert.ToInt32(dr("turno").ToString)
                emp.Err = False
                LstEmp.Add(emp)
                LstEmp.Item(0).Err = False
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
    Public Sub InsertarModificacionesAusentismo(ByVal cadenaConex As String, objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Incidencias_Ausentismo", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar() 'En un Insert de XML, NO olvidar esta línea si no, no inserta mi madres

            MsgBox("Ausentismos insertados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Sub InsertarModificacionesHE(ByVal cadenaConex As String, objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Incidencias_HE", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar() 'En un Insert de XML, NO olvidar esta línea si no, no inserta mi madres

            MsgBox("Incidencias insertadas")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Sub InsertarModificacionesChecadas(ByVal cadenaConex As String, ByVal objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Incidencias_Checadas", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

            MsgBox("Checadas insertadas")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Function RecuperarMotivosRetardo(ByVal cadenaConex As String) As LHorarios
        Dim lstHr As New LHorarios()
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("select idMotivo, motivo from Rh_MotivoRetardo", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim hr As New Horarios()
                hr.IdMotivoRetardo = dr("idMotivo").ToString
                hr.MotivoRetardo = dr("motivo").ToString
                lstHr.Add(hr)
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
    Public Sub InsertarMotivoRetardoChecadas(ByVal cadenaConex As String, ByVal objEmp As Empleado)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("rh_Motivo_Retardo_Checadas", oCon)
            query.Parameters.AddWithValue("@XML", objEmp.Xml)
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
    End Sub
    Public Function RecuperaAcumulado(ByVal cadenaConex As String, ByVal mes As String, ByVal año As Integer) As LBono
        Dim lstBono As New LBono()
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT CLAVE, ISNULL(" & mes & ",0) as " & mes & ", año from Supervisor_giro.Empacum where año = " & año & " order by CLAVE", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim bono As New Bono()
                bono.IdEmpleado = Convert.ToInt32(dr("CLAVE").ToString)
                bono.AcumulaMes = Convert.ToDouble(dr(mes).ToString)
                bono.Año = Convert.ToInt32(dr("año").ToString)
                lstBono.Add(bono)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstBono
    End Function
    Public Sub InsertarAcumulado(ByVal cadenaConex As String, ByVal objBono As Bono, ByVal mes As Integer)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Rh_InsertarAcumulado", oCon)
            query.Parameters.AddWithValue("@xml", objBono.XML)
            query.Parameters.AddWithValue("@mes", mes)
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
    End Sub
    Public Function VerificarUltimoMesCalculado(ByVal cadenaConex As String) As Integer
        Dim mes As Integer
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT top 1 Calculado from Supervisor_giro.Empacum order by Calculado desc", oCon)
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                mes = Convert.ToInt32(dr("Calculado").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return mes
    End Function
End Class