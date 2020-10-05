Imports Clases
Imports Negocio
Imports System.IO
Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms

Public Class Frm_PolizasDiario
#Region "Variables de clase"
    Dim origen As Integer '1:Diario, 2:Egresos
    Dim conex As New conexion()
    Dim cadenaConex As String
    Dim cadConex As String
    Dim cadConexCont As String
    Dim userName As String
    Dim ruta As String
    Dim archivo As String
    Dim fechaPago As Date
    Dim tCamb As Double
    Dim pasoPol As String
    Dim pasoEgre As String
    Dim rec As Boolean = False
    Dim codigoBanco As String
    Dim idBanco As Integer
    Dim ip As String = Strings.Left(Me.conex.getIp(), 6)
    Dim emp As New Empleado()
    Dim LComp As New LCompras()
    Dim subsid As String
    Dim Ocomp As Integer, IdProvi As Integer
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal emp As Empleado, ByVal origen As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.emp = emp
        Me.origen = origen
    End Sub
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_PolizasDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim conex As New conexion()
        Dim Subsi As New Frm_Subsidiaria()
        If Me.ip = "172.16" Then
            Me.cadenaConex = Me.conex.cadenaConexExpress
            Me.cadConex = Me.conex.conexion2008
            Me.cadConexCont = Me.conex.conexionCont
        Else
            Me.cadenaConex = Me.conex.cadenaConexExpressFor
            Me.cadConex = Me.conex.conexion2008For
            Me.cadConexCont = Me.conex.conexionContFor
        End If
        If Subsi.ShowDialog() = DialogResult.OK Then
            Me.subsid = Subsi.SubsiSelect
            If Me.subsid = "MEX" Then
                If origen = 1 Then
                    Dgv_Prepolizas.Visible = True
                    Me.Text = "Polizas de Diario " & Me.subsid
                    Dtp_Inicio.Value = DateAdd(DateInterval.Day, -7, Date.Now())
                    Dgv_Compras.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
                    Dgv_Prepolizas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
                ElseIf origen = 2 Then
                    Dgv_Egresos.Visible = True
                    Me.Text = "Proyecciones " & Me.subsid
                    Lbl_BancoMoneda.Visible = True
                    Cmb_BancoMoneda.Visible = True
                    RellenarCmbBancos()
                    Dtp_Inicio.Value = DateAdd(DateInterval.Day, -7, Date.Now())
                    Dgv_Compras.AlternatingRowsDefaultCellStyle.BackColor = Color.Chartreuse
                    Dgv_Compras.DefaultCellStyle.SelectionBackColor = Color.LimeGreen
                    Dgv_Egresos.AlternatingRowsDefaultCellStyle.BackColor = Color.Chartreuse
                    Dgv_Egresos.DefaultCellStyle.SelectionBackColor = Color.LimeGreen
                End If
            ElseIf Me.subsid = "SERV" Then
                If origen = 1 Then
                    Dgv_Prepolizas.Visible = True
                    Me.Text = "Polizas de Diario " & Me.subsid
                    Dtp_Inicio.Value = DateAdd(DateInterval.Day, -7, Date.Now())
                    Dgv_Compras.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
                    Dgv_Prepolizas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
                ElseIf origen = 2 Then
                    Dgv_Egresos.Visible = True
                    Me.Text = "Proyecciones " & Me.subsid
                    Lbl_BancoMoneda.Visible = True
                    Cmb_BancoMoneda.Visible = True
                    RellenarCmbBancos()
                    Dtp_Inicio.Value = DateAdd(DateInterval.Day, -7, Date.Now())
                    Dgv_Compras.AlternatingRowsDefaultCellStyle.BackColor = Color.Chartreuse
                    Dgv_Compras.DefaultCellStyle.SelectionBackColor = Color.LimeGreen
                    Dgv_Egresos.AlternatingRowsDefaultCellStyle.BackColor = Color.Chartreuse
                    Dgv_Egresos.DefaultCellStyle.SelectionBackColor = Color.LimeGreen
                End If

            End If
            'Dgv_Compras.colu
            RecuperarCompras()
            RecuperarProveedores()
            rec = True
        End If
    End Sub
    Private Sub Dgv_Compras_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_Compras.DoubleClick
        Dim uuid As String, moneda As String, respuesta As String
        Dim fila As Integer, tc As Double
        Dim Comp As New Compras(), NComp As New NCompras()
        Dim emp As String = ""
        Select Case Me.subsid
            Case "MEX" : emp = "AAM"
            Case "SERV" : emp = "AAMS"
        End Select
        fila = Dgv_Compras.CurrentRow.Index
        Comp.IdOrdenCompra = Dgv_Compras.Rows(fila).Cells("oc").Value
        Comp.MontoFact = Dgv_Compras.Rows(fila).Cells("montoFact").Value
        Comp.IdProvision = Dgv_Compras.Rows(fila).Cells("provision").Value
        Comp.Empresa = emp
        Select Case Me.origen
            Case 1 : Comp.Tipo = 3
            Case 2 : Comp.Tipo = 48
        End Select
        Comp = NComp.ConsultaBitacoraCreados(cadConexCont, Comp)
        If Dgv_Compras.Rows(fila).DefaultCellStyle.BackColor <> Color.DarkRed Then
            If Me.origen = 1 Then
                If Dgv_Compras.Rows(fila).Cells("seleccion").Value = 0 Then
                    If Comp.DocContableCrea = False Then
                        If Comp.TxtCreado = True Then
                            respuesta = MsgBox("El Txt ya fue creado. Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Txt Creado")
                        Else
                            respuesta = "6"
                        End If
                        If respuesta = "6" Then
                            Me.pasoPol = ""
                            uuid = Dgv_Compras.Rows(fila).Cells("uuid").Value
                            moneda = Dgv_Compras.Rows(fila).Cells("moneda").Value
                            tc = Dgv_Compras.Rows(fila).Cells("tazaCambio").Value
                            Me.tCamb = Dgv_Compras.Rows(fila).Cells("tazaCambio").Value
                            Me.Ocomp = Dgv_Compras.Rows(fila).Cells("oc").Value
                            Me.IdProvi = Dgv_Compras.Rows(fila).Cells("provision").Value
                            Me.fechaPago = Dgv_Compras.Rows(fila).Cells("fechaPagoFactura").Value
                            RecuperarPolizas(moneda, uuid, tc, Me.Ocomp)
                            If Me.pasoPol = "Ok" Then Dgv_Compras.Rows(fila).Cells("seleccion").Value = 1

                        End If
                    Else
                        MsgBox("EL DOCUMENTO CONTABLE ESTA CREADO", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("ESTA PROVICION YA ESTA PREPARADA PARA CONVERSIÓN A TXT", MsgBoxStyle.Exclamation, "")
                End If
            ElseIf Me.origen = 2 Then
                If Dgv_Compras.Rows(fila).Cells("seleccion").Value = 0 Then
                    If Comp.DocContableCrea = False Then
                        If Comp.TxtCreado = True Then
                            respuesta = MsgBox("El Txt ya fue creado. Desea continuar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Txt Creado")
                        Else
                            respuesta = "6"
                        End If
                        If respuesta = "6" Then
                            Me.pasoPol = ""
                            uuid = Dgv_Compras.Rows(fila).Cells("uuid").Value
                            moneda = Dgv_Compras.Rows(fila).Cells("moneda").Value
                            Me.Ocomp = Dgv_Compras.Rows(fila).Cells("oc").Value
                            Me.IdProvi = Dgv_Compras.Rows(fila).Cells("provision").Value
                            RecuperarEgreso(moneda, uuid, Me.Ocomp)
                            If Me.pasoPol = "Ok" Then Dgv_Compras.Rows(fila).Cells("seleccion").Value = 1
                        End If
                    Else
                        MsgBox("EL DOCUMENTO CONTABLE ESTA CREADO", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("ESTE EGRESO YA ESTA PREPARADO PARA CONVERSIÓN A TXT", MsgBoxStyle.Exclamation, "")
                End If
            End If
        Else
            MsgBox("NO COINCIDEN MONTOS DE COMPRA Y DE FACTURA", MsgBoxStyle.Critical, "")
        End If
    End Sub
    Private Sub Dtp_Inicio_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Inicio.ValueChanged
        RecuperarCompras()
        RecuperarProveedores()
        If Me.origen = 1 Then
            Dgv_Prepolizas.DataSource = Nothing
            Dgv_Prepolizas.Rows.Clear()
        ElseIf Me.origen = 2 Then
            Dgv_Egresos.DataSource = Nothing
            Dgv_Egresos.Rows.Clear()
        End If
    End Sub
    Private Sub Dtp_Fin_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fin.ValueChanged
        RecuperarCompras()
        RecuperarProveedores()
        If Me.origen = 1 Then
            Dgv_Prepolizas.DataSource = Nothing
            Dgv_Prepolizas.Rows.Clear()
        ElseIf Me.origen = 2 Then
            Dgv_Egresos.DataSource = Nothing
            Dgv_Egresos.Rows.Clear()
        End If
    End Sub
    Private Sub Btn_Txt_Click(sender As Object, e As EventArgs) Handles Btn_Txt.Click
        CrearTxt()
        If Me.origen = 1 Then
            EscribirArchivoDiarios()
            InsertaBitacora(1)
        Else
            EscribirArchivoProyecciones()
            InsertaBitacora(2)
        End If
    End Sub
    Private Sub Txt_FiltroCompras_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroCompras.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count, folio As Integer
        If IsNumeric(Txt_FiltroCompras.Text) Then
            If Txt_FiltroCompras.Text <> "" Then
                Txt_FiltroOC.Text = ""
                Txt_FiltroFactura.Text = ""
                Txt_FiltroProveedor.Text = ""
                'Cmb_BancoMoneda.SelectedValue = ""
                'Me.codigoBanco = ""
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        folio = .Cells("compra").Value
                        If Not (folio Like Txt_FiltroCompras.Text) And folio <> 0 Then
                            .Visible = True
                        End If
                        If Not (folio Like Txt_FiltroCompras.Text) And folio <> 0 Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        Else
            Txt_FiltroCompras.Text = ""

            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Txt_FiltroOC_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroOC.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count, folio As Integer
        If IsNumeric(Txt_FiltroOC.Text) Then
            If Txt_FiltroOC.Text <> "" Then
                Txt_FiltroCompras.Text = ""
                Txt_FiltroFactura.Text = ""
                Txt_FiltroProveedor.Text = ""
                'Cmb_BancoMoneda.SelectedValue = ""
                'Me.codigoBanco = ""
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        folio = .Cells("oc").Value
                        If Not (folio Like Txt_FiltroOC.Text) And folio <> 0 Then
                            .Visible = True
                        End If
                        If Not (folio Like Txt_FiltroOC.Text) And folio <> 0 Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        Else
            Txt_FiltroOC.Text = ""

            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Txt_FiltroFactura_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroFactura.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count, folio As String
        If Txt_FiltroFactura.Text <> "" Then
            Txt_FiltroOC.Text = ""
            Txt_FiltroCompras.Text = ""
            Txt_FiltroProveedor.Text = ""
            'Cmb_BancoMoneda.SelectedValue = ""
            'Me.codigoBanco = ""
            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    .Visible = True
                End With
            Next
            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    folio = .Cells("factura").Value
                    If Not (folio Like Txt_FiltroFactura.Text) And folio <> "" Then
                        .Visible = True
                    End If
                    If Not (folio Like Txt_FiltroFactura.Text) And folio <> "" Then
                        .Visible = False
                    End If
                End With
            Next
        Else
            For fila = 0 To totalFilas - 1
                With Dgv_Compras.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Txt_FiltroProveedor_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroProveedor.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count, proveedor As String
        If Len(Txt_FiltroProveedor.Text) > 4 Or Len(Txt_FiltroProveedor.Text) = 0 Then
            Txt_FiltroOC.Text = ""
            Txt_FiltroCompras.Text = ""
            Txt_FiltroFactura.Text = ""
            'Cmb_BancoMoneda.SelectedValue = ""
            'Me.codigoBanco = ""
            If Txt_FiltroProveedor.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        proveedor = .Cells("proveedor").Value
                        If Not (proveedor Like Txt_FiltroProveedor.Text) And proveedor <> "" Then
                            .Visible = True
                        End If
                        If Not (proveedor Like Txt_FiltroProveedor.Text) And proveedor <> "" Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_Compras.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        LimpiarDgv()
        LimpiarFiltros()
        RecuperarCompras()
        RecuperarProveedores()
    End Sub
    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        LimpiarDgv()
        LimpiarFiltros()
    End Sub
    Private Sub Btn_LimpiarFiltros_Click(sender As Object, e As EventArgs) Handles Btn_LimpiarFiltros.Click
        LimpiarFiltros()
    End Sub
    Private Sub Cmb_BancoMoneda_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_BancoMoneda.SelectedValueChanged
        If Me.origen = 2 Then
            If rec = True Then
                Dim moneda As String = RegresoMonedaLetra(Cmb_BancoMoneda.Text)
                Dim NComp As New NCompras()
                Me.codigoBanco = Cmb_BancoMoneda.SelectedValue
                Me.idBanco = NComp.RecuperarIdBanco(Me.cadenaConex, Me.codigoBanco, Me.subsid)
                If Cmb_BancoMoneda.Text <> "" Then
                    Txt_FiltroOC.Text = ""
                    Txt_FiltroCompras.Text = ""
                    Txt_FiltroProveedor.Text = ""
                    RellenarDgvCompras(Me.LComp, moneda)
                Else
                    Txt_FiltroOC.Text = ""
                    Txt_FiltroCompras.Text = ""
                    Txt_FiltroProveedor.Text = ""
                    Dgv_Compras.DataSource = Nothing
                    Dgv_Compras.Rows.Clear()
                End If
            End If
        End If
    End Sub
#End Region
#Region "Recuperar"
    Private Sub RecuperarCompras()
        Dim NComp As New NCompras()
        'Dim lstComp As New LCompras()
        Dim fi As Date = Dtp_Inicio.Value, ff As Date = Dtp_Fin.Value
        LimpiarFiltros()
        Me.LComp = NComp.RecuperarLstCompras(Me.cadenaConex, fi, ff, Me.subsid)
        NComp.EmpatarDocumentosContablesBitacora(Me.cadConexCont, Me.subsid)
        If Me.origen = 1 Then
            RellenarDgvCompras(Me.LComp)
        End If
    End Sub
    Private Sub RecuperarProveedores()
        Dim lstComp As New LCompras()
        Dim NComp As New NCompras()
        Dim prov As New Compras()
        Dim fi As Date = Format(Dtp_Inicio.Value, "dd/MM/yyyy"), ff As Date = Format(Dtp_Fin.Value, "dd/MM/yyyy")

        lstComp = NComp.RecuperarListaProveedores(Me.cadenaConex, fi, ff, Me.subsid)
        prov.Proveedor = ""
        lstComp.Add(prov)
        For Each item In lstComp
            Txt_FiltroProveedor.AutoCompleteCustomSource.Add(item.Proveedor)
        Next
    End Sub
    Private Sub RecuperarPolizas(ByVal moneda As String, ByVal uuid As String, ByVal tc As Double, ByVal oc As Integer)
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim cuenta As Integer

        lstComp = NComp.ConsultarImpuestosExtra(Me.cadConexCont, uuid, Me.subsid)
        cuenta = lstComp.Count
        lstComp = NComp.VistaPoliza(Me.cadenaConex, moneda, uuid, tc, Me.subsid)
        RellenarDgvVistaPolizas(lstComp, oc)
    End Sub
    Private Sub RecuperarEgreso(ByVal moneda As String, ByVal uuid As String, ByVal oc As Integer)
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim cuenta As Integer

        lstComp = NComp.ConsultarImpuestosExtra(Me.cadConexCont, uuid)
        cuenta = lstComp.Count
        lstComp = NComp.RecuperarEgreso(Me.cadenaConex, moneda, uuid, Me.subsid)
        RellenaDGVPolizasEgresos(lstComp)
    End Sub
#End Region
#Region "Rellenar"
    Private Sub RellenarDgvCompras(ByVal lstComp As LCompras, ByVal Optional moneda As String = "")
        Dim fila As Integer = 0
        Dgv_Compras.DataSource = Nothing
        Dgv_Compras.Rows.Clear()

        If Me.origen = 1 Then
            For Each item In lstComp
                Dgv_Compras.Rows.Add()
                'Dgv_Compras.Columns("acum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                With Dgv_Compras.Rows(fila)
                    .Cells("provision").Value = item.IdProvision
                    .Cells("compra").Value = item.IdCompra
                    .Cells("oc").Value = item.IdOrdenCompra
                    .Cells("serie").Value = item.Serie
                    .Cells("factura").Value = item.Factura
                    .Cells("proveedor").Value = item.Proveedor
                    .Cells("montoOc").Value = Format(item.MontoOC, "$ #,###,##0.00")
                    .Cells("montoFact").Value = Format(item.MontoFact, "$ #,###,##0.00")
                    .Cells("montoPagar").Value = Format(item.MontoPagar, "$ #,###,##0.00")
                    .Cells("montoCompra").Value = Format(item.MontoCompra, "$ #,###,##0.00")
                    .Cells("fechaFactura").Value = Format(item.FechaFact, "dd/MM/yyyy")
                    .Cells("fechaPagoFactura").Value = Format(item.FechaPagoFact, "dd/MM/yyyy")
                    .Cells("fechaPagoReal").Value = Format(item.FechaPagoReal, "dd/MM/yyyy")
                    .Cells("moneda").Value = item.Moneda
                    .Cells("empresa").Value = item.Empresa
                    .Cells("fechaCompra").Value = Format(item.FechaCompra, "dd/MM/yyyy")
                    .Cells("uuid").Value = item.UUID
                    .Cells("tazaCambio").Value = Format(item.TazaCambio, "$ #,###,##0.0000")
                    Dim res = .Cells("montoCompra").Value - .Cells("montoFact").Value
                    If res >= 0.05 Or res <= -0.05 Then
                        .DefaultCellStyle.BackColor = Color.DarkRed
                        .DefaultCellStyle.ForeColor = Color.White
                    End If
                End With
                fila += 1
            Next
        ElseIf Me.origen = 2 Then
            For Each item In lstComp
                If item.Moneda = moneda Then
                    Dgv_Compras.Rows.Add()
                    'Dgv_Compras.Columns("acum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    With Dgv_Compras.Rows(fila)
                        .Cells("provision").Value = item.IdProvision
                        .Cells("compra").Value = item.IdCompra
                        .Cells("oc").Value = item.IdOrdenCompra
                        .Cells("serie").Value = item.Serie
                        .Cells("factura").Value = item.Factura
                        .Cells("proveedor").Value = item.Proveedor
                        .Cells("montoOc").Value = Format(item.MontoOC, "$ #,###,##0.00")
                        .Cells("montoFact").Value = Format(item.MontoFact, "$ #,###,##0.00")
                        .Cells("montoPagar").Value = Format(item.MontoPagar, "$ #,###,##0.00")
                        .Cells("montoCompra").Value = Format(item.MontoCompra, "$ #,###,##0.00")
                        .Cells("fechaFactura").Value = Format(item.FechaFact, "dd/MM/yyyy")
                        .Cells("fechaPagoFactura").Value = Format(item.FechaPagoFact, "dd/MM/yyyy")
                        .Cells("fechaPagoReal").Value = Format(item.FechaPagoReal, "dd/MM/yyyy")
                        .Cells("moneda").Value = item.Moneda
                        .Cells("empresa").Value = item.Empresa
                        .Cells("fechaCompra").Value = Format(item.FechaCompra, "dd/MM/yyyy")
                        .Cells("uuid").Value = item.UUID
                        .Cells("tazaCambio").Value = Format(item.TazaCambio, "$ #,###,##0.0000")
                        Dim res = .Cells("montoCompra").Value - .Cells("montoFact").Value
                        If res >= 0.05 Or res <= -0.05 Then
                            .DefaultCellStyle.BackColor = Color.DarkRed
                            .DefaultCellStyle.ForeColor = Color.White
                        End If
                    End With
                    fila += 1
                End If
            Next
        End If
    End Sub
    Private Sub RellenarDgvVistaPolizas(ByVal lstComp As LCompras, ByVal oc As Integer)
        Dim fila As Integer = Dgv_Prepolizas.Rows.Count(), pfila As Integer = fila
        Dim sum As Double, sumCargo As Double, sumRet As Double, t As Double
        Dim frm As New Frm_ConceptoPoliza("" & oc & "", lstComp)

        If frm.ShowDialog() = DialogResult.OK Then
            For Each item In lstComp
                Dgv_Prepolizas.Rows.Add()
                'Dgv_Prepolizas.Columns("acum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                If item.Pivote = 1 Or item.Pivote = 2 Then
                    sum = sum + Format(item.Total, "0.00")
                ElseIf item.Pivote = 3 Then
                    sumRet = sumRet + Format(item.Total, "0.00")
                ElseIf item.Pivote = 4 Or item.Pivote = 5 Then
                    sumCargo = sumCargo + Format(item.Total, "0.00")
                End If
                With Dgv_Prepolizas.Rows(fila)
                    .Cells("pivot").Value = item.Pivote
                    .Cells("ordenCompra").Value = oc
                    .Cells("idCompra").Value = item.IdCompra
                    .Cells("serieF").Value = item.Serie
                    .Cells("idFactura").Value = item.Factura
                    .Cells("nombreProveedor").Value = item.Proveedor
                    .Cells("rfcProveedor").Value = item.Rfc
                    .Cells("totalFactura").Value = Format(item.TotalFactura, "$ #,###,##0.00")
                    .Cells("compraTotal").Value = Format(item.CompraTotal, "$ #,###,##0.00")
                    .Cells("fechaFact").Value = Format(item.FechaFact, "dd/MM/yyyy")
                    .Cells("fechaPagoFact").Value = Format(Me.fechaPago, "dd/MM/yyyy")
                    .Cells("monedaVP").Value = item.Moneda
                    .Cells("tc").Value = Format(Me.tCamb, "$ #,###,##0.0000")
                    .Cells("empresaVP").Value = item.Empresa
                    .Cells("rfcEmisor").Value = item.RfcEmisor
                    .Cells("nombreEmisor").Value = item.NombreEmisor
                    .Cells("uuidFactura").Value = item.UUID
                    .Cells("total").Value = Format(item.Total, "$ #,###,##0.00")
                    .Cells("area").Value = item.Area
                    .Cells("familia").Value = item.Familia
                    .Cells("cuenta").Value = item.Cuenta
                    .Cells("neto").Value = Format(item.Neto, "$ #,###,##0.00")
                    .Cells("cuentaIva").Value = item.CuentaIva
                    .Cells("ivaT").Value = Format(item.IvaT, "$ #,###,##0.00")
                    .Cells("cuentaP").Value = item.CuentaP
                    .Cells("impuesto").Value = Format(item.Impuesto, "$ #,###,##0.00")
                    .Cells("concepto").Value = frm.Concepto
                    .Cells("folioProvisionPol").Value = Me.IdProvi
                End With
                fila += 1
            Next
            Me.pasoPol = "Ok"
            t = Format(sum, "0.00") - Format(sumCargo, "0.00")
            If Dgv_Prepolizas.Rows(pfila).Cells("total").Value > 0 Then
                Dgv_Prepolizas.Rows(pfila).Cells("total").Value = Format((Dgv_Prepolizas.Rows(pfila).Cells("total").Value - t) + sumRet, "$ #,###,##0.00")
            Else
                pfila += 1
                Dgv_Prepolizas.Rows(pfila).Cells("total").Value = Format((Dgv_Prepolizas.Rows(pfila).Cells("total").Value - t) + sumRet, "$ #,###,##0.00")
            End If
        End If
    End Sub
    Private Sub RellenaDGVPolizasEgresos(ByVal lstComp As LCompras)
        Dim fila As Integer = Dgv_Egresos.Rows.Count(), pfila As Integer = fila
        'Dim sum As Double, sumCargo As Double, sumRet As Double, t As Double
        Dim frm As New Frm_ConceptoEgreso(lstComp), NComp As New NCompras()

        If frm.ShowDialog() = DialogResult.OK Then
            For Each item In lstComp
                Dgv_Egresos.Rows.Add()
                Dim sNeg As String = ""
                If item.Pivote = 2 Then sNeg = NComp.RecuperaSubCategorias(Me.cadenaConex, lstComp, item.Cuenta, idSegNeg(item.Area))

                With Dgv_Egresos.Rows(fila)
                    .Cells("pivote").Value = item.Pivote
                    .Cells("fechaFac").Value = item.FechaFactura
                    .Cells("ejercicio").Value = item.Ejercicio
                    .Cells("periodo").Value = item.Periodo
                    .Cells("fechaPag").Value = item.FechaPagoFact
                    .Cells("ejercicioPag").Value = item.EjercicioPago
                    .Cells("periodoPag").Value = item.PeriodoPago
                    .Cells("idProv").Value = item.IdProveedor
                    .Cells("prov").Value = item.Proveedor
                    .Cells("moneda2").Value = item.Moneda
                    .Cells("tipCambio").Value = item.TazaCambio
                    .Cells("total2").Value = Format(item.TotalFactura, "0.00")
                    .Cells("oCompra").Value = item.IdOrdenCompra
                    .Cells("uuidE").Value = item.UUID
                    .Cells("conceptoCuenta").Value = Replace(frm.Concepto, vbLf, " ")
                    .Cells("cuentaClabe").Value = item.CuentaClabe
                    .Cells("codBanco").Value = Me.codigoBanco
                    .Cells("Banco").Value = Cmb_BancoMoneda.Text
                    .Cells("sc").Value = sNeg
                    .Cells("cuentaS").Value = item.Cuenta
                    .Cells("folioProvisionProy").Value = Me.IdProvi
                End With
                fila += 1
            Next
            Me.pasoPol = "Ok"
        End If
    End Sub
    Private Sub RellenarCmbBancos()
        Dim lstBancos As New LBancos()
        Dim Bancos As New Bancos()
        Dim NComp As New NCompras()
        lstBancos = NComp.RecuperaCtasBancos(Me.cadenaConex, Me.subsid)

        Bancos.NombreBanco = ""
        Bancos.Codigo = ""
        Bancos.IdBanco = 0
        lstBancos.Add(Bancos)


        With Cmb_BancoMoneda
            .DataSource = lstBancos
            .DisplayMember = "NombreBanco"
            .ValueMember = "Codigo"
            .SelectedItem = lstBancos.Item(lstBancos.Count - 1).IdBanco
        End With
    End Sub
#End Region
#Region "Otros"
    Private Sub CrearTxt()
        Me.userName = Environment.UserName
        Me.ruta = "C:\Users\" & Me.userName & "\Desktop\Polizas\"
        If Me.origen = 1 Then
            Me.archivo = "PolizasDiario" & Format(Date.Now(), "yyyyMMddHHmmss") & ".txt"
        ElseIf Me.origen = 2 Then
            Me.archivo = "Proyección" & Format(Date.Now(), "yyyyMMddHHmmss") & ".txt"
        End If
        Dim fs As FileStream

        'Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If File.Exists(ruta) Then

                'Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "")
            Else

                'Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)

                'Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                'MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            fs.Close()
        End Try
    End Sub
    Private Sub EscribirArchivoDiarios()
        Dim tx As New StreamWriter(Me.ruta & Me.archivo)
        Dim fila As Integer, pivot As Integer, idX As Integer = 0, e As Integer
        Dim total As Double, tc As Double
        Dim fecha As Date
        Dim folio As String = "", uuid As String = "", sn As String, idFol As String = ""
        Dim totalFilas As Integer = Dgv_Prepolizas.Rows.Count
        Dim NPol As New NPolizas(), pol As New Polizas()
        Try
            fecha = Dgv_Prepolizas.Rows(0).Cells("fechaFact").Value
            pol = NPol.RecuperarUltimoFolio(Me.cadenaConex, fecha, Me.subsid)
            e = pol.FolioPoliza
            For fila = 0 To totalFilas - 1
                Dim cargo As Integer = 0
                pivot = Dgv_Prepolizas.Rows(fila).Cells("pivot").Value
                With Dgv_Prepolizas.Rows(fila)
                    If pivot = 1 And uuid <> Dgv_Prepolizas.Rows(fila).Cells("uuidFactura").Value Then
                        'Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
                        e += 1
                        .Cells("folioPoliza").Value = e
                        tx.Write("P  ")
                        tx.Write(CDate(.Cells("fechaFact").Value).ToString("yyyyMMdd") & " ") 'ToString("yyyyMMdd", .Cells("fechaFact").Value))
                        tx.Write("   3 ")
                        tx.Write(String.Format("{0,9}", e) & " ")
                        tx.Write("1 ")
                        tx.Write("0          ")
                        tx.Write(String.Format("{0,-100}", .Cells("concepto").Value))
                        tx.Write("11 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(String.Format("{0,-37}", ""))
                        tx.WriteLine()
                        uuid = Dgv_Prepolizas.Rows(fila).Cells("uuidFactura").Value
                    End If
                    If DatePart("m", .Cells("fechaFact").Value) = DatePart("m", .Cells("fechaPagoFact").Value) And'''''''''''''''''''''''\
                       DatePart("yyyy", .Cells("fechaFact").Value) = DatePart("yyyy", .Cells("fechaPagoFact").Value) Then '''''''''''''''/
                        If .Cells("monedaVP").Value = "MXN" Then folio = "F-" & .Cells("idFactura").Value
                        If .Cells("monedaVP").Value = "USD" Then
                            idFol = .Cells("idFactura").Value
                            tc = .Cells("tc").Value
                            If Len(idFol) > 6 Then idFol = Strings.Right(idFol, 6)
                            folio = "F-" & idFol & " TC " & tc
                        End If
                    Else
                        If .Cells("monedaVP").Value = "MXN" Then folio = "F/" & .Cells("idFactura").Value
                        If .Cells("monedaVP").Value = "USD" Then
                            idFol = .Cells("idFactura").Value
                            tc = .Cells("tc").Value
                            If Len(idFol) > 6 Then idFol = Strings.Right(idFol, 6)
                            folio = "F/" & idFol & " TC " & tc
                        End If
                    End If
                    If .Cells("familia").Value = "Cargo" Or .Cells("familia").Value = "ProveedorUSD" Or .Cells("familia").Value = "ComplementariaUSD" Or .Cells("familia").Value = "Retencion de IVA" Or
                        .Cells("familia").Value = "Traslado" Then
                        cargo = 1
                    End If
                    sn = idSegNeg(.Cells("area").Value)
                    total = .Cells("total").Value
                    tx.Write("M1 ")
                    tx.Write(String.Format("{0,-30}", .Cells("cuenta").Value) & " ")
                    tx.Write(String.Format("{0,-20}", folio) & " ")
                    tx.Write(cargo & " ")
                    tx.Write(String.Format("{0,-20}", total) & " ")
                    tx.Write("0          ")
                    tx.Write("0.0                  ")
                    tx.Write(String.Format("{0,-101}", ""))
                    tx.Write(String.Format("{0,4}", sn) & " ")
                    tx.Write(String.Format("{0,-37}", ""))
                    tx.WriteLine()
                    tx.Write("AM ")
                    tx.Write(String.Format("{0,-30}", .Cells("uuidFactura").Value) & " ")
                    tx.WriteLine()
                    If (.Cells("monedaVP").Value = "MXN" And .Cells("pivot").Value = "4") Or (.Cells("monedaVP").Value = "USD" And .Cells("pivot").Value = "5") Then
                        tx.Write("AD ")
                        tx.Write(String.Format("{0,-30}", .Cells("uuidFactura").Value) & " ")
                        tx.WriteLine()
                    End If
                    .Cells("folioPoliza").Value = e
                End With
            Next
            MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "")
            tx.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            tx.Close()
        End Try
    End Sub
    Private Sub EscribirArchivoProyecciones()
        Dim tx As New StreamWriter(Me.ruta & Me.archivo)
        Dim fila As Integer, pivot As Integer, idX As Integer = 0, e As Long, mon As Integer
        Dim folio As String = "", uuid As String = "", idFol As String = ""
        Dim totalFilas As Integer = Dgv_Egresos.Rows.Count
        Dim NPol As New NPolizas(), pol As New Polizas(), NComp As New NCompras()
        Dim tot As Double = 0
        Try
            pol = NPol.RecuperarUltimoFolioEgresos(Me.cadenaConex, Me.subsid)
            e = pol.FolioPolizaEgreso
            Dim ei As Integer = 0
            For fila = 0 To totalFilas - 1
                Dim cargo As Integer = 0
                pivot = Dgv_Egresos.Rows(fila).Cells("pivote").Value
                With Dgv_Egresos.Rows(fila)
                    If pivot = 1 And uuid <> Dgv_Egresos.Rows(fila).Cells("uuidE").Value Then
                        'Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
                        e += ei
                        .Cells("folioProyeccion").Value = e
                        tx.Write("EG ")
                        tx.Write("04040 ")
                        tx.Write(String.Format("{0,30}", 48) & " ")
                        tx.Write(String.Format("{0,20}", e) & " ")
                        tx.Write(CDate(.Cells("fechaPag").Value).ToString("yyyyMMdd") & " ")
                        tx.Write(String.Format("{0,4}", .Cells("ejercicioPag").Value) & " ")
                        tx.Write(String.Format("{0,2}", .Cells("periodoPag").Value) & " ")
                        tx.Write(CDate(.Cells("fechaPag").Value).ToString("yyyyMMdd") & " ")
                        tx.Write(String.Format("{0,4}", .Cells("ejercicioPag").Value) & " ")
                        tx.Write(String.Format("{0,2}", .Cells("periodoPag").Value) & " ")
                        tx.Write(String.Format("{0,6}", .Cells("idProv").Value) & " ")
                        tx.Write(String.Format("{0,-200}", .Cells("prov").Value) & " ")
                        tx.Write(String.Format("{0,-20}", .Cells("codBanco").Value) & " ")
                        tx.Write("0 ")
                        tx.Write("2 ")
                        tx.Write(String.Format("{0,4}", .Cells("moneda2").Value) & " ")
                        If .Cells("moneda2").Value = 1 Then
                            mon = 2
                            tx.Write(String.Format("{0,4}", mon) & " ")
                            tx.Write(String.Format("{0,-20}", Format(.Cells("tipCambio").Value, "0.0")) & " ")
                        ElseIf .Cells("moneda2").Value = 2 Or .Cells("moneda2").Value = 3 Then
                            mon = 1
                            tx.Write(String.Format("{0,4}", mon) & " ")
                            tx.Write(String.Format("{0,-20}", Format(.Cells("tipCambio").Value, "0.0000")) & " ")
                        End If
                        tx.Write(String.Format("{0,-20}", .Cells("total2").Value) & " ")
                        tx.Write(String.Format("{0,-20}", .Cells("oCompra").Value) & " ")
                        tx.Write(String.Format("{0,-100}", Replace(.Cells("conceptoCuenta").Value, vbLf, " ")) & " ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(String.Format("{0,20}", "") & " ") 'UsuAutorizaPresupuesto
                        tx.Write(String.Format("{0,10}", 0) & " ")
                        tx.Write(String.Format("{0,10}", 0) & " ")
                        tx.Write(String.Format("{0,4}", 0) & " ")
                        tx.Write(String.Format("{0,2}", 0) & " ")
                        tx.Write(String.Format("{0,10}", 0) & " ")
                        tx.Write(String.Format("{0,10}", 0) & " ")
                        tx.Write(String.Format("{0,10}", 0) & " ")
                        tx.Write("1 ")
                        tx.Write(String.Format("{0,10}", 0) & " ") 'IdPoliza
                        tx.Write("  201 ")
                        tx.Write(String.Format("{0,10}", 0) & " ") 'IdDocumento
                        tx.Write("   0 ")
                        tx.Write(" 0 ")
                        tx.Write(String.Format("{0,10}", 0) & " ")
                        tx.Write(String.Format("{0,10}", 0) & " ")
                        tx.Write(String.Format("{0,10}", 0) & " ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(String.Format("{0,20}", "") & " ")
                        tx.Write(String.Format("{0,20}", "") & " ")
                        tx.Write("0 ")
                        tx.Write(String.Format("{0,36}", "") & " ")
                        tx.Write(String.Format("{0,-50}", .Cells("cuentaS").Value) & " ")
                        tx.Write(String.Format("{0,10}", Me.idBanco) & " ")
                        tx.Write("03 ")
                        tx.WriteLine()
                        uuid = Dgv_Egresos.Rows(fila).Cells("uuidE").Value
                        tot = .Cells("total2").Value
                        ei = 1
                    End If
                    If pivot = 2 And uuid = Dgv_Egresos.Rows(fila).Cells("uuidE").Value Then
                        tx.Write("DC ")
                        tx.Write("04040 ")
                        tx.Write(String.Format("{0,30}", 48) & " ")
                        tx.Write(String.Format("{0,-20}", .Cells("codBanco").Value) & " ")
                        tx.Write(String.Format("{0,20}", e) & " ")
                        tx.Write(String.Format("{0,5}", NComp.RecuperaCategorias(cadenaConex, .Cells("moneda2").Value)) & " ")
                        tx.Write(String.Format("{0,5}", .Cells("sc").Value) & " ")
                        Dim prc As Double = Format(((.Cells("total2").Value * 100) / tot), "0.00")
                        tx.Write(String.Format("{0,-20}", prc) & " ")
                        tx.Write(String.Format("{0,-20}", .Cells("total2").Value) & " ")
                        tx.WriteLine()
                    End If
                    If pivot = 3 And uuid = Dgv_Egresos.Rows(fila).Cells("uuidE").Value Then
                        tx.Write("AD ")
                        tx.Write(String.Format("{0,-36}", .Cells("uuidE").Value) & " ")
                        tx.WriteLine()
                    End If
                End With
            Next
            MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "")
            tx.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            tx.Close()
        End Try
    End Sub
    Private Function idSegNeg(ByVal segneg As String) As String
        Select Case segneg
            Case "CONTABILIDAD" : Return "1"
            Case "CALIDAD" : Return "2"
            Case "ASEGURAMIENTO DE CALIDAD" : Return "2"
            Case "Control" : Return "3"
            Case "CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/ CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/C PRODUCCIÓN" : Return "3"
            Case "VENTAS/CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/CPRODUCCIION" : Return "3"
            Case "VENTAS/CPRODUCCION" : Return "3"
            Case "VENTAS/CPRODUCCIÓN" : Return "3"
            Case "INSPECCION PRODUCCION" : Return "3"
            Case "ATENCIÓN AL CLIENTE" : Return "3"
            Case "FUNDICION" : Return "4"
            Case "FUNDICIÓN" : Return "4"
            Case "FUNDICION 1" : Return "4"
            Case "FUNDICIÓN 1" : Return "4"
            Case "FUNDICION F1" : Return "4"
            Case "FUNDICIÓN F1" : Return "4"
            Case "INSPECCIÓN FUNDICION" : Return "4"
            Case "FUNDICION 1 Y 2" : Return "4, 11"
            Case "MOLDES" : Return "5"
            Case "MOLDES." : Return "5"
            Case "MAQUINADO" : Return "6"
            Case "Maquinado F1" : Return "6"
            Case "MAQUINADO F1" : Return "6"
            Case "MAQUINADOF1" : Return "6"
            Case "ARTICULOS DE LIMPIEZA" : Return "7"
            Case "ASUNTOS GENERALES" : Return "7"
            Case "ASUNTOS GENERALES." : Return "7"
            Case "RECURSOS HUMANOS" : Return "7"
            Case "SEGURIDAD" : Return "7"
            Case "SEGURIDAD E HIGIENE" : Return "7"
            Case "SEGURIDAD E HIGIENE." : Return "7"
            Case "SISTEMAS IT" : Return "7"
            Case "COMPRAS" : Return "8"
            Case "COMPRAS." : Return "8"
            Case "INGENIERIA" : Return "9"
            Case "INGENIERÍA" : Return "9"
            Case "GESTION" : Return "10"
            Case "GESTIÓN" : Return "10"
            Case "GESTIÓN/ FACILITIES" : Return "10"
            Case "GESTION/FACILITIES" : Return "10"
            Case "GESTIÓN/FACILITIES" : Return "10"
            Case "FUNCICIÓN F2" : Return "11"
            Case "FUNDICION 2" : Return "11"
            Case "FUNDICIÓN 2" : Return "11"
            Case "FUNDICION F2" : Return "11"
            Case "Fundición F2" : Return "11"
            Case "FUNDICIÓN F2" : Return "11"
            Case "MAQUINADO 2" : Return "12"
            Case "Maquinado F2" : Return "12"
            Case "MAQUINADO F2" : Return "12"
            Case "INSPECCION DE CALIDAD" : Return "13"
            Case "INSPECCIÓN DE CALIDAD" : Return "13"
            Case Else : Return "1"
        End Select
    End Function
    Private Sub LimpiarFiltros()
        Txt_FiltroOC.Text = ""
        Txt_FiltroCompras.Text = ""
        Txt_FiltroFactura.Text = ""
        Txt_FiltroProveedor.Text = ""
        Cmb_BancoMoneda.SelectedValue = ""
        Me.codigoBanco = ""
    End Sub
    Private Sub LimpiarDgv()
        Dim fila As Integer, totalFilas As Integer = Dgv_Compras.Rows.Count()
        Dim var
        If Me.origen = 1 Then
            Dgv_Prepolizas.DataSource = Nothing
            Dgv_Prepolizas.Rows.Clear()
        ElseIf Me.origen = 2 Then
            Dgv_Egresos.DataSource = Nothing
            Dgv_Egresos.Rows.Clear()
        End If
        For fila = 0 To totalFilas - 1
            With Dgv_Compras.Rows(fila)
                var = .Cells("seleccion").Value
                If .Cells("seleccion").Value = 1 Then
                    .Cells("seleccion").Value = 0
                End If
            End With
        Next
    End Sub
    Private Function RegresoMonedaLetra(moneda As String) As String
        Select Case moneda
            Case "The Hiroshima Bank Ltd" : Return "USD"
            Case "The hiroshima Bank Yenes" : Return "YEN"
            Case "Banamex Pesos" : Return "MXN"
            Case "Sumitomo Pesos" : Return "MXN"
            Case "Sumitomo Yenes" : Return "YEN"
            Case "Sumitomo USD" : Return "USD"
            Case "Banamex USD" : Return "USD"
            Case "banco MONEX SA" : Return "YEN"
            Case "Sumitomo Mitsui Banking Corp MXN" : Return "MXN"
            Case "Sumitomo Mitsui Banking Corp USD" : Return "USD"
            Case "Banorte" : Return "MXN"
            Case Else : Return "MXN"
        End Select
    End Function
    Private Sub InsertaBitacora(ByVal de As Integer)
        Dim NCompras As New NCompras(), lstComp As New LCompras
        Dim fila As Integer, totalFila As Integer
        Dim emp As String = ""
        Select Case Me.subsid
            Case "MEX" : emp = "AAM"
            Case "SERV" : emp = "AAMS"
        End Select
        If de = 1 Then
            totalFila = Dgv_Prepolizas.Rows.Count - 1
            For fila = 0 To totalFila
                With Dgv_Prepolizas.Rows(fila)
                    If .Cells("Pivot").Value = 4 Then
                        Dim comp As New Compras()
                        comp.IdProvision = .Cells("folioProvisionPol").Value
                        comp.IdOrdenCompra = .Cells("ordenCompra").Value
                        comp.MontoFact = .Cells("total").Value
                        comp.MontoOC = .Cells("total").Value
                        comp.FolioDocCont = .Cells("folioPoliza").Value
                        comp.FechaFactura = .Cells("fechaFact").Value
                        comp.Empresa = emp
                        comp.Tipo = 3
                        lstComp.Add(comp)
                    End If
                End With
            Next
            NCompras.AgregarBitacora(Me.cadConexCont, lstComp)
        ElseIf de = 2 Then
            totalFila = Dgv_Egresos.Rows.Count - 1
            For fila = 0 To totalFila
                With Dgv_Egresos.Rows(fila)
                    If .Cells("Pivote").Value = 1 Then
                        Dim comp As New Compras()
                        comp.IdProvision = .Cells("folioProvisionProy").Value
                        comp.IdOrdenCompra = .Cells("oCompra").Value
                        comp.MontoFact = .Cells("total2").Value
                        comp.MontoOC = .Cells("total2").Value
                        comp.FolioDocCont = .Cells("folioProyeccion").Value
                        comp.FechaFactura = .Cells("fechaPag").Value
                        comp.Empresa = emp
                        comp.Tipo = 48
                        lstComp.Add(comp)
                    End If
                End With
            Next
            NCompras.AgregarBitacora(Me.cadConexCont, lstComp)
        End If
    End Sub
#End Region
End Class