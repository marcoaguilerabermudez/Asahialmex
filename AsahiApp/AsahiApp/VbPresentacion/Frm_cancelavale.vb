Imports System.Data.SqlClient

Public Class Frm_cancelavale
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection

    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub
    Private Sub Frm_cancelavale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_folio.Focus()

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


    Sub muestravale()

        cnn.Close()

        cnn.Open()

        Try

            Dim da As New SqlDataAdapter("Sp_MuestraValidaVale", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@folio", txt_folio.Text)

            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Medida").Visible = False
            dtgvp.Columns("Fecha_solicita").Visible = False
            dtgvp.Columns("Id_vale").Visible = False
            dtgvp.Columns("Folio").Visible = False
            dtgvp.Columns("Codigo").Visible = False

            dtgvp.Columns("Producto").ReadOnly = True
            dtgvp.Columns("Cantidad").ReadOnly = True
            dtgvp.Columns("Precio").ReadOnly = True
            dtgvp.Columns("Total").ReadOnly = True

            cnn.Close()

            If dtgvp.RowCount > 0 Then

                Btn_cancelar.Enabled = True
                dtgvp.Visible = True
            Else
                Btn_cancelar.Enabled = False
                MessageBox.Show("El vale " & txt_folio.Text & " no existe , ya ha sido validado o ya ha sido cancelado, revise su información.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtgvp.Visible = False
                txt_folio.Clear()

            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("Revise que el código de vale sea correcto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Btn_cancelar.Enabled = False
            dtgvp.Visible = False
            txt_folio.Clear()
        End Try
    End Sub

    Private Sub txt_folio_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_folio.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            muestravale()

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then

            txt_folio.Clear()

            Btn_cancelar.Enabled = False
            dtgvp.Visible = False

        End If
    End Sub



    Sub CancelaRegistroVale()
        cnn.Close()
        cnn.Open()
        Dim agrega As SqlCommand = New SqlCommand("  

update [Asahi].[dbo].[Vales_Almacen] set p_cancela = @entrega , fecha_cancela = getdate(), cancelado = 1
where Folio_vale = @folio


update [Asahi].[dbo].[Vales_Almacen_Productos] set cancelado = 1
where folio_vale = @folio

delete from [Asahi].[dbo].[Vales_Almacen_Temp]
where folio_vale = @folio

", cnn)


        Try

            agrega.Parameters.Clear()


            agrega.Parameters.Add("@folio", SqlDbType.Int).Value = txt_folio.Text
            agrega.Parameters.Add("@entrega", SqlDbType.Int).Value = id

            agrega.ExecuteNonQuery()

            MessageBox.Show("El registro(s) ha(n) sido cancelado(s) correctamente", "Advertencia", MessageBoxButtons.OK)
            txt_folio.Clear()

            dtgvp.Visible = False
            Btn_cancelar.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error al cancelar el vale, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()

            'cargagrid()
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        CancelaRegistroVale()
    End Sub


End Class