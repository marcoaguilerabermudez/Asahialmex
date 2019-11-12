Imports System.Data.SqlClient

Public Class Detalle2oee

    Dim id_defecto As Integer
    Dim valor As Integer
    Dim valor2 As String

    Private Sub Detalle2oee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_fecha.Text = Modulo_detalle.parametro
        lbl_hora.Text = Modulo_detalle.parametro2
        lbl_turno.Text = Modulo_detalle.parametro3
        lbl_piezas.Text = Modulo_detalle.parametro4
        lbl_proceso.Text = Modulo_detalle.parametro5
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try

            CapturaOEE.Cn.Open()
            Dim SSel As String

            SSel = (" select id_defecto , DefectoD, valor FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE]
  where Id_defectohoja =  " & txt_error.Text & " ")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, CapturaOEE.Cn)
            da.Fill(ds)


            id_defecto = ds.Tables(0).Rows(0).Item(0)
            lbl_defecto.Text = ds.Tables(0).Rows(0).Item(1)
            valor = ds.Tables(0).Rows(0).Item(2)

            CapturaOEE.Cn.Close()

        Catch ex As Exception
            CapturaOEE.Cn.Close()
            MessageBox.Show(ex.ToString)

            MessageBox.Show("No hay ningún defecto registrado con ese ID, revise en intente de nuevo", "¡Aviso!")
            txt_error.Text = ""
            lbl_defecto.Text = "Debe teclear un defecto"

        End Try


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
            If txt_cantidad.Text > lbl_piezas.Text Then
                MessageBox.Show("No se pueden agregar más piezas con defectos que piezas producidad, revise sus cantidades", "¡Aviso!")
            Else
                valor2 = "Pza"
                CapturaOEE.dtgvp.Rows.Add(New String() {lbl_defecto.Text, valor, valor2, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, id_defecto, lbl_piezas.Text})
                CapturaOEE.ngxhora()
                CapturaOEE.etiquetaspieza()

            End If
        ElseIf valor = 2 Then
            If txt_cantidad.Text > 60 Then
                MessageBox.Show("No se pueden agregar más de 60 minutos de paro por hora, revise sus cantidades", "¡Aviso!")
            Else
                valor2 = "Tiempo"
                CapturaOEE.dtgvp.Rows.Add(New String() {lbl_defecto.Text, valor, valor2, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, id_defecto, lbl_piezas.Text})
                CapturaOEE.calculotppxhora()
                CapturaOEE.etiquetastiempo()

            End If

        End If
    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged
        If txt_cantidad.Text = "0" Or txt_cantidad.Text = "" Then
            btn_1.Enabled = False
        Else
            btn_1.Enabled = True
        End If
    End Sub

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