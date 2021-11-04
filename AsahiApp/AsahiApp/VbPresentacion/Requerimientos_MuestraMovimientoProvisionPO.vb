Imports System.Data.SqlClient

Public Class Requerimientos_MuestraMovimientoProvisionPO
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String

    Private Sub Requerimientos_MuestraMovimientoProvisionPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            lbl_foliofact.Text = Modulo_vistarecepprincipal.e_folio
            lbl_uuid.Text = Modulo_vistarecepprincipal.e_uuid
            lbl_provision.Text = Modulo_vistarecepprincipal.e_provision
            dtp1.Value = Modulo_vistarecepprincipal.e_ffac
            dtp2.Value = Modulo_vistarecepprincipal.e_fpago
            lbl_subtotalfact.Text = Modulo_vistarecepprincipal.e_fsub
            lbl_totalfact.Text = Modulo_vistarecepprincipal.e_ftotal
        Catch
        End Try


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

        cargagrid()
    End Sub


    Sub cargagrid()


        cnn.Close()
        cnn.Open()

        '   MessageBox.Show(cnn.ToString)
        Try



            Dim da As New SqlDataAdapter("Sp_muestragridmodificaRecepcionconPO", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@codigo", lbl_provision.Text)
            da.SelectCommand.Parameters.AddWithValue("@serie", 0)
            da.SelectCommand.Parameters.AddWithValue("@coal", "")
            da.SelectCommand.Parameters.AddWithValue("@id_cotizacion", 0)
            da.SelectCommand.Parameters.AddWithValue("@var", 3)

            'MessageBox.Show(txt_no.Text)
            'MessageBox.Show(cbx_serie.Text)

            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            'dtgvp.Columns("Recepcion").Width = 70
            'dtgvp.Columns("Folio").Width = 85
            'dtgvp.Columns("UUID").Width = 200
            '  dtgvp.Columns("Departamento").Width = 130

            dtgvp.Columns("Fecha de recepcion").Width = 80
            dtgvp.Columns("Codigo").Width = 65
            dtgvp.Columns("Requerimiento").Width = 88
            dtgvp.Columns("Nombre").Width = 300
            dtgvp.Columns("No parte").Width = 100
            dtgvp.Columns("Cantidad recibida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns("Fecha de pago real").Width = 65
            'dtgvp.Columns("Fecha de provisión").Width = 65
            'dtgvp.Columns("Fecha de factura").Width = 60
            'dtgvp.Columns("Fecha de pago").Width = 60
            'dtgvp.Columns("Subtotal").Width = 60
            'dtgvp.Columns("Total").Width = 60
            'dtgvp.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dtgvp.Columns("Fecha de recepcion").ReadOnly = True
            dtgvp.Columns("Cantidad recibida").ReadOnly = True
            dtgvp.Columns("Codigo").ReadOnly = True
            dtgvp.Columns("Nombre").ReadOnly = True
            dtgvp.Columns("No parte").ReadOnly = True
            dtgvp.Columns("Requerimiento").ReadOnly = True


            dtgvp.Columns("Recepcion").Visible = False
            dtgvp.Columns("Folio").Visible = False
            dtgvp.Columns("UUID").Visible = False


            '  cnn.Close()

            dtgvp.Visible = True

            '  dtgvp.Refresh()

            If dtgvp.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")
                dtgvp.Visible = False

            End If







            'If (depto <> 19 Or depto <> 7) Then
            '    dtgvp.Columns.Remove("X")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub
End Class