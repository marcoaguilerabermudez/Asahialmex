Imports System.Data.SqlClient

Public Class Modificacion_de_Turno


    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cn As SqlConnection


    Dim id As Integer
    Dim permiso As Integer
    Dim depto As String

    Sub New(id As Integer, depto As String, permiso As Integer)

        InitializeComponent()

        Me.id = id
        Me.depto = depto
        Me.permiso = permiso

    End Sub


    Private Sub Modificacion_de_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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





        lbl_nombre.Text = Modulo_Turno.parametro2
        lbl_clave.Text = Modulo_Turno.parametro
        lbl_dpto.Text = Modulo_Turno.parametro3
        etiquetas()
    End Sub


    Sub etiquetas()
        Try

            cn.Open()
            Dim SSel As String

            SSel = ("     
  
  select top 1 convert(date,[FECHA_ENTRADA]),
(select case  
       when CATALOGO = 1 then 'Matutino'
   when CATALOGO =  2 then 'Vespertino'
   when CATALOGO =  3 then 'Nocturno'
   when CATALOGO =  10 then 'Administrativo'
   when CATALOGO =  5 then 'Mazda día'
   when CATALOGO =  6 then 'Mazda noche'
   when CATALOGO =  7 then '12 M'
   when CATALOGO =  8 then '12 N'
   else 'Error'
end
FROM giro.[asahi16].[Supervisor_giro].[Empturno]
where [FECHA_ENTRADA] = (select top 1 [FECHA_ENTRADA]
FROM giro.[asahi16].[Supervisor_giro].[Empturno] t
where clave = " & lbl_clave.Text & " 
order by FECHA_ENTRADA desc) and [Clave] = " & lbl_clave.Text & " ) as 'Turno'
FROM giro.[asahi16].[Supervisor_giro].[Empturno] t
where clave = " & lbl_clave.Text & "
order by FECHA_ENTRADA desc
  
  ")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cn)
            da.Fill(ds)


            txt_fecha.Value = ds.Tables(0).Rows(0).Item(0)
            txt_turno.Text = ds.Tables(0).Rows(0).Item(1)


            cn.Close()


        Catch ex As Exception

            cn.Close()
        End Try

    End Sub

    Private Sub cbox_turno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_turno.SelectedIndexChanged
        If cbox_turno.Text = "" Then
            btn_mod.Enabled = False
        Else
            btn_mod.Enabled = True
        End If
    End Sub


    Sub ProcesaCambiodeTurno()


        cn.Close()
        cn.Open()

        Dim command As New SqlCommand("Sp_cambiodeturno", cn)

        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Dim Pregunta As Integer

        Pregunta = MsgBox("¿Desea modificar el turno? verifique bien su información antes de aceptar.", vbYesNo + vbExclamation + vbDefaultButton2, "Modificación de turno")


        If Pregunta = vbYes Then

            Try




                command.Parameters.Clear()

                command.Parameters.AddWithValue("@clave", lbl_clave.Text)
                command.Parameters.AddWithValue("@fecha", txt_fecha.Value.ToShortDateString)
                command.Parameters.AddWithValue("@turno", cbox_turno.Text)
                command.Parameters.AddWithValue("@variable", 2)
                command.Parameters.AddWithValue("@id", id)



                command.ExecuteNonQuery()



                MessageBox.Show("Correcto, turno cambiado exitosamente", "¡Carga exitosa!")


            Catch ex As Exception

                MessageBox.Show(ex.ToString)

            Finally
                cn.Close()
            End Try

        Else

            MessageBox.Show("Acción no completada", "¡Aviso!")

        End If


    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        ProcesaCambiodeTurno()
    End Sub

    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        Me.Dispose()
        Dim CambioTurno As New Frm_cambiodeturno(id, depto, permiso)
        CambioTurno.Show()
    End Sub
End Class