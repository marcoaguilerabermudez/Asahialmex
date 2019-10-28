Imports System.Data.SqlClient

Public Class CapturaOEE

    Dim Cn As New SqlConnection("Data Source=GIRO\SQLEX2014;Initial Catalog=SistemaAAM;Uid=sa; Pwd=Pa55word")

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
        Modulo_detalle.parametro5 = cbx_proceso.Text
        SubventanaOee.Show()
    End Sub


    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h2.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_2.Text
        Modulo_detalle.parametro5 = cbx_proceso.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h3.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_3.Text
        Modulo_detalle.parametro5 = cbx_proceso.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h4.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_4.Text
        Modulo_detalle.parametro5 = cbx_proceso.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h5.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_5.Text
        Modulo_detalle.parametro5 = cbx_proceso.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h6.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_6.Text
        Modulo_detalle.parametro5 = cbx_proceso.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h7.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_7.Text
        Modulo_detalle.parametro5 = cbx_proceso.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h8.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_8.Text
        Modulo_detalle.parametro5 = cbx_proceso.Text
        SubventanaOee.Show()
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        Modulo_detalle.parametro = DateTimePicker1.Value.ToShortDateString
        Modulo_detalle.parametro2 = lbl_h9.Text
        Modulo_detalle.parametro3 = cbx_turno.Text
        Modulo_detalle.parametro4 = txt_9.Text
        Modulo_detalle.parametro5 = cbx_proceso.Text
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
            btn_9.Enabled = True
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


        End If

        btn_guardar.Enabled = True
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

if @var = 'FUNDICIÓN'
BEGIN
select nombre from [SistemaAAM].[dbo].[Pro_Cat_Maquinaria]
  where id_maquina in (2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17)
END
ELSE if @var = 'MAQUINADO'
BEGIN
select nombre from [SistemaAAM].[dbo].[Pro_Cat_Maquinaria]
  where id_maquina NOT in (2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17)
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

    Sub llenacombomolde()
        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "
declare @var as integer
set @var = (select [id_producto] from [SistemaAAM].[dbo].[Pro_Cat_Productos] where np_Cast = '" & cbx_pieza.Text & "')

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

    Private Sub cbx_proceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_proceso.SelectedIndexChanged
        llenacombomaquina()
    End Sub

    Private Sub cbx_pieza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pieza.SelectedIndexChanged
        llenacombomolde()
    End Sub


End Class

Module Modulo_detalle
    Public parametro As String
    Public parametro2 As String
    Public parametro3 As String
    Public parametro4 As Integer
    Public parametro5 As String
End Module
