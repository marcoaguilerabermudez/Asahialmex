Imports System.Data.SqlClient

Public Class Frm_terminavale
    Dim clave As Integer
    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer




    Private Sub Frm_terminavale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



        clave = Modulo_vales.e_clave
        historial()
    End Sub


    Sub historial()

        cnn.Close()

        cnn.Open()

        Try

            Dim da As New SqlDataAdapter("Sp_muestrahistorialVale", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@clave", clave)





            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Vale").Width = 40
            dtgvp.Columns("Cantidad").Width = 60
            dtgvp.Columns("Surtido").Width = 60
            dtgvp.Columns("Validado").Width = 60
            dtgvp.Columns("Cancelado").Width = 60
            dtgvp.Columns("Producto").Width = 240
            'dtgvp.Columns("Fecha_solicita").Visible = False
            'dtgvp.Columns("Id_vale").Visible = False
            'dtgvp.Columns("Folio").Visible = False
            'dtgvp.Columns("Codigo").Visible = False

            'dtgvp.Columns("Producto").ReadOnly = True
            'dtgvp.Columns("Cantidad").ReadOnly = True
            'dtgvp.Columns("Precio").ReadOnly = True
            'dtgvp.Columns("Total").ReadOnly = True

            cnn.Close()



        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("Revise que el código de vale sea correcto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' dtgvp.Visible = False

        End Try
    End Sub


End Class