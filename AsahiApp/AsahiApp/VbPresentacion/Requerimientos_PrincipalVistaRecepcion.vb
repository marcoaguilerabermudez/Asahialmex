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

        Try
            dtgvp.Columns.Remove("X")
            dtgvp.Columns.Remove("Totals")
            dtgvp.Columns.Remove("Totalx")
        Catch ex As Exception

        End Try


        Try



            cnn.Close()

            cnn.Open()

            Dim da As New SqlDataAdapter("Sp_muestrarecepcion", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@codigo", PO)

            da.SelectCommand.Parameters.AddWithValue("@serie", Serie)



            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns(7).Width = 65
            dtgvp.Columns(8).Width = 300
            dtgvp.Columns(9).Width = 100
            dtgvp.Columns("Departamento").Width = 100

            dtgvp.Columns(11).Width = 60
            dtgvp.Columns(12).Width = 60
            dtgvp.Columns(13).Width = 60
            dtgvp.Columns(30).Width = 60
            dtgvp.Columns(31).Width = 60
            dtgvp.Columns(32).Width = 60
            dtgvp.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            dtgvp.Columns(7).ReadOnly = True
            dtgvp.Columns(8).ReadOnly = True
            dtgvp.Columns(9).ReadOnly = True
            dtgvp.Columns(10).ReadOnly = True
            dtgvp.Columns(11).ReadOnly = True
            dtgvp.Columns(30).ReadOnly = True
            dtgvp.Columns("Departamento").ReadOnly = True
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
            dtgvp.Columns("id_mov").Visible = False
            dtgvp.Columns("id_po").Visible = False




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


            'colores()
            'AgregarColumna()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


        colores()

    End Sub

End Class