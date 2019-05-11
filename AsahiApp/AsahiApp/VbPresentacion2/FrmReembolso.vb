Imports Negocio
Imports Clases
Imports System.Windows.Forms

Public Class FrmReembolso
    Private cadenaConex As String
    Private modificacion As Byte
    Private recuperado As Byte
    Sub New(ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
    End Sub
    Private Sub FrmReembolso_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        BtnNew.Enabled = False
        BtnF3.Visible = False
        FormatoColumnas()
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        RellenaObjProveedor()
        TxtProveedor.Text = Nothing
    End Sub
    Private Sub RellenaObjProveedor()
        Dim Nproveedor As New NProveedor
        Dim NombreProveedor As New Proveedor
        NombreProveedor.Proveedor = TxtProveedor.Text
        Nproveedor.InsertaProveedor(cadenaConex, NombreProveedor)
    End Sub
    ''' <summary>
    ''' evento que se dispara cuando se empieza a escribir en un textbox, habilita o inhabilita boton
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtProveedor_TextChanged(sender As Object, e As EventArgs) Handles TxtProveedor.TextChanged
        If TxtProveedor.Text = "" Then
            BtnNew.Enabled = False
        Else
            BtnNew.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' evento que se muestra el boton F3 en la columna de Nombre en el datagriview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvReembolso_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvReembolso.CellEnter
        Dim x As Integer, y As Integer, fila As Byte
        If DgvReembolso.CurrentCell.ColumnIndex = 1 Then
            fila = DgvReembolso.CurrentCell.RowIndex
            y = 164 + (fila * 21) 'poscion
            Select Case DgvReembolso.CurrentCell.ColumnIndex
                Case 1 : x = 298
            End Select

            BtnF3.Visible = True
        Else
            If BtnF3.Visible = True Then BtnF3.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' evento que se dispara cuando se le da click al boton F3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnF3_Click(sender As Object, e As EventArgs) Handles BtnF3.Click
        Select Case BtnF3.Location.X
            Case 339
                Dim frm As New FrmBuscadorProveedor(cadenaConex)
                If frm.ShowDialog() = DialogResult.OK Then
                    Dim fila As Byte
                    fila = DgvReembolso.CurrentCell.RowIndex
                    DgvReembolso.Rows(fila).Cells("Nombre").Value = frm.nombre
                    DgvReembolso.Rows(fila).Cells("idProveedor").Value = frm.idProveedor
                End If
        End Select

    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Dim utilerias As New PUtilerias
        utilerias.LimpiarComboBox(Me, False, False, False, True, True, False)
        utilerias.LimpiarTextBox(Me)
        DgvReembolso.Rows.Clear()
        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        BtnGuardar.Enabled = True
        BtnCancelar.Enabled = True
        TxtProveedor.ReadOnly = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtCheque.Text = "" Then
            MsgBox("Falta escribir el N° de cheque")
        Else
            InsertaReembolso()
        End If
    End Sub
    ''' <summary>
    ''' despues del msgbox se obtiene el ultimo registro del cheque al cual se le suma uno y compararlo con el cheque que el usuario ingreso, para asi verificar que vayan consecutivos
    ''' en caso que no coincida el numero de chuque el procedimiento no sigue corriendo
    ''' </summary>
    Private Sub InsertaReembolso()
        Dim ObjReembolso As New Reembolso
        Dim Reembolso As New NReembolso
        Dim lstReembolso As New LReembolso
        Dim SigCheque As Integer
        Dim resultado As String
        If recuperado = 1 Then
            resultado = MsgBox("¿Desea Modificar el Reembolso?", vbYesNo + vbQuestion, "Advertencia")
            If resultado = vbYes Then
                modificacion = 1
                lstReembolso = RellenaListaReembolso(lstReembolso)
                Reembolso.ModificaReembolso(cadenaConex, ObjReembolso, lstReembolso)
                Limpiar()
            End If
        Else
            ObjReembolso = VerficaCheque(cadenaConex)
            SigCheque = ObjReembolso.NoCheque + 1 'se suma 1 para comparar
            If SigCheque <> TxtCheque.Text Then
                MsgBox("El N° de cheque no coincide con el consecutivo", MsgBoxStyle.Exclamation, "sin coincidencia")
            Else
                If DgvReembolso.Rows(0).Cells("Factura").Value IsNot Nothing Then
                    lstReembolso = RellenaListaReembolso(lstReembolso)
                    Reembolso.InsertaReembolso(cadenaConex, ObjReembolso, lstReembolso)
                    Limpiar()
                Else
                    MsgBox("Es necesario agregar informacion del reembolso", MsgBoxStyle.Exclamation, "Llenar columnas")
                End If
            End If
        End If
    End Sub

    Private Function RellenaListaReembolso(ByVal lstReembolso As LReembolso) As LReembolso
        Dim i As Byte
        For i = 0 To DgvReembolso.Rows.Count - 1
            With DgvReembolso.Rows(i)
                If .Cells("Factura").Value IsNot Nothing Then
                    Dim ObjReembolso As New Reembolso
                    If modificacion = 1 Then
                        ObjReembolso.IdReembolso = .Cells("idReembolso").Value
                        ObjReembolso.Cancelado = 0
                        ObjReembolso.Fecha = TxtFecha.Text
                        ObjReembolso.NoCheque = TxtCheque.Text
                        ObjReembolso.Factura = .Cells("Factura").Value
                        ObjReembolso.Subtotal = .Cells("Subtotal").Value
                        ObjReembolso.Otros = .Cells("Otros").Value
                        ObjReembolso.Iva = .Cells("Iva").Value
                        ObjReembolso.RetenIva = .Cells("RetenIVA").Value
                        ObjReembolso.RetenIsr = .Cells("RetenISR").Value
                        ObjReembolso.Total = .Cells("Total").Value
                        ObjReembolso.TotalNeto = .Cells("TotalNeto").Value
                        ObjReembolso.IdProveedor = .Cells("idProveedor").Value
                        lstReembolso.Add(ObjReembolso)
                    Else
                        ObjReembolso.Cancelado = 0
                        ObjReembolso.Fecha = TxtFecha.Text
                        ObjReembolso.NoCheque = TxtCheque.Text
                        ObjReembolso.Factura = .Cells("Factura").Value
                        ObjReembolso.Subtotal = .Cells("Subtotal").Value
                        ObjReembolso.Otros = .Cells("Otros").Value
                        ObjReembolso.Iva = .Cells("Iva").Value
                        ObjReembolso.RetenIva = .Cells("RetenIVA").Value
                        ObjReembolso.RetenIsr = .Cells("RetenISR").Value
                        ObjReembolso.Total = .Cells("Total").Value
                        ObjReembolso.TotalNeto = .Cells("TotalNeto").Value
                        ObjReembolso.IdProveedor = .Cells("idProveedor").Value
                        lstReembolso.Add(ObjReembolso)
                    End If
                End If
            End With
        Next
        Return lstReembolso
    End Function
    Private Function VerficaCheque(ByVal cadenaConex As String)
        Dim ObjCheque As New NReembolso
        Return ObjCheque.ObtieneCheque(cadenaConex)
    End Function
    Private Sub FormatoColumnas()
        DgvReembolso.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter 'centrar encabezados
        DgvReembolso.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvReembolso.Columns("Otros").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvReembolso.Columns("Iva").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvReembolso.Columns("RetenIVA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvReembolso.Columns("RetenISR").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvReembolso.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvReembolso.Columns("TotalNeto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    ''' <summary>
    ''' evento que obliga a poner todo el texto en mayusculas dentro del datagriview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvReembolso_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvReembolso.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub
    Private Sub DgvReembolso_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvReembolso.CellEndEdit
        CalcularNumeros(DgvReembolso.CurrentRow)
    End Sub
    Private Sub CalcularNumeros(ByVal row As DataGridViewRow)
        CalculaTotal()
        If row.Cells("RetenIVA").Value <> 0 Then
            CalculaTotalNeto()
        End If
        CalculaSumaSubtotal()
        CalculaSumaOtros()
        CalculaSumaIva()
        CalculaSumaRetenIva()
        CalculaSumaRetenIsr()
        CalculaSumaTotal()
        CalculaSumaTotalNeto()
    End Sub
    ''' <summary>
    ''' sumas las columnas de subtotal, otros, iva
    ''' </summary>
    Private Sub CalculaTotal()
        Dim suma As Double
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            suma = Convert.ToDouble(fila.Cells("Subtotal").Value) + Convert.ToDouble(fila.Cells("Otros").Value) + Convert.ToDouble(fila.Cells("Iva").Value)
            fila.Cells("Total").Value = suma
        Next

    End Sub
    ''' <summary>
    ''' resta las columnas de total, retenIva, retenIsr
    ''' </summary>
    Private Sub CalculaTotalNeto()
        Dim resta As Double
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            resta = Convert.ToDouble(fila.Cells("Total").Value) - Convert.ToDouble(fila.Cells("RetenIVA").Value) - Convert.ToDouble(fila.Cells("RetenISR").Value)
            fila.Cells("TotalNeto").Value = resta
        Next
    End Sub
    ''' <summary>
    ''' suma toda la columna de susbtotaL
    ''' </summary>
    Private Sub CalculaSumaSubtotal()
        Dim total As Single
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            total += Val(fila.Cells("Subtotal").Value)
        Next
        Me.TxtTotalSubtotal.Text = Format(CType(total, Decimal), "$ #,##0.00")
    End Sub
    Private Sub CalculaSumaOtros()
        Dim total As Single
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            total += Val(fila.Cells("Otros").Value)
        Next
        Me.TxtTotalOtros.Text = Format(CType(total, Decimal), "$ #,##0.00")
    End Sub
    Private Sub CalculaSumaIva()
        Dim total As Single
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            total += Val(fila.Cells("Iva").Value)
        Next
        Me.TxtTotalIva.Text = Format(CType(total, Decimal), "$ #,##0.00")
    End Sub
    Private Sub CalculaSumaRetenIva()
        Dim total As Single
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            total += Val(fila.Cells("RetenIVA").Value)
        Next
        Me.TxtTotalRetenIva.Text = Format(CType(total, Decimal), "$ #,##0.00")
    End Sub
    Private Sub CalculaSumaRetenIsr()
        Dim total As Single
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            total += Val(fila.Cells("RetenISR").Value)
        Next
        Me.TxtTotalRetenIsr.Text = Format(CType(total, Decimal), "$ #,##0.00")
    End Sub
    Private Sub CalculaSumaTotal()
        Dim total As Single
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            total += Val(fila.Cells("Total").Value)
        Next
        Me.TxtTotal.Text = Format(CType(total, Decimal), "$ #,##0.00")
    End Sub
    Private Sub CalculaSumaTotalNeto()
        Dim total As Single
        For Each fila As DataGridViewRow In DgvReembolso.Rows
            total += Val(fila.Cells("TotalNeto").Value)
        Next
        Me.TxtTotalNeto.Text = Format(CType(total, Decimal), "$ #,##0.00")
    End Sub

    Private Sub TxtCheque_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCheque.KeyDown
        If e.KeyCode = Keys.Enter Then
            RecuperaReembolso()
        End If
    End Sub
    Private Sub RecuperaReembolso()
        Dim ObjObtener As New NReembolso
        Dim Reembolso As New Reembolso
        Dim lstReembolso As New LReembolso
        Reembolso.NoCheque = TxtCheque.Text
        lstReembolso = ObjObtener.ObtenerReembolso(cadenaConex, Reembolso)
        For Each item In lstReembolso
            If item.Cancelado = "True" Then 'reembolso cancelado
                MsgBox("El reembolso " & TxtCheque.Text & " ha sido cancelado")
                RellenaFrmReembolso(lstReembolso)
                CalcularNumeros(DgvReembolso.CurrentRow)
                BtnGuardar.Enabled = False
                BtnCancelar.Enabled = False
                TxtProveedor.ReadOnly = True
                GoTo Finalize
            Else 'reembolso NO cancelado
                RellenaFrmReembolso(lstReembolso)
                CalcularNumeros(DgvReembolso.CurrentRow)
                Recuperado = 1
                GoTo Finalize
            End If
        Next
        Exit Sub
Finalize:
    End Sub
    Private Sub RellenaFrmReembolso(ByVal lstReembolso As LReembolso)
        Dim fila As Byte = 0
        For Each item In lstReembolso
            DgvReembolso.Rows.Add()
            DgvReembolso.Rows(fila).Cells("idReembolso").Value = item.IdReembolso
            TxtFecha.Text = item.Fecha
            DgvReembolso.Rows(fila).Cells("idProveedor").Value = item.IdProveedor
            DgvReembolso.Rows(fila).Cells("Nombre").Value = item.Proveedor
            DgvReembolso.Rows(fila).Cells("Factura").Value = item.Factura
            DgvReembolso.Rows(fila).Cells("Subtotal").Value = item.Subtotal
            DgvReembolso.Rows(fila).Cells("Otros").Value = item.Otros
            DgvReembolso.Rows(fila).Cells("Iva").Value = item.Iva
            DgvReembolso.Rows(fila).Cells("RetenIVA").Value = item.RetenIva
            DgvReembolso.Rows(fila).Cells("RetenISR").Value = item.RetenIsr
            DgvReembolso.Rows(fila).Cells("Total").Value = item.Total
            DgvReembolso.Rows(fila).Cells("TotalNeto").Value = item.TotalNeto

            DgvReembolso.Columns("Subtotal").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvReembolso.Columns("Otros").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvReembolso.Columns("Iva").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvReembolso.Columns("RetenIVA").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvReembolso.Columns("RetenISR").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvReembolso.Columns("Total").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvReembolso.Columns("TotalNeto").DefaultCellStyle.Format = "$ ##,##0.00"
            fila = fila + 1
        Next
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resultado As String
        If TxtCheque.Text = "" Then
            MsgBox("Falta escribir el N° de cheque a cancelar")
        Else
            resultado = MsgBox("¿Desea Cancelar el Reembolso?", vbYesNo + vbQuestion, "Advertencia")
            If resultado = vbYes Then
                CancelarReembolso()
                Limpiar()
            End If
        End If
    End Sub
    Private Sub CancelarReembolso()
        Dim nreembolso As New NReembolso
        Dim reembolso As New Reembolso
        reembolso.NoCheque = TxtCheque.Text
        nreembolso.CancelaReembolso(cadenaConex, reembolso)
    End Sub
    Private Sub Limpiar()
        Dim utilerias As New PUtilerias
        utilerias.LimpiarComboBox(Me, False, False, False, True, True, False)
        utilerias.LimpiarTextBox(Me)
        DgvReembolso.Rows.Clear()
        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
    End Sub
End Class