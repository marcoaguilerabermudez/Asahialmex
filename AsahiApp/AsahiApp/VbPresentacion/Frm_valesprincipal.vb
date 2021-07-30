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
    Public cnn2 As SqlConnection
    Dim ColumnaAgregar As New DataGridViewButtonColumn
    Dim Cantidad_Requerida As Double

    Dim Repetido As Boolean
    Dim Codigo, Medida As String
    Dim Stock_1 As Double

    Dim y As Integer

    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Frm_valesprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        txt_nombre.Focus()
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



        lbl_usuario.Text = nombre
        ' cargagridmuestraproducto()
        txt_nombre.Focus()




        If p_vales = 1 Then
            lbl_empleado.Text = "Empleado"
        Else
            lbl_empleado.Text = "Supervisor"
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



    Private Sub txt_empleado_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_empleado.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            muestraetiqueta()

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_empleado.Clear()
            lbl_persona.Text = ""
            btn_historial.Visible = False

        End If


    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            cargagridmuestraproducto()
            dtgvp.Visible = True
            dtgv_2.Visible = True
            pbx.Visible = True

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_nombre.Clear()
            ''  cargagridmuestraproducto()

        End If


    End Sub


    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            cnn2.Close()
            cnn2.Open()
            Dim SSel As String

            Dim parametro1 As Integer
            parametro1 = txt_empleado.Text



            SSel = ("

declare @permiso as int
set @permiso = " & p_vales & "


if @permiso = 0
begin


select CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
,Turno = CASE (select TOP 1 ETT.CATALOGO  from GIRO.[asahi16].[Supervisor_giro].[Empturno] ETT
  where ett.clave = vig.CLAVE and ett.FECHA_ENTRADA <= getdate()
  order by ETT.FECHA_ENTRADA desc)/1 /*EM.TURNO*/
   when 1 then 'Matutino'
   when 2 then 'Vespertino'
   when 3 then 'Nocturno'
   when 4 then 'Administrativo'
   when 5 then 'Mazda día'
   when 6 then 'Mazda noche'
   when 7 then '12 M'
   when 8 then '12 N'
   when 9 then 'Descanso'
   else 'Error'
   end
   ,descripcion_depto
    ,departamento
from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig
join ASAHISYSTEM.[AsahiSystem].[dbo].[Rh_planmensualTE] te
on te.id_depto = vig.departamento
where vig.vigencia = 'VIGENTE' and clave = " & parametro1 & " and puesto not in (5,6)
end

else

begin

select CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
,Turno = CASE (select TOP 1 ETT.CATALOGO  from GIRO.[asahi16].[Supervisor_giro].[Empturno] ETT
  where ett.clave = vig.CLAVE and ett.FECHA_ENTRADA <= getdate()
  order by ETT.FECHA_ENTRADA desc)/1 /*EM.TURNO*/
   when 1 then 'Matutino'
   when 2 then 'Vespertino'
   when 3 then 'Nocturno'
   when 4 then 'Administrativo'
   when 5 then 'Mazda día'
   when 6 then 'Mazda noche'
   when 7 then '12 M'
   when 8 then '12 N'
   when 9 then 'Descanso'
   else 'Error'
   end
   ,descripcion_depto
    ,departamento
from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig
join ASAHISYSTEM.[AsahiSystem].[dbo].[Rh_planmensualTE] te
on te.id_depto = vig.departamento
where vig.vigencia = 'VIGENTE' and clave = " & parametro1 & " 


end


declare @TiempoEspera as smalldatetime
set @TiempoEspera = dateadd(MINUTE, -60, getdate())
 

delete from [Asahi].[dbo].[Vales_Almacen_Temp] where [TimeStampSalida] < @TiempoEspera

")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn)
            da.Fill(ds)

            lbl_persona.Text = ds.Tables(0).Rows(0).Item(1)
            btn_historial.Visible = True



            cnn2.Close()

        Catch ex As Exception

            ''   MessageBox.Show(ex.ToString)

            If p_vales = 0 Then
                MessageBox.Show("El empleado que ha seleccionado no tiene permisos para generar este tipo de vales.", "¡Aviso!")
            Else
                MessageBox.Show("El empleado que ha seleccionado no está activo o es incorrecto, verifique e intente de nuevo.", "¡Aviso!")
            End If

            txt_empleado.Text = ""
            lbl_persona.Text = ""
            btn_historial.Visible = False
        End Try

    End Sub


    Private Sub ValidarCantidadRequerida(Objeto As Object, e As DataGridViewCellEventArgs) Handles dtgv_2.CellEndEdit
        If e.ColumnIndex = 2 Then
            Try
                Cantidad_Requerida = CDbl(dtgv_2.Rows(e.RowIndex).Cells("C_3").Value)
                If Cantidad_Requerida > dtgv_2.Rows(e.RowIndex).Cells("Stock").Value Then
                    MessageBox.Show("La cantidad que requerie supera a la que se encuentra disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    dtgv_2.Rows(e.RowIndex).Cells("C_3").Value = 1
                End If
            Catch ex As Exception
                ' MessageBox.Show(ex.ToString)
                MessageBox.Show("La cantidad que introdujo no es valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtgv_2.Rows(e.RowIndex).Cells("C_3").Value = 1
            End Try

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

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick

        pbx.ImageLocation = ("V:\Fotografias\" & Me.dtgvp.Rows(e.RowIndex).Cells("Codigo").Value.ToString() & ".jpg")
        pbx.SizeMode = PictureBoxSizeMode.CenterImage
        pbx.BorderStyle = BorderStyle.Fixed3D
        pbx.SizeMode = PictureBoxSizeMode.StretchImage


        If dtgv_2.RowCount < 8 Then
            Try
                Existencia = dtgvp.Rows(e.RowIndex).Cells("Disponible").Value

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Existencia = 0
            End Try


            Try
                StockSeguridad = dtgvp.Rows(e.RowIndex).Cells("Disponible").Value

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                StockSeguridad = 0
            End Try



            ''172.16.6.84

            If Existencia > 0 Then
                Global_ExistenciaMaterial = True
                Global_PedidoValeCompleto = False


                If e.ColumnIndex = 8 And e.RowIndex >= 0 Then

                    If Existencia < StockSeguridad Then
                        UsoStockSeguridad = 1

                    Else
                        UsoStockSeguridad = 0

                    End If


                    Repetido = False
                    Codigo = dtgvp.Rows(e.RowIndex).Cells("Codigo").Value
                    nombre = dtgvp.Rows(e.RowIndex).Cells("Nombre").Value
                    Stock_1 = dtgvp.Rows(e.RowIndex).Cells("Disponible").Value
                    ''  Medida = dtgvp.Rows(e.RowIndex).Cells(2).Value

                    ''  If dtgv_2.RowCount > 0 Then


                    For index = 0 To dtgv_2.RowCount - 1
                        If dtgv_2.Rows(index).Cells(0).Value = Codigo Then
                            Repetido = True
                        End If
                    Next
                    '' End If

                    If Repetido = False Then
                        dtgv_2.Rows.Add(Codigo, nombre, 1, Stock_1, "No")
                        gbx_terminar.Visible = True
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


    Private Sub dtgvp_CellContentClick2(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter

        pbx.ImageLocation = ("V:\Fotografias\" & Me.dtgvp.Rows(e.RowIndex).Cells("Codigo").Value.ToString() & ".jpg")
        pbx.SizeMode = PictureBoxSizeMode.CenterImage
        pbx.BorderStyle = BorderStyle.Fixed3D
        pbx.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btn_historial_Click(sender As Object, e As EventArgs) Handles btn_historial.Click
        Frm_terminavale.Show()
    End Sub

    Private Sub btn_selec_Click_1(sender As Object, e As EventArgs) Handles btn_selec.Click
        ' generarreporte()
        If dtgv_2.RowCount > 0 And lbl_persona.Text <> "" Then


            crearvale()
            insertarfilas()
            ' generarreporte()
        ElseIf dtgv_2.RowCount < 1 And lbl_persona.Text <> "" Then
            MessageBox.Show("¡Debe agregar productos para terminar su vale!", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf dtgv_2.RowCount > 0 And lbl_persona.Text = "" Then
            MessageBox.Show("Empleado inexistente, verifique que sus datos sean correctos.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf dtgv_2.RowCount < 1 And lbl_persona.Text = "" Then
            MessageBox.Show("Complete su información, por favor.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub


    Sub crearvale()
        cnn.Close()
        cnn.Open()
        Dim agrega As SqlCommand = New SqlCommand("  
declare @FolioVale as integer
set @FolioVale = (select top 1 folio_vale from Asahi.dbo.Vales_Almacen order by folio_vale desc) + 1

insert into Asahi.dbo.Vales_Almacen values
(@FolioVale, @solicita, @autoriza, null, null, getdate(), getdate(), null, null, @observaciones, 1, 0, 0)
", cnn)


        Try

            agrega.Parameters.Clear()

            If p_vales = 0 Then
                agrega.Parameters.Add("@solicita", SqlDbType.Int).Value = id
                agrega.Parameters.Add("@autoriza", SqlDbType.Int).Value = txt_empleado.Text

            Else
                agrega.Parameters.Add("@solicita", SqlDbType.Int).Value = txt_empleado.Text
                agrega.Parameters.Add("@autoriza", SqlDbType.Int).Value = id
            End If


            agrega.Parameters.Add("@observaciones", SqlDbType.VarChar, (200)).Value = txt_comentario.Text




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
        comando.CommandText = " select top 1 folio_vale FROM Asahi.dbo.Vales_Almacen order by folio_vale desc"
        comando.Connection = cnn
        cnn.Close()
        cnn.Open()

        y = comando.ExecuteScalar()

        cnn.Close()





        cnn.Close()


        Dim command As New SqlCommand("Sp_CrearValeMovimientos", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try

            For Each fila In dtgv_2.Rows


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@folioVale", y)
                command.Parameters.AddWithValue("@CodigoMaterial", (fila.Cells("c_1").Value))
                command.Parameters.AddWithValue("@CantidadMaterial", (fila.Cells("C_3").Value))
                command.Parameters.AddWithValue("@CambioMaterial", 0)
                command.Parameters.AddWithValue("@PrestamoMaterial", 0)
                If (fila.Cells("c_cobro").Value) = "Sí" Then
                    command.Parameters.AddWithValue("@Cobro", 1)
                Else
                    command.Parameters.AddWithValue("@Cobro", 0)
                End If



                command.ExecuteNonQuery()

            Next

            MessageBox.Show("Vale creado con el folio: " & y & "", "¡Correcto!", MessageBoxButtons.OK)
            generarreporte()
            txt_nombre.Clear()
            gbx_terminar.Visible = False
            dtgv_2.Visible = False
            dtgv_2.Rows.Clear()
            dtgvp.Visible = False
            dtgvp.Columns.Clear()
            txt_comentario.Clear()
            txt_empleado.Clear()
            lbl_persona.Text = ""
            pbx.Visible = False
            btn_historial.Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try




    End Sub



    Sub generarreporte()
        ContenedorReporteVale1.folio = y
        'ContenedorReporteVale1.folio = 2

        ContenedorReporteVale1.Show()
    End Sub

End Class