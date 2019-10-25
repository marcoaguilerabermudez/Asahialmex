Public Class CapturaOEE

    Private Sub CapturaOEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub




    Private Sub txtIdPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_1.KeyPress, txt_2.KeyPress, txt_3.KeyPress, txt_4.KeyPress, txt_5.KeyPress, txt_6.KeyPress, txt_7.KeyPress, txt_8.KeyPress, txt_9.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h1.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_1.Text
        SubventanaOee.Show()
    End Sub


    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h2.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_2.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h3.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_3.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h4.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_4.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h5.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_5.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h6.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_6.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h7.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_7.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h8.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_8.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h9.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_9.Text
        SubventanaOee.Show()
    End Sub

    Private Sub txt_1_TextChanged(sender As Object, e As EventArgs) Handles txt_1.TextChanged, txt_2.TextChanged, txt_3.TextChanged, txt_4.TextChanged, txt_5.TextChanged, txt_6.TextChanged, txt_7.TextChanged, txt_8.TextChanged, txt_9.TextChanged
        Try
            Dim a As Integer = CInt(txt_1.Text.ToString)
            Dim b As Integer = CInt(txt_2.Text.ToString)
            Dim c As Integer = CInt(txt_3.Text.ToString)
            Dim d As Integer = CInt(txt_4.Text.ToString)
            Dim ee As Integer = CInt(txt_5.Text.ToString)
            Dim f As Integer = CInt(txt_6.Text.ToString)
            Dim g As Integer = CInt(txt_7.Text.ToString)
            Dim h As Integer = CInt(txt_8.Text.ToString)
            Dim i As Integer = CInt(txt_9.Text.ToString)


            lbl_acumulado1.Text = a
            lbl_acumulado2.Text = (a + b)
            lbl_acumulado3.Text = (a + b + c)
            lbl_acumulado4.Text = (a + b + c + d)
            lbl_acumulado5.Text = (a + b + c + d + ee)
            lbl_acumulado6.Text = (a + b + c + d + ee + f)
            lbl_acumulado7.Text = (a + b + c + d + ee + f + g)
            lbl_acumulado8.Text = (a + b + c + d + ee + f + g + h)
            lbl_acumulado9.Text = (a + b + c + d + ee + f + g + h + i)
        Catch
        End Try
    End Sub
End Class

Module Modulo_detalle
    Public parametro As String
    Public parametro2 As String
    Public parametro3 As String
    Public parametro4 As Integer
End Module
