Imports System.Data.SqlClient

Public Class EvaluacionesPrincipal
    Dim id As Integer
    Dim id_eval As Integer
    Dim tipo As String
    Dim estado As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim a As String
    Dim mes As Integer
    Dim fecha As String
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")



    Sub New(id As Integer, depto As String, permiso As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso

    End Sub

    Public Sub EvaluacionesPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        a = Today.Month

        Select Case a
            Case 1
                cbx_mes.Text = "Enero"
                mes = 12
                fecha = "01/01/" & cbx_año.Text & " "
            Case 2
                cbx_mes.Text = "Febrero"
                mes = 2
                fecha = "01/02/" & cbx_año.Text & " "
            Case 3
                cbx_mes.Text = "Marzo"
                mes = 3
                fecha = "01/03/" & cbx_año.Text & " "
            Case 4
                cbx_mes.Text = "Abril"
                mes = 4
                fecha = "01/04/" & cbx_año.Text & " "
            Case 5
                cbx_mes.Text = "Mayo"
                mes = 5
                fecha = "01/05/" & cbx_año.Text & " "
            Case 6
                cbx_mes.Text = "Junio"
                mes = 6
                fecha = "01/06/" & cbx_año.Text & " "
            Case 7
                cbx_mes.Text = "Julio"
                mes = 7
                fecha = "01/07/" & cbx_año.Text & " "
            Case 8
                cbx_mes.Text = "Agosto"
                mes = 8
                fecha = "01/08/" & cbx_año.Text & " "
            Case 9
                cbx_mes.Text = "Septiembre"
                mes = 9
                fecha = "01/09/" & cbx_año.Text & " "
            Case 10
                cbx_mes.Text = "Octubre"
                mes = 10
                fecha = "01/10/" & cbx_año.Text & " "
            Case 11
                cbx_mes.Text = "Noviembre"
                mes = 11
                fecha = "01/11/" & cbx_año.Text & " "
            Case 12
                cbx_mes.Text = "Diciembre"
                mes = 12
                fecha = "01/12/" & cbx_año.Text & " "
        End Select


        cbx_año.Text = Today.Year()

        llenacombodepto()

        If depto = "04" OrElse depto = "19" OrElse depto = "07" Then
            Label1.Visible = True
            cbx_depto.Visible = True
            '   btn_solicitar.Visible = True
            cbx_mes.Enabled = True
            cbx_año.Enabled = True
            btn_liberar.Visible = True
            btn_desma.Visible = True
            btn_selec.Visible = True

        End If

        cbx_tipoeva.Text = "--Todas--"
        cbx_depto.DropDownStyle = ComboBoxStyle.DropDown
        cbx_depto.Text = "--Todos--"
        cbx_perfil.Text = "--Todos--"


        Muestragrid()

    End Sub

    Private Sub cbx_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mes.SelectedIndexChanged
        a = cbx_mes.Text
        Select Case a
            Case "Enero"
                mes = 12
                fecha = "01/01/" & cbx_año.Text & " "
            Case "Febrero"
                mes = 2
                fecha = "01/02/" & cbx_año.Text & " "
            Case "Marzo"
                mes = 3
                fecha = "01/03/" & cbx_año.Text & " "
            Case "Abril"
                mes = 4
                fecha = "01/04/" & cbx_año.Text & " "
            Case "Mayo"
                mes = 5
                fecha = "01/05/" & cbx_año.Text & " "
            Case "Junio"
                mes = 6
                fecha = "01/06/" & cbx_año.Text & " "
            Case "Julio"
                mes = 7
                fecha = "01/07/" & cbx_año.Text & " "
            Case "Agosto"
                mes = 8
                fecha = "01/08/" & cbx_año.Text & " "
            Case "Septiembre"
                mes = 9
                fecha = "01/09/" & cbx_año.Text & " "
            Case "Octubre"
                mes = 10
                fecha = "01/10/" & cbx_año.Text & " "
            Case "Noviembre"
                mes = 11
                fecha = "01/11/" & cbx_año.Text & " "
            Case "Diciembre"
                mes = 12
                fecha = "01/12/" & cbx_año.Text & " "
        End Select

    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        cbx_depto.DropDownStyle = ComboBoxStyle.DropDown
        cbx_depto.Text = "--Todos--"

    End Sub

    Private Sub cbx_depto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_depto.SelectedIndexChanged
        cbx_depto.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub



    Sub llenacombodepto()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand



        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	

select '--Todos--' as 'descripcion', '--Todos--' as 'clave'
union
select descripcion, clave from giro.[asahi16].[Supervisor_giro].[DEPTO] where CENTRO_COSTO not in ('16')
"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_depto
            .DataSource = Dt
            .DisplayMember = "descripcion"


        End With
    End Sub


    Friend Sub Muestragrid()

        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestraEvaluaciones", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@depto", depto)
            da.SelectCommand.Parameters.AddWithValue("@descripcion_depto", cbx_depto.Text)
            da.SelectCommand.Parameters.AddWithValue("@mes", mes)
            da.SelectCommand.Parameters.AddWithValue("@año", cbx_año.Text)
            da.SelectCommand.Parameters.AddWithValue("@tipoeva", cbx_tipoeva.Text)


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
        dtgvp.Columns("evaluacion").Visible = False
        dtgvp.Columns("fecha").Visible = False
        dtgvp.Columns("total_eval").Visible = False

        For Each row As DataGridViewRow In Me.dtgvp.Rows

            If row.Cells(“Estado”).Value = 0 Then
                row.DefaultCellStyle.BackColor = Color.White
            ElseIf row.Cells(“Estado”).Value = 1 Then
                row.DefaultCellStyle.BackColor = Color.Gold
            ElseIf row.Cells(“Estado”).Value = 2 Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
            ElseIf row.Cells(“Estado”).Value = 3 Then
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
            lbl_totalpuntos.Text = Me.dtgvp.Rows(e.RowIndex).Cells("total_eval").Value.ToString()
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
                Modulo_evaluaciones.e_clave = Me.dtgvp.Rows(e.RowIndex).Cells("Clave").Value.ToString()
                Modulo_evaluaciones.e_depto = Me.dtgvp.Rows(e.RowIndex).Cells("Departamento").Value.ToString()
                Modulo_evaluaciones.e_evaluacion = Me.dtgvp.Rows(e.RowIndex).Cells("Tiempo").Value.ToString()
                Modulo_evaluaciones.e_fecha = Me.dtgvp.Rows(e.RowIndex).Cells("fecha").Value.ToString()
                Modulo_evaluaciones.e_nombre = Me.dtgvp.Rows(e.RowIndex).Cells("Empleado").Value.ToString()
                Modulo_evaluaciones.e_puesto = Me.dtgvp.Rows(e.RowIndex).Cells("Puesto").Value.ToString()
                Modulo_evaluaciones.e_id = Me.dtgvp.Rows(e.RowIndex).Cells("id").Value.ToString()
                Modulo_evaluaciones.e_estado = Me.dtgvp.Rows(e.RowIndex).Cells("Estado").Value.ToString()
                Modulo_evaluaciones.e_idemp = id


                Dim segundoForm As New EvaluacionPersonal

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
            lbl_totalpuntos.Text = Me.dtgvp.Rows(e.RowIndex).Cells("total_eval").Value.ToString()
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
        MessageBox.Show(fecha)
    End Sub


    Sub generarreporte()

        If estado < 2 Then
            MessageBox.Show("Solamente se pueden imprimir evaluaciones que ya han sido calificadas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ContenedorREvaluacionSin.id_evaluaciones = id_eval
            ContenedorREvaluacionSin.teval = tipo
            ContenedorREvaluacionSin.fecha = fecha
            ContenedorREvaluacionSin.Show()

        End If

    End Sub


End Class

Module Modulo_evaluaciones

    Public e_clave As Integer
    Public e_id As Integer
    Public e_idemp As Integer
    Public e_estado As Integer
    Public e_nombre As String
    Public e_depto As String
    Public e_puesto As String
    Public e_evaluacion As String
    Public e_fecha As Date

End Module
