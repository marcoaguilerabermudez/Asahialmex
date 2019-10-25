Public Class SubventanaOee
    Private Sub SubventanaOee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_fecha.Text = Modulo_detalle.parametro
        lbl_hora.Text = Modulo_detalle.parametro2
        lbl_turno.Text = Modulo_detalle.parametro3
        lbl_piezas.Text = Modulo_detalle.parametro4
    End Sub

    Private Sub txtIdPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub


End Class