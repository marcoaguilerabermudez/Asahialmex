Imports System.Data.SqlClient

Public Class ActualizaTe


    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection

    Public cadenagi As String
    Public cadenaCgiro As String
    Public cnn2 As SqlConnection

    '' Dim cnn2 As New SqlConnection("data source = GIRO\SQL2008 ;initial catalog=asahi16;user id=sa;password=Pa55word")

    Private Sub ActualizaTe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cnn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress

            Me.cnn2 = conexion.cadenagiro


        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cnn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor


            Me.cnn2 = conexion.cadenagirofor

        End If

    End Sub



    'Sub actualizageneral()







    '    cnn2.Close()


    '    Dim command As New SqlCommand("Sp_actualizaentradasalida", cnn2)
    '    cnn2.Open()

    '        command.CommandType = CommandType.StoredProcedure

    '        Try


    '            command.Parameters.Clear()

    '            command.Parameters.AddWithValue("@Fecha", dtp_todos.Value.ToShortDateString)
    '            command.Parameters.AddWithValue("@clave", 0)
    '            command.Parameters.AddWithValue("@TurnoE", 0)
    '            command.Parameters.AddWithValue("@variable", 1)
    '            command.Parameters.AddWithValue("@id_solicitud", 0)


    '            command.ExecuteNonQuery()



    '        MessageBox.Show("Los cambios se realizaron correctamente", "¡Aviso!")






    '    Catch ex As Exception
    '            MessageBox.Show(ex.ToString)

    '        Finally
    '            cnn2.Close()
    '        End Try

    'End Sub

    Sub actualizaindividual()

        Dim Frmespera As New Frmwait
        Frmespera.Show()
        Frmespera.BringToFront()
        Frmespera.WindowState = FormWindowState.Normal

        cnn2.Close()


        Dim command As New SqlCommand("Sp_actualizaentradasalida", cnn2)
        cnn2.Open()

        command.CommandType = CommandType.StoredProcedure

        Try


            command.Parameters.Clear()

            command.Parameters.AddWithValue("@Fecha", dtp_individual.Value.ToShortDateString)
            command.Parameters.AddWithValue("@clave", txt_clave.Text)
            command.Parameters.AddWithValue("@TurnoE", 0)
            command.Parameters.AddWithValue("@variable", 2)
            command.Parameters.AddWithValue("@id_solicitud", 0)



            command.ExecuteNonQuery()


            Frmespera.Close()
            MessageBox.Show("Los cambios se realizaron correctamente", "¡Aviso!")
            Btn_autorizar.Enabled = False






        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            cnn2.Close()
        End Try



    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    actualizageneral()
    'End Sub

    Private Sub Btn_autorizar_Click(sender As Object, e As EventArgs) Handles Btn_autorizar.Click

        actualizaindividual()

    End Sub


    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            Cnn.Close()
            Cnn.Open()
            Dim SSel As String

            Dim parametro1 As Integer
            parametro1 = txt_clave.Text



            SSel = ("


select CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado

from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig

where  clave = " & parametro1 & "")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, Cnn)
            da.Fill(ds)

            txt_nombre.Text = ds.Tables(0).Rows(0).Item(1)


            Cnn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show("El empleado que ha seleccionado no está activo o no corresponde a su departamento, verifique e intente de nuevo.", "¡Aviso!")
        End Try

    End Sub

    Private Sub txt_clave_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress
        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            muestraetiqueta()
            Btn_autorizar.Enabled = True

        ElseIf AscW(e.KeyChar) = CInt(Keys.Back) Then
            txt_clave.Clear()
            txt_nombre.Clear()
            Btn_autorizar.Enabled = False
        End If
    End Sub



End Class