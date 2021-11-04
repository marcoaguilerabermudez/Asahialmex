Imports System.Data.SqlClient
Public Class Requerimientos_PrincipalRecepciones


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
    Dim id_coti As Integer
    Dim coal As String



    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Requerimientos_PrincipalRecepciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        PO = Modulo_VistaRecepciones.e_codigo
        Serie = Modulo_VistaRecepciones.e_serie
        id_coti = Modulo_VistaRecepciones.e_idcotizacion
        coal = Modulo_VistaRecepciones.e_coal

        cargagrid()

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
            da.SelectCommand.Parameters.AddWithValue("@coal", coal)
            da.SelectCommand.Parameters.AddWithValue("@id_cotizacion", id_coti)
            da.SelectCommand.Parameters.AddWithValue("@var", 0)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Recepcion").Width = 70
            dtgvp.Columns("Folio").Width = 85
            dtgvp.Columns("UUID").Width = 200
            '  dtgvp.Columns("Departamento").Width = 130

            dtgvp.Columns("Fecha de recepcion").Width = 65
            dtgvp.Columns("Fecha de factura").Width = 60
            dtgvp.Columns("Fecha de pago").Width = 60
            dtgvp.Columns("Subtotal").Width = 60
            dtgvp.Columns("Total").Width = 60
            'dtgvp.Columns("Tipo").Width = 60
            'dtgvp.Columns("Folio").Width = 85
            'dtgvp.Columns("Modificado").Width = 40
            'dtgvp.Columns("Cancelado").Width = 40
            'dtgvp.Columns("Provision").Width = 60
            'dtgvp.Columns(13).Width = 60
            'dtgvp.Columns(30).Width = 60
            'dtgvp.Columns(31).Width = 60
            'dtgvp.Columns(32).Width = 60
            'dtgvp.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns("Cantidad PO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns("Cantidad recibida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dtgvp.Columns("Recepcion").ReadOnly = True
            dtgvp.Columns("Folio").ReadOnly = True
            dtgvp.Columns("UUID").ReadOnly = True
            dtgvp.Columns("Fecha de recepcion").ReadOnly = True
            dtgvp.Columns("Fecha de factura").ReadOnly = True
            dtgvp.Columns("Fecha de pago").ReadOnly = True
            '  dtgvp.Columns("Nueva Cantidad").ReadOnly = True
            dtgvp.Columns("Subtotal").ReadOnly = True
            dtgvp.Columns("Total").ReadOnly = True
            ' dtgvp.Columns("Precio").ReadOnly = True
            'dtgvp.Columns(14).ReadOnly = True
            'dtgvp.Columns(15).ReadOnly = True
            'dtgvp.Columns(30).ReadOnly = True


            dtgvp.Columns("id_cotizacion").Visible = False
            dtgvp.Columns("Codigo").Visible = False
            dtgvp.Columns("Edo_prov").Visible = False
            'dtgvp.Columns("id_prov").Visible = False
            'dtgvp.Columns("id_cotizacion").Visible = False
            'dtgvp.Columns("id_pomov").Visible = False
            'dtgvp.Columns("id_provmov").Visible = False
            'dtgvp.Columns("id_movalamacen").Visible = False
            'dtgvp.Columns("t").Visible = False
            'dtgvp.Columns("uuid").Visible = False


            'dtgvp.Columns("Cancelado").Visible = False
            'dtgvp.Columns("Modificado").Visible = False
            'dtgvp.Columns("Tipo").Visible = False
            'dtgvp.Columns("Fecha recepcion").Visible = False
            'dtgvp.Columns("CantidadrecibidaPO").Visible = False
            'dtgvp.Columns("Departamento").Visible = False
            'dtgvp.Columns("Edo_prov").Visible = False
            'dtgvp.Columns("CantidadfacturadaPO").Visible = False
            'dtgvp.Columns("CantidadPendientePO").Visible = False


            cnn.Close()

            dtgvp.Visible = True
            'btn_desma.Visible = True
            'btn_selec.Visible = True
            ''btn_cargar.Visible = True
            'btn_calcular.Visible = True

            'Panel1.Visible = True
            'Panel2.Visible = True
            '  Panel5.Visible = True
            'predictivo()
            'txt_busca.Focus()

            If dtgvp.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")
                dtgvp.Visible = False
                'lbl_po.Text = ""


                'lbl_proveedor.Text = ""

                'txt_no.Text = ""
                'btn_selec.Visible = False
                'btn_desma.Visible = False
                'btn_cargar.Visible = False
                'btn_calcular.Visible = False
                'Panel1.Visible = False
                'Panel2.Visible = False
                '  Panel5.Visible = False

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


End Class