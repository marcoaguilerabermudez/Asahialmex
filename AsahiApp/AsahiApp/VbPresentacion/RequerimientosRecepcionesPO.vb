Imports System.Data.SqlClient

Public Class RequerimientosRecepcionesPO
    Dim var_filtro As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer
    Dim id_provision As Integer
    Dim id_po As Integer
    Dim edo_po As Integer


    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String


    Private Sub RequerimientosRecepcionesPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub


    Sub cargagrid()

        Try
            'dtgvp.Columns.Remove("XML")
            dtgvp.Columns.Remove("XML")
            dtgvp.Columns.Remove("Eliminar")
            dtgvp.Columns.Remove("PDF")
        Catch ex As Exception

        End Try




        cnn = New SqlConnection("Data Source=SERV-CONTA\SQLEX2014;Initial Catalog=Asahi;Uid=sa; Pwd=Me*1can;")
        cnn.Close()
        cnn.Open()
        '   MessageBox.Show(cnn.ToString)
        Try



            Dim da As New SqlDataAdapter("Sp_muestragridmodificaRecepcionconPO", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@codigo", txt_no.Text)
            da.SelectCommand.Parameters.AddWithValue("@serie", cbx_serie.Text)
            da.SelectCommand.Parameters.AddWithValue("@coal", "")
            da.SelectCommand.Parameters.AddWithValue("@id_cotizacion", 0)
            da.SelectCommand.Parameters.AddWithValue("@var", 2)

            'MessageBox.Show(txt_no.Text)
            'MessageBox.Show(cbx_serie.Text)

            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Recepcion").Width = 70
            dtgvp.Columns("Folio").Width = 85
            dtgvp.Columns("UUID").Width = 200
            '  dtgvp.Columns("Departamento").Width = 130

            dtgvp.Columns("Fecha de recepcion").Width = 65
            dtgvp.Columns("Fecha de pago real").Width = 65
            dtgvp.Columns("Fecha de provisión").Width = 65
            dtgvp.Columns("Fecha de factura").Width = 60
            dtgvp.Columns("Fecha de pago").Width = 60
            dtgvp.Columns("Subtotal").Width = 60
            dtgvp.Columns("Total").Width = 60
            dtgvp.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dtgvp.Columns("Recepcion").ReadOnly = True
            dtgvp.Columns("Folio").ReadOnly = True
            dtgvp.Columns("UUID").ReadOnly = True
            dtgvp.Columns("Fecha de recepcion").ReadOnly = True
            dtgvp.Columns("Fecha de factura").ReadOnly = True
            dtgvp.Columns("Fecha de pago").ReadOnly = True
            dtgvp.Columns("Subtotal").ReadOnly = True
            dtgvp.Columns("Total").ReadOnly = True

            dtgvp.Columns("Proveedor").Visible = False
            dtgvp.Columns("f_total").Visible = False
            dtgvp.Columns("RFC").Visible = False
            dtgvp.Columns("Edo_prov").Visible = False
            dtgvp.Columns("f_fac").Visible = False
            dtgvp.Columns("f_sub").Visible = False
            dtgvp.Columns("id_po").Visible = False
            dtgvp.Columns("moneda").Visible = False
            dtgvp.Columns("edo_po").Visible = False

            '  cnn.Close()

            dtgvp.Visible = True
            lbl_rfc.Visible = True
            lbl_proveedor.Visible = True
            '  dtgvp.Refresh()

            If dtgvp.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")
                dtgvp.Visible = False
                lbl_rfc.Visible = False
                lbl_proveedor.Visible = False
            End If


            colores()
            'AgregarColumna()
            AgregarColumna()




            'If (depto <> 19 Or depto <> 7) Then
            '    dtgvp.Columns.Remove("X")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub


    Sub AgregarColumna()

        'Dim cbtn As New DataGridViewButtonColumn
        'dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn)
        Dim cbtn2 As New DataGridViewButtonColumn
        Dim cbtn3 As New DataGridViewButtonColumn
        Dim cbtn4 As New DataGridViewButtonColumn

        If depto = 19 Then

            dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn2)

            dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn4)
            dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn3)
            With cbtn2
                .HeaderText = "XML"
                .Name = "XML"
                .Width = 40
            End With
            With cbtn3
                .HeaderText = "Eliminar"
                .Name = "Eliminar"
                .Width = 50
            End With
            With cbtn4
                .HeaderText = "PDF"
                .Name = "PDF"
                .Width = 40
            End With

        ElseIf depto = 7 Then

            dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn2)

            dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn4)
            dtgvp.Columns.Insert(dtgvp.ColumnCount, cbtn3)
            With cbtn2
                .HeaderText = "XML"
                .Name = "XML"
                .Width = 40
            End With
            With cbtn3
                .HeaderText = "Eliminar"
                .Name = "Eliminar"
                .Width = 50
            End With
            With cbtn4
                .HeaderText = "PDF"
                .Name = "PDF"
                .Width = 40
            End With
        Else

        End If


        'With cbtn
        '    .HeaderText = "XML"
        '    .Name = "XML"
        '    .Width = 40
        'End With


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
                ElseIf row.Cells(“Edo_prov”).Value = 3 Then
                    row.DefaultCellStyle.BackColor = Color.Coral
                ElseIf row.Cells(“Edo_prov”).Value = 20 Then
                    row.DefaultCellStyle.BackColor = Color.Gold
                ElseIf row.Cells(“Edo_prov”).Value = 88 Then
                    row.DefaultCellStyle.BackColor = Color.Red
                ElseIf row.Cells(“Edo_prov”).Value = 99 Then
                    row.DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next
        Catch
        End Try

    End Sub

    Private Sub btn_fil2_Click(sender As Object, e As EventArgs) Handles btn_fil2.Click
        cargagrid()
    End Sub

    Private Sub txt_no_TextChanged(sender As Object, e As EventArgs) Handles txt_no.TextChanged
        If txt_no.Text <> "" Then
            btn_fil2.Enabled = True
        Else
            btn_fil2.Enabled = False
        End If
    End Sub


    Private Sub ValidarCantidadRequerida(Objeto As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellEndEdit, dtgvp.CellContentClick
        lbl_proveedor.Text = dtgvp.Rows(e.RowIndex).Cells("Proveedor").Value
        lbl_rfc.Text = dtgvp.Rows(e.RowIndex).Cells("RFC").Value
        id_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value
        id_po = dtgvp.Rows(e.RowIndex).Cells("id_po").Value
        edo_po = dtgvp.Rows(e.RowIndex).Cells("edo_po").Value


        If edo_po = 2 Or edo_po = 3 Then

            Try
                If e.ColumnIndex = 19 Then

                    If dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value = 1 Then

                        Modulo_vistarecepprincipal.e_rfc = lbl_rfc.Text
                        Modulo_vistarecepprincipal.e_proveedor = lbl_proveedor.Text
                        Modulo_vistarecepprincipal.e_subtotal = dtgvp.Rows(e.RowIndex).Cells("Subtotal").Value
                        Modulo_vistarecepprincipal.e_total = dtgvp.Rows(e.RowIndex).Cells("Total").Value
                        Modulo_vistarecepprincipal.e_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value

                        Modulo_vistarecepprincipal.e_ffac = dtgvp.Rows(e.RowIndex).Cells("f_fac").Value
                        Modulo_vistarecepprincipal.e_fpago = dtgvp.Rows(e.RowIndex).Cells("Fecha de pago").Value
                        Modulo_vistarecepprincipal.e_fsub = dtgvp.Rows(e.RowIndex).Cells("f_sub").Value
                        Modulo_vistarecepprincipal.e_ftotal = dtgvp.Rows(e.RowIndex).Cells("f_total").Value
                        Modulo_vistarecepprincipal.e_uuid = CStr(dtgvp.Rows(e.RowIndex).Cells("UUID").Value)
                        Modulo_vistarecepprincipal.e_folio = dtgvp.Rows(e.RowIndex).Cells("Folio").Value
                        Modulo_vistarecepprincipal.e_estadoprov = dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value
                        Modulo_vistarecepprincipal.e_moneda = dtgvp.Rows(e.RowIndex).Cells("moneda").Value

                        Dim Req_cargaxml As New Requerimientos_CargaXML(id, depto, permiso, nombre, p_vales)
                        Req_cargaxml.Show()
                        dtgvp.Visible = False
                        lbl_proveedor.Text = ""
                        lbl_rfc.Text = ""

                    ElseIf dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value = 2 Then

                        Modulo_vistarecepprincipal.e_rfc = lbl_rfc.Text
                        Modulo_vistarecepprincipal.e_proveedor = lbl_proveedor.Text
                        Modulo_vistarecepprincipal.e_subtotal = dtgvp.Rows(e.RowIndex).Cells("Subtotal").Value
                        Modulo_vistarecepprincipal.e_total = dtgvp.Rows(e.RowIndex).Cells("Total").Value
                        Modulo_vistarecepprincipal.e_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value

                        Modulo_vistarecepprincipal.e_ffac = dtgvp.Rows(e.RowIndex).Cells("f_fac").Value
                        Modulo_vistarecepprincipal.e_fpago = dtgvp.Rows(e.RowIndex).Cells("Fecha de pago").Value
                        Modulo_vistarecepprincipal.e_fsub = dtgvp.Rows(e.RowIndex).Cells("f_sub").Value
                        Modulo_vistarecepprincipal.e_ftotal = dtgvp.Rows(e.RowIndex).Cells("f_total").Value
                        Modulo_vistarecepprincipal.e_uuid = CStr(dtgvp.Rows(e.RowIndex).Cells("UUID").Value)
                        Modulo_vistarecepprincipal.e_folio = dtgvp.Rows(e.RowIndex).Cells("Folio").Value
                        Modulo_vistarecepprincipal.e_estadoprov = dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value
                        Modulo_vistarecepprincipal.e_moneda = dtgvp.Rows(e.RowIndex).Cells("moneda").Value

                        Dim Req_cargaxml As New Requerimientos_CargaXML(id, depto, permiso, nombre, p_vales)
                        Req_cargaxml.Show()
                        dtgvp.Visible = False
                        lbl_proveedor.Text = ""
                        lbl_rfc.Text = ""

                    ElseIf dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value = 0 Then

                        Modulo_vistarecepprincipal.e_rfc = lbl_rfc.Text
                        Modulo_vistarecepprincipal.e_proveedor = lbl_proveedor.Text
                        Modulo_vistarecepprincipal.e_subtotal = dtgvp.Rows(e.RowIndex).Cells("Subtotal").Value
                        Modulo_vistarecepprincipal.e_total = dtgvp.Rows(e.RowIndex).Cells("Total").Value
                        Modulo_vistarecepprincipal.e_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value

                        Modulo_vistarecepprincipal.e_ffac = Today.Date
                        Modulo_vistarecepprincipal.e_fpago = dtgvp.Rows(e.RowIndex).Cells("Fecha de pago").Value
                        Modulo_vistarecepprincipal.e_fsub = 0
                        Modulo_vistarecepprincipal.e_ftotal = 0
                        Modulo_vistarecepprincipal.e_uuid = ""
                        Modulo_vistarecepprincipal.e_folio = ""
                        Modulo_vistarecepprincipal.e_estadoprov = dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value
                        Modulo_vistarecepprincipal.e_moneda = dtgvp.Rows(e.RowIndex).Cells("moneda").Value

                        Dim Req_cargaxml As New Requerimientos_CargaXML(id, depto, permiso, nombre, p_vales)
                        Req_cargaxml.Show()

                    Else

                    End If

                ElseIf e.ColumnIndex = 21 Then

                    If dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value <> 88 Then
                        var_filtro = 0
                        MessageBox.Show("No puede eliminar la recepción porque la PO ya está cerrada o cancelada", "¡Aviso!")

                    Else

                    End If






                End If

            Catch EX As Exception
                MessageBox.Show(EX.ToString)
            End Try

        Else

            Try
                If e.ColumnIndex = 19 Then

                    If dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value = 1 Then

                        Modulo_vistarecepprincipal.e_rfc = lbl_rfc.Text
                        Modulo_vistarecepprincipal.e_proveedor = lbl_proveedor.Text
                        Modulo_vistarecepprincipal.e_subtotal = dtgvp.Rows(e.RowIndex).Cells("Subtotal").Value
                        Modulo_vistarecepprincipal.e_total = dtgvp.Rows(e.RowIndex).Cells("Total").Value
                        Modulo_vistarecepprincipal.e_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value

                        Modulo_vistarecepprincipal.e_ffac = dtgvp.Rows(e.RowIndex).Cells("f_fac").Value
                        Modulo_vistarecepprincipal.e_fpago = dtgvp.Rows(e.RowIndex).Cells("Fecha de pago").Value
                        Modulo_vistarecepprincipal.e_fsub = dtgvp.Rows(e.RowIndex).Cells("f_sub").Value
                        Modulo_vistarecepprincipal.e_ftotal = dtgvp.Rows(e.RowIndex).Cells("f_total").Value
                        Modulo_vistarecepprincipal.e_uuid = CStr(dtgvp.Rows(e.RowIndex).Cells("UUID").Value)
                        Modulo_vistarecepprincipal.e_folio = dtgvp.Rows(e.RowIndex).Cells("Folio").Value
                        Modulo_vistarecepprincipal.e_estadoprov = dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value
                        Modulo_vistarecepprincipal.e_moneda = dtgvp.Rows(e.RowIndex).Cells("moneda").Value

                        Dim Req_cargaxml As New Requerimientos_CargaXML(id, depto, permiso, nombre, p_vales)
                        Req_cargaxml.Show()
                        dtgvp.Visible = False
                        lbl_proveedor.Text = ""
                        lbl_rfc.Text = ""

                    ElseIf dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value = 2 Then

                        Modulo_vistarecepprincipal.e_rfc = lbl_rfc.Text
                        Modulo_vistarecepprincipal.e_proveedor = lbl_proveedor.Text
                        Modulo_vistarecepprincipal.e_subtotal = dtgvp.Rows(e.RowIndex).Cells("Subtotal").Value
                        Modulo_vistarecepprincipal.e_total = dtgvp.Rows(e.RowIndex).Cells("Total").Value
                        Modulo_vistarecepprincipal.e_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value

                        Modulo_vistarecepprincipal.e_ffac = dtgvp.Rows(e.RowIndex).Cells("f_fac").Value
                        Modulo_vistarecepprincipal.e_fpago = dtgvp.Rows(e.RowIndex).Cells("Fecha de pago").Value
                        Modulo_vistarecepprincipal.e_fsub = dtgvp.Rows(e.RowIndex).Cells("f_sub").Value
                        Modulo_vistarecepprincipal.e_ftotal = dtgvp.Rows(e.RowIndex).Cells("f_total").Value
                        Modulo_vistarecepprincipal.e_uuid = CStr(dtgvp.Rows(e.RowIndex).Cells("UUID").Value)
                        Modulo_vistarecepprincipal.e_folio = dtgvp.Rows(e.RowIndex).Cells("Folio").Value
                        Modulo_vistarecepprincipal.e_estadoprov = dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value
                        Modulo_vistarecepprincipal.e_moneda = dtgvp.Rows(e.RowIndex).Cells("moneda").Value

                        Dim Req_cargaxml As New Requerimientos_CargaXML(id, depto, permiso, nombre, p_vales)
                        Req_cargaxml.Show()
                        dtgvp.Visible = False
                        lbl_proveedor.Text = ""
                        lbl_rfc.Text = ""

                    ElseIf dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value = 0 Then

                        Modulo_vistarecepprincipal.e_rfc = lbl_rfc.Text
                        Modulo_vistarecepprincipal.e_proveedor = lbl_proveedor.Text
                        Modulo_vistarecepprincipal.e_subtotal = dtgvp.Rows(e.RowIndex).Cells("Subtotal").Value
                        Modulo_vistarecepprincipal.e_total = dtgvp.Rows(e.RowIndex).Cells("Total").Value
                        Modulo_vistarecepprincipal.e_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value

                        Modulo_vistarecepprincipal.e_ffac = Today.Date
                        Modulo_vistarecepprincipal.e_fpago = dtgvp.Rows(e.RowIndex).Cells("Fecha de pago").Value
                        Modulo_vistarecepprincipal.e_fsub = 0
                        Modulo_vistarecepprincipal.e_ftotal = 0
                        Modulo_vistarecepprincipal.e_uuid = ""
                        Modulo_vistarecepprincipal.e_folio = ""
                        Modulo_vistarecepprincipal.e_estadoprov = dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value
                        Modulo_vistarecepprincipal.e_moneda = dtgvp.Rows(e.RowIndex).Cells("moneda").Value

                        Dim Req_cargaxml As New Requerimientos_CargaXML(id, depto, permiso, nombre, p_vales)
                        Req_cargaxml.Show()

                    Else

                    End If

                ElseIf e.ColumnIndex = 21 Then
                    var_filtro = 0

                    If dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value <> (88) And dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value <> (99) Then

                        Dim Pregunta As Integer

                        Pregunta = MsgBox("¿Desea eliminar la recepción: " & id_provision & " ? Recuerde que este proceso implica movimientos en inventarios", vbYesNo + vbExclamation + vbDefaultButton2, "")

                        If Pregunta = vbYes Then

                            EliminaProvision()
                        Else
                            MessageBox.Show("Acción no completada", "¡Aviso!")
                        End If

                    ElseIf dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value = (99) Then


                        Dim Pregunta As Integer

                        Pregunta = MsgBox("¿Desea eliminar la recepción: " & id_provision & " ? Al ser un pago contra factura, no genera movimientos en inventario", vbYesNo + vbExclamation + vbDefaultButton2, "")

                        If Pregunta = vbYes Then
                            var_filtro = 2
                            EliminaProvision()
                        Else
                            MessageBox.Show("Acción no completada", "¡Aviso!")
                        End If
                    End If


                ElseIf e.ColumnIndex = 20 Then
                    MessageBox.Show("PDF")

                End If

            Catch EX As Exception
                MessageBox.Show(EX.ToString)
            End Try

        End If

        If e.ColumnIndex = 20 Then
            var_filtro = 1
            MessageBox.Show("PDF")

        End If

    End Sub


    Private Sub ValidarCantidadRequerida2(Objeto As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter

        lbl_proveedor.Text = dtgvp.Rows(e.RowIndex).Cells("Proveedor").Value
        lbl_rfc.Text = dtgvp.Rows(e.RowIndex).Cells("RFC").Value
        id_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value
        id_po = dtgvp.Rows(e.RowIndex).Cells("id_po").Value


    End Sub



    Private Sub ValidarCantidadRequerida3(Objeto As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick

        Modulo_vistarecepprincipal.e_estadoprov = dtgvp.Rows(e.RowIndex).Cells("Edo_prov").Value
        Modulo_vistarecepprincipal.e_moneda = dtgvp.Rows(e.RowIndex).Cells("moneda").Value
        Try
            Modulo_vistarecepprincipal.e_rfc = lbl_rfc.Text
            Modulo_vistarecepprincipal.e_proveedor = lbl_proveedor.Text
            Modulo_vistarecepprincipal.e_subtotal = dtgvp.Rows(e.RowIndex).Cells("Subtotal").Value
            Modulo_vistarecepprincipal.e_total = dtgvp.Rows(e.RowIndex).Cells("Total").Value
            Modulo_vistarecepprincipal.e_provision = dtgvp.Rows(e.RowIndex).Cells("Recepcion").Value

            Modulo_vistarecepprincipal.e_ffac = dtgvp.Rows(e.RowIndex).Cells("f_fac").Value
            Modulo_vistarecepprincipal.e_fpago = dtgvp.Rows(e.RowIndex).Cells("Fecha de pago").Value
            Modulo_vistarecepprincipal.e_fsub = dtgvp.Rows(e.RowIndex).Cells("f_sub").Value
            Modulo_vistarecepprincipal.e_ftotal = dtgvp.Rows(e.RowIndex).Cells("f_total").Value
            Modulo_vistarecepprincipal.e_uuid = CStr(dtgvp.Rows(e.RowIndex).Cells("UUID").Value)
            Modulo_vistarecepprincipal.e_folio = dtgvp.Rows(e.RowIndex).Cells("Folio").Value
            Modulo_vistarecepprincipal.e_folio = dtgvp.Rows(e.RowIndex).Cells("tc").Value


        Catch
        End Try

        Requerimientos_MuestraMovimientoProvisionPO.Show()

    End Sub

    Sub EliminaProvision()
        cnn.Close()
        '  cnn.Open()

        Dim agrega As New SqlCommand("Sp_EliminaProvision", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        agrega.CommandType = CommandType.StoredProcedure


        Try

            agrega.Parameters.Clear()
            agrega.Parameters.Add("@id_provision", SqlDbType.Int).Value = id_provision
            agrega.Parameters.Add("@id_po", SqlDbType.Int).Value = id_po
            agrega.Parameters.Add("@var", SqlDbType.Int).Value = var_filtro
            agrega.Parameters.Add("@pdf", SqlDbType.VarChar, 400).Value = id_po
            agrega.ExecuteNonQuery()

            cnn.Close()

            MessageBox.Show("Acción completada correctamente", "¡Aviso!")

            cargagrid()

        Catch ex As Exception

            MessageBox.Show("Error, consulte al administrador")

            MessageBox.Show(ex.ToString)

            cnn.Close()

            'cargagrid()
        Finally
            cnn.Close()
        End Try

        'Dim Req_RecPO As New RequerimientosRecepcionesPO(id, depto, permiso, nombre, p_vales)

        'Req_RecPO.cargagrid()
        '  Req_RecPO.cargagrid()
    End Sub




End Class