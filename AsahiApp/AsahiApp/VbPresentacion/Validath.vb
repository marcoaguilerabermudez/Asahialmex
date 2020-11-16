Imports System.Data.SqlClient

Public Class Validath

    Dim id As Integer
    Dim depto As String
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")

    Sub New(id As Integer, depto As String)
        InitializeComponent()
        Me.id = id
        Me.depto = depto
    End Sub

    Private Sub dtp_cuando_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        cargagrid()
    End Sub

    Sub cargagrid()



        Cn.Close()
        Cn.Open()

        Dim da As New SqlDataAdapter("Sp_validatiempoextra", Cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
        da.SelectCommand.Parameters.AddWithValue("@depto", id)
        da.SelectCommand.Parameters.AddWithValue("@var", 0)
        da.SelectCommand.Parameters.AddWithValue("@departamento", " ")


        Dim dt As New DataTable
        da.Fill(dt)
        dtgvp.DataSource = dt
        dtgvp.Columns("Id_RhIncidenciasprincipal").Visible = False
        dtgvp.Columns("ValSuper").Visible = False
        dtgvp.Columns("ValRh").Visible = False
        dtgvp.Columns("TimeStampVal").Visible = False
        dtgvp.Columns("PlanExtra").Visible = False
        dtgvp.Columns("Comedor").Visible = False

        Cn.Close()


        For Each row As DataGridViewRow In Me.dtgvp.Rows

            If row.Cells(“ValSuper”).Value = 1 Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
            ElseIf row.Cells(“ValSuper”).Value = 2 Then
                row.DefaultCellStyle.BackColor = Color.ForestGreen
            End If





        Next

        Dim col As DataGridViewColumn =
          Me.dtgvp.Columns("INC")

        col.ReadOnly = True



        For Each row As DataGridViewRow In Me.dtgvp.Rows
            'If Not IsDBNull("Plan") And IsDBNull("TE") Then


            If row.Cells("Plan").Value < row.Cells("TE").Value Then
                    row.Cells("TE").ReadOnly = False
                Else
                    row.Cells("TE").ReadOnly = True
                End If
            'End If

        Next


    End Sub

    Private Sub Validath_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Sub autorizar()

        Cn.Close()
        Cn.Open()

        Dim auto As SqlCommand = New SqlCommand("
update [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal] set incidencia = @inci, ValSuper = 1 , timestampval = getdate()
,TE = 
case
when @te = 0.25 then 15
when @te = 0.50 then 30
when @te = 0.75 then 45
when @te = 1 then 60
when @te = 1.25 then 75
when @te = 1.50 then 90
when @te = 1.75 then 105
when @te = 2.00 then 120
when @te = 2.25 then 135
when @te = 2.50 then 150
when @te = 2.75 then 165
when @te = 3.00 then 180
when @te = 3.25 then 195
when @te = 3.50 then 210
when @te = 3.75 then 225
when @te = 4 then 240
when @te = 4.25 then 255
when @te = 4.50 then 270
when @te = 4.75 then 285
when @te = 5 then 300
when @te = 5.25 then 315
when @te = 5.50 then 330
when @te = 5.75 then 345
when @te = 6 then 360
when @te = 6.25 then 375
when @te = 6.50 then 390
when @te = 6.75 then 405
when @te = 7 then 420
when @te = 7.25 then 435
when @te = 7.50 then 450
when @te = 7.75 then 465
when @te = 8 then 480
when @te = 8.25 then 495
when @te = 8.50 then 510
when @te = 8.75 then 525
when @te = 9 then 540
when @te = 9.25 then 555
when @te = 9.50 then 570
when @te = 9.75 then 585
when @te = 10 then 600
when @te = 10.25 then 615
when @te = 10.50 then 630
when @te = 10.75 then 645
when @te = 11 then 660
when @te = 11.25 then 675
when @te = 11.50 then 690
when @te = 11.75 then 705
else @te * 60
end

where Id_RhIncidenciasprincipal = @id and valsuper in (0,1)", Cn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True And fila.Cells("Plan").Value >= fila.Cells("TE").Value Then
                    auto.Parameters.Clear()
                    auto.Parameters.Add("@id", SqlDbType.Int).Value = (fila.Cells("Id_RhIncidenciasprincipal").Value)
                    auto.Parameters.Add("@inci", SqlDbType.VarChar, 5).Value = (fila.Cells("INC").Value)
                    auto.Parameters.Add("@te", SqlDbType.Float).Value = (fila.Cells("TE").Value)



                    auto.ExecuteNonQuery()

                    RI = "¡Registro(s) Validados!"
                    'Else
                    '    RI = "¡Debe palomear mínimo una casilla para validar!"

                End If

            Next

            MessageBox.Show(RI, "¡Aviso!")
            cargagrid()


        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cn.Close()
        Finally
            Cn.Close()

        End Try
    End Sub

    Sub autorizardomingo()

        Cn.Close()
        Cn.Open()

        Dim auto As SqlCommand = New SqlCommand("
update [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal] set incidencia = @inci, ValSuper = 1 , timestampval = getdate()
where Id_RhIncidenciasprincipal = @id and valsuper in (0,1)", Cn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then
                    auto.Parameters.Clear()
                    auto.Parameters.Add("@id", SqlDbType.Int).Value = (fila.Cells("Id_RhIncidenciasprincipal").Value)
                    auto.Parameters.Add("@inci", SqlDbType.VarChar, 5).Value = (fila.Cells("INC").Value)
                    'auto.Parameters.Add("@te", SqlDbType.Float).Value = (fila.Cells("TE").Value)



                    auto.ExecuteNonQuery()

                    RI = "¡Registro(s) Validados!"
                    'Else
                    '    RI = "¡Debe palomear mínimo una casilla para validar!"

                End If

            Next

            MessageBox.Show(RI, "¡Aviso!")
            cargagrid()


        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cn.Close()
        Finally
            Cn.Close()

        End Try
    End Sub



    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If dtp1.Value.DayOfWeek = 7 Then
            autorizardomingo()
        Else
            autorizar()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ContenedorReporteTeN.depto = id
        ContenedorReporteTeN.fecha = dtp1.Value.ToShortDateString
        ContenedorReporteTeN.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AcomodaHoras.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HistoricoChecadas.Show()
    End Sub


End Class