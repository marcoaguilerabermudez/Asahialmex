Imports System.Data.SqlClient
Public Class Requerimientos_CargaXML
    Dim var_provision As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer
    Dim estado_prov As Integer

    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String
    Dim filtro As Integer

    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub
    Private Sub Requerimientos_CargaXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load



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





        estado_prov = Modulo_vistarecepprincipal.e_estadoprov


        If estado_prov = 1 Then

            lbl_proveedor.Text = Modulo_vistarecepprincipal.e_proveedor
            lbl_provi.Text = Modulo_vistarecepprincipal.e_provision
            lbl_rfc.Text = Modulo_vistarecepprincipal.e_rfc
            lbl_subtotal.Text = Format(CType(Modulo_vistarecepprincipal.e_subtotal, Decimal), "#,##0.00")
            lbl_total.Text = Format(CType(Modulo_vistarecepprincipal.e_total, Decimal), "#,##0.00")
            lbl_foliofact.Text = Modulo_vistarecepprincipal.e_folio
            lbl_uuid.Text = Modulo_vistarecepprincipal.e_uuid
            dtp1.Value = Modulo_vistarecepprincipal.e_ffac
            dtp2.Value = Modulo_vistarecepprincipal.e_fpago
            lbl_subtotalfact.Text = Format(CType(Modulo_vistarecepprincipal.e_fsub, Decimal), "#,##0.00")
            lbl_totalfact.Text = Format(CType(Modulo_vistarecepprincipal.e_ftotal, Decimal), "#,##0.00")
            txt_busca.Text = Modulo_vistarecepprincipal.e_uuid
            btn_doc.Enabled = True
            btn_quitar.Visible = True
            lbl_moneda.Text = Modulo_vistarecepprincipal.e_moneda
            btn_fil2.Text = "Modificar"
        ElseIf estado_prov = 2 Then

            lbl_proveedor.Text = Modulo_vistarecepprincipal.e_proveedor
            lbl_provi.Text = Modulo_vistarecepprincipal.e_provision
            lbl_rfc.Text = Modulo_vistarecepprincipal.e_rfc
            lbl_subtotal.Text = Format(CType(Modulo_vistarecepprincipal.e_subtotal, Decimal), "#,##0.00")
            lbl_total.Text = Format(CType(Modulo_vistarecepprincipal.e_total, Decimal), "#,##0.00")
            lbl_foliofact.Text = Modulo_vistarecepprincipal.e_folio
            lbl_uuid.Text = Modulo_vistarecepprincipal.e_uuid
            dtp1.Value = Modulo_vistarecepprincipal.e_ffac
            dtp2.Value = Modulo_vistarecepprincipal.e_fpago
            lbl_subtotalfact.Text = Format(CType(Modulo_vistarecepprincipal.e_fsub, Decimal), "#,##0.00")
            lbl_totalfact.Text = Format(CType(Modulo_vistarecepprincipal.e_ftotal, Decimal), "#,##0.00")
            txt_busca.Text = Modulo_vistarecepprincipal.e_uuid
            btn_doc.Enabled = True
            btn_quitar.Visible = True
            lbl_moneda.Text = Modulo_vistarecepprincipal.e_moneda
            btn_fil2.Text = "Modificar"
        Else

            lbl_proveedor.Text = Modulo_vistarecepprincipal.e_proveedor
            lbl_provi.Text = Modulo_vistarecepprincipal.e_provision
            lbl_rfc.Text = Modulo_vistarecepprincipal.e_rfc
            lbl_subtotal.Text = Format(CType(Modulo_vistarecepprincipal.e_subtotal, Decimal), "#,##0.00")
            lbl_total.Text = Format(CType(Modulo_vistarecepprincipal.e_total, Decimal), "#,##0.00")
            lbl_foliofact.Text = ""
            lbl_uuid.Text = ""
            txt_busca.Text = ""
            dtp1.Value = Today.Date
            dtp2.Value = Today.Date
            lbl_subtotalfact.Text = 0
            lbl_totalfact.Text = 0
            filtro = 0
            btn_quitar.Visible = False
            lbl_moneda.Text = Modulo_vistarecepprincipal.e_moneda
            btn_fil2.Text = "Guardar"
        End If



        predictivo()

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing



    End Sub

    Sub predictivo()
        Dim cmd As New SqlCommand("     if " & filtro & " = 0
begin


SELECT  upper([uuid]) as 'f'
  FROM [Asahi].[dbo].[Netsuite_XML]
  WHERE RFCEmisor = '" & lbl_rfc.Text & "' AND id_provision is null

  end 
  else if " & filtro & "  = 1
  begin 


  SELECT upper([folio]) as 'f'
  FROM [Asahi].[dbo].[Netsuite_XML]
  WHERE RFCEmisor = '" & lbl_rfc.Text & "' and id_provision is null
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


SELECT  [UUID]
      ,upper([UUID])
      ,[RFCEmisor]
      ,[RazonSocialEmisor]
      ,'a'
      ,[folio]
      ,[FechaTimbrado]
      ,[FechaTimbrado]
      ,[id_provision]
      ,[estado]
      ,[moneda]
      ,
[total] 

,
[subtotal]

  FROM [Asahi].[dbo].[Netsuite_XML]
  WHERE [Uuid] = @selec

  end 
  else if @tipo = 1
  begin 
SELECT  [UUID]
      ,upper([UUID])
      ,[RFCEmisor]
      ,[RazonSocialEmisor]
      ,'a'
      ,[folio]
      ,[FechaTimbrado]
      ,[FechaTimbrado]
      ,[id_provision]
      ,[estado]
      ,[moneda]
      ,
[total]  

,
[subtotal]

  FROM [Asahi].[dbo].[Netsuite_XML]
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
            MessageBox.Show(ex.ToString)
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
            lbl_totalfact.Enabled = True
            btn_fil2.Enabled = False
        Else
            dtp1.Enabled = False
            lbl_subtotalfact.Enabled = False
            lbl_totalfact.Enabled = False
            btn_fil2.Enabled = True
        End If
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        If txt_busca.Text = "" Then
            btn_doc.Enabled = False
            lbl_uuid.Text = ""
            lbl_foliofact.Text = ""
            lbl_subtotalfact.Text = 0
            lbl_totalfact.Text = 0

        Else
            btn_doc.Enabled = True
        End If
    End Sub


    Sub CargaModificaInserta()
        cnn.Close()
        '  cnn.Open()

        Dim agrega As New SqlCommand("Sp_InsertaActualizaEliminaXMLProvision", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        agrega.CommandType = CommandType.StoredProcedure


        Try

            agrega.Parameters.Clear()
            agrega.Parameters.Add("@var", SqlDbType.Int).Value = var_provision
            agrega.Parameters.Add("@id_provision", SqlDbType.Int).Value = lbl_provi.Text
            agrega.Parameters.Add("@uuid", SqlDbType.VarChar, 150).Value = lbl_uuid.Text
            agrega.Parameters.Add("@f_factura", SqlDbType.Date).Value = dtp1.Value.ToShortDateString
            agrega.Parameters.Add("@f_pago", SqlDbType.Date).Value = dtp2.Value.ToShortDateString
            agrega.Parameters.Add("@subtotalp", SqlDbType.Money).Value = lbl_subtotalfact.Text
            agrega.Parameters.Add("@totalp", SqlDbType.Money).Value = lbl_totalfact.Text
            agrega.Parameters.Add("@folio", SqlDbType.VarChar, 100).Value = lbl_foliofact.Text



            agrega.ExecuteNonQuery()


            cnn.Close()

            MessageBox.Show("Acción completada correctmento", "¡Aviso!")
            Me.Dispose()



        Catch ex As Exception
            MessageBox.Show("Error, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()

            'cargagrid()
        Finally
            cnn.Close()
        End Try

        'Dim Req_RecPO As New RequerimientosRecepcionesPO(id, depto, permiso, nombre, p_vales)

        'Req_RecPO.cargagrid()
        '  Req_RecPO.cargagrid()
    End Sub

    Private Sub btn_quitar_Click(sender As Object, e As EventArgs) Handles btn_quitar.Click

        Dim Pregunta As Integer

        Pregunta = MsgBox("¿Desea eliminar el xml que está ligado a la provisión: " & lbl_provi.Text & " ?", vbYesNo + vbExclamation + vbDefaultButton2, "")

        If Pregunta = vbYes Then
            var_provision = 1
            CargaModificaInserta()
        Else
            MessageBox.Show("Acción no completada", "¡Aviso!")
        End If



    End Sub

    Private Sub btn_fil2_Click(sender As Object, e As EventArgs) Handles btn_fil2.Click


        'Dim Pregunta As Integer
        'Dim dif As Double


        'If estado_prov = 1 Then
        '    var_provision = 2

        '    If CDbl(lbl_total.Text) > CDbl(lbl_totalfact.Text) Then
        '        MessageBox.Show("El total del XML que desea sustituir es mayor al que desea cambiar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    ElseIf CDbl(lbl_total.Text) < CDbl(lbl_totalfact.Text) Then
        '        MessageBox.Show("El total del XML que desea sustituir es menor al que desea cambiar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    ElseIf CDbl(lbl_total.Text) = CDbl(lbl_totalfact.Text) Then
        '        Pregunta = MsgBox("¿Desea modificar el xml que está ligado a la provisión: " & lbl_provi.Text & " ?", vbYesNo + vbExclamation + vbDefaultButton2, "")
        '    End If


        'ElseIf estado_prov = 0 Then
        '        var_provision = 0

        '    If CDbl(lbl_total.Text) > CDbl(lbl_totalfact.Text) Then
        '        MessageBox.Show("El total de la recepción es mayor al total del xml que desea ligar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    ElseIf CDbl(lbl_total.Text) < CDbl(lbl_totalfact.Text) Then
        '        MessageBox.Show("El total de la recepción es menor al total del xml que desea ligar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    ElseIf CDbl(lbl_total.Text) = CDbl(lbl_totalfact.Text) Then
        '        Pregunta = MsgBox("¿Desea ligar el xml a la provisión: " & lbl_provi.Text & " ?", vbYesNo + vbExclamation + vbDefaultButton2, "")
        '    End If

        'End If



        'If Pregunta = vbYes Then

        '    CargaModificaInserta()
        'Else
        '    MessageBox.Show("Acción no completada", "¡Aviso!")
        'End If


        If estado_prov = 1 Then
            var_provision = 2



            If lbl_moneda.Text = "MEX" Then

                If CDbl(lbl_totalfact.Text) - CDbl(lbl_total.Text) > 0.99 Then
                    MessageBox.Show("El total de la factura es mayor al total de lo que se recibió con anterioridad, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 99 centavos)", "¡Aviso!")
                ElseIf CDbl(lbl_total.Text) - CDbl(lbl_totalfact.Text) > 0.99 Then
                    MessageBox.Show("El total de lo que se recibió con anteriridad es mayor al total de la factura, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 99 centavos)", "¡Aviso!")
                Else
                    Dim Pregunta As Integer

                    Pregunta = MsgBox("¿Desea modificar el xml que está ligado a la provisión: " & lbl_provi.Text & " ?", vbYesNo + vbExclamation + vbDefaultButton2, "")

                    If Pregunta = vbYes Then
                        CargaModificaInserta()
                    Else
                        MessageBox.Show("Acción no completada", "¡Aviso!")
                    End If
                End If

            ElseIf lbl_moneda.Text = "USD" Then

                If CDbl(lbl_totalfact.Text) - CDbl(lbl_total.Text) > 0.05 Then
                    MessageBox.Show("El total de la factura es mayor al total de lo que se recibió con anterioridad, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 5 centavos)", "¡Aviso!")
                ElseIf CDbl(lbl_total.Text) - CDbl(lbl_totalfact.Text) > 0.05 Then
                    MessageBox.Show("El total de lo que se recibió con anteriridad es mayor al total de la factura, revise de nuevo sus cantidades y documentos.  (Recuerde que tiene una tolerancia de 5 centavos)", "¡Aviso!")
                Else
                    Dim Pregunta As Integer

                    Pregunta = MsgBox("¿Desea modificar el xml que está ligado a la provisión: " & lbl_provi.Text & " ?", vbYesNo + vbExclamation + vbDefaultButton2, "")

                    If Pregunta = vbYes Then
                        CargaModificaInserta()
                    Else
                        MessageBox.Show("Acción no completada", "¡Aviso!")
                    End If
                End If

            End If

        ElseIf estado_prov = 0 Then
            var_provision = 0


            If lbl_moneda.Text = "MEX" Then

                If CDbl(lbl_totalfact.Text) - CDbl(lbl_total.Text) > 0.99 Then
                    MessageBox.Show("El total de la factura es mayor al total de lo que se recibió con anterioridad, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 99 centavos)", "¡Aviso!")
                ElseIf CDbl(lbl_total.Text) - CDbl(lbl_totalfact.Text) > 0.99 Then
                    MessageBox.Show("El total de lo que se recibió con anteriridad es mayor al total de la factura, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 99 centavos)", "¡Aviso!")
                Else
                    Dim Pregunta As Integer

                    Pregunta = MsgBox("¿Desea ligar el xml a la provisión: " & lbl_provi.Text & " ?", vbYesNo + vbExclamation + vbDefaultButton2, "")

                    If Pregunta = vbYes Then
                        CargaModificaInserta()
                    Else
                        MessageBox.Show("Acción no completada", "¡Aviso!")
                    End If
                End If

            ElseIf lbl_moneda.Text = "USD" Then

                If CDbl(lbl_totalfact.Text) - CDbl(lbl_total.Text) > 0.05 Then
                    MessageBox.Show("El total de la factura es mayor al total de lo que se recibió con anterioridad, revise de nuevo sus cantidades y documentos. (Recuerde que tiene una tolerancia de 5 centavos)", "¡Aviso!")
                ElseIf CDbl(lbl_total.Text) - CDbl(lbl_totalfact.Text) > 0.05 Then
                    MessageBox.Show("El total de lo que se recibió con anteriridad es mayor al total de la factura, revise de nuevo sus cantidades y documentos.  (Recuerde que tiene una tolerancia de 5 centavos)", "¡Aviso!")
                Else
                    Dim Pregunta As Integer

                    Pregunta = MsgBox("¿Desea ligar el xml a la provisión: " & lbl_provi.Text & " ?", vbYesNo + vbExclamation + vbDefaultButton2, "")

                    If Pregunta = vbYes Then
                        CargaModificaInserta()
                    Else
                        MessageBox.Show("Acción no completada", "¡Aviso!")
                    End If
                End If

            End If
        End If


    End Sub
End Class