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
            lbl_fechaE.Text = fc.ToString("dd/MM/yyyy")


            Dim fs As Date
            fs = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_solicitud").Value.ToString()
            lbl_fechaS.Text = fc.ToString("dd/MM/yyyy")


            codigo = Me.dtgvp.Rows(e.RowIndex).Cells("codigo").Value.ToString()
            serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie").Value.ToString()


        Catch
        End Try






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


    End Sub

    Private Sub txt_no_TextChanged(sender As Object, e As EventArgs) Handles txt_no.TextChanged
        If txt_no.Text = "" Then
            btn_fil2.Enabled = False
        Else
            btn_fil2.Enabled = True
        End If
    End Sub

    Private Sub btn_pdf_Click(sender As Object, e As EventArgs) Handles btn_pdf.Click
        ContenedorReportePO.serie = serie
        ContenedorReportePO.codigo = codigo
        ContenedorReportePO.Show()


        enviarcorreoreincidencia()

    End Sub

    Sub enviarcorreoreincidencia()
        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage
        Dim adjunto As System.Net.Mail.Attachment


        ''Create an instance of ReportViewer

        'Dim viewer As New Microsoft.Reporting.WinForms.ReportViewer()

        ''Set local report
        ''NOTE: MyAppNamespace refers to the namespace for the app.
        'viewer.LocalReport.ReportEmbeddedResource = "AsahiApp.ReportePO_1.rdlc"

        ''Create Report Data Source
        'Dim rptDataSource As New Microsoft.Reporting.WinForms.ReportDataSource("Product", Data)
        'viewer.LocalReport.DataSources.Add(rptDataSource)

        ''Export to PDF. Get binary content.
        'Dim pdfContent As Byte() = viewer.LocalReport.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        ''Creatr PDF file on disk
        'Dim pdfPath As String = "C:\temp\report.pdf"
        'Dim pdfFile As New System.IO.FileStream(pdfPath, System.IO.FileMode.Create)
        'pdfFile.Write(pdfContent, 0, pdfContent.Length)
        'pdfFile.Close()





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

End Class