Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class MisPOPrincipal

    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer


    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String

    Dim a As String
    Dim var As Integer
    Dim tipo As Integer
    Dim codigo As Integer
    Dim serie As String
    Dim accion As Integer

    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub MisPOPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        dtp1.Value = DateAdd(DateInterval.Day, -10, dtp2.Value)
        cbx_serie.Text = "A"


        tipo = Modulo_verpo.tipo

        If tipo = 0 Then
            'MessageBox.Show(Modulo_verpo.id)
            btn_fil2.Enabled = True

            txt_no.Text = Modulo_verpo.id
            cbx_serie.Text = "A"
            var = 0


            cargagrid()
        End If

        'Select Case depto
        '    Case "03"
        '        cbx_area.Text = "ASEGURAMIENTO DE CALIDAD F1"
        '    Case "04"
        '        cbx_area.Text = "ASUNTOS GENERALES"
        '    Case "05"
        '        cbx_area.Text = "ATENCIÓN AL CLIENTE"
        '    Case "06"
        '        cbx_area.Text = "COMPRAS"
        '    Case "07"
        '        cbx_area.Text = "CONTABILIDAD"
        '    Case "08"
        '        cbx_area.Text = "CONTROL DE MANUFACTURA"
        '    Case "09"
        '        cbx_area.Text = "CONTROL DE PRODUCCION"
        '    Case "16"
        '        cbx_area.Text = "MOLDES"
        '    Case "18"
        '        cbx_area.Text = "SEGURIDAD"
        '    Case "19"
        '        cbx_area.Text = "SISTEMAS IT"
        '    Case "27"
        '        cbx_area.Text = "INGENIERÍA MAQUINADO"
        '    Case "28"
        '        cbx_area.Text = "INGENIERÍA FUNDICIÓN"
        '    Case "31"
        '        cbx_area.Text = "INSPECCION PRODUCCION"
        '    Case "32"
        '        cbx_area.Text = "FUNDICION 1"
        '    Case "33"
        '        cbx_area.Text = "FUNDICION 2"
        '    Case "34"
        '        cbx_area.Text = "ACABADO"
        '    Case "35"
        '        cbx_area.Text = "ACABADO 2"
        '    Case "36"
        '        cbx_area.Text = "CONTROL DE CLIENTES"
        '    Case "37"
        '        cbx_area.Text = "MANTENIMIENTO DE PLANTA"
        '    Case "38"
        '        cbx_area.Text = "MANTENIMIENTO FUNDICION"
        '    Case "39"
        '        cbx_area.Text = "MANTENIMIENTO MAQUINADO"
        '    Case "40"
        '        cbx_area.Text = "MAQUINADO F2"
        '    Case "41"
        '        cbx_area.Text = "INSPECCIÓN FUNDICION"
        '    Case "42"
        '        cbx_area.Text = "INSPECCIÓN MAQUINADO"
        '    Case "43"
        '        cbx_area.Text = "MANTENIMIENTO FUNDICION"
        '    Case "44"
        '        cbx_area.Text = "FUSION"
        '    Case "46"
        '        cbx_area.Text = "ASEGURAMIENTO DE CALIDAD F2"
        '    Case "47"
        '        cbx_area.Text = "REPARACION DE MOLDES"
        '    Case "48"
        '        cbx_area.Text = "PRODUCCIÓN"
        'End Select



        'If p_vales = 0 Then

        '    Me.Text = "Mis PO"
        '    Panel1.Visible = False

        '    btn_pdf.Visible = False

        '    ' cargagrid()

        'ElseIf p_vales = 1 Then

        '    Me.Text = "PO"
        '    Panel1.Visible = True

        '    btn_pdf.Visible = True

        'End If
    End Sub


    Sub cargagrid()

        Try
            dtgvp.Columns.Remove("X")

        Catch ex As Exception

        End Try

        Try

            cnn.Close()

            cnn.Open()

            Dim da As New SqlDataAdapter("Sp_muestragridPOConsulta", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@id", txt_no.Text)
            da.SelectCommand.Parameters.AddWithValue("@var", var)
            da.SelectCommand.Parameters.AddWithValue("@serie", cbx_serie.Text)
            da.SelectCommand.Parameters.AddWithValue("@inicio", dtp1.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@fin", dtp2.Value.ToShortDateString)



            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns(10).Width = 400
            dtgvp.Columns(3).Width = 60
            dtgvp.Columns(11).Width = 100
            'dtgvp.Columns(1).ReadOnly = True
            dtgvp.Columns(3).ReadOnly = True
            dtgvp.Columns(11).ReadOnly = True
            dtgvp.Columns(10).ReadOnly = True
            dtgvp.Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            dtgvp.Columns(0).Visible = False
            dtgvp.Columns(1).Visible = False
            dtgvp.Columns(2).Visible = False
            dtgvp.Columns(4).Visible = False
            dtgvp.Columns(5).Visible = False
            dtgvp.Columns(6).Visible = False
            dtgvp.Columns(7).Visible = False
            dtgvp.Columns(9).Visible = False
            'dtgvp.Columns(10).Visible = False
            dtgvp.Columns(8).Visible = False
            dtgvp.Columns(12).Visible = False
            dtgvp.Columns(13).Visible = False
            'dtgvp.Columns(12).Visible = False

            dtgvp.Columns(14).Visible = False
            dtgvp.Columns(15).Visible = False
            dtgvp.Columns(16).Visible = False
            dtgvp.Columns("RFC").Visible = False
            dtgvp.Columns("Estado").Visible = False
            'dtgvp.Columns(17).Visible = False
            'dtgvp.Columns(18).Visible = False
            'dtgvp.Columns(19).Visible = False
            'dtgvp.Columns(20).Visible = False
            'dtgvp.Columns(21).Visible = False
            'dtgvp.Columns(22).Visible = False
            'dtgvp.Columns(23).Visible = False
            'dtgvp.Columns(24).Visible = False
            'dtgvp.Columns(25).Visible = False
            'dtgvp.Columns(26).Visible = False
            'dtgvp.Columns(27).Visible = False

            cnn.Close()

            dtgvp.Visible = True
            AgregarColumna()
            Panel4.Visible = True
            colores()

            If dtgvp.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")
                dtgvp.Visible = False
                lbl_po.Text = ""
                lbl_subtotal.Text = ""
                lbl_impuestos.Text = ""
                lbl_retenciones.Text = ""
                lbl_descuentos.Text = ""
                lbl_total.Text = ""
                lbl_moneda.Text = ""
                lbl_tc.Text = ""
                lbl_proveedor.Text = ""
                lbl_fechaC.Text = ""
                lbl_fechaE.Text = ""
                lbl_fechaS.Text = ""
                lbl_comprador.Text = ""
                txt_comen.Text = ""
                txt_no.Text = ""
                Panel4.Visible = False

            End If





        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_fil2.Click
        var = 0
        cargagrid()
    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        var = 1
        cargagrid()
    End Sub

    Sub AgregarColumna()

        Dim cbox As New DataGridViewCheckBoxColumn
        dtgvp.Columns.Insert(dtgvp.ColumnCount, cbox)

        With cbox
            .HeaderText = "X"
            .Name = "X"
            .Width = 30
        End With
    End Sub



    Private Sub dtgvp_CellContentClick0(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick

        Try
            lbl_po.Text = Me.dtgvp.Rows(e.RowIndex).Cells("PO").Value.ToString()
            lbl_comprador.Text = Me.dtgvp.Rows(e.RowIndex).Cells("id_usuario_crea").Value.ToString()
            lbl_subtotal.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("sub_total").Value.ToString(), Decimal), "#,##0.00")
            lbl_impuestos.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("Imp_ret").Value.ToString(), Decimal), "#,##0.00")
            lbl_retenciones.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("Imp_tras").Value.ToString(), Decimal), "#,##0.00")
            lbl_descuentos.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("descuento").Value.ToString(), Decimal), "#,##0.00")
            lbl_total.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("total").Value.ToString(), Decimal), "#,##0.00")
            lbl_moneda.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Moneda").Value.ToString()

            lbl_tc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tc").Value.ToString()
            lbl_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells("proveedor").Value.ToString()
            txt_comen.Text = Me.dtgvp.Rows(e.RowIndex).Cells("observaciones").Value.ToString()
            Dim fc As Date
            fc = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_creacion").Value.ToString()
            lbl_fechaC.Text = fc.ToString("dd/MM/yyyy")

            Dim fe As Date
            fe = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_entrega").Value.ToString()
            lbl_fechaE.Text = fe.ToString("dd/MM/yyyy")


            Dim fs As Date
            fs = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_solicitud").Value.ToString()
            lbl_fechaS.Text = fs.ToString("dd/MM/yyyy")


            codigo = Me.dtgvp.Rows(e.RowIndex).Cells("codigo").Value.ToString()
            serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie").Value.ToString()


        Catch
        End Try



        colores()


    End Sub

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        Try
            lbl_po.Text = Me.dtgvp.Rows(e.RowIndex).Cells("PO").Value.ToString()
            lbl_comprador.Text = Me.dtgvp.Rows(e.RowIndex).Cells("id_usuario_crea").Value.ToString()
            lbl_subtotal.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("sub_total").Value.ToString(), Decimal), "#,##0.00")
            lbl_impuestos.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("Imp_ret").Value.ToString(), Decimal), "#,##0.00")
            lbl_retenciones.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("Imp_tras").Value.ToString(), Decimal), "#,##0.00")
            lbl_descuentos.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("descuento").Value.ToString(), Decimal), "#,##0.00")
            lbl_total.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("total").Value.ToString(), Decimal), "#,##0.00")
            lbl_moneda.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Moneda").Value.ToString()

            lbl_tc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tc").Value.ToString()
            lbl_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells("proveedor").Value.ToString()
            txt_comen.Text = Me.dtgvp.Rows(e.RowIndex).Cells("observaciones").Value.ToString()
            Dim fc As Date
            fc = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_creacion").Value.ToString()
            lbl_fechaC.Text = fc.ToString("dd/MM/yyyy")

            Dim fe As Date
            fe = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_entrega").Value.ToString()
            lbl_fechaE.Text = fe.ToString("dd/MM/yyyy")


            Dim fs As Date
            fs = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_solicitud").Value.ToString()
            lbl_fechaS.Text = fs.ToString("dd/MM/yyyy")


            codigo = Me.dtgvp.Rows(e.RowIndex).Cells("codigo").Value.ToString()
            serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie").Value.ToString()

        Catch
        End Try

        colores()
    End Sub

    Private Sub txt_no_TextChanged(sender As Object, e As EventArgs) Handles txt_no.TextChanged
        If txt_no.Text = "" Then
            btn_fil2.Enabled = False
        Else
            btn_fil2.Enabled = True
        End If
    End Sub

    Private Sub btn_pdf_Click(sender As Object, e As EventArgs)
        ContenedorReportePO.serie = serie
        ContenedorReportePO.codigo = codigo
        ContenedorReportePO.Show()


        ' enviarcorreoreincidencia()

    End Sub

    Sub enviarcorreoreincidencia()
        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage
        Dim adjunto As System.Net.Mail.Attachment


        With smtp
            .Port = 25
            .Host = "mail.asahialmex.com"
            .Credentials = New System.Net.NetworkCredential("erik.urbina@asahialmex.com", "wM8zh25_")
            .EnableSsl = False
        End With
        adjunto = New System.Net.Mail.Attachment("V:\" & codigo & ".pdf")
        With correo
            .From = New System.Net.Mail.MailAddress("erik.urbina@asahialmex.com")
            .To.Add("marco.aguilera@asahialmex.com")
            .Subject = "Asunto del correo"
            .Body = "<strong>Texto del mensaje de correo</strong>"
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
            .Attachments.Add(adjunto)
        End With

        Try
            smtp.Send(correo)
            MessageBox.Show("Su mensaje de correo ha sido enviado.",
                            "Correo enviado",
                             MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message,
                            "Error al enviar correo",
                             MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick

        Modulo_vistarecepprincipal.e_codigo = Me.dtgvp.Rows(e.RowIndex).Cells("codigo").Value.ToString()
        Modulo_vistarecepprincipal.e_serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie").Value.ToString()
        Modulo_vistarecepprincipal.e_po = lbl_po.Text
        Modulo_vistarecepprincipal.e_subtotal = lbl_subtotal.Text
        Modulo_vistarecepprincipal.e_total = lbl_total.Text
        Modulo_vistarecepprincipal.e_moneda = lbl_moneda.Text
        Modulo_vistarecepprincipal.e_tc = lbl_tc.Text
        Modulo_vistarecepprincipal.e_rfc = Me.dtgvp.Rows(e.RowIndex).Cells("RFC").Value.ToString()
        Modulo_vistarecepprincipal.e_proveedor = lbl_proveedor.Text

        Dim Req_movPO As New Requerimientos_MovimientosPO(id, depto, permiso, nombre, p_vales)
        Req_movPO.Show()
        colores()
    End Sub

    Private Sub btn_autorizar_Click(sender As Object, e As EventArgs) Handles btn_autorizar.Click
        accion = 1
        procesar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        accion = 2
        procesar()
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        accion = 3
        procesar()
    End Sub

    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("X").Value = True
        Next
    End Sub


    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("X").Value = False
        Next
    End Sub


    Sub procesar()
        Dim Pregunta As Integer

        If accion = 1 Then
            Pregunta = MsgBox("¿Desea autorizar la(s) siguiente(s) orden(es) de compra?", vbYesNo + vbExclamation + vbDefaultButton2, "¡Aviso!")
        ElseIf accion = 2 Then
            Pregunta = MsgBox("¿Desea cancelar la(s) siguiente(s) orden(es) de compra?", vbYesNo + vbExclamation + vbDefaultButton2, "¡Aviso!")
        ElseIf accion = 3 Then
            Pregunta = MsgBox("¿Desea cerrar la(s) siguiente(s) orden(es) de compra?", vbYesNo + vbExclamation + vbDefaultButton2, "¡Aviso!")
        End If


        If Pregunta = vbYes Then

            cnn.Close()
            cnn.Open()

            Dim auto As SqlCommand = New SqlCommand("
            declare @var1 as int
            set @var1 = @var 

            if @var1 = 1
            begin
            update [Asahi].[dbo].[com_po_principal] set estado = 1
            where id = @id and estado = 0
            end


            else if @var1= 2
            begin

            UPDATE 
            t2
            SET 
	        t2.Estado = 0 , t2.oc = 0
            FROM [Asahi].[dbo].[Com_RequerimientoPrincipal] t1
            JOIN [Asahi].[dbo].[Com_RequerimientoMovimiento] t2
	        on t2.Id_requerimiento = t1.Id_requerimientoP
	        join [Asahi].[dbo].[com_PO_movimientos] pomov
	        on pomov.id_req = t2.Id_movimiento
             join [Asahi].[dbo].[com_po_principal] poprin
	         on poprin.id = pomov.id_po
             WHERE pomov.id_po = @id and poprin.estado in (1,0) 


            UPDATE 
            pomov
            SET 
	         pomov.id_req = 0 , pomov.id_cotizacion = 0
            FROM [Asahi].[dbo].[Com_RequerimientoPrincipal] t1
            JOIN [Asahi].[dbo].[Com_RequerimientoMovimiento] t2
	        on t2.Id_requerimiento = t1.Id_requerimientoP
	        join [Asahi].[dbo].[com_PO_movimientos] pomov
	        on pomov.id_req = t2.Id_movimiento
            join [Asahi].[dbo].[com_po_principal] poprin
	         on poprin.id = pomov.id_po
             WHERE pomov.id_po = @id and poprin.estado in (1,0) 

            update [Asahi].[dbo].[com_po_principal] set estado = 2
            where id = @id and estado in (1,0)
            


            end


            else if @var1= 3
            begin

            UPDATE 
            pomov
            SET 
	         cantidad_recibida = cantidad , cantidad_facturada = cantidad, cantidad_pendiente = 0
            FROM [Asahi].[dbo].[com_PO_movimientos] pomov
            join [Asahi].[dbo].[com_po_principal] poprin
	         on poprin.id = pomov.id_po
             WHERE pomov.id_po = @id and poprin.estado in (4) 


            UPDATE 
            t2
            SET 
	        t2.Estado = 8
            FROM [Asahi].[dbo].[Com_RequerimientoPrincipal] t1
            JOIN [Asahi].[dbo].[Com_RequerimientoMovimiento] t2
	        on t2.Id_requerimiento = t1.Id_requerimientoP
	        join [Asahi].[dbo].[com_PO_movimientos] pomov
	        on pomov.id_req = t2.Id_movimiento
             join [Asahi].[dbo].[com_po_principal] poprin
	         on poprin.id = pomov.id_po
             WHERE pomov.id_po = @id and poprin.estado in (4) 
            

            update [Asahi].[dbo].[com_po_principal] set estado = 3
            where id = @id and estado in (4)
            



            end
 
                

", cnn)

            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim RI As String

            Try

                For Each fila In dtgvp.Rows
                    If fila.Cells("X").Value = True Then
                        auto.Parameters.Clear()
                        auto.Parameters.Add("@id", SqlDbType.Int).Value = (fila.Cells("id").Value)
                        auto.Parameters.Add("@var", SqlDbType.Int).Value = accion




                        auto.ExecuteNonQuery()


                        'Else
                        '    RI = "¡Debe palomear mínimo una casilla para validar!"

                    End If

                Next

                If accion = 1 Then
                    MessageBox.Show("Orden(es) de compra autorizada(s) correctamente", "¡Aviso!")
                ElseIf accion = 2 Then
                    MessageBox.Show("Orden(es) de compra cancelada(s) correctamente", "¡Aviso!")
                ElseIf accion = 3 Then
                    MessageBox.Show("Orden(es) de compra cerrada(s) correctamente", "¡Aviso!")
                End If


                cargagrid()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar registro, consulte al administrador")
                MessageBox.Show(ex.ToString)
                cnn.Close()
            Finally
                cnn.Close()
            End Try
        Else
            MessageBox.Show("Acción no completada", "¡Aviso!")

            cnn.Close()
        End If


    End Sub


    Sub colores()

        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells(“Estado”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.White
                ElseIf row.Cells(“Estado”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf row.Cells(“Estado”).Value = 2 Then
                    row.DefaultCellStyle.BackColor = Color.DarkGoldenrod
                ElseIf row.Cells(“Estado”).Value = 3 Then
                    row.DefaultCellStyle.BackColor = Color.Thistle
                ElseIf row.Cells(“Estado”).Value = 4 Then
                    row.DefaultCellStyle.BackColor = Color.Yellow
                ElseIf row.Cells(“Estado”).Value = 5 Then
                    row.DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next
        Catch
        End Try


    End Sub


End Class


Module Modulo_vistarecepprincipal

    Public e_codigo As Integer
    Public e_serie As String
    Public e_po As String
    Public e_proveedor As String
    Public e_subtotal As Double
    Public e_total As Double
    Public e_moneda As String
    Public e_tc As Double
    Public e_rfc As String
    Public e_provision As Integer

    Public e_ffac As String
    Public e_fpago As String
    Public e_fsub As Double
    Public e_ftotal As Double


    Public e_uuid As String
    Public e_folio As String
    Public e_estadoprov As Integer




End Module

