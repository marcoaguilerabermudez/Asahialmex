Imports System.Data.SqlClient

Public Class Alta_proveedores
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
    Dim id_proveedor As Integer
    Dim p_temporal As Integer
    Dim id_cuenta As Integer
    Dim actualiza_elimina_cuenta As Integer


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Alta_proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_proveedor = Modulo_modificaproveedor.e_id

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


        If p_vales = 0 Then


            btn_solicitar.Text = "Crear"
            Me.Text = "Alta de proveedores"



        ElseIf p_vales = 1 Then

            btn_solicitar.Text = "Modificar"
            Me.Text = "Modificar proveedores"
            MuestraEtiquetas()
            cargagrid()

            btn_bloquear.Visible = True
            btn_quitar.Visible = False
        End If

        llenacombobanco()
        colores()
    End Sub

    Sub colores()
        Try
            For Each row As DataGridViewRow In Me.dtgv_cuentas.Rows

                If row.Cells(“estado”).Value = False Then
                    row.DefaultCellStyle.BackColor = Color.Yellow
                ElseIf row.Cells(“estado”).Value = True Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                End If
            Next
        Catch
        End Try

    End Sub

    Sub llenacombobanco()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        Dim parametro1 As String
        parametro1 = cbx_tipo.Text

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	
SELECT nombre
  FROM [Asahi].[dbo].[cat_Bancos]
  order by nombre
"
            .Connection = cnn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With txt_banco
            .DataSource = Dt
            .DisplayMember = "nombre"
            '.ValueMember = "id"
        End With


    End Sub


    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_cuentas.CellClick
        Try
            id_cuenta = Me.dtgv_cuentas.Rows(e.RowIndex).Cells("id").Value.ToString()


        Catch
        End Try

        colores()
    End Sub


    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_cuentas.RowEnter
        Try
            id_cuenta = Me.dtgv_cuentas.Rows(e.RowIndex).Cells("id").Value.ToString()
        Catch
        End Try

        colores()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If p_vales = 0 Then
            dtgv_cuentas.Rows.Add(txt_banco.Text, txt_cuenta.Text, txt_clabe.Text, cbx_tipo.Text, txt_aba.Text, txt_swift.Text, txt_iban.Text, cbx_monedacuenta.Text)

        ElseIf p_vales = 1 Then
            actualiza_elimina_cuenta = 1
            Dim Pregunta As Integer

            Pregunta = MsgBox("¿Desea guardar el la cuenta en el proveedor actual?", vbYesNo + vbExclamation + vbDefaultButton2, "Guardar Cuenta")

            If Pregunta = vbYes Then

                insertarcuentadirecta()
            Else
                MessageBox.Show("Acción no completada", "¡Aviso!")
            End If
        End If
    End Sub


    Private Sub btn_bloquear_Click(sender As Object, e As EventArgs) Handles btn_bloquear.Click
        actualiza_elimina_cuenta = 2
        Dim Pregunta As Integer

        Pregunta = MsgBox("¿Desea cancelar la cuenta en el proveedor actual?", vbYesNo + vbExclamation + vbDefaultButton2, "Cancelar Cuenta")

        If Pregunta = vbYes Then

            insertarcuentadirecta()
        Else
            MessageBox.Show("Acción no completada", "¡Aviso!")
        End If

    End Sub

    Sub insertarproveedor()

        cnn.Close()


        Dim command As New SqlCommand("Sp_InsertaModificaProveedor", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try

            command.Parameters.Clear()


            command.Parameters.AddWithValue("@rfc", txt_rfc.Text)
            command.Parameters.AddWithValue("@curp", txt_curp.Text)
            command.Parameters.AddWithValue("@nacionalidad", cbx_nacionalidad.Text)
            command.Parameters.AddWithValue("@razon_social", txt_razonsocial.Text)
            command.Parameters.AddWithValue("@nombre", txt_nombre.Text)
            command.Parameters.AddWithValue("@telefono", txt_tel1.Text)
            command.Parameters.AddWithValue("@telefono2", txt_tel2.Text)
            command.Parameters.AddWithValue("@correo", txt_email.Text)
            command.Parameters.AddWithValue("@credito", cbx_terminos.Text)
            command.Parameters.AddWithValue("@cp", txt_cp.Text)
            command.Parameters.AddWithValue("@pais", txt_pais.Text)
            command.Parameters.AddWithValue("@estado", txt_estado.Text)
            command.Parameters.AddWithValue("@municipio", txt_municipio.Text)
            command.Parameters.AddWithValue("@colonia", cbx_colonia.Text)
            command.Parameters.AddWithValue("@calle", txt_calle.Text)
            command.Parameters.AddWithValue("@num", txt_numero.Text)
            command.Parameters.AddWithValue("@num_int", txt_interior.Text)
            command.Parameters.AddWithValue("@detalle", txt_detallecontacto.Text)
            command.Parameters.AddWithValue("@nombre_contacto", txt_NombreContacto.Text)
            command.Parameters.AddWithValue("@apellido", txt_apellidocontacto.Text)
            command.Parameters.AddWithValue("@rol", cbx_rolcontacto.Text)
            command.Parameters.AddWithValue("@correo_contacto", txt_mailcontacto.Text)
            command.Parameters.AddWithValue("@tel1_contacto", txt_tel1contacto.Text)
            command.Parameters.AddWithValue("@tel2_contacto", txt_tel2contacto.Text)
            command.Parameters.AddWithValue("@var", p_vales)
            command.Parameters.AddWithValue("@id_prov", id_proveedor)

            command.ExecuteNonQuery()


            insertarfilas()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try
    End Sub


    Sub insertarcuentadirecta()
        cnn.Close()


        Dim command As New SqlCommand("Sp_insertamovimientosproveedor", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try


            command.Parameters.Clear()

            command.Parameters.AddWithValue("@moneda", cbx_monedacuenta.Text)
            command.Parameters.AddWithValue("@nombre", txt_banco.Text)
            command.Parameters.AddWithValue("@cuenta", txt_cuenta.Text)
            command.Parameters.AddWithValue("@clabe", txt_clabe.Text)
            command.Parameters.AddWithValue("@tipo", cbx_tipo.Text)
            command.Parameters.AddWithValue("@aba", txt_aba.Text)
            command.Parameters.AddWithValue("@swift", txt_swift.Text)
            command.Parameters.AddWithValue("@iban", txt_iban.Text)

            command.Parameters.AddWithValue("@var", actualiza_elimina_cuenta)
            If actualiza_elimina_cuenta = 1 Then
                command.Parameters.AddWithValue("@id", 0)
            ElseIf actualiza_elimina_cuenta = 2 Then
                command.Parameters.AddWithValue("@id", id_cuenta)
            End If

            command.Parameters.AddWithValue("@estado", 0)
            command.Parameters.AddWithValue("@id_proveedor", id_proveedor)
            command.ExecuteNonQuery()





            txt_cuenta.Clear()
            txt_clabe.Clear()
            txt_aba.Clear()
            txt_swift.Clear()
            txt_iban.Clear()
            cbx_tipo.Text = ""
            cbx_monedacuenta.Text = ""
            txt_banco.Text = ""





            If actualiza_elimina_cuenta = 1 Then

                MessageBox.Show("Cuenta insertada en registro de proveedor", "¡Correcto!", MessageBoxButtons.OK)

            ElseIf actualiza_elimina_cuenta = 2 Then

                MessageBox.Show("Cuenta cancelada en registro de proveedor", "¡Correcto!", MessageBoxButtons.OK)

            End If

            cargagrid()
            colores()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try
    End Sub

    Sub insertarfilas()

        cnn.Close()


        Dim command As New SqlCommand("Sp_insertamovimientosproveedor", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try

            For Each fila In dtgv_cuentas.Rows


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@moneda", (fila.Cells("Moneda").Value))
                command.Parameters.AddWithValue("@nombre", (fila.Cells("Banco").Value))
                command.Parameters.AddWithValue("@cuenta", (fila.Cells("Cuenta").Value))
                command.Parameters.AddWithValue("@clabe", (fila.Cells("Clabe").Value))
                command.Parameters.AddWithValue("@tipo", (fila.Cells("Tipo").Value))
                command.Parameters.AddWithValue("@aba", (fila.Cells("ABA").Value))
                command.Parameters.AddWithValue("@swift", (fila.Cells("SWIFT").Value))
                command.Parameters.AddWithValue("@iban", (fila.Cells("IBAN").Value))
                command.Parameters.AddWithValue("@var", p_vales)
                command.Parameters.AddWithValue("@id", (fila.Cells("id").Value))
                command.Parameters.AddWithValue("@estado", (fila.Cells("estado").Value))
                command.Parameters.AddWithValue("@id_proveedor", id_proveedor)
                command.ExecuteNonQuery()

            Next


            txt_rfc.Clear()
            txt_curp.Clear()
            txt_nombre.Clear()
            txt_razonsocial.Clear()
            cbx_nacionalidad.Text = ""
            txt_tel1.Clear()
            txt_tel2.Clear()
            txt_email.Clear()
            cbx_terminos.Text = ""
            txt_cp.Clear()
            txt_pais.Clear()
            txt_estado.Clear()
            txt_municipio.Clear()
            cbx_colonia.Text = ""
            txt_calle.Clear()
            txt_numero.Clear()
            txt_interior.Clear()
            txt_detallecontacto.Clear()
            txt_NombreContacto.Clear()
            txt_apellidocontacto.Clear()
            cbx_rolcontacto.Text = ""
            txt_mailcontacto.Clear()
            txt_tel1contacto.Clear()
            txt_tel2contacto.Clear()
            txt_cuenta.Clear()
            txt_clabe.Clear()
            txt_aba.Clear()
            txt_swift.Clear()
            txt_iban.Clear()
            cbx_tipo.Text = ""
            cbx_monedacuenta.Text = ""
            txt_banco.Text = ""

            Try


                dtgv_cuentas.Rows.Clear()

            Catch
            End Try

            If p_vales = 0 Then
                MessageBox.Show("Registro de proveedor completado", "¡Correcto!", MessageBoxButtons.OK)
            ElseIf p_vales = 1 Then
                MessageBox.Show("Registro de proveedor modificado", "¡Correcto!", MessageBoxButtons.OK)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try

    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click


        Dim Pregunta As Integer
        If p_vales = 0 Then
            Pregunta = MsgBox("¿Desea guardar el registro con los datos que ha elegido?", vbYesNo + vbExclamation + vbDefaultButton2, "Guardar Proveedor")
        ElseIf p_vales = 1 Then
            Pregunta = MsgBox("¿Desea modificar el registro?", vbYesNo + vbExclamation + vbDefaultButton2, "Modificar Proveedor")
        End If

        If Pregunta = vbYes Then

            insertarproveedor()
        Else
            MessageBox.Show("Acción no completada", "¡Aviso!")
        End If

    End Sub

    Sub MuestraEtiquetas()

        cnn.Close()
        cnn.Open()

        Try
            Dim da As New SqlDataAdapter("Sp_MuestraListaProveedor", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@variable", 1)
            da.SelectCommand.Parameters.AddWithValue("@proveedor", "")
            da.SelectCommand.Parameters.AddWithValue("@id_prov", id_proveedor)


            Dim ds As New DataSet
            ds.Clear()

            da.Fill(ds)

            txt_nombre.Text = ds.Tables(0).Rows(0).Item(1)
            txt_razonsocial.Text = ds.Tables(0).Rows(0).Item(2)
            txt_rfc.Text = ds.Tables(0).Rows(0).Item(3)
            txt_curp.Text = ds.Tables(0).Rows(0).Item(4)
            cbx_terminos.Text = ds.Tables(0).Rows(0).Item(5)
            cbx_nacionalidad.Text = ds.Tables(0).Rows(0).Item(6)
            txt_tel1.Text = ds.Tables(0).Rows(0).Item(9)
            txt_tel2.Text = ds.Tables(0).Rows(0).Item(10)
            txt_email.Text = ds.Tables(0).Rows(0).Item(11)
            txt_pais.Text = ds.Tables(0).Rows(0).Item(12)
            txt_cp.Text = ds.Tables(0).Rows(0).Item(13)
            txt_estado.Text = ds.Tables(0).Rows(0).Item(14)
            txt_municipio.Text = ds.Tables(0).Rows(0).Item(15)
            cbx_colonia.Text = ds.Tables(0).Rows(0).Item(16)
            txt_calle.Text = ds.Tables(0).Rows(0).Item(17)
            txt_numero.Text = ds.Tables(0).Rows(0).Item(18)
            txt_interior.Text = ds.Tables(0).Rows(0).Item(19)
            txt_NombreContacto.Text = ds.Tables(0).Rows(0).Item(20)
            txt_apellidocontacto.Text = ds.Tables(0).Rows(0).Item(21)
            cbx_rolcontacto.Text = ds.Tables(0).Rows(0).Item(22)
            txt_detallecontacto.Text = ds.Tables(0).Rows(0).Item(23)
            txt_mailcontacto.Text = ds.Tables(0).Rows(0).Item(24)
            txt_tel1contacto.Text = ds.Tables(0).Rows(0).Item(25)
            txt_tel2contacto.Text = ds.Tables(0).Rows(0).Item(26)

            cnn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ' MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
        End Try



    End Sub




    Public Sub cargagrid()


        Try
            dtgv_cuentas.Columns.Remove("Banco")
            dtgv_cuentas.Columns.Remove("Cuenta")
            dtgv_cuentas.Columns.Remove("Clabe")
            dtgv_cuentas.Columns.Remove("Tipo")
            dtgv_cuentas.Columns.Remove("ABA")
            dtgv_cuentas.Columns.Remove("SWIFT")
            dtgv_cuentas.Columns.Remove("IBAN")
            dtgv_cuentas.Columns.Remove("Moneda")

        Catch ex As Exception

        End Try


        cnn.Close()

        cnn.Open()

        Try

            Dim da As New SqlDataAdapter("Sp_MuestraListaProveedor", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@variable", 2)
            da.SelectCommand.Parameters.AddWithValue("@id_prov", id_proveedor)
            da.SelectCommand.Parameters.AddWithValue("@proveedor", "")



            Dim dt As New DataTable
            da.Fill(dt)
            dtgv_cuentas.DataSource = dt
            dtgv_cuentas.Columns("id").Visible = False
            dtgv_cuentas.Columns("id_banco").Visible = False
            dtgv_cuentas.Columns("id_prov").Visible = False
            dtgv_cuentas.Columns("estado").Visible = False

            cnn.Close()
            colores()






        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub


End Class