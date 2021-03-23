Imports System.Data.SqlClient

Public Class ActualizaTurnoSolicitud
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Dim variable As Integer
    Dim fecha As String
    Dim claveprincipal As Integer


    Dim id_depa As Integer
    Dim id_id As Integer
    Dim id_permiso As Integer

    Private Sub ActualizaTurnoSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            Cn.Close()


            Dim command As New SqlCommand("Sp_actualizaentradaysalidaRh", Cn)
            Cn.Open()

            command.CommandType = CommandType.StoredProcedure

            Try


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@Fecha", "01/01/2000")
                command.Parameters.AddWithValue("@clave", lbl_clave.Text)
                command.Parameters.AddWithValue("@TurnoE", cbx_textra.Text)
                command.Parameters.AddWithValue("@variable", 3)
                command.Parameters.AddWithValue("@id_solicitud", variable)


                command.ExecuteNonQuery()



                MessageBox.Show("Los cambios se realizaron correctamente", "¡Se ha modificado el turno a laborar!")






            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            Finally
                Cn.Close()
            End Try

        Else
            Cn.Close()
        End If
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizar()

        Dim solte As New SolicitudTE(id_id, id_depa, id_permiso)
        solte.Show()
        Me.Dispose()
        Me.Close()
    End Sub


End Class