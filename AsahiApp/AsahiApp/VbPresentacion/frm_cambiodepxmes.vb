Public Class frm_cambiodepxmes

    Dim a As String
    Dim mes As Integer

    Private Sub frm_cambiodepxmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = Today.Month

        Select Case a
            Case 1
                cbx_mes.Text = "Enero"
                mes = 12
            Case 2
                cbx_mes.Text = "Febrero"
                mes = 2
            Case 3
                cbx_mes.Text = "Marzo"
                mes = 3
            Case 4
                cbx_mes.Text = "Abril"
                mes = 4
            Case 5
                cbx_mes.Text = "Mayo"
                mes = 5
            Case 6
                cbx_mes.Text = "Junio"
                mes = 6
            Case 7
                cbx_mes.Text = "Julio"
                mes = 7
            Case 8
                cbx_mes.Text = "Agosto"
                mes = 8
            Case 9
                cbx_mes.Text = "Septiembre"
                mes = 9
            Case 10
                cbx_mes.Text = "Octubre"
                mes = 10
            Case 11
                cbx_mes.Text = "Noviembre"
                mes = 11
            Case 12
                cbx_mes.Text = "Diciembre"
                mes = 12
        End Select


        cbx_año.Text = Today.Year()

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        ContenedorReporteCambioPuestoxMes.mes = mes
        ContenedorReporteCambioPuestoxMes.año = cbx_año.Text
        ContenedorReporteCambioPuestoxMes.Show()
    End Sub
    'test
    Private Sub cbx_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mes.SelectedIndexChanged

        a = cbx_mes.Text
        Select Case a
            Case "Enero"
                mes = 1
            Case "Febrero"
                mes = 2
            Case "Marzo"
                mes = 3
            Case "Abril"
                mes = 4
            Case "Mayo"
                mes = 5
            Case "Junio"
                mes = 6
            Case "Julio"
                mes = 7
            Case "Agosto"
                mes = 8
            Case "Septiembre"
                mes = 9
            Case "Octubre"
                mes = 10
            Case "Noviembre"
                mes = 11
            Case "Diciembre"
                mes = 12
        End Select

    End Sub

End Class