﻿Imports Clases
Imports Negocio

Public Class Frm_ConceptoPoliza
    Dim origen As Integer '1:Diario, 3:Diarios Ventas
    Dim lstComp As New LCompras
    Dim lstVent As New LVentas
    Dim conex As New conexion()
    Dim cadenaConex As String
    Dim cadenaConexCont As String
    Dim ip As String = Strings.Left(Me.conex.getIp(), 6)
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal oc As String, ByVal lstComp As LCompras, origen As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.origen = origen
        Txt_Po.Text = oc
        Me.lstComp = lstComp
    End Sub
    Sub New(ByVal oc As String, ByVal lstVent As LVentas, origen As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.origen = origen
        Txt_Po.Text = oc
        Me.lstVent = lstVent
    End Sub
    Private concepto_ As String
    Public Property Concepto() As String
        Get
            Return concepto_
        End Get
        Set(ByVal value As String)
            concepto_ = value
        End Set
    End Property
    Private Sub Frm_ConceptoPoliza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim proveedor() As String
        If Me.ip = "172.16" Then
            Me.cadenaConex = Me.conex.cadenaConexExpress
            Me.cadenaConexCont = Me.conex.conexionCont
        Else
            Me.cadenaConex = Me.conex.cadenaConexExpressFor
            Me.cadenaConexCont = Me.conex.conexionCont
        End If
        Try
            If Me.origen = 1 Then
                proveedor = Me.lstComp.Item(0).Proveedor.Split(New Char() {" "c})
                If proveedor.Count() > 1 Then
                    Txt_Proveedor.Text = proveedor(0) & " " & proveedor(1)
                Else
                    Txt_Proveedor.Text = proveedor(0)
                End If
                RellenarTxtFamilia(lstComp)
                RellenarTxtSegNeg(lstComp)
                ElseIf Me.origen = 3 Then
                    Lbl_CteProveedor.Text = "CLIENTE"
                Txt_Prov.Text = "VENTA"
                proveedor = Me.lstVent.Item(0).Cliente.Split(New Char() {" "c})
                Txt_Proveedor.Text = proveedor(0) '& " " & proveedor(1)
                RellenarTxtFamilia(lstVent)
                RellenarTxtSegNeg(lstVent)
                Label2.Visible = False
                Txt_Po.Visible = False
            End If
            Txt_Prov.Select()
        Catch ex As Exception
            MsgBox("NO HAY XML LIGADO", MsgBoxStyle.Critical)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Frm_ConceptoPoliza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If Me.origen = 1 Then
                    Dim concepto As String
                    concepto = "PO " & Txt_Po.Text & " PROVISION " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                ElseIf Me.origen = 3 Then
                    Dim concepto As String
                    concepto = "PROVISION DE " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        If Me.origen = 1 Then
            Dim concepto As String
            concepto = "PO " & Txt_Po.Text & " PROVISION " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
            Me.Concepto = concepto
            DialogResult = DialogResult.OK
            Me.Dispose()
        ElseIf Me.origen = 3 Then
            Dim concepto As String
            concepto = "PROVISION DE " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
            Me.Concepto = concepto
            DialogResult = DialogResult.OK
            Me.Dispose()
        End If
    End Sub
    Private Sub Txt_Familia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Familia.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If Me.origen = 1 Then
                    Dim concepto As String
                    concepto = "PO " & Txt_Po.Text & " PROVISION " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                ElseIf Me.origen = 3 Then
                    Dim concepto As String
                    concepto = "PROVISION DE " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub Txt_Po_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Po.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If Me.origen = 1 Then
                    Dim concepto As String
                    concepto = "PO " & Txt_Po.Text & " PROVISION " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                ElseIf Me.origen = 3 Then
                    Dim concepto As String
                    concepto = "PROVISION DE " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub Txt_Prov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Prov.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If Me.origen = 1 Then
                    Dim concepto As String
                    concepto = "PO " & Txt_Po.Text & " PROVISION " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                ElseIf Me.origen = 3 Then
                    Dim concepto As String
                    concepto = "PROVISION DE " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub Txt_Proveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Proveedor.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If Me.origen = 1 Then
                    Dim concepto As String
                    concepto = "PO " & Txt_Po.Text & " PROVISION " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                ElseIf Me.origen = 3 Then
                    Dim concepto As String
                    concepto = "PROVISION DE " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub Txt_SegNeg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SegNeg.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                If Me.origen = 1 Then
                    Dim concepto As String
                    concepto = "PO " & Txt_Po.Text & " PROVISION " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                ElseIf Me.origen = 3 Then
                    Dim concepto As String
                    concepto = "PROVISION DE " & Txt_Prov.Text & " " & Txt_Familia.Text & " " & Txt_Proveedor.Text & " S-" & Txt_SegNeg.Text & ""
                    Me.Concepto = concepto
                    DialogResult = DialogResult.OK
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub RellenarTxtFamilia(ByVal lstCompra As LCompras)
        Dim fam As String = ""
        Dim vuelta As Integer = 0
        Dim lstComp As New LCompras(), NComp As New NCompras()
        lstComp = NComp.RecuperarListaFamilia(Me.cadenaConex, Me.lstComp.Item(0).UUID)
        For Each item In lstComp
            If vuelta <= 2 Then
                If fam = "" Or fam <> item.Familia Then
                    fam = item.Familia
                    If vuelta > 0 Then Txt_Familia.Text = Txt_Familia.Text & ","
                    Txt_Familia.Text = Txt_Familia.Text & item.Familia
                    vuelta += 1
                End If
            End If
        Next
    End Sub
    Private Sub RellenarTxtSegNeg(ByVal lstCompra As LCompras)
        Dim area As String = ""
        Dim vuelta As Integer = 0
        Dim lstComp As New LCompras(), NComp As New NCompras()
        lstComp = NComp.RecuperarListaSegNeg(Me.cadenaConex, Me.lstComp.Item(0).UUID)
        For Each item In lstComp
            If vuelta <= 3 Then
                If area = "" Or area <> item.Area Then
                    area = item.Area
                    If vuelta > 0 Then Txt_SegNeg.Text = Txt_SegNeg.Text & ","
                    Txt_SegNeg.Text = Txt_SegNeg.Text & NComp.IdSegNeg(Me.cadenaConexCont, item.Area)
                    vuelta += 1
                End If
            End If
        Next
    End Sub
    Private Sub RellenarTxtFamilia(ByVal lstVent As LVentas)
        Dim fam As String = ""
        Dim vuelta As Integer = 0
        Dim NComp As New NCompras()
        lstVent = NComp.RecuperarListaFamiliaVentas(Me.cadenaConex, Me.lstVent.Item(0).UUID)
        For Each item In lstVent
            If vuelta <= 2 Then
                If fam = "" Or fam <> item.Familia Then
                    fam = item.Familia
                    If vuelta > 0 Then Txt_Familia.Text = Txt_Familia.Text & ","
                    Txt_Familia.Text = Txt_Familia.Text & item.Familia
                    vuelta += 1
                End If
            End If
        Next
    End Sub
    Private Sub RellenarTxtSegNeg(ByVal lstVent As LVentas)
        Dim area As String = ""
        Dim vuelta As Integer = 0
        Dim NComp As New NCompras()
        lstVent = NComp.RecuperarListaSegNegVentas(Me.cadenaConex, Me.lstVent.Item(0).UUID)
        For Each item In lstVent
            If vuelta <= 3 Then
                If area = "" Or area <> item.Area Then
                    area = item.Area
                    If vuelta > 0 Then Txt_SegNeg.Text = Txt_SegNeg.Text & ","
                    Txt_SegNeg.Text = Txt_SegNeg.Text & NComp.IdSegNeg(Me.cadenaConexCont, item.Area)
                    vuelta += 1
                End If
            End If
        Next
    End Sub
    Private Function idSegNeg(ByVal segneg As String) As String
        Select Case segneg
            Case "ARTICULOS DE LIMPIEZA" : Return "7"
            Case "ASEGURAMIENTO DE CALIDAD" : Return "2"
            Case "ASUNTOS GENERALES" : Return "7"
            Case "ASUNTOS GENERALES." : Return "7"
            Case "CALIDAD" : Return "2"
            Case "COMPRAS" : Return "8"
            Case "COMPRAS." : Return "8"
            Case "CONTABILIDAD" : Return "1"
            Case "01.1 Contabilidad" : Return "1"
            Case "Control" : Return "3"
            Case "CONTROL DE PRODUCCIÓN" : Return "3"
            Case "FUNCICIÓN F2" : Return "11"
            Case "FUNDICION" : Return "4"
            Case "FUNDICIÓN" : Return "4"
            Case "FUNDICION 1" : Return "4"
            Case "FUNDICIÓN 1" : Return "4"
            Case "FUNDICION 1 Y 2" : Return "4, 11"
            Case "FUNDICION 2" : Return "11"
            Case "FUNDICIÓN 2" : Return "11"
            Case "FUNDICION F1" : Return "4"
            Case "FUNDICIÓN F1" : Return "4"
            Case "FUNDICION F2" : Return "11"
            Case "Fundición F2" : Return "11"
            Case "FUNDICIÓN F2" : Return "11"
            Case "GESTION" : Return "10"
            Case "GESTIÓN" : Return "10"
            Case "GESTIÓN/ FACILITIES" : Return "10"
            Case "GESTION/FACILITIES" : Return "10"
            Case "GESTIÓN/FACILITIES" : Return "10"
            Case "INGENIERIA" : Return "9"
            Case "INGENIERÍA" : Return "9"
            Case "INSPECCION DE CALIDAD" : Return "13"
            Case "INSPECCIÓN DE CALIDAD" : Return "13"
            Case "MAQUINADO" : Return "6"
            Case "MAQUINADO 2" : Return "12"
            Case "Maquinado F1" : Return "6"
            Case "Maquinado F2" : Return "12"
            Case "MAQUINADO F1" : Return "6"
            Case "MAQUINADO F2" : Return "12"
            Case "MAQUINADOF1" : Return "6"
            Case "MOLDES" : Return "5"
            Case "MOLDES." : Return "5"
            Case "RECURSOS HUMANOS" : Return "7"
            Case "SEGURIDAD" : Return "7"
            Case "SEGURIDAD E HIGIENE" : Return "7"
            Case "SEGURIDAD E HIGIENE." : Return "7"
            Case "2.3 Seguridad y 5S" : Return "7"
            Case "SISTEMAS IT" : Return "7"
            Case "VENTAS/ CONTROL DE PRODUCCIÓN" : Return "3"
            Case "VENTAS/C PRODUCCIÓN" : Return "3"
            Case "VENTAS/CONTROL DE PRODUCCIÓN" : Return "3"
            Case "04 Control de Producción" : Return "3"
            Case "4.2 Control de Producción" : Return "3"
            Case "VENTAS/CPRODUCCIION" : Return "3"
            Case "VENTAS/CPRODUCCION" : Return "3"
            Case "VENTAS/CPRODUCCIÓN" : Return "3"
            Case "4.1 Atención al cliente" : Return "3"
            Case Else : Return "1"
        End Select
    End Function
End Class