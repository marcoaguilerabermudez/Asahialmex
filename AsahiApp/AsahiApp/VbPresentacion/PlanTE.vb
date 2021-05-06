Imports System.Data.SqlClient

Public Class PlanTE

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection

    Public cadenagi As String
    Public cadenaCgiro As String
    Public cnn2 As SqlConnection

    Public a As String
    Public b As Integer

    Private Sub PlanTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        lbl_area.Text = Modulo_plante.departamento
        lbl_año.Text = Modulo_plante.año
        lbl_mes.Text = Modulo_plante.mes


        a = lbl_mes.Text
        Select Case a
            Case "ENERO      1 月"
                b = 1
            Case "FEBRERO    2 月"
                b = 2
            Case "MARZO      3 月"
                b = 3
            Case "ABRIL      4 月"
                b = 4
            Case "MAYO       5 月"
                b = 5
            Case "JUNIO      6 月"
                b = 6
            Case "JULIO      7 月"
                b = 7
            Case "AGOSTO     8 月"
                b = 8
            Case "SEPTIEMBRE 9 月"
                b = 9
            Case "OCTUBRE   10 月"
                b = 10
            Case "NOVIEMBRE 11 月"
                b = 11
            Case "DICIEMBRE 12 月"
                b = 12
        End Select

        etiquetas()

    End Sub

    Sub etiquetas()
        Try
            ''  Dim Cnn As New SqlConnection("data source =GIRO\SQL2008 ;initial catalog=asahi16 ;user id=sa;password=Pa55word")
            cnn2.Close()
            cnn2.Open()
            Dim SSel As String
            Dim parametro1 As String
            parametro1 = lbl_area.Text
            Dim parametro2 As Integer
            parametro2 = lbl_año.Text
            Dim parametro3 As Integer
            parametro3 = b

            SSel = (" 
select  rh.id_puesto , rh.dobles, rh.triples, rh.descanso
     FROM [asahi16].[dbo].[Rh_totalpuestos] rh
	 join [asahi16].[Supervisor_giro].[DEPTO] de
	 on de.CLAVE = rh.Id_area
	 where de.DESCRIPCION = '" & parametro1 & "' and mes = " & parametro3 & " and año = " & parametro2 & " and id_tipo = 0
order by rh.id_puesto")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn2)
            da.Fill(ds)
            txt_gerente2.Text = ds.Tables(0).Rows(0).Item(1)
            txt_am2.Text = ds.Tables(0).Rows(1).Item(1)
            txt_su2.Text = ds.Tables(0).Rows(2).Item(1)
            txt_lda2.Text = ds.Tables(0).Rows(3).Item(1)
            txt_staff2.Text = ds.Tables(0).Rows(4).Item(1)
            txt_lider2.Text = ds.Tables(0).Rows(5).Item(1)
            txt_operador2.Text = ds.Tables(0).Rows(6).Item(1)
            txt_cor2.Text = ds.Tables(0).Rows(7).Item(1)
            txt_tra2.Text = ds.Tables(0).Rows(8).Item(1)

            txt_gerente3.Text = ds.Tables(0).Rows(0).Item(2)
            txt_am3.Text = ds.Tables(0).Rows(1).Item(2)
            txt_su3.Text = ds.Tables(0).Rows(2).Item(2)
            txt_lda3.Text = ds.Tables(0).Rows(3).Item(2)
            txt_staff3.Text = ds.Tables(0).Rows(4).Item(2)
            txt_lider3.Text = ds.Tables(0).Rows(5).Item(2)
            txt_operador3.Text = ds.Tables(0).Rows(6).Item(2)
            txt_cor3.Text = ds.Tables(0).Rows(7).Item(2)
            txt_tra3.Text = ds.Tables(0).Rows(8).Item(2)


            txt_gerentedl.Text = ds.Tables(0).Rows(0).Item(3)
            txt_amdl.Text = ds.Tables(0).Rows(1).Item(3)
            txt_sudl.Text = ds.Tables(0).Rows(2).Item(3)
            txt_ldadl.Text = ds.Tables(0).Rows(3).Item(3)
            txt_staffdl.Text = ds.Tables(0).Rows(4).Item(3)
            txt_liderdl.Text = ds.Tables(0).Rows(5).Item(3)
            txt_operadordl.Text = ds.Tables(0).Rows(6).Item(3)
            txt_cordl.Text = ds.Tables(0).Rows(7).Item(3)
            txt_tradl.Text = ds.Tables(0).Rows(8).Item(3)



            cnn2.Close()
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un departamento válido.", "¡Aviso!")
            MessageBox.Show(ex.ToString)

            cnn2.Close()
        End Try
    End Sub


    Sub carga()
        Dim Pregunta As Integer


        Pregunta = MsgBox("¿Desea guardar cambios en su tiempo extra planeado?", vbYesNo + vbExclamation + vbDefaultButton2, "Tiempo Extra")


            If Pregunta = vbYes Then


            cnn2.Close()


            Dim command As New SqlCommand("Sp_actualizaplante", cnn2)
            cnn2.Open()

            command.CommandType = CommandType.StoredProcedure

            Try


                command.Parameters.Clear()




                command.Parameters.AddWithValue("@cantidad1", txt_gerente2.Text)
                command.Parameters.AddWithValue("@cantidad1t", txt_gerente3.Text)
                command.Parameters.AddWithValue("@cantidad1d", txt_gerentedl.Text)

                command.Parameters.AddWithValue("@cantidad2", txt_am2.Text)
                command.Parameters.AddWithValue("@cantidad2t", txt_am3.Text)
                command.Parameters.AddWithValue("@cantidad2d", txt_amdl.Text)

                command.Parameters.AddWithValue("@cantidad3", txt_su2.Text)
                command.Parameters.AddWithValue("@cantidad3t", txt_su3.Text)
                command.Parameters.AddWithValue("@cantidad3d", txt_sudl.Text)

                command.Parameters.AddWithValue("@cantidad4", txt_lda2.Text)
                command.Parameters.AddWithValue("@cantidad4t", txt_lda3.Text)
                command.Parameters.AddWithValue("@cantidad4d", txt_ldadl.Text)

                command.Parameters.AddWithValue("@cantidad5", txt_staff2.Text)
                command.Parameters.AddWithValue("@cantidad5t", txt_staff3.Text)
                command.Parameters.AddWithValue("@cantidad5d", txt_staffdl.Text)

                command.Parameters.AddWithValue("@cantidad6", txt_lider2.Text)
                command.Parameters.AddWithValue("@cantidad6t", txt_lider3.Text)
                command.Parameters.AddWithValue("@cantidad6d", txt_liderdl.Text)

                command.Parameters.AddWithValue("@cantidad7", txt_operador2.Text)
                command.Parameters.AddWithValue("@cantidad7t", txt_operador3.Text)
                command.Parameters.AddWithValue("@cantidad7d", txt_operadordl.Text)

                command.Parameters.AddWithValue("@cantidad8", txt_cor2.Text)
                command.Parameters.AddWithValue("@cantidad8t", txt_cor3.Text)
                command.Parameters.AddWithValue("@cantidad8d", txt_cordl.Text)

                command.Parameters.AddWithValue("@cantidad9", txt_tra2.Text)
                command.Parameters.AddWithValue("@cantidad9t", txt_tra3.Text)
                command.Parameters.AddWithValue("@cantidad9d", txt_tradl.Text)





                command.Parameters.AddWithValue("@año", lbl_año.Text)
                command.Parameters.AddWithValue("@mes", b)
                command.Parameters.AddWithValue("@catalogodepartamento", lbl_area.Text)



                command.ExecuteNonQuery()







                MsgBox("¡Cambios Guardados!", vbInformation, "¡Correcto!")
                cnn2.Close()



            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                MessageBox.Show("Registro no guardado, contacte al área de Sistemas.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cnn2.Close()
            End Try



        ElseIf Pregunta = vbNo Then

            MessageBox.Show("Acción no completada", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        carga()
    End Sub
End Class