Imports System.Data.SqlClient

Public Class Provisiones
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
    Dim bs = New BindingSource

    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable



    Dim Cantidad_Requerida As Double
    Dim filtro As Integer
    Dim y As Integer
    Dim id_po As Integer


    Private Sub Provisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        var_filtro = 0
        cargagridconta()
        dtpf.Value = DateAdd(DateInterval.Day, -10, Today.Date)
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





        cnn.Close()
        cnn.Open()
        '   MessageBox.Show(cnn.ToString)
        Try



            Dim da As New SqlDataAdapter("Sp_MuestraProvisiones", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@desde", dtpf.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@hasta", dtpf2.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@var", var_filtro)

            'MessageBox.Show(txt_no.Text)
            'MessageBox.Show(cbx_serie.Text)

            dt.Clear()
            da.Fill(dt)
            dtgv.DataSource = dt
            '  dtgv.DataMember = bs

            dtgv.Columns("Id_prov").Visible = False
            dtgv.Columns("id_po").Visible = False
            dtgv.Columns("Codigo").Visible = False
            dtgv.Columns("Serie").Visible = False
            dtgv.Columns("UUID").Visible = False
            dtgv.Columns("ObservaConta").Visible = False
            dtgv.Columns("Ruta").Visible = False
            dtgv.Columns("Edo_prov").Visible = False
            dtgv.Columns("edo_po").Visible = False
            dtgv.Columns("Fecha_Pago_Real").Visible = False
            'dtgv.Columns("FechaPagoReal").Visible = False
            'dtgv.Columns("o").Visible = False
            'dtgv.Columns("serie").Visible = False
            dtgv.Columns("PO").Width = 65

            dtgv.Columns("Folio_factura").Width = 80
            dtgv.Columns("Proveedor").Width = 150
            dtgv.Columns("Moneda").Width = 60

            dtgv.Columns("Moneda").ReadOnly = True
            dtgv.Columns("PO").ReadOnly = True
            dtgv.Columns("Folio_factura").ReadOnly = True
            dtgv.Columns("Proveedor").ReadOnly = True
            dtgv.Columns("RFC").ReadOnly = True
            dtgv.Columns("Monto_PO").ReadOnly = True
            dtgv.Columns("Monto_Factura").ReadOnly = True
            dtgv.Columns("Fecha_Factura").ReadOnly = True
            dtgv.Columns("Nombre_Emisor").ReadOnly = True
            dtgv.Columns("RFC_Emisor").ReadOnly = True
            dtgv.Columns("frecepcion").ReadOnly = True

            If dtgv.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")

            End If


            colores()




            'If (depto <> 19 Or depto <> 7) Then
            '    dtgvp.Columns.Remove("X")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub


    Sub cargagridvalidado()


        cnn.Close()
        cnn.Open()
        '   MessageBox.Show(cnn.ToString)




        Try



            Dim da As New SqlDataAdapter("Sp_MuestraProvisiones", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@desde", dtp1.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@hasta", dtp2.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@var", 2)

            'MessageBox.Show(txt_no.Text)
            'MessageBox.Show(cbx_serie.Text)

            dt2.Clear()
            da.Fill(dt2)
            dgv2.DataSource = dt2

            dgv2.Columns("Id_provcompra").Visible = False
            dgv2.Columns("Id_provision").Visible = False
            dgv2.Columns("id_po").Visible = False
            dgv2.Columns("Codigo").Visible = False
            dgv2.Columns("Serie").Visible = False

            'dtgv3.Columns("ObservaConta").Visible = False

            dgv2.Columns("Ruta").Visible = False
            dgv2.Columns("UUID").Visible = False
            dgv2.Columns("EstatusConta").Visible = False
            dgv2.Columns("Estatus_Conta").Visible = False

            dgv2.Columns("PO").Width = 65

            dgv2.Columns("Factura").Width = 80
            dgv2.Columns("Proveedor").Width = 150
            dgv2.Columns("Moneda").Width = 60

            dgv2.Columns("FechaVal").ReadOnly = True
            dgv2.Columns("PO").ReadOnly = True
            dgv2.Columns("Factura").ReadOnly = True
            dgv2.Columns("Proveedor").ReadOnly = True
            dgv2.Columns("MontoFact").ReadOnly = True

            dgv2.Columns("FechaFactura").ReadOnly = True
            dgv2.Columns("FechaPagoReal").ReadOnly = True
            dgv2.Columns("MontoOc").ReadOnly = True
            dgv2.Columns("Moneda").ReadOnly = True
            dgv2.Columns("EstatusPago").ReadOnly = True
            dgv2.Columns("EstatusConta").ReadOnly = True
            dgv2.Columns("RFC").ReadOnly = True
            dgv2.Columns("RFCEmisor").ReadOnly = True
            dgv2.Columns("NombreEmisor").ReadOnly = True



            colores()




            'If (depto <> 19 Or depto <> 7) Then
            '    dtgvp.Columns.Remove("X")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub


    Sub cargagridvalidadoxPago()


        cnn.Close()
        cnn.Open()
        '   MessageBox.Show(cnn.ToString)




        Try



            Dim da As New SqlDataAdapter("Sp_MuestraProvisiones", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@desde", dtpb.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@hasta", dtp2.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@var", 4)

            'MessageBox.Show(txt_no.Text)
            'MessageBox.Show(cbx_serie.Text)

            dt2.Clear()
            da.Fill(dt2)
            dgv2.DataSource = dt2

            dgv2.Columns("Id_provcompra").Visible = False
            dgv2.Columns("Id_provision").Visible = False
            dgv2.Columns("id_po").Visible = False
            dgv2.Columns("Codigo").Visible = False
            dgv2.Columns("Serie").Visible = False

            'dtgv3.Columns("ObservaConta").Visible = False
            dgv2.Columns("Ruta").Visible = False
            dgv2.Columns("UUID").Visible = False
            dgv2.Columns("EstatusConta").Visible = False
            dgv2.Columns("Estatus_Conta").Visible = False

            dgv2.Columns("PO").Width = 65

            dgv2.Columns("Factura").Width = 80
            dgv2.Columns("Proveedor").Width = 150
            dgv2.Columns("Moneda").Width = 60

            dgv2.Columns("FechaVal").ReadOnly = True
            dgv2.Columns("PO").ReadOnly = True
            dgv2.Columns("Factura").ReadOnly = True
            dgv2.Columns("Proveedor").ReadOnly = True
            dgv2.Columns("MontoFact").ReadOnly = True

            dgv2.Columns("FechaFactura").ReadOnly = True
            dgv2.Columns("FechaPagoReal").ReadOnly = True
            dgv2.Columns("MontoOc").ReadOnly = True
            dgv2.Columns("Moneda").ReadOnly = True
            dgv2.Columns("EstatusPago").ReadOnly = True
            dgv2.Columns("EstatusConta").ReadOnly = True
            dgv2.Columns("RFC").ReadOnly = True
            dgv2.Columns("RFCEmisor").ReadOnly = True
            dgv2.Columns("NombreEmisor").ReadOnly = True



            colores()




            'If (depto <> 19 Or depto <> 7) Then
            '    dtgvp.Columns.Remove("X")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub



    Sub cargagridconta()


        cnn.Close()
        cnn.Open()
        '   MessageBox.Show(cnn.ToString)
        Try



            Dim da As New SqlDataAdapter("Sp_MuestraProvisiones", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@desde", dtpf.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@hasta", dtpf2.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@var", 3)

            'MessageBox.Show(txt_no.Text)
            'MessageBox.Show(cbx_serie.Text)

            dt3.Clear()
            da.Fill(dt3)
            dtgv3.DataSource = dt3

            dtgv3.Columns("Id_provcompra").Visible = False
            dtgv3.Columns("Id_provision").Visible = False
            dtgv3.Columns("id_po").Visible = False
            dtgv3.Columns("Codigo").Visible = False
            dtgv3.Columns("Serie").Visible = False

            'dtgv3.Columns("ObservaConta").Visible = False
            dtgv3.Columns("Ruta").Visible = False
            dtgv3.Columns("UUID").Visible = False
            dtgv3.Columns("Estatus_Conta").Visible = False
            'dtgv3.Columns("edo_po").Visible = False
            'dtgv3.Columns("Fecha_Pago_Real").Visible = False
            'dtgv.Columns("FechaPagoReal").Visible = False
            'dtgv.Columns("o").Visible = False
            'dtgv.Columns("serie").Visible = False
            dtgv3.Columns("PO").Width = 65

            dtgv3.Columns("Factura").Width = 80
            dtgv3.Columns("Proveedor").Width = 150
            dtgv3.Columns("Moneda").Width = 60

            dtgv3.Columns("FechaVal").ReadOnly = True
            dtgv3.Columns("PO").ReadOnly = True
            dtgv3.Columns("Factura").ReadOnly = True
            dtgv3.Columns("Proveedor").ReadOnly = True
            dtgv3.Columns("MontoFact").ReadOnly = True
            dtgv3.Columns("MontoPago").ReadOnly = True
            dtgv3.Columns("FechaFactura").ReadOnly = True
            dtgv3.Columns("FechaPagoFact").ReadOnly = True


            dtgv3.Columns("ObservaCompra").ReadOnly = True
            dtgv3.Columns("Moneda").ReadOnly = True
            dtgv3.Columns("Estatus").ReadOnly = True









            'If (depto <> 19 Or depto <> 7) Then
            '    dtgvp.Columns.Remove("X")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub


    Sub colores()

        Try
            For Each row As DataGridViewRow In Me.dtgv.Rows

                If row.Cells(“Edo_prov”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                ElseIf row.Cells(“Edo_prov”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.Pink
                ElseIf row.Cells(“Edo_prov”).Value = 2 Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
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


        Try
            For Each row As DataGridViewRow In Me.dgv2.Rows

                If row.Cells(“EstatusConta”).Value = "A" Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                ElseIf row.Cells(“EstatusConta”).Value = "R" Then
                    row.DefaultCellStyle.BackColor = Color.LightPink
                ElseIf row.Cells(“EstatusConta”).Value = "M" Then
                    row.DefaultCellStyle.BackColor = Color.Gold
                Else
                    row.DefaultCellStyle.BackColor = Color.White
                End If
            Next
        Catch
        End Try


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        cargagrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cargagridvalidado()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        cargagridvalidadoxPago()
    End Sub

    Private Sub rbt_retardo_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_ffac.CheckedChanged
        var_filtro = 1
    End Sub

    Private Sub rbt_falta_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_frecep.CheckedChanged
        var_filtro = 0
    End Sub


    Sub insertarfilas()


        cnn.Close()


        Dim command As New SqlCommand("Sp_ValidaModificaAutorizaProvisiones", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Try

            For Each fila In dtgv.Rows
                If fila.Cells("x").Value = True And fila.Cells("Edo_prov").Value > 0 Then

                    command.Parameters.Clear()

                    command.Parameters.AddWithValue("@var", 0)
                    command.Parameters.AddWithValue("@id_prov", (fila.Cells("Id_prov").Value))
                    command.Parameters.AddWithValue("@id_po", (fila.Cells("id_po").Value))
                    command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))
                    command.Parameters.AddWithValue("@serie", (fila.Cells("Serie").Value))
                    command.Parameters.AddWithValue("@folio_factura", (fila.Cells("Folio_factura").Value))
                    command.Parameters.AddWithValue("@uuid", (fila.Cells("UUID").Value))
                    command.Parameters.AddWithValue("@proveedor", (fila.Cells("Proveedor").Value))
                    command.Parameters.AddWithValue("@rfc", (fila.Cells("RFC").Value))
                    command.Parameters.AddWithValue("@monto_po", (fila.Cells("Monto_PO").Value))
                    command.Parameters.AddWithValue("@monto_fact", (fila.Cells("Monto_Factura").Value))
                    command.Parameters.AddWithValue("@monto_pago", (fila.Cells("Monto_Pago").Value))
                    command.Parameters.AddWithValue("@fecha_factura", (fila.Cells("Fecha_Factura").Value))
                    command.Parameters.AddWithValue("@fecha_pago", (fila.Cells("Fecha_Pago").Value))
                    command.Parameters.AddWithValue("@nombre_emisor", (fila.Cells("Nombre_Emisor").Value))
                    command.Parameters.AddWithValue("@rfc_emisor", (fila.Cells("RFC_Emisor").Value))
                    command.Parameters.AddWithValue("@estatus", (fila.Cells("Estatus").Value))
                    command.Parameters.AddWithValue("@ruta", (fila.Cells("Ruta").Value))
                    command.Parameters.AddWithValue("@observacompra", (fila.Cells("ObservaCompra").Value))
                    command.Parameters.AddWithValue("@usuariocompras", id)

                    command.Parameters.AddWithValue("@estatuspago", "")
                    command.Parameters.AddWithValue("@observaconta", "")
                    command.Parameters.AddWithValue("@id_provcompra", 0)

                    command.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Registro(s) validado(s)", "¡Correcto!", MessageBoxButtons.OK)
            cargagrid()


            'btn_selec.Visible = False
            'btn_desma.Visible = False
            'btn_cargar.Visible = False
            ''btn_calcular.Visible = False
            'Panel1.Visible = False
            'Panel2.Visible = False
            'Panel5.Visible = False



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try

    End Sub

    Sub ValidaConta()


        cnn.Close()


        Dim command As New SqlCommand("Sp_ValidaModificaAutorizaProvisiones", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Try

            For Each fila In dtgv3.Rows
                If fila.Cells(0).Value = True Then

                    command.Parameters.Clear()

                    command.Parameters.AddWithValue("@var", 3)
                    command.Parameters.AddWithValue("@id_prov", (fila.Cells("Id_provision").Value))
                    command.Parameters.AddWithValue("@id_po", (fila.Cells("Id_po").Value))
                    command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))
                    command.Parameters.AddWithValue("@serie", (fila.Cells("Serie").Value))
                    command.Parameters.AddWithValue("@folio_factura", (fila.Cells("Factura").Value))
                    command.Parameters.AddWithValue("@uuid", (fila.Cells("UUID").Value))
                    command.Parameters.AddWithValue("@proveedor", (fila.Cells("Proveedor").Value))
                    command.Parameters.AddWithValue("@rfc", "")
                    command.Parameters.AddWithValue("@monto_po", 0)
                    command.Parameters.AddWithValue("@monto_fact", 0)
                    command.Parameters.AddWithValue("@monto_pago", 0)
                    command.Parameters.AddWithValue("@fecha_factura", (fila.Cells("FechaFactura").Value))
                    command.Parameters.AddWithValue("@fecha_pago", (fila.Cells("FechaPagoReal").Value))
                    command.Parameters.AddWithValue("@nombre_emisor", (fila.Cells("Proveedor").Value))
                    command.Parameters.AddWithValue("@rfc_emisor", "")
                    command.Parameters.AddWithValue("@estatus", (fila.Cells("EstatusConta").Value))
                    command.Parameters.AddWithValue("@ruta", (fila.Cells("ruta").Value))
                    command.Parameters.AddWithValue("@observacompra", (fila.Cells("ObservaCompra").Value))
                    command.Parameters.AddWithValue("@usuariocompras", id)

                    command.Parameters.AddWithValue("@estatuspago", (fila.Cells("EstatusPago").Value))
                    command.Parameters.AddWithValue("@observaconta", (fila.Cells("ObservaConta").Value))
                    command.Parameters.AddWithValue("@id_provcompra", (fila.Cells("Id_provcompra").Value))





                    command.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Registro(s) validado(s)", "¡Correcto!", MessageBoxButtons.OK)

            cargagridconta()


            'btn_selec.Visible = False
            'btn_desma.Visible = False
            'btn_cargar.Visible = False
            'btn_calcular.Visible = False
            'Panel1.Visible = False
            'Panel2.Visible = False
            'Panel5.Visible = False



        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try

    End Sub

    Sub ModificaCompras()
        cnn.Close()


        Dim command As New SqlCommand("Sp_ValidaModificaAutorizaProvisiones", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Try

            For Each fila In dgv2.Rows
                If fila.Cells(0).Value = True And fila.Cells("EstatusConta").Value <> "A" Then

                    command.Parameters.Clear()

                    command.Parameters.AddWithValue("@var", 2)
                    command.Parameters.AddWithValue("@id_prov", (fila.Cells("Id_provision").Value))
                    command.Parameters.AddWithValue("@id_po", (fila.Cells("Id_po").Value))
                    command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))
                    command.Parameters.AddWithValue("@serie", (fila.Cells("Serie").Value))
                    command.Parameters.AddWithValue("@folio_factura", (fila.Cells("Factura").Value))
                    command.Parameters.AddWithValue("@uuid", (fila.Cells("UUID").Value))
                    command.Parameters.AddWithValue("@proveedor", (fila.Cells("Proveedor").Value))
                    command.Parameters.AddWithValue("@rfc", "")
                    command.Parameters.AddWithValue("@monto_po", 0)
                    command.Parameters.AddWithValue("@monto_fact", 0)
                    command.Parameters.AddWithValue("@monto_pago", (fila.Cells("MontoPago").Value))
                    command.Parameters.AddWithValue("@fecha_factura", (fila.Cells("FechaFactura").Value))
                    command.Parameters.AddWithValue("@fecha_pago", (fila.Cells("FechaPagoFact").Value))
                    command.Parameters.AddWithValue("@nombre_emisor", (fila.Cells("Proveedor").Value))
                    command.Parameters.AddWithValue("@rfc_emisor", "")
                    command.Parameters.AddWithValue("@estatus", (fila.Cells("EstatusConta").Value))
                    command.Parameters.AddWithValue("@ruta", (fila.Cells("ruta").Value))
                    command.Parameters.AddWithValue("@observacompra", (fila.Cells("ObservaCompra").Value))
                    command.Parameters.AddWithValue("@usuariocompras", id)

                    command.Parameters.AddWithValue("@estatuspago", (fila.Cells("EstatusPago").Value))
                    command.Parameters.AddWithValue("@observaconta", (fila.Cells("ObservaConta").Value))
                    command.Parameters.AddWithValue("@id_provcompra", (fila.Cells("Id_provcompra").Value))

                    command.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Registro(s) modificados(s)", "¡Correcto!", MessageBoxButtons.OK)
            cargagridvalidado()


            'btn_selec.Visible = False
            'btn_desma.Visible = False
            'btn_cargar.Visible = False
            'btn_calcular.Visible = False
            'Panel1.Visible = False
            'Panel2.Visible = False
            'Panel5.Visible = False



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try
    End Sub


    Sub EliminaCompras()
        cnn.Close()


        Dim command As New SqlCommand("Sp_ValidaModificaAutorizaProvisiones", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Try

            For Each fila In dgv2.Rows
                If fila.Cells(0).Value = True Then
                    'And fila.Cells("Estatus_Conta").Value <> 1
                    command.Parameters.Clear()

                    command.Parameters.AddWithValue("@var", 4)
                    command.Parameters.AddWithValue("@id_prov", (fila.Cells("Id_provision").Value))
                    command.Parameters.AddWithValue("@id_po", (fila.Cells("Id_po").Value))
                    command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))
                    command.Parameters.AddWithValue("@serie", (fila.Cells("Serie").Value))
                    command.Parameters.AddWithValue("@folio_factura", (fila.Cells("Factura").Value))
                    command.Parameters.AddWithValue("@uuid", (fila.Cells("UUID").Value))
                    command.Parameters.AddWithValue("@proveedor", (fila.Cells("Proveedor").Value))
                    command.Parameters.AddWithValue("@rfc", "")
                    command.Parameters.AddWithValue("@monto_po", 0)
                    command.Parameters.AddWithValue("@monto_fact", 0)
                    command.Parameters.AddWithValue("@monto_pago", (fila.Cells("MontoPago").Value))
                    command.Parameters.AddWithValue("@fecha_factura", (fila.Cells("FechaFactura").Value))
                    command.Parameters.AddWithValue("@fecha_pago", (fila.Cells("FechaPagoFact").Value))
                    command.Parameters.AddWithValue("@nombre_emisor", (fila.Cells("Proveedor").Value))
                    command.Parameters.AddWithValue("@rfc_emisor", "")
                    command.Parameters.AddWithValue("@estatus", (fila.Cells("EstatusConta").Value))
                    command.Parameters.AddWithValue("@ruta", (fila.Cells("ruta").Value))
                    command.Parameters.AddWithValue("@observacompra", (fila.Cells("ObservaCompra").Value))
                    command.Parameters.AddWithValue("@usuariocompras", id)

                    command.Parameters.AddWithValue("@estatuspago", (fila.Cells("EstatusPago").Value))
                    command.Parameters.AddWithValue("@observaconta", (fila.Cells("ObservaConta").Value))
                    command.Parameters.AddWithValue("@id_provcompra", (fila.Cells("Id_provcompra").Value))

                    command.ExecuteNonQuery()
                    'MessageBox.Show((fila.Cells("Id_provcompra").Value))
                End If
            Next

            MessageBox.Show("Registro(s) eliminado(s)", "¡Correcto!", MessageBoxButtons.OK)
            cargagridvalidado()


            'btn_selec.Visible = False
            'btn_desma.Visible = False
            'btn_cargar.Visible = False
            'btn_calcular.Visible = False
            'Panel1.Visible = False
            'Panel2.Visible = False
            'Panel5.Visible = False



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try
    End Sub





    Private Sub btn_valida_Click(sender As Object, e As EventArgs) Handles btn_valida.Click
        insertarfilas()
    End Sub

    Private Sub dtgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.CellContentClick

        Try
            colores()
        Catch
        End Try
    End Sub


    Sub colores(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dtgv3.CellFormatting
        Dim TipoTrade As String

        If dtgv3.Columns(e.ColumnIndex).Name.Equals("Estatus") Then

            TipoTrade = (dtgv3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)

            If TipoTrade = "C" Then
                e.CellStyle.BackColor = Color.DarkGreen
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.SelectionBackColor = Color.DarkGreen
                e.CellStyle.SelectionForeColor = Color.White
            End If

            If TipoTrade = "P" Then
                e.CellStyle.BackColor = Color.LightBlue
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.SelectionBackColor = Color.LightBlue
                e.CellStyle.SelectionForeColor = Color.Black
            End If
        End If





        If dtgv3.Columns(e.ColumnIndex).Name.Equals("Moneda") Then

            TipoTrade = (dtgv3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

            If TipoTrade = "MEX" Then
                e.CellStyle.BackColor = Color.DarkGreen
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.SelectionBackColor = Color.DarkGreen
                e.CellStyle.SelectionForeColor = Color.White
            End If

            If TipoTrade = "USD" Then
                e.CellStyle.BackColor = Color.White
                e.CellStyle.ForeColor = Color.Blue
                e.CellStyle.SelectionBackColor = Color.White
                e.CellStyle.SelectionForeColor = Color.Blue
            End If


            If TipoTrade = "YEN" Then
                e.CellStyle.BackColor = Color.PaleVioletRed
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.SelectionBackColor = Color.PaleVioletRed
                e.CellStyle.SelectionForeColor = Color.White
            End If
        End If




        If dtgv3.Columns(e.ColumnIndex).Name.Equals("EstatusConta") Then

            TipoTrade = (dtgv3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString)

            If TipoTrade = "A" Then
                e.CellStyle.BackColor = Color.DarkGreen
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.SelectionBackColor = Color.DarkGreen
                e.CellStyle.SelectionForeColor = Color.White
            End If

            If TipoTrade = "R" Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.SelectionBackColor = Color.Red
                e.CellStyle.SelectionForeColor = Color.White
            End If

            If TipoTrade = "M" Then
                e.CellStyle.BackColor = Color.Gold
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.SelectionBackColor = Color.Gold
                e.CellStyle.SelectionForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ValidaConta()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModificaCompras()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EliminaCompras()
    End Sub

    Private Sub txt_foc_TextChanged(sender As Object, e As EventArgs) Handles txt_foc.TextChanged, txt_ffa.TextChanged, txt_fpr.TextChanged
        filtrar_dtgv1()
    End Sub

    Sub filtrar_dtgv1()
        Try
            dt.DefaultView.RowFilter = "PO LIKE '%" & txt_foc.Text & "%' and Folio_factura LIKE '%" & txt_ffa.Text & "%' and Proveedor LIKE '%" & txt_fpr.Text & "%' "
            colores()
        Catch
        End Try
    End Sub

    Private Sub txt_foc_TextChanged2(sender As Object, e As EventArgs) Handles txt_f1.TextChanged, txt_f2.TextChanged, txt_f3.TextChanged, txt_status.TextChanged
        filtrar_dtgv2()
    End Sub

    Sub filtrar_dtgv2()
        Try
            dt2.DefaultView.RowFilter = "PO LIKE '%" & txt_f1.Text & "%' and Factura LIKE '%" & txt_f2.Text & "%' and Proveedor LIKE '%" & txt_f3.Text & "%' and EstatusConta LIKE '%" & txt_status.Text & "%' "
            colores()
        Catch
        End Try
    End Sub


    Private Sub txt_foc_TextChanged3(sender As Object, e As EventArgs) Handles t1.TextChanged, t2.TextChanged, t3.TextChanged, t4.TextChanged, t5.TextChanged, t6.TextChanged, t7.TextChanged, t8.TextChanged
        filtrar_dtgv3()
    End Sub

    Sub filtrar_dtgv3()
        Try
            dt3.DefaultView.RowFilter = "PO LIKE '%" & t1.Text & "%' and EstatusConta LIKE '%" & t2.Text & "%' and Factura LIKE '%" & t3.Text & "%' and Proveedor LIKE '%" & t4.Text & "%' and Serie LIKE '%" & t5.Text & "%' and Moneda LIKE '%" & t6.Text & "%' and  CONVERT ( FechaVal, System.String) LIKE '%" & t7.Text & "%' and CONVERT ( FechaPagoFact, System.String) LIKE '%" & t8.Text & "%' "
            ' colores()
        Catch
        End Try
    End Sub


End Class