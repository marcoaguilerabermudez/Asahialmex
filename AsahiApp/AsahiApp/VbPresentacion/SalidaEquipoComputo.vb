Imports System.Data.SqlClient

Public Class SalidaEquipoComputo
    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Dim dp As Integer
    Dim id_equipo As Integer
    Dim y As Integer
    Dim x As Integer

    Private Sub SalidaEquipoComputo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cnn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress
        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cnn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor
        End If
    End Sub

    Sub muestraetiqueta()


        Try

            cnn.Close()
            cnn.Open()
            Dim SSel As String

            Dim parametro1 As Integer
            parametro1 = txt_clave.Text

            'Dim parametro2 As String
            'parametro2 = dtp1.Value.ToShortDateString

            SSel = ("


select vig.CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
,Turno = CASE (select TOP 1 ETT.CATALOGO  from GIRO.[asahi16].[Supervisor_giro].[Empturno] ETT
  where ett.clave = vig.CLAVE and ett.FECHA_ENTRADA <= getdate()
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
    ,vig.departamento
	,id_equipo
	,Nombre
	,Marca
	,Modelo
	,Serie
from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig
join [AsahiSystem].[dbo].[Equipos_de_computo] com
on com.usuario = RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM))
where vig.vigencia = 'VIGENTE' and vig.clave = " & parametro1 & "")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn)
            da.Fill(ds)

            txt_nombre.Text = ds.Tables(0).Rows(0).Item(1)
            txt_turno.Text = ds.Tables(0).Rows(0).Item(2)
            txt_depto.Text = ds.Tables(0).Rows(0).Item(3)
            dp = ds.Tables(0).Rows(0).Item(4)
            id_equipo = ds.Tables(0).Rows(0).Item(5)
            txt_nombreequipo.Text = ds.Tables(0).Rows(0).Item(6)
            txt_marca.Text = ds.Tables(0).Rows(0).Item(7)
            txt_modelo.Text = ds.Tables(0).Rows(0).Item(8)
            txt_serie.Text = ds.Tables(0).Rows(0).Item(9)
            cnn.Close()
            btn_guardar.Enabled = True
            gbx_historial.Visible = True
            muestragird()
        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("El empleado que ha seleccionado no está activo o no tiene equipo de cómputo asignado, verifique e intente de nuevo.", "¡Aviso!")
            cnn.Close()
            btn_guardar.Enabled = False
            gbx_historial.Visible = False
        End Try

    End Sub



    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            muestraetiqueta()
            txt_motivo.Focus()




        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
            txt_clave.Clear()
            txt_nombre.Clear()
            txt_turno.Clear()
            txt_depto.Clear()
            txt_motivo.Clear()
            txt_nombreequipo.Clear()
            txt_marca.Clear()
            txt_modelo.Clear()
            txt_serie.Clear()

            btn_guardar.Enabled = False
            gbx_historial.Visible = False

        End If

    End Sub


    Sub insertaregistro()

        Dim Pregunta As Integer


        Pregunta = MsgBox("¿Desea completar la solicitud?", vbYesNo + vbExclamation + vbDefaultButton2, "Salida de equipo de cómputo")

        If Pregunta = vbYes Then

            Dim dt = New DataTable()
            Dim strSql As String
            strSql = "Sp_insertamuestraSalidaComputo"


            Dim da = New SqlDataAdapter(strSql, cnn)
            cnn.Close()
            cnn.Open()
            da.SelectCommand.CommandType = CommandType.StoredProcedure


            da.SelectCommand.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@clave", txt_clave.Text)
            da.SelectCommand.Parameters.AddWithValue("@id_equipo", id_equipo)
            da.SelectCommand.Parameters.AddWithValue("@variable", 0)
            da.SelectCommand.Parameters.AddWithValue("@observaciones", txt_motivo.Text)


            da.Fill(dt)
            cnn.Close()


            Dim comando As SqlCommand = New SqlCommand
            comando.CommandText = " select top 1 [Id_solicitud] FROM [AsahiSystem].[dbo].[Rh_SalidaEquipoComputo] order by Id_solicitud desc"
            comando.Connection = cnn
            cnn.Close()
            cnn.Open()

            y = comando.ExecuteScalar()

            cnn.Close()



            MessageBox.Show("¡Registro realizado con éxito!", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


            txt_clave.Clear()
            txt_nombre.Clear()
            txt_turno.Clear()
            txt_depto.Clear()
            txt_motivo.Clear()
            txt_nombreequipo.Clear()
            txt_marca.Clear()
            txt_modelo.Clear()
            txt_serie.Clear()
            gbx_historial.Visible = False

            btn_guardar.Enabled = False
            generarreporte()
            ' muestragird()





        Else Pregunta = vbNo

            MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub


    Sub muestragird()

        Try
            cnn.Close()
            cnn.Open()

            '  Using cnn
            Dim da As New SqlDataAdapter("Sp_insertamuestraSalidaComputo", cnn)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
                da.SelectCommand.Parameters.AddWithValue("@clave", txt_clave.Text)
                da.SelectCommand.Parameters.AddWithValue("@id_equipo", id_equipo)
                da.SelectCommand.Parameters.AddWithValue("@variable", 1)
                da.SelectCommand.Parameters.AddWithValue("@observaciones", "")

                Dim dt As New DataTable
                da.Fill(dt)
                dtgvp.DataSource = dt
            dtgvp.Columns("id_solicitud").Visible = False


            'For Each row As DataGridViewRow In Me.dtgvp.Rows

            '    If row.Cells(“Estado”).Value = 1 Then
            '        row.DefaultCellStyle.BackColor = Color.LightBlue
            '    ElseIf row.Cells(“Estado”).Value = 2 Then
            '        row.DefaultCellStyle.BackColor = Color.ForestGreen
            '    End If
            'Next
            '  End Using
            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cnn.Close()
        End Try

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Dim comando As SqlCommand = New SqlCommand
        comando.CommandText = "if exists(select top 1 estado FROM [AsahiSystem].[dbo].[Rh_SalidaEquipoComputo] where clave = " & txt_clave.Text & " order by Id_solicitud desc)
  begin
  select top 1 estado FROM [AsahiSystem].[dbo].[Rh_SalidaEquipoComputo] where clave = " & txt_clave.Text & " order by Id_solicitud desc
  end
  else
  begin
  select 1
  end"
        comando.Connection = cnn
        cnn.Close()
        cnn.Open()

        x = comando.ExecuteScalar()

        cnn.Close()


        If x = 0 Then
            MessageBox.Show("Tiene un equipo en préstamo, no se puede completar la solicitud.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            insertaregistro()
        End If


    End Sub


    Sub generarreporte()
        ContenedorReporteSalidaComputo.id_solicitud = y
        ContenedorReporteSalidaComputo.Show()
    End Sub



    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick



        ContenedorReporteSalidaComputo.id_solicitud = Me.dtgvp.Rows(e.RowIndex).Cells("id_solicitud").Value.ToString()
        ContenedorReporteSalidaComputo.Show()

    End Sub


End Class
