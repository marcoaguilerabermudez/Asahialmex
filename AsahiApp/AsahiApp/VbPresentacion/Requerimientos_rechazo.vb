Imports System.Data.SqlClient

Public Class Requerimientos_rechazo


    Dim id_mov As Integer
    Dim id_req As Integer
    Dim id As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim nombre As String
    Dim p_vales As Integer

    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String

    Private Sub Requerimientos_rechazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_mov = Modulo_verpo.id_movi
        id = Modulo_verpo.e_id
        depto = Modulo_verpo.e_depto
        permiso = Modulo_verpo.e_permiso
        nombre = Modulo_verpo.e_nombre
        p_vales = Modulo_verpo.e_p_vales
        txt_comen.Text = Modulo_verpo.e_rechazo


        If p_vales = 0 Then
            btn_cancelar.Enabled = False
            txt_comen.Enabled = False
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



    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

        cnn.Close()
        cnn.Open()
        Dim auto As SqlCommand = New SqlCommand("




           update  [Asahi].[dbo].[Com_RequerimientoMovimiento] set estado = 6 , Rechazo = @rechazo  where id_movimiento = @id


        ", cnn)



        Dim fila As DataGridViewRow = New DataGridViewRow()
        Dim RI As String

        Try



            auto.Parameters.Clear()

            auto.Parameters.Add("@id", SqlDbType.Int).Value = id_mov
            auto.Parameters.Add("@rechazo", SqlDbType.NVarChar, 100).Value = txt_comen.Text

            auto.ExecuteNonQuery()





            MessageBox.Show("Cancelación realizada con éxito", "¡Correcto!", MessageBoxButtons.OK)
            Me.Dispose()

            Dim Req_mov As New Requerimientos_movimientos(id, depto, permiso, nombre, p_vales)
            Req_mov.Show()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()
        Finally
            cnn.Close()

        End Try

    End Sub



    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim Req_mov As New Requerimientos_movimientos(id, depto, permiso, nombre, p_vales)
        Req_mov.Show()


    End Sub

End Class