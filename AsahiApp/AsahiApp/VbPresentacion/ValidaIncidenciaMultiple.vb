Imports System.Data.SqlClient

Public Class ValidaIncidenciaMultiple
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Dim motivo As Integer
    Dim incidencia As String
    Dim retardo As Integer
    Dim fechaagregada As String
    Dim resultado As DateTime
    Dim extra As DateTime


    Private Sub txtIdPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_folio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub


    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            Cn.Close()
            Cn.Open()
            Dim SSel As String

            Dim parametro1 As Integer
            parametro1 = txt_folio.Text

            SSel = ("

  declare @fecha as date
  set @fecha = (SELECT DESDEF FROM [AsahiSystem].[dbo].[Rh_incidenciamultiple] WHERE Id_permisogoce = " & parametro1 & ")

 select INC.Id_permisogoce,  vig.CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
   ,descripcion_depto
,Turno = CASE (select TOP 1 ETT.CATALOGO  from GIRO.[asahi16].[Supervisor_giro].[Empturno] ETT
  where ett.clave = vig.CLAVE and ett.FECHA_ENTRADA <= @fecha
  order by ETT.FECHA_ENTRADA desc)/1 /*EM.TURNO*/
   when 1 then 'Matutino'
   when 2 then 'Vespertino'
   when 3 then 'Nocturno'
   when 4 then 'Administrativo'
   when 5 then 'Mazda día'
   when 6 then 'Mazda noche'
   when 7 then '12 M'
   when 8 then '12 N'
   when 9 then 'Descanso'
   else 'Error'
   end
   ,inc.DesdeF as 'Desde'
  
   ,case
   when inc.HastaF is null then '01/01/1900'
   else
   inc.HastaF
   end as 'Hasta'
   ,case
   when Motivo = 1 then 'Permiso con goce de sueldo'
   when Motivo = 2 then 'Permiso sin goce de sueldo'
   when Motivo = 3 then 'Falta o retardo injustificado y sin goce de sueldo'
   when Motivo = 4 then 'Falta o retardo JUSTIFICADO y con goce de sueldo (No solicitado anticipadamente)'
   when Motivo = 5 then 'Vacaciones'
   when Motivo = 6 then 'Registro en reloj checador'
   end
   ,case 
   when Incidencia = '0' and retardo = 0 then 'Paternidad'
   when Incidencia = '1' and retardo = 0 then 'Trámite de documento'
   when Incidencia = '2' and retardo = 0 then 'Asunto escolar'
   when Incidencia = '3' and retardo = 0 then 'Se quedó dormido'
   when Incidencia = '4' and retardo = 0 then 'Defunción familiar'
   when Incidencia = '5' and retardo = 0 then 'Salió de la ciudad'
   when Incidencia = '6' and retardo = 0 then 'No tenía ganas de trabajar'
   when Incidencia = '7' and retardo = 0 then 'Trámite de documento CG'
   when Incidencia = '8' and retardo = 0 then 'IMSS Trámites'
   when Incidencia = '9' and retardo = 0 then 'Asunto escolar'
   when Incidencia = 'A' and retardo = 0 then 'Abandono de trabajo'
   when Incidencia = 'B' and retardo = 0 then 'Prestación por matrimonio'
   when Incidencia = 'C' and retardo = 0 then 'Cita IMSS'
   when Incidencia = 'D' and retardo = 0 then 'Empleado vulnerable'
   when Incidencia = 'E' and retardo = 0 then 'Enfermedad'
   when Incidencia = 'F' and retardo = 0 then 'Falta injustificada'
   when Incidencia = 'G' and retardo = 0 then 'Permiso con goce'
   when Incidencia = 'H' and retardo = 0 then 'Home office'
   when Incidencia = 'J' and retardo = 0 then 'Confirmado'
   when Incidencia = 'K' and retardo = 0 then 'Consulta sospecha'
   when Incidencia = 'L' and retardo = 0 then 'Enfermedad leve'
   when Incidencia = 'M' and retardo = 0 then 'Enfermedad moderada'
   when Incidencia = 'N' and retardo = 0 then 'Suspención'
   when Incidencia = 'O' and retardo = 0 then 'Sospechoso enfermedad'
   when Incidencia = 'P' and retardo = 0 then 'Permiso sin goce'
   when Incidencia = 'R' and retardo = 0 then 'Familiar'
   when Incidencia = 'S' and retardo = 0 then 'Asuntos personales'
   when Incidencia = 'T' and retardo = 0 then 'Transporte'
   when Incidencia = 'U' and retardo = 0 then 'Falta justificada'
   when Incidencia = 'V' and retardo = 0 then 'Viaje'
   when Incidencia = 'W' and retardo = 0 then 'Asunto Personal'
   when Incidencia = 'X' and retardo = 0 then 'IMSS ENFERMEDAD'
   when Incidencia = 'Y' and retardo = 0 then 'DEFUNCION'
  when Incidencia = '1' and retardo = 1 then 'TRABAJAR TIEMPO EXTRA'
  when Incidencia = '10' and retardo = 1 then 'DEFUNCION FAMILIAR'
  when Incidencia = '11' and retardo = 1 then 'SALIO DE LA CIUDAD'
  when Incidencia = '12' and retardo = 1 then 'NO TENÍA GANAS DE TRABAJAR'
  when Incidencia = '13' and retardo = 1 then 'OTRO'
  when Incidencia = '14' and retardo = 1 then 'TRAMITE DE DOCUMENTO'
  when Incidencia = '15' and retardo = 1 then 'IMSS TRAMITES'
  when Incidencia = '16' and retardo = 1 then 'ASUNTO ESCOLAR'
  when Incidencia = '17' and retardo = 1 then 'ASUNTO PERSONAL'
  when Incidencia = '18' and retardo = 1 then 'IMSS ENFERMEDAD'
  when Incidencia = '19' and retardo = 1 then 'DEFUNCION'
  when Incidencia = '2' and retardo = 1 then 'SALIR TEMPRANO'
  when Incidencia = '20' and retardo = 1 then 'OTRO'
  when Incidencia = '4' and retardo = 1 then 'RETARDO POR TRANSPORTE'
  when Incidencia = '5' and retardo = 1 then 'LLEGAR TARDE'
  when Incidencia = '6' and retardo = 1 then 'EXTRA PENDIENTE'
  when Incidencia = '7' and retardo = 1 then 'SE QUEDO DORMIDO'
  when Incidencia = '8' and retardo = 1 then 'FAMILIAR ENFERMO'
  when Incidencia = '9' and retardo = 1 then 'ASUNTO PERSONAL'
   when Motivo = 5 then 'Vacaciones'
   WHEN Motivo = 6 THEN 'Checadas'
   END
  ,motivo,
  case
  when incidencia = 'CHE1' THEN 'Entrada'
  when incidencia = 'CHE2' THEN 'Salida'
  else
  incidencia
  end,retardo,
  
  case
  when desdeh is null then 0
  else
  CASE (select TOP 1 ETT.CATALOGO  from GIRO.[asahi16].[Supervisor_giro].[Empturno] ETT
  where ett.clave = vig.CLAVE and ett.FECHA_ENTRADA <= @fecha
  order by ETT.FECHA_ENTRADA desc)/1 /*EM.TURNO*/
   when 1 then datediff(minute,desdeh, hastah)
   when 2 then datediff(minute,desdeh, hastah)
   when 3 then datediff(minute,desdeh, hastah)
   when 4 then datediff(minute,desdeh, hastah)
   else 'Error'
   end
   end
 ,case
  when convert(varchar,desdeh) is null then '00:00:00'
  else
dateadd(year,100,convert(datetime,desdeh))
  end
  ,case
  when convert(varchar,HastaH) is null then '00:00:00'
  else
dateadd(year,100,convert(datetime,HastaH))
  end
  ,dateadd(day,1,inc.DesdeF)
  


   
from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig
join [AsahiSystem].[dbo].[Rh_incidenciamultiple] inc
on inc.Clave = vig.clave
where vig.vigencia = 'VIGENTE' AND INC.Id_permisogoce = " & parametro1 & " and validado = 0")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, Cn)
            da.Fill(ds)

            lbl_clave.Text = ds.Tables(0).Rows(0).Item(1)
            lbl_nombre.Text = ds.Tables(0).Rows(0).Item(2)
            lbl_depto.Text = ds.Tables(0).Rows(0).Item(3)
            lbl_turno.Text = ds.Tables(0).Rows(0).Item(4)
            lbl_desde.Value = ds.Tables(0).Rows(0).Item(5)

            lbl_hasta.Value = ds.Tables(0).Rows(0).Item(6)
            lbl_tipop.Text = ds.Tables(0).Rows(0).Item(7)
            lbl_motivop.Text = ds.Tables(0).Rows(0).Item(8)
            motivo = ds.Tables(0).Rows(0).Item(9)
            incidencia = ds.Tables(0).Rows(0).Item(10)
            lbl_ES.Text = ds.Tables(0).Rows(0).Item(10)
            retardo = ds.Tables(0).Rows(0).Item(11)
            txt_retardo.Text = ds.Tables(0).Rows(0).Item(12)
            If incidencia = "Entrada" Then
                dtp1.Value = ds.Tables(0).Rows(0).Item(13)
            ElseIf incidencia = "Salida" Then
                dtp1.Value = ds.Tables(0).Rows(0).Item(14)
            End If
            fechaagregada = ds.Tables(0).Rows(0).Item(15)

            Cn.Close()
            Btn_autorizar.Enabled = True
            Empleado.Visible = True
            gbx_inicidencia.Visible = True

        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("El folio de incidencia que eligió no es correcto o ya ha sido validado. Verifique e intente de nuevo.", "¡Aviso!")
            Btn_autorizar.Enabled = False
            Empleado.Visible = False
            gbx_inicidencia.Visible = False



        End Try





    End Sub



    Sub mostrarocultarcontroles()
        If motivo = 1 OrElse motivo = 2 Then
            lbl_hasta.Visible = True
            lbl_desde.Visible = True
            Label5.Visible = True
            Label7.Visible = True
            lbl_ES.Visible = False
            dtp1.Visible = False
            Label2.Visible = False
            Label6.Visible = False
            txt_retardo.Visible = False
            lbl_tipo.Visible = False
            dtgvi.Visible = True
            lbl_hora.Visible = False
            Label9.Visible = False

        ElseIf (motivo = 3 OrElse motivo = 4) And retardo = 0 Then
            lbl_hasta.Visible = True
            lbl_desde.Visible = True
            Label5.Visible = True
            Label7.Visible = True
            lbl_ES.Visible = False
            dtp1.Visible = False
            Label2.Visible = False
            Label6.Visible = False
            txt_retardo.Visible = False
            lbl_tipo.Text = "FALTA"
            dtgvi.Visible = True
            lbl_hora.Visible = False
            Label9.Visible = False

        ElseIf (motivo = 3 OrElse motivo = 4) And retardo = 1 Then
            lbl_desde.Visible = True
            Label5.Visible = True
            Label2.Visible = True
            Label6.Visible = True
            txt_retardo.Visible = True
            lbl_hasta.Visible = False
            Label7.Visible = False
            lbl_ES.Visible = False
            dtp1.Visible = False
            lbl_tipo.Text = "RETARDO"
            dtgvi.Visible = True
            ' muestrahoraretardo()
            'lbl_hora.Visible = True
            'Label9.Visible = True
        ElseIf motivo = 5 Then
            lbl_hasta.Visible = True
            lbl_desde.Visible = True
            Label5.Visible = True
            Label7.Visible = True
            lbl_ES.Visible = False
            dtp1.Visible = False
            Label2.Visible = False
            Label6.Visible = False
            txt_retardo.Visible = False
            lbl_tipo.Visible = False
            dtgvi.Visible = True
            lbl_hora.Visible = False
            Label9.Visible = False
        ElseIf motivo = 6 Then

            lbl_desde.Visible = True
            Label5.Visible = True
            lbl_ES.Visible = True
            dtp1.Visible = True
            Label2.Visible = False
            Label6.Visible = False
            txt_retardo.Visible = False
            lbl_tipo.Visible = False
            dtgvi.Visible = False
            lbl_hasta.Visible = False
            Label7.Visible = False
            lbl_hora.Visible = False
            Label9.Visible = False




        End If



    End Sub


    Sub muestrahoraretardo()
        'Dim f1 As DateTime = lbl_desde.Value
        'Dim f2 As TimeSpan = fechaagregada
        'Dim fm As String = "01/01/2020 06:55:00"
        'Dim fv As String = "01/01/2020 15:25:00"
        'Dim fn As String = "01/01/2020 23:25:00"
        'Dim fa As String = "01/01/2020 08:00:00"
        'Dim f0 As String = "01/01/2020 00:00:01"


        'Try
        '    If lbl_turno.Text = "Administrativo" Then
        '        resultado = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f1, fa))

        '        extra = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f2, f0))



        '    ElseIf lbl_turno.Text = "Matutino" Then
        '        resultado = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f1, fm))
        '        extra = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f2, f0))

        '    ElseIf lbl_turno.Text = "Nocturno" Then
        '        resultado = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f1, fn))
        '        extra = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f2, f0))

        '    ElseIf lbl_turno.Text = "Vespertino" Then
        '        resultado = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f1, fv))
        '        extra = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f2, f0))
        '    End If



        '    ''MessageBox.Show(lbl_clave.Text)
        '    'MessageBox.Show(resultado)
        '    'MessageBox.Show(extra)





        '    Cn.Close()
        '    Cn.Open()
        '    Dim SSel As String

        '    Dim parametro1 As String
        '    parametro1 = lbl_turno.Text




        '    Dim parametro4 As String
        '    parametro4 = lbl_clave.Text


        '    SSel = ("


        '             declare @turno as varchar(20)
        '         set @turno = '" & parametro1 & "'

        '         declare @fecha as varchar(50)
        '         set @fecha = '" & resultado.ToString & "'

        '         declare @fechan as varchar(50)
        '         set @fechan = '" & extra.ToString & "'

        '         declare @clave as varchar(10)
        '         set @clave = '" & parametro4 & "'


        '         if @turno = 'Nocturno'
        '         begin

        '         select top 1 convert(time,fecha)
        '        ,DATEDIFF(MINUTE,@fecha,fecha) + DATEDIFF(MINUTE,@fechan,fecha) 
        '         from 
        '         giro.[giro].[Supervisor_giro].[BitacoraRegistros]
        '         where fecha > @fecha and @clave = SUBSTRING (clave , 2, 5)
        '         end

        '         else if @turno = 'Matutino'
        '         begin
        '           select top 1 convert(time,fecha)
        '         ,DATEDIFF(MINUTE,@fecha,fecha) 
        '         from
        '         giro.[giro].[Supervisor_giro].[BitacoraRegistros]
        '         where fecha > @fecha and @clave = SUBSTRING (clave , 2, 5)
        '         end

        '          else if @turno = 'Vespertino'
        '         begin
        '           select top 1 convert(time,fecha)
        '        ,DATEDIFF(MINUTE,@fecha,fecha) 
        '         from
        '         giro.[giro].[Supervisor_giro].[BitacoraRegistros]
        '         where fecha > @fecha and @clave = SUBSTRING (clave , 2, 5)
        '         end

        '             else if @turno = 'Administrativo'
        '         begin
        '           select top 1 convert(time,fecha)
        '        ,DATEDIFF(MINUTE,@fecha,fecha) 
        '         from
        '         giro.[giro].[Supervisor_giro].[BitacoraRegistros]
        '         where fecha > @fecha and @clave = SUBSTRING (clave , 2, 5)
        '         end")

        '    Dim da As SqlDataAdapter
        '    Dim ds As New DataSet
        '    ds.Clear()
        '    da = New SqlDataAdapter(SSel, Cn)
        '    da.Fill(ds)

        '    lbl_hora.Value = ds.Tables(0).Rows(0).Item(0)
        '    txt_retardo.Text = ds.Tables(0).Rows(0).Item(1)


        '    Cn.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        '    MessageBox.Show("Falla retardo")


        'End Try


    End Sub


    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_folio.KeyPress

        Try

            If AscW(e.KeyChar) = CInt(Keys.Enter) Then


                muestraetiqueta()
                mostrarocultarcontroles()

                Muestragrid()



            ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
                Empleado.Visible = False
                gbx_inicidencia.Visible = False
                dtgvi.Visible = False
                gbx_inicidencia.Visible = False




            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub



    Sub Muestragrid()

        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestraregistrosincidencias", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@clave", lbl_clave.Text)
            da.SelectCommand.Parameters.AddWithValue("@motivo", motivo)
            da.SelectCommand.Parameters.AddWithValue("@retardo", retardo)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvi.DataSource = dt
            dtgvi.Columns("CLAVE").Visible = False
            Cn.Close()
        Catch
        End Try

    End Sub



    Sub revisaincidencia()
        Dim str_folio As String = "00000" + Trim(Str(lbl_clave.Text))

        Dim Pregunta As Integer


        Pregunta = MsgBox("¿Desea realizar la carga de incidencia? ", vbYesNo + vbExclamation + vbDefaultButton2, "Incidencia")

        If Pregunta = vbYes Then

            Dim dt = New DataTable()
            Dim strSql As String
            strSql = "Sp_InsertaServicioMultipleOp2"


            Dim da = New SqlDataAdapter(strSql, Cn)
            Cn.Open()
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.Add("@permiso", SqlDbType.VarChar, 300).Value = lbl_tipop.Text

            da.SelectCommand.Parameters.Add("@clave", SqlDbType.Int).Value = lbl_clave.Text
            da.SelectCommand.Parameters.Add("@desde", SqlDbType.Date).Value = lbl_desde.Text
            da.SelectCommand.Parameters.Add("@hasta", SqlDbType.Date).Value = lbl_hasta.Text


            da.Fill(dt)
            Cn.Close()

            If dt.Rows.Count > 0 Then

                MessageBox.Show("Ya hay una Incidencia dentro de esta fecha, Favor de verificar.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)




            Else

                cargaincidencia()
            End If


        ElseIf Pregunta = vbNo Then

            MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub


    Sub cargaincidencia()

        Dim f1 = lbl_desde.Value
        Dim f2 = dtp1.Value

        Dim Result = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f1, f2))

        Dim command As New SqlCommand("Sp_insertaincidenciagiro", Cn)

        command.CommandType = CommandType.StoredProcedure

        Cn.Open()

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@folio", txt_folio.Text)
            command.Parameters.AddWithValue("@motivo", motivo)
            command.Parameters.AddWithValue("@clave", lbl_clave.Text)

            command.Parameters.AddWithValue("@incidencia", incidencia)
            command.Parameters.AddWithValue("@retardo", retardo)
            command.Parameters.AddWithValue("@Cretardo", txt_retardo.Text)
            command.Parameters.AddWithValue("@fechayhora", Result)




            command.ExecuteNonQuery()





            MessageBox.Show("Incidencia Cargada", "¡Correcto!")
            txt_folio.Clear()
            Empleado.Visible = False
            gbx_inicidencia.Visible = False
            dtgvi.Visible = False
            gbx_inicidencia.Visible = False
            lbl_tipo.Text = ""
            lbl_hora.Visible = False
            Label9.Visible = False


        Catch ex As Exception

            MessageBox.Show("Error al cargar general, contacte inmediatamente al equipo de sistemas.", "¡Error!")

            MessageBox.Show(ex.ToString)
            txt_folio.Clear()
            Empleado.Visible = False
            gbx_inicidencia.Visible = False
            dtgvi.Visible = False
            gbx_inicidencia.Visible = False
            lbl_hora.Visible = False
            Label9.Visible = False

        Finally

            Cn.Close()

        End Try

    End Sub

    Private Sub Btn_autorizar_Click(sender As Object, e As EventArgs) Handles Btn_autorizar.Click
        revisaincidencia()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HistoricoChecadas.Show()
    End Sub


End Class