Imports Clases
Imports Negocio

Public Class Frm_Provisiones
#Region "Varianbles de clase"
    Dim cadenaConex As String
    Dim cadConex As String
    Dim userName As String
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_Provisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion()
        Me.cadenaConex = conex.cadenaConexExpress
        Me.cadConex = conex.conexion2008

        Dtp_Inicio.Value = DateAdd(DateInterval.Day, -14, Date.Now())
        Dgv_PorProvisionar.RowsDefaultCellStyle.BackColor = Color.LightGray
        Dgv_Provisionadas.RowsDefaultCellStyle.BackColor = Color.LightGray
        RecuperarCompras()
    End Sub
    Private Sub Btn_BuscarCompras_Click(sender As Object, e As EventArgs) Handles Btn_BuscarCompras.Click
        RecuperarCompras()
    End Sub
    Private Sub Btn_ActualizarXml_Click(sender As Object, e As EventArgs) Handles Btn_ActualizarXml.Click
        ActualizaXml()
        RecuperarCompras()
    End Sub
    Private Sub Btn_Validar_Click(sender As Object, e As EventArgs) Handles Btn_Validar.Click
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()

        lstComp = RellenaObjetoCompras()
        RecuperarCompras()
    End Sub
    Private Sub Btn_BuscaProvisionadas_Click(sender As Object, e As EventArgs) Handles Btn_BuscaProvisionadas.Click
        RecuperarProvisionadas()
    End Sub
    Private Sub Dgv_Provisionadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Provisionadas.CellContentClick
        Dim NComp As New NCompras(), lstComp As New LCompras
        If Me.Dgv_Provisionadas.Columns(e.ColumnIndex).Name = "pdf" Then

            Dim folder As New OpenFileDialog
            Dim result As DialogResult = folder.ShowDialog()

            If result = DialogResult.OK Then
                For Each fila As DataGridViewRow In Dgv_Provisionadas.Rows
                    If fila.Cells(1).Selected Then
                        fila.Cells("Ruta").Value = folder.FileName

                        Dim comp As New Compras
                        comp.IdProvision = fila.Cells("idProvision2").Value
                        comp.Ruta = fila.Cells("Ruta").Value
                        lstComp.Add(comp)
                        NComp.InsertarRuta(cadenaConex, lstComp)
                    End If
                Next
            Else
                MessageBox.Show("Salió sin guardar ningún documento", "¡Aviso!")
            End If

        End If
    End Sub
    Private Sub Dgv_Provisionadas_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_Provisionadas.DoubleClick
        Dim fila = Dgv_Provisionadas.CurrentRow.Index
        Try
            System.Diagnostics.Process.Start(Me.Dgv_Provisionadas.Rows(fila).Cells("ruta").Value.ToString())
        Catch ex As Exception
            MessageBox.Show("¡No se encuentra el archivo! Verifique que se haya anexado el archivo y su conexión a las unidades de red.")
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Txt_Oc_TextChanged(sender As Object, e As EventArgs) Handles Txt_Oc.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, oc As String
        If Len(Txt_Oc.Text) > 3 Or Len(Txt_Oc.Text) = 0 Then
            'Txt_FiltroId.Text = ""
            'Txt_FiltroNombre.Text = ""
            'Txt_FiltroDpto.Text = ""
            If Txt_Oc.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        oc = .Cells("idOc").Value
                        If Not (oc Like Txt_Oc.Text) And oc <> "" Then
                            .Visible = True
                        End If
                        If Not (oc Like Txt_Oc.Text) And oc <> "" Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Txt_Proveedor_TextChanged(sender As Object, e As EventArgs) Handles Txt_Proveedor.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, prov As String
        If Len(Txt_Proveedor.Text) > 7 Or Len(Txt_Proveedor.Text) = 0 Then
            'Txt_FiltroId.Text = ""
            'Txt_FiltroNombre.Text = ""
            'Txt_FiltroDpto.Text = ""
            If Txt_Proveedor.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        prov = .Cells("proveedor").Value
                        If Not (prov Like Txt_Proveedor.Text) And prov <> "" Then .Visible = True
                        If Not (prov Like Txt_Proveedor.Text) And prov <> "" Then .Visible = False
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Txt_Factura_TextChanged(sender As Object, e As EventArgs) Handles Txt_Factura.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, factura As String
        If Len(Txt_Factura.Text) > 3 Or Len(Txt_Factura.Text) = 0 Then
            'Txt_FiltroId.Text = ""
            'Txt_FiltroNombre.Text = ""
            'Txt_FiltroDpto.Text = ""
            If Txt_Factura.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        factura = .Cells("factura").Value
                        If Not (factura Like Txt_Factura.Text) And factura = "" Then .Visible = True
                        If Not (factura Like Txt_Factura.Text) And factura = "" Then .Visible = False
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Txt_Empresa_TextChanged(sender As Object, e As EventArgs) Handles Txt_Empresa.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, emp As String
        If Len(Txt_Empresa.Text) > 2 Or Len(Txt_Empresa.Text) = 0 Then
            'Txt_FiltroId.Text = ""
            'Txt_FiltroNombre.Text = ""
            'Txt_FiltroDpto.Text = ""
            If Txt_Empresa.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        emp = .Cells("empresa").Value
                        If Not (emp Like Txt_Empresa.Text) And emp <> "" Then .Visible = True
                        If Not (emp Like Txt_Empresa.Text) And emp <> "" Then .Visible = False
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Txt_Oc2_TextChanged(sender As Object, e As EventArgs) Handles Txt_Oc2.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, oc As String
        If Len(Txt_Oc2.Text) > 3 Or Len(Txt_Oc2.Text) = 0 Then
            'Txt_FiltroId.Text = ""
            'Txt_FiltroNombre.Text = ""
            'Txt_FiltroDpto.Text = ""
            If Txt_Oc2.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        oc = .Cells("idOc2").Value
                        If Not (oc Like Txt_Oc2.Text) And oc <> "" Then .Visible = True
                        If Not (oc Like Txt_Oc2.Text) And oc <> "" Then .Visible = False
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_PorProvisionar.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Txt_Proveedor2_TextChanged(sender As Object, e As EventArgs) Handles Txt_Proveedor2.TextChanged
        'Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, oc As String
        'If Len(Txt_Oc.Text) > 3 Or Len(Txt_Oc.Text) = 0 Then
        '    'Txt_FiltroId.Text = ""
        '    'Txt_FiltroNombre.Text = ""
        '    'Txt_FiltroDpto.Text = ""
        '    If Txt_Oc.Text <> "" Then
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                .Visible = True
        '            End With
        '        Next
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                oc = .Cells("idOc").Value
        '                If Not (oc Like Txt_Oc.Text) And oc <> "" Then
        '                    .Visible = True
        '                End If
        '                If Not (oc Like Txt_Oc.Text) And oc <> "" Then
        '                    .Visible = False
        '                End If
        '            End With
        '        Next
        '    Else
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                .Visible = True
        '            End With
        '        Next
        '    End If
        'End If
    End Sub
    Private Sub Txt_Factura2_TextChanged(sender As Object, e As EventArgs) Handles Txt_Factura2.TextChanged
        'Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, oc As String
        'If Len(Txt_Oc.Text) > 3 Or Len(Txt_Oc.Text) = 0 Then
        '    'Txt_FiltroId.Text = ""
        '    'Txt_FiltroNombre.Text = ""
        '    'Txt_FiltroDpto.Text = ""
        '    If Txt_Oc.Text <> "" Then
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                .Visible = True
        '            End With
        '        Next
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                oc = .Cells("idOc").Value
        '                If Not (oc Like Txt_Oc.Text) And oc <> "" Then
        '                    .Visible = True
        '                End If
        '                If Not (oc Like Txt_Oc.Text) And oc <> "" Then
        '                    .Visible = False
        '                End If
        '            End With
        '        Next
        '    Else
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                .Visible = True
        '            End With
        '        Next
        '    End If
        'End If
    End Sub
    Private Sub Txt_Empresa2_TextChanged(sender As Object, e As EventArgs) Handles Txt_Empresa2.TextChanged
        'Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, oc As String
        'If Len(Txt_Oc.Text) > 3 Or Len(Txt_Oc.Text) = 0 Then
        '    'Txt_FiltroId.Text = ""
        '    'Txt_FiltroNombre.Text = ""
        '    'Txt_FiltroDpto.Text = ""
        '    If Txt_Oc.Text <> "" Then
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                .Visible = True
        '            End With
        '        Next
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                oc = .Cells("idOc").Value
        '                If Not (oc Like Txt_Oc.Text) And oc <> "" Then
        '                    .Visible = True
        '                End If
        '                If Not (oc Like Txt_Oc.Text) And oc <> "" Then
        '                    .Visible = False
        '                End If
        '            End With
        '        Next
        '    Else
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                .Visible = True
        '            End With
        '        Next
        '    End If
        'End If
    End Sub
    Private Sub Txt_StatusCompra_TextChanged(sender As Object, e As EventArgs) Handles Txt_StatusCompra.TextChanged
        'Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count, oc As String
        'If Len(Txt_Oc.Text) > 3 Or Len(Txt_Oc.Text) = 0 Then
        '    'Txt_FiltroId.Text = ""
        '    'Txt_FiltroNombre.Text = ""
        '    'Txt_FiltroDpto.Text = ""
        '    If Txt_Oc.Text <> "" Then
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                .Visible = True
        '            End With
        '        Next
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                oc = .Cells("idOc").Value
        '                If Not (oc Like Txt_Oc.Text) And oc <> "" Then
        '                    .Visible = True
        '                End If
        '                If Not (oc Like Txt_Oc.Text) And oc <> "" Then
        '                    .Visible = False
        '                End If
        '            End With
        '        Next
        '    Else
        '        For fila = 0 To totalFilas - 1
        '            With Dgv_PorProvisionar.Rows(fila)
        '                .Visible = True
        '            End With
        '        Next
        '    End If
        'End If
    End Sub
#End Region
#Region "Recuperar"
    Private Sub RecuperarCompras()
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim fi As Date = Dtp_Inicio.Value, ff As Date = Dtp_Final.Value
        lstComp = NComp.RecuperarLstPorProvisionar(Me.cadenaConex, fi, ff)
        RellenarDgvPorProvisionar(lstComp)
    End Sub
    Private Sub RecuperarProvisionadas()
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim fi As Date = Dtp_InicioProv.Value, ff As Date = Dtp_FinalProv.Value
        lstComp = NComp.RecuperarLstProvisionadas(Me.cadenaConex, fi, ff)
        RellenarDgvProvisionadas(lstComp)
    End Sub
#End Region
#Region "Rellena Formulario"
    Private Sub RellenarDgvPorProvisionar(ByVal lstComp As LCompras)
        Dim fila As Integer = 0
        Dgv_PorProvisionar.DataSource = Nothing
        Dgv_PorProvisionar.Rows.Clear()

        For Each item In lstComp
            Dgv_PorProvisionar.Rows.Add()
            With Dgv_PorProvisionar.Rows(fila)
                .Cells("idProvision").Value = item.IdProvision
                .Cells("oc").Value = item.Oc
                .Cells("idOc").Value = item.IdOrdenCompra
                .Cells("compra").Value = item.IdCompra
                .Cells("factura").Value = item.Factura
                .Cells("proveedor").Value = item.Proveedor
                .Cells("rfc").Value = item.Rfc
                .Cells("rfcEmisor").Value = item.RfcEmisor
                .Cells("moneda").Value = item.Moneda
                If item.MontoOC <> 0 Then .Cells("montoOc").Value = Format(item.MontoOC, "$ #,###,##0.00")
                If item.MontoCompra <> 0 Then .Cells("montoCompra").Value = Format(item.MontoCompra, "$ #,###,##0.00")
                If item.MontoFact <> 0 Then .Cells("montoFactura").Value = Format(item.MontoFact, "$ #,###,##0.00")
                If item.MontoPagar <> 0 Then .Cells("montoPago").Value = Format(item.MontoPagar, "$ #,###,##0.00")
                If item.FechaFact <> "1/1/1900 12:00:00 AM" Then .Cells("fechaFactura").Value = Format(item.FechaFact, "dd/MM/yyyy")
                If item.FechaPagoFact <> "1/1/1900 12:00:00 AM" Then .Cells("fechaPago").Value = Format(item.FechaPagoFact, "dd/MM/yyyy")
                .Cells("status").Value = item.Status
                .Cells("observacionCompra").Value = item.ObservaCompra
                .Cells("empresa").Value = item.Empresa
                .Cells("nombreEmisor").Value = item.NombreEmisor
                .Cells("serie").Value = item.Serie
                If item.FechaCompra <> "1/1/1900 12:00:00 AM" Then .Cells("fechaCompra").Value = Format(item.FechaCompra, "dd/MM/yyyy")
                Select Case item.Status
                    Case "D"
                        .DefaultCellStyle.BackColor = Color.OrangeRed
                        .DefaultCellStyle.ForeColor = Color.White
                    Case "C"
                        .DefaultCellStyle.BackColor = Color.LightGreen
                    Case "P"
                        .DefaultCellStyle.BackColor = Color.LightSteelBlue
                End Select
            End With
            fila += 1
            Txt_Oc.AutoCompleteCustomSource.Add(item.IdOrdenCompra)
            Txt_Proveedor.AutoCompleteCustomSource.Add(item.Proveedor)
            Txt_Factura.AutoCompleteCustomSource.Add(item.Factura)
        Next
    End Sub
    Private Sub RellenarDgvProvisionadas(ByVal lstComp As LCompras)
        Dim fila As Integer = 0
        Dgv_Provisionadas.DataSource = Nothing
        Dgv_Provisionadas.Rows.Clear()

        For Each item In lstComp
            Dgv_Provisionadas.Rows.Add()
            With Dgv_Provisionadas.Rows(fila)
                .Cells("idProvision2").Value = item.IdProvision
                .Cells("oc2").Value = item.Oc
                .Cells("idOc2").Value = item.IdOrdenCompra
                .Cells("compra2").Value = item.IdCompra
                .Cells("factura2").Value = item.Factura
                .Cells("proveedor2").Value = item.Proveedor
                .Cells("rfc2").Value = item.Rfc
                .Cells("rfcEmisor2").Value = item.RfcEmisor
                .Cells("moneda2").Value = item.Moneda
                If item.MontoOC <> 0 Then .Cells("montoOc2").Value = Format(item.MontoOC, "$ #,###,##0.00")
                If item.MontoCompra <> 0 Then .Cells("montoCompra2").Value = Format(item.MontoCompra, "$ #,###,##0.00")
                If item.MontoFact <> 0 Then .Cells("montoFactura2").Value = Format(item.MontoFact, "$ #,###,##0.00")
                If item.MontoPagar <> 0 Then .Cells("montoPagar").Value = Format(item.MontoPagar, "$ #,###,##0.00")
                If item.FP <> "1/1/1900 12:00:00 AM" Then .Cells("fp").Value = Format(item.FechaFact, "dd/MM/yyyy")
                If item.FechaFact <> "1/1/1900 12:00:00 AM" Then .Cells("fechaFactura2").Value = Format(item.FechaFact, "dd/MM/yyyy")
                If item.FechaPagoFact <> "1/1/1900 12:00:00 AM" Then .Cells("fechaPagoFact").Value = Format(item.FechaPagoFact, "dd/MM/yyyy")
                .Cells("statusPago").Value = item.StatusPago
                .Cells("status2").Value = item.Status
                .Cells("observaComp").Value = item.ObservaCompra
                .Cells("observaConta").Value = item.ObservaConta
                .Cells("empresa2").Value = item.Empresa
                .Cells("nombreEmisor2").Value = item.NombreEmisor
                If item.FechaProv <> "1/1/1900 12:00:00 AM" Then .Cells("fdp").Value = Format(item.FechaCompra, "dd/MM/yyyy")
                .Cells("serie2").Value = item.Serie
                .Cells("uuid").Value = item.UUID
                .Cells("ruta").Value = item.Ruta
                Select Case item.StatusConta
                    Case "A"
                        .DefaultCellStyle.BackColor = Color.LightSteelBlue
                    Case "R"
                        .DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
                End Select
            End With
            Txt_Proveedor2.AutoCompleteCustomSource.Add(item.Proveedor)
            Txt_Factura2.AutoCompleteCustomSource.Add(item.Factura)
            Txt_StatusCompra.AutoCompleteCustomSource.Add(item.Status)
            Txt_Oc2.AutoCompleteCustomSource.Add(item.IdOrdenCompra)
            fila += 1
        Next
    End Sub
#End Region
#Region "Rellena Objetos"
    Private Function RellenaObjetoCompras() As LCompras
        Dim lstComp As New LCompras(), NCompra As New NCompras()
        Dim fila As Integer, totalFilas As Integer = Dgv_PorProvisionar.Rows.Count - 1, ctaSelect As Integer = 0

        For fila = 0 To totalFilas
            With Dgv_PorProvisionar.Rows(fila)
                If .Cells("seleccion").Value Then
                    ctaSelect += 1
                    Dim comp As New Compras()
                    comp.IdProvision = .Cells("idProvision").Value
                    comp.Factura = .Cells("factura").Value
                    comp.MontoFact = .Cells("montoFactura").Value
                    comp.FechaPagoFact = .Cells("fechaPago").Value
                    comp.Oc = .Cells("oc").Value
                    comp.Proveedor = .Cells("proveedor").Value
                    comp.Serie = .Cells("serie").Value
                    comp.Status = .Cells("status").Value
                    comp.RfcEmisor = .Cells("rfc").Value
                    comp.ObservaCompra = .Cells("observacionCompra").Value
                    comp.IdCompra = .Cells("compra").Value
                End If
            End With
        Next
        If ctaSelect = 0 Then
            MsgBox("No has seleccionado ningún campo")
        End If
        Return lstComp
    End Function
#End Region
#Region "Otros"
    Private Sub ActualizaXml()
        Dim NComp As New NCompras()
        NComp.ActualizarXml(Me.cadenaConex)
    End Sub
#End Region
End Class