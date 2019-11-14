Imports System.Data.SqlClient

Public Class DefectoM

    Dim valor As Integer
    Private Sub DefectoM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_fecha.Text = Modulo_detalle.parametro
        lbl_hora.Text = Modulo_detalle.parametro2
        lbl_turno.Text = Modulo_detalle.parametro3
        lbl_piezas.Text = Modulo_detalle.parametro4
        lbl_proceso.Text = Modulo_detalle.parametro5


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
                CapturaOEE.dtgvp.Rows.Add(New String() {cbx_defecto.Text, valor, lbl_valor.Text, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, lbl_id.Text, lbl_piezas.Text})
                CapturaOEE.ngxhora()
                CapturaOEE.etiquetaspieza()

                txt_cantidad.Text = "0"
            End If
        ElseIf valor = 2 Then
            If CInt(txt_cantidad.Text) > 60 Then
                MessageBox.Show("No se pueden agregar más de 60 minutos de paro por hora, revise sus cantidades", "¡Aviso!")
            Else
                lbl_valor.Text = "TIEMPO"
                CapturaOEE.dtgvp.Rows.Add(New String() {cbx_defecto.Text, valor, lbl_valor.Text, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, lbl_id.Text, lbl_piezas.Text})
                CapturaOEE.calculotppxhora()
                CapturaOEE.etiquetastiempo()

                txt_cantidad.Text = "0"

            End If

        End If
    End Sub
End Class