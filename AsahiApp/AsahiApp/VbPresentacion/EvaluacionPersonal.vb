Imports System.Data.SqlClient

Public Class EvaluacionPersonal
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Dim faltas As Integer


    Private Sub EvaluacionPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lbl_nombre.Text = Modulo_evaluaciones.e_nombre
        lbl_clave.Text = Modulo_evaluaciones.e_clave
        lbl_depto.Text = Modulo_evaluaciones.e_depto
        lbl_puesto.Text = Modulo_evaluaciones.e_puesto
        lbl_evaluacion.Text = Modulo_evaluaciones.e_evaluacion
        MuestraEtiquetasKardex()
        pbx.ImageLocation = ("V:\Recursos Humanos\CARPETA 2018\RH. FOTOGRAFIAS DEL PERSONAL\" & lbl_clave.Text & ".jpg")
        Me.pbx.SizeMode = PictureBoxSizeMode.CenterImage
        Me.pbx.BorderStyle = BorderStyle.Fixed3D
        pbx.SizeMode = PictureBoxSizeMode.StretchImage


    End Sub



    Sub MuestraEtiquetasKardex()

        Cn.Close()
        Cn.Open()

        Try
            Dim da As New SqlDataAdapter("Sp_MuestraIncidenciaEvaluaciones", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@clave", lbl_clave.Text)
            da.SelectCommand.Parameters.AddWithValue("@fecha", Modulo_evaluaciones.e_fecha)
            da.SelectCommand.Parameters.AddWithValue("@tipo", Modulo_evaluaciones.e_evaluacion)

            Dim ds As New DataSet
            ds.Clear()

            da.Fill(ds)

            lbl_n.Text = ds.Tables(0).Rows(0).Item(0)
            lbl_f.Text = ds.Tables(0).Rows(0).Item(1)
            lbl_p.Text = ds.Tables(0).Rows(0).Item(2)
            lbl_u.Text = ds.Tables(0).Rows(0).Item(3)
            lbl_g.Text = ds.Tables(0).Rows(0).Item(4)
            lbl_v.Text = ds.Tables(0).Rows(0).Item(5)
            lbl_r.Text = ds.Tables(0).Rows(0).Item(6)
            faltas = CInt(lbl_f.Text) + CInt(lbl_n.Text) + CInt(lbl_p.Text)


            Cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ' MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
        End Try

        Muestrapuntos()
        Muestragrid()

    End Sub


    Sub Muestrapuntos()

        Cn.Close()
        Cn.Open()

        Try
            Dim da As New SqlDataAdapter("Sp_tabulaAsistenciaEvaluacion", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@faltaj", CInt(lbl_u.Text))
            da.SelectCommand.Parameters.AddWithValue("@faltai", CInt(lbl_f.Text))
            da.SelectCommand.Parameters.AddWithValue("@psg", CInt(lbl_p.Text))
            da.SelectCommand.Parameters.AddWithValue("@sus", CInt(lbl_n.Text))
            da.SelectCommand.Parameters.AddWithValue("@ret", CInt(lbl_r.Text))
            da.SelectCommand.Parameters.AddWithValue("@tipo", Modulo_evaluaciones.e_evaluacion)
            da.SelectCommand.Parameters.AddWithValue("@puesto", Modulo_evaluaciones.e_puesto)

            Dim ds As New DataSet
            ds.Clear()

            da.Fill(ds)

            lbl_puntosd.Text = ds.Tables(0).Rows(0).Item(0)



            Cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ' MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
        End Try
    End Sub

    Sub Muestragrid()

        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestragridEvaluacionPersonal", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@tipo", lbl_evaluacion.Text)
            da.SelectCommand.Parameters.AddWithValue("@puntaje", lbl_puntosd.Text)
            da.SelectCommand.Parameters.AddWithValue("@faltas", faltas)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt

            Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        dtgvp.Columns("id_tipo").Visible = False
        dtgvp.Columns("id_evacrit").Visible = False
        dtgvp.Columns("Puntos Mínimos").Visible = False





        Me.dtgvp.Columns("Puntos Máximos").ReadOnly = True
        Me.dtgvp.Columns("Criterio").ReadOnly = True
        Me.dtgvp.Columns("Puntos Máximos").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
        Me.dtgvp.Columns("Puntaje").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

        dtgvp.Rows(9).ReadOnly = True

    End Sub


    Private Sub cellTextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

        '
        Dim tb As TextBox = TryCast(sender, TextBox)

        '
        If (tb Is Nothing) Then
            e.Handled = True
            Return
        End If

        Dim isDecimal, isSign, isValidChar As Boolean
        Dim decimalSeparator As String = Nothing

        Select Case e.KeyChar
            Case "."c

                '
                decimalSeparator = Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

                '
                e.KeyChar = decimalSeparator.Chars(0)

                '
                If (((tb.TextLength = 0) OrElse (tb.SelectionLength = tb.TextLength)) OrElse
                    ((tb.TextLength = 1) AndAlso ((tb.Text.Contains("-")) OrElse
                    (Text.Contains("+"))))) Then

                    SendKeys.Send("{0}")
                    SendKeys.Send("{" & decimalSeparator & "}")
                    e.Handled = True
                    Return
                End If


                isDecimal = True
                isValidChar = True


            Case Else

                Dim isDigit As Boolean = Char.IsDigit(e.KeyChar)
                Dim isControl As Boolean = Char.IsControl(e.KeyChar)

                If ((isDigit) OrElse (isControl)) Then
                    isValidChar = True

                Else
                    e.Handled = True
                    Return

                End If

        End Select


        '
        If ((isValidChar) And (tb.SelectionLength = tb.TextLength)) Then
            tb.Text = String.Empty
        End If

        If (isSign) Then

            '
            If ((tb.SelectionStart <> 0) OrElse
                (tb.Text.IndexOf("-") >= 0) OrElse
                (tb.Text.IndexOf("+") >= 0)) Then
                e.Handled = True
                Return
            End If
        End If

        If (isDecimal) Then

            If (tb.Text.IndexOf(decimalSeparator) >= 0) Then
                e.Handled = True
            End If
        End If





    End Sub

    Private Sub Malla_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgvp.EditingControlShowing
        Dim ValidarNro As TextBox = e.Control
        RemoveHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress
        AddHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress

    End Sub

    Private Sub btn_evaluar_Click(sender As Object, e As EventArgs) Handles btn_evaluar.Click


        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows



                If (row.Cells("Puntos Máximos").Value < row.Cells("Puntaje").Value) OrElse IsDBNull(row.Cells("Puntaje").Value) Then
                    row.Cells("Puntaje").Value = 0
                    row.DefaultCellStyle.BackColor = Color.LightSalmon


                End If

                row.DefaultCellStyle.BackColor = Color.White
            Next
        Catch
        End Try
    End Sub

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick
        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells("Puntos Máximos").Value < row.Cells("Puntaje").Value OrElse IsDBNull(row.Cells("Puntaje").Value) Then
                    ''  row.Cells("Puntaje").Value = 0
                    row.DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    row.DefaultCellStyle.BackColor = Color.White
                End If



            Next
        Catch
        End Try
    End Sub


    Private Sub dtgmuestra_CellContentClick1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells("Puntos Máximos").Value < row.Cells("Puntaje").Value OrElse IsDBNull(row.Cells("Puntaje").Value) Then
                    ''  row.Cells("Puntaje").Value = 0
                    row.DefaultCellStyle.BackColor = Color.LightSalmon
                Else
                    row.DefaultCellStyle.BackColor = Color.White
                End If
            Next

        Catch
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MuestraKardexEva.Show()
    End Sub


    Private Sub FrmMainPlatform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Me.Dispose()
        MuestraKardexEva.Dispose()

    End Sub

End Class