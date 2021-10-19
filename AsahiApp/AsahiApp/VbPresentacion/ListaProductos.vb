Imports System.Data.SqlClient

Public Class ListaProductos
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
    Dim a As Boolean


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub


    Private Sub ListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        var_filtro = 0
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


    Private Sub rbt_falta_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_falta.CheckedChanged
        var_filtro = 0
        lbl_txtfiltro.Text = "Código / Nombre"
    End Sub

    Private Sub rbt_retardo_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_retardo.CheckedChanged
        var_filtro = 1
        lbl_txtfiltro.Text = "Familia"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        var_filtro = 2
        lbl_txtfiltro.Text = "Número de parte"
    End Sub


    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_código.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then

            If txt_código.Text = "" Then
                MessageBox.Show("Debe escribir palabras clave", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dtgvp.Visible = True
                Panel1.Visible = True
                cargagridmuestraproducto()

            End If




        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_código.Clear()
            dtgvp.Visible = False
            Panel1.Visible = False
            ''  cargagridmuestraproducto()

        End If


    End Sub


    Sub cargagridmuestraproducto()

        cnn.Close()

        cnn.Open()

        Dim da As New SqlDataAdapter("Sp_muestralistaproductos", cnn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@tipo", var_filtro)
        da.SelectCommand.Parameters.AddWithValue("@variable", txt_código.Text)



        Dim dt As New DataTable
        da.Fill(dt)
        dtgvp.DataSource = dt
        dtgvp.Columns("No_Parte").Visible = False
        dtgvp.Columns("n1").Visible = False
        dtgvp.Columns("n2").Visible = False
        dtgvp.Columns("n3").Visible = False
        dtgvp.Columns("art_inv").Visible = False
        dtgvp.Columns(7).Visible = False
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
        dtgvp.Columns(1).Width = 400
        dtgvp.Columns(0).ReadOnly = True
        dtgvp.Columns(1).ReadOnly = True
        cnn.Close()




    End Sub

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick
        Try

            lbl_cod.Text = Me.dtgvp.Rows(e.RowIndex).Cells(0).Value.ToString()
            lbl_nom.Text = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
            Lbl_numpart.Text = Me.dtgvp.Rows(e.RowIndex).Cells(2).Value.ToString()
            lbl_umed_com.Text = Me.dtgvp.Rows(e.RowIndex).Cells(3).Value.ToString()
            lbl_umed_con.Text = Me.dtgvp.Rows(e.RowIndex).Cells(4).Value.ToString()
            lbl_fam.Text = Me.dtgvp.Rows(e.RowIndex).Cells(5).Value.ToString()
            lbl_inv.Text = Me.dtgvp.Rows(e.RowIndex).Cells(6).Value.ToString()
            a = Me.dtgvp.Rows(e.RowIndex).Cells(7).Value.ToString()
            lbl_ulpred.Text = Me.dtgvp.Rows(e.RowIndex).Cells(8).Value.ToString()
            Dim fe As Date
            fe = Me.dtgvp.Rows(e.RowIndex).Cells(9).Value.ToString()
            lbl_ulfec.Text = fe.ToString("dd/MM/yyyy")

            '.Text = Me.dtgvp.Rows(e.RowIndex).Cells(9).Value.ToString()
            lbl_ulpro.Text = Me.dtgvp.Rows(e.RowIndex).Cells(10).Value.ToString()
            lbl_ulsol.Text = Me.dtgvp.Rows(e.RowIndex).Cells(11).Value.ToString()
            lbl_almacen.Text = Me.dtgvp.Rows(e.RowIndex).Cells(12).Value.ToString()


            lbl_almacen.Text = Me.dtgvp.Rows(e.RowIndex).Cells(14).Value.ToString()
            lbl_pasillo.Text = Me.dtgvp.Rows(e.RowIndex).Cells(15).Value.ToString()
            lbl_anaquel.Text = Me.dtgvp.Rows(e.RowIndex).Cells(16).Value.ToString()
            lbl_nivel.Text = Me.dtgvp.Rows(e.RowIndex).Cells(17).Value.ToString()

        Catch

        End Try

    End Sub







    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        Try
            lbl_cod.Text = Me.dtgvp.Rows(e.RowIndex).Cells(0).Value.ToString()
            lbl_nom.Text = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
            Lbl_numpart.Text = Me.dtgvp.Rows(e.RowIndex).Cells(2).Value.ToString()
            lbl_umed_com.Text = Me.dtgvp.Rows(e.RowIndex).Cells(3).Value.ToString()
            lbl_umed_con.Text = Me.dtgvp.Rows(e.RowIndex).Cells(4).Value.ToString()
            lbl_fam.Text = Me.dtgvp.Rows(e.RowIndex).Cells(5).Value.ToString()
            lbl_inv.Text = Me.dtgvp.Rows(e.RowIndex).Cells(6).Value.ToString()
            a = Me.dtgvp.Rows(e.RowIndex).Cells(7).Value.ToString()
            lbl_ulpred.Text = Me.dtgvp.Rows(e.RowIndex).Cells(8).Value.ToString()
            Dim fe As Date
            fe = Me.dtgvp.Rows(e.RowIndex).Cells(9).Value.ToString()
            lbl_ulfec.Text = fe.ToString("dd/MM/yyyy")
            lbl_ulpro.Text = Me.dtgvp.Rows(e.RowIndex).Cells(10).Value.ToString()
            lbl_ulsol.Text = Me.dtgvp.Rows(e.RowIndex).Cells(11).Value.ToString()
            lbl_almacen.Text = Me.dtgvp.Rows(e.RowIndex).Cells(12).Value.ToString()

            lbl_almacen.Text = Me.dtgvp.Rows(e.RowIndex).Cells(14).Value.ToString()
            lbl_pasillo.Text = Me.dtgvp.Rows(e.RowIndex).Cells(15).Value.ToString()
            lbl_anaquel.Text = Me.dtgvp.Rows(e.RowIndex).Cells(16).Value.ToString()
            lbl_nivel.Text = Me.dtgvp.Rows(e.RowIndex).Cells(17).Value.ToString()

        Catch
        End Try


    End Sub


    Private Sub dtgvp_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick





        If depto = "19" Or depto = "06" Then

            Modulo_modificaproducto.e_codigo = Me.dtgvp.Rows(e.RowIndex).Cells(0).Value.ToString()
            Modulo_modificaproducto.e_nombre = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
            Modulo_modificaproducto.e_numpart = Me.dtgvp.Rows(e.RowIndex).Cells(2).Value.ToString()
            Modulo_modificaproducto.e_medm = Me.dtgvp.Rows(e.RowIndex).Cells(3).Value.ToString()
            Modulo_modificaproducto.e_medn = Me.dtgvp.Rows(e.RowIndex).Cells(4).Value.ToString()
            Modulo_modificaproducto.e_familia = Me.dtgvp.Rows(e.RowIndex).Cells(5).Value.ToString()
            Modulo_modificaproducto.e_inventario = Me.dtgvp.Rows(e.RowIndex).Cells(6).Value.ToString()
            Modulo_modificaproducto.e_descripcion = Me.dtgvp.Rows(e.RowIndex).Cells(13).Value.ToString()


            Modulo_modificaproducto.e_almacen = Me.dtgvp.Rows(e.RowIndex).Cells(14).Value.ToString()
            Modulo_modificaproducto.e_pasillo = Me.dtgvp.Rows(e.RowIndex).Cells(15).Value.ToString()
            Modulo_modificaproducto.e_anaquel = Me.dtgvp.Rows(e.RowIndex).Cells(16).Value.ToString()
            Modulo_modificaproducto.e_nivel = Me.dtgvp.Rows(e.RowIndex).Cells(17).Value.ToString()




            Dim Alta_pro As New Alta_productos(id, depto, permiso, nombre, 1)
            Alta_pro.Show()
            txt_código.Clear()
            dtgvp.Visible = False
            Panel1.Visible = False


        End If



    End Sub

End Class


Module Modulo_modificaproducto

    Public e_codigo As String
    Public e_nombre As String
    Public e_numpart As String
    Public e_medm As String
    Public e_medn As String
    Public e_familia As String
    Public e_inventario As String
    Public e_descripcion As String

    Public e_almacen As String
    Public e_pasillo As String
    Public e_anaquel As String
    Public e_nivel As String



End Module
