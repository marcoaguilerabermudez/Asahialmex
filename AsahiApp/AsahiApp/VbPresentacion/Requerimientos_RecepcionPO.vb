Imports System.Data.SqlClient

''Variable 'excep'
'0 -> Proveedores comunes
'1 -> Proveedores que puerden tomar facturas de diferentes emisores
'2 -> Proveedores en los que se debe cuadrar el monto de la factura con la PO


Public Class Requerimientos_RecepcionPO
    Dim var_filtro As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer

    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String

    Dim Cantidad_Requerida As Double
    Dim filtro As Integer
    Dim y As Integer
    Dim id_po As Integer
    Dim excep As Integer


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub Requerimientos_RecepcionPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        filtro = 0

    End Sub


    Sub cargagrid()

        Try
            dtgvp.Columns.Remove("X")
            dtgvp.Columns.Remove("Totals")
            dtgvp.Columns.Remove("Totalx")
        Catch ex As Exception

        End Try


        Try



            cnn.Close()

            cnn.Open()

            Dim da As New SqlDataAdapter("Sp_muestrarecepcion", cnn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@codigo", txt_no.Text)

            da.SelectCommand.Parameters.AddWithValue("@serie", cbx_serie.Text)



            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Codigo").Width = 65
            dtgvp.Columns("Nombre").Width = 300
            dtgvp.Columns("No parte").Width = 100
            dtgvp.Columns("Departamento").Width = 130

            dtgvp.Columns("Cantidad PO").Width = 60
            dtgvp.Columns("Cantidad recibida").Width = 60
            dtgvp.Columns(13).Width = 60
            dtgvp.Columns(30).Width = 60
            dtgvp.Columns(31).Width = 60
            dtgvp.Columns(32).Width = 60
            'dtgvp.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dtgvp.Columns(31).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            dtgvp.Columns("Codigo").ReadOnly = True
            dtgvp.Columns("Nombre").ReadOnly = True
            dtgvp.Columns("No parte").ReadOnly = True
            dtgvp.Columns("Departamento").ReadOnly = True
            dtgvp.Columns("Cantidad PO").ReadOnly = True
            dtgvp.Columns("Cantidad recibida").ReadOnly = True
            dtgvp.Columns("Precio").ReadOnly = True
            '  dtgvp.Columns("Recibido").ReadOnly = True
            'dtgvp.Columns(14).ReadOnly = True
            'dtgvp.Columns(15).ReadOnly = True
            'dtgvp.Columns(30).ReadOnly = True


            dtgvp.Columns("id_mov").Visible = False
            dtgvp.Columns("id_po").Visible = False
            dtgvp.Columns("PO").Visible = False
            dtgvp.Columns("Proveedor").Visible = False
            dtgvp.Columns("total_po").Visible = False
            dtgvp.Columns("Moneda").Visible = False
            dtgvp.Columns("tc").Visible = False
            dtgvp.Columns("Cantidad x recibir").Visible = False
            dtgvp.Columns("Cantidad facturada").Visible = False
            dtgvp.Columns("Subtotal").Visible = False
            dtgvp.Columns("Subtotal Unitario").Visible = False
            dtgvp.Columns("Total").Visible = False
            dtgvp.Columns("Total Unitario").Visible = False
            dtgvp.Columns("subtotal_po").Visible = False
            dtgvp.Columns("iva_po").Visible = False
            dtgvp.Columns("ret_po").Visible = False
            dtgvp.Columns("desc_po").Visible = False
            dtgvp.Columns("fecha_creacion").Visible = False
            dtgvp.Columns("fecha_solicitud").Visible = False
            dtgvp.Columns("fecha_entrega").Visible = False
            dtgvp.Columns("obs_po").Visible = False
            dtgvp.Columns("id_usuario_crea").Visible = False
            dtgvp.Columns("cod_po").Visible = False
            dtgvp.Columns("serie_po").Visible = False
            dtgvp.Columns("Estado").Visible = False
            dtgvp.Columns("Precio").Visible = False
            ' dtgvp.Columns("Recibido").Visible = False
            dtgvp.Columns("RFC").Visible = False
            dtgvp.Columns("id_cotizacion").Visible = False
            dtgvp.Columns("id_req").Visible = False
            dtgvp.Columns("Departamento").Visible = False
            dtgvp.Columns("Familia").Visible = False
            dtgvp.Columns("rete_4").Visible = False


            cnn.Close()

            dtgvp.Visible = True
            'btn_desma.Visible = True
            'btn_selec.Visible = True
            ''btn_cargar.Visible = True
            'btn_calcular.Visible = True

            Panel1.Visible = True
            Panel2.Visible = True
            Panel5.Visible = True
            CheckBox1.Visible = True
            predictivo()
            txt_busca.Focus()

            If dtgvp.RowCount < 1 Then

                MessageBox.Show("No hay ningún registro disponible para recepción con los criterios de búsqueda seleccionados", "¡Alerta!")
                dtgvp.Visible = False
                lbl_po.Text = ""

                lbl_total.Text = ""
                lbl_moneda.Text = ""
                lbl_tc.Text = ""
                lbl_proveedor.Text = ""

                txt_no.Text = ""
                lbl_t.Text = 0
                lbl_neto.Text = 0

                'btn_selec.Visible = False
                'btn_desma.Visible = False
                'btn_cargar.Visible = False
                'btn_calcular.Visible = False
                Panel1.Visible = False
                Panel2.Visible = False
                Panel5.Visible = False
                CheckBox1.Visible = False

            End If


            colores()
            AgregarColumna()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub

    Private Sub btn_fil2_Click(sender As Object, e As EventArgs) Handles btn_fil2.Click
        cargagrid()
    End Sub


    Private Sub txt_no_TextChanged(sender As Object, e As EventArgs) Handles txt_no.TextChanged
        If txt_no.Text = "" Then
            btn_fil2.Enabled = False
        Else
            btn_fil2.Enabled = True
        End If
    End Sub


    Sub AgregarColumna()

        Dim cbox As New DataGridViewCheckBoxColumn
        'Dim recibido As New DataGridViewTextBoxColumn
        Dim totals As New DataGridViewTextBoxColumn
        Dim totalx As New DataGridViewTextBoxColumn


        'dtgvp.Columns.Insert(dtgvp.ColumnCount, recibido)
        dtgvp.Columns.Insert(dtgvp.ColumnCount, totals)
        dtgvp.Columns.Insert(dtgvp.ColumnCount, totalx)
        dtgvp.Columns.Insert(dtgvp.ColumnCount, cbox)

        With cbox
            .HeaderText = "X"
            .Name = "X"
            .Width = 30
        End With

        'With recibido
        '    .HeaderText = "Recibido"
        '    .Name = "Recibido"
        '    .Width = 60
        '    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'End With

        With totalx
            .HeaderText = "Totalx"
            .Name = "Totalx"
            .Width = 60
            .ReadOnly = True
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = False
        End With

        With totals
            .HeaderText = "Totals"
            .Name = "Totals"
            .Width = 60
            .ReadOnly = True
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = False
        End With



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


  SELECT upper([Folio]) as 'f'
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

            '  " & lbl_total.Text & "
            '   " & lbl_subtotalpo.Text & "
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
  WHERE [UUID] = @selec
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
  end 

")

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



    Public Sub cellTextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

        '
        Dim tb As TextBox = TryCast(sender, TextBox)

        '
        If (tb Is Nothing) Then
            e.Handled = True
            Return
        End If

        Dim isDecimal, isSign, isValidChar As Boolean
        Dim decimalSeparator As String = Nothing

        Select Case e.KeyChar
            Case "."c

                '
                decimalSeparator = Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

                '
                e.KeyChar = decimalSeparator.Chars(0)

                '
                If (((tb.TextLength = 0) OrElse (tb.SelectionLength = tb.TextLength)) OrElse
                    ((tb.TextLength = 1) AndAlso ((tb.Text.Contains("-")) OrElse
                    (Text.Contains("+"))))) Then

                    SendKeys.Send("{0}")
                    SendKeys.Send("{" & decimalSeparator & "}")
                    e.Handled = True
                    Return
                End If


                isDecimal = True
                isValidChar = True


            Case Else

                Dim isDigit As Boolean = Char.IsDigit(e.KeyChar)
                Dim isControl As Boolean = Char.IsControl(e.KeyChar)

                If ((isDigit) OrElse (isControl)) Then
                    isValidChar = True

                Else
                    e.Handled = True
                    Return

                End If

        End Select


        '
        If ((isValidChar) And (tb.SelectionLength = tb.TextLength)) Then
            tb.Text = String.Empty
        End If

        If (isSign) Then

            '
            If ((tb.SelectionStart <> 0) OrElse
                (tb.Text.IndexOf("-") >= 0) OrElse
                (tb.Text.IndexOf("+") >= 0)) Then
                e.Handled = True
                Return
            End If
        End If

        If (isDecimal) Then

            If (tb.Text.IndexOf(decimalSeparator) >= 0) Then
                e.Handled = True
            End If
        End If





    End Sub


    Private Sub Malla_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgvp.EditingControlShowing
        Dim ValidarNro As TextBox = e.Control
        RemoveHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress
        AddHandler ValidarNro.KeyPress, AddressOf cellTextBox_KeyPress

    End Sub



    Private Sub ValidarCantidadRequerida(Objeto As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellEndEdit, dtgvp.CellContentClick
        If e.ColumnIndex = 31 Then
            Try
                Cantidad_Requerida = CDbl(dtgvp.Rows(e.RowIndex).Cells("Cantidad x recibir").Value)
                dtgvp.Rows(e.RowIndex).Cells("Totalx").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Total Unitario").Value
                dtgvp.Rows(e.RowIndex).Cells("Totals").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Subtotal Unitario").Value
                If Cantidad_Requerida < CDbl(dtgvp.Rows(e.RowIndex).Cells("Recibido").Value) Then
                    MessageBox.Show("La cantidad que desea guardar es mayor a la que tiene pendiente por recibir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    dtgvp.Rows(e.RowIndex).Cells("Recibido").Value = dtgvp.Rows(e.RowIndex).Cells("Cantidad x recibir").Value
                    dtgvp.Rows(e.RowIndex).Cells("Totalx").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Total Unitario").Value
                    dtgvp.Rows(e.RowIndex).Cells("Totals").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Subtotal Unitario").Value
                    '   Btn_autorizar.Enabled = False
                End If
            Catch ex As Exception
                ' MessageBox.Show(ex.ToString)
                MessageBox.Show("La cantidad que introdujo no es valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtgvp.Rows(e.RowIndex).Cells("Recibido").Value = dtgvp.Rows(e.RowIndex).Cells("Cantidad x recibir").Value
                dtgvp.Rows(e.RowIndex).Cells("Totalx").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Total Unitario").Value
                dtgvp.Rows(e.RowIndex).Cells("Totals").Value = dtgvp.Rows(e.RowIndex).Cells("Recibido").Value * dtgvp.Rows(e.RowIndex).Cells("Subtotal Unitario").Value
                ' Btn_autorizar.Enabled = False
            End Try

        End If
        btn_cargar.Enabled = False
        colores()




    End Sub

    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = True
        Next
    End Sub


    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = False
        Next
    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        If CheckBox1.Checked = False Then



            If lbl_moneda.Text = "MEX" Then
                If excep = 0 Then



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

                ElseIf excep = 2 Then

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
                If excep = 0 Then

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
                ElseIf excep = 2 Then
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
        Else

            Dim Pregunta As Integer

            Pregunta = MsgBox("¿Desea cargar el registro con las cantidades que ha registrado? Recuerde que esto es una recepción contra factura.", vbYesNo + vbExclamation + vbDefaultButton2, "Crear documento de provisión")

            If Pregunta = vbYes Then
                crearrecepcion()
                insertarfilas()
            Else
                MessageBox.Show("Acción no completada", "¡Aviso!")
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


    Private Sub dtgvp_CellContentClick0(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick

        Try
            lbl_po.Text = Me.dtgvp.Rows(e.RowIndex).Cells("PO").Value.ToString()
            lbl_total.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("total_po").Value.ToString(), Decimal), "#,##0.00")
            lbl_subtotalpo.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("subtotal_po").Value.ToString(), Decimal), "#,##0.00")
            lbl_moneda.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Moneda").Value.ToString()
            lbl_tc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tc").Value.ToString()
            lbl_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Proveedor").Value.ToString()
            serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie_po").Value.ToString()
            lbl_rfc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("RFC").Value.ToString()
            id_po = Me.dtgvp.Rows(e.RowIndex).Cells("id_po").Value.ToString()
            excep = Me.dtgvp.Rows(e.RowIndex).Cells("rete_4").Value.ToString()
        Catch
        End Try




        colores()

    End Sub

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        Try

            lbl_po.Text = Me.dtgvp.Rows(e.RowIndex).Cells("PO").Value.ToString()
            lbl_total.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("total_po").Value.ToString(), Decimal), "#,##0.00")
            lbl_subtotalpo.Text = Format(CType(Me.dtgvp.Rows(e.RowIndex).Cells("subtotal_po").Value.ToString(), Decimal), "#,##0.00")
            lbl_moneda.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Moneda").Value.ToString()
            lbl_tc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("tc").Value.ToString()
            lbl_proveedor.Text = Me.dtgvp.Rows(e.RowIndex).Cells("Proveedor").Value.ToString()
            serie = Me.dtgvp.Rows(e.RowIndex).Cells("serie_po").Value.ToString()
            lbl_rfc.Text = Me.dtgvp.Rows(e.RowIndex).Cells("RFC").Value.ToString()
            id_po = Me.dtgvp.Rows(e.RowIndex).Cells("id_po").Value.ToString()
            excep = Me.dtgvp.Rows(e.RowIndex).Cells("rete_4").Value.ToString()
        Catch
        End Try

        colores()


    End Sub



    Sub totales()

        Try
            Dim Total As Double
            Dim Total1 As Double

            Dim Col As Integer = Me.dtgvp.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.dtgvp.Rows
                If row.Cells("x").Value = True Then
                    Total += Val(row.Cells("Totals").Value)
                    Total1 += Val(row.Cells("Totalx").Value)

                End If
            Next


            lbl_neto.Text = Format(CType(Total, Decimal), "#,##0.00")
            lbl_t.Text = Format(CType(Total1, Decimal), "#,##0.00")

        Catch
        End Try


    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim i As Integer

        For i = 0 To dtgvp.Rows.Count - 1



            Try
                Cantidad_Requerida = CDbl(dtgvp.Rows(i).Cells("Cantidad x recibir").Value)
                dtgvp.Rows(i).Cells("Totalx").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Total Unitario").Value
                dtgvp.Rows(i).Cells("Totals").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Subtotal Unitario").Value
                If Cantidad_Requerida < dtgvp.Rows(i).Cells("Recibido").Value Then
                    MessageBox.Show("La cantidad que desea guardar es mayor a la que tiene pendiente por recibir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    dtgvp.Rows(i).Cells("Recibido").Value = dtgvp.Rows(i).Cells("Cantidad x recibir").Value
                    dtgvp.Rows(i).Cells("Totalx").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Total Unitario").Value
                    dtgvp.Rows(i).Cells("Totals").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Subtotal Unitario").Value
                    '   Btn_autorizar.Enabled = False
                End If
            Catch ex As Exception
                ' MessageBox.Show(ex.ToString)
                MessageBox.Show("La cantidad que introdujo no es valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dtgvp.Rows(i).Cells("Recibido").Value = dtgvp.Rows(i).Cells("Cantidad x recibir").Value
                dtgvp.Rows(i).Cells("Totalx").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Total Unitario").Value
                dtgvp.Rows(i).Cells("Totals").Value = dtgvp.Rows(i).Cells("Recibido").Value * dtgvp.Rows(i).Cells("Subtotal Unitario").Value
                ' Btn_autorizar.Enabled = False
            End Try



        Next

        totales()

        If lbl_t.Text = 0 Then
            MessageBox.Show("Debe palomear lo items que quiere recibir", "¡Alerta!")
            btn_cargar.Enabled = False
        Else
            btn_cargar.Visible = True
            btn_cargar.Enabled = True

        End If

    End Sub


    Sub colores()

        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells(“Estado”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.White
                ElseIf row.Cells(“Estado”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next
        Catch
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

            If CheckBox1.Checked = False Then

                agrega.Parameters.Add("@id_po", SqlDbType.Int).Value = id_po
                agrega.Parameters.Add("@f_factura", SqlDbType.Date).Value = dtp1.Value.ToShortDateString
                agrega.Parameters.Add("@f_pago", SqlDbType.Date).Value = dtp2.Value.ToShortDateString
                If excep = 0 Then

                    agrega.Parameters.Add("@subtotal", SqlDbType.Money).Value = lbl_subtotalfact.Text
                    agrega.Parameters.Add("@total", SqlDbType.Money).Value = lbl_totalfact.Text

                ElseIf excep = 2 Then
                    agrega.Parameters.Add("@subtotal", SqlDbType.Money).Value = lbl_subtotalpo.Text
                    agrega.Parameters.Add("@total", SqlDbType.Money).Value = lbl_total.Text
                End If

                agrega.Parameters.Add("@moneda", SqlDbType.VarChar, 3).Value = lbl_moneda.Text
                agrega.Parameters.Add("@uuid", SqlDbType.VarChar, 150).Value = lbl_uuid.Text
                agrega.Parameters.Add("@rfc", SqlDbType.VarChar, 50).Value = lbl_rfc.Text
                agrega.Parameters.Add("@var", SqlDbType.Int).Value = 0
                agrega.Parameters.Add("@folio", SqlDbType.VarChar, 100).Value = lbl_foliofact.Text
                agrega.Parameters.Add("@id_provision", SqlDbType.Int).Value = 0
            Else

                agrega.Parameters.Add("@id_po", SqlDbType.Int).Value = id_po
                agrega.Parameters.Add("@f_factura", SqlDbType.Date).Value = Today.Date
                agrega.Parameters.Add("@f_pago", SqlDbType.Date).Value = Today.Date
                agrega.Parameters.Add("@subtotal", SqlDbType.Money).Value = lbl_neto.Text
                agrega.Parameters.Add("@total", SqlDbType.Money).Value = lbl_t.Text
                agrega.Parameters.Add("@moneda", SqlDbType.VarChar, 3).Value = lbl_moneda.Text
                agrega.Parameters.Add("@uuid", SqlDbType.VarChar, 150).Value = ""

                agrega.Parameters.Add("@rfc", SqlDbType.VarChar, 50).Value = lbl_rfc.Text

                agrega.Parameters.Add("@var", SqlDbType.Int).Value = 0

                agrega.Parameters.Add("@folio", SqlDbType.VarChar, 100).Value = "Pago contra Factura"
                agrega.Parameters.Add("@id_provision", SqlDbType.Int).Value = 0

            End If

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

        Dim comando As SqlCommand = New SqlCommand
        comando.CommandText = "select top 1 id_provision from [Asahi].[dbo].[Com_ProvisionesPrincipal] order by Id_provision desc"
        comando.Connection = cnn
        cnn.Close()
        cnn.Open()

        y = comando.ExecuteScalar()

        cnn.Close()

        cnn.Close()


        Dim command As New SqlCommand("Sp_RecepcionConPoMovimiento", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure


        Try

            For Each fila In dtgvp.Rows
                If fila.Cells("x").Value = True And fila.Cells("Recibido").Value > 0 Then

                    command.Parameters.Clear()

                    If CheckBox1.Checked = False Then


                        command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))

                        command.Parameters.AddWithValue("@cantidad", (fila.Cells("Recibido").Value))
                        command.Parameters.AddWithValue("@precio", (fila.Cells("Precio").Value))
                        command.Parameters.AddWithValue("@subtotal", (fila.Cells("Subtotal").Value))
                        command.Parameters.AddWithValue("@id_movpo", (fila.Cells("id_mov").Value))
                        command.Parameters.AddWithValue("@id_cotizacion", (fila.Cells("id_cotizacion").Value))
                        command.Parameters.AddWithValue("@req", (fila.Cells("id_req").Value))
                        command.Parameters.AddWithValue("@id_po", (fila.Cells("id_po").Value))
                        command.Parameters.AddWithValue("@var", 0)

                    Else
                        command.Parameters.AddWithValue("@codigo", (fila.Cells("Codigo").Value))

                        command.Parameters.AddWithValue("@cantidad", (fila.Cells("Recibido").Value))
                        command.Parameters.AddWithValue("@precio", (fila.Cells("Precio").Value))
                        command.Parameters.AddWithValue("@subtotal", (fila.Cells("Subtotal").Value))
                        command.Parameters.AddWithValue("@id_movpo", (fila.Cells("id_mov").Value))
                        command.Parameters.AddWithValue("@id_cotizacion", (fila.Cells("id_cotizacion").Value))
                        command.Parameters.AddWithValue("@req", (fila.Cells("id_req").Value))
                        command.Parameters.AddWithValue("@id_po", (fila.Cells("id_po").Value))
                        command.Parameters.AddWithValue("@var", 1)

                    End If

                    command.ExecuteNonQuery()

                End If
            Next

            MessageBox.Show("Provisión creada con el folio: " & y & "", "¡Correcto!", MessageBoxButtons.OK)
            dtgvp.Visible = False
            lbl_po.Text = ""

            lbl_total.Text = ""
            lbl_moneda.Text = ""
            lbl_tc.Text = ""
            lbl_proveedor.Text = ""

            txt_no.Text = ""
            txt_busca.Text = ""
            lbl_t.Text = 0
            lbl_neto.Text = 0
            lbl_subtotalfact.Text = 0
            lbl_totalfact.Text = 0
            lbl_subtotalfact.Enabled = True

            lbl_totalfact.Enabled = True
            dtp1.Enabled = True
            dtp2.Enabled = True
            lbl_foliofact.Text = ""
            lbl_foliofact.Enabled = True
            lbl_uuid.Text = ""
            btn_cargar.Enabled = False


            'btn_selec.Visible = False
            'btn_desma.Visible = False
            'btn_cargar.Visible = False
            'btn_calcular.Visible = False
            Panel1.Visible = False
            Panel2.Visible = False
            Panel5.Visible = False
            CheckBox1.Visible = False



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel1.Enabled = False
        Else
            Panel1.Enabled = True

        End If
    End Sub
End Class