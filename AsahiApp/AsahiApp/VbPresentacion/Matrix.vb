Public Class Matrix
    Dim nombre As String

    Private Sub Matrix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nombre.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_nombre.Text = "" Then
            MessageBox.Show("El hecho de preguntar tu nombre fue mera cortesía, hemos estado buscándote, eres la elegida, Amalinalli", "¡Aviso!")
            nombre = "Amalinalli"
        Else
            nombre = txt_nombre.Text
        End If
        Eleccion.Show()

    End Sub


End Class

