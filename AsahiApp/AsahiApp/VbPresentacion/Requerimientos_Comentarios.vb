Public Class Requerimientos_Comentarios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ownerForm As Requerimientos_crear = Me.Owner
        ownerForm.txt_comentarios.Text = txt_descr.Text
    End Sub
End Class