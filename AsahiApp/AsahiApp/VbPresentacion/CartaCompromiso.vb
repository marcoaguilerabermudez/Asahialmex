Imports System.Data.SqlClient

Public Class CartaCompromiso

    Dim antecedente As Integer
    Dim fecha_antecedente As String



    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection

    Public cadenagi As String
    Public cadenaCgiro As String
    Public cnn2 As SqlConnection

    Private Sub CartaCompromiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_clave.Focus()
        dtp1.Enabled = True
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

        llenacombomotivo()
    End Sub


    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            cnn2.Close()
            cnn2.Open()
            Dim SSel As String



            SSel = ("


declare @año as int
set @año = '" & dtp1.Value.Year & "'


declare @clave as int
set @clave = '" & txt_clave.Text & "'

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
WHEN  (SELECT TOP 1 id_empleado from SQLEX.[AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] where id_empleado = @clave and DATEPART(YEAR,Fecha_Aplicacion) = @año   AND Clave_disciplinaria = 15) IS NULL THEN 0
else
1
end
,CASE
WHEN  (SELECT TOP 1 id_empleado from SQLEX.[AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] where id_empleado = @clave and DATEPART(YEAR,Fecha_Aplicacion) = @año   AND Clave_disciplinaria = 15) IS NULL THEN '01/01/1900'
else
(SELECT TOP 1 Fecha_Aplicacion from SQLEX.[AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] where id_empleado = @clave and DATEPART(YEAR,Fecha_Aplicacion) = @año   AND Clave_disciplinaria = 15)
end

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
            txt_fechainjustificada.Text = ds.Tables(0).Rows(0).Item(6)
            antecedente = ds.Tables(0).Rows(0).Item(7)
            fecha_antecedente = ds.Tables(0).Rows(0).Item(8)
            pbx.Visible = True
            pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" & txt_clave.Text & ".jpg")
            Me.pbx.SizeMode = PictureBoxSizeMode.CenterImage
            Me.pbx.BorderStyle = BorderStyle.Fixed3D
            pbx.SizeMode = PictureBoxSizeMode.StretchImage
            btn_solicitar.Enabled = True
            GroupBox2.Enabled = True
            cnn.Close()

        Catch ex As Exception
            '   MessageBox.Show(ex.ToString)
            MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
            btn_solicitar.Enabled = False
            pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/x.jpg")
            GroupBox2.Enabled = False
            pbx.Visible = False
        End Try


        If antecedente = 1 Then
            MessageBox.Show("El empleado " & txt_clave.Text & " tiene una carta compromiso el día  " & fecha_antecedente & ", verifique su información. ", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    txt_clave.Clear()
            btn_solicitar.Enabled = False
            '  pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/x.jpg")
            GroupBox2.Enabled = False
            '   pbx.Visible = False
            txt_nombre.Clear()
            txt_motivo.Clear()
            txt_puesto.Clear()
            txt_depto.Clear()
            txt_fechainjustificada.Value = "01/01/1900"
            txt_ingreso.Clear()
            txt_turno.Clear()
            Label6.Visible = False
            txt_motivo.Visible = False
        End If

    End Sub


    Sub llenacombomotivo()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand


        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	
SELECT [Nombre]
  FROM [AsahiSystem].[dbo].[Rh_TipoCompromiso]
"
            .Connection = cnn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_motivo
            .DataSource = Dt
            .DisplayMember = "Nombre"
            '.ValueMember = "id"
        End With


    End Sub

    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then

            muestraetiqueta()

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_clave.Clear()
            btn_solicitar.Enabled = False
            pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/x.jpg")
            GroupBox2.Enabled = False
            pbx.Visible = False
            txt_nombre.Clear()
            txt_motivo.Clear()
            txt_puesto.Clear()
            txt_depto.Clear()
            txt_fechainjustificada.Value = "01/01/1900"
            txt_ingreso.Clear()
            txt_turno.Clear()
            Label6.Visible = False
            txt_motivo.Visible = False
        End If
    End Sub

    Private Sub cbx_motivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_motivo.SelectedIndexChanged
        If cbx_motivo.Text = "Otro" Then
            Label6.Visible = True
            txt_motivo.Visible = True
        Else
            Label6.Visible = False
            txt_motivo.Visible = False

        End If
    End Sub


    Sub imprimereporte()
        ContenedorReporteCartaCompromiso.clave = txt_clave.Text
        ContenedorReporteCartaCompromiso.año = dtp1.Value.Year()
        ContenedorReporteCartaCompromiso.Show()
    End Sub


    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        If txt_fechainjustificada.Value.ToShortDateString = "01/01/1900" Then
            MessageBox.Show("El empleado no tiene ninguna falta aplicada en el sistema, verifique su información", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            guardar()
        End If

    End Sub


    Sub guardar()

        Dim Pregunta As Integer

        Pregunta = MsgBox("¿Desea aplicar la carta compromiso?", vbYesNo + vbExclamation + vbDefaultButton2, "Carta Compromiso")

        If Pregunta = vbYes Then


            cnn.Close()


            Dim command As New SqlCommand("Sp_insertamedidadisciplinaria", cnn)
            cnn.Open()

            command.CommandType = CommandType.StoredProcedure

            Try


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@id_empleado", txt_clave.Text)
                command.Parameters.AddWithValue("@clave_disciplianaria", 15)
                command.Parameters.AddWithValue("@id_tipocompromiso", cbx_motivo.Text)
                command.Parameters.AddWithValue("@id_tipoamonestacion", 0)
                command.Parameters.AddWithValue("@fecha_aplicacion", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@comentarios", txt_motivo.Text)
                command.Parameters.AddWithValue("@fechainicio_amonestacion", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@fechafin_amonestacion", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@fechafalta", txt_fechainjustificada.Value.ToShortDateString)
                command.Parameters.AddWithValue("@aplica", 1)
                command.Parameters.AddWithValue("@timestamp", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@variable", 0)
                command.Parameters.AddWithValue("@tipo_dis", 1)
                command.Parameters.AddWithValue("@antecedentes", "N/A")




                command.ExecuteNonQuery()



                MessageBox.Show("Carta compromiso aplicada correctamente", "¡Aviso!")
                imprimereporte()
                txt_clave.Clear()
                btn_solicitar.Enabled = False
                pbx.ImageLocation = ("V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/x.jpg")
                GroupBox2.Enabled = False
                pbx.Visible = False
                txt_nombre.Clear()
                txt_motivo.Clear()
                txt_puesto.Clear()
                txt_depto.Clear()
                txt_fechainjustificada.Value = "01/01/1900"
                txt_ingreso.Clear()
                txt_turno.Clear()
                Label6.Visible = False
                txt_motivo.Visible = False


            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            Finally
                cnn.Close()
            End Try



        ElseIf Pregunta = vbNo Then

            MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Private Sub btn_anteriores_Click(sender As Object, e As EventArgs) Handles btn_anteriores.Click
        imprimereporte()
    End Sub


End Class