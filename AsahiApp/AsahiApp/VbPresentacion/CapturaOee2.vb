Imports System.Data.SqlClient

Public Class CapturaOee2

    Public Cn As New SqlConnection("Data Source=GIRO\SQLEX2014;Initial Catalog=SistemaAAM;Uid=sa; Pwd=Pa55word ;MultipleActiveResultSets=true")
    Public idh As Integer


    Private Sub CapturaOee2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Enabled = True
    End Sub

    Private Sub txtIdPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tpza.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub cbx_proceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_proceso.SelectedIndexChanged

        If cbx_proceso.Text = "FUNDICION" Then
            cbx_molde.Enabled = True
            cbx_cavidad.Visible = True
        Else
            'cbx_molde.Enabled = False
            'cbx_cavidad.Text = "1"
            'cbx_cavidad.Enabled = False

            cbx_cavidad.Enabled = True
            cbx_cavidad.Text = "1"
            cbx_molde.Enabled = False
        End If

        llenacombomaquina()
        llenacombopieza()

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

        If cbx_proceso.Text = "FUNDICION" Then

            llenacombocavidad()

        Else
            cbx_cavidad.Text = 1
        End If
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
            lbl_ct.Text = Format(CDbl(Rs(0)), "0.00")
            lbl_ct2.Text = Format(CDbl(Rs(0) / CInt(cbx_cavidad.Text)), "0.00")


            Panel1.Enabled = True

            Rs.Close()
            Cn.Close()
        Catch ex As Exception
            lbl_ct.Text = "0"
            lbl_ct2.Text = "0"
            Panel1.Enabled = False
            Cn.Close()

        End Try


    End Sub

    Private Sub cbx_maquina_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbx_maquina.SelectedIndexChanged

        CT()

    End Sub

    Private Sub cbx_pieza_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbx_pieza.SelectedIndexChanged




        CT()
        If cbx_proceso.Text = "FUNDICION" Then

            llenacombocavidad()

        Else
            cbx_cavidad.Text = 1
        End If

    End Sub


    Private Sub cbx_pieza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_pieza.TextChanged
        llenacombomolde()
        If cbx_proceso.Text = "FUNDICION" Then
            llenacombocavidad()
        Else
            cbx_cavidad.Text = 1
        End If


    End Sub

    Private Sub cbx_maquina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_maquina.TextChanged
        llenacombopieza()
        If cbx_proceso.Text = "FUNDICION" Then

            llenacombocavidad()

        Else
            cbx_cavidad.Text = 1
        End If
    End Sub

    Private Sub cbx_molde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_molde.SelectedIndexChanged


        ''llenacombocavidad()
        CT()


    End Sub




    Private Sub cbx_cavidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_cavidad.SelectedIndexChanged

        CT()
                '' lbl_ct.Text = lbl_ct.Text / cbx_cavidad.Text

        'lbl_ct.Text = CDbl(lbl_ct.Text) / cbx_cavidad.Text

        '' lbl_v2.Text = CInt(lbl_d1.Text) - CInt(lbl_v3.Text)

    End Sub

    Private Sub cbx_turno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_turno.SelectedIndexChanged

        If cbx_turno.Text = "1" Then
            lbl_tpo.Text = "510"
            lbl_topr.Text = (510 - (CInt(lbl_pp.Text) + CInt(lbl_topp.Text) + CInt(lbl_pnp.Text)))
            lbl_topp.Text = (510 - CInt(lbl_pp.Text))
        ElseIf cbx_turno.Text = "2" Then
            lbl_tpo.Text = "480"
            lbl_topr.Text = (480 - (CInt(lbl_pp.Text) + CInt(lbl_topp.Text) + CInt(lbl_pnp.Text)))
            lbl_topp.Text = (480 - CInt(lbl_pp.Text))
        ElseIf cbx_turno.Text = "3" Then
            lbl_tpo.Text = "450"
            lbl_topr.Text = (450 - (CInt(lbl_pp.Text) + CInt(lbl_topp.Text) + CInt(lbl_pnp.Text)))
            lbl_topp.Text = (450 - CInt(lbl_pp.Text))
        End If

    End Sub

    Sub llenacombocavidad()
        Try
            Dim Dt As DataTable

            Dim Da As New SqlDataAdapter
            Dim Cmd As New SqlCommand
            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "
  declare @id_pieza as int
  set @id_pieza = (select Id_pieza from [SistemaAAM].[dbo].Pro_Cat_Pieza where Nombre = '" & cbx_pieza.Text & "')

    SELECT TOP 1 CAVIDAD
    FROM [SistemaAAM].[dbo].[Standar_fundicion] where id_pieza = @id_pieza
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
        Catch
            cbx_cavidad.Text = "1"
        End Try
        'totales()
    End Sub

    Private Sub lbl_tpo_Click(sender As Object, e As EventArgs) Handles lbl_tpo.TextChanged, lbl_topr.TextChanged, lbl_ct2.TextChanged, txt_tpza.TextChanged, lbl_png.TextChanged
        utilizacion()
        rendimiento()
        calidad()
        'If CInt(lbl_topr.Text) < 0 Then
        '    lbl_topr.ForeColor = Color.DarkRed
        'Else
        '    lbl_topr.ForeColor = Color.Black
        'End If

    End Sub


    Sub utilizacion()
        Try
            lbl_utilizacion.Text = Format((CInt(lbl_topr.Text) / CInt(lbl_tpo.Text)) * 100, "0.00")
            If CDbl(lbl_utilizacion.Text) > 101 Then
                lbl_utilizacion.ForeColor = Color.DarkRed
            Else
                lbl_utilizacion.ForeColor = Color.Black

            End If
        Catch
            lbl_utilizacion.Text = "0"
        End Try
    End Sub

    Sub rendimiento()
        If cbx_proceso.Text = "FUNDICION" Then

            Try
                lbl_rendimiento.Text = Format(CDbl(lbl_ct.Text / ((CInt(lbl_topr.Text) * 60) / (CInt(txt_tpza.Text) / CInt(cbx_cavidad.Text)))) * 100, "0.00")
                If CDbl(lbl_rendimiento.Text) > 101 Then
                    lbl_rendimiento.ForeColor = Color.DarkRed
                Else
                    lbl_rendimiento.ForeColor = Color.Black
                End If
            Catch
                lbl_rendimiento.Text = 0
            End Try

        Else

            Try
                lbl_rendimiento.Text = Format(CDbl(lbl_ct.Text / ((CInt(lbl_topr.Text) * 60) / (CInt(txt_tpza.Text) * 1))) * 100, "0.00")
                If CDbl(lbl_rendimiento.Text) > 101 Then
                    lbl_rendimiento.ForeColor = Color.DarkRed
                Else
                    lbl_rendimiento.ForeColor = Color.Black
                End If
            Catch
                lbl_rendimiento.Text = 0
            End Try

        End If

    End Sub

    Sub calidad()
        Try
            lbl_calidad.Text = Format(((CInt(txt_tpza.Text) - CInt(lbl_png.Text)) / (CInt(txt_tpza.Text))) * 100, "0.00")
            If CDbl(lbl_calidad.Text) > 101 Then
                lbl_calidad.ForeColor = Color.DarkRed
            Else
                lbl_calidad.ForeColor = Color.Black
            End If
        Catch
            lbl_calidad.Text = 0
        End Try
    End Sub

    Private Sub lbl_utilizacion_Click(sender As Object, e As EventArgs) Handles lbl_utilizacion.TextChanged, lbl_rendimiento.TextChanged, lbl_calidad.TextChanged
        Try
            lbl_oee.Text = Format(((CDbl(lbl_calidad.Text / 100) * CDbl(lbl_rendimiento.Text / 100) * CDbl(lbl_utilizacion.Text / 100)) * 100), "0.00")
            If CDbl(lbl_oee.Text) > "101" Then
                lbl_oee.ForeColor = Color.DarkRed
            Else
                lbl_oee.ForeColor = Color.Black
            End If
        Catch ex As Exception
            lbl_oee.Text = 0

        End Try

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Try
            If cbx_proceso.Text = "FUNDICION" Then
                DefectoM.Close()
                Detalle2oee.Show()
            Else
                Detalle2oee.Close()
                DefectoM.Show()
            End If
        Catch
        End Try

    End Sub

    Private Sub txt_tpza_TextChanged(sender As Object, e As EventArgs) Handles txt_tpza.TextChanged, lbl_png.TextChanged
        Try
            lbl_pc.Text = CInt(CInt(txt_tpza.Text) - CInt(lbl_png.Text))
        Catch
            lbl_pc.Text = 0
        End Try
    End Sub


    Sub etiquetaspieza()
        Dim c1 As Integer = 0
        Dim c2 As Integer = 0
        Dim c3 As Integer = 0
        Dim c4 As Integer = 0


        For Each fila As DataGridViewRow In dtgvp.Rows
            If fila.Cells("DefectoG").Value = "Tiempo de paro planeado 計画停止" OrElse fila.Cells("DefectoG").Value = "Tiempo de paro planeado
計画停止" Then
                c1 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("DefectoG").Value = "Cambio de molde 段替時間" OrElse fila.Cells("DefectoG").Value = "Cambio de molde
段替時間" OrElse fila.Cells("DefectoG").Value = "LOSS POR FALTA DE CONTROL
管理ロス" OrElse fila.Cells("DefectoG").Value = "TIEMPO MUERTO POR MAQUINA 機械故障ロス" OrElse fila.Cells("DefectoG").Value = "TIEMPO MUERTO POR MAQUINA
機械故障ロス" OrElse fila.Cells("DefectoG").Value = "TIEMPO MUERTO POR MOLDE / 金型故障ロス" Then
                c2 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            ElseIf fila.Cells("DefectoG").Value = "Defecto de fundición y acabado(pza) / 不良ロス個数(個)" OrElse fila.Cells("DefectoG").Value = "Defecto de fundición y maquinado , grabado 不良ロス個数" OrElse fila.Cells("DefectoG").Value = "Inyección de prueba/Defecto de fundición  捨打/不良ロス個数" OrElse fila.Cells("DefectoG").Value = "Defecto de fundición y maquinado , grabado
不良ロス個数" Then
                c3 += Convert.ToDouble(fila.Cells("Cantidad").Value)
            End If
        Next

        lbl_pp.Text = c1
        lbl_pnp.Text = c2
        lbl_png.Text = c3

    End Sub

    'Private Sub lbl_pp_Click(sender As Object, e As EventArgs) Handles lbl_pnp.TextChanged, lbl_topp.TextChanged
    '    Try

    '        lbl_topr.Text = CInt(lbl_topp.Text) - CInt(lbl_pnp.Text)

    '    Catch
    '    End Try
    'End Sub

    Private Sub lbl_pp_Click2(sender As Object, e As EventArgs) Handles lbl_pnp.TextChanged, lbl_topp.TextChanged, lbl_pp.TextChanged
        Try
            lbl_topp.Text = CInt(lbl_tpo.Text) - CInt(lbl_pp.Text)
            lbl_topr.Text = CInt(lbl_topp.Text) - CInt(lbl_pnp.Text)

            If CInt(lbl_topp.Text) < 0 Then
                lbl_topp.ForeColor = Color.DarkRed
            Else
                lbl_topp.ForeColor = Color.Black
            End If

        Catch
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click


        If dtgvp.SelectedRows.Count > 0 Then
            dtgvp.Rows.Remove(dtgvp.SelectedRows(0))
        Else
            MessageBox.Show("Seleccione una casilla antes de eliminar", "¡Aviso!")
        End If
        etiquetaspieza()
        utilizacion()
        rendimiento()
        calidad()

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
            command.Parameters.AddWithValue("@tpok", 0)
            command.Parameters.AddWithValue("@tpo", lbl_topp.Text)
            command.Parameters.AddWithValue("@tpp", lbl_pp.Text)
            command.Parameters.AddWithValue("@ct", lbl_ct2.Text)
            command.Parameters.AddWithValue("@cantidadtotal", txt_tpza.Text)
            command.Parameters.AddWithValue("@inypru", 0)
            command.Parameters.AddWithValue("@dfundicion", lbl_png.Text) ''Al no haber un apartado especial, los productos ng caen a este parámetro
            command.Parameters.AddWithValue("@dmaquinado", 0)
            command.Parameters.AddWithValue("@insmuestra", 0)
            command.Parameters.AddWithValue("@pconforme", lbl_pc.Text)
            command.Parameters.AddWithValue("@ttotal", lbl_tpo.Text)
            command.Parameters.AddWithValue("@cjig", 0)
            command.Parameters.AddWithValue("@tmmolde", 0)
            command.Parameters.AddWithValue("@tmmaquina", 0)
            command.Parameters.AddWithValue("@loosf", 0)
            command.Parameters.AddWithValue("@toperacion", lbl_topr.Text)


            command.ExecuteNonQuery()


            MessageBox.Show("Validado Correctamente.", "¡Correcto!")

        Catch ex As Exception

            MessageBox.Show("Error al cargar general, contacte inmediatamente al equipo de sistemas.", "¡Error!")

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

                command.Parameters.AddWithValue("@id_hora", 0)
                command.Parameters.AddWithValue("@id_error", (fila.Cells("id_error").Value))
                command.Parameters.AddWithValue("@valor", (fila.Cells("Cantidad").Value))
                command.Parameters.AddWithValue("@tipo", (fila.Cells("Valor").Value))
                command.Parameters.AddWithValue("@tp", 0)

                command.ExecuteNonQuery()
            Next


            Cn.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar detalle, comuníquese al área de Sistemas.")
            MessageBox.Show(ex.Message)
            Cn.Close()

        End Try

    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        insertaoeeprincipal()
        insertaoeedetalle()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dtgvp.Rows.Clear()
        lbl_tpo.Text = ""
        lbl_pp.Text = "0"
        lbl_topp.Text = "0"
        lbl_pnp.Text = "0"
        lbl_topr.Text = ""
        lbl_ct2.Text = "0"
        lbl_ct.Text = "0"
        lbl_pc.Text = ""
        lbl_png.Text = "0"
        txt_tpza.Text = ""
    End Sub


End Class