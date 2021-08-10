Imports System.Data.SqlClient

Public Class ValidarVale

    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer
    Dim Cantidad_Requerida As Double

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection



    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub ValidarVale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_folio.Focus()

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

    End Sub


    Sub muestravale()


        cnn.Close()

        cnn.Open()

        Try

            Dim da As New SqlDataAdapter("Sp_MuestraValidaVale", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@folio", txt_folio.Text)





            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Medida").Visible = False
            dtgvp.Columns("Fecha_solicita").Visible = False
            dtgvp.Columns("Id_vale").Visible = False
            dtgvp.Columns("Folio").Visible = False
            dtgvp.Columns("Codigo").Visible = False

            dtgvp.Columns("Producto").ReadOnly = True
            dtgvp.Columns("Cantidad").ReadOnly = True
            dtgvp.Columns("Precio").ReadOnly = True
            dtgvp.Columns("Total").ReadOnly = True

            cnn.Close()

            If dtgvp.RowCount > 0 Then

                Btn_autorizar.Enabled = True
                dtgvp.Visible = True
            Else
                Btn_autorizar.Enabled = False
                MessageBox.Show("El vale " & txt_folio.Text & " no existe o ya ha sido validado, revise su información.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtgvp.Visible = False
                txt_folio.Clear()

            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("Revise que el código de vale sea correcto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Btn_autorizar.Enabled = False
            dtgvp.Visible = False
            txt_folio.Clear()
        End Try
    End Sub

    Private Sub txt_folio_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_folio.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            muestravale()


        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_folio.Clear()

            Btn_autorizar.Enabled = False
            dtgvp.Visible = False

        End If
    End Sub


    Private Sub ValidarCantidadRequerida(Objeto As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellEndEdit
        If e.ColumnIndex = 4 Then
            Try
                Cantidad_Requerida = CDbl(dtgvp.Rows(e.RowIndex).Cells("Surtido").Value)
                dtgvp.Rows(e.RowIndex).Cells("Total").Value = dtgvp.Rows(e.RowIndex).Cells("Surtido").Value * dtgvp.Rows(e.RowIndex).Cells("Precio").Value
                If Cantidad_Requerida > dtgvp.Rows(e.RowIndex).Cells("Cantidad").Value Then
                    MessageBox.Show("La cantidad que desea modificar es mayor a la del vale.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    dtgvp.Rows(e.RowIndex).Cells("Surtido").Value = dtgvp.Rows(e.RowIndex).Cells("Cantidad").Value
                    dtgvp.Rows(e.RowIndex).Cells("Total").Value = dtgvp.Rows(e.RowIndex).Cells("Cantidad").Value * dtgvp.Rows(e.RowIndex).Cells("Precio").Value
                    Btn_autorizar.Enabled = False
                End If
            Catch ex As Exception
                ' MessageBox.Show(ex.ToString)
                MessageBox.Show("La cantidad que introdujo no es valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtgvp.Rows(e.RowIndex).Cells("Surtido").Value = dtgvp.Rows(e.RowIndex).Cells("Cantidad").Value
                dtgvp.Rows(e.RowIndex).Cells("Total").Value = dtgvp.Rows(e.RowIndex).Cells("Cantidad").Value * dtgvp.Rows(e.RowIndex).Cells("Precio").Value
                Btn_autorizar.Enabled = False
            End Try

        End If
    End Sub


    Sub ValidaRegistroVale()
        cnn.Close()
        cnn.Open()
        Dim agrega As SqlCommand = New SqlCommand("  

update [Asahi].[dbo].[Vales_Almacen] set P_entrega = @entrega , Fecha_surtido = getdate(), Surtido = 1
where Folio_vale = @folio
", cnn)


        Try

            agrega.Parameters.Clear()


            agrega.Parameters.Add("@folio", SqlDbType.Int).Value = txt_folio.Text
            agrega.Parameters.Add("@entrega", SqlDbType.Int).Value = id

            agrega.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error al validar el vale, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()

            'cargagrid()
        Finally
            cnn.Close()
        End Try

    End Sub


    Sub ValidaMovimientos()


        cnn.Close()


        Dim command As New SqlCommand("Sp_ValidarVales", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try

            For Each fila In dtgvp.Rows


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@folio", txt_folio.Text)
                command.Parameters.AddWithValue("@surtido", (fila.Cells("Surtido").Value))
                command.Parameters.AddWithValue("@cantidad", (fila.Cells("Cantidad").Value))
                command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))


                command.ExecuteNonQuery()

            Next


            MessageBox.Show("El registro(s) ha(n) sido validado(s) correctamente", "Advertencia", MessageBoxButtons.OK)
            txt_folio.Clear()

            dtgvp.Visible = False

            Btn_autorizar.Enabled = False


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
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


    Private Sub Malla_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgvp.EditingControlShowing
        Dim ValidarNro As TextBox = e.Control
        RemoveHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress
        AddHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress

    End Sub

    Private Sub Btn_autorizar_Click(sender As Object, e As EventArgs) Handles Btn_autorizar.Click
        ValidaRegistroVale()
        ValidaMovimientos()
    End Sub
End Class