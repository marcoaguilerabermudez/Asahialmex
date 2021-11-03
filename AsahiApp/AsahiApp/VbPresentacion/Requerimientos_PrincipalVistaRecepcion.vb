Imports System.Data.SqlClient

Public Class Requerimientos_PrincipalVistaRecepcion
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
    Dim PO As Integer
    Dim Serie As String




    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Requerimientos_PrincipalVistaRecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        PO = Modulo_vistarecepprincipal.e_codigo
        Serie = Modulo_vistarecepprincipal.e_serie
        lbl_po.Text = Modulo_vistarecepprincipal.e_po
        lbl_proveedor.Text = Modulo_vistarecepprincipal.e_proveedor

        ' lbl_po.Text = PO + "-" + Serie

        cargagrid()
    End Sub

    Sub colores()

        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells(“Edo_prov”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                ElseIf row.Cells(“Edo_prov”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.Pink
                ElseIf row.Cells(“Edo_prov”).Value = 2 Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf row.Cells(“Edo_prov”).Value = 20 Then
                    row.DefaultCellStyle.BackColor = Color.Gold
                End If
            Next
        Catch
        End Try

    End Sub

    Sub cargagrid()

        Try
            'dtgvp.Columns.Remove("XML")
            dtgvp.Columns.Remove("X")

        Catch ex As Exception

        End Try


        Try



            cnn.Close()

            cnn.Open()

            Dim da As New SqlDataAdapter("Sp_muestragridmodificaRecepcionconPO", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@codigo", PO)
            da.SelectCommand.Parameters.AddWithValue("@serie", Serie)
            da.SelectCommand.Parameters.AddWithValue("@coal", "")
            da.SelectCommand.Parameters.AddWithValue("@id_cotizacion", 0)
            da.SelectCommand.Parameters.AddWithValue("@var", 1)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Codigo").Width = 65
            dtgvp.Columns("Nombre").Width = 300
            dtgvp.Columns("No parte").Width = 100
            dtgvp.Columns("Departamento").Width = 130

            dtgvp.Columns("Cantidad PO").Width = 60
            dtgvp.Columns("Cantidad recibida").Width = 60
            dtgvp.Columns("Precio").Width = 60
            dtgvp.Columns("Nueva Cantidad").Width = 60
            dtgvp.Columns("Fecha recepcion").Width = 60
            dtgvp.Columns("Tipo").Width = 60
            dtgvp.Columns("Folio").Width = 85
            dtgvp.Columns("Modificado").Width = 40
            dtgvp.Columns("Cancelado").Width = 40
            dtgvp.Columns("Provision").Width = 60
            'dtgvp.Columns(13).Width = 60
            'dtgvp.Columns(30).Width = 60
            'dtgvp.Columns(31).Width = 60
            'dtgvp.Columns(32).Width = 60
            'dtgvp.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns("Cantidad PO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns("Cantidad recibida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns("Nueva Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dtgvp.Columns("Codigo").ReadOnly = True
            dtgvp.Columns("Nombre").ReadOnly = True
            dtgvp.Columns("No parte").ReadOnly = True
            dtgvp.Columns("Provision").ReadOnly = True
            dtgvp.Columns("Cantidad PO").ReadOnly = True
            dtgvp.Columns("Cantidad recibida").ReadOnly = True
            '  dtgvp.Columns("Nueva Cantidad").ReadOnly = True
            dtgvp.Columns("Tipo").ReadOnly = True
            dtgvp.Columns("Folio").ReadOnly = True
            dtgvp.Columns("Precio").ReadOnly = True
            'dtgvp.Columns(14).ReadOnly = True
            'dtgvp.Columns(15).ReadOnly = True
            'dtgvp.Columns(30).ReadOnly = True


            dtgvp.Columns("id_reqprin").Visible = False
            dtgvp.Columns("id_po").Visible = False
            dtgvp.Columns("id_reqmov").Visible = False
            'dtgvp.Columns("id_prov").Visible = False
            dtgvp.Columns("id_cotizacion").Visible = False
            dtgvp.Columns("id_pomov").Visible = False
            dtgvp.Columns("id_provmov").Visible = False
            dtgvp.Columns("id_movalamacen").Visible = False
            dtgvp.Columns("t").Visible = False
            dtgvp.Columns("uuid").Visible = False


            dtgvp.Columns("Cancelado").Visible = False
            dtgvp.Columns("Modificado").Visible = False
            dtgvp.Columns("Tipo").Visible = False
            dtgvp.Columns("Fecha recepcion").Visible = False
            dtgvp.Columns("CantidadrecibidaPO").Visible = False
            dtgvp.Columns("Departamento").Visible = False
            dtgvp.Columns("Edo_prov").Visible = False
            dtgvp.Columns("CantidadfacturadaPO").Visible = False
            dtgvp.Columns("CantidadPendientePO").Visible = False


            cnn.Close()

            dtgvp.Visible = True
            'btn_desma.Visible = True
            'btn_selec.Visible = True
            ''btn_cargar.Visible = True
            'btn_calcular.Visible = True

            'Panel1.Visible = True
            'Panel2.Visible = True
            Panel5.Visible = True
            'predictivo()
            'txt_busca.Focus()

            If dtgvp.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")
                dtgvp.Visible = False
                lbl_po.Text = ""


                lbl_proveedor.Text = ""

                'txt_no.Text = ""
                'btn_selec.Visible = False
                'btn_desma.Visible = False
                'btn_cargar.Visible = False
                'btn_calcular.Visible = False
                'Panel1.Visible = False
                'Panel2.Visible = False
                Panel5.Visible = False

            End If


            colores()
            'AgregarColumna()
            AgregarColumna()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub


    Sub AgregarColumna()

        'Dim cbtn As New DataGridViewButtonColumn
        'dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn)
        Dim cbtn2 As New DataGridViewButtonColumn
        dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn2)


        'With cbtn
        '    .HeaderText = "XML"
        '    .Name = "XML"
        '    .Width = 40
        'End With

        With cbtn2
            .HeaderText = "X"
            .Name = "X"
            .Width = 40
        End With
    End Sub


    Private Sub dtgvp_CellContentClick0(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick

        Try
            lbl_factura.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Folio").Value.ToString()
            lbl_uuid.Text = Me.dtgvp.Rows(e.RowIndex).Cells("uuid").Value.ToString()
            lbl_fecharecep.value = Me.dtgvp.Rows(e.RowIndex).Cells("Fecha recepcion").Value.ToString()
            lbl_depto.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Departamento").Value.ToString()
            lbl_cancelado.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Cancelado").Value.ToString()
            lbl_modificado.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Modificado").Value.ToString()
            lbl_tipo.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Tipo").Value.ToString()
        Catch
        End Try




        colores()

    End Sub

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        Try
            lbl_factura.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Folio").Value.ToString()
            lbl_uuid.Text = Me.dtgvp.Rows(e.RowIndex).Cells("uuid").Value.ToString()
            lbl_fecharecep.Value = Me.dtgvp.Rows(e.RowIndex).Cells("Fecha recepcion").Value.ToString()
            lbl_depto.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Departamento").Value.ToString()
            lbl_cancelado.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Cancelado").Value.ToString()
            lbl_modificado.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Modificado").Value.ToString()
            lbl_tipo.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Tipo").Value.ToString()
        Catch
        End Try

        colores()


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


End Class