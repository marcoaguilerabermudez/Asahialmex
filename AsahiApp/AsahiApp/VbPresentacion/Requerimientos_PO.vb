Imports System.Data.SqlClient

Public Class Requerimientos_PO


    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String
    Dim id_proveedor As Integer
    Dim id_moneada As Integer

    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer

    Dim indice1 As Integer = 100
    Dim fecha_recep(indice1) As String
    Dim fecha_solicitud(indice1) As String
    Dim top_fecharecep As String
    Dim top_fechasolicitud As String
    Dim y As Integer


    Private Sub Requerimientos_PO_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

        llenacomboproveedor()

        AgregarColumna()

        'cargagrid()
        'agregarcolumna2()
        id_moneada = 0
        tc()
    End Sub


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub



    Sub tc()

        Try
            Dim Dt As DataTable

            Dim Da As New SqlDataAdapter
            Dim Cmd As New SqlCommand


            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "



SELECT TOP 1 [id]
      ,[fecha]
      ,[moneda]
      ,[tc]
  FROM [Asahi].[dbo].[com_tc]
  where moneda = 2

 
"
                .Connection = cnn
            End With

            Da.SelectCommand = Cmd
            Dt = New DataTable
            Da.Fill(Dt)


            Dim ds As New DataSet
            Da.Fill(ds)

            lbl_usd.Text = ds.Tables(0).Rows(0).Item(3)



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub



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

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress, txt_precio.KeyPress, txt_iva.KeyPress, txt_iesp.KeyPress, txt_isr.KeyPress, txt_impex.KeyPress, txt_retiva.KeyPress, txt_retcel.KeyPress, txt_retisr.KeyPress, txt_retex.KeyPress, txt_desc1.KeyPress, txt_desc2.KeyPress
        NumerosyDecimal(txt_cantidad, e)
        NumerosyDecimal(txt_precio, e)
        NumerosyDecimal(txt_iva, e)
        NumerosyDecimal(txt_iesp, e)
        NumerosyDecimal(txt_isr, e)
        NumerosyDecimal(txt_impex, e)
        NumerosyDecimal(txt_retiva, e)
        NumerosyDecimal(txt_retcel, e)
        NumerosyDecimal(txt_retisr, e)
        NumerosyDecimal(txt_retex, e)
        NumerosyDecimal(txt_desc1, e)
        NumerosyDecimal(txt_desc2, e)

    End Sub


    Private Sub txt_cantidad_TextChanged(sender As Object, e As EventArgs) Handles txt_cantidad.TextChanged, txt_precio.TextChanged, txt_iva.TextChanged, txt_iesp.TextChanged, txt_isr.TextChanged, txt_impex.TextChanged, txt_retiva.TextChanged, txt_retcel.TextChanged, txt_retisr.TextChanged, txt_retex.TextChanged, txt_desc1.TextChanged, txt_desc2.TextChanged

        Try
            txt_subtotal.Text = Format(CType(txt_precio.Text * txt_cantidad.Text, Decimal), "#,##0.00")

            txt_total.Text = Format(CType((CDbl(txt_subtotal.Text) + (CDbl(txt_iva.Text) + CDbl(txt_iesp.Text) + CDbl(txt_isr.Text) + CDbl(txt_impex.Text)) - (CDbl(txt_retiva.Text) + CDbl(txt_retcel.Text) + CDbl(txt_retisr.Text) + CDbl(txt_retex.Text) + CDbl(txt_desc1.Text) + CDbl(txt_desc2.Text))), Decimal), "#,##0.00")
        Catch
        End Try


    End Sub


    Sub AgregarColumna()
        Dim cbox As New DataGridViewCheckBoxColumn
        dtgvp.Columns.Insert(dtgvp.ColumnCount, cbox)
        With cbox
            .HeaderText = "x"
            .Name = "x"
            .Width = 20
        End With
    End Sub


    Sub llenacomboproveedor()




        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        Dim parametro1 As String
        parametro1 = cbx_proveedor.Text

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	
 SELECT distinct razon_social
 FROM 
 [Asahi].[dbo].[com_proveedores] prov
 join [Asahi].[dbo].[Com_RequerimientoMovimiento] movi
  on prov.id = movi.Id_proveedor
  where movi.estado = 4
"
            .Connection = cnn
        End With

        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)



        With cbx_proveedor
            .DataSource = Dt
            .DisplayMember = "razon_social"

        End With



    End Sub

    Sub llenacuentas()


        Try
            Dim Dt As DataTable

            Dim Da As New SqlDataAdapter
            Dim Cmd As New SqlCommand


            With Cmd
                .CommandType = CommandType.Text
                .CommandText = "




SELECT PROV.ID, razon_social , ltrim(rtrim(valor)), ltrim(rtrim(cuenta)), ltrim(rtrim(clabe)), moneda, correo
  FROM [Asahi].[dbo].[com_proveedores] prov
 left join [Asahi].[dbo].[com_pv_bancos] pv_ban
  on pv_ban.id_prov = prov.id
 left join [Asahi].[dbo].[cat_Bancos] cat_ban
 on cat_ban.id = pv_ban.id_banco
 where prov.razon_social = '" & cbx_proveedor.Text & "' and moneda = " & id_moneada & "

 
"
                .Connection = cnn
            End With

            Da.SelectCommand = Cmd
            Dt = New DataTable
            Da.Fill(Dt)


            Dim ds As New DataSet
            Da.Fill(ds)

            cbx_banco.Text = ds.Tables(0).Rows(0).Item(2)
            cbx_cuenta.Text = ds.Tables(0).Rows(0).Item(3)
            cbx_clabe.Text = ds.Tables(0).Rows(0).Item(4)
            txt_correo.Text = ds.Tables(0).Rows(0).Item(6)
            id_proveedor = ds.Tables(0).Rows(0).Item(0)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Sub cargagrid()

        Try

            cnn.Close()

            cnn.Open()

            Dim da As New SqlDataAdapter("Sp_MuestraGridPO", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@id", id_proveedor)
            da.SelectCommand.Parameters.AddWithValue("@moneda", cbx_moneda.Text)




            Dim dt As New DataTable


            da.Fill(dt)
            dtgvp.DataSource = dt

            dtgvp.Columns(0).Width = 20
            dtgvp.Columns(1).Width = 45
            dtgvp.Columns(2).Width = 70
            dtgvp.Columns(3).Width = 370
            dtgvp.Columns(4).Width = 270
            dtgvp.Columns(1).ReadOnly = True
            dtgvp.Columns(2).ReadOnly = True
            dtgvp.Columns(3).ReadOnly = True
            dtgvp.Columns(4).ReadOnly = True


            dtgvp.Columns(12).Visible = False
            dtgvp.Columns(5).Visible = False
            dtgvp.Columns(6).Visible = False
            dtgvp.Columns(7).Visible = False
            dtgvp.Columns(8).Visible = False
            dtgvp.Columns(9).Visible = False
            dtgvp.Columns(10).Visible = False
            dtgvp.Columns(11).Visible = False
            dtgvp.Columns(13).Visible = False
            dtgvp.Columns(14).Visible = False
            dtgvp.Columns(15).Visible = False
            dtgvp.Columns(16).Visible = False
            dtgvp.Columns(17).Visible = False
            dtgvp.Columns(18).Visible = False
            dtgvp.Columns(19).Visible = False
            dtgvp.Columns(20).Visible = False
            dtgvp.Columns(21).Visible = False
            dtgvp.Columns(22).Visible = False
            dtgvp.Columns(23).Visible = False
            dtgvp.Columns(24).Visible = False
            dtgvp.Columns(25).Visible = False
            dtgvp.Columns(26).Visible = False


            cnn.Close()

        Catch
        End Try

    End Sub


    Private Sub dtgvp_CellContentClick0(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick

        Try
            cbx_fam.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Familia").Value.ToString()
            txt_iva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("imp_iva").Value.ToString()
            txt_iesp.Text = Me.dtgvp.Rows(e.RowIndex).Cells("imp_iesp").Value.ToString()
            txt_isr.Text = Me.dtgvp.Rows(e.RowIndex).Cells("imp_isr").Value.ToString()
            txt_impex.Text = Me.dtgvp.Rows(e.RowIndex).Cells("imp_ex").Value.ToString()
            txt_retiva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("ret_iva").Value.ToString()
            txt_retcel.Text = Me.dtgvp.Rows(e.RowIndex).Cells("ret_ced").Value.ToString()
            txt_retisr.Text = Me.dtgvp.Rows(e.RowIndex).Cells("ret_isr").Value.ToString()
            txt_retex.Text = Me.dtgvp.Rows(e.RowIndex).Cells("ret_ex").Value.ToString()
            txt_desc1.Text = Me.dtgvp.Rows(e.RowIndex).Cells("desc1").Value.ToString()
            txt_desc2.Text = Me.dtgvp.Rows(e.RowIndex).Cells("desc2").Value.ToString()
            txt_cantidad.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Cantidad").Value.ToString()
            txt_precio.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Precio").Value.ToString()
            cbx_area.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Departamento").Value.ToString()
            txt_subtotal.Text = Format(CType(txt_precio.Text * txt_cantidad.Text, Decimal), "#,##0.00")
            txt_total.Text = Format(CType((CDbl(txt_subtotal.Text) + (CDbl(txt_iva.Text) + CDbl(txt_iesp.Text) + CDbl(txt_isr.Text) + CDbl(txt_impex.Text)) - (CDbl(txt_retiva.Text) + CDbl(txt_retcel.Text) + CDbl(txt_retisr.Text) + CDbl(txt_retex.Text) + CDbl(txt_desc1.Text) + CDbl(txt_desc2.Text))), Decimal), "#,##0.00")
        Catch
        End Try

    End Sub

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter

        Try
            cbx_fam.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Familia").Value.ToString()
            txt_iva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("imp_iva").Value.ToString()
            txt_iesp.Text = Me.dtgvp.Rows(e.RowIndex).Cells("imp_iesp").Value.ToString()
            txt_isr.Text = Me.dtgvp.Rows(e.RowIndex).Cells("imp_isr").Value.ToString()
            txt_impex.Text = Me.dtgvp.Rows(e.RowIndex).Cells("imp_ex").Value.ToString()
            txt_retiva.Text = Me.dtgvp.Rows(e.RowIndex).Cells("ret_iva").Value.ToString()
            txt_retcel.Text = Me.dtgvp.Rows(e.RowIndex).Cells("ret_ced").Value.ToString()
            txt_retisr.Text = Me.dtgvp.Rows(e.RowIndex).Cells("ret_isr").Value.ToString()
            txt_retex.Text = Me.dtgvp.Rows(e.RowIndex).Cells("ret_ex").Value.ToString()
            txt_desc1.Text = Me.dtgvp.Rows(e.RowIndex).Cells("desc1").Value.ToString()
            txt_desc2.Text = Me.dtgvp.Rows(e.RowIndex).Cells("desc2").Value.ToString()
            txt_cantidad.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Cantidad").Value.ToString()
            txt_precio.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Precio").Value.ToString()
            cbx_area.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Departamento").Value.ToString()
            txt_subtotal.Text = Format(CType(txt_precio.Text * txt_cantidad.Text, Decimal), "#,##0.00")
            txt_total.Text = Format(CType((CDbl(txt_subtotal.Text) + (CDbl(txt_iva.Text) + CDbl(txt_iesp.Text) + CDbl(txt_isr.Text) + CDbl(txt_impex.Text)) - (CDbl(txt_retiva.Text) + CDbl(txt_retcel.Text) + CDbl(txt_retisr.Text) + CDbl(txt_retex.Text) + CDbl(txt_desc1.Text) + CDbl(txt_desc2.Text))), Decimal), "#,##0.00")
        Catch
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click





        Panel1.Visible = True
        Panel2.Visible = False
        btn_desma.Visible = True
        btn_selec.Visible = True
        llenacuentas()
        cargagrid()
        dtgvp.Visible = True

    End Sub


    Sub totales()

        Try
            Dim Total As Double
            Dim Total1 As Double
            Dim Total2 As Double
            Dim Total3 As Double
            Dim Total4 As Double
            Dim Total5 As Double
            Dim Total6 As Double
            Dim Total7 As Double
            Dim total8 As Double
            Dim Total9 As Double
            Dim total10 As Double



            Dim Col As Integer = Me.dtgvp.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.dtgvp.Rows
                If row.Cells("x").Value = True Then
                    Total += Val(row.Cells("Subtotal").Value)
                    Total1 += Val(row.Cells("imp_iva").Value)
                    Total2 += Val(row.Cells("imp_iesp").Value)
                    Total3 += Val(row.Cells("imp_isr").Value)
                    Total4 += Val(row.Cells("imp_ex").Value)
                    Total5 += Val(row.Cells("ret_iva").Value)
                    Total6 += Val(row.Cells("ret_ced").Value)
                    Total7 += Val(row.Cells("ret_isr").Value)
                    total8 += Val(row.Cells("ret_ex").Value)
                    Total9 += Val(row.Cells("desc1").Value)
                    total10 += Val(row.Cells("desc2").Value)

                End If
            Next


            lbl_neto.Text = Format(CType(Total, Decimal), "#,##0.00")

            lbl_iva.Text = Format(CType(Total1, Decimal), "#,##0.00")
            lbl_ieps.Text = Format(CType(Total2, Decimal), "#,##0.00")
            lbl_estatales.Text = Format(CType(Total3, Decimal), "#,##0.00")
            lbl_impex.Text = Format(CType(Total4, Decimal), "#,##0.00")



            lbl_ret1.Text = Format(CType(Total7, Decimal), "#,##0.00")
            lbl_otros.Text = Format(CType(Total6, Decimal), "#,##0.00")
            lbl_ret2.Text = Format(CType(Total5, Decimal), "#,##0.00")
            lbl_retex.Text = Format(CType(total8, Decimal), "#,##0.00")


            lbl_desc1.Text = Format(CType(Total9, Decimal), "#,##0.00")
            lbl_desc22.Text = Format(CType(total10, Decimal), "#,##0.00")








            lbl_total.Text = Format(CType(Total + (Total1 + Total2 + Total3 + Total4) - (Total5 + Total6 + Total7 + total8 + Total9 + total10), Decimal), "#,##0.00")

        Catch
        End Try


    End Sub

    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = True
        Next
    End Sub


    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = False
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LlenarArreglos()
        totales()
        Panel2.Visible = True

        If lbl_total.Text < 0 Then
            btn_carga.Enabled = False
        End If


    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        modificarregistros()


    End Sub

    Sub LlenarArreglos()
        Try




            For cont As Integer = 0 To dtgvp.Rows.Count - 1
                If Me.dtgvp.Rows(cont).Cells("x").Value = True Then
                    fecha_recep(cont) = Me.dtgvp.Rows(cont).Cells("fecha_recep").Value
                    fecha_solicitud(cont) = Me.dtgvp.Rows(cont).Cells("fecha_solicitud").Value


                End If
            Next

            Array.Sort(fecha_solicitud)

            Array.Reverse(fecha_solicitud)

            Array.Sort(fecha_recep)

            Array.Reverse(fecha_recep)


            top_fechasolicitud = fecha_solicitud(0)
            top_fecharecep = fecha_recep(0)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Sub modificarregistros()
        Try
            dtgvp.CurrentRow.Cells("imp_iva").Value = txt_iva.Text
            dtgvp.CurrentRow.Cells("imp_iesp").Value = txt_iesp.Text
            dtgvp.CurrentRow.Cells("imp_isr").Value = txt_isr.Text
            dtgvp.CurrentRow.Cells("imp_ex").Value = txt_impex.Text
            dtgvp.CurrentRow.Cells("ret_iva").Value = txt_retiva.Text
            dtgvp.CurrentRow.Cells("ret_ced").Value = txt_retcel.Text
            dtgvp.CurrentRow.Cells("ret_isr").Value = txt_retisr.Text
            dtgvp.CurrentRow.Cells("ret_ex").Value = txt_retex.Text
            dtgvp.CurrentRow.Cells("desc1").Value = txt_desc1.Text
            dtgvp.CurrentRow.Cells("desc2").Value = txt_desc2.Text


            dtgvp.CurrentRow.Cells("Departamento").Value = cbx_area.Text
            dtgvp.CurrentRow.Cells("Familia").Value = cbx_fam.Text

            MessageBox.Show("Movimiento Modificado", "¡Correcto!", MessageBoxButtons.OK)

        Catch
        End Try



    End Sub

    Private Sub cbx_moneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_moneda.SelectedIndexChanged
        If cbx_moneda.Text = "MEX" Then
            id_moneada = 1
            btn_buscar.Enabled = True
        ElseIf cbx_moneda.Text = "USD" Then
            id_moneada = 2
            btn_buscar.Enabled = True
        ElseIf cbx_moneda.Text = "YEN" Then
            id_moneada = 3
            btn_buscar.Enabled = True
        End If
    End Sub




    Sub crearPO()
        cnn.Close()
        cnn.Open()
        Dim agrega As SqlCommand = New SqlCommand("  
 insert into [Asahi].[dbo].[com_po_principal] values ((SELECT TOP 1 [codigo] FROM [Asahi].[dbo].[com_po_principal] WHERE serie <> 'N'  ORDER BY codigo desc) + 1 , 'A', @proveedor, @moneda, @tc, getdate(), @fecha_solicitud, @fecha_entrega,
  (SELECT ltrim(rtrim([id])) FROM [Asahi].[dbo].[cat_Bancos]  where  ltrim(rtrim([valor])) = @banco) , @cuenta, @clabe, @subtotal, @imp_ret,
   @imp_tras, @descuento, @total, @observaciones, 0, @id_usuario, null,0)
", cnn)


        Try

            agrega.Parameters.Clear()

            agrega.Parameters.Add("@fecha_solicitud", SqlDbType.Date).Value = top_fechasolicitud
            agrega.Parameters.Add("@fecha_entrega", SqlDbType.Date).Value = top_fecharecep

            agrega.Parameters.Add("@proveedor", SqlDbType.Int).Value = id_proveedor
            agrega.Parameters.Add("@moneda", SqlDbType.Int).Value = id_moneada

            If id_moneada = 1 Then
                agrega.Parameters.Add("@tc", SqlDbType.Money).Value = 1
            ElseIf id_moneada = 2 Then
                agrega.Parameters.Add("@tc", SqlDbType.Money).Value = lbl_usd.Text
            ElseIf id_moneada = 3 Then
                agrega.Parameters.Add("@tc", SqlDbType.Money).Value = 1 'lbl_yen.text 
            End If

            agrega.Parameters.Add("@banco", SqlDbType.NChar, (20)).Value = cbx_banco.Text

            agrega.Parameters.Add("@cuenta", SqlDbType.NChar, (18)).Value = cbx_cuenta.Text

            agrega.Parameters.Add("@clabe", SqlDbType.NChar, (20)).Value = cbx_clabe.Text

            agrega.Parameters.Add("@subtotal", SqlDbType.Money).Value = lbl_neto.Text


            agrega.Parameters.Add("@imp_ret", SqlDbType.Money).Value = CDbl(lbl_iva.Text) + CDbl(lbl_ieps.Text) + CDbl(lbl_estatales.Text) + CDbl(lbl_impex.Text)

            agrega.Parameters.Add("@imp_tras", SqlDbType.Money).Value = CDbl(lbl_ret2.Text) + CDbl(lbl_otros.Text) + CDbl(lbl_ret1.Text) + CDbl(lbl_retex.Text)


            agrega.Parameters.Add("@descuento", SqlDbType.Money).Value = CDbl(lbl_desc1.Text) + CDbl(lbl_desc22.Text)



            agrega.Parameters.Add("@total", SqlDbType.Money).Value = lbl_total.Text

            agrega.Parameters.Add("@observaciones", SqlDbType.Text).Value = txt_comen.Text

            agrega.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id




            agrega.ExecuteNonQuery()



            insertarfilas()

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
        comando.CommandText = "select top 1 CODIGO from [Asahi].[dbo].[com_po_principal] WHERE serie <> 'N' order by CODIGO desc"
        comando.Connection = cnn
        cnn.Close()
        cnn.Open()

        y = comando.ExecuteScalar()

        cnn.Close()





        cnn.Close()


        Dim command As New SqlCommand("Sp_CargaMovimientoPO", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True Then


                    command.Parameters.Clear()


                    command.Parameters.AddWithValue("@id_req", (fila.Cells("Id_movimiento").Value))
                    command.Parameters.AddWithValue("@id_cotizacion", (fila.Cells("Id_coti").Value))
                    command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))
                    command.Parameters.AddWithValue("@familia", (fila.Cells("Familia").Value))
                    command.Parameters.AddWithValue("@depto", (fila.Cells("Departamento").Value))
                    command.Parameters.AddWithValue("@cantidad", (fila.Cells("Cantidad").Value))
                    command.Parameters.AddWithValue("@precio", (fila.Cells("Precio").Value))
                    command.Parameters.AddWithValue("@subtotal", (fila.Cells("Subtotal").Value))
                    command.Parameters.AddWithValue("@iva", (fila.Cells("imp_iva").Value))
                    command.Parameters.AddWithValue("@iesp", (fila.Cells("imp_iesp").Value))
                    command.Parameters.AddWithValue("@isr", (fila.Cells("imp_isr").Value))
                    command.Parameters.AddWithValue("@imp_ex", (fila.Cells("imp_ex").Value))
                    command.Parameters.AddWithValue("@ret_iva", (fila.Cells("ret_iva").Value))
                    command.Parameters.AddWithValue("@ret_ced", (fila.Cells("ret_ced").Value))
                    command.Parameters.AddWithValue("@ret_isr", (fila.Cells("ret_isr").Value))
                    command.Parameters.AddWithValue("@ret_ex", (fila.Cells("ret_ex").Value))
                    command.Parameters.AddWithValue("@desc1", (fila.Cells("desc1").Value))
                    command.Parameters.AddWithValue("@desc2", (fila.Cells("desc2").Value))
                    command.Parameters.AddWithValue("@total", 0) '((fila.Cells("Subtotal").Value) + ((fila.Cells("imp_iva").Value) + (fila.Cells("imp_iesp").Value) + (fila.Cells("imp_isr").Value)(fila.Cells("imp_ex").Value) - ((fila.Cells("ret_iva").Value) + (fila.Cells("ret_ced").Value) + (fila.Cells("ret_isr").Value) + (fila.Cells("ret_ex").Value) + (fila.Cells("desc1").Value) + (fila.Cells("desc2").Value))))
                    command.Parameters.AddWithValue("@usuario", id)



                    command.ExecuteNonQuery()

                End If
            Next


            Panel1.Visible = False
            Panel2.Visible = False


            MessageBox.Show("Orden de compra creada con el folio: " & y & "", "¡Correcto!", MessageBoxButtons.OK)
            dtgvp.Visible = False
            llenacomboproveedor()
            btn_buscar.Enabled = False
            ContenedorReportePO.serie = "A"
            ContenedorReportePO.codigo = y
            btn_carga.Enabled = False
            ContenedorReportePO.Show()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try




    End Sub

    Private Sub btn_carga_Click(sender As Object, e As EventArgs) Handles btn_carga.Click
        crearPO()
    End Sub

    Private Sub lbl_total_Click(sender As Object, e As EventArgs) Handles lbl_total.TextChanged
        If lbl_total.Text = 0 Then
            btn_carga.Enabled = False
        Else
            btn_carga.Enabled = True
        End If
    End Sub


End Class