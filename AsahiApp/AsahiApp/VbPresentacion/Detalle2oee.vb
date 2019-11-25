Imports System.Data.SqlClient

Public Class Detalle2oee

    Dim id_defecto As Integer
    Dim valor As Integer
    Dim valor2 As String
    'Public idh As String
    Dim detalleg As String


    Private Sub Detalle2oee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lbl_fecha.Text = Modulo_detalle.parametro
        'lbl_hora.Text = Modulo_detalle.parametro2
        'lbl_turno.Text = Modulo_detalle.parametro3
        'lbl_piezas.Text = Modulo_detalle.parametro4
        'lbl_proceso.Text = Modulo_detalle.parametro5
        'idh = Modulo_detalle.parametro6
    End Sub



    Private Sub lbl_defecto_Click(sender As Object, e As EventArgs) Handles lbl_defecto.TextChanged
        If lbl_defecto.Text = "Debe teclear un defecto" Then
            txt_cantidad.Enabled = False
        Else
            txt_cantidad.Enabled = True
        End If

    End Sub



    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If valor = 1 Then
            ''     If CInt(txt_cantidad.Text) > CInt(lbl_piezas.Text) Then
            'MessageBox.Show("No se pueden agregar más piezas con defectos que piezas producidad, revise sus cantidades", "¡Aviso!")
            '' Else
            valor2 = "Pza"
                CapturaOee2.dtgvp.Rows.Add(New String() {lbl_defecto.Text, detalleg, valor, valor2, txt_cantidad.Text, id_defecto})
                'CapturaOEE.ngxhora()
                'CapturaOEE.etiquetaspieza()
                CapturaOee2.etiquetaspieza()
                txt_error.Clear()
                txt_error.Focus()
                txt_cantidad.Text = "0"
                lbl_defecto.Text = "Debe teclear un defecto"
            ''End If
        ElseIf valor = 2 Then
            '' If CInt(txt_cantidad.Text) > 60 Then
            ' MessageBox.Show("No se pueden agregar más de 60 minutos de paro por hora, revise sus cantidades", "¡Aviso!")
            ''   Else
            valor2 = "Tiempo"
                CapturaOee2.dtgvp.Rows.Add(New String() {lbl_defecto.Text, detalleg, valor, valor2, txt_cantidad.Text, id_defecto})
                'CapturaOEE.calculotppxhora()
                'CapturaOEE.etiquetastiempo()
                CapturaOee2.etiquetaspieza()
                txt_error.Clear()
                txt_error.Focus()
                txt_cantidad.Text = "0"
                lbl_defecto.Text = "Debe teclear un defecto"

            End If

        'End If
    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged
        If txt_cantidad.Text = "0" Or txt_cantidad.Text = "" Then
            btn_1.Enabled = False
        Else
            btn_1.Enabled = True
        End If
    End Sub

    Private Sub txt_error_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_error.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try

                CapturaOEE.Cn.Open()
                Dim SSel As String

                SSel = (" select id_defecto , DefectoD, valor,defectog FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE]
  where Id_defectohoja =  " & txt_error.Text & " ")
                Dim da As SqlDataAdapter
                Dim ds As New DataSet
                ds.Clear()
                da = New SqlDataAdapter(SSel, CapturaOEE.Cn)
                da.Fill(ds)


                id_defecto = ds.Tables(0).Rows(0).Item(0)
                lbl_defecto.Text = ds.Tables(0).Rows(0).Item(1)
                valor = ds.Tables(0).Rows(0).Item(2)
                detalleg = ds.Tables(0).Rows(0).Item(3)

                CapturaOEE.Cn.Close()
                txt_cantidad.Focus()

            Catch ex As Exception
                CapturaOEE.Cn.Close()
                MessageBox.Show(ex.ToString)

                MessageBox.Show("No hay ningún defecto registrado con ese ID, revise en intente de nuevo", "¡Aviso!")
                txt_error.Text = ""
                lbl_defecto.Text = "Debe teclear un defecto"

            End Try
        End If

    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_retrocede.Click
    '    If idh = 1 Then
    '        idh = 9
    '        lbl_piezas.Text = CapturaOEE.t9.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h9.Text

    '    ElseIf idh = 2 Then
    '        idh = 1
    '        lbl_piezas.Text = CapturaOEE.t1.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h1.Text

    '    ElseIf idh = 3 Then
    '        idh = 2
    '        lbl_piezas.Text = CapturaOEE.t2.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h2.Text

    '    ElseIf idh = 4 Then
    '        idh = 3
    '        lbl_piezas.Text = CapturaOEE.t3.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h3.Text

    '    ElseIf idh = 5 Then
    '        idh = 4
    '        lbl_piezas.Text = CapturaOEE.t4.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h4.Text

    '    ElseIf idh = 6 Then
    '        idh = 5
    '        lbl_piezas.Text = CapturaOEE.t5.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h5.Text

    '    ElseIf idh = 7 Then
    '        idh = 6
    '        lbl_piezas.Text = CapturaOEE.t6.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h6.Text


    '    ElseIf idh = 8 Then
    '        idh = 7
    '        lbl_piezas.Text = CapturaOEE.t7.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h7.Text


    '    ElseIf idh = 9 Then
    '        idh = 8
    '        lbl_piezas.Text = CapturaOEE.t8.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h8.Text

    '    End If


    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_avanza.Click
    '    If idh = 1 Then
    '        idh = 2
    '        lbl_piezas.Text = CapturaOEE.t2.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h2.Text

    '    ElseIf idh = 2 Then
    '        idh = 3
    '        lbl_piezas.Text = CapturaOEE.t3.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h3.Text

    '    ElseIf idh = 3 Then
    '        idh = 4
    '        lbl_piezas.Text = CapturaOEE.t4.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h4.Text

    '    ElseIf idh = 4 Then
    '        idh = 5
    '        lbl_piezas.Text = CapturaOEE.t5.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h5.Text

    '    ElseIf idh = 5 Then
    '        idh = 6
    '        lbl_piezas.Text = CapturaOEE.t6.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h6.Text

    '    ElseIf idh = 6 Then
    '        idh = 7
    '        lbl_piezas.Text = CapturaOEE.t7.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h7.Text

    '    ElseIf idh = 7 Then
    '        idh = 8
    '        lbl_piezas.Text = CapturaOEE.t8.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h8.Text

    '    ElseIf idh = 8 Then
    '        idh = 9
    '        lbl_piezas.Text = CapturaOEE.t9.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h9.Text


    '    ElseIf idh = 9 Then
    '        idh = 1
    '        lbl_piezas.Text = CapturaOEE.t1.Text
    '        lbl_hora.Text = CapturaOEE.lbl_h1.Text

    '    End If
    'End Sub

    'Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
    '    If valor = 1 Then
    '        valor2 = "Pza"
    '        CapturaOEE.dtgvp.Rows.Add(New String() {cbx_error.Text, valor, valor2, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, id_error, lbl_piezas.Text})
    '        CapturaOEE.ngxhora()
    '        CapturaOEE.etiquetaspieza()

    '    ElseIf valor = 2 And cbx_errorg.Text <> "Tiempo de paro planeado 計画停止" Then
    '        valor2 = "Tiempo"
    '        CapturaOEE.dtgvp.Rows.Add(New String() {cbx_error.Text, valor, valor2, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, id_error, lbl_piezas.Text})
    '        ''CapturaOEE.calculotppxhora()
    '        CapturaOEE.etiquetastiempo()

    '    ElseIf valor = 2 And cbx_errorg.Text = "Tiempo de paro planeado 計画停止" Then
    '        valor2 = "Tiempo"
    '        CapturaOEE.dtgvp.Rows.Add(New String() {cbx_error.Text, valor, valor2, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, id_error, lbl_piezas.Text})
    '        CapturaOEE.calculotppxhora()
    '        CapturaOEE.etiquetastiempo()

    '    End If
    'End Sub
End Class