Imports System.Data.SqlClient

Public Class MedidasDisciplinarias

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection

    Public cadenagi As String
    Public cadenaCgiro As String
    Public cnn2 As SqlConnection

    Dim estadoausentismo As Integer
    Dim clavedisciplinaria As Integer
    Dim terminodisciplinaria As Integer
    Dim id_tipoamonestacion As Integer
    Dim y As Integer





    Private Sub MedidasDisciplinarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub



    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            cnn2.Close()
            cnn2.Open()
            Dim SSel As String



            SSel = ("


declare @año as int
set @año = " & dtp1.Value.Year & "


declare @clave as int
set @clave = " & txt_clave.Text & "


select CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
,descripcion_depto
,DESCRIPCION_PUESTO
,Turno = CASE (select TOP 1 ETT.CATALOGO  from [asahi16].[Supervisor_giro].[Empturno] ETT
  where ett.clave = vig.CLAVE and ett.FECHA_ENTRADA <= GETDATE()
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
   ,INGRESO
   ,CASE
WHEN  (SELECT TOP 1 fechai from [asahi16].[Supervisor_giro].[Empaus] where clave = @clave and DATEPART(YEAR,FECHAI) = @año and TIPO = 'F'  AND VIG.INGRESO < FECHAI) IS NULL THEN '01/01/1900'
else
(SELECT TOP 1 fechai from [asahi16].[Supervisor_giro].[Empaus] where clave = @clave and DATEPART(YEAR,FECHAI) = @año and TIPO = 'F'  AND VIG.INGRESO < FECHAI)
end
,CASE
WHEN  (SELECT TOP 1 id_empleado from SQLEX.[AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] where id_empleado = @clave and DATEPART(YEAR,Fecha_Aplicacion) = @año   AND Clave_disciplinaria = 100) IS NULL THEN 0
else
1
end
,CASE
WHEN  (SELECT TOP 1 id_empleado from SQLEX.[AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] where id_empleado = @clave and DATEPART(YEAR,Fecha_Aplicacion) = @año   AND Clave_disciplinaria = 100) IS NULL THEN '01/01/1900'
else
(SELECT TOP 1 Fecha_Aplicacion from SQLEX.[AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] where id_empleado = @clave and DATEPART(YEAR,Fecha_Aplicacion) = @año   AND Clave_disciplinaria = 100)
end
,  case
  when (select top 1 id_tipoamonestacion from SQLEX.[AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] 
  where clave_disciplinaria = 15 and tipo_disciplinaria = 1 and aplica = 1 and id_empleado = @clave
  and datepart(year,fecha_aplicacion) = @año) is null then 15
  else
  (select top 1 id_tipoamonestacion from SQLEX.[AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] 
  where clave_disciplinaria = 15 and tipo_disciplinaria = 1 and aplica = 1 and id_empleado = @clave
  and datepart(year,fecha_aplicacion) = @año) end
from asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig

where vig.vigencia = 'VIGENTE' and clave = @clave")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn2)
            da.Fill(ds)

            txt_nombre.Text = ds.Tables(0).Rows(0).Item(1)
            txt_turno.Text = ds.Tables(0).Rows(0).Item(4)
            txt_depto.Text = ds.Tables(0).Rows(0).Item(2)
            txt_puesto.Text = ds.Tables(0).Rows(0).Item(3)
            txt_ingreso.Text = ds.Tables(0).Rows(0).Item(5)
            estadoausentismo = ds.Tables(0).Rows(0).Item(9)

            pbx.Visible = True
            pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" & txt_clave.Text & ".jpg")
            Me.pbx.SizeMode = PictureBoxSizeMode.CenterImage
            Me.pbx.BorderStyle = BorderStyle.Fixed3D
            pbx.SizeMode = PictureBoxSizeMode.StretchImage

            Label5.Visible = True
            cbx_tipo.Visible = True
            cbx_tipo.Text = "--Seleccionar--"

            cnn2.Close()

            ' MessageBox.Show(estadoausentismo)
            dtgvp.Visible = True
            cargagrid()
        Catch ex As Exception
            '  MessageBox.Show(ex.ToString)
            MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
            btn_solicitar.Enabled = False
            pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/x.jpg")

            pbx.Visible = False
            Label5.Visible = False
            cbx_tipo.Visible = False
            cbx_tipo.Text = "--Seleccionar--"
            Label4.Visible = False
            txt_articulo.Visible = False
            txt_articulo.Clear()
            dtgvp.Visible = False
        End Try


        'If antecedente = 1 Then
        '    MessageBox.Show("El empleado " & txt_clave.Text & " tiene una carta compromiso el día  " & fecha_antecedente & ", verifique su información. ", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    '    txt_clave.Clear()
        '    btn_solicitar.Enabled = False
        '    '  pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/x.jpg")
        '    GroupBox2.Enabled = False
        '    '   pbx.Visible = False
        '    txt_nombre.Clear()
        '    txt_motivo.Clear()
        '    txt_puesto.Clear()
        '    txt_depto.Clear()
        '    txt_fechainjustificada.Value = "01/01/1900"
        '    txt_ingreso.Clear()
        '    txt_turno.Clear()
        '    Label6.Visible = False
        '    txt_motivo.Visible = False
        'End If

    End Sub



    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then

            muestraetiqueta()

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_clave.Clear()
            btn_solicitar.Enabled = False
            pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/x.jpg")

            pbx.Visible = False
            txt_nombre.Clear()

            txt_puesto.Clear()
            txt_depto.Clear()

            txt_ingreso.Clear()
            txt_turno.Clear()
            Label6.Visible = False

            cbx_tipo.Text = "--Seleccionar--"
            Label5.Visible = False
            cbx_tipo.Visible = False
            Label4.Visible = False
            txt_articulo.Visible = False
            txt_articulo.Clear()
            txt_faltacometida.Visible = False
            txt_faltacometida.Clear()
            txt_antecedente.Visible = False
            txt_antecedente.Clear()
            Label6.Visible = False
            Label7.Visible = False
            Panel2.Visible = False
            Label9.Visible = False
            rbt_escrita.Checked = False
            rbt_verbal.Checked = False
            rbt_suspensión.Checked = False
            rbt_rescisión.Checked = False
            For Each row As DataGridViewRow In dtgv_fechas.Rows
                dtgv_fechas.Rows.Remove(row)
            Next
            dtgvp.Visible = False
        End If
    End Sub

    Private Sub cbx_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipo.SelectedIndexChanged
        If cbx_tipo.Text = "--Seleccionar--" Then
            Label4.Visible = False
            txt_articulo.Visible = False
            txt_articulo.Clear()
            txt_faltacometida.Visible = False
            txt_faltacometida.Clear()
            txt_antecedente.Visible = False
            txt_antecedente.Clear()
            Label6.Visible = False
            Label7.Visible = False
            Panel2.Visible = False
            Label9.Visible = False
            rbt_escrita.Checked = False
            rbt_verbal.Checked = False
            rbt_suspensión.Checked = False
            rbt_rescisión.Checked = False
            For Each row As DataGridViewRow In dtgv_fechas.Rows
                dtgv_fechas.Rows.Remove(row)
            Next

        Else
            Label4.Visible = True
            txt_articulo.Visible = True
            Consultaaarticulo()
        End If
    End Sub


    Sub Consultaaarticulo()

        Try
            Dim lista As New List(Of String)
            cnn.Close()
            cnn.Open()
            Dim SSel As String



            SSel = ("


declare @tipo as varchar(15)
set @tipo = '" & cbx_tipo.Text & "'


declare @articulo as int
set @articulo = '" & txt_articulo.Text & "'


if @tipo = 'Obligaciones'
begin

 select nombre,clave, termino from [AsahiSystem].[dbo].[Rh_TiposDisciplinaria]
  where termino = 0 and clave = @articulo
end
else if @tipo = 'Prohibiciones'
begin
 select nombre,clave, termino from [AsahiSystem].[dbo].[Rh_TiposDisciplinaria]
  where termino = 1 and clave = @articulo
end


")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn)
            da.Fill(ds)

            txt_articuloinfracionado.Visible = True
            txt_articuloinfracionado.Text = ds.Tables(0).Rows(0).Item(0)
            clavedisciplinaria = ds.Tables(0).Rows(0).Item(1)
            terminodisciplinaria = ds.Tables(0).Rows(0).Item(2)
            txt_faltacometida.Visible = True
            txt_antecedente.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Panel2.Visible = True
            Label9.Visible = True
            btn_solicitar.Visible = True

            cnn.Close()


            If txt_articulo.Text = 15 And cbx_tipo.Text = "Prohibiciones" And estadoausentismo = 0 Then
                rbt_verbal.Checked = True
            ElseIf txt_articulo.Text = 15 And cbx_tipo.Text = "Prohibiciones" And estadoausentismo = 1 Then

                rbt_escrita.Checked = True
            ElseIf txt_articulo.Text = 15 And cbx_tipo.Text = "Prohibiciones" And estadoausentismo = 2 Then

                rbt_suspensión.Checked = True
            ElseIf txt_articulo.Text = 15 And cbx_tipo.Text = "Prohibiciones" And estadoausentismo = 3 Then

                rbt_rescisión.Checked = True

            End If

            '  MessageBox.Show(clavedisciplinaria)

        Catch ex As Exception

            '  MessageBox.Show(ex.ToString)
            txt_articuloinfracionado.Visible = False
            txt_articuloinfracionado.Clear()
            clavedisciplinaria = 0
            txt_faltacometida.Visible = False
            txt_antecedente.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Panel2.Visible = False
            Label9.Visible = False
            rbt_escrita.Checked = False
            rbt_verbal.Checked = False
            rbt_suspensión.Checked = False
            rbt_rescisión.Checked = False
            btn_solicitar.Visible = False
            For Each row As DataGridViewRow In dtgv_fechas.Rows
                dtgv_fechas.Rows.Remove(row)
            Next

        End Try

    End Sub

    Private Sub txt_articulo_TextChanged(sender As Object, e As EventArgs) Handles txt_articulo.TextChanged

        If txt_articulo.Text = "" Then
            txt_articuloinfracionado.Visible = False
            txt_articuloinfracionado.Clear()
            clavedisciplinaria = 0
            txt_faltacometida.Visible = False
            txt_faltacometida.Clear()
            txt_antecedente.Visible = False
            txt_antecedente.Clear()
            Label6.Visible = False
            Label7.Visible = False
            Panel2.Visible = False
            Label9.Visible = False
            rbt_escrita.Checked = False
            rbt_verbal.Checked = False
            rbt_suspensión.Checked = False
            rbt_rescisión.Checked = False
            btn_solicitar.Visible = False

            For Each row As DataGridViewRow In dtgv_fechas.Rows
                dtgv_fechas.Rows.Remove(row)
            Next

        Else
            Consultaaarticulo()
        End If

    End Sub

    Private Sub rbt_suspensión_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_suspensión.CheckedChanged, rbt_escrita.CheckedChanged, rbt_rescisión.CheckedChanged, rbt_verbal.CheckedChanged
        If rbt_suspensión.Checked = True Then
            dtp_desde.Visible = True
            Panel3.Visible = True
            Label10.Visible = True
            id_tipoamonestacion = 3
            btn_solicitar.Enabled = True

        ElseIf rbt_verbal.Checked = True Then
            dtp_desde.Visible = False
            Panel3.Visible = False
            Label10.Visible = False
            id_tipoamonestacion = 1
            btn_solicitar.Enabled = True

        ElseIf rbt_escrita.Checked = True Then
            dtp_desde.Visible = False
            Panel3.Visible = False
            Label10.Visible = False
            id_tipoamonestacion = 2
            btn_solicitar.Enabled = True

        ElseIf rbt_rescisión.Checked = True Then
            dtp_desde.Visible = False
            Panel3.Visible = False
            Label10.Visible = False
            id_tipoamonestacion = 4
            btn_solicitar.Enabled = True

        Else
            dtp_desde.Visible = False
            Panel3.Visible = False
            Label10.Visible = False
            id_tipoamonestacion = 0
            btn_solicitar.Enabled = False
        End If

        For Each row As DataGridViewRow In dtgv_fechas.Rows
            dtgv_fechas.Rows.Remove(row)
        Next

        '  MessageBox.Show(id_tipoamonestacion)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'If dtgv_fechas.SelectedRows.Count > 0 Then
        Try
            dtgv_fechas.Rows.Remove(dtgv_fechas.CurrentRow)
        Catch
        End Try
        'Else
        '    MessageBox.Show("Seleccione una casilla antes de eliminar")
        'End If

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        dtgv_fechas.Rows.Add(dtp_desde.Value.ToShortDateString)
    End Sub

    Sub cargagrid()

        cnn.Close()

        cnn.Open()

        Dim da As New SqlDataAdapter("Sp_muestramedidasdisciplinarias", cnn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@año", dtp1.Value.Year)
        da.SelectCommand.Parameters.AddWithValue("@clave", txt_clave.Text)



        Dim dt As New DataTable
        da.Fill(dt)
        dtgvp.DataSource = dt
        ' dtgvp.Columns("id").Visible = False


        cnn.Close()


        For Each row As DataGridViewRow In Me.dtgvp.Rows

            If row.Cells(“Estado”).Value = "Creada" Then
                row.DefaultCellStyle.BackColor = Color.White
            ElseIf row.Cells(“Estado”).Value = "Aplicada" Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
            ElseIf row.Cells(“Estado”).Value = "Eliminada" Then
                row.DefaultCellStyle.BackColor = Color.LightSalmon
            End If

        Next




    End Sub



    Sub guardar()

        Dim Pregunta As Integer

        Pregunta = MsgBox("¿Desea guardar la Medida Disciplinaria?", vbYesNo + vbExclamation + vbDefaultButton2, "Medida Disciplinaria")

        If Pregunta = vbYes Then


            cnn.Close()


            Dim command As New SqlCommand("Sp_insertamedidadisciplinaria", cnn)
            cnn.Open()

            command.CommandType = CommandType.StoredProcedure

            Try


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@id_empleado", txt_clave.Text)
                command.Parameters.AddWithValue("@clave_disciplianaria", clavedisciplinaria)
                command.Parameters.AddWithValue("@id_tipocompromiso", 0)
                command.Parameters.AddWithValue("@id_tipoamonestacion", id_tipoamonestacion)
                command.Parameters.AddWithValue("@fecha_aplicacion", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@comentarios", txt_faltacometida.Text)
                command.Parameters.AddWithValue("@fechainicio_amonestacion", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@fechafin_amonestacion", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@fechafalta", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@aplica", 0)
                command.Parameters.AddWithValue("@timestamp", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@variable", 1)
                command.Parameters.AddWithValue("@tipo_dis", terminodisciplinaria)
                command.Parameters.AddWithValue("@antecedentes", txt_antecedente.Text)


                command.ExecuteNonQuery()



                If id_tipoamonestacion = 3 Then
                    cargasuspensión()
                End If


                Dim comando As SqlCommand = New SqlCommand
                comando.CommandText = "select top 1 [Id_medida] FROM [AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] order by Id_medida desc"
                comando.Connection = cnn
                cnn.Close()
                cnn.Open()

                y = comando.ExecuteScalar()

                cnn.Close()


                MessageBox.Show("Medida disciplinaria guardada correctamente con el folio: " & y & "  ", "¡Correcto!")
                ' MessageBox.Show("Medida disciplinaria guardada correctamente", "¡Aviso!")
                imprimereporte()
                txt_clave.Clear()
                pbx.Visible = False
                Label4.Visible = False
                txt_nombre.Clear()
                txt_depto.Clear()
                txt_puesto.Clear()
                txt_turno.Clear()
                txt_ingreso.Clear()
                Label5.Visible = False
                cbx_tipo.Visible = False
                txt_articulo.Visible = False
                txt_articulo.Clear()
                txt_faltacometida.Visible = False
                txt_faltacometida.Clear()
                txt_antecedente.Visible = False
                txt_antecedente.Clear()
                Label6.Visible = False
                Label7.Visible = False
                Panel2.Visible = False
                Label9.Visible = False
                rbt_escrita.Checked = False
                rbt_verbal.Checked = False
                rbt_suspensión.Checked = False
                rbt_rescisión.Checked = False
                For Each row As DataGridViewRow In dtgv_fechas.Rows
                    dtgv_fechas.Rows.Remove(row)
                Next
                dtgvp.Visible = False
                btn_solicitar.Enabled = False
                txt_clave.Focus()
            Catch ex As Exception
                ' MessageBox.Show(ex.ToString)
                MessageBox.Show("Registro no guardado, contacte al área de Sistemas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cnn.Close()
            End Try



        ElseIf Pregunta = vbNo Then

            MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Sub imprimereporte()
        ContenedorReporteMedidaDisciplinaria.clave = txt_clave.Text
        ContenedorReporteMedidaDisciplinaria.id = y
        ContenedorReporteMedidaDisciplinaria.Show()

    End Sub


    Sub cargasuspensión()



        cnn.Close()


        Dim command As New SqlCommand("Sp_insertamedidadisciplinaria", cnn)
        cnn.Open()

        command.CommandType = CommandType.StoredProcedure

        Try

            For Each fila In dtgv_fechas.Rows


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@id_empleado", txt_clave.Text)
                command.Parameters.AddWithValue("@clave_disciplianaria", clavedisciplinaria)
                command.Parameters.AddWithValue("@id_tipocompromiso", 0)
                command.Parameters.AddWithValue("@id_tipoamonestacion", id_tipoamonestacion)
                command.Parameters.AddWithValue("@fecha_aplicacion", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@comentarios", txt_faltacometida.Text)
                command.Parameters.AddWithValue("@fechainicio_amonestacion", (fila.Cells("Fecha").Value))
                command.Parameters.AddWithValue("@fechafin_amonestacion", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@fechafalta", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@aplica", 0)
                command.Parameters.AddWithValue("@timestamp", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@variable", 15)
                command.Parameters.AddWithValue("@tipo_dis", terminodisciplinaria)
                command.Parameters.AddWithValue("@antecedentes", txt_antecedente.Text)


                command.ExecuteNonQuery()



            Next

        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("Registro no guardado, contacte al área de Sistemas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cnn.Close()
        End Try


    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click

        guardar()

    End Sub


    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick

        Modulo_reimprimedisciplinaria.id = Me.dtgvp.Rows(e.RowIndex).Cells("Folio").Value.ToString()


        Dim segundoForm As New ReimprimeMedida

        segundoForm.Show(Me)

    End Sub


End Class


Module Modulo_reimprimedisciplinaria

    Public id As Integer

End Module