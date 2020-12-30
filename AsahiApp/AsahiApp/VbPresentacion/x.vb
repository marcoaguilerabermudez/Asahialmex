Imports System.Data.SqlClient

Public Class FormatoSM
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Dim vpermiso As Integer
    Dim VMOTIVO As String
    Dim y As Integer
    Dim id As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim difvacaciones As Integer
    Dim NPuesto As String
    Dim NDepto As String


    Sub New(id As Integer, depto As String, permiso As Integer)
        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso

    End Sub


    Private Sub txtIdPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Sub llenacombomotivo()

        Dim Dt As DataTable

            Dim Da As New SqlDataAdapter
            Dim Cmd As New SqlCommand
            Dim parametro1 As String
            parametro1 = cbx_tipo.Text

            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "	
 select Motivo
  FROM [AsahiSystem].[dbo].[Rh_motivopermiso] mot
  join [AsahiSystem].[dbo].[Rh_tipospermiso] tip
  on mot.Id_tipopermiso = tip.Id_tipopermiso
  where tip.Permiso = '" & parametro1 & "'
"
                .Connection = Cn
            End With
            Da.SelectCommand = Cmd
            Dt = New DataTable
            Da.Fill(Dt)
            With cbx_motivo
                .DataSource = Dt
                .DisplayMember = "Motivo"
                '.ValueMember = "id"
            End With


    End Sub


    Sub llenacombodepto()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        Dim parametro1 As String
        parametro1 = cbx_tipo.Text

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	
select descripcion,clave from giro.[asahi16].[Supervisor_giro].[DEPTO] where CENTRO_COSTO not in ('16')
"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_depto
            .DataSource = Dt
            .DisplayMember = "descripcion"
            .ValueMember = "clave"
        End With




    End Sub


    Sub llenacombopuesto()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        Dim parametro1 As String
        parametro1 = cbx_tipo.Text

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	
select descripcion,CLAVE from giro.[asahi16].[Supervisor_giro].[Puesto] where clave not in ('003','011','015','014','013','012','010')
"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_puesto
            .DataSource = Dt
            .DisplayMember = "descripcion"
            .ValueMember = "CLAVE"
        End With



    End Sub



    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            Cn.Close()
            Cn.Open()
            Dim SSel As String

            Dim parametro1 As Integer
            parametro1 = txt_clave.Text

            Dim parametro2 As String
            parametro2 = dtp1.Value.ToShortDateString



            SSel = ("
declare @fecha as date
set @fecha = '" & parametro2 & "'

select CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
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
,descripcion_puesto
from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig
where vig.vigencia = 'VIGENTE' and clave = " & parametro1 & "")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, Cn)
            da.Fill(ds)

            lbl_empleado.Text = ds.Tables(0).Rows(0).Item(1)
            lbl_depto.Text = ds.Tables(0).Rows(0).Item(2)
            lbl_turno.Text = ds.Tables(0).Rows(0).Item(3)
            lbl_puesto.Text = ds.Tables(0).Rows(0).Item(4)

            Cn.Close()
            btn_solicitar.Enabled = True
        Catch ex As Exception
            '   MessageBox.Show(ex.ToString)
            MessageBox.Show("El empleado que ha seleccionado no es válido, verifique e intente de nuevo.", "¡Aviso!")
            btn_solicitar.Enabled = False
        End Try





    End Sub



    Sub variables()
        Try

            Cn.Close()
            Cn.Open()
            Dim SSel As String

            Dim parametro1 As String
            parametro1 = cbx_tipo.Text

            Dim parametro2 As String
            parametro2 = cbx_motivo.Text



            SSel = ("
SELECT  [Id_motivopermiso]
      ,mo.[Id_tipopermiso]
	  ,ti.Permiso
      ,[Motivo]
	  ,id_giro

  FROM [AsahiSystem].[dbo].[Rh_motivopermiso] mo
  join [AsahiSystem].[dbo].[Rh_tipospermiso] ti
  on mo.Id_tipopermiso = ti.Id_tipopermiso
  where ti.permiso = '" & parametro1 & "' and motivo =  '" & parametro2 & "'")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, Cn)
            da.Fill(ds)

            VMOTIVO = ds.Tables(0).Rows(0).Item("id_giro")


            Cn.Close()


        Catch ex As Exception
            '  MessageBox.Show(ex.ToString)


        End Try





    End Sub


    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress

        Try

            If AscW(e.KeyChar) = CInt(Keys.Enter) Then
                muestraetiqueta()
                muestraetiquetavacaciones()


                cbx_tipo.Enabled = True
                cbx_motivo.Enabled = True



                cbx_motivo.DropDownStyle = ComboBoxStyle.DropDown
                cbx_tipo.DropDownStyle = ComboBoxStyle.DropDown
                cbx_tipo.Text = "---Seleccionar---"
                cbx_motivo.Text = "---Seleccionar---"




            ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
                txt_clave.Clear()
                lbl_empleado.Text = "Empleado"
                lbl_depto.Text = "Departamento"
                lbl_turno.Text = "Turno"
                lbl_puesto.Text = "Puesto"

                cbx_motivo.DropDownStyle = ComboBoxStyle.DropDown
                cbx_tipo.DropDownStyle = ComboBoxStyle.DropDown
                cbx_tipo.Text = ""
                cbx_motivo.Text = ""

                cbx_tipo.Enabled = False
                cbx_motivo.Enabled = False

                rbt_falta.Checked = True
                txt_motivo.Clear()
                Check_entrada.Checked = True
                rbt_nocturno.Checked = False
                Check_aviso.Checked = False
                txt_quien.Clear()
                btn_solicitar.Enabled = False
                dtgvp.Visible = False
                gbx_vacaciones.Visible = False
                lbl_pendientes.Text = "0"
                lbl_tomados.Text = "0"
                lbl_ndepto.Visible = False
                cbx_depto.Visible = False
                lbl_npuesto.Visible = False
                cbx_puesto.Visible = False



            End If

        Catch
        End Try
    End Sub




    Private Sub cbx_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipo.SelectedIndexChanged
        cbx_motivo.DropDownStyle = ComboBoxStyle.DropDownList
        cbx_tipo.DropDownStyle = ComboBoxStyle.DropDownList
        llenacombomotivo()
        If cbx_tipo.Text = "Registro en reloj checador" Then
            Check_entrada.Visible = True
            Check_salida.Visible = True
            'rbt_nocturno.Visible = True
            Label6.Visible = False
            dtp2.Visible = False
            Label9.Visible = False
            Label8.Visible = False
            desde_h.Visible = False
            hasta_h.Visible = False
            dtp_checada.Visible = True
            Label10.Visible = False
            dtp_regreso.Visible = False
            gb_aviso.Visible = False
            Check_aviso.Checked = False
            'rbt_nocturno.Visible = True
            vpermiso = 6
            dtgvp.Visible = False
            gbx_vacaciones.Visible = False
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False


        ElseIf cbx_tipo.Text = "Vacaciones" Then
            Check_entrada.Visible = False
            Check_salida.Visible = False
            'rbt_nocturno.Visible = False
            Label6.Visible = True
            dtp2.Visible = True
            Label9.Visible = False
            Label8.Visible = False
            desde_h.Visible = False
            hasta_h.Visible = False
            dtp_checada.Visible = False
            Label10.Visible = True
            dtp_regreso.Visible = True
            gb_aviso.Visible = False
            Check_aviso.Checked = False
            gbx_tipo.Visible = False
            gbx_vacaciones.Visible = True
            'rbt_nocturno.Visible = False
            muestraetiquetavacaciones()
            dtp1.Value = Today.Now.AddDays(3)
            dtp2.Value = Today.Now.AddDays(3)
            vpermiso = 5
            dtgvp.Visible = True
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False


        ElseIf cbx_tipo.Text = "Falta o retardo JUSTIFICADO y sin goce de sueldo (No solicitado anticipadamente)" Then
            Check_entrada.Visible = False
            Check_salida.Visible = False
            'rbt_nocturno.Visible = False
            Label6.Visible = True
            dtp2.Visible = True
            desde_h.Visible = True
            hasta_h.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            dtp_checada.Visible = False
            Label10.Visible = False
            dtp_regreso.Visible = False
            gb_aviso.Visible = True
            gbx_tipo.Visible = True
            'rbt_nocturno.Visible = False
            vpermiso = 4
            dtgvp.Visible = True
            gbx_vacaciones.Visible = False
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False


        ElseIf cbx_tipo.Text = "Falta o retardo injustificado y sin goce de sueldo" Then
            Check_entrada.Visible = False
            Check_salida.Visible = False
            'rbt_nocturno.Visible = False
            Label6.Visible = True
            dtp2.Visible = True
            desde_h.Visible = True
            hasta_h.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            dtp_checada.Visible = False
            Label10.Visible = False
            dtp_regreso.Visible = False
            gb_aviso.Visible = True
            gbx_tipo.Visible = True
            'rbt_nocturno.Visible = False
            vpermiso = 3
            dtgvp.Visible = True
            gbx_vacaciones.Visible = False
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False


        ElseIf cbx_tipo.Text = "Permiso sin goce de sueldo" Then
            Check_entrada.Visible = False
            Check_salida.Visible = False
            'rbt_nocturno.Visible = False
            Label6.Visible = True
            dtp2.Visible = True
            desde_h.Visible = True
            hasta_h.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            dtp_checada.Visible = False
            Label10.Visible = False
            dtp_regreso.Visible = False
            gb_aviso.Visible = False
            Check_aviso.Checked = False
            gbx_tipo.Visible = False
            'rbt_nocturno.Visible = False
            vpermiso = 2
            dtgvp.Visible = True
            gbx_vacaciones.Visible = False
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False


        ElseIf cbx_tipo.Text = "Permiso con goce de sueldo" Then
            Check_entrada.Visible = False
            Check_salida.Visible = False
            'rbt_nocturno.Visible = False
            Label6.Visible = True
            dtp2.Visible = True
            desde_h.Visible = True
            hasta_h.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            dtp_checada.Visible = False
            Label10.Visible = False
            dtp_regreso.Visible = False
            gb_aviso.Visible = False
            Check_aviso.Checked = False
            gbx_tipo.Visible = False
            'rbt_nocturno.Visible = False
            vpermiso = 1
            dtgvp.Visible = True
            gbx_vacaciones.Visible = False
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False

        ElseIf cbx_tipo.Text = "Cambio de departamento" Then
            Check_entrada.Visible = False
            Check_salida.Visible = False
            'rbt_nocturno.Visible = False
            lbl_ndepto.Location = New Point(258, 203)
            cbx_depto.Location = New Point(334, 199)

            desde_h.Visible = True
            hasta_h.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            dtp_checada.Visible = False
            Label10.Visible = False
            dtp_regreso.Visible = False
            gb_aviso.Visible = False
            Check_aviso.Checked = False
            gbx_tipo.Visible = False
            'rbt_nocturno.Visible = False
            vpermiso = 7
            dtgvp.Visible = True
            gbx_vacaciones.Visible = False

            lbl_ndepto.Visible = True
            cbx_depto.Visible = True
            Label6.Visible = False
            dtp2.Visible = False

            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False

        ElseIf cbx_tipo.Text = "Cambio de puesto" Then
            Check_entrada.Visible = False
            Check_salida.Visible = False
            'rbt_nocturno.Visible = False

            desde_h.Visible = True
            hasta_h.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            dtp_checada.Visible = False
            Label10.Visible = False
            dtp_regreso.Visible = False
            gb_aviso.Visible = False
            Check_aviso.Checked = False
            gbx_tipo.Visible = False
            'rbt_nocturno.Visible = False
            vpermiso = 8
            dtgvp.Visible = True
            gbx_vacaciones.Visible = False

            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            Label6.Visible = False
            dtp2.Visible = False

            lbl_npuesto.Visible = True
            cbx_puesto.Visible = True



        ElseIf cbx_tipo.Text = "Suspensión" Then
            Check_entrada.Visible = False
            Check_salida.Visible = False
            'rbt_nocturno.Visible = False
            Label6.Visible = True
            dtp2.Visible = True
            desde_h.Visible = True
            hasta_h.Visible = True
            Label9.Visible = True
            Label8.Visible = True
            dtp_checada.Visible = False
            Label10.Visible = False
            dtp_regreso.Visible = False
            gb_aviso.Visible = False
            gbx_tipo.Visible = False
            'rbt_nocturno.Visible = False
            vpermiso = 9
            dtgvp.Visible = True
            gbx_vacaciones.Visible = False
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False


        End If


        Muestragrid()

    End Sub

    Private Sub cbx_motivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_motivo.SelectedIndexChanged

        If cbx_motivo.Text = "Otro" Then
            Label7.Visible = True
            txt_motivo.Visible = True
        ElseIf cbx_motivo.Text = "Cambio de puesto y departamento" Then

            lbl_ndepto.Visible = True
            cbx_depto.Visible = True

            lbl_ndepto.Location = New Point(550, 203)
            cbx_depto.Location = New Point(630, 199)
            Label7.Visible = False
            txt_motivo.Visible = False
            Check_aviso.Checked = False
            txt_quien.Clear()

        ElseIf cbx_motivo.Text = "Cambio de puesto" Then

            lbl_ndepto.Visible = False
            cbx_depto.Visible = False

            Label7.Visible = False
            txt_motivo.Visible = False
            Check_aviso.Checked = False
            txt_quien.Clear()



        Else
            Label7.Visible = False
            txt_motivo.Visible = False
            Check_aviso.Checked = False
            txt_quien.Clear()

        End If

        variables()
    End Sub

    Private Sub FormatoSM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_regreso.Value = dtp2.Value.AddDays(1)
        txt_clave.Focus()
        llenacombodepto()
        llenacombopuesto()
    End Sub

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        Try
            muestraetiqueta()
            dtp2.Value = dtp1.Value
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
            da.SelectCommand.Parameters.AddWithValue("@clave", txt_clave.Text)
            da.SelectCommand.Parameters.AddWithValue("@motivo", vpermiso)
            da.SelectCommand.Parameters.AddWithValue("@retardo", rbt_retardo.Checked)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("CLAVE").Visible = False
            Cn.Close()
        Catch
        End Try

    End Sub


    Sub muestraetiquetavacaciones()
        Cn.Close()
        Cn.Open()
        Try
            Dim da As New SqlDataAdapter("Sp_InsertaServicioMultipleOp2", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@clave", txt_clave.Text)
            da.SelectCommand.Parameters.AddWithValue("@permiso", "Vacaciones")
            da.SelectCommand.Parameters.AddWithValue("@desde", "01/01/1900")
            da.SelectCommand.Parameters.AddWithValue("@hasta", "01/01/1900")
            da.SelectCommand.Parameters.AddWithValue("@var", 1)



            Dim ds As New DataSet
            ds.Clear()

            da.Fill(ds)

            lbl_pendientes.Text = ds.Tables(0).Rows(0).Item(0)
            lbl_tomados.Text = ds.Tables(0).Rows(0).Item(1)


            Cn.Close()

        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            ' MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
        End Try

    End Sub


    Private Sub lbl_turno_Click(sender As Object, e As EventArgs) Handles lbl_turno.TextChanged
        If lbl_turno.Text = "Matutino" Then
            desde_h.Value = "01/01/2020 06:55:00"
            hasta_h.Value = "01/01/2020 15:25:00"
        ElseIf lbl_turno.Text = "Vespertino" Then
            desde_h.Value = "01/01/2020 15:25:00"
            hasta_h.Value = "01/01/2020 23:25:00"
        ElseIf lbl_turno.Text = "Nocturno" Then
            desde_h.Value = "01/01/2020 23:25:00"
            hasta_h.Value = "01/01/2020 06:55:00"
        ElseIf lbl_turno.Text = "Administrativo" Then
            desde_h.Value = "01/01/2020 08:00:00"
            hasta_h.Value = "01/01/2020 17:00:00"
        End If

    End Sub

    Private Sub Check_aviso_CheckedChanged(sender As Object, e As EventArgs) Handles Check_aviso.CheckedChanged
        If Check_aviso.Checked = True Then
            dtp_hora.Visible = True
            dtp_cuando.Visible = True
            txt_quien.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True

        Else
            dtp_hora.Visible = False
            dtp_cuando.Visible = False
            txt_quien.Visible = False
            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False

        End If
    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        revisavacaciones()
        'generarreporte()
    End Sub



    Sub generarreporte()

        If vpermiso = 1 OrElse vpermiso = 2 Then
            F_reportePCSGoce.id = y
            F_reportePCSGoce.Tipo = 0
            F_reportePCSGoce.motivo = 0
            F_reportePCSGoce.retardo = 0
            F_reportePCSGoce.Show()
        ElseIf vpermiso = 3 OrElse vpermiso = 4 Then
            Fr_reportefaltajusinj.id = y
            Fr_reportefaltajusinj.Tipo = 0
            Fr_reportefaltajusinj.motivo = 0
            Fr_reportefaltajusinj.retardo = 0
            Fr_reportefaltajusinj.Show()
        ElseIf vpermiso = 5 Then
            ContenedorReporteVacacionesRH.id = y
            ContenedorReporteVacacionesRH.Tipo = 0
            ContenedorReporteVacacionesRH.motivo = 0
            ContenedorReporteVacacionesRH.retardo = 0
            ContenedorReporteVacacionesRH.Show()
        ElseIf vpermiso = 6 Then
            ContenedorReporteChecadas.id = y
            ContenedorReporteChecadas.Tipo = 0
            ContenedorReporteChecadas.motivo = 0
            ContenedorReporteChecadas.retardo = 0
            ContenedorReporteChecadas.Show()


        ElseIf vpermiso = 7 Then
            ContenedorReporteDeptoN.id = y
            ContenedorReporteDeptoN.Tipo = 0
            ContenedorReporteDeptoN.motivo = 0
            ContenedorReporteDeptoN.retardo = 0
            ContenedorReporteDeptoN.Show()


        ElseIf vpermiso = 8 And cbx_motivo.Text = "Cambio de puesto" Then
            ContenedorReporteNuevoPuesto.id = y
            ContenedorReporteNuevoPuesto.Tipo = 0
            ContenedorReporteNuevoPuesto.motivo = 0
            ContenedorReporteNuevoPuesto.retardo = 0
            ContenedorReporteNuevoPuesto.Show()

        ElseIf vpermiso = 8 And cbx_motivo.Text = "Cambio de puesto y departamento" Then
            ContenedorReporteDeptoPuesto.id = y
            ContenedorReporteDeptoPuesto.Tipo = 0
            ContenedorReporteDeptoPuesto.motivo = 0
            ContenedorReporteDeptoPuesto.retardo = 0
            ContenedorReporteDeptoPuesto.Show()


        ElseIf vpermiso = 9 Then
            ContenedorReporteSuspension.id = y
            ContenedorReporteSuspension.Tipo = 0
            ContenedorReporteSuspension.motivo = 0
            ContenedorReporteSuspension.retardo = 0
            ContenedorReporteSuspension.Show()

        End If

    End Sub


    Sub revisavacaciones()

        difvacaciones = DateDiff(DateInterval.Day, dtp1.Value, dtp2.Value) + 1

        If permiso = 3 Then
            revisaincidencia()
        Else

            If cbx_tipo.Text = "Vacaciones" Then

                If dtp1.Value.ToShortDateString < Today.Now.AddDays(2) Then


                    MessageBox.Show("Debe pedir las vacaciones con 3 días de anticipación.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf difvacaciones > CInt(lbl_pendientes.Text) Then

                    MessageBox.Show("No puede tomar más días de los que tiene asignados, revise sus fechas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    revisaincidencia()

                End If


            ElseIf vpermiso = 2 Then

                If dtp1.Value.ToShortDateString <= Today.Now Then


                    MessageBox.Show("Debe pedir el permiso con 1 día de anticipación", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    revisaincidencia()

                End If

            Else

                revisaincidencia()
            End If

        End If








        'If permiso = 3 Then
        '        revisaincidencia()
        '    Else


        '    If dtp1.Value.ToShortDateString < Today.Now.AddDays(2) And cbx_tipo.Text = "Vacaciones" Then


        '        MessageBox.Show("Debe pedir las vacaciones con 3 días de anticipación.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Else
        '        revisaincidencia()

        '        End If
        '    End If


    End Sub


    Sub revisaincidencia()
        Dim str_folio As String = "00000" + Trim(Str(txt_clave.Text))

        Dim Pregunta As Integer


        Pregunta = MsgBox("¿Desea completar la solicitud? Recuerde que debe entregar el formato generado a RH para que se aplique la incidencia.", vbYesNo + vbExclamation + vbDefaultButton2, "Incidencia")

        If Pregunta = vbYes And cbx_tipo.Text <> "" Then

            Dim dt = New DataTable()
            Dim strSql As String
            strSql = "Sp_InsertaServicioMultipleOp2"


            Dim da = New SqlDataAdapter(strSql, Cn)
            Cn.Close()
            Cn.Open()
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.Add("@permiso", SqlDbType.VarChar, 300).Value = cbx_tipo.Text

            da.SelectCommand.Parameters.Add("@clave", SqlDbType.Int).Value = txt_clave.Text
            da.SelectCommand.Parameters.Add("@desde", SqlDbType.Date).Value = dtp1.Value.ToShortDateString
            da.SelectCommand.Parameters.Add("@hasta", SqlDbType.Date).Value = dtp2.Value.ToShortDateString
            da.SelectCommand.Parameters.Add("@var", SqlDbType.Int).Value = 0


            da.Fill(dt)
            Cn.Close()

            If dt.Rows.Count > 0 Then

                MessageBox.Show("Ya hay una Incidencia dentro de esta fecha, Favor de verificar.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_clave.Clear()
                rbt_falta.Checked = True
                txt_motivo.Clear()
                lbl_empleado.Text = "Empleado"
                lbl_depto.Text = "Departamento"
                lbl_turno.Text = "Turno"
                lbl_puesto.Text = "Puesto"
                Check_entrada.Checked = True
                Check_aviso.Checked = False
                txt_quien.Clear()
                rbt_nocturno.Checked = False
                btn_solicitar.Enabled = False

            Else

                CargaIncidencia()
            End If

        ElseIf Pregunta = vbYes And cbx_tipo.Text = "" Then
            MessageBox.Show("Debe elegir un tipo de motivo", "¡Acción no completada!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Pregunta = vbNo Then

            MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub



    Sub CargaIncidencia()



        Dim f1 = dtp1.Value
        Dim f2 = dtp_checada.Value

        Dim Result = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", f1, f2))


        Dim command As New SqlCommand("Sp_InsertaServicioMultiple", Cn)

        command.CommandType = CommandType.StoredProcedure

        Cn.Open()

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@permiso", vpermiso)
            command.Parameters.AddWithValue("@motivo", cbx_motivo.Text)
            command.Parameters.AddWithValue("@clave", txt_clave.Text)

            command.Parameters.AddWithValue("@desde", dtp1.Value.ToShortDateString)
            command.Parameters.AddWithValue("@hasta", dtp2.Value.ToShortDateString)
            command.Parameters.AddWithValue("@DesdeH", desde_h.Value.ToOADate)
            command.Parameters.AddWithValue("@HastaH", hasta_h.Value.ToOADate)
            command.Parameters.AddWithValue("@autorizo", id)
            command.Parameters.AddWithValue("@otro", txt_motivo.Text)
            command.Parameters.AddWithValue("@falta", rbt_falta.Checked)
            command.Parameters.AddWithValue("@retardo", rbt_retardo.Checked)
            command.Parameters.AddWithValue("@comunico", Check_aviso.CheckState)
            command.Parameters.AddWithValue("@quien", txt_quien.Text)
            command.Parameters.AddWithValue("@cuando", dtp_cuando.Value.ToShortDateString)
            command.Parameters.AddWithValue("@hora", dtp_hora.Value.ToOADate)
            command.Parameters.AddWithValue("@checada", dtp_checada.Value.ToOADate)
            command.Parameters.AddWithValue("@ChEntrada", Check_entrada.Checked)
            command.Parameters.AddWithValue("@ChSalida", Check_salida.Checked)
            command.Parameters.AddWithValue("@regresov", dtp_regreso.Value.ToShortDateString)
            command.Parameters.AddWithValue("@cnocturno", rbt_nocturno.CheckState)
            command.Parameters.AddWithValue("@fechayhora", Result)
            command.Parameters.AddWithValue("@variable", VMOTIVO)
            command.Parameters.AddWithValue("@ndepto", cbx_depto.Text)
            command.Parameters.AddWithValue("@npuesto", cbx_puesto.Text)



            command.ExecuteNonQuery()



            Dim comando As SqlCommand = New SqlCommand
            comando.CommandText = " select top 1 [Id_permisogoce] FROM [AsahiSystem].[dbo].[Rh_incidenciamultiple] order by id_permisogoce desc"
            comando.Connection = Cn
            Cn.Close()
            Cn.Open()

            y = comando.ExecuteScalar()

            Cn.Close()


            MessageBox.Show("Solicitud de incidencia creada con el folio: " & y & " ,recuerde que debe llevar el formato generado a RH para hacer válida la incidencia.  ", "¡Correcto!")
            txt_clave.Clear()
            rbt_falta.Checked = True
            txt_motivo.Clear()
            lbl_empleado.Text = "Empleado"
            lbl_depto.Text = "Departamento"
            lbl_turno.Text = "Turno"
            lbl_puesto.Text = "Puesto"
            Check_entrada.Checked = True
            Check_aviso.Checked = False
            txt_quien.Clear()
            rbt_nocturno.Checked = False
            btn_solicitar.Enabled = False
            txt_clave.Focus()
            dtgvp.Visible = False
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False
            gbx_tipo.Visible = False

            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False

            generarreporte()

        Catch ex As Exception

            MessageBox.Show("Error al cargar general, contacte inmediatamente al equipo de sistemas.", "¡Error!")

            MessageBox.Show(ex.ToString)


            txt_clave.Clear()
            rbt_falta.Checked = True
            txt_motivo.Clear()
            lbl_empleado.Text = "Empleado"
            lbl_depto.Text = "Departamento"
            lbl_turno.Text = "Turno"
            Check_entrada.Checked = True
            Check_aviso.Checked = False
            txt_quien.Clear()
            rbt_nocturno.Checked = False
            btn_solicitar.Enabled = False
            dtgvp.Visible = False
            lbl_ndepto.Visible = False
            cbx_depto.Visible = False

            lbl_npuesto.Visible = False
            cbx_puesto.Visible = False
            gbx_tipo.Visible = False
        Finally

            Cn.Close()

        End Try

    End Sub

    Private Sub dtp2_ValueChanged(sender As Object, e As EventArgs) Handles dtp2.ValueChanged
        If dtp2.Value < dtp1.Value Then
            dtp2.Value = dtp1.Value.ToShortDateString

        End If

        dtp_regreso.Value = dtp2.Value.AddDays(1)
    End Sub

    Private Sub dtp_regreso_ValueChanged(sender As Object, e As EventArgs) Handles dtp_regreso.ValueChanged
        If dtp_regreso.Value < dtp2.Value OrElse dtp_regreso.Value = dtp2.Value Then
            dtp_regreso.Value = dtp2.Value.AddDays(1)
        End If
    End Sub

    Private Sub rbt_retardo_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_retardo.CheckedChanged
        Muestragrid()
    End Sub

    Private Sub rbt_falta_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_falta.CheckedChanged
        Muestragrid()
    End Sub

    Private Sub btn_anteriores_Click(sender As Object, e As EventArgs) Handles btn_anteriores.Click
        ImprimirAnteriores.Show()
    End Sub

End Class