Imports System.Data.SqlClient

Public Class Requerimientos_RecepcionPO
    Dim var_filtro As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer

    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String

    Dim Cantidad_Requerida As Double
    Dim filtro As Integer


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Requerimientos_RecepcionPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New conexion()


        If Strings.Left(conexion.getIp(), 6) = "172.16" Then

            Me.cadenaConex = conexion.conexionCont
            Me.cnn = conexion.conexionContpaq2
            Me.cnn2 = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress

        Else

            Me.cadenaConex = conexion.cadenaConexFor
            Me.cnn = conexion.conexionContpaqFor2
            Me.cnn2 = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor

        End If

        filtro = 0

    End Sub


    Sub cargagrid()

        Try
            dtgvp.Columns.Remove("X")
            dtgvp.Columns.Remove("Totals")
            dtgvp.Columns.Remove("Totalx")
        Catch ex As Exception

        End Try


        Try



            cnn.Close()

            cnn.Open()

            Dim da As New SqlDataAdapter("Sp_muestrarecepcion", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@codigo", txt_no.Text)

            da.SelectCommand.Parameters.AddWithValue("@serie", cbx_serie.Text)



            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns(7).Width = 65
            dtgvp.Columns(8).Width = 300
            dtgvp.Columns(9).Width = 100
            dtgvp.Columns(10).Width = 60
            dtgvp.Columns(11).Width = 60
            dtgvp.Columns(12).Width = 60
            dtgvp.Columns(13).Width = 60
            dtgvp.Columns(30).Width = 60
            dtgvp.Columns(31).Width = 60
            dtgvp.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            dtgvp.Columns(7).ReadOnly = True
            dtgvp.Columns(8).ReadOnly = True
            dtgvp.Columns(9).ReadOnly = True
            dtgvp.Columns(10).ReadOnly = True
            dtgvp.Columns(11).ReadOnly = True
            dtgvp.Columns(30).ReadOnly = True
            'dtgvp.Columns(14).ReadOnly = True
            'dtgvp.Columns(15).ReadOnly = True
            'dtgvp.Columns(30).ReadOnly = True


            dtgvp.Columns(0).Visible = False
            dtgvp.Columns(1).Visible = False
            dtgvp.Columns(2).Visible = False
            dtgvp.Columns(3).Visible = False
            dtgvp.Columns(4).Visible = False
            dtgvp.Columns(5).Visible = False
            dtgvp.Columns(6).Visible = False
            dtgvp.Columns(12).Visible = False
            dtgvp.Columns(13).Visible = False

            dtgvp.Columns(18).Visible = False
            dtgvp.Columns(19).Visible = False
            dtgvp.Columns(20).Visible = False
            dtgvp.Columns(21).Visible = False
            dtgvp.Columns(22).Visible = False
            dtgvp.Columns(23).Visible = False
            'dtgvp.Columns(10).Visible = False
            dtgvp.Columns(24).Visible = False
            dtgvp.Columns(25).Visible = False
            dtgvp.Columns(26).Visible = False
            'dtgvp.Columns(12).Visible = False

            dtgvp.Columns(27).Visible = False
            dtgvp.Columns(28).Visible = False
            dtgvp.Columns(29).Visible = False
            dtgvp.Columns(14).Visible = False
            dtgvp.Columns(15).Visible = False
            dtgvp.Columns(16).Visible = False
            dtgvp.Columns(17).Visible = False
            dtgvp.Columns(32).Visible = False
            'dtgvp.Columns(19).Visible = False
            'dtgvp.Columns(20).Visible = False
            'dtgvp.Columns(21).Visible = False
            'dtgvp.Columns(22).Visible = False
            'dtgvp.Columns(23).Visible = False
            'dtgvp.Columns(24).Visible = False
            'dtgvp.Columns(25).Visible = False



            cnn.Close()

            dtgvp.Visible = True
            'btn_desma.Visible = True
            'btn_selec.Visible = True
            ''btn_cargar.Visible = True
            'btn_calcular.Visible = True

            Panel1.Visible = True
            Panel2.Visible = True
            Panel5.Visible = True
            txt_busca.Focus()

            If dtgvp.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")
                dtgvp.Visible = False
                lbl_po.Text = ""

                lbl_total.Text = ""
                lbl_moneda.Text = ""
                lbl_tc.Text = ""
                lbl_proveedor.Text = ""

                txt_no.Text = ""
                'btn_selec.Visible = False
                'btn_desma.Visible = False
                'btn_cargar.Visible = False
                'btn_calcular.Visible = False
                Panel1.Visible = False
                Panel2.Visible = False
                Panel5.Visible = False

            End If


            colores()
            AgregarColumna()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub

    Private Sub btn_fil2_Click(sender As Object, e As EventArgs) Handles btn_fil2.Click
        cargagrid()
    End Sub


    Private Sub txt_no_TextChanged(sender As Object, e As EventArgs) Handles txt_no.TextChanged
        If txt_no.Text = "" Then
            btn_fil2.Enabled = False
        Else
            btn_fil2.Enabled = True
        End If
    End Sub


    Sub AgregarColumna()

        Dim cbox As New DataGridViewCheckBoxColumn
        'Dim recibido As New DataGridViewTextBoxColumn
        Dim totals As New DataGridViewTextBoxColumn
        Dim totalx As New DataGridViewTextBoxColumn


        'dtgvp.Columns.Insert(dtgvp.ColumnCount, recibido)
        dtgvp.Columns.Insert(dtgvp.ColumnCount, totals)
        dtgvp.Columns.Insert(dtgvp.ColumnCount, totalx)
        dtgvp.Columns.Insert(dtgvp.ColumnCount, cbox)

        With cbox
            .HeaderText = "X"
            .Name = "X"
            .Width = 30
        End With

        'With recibido
        '    .HeaderText = "Recibido"
        '    .Name = "Recibido"
        '    .Width = 60
        '    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'End With

        With totalx
            .HeaderText = "Totalx"
            .Name = "Totalx"
            .Width = 60
            .ReadOnly = True
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = False
        End With

        With totals
            .HeaderText = "Totals"
            .Name = "Totals"
            .Width = 60
            .ReadOnly = True
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = False
        End With



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


    Private Sub Malla_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgvp.EditingControlShowing
        Dim ValidarNro As TextBox = e.Control
        RemoveHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress
        AddHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress

    End Sub



    Private Sub ValidarCantidadRequerida(Objeto As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellEndEdit, dtgvp.CellContentClick
        If e.ColumnIndex = 30 Then
            Try
                Cantidad_Requerida = CDbl(dtgvp.Rows(e.RowIndex).Cells("Recibido").Value)
                dtgvp.Rows(e.RowIndex).Cells("Totalx").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Total Unitario").Value
                dtgvp.Rows(e.RowIndex).Cells("Totals").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Subtotal Unitario").Value
                If Cantidad_Requerida > dtgvp.Rows(e.RowIndex).Cells("Cantidad PO").Value Then
                    MessageBox.Show("La cantidad que desea guardar es mayor a la que tiene pendiente por recibir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    dtgvp.Rows(e.RowIndex).Cells("Recibido").Value = dtgvp.Rows(e.RowIndex).Cells("Cantidad x recibir").Value
                    dtgvp.Rows(e.RowIndex).Cells("Totalx").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Total Unitario").Value
                    dtgvp.Rows(e.RowIndex).Cells("Totals").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Subtotal Unitario").Value
                    '   Btn_autorizar.Enabled = False
                End If
            Catch ex As Exception
                ' MessageBox.Show(ex.ToString)
                MessageBox.Show("La cantidad que introdujo no es valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtgvp.Rows(e.RowIndex).Cells("Recibido").Value = dtgvp.Rows(e.RowIndex).Cells("Cantidad x recibir").Value
                dtgvp.Rows(e.RowIndex).Cells("Totalx").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Total Unitario").Value
                dtgvp.Rows(e.RowIndex).Cells("Totals").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Subtotal Unitario").Value
                ' Btn_autorizar.Enabled = False
            End Try

        End If
        btn_cargar.Enabled = False
        colores()
    End Sub

    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = True
        Next
    End Sub


    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = False
        Next
    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click



    End Sub


    Private Sub dtgvp_CellContentClick0(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick

        Try
            lbl_po.Text = Me.dtgvp.Rows(e.RowIndex).Cells("PO").Value.ToString()
            lbl_total.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("total_po").Value.ToString(), Decimal), "#,##0.00")
            lbl_subtotalpo.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("subtotal_po").Value.ToString(), Decimal), "#,##0.00")
            lbl_moneda.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Moneda").Value.ToString()
            lbl_tc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tc").Value.ToString()
            lbl_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Proveedor").Value.ToString()
            serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie_po").Value.ToString()
            lbl_rfc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("RFC").Value.ToString()
        Catch
        End Try




        colores()

    End Sub

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        Try
            lbl_po.Text = Me.dtgvp.Rows(e.RowIndex).Cells("PO").Value.ToString()
            lbl_total.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("total_po").Value.ToString(), Decimal), "#,##0.00")
            lbl_subtotalpo.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("subtotal_po").Value.ToString(), Decimal), "#,##0.00")
            lbl_moneda.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Moneda").Value.ToString()
            lbl_tc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tc").Value.ToString()
            lbl_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Proveedor").Value.ToString()
            serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie_po").Value.ToString()
            lbl_rfc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("RFC").Value.ToString()
        Catch
        End Try

        colores()


    End Sub



    Sub totales()

        Try
            Dim Total As Double
            Dim Total1 As Double




            Dim Col As Integer = Me.dtgvp.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.dtgvp.Rows
                If row.Cells("x").Value = True Then
                    Total += Val(row.Cells("Totals").Value)
                    Total1 += Val(row.Cells("Totalx").Value)


                End If
            Next


            lbl_neto.Text = Format(CType(Total, Decimal), "#,##0.00")
            lbl_t.Text = Format(CType(Total1, Decimal), "#,##0.00")






        Catch
        End Try


    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim i As Integer

        For i = 0 To dtgvp.Rows.Count - 1



            Try
                Cantidad_Requerida = CDbl(dtgvp.Rows(i).Cells("Recibido").Value)
                dtgvp.Rows(i).Cells("Totalx").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Total Unitario").Value
                dtgvp.Rows(i).Cells("Totals").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Subtotal Unitario").Value
                If Cantidad_Requerida > dtgvp.Rows(i).Cells("Cantidad PO").Value Then
                    MessageBox.Show("La cantidad que desea guardar es mayor a la que tiene pendiente por recibir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    dtgvp.Rows(i).Cells("Recibido").Value = dtgvp.Rows(i).Cells("Cantidad x recibir").Value
                    dtgvp.Rows(i).Cells("Totalx").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Total Unitario").Value
                    dtgvp.Rows(i).Cells("Totals").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Subtotal Unitario").Value
                    '   Btn_autorizar.Enabled = False
                End If
            Catch ex As Exception
                ' MessageBox.Show(ex.ToString)
                MessageBox.Show("La cantidad que introdujo no es valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtgvp.Rows(i).Cells("Recibido").Value = dtgvp.Rows(i).Cells("Cantidad x recibir").Value
                dtgvp.Rows(i).Cells("Totalx").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Total Unitario").Value
                dtgvp.Rows(i).Cells("Totals").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Subtotal Unitario").Value
                ' Btn_autorizar.Enabled = False
            End Try



        Next

        totales()

        If lbl_t.Text = 0 Then
            MessageBox.Show("Debe palomear lo items que quiere recibir", "¡Alerta!")
            btn_cargar.Enabled = False
        Else
            btn_cargar.Visible = True
            btn_cargar.Enabled = True

        End If

    End Sub


    Sub colores()

        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells(“Estado”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.White
                ElseIf row.Cells(“Estado”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub rbt_falta_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_falta.CheckedChanged
        filtro = 0
        lbl_txtfiltro.Text = "UUID"
        txt_busca.Text = ""

    End Sub

    Private Sub rbt_retardo_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_retardo.CheckedChanged
        filtro = 1
        lbl_txtfiltro.Text = "Folio"
        txt_busca.Text = ""
    End Sub



End Class