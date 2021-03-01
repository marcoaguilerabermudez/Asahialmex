Imports System.Data.SqlClient

Public Class SolicitudTE

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cn As SqlConnection


    Dim id As Integer
    Dim permiso As Integer
    Dim depto As String
    Dim dp As String
    Dim tconsumido As Double

    Sub New(id As Integer, depto As String, permiso As Integer)

        InitializeComponent()

        Me.id = id
        Me.depto = depto
        Me.permiso = permiso

    End Sub



    Private Sub SolicitudTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress
        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor
        End If

        If permiso = 2 OrElse permiso = 3 Then
            Btn_autorizar.Visible = True
        Else
            Btn_autorizar.Visible = False
        End If

        Muestragrid()

        muestraetiquetaplan()

    End Sub


    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            Cnn.Close()
            Cnn.Open()
            Dim SSel As String

            Dim parametro1 As Integer
            parametro1 = txt_clave.Text

            Dim parametro2 As String
            parametro2 = dtp1.Value.ToShortDateString

            SSel = ("
declare @fecha as date
set @fecha = '" & parametro2 & "'

select CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
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
   ,descripcion_depto
    ,departamento
, te.plan_horas -(select 
  case
  when sum(parcial) is null then 0
  else
  sum(parcial)
  end from [AsahiSystem].[dbo].[Rh_solicitudTE] where depto = te.Id_depto and datepart(month,fecha) = datepart(month,getdate()) and datepart(year,fecha) = datepart(year,getdate()) )
from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig
join [AsahiSystem].[dbo].[Rh_planmensualTE] te
on te.id_depto = vig.departamento
where vig.vigencia = 'VIGENTE' and clave = " & parametro1 & "")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, Cnn)
            da.Fill(ds)

            txt_nombre.Text = ds.Tables(0).Rows(0).Item(1)
            txt_turno.Text = ds.Tables(0).Rows(0).Item(2)
            txt_depto.Text = ds.Tables(0).Rows(0).Item(3)
            dp = ds.Tables(0).Rows(0).Item(4)
            tconsumido = ds.Tables(0).Rows(0).Item(5)

            Cnn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
        End Try

    End Sub



    Sub muestraetiquetaplan()

        Cnn.Close()
        Cnn.Open()

        Try
            Dim da As New SqlDataAdapter("Sp_RhetiquetaplanTE", Cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@clave", id)



            Dim ds As New DataSet
            ds.Clear()

            da.Fill(ds)

            lbl_depto1.Text = ds.Tables(0).Rows(0).Item(0)
            hs1.Text = ds.Tables(0).Rows(0).Item(1)
            hd1.Text = ds.Tables(0).Rows(0).Item(2)

            lbl_depto2.Text = ds.Tables(0).Rows(1).Item(0)
            hs2.Text = ds.Tables(0).Rows(1).Item(1)
            hd2.Text = ds.Tables(0).Rows(1).Item(2)

            lbl_depto3.Text = ds.Tables(0).Rows(2).Item(0)
            hs3.Text = ds.Tables(0).Rows(2).Item(1)
            hd3.Text = ds.Tables(0).Rows(2).Item(2)

            lbl_depto4.Text = ds.Tables(0).Rows(3).Item(0)
            hs4.Text = ds.Tables(0).Rows(3).Item(1)
            hd4.Text = ds.Tables(0).Rows(3).Item(2)





            Cnn.Close()

        Catch ex As Exception
            '   MessageBox.Show(ex.ToString)
            '' MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
        End Try

        Try
            di1.Text = CDbl(hs1.Text - hd1.Text)
            di2.Text = CDbl(hs2.Text - hd2.Text)
            di3.Text = CDbl(hs3.Text - hd3.Text)
            di4.Text = CDbl(hs4.Text - hd4.Text)




        Catch
        End Try

        Try

            If CDbl(di1.Text) > 0 Then
                di1.ForeColor = Color.Green
            ElseIf CDbl(di1.Text) < 0 Then
                di1.ForeColor = Color.Red
            ElseIf CDbl(di2.Text) > 0 Then
                di2.ForeColor = Color.Green
            ElseIf CDbl(di2.Text) < 0 Then
                di2.ForeColor = Color.Red
            ElseIf CDbl(di3.Text) > 0 Then
                di3.ForeColor = Color.Green
            ElseIf CDbl(di3.Text) < 0 Then
                di3.ForeColor = Color.Red
            ElseIf CDbl(di4.Text) > 0 Then
                di4.ForeColor = Color.Green
            ElseIf CDbl(di4.Text) < 0 Then
                di4.ForeColor = Color.Red

            End If
        Catch
        End Try

    End Sub



    Sub validarsolicitud()

        Try

            If CDbl(txt_horas.Text) > 0 Then



                Try
                    If CDbl(txt_horas.Text) <= tconsumido Then
                        solicitar()
                    Else
                        MessageBox.Show("Usted a sobrepasado el límite de su Plan de Tiempo Extra, deberá entregar el reporte generado a RH firmado por el gerente, de no ser así, no aplicara el tiempo extra.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        solicitarexcedido()
                    End If
                Catch
                End Try
            Else
                MessageBox.Show("Las horas solicitadas deben tener un valor mayor a 0.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un empleado válido.")
        End Try
    End Sub



    Sub solicitar()

        'If DateTimePicker1.Value.ToShortDateString >= Date.Now.ToShortDateString Then


        Cnn.Close()
        Cnn.Open()
        Dim agrega As SqlCommand = New SqlCommand("  insert into [AsahiSystem].[dbo].[Rh_solicitudTE]
  values
  (@clave, @fecha,
  case
  when @turnoa = 'Matutino' then 1
  when @turnoa = 'Vespertino' then 2
  when @turnoa = 'Nocturno' then 3
  when @turnoa = 'Administrativo' then 4
  end,
   case
  when @turnoe = 'Matutino' then 1
  when @turnoe = 'Vespertino' then 2
  when @turnoe = 'Nocturno' then 3
  when @turnoe = 'Administrativo' then 4
  end,
  @parcial, @motivo, 
   case
  when @turnoe = 'Matutino' then '01/01/1900 06:55:00'
  when @turnoe = 'Vespertino' then '01/01/1900 15:25:00'
  when @turnoe = 'Nocturno' then  '01/01/1900 23:25:00'
  when @turnoe = 'Administrativo' then  '01/01/1900 08:00:00'
  end,
  case
  when @turnoe = 'Matutino' then '01/01/1900 15:25:00'
  when @turnoe = 'Vespertino' then '01/01/1900 23:25:00'
  when @turnoe = 'Nocturno' then  '01/01/1900 06:55:00'
  when @turnoe = 'Administrativo' then  '01/01/1900 17:00:00'
  end, 0, @depto,0,'01/01/1900')
", Cnn)

        Dim RI As String
        Try

            agrega.Parameters.Clear()
            agrega.Parameters.Add("@clave", SqlDbType.Int).Value = txt_clave.Text
            agrega.Parameters.Add("@fecha", SqlDbType.Date).Value = dtp1.Value.ToShortDateString
            agrega.Parameters.Add("@turnoa", SqlDbType.VarChar, (20)).Value = txt_turno.Text
            agrega.Parameters.Add("@turnoe", SqlDbType.VarChar, (20)).Value = cbx_textra.Text
            agrega.Parameters.Add("@parcial", SqlDbType.Float).Value = txt_horas.Text
            agrega.Parameters.Add("@motivo", SqlDbType.Text).Value = txt_motivo.Text
            agrega.Parameters.Add("@entrada", SqlDbType.VarChar, (20)).Value = cbx_textra.Text
            agrega.Parameters.Add("@salida", SqlDbType.VarChar, (20)).Value = cbx_textra.Text
            agrega.Parameters.Add("@depto", SqlDbType.VarChar, (5)).Value = dp



            agrega.ExecuteNonQuery()

            RI = "Correcto, ha solicidato el tiempo extra."
            Muestragrid()


            MessageBox.Show(RI, "¡Aviso!")
            txt_clave.Clear()
            txt_nombre.Clear()
            txt_turno.Clear()
            txt_depto.Clear()
            txt_horas.Clear()
            cbx_textra.Items.Clear()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cnn.Close()

            'cargagrid()
        Finally
            Cnn.Close()
        End Try
        'Else
        '    MessageBox.Show("La hora límite para hacer la solicitud de tiempo extra es a las 16:55 del día en curso.", "¡Aviso!")

        'End If
        muestraetiquetaplan()
    End Sub



    Sub solicitarexcedido()

        'If DateTimePicker1.Value.ToShortDateString >= Date.Now.ToShortDateString Then


        Cnn.Close()
        Cnn.Open()
        Dim agrega As SqlCommand = New SqlCommand("  insert into [AsahiSystem].[dbo].[Rh_solicitudTE]
  values
  (@clave, @fecha,
  case
  when @turnoa = 'Matutino' then 1
  when @turnoa = 'Vespertino' then 2
  when @turnoa = 'Nocturno' then 3
  when @turnoa = 'Administrativo' then 4
  end,
   case
  when @turnoe = 'Matutino' then 1
  when @turnoe = 'Vespertino' then 2
  when @turnoe = 'Nocturno' then 3
  when @turnoe = 'Administrativo' then 4
  end,
  @parcial, @motivo, 
   case
  when @turnoe = 'Matutino' then '01/01/1900 06:55:00'
  when @turnoe = 'Vespertino' then '01/01/1900 15:25:00'
  when @turnoe = 'Nocturno' then  '01/01/1900 23:25:00'
  when @turnoe = 'Administrativo' then  '01/01/1900 08:00:00'
  end,
  case
  when @turnoe = 'Matutino' then '01/01/1900 15:25:00'
  when @turnoe = 'Vespertino' then '01/01/1900 23:25:00'
  when @turnoe = 'Nocturno' then  '01/01/1900 06:55:00'
  when @turnoe = 'Administrativo' then  '01/01/1900 17:00:00'
  end, 0, @depto,1,'01/01/1900')
", Cnn)

        Dim RI As String
        Try

            agrega.Parameters.Clear()
            agrega.Parameters.Add("@clave", SqlDbType.Int).Value = txt_clave.Text
            agrega.Parameters.Add("@fecha", SqlDbType.Date).Value = dtp1.Value.ToShortDateString
            agrega.Parameters.Add("@turnoa", SqlDbType.VarChar, (20)).Value = txt_turno.Text
            agrega.Parameters.Add("@turnoe", SqlDbType.VarChar, (20)).Value = cbx_textra.Text
            agrega.Parameters.Add("@parcial", SqlDbType.Float).Value = txt_horas.Text
            agrega.Parameters.Add("@motivo", SqlDbType.Text).Value = txt_motivo.Text
            agrega.Parameters.Add("@entrada", SqlDbType.VarChar, (20)).Value = cbx_textra.Text
            agrega.Parameters.Add("@salida", SqlDbType.VarChar, (20)).Value = cbx_textra.Text
            agrega.Parameters.Add("@depto", SqlDbType.VarChar, (5)).Value = dp



            agrega.ExecuteNonQuery()

            '' RI = "Correcto, ha solicidato el tiempo extra."
            ContenedorReporteExcedenteTe.clave = txt_clave.Text
            ContenedorReporteExcedenteTe.fecha = dtp1.Value.ToShortDateString
            ContenedorReporteExcedenteTe.Turno = cbx_textra.Text
            ContenedorReporteExcedenteTe.Show()

            Muestragrid()


            ''MessageBox.Show(RI, "¡Aviso!")
            txt_clave.Clear()
            txt_nombre.Clear()
            txt_turno.Clear()
            txt_depto.Clear()
            txt_horas.Clear()
            cbx_textra.Items.Clear()

        Catch ex As Exception

            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cnn.Close()

            'cargagrid()
        Finally
            Cnn.Close()
        End Try
        'Else
        '    MessageBox.Show("La hora límite para hacer la solicitud de tiempo extra es a las 16:55 del día en curso.", "¡Aviso!")

        'End If
        muestraetiquetaplan()
    End Sub



    Sub preautorizar()
        Cnn.Close()
        Cnn.Open()
        Dim preau As SqlCommand = New SqlCommand("update [AsahiSystem].[dbo].[Rh_solicitudTE] set estado = 1
 where Id_solicitudte = @ID", Cnn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then
                    preau.Parameters.Clear()
                    preau.Parameters.Add("@ID", SqlDbType.Int).Value = (fila.Cells("id").Value)
                    preau.ExecuteNonQuery()
                    RI = "¡Registro Preautorizado!"
                End If
            Next

            MessageBox.Show(RI, "¡Aviso!")
            Muestragrid()


        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cnn.Close()
        Finally
            Cnn.Close()

        End Try

    End Sub

    Sub autorizar()
        Cnn.Close()
        Cnn.Open()
        Dim auto As SqlCommand = New SqlCommand("update [AsahiSystem].[dbo].[Rh_solicitudTE] set estado = 2, timestampval = getdate()
 where Id_solicitudte = @ID and estado = 0

delete from giro.[asahi16].[dbo].[Rh_entradasalida2] where grupo = 0 and clave = @clave and fecha = @fecha

delete from [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal] where clave = @clave and Fecha = @fecha and PlanExtra = 0

if not exists (select clave from giro.[asahi16].[dbo].[Rh_entradasalida2] where clave = @clave and grupo =    case
  when @turnoe = 'Matutino' then 1
  when @turnoe = 'Vespertino' then 2
  when @turnoe = 'Nocturno' then 3
  when @turnoe = 'Administrativo' then 4
  end and fecha = @fecha)
begin
 insert into giro.[asahi16].[dbo].[Rh_entradasalida2] (clave,fecha,turno,grupo) 
values (RIGHT(CONCAT('00000', @clave), 5),@fecha,
  case
  when @turnoa = 'Matutino' then 1
  when @turnoa = 'Vespertino' then 2
  when @turnoa = 'Nocturno' then 3
  when @turnoa = 'Administrativo' then 4
  end,
   case
  when @turnoe = 'Matutino' then 1
  when @turnoe = 'Vespertino' then 2
  when @turnoe = 'Nocturno' then 3
  when @turnoe = 'Administrativo' then 4
  end)
  end


 if not exists (select clave from [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal] where clave = @clave and turnoe =    case
 when @turnoe = 'Matutino' then 1
 when @turnoe = 'Vespertino' then 2
 when @turnoe = 'Nocturno' then 3
when @turnoe = 'Administrativo' then 4
end and fecha = @fecha)
begin
insert into [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal] (CLAVE, FECHA, ValSuper, ValRh,PlanExtra,TurnoA,TurnoE )
select RIGHT(CONCAT('00000', @clave), 5), convert (date , @fecha),0,0,1,
case
when @turnoa = 'Matutino' then 1
when @turnoa = 'Vespertino' then 2
when @turnoa = 'Nocturno' then 3
when @turnoa = 'Administrativo' then 4
end,
case
when @turnoe = 'Matutino' then 1
when @turnoe = 'Vespertino' then 2
when @turnoe = 'Nocturno' then 3
when @turnoe = 'Administrativo' then 4
end
end
", Cnn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then
                    auto.Parameters.Clear()
                    auto.Parameters.Add("@ID", SqlDbType.Int).Value = (fila.Cells("id").Value)
                    auto.Parameters.Add("@clave", SqlDbType.Int).Value = (fila.Cells("Clave").Value)
                    auto.Parameters.Add("@turnoa", SqlDbType.VarChar, (20)).Value = (fila.Cells("TurnoA").Value)
                    auto.Parameters.Add("@turnoe", SqlDbType.VarChar, (20)).Value = (fila.Cells("TurnoE").Value)
                    auto.Parameters.Add("@fecha", SqlDbType.Date).Value = dtp1.Value.ToShortDateString

                    auto.ExecuteNonQuery()

                    RI = "¡Registro Autorizado!"

                End If

            Next

            MessageBox.Show(RI, "¡Aviso!")
            Muestragrid()


        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cnn.Close()
        Finally
            Cnn.Close()

        End Try


    End Sub

    Sub eliminar()

        Cnn.Close()
        Cnn.Open()

        Dim eliminar As SqlCommand = New SqlCommand("delete from [AsahiSystem].[dbo].[Rh_solicitudTE]
 where Id_solicitudte = @ID

if
(select count(clave) from giro.[asahi16].[dbo].[Rh_entradasalida2]
where clave = @clave and fecha = @fecha) > 1
begin
delete from giro.[asahi16].[dbo].[Rh_entradasalida2] where clave = @clave and fecha = @fecha and grupo = case
when @turnoe = 'Matutino' then 1
when @turnoe = 'Nocturno' then 3
when @turnoe = 'Administrativo' then 4
end
delete from [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal] where Clave = @clave and Fecha = @fecha and PlanExtra = 1 and TurnoE = case
when @turnoe = 'Matutino' then 1
when @turnoe = 'Vespertino' then 2
when @turnoe = 'Nocturno' then 3
when @turnoe = 'Administrativo' then 4
end
end

  else if (select count(clave) from giro.[asahi16].[dbo].[Rh_entradasalida2]
  where clave = @clave and fecha = @fecha) = 1
  begin 
  update giro.[asahi16].[dbo].[Rh_entradasalida2] set grupo = 0 where clave = @clave and fecha = @fecha
  update [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal] set TurnoE = 0, PlanExtra = 0 where clave = @clave and fecha = @fecha
  end ", Cnn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then
                    eliminar.Parameters.Clear()
                    eliminar.Parameters.Add("@ID", SqlDbType.Int).Value = (fila.Cells("id").Value)
                    eliminar.Parameters.Add("@clave", SqlDbType.Int).Value = (fila.Cells("Clave").Value)
                    eliminar.Parameters.Add("@fecha", SqlDbType.Date).Value = dtp1.Value.ToShortDateString
                    eliminar.Parameters.Add("@turnoe", SqlDbType.VarChar, (20)).Value = (fila.Cells("TurnoE").Value)

                    eliminar.ExecuteNonQuery()

                    RI = "¡Registro Eliminado!"
                End If
            Next

            MessageBox.Show(RI, "¡Aviso!")
            Muestragrid()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cnn.Close()
        Finally
            Cnn.Close()
        End Try

        muestraetiquetaplan()

    End Sub


    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            muestraetiqueta()

            cbx_textra.Items.Clear()
            cbx_textra.Items.Add("Administrativo")
            cbx_textra.Items.Add("Matutino")
            cbx_textra.Items.Add("Nocturno")
            cbx_textra.Items.Add("Vespertino")




            If txt_turno.Text = "Administrativo" And (dtp1.Value.DayOfWeek = 1 OrElse dtp1.Value.DayOfWeek = 3 OrElse dtp1.Value.DayOfWeek = 5 OrElse dtp1.Value.DayOfWeek = 4 OrElse dtp1.Value.DayOfWeek = 2) Then
                cbx_textra.Items.Clear()
                cbx_textra.Items.Add("Nocturno")
                cbx_textra.Items.Add("Vespertino")
            ElseIf txt_turno.Text = "Administrativo" And (dtp1.Value.DayOfWeek = 6 OrElse dtp1.Value.DayOfWeek = 0) Then
                cbx_textra.Items.Clear()
                cbx_textra.Items.Add("Administrativo")
                cbx_textra.Items.Add("Matutino")
                cbx_textra.Items.Add("Nocturno")
                cbx_textra.Items.Add("Vespertino")


            ElseIf txt_turno.Text = "Matutino" And (dtp1.Value.DayOfWeek = 1 OrElse dtp1.Value.DayOfWeek = 3 OrElse dtp1.Value.DayOfWeek = 5 OrElse dtp1.Value.DayOfWeek = 4 OrElse dtp1.Value.DayOfWeek = 2 OrElse dtp1.Value.DayOfWeek = 6) Then

                cbx_textra.Items.Clear()
                cbx_textra.Items.Add("Nocturno")
                cbx_textra.Items.Add("Vespertino")

            ElseIf txt_turno.Text = "Matutino" And (dtp1.Value.DayOfWeek = 0) Then

                cbx_textra.Items.Clear()
                cbx_textra.Items.Add("Administrativo")
                cbx_textra.Items.Add("Matutino")
                cbx_textra.Items.Add("Nocturno")
                cbx_textra.Items.Add("Vespertino")

            ElseIf txt_turno.Text = "Vespertino" And (dtp1.Value.DayOfWeek = 1 OrElse dtp1.Value.DayOfWeek = 3 OrElse dtp1.Value.DayOfWeek = 5 OrElse dtp1.Value.DayOfWeek = 4 OrElse dtp1.Value.DayOfWeek = 2 OrElse dtp1.Value.DayOfWeek = 6) Then
                cbx_textra.Items.Clear()
                cbx_textra.Items.Add("Matutino")
                cbx_textra.Items.Add("Nocturno")

            ElseIf txt_turno.Text = "Vespertino" And (dtp1.Value.DayOfWeek = 0) Then

                cbx_textra.Items.Clear()
                cbx_textra.Items.Add("Administrativo")
                cbx_textra.Items.Add("Matutino")
                cbx_textra.Items.Add("Nocturno")
                cbx_textra.Items.Add("Vespertino")



            ElseIf txt_turno.Text = "Nocturno" And (dtp1.Value.DayOfWeek = 1 OrElse dtp1.Value.DayOfWeek = 3 OrElse dtp1.Value.DayOfWeek = 5 OrElse dtp1.Value.DayOfWeek = 4 OrElse dtp1.Value.DayOfWeek = 2 OrElse dtp1.Value.DayOfWeek = 6) Then
                cbx_textra.Items.Clear()
                cbx_textra.Items.Add("Matutino")
                cbx_textra.Items.Add("Vespertino")
            ElseIf txt_turno.Text = "Nocturno" And (dtp1.Value.DayOfWeek = 0) Then
                cbx_textra.Items.Clear()
                cbx_textra.Items.Add("Administrativo")
                cbx_textra.Items.Add("Matutino")
                cbx_textra.Items.Add("Nocturno")
                cbx_textra.Items.Add("Vespertino")
            End If



        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
            txt_clave.Clear()
            txt_nombre.Clear()
            txt_turno.Clear()
            txt_depto.Clear()
            txt_motivo.Clear()
            txt_horas.Clear()
            cbx_textra.Items.Clear()
        End If


        'cbx_textra.Items.Clear()
        'cbx_textra.Items.Add("Administrativo")
        'cbx_textra.Items.Add("Matutino")
        'cbx_textra.Items.Add("Nocturno")
        'cbx_textra.Items.Add("Vespertino")

    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        If txt_motivo.Text = "" Then
            MessageBox.Show("Debe poner un motivo que justifique su tiempo extra", "¡Aviso!")
        Else
            validarsolicitud()
        End If
    End Sub

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        txt_clave.Clear()
        txt_nombre.Clear()
        txt_turno.Clear()
        txt_depto.Clear()
        txt_motivo.Clear()
        txt_horas.Clear()
        cbx_textra.Items.Clear()
        Muestragrid()
        'muestraetiqueta()
    End Sub

    Private Sub cbx_textra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_textra.SelectedIndexChanged
        If cbx_textra.Text = "Matutino" Then
            txt_horas.Text = 8.5
        ElseIf cbx_textra.Text = "Vespertino" Then
            txt_horas.Text = 8
        ElseIf cbx_textra.Text = "Nocturno" Then
            txt_horas.Text = 7.5
        ElseIf cbx_textra.Text = "Administrativo" Then
            txt_horas.Text = 9
        End If
    End Sub

    Private Sub Btn_autorizar_Click(sender As Object, e As EventArgs) Handles Btn_autorizar.Click
        autorizar()
    End Sub

    Private Sub btn_preautorizar_Click(sender As Object, e As EventArgs) Handles btn_preautorizar.Click
        preautorizar()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        eliminar()
    End Sub

    Sub Muestragrid()

        Try


            Using cnn As New SqlConnection("data source = GIRO\SQLEXPRESS ;initial catalog=Asahisystem;user id=sa;password=Pa55word")
                Dim da As New SqlDataAdapter("Sp_muestralistate", cnn)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
                da.SelectCommand.Parameters.AddWithValue("@clave", id)


                Dim dt As New DataTable
                da.Fill(dt)
                dtgvp.DataSource = dt
                dtgvp.Columns("id").Visible = False
                dtgvp.Columns("Estado").Visible = False

                For Each row As DataGridViewRow In Me.dtgvp.Rows

                    If row.Cells(“Estado”).Value = 1 Then
                        row.DefaultCellStyle.BackColor = Color.LightBlue
                    ElseIf row.Cells(“Estado”).Value = 2 Then
                        row.DefaultCellStyle.BackColor = Color.ForestGreen
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Cnn.Close()
        End Try
    End Sub


End Class