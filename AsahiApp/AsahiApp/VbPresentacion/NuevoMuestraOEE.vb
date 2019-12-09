Imports System.Data.SqlClient

Public Class NuevoMuestraOEE
    Dim a As Integer

    Private Sub MuestraOeeCompleto_Load2(sender As Object, e As EventArgs) Handles MyBase.Load
        ''  Me.WindowState = FormWindowState.Maximized
        muestragrid()
        medidasgrid()
        muestragrid2()
        medidasgrid2()
        fechaesp()
        lbl_momento.Text = DateTime.Now
    End Sub

    Sub fechaesp()
        If Date.Today.Month = 1 Then
            lbl_fecha.Text = "ENERO"
        ElseIf Date.Today.Month = 2 Then
            lbl_fecha.Text = "FEBRERO"
        ElseIf Date.Today.Month = 3 Then
            lbl_fecha.Text = "MARZO"
        ElseIf Date.Today.Month = 4 Then
            lbl_fecha.Text = "ABRIL"
        ElseIf Date.Today.Month = 5 Then
            lbl_fecha.Text = "MAYO"
        ElseIf Date.Today.Month = 6 Then
            lbl_fecha.Text = "JUNIO"
        ElseIf Date.Today.Month = 7 Then
            lbl_fecha.Text = "JULIO"
        ElseIf Date.Today.Month = 8 Then
            lbl_fecha.Text = "AGOSTO"
        ElseIf Date.Today.Month = 9 Then
            lbl_fecha.Text = "SEPTIEMBRE"
        ElseIf Date.Today.Month = 10 Then
            lbl_fecha.Text = "OCTUBRE"
        ElseIf Date.Today.Month = 11 Then
            lbl_fecha.Text = "NOVIEMBRE"
        ElseIf Date.Today.Month = 12 Then
            lbl_fecha.Text = "DICIEMBRE"
        End If
    End Sub


    Sub fechajp()
        If Date.Today.Month = 1 Then
            lbl_fecha.Text = "1 月"
        ElseIf Date.Today.Month = 2 Then
            lbl_fecha.Text = "2 月"
        ElseIf Date.Today.Month = 3 Then
            lbl_fecha.Text = "3 月"
        ElseIf Date.Today.Month = 4 Then
            lbl_fecha.Text = "4 月"
        ElseIf Date.Today.Month = 5 Then
            lbl_fecha.Text = "5 月"
        ElseIf Date.Today.Month = 6 Then
            lbl_fecha.Text = "6 月"
        ElseIf Date.Today.Month = 7 Then
            lbl_fecha.Text = "7 月"
        ElseIf Date.Today.Month = 8 Then
            lbl_fecha.Text = "8 月"
        ElseIf Date.Today.Month = 9 Then
            lbl_fecha.Text = "9 月"
        ElseIf Date.Today.Month = 10 Then
            lbl_fecha.Text = "10 月"
        ElseIf Date.Today.Month = 11 Then
            lbl_fecha.Text = "11 月"
        ElseIf Date.Today.Month = 12 Then
            lbl_fecha.Text = "12 月"
        End If
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


    Sub muestragrid3()
        Try
            CapturaOEE.Cn.Open()
            Dim da As New SqlDataAdapter("Sp_reportegeneraloee", CapturaOEE.Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@var", 3)
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

            Me.dtgv.Columns("使用%").DefaultCellStyle.Format = "0.00%"
            Me.dtgv.Columns("稼働率%").DefaultCellStyle.Format = "0.00%"
            Me.dtgv.Columns("品質%").DefaultCellStyle.Format = "0.00%"
            Me.dtgv.Columns("OEE").DefaultCellStyle.Format = "0.00%"

            CapturaOEE.Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CapturaOEE.Cn.Close()
        End Try

    End Sub


    Sub muestragrid4()
        Try
            CapturaOEE.Cn.Open()


            Dim da As New SqlDataAdapter("Sp_reportegeneraloee", CapturaOEE.Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@var", 4)

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

            Me.dtgv2.Columns("使用%").DefaultCellStyle.Format = "0.00%"
            Me.dtgv2.Columns("稼働率%").DefaultCellStyle.Format = "0.00%"
            Me.dtgv2.Columns("品質%").DefaultCellStyle.Format = "0.00%"
            Me.dtgv2.Columns("OEE").DefaultCellStyle.Format = "0.00%"

            CapturaOEE.Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CapturaOEE.Cn.Close()
        End Try

    End Sub




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

        dtgv.Columns("Proceso").Width = 60
        dtgv.Columns("Máquina").Width = 63
        dtgv.Columns("Pieza").Width = 98
        dtgv.Columns("Molde").Width = 40
        dtgv.Columns("Turno").Width = 33
        dtgv.Columns("Utilización").Width = 60
        dtgv.Columns("Rendimiento").Width = 62
        dtgv.Columns("Calidad").Width = 56
        dtgv.Columns("OEE").Width = 56




        dtgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

    End Sub

    Sub medidasgrid2()

        dtgv2.Columns("Proceso").Width = 60
        dtgv2.Columns("Máquina").Width = 63
        dtgv2.Columns("Pieza").Width = 98
        dtgv2.Columns("Molde").Width = 40
        dtgv2.Columns("Turno").Width = 33
        dtgv2.Columns("Utilización").Width = 60
        dtgv2.Columns("Rendimiento").Width = 62
        dtgv2.Columns("Calidad").Width = 56
        dtgv2.Columns("OEE").Width = 56


        dtgv2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue


    End Sub


    Sub medidasgrid3()

        dtgv.Columns("工程").Width = 60
        dtgv.Columns("機械").Width = 63
        dtgv.Columns("製品").Width = 98
        dtgv.Columns("金型").Width = 42
        dtgv.Columns("直").Width = 33
        dtgv.Columns("使用%").Width = 60
        dtgv.Columns("稼働率%").Width = 62
        dtgv.Columns("品質%").Width = 56
        dtgv.Columns("OEE").Width = 56




        dtgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue

    End Sub

    Sub medidasgrid4()

        dtgv2.Columns("工程").Width = 60
        dtgv2.Columns("機械").Width = 63
        dtgv2.Columns("製品").Width = 98
        dtgv2.Columns("金型").Width = 42
        dtgv2.Columns("直").Width = 33
        dtgv2.Columns("使用%").Width = 60
        dtgv2.Columns("稼働率%").Width = 62
        dtgv2.Columns("品質%").Width = 56
        dtgv2.Columns("OEE").Width = 56


        dtgv2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_actualiza.Click
        If btn_esp.Checked = True Then
            muestragrid()
            medidasgrid()
            muestragrid2()
            medidasgrid2()
            btn_actualiza.Text = "Actualizar"
            lbl_actu.Text = "Última actualización"
            fechaesp()
            lbl_momento.Text = DateTime.Now
        ElseIf btn_jap.Checked = True Then
            muestragrid3()
            medidasgrid3()
            muestragrid4()
            medidasgrid4()
            btn_actualiza.Text = "アップデート"
            lbl_actu.Text = "更新日付"
            fechajp()
            lbl_momento.Text = DateTime.Now
        Else
            muestragrid()
            medidasgrid()
            muestragrid2()
            medidasgrid2()
            btn_actualiza.Text = "Actualizar"
            lbl_actu.Text = "Última actualización"
            fechaesp()
            lbl_momento.Text = DateTime.Now

        End If

    End Sub

    Private Sub btn_esp_CheckedChanged(sender As Object, e As EventArgs) Handles btn_esp.CheckedChanged
        muestragrid()
        medidasgrid()
        muestragrid2()
        medidasgrid2()
        btn_actualiza.Text = "Actualizar"
        lbl_actu.Text = "Última actualización"
        fechaesp()
        lbl_momento.Text = DateTime.Now
    End Sub

    Private Sub btn_jap_CheckedChanged(sender As Object, e As EventArgs) Handles btn_jap.CheckedChanged
        muestragrid3()
        medidasgrid3()
        muestragrid4()
        medidasgrid4()
        btn_actualiza.Text = "アップデート"
        lbl_actu.Text = "更新日付"
        fechajp()
        lbl_momento.Text = DateTime.Now
    End Sub

End Class