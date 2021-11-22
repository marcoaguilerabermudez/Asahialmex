Imports System.Data.SqlClient

Public Class Requerimientos_MuestraMovimientoProvisionPO
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String
    Dim edo_provi As Integer
    Dim filtro As Integer

    Private Sub Requerimientos_MuestraMovimientoProvisionPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            lbl_rfc.Text = Modulo_vistarecepprincipal.e_rfc
            lbl_proveedor.Text = Modulo_vistarecepprincipal.e_proveedor
            lbl_moneda.Text = Modulo_vistarecepprincipal.e_moneda

            lbl_foliofact.Text = Modulo_vistarecepprincipal.e_folio
            lbl_uuid.Text = Modulo_vistarecepprincipal.e_uuid
            lbl_prov.Text = Modulo_vistarecepprincipal.e_provision
            edo_provi = Modulo_vistarecepprincipal.e_estadoprov
            dtp1.Value = Modulo_vistarecepprincipal.e_ffac
            dtp2.Value = Modulo_vistarecepprincipal.e_fpago
            lbl_subtotalfact.Text = Modulo_vistarecepprincipal.e_fsub
            lbl_totalfact.Text = Modulo_vistarecepprincipal.e_ftotal


        Catch
        End Try


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



        If edo_provi = 3 Then
            Panel1.Visible = True
            Panel2.Visible = True
        Else
            Panel1.Visible = False
            Panel2.Visible = False

        End If

        cargagrid()
        filtro = 0
    End Sub


    Sub cargagrid()


        cnn.Close()
        cnn.Open()

        '   MessageBox.Show(cnn.ToString)
        Try



            Dim da As New SqlDataAdapter("Sp_muestragridmodificaRecepcionconPO", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@codigo", lbl_prov.Text)
            da.SelectCommand.Parameters.AddWithValue("@serie", 0)
            da.SelectCommand.Parameters.AddWithValue("@coal", "")
            da.SelectCommand.Parameters.AddWithValue("@id_cotizacion", 0)
            da.SelectCommand.Parameters.AddWithValue("@var", 3)

            'MessageBox.Show(txt_no.Text)
            'MessageBox.Show(cbx_serie.Text)

            Dim dt As New DataTable

            da.Fill(dt)

            dtgvp.DataSource = dt
            'dtgvp.Columns("Recepcion").Width = 70
            'dtgvp.Columns("Folio").Width = 85
            'dtgvp.Columns("UUID").Width = 200
            '  dtgvp.Columns("Departamento").Width = 130

            dtgvp.Columns("Fecha de recepcion").Width = 80
            dtgvp.Columns("Codigo").Width = 65
            dtgvp.Columns("Requerimiento").Width = 88
            dtgvp.Columns("Nombre").Width = 300
            dtgvp.Columns("No parte").Width = 100
            dtgvp.Columns("Cantidad recibida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns("Fecha de pago real").Width = 65
            'dtgvp.Columns("Fecha de provisión").Width = 65
            'dtgvp.Columns("Fecha de factura").Width = 60
            'dtgvp.Columns("Fecha de pago").Width = 60
            'dtgvp.Columns("Subtotal").Width = 60
            'dtgvp.Columns("Total").Width = 60
            'dtgvp.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dtgvp.Columns("Fecha de recepcion").ReadOnly = True
            dtgvp.Columns("Cantidad recibida").ReadOnly = True
            dtgvp.Columns("Codigo").ReadOnly = True
            dtgvp.Columns("Nombre").ReadOnly = True
            dtgvp.Columns("No parte").ReadOnly = True
            dtgvp.Columns("Requerimiento").ReadOnly = True


            dtgvp.Columns("Recepcion").Visible = False
            dtgvp.Columns("Folio").Visible = False
            dtgvp.Columns("UUID").Visible = False
            dtgvp.Columns("totals").Visible = False
            dtgvp.Columns("totalx").Visible = False
            ' dtgvp.Columns("id_mov").Visible = False

            '  cnn.Close()

            dtgvp.Visible = True
            predictivo()
            totales()
            '  dtgvp.Refresh()

            If dtgvp.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")
                dtgvp.Visible = False

            End If







            'If (depto <> 19 Or depto <> 7) Then
            '    dtgvp.Columns.Remove("X")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub


    Sub totales()

        Try
            Dim Total As Double
            Dim Total1 As Double


            Dim Col As Integer = Me.dtgvp.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.dtgvp.Rows
                'If row.Cells("x").Value = True Then
                Total += Val(row.Cells("Totals").Value)
                Total1 += Val(row.Cells("Totalx").Value)
            Next


            lbl_neto.Text = Format(CType(Total, Decimal), "#,##0.00")
            lbl_t.Text = Format(CType(Total1, Decimal), "#,##0.00")

        Catch
        End Try


    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click




        If lbl_moneda.Text = "MEX" Then

                If CDbl(lbl_totalfact.Text) - CDbl(lbl_t.Text) > 0.99 Then
                    MessageBox.Show("El total de la factura es mayor al total de lo que está recibiendo, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 99 centavos)", "¡Aviso!")
                ElseIf CDbl(lbl_t.Text) - CDbl(lbl_totalfact.Text) > 0.99 Then
                    MessageBox.Show("El total de lo que estpa recibiendo es mayor al total de la factura, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 99 centavos)", "¡Aviso!")
                Else
                    Dim Pregunta As Integer

                    Pregunta = MsgBox("¿Desea cargar el registro con las cantidades que ha registrado?", vbYesNo + vbExclamation + vbDefaultButton2, "Crear documento de provisión")

                    If Pregunta = vbYes Then
                    crearrecepcion()
                    insertarfilas()
                Else
                    MessageBox.Show("Acción no completada", "¡Aviso!")
                    End If
                End If

            ElseIf lbl_moneda.Text = "USD" Then

                If CDbl(lbl_totalfact.Text) - CDbl(lbl_t.Text) > 0.05 Then
                    MessageBox.Show("El total de la factura es mayor al total de lo que está recibiendo, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 5 centavos)", "¡Aviso!")
                ElseIf CDbl(lbl_t.Text) - CDbl(lbl_totalfact.Text) > 0.05 Then
                    MessageBox.Show("El total de lo que estpa recibiendo es mayor al total de la factura, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 5 centavos)", "¡Aviso!")
                Else
                    Dim Pregunta As Integer

                    Pregunta = MsgBox("¿Desea cargar el registro con las cantidades que ha registrado?", vbYesNo + vbExclamation + vbDefaultButton2, "Crear documento de provisión")

                    If Pregunta = vbYes Then
                    crearrecepcion()
                    insertarfilas()
                Else
                    MessageBox.Show("Acción no completada", "¡Aviso!")
                    End If
                End If

            End If





        'Dim Pregunta As Integer

        'Pregunta = MsgBox("¿Desea cargar el registro con las cantidades que ha registrado?", vbYesNo + vbExclamation + vbDefaultButton2, "Crear documento de provisión")

        'If Pregunta = vbYes Then
        '    crearrecepcion()
        '    insertarfilas()
        'Else
        '    MessageBox.Show("Acción no completada", "¡Aviso!")
        'End If




    End Sub

    Sub predictivo()
        Dim cmd As New SqlCommand("     if " & filtro & " = 0
begin


SELECT  upper([uid]) as 'f'
  FROM [Asahi].[dbo].[XML_principal]
  WHERE emi_rfc = '" & lbl_rfc.Text & "' AND id_provision is null

  end 
  else if " & filtro & "  = 1
  begin 


  SELECT upper([folio]) as 'f'
  FROM [Asahi].[dbo].[XML_principal]
  WHERE emi_rfc = '" & lbl_rfc.Text & "' and id_provision is null
  end  ", cnn)
        If cnn.State = ConnectionState.Closed Then cnn.Open()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "Autofill")

        Dim col As New AutoCompleteStringCollection

        Dim i As Integer


        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("f").ToString())
        Next



        txt_busca.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_busca.AutoCompleteCustomSource = col
        txt_busca.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub


    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            cnn.Close()
            cnn.Open()
            Dim SSel As String



            SSel = ("


declare @tipo as int
set @tipo = " & filtro & "


declare @selec as varchar(120)
set @selec = '" & txt_busca.Text & "'

if @tipo = 0
begin


SELECT  [id]
      ,upper([uid])
      ,[emi_rfc]
      ,[nombre_emisor]
      ,[serie]
      ,[folio]
      ,[fecha]
      ,[fecha_timbrado]
      ,[id_provision]
      ,[estado]
      ,[moneda]
      ,[total]
      ,[subtotal]
  FROM [Asahi].[dbo].[XML_principal]
  WHERE [Uid] = @selec

  end 
  else if @tipo = 1
  begin 
  SELECT  [id]
      ,upper([uid])
       ,[emi_rfc]
      ,[nombre_emisor]
      ,[serie]
      ,[folio]
      ,[fecha]
      ,[fecha_timbrado]
      ,[id_provision]
      ,[estado]
      ,[moneda]
      ,[total]
      ,[subtotal]
  FROM [Asahi].[dbo].[XML_principal]
  WHERE folio = @selec
  end ")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()

            da = New SqlDataAdapter(SSel, cnn)

            da.Fill(ds)

            lbl_foliofact.Text = ds.Tables(0).Rows(0).Item(5)
            lbl_uuid.Text = ds.Tables(0).Rows(0).Item(1)
            dtp1.Value = ds.Tables(0).Rows(0).Item(6)
            lbl_subtotalfact.Text = Format(CType(ds.Tables(0).Rows(0).Item(12), Decimal), "#,##0.00")
            lbl_totalfact.Text = Format(CType(ds.Tables(0).Rows(0).Item(11), Decimal), "#,##0.00")




            cnn.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
            MessageBox.Show("El registro que está tecleando es incorrecto, revise de nueva cuenta", "¡Aviso!")

            txt_busca.Clear()
            txt_busca.Focus()
            lbl_subtotalfact.Text = 0
            lbl_foliofact.Text = ""
            lbl_uuid.Text = ""
            lbl_totalfact.Text = 0

        End Try



    End Sub
    Private Sub rbt_falta_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_falta.CheckedChanged

        filtro = 0
        predictivo()
        lbl_txtfiltro.Text = "UUID"
        txt_busca.Text = ""
        lbl_totalfact.Text = 0
        lbl_subtotalfact.Text = 0
        lbl_uuid.Text = ""
        lbl_foliofact.Text = ""

    End Sub

    Private Sub rbt_retardo_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_retardo.CheckedChanged

        filtro = 1
        predictivo()
        lbl_txtfiltro.Text = "Folio"
        txt_busca.Text = ""
        lbl_totalfact.Text = 0
        lbl_subtotalfact.Text = 0
        lbl_uuid.Text = ""
        lbl_foliofact.Text = ""

    End Sub

    Private Sub btn_doc_Click(sender As Object, e As EventArgs) Handles btn_doc.Click

        muestraetiqueta()

    End Sub


    Private Sub lbl_uuid_TextChanged(sender As Object, e As EventArgs) Handles lbl_uuid.TextChanged

        If lbl_uuid.Text = "" Then
            dtp1.Enabled = True
            lbl_subtotalfact.Enabled = True
            lbl_foliofact.Enabled = True
            lbl_totalfact.Enabled = True
        Else
            dtp1.Enabled = False
            lbl_subtotalfact.Enabled = False
            lbl_totalfact.Enabled = False
            lbl_foliofact.Enabled = False
        End If
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        If txt_busca.Text = "" Then
            btn_doc.Enabled = False

            lbl_subtotalfact.Text = 0
            lbl_foliofact.Text = ""
            lbl_uuid.Text = ""
            lbl_totalfact.Text = 0
        Else
            btn_doc.Enabled = True
            lbl_subtotalfact.Text = 0
            lbl_foliofact.Text = ""
            lbl_uuid.Text = ""
            lbl_totalfact.Text = 0
        End If
    End Sub


    Sub crearrecepcion()
        cnn.Close()
        '  cnn.Open()

        Dim agrega As New SqlCommand("Sp_RecepcionConPO", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        agrega.CommandType = CommandType.StoredProcedure


        Try

            agrega.Parameters.Clear()

            'Verificar que estado pondremos


            agrega.Parameters.Add("@id_po", SqlDbType.Int).Value = 0
            agrega.Parameters.Add("@f_factura", SqlDbType.Date).Value = dtp1.Value.ToShortDateString
            agrega.Parameters.Add("@f_pago", SqlDbType.Date).Value = dtp2.Value.ToShortDateString
            agrega.Parameters.Add("@subtotal", SqlDbType.Money).Value = lbl_neto.Text
            agrega.Parameters.Add("@total", SqlDbType.Money).Value = lbl_t.Text
            agrega.Parameters.Add("@moneda", SqlDbType.VarChar, 3).Value = lbl_moneda.Text
            agrega.Parameters.Add("@uuid", SqlDbType.VarChar, 150).Value = lbl_uuid.Text
            agrega.Parameters.Add("@rfc", SqlDbType.VarChar, 50).Value = lbl_rfc.Text
            agrega.Parameters.Add("@var", SqlDbType.Int).Value = 1
            agrega.Parameters.Add("@folio", SqlDbType.VarChar, 100).Value = lbl_foliofact.Text
            agrega.Parameters.Add("@id_provision", SqlDbType.Int).Value = lbl_prov.Text


            agrega.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()

            'cargagrid()
        Finally
            cnn.Close()
        End Try


    End Sub


    Sub insertarfilas()



        cnn.Close()

        cnn.Close()


        Dim command As New SqlCommand("Sp_RecepcionConPoMovimiento", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Try

            For Each fila In dtgvp.Rows


                command.Parameters.Clear()




                command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))

                command.Parameters.AddWithValue("@cantidad", (fila.Cells("Cantidad recibida").Value))
                command.Parameters.AddWithValue("@precio", (fila.Cells("Precio").Value))
                command.Parameters.AddWithValue("@subtotal", 0)
                command.Parameters.AddWithValue("@id_movpo", (fila.Cells("id_mov").Value))
                command.Parameters.AddWithValue("@id_cotizacion", 0)
                command.Parameters.AddWithValue("@req", (fila.Cells("Requerimiento").Value))
                command.Parameters.AddWithValue("@id_po", lbl_prov.Text)
                command.Parameters.AddWithValue("@var", 2)



                command.ExecuteNonQuery()


            Next

            MessageBox.Show("Provisión actualizada", "¡Correcto!", MessageBoxButtons.OK)




        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try

    End Sub

End Class