Imports System.Data.SqlClient

Public Class Requerimientos_crear
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
    Dim Repetido As Boolean

    Dim Codigo_p As String
    Dim nombre_p As String
    Dim proveedor_p As String
    Dim precio_p As Double
    Dim cantidad_p As Double
    Dim a As String
    Dim y As Integer
    Dim z As String




    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub




    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        NumerosyDecimal(txt_cantidad, e)
        '  NumerosyDecimal(txt_precio, e)
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress

        NumerosyDecimal(txt_precio, e)
    End Sub


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Requerimientos_crear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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





        a = depto

        Select Case a
            Case "03"
                cbx_area.Text = "ASEGURAMIENTO DE CALIDAD F1"
            Case "04"
                cbx_area.Text = "ASUNTOS GENERALES"
            Case "05"
                cbx_area.Text = "ATENCIÓN AL CLIENTE"
            Case "06"
                cbx_area.Text = "COMPRAS"
            Case "07"
                cbx_area.Text = "CONTABILIDAD"
            Case "08"
                cbx_area.Text = "CONTROL DE MANUFACTURA"
            Case "09"
                cbx_area.Text = "CONTROL DE PRODUCCION"
            Case "16"
                cbx_area.Text = "MOLDES"
            Case "18"
                cbx_area.Text = "SEGURIDAD"
            Case "19"
                cbx_area.Text = "SISTEMAS IT"
            Case "27"
                cbx_area.Text = "INGENIERÍA MAQUINADO"
            Case "28"
                cbx_area.Text = "INGENIERÍA FUNDICIÓN"
            Case "31"
                cbx_area.Text = "INSPECCION PRODUCCION"
            Case "32"
                cbx_area.Text = "FUNDICION 1"
            Case "33"
                cbx_area.Text = "FUNDICION 2"
            Case "34"
                cbx_area.Text = "ACABADO"
            Case "35"
                cbx_area.Text = "ACABADO 2"
            Case "36"
                cbx_area.Text = "CONTROL DE CLIENTES"
            Case "37"
                cbx_area.Text = "MANTENIMIENTO DE PLANTA"
            Case "38"
                cbx_area.Text = "MANTENIMIENTO FUNDICION"
            Case "39"
                cbx_area.Text = "MANTENIMIENTO MAQUINADO"
            Case "40"
                cbx_area.Text = "MAQUINADO F2"
            Case "41"
                cbx_area.Text = "INSPECCIÓN FUNDICION"
            Case "42"
                cbx_area.Text = "INSPECCIÓN MAQUINADO"
            Case "43"
                cbx_area.Text = "MANTENIMIENTO FUNDICION"
            Case "44"
                cbx_area.Text = "FUSION"
            Case "46"
                cbx_area.Text = "ASEGURAMIENTO DE CALIDAD F2"
            Case "47"
                cbx_area.Text = "REPARACION DE MOLDES"
            Case "48"
                cbx_area.Text = "PRODUCCIÓN"
        End Select




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
        dtgvp.Columns(1).Width = 350
        dtgvp.Columns(0).ReadOnly = True
        dtgvp.Columns(1).ReadOnly = True
        cnn.Close()

    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_código.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then

            If txt_código.Text = "" Then
                MessageBox.Show("Debe escribir palabras clave", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dtgvp.Visible = True
                Panel1.Visible = True
                cargagridmuestraproducto()
                btn_doc.Visible = True
                btn_selec.Visible = True
                txt_comentarios.Visible = True
                Label12.Visible = True
            End If




        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_código.Clear()
            dtgvp.Visible = False
            Panel1.Visible = False
            btn_doc.Visible = False
            btn_selec.Visible = False
            txt_comentarios.Visible = False
            Label12.Visible = False
            ''  cargagridmuestraproducto()

        End If


    End Sub


    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick

        lbl_codigo.Text = Me.dtgvp.Rows(e.RowIndex).Cells(0).Value.ToString()
        lbl_producto.Text = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
        Lbl_numpart.Text = Me.dtgvp.Rows(e.RowIndex).Cells(2).Value.ToString()
        lbl_umed_com.Text = Me.dtgvp.Rows(e.RowIndex).Cells(3).Value.ToString()
        lbl_umed_con.Text = Me.dtgvp.Rows(e.RowIndex).Cells(4).Value.ToString()
        lbl_familia.Text = Me.dtgvp.Rows(e.RowIndex).Cells(5).Value.ToString()
        txt_precio.Text = Me.dtgvp.Rows(e.RowIndex).Cells(8).Value.ToString()

        txt_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells(10).Value.ToString()



    End Sub

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        lbl_codigo.Text = Me.dtgvp.Rows(e.RowIndex).Cells(0).Value.ToString()
        lbl_producto.Text = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
        Lbl_numpart.Text = Me.dtgvp.Rows(e.RowIndex).Cells(2).Value.ToString()
        lbl_umed_com.Text = Me.dtgvp.Rows(e.RowIndex).Cells(3).Value.ToString()
        lbl_umed_con.Text = Me.dtgvp.Rows(e.RowIndex).Cells(4).Value.ToString()
        lbl_familia.Text = Me.dtgvp.Rows(e.RowIndex).Cells(5).Value.ToString()
        txt_precio.Text = Me.dtgvp.Rows(e.RowIndex).Cells(8).Value.ToString()

        txt_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells(10).Value.ToString()
    End Sub


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

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

                dtgv_2.Visible = True
                Repetido = False
                Codigo_p = lbl_codigo.Text
                nombre_p = lbl_producto.Text
                proveedor_p = txt_proveedor.Text
                cantidad_p = txt_cantidad.Text
                precio_p = txt_precio.Text


                'For index = 0 To dtgv_2.RowCount - 1
                '    If dtgv_2.Rows(index).Cells(0).Value = Codigo_p Then
                '        Repetido = True
                '    End If
                'Next


                'If Repetido = False Then
                dtgv_2.Rows.Add(Codigo_p, Codigo_p + " " + nombre_p, cantidad_p, precio_p, proveedor_p, a, dtp1.Value.ToShortDateString, txt_descr.Text)
                    txt_cantidad.Text = 0
                    'Else

                    '    MessageBox.Show("El producto ya está agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'End If

                End If

        End If

    End Sub

    Private Sub dtgv_2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_2.CellContentClick
        If sender.Columns(e.ColumnIndex).HeaderText = "Quitar" Then

            Try
                dtgv_2.Rows.Remove(dtgv_2.CurrentRow)
            Catch
            End Try
        End If
    End Sub

    Private Sub cbx_area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_area.SelectedIndexChanged
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



    Sub crearvale()
        cnn.Close()
        cnn.Open()
        Dim agrega As SqlCommand = New SqlCommand("  
declare @FolioVale as integer
set @FolioVale = (select top 1 Id_requerimientoP from [Asahi].[dbo].[Com_RequerimientoPrincipal] order by Id_requerimientoP desc) + 1

insert into [Asahi].[dbo].[Com_RequerimientoPrincipal] values
(@id, @depto, getdate(), @comentarios, 0, @documento)
", cnn)


        Try

            agrega.Parameters.Clear()

            agrega.Parameters.Add("@id", SqlDbType.Int).Value = id
            agrega.Parameters.Add("@depto", SqlDbType.Int).Value = depto




            agrega.Parameters.Add("@documento", SqlDbType.NVarChar, (300)).Value = txt_liga.Text
            agrega.Parameters.Add("@comentarios", SqlDbType.NVarChar, (99)).Value = txt_comentarios.Text



            agrega.ExecuteNonQuery()





        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()

            'cargagrid()
        Finally
            cnn.Close()
        End Try


    End Sub



    Sub insertarfilas()


        Dim comando As SqlCommand = New SqlCommand
        comando.CommandText = " select top 1 Id_requerimientoP FROM [Asahi].[dbo].[Com_RequerimientoPrincipal] order by Id_requerimientoP desc"
        comando.Connection = cnn
        cnn.Close()
        cnn.Open()

        y = comando.ExecuteScalar()

        cnn.Close()





        cnn.Close()


        Dim command As New SqlCommand("Sp_InsertaMovimientoRequerimiento", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try

            For Each fila In dtgv_2.Rows


                command.Parameters.Clear()


                command.Parameters.AddWithValue("@cantidad", (fila.Cells("Cantidad").Value))

                command.Parameters.AddWithValue("@codigo", (fila.Cells("c_1").Value))
                command.Parameters.AddWithValue("@precio", (fila.Cells("Precio").Value))
                command.Parameters.AddWithValue("@proveedor", (fila.Cells("Proveedor").Value))
                command.Parameters.AddWithValue("@area", (fila.Cells("area").Value))
                command.Parameters.AddWithValue("@fecha", (fila.Cells("fecha").Value))
                command.Parameters.AddWithValue("@comentarios", (fila.Cells("comentario").Value))



                command.ExecuteNonQuery()

            Next


            txt_código.Clear()
            Panel1.Visible = False
            dtgv_2.Visible = False
            dtgv_2.Rows.Clear()
            dtgvp.Visible = False
            dtgvp.Columns.Clear()
            txt_cantidad.Text = 0
            btn_doc.Visible = False
            btn_selec.Visible = False
            txt_comentarios.Clear()
            txt_comentarios.Visible = False
            Label12.Visible = False

            MessageBox.Show("Requerimiento creado con el folio: " & y & "", "¡Correcto!", MessageBoxButtons.OK)





        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try




    End Sub

    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click


        If dtgv_2.RowCount > 0 Then


            Dim Pregunta As Integer


            Pregunta = MsgBox("¿Desea cerrar su requerimiento con los items que ha registrado?", vbYesNo + vbExclamation + vbDefaultButton2, "Requerimiento")


            If Pregunta = vbYes Then


                crearvale()
                insertarfilas()


            Else
                MessageBox.Show("Acción no completada", "Requerimiento")
            End If

        ElseIf dtgv_2.RowCount < 1 Then
            MessageBox.Show("¡Debe agregar lineas para terminar su requerimiento!", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_doc.Click
        Dim folder As New OpenFileDialog
        Dim result As DialogResult = folder.ShowDialog()

        If result = DialogResult.OK Then

            txt_liga.Text = folder.FileName
        Else
            MessageBox.Show("Salió sin guardar ningún documento", "¡Aviso!")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Requerimientos_Comentarios.Show()
    End Sub
End Class