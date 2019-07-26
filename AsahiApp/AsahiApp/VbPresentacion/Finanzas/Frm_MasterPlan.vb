Imports System.Data.SqlClient
Imports Clases
Imports Negocio

Public Class Frm_MasterPlan
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
    End Sub
    Private Sub Cmb_Meses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Meses.SelectionChangeCommitted
        Cmb_Años.Enabled = True
    End Sub
    Private Sub Cmb_Años_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Años.SelectionChangeCommitted
        Cmb_Depto.Enabled = True
    End Sub
    Private Sub Cmb_Depto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Depto.SelectionChangeCommitted

    End Sub
#End Region
#Region "Rellena Cmb"
    Private Sub RellenaCmbDepartamento()
        Dim lstDep As New LEmpleado()
        Dim NEmp As New NEmpleado()

        lstDep = NEmp.RecuperarDepartamentos(Me.cadConex, 1)
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
            .DisplayMember = "Año"
            .SelectedItem = Nothing
        End With
    End Sub
#End Region
#Region "Otros procesos"

#End Region
End Class