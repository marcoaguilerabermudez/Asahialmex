Imports System.Data.SqlClient
Imports System

Public Class EvaluacionIndirecto
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Dim faltas As Integer
    Dim id As Integer
    Dim estado As Integer
    Dim puntajemax As Double
    Dim idemp As Integer

    Dim idpuesto As Integer
    Dim iddepto As Integer
    Dim puntajeincidencias As Double




    Private Sub EvaluacionIndirecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        '  TabControl1.TabPages(2).Controls.Add(dtgvobj)

        'Dim tab As TabControl = TabControl1
        'tab.Contains(dtgvp)



        'tab.TabPages(0).dtgvp.Columns("PAE").DefaultCellStyle.BackColor = Color.LightBlue



        Dim style As New DataGridViewCellStyle
        style.Font = New Font(dtgvp.Font, FontStyle.Bold)


        Dim style2 As New DataGridViewCellStyle
        style2.Font = New Font(dtgvIndicadores.Font, FontStyle.Bold)


        Dim style3 As New DataGridViewCellStyle
        style3.Font = New Font(dtgvobj.Font, FontStyle.Bold)

        lbl_nombre.Text = Modulo_evaluacionesindi.e_nombre
        lbl_clave.Text = Modulo_evaluacionesindi.e_clave
        id = Modulo_evaluacionesindi.e_id
        idemp = Modulo_evaluacionesindi.e_idemp
        estado = Modulo_evaluacionesindi.e_estado
        lbl_depto.Text = Modulo_evaluacionesindi.e_depto
        lbl_puesto.Text = Modulo_evaluacionesindi.e_puesto
        lbl_evaluacion.Text = Modulo_evaluacionesindi.e_evaluacion
        idpuesto = Modulo_evaluacionesindi.id_puesto
        iddepto = Modulo_evaluacionesindi.id_depto
        MuestraEtiquetasKardex()
        pbx.ImageLocation = ("V:\Recursos Humanos\CARPETA 2018\RH. FOTOGRAFIAS DEL PERSONAL\" & lbl_clave.Text & ".jpg")
        Me.pbx.SizeMode = PictureBoxSizeMode.CenterImage
        Me.pbx.BorderStyle = BorderStyle.Fixed3D
        pbx.SizeMode = PictureBoxSizeMode.StretchImage


        '  Muestragrid()


        If estado = 1 Then
            Me.dtgvp.Columns("PES").ReadOnly = True
            dtgvp.Columns("PAE").DefaultCellStyle = style
            Me.dtgvp.Columns("PAE").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight


            txt_observaciones.Enabled = False

        ElseIf estado = 10 Then
            Me.dtgvp.Columns("PES").ReadOnly = False
            Me.dtgvp.Columns("PAE").ReadOnly = True
            dtgvp.Columns("PES").DefaultCellStyle = style
            Me.dtgvp.Columns("PES").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

        ElseIf estado = 11 Then
            Me.dtgvp.Columns("PES").ReadOnly = True
            Me.dtgvp.Columns("PAE").ReadOnly = True

            btn_evaluar.Enabled = False
            btn_evaluar2.Enabled = True
            'btn_evaluar2.Enabled = False
            btn_evaluar3.Enabled = False
            dtgvIndicadores.Columns("Logro %").DefaultCellStyle = style2
            Me.dtgvIndicadores.Columns("Logro %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

        ElseIf estado = 12 Then
            Me.dtgvp.Columns("PES").ReadOnly = True
            Me.dtgvp.Columns("PAE").ReadOnly = True
            Me.dtgvIndicadores.Columns("Logro %").ReadOnly = True
            dtgvobj.Columns("Logro %").DefaultCellStyle = style3
            Me.dtgvobj.Columns("Logro %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
            btn_evaluar.Enabled = False
            btn_evaluar2.Enabled = False
            btn_evaluar3.Enabled = True
            dtgvobj.Rows(1).Cells(6).ReadOnly = True
            dtgvobj.Rows(2).Cells(6).ReadOnly = True




        ElseIf estado = 13 OrElse estado = 14 Then
            Me.dtgvp.Columns("PES").ReadOnly = True
            Me.dtgvp.Columns("PAE").ReadOnly = True


            Me.dtgvIndicadores.Columns("Logro %").ReadOnly = True


            Me.dtgvobj.Columns("Logro %").ReadOnly = True



            btn_evaluar.Enabled = False
            btn_evaluar2.Enabled = False
            btn_evaluar3.Enabled = False


            dtgvobj.Rows(1).Cells(6).ReadOnly = True
            dtgvobj.Rows(2).Cells(6).ReadOnly = True


        End If

        sumarpuntaje()

    End Sub




    Sub MuestraEtiquetasKardex()

        Cn.Close()
        Cn.Open()

        Try
            Dim da As New SqlDataAdapter("Sp_MuestraIncidenciaEvaluaciones", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@clave", lbl_clave.Text)
            da.SelectCommand.Parameters.AddWithValue("@fecha", Modulo_evaluacionesindi.e_fecha)
            da.SelectCommand.Parameters.AddWithValue("@tipo", Modulo_evaluacionesindi.e_evaluacion)


            Dim ds As New DataSet
            ds.Clear()

            da.Fill(ds)

            lbl_n.Text = ds.Tables(0).Rows(0).Item(0)
            lbl_suspension.Text = ds.Tables(0).Rows(0).Item(0)

            lbl_f.Text = ds.Tables(0).Rows(0).Item(1)
            lbl_puntajeFI.Text = ds.Tables(0).Rows(0).Item(1)


            lbl_p.Text = ds.Tables(0).Rows(0).Item(2)
            lbl_puntajePSG.Text = (ds.Tables(0).Rows(0).Item(2) / 2)


            lbl_u.Text = ds.Tables(0).Rows(0).Item(3)
            lbl_puntajeFJ.Text = (ds.Tables(0).Rows(0).Item(3) / 2)


            lbl_g.Text = ds.Tables(0).Rows(0).Item(4) / 2
            lbl_v.Text = ds.Tables(0).Rows(0).Item(5)


            lbl_r.Text = ds.Tables(0).Rows(0).Item(6)
            lbl_puntajeRetardo.Text = (ds.Tables(0).Rows(0).Item(6) / 2)

            lbl_meses.Text = ds.Tables(0).Rows(0).Item(7)
            lbl_mejora.Text = ds.Tables(0).Rows(0).Item(8)
            lbl_amonestaciones.Text = ds.Tables(0).Rows(0).Item(9)
            faltas = CInt(lbl_f.Text) + CInt(lbl_n.Text) + CInt(lbl_p.Text)

            puntajeincidencias = CDbl(lbl_suspension.Text) + CDbl(lbl_puntajeFI.Text) + CDbl(lbl_puntajePSG.Text) + CDbl(lbl_puntajeFJ.Text) + CDbl(lbl_puntajeRetardo.Text)


            Cn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ' MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
        End Try


        Muestragrid()
        If estado > 10 Then
            MuestragridIndicador()
        End If

        If estado > 11 Then
            MuestragridObjetivos()
        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MuestraKardexEva.Show()
    End Sub


    Private Sub FrmMainPlatform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        Me.Dispose()
        MuestraKardexEva.Dispose()

    End Sub



    Sub Muestragrid()

        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestragridEvaluacionPersonal", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@tipo", lbl_evaluacion.Text)
            da.SelectCommand.Parameters.AddWithValue("@puntaje", 0)
            da.SelectCommand.Parameters.AddWithValue("@faltas", 0)
            da.SelectCommand.Parameters.AddWithValue("@estado", estado)
            da.SelectCommand.Parameters.AddWithValue("@id_eval", id)
            da.SelectCommand.Parameters.AddWithValue("@puesto", Modulo_evaluacionesindi.e_puesto)
            da.SelectCommand.Parameters.AddWithValue("@p_sus", 0)
            da.SelectCommand.Parameters.AddWithValue("@p_ret", 0)
            da.SelectCommand.Parameters.AddWithValue("@p_fi", 0)
            da.SelectCommand.Parameters.AddWithValue("@p_fj", 0)
            da.SelectCommand.Parameters.AddWithValue("@p_psg", 0)
            da.SelectCommand.Parameters.AddWithValue("@meses", 0)
            da.SelectCommand.Parameters.AddWithValue("@p_mejora", 0)
            da.SelectCommand.Parameters.AddWithValue("@p_amon", 0)

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
        dtgvp.Columns("nota").Visible = False
        'dtgvp.Columns("Evaluacion").Visible = False





        Me.dtgvp.Columns("PMP").ReadOnly = True
        Me.dtgvp.Columns("Criterio").ReadOnly = True
        Me.dtgvp.Columns("PME").ReadOnly = True

        Me.dtgvp.Columns("PMP").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
        Me.dtgvp.Columns("PAE").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
        Me.dtgvp.Columns("PES").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
        Me.dtgvp.Columns("PME").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight





        'dtgvp.Rows(9).ReadOnly = True
        'dtgvp.Rows(13).ReadOnly = True
        'dtgvp.Rows(5).ReadOnly = True



    End Sub






    Sub MuestragridIndicador()

        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestraResponsabilidadesObjetivos", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@clave", lbl_clave.Text)
            da.SelectCommand.Parameters.AddWithValue("@depto", iddepto)
            da.SelectCommand.Parameters.AddWithValue("@puesto", idpuesto)
            da.SelectCommand.Parameters.AddWithValue("@estado", estado)
            da.SelectCommand.Parameters.AddWithValue("@id", id)

            Dim dt As New DataTable
            da.Fill(dt)
            dtgvIndicadores.DataSource = dt


            Cn.Close()


            dtgvIndicadores.Columns("Nombre").DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            dtgvIndicadores.Columns("Nombre").Width = 400
            dtgvIndicadores.Columns("Estándar %").Width = 80
            dtgvIndicadores.Columns("Resultado %").Width = 85
            dtgvIndicadores.Columns("Logro %").Width = 80
            dtgvIndicadores.Columns("Puntaje").Width = 70



            dtgvIndicadores.Columns("Id").Visible = False
            dtgvIndicadores.Columns("Id_Puesto").Visible = False
            dtgvIndicadores.Columns("Id_Dpto").Visible = False
            dtgvIndicadores.Columns("Puntos_Max").Visible = False







            Me.dtgvIndicadores.Columns("Nombre").ReadOnly = True
            Me.dtgvIndicadores.Columns("Estándar %").ReadOnly = True
            Me.dtgvIndicadores.Columns("Resultado %").ReadOnly = True
            Me.dtgvIndicadores.Columns("Puntaje").ReadOnly = True


            Me.dtgvIndicadores.Columns("Estándar %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
            Me.dtgvIndicadores.Columns("Resultado %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
            Me.dtgvIndicadores.Columns("Puntaje").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
            Me.dtgvIndicadores.Columns("Logro %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub



    Sub MuestragridObjetivos()

        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestraevaluacionesObjetivos", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@clave", lbl_clave.Text)
            da.SelectCommand.Parameters.AddWithValue("@depto", iddepto)
            da.SelectCommand.Parameters.AddWithValue("@puesto", idpuesto)
            da.SelectCommand.Parameters.AddWithValue("@estado", estado)
            da.SelectCommand.Parameters.AddWithValue("@id", id)
            da.SelectCommand.Parameters.AddWithValue("@incidencias", puntajeincidencias)
            da.SelectCommand.Parameters.AddWithValue("@mejoras", lbl_mejora.Text)

            Dim dt As New DataTable
            da.Fill(dt)
            dtgvobj.DataSource = dt


            Cn.Close()


            'dtgvobj.Columns("Descripción").DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            'dtgvobj.Columns("Descripción").Width = 350
            'dtgvobj.Columns("Estándar %").Width = 80
            'dtgvobj.Columns("Resultado %").Width = 85
            'dtgvobj.Columns("Logro %").Width = 80
            'dtgvobj.Columns("Puntaje").Width = 70



            dtgvobj.Columns("Id").Visible = False
            dtgvobj.Columns("Id_Puesto").Visible = False
            dtgvobj.Columns("Id_Depto").Visible = False
            dtgvobj.Columns("Puntos_Max").Visible = False







            Me.dtgvobj.Columns("Descripción").ReadOnly = True
            Me.dtgvobj.Columns("Estándar %").ReadOnly = True
            Me.dtgvobj.Columns("Resultado %").ReadOnly = True
            Me.dtgvobj.Columns("Puntaje").ReadOnly = True


            Me.dtgvobj.Columns("Estándar %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
            Me.dtgvobj.Columns("Resultado %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
            Me.dtgvobj.Columns("Puntaje").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
            Me.dtgvobj.Columns("Logro %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight


            dtgvobj.Rows(2).Cells(6).ReadOnly = True
            'dtgvobj.Rows(2).ReadOnly = True
            'dtgvobj.Rows(3).ReadOnly = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub




    Public Sub cellTextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

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

    Private Sub Malla_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgvp.EditingControlShowing, dtgvIndicadores.EditingControlShowing, dtgvobj.EditingControlShowing

        '
        Dim ValidarNro As TextBox = e.Control
        RemoveHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress
        AddHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress

    End Sub

    'Private Sub Malla_EditingControlShowing2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgvIndicadores.EditingControlShowing
    '    Dim ValidarNro As TextBox = e.Control
    '    RemoveHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress
    '    AddHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress

    'End Sub


    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick
        Try

            If estado = 1 Then


                For Each row As DataGridViewRow In Me.dtgvp.Rows

                    If row.Cells("PMP").Value < row.Cells("PAE").Value OrElse IsDBNull(row.Cells("PAE").Value) Then
                        ''  row.Cells("Puntaje").Value = 0
                        row.DefaultCellStyle.BackColor = Color.LightSalmon

                    Else
                        row.DefaultCellStyle.BackColor = Color.White
                    End If

                Next

            ElseIf estado = 10 Then

                For Each row1 As DataGridViewRow In Me.dtgvp.Rows
                    If row1.Cells("PMP").Value < row1.Cells("PES").Value OrElse IsDBNull(row1.Cells("PES").Value) Then
                        ''  row.Cells("Puntaje").Value = 0
                        row1.DefaultCellStyle.BackColor = Color.LightSalmon
                    Else
                        row1.DefaultCellStyle.BackColor = Color.White
                    End If

                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try



        txt_observaciones.Text = Me.dtgvp.Rows(e.RowIndex).Cells("nota").Value.ToString()


        'MessageBox.Show(Me.dtgvp.Rows(e.RowIndex).Cells("id_evacrit").Value.ToString())

        pbx_eva.ImageLocation = ("V:\Eva_F\" & Me.dtgvp.Rows(e.RowIndex).Cells("id_evacrit").Value.ToString() & ".jpg")
        Me.pbx_eva.SizeMode = PictureBoxSizeMode.CenterImage
        Me.pbx_eva.BorderStyle = BorderStyle.Fixed3D
        pbx_eva.SizeMode = PictureBoxSizeMode.StretchImage







    End Sub





    Private Sub dtgvp_CellContentClick2(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvIndicadores.CellClick, dtgvobj.CellClick

        If estado = 11 Then

            Try

                For Each row2 As DataGridViewRow In Me.dtgvIndicadores.Rows
                    If row2.Cells("Logro %").Value > 100 OrElse IsDBNull(row2.Cells("Logro %").Value) Then
                        ''  row.Cells("Puntaje").Value = 0
                        row2.DefaultCellStyle.BackColor = Color.LightSalmon
                        row2.Cells("Resultado %").Value = 0.0
                        row2.Cells("Puntaje").Value = 0.0
                    Else
                        If row2.Cells("Logro %").Value = 0 OrElse IsDBNull(row2.Cells("Logro %").Value) Then
                            row2.DefaultCellStyle.BackColor = Color.White
                        Else
                            row2.DefaultCellStyle.BackColor = Color.White

                            row2.Cells("Resultado %").Value = (CDbl(row2.Cells("Estándar %").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
                            row2.Cells("Puntaje").Value = (CDbl(row2.Cells("Puntos_Max").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
                            ' Pendiente row2.Cells("Puntaje").Value = 0.0

                        End If

                    End If

                Next

            Catch
            End Try
        Else
        End If









    End Sub









    Private Sub dtgmuestra_CellContentClick11(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter

        Try
            If estado = 1 Then

                For Each row As DataGridViewRow In Me.dtgvp.Rows

                    If row.Cells("PMP").Value < row.Cells("PAE").Value OrElse IsDBNull(row.Cells("PAE").Value) Then
                        ''  row.Cells("Puntaje").Value = 0
                        row.DefaultCellStyle.BackColor = Color.LightSalmon
                    Else
                        row.DefaultCellStyle.BackColor = Color.White
                    End If

                Next

            ElseIf estado = 10 Then

                For Each row1 As DataGridViewRow In Me.dtgvp.Rows
                    If row1.Cells("PMP").Value < row1.Cells("PES").Value OrElse IsDBNull(row1.Cells("PES").Value) Then
                        ''  row.Cells("Puntaje").Value = 0
                        row1.DefaultCellStyle.BackColor = Color.LightSalmon
                    Else
                        row1.DefaultCellStyle.BackColor = Color.White
                    End If

                Next



            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try


        txt_observaciones.Text = Me.dtgvp.Rows(e.RowIndex).Cells("nota").Value.ToString()

        pbx_eva.ImageLocation = ("V:\Eva_F\" & Me.dtgvp.Rows(e.RowIndex).Cells("id_evacrit").Value.ToString() & ".jpg")

        Me.pbx_eva.SizeMode = PictureBoxSizeMode.CenterImage

        Me.pbx_eva.BorderStyle = BorderStyle.Fixed3D

        pbx_eva.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub



    Private Sub dtgmuestra_CellContentClick12(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvIndicadores.RowEnter

        If estado = 11 Then

            Try

                For Each row2 As DataGridViewRow In Me.dtgvIndicadores.Rows
                    If row2.Cells("Logro %").Value > 100 OrElse IsDBNull(row2.Cells("Logro %").Value) Then
                        ''  row.Cells("Puntaje").Value = 0
                        row2.DefaultCellStyle.BackColor = Color.LightSalmon
                        row2.Cells("Resultado %").Value = 0.0
                        row2.Cells("Puntaje").Value = 0.0
                    Else
                        If row2.Cells("Logro %").Value = 0 OrElse IsDBNull(row2.Cells("Logro %").Value) Then
                            row2.DefaultCellStyle.BackColor = Color.White
                        Else
                            row2.DefaultCellStyle.BackColor = Color.White

                            row2.Cells("Resultado %").Value = (CDbl(row2.Cells("Estándar %").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
                            row2.Cells("Puntaje").Value = (CDbl(row2.Cells("Puntos_Max").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
                            ' Pendiente row2.Cells("Puntaje").Value = 0.0

                        End If

                    End If

                Next

            Catch
            End Try
        Else
        End If

        'dtgvobj.Rows(2).Cells(6).ReadOnly = True
        'dtgvobj.Rows(3).Cells(6).ReadOnly = True

    End Sub




    Private Sub dtgvp_CellContentClick5(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvobj.CellClick


        If estado = 12 Then



            'Try

            '    For Each row2 As DataGridViewRow In Me.dtgvobj.Rows


            '        If row2.Cells("Logro %").Value > 100 OrElse IsDBNull(row2.Cells("Logro %").Value) Then
            '            ''  row.Cells("Puntaje").Value = 0
            '            row2.DefaultCellStyle.BackColor = Color.LightSalmon
            '            row2.Cells("Resultado %").Value = 0.0
            '            row2.Cells("Puntaje").Value = 0.0
            '        Else
            '            If row2.Cells("Logro %").Value = 0 OrElse IsDBNull(row2.Cells("Logro %").Value) Then
            '                row2.DefaultCellStyle.BackColor = Color.White
            '            Else
            '                row2.DefaultCellStyle.BackColor = Color.White

            '                row2.Cells("Resultado %").Value = (CDbl(row2.Cells("Estándar %").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
            '                row2.Cells("Puntaje").Value = (CDbl(row2.Cells("Puntos_Max").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
            '                ' Pendiente row2.Cells("Puntaje").Value = 0.0

            '            End If

            '        End If



            '    Next

            'Catch
            'End Try



            Try




                For Each row2 As DataGridViewRow In Me.dtgvobj.Rows


                    If row2.Cells("Logro %").Value > 100 OrElse IsDBNull(row2.Cells("Logro %").Value) Then
                        ''  row.Cells("Puntaje").Value = 0
                        row2.DefaultCellStyle.BackColor = Color.LightSalmon
                        row2.Cells("Resultado %").Value = 0.0
                        row2.Cells("Puntaje").Value = 0.0
                    Else
                        If row2.Cells("Logro %").Value = 0 OrElse IsDBNull(row2.Cells("Logro %").Value) Then
                            row2.DefaultCellStyle.BackColor = Color.White
                        Else
                            row2.DefaultCellStyle.BackColor = Color.White

                            row2.Cells("Resultado %").Value = (CDbl(row2.Cells("Estándar %").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
                            row2.Cells("Puntaje").Value = (CDbl(row2.Cells("Puntos_Max").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
                            ' Pendiente row2.Cells("Puntaje").Value = 0.0

                        End If

                    End If






                Next

            Catch
            End Try
            dtgvobj.Rows(1).Cells(6).ReadOnly = True
            dtgvobj.Rows(2).Cells(6).ReadOnly = True
        End If


    End Sub

    Private Sub dtgmuestra_CellContentClick13(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvobj.RowEnter




        If estado = 12 Then





            Try

                For Each row2 As DataGridViewRow In Me.dtgvobj.Rows
                    If row2.Cells("Logro %").Value > 100 Then
                        ''  row.Cells("Puntaje").Value = 0
                        row2.DefaultCellStyle.BackColor = Color.LightSalmon
                        row2.Cells("Resultado %").Value = 0.0
                        row2.Cells("Puntaje").Value = 0.0
                    Else





                        row2.DefaultCellStyle.BackColor = Color.White
                        '   row2.Cells("Resultado %").Value = (CDbl(row2.Cells("Estándar %").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
                        '  row2.Cells("Puntaje").Value = (CDbl(row2.Cells("Puntos_Max").Value) * CDbl(row2.Cells("Logro %").Value)) / 100



                    End If

                Next

                'dtgvobj(1, "Logro %",).ReadOnly = False
                'dtgvobj(2, "Logro %",).ReadOnly = False

                '  MessageBox.Show(dtgvobj.Rows(2).ToString)

                '  dtgvobj.Rows(2).Cells(0).ReadOnly = True

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
        End If



    End Sub





    Sub Cargaevaluacion()


        Dim style As New DataGridViewCellStyle
        style.Font = New Font(dtgvp.Font, FontStyle.Bold)


        Dim style2 As New DataGridViewCellStyle
        style2.Font = New Font(dtgvIndicadores.Font, FontStyle.Bold)


        Dim style3 As New DataGridViewCellStyle
        style3.Font = New Font(dtgvobj.Font, FontStyle.Bold)


        Try



            sumarpuntaje()






            Dim Pregunta As Integer



            If estado = 1 OrElse estado = 10 Then



                If estado = 1 Then
                    Pregunta = MsgBox("Puntaje máximo posible = " & lbl_puntajm.Text & " " + vbCrLf + " Puntaje obtenido = " & lbl_puntajetotal.Text & " " + vbCrLf + " ¿Es correcta su Autoevaluación?", vbYesNo + vbExclamation + vbDefaultButton2, "Autoevaluación")
                ElseIf estado = 10 Then
                    Pregunta = MsgBox("Puntaje máximo posible = " & lbl_puntajm2.Text & " " + vbCrLf + " Puntaje obtenido = " & lbl_puntajetotal2.Text & " " + vbCrLf + " ¿Es correcta su evaluación?", vbYesNo + vbExclamation + vbDefaultButton2, "Evaluación")
                ElseIf estado = 11 Then
                    Pregunta = MsgBox("Puntaje máximo posible = " & lbl_puntajm3.Text & " " + vbCrLf + " Puntaje obtenido = " & lbl_puntajetotal3.Text & " " + vbCrLf + " ¿Es correcta su evaluación de indicadores?", vbYesNo + vbExclamation + vbDefaultButton2, "Indicadores")

                End If


                If Pregunta = vbYes Then

                    Cn.Close()


                    Dim command As New SqlCommand("Sp_EvaluaEvaluacion", Cn)
                    Cn.Open()
                    Dim fila As DataGridViewRow = New DataGridViewRow()
                    command.CommandType = CommandType.StoredProcedure

                    Try

                        For Each fila In dtgvp.Rows


                            command.Parameters.Clear()

                            command.Parameters.AddWithValue("@id_eva", id)
                            command.Parameters.AddWithValue("@user", idemp)
                            command.Parameters.AddWithValue("@id_evacrit", (fila.Cells("id_evacrit").Value))
                            command.Parameters.AddWithValue("@puntmax", (fila.Cells("PMP").Value))
                            command.Parameters.AddWithValue("@descripcion", lbl_evaluacion.Text)
                            If estado = 1 Then
                                command.Parameters.AddWithValue("@puntaje", (fila.Cells("PAE").Value))
                                command.Parameters.AddWithValue("@punttotal", lbl_puntajetotal.Text)
                            ElseIf estado = 10 Then
                                command.Parameters.AddWithValue("@puntaje", (fila.Cells("PES").Value))
                                command.Parameters.AddWithValue("@punttotal", lbl_puntajetotal2.Text)
                            End If
                            command.Parameters.AddWithValue("@nota", txt_observaciones.Text)
                            command.Parameters.AddWithValue("@estado", estado)
                            command.Parameters.AddWithValue("@movimiento", (fila.Cells("id_tipo").Value))
                            command.Parameters.AddWithValue("@puesto", lbl_puesto.Text)
                            command.Parameters.AddWithValue("@tot_porcentaje", 0)
                            command.Parameters.AddWithValue("@tot_puntos", 0)
                            command.Parameters.AddWithValue("@porcemax", 0)
                            command.Parameters.AddWithValue("@id_res_obj", 0)
                            command.Parameters.AddWithValue("@id_depto", id_depto)
                            command.Parameters.AddWithValue("@id_puesto", id_puesto)

                            command.ExecuteNonQuery()

                        Next

                        MessageBox.Show("El empleado ha sido evaluado correctamente", "¡Carga exitosa!")

                        Dim ownerForm As EvaluacionPrincipalIndirecto = Me.Owner
                        ownerForm.Muestragrid()

                        btn_evaluar.Enabled = False

                        If estado = 10 Then

                            estado = 11
                            btn_evaluar2.Enabled = True
                            'btn_evaluar2.Enabled = False
                            'zxxx



                            MuestragridIndicador()
                            dtgvIndicadores.Columns("Logro %").DefaultCellStyle = style2
                            Me.dtgvIndicadores.Columns("Logro %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
                        End If



                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)

                    Finally
                        Cn.Close()
                    End Try

                ElseIf Pregunta = vbNo Then

                    MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If


            ElseIf estado = 11 Then



                Pregunta = MsgBox("Puntaje máximo posible = " & lbl_puntajm3.Text & " " + vbCrLf + " Puntaje obtenido = " & lbl_puntajetotal3.Text & " " + vbCrLf + " ¿Es correcta su evaluación de indicadores?", vbYesNo + vbExclamation + vbDefaultButton2, "Indicadores")




                If Pregunta = vbYes Then

                    Cn.Close()


                    Dim command As New SqlCommand("Sp_EvaluaEvaluacion", Cn)
                    Cn.Open()
                    Dim fila As DataGridViewRow = New DataGridViewRow()
                    command.CommandType = CommandType.StoredProcedure

                    Try

                        For Each fila In dtgvIndicadores.Rows


                            command.Parameters.Clear()

                            command.Parameters.AddWithValue("@id_eva", id)
                            command.Parameters.AddWithValue("@id_res_obj", (fila.Cells("Id").Value))
                            command.Parameters.AddWithValue("@tot_porcentaje", (fila.Cells("Resultado %").Value))
                            command.Parameters.AddWithValue("@porcemax", (fila.Cells("Estándar %").Value))
                            command.Parameters.AddWithValue("@tot_puntos", (fila.Cells("Puntaje").Value))
                            command.Parameters.AddWithValue("@puntmax", (fila.Cells("Puntos_Max").Value))
                            command.Parameters.AddWithValue("@user", idemp)
                            command.Parameters.AddWithValue("@punttotal", lbl_puntajetotal3.Text)
                            command.Parameters.AddWithValue("@nota", "")
                            command.Parameters.AddWithValue("@estado", estado)
                            command.Parameters.AddWithValue("@movimiento", 0)
                            command.Parameters.AddWithValue("@puesto", lbl_puesto.Text)
                            command.Parameters.AddWithValue("@id_depto", id_depto)
                            command.Parameters.AddWithValue("@id_puesto", id_puesto)


                            command.Parameters.AddWithValue("@id_evacrit", 0)

                            command.Parameters.AddWithValue("@descripcion", lbl_evaluacion.Text)

                            command.Parameters.AddWithValue("@puntaje", 0)






                            command.ExecuteNonQuery()

                        Next

                        MessageBox.Show("El empleado ha sido evaluado correctamente", "¡Carga exitosa!")

                        Dim ownerForm As EvaluacionPrincipalIndirecto = Me.Owner
                        ownerForm.Muestragrid()
                        btn_evaluar2.Enabled = False
                        estado = 12
                        btn_evaluar3.Enabled = True
                        MuestragridObjetivos()
                        dtgvobj.Columns("Logro %").DefaultCellStyle = style2
                        Me.dtgvobj.Columns("Logro %").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
                        dtgvobj.Rows(1).Cells(6).ReadOnly = True
                        dtgvobj.Rows(2).Cells(6).ReadOnly = True


                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)

                    Finally
                        Cn.Close()
                    End Try

                ElseIf Pregunta = vbNo Then

                    MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If


            ElseIf estado = 12 Then



                Pregunta = MsgBox("Puntaje máximo posible = " & lbl_puntajm5.Text & " " + vbCrLf + " Puntaje obtenido = " & lbl_puntajetotal5.Text & " " + vbCrLf + " ¿Es correcta su evaluación de Objetivos?", vbYesNo + vbExclamation + vbDefaultButton2, "Objetivos")




                If Pregunta = vbYes Then

                    Cn.Close()


                    Dim command As New SqlCommand("Sp_EvaluaEvaluacion", Cn)
                    Cn.Open()
                    Dim fila As DataGridViewRow = New DataGridViewRow()
                    command.CommandType = CommandType.StoredProcedure

                    Try

                        For Each fila In dtgvobj.Rows


                            command.Parameters.Clear()

                            command.Parameters.AddWithValue("@id_eva", id)
                            command.Parameters.AddWithValue("@id_res_obj", (fila.Cells("Id").Value))
                            command.Parameters.AddWithValue("@tot_porcentaje", (fila.Cells("Resultado %").Value))
                            command.Parameters.AddWithValue("@porcemax", (fila.Cells("Estándar %").Value))
                            command.Parameters.AddWithValue("@tot_puntos", (fila.Cells("Puntaje").Value))
                            command.Parameters.AddWithValue("@puntmax", (fila.Cells("Puntos_Max").Value))
                            command.Parameters.AddWithValue("@user", idemp)
                            command.Parameters.AddWithValue("@punttotal", lbl_puntajetotal5.Text)
                            command.Parameters.AddWithValue("@nota", "")
                            command.Parameters.AddWithValue("@estado", estado)
                            command.Parameters.AddWithValue("@movimiento", 0)
                            command.Parameters.AddWithValue("@puesto", lbl_puesto.Text)
                            command.Parameters.AddWithValue("@id_depto", id_depto)
                            command.Parameters.AddWithValue("@id_puesto", id_puesto)


                            command.Parameters.AddWithValue("@id_evacrit", 0)

                            command.Parameters.AddWithValue("@descripcion", lbl_evaluacion.Text)

                            command.Parameters.AddWithValue("@puntaje", 0)






                            command.ExecuteNonQuery()

                        Next

                        MessageBox.Show("El empleado ha sido evaluado correctamente", "¡Carga exitosa!")

                        Dim ownerForm As EvaluacionPrincipalIndirecto = Me.Owner
                        ownerForm.Muestragrid()
                        btn_evaluar3.Enabled = False
                        estado = 13




                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)

                    Finally
                        Cn.Close()
                    End Try

                ElseIf Pregunta = vbNo Then

                    MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If



            End If



        Catch
            MessageBox.Show("No puede dejar criterios sin evaluación", "Aviso")
        End Try
    End Sub

    Private Sub btn_evaluar_Click(sender As Object, e As EventArgs) Handles btn_evaluar.Click, btn_evaluar2.Click, btn_evaluar3.Click

        If estado = 1 Then
            Try
                For Each row As DataGridViewRow In Me.dtgvp.Rows



                    If (row.Cells("PMP").Value < row.Cells("PAE").Value) OrElse IsDBNull(row.Cells("PAE").Value) Then
                        row.Cells("PAE").Value = 0
                        row.DefaultCellStyle.BackColor = Color.LightSalmon
                    End If


                    row.DefaultCellStyle.BackColor = Color.White

                Next
            Catch
            End Try


        ElseIf estado = 10 Then

            Try
                For Each row As DataGridViewRow In Me.dtgvp.Rows



                    If (row.Cells("PMP").Value < row.Cells("PES").Value) OrElse IsDBNull(row.Cells("PES").Value) Then
                        row.Cells("PES").Value = 0
                        row.DefaultCellStyle.BackColor = Color.LightSalmon
                    End If


                    row.DefaultCellStyle.BackColor = Color.White

                Next
            Catch
            End Try

        ElseIf estado = 11 Then

            Try
                For Each row As DataGridViewRow In Me.dtgvIndicadores.Rows
                    row.Cells("Resultado %").Value = (CDbl(row.Cells("Estándar %").Value) * CDbl(row.Cells("Logro %").Value)) / 100
                    row.Cells("Puntaje").Value = (CDbl(row.Cells("Puntos_Max").Value) * CDbl(row.Cells("Logro %").Value)) / 100


                    If (row.Cells("Logro %").Value > 100 OrElse IsDBNull(row.Cells("Logro %").Value)) Then
                        row.Cells("Logro %").Value = 0
                        row.Cells("Puntaje").Value = 0
                        row.DefaultCellStyle.BackColor = Color.LightSalmon
                    End If


                    row.DefaultCellStyle.BackColor = Color.White
                Next





            Catch
            End Try


        ElseIf estado = 12 Then

            For Each row2 As DataGridViewRow In Me.dtgvobj.Rows
                row2.Cells("Resultado %").Value = (CDbl(row2.Cells("Estándar %").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
                row2.Cells("Puntaje").Value = (CDbl(row2.Cells("Puntos_Max").Value) * CDbl(row2.Cells("Logro %").Value)) / 100
            Next

            Try
                For Each row As DataGridViewRow In Me.dtgvobj.Rows



                    If (row.Cells("Logro %").Value > 100 OrElse IsDBNull(row.Cells("Logro %").Value)) Then
                        row.Cells("Logro %").Value = 0
                        row.Cells("Puntaje").Value = 0
                        row.DefaultCellStyle.BackColor = Color.LightSalmon
                    End If


                    row.DefaultCellStyle.BackColor = Color.White

                Next
            Catch
            End Try



        End If


        Cargaevaluacion()
    End Sub


    Sub sumarpuntaje()

        ''  If estado = 1 Then

        Dim Total As Double
        Dim TotalM As Double

        For Each row As DataGridViewRow In Me.dtgvp.Rows
            Total += Val(row.Cells("PAE").Value)
            TotalM += Val(row.Cells("PMP").Value)
        Next
        Me.lbl_puntajetotal.Text = Total.ToString
        Me.lbl_puntajm.Text = TotalM.ToString

        'Else


        '    Dim Total As Double
        '    Dim TotalM As Double

        '    For Each row As DataGridViewRow In Me.dtgvp.Rows
        '        Total += Val(row.Cells("PES").Value)
        '        TotalM += Val(row.Cells("PMP").Value)
        '    Next
        '    Me.lbl_puntajetotal2.Text = Total.ToString
        '    Me.lbl_puntajm2.Text = TotalM.ToString
        'End If


        Dim Total2 As Double
        Dim TotalM2 As Double

        For Each row2 As DataGridViewRow In Me.dtgvp.Rows
            Total2 += Val(row2.Cells("PES").Value)
            TotalM2 += Val(row2.Cells("PMP").Value)
        Next
        Me.lbl_puntajetotal2.Text = Total2.ToString
        Me.lbl_puntajm2.Text = TotalM2.ToString


        Try
            Dim Total3 As Double
            Dim TotalM3 As Double

            For Each row3 As DataGridViewRow In Me.dtgvIndicadores.Rows
                Total3 += Val(row3.Cells("Puntaje").Value)
                TotalM3 += Val(row3.Cells("Puntos_Max").Value)
            Next
            Me.lbl_puntajetotal3.Text = Math.Round(Total3, 2)
            Me.lbl_puntajm3.Text = Math.Round(TotalM3, 2)



            Dim Total4 As Double
            Dim TotalM4 As Double

            For Each row4 As DataGridViewRow In Me.dtgvIndicadores.Rows
                Total4 += Val(row4.Cells("Resultado %").Value)
                TotalM4 += Val(row4.Cells("Estándar %").Value)
            Next
            Me.lbl_puntajetotal4.Text = Math.Round(Total4, 2)
            Me.lbl_puntajem4.Text = Math.Round(TotalM4, 2)




        Catch ex As Exception

        End Try




        If estado > 11 Then

            Try
                Dim Total5 As Double
                Dim TotalM5 As Double

                For Each row5 As DataGridViewRow In Me.dtgvobj.Rows
                    Total5 += Val(row5.Cells("Puntaje").Value)
                    TotalM5 += Val(row5.Cells("Puntos_Max").Value)
                Next
                Me.lbl_puntajetotal5.Text = Math.Round(Total5, 2)
                Me.lbl_puntajm5.Text = Math.Round(TotalM5, 2)





                Dim Total6 As Double
                Dim TotalM6 As Double

                For Each row4 As DataGridViewRow In Me.dtgvobj.Rows
                    Total6 += Val(row4.Cells("Resultado %").Value)
                    TotalM6 += Val(row4.Cells("Estándar %").Value)
                Next
                Me.lbl_puntajetotal6.Text = Math.Round(Total6, 2)
                Me.lbl_puntajm6.Text = Math.Round(TotalM6, 2)



                dtgvobj.Columns("Id").Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
        End If






    End Sub


End Class