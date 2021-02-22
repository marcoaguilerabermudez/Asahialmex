Imports System.Data.SqlClient

Public Class EvaluacionPrincipalIndirecto

    Dim id As Integer
    Dim id_eval As Integer
    Dim tipo As String
    Dim estado As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim a As String
    Dim mes As Integer
    Dim id_puesto As Integer
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")



    Sub New(id As Integer, depto As String, permiso As Integer, id_puesto As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.id_puesto = id_puesto

    End Sub


    Public Sub EvaluacionesPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'a = Today.Month
        'Select Case a
        '    Case 1
        '        cbx_mes.Text = "Enero"
        '        mes = 1
        '    Case 2
        '        cbx_mes.Text = "Febrero"
        '        mes = 2
        '    Case 3
        '        cbx_mes.Text = "Marzo"
        '        mes = 3
        '    Case 4
        '        cbx_mes.Text = "Abril"
        '        mes = 4
        '    Case 5
        '        cbx_mes.Text = "Mayo"
        '        mes = 5
        '    Case 6
        '        cbx_mes.Text = "Junio"
        '        mes = 6
        '    Case 7
        '        cbx_mes.Text = "Julio"
        '        mes = 7
        '    Case 8
        '        cbx_mes.Text = "Agosto"
        '        mes = 8
        '    Case 9
        '        cbx_mes.Text = "Septiembre"
        '        mes = 9
        '    Case 10
        '        cbx_mes.Text = "Octubre"
        '        mes = 10
        '    Case 11
        '        cbx_mes.Text = "Noviembre"
        '        mes = 11
        '    Case 12
        '        cbx_mes.Text = "Diciembre"
        '        mes = 12
        'End Select

        cbx_mes.Text = "Diciembre"
        mes = 12
        cbx_año.Text = Today.Year() - 1



        If depto = "04" OrElse depto = "19" OrElse depto = "07" Then
            Label1.Visible = True

            '  cbx_depto.Visible = True
            '  btn_solicitar.Visible = True
            '  cbx_mes.Enabled = True
            '  cbx_año.Enabled = True

            btn_liberar.Visible = True
            btn_desma.Visible = True
            btn_selec.Visible = True

        End If

        cbx_tipoeva.Text = "--Todas--"
        'cbx_depto.DropDownStyle = ComboBoxStyle.DropDown
        'cbx_depto.Text = "--Todos--"



        Muestragrid()
        llenacombodepto()
    End Sub




    ''Datagridview


    Private Sub cbx_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mes.SelectedIndexChanged
        a = cbx_mes.Text
        Select Case a
            Case "Enero"
                mes = 1
            Case "Febrero"
                mes = 2
            Case "Marzo"
                mes = 3
            Case "Abril"
                mes = 4
            Case "Mayo"
                mes = 5
            Case "Junio"
                mes = 6
            Case "Julio"
                mes = 7
            Case "Agosto"
                mes = 8
            Case "Septiembre"
                mes = 9
            Case "Octubre"
                mes = 10
            Case "Noviembre"
                mes = 11
            Case "Diciembre"
                mes = 12
        End Select

    End Sub


    Private Sub cbx_depto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_depto.SelectedIndexChanged
        cbx_depto.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub



    Sub llenacombodepto()

        Try
            Cn.Close()
            Cn.Open()

            Dim cmd As New SqlCommand("Sp_muetradepartamentosEvaluacionesIndirecto", Cn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim da As New SqlDataAdapter(cmd)

            da.SelectCommand.Parameters.AddWithValue("@depto", depto)
            da.SelectCommand.Parameters.AddWithValue("@clave", id)

            Dim dt As New DataTable

                da.Fill(dt)

            cbx_depto.ValueMember = "descripcion"
            'cbx_depto.DisplayMember = "NOMBRE_ESPECIALIDAD"
            cbx_depto.DataSource = dt
            Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Friend Sub Muestragrid()




        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestraevaluacionesIndirecto", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@depto", depto)
            da.SelectCommand.Parameters.AddWithValue("@descripcion_depto", cbx_depto.Text)
            da.SelectCommand.Parameters.AddWithValue("@mes", mes)
            da.SelectCommand.Parameters.AddWithValue("@año", cbx_año.Text)
            da.SelectCommand.Parameters.AddWithValue("@tipoeva", cbx_tipoeva.Text)
            da.SelectCommand.Parameters.AddWithValue("@puesto", id_puesto)
            da.SelectCommand.Parameters.AddWithValue("@clave", id)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt

            Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        dtgvp.Columns("Pues").Visible = False
        dtgvp.Columns("Dep").Visible = False
        dtgvp.Columns("Estado").Visible = False
        dtgvp.Columns("id").Visible = False
        dtgvp.Columns("liberacion").Visible = False
        dtgvp.Columns("aprobacion").Visible = False
        dtgvp.Columns("evaluacion").Visible = True
        dtgvp.Columns("fecha").Visible = False
        dtgvp.Columns("total_eval").Visible = False
        dtgvp.Columns("Total_Autoeval").Visible = False
        dtgvp.Columns("Total_Objetivos").Visible = False
        dtgvp.Columns("Total_Mejora").Visible = False
        dtgvp.Columns("autoeval").Visible = False


        dtgvp.Columns("evaluacion").Visible = False
        dtgvp.Columns("id_depto").Visible = False
        dtgvp.Columns("id_puesto").Visible = False

        For Each row As DataGridViewRow In Me.dtgvp.Rows

            If row.Cells(“Estado”).Value = 0 Then
                row.DefaultCellStyle.BackColor = Color.White
            ElseIf row.Cells(“Estado”).Value = 1 Then
                row.DefaultCellStyle.BackColor = Color.Gold
            ElseIf row.Cells(“Estado”).Value = 10 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            ElseIf row.Cells(“Estado”).Value = 11 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            ElseIf row.Cells(“Estado”).Value = 12 Then
                row.DefaultCellStyle.BackColor = Color.Pink
            ElseIf row.Cells(“Estado”).Value = 13 Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
            ElseIf row.Cells(“Estado”).Value = 14 Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next


        Me.dtgvp.Columns("Clave").ReadOnly = True
        Me.dtgvp.Columns("Ingreso").ReadOnly = True
        Me.dtgvp.Columns("Tiempo").ReadOnly = True
        Me.dtgvp.Columns("Departamento").ReadOnly = True
        Me.dtgvp.Columns("Empleado").ReadOnly = True
        Me.dtgvp.Columns("Puesto").ReadOnly = True
        Me.dtgvp.Columns("fecha").ReadOnly = True

    End Sub


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Muestragrid()
    End Sub



    Sub autorizar()

        Cn.Close()
        Cn.Open()
        Dim auto As SqlCommand = New SqlCommand("
update [AsahiSystem].[dbo].[Eva_evaluaciones] set estado = 1, Fecha_liberacion = getdate()
where id_evaluaciones = @ID and estado = 0

", Cn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then
                    auto.Parameters.Clear()
                    auto.Parameters.Add("@ID", SqlDbType.Int).Value = (fila.Cells("id").Value)


                    auto.ExecuteNonQuery()

                    RI = "¡Registro(s) Liberado(s)!"


                End If
            Next

            MessageBox.Show(RI, "¡Aviso!")
            Muestragrid()


        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cn.Close()
        Finally
            Cn.Close()

        End Try


    End Sub

    Private Sub dtgmuestra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellContentClick
        Try
            lbl_autorizacion.Text = Me.dtgvp.Rows(e.RowIndex).Cells("aprobacion").Value.ToString()
            lbl_evaluacion.Text = Me.dtgvp.Rows(e.RowIndex).Cells("evaluacion").Value.ToString()
            lbl_liberacion.Text = Me.dtgvp.Rows(e.RowIndex).Cells("liberacion").Value.ToString()
            lbl_autoeva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("autoeval").Value.ToString()

            lbl_puntajeeva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("total_eval").Value.ToString()
            lbl_puntajeautoeva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Total_Autoeval").Value.ToString()
            lbl_puntajemejora.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Total_Mejora").Value.ToString()
            lbl_puntajeobj.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Total_Objetivos").Value.ToString()
            lbl_totalpuntos.Text = CDbl((CDbl(lbl_puntajeeva.Text) + CDbl(lbl_puntajeautoeva.Text)) / 2) + CDbl(lbl_puntajemejora.Text) + CDbl(lbl_puntajeobj.Text)


            id_eval = Me.dtgvp.Rows(e.RowIndex).Cells("id").Value.ToString()
            tipo = Me.dtgvp.Rows(e.RowIndex).Cells("Tiempo").Value.ToString()
            estado = Me.dtgvp.Rows(e.RowIndex).Cells("Estado").Value.ToString()

        Catch
        End Try

    End Sub

    Private Sub dtgmuestra_CellContentClick2(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick

        If Me.dtgvp.Rows(e.RowIndex).Cells("Estado").Value.ToString() = 0 Then

            MessageBox.Show("La evaluación no ha sido liberada por RH", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try
                Modulo_evaluacionesindi.e_clave = Me.dtgvp.Rows(e.RowIndex).Cells("Clave").Value.ToString()
                Modulo_evaluacionesindi.e_depto = Me.dtgvp.Rows(e.RowIndex).Cells("Departamento").Value.ToString()
                Modulo_evaluacionesindi.e_evaluacion = Me.dtgvp.Rows(e.RowIndex).Cells("Tiempo").Value.ToString()
                Modulo_evaluacionesindi.e_fecha = Me.dtgvp.Rows(e.RowIndex).Cells("fecha").Value.ToString()
                Modulo_evaluacionesindi.e_nombre = Me.dtgvp.Rows(e.RowIndex).Cells("Empleado").Value.ToString()
                Modulo_evaluacionesindi.e_puesto = Me.dtgvp.Rows(e.RowIndex).Cells("Puesto").Value.ToString()
                Modulo_evaluacionesindi.e_id = Me.dtgvp.Rows(e.RowIndex).Cells("id").Value.ToString()
                Modulo_evaluacionesindi.e_estado = Me.dtgvp.Rows(e.RowIndex).Cells("Estado").Value.ToString()

                Modulo_evaluacionesindi.id_depto = Me.dtgvp.Rows(e.RowIndex).Cells("Id_depto").Value.ToString()
                Modulo_evaluacionesindi.id_puesto = Me.dtgvp.Rows(e.RowIndex).Cells("Id_puesto").Value.ToString()
                Modulo_evaluacionesindi.e_idemp = id


                Dim segundoForm As New EvaluacionIndirecto

                MuestraKardexEva.Dispose()

                segundoForm.Show(Me)


            Catch
            End Try


        End If

    End Sub



    Private Sub dtgmuestra_CellContentClick1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        Try
            lbl_autorizacion.Text = Me.dtgvp.Rows(e.RowIndex).Cells("aprobacion").Value.ToString()
            lbl_evaluacion.Text = Me.dtgvp.Rows(e.RowIndex).Cells("evaluacion").Value.ToString()
            lbl_liberacion.Text = Me.dtgvp.Rows(e.RowIndex).Cells("liberacion").Value.ToString()
            lbl_autoeva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("autoeval").Value.ToString()
            '' lbl_totalpuntos.Text = Me.dtgvp.Rows(e.RowIndex).Cells("total_eval").Value.ToString()
            lbl_puntajeeva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("total_eval").Value.ToString()
            lbl_puntajeautoeva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Total_Autoeval").Value.ToString()
            lbl_puntajemejora.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Total_Mejora").Value.ToString()
            lbl_puntajeobj.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Total_Objetivos").Value.ToString()
            lbl_totalpuntos.Text = CDbl((CInt(lbl_puntajeeva.Text) + CInt(lbl_puntajeautoeva.Text)) / 2) + CInt(lbl_puntajemejora.Text) + CInt(lbl_puntajeobj.Text)



            id_eval = Me.dtgvp.Rows(e.RowIndex).Cells("id").Value.ToString()
            tipo = Me.dtgvp.Rows(e.RowIndex).Cells("Tiempo").Value.ToString()
            estado = Me.dtgvp.Rows(e.RowIndex).Cells("Estado").Value.ToString()

        Catch
        End Try

    End Sub



    Private Sub btn_liberar_Click(sender As Object, e As EventArgs) Handles btn_liberar.Click
        autorizar()
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        generarreporte()
    End Sub


    Sub generarreporte()
        If estado < 13 Then
            MessageBox.Show("Solamente se pueden imprimir evaluaciones que ya han sido calificadas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ContenedorReporteIndirecto.id_evaluacion = id_eval

            ContenedorReporteIndirecto.fecha = "01/12/2020"
            ContenedorReporteIndirecto.Show()

        End If


    End Sub

    Private Sub cbx_tipoeva_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipoeva.SelectedIndexChanged, cbx_depto.SelectedIndexChanged
        Muestragrid()

    End Sub
End Class

Module Modulo_evaluacionesindi

    Public e_clave As Integer
    Public e_id As Integer
    Public e_idemp As Integer
    Public e_estado As Integer
    Public e_nombre As String
    Public e_depto As String
    Public e_puesto As String
    Public e_evaluacion As String
    Public e_fecha As Date
    Public id_puesto As Integer
    Public id_depto As Integer

End Module



