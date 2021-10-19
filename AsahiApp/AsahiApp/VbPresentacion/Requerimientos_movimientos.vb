Imports System.Data.SqlClient
Public Class Requerimientos_movimientos

    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer


    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String

    Dim requerimiento_id As Integer
    Dim estado_mov As Integer
    Dim id_mov As Integer
    Dim a As Integer
    Dim tipo As Integer
    Dim var_fila As Integer
    Dim rechazo As String

    Dim usuario_c As Integer
    Dim z As String


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub


    Sub AgregarColumna()
        Dim cbox As New DataGridViewCheckBoxColumn
        dtgvp.Columns.Insert(dtgvp.ColumnCount, cbox)
        With cbox
            .HeaderText = "x"
            .Name = "x"
            .Width = 40
        End With
    End Sub

    Private Sub Requerimientos_movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        requerimiento_id = Modulo_Req_principal.e_id

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


        If p_vales = 0 Then

            Me.Text = "Movimientos"
            dtp_fecharecep.Visible = False
            lbl_fecharecep.Visible = True
            btn_solicitar.Text = "Guardar"
            lbl_moneda.Enabled = False
            btn_autoriza.Visible = False
            'btn_pdf.Visible = False
            'btn_desma.Visible = False
            'btn_selec.Visible = False


        ElseIf p_vales = 1 Then

            Me.Text = "Cotizar movimiento"
            dtp_fecharecep.Visible = True

            btn_solicitar.Text = "Cotizar"

            dtp1.Enabled = False
            txt_comen.Enabled = False
            btn_autoriza.Visible = True
            btn_pdf.Visible = True
            btn_desma.Visible = True
            btn_selec.Visible = True
            btn_cancelar.Visible = True
            btn_doc.Visible = True
            cbx_fam.Enabled = True



        End If

        AgregarColumna()
        cargagrid()
        areas()

        Dim cmd As New SqlCommand("   select razon_social from [Asahi].[dbo].[com_proveedores] ", cnn)
        If cnn.State = ConnectionState.Closed Then cnn.Open()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "Autofill")

        Dim col As New AutoCompleteStringCollection

        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Razon_Social").ToString())
        Next

        txt_proveedor.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_proveedor.AutoCompleteCustomSource = col
        txt_proveedor.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub


    Sub cargagrid()


        Try

            cnn.Close()

            cnn.Open()

            Dim da As New SqlDataAdapter("Sp_MuestraRequerimientoMovimiento", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@id", requerimiento_id)




            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns(1).Width = 480
            dtgvp.Columns(1).ReadOnly = True
            dtgvp.Columns(2).Visible = False
            dtgvp.Columns(3).Visible = False
            dtgvp.Columns(4).Visible = False
            dtgvp.Columns(5).Visible = False
            dtgvp.Columns(6).Visible = False
            dtgvp.Columns(7).Visible = False
            dtgvp.Columns(10).Visible = False
            dtgvp.Columns(8).Visible = False
            dtgvp.Columns(9).Visible = False
            dtgvp.Columns(10).Visible = False
            dtgvp.Columns(11).Visible = False
            dtgvp.Columns(12).Visible = False
            dtgvp.Columns(13).Visible = False
            dtgvp.Columns(14).Visible = False
            dtgvp.Columns(15).Visible = False
            dtgvp.Columns(16).Visible = False
            dtgvp.Columns(17).Visible = False
            dtgvp.Columns(18).Visible = False
            dtgvp.Columns(19).Visible = False
            dtgvp.Columns(20).Visible = False
            dtgvp.Columns(21).Visible = False
            dtgvp.Columns(22).Visible = False
            dtgvp.Columns(23).Visible = False
            dtgvp.Columns(24).Visible = False
            dtgvp.Columns(25).Visible = False
            dtgvp.Columns(26).Visible = False
            dtgvp.Columns(27).Visible = False
            dtgvp.Columns(28).Visible = False
            dtgvp.Columns(29).Visible = False
            dtgvp.Columns(30).Visible = False
            cnn.Close()

        Catch
        End Try


        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells(“Estado_mov”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.White
                ElseIf row.Cells(“Estado_mov”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                ElseIf row.Cells(“Estado_mov”).Value = 4 Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf row.Cells(“Estado_mov”).Value = 5 Then
                    row.DefaultCellStyle.BackColor = Color.Thistle
                ElseIf row.Cells(“Estado_mov”).Value = 6 Then
                    row.DefaultCellStyle.BackColor = Color.DarkGoldenrod

                End If
            Next
        Catch
        End Try




    End Sub


    Private Sub dtgvp_CellContentClick0(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick
        Try
            lbl_producto.Text = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
            lbl_comprador.Text = Me.dtgvp.Rows(e.RowIndex).Cells(2).Value.ToString()
            lbl_codigo.Text = Me.dtgvp.Rows(e.RowIndex).Cells(3).Value.ToString()
            lbl_nparte.Text = Me.dtgvp.Rows(e.RowIndex).Cells(4).Value.ToString()
            cbx_area.Text = Me.dtgvp.Rows(e.RowIndex).Cells(5).Value.ToString()
            txt_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells(6).Value.ToString()
            txt_cantidad.Text = Me.dtgvp.Rows(e.RowIndex).Cells(7).Value.ToString()
            txt_precio.Text = Me.dtgvp.Rows(e.RowIndex).Cells(8).Value.ToString()
            dtp1.Value = Me.dtgvp.Rows(e.RowIndex).Cells(9).Value.ToString()
            lbl_fecharecep.Text = Me.dtgvp.Rows(e.RowIndex).Cells(10).Value.ToString()
            lbl_moneda.Text = Me.dtgvp.Rows(e.RowIndex).Cells(11).Value.ToString()
            txt_comen.Text = Me.dtgvp.Rows(e.RowIndex).Cells(12).Value.ToString()
            lbl_subtotal.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(13).Value.ToString(), Decimal), "#,##0.00")
            lbl_impuestos.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(14).Value.ToString(), Decimal), "#,##0.00")
            lbl_retenciones.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(15).Value.ToString(), Decimal), "#,##0.00")
            lbl_descuento.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(16).Value.ToString(), Decimal), "#,##0.00")
            lbl_total.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(17).Value.ToString(), Decimal), "#,##0.00")
            lbl_oc.Text = Me.dtgvp.Rows(e.RowIndex).Cells(18).Value.ToString()
            id_mov = Me.dtgvp.Rows(e.RowIndex).Cells(19).Value.ToString()
            estado_mov = Me.dtgvp.Rows(e.RowIndex).Cells(20).Value.ToString()
            rechazo = Me.dtgvp.Rows(e.RowIndex).Cells(28).Value.ToString()
            txt_liga.Text = Me.dtgvp.Rows(e.RowIndex).Cells(29).Value.ToString()
            cbx_fam.Text = Me.dtgvp.Rows(e.RowIndex).Cells(30).Value.ToString()

            usuario_c = Me.dtgvp.Rows(e.RowIndex).Cells(22).Value.ToString()
            Try
                var_fila = dtgvp.CurrentRow.Index
            Catch
            End Try



            If p_vales = 0 Then
                If estado_mov = 0 Or estado_mov = 6 Then
                    cbx_area.Enabled = True
                    txt_proveedor.Enabled = True
                    txt_cantidad.Enabled = True
                    txt_precio.Enabled = True
                    txt_comen.Enabled = True
                    dtp1.Enabled = True
                    btn_solicitar.Enabled = True
                    btn_eliminar.Enabled = True

                Else
                    cbx_area.Enabled = False
                    txt_proveedor.Enabled = False
                    txt_cantidad.Enabled = False
                    txt_precio.Enabled = False
                    txt_comen.Enabled = False
                    dtp1.Enabled = False
                    btn_solicitar.Enabled = False
                    btn_eliminar.Enabled = False

                End If

            ElseIf p_vales = 1 Then

                cbx_area.Enabled = True
                txt_proveedor.Enabled = True
                txt_cantidad.Enabled = True
                txt_precio.Enabled = True
                txt_comen.Enabled = False
                dtp1.Enabled = False
                btn_solicitar.Enabled = True
                btn_eliminar.Enabled = True


                If estado_mov = 0 Then
                    btn_autoriza.Enabled = False

                Else
                    btn_autoriza.Enabled = True

                End If

            End If
        Catch
        End Try

    End Sub

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        lbl_producto.Text = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
        lbl_comprador.Text = Me.dtgvp.Rows(e.RowIndex).Cells(2).Value.ToString()
        lbl_codigo.Text = Me.dtgvp.Rows(e.RowIndex).Cells(3).Value.ToString()
        lbl_nparte.Text = Me.dtgvp.Rows(e.RowIndex).Cells(4).Value.ToString()
        cbx_area.Text = Me.dtgvp.Rows(e.RowIndex).Cells(5).Value.ToString()
        txt_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells(6).Value.ToString()
        txt_cantidad.Text = Me.dtgvp.Rows(e.RowIndex).Cells(7).Value.ToString()
        txt_precio.Text = Me.dtgvp.Rows(e.RowIndex).Cells(8).Value.ToString()
        dtp1.Value = Me.dtgvp.Rows(e.RowIndex).Cells(9).Value.ToString()
        lbl_fecharecep.Text = Me.dtgvp.Rows(e.RowIndex).Cells(10).Value.ToString()
        lbl_moneda.Text = Me.dtgvp.Rows(e.RowIndex).Cells(11).Value.ToString()
        txt_comen.Text = Me.dtgvp.Rows(e.RowIndex).Cells(12).Value.ToString()
        lbl_subtotal.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(13).Value.ToString(), Decimal), "#,##0.00")
        lbl_impuestos.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(14).Value.ToString(), Decimal), "#,##0.00")
        lbl_retenciones.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(15).Value.ToString(), Decimal), "#,##0.00")
        lbl_descuento.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(16).Value.ToString(), Decimal), "#,##0.00")
        lbl_total.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells(17).Value.ToString(), Decimal), "#,##0.00")
        lbl_oc.Text = Me.dtgvp.Rows(e.RowIndex).Cells(18).Value.ToString()
        id_mov = Me.dtgvp.Rows(e.RowIndex).Cells(19).Value.ToString()
        estado_mov = Me.dtgvp.Rows(e.RowIndex).Cells(20).Value.ToString()
        cbx_fam.Text = Me.dtgvp.Rows(e.RowIndex).Cells(30).Value.ToString()
        usuario_c = Me.dtgvp.Rows(e.RowIndex).Cells(22).Value.ToString()
        rechazo = Me.dtgvp.Rows(e.RowIndex).Cells(28).Value.ToString()
        txt_liga.Text = Me.dtgvp.Rows(e.RowIndex).Cells(29).Value.ToString()
        Try
            var_fila = dtgvp.CurrentRow.Index
        Catch
        End Try


        If p_vales = 0 Then
            If estado_mov = 0 Or estado_mov = 6 Then
                cbx_area.Enabled = True
                txt_proveedor.Enabled = True
                txt_cantidad.Enabled = True
                txt_precio.Enabled = True
                txt_comen.Enabled = True
                dtp1.Enabled = True
                btn_solicitar.Enabled = True
                btn_eliminar.Enabled = True

            Else
                cbx_area.Enabled = False
                txt_proveedor.Enabled = False
                txt_cantidad.Enabled = False
                txt_precio.Enabled = False
                txt_comen.Enabled = False
                dtp1.Enabled = False
                btn_solicitar.Enabled = False
                btn_eliminar.Enabled = False

            End If

        ElseIf p_vales = 1 Then

            cbx_area.Enabled = True
            txt_proveedor.Enabled = True
            txt_cantidad.Enabled = True
            txt_precio.Enabled = True
            txt_comen.Enabled = False
            dtp1.Enabled = False
            btn_solicitar.Enabled = True
            btn_eliminar.Enabled = True


            If estado_mov = 0 Then
                btn_autoriza.Enabled = False

            Else
                btn_autoriza.Enabled = True

            End If



        End If

    End Sub




    Sub modificar()



        Dim command As New SqlCommand("Sp_ActualizaEliminaMovimientoRequerimiento", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try




            command.Parameters.Clear()


            command.Parameters.AddWithValue("@cantidad", txt_cantidad.Text)
            command.Parameters.AddWithValue("@precio", txt_precio.Text)
            command.Parameters.AddWithValue("@comentarios", txt_comen.Text)
            command.Parameters.AddWithValue("@id", id_mov)
            command.Parameters.AddWithValue("@proveedor", txt_proveedor.Text)

            command.Parameters.AddWithValue("@area", a)
            command.Parameters.AddWithValue("@var", tipo)
            command.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
            command.Parameters.AddWithValue("@doc", txt_liga.Text)
            command.Parameters.AddWithValue("@familia", cbx_fam.Text)

            If p_vales = 0 Then
                command.Parameters.AddWithValue("@estado", 0)
                command.Parameters.AddWithValue("@moneda", "N/A")
                command.Parameters.AddWithValue("@fecha_recep", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@comprador", 0)
            ElseIf p_vales = 1 Then
                command.Parameters.AddWithValue("@estado", 1)
                command.Parameters.AddWithValue("@moneda", lbl_moneda.Text)
                command.Parameters.AddWithValue("@fecha_recep", dtp_fecharecep.Value.ToShortDateString)
                command.Parameters.AddWithValue("@comprador", id)

            End If







            command.ExecuteNonQuery()


            If p_vales = 0 Then
                If tipo = 0 Then
                    MessageBox.Show("Modificación realizada con éxito", "¡Correcto!", MessageBoxButtons.OK)
                ElseIf tipo = 1 Then
                    MessageBox.Show("Movimiento eliminado con éxito", "¡Correcto!", MessageBoxButtons.OK)
                End If


            ElseIf p_vales = 1 Then

                If tipo = 0 Then
                    MessageBox.Show("Cotización realizada con éxito", "¡Correcto!", MessageBoxButtons.OK)
                ElseIf tipo = 1 Then
                    MessageBox.Show("Movimiento eliminado con éxito", "¡Correcto!", MessageBoxButtons.OK)
                End If
            End If




            cargagrid()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try



    End Sub

    Private Sub cbx_area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_area.SelectedIndexChanged
        areas()
    End Sub


    Sub areas()


        Select Case cbx_area.Text
            Case "ASEGURAMIENTO DE CALIDAD F1"
                a = "03"
            Case "ASUNTOS GENERALES"
                a = "04"
            Case "ATENCIÓN AL CLIENTE"
                a = "05"
            Case "COMPRAS"
                a = "06"
            Case "CONTABILIDAD"
                a = "07"
            Case "CONTROL DE MANUFACTURA"
                a = "08"
            Case "CONTROL DE PRODUCCION"
                a = "09"
            Case "MOLDES"
                a = "16"
            Case "SEGURIDAD"
                a = "18"
            Case "SISTEMAS IT"
                a = "19"
            Case "INGENIERÍA MAQUINADO"
                a = "27"
            Case "INGENIERÍA FUNDICIÓN"
                a = "28"
            Case "INSPECCION PRODUCCION"
                a = "31"
            Case "FUNDICION 1"
                a = "32"
            Case "FUNDICION 2"
                a = "33"
            Case "ACABADO"
                a = "34"
            Case "ACABADO 2"
                a = "35"
            Case "CONTROL DE CLIENTES"
                a = "36"
            Case "MANTENIMIENTO DE PLANTA"
                a = "37"
            Case "MANTENIMIENTO FUNDICION"
                a = "38"
            Case "MANTENIMIENTO MAQUINADO"
                a = "39"
            Case "MAQUINADO F2"
                a = "40"
            Case "INSPECCIÓN FUNDICION"
                a = "41"
            Case "INSPECCIÓN MAQUINADO"
                a = "42"
            Case "MANTENIMIENTO FUNDICION"
                a = "43"
            Case "FUSION"
                a = "44"
            Case "ASEGURAMIENTO DE CALIDAD F2"
                a = "46"
            Case "REPARACION DE MOLDES"
                a = "47"
            Case "PRODUCCIÓN"
                a = "48"
        End Select


    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click


        Dim comando As SqlCommand = New SqlCommand
        comando.CommandText = " 

if exists (select top 1 razon_social FROM [Asahi].[dbo].[com_proveedores] where razon_social = '" & txt_proveedor.Text & "')
begin
select 'x'
end
else
begin
select 'z'
end"
        comando.Connection = cnn
        cnn.Close()
        cnn.Open()

        z = comando.ExecuteScalar()

        cnn.Close()







        tipo = 0


        If p_vales = 0 Then


            If z = "z" Then
                MessageBox.Show("Debe elegir un proveedor registrado, si no tiene un posible proveedor seleccione 'X'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                If txt_cantidad.Text = "" Then
                    txt_cantidad.Text = 0
                End If


                If txt_precio.Text = "" Then
                    txt_precio.Text = 0
                End If

                If txt_cantidad.Text <= 0 Then
                    MessageBox.Show("La cantidad a solicitar debe ser mayor a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else



                    If usuario_c = id Then


                        Dim Pregunta As Integer


                        Pregunta = MsgBox("¿Desea modificar el movimiento?", vbYesNo + vbExclamation + vbDefaultButton2, "Modificación")


                        If Pregunta = vbYes Then


                            modificar()

                            Try
                                dtgvp.CurrentCell = dtgvp.Rows(var_fila + 1).Cells(0)
                            Catch ex As Exception

                            End Try

                            Try
                                var_fila = dtgvp.CurrentRow.Index
                            Catch
                            End Try

                        Else
                            MessageBox.Show("Acción no completada", "Modificación")
                        End If

                    Else

                        MessageBox.Show("No puede modificar un requerimiento que no fue creado por usted", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If

                End If

            End If

        ElseIf p_vales = 1 Then


            If z = "z" Then
                MessageBox.Show("Debe elegir un proveedor registrado, si no tiene un posible proveedor seleccione 'X'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                If txt_cantidad.Text = "" Then
                    txt_cantidad.Text = 0
                End If


                If txt_precio.Text = "" Then
                    txt_precio.Text = 0
                End If

                If txt_cantidad.Text <= 0 Or txt_precio.Text <= 0 Then
                    MessageBox.Show("La cantidad a solicitar debe ser mayor a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else


                    Dim Pregunta As Integer


                    Pregunta = MsgBox("¿Desea cotizar el movimiento?", vbYesNo + vbExclamation + vbDefaultButton2, "Cotización")


                    If Pregunta = vbYes Then

                        If lbl_moneda.Text = "N/A" Then
                            MessageBox.Show("Debe elegir una moneda para la cotización", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Else

                            modificar()
                            Try
                                dtgvp.CurrentCell = dtgvp.Rows(var_fila + 1).Cells(0)
                            Catch ex As Exception

                            End Try

                            Try
                                var_fila = dtgvp.CurrentRow.Index
                            Catch
                            End Try

                        End If






                    Else
                        MessageBox.Show("Acción no completada", "Modificación")
                    End If



                End If

            End If


        End If




    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        tipo = 1


        If usuario_c = id Then
            Dim Pregunta As Integer


            Pregunta = MsgBox("¿Desea eliminar el movimiento? Recuerde que esta acción es irreversible", vbYesNo + vbExclamation + vbDefaultButton2, "Eliminación")


            If Pregunta = vbYes Then


                modificar()


            Else
                MessageBox.Show("Acción no completada", "Eliminación")
            End If

        Else

            MessageBox.Show("No puede eliminar un requerimiento que no fue creado por usted", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = False
        Next
    End Sub


    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = True
        Next
    End Sub

    Private Sub btn_pdf_Click(sender As Object, e As EventArgs) Handles btn_pdf.Click

        cnn.Close()
        cnn.Open()
        Dim auto As SqlCommand = New SqlCommand("

insert into [Asahi].[dbo].[Temp_MovimientoRequerimiento] values (@id)

", cnn)


        Dim auto2 As SqlCommand = New SqlCommand("

delete from [Asahi].[dbo].[Temp_MovimientoRequerimiento]

", cnn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try
            auto2.ExecuteNonQuery()

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then
                    auto.Parameters.Clear()

                    auto.Parameters.Add("@id", SqlDbType.Int).Value = (fila.Cells(19).Value)

                    auto.ExecuteNonQuery()


                End If

            Next
            generar_reporte()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()
        Finally
            cnn.Close()

        End Try


    End Sub


    Sub generar_reporte()
        ContenedorReporteRequerimiento.Show()
    End Sub

    Private Sub btn_autoriza_Click(sender As Object, e As EventArgs) Handles btn_autoriza.Click
        autorizar()
    End Sub


    Sub autorizar()
        cnn.Close()
        cnn.Open()
        Dim auto As SqlCommand = New SqlCommand("

   


   update  [Asahi].[dbo].[Com_RequerimientoMovimiento] set estado = 4  where id_movimiento = @id and estado = 1


", cnn)



        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try


            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then
                    auto.Parameters.Clear()

                    auto.Parameters.Add("@id", SqlDbType.Int).Value = (fila.Cells(19).Value)

                    auto.ExecuteNonQuery()


                End If

            Next

            MessageBox.Show("Autorización realizada con éxito", "¡Correcto!", MessageBoxButtons.OK)
            cargagrid()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()
        Finally
            cnn.Close()

        End Try

    End Sub

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick


        If estado_mov = 6 Then


            Modulo_verpo.id_movi = id_mov
            Modulo_verpo.id_requi = requerimiento_id

            Modulo_verpo.e_id = id
            Modulo_verpo.e_depto = depto
            Modulo_verpo.e_permiso = permiso
            Modulo_verpo.e_nombre = nombre
            Modulo_verpo.e_p_vales = p_vales
            Modulo_verpo.e_rechazo = rechazo
            Requerimientos_rechazo.Show()
            Me.Dispose()
        Else

            Try
                Modulo_verpo.id = lbl_oc.Text
                Modulo_verpo.serie = "A"
                Modulo_verpo.tipo = 0
                Dim Req_misPo As New MisPOPrincipal(id, depto, permiso, nombre, 0)

                Req_misPo.Show()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Modulo_verpo.id_movi = id_mov
        Modulo_verpo.id_requi = requerimiento_id

        Modulo_verpo.e_id = id
        Modulo_verpo.e_depto = depto
        Modulo_verpo.e_permiso = permiso
        Modulo_verpo.e_nombre = nombre
        Modulo_verpo.e_p_vales = p_vales
        Modulo_verpo.e_rechazo = rechazo


        Requerimientos_rechazo.Show()
        Me.Dispose()


        '        cnn.Close()
        '        cnn.Open()
        '        Dim auto As SqlCommand = New SqlCommand("




        '   update  [Asahi].[dbo].[Com_RequerimientoMovimiento] set estado = 6  where id_movimiento = @id


        '", cnn)



        '        Dim fila As DataGridViewRow = New DataGridViewRow()
        '        Dim RI As String

        '        Try


        '            For Each fila In dtgvp.Rows
        '                If fila.Cells("x").Value = True Then
        '                    auto.Parameters.Clear()

        '                    auto.Parameters.Add("@id", SqlDbType.Int).Value = (fila.Cells(19).Value)

        '                    auto.ExecuteNonQuery()


        '                End If

        '            Next

        '            MessageBox.Show("Cancelación realizada con éxito", "¡Correcto!", MessageBoxButtons.OK)
        '            cargagrid()

        '        Catch ex As Exception
        '            MessageBox.Show("Error al actualizar registro, consulte al administrador")
        '            MessageBox.Show(ex.ToString)
        '            cnn.Close()
        '        Finally
        '            cnn.Close()

        '        End Try
    End Sub

    Private Sub btn_doc_Click(sender As Object, e As EventArgs) Handles btn_doc.Click
        Dim folder As New OpenFileDialog
        Dim result As DialogResult = folder.ShowDialog()

        If result = DialogResult.OK Then

            txt_liga.Text = folder.FileName
        Else
            MessageBox.Show("Salió sin guardar ningún documento", "¡Aviso!")

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class


Module Modulo_verpo

    Public id As Integer
    Public serie As String
    Public tipo As Integer
    Public id_movi As Integer
    Public id_requi As Integer


    Public e_id As Integer
    Public e_depto As String
    Public e_permiso As Integer
    Public e_nombre As String
    Public e_p_vales As Integer
    Public e_rechazo As String

End Module
