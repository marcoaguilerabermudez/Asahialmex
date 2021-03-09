Public Class KardexEmpleado
    Private Sub KardexEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_textra.Text = "--TODO--"
    End Sub



    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then


            pbx.ImageLocation = ("V:\Recursos Humanos\CARPETA 2018\RH. FOTOGRAFIAS DEL PERSONAL\" & txt_clave.Text & ".jpg")
            Me.pbx.SizeMode = PictureBoxSizeMode.CenterImage
            Me.pbx.BorderStyle = BorderStyle.Fixed3D
            pbx.SizeMode = PictureBoxSizeMode.StretchImage
            btn_evaluar.Enabled = True

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
            txt_clave.Clear()
            btn_evaluar.Enabled = False

            pbx.ImageLocation = ("V:\Recursos Humanos\CARPETA 2018\RH. FOTOGRAFIAS DEL PERSONAL\x.jpg")
        End If



    End Sub

    Private Sub btn_evaluar_Click(sender As Object, e As EventArgs) Handles btn_evaluar.Click
        If cbx_textra.Text = "--TODO--" Then

            ContenedorReporteKardexIncidencias.clave = txt_clave.Text
            ContenedorReporteKardexIncidencias.año = 0
            ContenedorReporteKardexIncidencias.Show()

        Else

            ContenedorReporteKardexIncidencias.clave = txt_clave.Text
            ContenedorReporteKardexIncidencias.año = cbx_textra.Text
            ContenedorReporteKardexIncidencias.Show()


        End If



    End Sub
End Class