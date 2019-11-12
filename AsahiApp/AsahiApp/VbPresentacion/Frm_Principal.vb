Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Clases
Imports Negocio
Imports CsPresentacion
Public Class Frm_Principal
#Region "Variables de clase"
    Dim cadenaConex As String
    Dim cadenaConesExp As String
    Dim conex As New conexion
    Dim cadConex As SqlConnection
    Dim emp As New Empleado
#End Region
    'Variable para generar reportes de prenómina
    Public Var As Int64

#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal cadConex As SqlConnection, ByVal cadenaConex As String, ByVal emp As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadConex = cadConex
        Me.cadenaConex = cadenaConex
        Me.cadenaConesExp = conex.cadenaConexExpress
        Me.emp = emp
    End Sub
#End Region
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.emp.TipoUsuario = 0 Then
            Dim lstPer As New LPermisos(), NEmp As New NEmpleado()
            BloquearPestañas()
            lstPer = NEmp.RecuperarPermisosUsuario(Me.cadenaConesExp, Me.emp)
            DesbloquearPestañas(lstPer)
            ''ElseIf Me.emp.TipoUsuario = 1 Then
        End If
    End Sub
#Region "Procesos"
    Private Sub BloquearPestañas()
        PreNominaToolStripMenuItem.Enabled = False
        PreNominaListadoToolStripMenuItem.Enabled = False
        PreNominaGlobalToolStripMenuItem.Enabled = False
        BonoMensualToolStripMenuItem.Enabled = False
        ChecadasToolStripMenuItem.Enabled = False
        ComidasToolStripMenuItem.Enabled = False
        ReportesToolStripMenuItem1.Enabled = False
        EmpleadosToolStripMenuItem.Enabled = False
        AltaToolStripMenuItem.Enabled = False
        BajaToolStripMenuItem.Enabled = False
        InformaciónToolStripMenuItem.Enabled = False
        CredencialesToolStripMenuItem.Enabled = False
        ContratoToolStripMenuItem.Enabled = False
        ListadosToolStripMenuItem.Enabled = False
        ActivosToolStripMenuItem.Enabled = False
        BajaEmpleadosToolStripMenuItem.Enabled = False
        BajaEmpleadosToolStripMenuItem1.Enabled = False
        PlanHorasExtraToolStripMenuItem.Enabled = False
        ReportesToolStripMenuItem.Enabled = False
        FiniquitoToolStripMenuItem.Enabled = False
        MejoraContinuaToolStripMenuItem.Enabled = False
        ReporteMejorasToolStripMenuItem.Enabled = False
        PlanTiempoExtraToolStripMenuItem.Enabled = False
        'ControlDeProducciónToolStripMenuItem.Enabled = False
        EvaluacionesToolStripMenuItem.Enabled = False
        MasterPlanToolStripMenuItem.Enabled = False
        PlanToolStripMenuItem.Enabled = False
        PermisosYAutorizacionesToolStripMenuItem.Enabled = False
        AusentismosGlobalToolStripMenuItem.Enabled = False

    End Sub
    Private Sub DesbloquearPestañas(ByVal lstPer As LPermisos)
        For Each item In lstPer
            Select Case item.NombreModulo
                Case "PreNominaToolStripMenuItem" : PreNominaToolStripMenuItem.Enabled = True
                Case "PreNominaListadoToolStripMenuItem" : PreNominaListadoToolStripMenuItem.Enabled = True
                Case "PreNominaGlobalToolStripMenuItem" : PreNominaGlobalToolStripMenuItem.Enabled = True
                Case "BonoMensualToolStripMenuItem" : BonoMensualToolStripMenuItem.Enabled = True
                Case "ChecadasToolStripMenuItem" : ChecadasToolStripMenuItem.Enabled = True
                Case "ComidasToolStripMenuItem" : ComidasToolStripMenuItem.Enabled = True
                Case "ReportesToolStripMenuItem1" : ReportesToolStripMenuItem1.Enabled = True
                Case "EmpleadosToolStripMenuItem" : EmpleadosToolStripMenuItem.Enabled = True
                Case "AltaToolStripMenuItem" : AltaToolStripMenuItem.Enabled = True
                Case "BajaToolStripMenuItem" : BajaToolStripMenuItem.Enabled = True
                Case "InformaciónToolStripMenuItem" : InformaciónToolStripMenuItem.Enabled = True
                Case "CredencialesToolStripMenuItem" : CredencialesToolStripMenuItem.Enabled = True
                Case "ContratoToolStripMenuItem" : ContratoToolStripMenuItem.Enabled = True
                Case "ListadosToolStripMenuItem" : ListadosToolStripMenuItem.Enabled = True
                Case "ActivosToolStripMenuItem" : ActivosToolStripMenuItem.Enabled = True
                Case "BajaEmpleadosToolStripMenuItem" : BajaEmpleadosToolStripMenuItem.Enabled = True
                Case "BajaEmpleadosToolStripMenuItem1" : BajaEmpleadosToolStripMenuItem1.Enabled = True
                Case "PlanHorasExtraToolStripMenuItem" : PlanHorasExtraToolStripMenuItem.Enabled = True
                Case "ReportesToolStripMenuItem" : ReportesToolStripMenuItem.Enabled = True
                Case "FiniquitoToolStripMenuItem" : FiniquitoToolStripMenuItem.Enabled = True
                Case "MejoraContinuaToolStripMenuItem" : MejoraContinuaToolStripMenuItem.Enabled = True
                Case "ReporteMejorasToolStripMenuItem" : ReporteMejorasToolStripMenuItem.Enabled = True
                Case "PlanTiempoExtraToolStripMenuItem" : PlanTiempoExtraToolStripMenuItem.Enabled = True
                Case "ControlDeProducciónToolStripMenuItem" : ControlDeProducciónToolStripMenuItem.Enabled = True
                Case "EvaluacionesToolStripMenuItem" : EvaluacionesToolStripMenuItem.Enabled = True
                Case "MasterPlanToolStripMenuItem" : MasterPlanToolStripMenuItem.Enabled = True
                Case "PlanToolStripMenuItem" : PlanToolStripMenuItem.Enabled = True
                Case "PermisosYAutorizacionesToolStripMenuItem" : PermisosYAutorizacionesToolStripMenuItem.Enabled = True
                Case "AusentismosGlobalToolStripMenuItem" : AusentismosGlobalToolStripMenuItem.Enabled = True
            End Select
        Next
    End Sub
#End Region
#Region "Botónes"
    Private Sub PreNominaListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreNominaListadoToolStripMenuItem.Click
        Dim lista As New Frm_ListaPrenomina(cadConex, cadenaConex)
        lista.Show()
    End Sub
    Private Sub ControlDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeProducciónToolStripMenuItem.Click
    End Sub
    Private Sub Men_Principal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Men_Principal.ItemClicked

    End Sub
    Private Sub BajaEmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BajaEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ACercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACercaDeToolStripMenuItem.Click
        Dim Soporte As New Frm_Soporte()
        Soporte.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
        Dim Login As New Frm_Login()
        Login.Show()
    End Sub
    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Close()
    End Sub
    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        Dim Acerca As New Frm_Acerca()
        Acerca.Show()
    End Sub
    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click
        Dim Detalle As New Frm_Modificaciones()
        Detalle.Show()
    End Sub
    Private Sub FiniquitoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        'Módulo de bajas de empleados
        Dim Baja As New Frm_bajas()
        Baja.Show()
    End Sub
    Private Sub EvaluacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluacionesToolStripMenuItem.Click
        Dim Evaluaciones As New Frm_Evaluacion()
        Evaluaciones.Show()
    End Sub
    Private Sub MejoraContinuaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MejoraContinuaToolStripMenuItem.Click
        'Módulo de reportes de Mejoras Continuas
        Dim Mejora As New Frm_Mejora_Param()
        Mejora.Show()
    End Sub
    Private Sub PreNominaGlobalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreNominaGlobalToolStripMenuItem.Click
        Dim globPren As New Frm_GlobalPrenomina(cadConex, cadenaConex)
        globPren.Show()
    End Sub
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        'Módulo de alta de empleados
        Dim Alta As New Frm_Altas()
        Alta.Show()
    End Sub
    Private Sub CredencialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CredencialesToolStripMenuItem.Click
    End Sub
    Private Sub BonoMensualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonoMensualToolStripMenuItem.Click
        Dim bono As New Frm_BonoMensual()
        bono.Show()
    End Sub
    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Ejecuta todos los reportes de pre nomina
        Dim Retardos As New Frm_Parametros_rep_prenomina()
        Var = 0
        Retardos.lbl_var.Text = Var
        Retardos.Show()
    End Sub
    'Private Sub DescansoLaboradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescansoLaboradoToolStripMenuItem.Click
    '    'Ejecuta reporte de Descanso Laborado de RH
    '    Dim Descanso As New Frm_Parametros_rep_prenomina()
    '    Var = 1
    '    Descanso.lbl_var.Text = Var
    '    Descanso.ShowDialog()
    'End Sub
    'Private Sub RetardosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetardosToolStripMenuItem.Click
    '    'Ejecuta reporte de Retardos de RH
    '    Dim Retardos As New Frm_Parametros_rep_prenomina()
    '    Var = 2
    '    Retardos.lbl_var.Text = Var
    '    Retardos.ShowDialog()
    'End Sub
    Private Sub PlanHorasExtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanHorasExtraToolStripMenuItem.Click
        Dim hrsEx As New Frm_PlanHorasExtra()
        hrsEx.Show()
    End Sub
    Private Sub MensualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MensualToolStripMenuItem1.Click
        Dim rph As New Frm_ReportesPlanHorasExtra()
        rph.Show()
    End Sub

    Private Sub PermisosDeSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub TodosToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
    End Sub
    Private Sub ReporteMejorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteMejorasToolStripMenuItem.Click
    End Sub
    Private Sub EspañolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspañolToolStripMenuItem.Click
        Dim Mej As New Frm_Reporte_Anual_Mejoras()
        Mej.variable = 0
        Mej.Show()
    End Sub
    Private Sub JaponésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JaponésToolStripMenuItem.Click
        Dim Mej As New Frm_Reporte_Anual_Mejoras()
        Mej.variable = 1
        Mej.Show()
    End Sub

    Private Sub ContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratoToolStripMenuItem.Click
        Dim Con As New Contrato_Clave()
        Con.Show()
    End Sub
    Private Sub DescansoLaboradoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescansoLaboradoToolStripMenuItem1.Click
        'Ejecuta reporte de Descanso Laborado de RH
        Dim Descanso As New Frm_Parametros_rep_prenomina()
        Var = 1
        Descanso.lbl_var.Text = Var
        Descanso.Show()
    End Sub

    Private Sub PermisoDeSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisoDeSalidaToolStripMenuItem.Click
        'Ejecuta reporte de Permisos de salida RH
        Dim Retardos As New Frm_Parametros_rep_prenomina()
        Var = 3
        Retardos.lbl_var.Text = Var
        Retardos.Show()
    End Sub

    Private Sub RetardosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RetardosToolStripMenuItem1.Click
        'Ejecuta reporte de Retardos de RH
        Dim Retardos As New Frm_Parametros_rep_prenomina()
        Var = 2
        Retardos.lbl_var.Text = Var
        Retardos.Show()
    End Sub

    Private Sub AusentismosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AusentismosToolStripMenuItem1.Click
        'Ejecuta reporte de Ausentismos de RH
        Dim Aus As New Frm_Parametros_rep_prenomina()
        Var = 4
        Aus.lbl_var.Text = Var
        Aus.Show()

    End Sub

    Private Sub IncapacidadesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncapacidadesToolStripMenuItem1.Click
        'Ejecuta reporte de Incapacidades de RH
        Dim Retardos As New Frm_Parametros_rep_prenomina()
        Var = 5
        Retardos.lbl_var.Text = Var
        Retardos.Show()

    End Sub

    Private Sub VacacionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VacacionesToolStripMenuItem1.Click
        'Ejecuta reporte de Vacaciones de RH
        Dim Vac As New Frm_Parametros_rep_prenomina()
        Var = 6
        Vac.lbl_var.Text = Var
        Vac.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanToolStripMenuItem.Click
        'MsgBox("Ahí la llevamos no apureis para septiembre queda bro")
        Dim mp As New Frm_Gastos()
        mp.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        'Módulo de creación de Credenciales
        Dim C As New Frm_Rep_Cred()
        C.Show()
    End Sub

    Private Sub VisitantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitantesToolStripMenuItem.Click
        'Módulo creacion de credenciales visitantes
        Dim C As New Credencial_visitantes_param()
        C.Show()
    End Sub

    Private Sub PlanDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanDePersonalToolStripMenuItem.Click
        Frm_cargaplanpersonal.Show()
    End Sub

    Private Sub HisToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RotaciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub FiniquitoToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub FiniquitoToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles FiniquitoToolStripMenuItem.Click
        'Módulo de reportes de finiquito
        Dim Finiquito As New Frm_Finiquito()
        Finiquito.Show()
    End Sub

    Private Sub AltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem.Click
        ''Listado de activos AAM
        Dim Activos As New Frm_Listado_Activos()
        Activos.Show()
    End Sub

    Private Sub AltasDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaEmpleadosToolStripMenuItem.Click
        'Modulo de listado de altas de Empleados
        Dim Altas As New Frm_Listado_Altas()
        Altas.Show()
    End Sub

    Private Sub BajasDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaEmpleadosToolStripMenuItem1.Click
        'Modulo de listado de bajas
        Dim Bajas As New Frm_Listado_Bajas()
        Bajas.Show()
    End Sub

    Private Sub HistóricoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoToolStripMenuItem.Click
        'Histórico de empleados
        Dim H As New Frm_Historico()
        H.Show()
    End Sub

    Private Sub RotaciónToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RotaciónToolStripMenuItem.Click
        'Módulo  de rotación
        Dim H As New Frm_Rotacion()
        H.Show()
    End Sub

    Private Sub PermisosYAutorizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosYAutorizacionesToolStripMenuItem.Click
        'Permisos y autorizaciones'
        Dim pa As New Permisos_Autorizaciones()
        pa.Show()
    End Sub

    Private Sub AusentismosGlobalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusentismosGlobalToolStripMenuItem.Click
        'Ausentismo global
        Dim ag As New Ausentismo_Global()
        ag.Show()
    End Sub

    Private Sub CapturaOEEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaOEEToolStripMenuItem.Click
        CapturaOEE.Show()
    End Sub

    Private Sub PlanDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanDeGastosToolStripMenuItem.Click
        Dim capGastos As New Frm_PlanGastos(Me.emp)
        capGastos.Show()
    End Sub
#End Region
End Class