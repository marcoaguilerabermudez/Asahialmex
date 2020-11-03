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
    End Sub

    Private Sub Validath_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Sub autorizar()

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
        ContenedorReporteTeN.depto = id
        ContenedorReporteTeN.fecha = dtp1.Value.ToShortDateString
        ContenedorReporteTeN.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AcomodaHoras.Show()
    End Sub
End Class