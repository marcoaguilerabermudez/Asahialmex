Imports Clases
Imports Negocio
Public Class Frm_PlanGastos
#Region "Variables de Clase"
    Dim cadenaConex As String, cadConex As String
    Dim empleado As New Empleado
    Dim c As Integer = 0
    Dim cta As Integer
    Dim idioma As Integer = 1
    Dim mes As Integer
    Dim año As Integer
    Dim segNeg As Integer
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal empleado As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.empleado = empleado
    End Sub
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_PlanGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion
        Dim NEmp As New NEmpleado()
        Me.cadenaConex = conex.cadenaConexExpress
        Me.cadConex = conex.conexion2008
        Me.empleado = NEmp.EmpleadosRecuperar(Me.cadConex, Me.empleado)
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        RellenaCmbAño()
        'RellenaCtaGral()

        Rdb_Español.Checked = True
        Me.mes = DateTime.Now.ToString("MM")
        Me.año = DateTime.Now.ToString("yyyy")
        Dim mesLetra As String = UCase(MonthName(Me.mes))
        If Me.empleado.IdDepartamento = 1 Or Me.empleado.TipoUsuario <> 1 Then Cmb_Depto.Enabled = False
        Cmb_Depto.SelectedValue = Me.empleado.IdDepartamento
        Cmb_Meses.SelectedItem = mesLetra
        Cmb_Años.Text = Me.año
        If Me.c = 0 Then RellenarDgvPrincipal()
        Me.c = 1
    End Sub
    Private Sub Rdb_Español_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Español.CheckedChanged
        'Dgv_GastosGlobal.DataSource = Nothing
        'Dgv_GastosGlobal.Rows.Clear()
        Dgv_Datos.DataSource = Nothing
        Dgv_Datos.Rows.Clear()
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        Dim letraMes As String = MesNumeroLetra(Me.mes)
        Cmb_Meses.Text = letraMes
        Cmb_Depto.SelectedValue = Me.empleado.IdDepartamento
        If Me.c = 1 Then RellenarDgvPrincipal()
        'RellenaCtaGral()
        'Traducir()
    End Sub
    Private Sub Rdb_Japones_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Japones.CheckedChanged
        'Dgv_GastosGlobal.DataSource = Nothing
        'Dgv_GastosGlobal.Rows.Clear()
        Dgv_Datos.DataSource = Nothing
        Dgv_Datos.Rows.Clear()
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        Dim letraMes As String = MesNumeroLetra(Me.mes)
        Cmb_Meses.Text = letraMes
        Cmb_Depto.SelectedValue = Me.empleado.IdDepartamento
        If Me.c = 1 Then RellenarDgvPrincipal()
        'RellenaCtaGral()
        'Traducir()
    End Sub
    Private Sub Dgv_Principal_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_Principal.DoubleClick
        If Not Cmb_Depto.Text = "" Then
            Dim ctaGrl As Integer, mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text
            Me.segNeg = Cmb_Depto.SelectedValue
            Dim fila As Integer
            Dim NGst As New NGastos()
            Dim lstGst As New LGastos()
            fila = Dgv_Principal.CurrentRow.Index
            ctaGrl = Dgv_Principal.Rows(fila).Cells("codigo").Value
            Me.cta = ctaGrl
            lstGst = NGst.RecuperarListaCtas(Me.cadenaConex, ctaGrl, mes, año, Me.segNeg, Me.idioma)
            RellenarDgvDetalles(lstGst)
        Else

        End If
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim lstGastos As New LGastos()
        Dim NGts As New NGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text, segNeg As Integer = Cmb_Depto.SelectedValue
        lstGastos = RellenaObjGastos(lstGastos)
        NGts.InsertarPlan(Me.cadenaConex, lstGastos)
        lstGastos = NGts.RecuperarListaCtas(Me.cadenaConex, Me.cta, mes, año, segNeg, Me.idioma)
        RellenarDgvDetalles(lstGastos)
        RellenarDgvPrincipal()
    End Sub
    Private Sub Dgv_Datos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Datos.CellEndEdit
        Dim fila As Integer
        Dim columna As String
        fila = Dgv_Datos.CurrentRow.Index
        columna = Dgv_Datos.Columns(e.ColumnIndex).Name
        If columna = "nuevoPlan" Then
            With Dgv_Datos.Rows(fila)
                Dim valor As Double = Convert.ToDouble(.Cells("nuevoPlan").Value)
                .Cells("nuevoPlan").Value = Format(valor, "$ #,###,##0.00")
                .Cells("modificados").Value = "M"
            End With
        End If
    End Sub
    Private Sub Cmb_Meses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Meses.SelectionChangeCommitted
        Dim mes = MesLetraNumero(Cmb_Meses.Text)
        If mes < Me.mes And Cmb_Años.Text <= Me.año Then
            Dgv_Datos.Columns("nuevoPlan").ReadOnly = True
        ElseIf mes >= Me.mes And Cmb_Años.Text >= Me.año Then
            Dgv_Datos.Columns("nuevoPlan").ReadOnly = False
        Else
            Dgv_Datos.Columns("nuevoPlan").ReadOnly = False
        End If
        Me.mes = mes
        Dgv_Datos.DataSource = Nothing
        Dgv_Datos.Rows.Clear()
        RellenarDgvPrincipal()
    End Sub
    Private Sub Cmb_Años_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Años.SelectionChangeCommitted
        Dim mes = MesLetraNumero(Cmb_Meses.Text)
        Dim año = Cmb_Años.Text
        If año < Me.año Then
            Dgv_Datos.Columns("nuevoPlan").ReadOnly = True
        ElseIf año = DateTime.Now.ToString("yyyy") And mes < Me.mes Then
            Dgv_Datos.Columns("nuevoPlan").ReadOnly = True
        ElseIf mes >= Me.mes And año >= Me.año Then
            Dgv_Datos.Columns("nuevoPlan").ReadOnly = False
        Else
            Dgv_Datos.Columns("nuevoPlan").ReadOnly = False
        End If
        Me.año = año
        Dgv_Datos.DataSource = Nothing
        Dgv_Datos.Rows.Clear()
        RellenarDgvPrincipal()
    End Sub
    Private Sub Cmb_Depto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Depto.SelectionChangeCommitted
        Me.segNeg = Cmb_Depto.SelectedValue
        RellenarDgvPrincipal()
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
        Dim hora As New Horarios()
        hora.Año = 2020
        lstaño.Add(hora)
        With Cmb_Años
            .DataSource = lstaño
            .ValueMember = "Año"
            .DisplayMember = "Año"
            .SelectedItem = Nothing
        End With
    End Sub
#End Region
#Region "RellenarDgvs"
    Private Sub RellenarDgvPrincipal()
        Dim fila As Integer = 0
        Dim lstGts As New LGastos()
        Dim NGts As New NGastos()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text), año As Integer = Cmb_Años.Text, segNeg As Integer = Cmb_Depto.SelectedValue
        lstGts = NGts.RecuperarCuentasGeneral(Me.cadenaConex, Me.idioma, mes, año, segNeg)

        Dgv_Principal.DataSource = Nothing
        Dgv_Principal.Rows.Clear()

        For Each item In lstGts
            Dgv_Principal.Rows.Add()
            Dgv_Principal.Columns("acum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_Principal.Rows(fila)
                .Cells("codigo").Value = item.Cuenta
                .Cells("Nombre").Value = item.NombreCuenta
                .Cells("acum").Value = Format(item.MontoPesos, "$ #,###,##0.00")
            End With
            fila += 1
        Next
    End Sub
    Private Sub RellenarDgvDetalles(ByVal lstGst As LGastos)
        Dim fila As Integer = 0
        Dim NGts As New NGastos()

        Dgv_Datos.DataSource = Nothing
        Dgv_Datos.Rows.Clear()

        For Each item In lstGst
            Dgv_Datos.Rows.Add()
            Dgv_Datos.Columns("planActual").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dgv_Datos.Columns("nuevoPlan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_Datos.Rows(fila)
                If item.Empresa = "AAMS" Then .DefaultCellStyle.BackColor = Color.PeachPuff
                .Cells("codigo2").Value = item.Cuenta
                .Cells("cuenta").Value = item.NombreCuenta
                .Cells("planActual").Value = Format(item.PlanMonto, "$ #,###,##0.00")
                .Cells("nuevoPlan").Value = Format(item.PlanMonto, "$ #,###,##0.00")
                .Cells("modificados").Value = item.Modif
            End With
            fila += 1
        Next
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
    Private Function MesNumeroLetra(ByVal mes As Integer) As String
        If Me.idioma = 1 Then
            Select Case mes
                Case 1 : Return "ENERO"
                Case 2 : Return "FEBRERO"
                Case 3 : Return "MARZO"
                Case 4 : Return "ABRIL"
                Case 5 : Return "MAYO"
                Case 6 : Return "JUNIO"
                Case 7 : Return "JULIO"
                Case 8 : Return "AGOSTO"
                Case 9 : Return "SEPTIEMBRE"
                Case 10 : Return "OCTUBRE"
                Case 11 : Return "NOVIEMBRE"
                Case 12 : Return "DICIEMBRE"
                Case Else : Return ""
            End Select
        Else
            Select Case mes
                Case 1 : Return "1月"
                Case 2 : Return "2月"
                Case 3 : Return "3月"
                Case 4 : Return "4月"
                Case 5 : Return "5月"
                Case 6 : Return "6月"
                Case 7 : Return "7月"
                Case 8 : Return "8月"
                Case 9 : Return "9月"
                Case 10 : Return "10月"
                Case 11 : Return "11月"
                Case 12 : Return "12月"
                Case Else : Return ""
            End Select
        End If
    End Function
    'Private Sub Traducir()
    '    If Me.idioma = 1 Then
    '        Me.Text = "Gastos"
    '        Lbl_Mes.Text = "Mes"
    '        Lbl_Año.Text = "Año"
    '        Lbl_Depto.Text = "Departamento"
    '        Lbl_Ventas.Text = "VENTAS"
    '        Lbl_Monto.Text = "Monto"
    '        Lbl_Cant.Text = "Cantidad"
    '        Lbl_MF1.Text = "Maquinado F1"
    '        Lbl_FF1.Text = "Fundición F1"
    '        Lbl_MF2.Text = "Maquinado F2"
    '        Lbl_FF2.Text = "Fundición F2"
    '        Lbl_MP.Text = "Master"
    '        Lbl_PM.Text = "Plan"
    '        Lbl_Actual.Text = "Actual"
    '        Lbl_Dif.Text = "Diferencia"
    '        Dgv_GastosGlobal.Columns("noCta").HeaderText = "No. Cuenta"
    '        Dgv_GastosDepto.Columns("noCta2").HeaderText = "No. Cuenta"
    '        Dgv_GastosGlobal.Columns("cta").HeaderText = "Cuenta"
    '        Dgv_GastosDepto.Columns("cta2").HeaderText = "Cuenta"
    '        'Dgv_GastosGlobal.Columns("plan").HeaderText = "Plan"
    '        Dgv_GastosDepto.Columns("plan2").HeaderText = "Plan"
    '        'Dgv_GastosGlobal.Columns("actual").HeaderText = "Actual"
    '        Dgv_GastosDepto.Columns("actual2").HeaderText = "Actual"
    '        'Dgv_GastosGlobal.Columns("dif").HeaderText = "Diferencia"
    '        Dgv_GastosDepto.Columns("dif2").HeaderText = "Diferencia"
    '    ElseIf Me.idioma = 2 Then
    '        Me.Text = "費用報告書"
    '        Lbl_Mes.Text = "月"
    '        Lbl_Año.Text = "年"
    '        Lbl_Depto.Text = "部門"
    '        Lbl_Ventas.Text = "売上高"
    '        Lbl_Monto.Text = "金額"
    '        Lbl_Cant.Text = "数量"
    '        Lbl_MF1.Text = "第1加工課"
    '        Lbl_FF1.Text = "第1鋳造係"
    '        Lbl_MF2.Text = "第2加工課"
    '        Lbl_FF2.Text = "第2鋳造係"
    '        Lbl_MP.Text = "MP"
    '        Lbl_PM.Text = "予定"
    '        Lbl_Actual.Text = "実績"
    '        Lbl_Dif.Text = "差異"
    '        Dgv_GastosGlobal.Columns("noCta").HeaderText = "勘定科目コード"
    '        Dgv_GastosDepto.Columns("noCta2").HeaderText = "勘定科目コード"
    '        Dgv_GastosGlobal.Columns("cta").HeaderText = "勘定科目"
    '        Dgv_GastosDepto.Columns("cta2").HeaderText = "勘定科目"
    '        'Dgv_GastosGlobal.Columns("plan").HeaderText = "予定"
    '        Dgv_GastosDepto.Columns("plan2").HeaderText = "予定"
    '        'Dgv_GastosGlobal.Columns("actual").HeaderText = "実績"
    '        Dgv_GastosDepto.Columns("actual2").HeaderText = "実績"
    '        'Dgv_GastosGlobal.Columns("dif").HeaderText = "差異"
    '        Dgv_GastosDepto.Columns("dif2").HeaderText = "差異"
    '    End If
    'End Sub
#End Region
    Private Function RellenaObjGastos(ByVal lstGastos As LGastos) As LGastos
        Dim fila As Integer
        Dim totalFilas As Integer = Dgv_Datos.Rows.Count()
        Dim mes As Integer = MesLetraNumero(Cmb_Meses.Text)
        For fila = 0 To totalFilas - 1
            With Dgv_Datos.Rows(fila)
                If .Cells("modificados").Value = "M" Then
                    Dim objGast As New Gastos()
                    objGast.IdSistema = 1
                    objGast.TipoMovimiento = 3
                    objGast.Cuenta = .Cells("codigo2").Value
                    objGast.SegmNegocio = Cmb_Depto.SelectedValue
                    objGast.CantCompra = 0
                    objGast.MontoDls = 0
                    objGast.MontoPesos = .Cells("nuevoPlan").Value
                    objGast.Moneda = "MX"
                    objGast.FechaInsert = Format(Date.Now, "dd/MM/yyyy")
                    objGast.Mes = mes
                    objGast.Año = Cmb_Años.Text
                    lstGastos.Add(objGast)
                End If
            End With
        Next
        Return lstGastos
    End Function
End Class