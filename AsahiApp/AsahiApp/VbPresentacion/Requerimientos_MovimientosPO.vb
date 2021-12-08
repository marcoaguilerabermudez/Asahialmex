Imports System.Data.SqlClient

Public Class Requerimientos_MovimientosPO

    Dim var_filtro As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer
    Dim codigo As Integer
    Dim serie As String

    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String


    Private Sub Requerimientos_MovimientosPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_tc.Text = Modulo_vistarecepprincipal.e_tc
        lbl_subtotalpo.Text = Format(CType(Modulo_vistarecepprincipal.e_subtotal, Decimal), "#,##0.00")
        lbl_total.Text = Format(CType(Modulo_vistarecepprincipal.e_total, Decimal), "#,##0.00")
        lbl_moneda.Text = Modulo_vistarecepprincipal.e_moneda
        lbl_po.Text = Modulo_vistarecepprincipal.e_po
        lbl_proveedor.Text = Modulo_vistarecepprincipal.e_proveedor
        lbl_rfc.Text = Modulo_vistarecepprincipal.e_rfc
        serie = Modulo_vistarecepprincipal.e_serie
        codigo = Modulo_vistarecepprincipal.e_codigo

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


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

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

    Sub cargagrid()

        'Try
        '    dtgvp.Columns.Remove("X")
        '    dtgvp.Columns.Remove("Totals")
        '    dtgvp.Columns.Remove("Totalx")
        'Catch ex As Exception

        'End Try


        Try



            cnn.Close()

            cnn.Open()

            Dim da As New SqlDataAdapter("Sp_muestrarecepcion", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@codigo", codigo)

            da.SelectCommand.Parameters.AddWithValue("@serie", serie)



            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Codigo").Width = 65
            dtgvp.Columns("Nombre").Width = 300
            dtgvp.Columns("No parte").Width = 100
            dtgvp.Columns("Departamento").Width = 130

            dtgvp.Columns("Cantidad PO").Width = 60
            dtgvp.Columns("Cantidad recibida").Width = 60
            dtgvp.Columns(13).Width = 60
            dtgvp.Columns(30).Width = 60
            dtgvp.Columns(31).Width = 60
            dtgvp.Columns(32).Width = 60
            'dtgvp.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            dtgvp.Columns("Codigo").ReadOnly = True
            dtgvp.Columns("Nombre").ReadOnly = True
            dtgvp.Columns("No parte").ReadOnly = True
            dtgvp.Columns("Departamento").ReadOnly = True
            dtgvp.Columns("Cantidad PO").ReadOnly = True
            dtgvp.Columns("Cantidad recibida").ReadOnly = True
            dtgvp.Columns("Precio").ReadOnly = True
            '  dtgvp.Columns("Recibido").ReadOnly = True
            'dtgvp.Columns(14).ReadOnly = True
            'dtgvp.Columns(15).ReadOnly = True
            'dtgvp.Columns(30).ReadOnly = True


            dtgvp.Columns("id_mov").Visible = False
            dtgvp.Columns("id_po").Visible = False
            dtgvp.Columns("PO").Visible = False
            dtgvp.Columns("Proveedor").Visible = False
            dtgvp.Columns("total_po").Visible = False
            dtgvp.Columns("Moneda").Visible = False
            dtgvp.Columns("tc").Visible = False
            dtgvp.Columns("Cantidad x recibir").Visible = False
            dtgvp.Columns("Cantidad facturada").Visible = False
            dtgvp.Columns("Subtotal").Visible = False
            dtgvp.Columns("Subtotal Unitario").Visible = False
            dtgvp.Columns("Total").Visible = False
            dtgvp.Columns("Total Unitario").Visible = False
            dtgvp.Columns("subtotal_po").Visible = False
            dtgvp.Columns("iva_po").Visible = False
            dtgvp.Columns("ret_po").Visible = False
            dtgvp.Columns("desc_po").Visible = False
            dtgvp.Columns("fecha_creacion").Visible = False
            dtgvp.Columns("fecha_solicitud").Visible = False
            dtgvp.Columns("fecha_entrega").Visible = False
            dtgvp.Columns("obs_po").Visible = False
            dtgvp.Columns("id_usuario_crea").Visible = False
            dtgvp.Columns("cod_po").Visible = False
            dtgvp.Columns("serie_po").Visible = False
            dtgvp.Columns("Estado").Visible = False
            ' dtgvp.Columns("Precio").Visible = False
            dtgvp.Columns("Recibido").Visible = False
            dtgvp.Columns("RFC").Visible = False
            dtgvp.Columns("id_cotizacion").Visible = False
            dtgvp.Columns("id_req").Visible = False
            dtgvp.Columns("rete_4").Visible = False

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

                lbl_total.Text = ""
                lbl_moneda.Text = ""
                lbl_tc.Text = ""
                lbl_proveedor.Text = ""

                'txt_no.Text = ""
                'lbl_t.Text = 0
                'lbl_neto.Text = 0

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

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub

    '    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick

    '        Try

    '            Modulo_VistaRecepciones.e_idcotizacion = Me.dtgvp.Rows(e.RowIndex).Cells("id_cotizacion").Value.ToString()
    '            Modulo_VistaRecepciones.e_serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie_po").Value.ToString()
    '            Modulo_VistaRecepciones.e_coal = Me.dtgvp.Rows(e.RowIndex).Cells("Codigo").Value.ToString()
    '            Modulo_VistaRecepciones.e_codigo = Me.dtgvp.Rows(e.RowIndex).Cells("cod_po").Value.ToString()


    '            Dim Req_RecibirPo As New Requerimientos_PrincipalRecepciones(id, depto, permiso, nombre, p_vales)
    '            Req_RecibirPo.Show()

    '        Catch
    '        End Try

    '    End Sub


End Class

Module Modulo_VistaRecepciones

    Public e_codigo As Integer
    Public e_serie As String
    Public e_coal As String
    Public e_idcotizacion As Integer
    Public e_PO As String
    Public e_proveedor As String
    Public e_rfc As String
    Public e_subtotalPO As Double
    Public e_totalPO As Double
    Public e_tc As Double
    Public e_moneda As String
    'Public e_proveedor As String
    'Public e_subtotal As Double
    'Public e_total As Double
    'Public e_moneda As String
    'Public e_tc As Double
    'Public e_rfc As String




End Module

