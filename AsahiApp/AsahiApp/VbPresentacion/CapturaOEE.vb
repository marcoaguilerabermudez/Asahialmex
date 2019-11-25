Imports System.Data.SqlClient
Imports Negocio

Public Class CapturaOEE

    Public Cn As New SqlConnection("Data Source=GIRO\SQLEX2014;Initial Catalog=SistemaAAM;Uid=sa; Pwd=Pa55word ;MultipleActiveResultSets=true")

    '';MultipleActiveResultSets=true
    Public idh As Integer


    Private Sub CapturaOEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_1.Enabled = False
        btn_2.Enabled = False
        btn_3.Enabled = False
        btn4.Enabled = False
        btn_5.Enabled = False
        btn_6.Enabled = False
        btn_7.Enabled = False
        btn_8.Enabled = False
        btn_9.Enabled = False


        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
        b4.Enabled = False
        b5.Enabled = False
        b6.Enabled = False
        b7.Enabled = False
        b8.Enabled = False
        b9.Enabled = False

    End Sub


    Private Sub txtIdPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_1.KeyPress, txt_2.KeyPress, txt_3.KeyPress, txt_4.KeyPress, txt_5.KeyPress, txt_6.KeyPress, txt_7.KeyPress, txt_8.KeyPress, txt_9.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h1.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t1.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 1
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_1.Text = "0"
        End Try

    End Sub


    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h2.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t2.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 2
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_2.Text = "0"
        End Try
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h3.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t3.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 3
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_3.Text = "0"
        End Try
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h4.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t4.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 4
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_4.Text = "0"
        End Try
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h5.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t5.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 5
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_5.Text = "0"
        End Try
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h6.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t6.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 6
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_6.Text = "0"
        End Try
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h7.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t7.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 7
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_7.Text = "0"
        End Try

    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h8.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t8.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 8
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_8.Text = "0"
        End Try
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        Try
            DefectoM.Dispose()
            DefectoM.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h9.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t9.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 9
            DefectoM.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_9.Text = "0"
        End Try
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h1.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t1.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 1
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_1.Text = "0"
        End Try

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h2.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t2.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 2
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_2.Text = "0"
        End Try
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h3.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t3.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 3
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_3.Text = "0"
        End Try
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h4.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t4.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 4
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_4.Text = "0"
        End Try
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h5.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t5.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 5
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_5.Text = "0"
        End Try
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h6.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t6.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 6
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_6.Text = "0"
        End Try
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h7.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t7.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 7
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_7.Text = "0"
        End Try
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h8.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t8.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 8
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_8.Text = "0"
        End Try
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        Try
            Detalle2oee.Dispose()
            Detalle2oee.Close()
            Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
            Modulo_detalle.parametro2 = lbl_h9.Text
            Modulo_detalle.parametro3 = cbx_turno.Text
            Modulo_detalle.parametro4 = t9.Text
            Modulo_detalle.parametro5 = cbx_proceso.Text
            Modulo_detalle.parametro6 = 9
            Detalle2oee.Show()
        Catch ex As Exception
            MessageBox.Show("¡Necesita poner el número de piezas antes de capturar los defectos!", "¡Aviso!")
            txt_9.Text = "0"
        End Try
    End Sub

    Private Sub txt_1_TextChanged(sender As Object, e As EventArgs) Handles txt_1.TextChanged, txt_2.TextChanged, txt_3.TextChanged, txt_4.TextChanged, txt_5.TextChanged, txt_6.TextChanged, txt_7.TextChanged, txt_8.TextChanged, txt_9.TextChanged, cbx_cavidad.TextChanged

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





            If cbx_proceso.Text = "FUNDICION" Then


                lbl_acumulado1.Text = a * CInt(cbx_cavidad.Text)
                lbl_acumulado2.Text = (a + b) * CInt(cbx_cavidad.Text)
                lbl_acumulado3.Text = (a + b + c) * CInt(cbx_cavidad.Text)
                lbl_acumulado4.Text = (a + b + c + d) * CInt(cbx_cavidad.Text)
                lbl_acumulado5.Text = (a + b + c + d + ee) * CInt(cbx_cavidad.Text)
                lbl_acumulado6.Text = (a + b + c + d + ee + f) * CInt(cbx_cavidad.Text)
                lbl_acumulado7.Text = (a + b + c + d + ee + f + g) * CInt(cbx_cavidad.Text)
                lbl_acumulado8.Text = (a + b + c + d + ee + f + g + h) * CInt(cbx_cavidad.Text)
                lbl_acumulado9.Text = (a + b + c + d + ee + f + g + h + i) * CInt(cbx_cavidad.Text)

                t1.Text = a * CInt(cbx_cavidad.Text)
                t2.Text = b * CInt(cbx_cavidad.Text)
                t3.Text = c * CInt(cbx_cavidad.Text)
                t4.Text = d * CInt(cbx_cavidad.Text)
                t5.Text = ee * CInt(cbx_cavidad.Text)
                t6.Text = f * CInt(cbx_cavidad.Text)
                t7.Text = g * CInt(cbx_cavidad.Text)
                t8.Text = h * CInt(cbx_cavidad.Text)
                t9.Text = i * CInt(cbx_cavidad.Text)

            Else

                lbl_acumulado1.Text = a
                lbl_acumulado2.Text = (a + b)
                lbl_acumulado3.Text = (a + b + c)
                lbl_acumulado4.Text = (a + b + c + d)
                lbl_acumulado5.Text = (a + b + c + d + ee)
                lbl_acumulado6.Text = (a + b + c + d + ee + f)
                lbl_acumulado7.Text = (a + b + c + d + ee + f + g)
                lbl_acumulado8.Text = (a + b + c + d + ee + f + g + h)
                lbl_acumulado9.Text = (a + b + c + d + ee + f + g + h + i)


                t1.Text = a
                t2.Text = b
                t3.Text = c
                t4.Text = d
                t5.Text = ee
                t6.Text = f
                t7.Text = g
                t8.Text = h
                t9.Text = i
            End If


        Catch
        End Try

        'If txt_1.Text = "" Then
        '    txt_1.Text = "0"
        'End If

        'If txt_2.Text = "" Then
        '    txt_2.Text = "0"
        'End If

        'If txt_3.Text = "" Then
        '    txt_3.Text = "0"
        'End If

        'If txt_4.Text = "" Then
        '    txt_4.Text = "0"
        'End If

        'If txt_5.Text = "" Then
        '    txt_5.Text = "0"
        'End If

        'If txt_6.Text = "" Then
        '    txt_6.Text = "0"
        'End If

        'If txt_7.Text = "" Then
        '    txt_7.Text = "0"
        'End If

        'If txt_8.Text = "" Then
        '    txt_8.Text = "0"
        'End If

        'If txt_9.Text = "" Then
        '    txt_9.Text = "0"
        'End If

        ngok()



    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_1.KeyDown, txt_2.KeyDown, txt_3.KeyDown, txt_4.KeyDown, txt_5.KeyDown, txt_6.KeyDown, txt_7.KeyDown, txt_8.KeyDown
        If e.KeyCode = Keys.Enter AndAlso ActiveControl IsNot Nothing Then
            SelectNextControl(ActiveControl, True, True, True, True)
            e.Handled = True
        End If

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





            If cbx_proceso.Text = "FUNDICION" Then


                lbl_acumulado1.Text = a * CInt(cbx_cavidad.Text)
                lbl_acumulado2.Text = (a + b) * CInt(cbx_cavidad.Text)
                lbl_acumulado3.Text = (a + b + c) * CInt(cbx_cavidad.Text)
                lbl_acumulado4.Text = (a + b + c + d) * CInt(cbx_cavidad.Text)
                lbl_acumulado5.Text = (a + b + c + d + ee) * CInt(cbx_cavidad.Text)
                lbl_acumulado6.Text = (a + b + c + d + ee + f) * CInt(cbx_cavidad.Text)
                lbl_acumulado7.Text = (a + b + c + d + ee + f + g) * CInt(cbx_cavidad.Text)
                lbl_acumulado8.Text = (a + b + c + d + ee + f + g + h) * CInt(cbx_cavidad.Text)
                lbl_acumulado9.Text = (a + b + c + d + ee + f + g + h + i) * CInt(cbx_cavidad.Text)

                t1.Text = a * CInt(cbx_cavidad.Text)
                t2.Text = b * CInt(cbx_cavidad.Text)
                t3.Text = c * CInt(cbx_cavidad.Text)
                t4.Text = d * CInt(cbx_cavidad.Text)
                t5.Text = ee * CInt(cbx_cavidad.Text)
                t6.Text = f * CInt(cbx_cavidad.Text)
                t7.Text = g * CInt(cbx_cavidad.Text)
                t8.Text = h * CInt(cbx_cavidad.Text)
                t9.Text = i * CInt(cbx_cavidad.Text)

            Else

                lbl_acumulado1.Text = a
                lbl_acumulado2.Text = (a + b)
                lbl_acumulado3.Text = (a + b + c)
                lbl_acumulado4.Text = (a + b + c + d)
                lbl_acumulado5.Text = (a + b + c + d + ee)
                lbl_acumulado6.Text = (a + b + c + d + ee + f)
                lbl_acumulado7.Text = (a + b + c + d + ee + f + g)
                lbl_acumulado8.Text = (a + b + c + d + ee + f + g + h)
                lbl_acumulado9.Text = (a + b + c + d + ee + f + g + h + i)


                t1.Text = a
                t2.Text = b
                t3.Text = c
                t4.Text = d
                t5.Text = ee
                t6.Text = f
                t7.Text = g
                t8.Text = h
                t9.Text = i
            End If


        Catch
        End Try

        ngok()
    End Sub

    Private Sub cbx_turno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_turno.SelectedIndexChanged

        If cbx_turno.Text = "1" Then
            lbl_h1.Text = "06:55 ~ 07:55"
            lbl_h2.Text = "07:55 ~ 08:55"
            lbl_h3.Text = "08:55 ~ 09:55"
            lbl_h4.Text = "09:55 ~ 10:55"
            lbl_h5.Text = "10:55 ~ 11:55"
            lbl_h6.Text = "11:55 ~ 12:55"
            lbl_h7.Text = "12:55 ~ 13:55"
            lbl_h8.Text = "13:55 ~ 14:55"
            lbl_h9.Text = "14:55 ~ 15:25"
            txt_9.Enabled = True

            lbl_tp9.Enabled = True
            lbl_d1.Text = "510"

        ElseIf cbx_turno.Text = "2" Then

            lbl_h1.Text = "15:25 ~ 16:25"
            lbl_h2.Text = "16:25 ~ 17:25"
            lbl_h3.Text = "17:25 ~ 18:25"
            lbl_h4.Text = "18:25 ~ 19:25"
            lbl_h5.Text = "19:25 ~ 20:25"
            lbl_h6.Text = "20:25 ~ 21:25"
            lbl_h7.Text = "21:25 ~ 22:25"
            lbl_h8.Text = "22:25 ~ 23:25"
            lbl_h9.Text = "~"
            txt_9.Enabled = False
            btn_9.Enabled = False
            b9.Enabled = False
            lbl_tp9.Enabled = False
            lbl_d1.Text = "480"

        ElseIf cbx_turno.Text = "3" Then
            lbl_h1.Text = "23:25 ~ 00:25"
            lbl_h2.Text = "00:25 ~ 01:25"
            lbl_h3.Text = "01:25 ~ 02:25"
            lbl_h4.Text = "02:25 ~ 03:25"
            lbl_h5.Text = "03:25 ~ 04:25"
            lbl_h6.Text = "04:25 ~ 05:25"
            lbl_h7.Text = "05:25 ~ 06:25"
            lbl_h8.Text = "06:25 ~ 06:55"
            lbl_h9.Text = "~"
            txt_9.Enabled = False
            btn_9.Enabled = False
            b9.Enabled = False
            lbl_tp9.Enabled = False
            lbl_d1.Text = "450"
        End If

        btn_guardar.Enabled = True

        CT()
        cantidadxhora()
        Try
            lbl_v2.Text = CInt(lbl_d1.Text) - CInt(lbl_v3.Text)
        Catch
        End Try

        btn_1.Enabled = True
        btn_2.Enabled = True
        btn_3.Enabled = True
        btn4.Enabled = True
        btn_5.Enabled = True
        btn_6.Enabled = True
        btn_7.Enabled = True
        btn_8.Enabled = True

        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        b5.Enabled = True
        b6.Enabled = True
        b7.Enabled = True
        b8.Enabled = True
    End Sub

    Sub llenacombomaquina()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "
declare @var as varchar(25)
set @var = '" & cbx_proceso.Text & "'

if @var = 'FUNDICION'
BEGIN
SELECT distinct maq.Nombre
FROM [SistemaAAM].[dbo].[Standar_fundicion] es
join [SistemaAAM].[dbo].Pro_Cat_Maquinas maq
on es.[id_maquina] = Maq.id_maquina


END
ELSE if @var = 'MAQUINADO'
BEGIN
SELECT distinct maq.Nombre
FROM [SistemaAAM].[dbo].[Standar_maquinado] es
join [SistemaAAM].[dbo].Pro_Cat_Maquinas maq
on es.[id_maquina] = Maq.id_maquina
where es.id_proceso = 2

END
ELSE if @var = 'LEAKTEST'
BEGIN
SELECT distinct maq.Nombre
FROM [SistemaAAM].[dbo].[Standar_maquinado] es
join [SistemaAAM].[dbo].Pro_Cat_Maquinas maq
on es.[id_maquina] = Maq.id_maquina
where es.id_proceso = 3

END
ELSE if @var = 'ENSAMBLE'
BEGIN
SELECT distinct maq.Nombre
FROM [SistemaAAM].[dbo].[Standar_maquinado] es
join [SistemaAAM].[dbo].Pro_Cat_Maquinas maq
on es.[id_maquina] = Maq.id_maquina
where es.id_proceso = 4

END
ELSE if @var = 'ACABADO'
BEGIN
SELECT distinct maq.Nombre
FROM [SistemaAAM].[dbo].[Standar_maquinado] es
join [SistemaAAM].[dbo].Pro_Cat_Maquinas maq
on es.[id_maquina] = Maq.id_maquina
where es.id_proceso = 5

END"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_maquina
            .DataSource = Dt
            .DisplayMember = "nombre"
            '.ValueMember = "id"
        End With
        'totales()

    End Sub

    Sub llenacombopieza()
        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "
declare @var as varchar(30)
set @var = '" & cbx_proceso.Text & "'

if @var = 'FUNDICION'
BEGIN

  SELECT distinct pie.Nombre
FROM [SistemaAAM].[dbo].[Standar_fundicion] es
join [SistemaAAM].[dbo].Pro_Cat_Pieza pie
on es.[id_pieza] = pie.Id_pieza
join [SistemaAAM].[dbo].Pro_Cat_Maquinas maq
on es.[id_maquina] = Maq.id_maquina
where maq.Nombre = '" & cbx_maquina.Text & "'
end 
else
begin


  SELECT distinct  pie.Nombre
FROM [SistemaAAM].[dbo].[Standar_maquinado] es
join [SistemaAAM].[dbo].Pro_Cat_Pieza pie
on es.[id_pieza] = pie.Id_pieza
join [SistemaAAM].[dbo].Pro_Cat_Maquinas maq
on es.[id_maquina] = Maq.id_maquina
where maq.Nombre = '" & cbx_maquina.Text & "'
end
"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_pieza
            .DataSource = Dt
            .DisplayMember = "nombre"
            '.ValueMember = "id"
        End With


    End Sub



    Sub llenacombomolde()
        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "
declare @var as integer
set @var = (select [Id_pieza] from [SistemaAAM].[dbo].[Pro_Cat_Pieza] where nombre = '" & cbx_pieza.Text & "')

select codigo FROM [SistemaAAM].[dbo].[Pro_Cat_Moldes] where id_producto = @var

"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_molde
            .DataSource = Dt
            .DisplayMember = "codigo"
            '.ValueMember = "id"
        End With
        'totales()

    End Sub


    Sub CT()
        Try
            Dim SQL As String

            Dim Rs As SqlDataReader
            Dim Com As New SqlCommand


            Com.Connection = Cn
            Cn.Open()

            SQL = " declare @proceso as varchar(30)
set @proceso = '" & cbx_proceso.Text & "'

if @proceso = 'FUNDICION'
BEGIN


  declare @id_pieza as int
  set @id_pieza = (select Id_pieza from [SistemaAAM].[dbo].Pro_Cat_Pieza where Nombre = '" & cbx_pieza.Text & "')

select top 1 ct, cavidad
FROM [SistemaAAM].[dbo].[Standar_fundicion] es
where 
 es.Id_pieza = @id_pieza
 and  es.id_molde = (select id_molde from [SistemaAAM].[dbo].Pro_Cat_Moldes where codigo = '" & cbx_molde.Text & "' AND Id_producto = @id_pieza)
 and es.id_maquina = (select id_maquina from [SistemaAAM].[dbo].Pro_Cat_Maquinas where Nombre = '" & cbx_maquina.Text & "' )


END 
ELSE
BEGIN

            Select top 1 CT, 1
            From [SistemaAAM].[dbo].[Standar_maquinado] es
            Join [SistemaAAM].[dbo].Pro_Cat_Pieza pie
            On es.[id_pieza] = pie.Id_pieza
            Join [SistemaAAM].[dbo].Pro_Cat_Maquinas maq
            On es.[id_maquina] = Maq.id_maquina
            where
                maq.Nombre = '" & cbx_maquina.Text & "'
            And
                pie.nombre = '" & cbx_pieza.Text & "'
            And es.id_proceso =
            case
            when '" & cbx_proceso.Text & "' = 'MAQUINADO'  then 2
            when '" & cbx_proceso.Text & "' = 'FUNDICION'  then 1
            when '" & cbx_proceso.Text & "' = 'LEAKTEST'  then 3
            when '" & cbx_proceso.Text & "' = 'ENSAMBLE'  then 4
            when '" & cbx_proceso.Text & "' = 'ACABADO'  then 5
            End
END


"

            Com = New SqlCommand(SQL, Cn)

                Rs = Com.ExecuteReader()

            Rs.Read()
            lbl_v4.Text = Format(CDbl(Rs(0)), "0.00")

            Rs.Close()
            Cn.Close()
        Catch ex As Exception
            'MessageBox.Show("Seleccione otra cavidad", "¡Aviso!")
            lbl_v4.Text = "0"
            'cbx_cavidad.Items.Add(1)
            'cbx_cavidad.Items.Add(2)
            'cbx_cavidad.Items.Add(3)
            'cbx_cavidad.Items.Add(4)
            'cbx_cavidad.Items.Add(5)
            'cbx_cavidad.Items.Add(6)
            'cbx_cavidad.Items.Add(7)
            'cbx_cavidad.Items.Add(8)
            'cbx_cavidad.Items.Add(9)
            'cbx_cavidad.Items.Add(10)
            'cbx_cavidad.Items.Add(11)
            'cbx_cavidad.Items.Add(12)


            Cn.Close()

        End Try


    End Sub

    Private Sub cbx_proceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_proceso.TextChanged
        llenacombomaquina()
        llenacombopieza()


    End Sub

    Private Sub cbx_pieza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pieza.TextChanged
        llenacombomolde()


    End Sub

    Private Sub cbx_maquina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_maquina.TextChanged

        llenacombopieza()


    End Sub



    Sub cantidadxhora()

        Try

            If cbx_proceso.Text = "FUNDICION" Then





                lbl_cp1.Text = CInt((60 - lbl_tp1.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                lbl_cp2.Text = CInt((60 - lbl_tp2.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                lbl_cp3.Text = CInt((60 - lbl_tp3.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                lbl_cp4.Text = CInt((60 - lbl_tp4.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                lbl_cp5.Text = CInt((60 - lbl_tp5.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                lbl_cp6.Text = CInt((60 - lbl_tp6.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                lbl_cp7.Text = CInt((60 - lbl_tp7.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)

                If cbx_turno.Text = 1 Then
                    lbl_cp8.Text = CInt((60 - lbl_tp8.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                ElseIf cbx_turno.Text = 2 Then
                    lbl_cp8.Text = CInt((60 - lbl_tp8.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                ElseIf cbx_turno.Text = 3 Then
                    lbl_cp8.Text = CInt((30 - lbl_tp8.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                End If



                If cbx_turno.Text = 1 Then
                    lbl_cp9.Text = CInt((30 - lbl_tp9.Text) / (lbl_v4.Text / 60)) * CInt(cbx_cavidad.Text)
                ElseIf cbx_turno.Text = 2 Then
                    lbl_cp9.Text = "0"
                ElseIf cbx_turno.Text = 3 Then
                    lbl_cp9.Text = "0"
                End If

            Else

                lbl_cp1.Text = CInt((60 - lbl_tp1.Text) / lbl_v4.Text)
                lbl_cp2.Text = CInt((60 - lbl_tp2.Text) / lbl_v4.Text)
                lbl_cp3.Text = CInt((60 - lbl_tp3.Text) / lbl_v4.Text)
                lbl_cp4.Text = CInt((60 - lbl_tp4.Text) / lbl_v4.Text)
                lbl_cp5.Text = CInt((60 - lbl_tp5.Text) / lbl_v4.Text)
                lbl_cp6.Text = CInt((60 - lbl_tp6.Text) / lbl_v4.Text)
                lbl_cp7.Text = CInt((60 - lbl_tp7.Text) / lbl_v4.Text)

                If cbx_turno.Text = 1 Then
                    lbl_cp8.Text = CInt((60 - lbl_tp8.Text) / lbl_v4.Text)
                ElseIf cbx_turno.Text = 2 Then
                    lbl_cp8.Text = CInt((60 - lbl_tp8.Text) / lbl_v4.Text)
                ElseIf cbx_turno.Text = 3 Then
                    lbl_cp8.Text = CInt((30 - lbl_tp8.Text) / lbl_v4.Text)
                End If



                If cbx_turno.Text = 1 Then
                    lbl_cp9.Text = CInt((30 - lbl_tp9.Text) / lbl_v4.Text)
                ElseIf cbx_turno.Text = 2 Then
                    lbl_cp9.Text = "0"
                ElseIf cbx_turno.Text = 3 Then
                    lbl_cp9.Text = "0"
                End If



            End If

        Catch
        End Try

        cantidadpok()

    End Sub

    Sub cantidadpok()
        Dim a As Integer = lbl_cp1.Text
        Dim b As Integer = lbl_cp2.Text
        Dim c As Integer = lbl_cp3.Text
        Dim d As Integer = lbl_cp4.Text
        Dim f As Integer = lbl_cp5.Text
        Dim g As Integer = lbl_cp6.Text
        Dim h As Integer = lbl_cp7.Text
        Dim i As Integer = lbl_cp8.Text
        Dim j As Integer = lbl_cp9.Text
        lbl_v1.Text = a + b + c + d + f + g + h + i + j
    End Sub

    Private Sub lbl_tp1_Click(sender As Object, e As EventArgs) Handles lbl_tp1.TextChanged, lbl_tp2.TextChanged, lbl_tp3.TextChanged, lbl_tp4.TextChanged, lbl_tp5.TextChanged, lbl_tp6.TextChanged, lbl_tp7.TextChanged, lbl_tp8.TextChanged, lbl_tp9.TextChanged
        Try
            Dim a As Integer = lbl_tp1.Text
            Dim b As Integer = lbl_tp2.Text
            Dim c As Integer = lbl_tp3.Text
            Dim d As Integer = lbl_tp4.Text
            Dim f As Integer = lbl_tp5.Text
            Dim g As Integer = lbl_tp6.Text
            Dim h As Integer = lbl_tp7.Text
            Dim i As Integer = lbl_tp8.Text
            Dim j As Integer = lbl_tp9.Text
            lbl_v2.Text = a + b + c + d + f + g + h + i + j
        Catch
        End Try
    End Sub

    Private Sub lbl_acumulado9_Click(sender As Object, e As EventArgs) Handles lbl_acumulado9.TextChanged

        If cbx_proceso.Text = "FUNDICION" Then

            lbl_t1.Text = CInt(lbl_acumulado9.Text)
        Else
            lbl_t1.Text = lbl_acumulado9.Text

        End If


    End Sub

    Private Sub lbl_t1_Click(sender As Object, e As EventArgs) Handles lbl_t1.TextChanged, lbl_t2.TextChanged, lbl_t3.TextChanged, lbl_t4.TextChanged, lbl_t9.TextChanged
        Try
            Dim a As Integer = lbl_t1.Text
            Dim b As Integer = lbl_t2.Text
            Dim c As Integer = lbl_t3.Text
            Dim d As Integer = lbl_t4.Text
            Dim f As Integer = lbl_t9.Text

            lbl_t5.Text = a - (b + c + d + f)
        Catch
        End Try
    End Sub

    Private Sub lbl_d1_Click(sender As Object, e As EventArgs) Handles lbl_d1.TextChanged, lbl_d2.TextChanged, lbl_d3.TextChanged, lbl_d4.TextChanged, lbl_d5.TextChanged, lbl_d6.TextChanged
        Try
            Dim a As Integer = lbl_d1.Text
            Dim b As Integer = lbl_d2.Text
            Dim c As Integer = lbl_d3.Text
            Dim d As Integer = lbl_d4.Text
            Dim f As Integer = lbl_d5.Text
            Dim g As Integer = lbl_d6.Text

            lbl_d7.Text = a - (b + c + d + f + g)
        Catch
        End Try
    End Sub

    Private Sub lbl_v3_Click(sender As Object, e As EventArgs) Handles lbl_v3.TextChanged
        Try
            lbl_v2.Text = CInt(lbl_d1.Text) - CInt(lbl_v3.Text)
        Catch
        End Try
    End Sub

    Private Sub cbx_molde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_molde.SelectedIndexChanged
        If cbx_proceso.Text = "FUNDICION" Then

            ''llenacombocavidad()
            CT()
        Else

            Try
                ' llenacombocavidad()
                cbx_cavidad.Text = "1"

                ''cantidadxhora()

                lbl_v2.Text = CInt(lbl_d1.Text) - CInt(lbl_v3.Text)
            Catch
            End Try

        End If
    End Sub


    Private Sub cbx_cavidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_cavidad.SelectedIndexChanged
        If cbx_proceso.Text = "FUNDICION" Then

            Try
                CT()
                cantidadxhora()

                lbl_v2.Text = CInt(lbl_d1.Text) - CInt(lbl_v3.Text)
            Catch
                MessageBox.Show("Seleccione otra cavidad", "¡Aviso!")
            End Try

        Else
        End If
    End Sub


    Sub llenacombocavidad()
        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "select cavidad FROM [SistemaAAM].[dbo].[Pro_Cat_cavidades] where molde = '" & cbx_molde.Text & "'
"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_cavidad
            .DataSource = Dt
            .DisplayMember = "cavidad"
            '.ValueMember = "id"
        End With
        'totales()
    End Sub

    Sub calculotppxhora()
        Dim h1 As Integer = 0
        Dim h2 As Integer = 0
        Dim h3 As Integer = 0
        Dim h4 As Integer = 0
        Dim h5 As Integer = 0
        Dim h6 As Integer = 0
        Dim h7 As Integer = 0
        Dim h8 As Integer = 0
        Dim h9 As Integer = 0




        For Each fila As DataGridViewRow In dtgvp.Rows
            If fila.Cells("id_error").Value = 66 OrElse fila.Cells("id_error").Value = 67 OrElse fila.Cells("id_error").Value = 68 OrElse fila.Cells("id_error").Value = 69 OrElse fila.Cells("id_error").Value = 70 OrElse fila.Cells("id_error").Value = 71 OrElse fila.Cells("id_error").Value = 72 OrElse fila.Cells("id_error").Value = 73 OrElse fila.Cells("id_error").Value = 126 OrElse fila.Cells("id_error").Value = 127 Then


                If fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 1 And fila.Cells("Valor").Value = 2 Then
                    h1 += Convert.ToDouble(fila.Cells("Cantidad").Value)
                ElseIf fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 2 And fila.Cells("Valor").Value = 2 Then
                    h2 += Convert.ToDouble(fila.Cells("Cantidad").Value)
                ElseIf fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 3 And fila.Cells("Valor").Value = 2 Then
                    h3 += Convert.ToDouble(fila.Cells("Cantidad").Value)
                ElseIf fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 4 And fila.Cells("Valor").Value = 2 Then
                    h4 += Convert.ToDouble(fila.Cells("Cantidad").Value)
                ElseIf fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 5 And fila.Cells("Valor").Value = 2 Then
                    h5 += Convert.ToDouble(fila.Cells("Cantidad").Value)
                ElseIf fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 6 And fila.Cells("Valor").Value = 2 Then
                    h6 += Convert.ToDouble(fila.Cells("Cantidad").Value)
                ElseIf fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 7 And fila.Cells("Valor").Value = 2 Then
                    h7 += Convert.ToDouble(fila.Cells("Cantidad").Value)
                ElseIf fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 8 And fila.Cells("Valor").Value = 2 Then
                    h8 += Convert.ToDouble(fila.Cells("Cantidad").Value)
                ElseIf fila.Cells("id_error").Value = (66 OrElse 67 OrElse 68 OrElse 69 OrElse 70 OrElse 71 OrElse 72 OrElse 73 OrElse 126 OrElse 127) And fila.Cells("id_hora").Value = 9 And fila.Cells("Valor").Value = 2 Then
                    h9 += Convert.ToDouble(fila.Cells("Cantidad").Value)

                End If
            Else


            End If



        Next
        ''And fila.Cells("Valor").Value = 2
        ''fila.Cells("id_error").Value = 66 OrElse fila.Cells("id_error").Value = 67 OrElse fila.Cells("id_error").Value = 68 OrElse fila.Cells("id_error").Value = 69 OrElse fila.Cells("id_error").Value = 70 OrElse fila.Cells("id_error").Value = 71 OrElse fila.Cells("id_error").Value = 72 OrElse fila.Cells("id_error").Value = 73

        lbl_tp1.Text = h1
        lbl_tp2.Text = h2
        lbl_tp3.Text = h3
        lbl_tp4.Text = h4
        lbl_tp5.Text = h5
        lbl_tp6.Text = h6
        lbl_tp7.Text = h7
        lbl_tp8.Text = h8
        lbl_tp9.Text = h9






    End Sub

    Sub ngxhora()
        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        Dim n3 As Integer = 0
        Dim n4 As Integer = 0
        Dim n5 As Integer = 0
        Dim n6 As Integer = 0
        Dim n7 As Integer = 0
        Dim n8 As Integer = 0
        Dim n9 As Integer = 0

        For Each fila As DataGridViewRow In dtgvp.Rows
            If fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 1 And fila.Cells("Valor").Value = 1 Then
                n1 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 2 And fila.Cells("Valor").Value = 1 Then
                n2 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 3 And fila.Cells("Valor").Value = 1 Then
                n3 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 4 And fila.Cells("Valor").Value = 1 Then
                n4 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 5 And fila.Cells("Valor").Value = 1 Then
                n5 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 6 And fila.Cells("Valor").Value = 1 Then
                n6 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 7 And fila.Cells("Valor").Value = 1 Then
                n7 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 8 And fila.Cells("Valor").Value = 1 Then
                n8 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = (3 OrElse 4 OrElse 5 OrElse 6 OrElse 7 OrElse 8 OrElse 9 OrElse 10 OrElse 11 OrElse 12 OrElse 15 OrElse 13 OrElse 14 OrElse 15 OrElse 16 OrElse 17 OrElse 18 OrElse 19 OrElse 20 OrElse 21 OrElse 22 OrElse 23 OrElse 24 OrElse 25 OrElse 26 OrElse 27 OrElse 28 OrElse 29 OrElse 30 OrElse 31 OrElse 32 OrElse 33 OrElse 34 OrElse 35 OrElse 36 OrElse 37 OrElse 38 OrElse 39 OrElse 40 OrElse 41 OrElse 42 OrElse 43 OrElse 44 OrElse 45 OrElse 46 OrElse 47 OrElse 48 OrElse 49 OrElse 50 OrElse 51) And fila.Cells("id_hora").Value = 9 And fila.Cells("Valor").Value = 1 Then
                n9 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            End If
        Next

        ''fila.Cells("id_error").Value = 3 OrElse fila.Cells("id_error").Value = 4 OrElse fila.Cells("id_error").Value = 5 OrElse fila.Cells("id_error").Value = 6 OrElse fila.Cells("id_error").Value = 7 OrElse fila.Cells("id_error").Value = 8 OrElse fila.Cells("id_error").Value = 9 OrElse fila.Cells("id_error").Value = 10 OrElse fila.Cells("id_error").Value = 11 OrElse fila.Cells("id_error").Value = 12 OrElse fila.Cells("id_error").Value = 15 OrElse fila.Cells("id_error").Value = 13 OrElse fila.Cells("id_error").Value = 14 OrElse fila.Cells("id_error").Value = 15 OrElse fila.Cells("id_error").Value = 16 OrElse fila.Cells("id_error").Value = 17 OrElse fila.Cells("id_error").Value = 18 OrElse fila.Cells("id_error").Value = 19 OrElse fila.Cells("id_error").Value = 20 OrElse fila.Cells("id_error").Value = 21 OrElse fila.Cells("id_error").Value = 22 OrElse fila.Cells("id_error").Value = 23 OrElse fila.Cells("id_error").Value = 24 OrElse fila.Cells("id_error").Value = 25 OrElse fila.Cells("id_error").Value = 26 OrElse fila.Cells("id_error").Value = 27 OrElse fila.Cells("id_error").Value = 28 OrElse fila.Cells("id_error").Value = 29 OrElse fila.Cells("id_error").Value = 30 OrElse fila.Cells("id_error").Value = 31 OrElse fila.Cells("id_error").Value = 32 OrElse fila.Cells("id_error").Value = 33 OrElse fila.Cells("id_error").Value = 34 OrElse fila.Cells("id_error").Value = 35 OrElse fila.Cells("id_error").Value = 36 OrElse fila.Cells("id_error").Value = 37 OrElse fila.Cells("id_error").Value = 38 OrElse fila.Cells("id_error").Value = 39 OrElse fila.Cells("id_error").Value = 40 OrElse fila.Cells("id_error").Value = 41 OrElse fila.Cells("id_error").Value = 42 OrElse fila.Cells("id_error").Value = 43 OrElse fila.Cells("id_error").Value = 44 OrElse fila.Cells("id_error").Value = 45 OrElse fila.Cells("id_error").Value = 46 OrElse fila.Cells("id_error").Value = 47 OrElse fila.Cells("id_error").Value = 48 OrElse fila.Cells("id_error").Value = 49 OrElse fila.Cells("id_error").Value = 50 OrElse fila.Cells("id_error").Value = 51


        ng1.Text = n1
        ng2.Text = n2
        ng3.Text = n3
        ng4.Text = n4
        ng5.Text = n5
        ng6.Text = n6
        ng7.Text = n7
        ng8.Text = n8
        ng9.Text = n9

    End Sub


    Sub etiquetaspieza()
        Dim c1 As Integer = 0
        Dim c2 As Integer = 0
        Dim c3 As Integer = 0
        Dim c4 As Integer = 0


        For Each fila As DataGridViewRow In dtgvp.Rows
            If fila.Cells("id_error").Value = 3 OrElse fila.Cells("id_error").Value = 4 OrElse fila.Cells("id_error").Value = 5 OrElse fila.Cells("id_error").Value = 6 OrElse fila.Cells("id_error").Value = 7 OrElse fila.Cells("id_error").Value = 8 OrElse fila.Cells("id_error").Value = 9 OrElse fila.Cells("id_error").Value = 10 OrElse fila.Cells("id_error").Value = 11 OrElse fila.Cells("id_error").Value = 12 OrElse fila.Cells("id_error").Value = 15 OrElse fila.Cells("id_error").Value = 16 OrElse fila.Cells("id_error").Value = 17 OrElse fila.Cells("id_error").Value = 18 OrElse fila.Cells("id_error").Value = 19 OrElse fila.Cells("id_error").Value = 20 OrElse fila.Cells("id_error").Value = 21 OrElse fila.Cells("id_error").Value = 22 OrElse fila.Cells("id_error").Value = 23 OrElse fila.Cells("id_error").Value = 40 OrElse fila.Cells("id_error").Value = 41 OrElse fila.Cells("id_error").Value = 42 OrElse fila.Cells("id_error").Value = 43 OrElse fila.Cells("id_error").Value = 44 OrElse fila.Cells("id_error").Value = 45 OrElse fila.Cells("id_error").Value = 46 OrElse fila.Cells("id_error").Value = 47 OrElse fila.Cells("id_error").Value = 48 OrElse fila.Cells("id_error").Value = 49 OrElse fila.Cells("id_error").Value = 50 OrElse fila.Cells("id_error").Value = 51 Then
                c1 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = 13 OrElse fila.Cells("id_error").Value = 14 OrElse fila.Cells("id_error").Value = 16 OrElse fila.Cells("id_error").Value = 25 OrElse fila.Cells("id_error").Value = 26 OrElse fila.Cells("id_error").Value = 27 OrElse fila.Cells("id_error").Value = 28 OrElse fila.Cells("id_error").Value = 29 OrElse fila.Cells("id_error").Value = 30 OrElse fila.Cells("id_error").Value = 31 OrElse fila.Cells("id_error").Value = 32 OrElse fila.Cells("id_error").Value = 33 OrElse fila.Cells("id_error").Value = 34 OrElse fila.Cells("id_error").Value = 35 OrElse fila.Cells("id_error").Value = 36 OrElse fila.Cells("id_error").Value = 37 Then
                c2 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = 24 OrElse fila.Cells("id_error").Value = 39 Then
                c3 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = 38 Then
                c4 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            End If
        Next

        lbl_t2.Text = c1
        lbl_t3.Text = c2
        lbl_t4.Text = c3
        lbl_t9.Text = c4

    End Sub

    Sub etiquetastiempo()
        Dim t1 As Integer = 0
        Dim t2 As Integer = 0
        Dim t3 As Integer = 0
        Dim t4 As Integer = 0
        Dim t5 As Integer = 0

        For Each fila As DataGridViewRow In dtgvp.Rows
            If fila.Cells("id_error").Value = 121 OrElse fila.Cells("id_error").Value = 1 OrElse fila.Cells("id_error").Value = 2 Then
                t1 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = 109 OrElse fila.Cells("id_error").Value = 110 OrElse fila.Cells("id_error").Value = 111 OrElse fila.Cells("id_error").Value = 112 OrElse fila.Cells("id_error").Value = 113 OrElse fila.Cells("id_error").Value = 114 OrElse fila.Cells("id_error").Value = 115 OrElse fila.Cells("id_error").Value = 116 OrElse fila.Cells("id_error").Value = 117 OrElse fila.Cells("id_error").Value = 118 OrElse fila.Cells("id_error").Value = 119 OrElse fila.Cells("id_error").Value = 120 OrElse fila.Cells("id_error").Value = 130 Then
                t2 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = 52 OrElse fila.Cells("id_error").Value = 53 OrElse fila.Cells("id_error").Value = 54 OrElse fila.Cells("id_error").Value = 55 OrElse fila.Cells("id_error").Value = 56 OrElse fila.Cells("id_error").Value = 57 OrElse fila.Cells("id_error").Value = 58 OrElse fila.Cells("id_error").Value = 59 OrElse fila.Cells("id_error").Value = 60 OrElse fila.Cells("id_error").Value = 61 OrElse fila.Cells("id_error").Value = 62 OrElse fila.Cells("id_error").Value = 63 OrElse fila.Cells("id_error").Value = 64 OrElse fila.Cells("id_error").Value = 65 Then
                t3 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = 74 OrElse fila.Cells("id_error").Value = 75 OrElse fila.Cells("id_error").Value = 76 OrElse fila.Cells("id_error").Value = 77 OrElse fila.Cells("id_error").Value = 78 OrElse fila.Cells("id_error").Value = 79 OrElse fila.Cells("id_error").Value = 80 OrElse fila.Cells("id_error").Value = 81 OrElse fila.Cells("id_error").Value = 82 OrElse fila.Cells("id_error").Value = 83 OrElse fila.Cells("id_error").Value = 84 OrElse fila.Cells("id_error").Value = 85 OrElse fila.Cells("id_error").Value = 86 OrElse fila.Cells("id_error").Value = 87 OrElse fila.Cells("id_error").Value = 88 OrElse fila.Cells("id_error").Value = 89 OrElse fila.Cells("id_error").Value = 90 OrElse fila.Cells("id_error").Value = 91 OrElse fila.Cells("id_error").Value = 92 OrElse fila.Cells("id_error").Value = 93 OrElse fila.Cells("id_error").Value = 94 OrElse fila.Cells("id_error").Value = 95 OrElse fila.Cells("id_error").Value = 96 OrElse fila.Cells("id_error").Value = 97 OrElse fila.Cells("id_error").Value = 98 OrElse fila.Cells("id_error").Value = 99 OrElse fila.Cells("id_error").Value = 100 OrElse fila.Cells("id_error").Value = 101 OrElse fila.Cells("id_error").Value = 102 OrElse fila.Cells("id_error").Value = 103 OrElse fila.Cells("id_error").Value = 104 OrElse fila.Cells("id_error").Value = 105 OrElse fila.Cells("id_error").Value = 106 OrElse fila.Cells("id_error").Value = 107 OrElse fila.Cells("id_error").Value = 108 Then
                t4 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("id_error").Value = 66 OrElse fila.Cells("id_error").Value = 67 OrElse fila.Cells("id_error").Value = 68 OrElse fila.Cells("id_error").Value = 69 OrElse fila.Cells("id_error").Value = 70 OrElse fila.Cells("id_error").Value = 71 OrElse fila.Cells("id_error").Value = 72 OrElse fila.Cells("id_error").Value = 73 OrElse fila.Cells("id_error").Value = 126 OrElse fila.Cells("id_error").Value = 127 Then
                t5 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            End If
        Next

        lbl_d2.Text = t1
        lbl_d3.Text = t2
        lbl_d5.Text = t3
        lbl_d4.Text = t4
        lbl_d6.Text = t5
        lbl_v3.Text = t5
    End Sub

    Private Sub lbl_tp1_Click_1(sender As Object, e As EventArgs) Handles lbl_tp1.TextChanged, lbl_tp2.TextChanged, lbl_tp3.TextChanged, lbl_tp4.TextChanged, lbl_tp5.TextChanged, lbl_tp6.TextChanged, lbl_tp7.TextChanged, lbl_tp8.TextChanged, lbl_tp9.TextChanged
        Try
            'Dim a As Integer = lbl_tp1.Text
            'Dim b As Integer = lbl_tp2.Text
            'Dim c As Integer = lbl_tp3.Text
            'Dim d As Integer = lbl_tp4.Text
            'Dim f As Integer = lbl_tp5.Text
            'Dim g As Integer = lbl_tp6.Text
            'Dim h As Integer = lbl_tp7.Text
            'Dim i As Integer = lbl_tp8.Text
            'Dim j As Integer = lbl_tp9.Text

            'lbl_v3.Text = a + b + c + d + f + g + h + i + j
            'lbl_d6.Text = a + b + c + d + f + g + h + i + j
            cantidadxhora()
        Catch
        End Try
    End Sub

    Private Sub ng1_Click(sender As Object, e As EventArgs) Handles ng1.TextChanged, ng2.TextChanged, ng3.TextChanged, ng4.TextChanged, ng5.TextChanged, ng6.TextChanged, ng7.TextChanged, ng8.TextChanged, ng9.TextChanged
        ngok()
    End Sub

    Sub ngok()
        Try
            ok1.Text = CInt(t1.Text) - CInt(ng1.Text)
            ok2.Text = CInt(t2.Text) - CInt(ng2.Text)
            ok3.Text = CInt(t3.Text) - CInt(ng3.Text)
            ok4.Text = CInt(t4.Text) - CInt(ng4.Text)
            ok5.Text = CInt(t5.Text) - CInt(ng5.Text)
            ok6.Text = CInt(t6.Text) - CInt(ng6.Text)
            ok7.Text = CInt(t7.Text) - CInt(ng7.Text)
            ok8.Text = CInt(t8.Text) - CInt(ng8.Text)
            ok9.Text = CInt(t9.Text) - CInt(ng9.Text)

        Catch
        End Try
    End Sub


    Sub insertaoeeprincipal()

        Dim command As New SqlCommand("Sp_insertageneraloee", Cn)

        command.CommandType = CommandType.StoredProcedure

        Cn.Open()

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@fecha", DateTimePicker1.Value.ToShortDateString)
            command.Parameters.AddWithValue("@id_proceso", cbx_proceso.Text)
            command.Parameters.AddWithValue("@maquina", cbx_maquina.Text)
            command.Parameters.AddWithValue("@pieza", cbx_pieza.Text)
            command.Parameters.AddWithValue("@molde", cbx_molde.Text)
            command.Parameters.AddWithValue("@cavidad", cbx_cavidad.Text)
            command.Parameters.AddWithValue("@turno", cbx_turno.Text)
            command.Parameters.AddWithValue("@tpok", lbl_v1.Text)
            command.Parameters.AddWithValue("@tpo", lbl_v2.Text)
            command.Parameters.AddWithValue("@tpp", lbl_v3.Text)
            command.Parameters.AddWithValue("@ct", lbl_v4.Text)
            command.Parameters.AddWithValue("@cantidadtotal", lbl_t1.Text)
            command.Parameters.AddWithValue("@inypru", lbl_t9.Text)
            command.Parameters.AddWithValue("@dfundicion", lbl_t2.Text)
            command.Parameters.AddWithValue("@dmaquinado", lbl_t3.Text)
            command.Parameters.AddWithValue("@insmuestra", lbl_t4.Text)
            command.Parameters.AddWithValue("@pconforme", lbl_t5.Text)
            command.Parameters.AddWithValue("@ttotal", lbl_d1.Text)
            command.Parameters.AddWithValue("@cjig", lbl_d2.Text)
            command.Parameters.AddWithValue("@tmmolde", lbl_d3.Text)
            command.Parameters.AddWithValue("@tmmaquina", lbl_d4.Text)
            command.Parameters.AddWithValue("@loosf", lbl_d5.Text)
            command.Parameters.AddWithValue("@toperacion", lbl_d7.Text)

            command.ExecuteNonQuery()


            MessageBox.Show("Validado Correctamente.", "¡Correcto!")

        Catch ex As Exception

            MessageBox.Show("Error al cargar general, contacte inmediatamente al equipo de sistemas.", "¡Error!")

            MessageBox.Show(ex.ToString)

        Finally

            Cn.Close()

        End Try

    End Sub

    Sub insertaoeexhora()

        Dim command As New SqlCommand("Sp_insertaoeexhora", Cn)

        command.CommandType = CommandType.StoredProcedure

        Cn.Open()

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            command.Parameters.Clear()

            command.Parameters.AddWithValue("@Tpp", lbl_tp1.Text)
            command.Parameters.AddWithValue("@Cpok", lbl_cp1.Text)
            command.Parameters.AddWithValue("@Resultado", t1.Text)
            command.Parameters.AddWithValue("@Ok", ok1.Text)
            command.Parameters.AddWithValue("@Ng", ng1.Text)

            command.Parameters.AddWithValue("@Tpp2", lbl_tp2.Text)
            command.Parameters.AddWithValue("@Cpok2", lbl_cp2.Text)
            command.Parameters.AddWithValue("@Resultado2", t2.Text)
            command.Parameters.AddWithValue("@Ok2", ok2.Text)
            command.Parameters.AddWithValue("@Ng2", ng2.Text)

            command.Parameters.AddWithValue("@Tpp3", lbl_tp3.Text)
            command.Parameters.AddWithValue("@Cpok3", lbl_cp3.Text)
            command.Parameters.AddWithValue("@Resultado3", t3.Text)
            command.Parameters.AddWithValue("@Ok3", ok3.Text)
            command.Parameters.AddWithValue("@Ng3", ng3.Text)


            command.Parameters.AddWithValue("@Tpp4", lbl_tp4.Text)
            command.Parameters.AddWithValue("@Cpok4", lbl_cp4.Text)
            command.Parameters.AddWithValue("@Resultado4", t4.Text)
            command.Parameters.AddWithValue("@Ok4", ok4.Text)
            command.Parameters.AddWithValue("@Ng4", ng4.Text)


            command.Parameters.AddWithValue("@Tpp5", lbl_tp5.Text)
            command.Parameters.AddWithValue("@Cpok5", lbl_cp5.Text)
            command.Parameters.AddWithValue("@Resultado5", t5.Text)
            command.Parameters.AddWithValue("@Ok5", ok5.Text)
            command.Parameters.AddWithValue("@Ng5", ng5.Text)


            command.Parameters.AddWithValue("@Tpp6", lbl_tp6.Text)
            command.Parameters.AddWithValue("@Cpok6", lbl_cp6.Text)
            command.Parameters.AddWithValue("@Resultado6", t6.Text)
            command.Parameters.AddWithValue("@Ok6", ok6.Text)
            command.Parameters.AddWithValue("@Ng6", ng6.Text)


            command.Parameters.AddWithValue("@Tpp7", lbl_tp7.Text)
            command.Parameters.AddWithValue("@Cpok7", lbl_cp7.Text)
            command.Parameters.AddWithValue("@Resultado7", t7.Text)
            command.Parameters.AddWithValue("@Ok7", ok7.Text)
            command.Parameters.AddWithValue("@Ng7", ng7.Text)


            command.Parameters.AddWithValue("@Tpp8", lbl_tp8.Text)
            command.Parameters.AddWithValue("@Cpok8", lbl_cp8.Text)
            command.Parameters.AddWithValue("@Resultado8", t8.Text)
            command.Parameters.AddWithValue("@Ok8", ok8.Text)
            command.Parameters.AddWithValue("@Ng8", ng8.Text)


            command.Parameters.AddWithValue("@Tpp9", lbl_tp9.Text)
            command.Parameters.AddWithValue("@Cpok9", lbl_cp9.Text)
            command.Parameters.AddWithValue("@Resultado9", t9.Text)
            command.Parameters.AddWithValue("@Ok9", ok9.Text)
            command.Parameters.AddWithValue("@Ng9", ng9.Text)





            command.ExecuteNonQuery()


            'MessageBox.Show("Validado Correctamente.", "¡Correcto!")

        Catch ex As Exception

            MessageBox.Show("Error al cargar xhora, contacte inmediatamente al equipo de sistemas.", "¡Error!")

            MessageBox.Show(ex.ToString)

        Finally

            Cn.Close()

        End Try

    End Sub


    Sub insertaoeedetalle()


        Dim command As New SqlCommand("Sp_insertadetalleoee", Cn)
        Cn.Open()
        command.CommandType = CommandType.StoredProcedure


        Try
            For Each fila In dtgvp.Rows

                command.Parameters.Clear()

                command.Parameters.AddWithValue("@id_hora", (fila.Cells("id_hora").Value))
                command.Parameters.AddWithValue("@id_error", (fila.Cells("id_error").Value))
                command.Parameters.AddWithValue("@valor", (fila.Cells("Cantidad").Value))
                command.Parameters.AddWithValue("@tipo", (fila.Cells("Valor").Value))
                command.Parameters.AddWithValue("@tp", (fila.Cells("tp").Value))

                command.ExecuteNonQuery()
            Next


            Cn.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar detalle, comuníquese al área de Sistemas.")
            MessageBox.Show(ex.Message)
            Cn.Close()

        End Try

    End Sub


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        insertaoeeprincipal()
        insertaoeedetalle()
        insertaoeexhora()

    End Sub


    Private Sub lbl_v4_Click(sender As Object, e As EventArgs)
        If lbl_v4.Text = "0" Or cbx_turno.Text = "" Then
            btn_guardar.Enabled = False
        ElseIf lbl_v4.Text <> "0" And cbx_turno.Text <> "" Then
            btn_guardar.Enabled = True
        End If
    End Sub

    Private Sub cbx_proceso_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbx_proceso.SelectedIndexChanged
        If cbx_proceso.Text = "FUNDICION" Then
            cbx_molde.Enabled = True
            cbx_cavidad.Enabled = True
            PanelF.Visible = True
            PanelM.Visible = False


        Else
            cbx_molde.Enabled = False
            cbx_cavidad.Enabled = False
            PanelF.Visible = False
            PanelM.Visible = True



        End If
    End Sub

    Private Sub lbl_v4_TextChanged(sender As Object, e As EventArgs) Handles lbl_v4.TextChanged
        Try
            cantidadxhora()
        Catch
        End Try

        If lbl_v4.Text = "0" OrElse lbl_v4.Text = "" Then
            lbl_v1.Text = "0"
            lbl_cp1.Text = "0"
            lbl_cp2.Text = "0"
            lbl_cp3.Text = "0"
            lbl_cp4.Text = "0"
            lbl_cp5.Text = "0"
            lbl_cp6.Text = "0"
            lbl_cp7.Text = "0"
            lbl_cp8.Text = "0"
            lbl_cp9.Text = "0"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If dtgvp.SelectedRows.Count > 0 Then

            dtgvp.Rows.Remove(dtgvp.SelectedRows(0))
        Else
            MessageBox.Show("Seleccione una casilla antes de eliminar")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbl_contador.Text = CInt(lbl_contador.Text) + 1
        lbl_v1.Text = "0"
        lbl_v2.Text = "0"
        lbl_v3.Text = "0"
        lbl_v4.Text = "0"


        lbl_t1.Text = "0"
        lbl_t2.Text = "0"
        lbl_t3.Text = "0"
        lbl_t4.Text = "0"
        lbl_t5.Text = "0"
        lbl_t9.Text = "0"


        lbl_d1.Text = "0"
        lbl_d2.Text = "0"
        lbl_d3.Text = "0"
        lbl_d4.Text = "0"
        lbl_d5.Text = "0"
        lbl_d6.Text = "0"
        lbl_d7.Text = "0"


        lbl_h1.Text = "~"
        lbl_h2.Text = "~"
        lbl_h3.Text = "~"
        lbl_h4.Text = "~"
        lbl_h5.Text = "~"
        lbl_h6.Text = "~"
        lbl_h7.Text = "~"
        lbl_h8.Text = "~"
        lbl_h9.Text = "~"


        lbl_tp1.Text = "0"
        lbl_tp2.Text = "0"
        lbl_tp3.Text = "0"
        lbl_tp4.Text = "0"
        lbl_tp5.Text = "0"
        lbl_tp6.Text = "0"
        lbl_tp7.Text = "0"
        lbl_tp8.Text = "0"
        lbl_tp9.Text = "0"

        lbl_acumulado1.Text = "0"
        lbl_acumulado2.Text = "0"
        lbl_acumulado3.Text = "0"
        lbl_acumulado4.Text = "0"
        lbl_acumulado5.Text = "0"
        lbl_acumulado6.Text = "0"
        lbl_acumulado7.Text = "0"
        lbl_acumulado8.Text = "0"
        lbl_acumulado9.Text = "0"

        txt_1.Text = "0"
        txt_2.Text = "0"
        txt_3.Text = "0"
        txt_4.Text = "0"
        txt_5.Text = "0"
        txt_6.Text = "0"
        txt_7.Text = "0"
        txt_8.Text = "0"
        txt_9.Text = "0"


        ok1.Text = "0"
        ok2.Text = "0"
        ok3.Text = "0"
        ok4.Text = "0"
        ok5.Text = "0"
        ok6.Text = "0"
        ok7.Text = "0"
        ok8.Text = "0"
        ok9.Text = "0"


        ng1.Text = "0"
        ng2.Text = "0"
        ng3.Text = "0"
        ng4.Text = "0"
        ng5.Text = "0"
        ng6.Text = "0"
        ng7.Text = "0"
        ng8.Text = "0"
        ng9.Text = "0"


        t1.Text = "0"
        t2.Text = "0"
        t3.Text = "0"
        t4.Text = "0"
        t5.Text = "0"
        t6.Text = "0"
        t7.Text = "0"
        t8.Text = "0"
        t9.Text = "0"




        lbl_cp1.Text = "0"
        lbl_cp2.Text = "0"
        lbl_cp3.Text = "0"
        lbl_cp4.Text = "0"
        lbl_cp5.Text = "0"
        lbl_cp6.Text = "0"
        lbl_cp7.Text = "0"
        lbl_cp8.Text = "0"
        lbl_cp9.Text = "0"

        dtgvp.Rows.Clear()
        btn_guardar.Enabled = False

    End Sub

    Private Sub cbx_maquina_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbx_maquina.SelectedIndexChanged
        CT()
    End Sub

    Private Sub cbx_pieza_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbx_pieza.SelectedIndexChanged
        CT()
    End Sub


End Class

Module Modulo_detalle
    Public parametro As String
    Public parametro2 As String
    Public parametro3 As String
    Public parametro4 As Integer
    Public parametro5 As String
    Public parametro6 As Integer
End Module
