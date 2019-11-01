Public Class SubventanaOee
    Dim errorg As Integer


    Private Sub SubventanaOee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_fecha.Text = Modulo_detalle.parametro
        lbl_hora.Text = Modulo_detalle.parametro2
        lbl_turno.Text = Modulo_detalle.parametro3
        lbl_piezas.Text = Modulo_detalle.parametro4
        lbl_proceso.Text = Modulo_detalle.parametro5


        GroupBox3.Visible = False


    End Sub

    Private Sub txtIdPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub rbt_cantidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_cantidad.CheckedChanged
        If lbl_proceso.Text = "FUNDICIÓN" Then
            GroupBox2.Visible = False
        ElseIf lbl_proceso.Text = "MAQUINADO" Then
            GroupBox2.Visible = False
            GroupBox3.Visible = True


        End If

    End Sub

    Private Sub rbt_tiempo_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_tiempo.CheckedChanged
        If lbl_proceso.Text = "FUNDICIÓN" Then
            GroupBox2.Visible = True
        ElseIf lbl_proceso.Text = "MAQUINADO" Then
            GroupBox2.Visible = True
            GroupBox3.Visible = False


        End If
    End Sub
End Class