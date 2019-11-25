Imports System.Data.SqlClient

Public Class MuestraOeeCompleto
    Private Sub MuestraOeeCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


        muestragrid()

        medidasgrid()
        muestragrid2()
        medidasgrid2()
    End Sub


    Sub muestragrid()
        Try
            CapturaOEE.Cn.Open()


            Dim da As New SqlDataAdapter("Sp_reportegeneraloee", CapturaOEE.Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@var", 1)

            Dim dt As New DataTable
            da.Fill(dt)

            dtgv.DataSource = dt

            'dtgv.Columns("CIDDOCUMENTO").Visible = False
            'dtgv.Columns("CIDMOVIMIENTO").Visible = False
            'dtgv.Columns("Total").Visible = False
            'dtgv.Columns("Nombre").Width = 310
            'dtgv.Columns("PO").Width = 50
            'dtgv.Columns("UMedida").Width = 130
            'colores()
            'pROIVEEDOR()

            Me.dtgv.Columns("Utilización").DefaultCellStyle.Format = "0.00%"
            Me.dtgv.Columns("Rendimiento").DefaultCellStyle.Format = "0.00%"
            Me.dtgv.Columns("Calidad").DefaultCellStyle.Format = "0.00%"
            Me.dtgv.Columns("OEE").DefaultCellStyle.Format = "0.00%"

            CapturaOEE.Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CapturaOEE.Cn.Close()
        End Try

    End Sub


    Sub muestragrid2()
        Try
            CapturaOEE.Cn.Open()


            Dim da As New SqlDataAdapter("Sp_reportegeneraloee", CapturaOEE.Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@var", 2)

            Dim dt As New DataTable
            da.Fill(dt)

            dtgv2.DataSource = dt

            'dtgv.Columns("CIDDOCUMENTO").Visible = False
            'dtgv.Columns("CIDMOVIMIENTO").Visible = False
            'dtgv.Columns("Total").Visible = False
            'dtgv.Columns("Nombre").Width = 310
            'dtgv.Columns("PO").Width = 50
            'dtgv.Columns("UMedida").Width = 130
            'colores()
            'pROIVEEDOR()

            Me.dtgv2.Columns("Utilización").DefaultCellStyle.Format = "0.00%"
            Me.dtgv2.Columns("Rendimiento").DefaultCellStyle.Format = "0.00%"
            Me.dtgv2.Columns("Calidad").DefaultCellStyle.Format = "0.00%"
            Me.dtgv2.Columns("OEE").DefaultCellStyle.Format = "0.00%"

            CapturaOEE.Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CapturaOEE.Cn.Close()
        End Try

    End Sub

    'Private Function IsTheSameCellValue(ByVal column As Integer, ByVal row As Integer) As Boolean
    '    Dim cell1 As DataGridViewCell = dtgv(column, row)
    '    Dim cell2 As DataGridViewCell = dtgv(column, row - 1)
    '    If (IsDBNull(cell1.Value) Or IsDBNull(cell2.Value)) Then
    '        Return False
    '    End If
    '    If (cell1.Value = cell2.Value) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    'Private Sub dtgvp_CellContentClick_13(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgv.CellFormatting
    '    If (e.RowIndex = 0) Then
    '        Return
    '    End If
    '    If (IsTheSameCellValue(e.ColumnIndex, e.RowIndex)) And e.ColumnIndex < 3 Then
    '        e.Value = ""
    '        e.FormattingApplied = True

    '    End If


    'End Sub

    'Private Sub dtgvp2_CellContentClick_14(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgv.CellFormatting

    '    For j As Integer = 0 To 4

    '        If e.ColumnIndex = j Then
    '            e.CellStyle.BackColor = Color.LightGreen
    '        End If

    '    Next


    'End Sub



    'Private Function IsTheSameCellValue2(ByVal column As Integer, ByVal row As Integer) As Boolean
    '    Dim cell1 As DataGridViewCell = dtgv2(column, row)
    '    Dim cell2 As DataGridViewCell = dtgv2(column, row - 1)
    '    If (IsDBNull(cell1.Value) Or IsDBNull(cell2.Value)) Then
    '        Return False
    '    End If
    '    If (cell1.Value = cell2.Value) Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    'Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgv2.CellFormatting
    '    If (e.RowIndex = 0) Then
    '        Return
    '    End If
    '    If (IsTheSameCellValue2(e.ColumnIndex, e.RowIndex)) And e.ColumnIndex < 3 Then
    '        e.Value = ""
    '        e.FormattingApplied = True

    '    End If


    'End Sub

    'Private Sub dtgvp2_CellContentClick_1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtgv2.CellFormatting

    '    For j As Integer = 0 To 4

    '        If e.ColumnIndex = j Then
    '            e.CellStyle.BackColor = Color.LightGreen
    '        End If

    '    Next


    'End Sub


    Private Sub DataGridView1_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dtgv.CellPainting

        If e.ColumnIndex = 2 AndAlso e.RowIndex <> -1 Then

            Using gridBrush As Brush = New SolidBrush(Me.dtgv.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)

                Using gridLinePen As Pen = New Pen(gridBrush)
                    ' Clear cell  
                    e.Graphics.FillRectangle(backColorBrush, e.CellBounds)

                    ' Draw line (bottom border and right border of current cell)  
                    'If next row cell has different content, only draw bottom border line of current cell  
                    If e.RowIndex < dtgv.Rows.Count - 2 AndAlso dtgv.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
                    End If

                    ' Draw right border line of current cell  
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)

                    ' draw/fill content in current cell, and fill only one cell of multiple same cells  
                    If Not e.Value Is Nothing Then
                        If e.RowIndex > 0 AndAlso dtgv.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
                        Else
                            e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Black, e.CellBounds.X + 2, e.CellBounds.Y + 5, StringFormat.GenericDefault)
                        End If
                    End If

                    e.Handled = True
                End Using
            End Using
        End If
    End Sub




    Sub medidasgrid()




        dtgv.Columns("Proceso").Width = 80
        dtgv.Columns("Máquina").Width = 75
        dtgv.Columns("Pieza").Width = 155
        dtgv.Columns("Molde").Width = 60
        dtgv.Columns("Turno").Width = 45
        dtgv.Columns("Utilización").Width = 85
        dtgv.Columns("Rendimiento").Width = 89
        dtgv.Columns("Calidad").Width = 87
        dtgv.Columns("OEE").Width = 87




        dtgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue



    End Sub

    Sub medidasgrid2()




        dtgv2.Columns("Proceso").Width = 80
        dtgv2.Columns("Máquina").Width = 75
        dtgv2.Columns("Pieza").Width = 155
        dtgv2.Columns("Molde").Width = 60
        dtgv2.Columns("Turno").Width = 45
        dtgv2.Columns("Utilización").Width = 85
        dtgv2.Columns("Rendimiento").Width = 89
        dtgv2.Columns("Calidad").Width = 87
        dtgv2.Columns("OEE").Width = 87


        dtgv2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        muestragrid()

        medidasgrid()
        muestragrid2()
        medidasgrid2()
    End Sub
End Class