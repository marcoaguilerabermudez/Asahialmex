Imports System.Data.SqlClient

Public Class Frm_cargaplanpersonal

    Dim a As String
    Dim b As String
    Dim x As String
    Dim y As String

    Dim semana As Integer
    Dim inicio As String
    Dim fin As String
    Dim variable As Integer


    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection

    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer


    Sub New(id As Integer, depto As String, permiso As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso

    End Sub


    Private Sub Frm_cargaplanpersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cnn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress
            Me.cnn2 = conexion.cadenagiro
        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cnn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor
            Me.cnn2 = conexion.cadenagirofor
        End If


        fechas()
        cbx_año.Text = Today.Year.ToString()
        l3.Text = Today.Month.ToString()
        a = l3.Text
        Select Case a
            Case "1"
                b = "ENERO      1 月"
            Case "2"
                b = "FEBRERO    2 月"
            Case "3"
                b = "MARZO      3 月"
            Case "4"
                b = "ABRIL      4 月"
            Case "5"
                b = "MAYO       5 月"
            Case "6"
                b = "JUNIO      6 月"
            Case "7"
                b = "JULIO      7 月"
            Case "8"
                b = "AGOSTO     8 月"
            Case "9"
                b = "SEPTIEMBRE 9 月"
            Case "10"
                b = "OCTUBRE   10 月"
            Case "11"
                b = "NOVIEMBRE 11 月"
            Case "12"
                b = "DICIEMBRE 12 月"
        End Select

        cbx_mes.Text = b
        llenacombodepto()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Enabled = True
        If permiso <> 3 Then
            Panel4.Enabled = False
        Else
            Panel4.Enabled = True
        End If
        a = cbx_mes.Text
        Select Case a
            Case "ENERO      1 月"
                b = 1
            Case "FEBRERO    2 月"
                b = 2
            Case "MARZO      3 月"
                b = 3
            Case "ABRIL      4 月"
                b = 4
            Case "MAYO       5 月"
                b = 5
            Case "JUNIO      6 月"
                b = 6
            Case "JULIO      7 月"
                b = 7
            Case "AGOSTO     8 月"
                b = 8
            Case "SEPTIEMBRE 9 月"
                b = 9
            Case "OCTUBRE   10 月"
                b = 10
            Case "NOVIEMBRE 11 月"
                b = 11
            Case "DICIEMBRE 12 月"
                b = 12
        End Select
        l3.Text = b

        Dim Frmespera As New Frmwait
        Frmespera.Show()
        Frmespera.BringToFront()
        Frmespera.WindowState = FormWindowState.Normal
        etiquetas()
        etiquetasmaster()
        etiquetas2()
        etiquetas3()
        Frmespera.Close()

        lbl_area.Text = cbx_depto.Text
        lbl_año.Text = cbx_año.Text
        lbl_mes.Text = cbx_mes.Text
        btn_horas.Enabled = True


    End Sub

    Private Sub cbx_depto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_depto.SelectedIndexChanged
        x = cbx_depto.Text
        Select Case x
            Case "ASEGURAMIENTO DE CALIDAD F1"
                y = 3
            Case "ASUNTOS GENERALES"
                y = 4
            Case "ATENCIÓN AL CLIENTE"
                y = 5
            Case "COMPRAS"
                y = 6
            Case "CONTABILIDAD"
                y = 7
            Case "CONTROL DE MANUFACTURA"
                y = 8
            Case "CONTROL DE PRODUCCION"
                y = 9
            Case "MOLDES"
                y = 16
            Case "SEGURIDAD"
                y = 18
            Case "SISTEMAS IT"
                y = 19
            Case "INGENIERÍA MAQUINADO"
                y = 27
            Case "INGENIERÍA FUNDICIÓN"
                y = 28
            Case "INSPECCION PRODUCCION"
                y = 31
            Case "FUNDICION 1"
                y = 32
            Case "FUNDICION 2"
                y = 33
            Case "ACABADO"
                y = 34
            Case "ACABADO 2"
                y = 35
            Case "CONTROL DE CLIENTES"
                y = 36
            Case "MANTENIMIENTO DE PLANTA"
                y = 37
            Case "MANTENIMIENTO FUNDICION"
                y = 38
            Case "MANTENIMIENTO MAQUINADO"
                y = 39
            Case "MAQUINADO F2"
                y = 40
            Case "INSPECCIÓN FUNDICION"
                y = 41
            Case "INSPECCIÓN MAQUINADO"
                y = 42
            Case "MAQUINADO F1"
                y = 43
            Case "FUSION"
                y = 44

        End Select


    End Sub


    Sub llenacombodepto()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand



        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	

SELECT 
      convert(varchar,[DESCRIPCION]) as 'DESCRIPCION'
    
  FROM [asahi16].[Supervisor_giro].[DEPTO]
  where CENTRO_COSTO not in (16) AND clave not in (17,46,47)

  union

  select 'XXX' as 'DESCRIPCION'
"
            .Connection = cnn2
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_depto
            .DataSource = Dt
            .DisplayMember = "DESCRIPCION"


        End With
    End Sub


    Sub etiquetas()
        Try
            ''  Dim Cnn As New SqlConnection("data source =GIRO\SQL2008 ;initial catalog=asahi16 ;user id=sa;password=Pa55word")
            cnn2.Close()
            cnn2.Open()
            Dim SSel As String
            Dim parametro1 As String
            parametro1 = cbx_depto.Text
            Dim parametro2 As Integer
            parametro2 = cbx_año.Text
            Dim parametro3 As Integer
            parametro3 = b
            SSel = (" 



select  rh.id_puesto , rh.cantidad , de.DESCRIPCION
     FROM [asahi16].[dbo].[Rh_totalpuestos] rh
	 join [asahi16].[Supervisor_giro].[DEPTO] de
	 on de.CLAVE = rh.Id_area
	 where de.DESCRIPCION = '" & parametro1 & "' and mes = " & parametro3 & " and año = " & parametro2 & " and id_tipo = 0
order by rh.id_puesto")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn2)
            da.Fill(ds)
            txt_gerente.Text = ds.Tables(0).Rows(0).Item(1)
            txt_asistente.Text = ds.Tables(0).Rows(1).Item(1)
            txt_supervisor.Text = ds.Tables(0).Rows(2).Item(1)
            txt_lad.Text = ds.Tables(0).Rows(3).Item(1)
            txt_staff.Text = ds.Tables(0).Rows(4).Item(1)
            txt_lid.Text = ds.Tables(0).Rows(5).Item(1)
            txt_operador.Text = ds.Tables(0).Rows(6).Item(1)
            txt_cor.Text = ds.Tables(0).Rows(7).Item(1)
            txt_tra.Text = ds.Tables(0).Rows(8).Item(1)
            cnn2.Close()

            c_p.Text = CInt(txt_gerente.Text) + CInt(txt_asistente.Text) + CInt(txt_supervisor.Text) + CInt(txt_lad.Text) + CInt(txt_staff.Text) + CInt(txt_lid.Text) + CInt(txt_operador.Text) + CInt(txt_cor.Text) + CInt(txt_tra.Text)

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un departamento válido.", "¡Aviso!")
            MessageBox.Show(ex.ToString)
            Panel1.Enabled = False
            Panel4.Enabled = False
            cnn2.Close()
        End Try
    End Sub


    Sub etiquetasmaster()
        Try
            ''  Dim Cnn As New SqlConnection("data source =GIRO\SQL2008 ;initial catalog=asahi16 ;user id=sa;password=Pa55word")
            cnn2.Close()
            cnn2.Open()
            Dim SSel As String
            Dim parametro1 As String
            parametro1 = cbx_depto.Text
            Dim parametro2 As Integer
            parametro2 = cbx_año.Text
            Dim parametro3 As Integer
            parametro3 = b
            SSel = (" 



select  rh.id_puesto , rh.masterplan , de.DESCRIPCION
     FROM [asahi16].[dbo].[Rh_totalpuestos] rh
	 join [asahi16].[Supervisor_giro].[DEPTO] de
	 on de.CLAVE = rh.Id_area
	 where de.DESCRIPCION = '" & parametro1 & "' and mes = " & parametro3 & " and año = " & parametro2 & " and id_tipo = 0
order by rh.id_puesto")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn2)
            da.Fill(ds)
            tm_gerente.Text = ds.Tables(0).Rows(0).Item(1)
            tm_asistente.Text = ds.Tables(0).Rows(1).Item(1)
            tm_super.Text = ds.Tables(0).Rows(2).Item(1)
            tm_lda.Text = ds.Tables(0).Rows(3).Item(1)
            tm_staff.Text = ds.Tables(0).Rows(4).Item(1)
            tm_lider.Text = ds.Tables(0).Rows(5).Item(1)
            tm_operador.Text = ds.Tables(0).Rows(6).Item(1)
            tm_coordinador.Text = ds.Tables(0).Rows(7).Item(1)
            tm_traductor.Text = ds.Tables(0).Rows(8).Item(1)
            cnn2.Close()

            c_m.Text = CInt(tm_gerente.Text) + CInt(tm_asistente.Text) + CInt(tm_super.Text) + CInt(tm_lda.Text) + CInt(tm_staff.Text) + CInt(tm_lider.Text) + CInt(tm_operador.Text) + CInt(tm_coordinador.Text) + CInt(tm_traductor.Text)

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un departamento válido.", "¡Aviso!")
            MessageBox.Show(ex.ToString)
            Panel1.Enabled = False
            Panel4.Enabled = False
            cnn2.Close()
        End Try
    End Sub


    Sub etiquetas2()
        '' MessageBox.Show(y)
        Try
            '' Dim Cnn As New SqlConnection("data source =GIRO\SQL2008 ;initial catalog=asahi16 ;user id=sa;password=Pa55word")
            cnn2.Close()
            cnn2.Open()
            Dim SSel As String
            Dim parametro1 As String
            parametro1 = cbx_depto.Text
            Dim parametro2 As Integer
            parametro2 = cbx_año.Text
            Dim parametro3 As Integer
            parametro3 = b
            SSel = ("  declare @depto as int
set @depto = " & y & "


select
 (select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 4 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 1 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 9 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 16 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 8 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 5 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 6 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 2 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 11 AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0 ) and VIGENCIA = 'VIGENTE') as 'M'
")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn2)
            da.Fill(ds)

            txt_gerente2.Text = ds.Tables(0).Rows(0).Item(0)
            txt_asistente2.Text = ds.Tables(0).Rows(0).Item(1)
            txt_supervisor2.Text = ds.Tables(0).Rows(0).Item(2)
            txt_lad2.Text = ds.Tables(0).Rows(0).Item(3)
            txt_staff2.Text = ds.Tables(0).Rows(0).Item(4)
            txt_lid2.Text = ds.Tables(0).Rows(0).Item(5)
            txt_operador2.Text = ds.Tables(0).Rows(0).Item(6)
            txt_cor2.Text = ds.Tables(0).Rows(0).Item(7)
            txt_tra2.Text = ds.Tables(0).Rows(0).Item(8)

            cnn2.Close()
            cr.Text = CInt(txt_gerente2.Text) + CInt(txt_asistente2.Text) + CInt(txt_supervisor2.Text) + CInt(txt_lad2.Text) + CInt(txt_staff2.Text) + CInt(txt_lid2.Text) + CInt(txt_operador2.Text) + CInt(txt_cor2.Text) + CInt(txt_tra2.Text)
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un departamento válido.", "¡Aviso!")
            cnn2.Close()
            MessageBox.Show(ex.ToString)
            Panel2.Enabled = False
        End Try
    End Sub


    Sub etiquetas3()
        txt_gerenteS.Text = Math.Abs(CInt(txt_gerente.Text - txt_gerente2.Text))
        txt_asiS.Text = Math.Abs(CInt(txt_asistente.Text - txt_asistente2.Text))
        txt_corS.Text = Math.Abs(CInt(txt_cor.Text - txt_cor2.Text))
        txt_traS.Text = Math.Abs(CInt(txt_tra.Text - txt_tra2.Text))
        txt_supS.Text = Math.Abs(CInt(txt_supervisor.Text - txt_supervisor2.Text))
        txt_StaffS.Text = Math.Abs(CInt(txt_staff.Text - txt_staff2.Text))
        txt_LiderAS.Text = Math.Abs(CInt(txt_lad.Text - txt_lad2.Text))
        txt_lidS.Text = Math.Abs(CInt(txt_lid.Text - txt_lid2.Text))
        txt_opeS.Text = Math.Abs(CInt(txt_operador.Text - txt_operador2.Text))




        If txt_asistente.Text - txt_asistente2.Text > 0 Then
            txt_asiS.BackColor = Color.LightGreen
        ElseIf txt_asistente.Text - txt_asistente2.Text < 0 Then
            txt_asiS.BackColor = Color.LightCoral
        ElseIf txt_asistente.Text - txt_asistente2.Text = 0 Then
            txt_asiS.BackColor = Color.White
        End If

        If txt_gerente.Text - txt_gerente2.Text > 0 Then
            txt_gerenteS.BackColor = Color.LightGreen
        ElseIf txt_gerente.Text - txt_gerente2.Text < 0 Then
            txt_gerenteS.BackColor = Color.LightCoral
        ElseIf txt_gerente.Text - txt_gerente2.Text = 0 Then
            txt_gerenteS.BackColor = Color.White
        End If

        If txt_cor.Text - txt_cor2.Text > 0 Then
            txt_corS.BackColor = Color.LightGreen
        ElseIf txt_cor.Text - txt_cor2.Text < 0 Then
            txt_corS.BackColor = Color.LightCoral
        ElseIf txt_cor.Text - txt_cor2.Text = 0 Then
            txt_corS.BackColor = Color.White
        End If

        If txt_tra.Text - txt_tra2.Text > 0 Then
            txt_traS.BackColor = Color.LightGreen
        ElseIf txt_tra.Text - txt_tra2.Text < 0 Then
            txt_traS.BackColor = Color.LightCoral
        ElseIf txt_tra.Text - txt_tra2.Text = 0 Then
            txt_traS.BackColor = Color.White
        End If

        If txt_supervisor.Text - txt_supervisor2.Text > 0 Then
            txt_supS.BackColor = Color.LightGreen
        ElseIf txt_supervisor.Text - txt_supervisor2.Text < 0 Then
            txt_supS.BackColor = Color.LightCoral
        ElseIf txt_supervisor.Text - txt_supervisor2.Text = 0 Then
            txt_supS.BackColor = Color.White
        End If


        If txt_staff.Text - txt_staff2.Text > 0 Then
            txt_StaffS.BackColor = Color.LightGreen
        ElseIf txt_staff.Text - txt_staff2.Text < 0 Then
            txt_StaffS.BackColor = Color.LightCoral
        ElseIf txt_staff.Text - txt_staff2.Text = 0 Then
            txt_StaffS.BackColor = Color.White
        End If


        If txt_lad.Text - txt_lad2.Text > 0 Then
            txt_LiderAS.BackColor = Color.LightGreen
        ElseIf txt_lad.Text - txt_lad2.Text < 0 Then
            txt_LiderAS.BackColor = Color.LightCoral
        ElseIf txt_lad.Text - txt_lad2.Text = 0 Then
            txt_LiderAS.BackColor = Color.White
        End If

        If txt_lid.Text - txt_lid2.Text > 0 Then
            txt_lidS.BackColor = Color.LightGreen
        ElseIf txt_lid.Text - txt_lid2.Text < 0 Then
            txt_lidS.BackColor = Color.LightCoral
        ElseIf txt_lid.Text - txt_lid2.Text = 0 Then
            txt_lidS.BackColor = Color.White
        End If

        If txt_operador.Text - txt_operador2.Text > 0 Then
            txt_opeS.BackColor = Color.LightGreen
        ElseIf txt_operador.Text - txt_operador2.Text < 0 Then
            txt_opeS.BackColor = Color.LightCoral
        ElseIf txt_operador.Text - txt_operador2.Text = 0 Then
            txt_opeS.BackColor = Color.White
        End If

    End Sub


    Sub fechas()

        semana = (DateDiff(DateInterval.WeekOfYear, New DateTime(Date.Now.Year, 1, 1), Date.Now) + 1)
        Dim fecha As Date = Today.ToShortDateString
        Dim pivote As Integer = Today.DayOfWeek

        Select Case pivote

            Case 1

                inicio = Format(Today.Date, "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 6, fecha), "dd/MM/yyyy")

            Case 2

                inicio = Format(DateAdd(DateInterval.Day, -1, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 5, fecha), "dd/MM/yyyy")

            Case 3

                inicio = Format(DateAdd(DateInterval.Day, -2, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 4, fecha), "dd/MM/yyyy")

            Case 4

                inicio = Format(DateAdd(DateInterval.Day, -3, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 3, fecha), "dd/MM/yyyy")

            Case 5

                inicio = Format(DateAdd(DateInterval.Day, -4, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 2, fecha), "dd/MM/yyyy")

            Case 6

                inicio = Format(DateAdd(DateInterval.Day, -5, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 1, fecha), "dd/MM/yyyy")

            Case 0

                inicio = Format(DateAdd(DateInterval.Day, -6, fecha), "dd/MM/yyyy")
                fin = Format(fecha, "dd/MM/yyyy")

        End Select

    End Sub




    Sub carga()
        Dim Pregunta As Integer

        If variable = 1 Then
            Pregunta = MsgBox("¿Desea guardar cambios en el Plan de Personal?", vbYesNo + vbExclamation + vbDefaultButton2, "Plan de Personal")
        ElseIf variable = 0 Then
            Pregunta = MsgBox("¿Desea guardar cambios en el Master Plan?", vbYesNo + vbExclamation + vbDefaultButton2, "Master Plan")
        End If

        If Pregunta = vbYes Then


            cnn2.Close()


            Dim command As New SqlCommand("Sp_actualizaplandepersonal", cnn2)
            cnn2.Open()

            command.CommandType = CommandType.StoredProcedure

            Try


                command.Parameters.Clear()

                If variable = 1 Then

                    command.Parameters.AddWithValue("@cantidad1", txt_gerente.Text)
                    command.Parameters.AddWithValue("@cantidad2", txt_asistente.Text)
                    command.Parameters.AddWithValue("@cantidad3", txt_supervisor.Text)
                    command.Parameters.AddWithValue("@cantidad4", txt_lad.Text)
                    command.Parameters.AddWithValue("@cantidad5", txt_staff.Text)
                    command.Parameters.AddWithValue("@cantidad6", txt_lid.Text)
                    command.Parameters.AddWithValue("@cantidad7", txt_operador.Text)
                    command.Parameters.AddWithValue("@cantidad8", txt_cor.Text)
                    command.Parameters.AddWithValue("@cantidad9", txt_tra.Text)
                    command.Parameters.AddWithValue("@año", lbl_año.Text)
                    command.Parameters.AddWithValue("@mes", l3.Text)
                    command.Parameters.AddWithValue("@catalogodepartamento", lbl_area.Text)
                    command.Parameters.AddWithValue("@variable", 1)

                ElseIf variable = 0 Then

                    command.Parameters.AddWithValue("@cantidad1", tm_gerente.Text)
                    command.Parameters.AddWithValue("@cantidad2", tm_asistente.Text)
                    command.Parameters.AddWithValue("@cantidad3", tm_super.Text)
                    command.Parameters.AddWithValue("@cantidad4", tm_lda.Text)
                    command.Parameters.AddWithValue("@cantidad5", tm_staff.Text)
                    command.Parameters.AddWithValue("@cantidad6", tm_lider.Text)
                    command.Parameters.AddWithValue("@cantidad7", tm_operador.Text)
                    command.Parameters.AddWithValue("@cantidad8", tm_coordinador.Text)
                    command.Parameters.AddWithValue("@cantidad9", tm_traductor.Text)
                    command.Parameters.AddWithValue("@año", lbl_año.Text)
                    command.Parameters.AddWithValue("@mes", l3.Text)
                    command.Parameters.AddWithValue("@catalogodepartamento", lbl_area.Text)
                    command.Parameters.AddWithValue("@variable", 0)


                End If


                command.ExecuteNonQuery()





                Dim Frmespera As New Frmwait
                Frmespera.Show()
                Frmespera.BringToFront()
                Frmespera.WindowState = FormWindowState.Normal

                ' etiquetas()
                'etiquetasmaster()
                etiquetas2()
                etiquetas3()
                Frmespera.Close()

                MsgBox("¡Cambios Guardados!", vbInformation, "¡Correcto!")
                cnn2.Close()



            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                MessageBox.Show("Registro no guardado, contacte al área de Sistemas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cnn2.Close()
            End Try



        ElseIf Pregunta = vbNo Then

            MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub




    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        variable = 1


        carga()

        c_p.Text = CInt(txt_gerente.Text) + CInt(txt_asistente.Text) + CInt(txt_supervisor.Text) + CInt(txt_lad.Text) + CInt(txt_staff.Text) + CInt(txt_lid.Text) + CInt(txt_operador.Text) + CInt(txt_cor.Text) + CInt(txt_tra.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'ContenedorReportePersonal2.semana = semana
        'ContenedorReportePersonal2.año = Today.Year
        'ContenedorReportePersonal2.variable = 0
        'ContenedorReportePersonal2.inicio = inicio
        'ContenedorReportePersonal2.fin = fin
        'ContenedorReportePersonal2.mes = Today.Month
        'ContenedorReportePersonal2.Show()

        ContenedorReportePlanPersonalTe.año = lbl_año.Text
        ContenedorReportePlanPersonalTe.mes = b
        ContenedorReportePlanPersonalTe.depto = lbl_area.Text
        ContenedorReportePlanPersonalTe.Show()

    End Sub

    Private Sub btn_modmaster_Click(sender As Object, e As EventArgs) Handles btn_modmaster.Click
        variable = 0
        carga()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_horas.Click
        Modulo_plante.mes = lbl_mes.Text
        Modulo_plante.año = lbl_año.Text
        Modulo_plante.departamento = lbl_area.Text

        Dim segundoForm As New PlanTE

        segundoForm.Show(Me)

    End Sub

End Class



Module Modulo_plante

    Public mes As String
    Public año As Integer
    Public departamento As String

End Module