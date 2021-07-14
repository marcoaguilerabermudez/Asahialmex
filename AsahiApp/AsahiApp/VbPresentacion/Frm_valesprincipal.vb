Imports System.Data.SqlClient

Public Class Frm_valesprincipal
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer
    Dim StockSeguridad, Existencia As Double
    Dim Global_ExistenciaMaterial As Boolean
    Dim Global_PedidoValeCompleto As Boolean
    Dim Global_PedidoValeRepetido As Boolean
    Dim UsoStockSeguridad As Short
    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Dim ColumnaAgregar As New DataGridViewButtonColumn

    Dim Repetido As Boolean
    Dim Codigo, Medida As String
    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Frm_valesprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cnn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress
        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cnn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor
        End If



        lbl_usuario.Text = nombre
        ' cargagridmuestraproducto()




    End Sub

    Private Sub dtgv_2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_2.CellContentClick
        If sender.Columns(e.ColumnIndex).HeaderText = "Quitar" Then

            Try
                dtgv_2.Rows.Remove(dtgv_2.CurrentRow)
            Catch
            End Try
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            cargagridmuestraproducto()

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_nombre.Clear()
            ''  cargagridmuestraproducto()

        End If


    End Sub

    Sub cargagridmuestraproducto()



        cnn.Close()

        cnn.Open()

        Dim da As New SqlDataAdapter("Sp_muestraproductosparavale", cnn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@tipo", p_vales)
        da.SelectCommand.Parameters.AddWithValue("@producto", txt_nombre.Text)



        Dim dt As New DataTable
        da.Fill(dt)
        dtgvp.DataSource = dt
        dtgvp.Columns("id").Visible = False
        dtgvp.Columns("Codigo").Visible = False
        dtgvp.Columns("TipoProducto").Visible = False
        dtgvp.Columns("FechaCreacion").Visible = False
        dtgvp.Columns("FechaModificacion").Visible = False
        dtgvp.Columns("Nombre").Width = 480
        dtgvp.Columns("Nombre").ReadOnly = True
        dtgvp.Columns("Stock").ReadOnly = True
        cnn.Close()

        Try
            dtgvp.Columns.Remove(ColumnaAgregar)
        Catch
        End Try
        dtgvp.Columns.Add(ColumnaAgregar)
        ColumnaAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        ColumnaAgregar.HeaderText = "Agregar"
        ColumnaAgregar.Name = "Agregar"
        ColumnaAgregar.Text = "Agregar"
        ColumnaAgregar.ToolTipText = "Agregar"
        ColumnaAgregar.UseColumnTextForButtonValue = True


    End Sub

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellContentClick


        If dtgv_2.RowCount < 8 Then
            Try
                Existencia = dtgvp.Rows(e.RowIndex).Cells("Stock").Value

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Existencia = 0
            End Try


            Try
                StockSeguridad = dtgvp.Rows(e.RowIndex).Cells("Stock").Value

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                StockSeguridad = 0
            End Try



            ''172.16.6.84


            If Existencia > 0 Then
                Global_ExistenciaMaterial = True
                Global_PedidoValeCompleto = False


                If e.ColumnIndex = 7 And e.RowIndex >= 0 Then

                    If Existencia < StockSeguridad Then
                        UsoStockSeguridad = 1

                    Else
                        UsoStockSeguridad = 0

                    End If


                    Repetido = False
                    Codigo = dtgvp.Rows(e.RowIndex).Cells("Codigo").Value
                    nombre = dtgvp.Rows(e.RowIndex).Cells("Nombre").Value
                    ''  Medida = dtgvp.Rows(e.RowIndex).Cells(2).Value

                    ''  If dtgv_2.RowCount > 0 Then


                    For index = 0 To dtgv_2.RowCount - 1
                        If dtgv_2.Rows(index).Cells(0).Value = Codigo Then
                            Repetido = True
                        End If
                    Next
                    '' End If

                    If Repetido = False Then
                        dtgv_2.Rows.Add(Codigo, nombre, 1, "No")
                        ''  Dgv_Cantidades.Rows.Add(UsoStockSeguridad, StockSeguridad, Codigo, nombre, Medida)
                        ''Dgv_Cantidades.Rows((Dgv_Cantidades.RowCount - 1)).Cells(8).Value = "Nuevo"
                    Else
                        MessageBox.Show("El producto ya está agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                    Global_PedidoValeRepetido = Repetido
                End If


            Else
                Global_ExistenciaMaterial = False
                MessageBox.Show("Por el momento el producto que usted requiere se encuentra agotado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Else
            Global_PedidoValeCompleto = True
            MessageBox.Show("Ha alcanzado el limite de productos permitidos por vale", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If



    End Sub
End Class