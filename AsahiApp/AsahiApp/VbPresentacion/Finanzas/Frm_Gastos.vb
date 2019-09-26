﻿Imports System.Data.SqlClient
Imports Clases
Imports Negocio

Public Class Frm_Gastos
#Region "Variables de clase"
    Dim cadenaConex As String, cadConex As String
    Dim c As Integer = 0
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_MasterPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion
        Me.cadenaConex = conex.cadenaConexExpress
        Me.cadConex = conex.conexion2008
        Cmb_Años.Enabled = False
        Cmb_Depto.Enabled = False
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        RellenaCmbAño()

        Rdb_Español.Checked = True
        Dim mes As Double = DateTime.Now.ToString("MM")
        Dim año As Double = DateTime.Now.ToString("yyyy")
        Dim mesLetra As String = UCase(MonthName(mes))
        Cmb_Meses.SelectedItem = mesLetra
        Cmb_Años.Text = año
        Cmb_Meses_SelectionChangeCommitted(sender, e)
        Cmb_Años_SelectionChangeCommitted(sender, e)
        RecuperarPlanesGlobal()
        RecuperarPlanesTVentas()
    End Sub
    Private Sub Cmb_Meses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Meses.SelectionChangeCommitted
        Cmb_Años.Enabled = True
        If Me.c = 1 Then
            RecuperarPlanesGlobal()
            RecuperarPlanesTVentas()
            Cmb_Depto.SelectedItem = ""
        End If
    End Sub
    Private Sub Cmb_Años_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Años.SelectionChangeCommitted
        Cmb_Depto.Enabled = True
        If Me.c = 1 Then
            RecuperarPlanesGlobal()
            RecuperarPlanesTVentas()
        End If
    End Sub
    Private Sub Cmb_Depto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Depto.SelectionChangeCommitted
        If Cmb_Depto.SelectedValue <> "" Then
            Dgv_GastosDepto.ColumnHeadersVisible = True
            RecuperarPlanesSegNeg()
        Else
            Dgv_GastosDepto.ColumnHeadersVisible = False
            Dgv_GastosDepto.DataSource = Nothing
            Dgv_GastosDepto.Rows.Clear()
        End If
    End Sub
    Private Sub Pct_Limpiar_Click(sender As Object, e As EventArgs) Handles Pct_Limpiar.Click
        Dgv_GastosDepto.DataSource = Nothing
        Dgv_GastosDepto.Rows.Clear()
        Dgv_GastosDepto.ColumnHeadersVisible = False
        Cmb_Depto.SelectedValue = ""
    End Sub
    Private Sub Lbl_ventas_DoubleClick(sender As Object, e As EventArgs) Handles Lbl_Ventas.DoubleClick

    End Sub
#End Region
#Region "Rellena Cmb"
    Private Sub RellenaCmbDepartamento()
        Dim lstDep As New LEmpleado()
        Dim NEmp As New NEmpleado()
        Dim dep As New Empleado()

        lstDep = NEmp.RecuperarDepartamentos(Me.cadConex, 1)
        dep.Departamento = ""
        lstDep.Add(dep)
        With Cmb_Depto
            .DataSource = lstDep
            .ValueMember = "IdDepartamento"
            .DisplayMember = "Departamento"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaCmbMeses()
        With Cmb_Meses
            .Items.Add("ENERO")
            .Items.Add("FEBRERO")
            .Items.Add("MARZO")
            .Items.Add("ABRIL")
            .Items.Add("MAYO")
            .Items.Add("JUNIO")
            .Items.Add("JULIO")
            .Items.Add("AGOSTO")
            .Items.Add("SEPTIEMBRE")
            .Items.Add("OCTUBRE")
            .Items.Add("NOVIEMBRE")
            .Items.Add("DICIEMBRE")
        End With
    End Sub
    Private Sub RellenaCmbAño()
        Dim lstaño As New LHorarios()
        Dim NHor As New NHorasExtra()

        lstaño = NHor.RecuperarAños(Me.cadConex)
        With Cmb_Años
            .DataSource = lstaño
            .ValueMember = "Año"
            .DisplayMember = "Año"
            .SelectedItem = Nothing
        End With
    End Sub
#End Region
#Region "Rellenar Formulario"
    Private Sub RellenarDgvGastosGral(ByVal lstGast As LGastos)
        Dim fila As Integer = 0
        Dgv_GastosGlobal.DataSource = Nothing
        Dgv_GastosGlobal.Rows.Clear()

        For Each item In lstGast
            Dgv_GastosGlobal.Rows.Add()
            Dgv_GastosGlobal.Columns("masterp").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_GastosGlobal.Columns("actual").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_GastosGlobal.Rows(fila)
                .Cells("noCta").Value = item.Cuenta
                .Cells("cta").Value = item.NombreCuenta
                .Cells("masterp").Value = Format(item.MasterP, "$ #,###,##0.00")
                If .Cells("masterp").Value = 0 Then .Cells("masterp").Style.ForeColor = Color.Red
                .Cells("actual").Value = Format(item.Actual, "$ #,###,##0.00")
                If .Cells("actual").Value = 0 Then .Cells("actual").Style.ForeColor = Color.Red
                .Cells("cotizacion").Value = Format(item.Cotizacion, "$ #,###,##0.00")
                If .Cells("cotizacion").Value = 0 Then .Cells("cotizacion").Style.ForeColor = Color.Red
                .Cells("po").Value = Format(item.OC, "$ #,###,##0.00")
                If .Cells("po").Value = 0 Then .Cells("po").Style.ForeColor = Color.Red
                .Cells("comp").Value = Format(item.Compras, "$ #,###,##0.00")
                If .Cells("comp").Value = 0 Then .Cells("comp").Style.ForeColor = Color.Red
                .Cells("poliza").Value = Format(item.Poliza, "$ #,###,##0.00")
                If .Cells("poliza").Value = 0 Then .Cells("poliza").Style.ForeColor = Color.Red
                .Cells("dif").Value = Format(item.MasterP - item.Actual, "$ #,###,##0.00")
                If .Cells("dif").Value < 0 Then .Cells("dif").Style.ForeColor = Color.Red
            End With
            fila += 1
        Next
    End Sub
    Private Sub RellenarDgvGastosDepto(ByVal lstGast As LGastos)
        Dim fila As Integer = 0
        Dgv_GastosDepto.DataSource = Nothing
        Dgv_GastosDepto.Rows.Clear()

        For Each item In lstGast
            Dgv_GastosDepto.Rows.Add()
            Dgv_GastosDepto.Columns("masterp2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_GastosDepto.Columns("actual2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_GastosDepto.Rows(fila)
                .Cells("noCta2").Value = item.Cuenta
                .Cells("cta2").Value = item.NombreCuenta
                .Cells("masterp2").Value = Format(item.MasterP, "$ #,###,##0.00")
                If .Cells("masterp2").Value = 0 Then .Cells("masterp2").Style.ForeColor = Color.Red
                .Cells("actual2").Value = Format(item.Actual, "$ #,###,##0.00")
                If .Cells("actual2").Value = 0 Then .Cells("actual2").Style.ForeColor = Color.Red
                .Cells("cotizacion2").Value = Format(item.Cotizacion, "$ #,###,##0.00")
                If .Cells("cotizacion2").Value = 0 Then .Cells("cotizacion2").Style.ForeColor = Color.Red
                .Cells("po2").Value = Format(item.OC, "$ #,###,##0.00")
                If .Cells("po2").Value = 0 Then .Cells("po2").Style.ForeColor = Color.Red
                .Cells("comp2").Value = Format(item.Compras, "$ #,###,##0.00")
                If .Cells("comp2").Value = 0 Then .Cells("comp2").Style.ForeColor = Color.Red
                .Cells("poliza2").Value = Format(item.Poliza, "$ #,###,##0.00")
                If .Cells("poliza2").Value = 0 Then .Cells("poliza2").Style.ForeColor = Color.Red
                .Cells("dif2").Value = Format(item.MasterP - item.Actual, "$ #,###,##0.00")
                If .Cells("dif2").Value < 0 Then .Cells("dif2").Style.ForeColor = Color.Red
            End With
            fila += 1
        Next
    End Sub
    Private Sub RellenaPlanVentas(ByVal lstGastos As LGastos)
        Dim smaM As Double = 0
        Dim smaC As Double = 0
        For Each item In lstGastos
            Select Case item.SegmNegocio
                Case 4
                    Lbl_MontoFF1.Text = Format(item.PlanMonto, "$ #,###,##0.00")
                    Lbl_CantFF1.Text = Format(item.Plan, "#,###,##")
                Case 6
                    Lbl_MontoMF1.Text = Format(item.PlanMonto, "$ #,###,##0.00")
                    Lbl_CantMF1.Text = Format(item.Plan, "#,###,##")
                Case 11
                    Lbl_MontoFF2.Text = Format(item.PlanMonto, "$ #,###,##0.00")
                    Lbl_CantFF2.Text = Format(item.Plan, "#,###,##")
                Case 12
                    Lbl_MontoMF2.Text = Format(item.PlanMonto, "$ #,###,##0.00")
                    Lbl_CantMF2.Text = Format(item.Plan, "#,###,##")
            End Select
            smaM += item.PlanMonto
            smaC += item.Plan
        Next
        Lbl_MontoPlan.Text = Format(smaM, "$ #,###,##0.00")
        Lbl_CantPlan.Text = Format(smaC, "#,###,##")
    End Sub
#End Region
#Region "Recuperar"
    Private Sub RecuperarPlanesGlobal()
        Dim NGast As New NGastos(), lstGast As New LGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text
        Dim fi As Date, ff As Date, d As Date

        d = "15" & "/" & mes & "/" & año
        fi = Format(DateSerial(Year(d), Month(d), 1), "dd/MM/yyyy")
        ff = Format(DateSerial(Year(d), Month(d) + 1, 0), "dd/MM/yyyy")

        lstGast = NGast.RecuperarPlanGastos(Me.cadenaConex, mes, año, fi, ff)
        RellenarDgvGastosGral(lstGast)
        Me.c = 1
    End Sub
    Private Sub RecuperarPlanesSegNeg()
        Dim NGast As New NGastos(), lstGast As New LGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text, sn As Integer
        Dim fi As Date, ff As Date, d As Date

        d = "15" & "/" & mes & "/" & año
        fi = Format(DateSerial(Year(d), Month(d), 1), "dd/MM/yyyy")
        ff = Format(DateSerial(Year(d), Month(d) + 1, 0), "dd/MM/yyyy")
        sn = AcoplarSegmentoNegocioADepto()

        lstGast = NGast.RecuperarPlanGastosDpto(Me.cadenaConex, mes, año, fi, ff, sn)
        RellenarDgvGastosDepto(lstGast)
        Me.c = 1
    End Sub
    Private Sub RecuperarPlanesTVentas()
        Dim NGast As New NGastos(), lstGast As New LGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text

        lstGast = NGast.RecuperarPlanVentas(Me.cadenaConex, mes, año)
        RellenaPlanVentas(lstGast)
    End Sub
#End Region
#Region "Otros procesos"
    Private Function MesLetraNumero(ByVal mes As String) As Integer
        Select Case mes
            Case "ENERO" : Return 1
            Case "FEBRERO" : Return 2
            Case "MARZO" : Return 3
            Case "ABRIL" : Return 4
            Case "MAYO" : Return 5
            Case "JUNIO" : Return 6
            Case "JULIO" : Return 7
            Case "AGOSTO" : Return 8
            Case "SEPTIEMBRE" : Return 9
            Case "OCTUBRE" : Return 10
            Case "NOVIEMBRE" : Return 11
            Case "DICIEMBRE" : Return 12
            Case Else : Return 0
        End Select
    End Function
    Private Function AcoplarSegmentoNegocioADepto() As Integer
        Select Case Cmb_Depto.Text
            Case "ACABADO 1" : Return 4
            Case "ACABADO 2" : Return 11
            Case "ASEGURAMIENTO DE CALIDAD" : Return 2
            Case "ASUNTOS GENERALES" : Return 7
            Case "ATENCIÓN AL CLIENTE" : Return 3
            Case "COMPRAS" : Return 8
            Case "CONTABILIDAD" : Return 1
            Case "CONTROL DE CLIENTES" : Return 3
            Case "CONTROL DE MANUFACTURA" : Return 3
            Case "CONTROL DE PRODUCCION" : Return 3
            Case "FUNDICION 1" : Return 4
            Case "FUNDICION 2" : Return 11
            Case "INGENIERÍA-FUNDICIÓN" : Return 9
            Case "INGENIERÍA-MAQUINADO" : Return 9
            Case "INSPECCIÓN FUNDICION" : Return 13
            Case "INSPECCIÓN MAQUINADO" : Return 13
            Case "INSPECCION PRODUCCION" : Return 10
            Case "MANTENIMIENTO DE PLANTA" : Return 10
            Case "MANTENIMIENTO FUNDICION" : Return 4
            Case "MANTENIMIENTO MAQUINADO" : Return 6
            Case "MAQUINADO F1" : Return 6
            Case "MAQUINADO F2" : Return 12
            Case "MOLDES" : Return 5
            Case "SEGURIDAD" : Return 7
            Case "SISTEMAS IT" : Return 1
            Case Else : Return 0
        End Select
    End Function
#End Region
End Class