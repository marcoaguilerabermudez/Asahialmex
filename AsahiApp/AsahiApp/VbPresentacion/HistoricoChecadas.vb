Imports System.Data.SqlClient

Public Class HistoricoChecadas
    Dim Cnn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Private Sub HistoricoChecadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub Muestragrid()

        Try


            Using cnn As New SqlConnection("data source = GIRO\SQLEXPRESS ;initial catalog=Asahisystem;user id=sa;password=Pa55word")
                Dim da As New SqlDataAdapter("Sp_ultimaschecadas", cnn)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@clave", txt_clave.Text)


                Dim dt As New DataTable
                da.Fill(dt)
                dtgvp.DataSource = dt




            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Cnn.Close()
        End Try
    End Sub



    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            Muestragrid()
            dtgvp.Visible = True

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
            txt_clave.Clear()
            dtgvp.Visible = False
        End If

    End Sub

End Class