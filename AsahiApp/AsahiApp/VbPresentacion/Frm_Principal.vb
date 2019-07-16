﻿Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Clases
Imports CsPresentacion
Public Class Frm_Principal
#Region "Variables de clase"
    Dim cadenaConex As String
    Dim cadConex As SqlConnection
#End Region
    'Variable para generar reportes de prenómina
    Public Var As Int64

#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal cadConex As SqlConnection, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadConex = cadConex
        Me.cadenaConex = cadenaConex
    End Sub
#End Region
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#Region "Botónes"
    Private Sub PreNominaListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreNominaListadoToolStripMenuItem.Click
        Dim lista As New Frm_ListaPrenomina(cadConex, cadenaConex)
        lista.ShowDialog()
    End Sub
    Private Sub ControlDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeProducciónToolStripMenuItem.Click
    End Sub

    Private Sub Men_Principal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Men_Principal.ItemClicked

    End Sub

    Private Sub BajaEmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BajaEmpleadosToolStripMenuItem1.Click
        'Modulo de listado de bajas
        Dim Bajas As New Frm_Listado_Bajas()
        Bajas.ShowDialog()
        Bajas.Hide()

    End Sub

    Private Sub BajaEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaEmpleadosToolStripMenuItem.Click
        'Modulo de listado de altas de Empleados
        Dim Altas As New Frm_Listado_Altas()
        Altas.ShowDialog()
        Altas.Hide()

    End Sub

    Private Sub ACercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACercaDeToolStripMenuItem.Click
        Dim Soporte As New Frm_Soporte()
        Soporte.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click

    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        Dim Acerca As New Frm_Acerca()
        Acerca.ShowDialog()
    End Sub

    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click
        Dim Detalle As New Frm_Modificaciones()
        Detalle.ShowDialog()
    End Sub

    Private Sub FiniquitoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiniquitoToolStripMenuItem.Click
        'Módulo de reportes de finiquito
        Dim Finiquito As New Frm_Finiquito()
        Finiquito.ShowDialog()
        Finiquito.Hide()

    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        'Módulo de bajas de empleados
        Dim Baja As New Frm_bajas()
        Baja.ShowDialog()
        Baja.Hide()
    End Sub

    Private Sub EvaluacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluacionesToolStripMenuItem.Click
        Dim Evaluaciones As New Frm_Evaluacion()
        Evaluaciones.ShowDialog()
        Evaluaciones.Hide()
    End Sub

    Private Sub MejoraContinuaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MejoraContinuaToolStripMenuItem.Click
        'Módulo de reportes de Mejoras Continuas
        Dim Mejora As New Frm_Mejora_Param()
        Mejora.ShowDialog()
        Mejora.Hide()
    End Sub
    Private Sub PreNominaGlobalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreNominaGlobalToolStripMenuItem.Click
        Dim globPren As New Frm_GlobalPrenomina(cadConex, cadenaConex)
        globPren.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        'Módulo de alta de empleados
        Dim Alta As New Frm_Altas()
        Alta.ShowDialog()
        Alta.Hide()
    End Sub

    Private Sub CredencialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CredencialesToolStripMenuItem.Click
        'Módulo de creación de Credenciales
        Dim C As New Frm_Rep_Cred()
        C.ShowDialog()
        C.Hide()

    End Sub
    Private Sub BonoMensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonoMensualToolStripMenuItem.Click
        Dim bono As New Frm_BonoMensual()
        bono.ShowDialog()
    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem.Click
        'Ejecuta todos los reportes de pre nomina
        Dim Retardos As New Frm_Parametros_rep_prenomina()
        Var = 0
        Retardos.lbl_var.Text = Var
        Retardos.ShowDialog()
    End Sub

    Private Sub DescansoLaboradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescansoLaboradoToolStripMenuItem.Click
        'Ejecuta reporte de Descanso Laborado de RH
        Dim Descanso As New Frm_Parametros_rep_prenomina()
        Var = 1
        Descanso.lbl_var.Text = Var
        Descanso.ShowDialog()
    End Sub

    Private Sub RetardosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetardosToolStripMenuItem.Click
        'Ejecuta reporte de Retardos de RH
        Dim Retardos As New Frm_Parametros_rep_prenomina()
        Var = 2
        Retardos.lbl_var.Text = Var
        Retardos.ShowDialog()
    End Sub

    Private Sub PlanHorasExtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanHorasExtraToolStripMenuItem.Click
        Dim hrsEx As New Frm_PlanHorasExtra()
        hrsEx.Show()
    End Sub
    Private Sub PlanHorasExtraToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlanHorasExtraToolStripMenuItem1.Click
        Dim rph As New Frm_ReportesPlanHorasExtra()
        rph.ShowDialog()
    End Sub
#End Region
End Class

