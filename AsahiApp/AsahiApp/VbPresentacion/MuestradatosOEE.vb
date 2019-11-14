Imports System.Data.SqlClient

Public Class MuestradatosOEE
    Private Sub MuestradatosOEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub cbx_proceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_proceso.TextChanged


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
            .Connection = CapturaOEE.Cn
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

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        muestragrid()
    End Sub

    Sub muestragrid()
        Try
            CapturaOEE.Cn.Open()


            Dim da As New SqlDataAdapter("Sp_muestragridoee1v", CapturaOEE.Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@fechain", dtp1.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@fechafn", dtp2.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@id_proceso", cbx_proceso.Text)
            da.SelectCommand.Parameters.AddWithValue("@maquina", cbx_maquina.Text)

            Dim dt As New DataTable
            da.Fill(dt)

            dtgvp.DataSource = dt

            'dtgv.Columns("CIDDOCUMENTO").Visible = False
            'dtgv.Columns("CIDMOVIMIENTO").Visible = False
            'dtgv.Columns("Total").Visible = False
            'dtgv.Columns("Nombre").Width = 310
            'dtgv.Columns("PO").Width = 50
            'dtgv.Columns("UMedida").Width = 130
            'colores()
            'pROIVEEDOR()

            CapturaOEE.Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CapturaOEE.Cn.Close()
        End Try

    End Sub

    Private Function IsTheSameCellValue(ByVal column As Integer, ByVal row As Integer) As Boolean
        Dim cell1 As DataGridViewCell = dtgvp(column, row)
        Dim cell2 As DataGridViewCell = dtgvp(column, row - 1)
        If (IsDBNull(cell1.Value) Or IsDBNull(cell2.Value)) Then
            Return False
        End If
        If (cell1.Value = cell2.Value) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgvp.CellFormatting
        If (e.RowIndex = 0) Then
            Return
        End If
        If (IsTheSameCellValue(e.ColumnIndex, e.RowIndex)) And e.ColumnIndex < 3 Then
            e.Value = ""
            e.FormattingApplied = True

        End If


    End Sub

    Private Sub dtgvp2_CellContentClick_1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgvp.CellFormatting

        For j As Integer = 0 To 2

            If e.ColumnIndex = j Then
                e.CellStyle.BackColor = Color.LightGreen
            End If

        Next
        dtgvp.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

    End Sub


    Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dtgvp.CellPainting



        If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
            If (e.RowIndex < 1 Or e.ColumnIndex = 0) Then
                Return
            End If

            If (IsTheSameCellValue(e.ColumnIndex, e.RowIndex)) Then
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
            Else
                e.AdvancedBorderStyle.Top = dtgvp.AdvancedCellBorderStyle.Top
            End If
        End If
    End Sub


End Class