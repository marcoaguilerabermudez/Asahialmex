Imports Clases
Imports Negocio
Public Class Frm_PlanGastos
#Region "Variables de Clase"
    Dim cadenaConex As String, cadConex As String
    Dim c As Integer = 0
    Dim idioma As Integer = 1
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_PlanGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion
        Me.cadenaConex = conex.cadenaConexExpress
        Me.cadConex = conex.conexion2008
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        RellenaCmbAño()
        RellenaCtaGral()

        Rdb_Español.Checked = True
        Dim mes As Double = DateTime.Now.ToString("MM")
        Dim año As Double = DateTime.Now.ToString("yyyy")
        Dim mesLetra As String = UCase(MonthName(mes))
        Cmb_Meses.SelectedItem = mesLetra
        Cmb_Años.Text = año
    End Sub
    Private Sub Rdb_Español_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Español.CheckedChanged
        'Dgv_GastosGlobal.DataSource = Nothing
        'Dgv_GastosGlobal.Rows.Clear()
        'Dgv_GastosGlobal.ColumnHeadersVisible = False
        'Dgv_DesplegadoAcum.DataSource = Nothing
        'Dgv_DesplegadoAcum.Rows.Clear()
        'Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        RellenaCtaGral()
        'Traducir()
    End Sub
    Private Sub Rdb_Japones_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Japones.CheckedChanged
        'Dgv_GastosGlobal.DataSource = Nothing
        'Dgv_GastosGlobal.Rows.Clear()
        'Dgv_GastosGlobal.ColumnHeadersVisible = False
        'Dgv_DesplegadoAcum.DataSource = Nothing
        'Dgv_DesplegadoAcum.Rows.Clear()
        'Dgv_DesplegadoAcum.ColumnHeadersVisible = False
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        RellenaCtaGral()
        'Traducir()
    End Sub
    Private Sub Cmb_CuentasGenerales_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_CuentasGenerales.SelectionChangeCommitted
        If Not Cmb_Depto.Text = "" Then
            Dim ctaGrl As Integer
            Dim NGst As New NGastos()
            Dim lstGst As New LGastos()
            ctaGrl = Cmb_CuentasGenerales.SelectedValue
            lstGst = NGst.RecuperarListaCtas(Me.cadenaConex, ctaGrl)
            RellenarDgvPrincipal(lstGst)
        Else

        End If
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
        With Cmb_Años
            .DataSource = lstaño
            .ValueMember = "Año"
            .DisplayMember = "Año"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaCtaGral()
        Dim lstGts As New LGastos()
        Dim NGts As New NGastos()
        lstGts = NGts.RecuperarCuentasGeneral(Me.cadenaConex, Me.idioma)
        With Cmb_CuentasGenerales
            .DataSource = lstGts
            .ValueMember = "Cuenta"
            .DisplayMember = "NombreCuenta"
            .SelectedItem = Nothing
        End With
    End Sub
#End Region
#Region "RellenarDgvs"
    Private Sub RellenarDgvPrincipal(ByVal lstGst As LGastos)
        Dim fila As Integer = 0
        Dgv_Principal.DataSource = Nothing
        Dgv_Principal.Rows.Clear()

        For Each item In lstGst
            Dgv_Principal.Rows.Add()
            With Dgv_Principal.Rows(fila)
                .Cells("codigo").Value = item.Cuenta
                .Cells("nombre").Value = item.NombreCuenta
            End With
            fila += 1
        Next
    End Sub
#End Region
End Class