Imports System.Data.SqlClient

Public Class Frm_cambiodeturno

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Dim filtar As New BindingSource


    Dim id As Integer
    Dim permiso As Integer
    Dim depto As String

    Sub New(id As Integer, depto As String, permiso As Integer)

        InitializeComponent()

        Me.id = id
        Me.depto = depto
        Me.permiso = permiso

    End Sub


    Sub muestraetiqueta()

        Try
            Dim lista As New List(Of String)
            cnn.Close()
            cnn.Open()
            Dim SSel As String

            Dim parametro1 As Integer
            parametro1 = txt_clave.Text


            SSel = ("


select CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
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
    ,descripcion_puesto
from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig
where vig.vigencia = 'VIGENTE' and clave = " & parametro1 & "")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn)
            da.Fill(ds)

            lbl_nombre.Text = ds.Tables(0).Rows(0).Item(1)



            lbl_dpto.Text = ds.Tables(0).Rows(0).Item(3)

            lbl_clave.Text = ds.Tables(0).Rows(0).Item(0)

            lbl_puesto.Text = ds.Tables(0).Rows(0).Item(4)

            cnn.Close()


            btn_cambiain.Enabled = True
            cbx_indi.Enabled = True
            dtp_1.Enabled = True
            dtgv_2.Visible = True
            Muestragridturno()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
            MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
            lbl_clave.Text = "Clave"
            lbl_dpto.Text = "Departamento"
            lbl_nombre.Text = "Nombre"
            lbl_puesto.Text = "Puesto"
            btn_cambiain.Enabled = False
            cbx_indi.Enabled = False
            dtp_1.Enabled = False
            dtgv_2.Visible = False

        End Try

    End Sub

    Private Sub Frm_cambiodeturno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtp1.Value = Today.Date()

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




        Muestragrid()

        'If dtp1.Value.DayOfWeek = 2 Then
        '    dtp1.Value = dtp1.Value.AddDays(6)
        'ElseIf dtp1.Value.DayOfWeek = 1 Then
        '    dtp1.Value = dtp1.Value.AddDays(7)
        'ElseIf dtp1.Value.DayOfWeek = 3 Then
        '    dtp1.Value = dtp1.Value.AddDays(5)
        'ElseIf dtp1.Value.DayOfWeek = 4 Then
        '    dtp1.Value = dtp1.Value.AddDays(4)
        'ElseIf dtp1.Value.DayOfWeek = 5 Then
        '    dtp1.Value = dtp1.Value.AddDays(3)
        'ElseIf dtp1.Value.DayOfWeek = 6 Then
        '    dtp1.Value = dtp1.Value.AddDays(2)
        'ElseIf dtp1.Value.DayOfWeek = 0 Then
        '    dtp1.Value = dtp1.Value.AddDays(1)
        'End If


        'If dtp1.Value <= Today.Date Then
        '    btn_cambiarturno.Enabled = False
        'Else
        '    btn_cambiarturno.Enabled = True
        'End If

    End Sub



    Sub Muestragrid()

        Try

            cnn.Close()
            cnn.Open()
            Dim da As New SqlDataAdapter("Sp_muestragridCambioTurno", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@clave", id)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt

            '   dtgvp.Columns("id").Visible = False
            ' dtgvp.Columns("Estado").Visible = False


            cnn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cnn.Close()
        End Try
        ' dtgvp.DataSource = filtar
    End Sub


    Sub Muestragridindividual()

        Try

            cnn.Close()
            cnn.Open()
            Dim da As New SqlDataAdapter("Sp_muestragridCambioTurno", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@clave", id)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt.AsEnumerable() _
            .Where(Function(r) r.Field(Of String)("Turno_Actual") = cbx_filtro.Text) _
            .CopyToDataTable()

            '   dtgvp.Columns("id").Visible = False
            ' dtgvp.Columns("Estado").Visible = False


            cnn.Close()

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("No tiene personal en el turno " & cbx_filtro.Text & " ", "Aviso")
            cnn.Close()
        End Try
        ' dtgvp.DataSource = filtar
    End Sub





    Sub Muestragridturno()

        Try

            cnn.Close()
            cnn.Open()
            Dim da As New SqlDataAdapter("SELECT top 5
       convert(date,[FECHA_ENTRADA]) as 'Desde'
      ,convert(date,[FECHA_SALIDA]) as 'Hasta'
      ,case
	  when [CATALOGO] = 1 then 'Matutino'
	  when [CATALOGO] = 2 then 'Vespertino'
	  when [CATALOGO] = 3 then 'Nocturno'
	  when [CATALOGO] = 4 then 'Administrativo'
      end as 'Turno'
  FROM giro.[asahi16].[Supervisor_giro].[Empturno]
  where CLAVE in (@clave) 
  order by FECHA_ENTRADA desc", cnn)
            da.SelectCommand.CommandType = CommandType.Text

            da.SelectCommand.Parameters.AddWithValue("@clave", lbl_clave.Text)


                Dim dt As New DataTable
                da.Fill(dt)
            dtgv_2.DataSource = dt
            cnn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cnn.Close()
        End Try

    End Sub

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged, cbx_turno.SelectedIndexChanged
        Dim x1 As String
        x1 = dtp1.Value.ToShortDateString
        Dim x0 As String
        x0 = cbx_turno.Text

        For i = 0 To dtgvp.Rows.Count() - 1
            Me.dtgvp.Rows(i).Cells(6).Value = x0
        Next

        For i1 = 0 To dtgvp.Rows.Count() - 1
            Me.dtgvp.Rows(i1).Cells(7).Value = x1
        Next

        If dtp1.Value.DayOfWeek = 2 Then
            dtp1.Value = dtp1.Value.AddDays(6)
        ElseIf dtp1.Value.DayOfWeek = 3 Then
            dtp1.Value = dtp1.Value.AddDays(5)
            'ElseIf dtp1.Value.DayOfWeek = 1 Then
            '    dtp1.Value = dtp1.Value.AddDays(7)
        ElseIf dtp1.Value.DayOfWeek = 4 Then
            dtp1.Value = dtp1.Value.AddDays(4)
        ElseIf dtp1.Value.DayOfWeek = 5 Then
            dtp1.Value = dtp1.Value.AddDays(3)
        ElseIf dtp1.Value.DayOfWeek = 6 Then
            dtp1.Value = dtp1.Value.AddDays(2)
        ElseIf dtp1.Value.DayOfWeek = 0 Then
            dtp1.Value = dtp1.Value.AddDays(1)
        End If


        If dtp1.Value <= Today.Date Then
            btn_cambiarturno.Enabled = False
        Else
            btn_cambiarturno.Enabled = True
        End If

    End Sub

    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = False
        Next
    End Sub

    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = True
        Next
    End Sub

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick

        Try
            Modulo_Turno.parametro = Me.dtgvp.Rows(e.RowIndex).Cells("Clave").Value.ToString()
            Modulo_Turno.parametro2 = Me.dtgvp.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
            Modulo_Turno.parametro3 = Me.dtgvp.Rows(e.RowIndex).Cells("Departamento").Value.ToString()
            Modulo_Turno.parametro4 = Me.dtgvp.Rows(e.RowIndex).Cells("Turno_Actual").Value.ToString()
            Modulo_Turno.parametro5 = Me.dtgvp.Rows(e.RowIndex).Cells("Próximo_Turno").Value.ToString()

            ' Modificacion_de_Turno.Show()

            Dim CambioTurno As New Modificacion_de_Turno(id, depto, permiso)
            CambioTurno.Show()

        Catch
        End Try
        Me.Dispose()

    End Sub




    Sub ProcesaCambiodeTurno()
        cnn.Close()
        cnn.Open()

        Dim command As New SqlCommand("Sp_cambiodeturno", cnn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Dim Pregunta As Integer

        Pregunta = MsgBox("¿Desea cargar los turnos nuevos? verifique bien su información antes de aceptar.", vbYesNo + vbExclamation + vbDefaultButton2, "Solicitud de Tiempo extra")


        If Pregunta = vbYes Then

            Try

                For Each fila In dtgvp.Rows

                    If fila.Cells("x").Value = True Then
                        command.Parameters.Clear()

                        command.Parameters.AddWithValue("@clave", (fila.Cells("Clave").Value))
                        command.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
                        command.Parameters.AddWithValue("@turno", (fila.Cells(6).Value))
                        command.Parameters.AddWithValue("@variable", 1)
                        command.Parameters.AddWithValue("@id", id)



                        command.ExecuteNonQuery()
                    End If
                Next

                MessageBox.Show("Correcto, turno(s) agregado(s) exitosamente", "¡Carga exitosa!")
                Muestragrid()

            Catch ex As Exception

                MessageBox.Show(ex.ToString)

            Finally
                cnn.Close()
            End Try

        Else

            MessageBox.Show("Acción no completada", "¡Aviso!")

        End If


    End Sub

    Private Sub btn_cambiarturno_Click(sender As Object, e As EventArgs) Handles btn_cambiarturno.Click
        ProcesaCambiodeTurno()
    End Sub

    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            muestraetiqueta()



        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
            lbl_clave.Text = "Clave"
            lbl_dpto.Text = "Departamento"
            lbl_nombre.Text = "Nombre"
            lbl_puesto.Text = "Puesto"


            btn_cambiain.Enabled = False
            cbx_indi.Enabled = False
            dtp_1.Enabled = False
            dtgv_2.Visible = False
        End If




    End Sub

    Private Sub dtp_1_ValueChanged(sender As Object, e As EventArgs) Handles dtp_1.ValueChanged, cbx_indi.SelectedIndexChanged




        If permiso <> 3 Then
            If dtp_1.Value.DayOfWeek = 2 Then
                dtp_1.Value = dtp_1.Value.AddDays(6)
            ElseIf dtp_1.Value.DayOfWeek = 3 Then
                dtp_1.Value = dtp_1.Value.AddDays(5)
            ElseIf dtp_1.Value.DayOfWeek = 4 Then
                dtp_1.Value = dtp_1.Value.AddDays(4)
            ElseIf dtp_1.Value.DayOfWeek = 5 Then
                dtp_1.Value = dtp_1.Value.AddDays(3)
            ElseIf dtp_1.Value.DayOfWeek = 6 Then
                dtp_1.Value = dtp_1.Value.AddDays(2)
            ElseIf dtp_1.Value.DayOfWeek = 0 Then
                dtp_1.Value = dtp_1.Value.AddDays(1)
            End If


            If dtp_1.Value <= Today.Date Then
                btn_cambiain.Enabled = False
            Else
                btn_cambiain.Enabled = True
            End If
        End If

    End Sub


    Sub ProcesaCambiodeTurno2()


        cnn.Close()
        cnn.Open()

        Dim command As New SqlCommand("Sp_cambiodeturno", cnn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Dim Pregunta As Integer

        Pregunta = MsgBox("¿Desea agregar el turno? verifique bien su información antes de aceptar.", vbYesNo + vbExclamation + vbDefaultButton2, "Modificación de turno")


        If Pregunta = vbYes Then

            Try




                command.Parameters.Clear()

                command.Parameters.AddWithValue("@clave", lbl_clave.Text)
                command.Parameters.AddWithValue("@fecha", dtp_1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@turno", cbx_indi.Text)
                command.Parameters.AddWithValue("@variable", 1)
                command.Parameters.AddWithValue("@id", id)



                command.ExecuteNonQuery()



                MessageBox.Show("Correcto, turno agregado exitosamente", "¡Carga exitosa!")

                Muestragridturno()

                Muestragrid()

            Catch ex As Exception

                MessageBox.Show(ex.ToString)

            Finally
                cnn.Close()
            End Try

        Else

            MessageBox.Show("Acción no completada", "¡Aviso!")

        End If


    End Sub

    Private Sub btn_cambiain_Click(sender As Object, e As EventArgs) Handles btn_cambiain.Click

        Dim y As String
        Dim comando As SqlCommand = New SqlCommand
        comando.CommandText = " select top 1 [FECHA_ENTRADA] FROM giro.[asahi16].[Supervisor_giro].[Empturno] where clave = '" & lbl_clave.Text & "' order by fecha_entrada desc"
        comando.Connection = cnn
        cnn.Close()
        cnn.Open()

        y = comando.ExecuteScalar()

        cnn.Close()



        If y >= dtp_1.Value Then
            MessageBox.Show("No puede agregar un turno con fecha menor al último registrado.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            ProcesaCambiodeTurno2()
        End If


    End Sub

    Private Sub dtgv_2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_2.CellDoubleClick



        If permiso = 3 Then

            Dim Pregunta As Integer


            Pregunta = MsgBox("Presiones 'Sí' para eliminar turno o 'No' para ir a la pantalla de actualización", vbYesNo + vbExclamation + vbDefaultButton2, "Cambio de Turno")


            If Pregunta = vbYes Then

                Try
                    cnn.Close()
                    cnn.Open()

                    Dim auto As SqlCommand = New SqlCommand(" delete FROM giro.[asahi16].[Supervisor_giro].[Empturno]
  where CLAVE = @clave and fecha_entrada = @fecha
                            ", cnn)





                    auto.Parameters.Clear()
                    auto.Parameters.Add("@clave", SqlDbType.VarChar, 20).Value = lbl_clave.Text
                    auto.Parameters.Add("@fecha", SqlDbType.Date).Value = Me.dtgv_2.Rows(e.RowIndex).Cells("Desde").Value.ToString()


                    auto.ExecuteNonQuery()


                    MessageBox.Show("¡Turno eliminado con éxito!", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Muestragridturno()
                    Muestragrid()



                Catch ex As Exception
                    MessageBox.Show("Error al eliminar registro, consulte al administrador")
                    MessageBox.Show(ex.ToString)
                    cnn.Close()
                Finally
                    cnn.Close()

                End Try



            Else
                Try
                    Modulo_Turno.parametro = lbl_clave.Text
                    Modulo_Turno.parametro2 = lbl_nombre.Text
                    Modulo_Turno.parametro3 = lbl_dpto.Text
                    Modulo_Turno.parametro4 = Me.dtgv_2.Rows(e.RowIndex).Cells("Turno").Value.ToString()
                    Modulo_Turno.parametro5 = Me.dtgv_2.Rows(e.RowIndex).Cells("Turno").Value.ToString()

                    ' Modificacion_de_Turno.Show()

                    Dim CambioTurno As New Modificacion_de_Turno(id, depto, permiso)
                    CambioTurno.Show()

                Catch
                End Try

                Me.Dispose()

            End If

        Else


            Try
                Modulo_Turno.parametro = lbl_clave.Text
                Modulo_Turno.parametro2 = lbl_nombre.Text
                Modulo_Turno.parametro3 = lbl_dpto.Text
                Modulo_Turno.parametro4 = Me.dtgv_2.Rows(e.RowIndex).Cells("Turno").Value.ToString()
                Modulo_Turno.parametro5 = Me.dtgv_2.Rows(e.RowIndex).Cells("Turno").Value.ToString()

                ' Modificacion_de_Turno.Show()

                Dim CambioTurno As New Modificacion_de_Turno(id, depto, permiso)
                CambioTurno.Show()

            Catch
            End Try
            Me.Dispose()


        End If


    End Sub

    Private Sub cbx_filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_filtro.SelectedIndexChanged
        Muestragridindividual()

    End Sub

    Private Sub btn_preautorizar_Click(sender As Object, e As EventArgs) Handles btn_preautorizar.Click
        cnn.Close()
        cnn.Open()
        Dim auto As SqlCommand = New SqlCommand("

insert into [AsahiSystem].[dbo].[Temporal_turno] values (@clave)

", cnn)


        Dim auto2 As SqlCommand = New SqlCommand("

delete from [AsahiSystem].[dbo].[Temporal_turno]

", cnn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try
            auto2.ExecuteNonQuery()

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then
                    auto.Parameters.Clear()

                    auto.Parameters.Add("@clave", SqlDbType.Int).Value = (fila.Cells("Clave").Value)

                    auto.ExecuteNonQuery()


                End If

            Next
            generar_reporte()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()
        Finally
            cnn.Close()

        End Try


    End Sub


    Sub generar_reporte()
        ContenedorCambioTurno.Show()
    End Sub



End Class

Module Modulo_Turno

    Public parametro As String
    Public parametro2 As String
    Public parametro3 As String
    Public parametro4 As String
    Public parametro5 As String
    Public parametro6 As String

End Module