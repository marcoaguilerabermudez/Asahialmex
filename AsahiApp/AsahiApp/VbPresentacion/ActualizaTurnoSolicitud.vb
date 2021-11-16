Imports System.Data.SqlClient

Public Class ActualizaTurnoSolicitud
    '  Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Dim variable As Integer
    Dim fecha As String
    Dim claveprincipal As Integer

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cn As SqlConnection

    Dim id_depa As Integer
    Dim id_id As Integer
    Dim id_permiso As Integer



    Private Sub ActualizaTurnoSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress
        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor
        End If


        lbl_clave.Text = Modulo_sollicitudte.e_clave
        lbl_nombre.Text = Modulo_sollicitudte.e_empleado
        lbl_turno.Text = Modulo_sollicitudte.e_turno
        variable = Modulo_sollicitudte.e_id
        fecha = Modulo_sollicitudte.e_fecha
        claveprincipal = Modulo_sollicitudte.e_claveprincipal

        id_depa = Modulo_sollicitudte.id_depa
        id_id = Modulo_sollicitudte.id_id
        id_permiso = Modulo_sollicitudte.id_permiso


    End Sub




    Sub actualizar()

        Dim Pregunta As Integer = MsgBox("¿Desea modificar el turno extra a laborar?", vbYesNo + vbExclamation + vbDefaultButton2, "¡Aviso!")

        If Pregunta = vbYes Then

            cn.Close()


            Dim command As New SqlCommand("Sp_actualizaentradaysalidaRh", cn)
            cn.Open()

            command.CommandType = CommandType.StoredProcedure

            Try


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@Fecha", fecha)
                command.Parameters.AddWithValue("@clave", lbl_clave.Text)
                command.Parameters.AddWithValue("@TurnoE", cbx_textra.Text)
                command.Parameters.AddWithValue("@variable", 3)
                command.Parameters.AddWithValue("@id_solicitud", variable)
                command.Parameters.AddWithValue("@parcial", txt_horas.Text)


                command.ExecuteNonQuery()



                MessageBox.Show("Los cambios se realizaron correctamente", "¡Se ha modificado el turno a laborar!")


            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            Finally
                cn.Close()
            End Try

        Else
            cn.Close()
        End If

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_actualiza.Click
        actualizar()

        Dim solte As New SolicitudTE(id_id, id_depa, id_permiso)
        solte.Show()
        Me.Dispose()
        Me.Close()
    End Sub



    Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyClass.FormClosing
        Dim solte As New SolicitudTE(id_id, id_depa, id_permiso)
        solte.Show()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub cbx_textra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_textra.SelectedIndexChanged

        txt_horas.Enabled = True

        If cbx_textra.Text = "Administrativo" Then
            txt_horas.Text = 9
        ElseIf cbx_textra.Text = "Matutino" Then
            txt_horas.Text = 8.5
        ElseIf cbx_textra.Text = "Vespertino" Then
            txt_horas.Text = 8
        ElseIf cbx_textra.Text = "Nocturno" Then
            txt_horas.Text = 7.5
        ElseIf cbx_textra.Text = "12 M" Then
            txt_horas.Text = 11
        ElseIf cbx_textra.Text = "12 N" Then
            txt_horas.Text = 11.5

        End If

        btn_actualiza.Enabled = True

    End Sub
End Class