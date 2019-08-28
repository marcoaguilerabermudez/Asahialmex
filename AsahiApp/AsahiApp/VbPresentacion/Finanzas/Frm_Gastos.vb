Imports System.Data.SqlClient
Imports Clases
Imports Negocio

Public Class Frm_Gastos
#Region "Variables de clase"
    Dim cadenaConex As String
    Dim cadConex As String
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
    End Sub
    Private Sub Cmb_Meses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Meses.SelectionChangeCommitted
        Cmb_Años.Enabled = True
    End Sub
    Private Sub Cmb_Años_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Años.SelectionChangeCommitted
        Cmb_Depto.Enabled = True
    End Sub
    Private Sub Cmb_Depto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Depto.SelectionChangeCommitted
        If Cmb_Depto.SelectedValue <> "" Then
            Dgv_GastosDepto.ColumnHeadersVisible = True
        Else
            Dgv_GastosDepto.ColumnHeadersVisible = False
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
#Region "Otros procesos"

#End Region
End Class