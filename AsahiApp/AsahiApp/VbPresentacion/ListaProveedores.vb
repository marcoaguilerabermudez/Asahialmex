Imports System.Data.SqlClient

Public Class ListaProveedores

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
    Dim id_proveedor As Integer
    Dim fe As Date

    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub ListaProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_código.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then

            If txt_código.Text = "" Then
                MessageBox.Show("Debe escribir palabras clave", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dtgvp.Visible = True
                Panel1.Visible = True
                cargagridmuestraproveedor()

            End If




        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_código.Clear()
            dtgvp.Visible = False
            Panel1.Visible = False
            ''  cargagridmuestraproducto()

        End If


    End Sub


    Sub cargagridmuestraproveedor()

        cnn.Close()

        cnn.Open()

        Dim da As New SqlDataAdapter("Sp_MuestraListaProveedor", cnn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        ' da.SelectCommand.Parameters.AddWithValue("@tipo", var_filtro)
        da.SelectCommand.Parameters.AddWithValue("@variable", 0)
        da.SelectCommand.Parameters.AddWithValue("@proveedor", txt_código.Text)
        da.SelectCommand.Parameters.AddWithValue("@id_prov", 0)



        Dim dt As New DataTable
        da.Fill(dt)
        dtgvp.DataSource = dt
        dtgvp.Columns("id").Visible = False
        dtgvp.Columns("Nombre_proveedor").Visible = False
        dtgvp.Columns("RFC").Visible = False
        dtgvp.Columns("curp").Visible = False
        dtgvp.Columns("Credito").Visible = False

        dtgvp.Columns("nacionalidad").Visible = False
        dtgvp.Columns("evaluacion").Visible = False
        dtgvp.Columns("fecha_alta").Visible = False
        dtgvp.Columns("tel_1").Visible = False
        dtgvp.Columns("tel_2").Visible = False

        dtgvp.Columns("email").Visible = False
        dtgvp.Columns("pais").Visible = False
        dtgvp.Columns("cp").Visible = False
        dtgvp.Columns("estado").Visible = False
        dtgvp.Columns("municipio").Visible = False

        dtgvp.Columns("colonia").Visible = False
        dtgvp.Columns("calle").Visible = False
        dtgvp.Columns("num").Visible = False
        dtgvp.Columns("num_int").Visible = False
        dtgvp.Columns("nombre_cont").Visible = False

        dtgvp.Columns("apellido").Visible = False
        dtgvp.Columns("rol").Visible = False
        dtgvp.Columns("detalle").Visible = False
        dtgvp.Columns("mail_contacto").Visible = False
        dtgvp.Columns("tel1_c").Visible = False
        dtgvp.Columns("tel2_c").Visible = False

        dtgvp.Columns("Razón social").ReadOnly = True
        dtgvp.Columns("Razón social").Width = 420
        cnn.Close()

    End Sub


    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick
        Try

            id_proveedor = Me.dtgvp.Rows(e.RowIndex).Cells("id").Value.ToString()
            lbl_nom.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Nombre_proveedor").Value.ToString()
            lbl_razonsocial.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Razón social").Value.ToString()
            lbl_rfc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("RFC").Value.ToString()
            lbl_curp.Text = Me.dtgvp.Rows(e.RowIndex).Cells("curp").Value.ToString()
            lbl_credito.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Credito").Value.ToString()
            lbl_correo.Text = Me.dtgvp.Rows(e.RowIndex).Cells("email").Value.ToString()
            lbl_tel1.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tel_1").Value.ToString()
            lbl_tel2.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tel_2").Value.ToString()
            lbl_evaluacion.Text = Me.dtgvp.Rows(e.RowIndex).Cells("evaluacion").Value.ToString()
            fe = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_alta").Value.ToString()
            lbl_alta.Text = fe.ToString("dd/MM/yyyy")


        Catch

        End Try

    End Sub







    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        Try
            id_proveedor = Me.dtgvp.Rows(e.RowIndex).Cells("id").Value.ToString()
            lbl_nom.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Nombre_proveedor").Value.ToString()
            lbl_razonsocial.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Razón social").Value.ToString()
            lbl_rfc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("RFC").Value.ToString()
            lbl_curp.Text = Me.dtgvp.Rows(e.RowIndex).Cells("curp").Value.ToString()
            lbl_credito.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Credito").Value.ToString()
            lbl_correo.Text = Me.dtgvp.Rows(e.RowIndex).Cells("email").Value.ToString()
            lbl_tel1.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tel_1").Value.ToString()
            lbl_tel2.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tel_2").Value.ToString()
            lbl_evaluacion.Text = Me.dtgvp.Rows(e.RowIndex).Cells("evaluacion").Value.ToString()
            fe = Me.dtgvp.Rows(e.RowIndex).Cells("fecha_alta").Value.ToString()
            lbl_alta.Text = fe.ToString("dd/MM/yyyy")

        Catch
        End Try


    End Sub



    Private Sub dtgvp_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick





        If depto = "19" Or depto = "06" Then

            Modulo_modificaproveedor.e_id = Me.dtgvp.Rows(e.RowIndex).Cells("id").Value.ToString()




            Dim Alta_pro As New Alta_proveedores(id, depto, permiso, nombre, 1)
            Alta_pro.Show()
            txt_código.Clear()
            dtgvp.Visible = False
            Panel1.Visible = False


        End If



    End Sub

End Class


Module Modulo_modificaproveedor

    Public e_id As Integer
    Public e_var As Integer




End Module