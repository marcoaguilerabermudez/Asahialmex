Imports System.Data.SqlClient

Public Class Alta_productos
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
    Dim y As String



    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Alta_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If p_vales = 0 Then
            lbl_código.Visible = False

            btn_solicitar.Text = "Crear"
            Me.Text = "Alta de productos"

            cbx_ualmacen.Text = "N/A"
            cbx_pasillo.Text = "N/A"
            cbx_anaquel.Text = "N/A"
            cbx_nivel.Text = "N/A"

        ElseIf p_vales = 1 Then
            lbl_código.Visible = True
            btn_solicitar.Text = "Modificar"
            Me.Text = "Modificar productos"
            txt_descr.Focus()

            cbx_fam.DropDownStyle = ComboBoxStyle.DropDown
            cbx_ucompra.DropDownStyle = ComboBoxStyle.DropDown
            cbx_uconsumo.DropDownStyle = ComboBoxStyle.DropDown
            cbx_inventario.DropDownStyle = ComboBoxStyle.DropDown
            cbx_ualmacen.DropDownStyle = ComboBoxStyle.DropDown
            cbx_pasillo.DropDownStyle = ComboBoxStyle.DropDown
            cbx_anaquel.DropDownStyle = ComboBoxStyle.DropDown
            cbx_nivel.DropDownStyle = ComboBoxStyle.DropDown




            txt_nombre.Text = Modulo_modificaproducto.e_nombre
            lbl_código.Text = Modulo_modificaproducto.e_codigo
            txt_numeroparte.Text = Modulo_modificaproducto.e_numpart
            cbx_fam.Text = Modulo_modificaproducto.e_familia
            cbx_ucompra.Text = Modulo_modificaproducto.e_medm
            cbx_uconsumo.Text = Modulo_modificaproducto.e_medn
            cbx_inventario.Text = Modulo_modificaproducto.e_inventario
            txt_descr.Text = Modulo_modificaproducto.e_descripcion


            cbx_ualmacen.Text = Modulo_modificaproducto.e_almacen
            cbx_pasillo.Text = Modulo_modificaproducto.e_pasillo
            cbx_anaquel.Text = Modulo_modificaproducto.e_anaquel
            cbx_nivel.Text = Modulo_modificaproducto.e_nivel




            cbx_fam.DropDownStyle = ComboBoxStyle.DropDownList
            cbx_ucompra.DropDownStyle = ComboBoxStyle.DropDownList
            cbx_uconsumo.DropDownStyle = ComboBoxStyle.DropDownList
            cbx_inventario.DropDownStyle = ComboBoxStyle.DropDownList
            cbx_ualmacen.DropDownStyle = ComboBoxStyle.DropDownList
            cbx_pasillo.DropDownStyle = ComboBoxStyle.DropDownList
            cbx_anaquel.DropDownStyle = ComboBoxStyle.DropDownList
            cbx_nivel.DropDownStyle = ComboBoxStyle.DropDownList



        End If


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



    Sub insertarproducto()






        cnn.Close()


        Dim command As New SqlCommand("Sp_InsertaActualizaProducto", cnn)
        cnn.Open()

        command.CommandType = CommandType.StoredProcedure

        Try




            command.Parameters.Clear()

            command.Parameters.AddWithValue("@nombre", txt_nombre.Text)
            command.Parameters.AddWithValue("@noparte", txt_numeroparte.Text)
            command.Parameters.AddWithValue("@descripcion", txt_descr.Text)
            command.Parameters.AddWithValue("@ucompra", cbx_ucompra.Text)
            command.Parameters.AddWithValue("@usurtido", cbx_uconsumo.Text)
            command.Parameters.AddWithValue("@inventario", cbx_inventario.Text)
            command.Parameters.AddWithValue("@familia", cbx_fam.Text)
            command.Parameters.AddWithValue("@almacen", cbx_ualmacen.Text)
            command.Parameters.AddWithValue("@pasillo", cbx_pasillo.Text)
            command.Parameters.AddWithValue("@anaquel", cbx_anaquel.Text)
            command.Parameters.AddWithValue("@nivel", cbx_nivel.Text)
            command.Parameters.AddWithValue("@tipo", p_vales)
            command.Parameters.AddWithValue("@usuario", id)
            If p_vales = 0 Then
                command.Parameters.AddWithValue("@codigo", "xxxx")
            ElseIf p_vales = 1 Then
                command.Parameters.AddWithValue("@codigo", lbl_código.Text)
            End If





            command.ExecuteNonQuery()

            Dim comando As SqlCommand = New SqlCommand
            comando.CommandText = " SELECT (concat('COAL', RIGHT('00000' + Ltrim(Rtrim((select top 1 convert(int,substring(codigo,5,20)) from [Asahi].[dbo].[Com_productos] order by convert(int,substring(codigo,5,20)) desc))),5)))"
            comando.Connection = cnn
            cnn.Close()
            cnn.Open()

            y = comando.ExecuteScalar()

            cnn.Close()



            If p_vales = 0 Then
                MessageBox.Show("Producto creado con el código: " & y & "", "¡Correcto!", MessageBoxButtons.OK)
                txt_nombre.Clear()
                txt_numeroparte.Clear()
                txt_descr.Clear()
                cbx_ucompra.Text = ""
                cbx_uconsumo.Text = ""
                cbx_inventario.Text = ""
                cbx_fam.Text = ""
                cbx_ualmacen.Text = "N/A"
                cbx_pasillo.Text = "N/A"
                cbx_anaquel.Text = "N/A"
                cbx_nivel.Text = "N/A"



            ElseIf p_vales = 1 Then
                MessageBox.Show("Código: " & lbl_código.Text & " modificado correctamente.", "¡Correcto!", MessageBoxButtons.OK)
                Me.Close()

            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try


    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        insertarproducto()
    End Sub

    Private Sub cbx_ucompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ucompra.SelectedIndexChanged
        cbx_uconsumo.Text = cbx_ucompra.Text
    End Sub



End Class