Imports System.Data.SqlClient

Public Class DefectoM
    Dim idh As Integer


    Dim valor As Integer
    Private Sub DefectoM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_fecha.Text = Modulo_detalle.parametro
        lbl_hora.Text = Modulo_detalle.parametro2
        lbl_turno.Text = Modulo_detalle.parametro3
        lbl_piezas.Text = Modulo_detalle.parametro4
        lbl_proceso.Text = Modulo_detalle.parametro5
        idh = Modulo_detalle.parametro6


        llenacombo()
    End Sub

    Private Sub cbx_defecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_defecto.SelectedIndexChanged
        Try
            etiquetas()
        Catch
        End Try
    End Sub

    Sub llenacombo()
        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "
  Select DefectoD
   FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE]
  where Maquinado = 1 OR Leak = 1 OR Ensamble = 1
  order by DefectoD
"
            .Connection = CapturaOEE.Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_defecto
            .DataSource = Dt
            .DisplayMember = "DefectoD"
            '.ValueMember = "id"
        End With
    End Sub

    Sub etiquetas()
        Try

            CapturaOEE.Cn.Open()
            Dim SSel As String

            SSel = ("     Select id_defecto, defectoD,
  case
  when valor = 1 then 'PZA'
  when Valor = 2 then 'TIEMPO'
  END
  , DefectoG
,valor
   FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE]
  where DefectoD =  N'" & cbx_defecto.Text & "' 
  order by DefectoD")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, CapturaOEE.Cn)
            da.Fill(ds)


            lbl_id.Text = ds.Tables(0).Rows(0).Item(0)
            lbl_valor.Text = ds.Tables(0).Rows(0).Item(2)
            lbl_general.Text = ds.Tables(0).Rows(0).Item(3)
            valor = ds.Tables(0).Rows(0).Item(4)

            CapturaOEE.Cn.Close()
            txt_cantidad.Enabled = True
            '' txt_cantidad.Focus()

        Catch
            CapturaOEE.Cn.Close()
        End Try

    End Sub

    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged
        If txt_cantidad.Text = "0" Or txt_cantidad.Text = "" Then
            btn_1.Enabled = False
        Else
            btn_1.Enabled = True
        End If
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If valor = 1 Then
            If CInt(txt_cantidad.Text) > CInt(lbl_piezas.Text) Then
                MessageBox.Show("No se pueden agregar más piezas con defectos que piezas producidad, revise sus cantidades", "¡Aviso!")
            Else
                lbl_valor.Text = "PZA"
                CapturaOEE.dtgvp.Rows.Add(New String() {cbx_defecto.Text, valor, lbl_valor.Text, txt_cantidad.Text, lbl_hora.Text, idh, lbl_id.Text, lbl_piezas.Text})
                CapturaOEE.ngxhora()
                CapturaOEE.etiquetaspieza()

                txt_cantidad.Text = "0"
            End If
        ElseIf valor = 2 Then
            If CInt(txt_cantidad.Text) > 60 Then
                MessageBox.Show("No se pueden agregar más de 60 minutos de paro por hora, revise sus cantidades", "¡Aviso!")
            Else
                lbl_valor.Text = "TIEMPO"
                CapturaOEE.dtgvp.Rows.Add(New String() {cbx_defecto.Text, valor, lbl_valor.Text, txt_cantidad.Text, lbl_hora.Text, idh, lbl_id.Text, lbl_piezas.Text})
                CapturaOEE.calculotppxhora()
                CapturaOEE.etiquetastiempo()

                txt_cantidad.Text = "0"

            End If

        End If
    End Sub

    Private Sub btn_avanza_Click(sender As Object, e As EventArgs) Handles btn_avanza.Click
        If idh = 1 Then
            idh = 2
            lbl_piezas.Text = CapturaOEE.t2.Text
            lbl_hora.Text = CapturaOEE.lbl_h2.Text

        ElseIf idh = 2 Then
            idh = 3
            lbl_piezas.Text = CapturaOEE.t3.Text
            lbl_hora.Text = CapturaOEE.lbl_h3.Text

        ElseIf idh = 3 Then
            idh = 4
            lbl_piezas.Text = CapturaOEE.t4.Text
            lbl_hora.Text = CapturaOEE.lbl_h4.Text

        ElseIf idh = 4 Then
            idh = 5
            lbl_piezas.Text = CapturaOEE.t5.Text
            lbl_hora.Text = CapturaOEE.lbl_h5.Text

        ElseIf idh = 5 Then
            idh = 6
            lbl_piezas.Text = CapturaOEE.t6.Text
            lbl_hora.Text = CapturaOEE.lbl_h6.Text

        ElseIf idh = 6 Then
            idh = 7
            lbl_piezas.Text = CapturaOEE.t7.Text
            lbl_hora.Text = CapturaOEE.lbl_h7.Text

        ElseIf idh = 7 Then
            idh = 8
            lbl_piezas.Text = CapturaOEE.t8.Text
            lbl_hora.Text = CapturaOEE.lbl_h8.Text

        ElseIf idh = 8 Then
            idh = 9
            lbl_piezas.Text = CapturaOEE.t9.Text
            lbl_hora.Text = CapturaOEE.lbl_h9.Text


        ElseIf idh = 9 Then
            idh = 1
            lbl_piezas.Text = CapturaOEE.t1.Text
            lbl_hora.Text = CapturaOEE.lbl_h1.Text

        End If
    End Sub

    Private Sub btn_retrocede_Click(sender As Object, e As EventArgs) Handles btn_retrocede.Click
        If idh = 1 Then
            idh = 9
            lbl_piezas.Text = CapturaOEE.t9.Text
            lbl_hora.Text = CapturaOEE.lbl_h9.Text

        ElseIf idh = 2 Then
            idh = 1
            lbl_piezas.Text = CapturaOEE.t1.Text
            lbl_hora.Text = CapturaOEE.lbl_h1.Text

        ElseIf idh = 3 Then
            idh = 2
            lbl_piezas.Text = CapturaOEE.t2.Text
            lbl_hora.Text = CapturaOEE.lbl_h2.Text

        ElseIf idh = 4 Then
            idh = 3
            lbl_piezas.Text = CapturaOEE.t3.Text
            lbl_hora.Text = CapturaOEE.lbl_h3.Text

        ElseIf idh = 5 Then
            idh = 4
            lbl_piezas.Text = CapturaOEE.t4.Text
            lbl_hora.Text = CapturaOEE.lbl_h4.Text

        ElseIf idh = 6 Then
            idh = 5
            lbl_piezas.Text = CapturaOEE.t5.Text
            lbl_hora.Text = CapturaOEE.lbl_h5.Text

        ElseIf idh = 7 Then
            idh = 6
            lbl_piezas.Text = CapturaOEE.t6.Text
            lbl_hora.Text = CapturaOEE.lbl_h6.Text


        ElseIf idh = 8 Then
            idh = 7
            lbl_piezas.Text = CapturaOEE.t7.Text
            lbl_hora.Text = CapturaOEE.lbl_h7.Text


        ElseIf idh = 9 Then
            idh = 8
            lbl_piezas.Text = CapturaOEE.t8.Text
            lbl_hora.Text = CapturaOEE.lbl_h8.Text

        End If
    End Sub
End Class