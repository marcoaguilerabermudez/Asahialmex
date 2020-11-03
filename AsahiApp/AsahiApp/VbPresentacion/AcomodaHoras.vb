Imports System.Data.SqlClient

Public Class AcomodaHoras
    Dim variable As Integer

    Dim Cnn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")

    Private Sub AcomodaHoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub Muestragrid()

        Try


            Using cnn As New SqlConnection("data source = GIRO\SQLEXPRESS ;initial catalog=Asahisystem;user id=sa;password=Pa55word")
                Dim da As New SqlDataAdapter("Sp_muestrachecadas", cnn)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
                da.SelectCommand.Parameters.AddWithValue("@clave", txt_clave.Text)

                Dim dt As New DataTable
                da.Fill(dt)
                dtgvp.DataSource = dt
                'dtgvp.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss"

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Cnn.Close()
        End Try
    End Sub


    Private Sub dtgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick


        lbl_fechahora.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Fecha").Value.ToString



    End Sub



    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            Muestragrid()




        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
            txt_clave.Clear()


        End If

    End Sub



    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        txt_clave.Clear()
        'lbl_FechaHora.Text = "Hora y Fecha"
        Try
            Muestragrid()
        Catch ex As Exception

        End Try
    End Sub


    Sub autorizar()


        Cnn.Close()
        Cnn.Open()

        Dim auto As SqlCommand = New SqlCommand("

if @variable = 0
begin

update [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal]
set Entrada = @dato , ValSuper = 1
where convert(int,Clave) = @clave and Fecha = @fecha and TurnoE = 
case
when @turno = 'Matutino' then 1
when @turno = 'Vespertino' then 2
when @turno = 'Nocturno' then 3
when @turno = 'Administrativo' then 4
end
and ValSuper in (0,1)
end
else if @variable = 1
begin

update [AsahiSystem].[dbo].[Rh_IncidenciasPrincipal]
set salida = @dato , ValSuper = 1
where convert(int,Clave) = @clave and Fecha = @fecha and TurnoE = 
case
when @turno = 'Matutino' then 1
when @turno = 'Vespertino' then 2
when @turno = 'Nocturno' then 3
when @turno = 'Administrativo' then 4
end
and ValSuper in (0,1)
end

", Cnn)



        Try
            'For Each fila In dtgvp.Rows 
            '    If fila.Cells("x").Value = True Then

            auto.Parameters.Clear()
                    auto.Parameters.AddWithValue("@clave", txt_clave.Text)
            auto.Parameters.AddWithValue("@dato", Convert.ToDateTime(lbl_fechahora.Text))
            auto.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
            auto.Parameters.AddWithValue("@turno", cbx_textra.Text)
            auto.Parameters.AddWithValue("@variable", variable)
            'auto.Parameters.Add("@te", SqlDbType.Float).Value = (fila.Cells("TE").Value)



            auto.ExecuteNonQuery()

            '    End If

            'Next




            MessageBox.Show("¡Correcto!")
            'cargagrid()


        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            Cnn.Close()
        Finally
            Cnn.Close()

        End Try
    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        autorizar()
    End Sub

    Private Sub Check_entrada_CheckedChanged(sender As Object, e As EventArgs) Handles Check_entrada.CheckedChanged
        variable = 0
    End Sub

    Private Sub Check_salida_CheckedChanged(sender As Object, e As EventArgs) Handles Check_salida.CheckedChanged
        variable = 1
    End Sub
End Class