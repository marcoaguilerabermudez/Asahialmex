Public Class Eleccion
    Private Sub Eleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbx.ImageLocation = ("C:/Users/erik.urbina.ASAHI/Downloads/Capturaazul.jpg")

        Me.pbx.SizeMode = PictureBoxSizeMode.CenterImage
        Me.pbx.BorderStyle = BorderStyle.Fixed3D
        pbx.SizeMode = PictureBoxSizeMode.StretchImage


        pbx2.ImageLocation = ("C:/Users/erik.urbina.ASAHI/Downloads/Capturaroja.jpg")

        Me.pbx2.SizeMode = PictureBoxSizeMode.CenterImage
        Me.pbx2.BorderStyle = BorderStyle.Fixed3D
        pbx2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class