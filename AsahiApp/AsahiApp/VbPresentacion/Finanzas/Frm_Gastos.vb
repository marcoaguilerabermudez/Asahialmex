Imports System.Data.SqlClient
Imports Clases
Imports Negocio

Public Class Frm_Gastos
#Region "Variables de clase"
    Dim cadenaConex As String, cadConex As String
    Dim c As Integer = 0
    Dim idioma As Integer = 1
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_Gastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'RecuperarPlanesGlobal()
        'RecuperarPlanesTVentas()
    End Sub
    Private Sub Cmb_Meses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Meses.SelectionChangeCommitted
        Cmb_Años.Enabled = True
        If Cmb_Depto.Text <> "" Then
            Dgv_GastosDepto.ColumnHeadersVisible = True
            RecuperarPlanesSegNeg()
        End If
        RecuperarPlanesTVentas()
        Dgv_GastosGlobal.ColumnHeadersVisible = False
        Dgv_GastosGlobal.DataSource = Nothing
        Dgv_GastosGlobal.Rows.Clear()
        Dgv_DesplegadoAcum.DataSource = Nothing
        Dgv_DesplegadoAcum.Rows.Clear()
        Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.Visible = False
        Lbl_CantidadTot.Text = 0
        Lbl_CostoUnitTotal.Text = 0
        Lbl_CotoTotal.Text = 0
    End Sub
    Private Sub Cmb_Años_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Años.SelectionChangeCommitted
        Cmb_Depto.Enabled = True
        If Cmb_Depto.Text <> "" Then RecuperarPlanesSegNeg()
        RecuperarPlanesTVentas()
        Dgv_GastosGlobal.ColumnHeadersVisible = False
        Dgv_GastosGlobal.DataSource = Nothing
        Dgv_GastosGlobal.Rows.Clear()
        Dgv_DesplegadoAcum.DataSource = Nothing
        Dgv_DesplegadoAcum.Rows.Clear()
        Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.Visible = False
        Lbl_CantidadTot.Text = 0
        Lbl_CostoUnitTotal.Text = 0
        Lbl_CotoTotal.Text = 0
    End Sub
    Private Sub Cmb_Depto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Depto.SelectionChangeCommitted
        If Cmb_Depto.SelectedValue <> "" Then
            If Cmb_Meses.Text <> "" Then Dgv_GastosDepto.ColumnHeadersVisible = True
            RecuperarPlanesSegNeg()
            Dgv_GastosGlobal.ColumnHeadersVisible = False
            Dgv_GastosGlobal.DataSource = Nothing
            Dgv_GastosGlobal.Rows.Clear()
            Dgv_DesplegadoAcum.DataSource = Nothing
            Dgv_DesplegadoAcum.Rows.Clear()
            Dgv_DesplegadoAcum.ColumnHeadersVisible = False
            Dgv_DesplegadoAcum.Visible = False
            Lbl_CantidadTot.Text = 0
            Lbl_CostoUnitTotal.Text = 0
            Lbl_CotoTotal.Text = 0
        ElseIf Cmb_Depto.Text = "GENERAL" Or Cmb_Depto.Text = "総勘定科目" Then
            If Cmb_Meses.Text <> "" Then Dgv_GastosDepto.ColumnHeadersVisible = True
            RecuperarPlanesGlobal()
            Dgv_GastosGlobal.ColumnHeadersVisible = False
            Dgv_GastosGlobal.DataSource = Nothing
            Dgv_GastosGlobal.Rows.Clear()
            Dgv_DesplegadoAcum.DataSource = Nothing
            Dgv_DesplegadoAcum.Rows.Clear()
            Dgv_DesplegadoAcum.ColumnHeadersVisible = False
            Dgv_DesplegadoAcum.Visible = False
            Lbl_CantidadTot.Text = 0
            Lbl_CostoUnitTotal.Text = 0
            Lbl_CotoTotal.Text = 0
        Else
            Dgv_GastosDepto.ColumnHeadersVisible = False
            Dgv_GastosDepto.DataSource = Nothing
            Dgv_GastosDepto.Rows.Clear()
            Dgv_GastosGlobal.ColumnHeadersVisible = False
            Dgv_GastosGlobal.DataSource = Nothing
            Dgv_GastosGlobal.Rows.Clear()
            Dgv_DesplegadoAcum.DataSource = Nothing
            Dgv_DesplegadoAcum.Rows.Clear()
            Dgv_DesplegadoAcum.ColumnHeadersVisible = False
            Dgv_DesplegadoAcum.Visible = False
            Lbl_CantidadTot.Text = 0
            Lbl_CostoUnitTotal.Text = 0
            Lbl_CotoTotal.Text = 0
        End If
    End Sub
    Private Sub Pct_Limpiar_Click(sender As Object, e As EventArgs) Handles Pct_Limpiar.Click
        Dgv_GastosDepto.DataSource = Nothing
        Dgv_GastosDepto.Rows.Clear()
        Dgv_GastosDepto.ColumnHeadersVisible = False
        Dgv_GastosGlobal.DataSource = Nothing
        Dgv_GastosGlobal.Rows.Clear()
        Dgv_GastosGlobal.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.DataSource = Nothing
        Dgv_DesplegadoAcum.Rows.Clear()
        Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.Visible = False
        Lbl_TPlan.Visible = True
        Lbl_TReal.Visible = True
        Lbl_TDif.Visible = True
        Lbl_TPorcentaje.Visible = True
        Lbl_TAPLan.Visible = False
        Lbl_TAReal.Visible = False
        Lbl_TADif.Visible = False
        Lbl_TAPorcentaje.Visible = False
        Lbl_CantidadTot.Text = 0
        Lbl_CostoUnitTotal.Text = 0
        Lbl_CotoTotal.Text = 0
        Cmb_Depto.SelectedValue = ""
    End Sub
    Private Sub Lbl_ventas_DoubleClick(sender As Object, e As EventArgs) Handles Lbl_Ventas.DoubleClick

    End Sub
    Private Sub Rdb_Español_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Español.CheckedChanged
        Dgv_GastosDepto.DataSource = Nothing
        Dgv_GastosDepto.Rows.Clear()
        Dgv_GastosDepto.ColumnHeadersVisible = False
        Dgv_GastosGlobal.DataSource = Nothing
        Dgv_GastosGlobal.Rows.Clear()
        Dgv_GastosGlobal.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.DataSource = Nothing
        Dgv_DesplegadoAcum.Rows.Clear()
        Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.Visible = False
        Lbl_CantidadTot.Text = 0
        Lbl_CostoUnitTotal.Text = 0
        Lbl_CotoTotal.Text = 0
        Cmb_Depto.SelectedValue = ""
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        Traducir()
    End Sub
    Private Sub Rdb_Japones_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Japones.CheckedChanged
        Dgv_GastosDepto.DataSource = Nothing
        Dgv_GastosDepto.Rows.Clear()
        Dgv_GastosDepto.ColumnHeadersVisible = False
        Dgv_GastosGlobal.DataSource = Nothing
        Dgv_GastosGlobal.Rows.Clear()
        Dgv_GastosGlobal.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.DataSource = Nothing
        Dgv_DesplegadoAcum.Rows.Clear()
        Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.Visible = False
        Cmb_Depto.SelectedValue = ""
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        Traducir()
    End Sub
    Private Sub Dgv_GastosDepto_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_GastosDepto.DoubleClick
        Dim cuenta As Integer
        Dim fila As Integer
        fila = Dgv_GastosDepto.CurrentRow.Index
        cuenta = Dgv_GastosDepto.Rows(fila).Cells("noCta2").Value
        Dgv_DesplegadoAcum.ColumnHeadersVisible = True
        Dgv_DesplegadoAcum.Visible = True
        Btn_Regresar.Enabled = True
        Lbl_TPlan.Visible = False
        Lbl_TReal.Visible = False
        Lbl_TDif.Visible = False
        Lbl_TPorcentaje.Visible = False
        Lbl_TAPLan.Visible = True
        Lbl_TAReal.Visible = True
        Lbl_TADif.Visible = True
        Lbl_TAPorcentaje.Visible = True
        RecuperarDesplegadoAcumulado(cuenta)
    End Sub
    Private Sub Dgv_DesplegadoAcum_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_DesplegadoAcum.DoubleClick
        Dim cuenta As String
        Dim fila As Integer
        fila = Dgv_DesplegadoAcum.CurrentRow.Index
        cuenta = Dgv_DesplegadoAcum.Rows(fila).Cells("noCta3").Value
        RecuperarDetallesGastos(cuenta)
    End Sub
    Private Sub Btn_Regresar_Click(sender As Object, e As EventArgs) Handles Btn_Regresar.Click
        Dgv_GastosGlobal.DataSource = Nothing
        Dgv_GastosGlobal.Rows.Clear()
        Dgv_GastosGlobal.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.DataSource = Nothing
        Dgv_DesplegadoAcum.Rows.Clear()
        Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        Dgv_DesplegadoAcum.Visible = False
        Btn_Regresar.Enabled = False
        Lbl_TPlan.Visible = True
        Lbl_TReal.Visible = True
        Lbl_TDif.Visible = True
        Lbl_TPorcentaje.Visible = True
        Lbl_TAPLan.Visible = False
        Lbl_TAReal.Visible = False
        Lbl_TADif.Visible = False
        Lbl_TAPorcentaje.Visible = False
        Lbl_CantidadTot.Text = 0
        Lbl_CostoUnitTotal.Text = 0
        Lbl_CotoTotal.Text = 0
    End Sub
#End Region
#Region "Rellena Cmb"
    Private Sub RellenaCmbDepartamento()
        Dim lstDep As New LEmpleado()
        Dim NGas As New NGastos()

        If Rdb_Español.Checked = True Then
            Me.idioma = 1
        ElseIf Rdb_Japones.Checked = True Then
            Me.idioma = 2
        End If
        lstDep = NGas.RecuperarSegNegocio(Me.cadenaConex, Me.idioma)

        For n = 1 To 2
            Dim dep As New Empleado()
            If n = 1 And Me.idioma = 1 Then dep.Departamento = "GENERAL"
            If n = 1 And Me.idioma = 2 Then dep.Departamento = "総勘定科目"
            If n = 2 Then dep.Departamento = ""
            lstDep.Add(dep)
        Next
        With Cmb_Depto
            .DataSource = lstDep
            .ValueMember = "IdDepartamento"
            .DisplayMember = "Departamento"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaCmbMeses()
        If Me.idioma = 1 Then
            With Cmb_Meses
                .Items.Clear()
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
        ElseIf Me.idioma = 2 Then
            With Cmb_Meses
                .Items.Clear()
                .Items.Add("1月")
                .Items.Add("2月")
                .Items.Add("3月")
                .Items.Add("4月")
                .Items.Add("5月")
                .Items.Add("6月")
                .Items.Add("7月")
                .Items.Add("8月")
                .Items.Add("9月")
                .Items.Add("10月")
                .Items.Add("11月")
                .Items.Add("12月")
            End With
        End If
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
        Dim tCant As Double = 0, tCosUnit As Double = 0, tCos As Double = 0
        Dgv_GastosGlobal.DataSource = Nothing
        Dgv_GastosGlobal.Rows.Clear()

        For Each item In lstGast
            Dgv_GastosGlobal.Rows.Add()
            Dgv_GastosGlobal.Columns("cosCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_GastosGlobal.Columns("cantCompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_GastosGlobal.Columns("segNeg").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_GastosGlobal.Columns("costoUnit").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_GastosGlobal.Rows(fila)
                .Cells("noCta").Value = item.Cuenta
                .Cells("cta").Value = item.NombreCuenta
                .Cells("idCompra").Value = item.IdCompra
                .Cells("cantCompra").Value = Format(item.CantCompra, "#,###,##0.00")
                tCant = tCant + .Cells("cantCompra").Value
                .Cells("costoUnit").Value = Format((item.Compras / item.CantCompra), "$ #,###,##0.00")
                If .Cells("costoUnit").Value = "NaN" Then .Cells("costoUnit").Value = Format(0, "$ #,###,##0.00")
                tCosUnit = tCosUnit + .Cells("costoUnit").Value
                .Cells("cosCompra").Value = Format(item.Compras, "$ #,###,##0.00")
                tCos = tCos + .Cells("cosCompra").Value
                '.Cells("po").Value = Format(item.OC, "$ #,###,##0.00")
                '.Cells("comp").Value = Format(item.Compras, "$ #,###,##0.00")
                .Cells("segNeg").Value = item.SegmNegocio
            End With
            fila += 1
        Next
        Lbl_CantidadTot.Text = Format(tCant, "#,###,##0.00")
        Lbl_CostoUnitTotal.Text = Format(tCosUnit, "$ #,###,##0.00")
        Lbl_CotoTotal.Text = Format(tCos, "$ #,###,##0.00")
    End Sub
    Private Sub RellenarDgvGastosDepto(ByVal lstGast As LGastos)
        Dim fila As Integer = 0
        Dim tPLan As Double = 0, tReal As Double = 0 ', tDif As Double = 0
        Dgv_GastosDepto.DataSource = Nothing
        Dgv_GastosDepto.Rows.Clear()

        For Each item In lstGast
            Dgv_GastosDepto.Rows.Add()
            Dgv_GastosDepto.Columns("plan2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_GastosDepto.Columns("real2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_GastosDepto.Columns("dif2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_GastosDepto.Columns("porcentaje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_GastosDepto.Rows(fila)
                .Cells("noCta2").Value = item.Cuenta
                .Cells("cta2").Value = item.NombreCuenta
                .Cells("plan2").Value = Format(item.PlanMonto, "$ #,###,##0.00")
                If .Cells("plan2").Value = 0 Then .Cells("plan2").Style.ForeColor = Color.Red
                tPLan = tPLan + .Cells("plan2").Value
                .Cells("real2").Value = Format(item.Actual, "$ #,###,##0.00")
                If .Cells("real2").Value = 0 Then .Cells("real2").Style.ForeColor = Color.Red
                tReal = tReal + .Cells("real2").Value
                .Cells("dif2").Value = Format(item.Actual - item.PlanMonto, "$ #,###,##0.00")
                If .Cells("dif2").Value > 0 Then .Cells("dif2").Style.ForeColor = Color.Red
                'tDif = tDif + .Cells("dif2").Value
                .Cells("porcentaje").Value = Format((item.Actual * 100) / item.PlanMonto, "#,###,##0.00")
                If .Cells("porcentaje").Value > 100 Then .Cells("porcentaje").Style.ForeColor = Color.Red
                Format(.Cells("porcentaje").Value, "#,###,##0.00")
                .Cells("porcentaje").Value = .Cells("porcentaje").Value & "%"
            End With
            fila += 1
        Next
        Lbl_TPlan.Text = Format(tPLan, "$ #,###,##0.00")
        Lbl_TReal.Text = Format(tReal, "$ #,###,##0.00")
        Lbl_TDif.Text = Format(tReal - tPLan, "$ #,###,##0.00")
        If Lbl_TDif.Text > 0 Then Lbl_TDif.ForeColor = Color.Red
        Lbl_TPorcentaje.Text = Format((tReal * 100) / tPLan, "#,###,##0.00")
        If Lbl_TPorcentaje.Text > 100 Then Lbl_TPorcentaje.ForeColor = Color.Red
        Format(Lbl_TPorcentaje.Text, "#,###,##0.00")
        Lbl_TPorcentaje.Text = Lbl_TPorcentaje.Text & "%"
    End Sub
    Private Sub RellenarDgvDesplegadoAcum(ByVal lstGast As LGastos)
        Dim fila As Integer = 0
        Dim tPLan As Double = 0, tReal As Double = 0
        Dgv_DesplegadoAcum.DataSource = Nothing
        Dgv_DesplegadoAcum.Rows.Clear()

        For Each item In lstGast
            Dgv_DesplegadoAcum.Rows.Add()
            Dgv_DesplegadoAcum.Columns("plan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_DesplegadoAcum.Columns("actual").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_DesplegadoAcum.Columns("dif").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_DesplegadoAcum.Columns("porcentaje2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_DesplegadoAcum.Rows(fila)
                .Cells("noCta3").Value = item.Cuenta
                .Cells("cta3").Value = item.NombreCuenta
                .Cells("plan").Value = Format(item.PlanMonto, "$ #,###,##0.00")
                If .Cells("plan").Value = 0 Then .Cells("plan").Style.ForeColor = Color.Red
                tPLan = tPLan + .Cells("plan").Value
                .Cells("actual").Value = Format(item.Actual, "$ #,###,##0.00")
                If .Cells("actual").Value = 0 Then .Cells("actual").Style.ForeColor = Color.Red
                tReal = tReal + .Cells("actual").Value
                .Cells("dif").Value = Format(item.Actual - item.PlanMonto, "$ #,###,##0.00")
                If .Cells("dif").Value > 0 Then .Cells("dif").Style.ForeColor = Color.Red
                .Cells("porcentaje2").Value = Format((item.Actual * 100) / item.PlanMonto, "#,###,##0.00")
                If .Cells("porcentaje2").Value > 100 Then .Cells("porcentaje2").Style.ForeColor = Color.Red
                Format(.Cells("porcentaje2").Value, "#,###,##0.00")
                .Cells("porcentaje2").Value = .Cells("porcentaje2").Value & "%"
            End With
            fila += 1
        Next
        Lbl_TAPLan.Text = Format(tPLan, "$ #,###,##0.00")
        Lbl_TAReal.Text = Format(tReal, "$ #,###,##0.00")
        Lbl_TADif.Text = Format(tReal - tPLan, "$ #,###,##0.00")
        If Lbl_TADif.Text > 0 Then
            Lbl_TADif.ForeColor = Color.Red
        Else
            Lbl_TADif.ForeColor = Color.Black
        End If
        Lbl_TAPorcentaje.Text = Format((tReal * 100) / tPLan, "#,###,##0.00")
        If Lbl_TAPorcentaje.Text > 100 Then
            Lbl_TAPorcentaje.ForeColor = Color.Red
        Else
            Lbl_TAPorcentaje.ForeColor = Color.Black
        End If
        Format(Lbl_TAPorcentaje.Text, "#,###,##0.00")
        Lbl_TAPorcentaje.Text = Lbl_TAPorcentaje.Text & "%"
    End Sub
    Private Sub RellenaPlanVentas(ByVal lstGastos As LGastos)
        Dim smaM As Double = 0
        Dim smaC As Double = 0
        For Each item In lstGastos
            Select Case item.SegmNegocio
                Case 4
                    Lbl_MontoFF1.Text = Format(item.PlanMonto * 20, "$ #,###,##0.00")
                    Lbl_CantFF1.Text = Format(item.Plan, "#,###,##0.00")
                Case 6
                    Lbl_MontoMF1.Text = Format(item.PlanMonto * 20, "$ #,###,##0.00")
                    Lbl_CantMF1.Text = Format(item.Plan, "#,###,##0.00")
                Case 11
                    Lbl_MontoFF2.Text = Format(item.PlanMonto * 20, "$ #,###,##0.00")
                    Lbl_CantFF2.Text = Format(item.Plan, "#,###,##0.00")
                Case 12
                    Lbl_MontoMF2.Text = Format(item.PlanMonto * 20, "$ #,###,##0.00")
                    Lbl_CantMF2.Text = Format(item.Plan, "#,###,##0.00")
            End Select
            smaM += item.PlanMonto
            smaC += item.Plan
            Lbl_MontoActualReal.Text = Format(item.ActualMonto, "$ #,###,##0.00")
            Lbl_CantActualReal.Text = Format(item.Actual, "#,###,##0.00")
        Next
        Lbl_MontoPlan.Text = Format(smaM * 20, "$ #,###,##0.00")
        Lbl_CantPlan.Text = Format(smaC, "#,###,##")
        Lbl_MontoDif.Text = Format((Lbl_MontoActualReal.Text - Lbl_MontoPlan.Text), "$ #,###,##0.00")
        If Lbl_MontoDif.Text < 0 Then
            Lbl_MontoDif.ForeColor = Color.Red
        Else
            Lbl_MontoDif.ForeColor = Color.Black
        End If
        Lbl_CantDif.Text = Format((Lbl_CantActualReal.Text - Lbl_CantPlan.Text), "#,###,##")
        If Lbl_CantDif.Text < 0 Then
            Lbl_CantDif.ForeColor = Color.Red
        Else
            Lbl_CantDif.ForeColor = Color.Black
        End If
    End Sub
#End Region
#Region "Recuperar"
    Private Sub RecuperarPlanesGlobal()
        Dim NGast As New NGastos(), lstGast As New LGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text
        Dim fi As Date, ff As Date, d As Date
        If mes <> 0 Then
            d = "15" & "/" & mes & "/" & año
            fi = Format(DateSerial(Year(d), Month(d), 1), "dd/MM/yyyy")
            ff = Format(DateSerial(Year(d), Month(d) + 1, 0), "dd/MM/yyyy")

            lstGast = NGast.RecuperarPlanGastosAgrupado(Me.cadenaConex, mes, año, fi, ff, Me.idioma)
            RellenarDgvGastosDepto(lstGast)
            'Me.c = 1
        End If
    End Sub
    Private Sub RecuperarDesplegadoAcumulado(ByVal cuenta As Integer)
        Dim NGast As New NGastos(), lstGast As New LGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text, sn As Integer
        Dim fi As Date, ff As Date, d As Date

        If mes <> 0 Then
            d = "15" & "/" & mes & "/" & año
            fi = Format(DateSerial(Year(d), Month(d), 1), "dd/MM/yyyy")
            ff = Format(DateSerial(Year(d), Month(d) + 1, 0), "dd/MM/yyyy")

            If Cmb_Depto.Text = "GENERAL" Or Cmb_Depto.Text = "総勘定科目" Then
                sn = 100
            Else
                sn = Cmb_Depto.SelectedValue
            End If

            If sn < 100 Then
                lstGast = NGast.RecuperarPlanGastosDpto(Me.cadenaConex, mes, año, fi, ff, sn, cuenta, Me.idioma)
            ElseIf sn = 100 Then
                lstGast = NGast.RecuperarPlanGastos(Me.cadenaConex, mes, año, fi, ff, cuenta, Me.idioma)
            End If
            RellenarDgvDesplegadoAcum(lstGast)
            'Me.c = 1
        End If
    End Sub
    Private Sub RecuperarPlanesSegNeg()
        Dim NGast As New NGastos(), lstGast As New LGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text, sn As Integer
        Dim fi As Date, ff As Date, d As Date

        If mes <> 0 Then
            d = "15" & "/" & mes & "/" & año
            fi = Format(DateSerial(Year(d), Month(d), 1), "dd/MM/yyyy")
            ff = Format(DateSerial(Year(d), Month(d) + 1, 0), "dd/MM/yyyy")
            If Cmb_Depto.Text = "GENERAL" Or Cmb_Depto.Text = "総勘定科目" Then
                sn = 100
            Else
                sn = Cmb_Depto.SelectedValue
            End If

            If sn < 100 Then
                lstGast = NGast.RecuperarPlanGastosAgrupado(Me.cadenaConex, mes, año, fi, ff, Me.idioma, sn)
            ElseIf sn = 100 Then
                lstGast = NGast.RecuperarPlanGastosAgrupado(Me.cadenaConex, mes, año, fi, ff, Me.idioma)
            End If
            RellenarDgvGastosDepto(lstGast)
            Me.c = 1
        End If
    End Sub
    Private Sub RecuperarPlanesTVentas()
        Dim NGast As New NGastos(), lstGast As New LGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text
        Dim fi As Date, ff As Date, d As Date

        If mes <> 0 Then
            d = "15" & "/" & mes & "/" & año
            fi = Format(DateSerial(Year(d), Month(d), 1), "dd/MM/yyyy")
            ff = Format(DateSerial(Year(d), Month(d) + 1, 0), "dd/MM/yyyy")

            lstGast = NGast.RecuperarPlanVentas(Me.cadenaConex, mes, año, fi, ff)
            RellenaPlanVentas(lstGast)
        End If
    End Sub
    Private Sub RecuperarDetallesGastos(ByVal cuenta As String)
        Dim NGast As New NGastos(), lstGast As New LGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text, sn As Integer
        Dim fi As Date, ff As Date, d As Date

        If mes <> 0 Then
            d = "15" & "/" & mes & "/" & año
            fi = Format(DateSerial(Year(d), Month(d), 1), "dd/MM/yyyy")
            ff = Format(DateSerial(Year(d), Month(d) + 1, 0), "dd/MM/yyyy")
            If Cmb_Depto.Text = "GENERAL" Or Cmb_Depto.Text = "総勘定科目" Then
                sn = 100
            Else
                sn = Cmb_Depto.SelectedValue
            End If

            If sn < 100 Then
                lstGast = NGast.RecuperarDetallesGastos(Me.cadenaConex, mes, año, fi, ff, cuenta, Me.idioma, sn)
            ElseIf sn = 100 Then
                lstGast = NGast.RecuperarDetallesGastos(Me.cadenaConex, mes, año, fi, ff, cuenta, Me.idioma)
            End If
            RellenarDgvGastosGral(lstGast)
            Dgv_GastosGlobal.ColumnHeadersVisible = True
        End If
    End Sub
#End Region
#Region "Otros procesos"
    Private Function MesLetraNumero(ByVal mes As String) As Integer
        If Me.idioma = 1 Then
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
        ElseIf Me.idioma = 2 Then
            Select Case mes
                Case "1月" : Return 1
                Case "2月" : Return 2
                Case "3月" : Return 3
                Case "4月" : Return 4
                Case "5月" : Return 5
                Case "6月" : Return 6
                Case "7月" : Return 7
                Case "8月" : Return 8
                Case "9月" : Return 9
                Case "10月" : Return 10
                Case "11月" : Return 11
                Case "12月" : Return 12
                Case Else : Return 0
            End Select
        Else
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
        End If
    End Function
    Private Sub Traducir()
        If Me.idioma = 1 Then
            Me.Text = "Gastos"
            Lbl_Mes.Text = "Mes"
            Lbl_Año.Text = "Año"
            Lbl_Depto.Text = "Departamento"
            Lbl_Ventas.Text = "VENTAS"
            Lbl_Monto.Text = "Monto"
            Lbl_Cant.Text = "Cantidad"
            Lbl_MF1.Text = "Maquinado F1"
            Lbl_FF1.Text = "Fundición F1"
            Lbl_MF2.Text = "Maquinado F2"
            Lbl_FF2.Text = "Fundición F2"
            Lbl_MP.Text = "Master"
            Lbl_PM.Text = "Plan"
            Lbl_Actual.Text = "Actual"
            Lbl_Dif.Text = "Diferencia"
            Dgv_GastosGlobal.Columns("noCta").HeaderText = "No. Cuenta"
            Dgv_GastosDepto.Columns("noCta2").HeaderText = "No. Cuenta"
            Dgv_GastosGlobal.Columns("cta").HeaderText = "Cuenta"
            Dgv_GastosDepto.Columns("cta2").HeaderText = "Cuenta"
            'Dgv_GastosGlobal.Columns("plan").HeaderText = "Plan"
            Dgv_GastosDepto.Columns("plan2").HeaderText = "Plan"
            'Dgv_GastosGlobal.Columns("actual").HeaderText = "Actual"
            Dgv_GastosDepto.Columns("actual2").HeaderText = "Actual"
            'Dgv_GastosGlobal.Columns("dif").HeaderText = "Diferencia"
            Dgv_GastosDepto.Columns("dif2").HeaderText = "Diferencia"
        ElseIf Me.idioma = 2 Then
            Me.Text = "費用報告書"
            Lbl_Mes.Text = "月"
            Lbl_Año.Text = "年"
            Lbl_Depto.Text = "部門"
            Lbl_Ventas.Text = "売上高"
            Lbl_Monto.Text = "金額"
            Lbl_Cant.Text = "数量"
            Lbl_MF1.Text = "第1加工課"
            Lbl_FF1.Text = "第1鋳造係"
            Lbl_MF2.Text = "第2加工課"
            Lbl_FF2.Text = "第2鋳造係"
            Lbl_MP.Text = "MP"
            Lbl_PM.Text = "予定"
            Lbl_Actual.Text = "実績"
            Lbl_Dif.Text = "差異"
            Dgv_GastosGlobal.Columns("noCta").HeaderText = "勘定科目コード"
            Dgv_GastosDepto.Columns("noCta2").HeaderText = "勘定科目コード"
            Dgv_GastosGlobal.Columns("cta").HeaderText = "勘定科目"
            Dgv_GastosDepto.Columns("cta2").HeaderText = "勘定科目"
            'Dgv_GastosGlobal.Columns("plan").HeaderText = "予定"
            Dgv_GastosDepto.Columns("plan2").HeaderText = "予定"
            'Dgv_GastosGlobal.Columns("actual").HeaderText = "実績"
            Dgv_GastosDepto.Columns("actual2").HeaderText = "実績"
            'Dgv_GastosGlobal.Columns("dif").HeaderText = "差異"
            Dgv_GastosDepto.Columns("dif2").HeaderText = "差異"
        End If
    End Sub
#End Region
End Class