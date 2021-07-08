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
    Dim empleado As New Empleado
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal cadConex As SqlConnection, ByVal cadenaConex As String, ByVal cadenaConexExpress As String, ByVal emp As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadConex = cadConex
        Me.cadenaConex = cadenaConex
        Me.emp = emp
        Me.cadenaConesExp = cadenaConexExpress
    End Sub
#End Region
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Version.Text = My.Application.Info.Version.ToString
        Lbl_NombreUser.Text = emp.NombreCompleto
        If Me.emp.TipoUsuario = 0 Then
            Dim lstPer As New LPermisos(), NEmp As New NEmpleado()

            BloquearPestañas()

            lstPer = NEmp.RecuperarPermisosUsuario(Me.cadenaConesExp, Me.emp)
            DesbloquearPestañas(lstPer)
            ''ElseIf Me.emp.TipoUsuario = 1 Then
        End If

        If Me.emp.rh_permiso = 1 OrElse Me.emp.rh_permiso = 2 Then
            SolicitudToolStripMenuItem.Enabled = True
            ValidaciónToolStripMenuItem.Enabled = True
            SolicitudToolStripMenuItem1.Enabled = True
            '   EvaluacionesToolStripMenuItem1.Enabled = False

        ElseIf Me.emp.rh_permiso = 3 Then
            SolicitudToolStripMenuItem.Enabled = True
            ValidaciónToolStripMenuItem.Enabled = True
            SolicitudToolStripMenuItem1.Enabled = True
            ValidaciónRHToolStripMenuItem.Enabled = True
            ValidaciónRHToolStripMenuItem1.Enabled = True
            ActualizaRegistrosToolStripMenuItem.Enabled = True
            MedidasDisciplinariasToolStripMenuItem.Enabled = True
            ' EvaluacionesToolStripMenuItem1.Enabled = True

        ElseIf Me.emp.rh_evaluacion = 1 Then
            EvaluacionesToolStripMenuItem1.Enabled = True

        ElseIf Me.emp.rh_evaluacion = 0 Then
            EvaluacionesToolStripMenuItem1.Enabled = False

        End If

    End Sub
#Region "Procesos"
    Private Sub BloquearPestañas()
        PreNominaToolStripMenuItem.Enabled = False
        PreNominaListadoToolStripMenuItem.Enabled = False
        PreNominaGlobalToolStripMenuItem.Enabled = False
        BonoMensualToolStripMenuItem.Enabled = False
        ChecadasToolStripMenuItem.Enabled = False
        Kardex_comedorToolStripMenuItem.Enabled = False
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
        PlanDeGastosToolStripMenuItem.Enabled = False
        PermisosYAutorizacionesToolStripMenuItem.Enabled = False
        AusentismosGlobalToolStripMenuItem.Enabled = False
        AusentismoGeneralToolStripMenuItem.Enabled = False
        Incapacidades_RetardosToolStripMenuItem.Enabled = False
        ProvicionesToolStripMenuItem.Enabled = False
        HistorialToolStripMenuItem.Enabled = False
        ChecadasToolStripMenuItem.Enabled = False
        ModificaSueldoToolStripMenuItem.Enabled = False

    End Sub
    Private Sub DesbloquearPestañas(ByVal lstPer As LPermisos)
        For Each item In lstPer
            Select Case item.NombreModulo
                Case "PreNominaToolStripMenuItem" : PreNominaToolStripMenuItem.Enabled = True
                Case "PreNominaListadoToolStripMenuItem" : PreNominaListadoToolStripMenuItem.Enabled = True
                Case "PreNominaGlobalToolStripMenuItem" : PreNominaGlobalToolStripMenuItem.Enabled = True
                Case "BonoMensualToolStripMenuItem" : BonoMensualToolStripMenuItem.Enabled = True
                Case "ChecadasToolStripMenuItem" : ChecadasToolStripMenuItem.Enabled = True
                Case "ComidasToolStripMenuItem" : Kardex_comedorToolStripMenuItem.Enabled = True
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
                Case "PlanDeGastosToolStripMenuItem" : PlanDeGastosToolStripMenuItem.Enabled = True
                Case "PermisosYAutorizacionesToolStripMenuItem" : PermisosYAutorizacionesToolStripMenuItem.Enabled = True
                Case "AusentismosGlobalToolStripMenuItem" : AusentismosGlobalToolStripMenuItem.Enabled = True
                Case "AusentismoGeneralToolStripMenuItem" : AusentismoGeneralToolStripMenuItem.Enabled = True
                Case "Incapacidades_RetardosToolStripMenuItem" : Incapacidades_RetardosToolStripMenuItem.Enabled = True
                Case "ProvicionesToolStripMenuItem" : ProvicionesToolStripMenuItem.Enabled = True
                Case "HistorialToolStripMenuItem" : HistorialToolStripMenuItem.Enabled = True
                Case "ModificaSueldoToolStripMenuItem" : ModificaSueldoToolStripMenuItem.Enabled = True
            End Select
        Next
    End Sub
#End Region
#Region "Botónes"

    Private Sub PreNominaListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreNominaListadoToolStripMenuItem.Click
        Dim lista As New Frm_ListaPrenomina(cadConex, cadenaConex, cadenaConesExp, Me.emp.IdEmpleado)
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
        Dim globPren As New Frm_GlobalPrenomina(cadConex, cadenaConex, Me.emp)
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
        Dim Retardos As New Frm_Parametros_rep_prenomina(Me.emp)
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
        Dim Descanso As New Frm_Parametros_rep_prenomina(Me.emp)
        Var = 1
        Descanso.lbl_var.Text = Var
        Descanso.Show()
    End Sub

    Private Sub PermisoDeSalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisoDeSalidaToolStripMenuItem.Click
        'Ejecuta reporte de Permisos de salida RH
        Dim Retardos As New Frm_Parametros_rep_prenomina(Me.emp)
        Var = 3
        Retardos.lbl_var.Text = Var
        Retardos.Show()
    End Sub

    Private Sub RetardosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RetardosToolStripMenuItem1.Click
        'Ejecuta reporte de Retardos de RH
        Dim Retardos As New Frm_Parametros_rep_prenomina(Me.emp)
        Var = 2
        Retardos.lbl_var.Text = Var
        Retardos.Show()
    End Sub

    Private Sub AusentismosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AusentismosToolStripMenuItem1.Click
        'Ejecuta reporte de Ausentismos de RH
        Dim Aus As New Frm_Parametros_rep_prenomina(Me.emp)
        Var = 4
        Aus.lbl_var.Text = Var
        Aus.Show()

    End Sub

    Private Sub IncapacidadesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncapacidadesToolStripMenuItem1.Click
        'Ejecuta reporte de Incapacidades de RH
        Dim Retardos As New Frm_Parametros_rep_prenomina(Me.emp)
        Var = 5
        Retardos.lbl_var.Text = Var
        Retardos.Show()

    End Sub

    Private Sub VacacionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VacacionesToolStripMenuItem1.Click
        'Ejecuta reporte de Vacaciones de RH
        Dim Vac As New Frm_Parametros_rep_prenomina(Me.emp)
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
    Private Sub RotaciónToolStripMenuItem1_Click(sender As Object, e As EventArgs)
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

        Dim Aus As New frm_ausentismo_global()
        Aus.Show()
        'Dim p As New Frm_progres()
        'p.var = 2
        'p.Show()
    End Sub

    Private Sub CapturaOEEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaOEEToolStripMenuItem.Click
        CapturaOee2.Show()
        '' CapturaOEE.Show()
    End Sub

    Private Sub PlanDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanDeGastosToolStripMenuItem.Click
        Dim capGastos As New Frm_PlanGastos(Me.emp)
        capGastos.Show()
    End Sub

    Private Sub MostrarOEEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarOEEToolStripMenuItem.Click
        MuestradatosOEE.Show()
    End Sub

    Private Sub OEECompletoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OEECompletoToolStripMenuItem.Click

        If Me.emp.IdEmpleado = "260" Then

            MuestraOeeCompleto.Show()
        Else
            NuevoMuestraOEE.Show()
        End If

    End Sub

    Private Sub AusentismoGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusentismoGeneralToolStripMenuItem.Click
        Dim Ag As New Frm_Ausentismo_Fecha
        Ag.Show()
    End Sub

    Private Sub PolizasDeDiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PolizasDeDiarioToolStripMenuItem.Click
        Dim polD As New Frm_PolizasDiario(Me.emp, 1)
        polD.Show()
    End Sub

    Private Sub Incapacidades_RetardosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Incapacidades_RetardosToolStripMenuItem.Click
        Dim Ag As New Frm_Aussentismos_Retardos(Me.emp)
        Ag.Show()
    End Sub

    Private Sub ComidasToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ProvicionesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProvicionesToolStripMenuItem1.Click
        Dim FrmProv As New Frm_Provisiones()
        FrmProv.Show()
    End Sub
    Private Sub AutorizaContabilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorizaContabilidadToolStripMenuItem.Click
        Dim frmAut As New Frm_ValidarConta()
        frmAut.Show()
    End Sub
    Private Sub ConsultaXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaXMLToolStripMenuItem.Click
        Dim frm As New Frm_ConsultaXml(Me.emp)
        frm.Show()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        Dim frm As New Frm_Historico_personal()
        frm.Show()
    End Sub

    Private Sub EgresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosToolStripMenuItem.Click
        Dim frmPol As New Frm_PolizasDiario(Me.emp, 2)
        frmPol.Show()
    End Sub

    Private Sub Kardex_comedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Kardex_comedorToolStripMenuItem.Click
        Dim Co As New Frm_Comedor
        Co.Show()
    End Sub

    Private Sub IncidenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidenciasToolStripMenuItem.Click

    End Sub

    Private Sub SolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudToolStripMenuItem.Click
        Dim solte As New SolicitudTE(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso)
        solte.Show()
    End Sub

    Private Sub ValidaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidaciónToolStripMenuItem.Click

        Dim validath As New Validath(Me.emp.IdEmpleado, Me.emp.IdDepartamento)

        validath.Show()
    End Sub


    Private Sub SolicitudToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SolicitudToolStripMenuItem1.Click
        Dim FormatoSM As New FormatoSM(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso)
        FormatoSM.Show()
    End Sub

    Private Sub ValidaciónRHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValidaciónRHToolStripMenuItem.Click
        x.Show()
    End Sub

    Private Sub ValidaciónRHToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ValidaciónRHToolStripMenuItem1.Click
        ValidaRh.Show()
    End Sub

    Private Sub ChecadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChecadasToolStripMenuItem.Click
        Dim Che As New Frm_Registros
        Che.Show()
    End Sub

    Private Sub MontacargasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MontacargasToolStripMenuItem.Click
        Dim Cre As New Frm_Licencias(Me.emp)
        Cre.Show()
    End Sub

    Private Sub PolizasDiarioVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PolizasDiarioVentasToolStripMenuItem.Click
        Dim frmPol As New Frm_PolizasDiario(Me.emp, 3)
        frmPol.Show()
    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click
        '    Dim Principaleva As New EvaluacionesPrincipal(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso)
        '    Principaleva.Show()


        Dim EligeEva As New EligeEvaluación(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso, Me.emp.Id_puesto)
        EligeEva.Show()

    End Sub

    Private Sub BajasPorMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasPorMesToolStripMenuItem.Click
        Frm_Bajas_mes.Show()
    End Sub


    Private Sub Salir()
        Application.Exit()
    End Sub


    Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyClass.FormClosing
        Salir()
    End Sub
    Private Sub DpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DpToolStripMenuItem.Click
        Dim frmDp As New Frm_DescripcionPuestos()
        frmDp.Show()
    End Sub

    Private Sub KárdexDeEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KárdexDeEmpleadoToolStripMenuItem.Click
        KardexEmpleado.Show()
    End Sub

    'Private Sub TratamientoDeAnomalíasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoDeAnomalíasToolStripMenuItem.Click
    '    Dim Anomalia As New AnomaliaPrincipal(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso, Me.emp.Id_puesto)
    '    Anomalia.Show()
    'End Sub

    'Private Sub ActualizaRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizaRegistrosToolStripMenuItem.Click
    '    ActualizaTe.Show()
    'End Sub

    'Private Sub SalidaDeEquipoDeCómputoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeEquipoDeCómputoToolStripMenuItem.Click
    '    SalidaEquipoComputo.Show()
    'End Sub
    'Private Sub CuestionariosPreguntasYRespuestasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuestionariosPreguntasYRespuestasToolStripMenuItem.Click
    '    Dim crp As New Frm_CuestionariosPreguntas(Me.emp)
    '    crp.Show()
    'End Sub
    'Private Sub DiseñarCuestionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiseñarCuestionariosToolStripMenuItem.Click
    '    Dim dc As New Frm_DiseñadorCuestionarios()
    '    dc.Show()
    'End Sub

    'Private Sub CartaCompromisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CartaCompromisoToolStripMenuItem.Click
    '    CartaCompromiso.Show()
    'End Sub

    'Private Sub AplicaciónDeMedidaDisciplinariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicaciónDeMedidaDisciplinariaToolStripMenuItem.Click
    '    MedidasDisciplinarias.Show()
    'End Sub

    'Private Sub PlanDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanDePersonalToolStripMenuItem.Click
    '    Dim PlanPersonal As New Frm_cargaplanpersonal(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso)
    '    PlanPersonal.Show()
    'End Sub

    'Private Sub CambiosDeDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiosDeDepartamentoToolStripMenuItem.Click

    '    frm_cambiodepxmes.Show()


    'End Sub

    'Private Sub AumentoDeSueldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AumentoDeSueldoToolStripMenuItem.Click
    '    Dim AumentoSOperador As New AumentoSueldoOperador(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso)
    '    AumentoSOperador.Show()
    'End Sub
    Private Sub ModificaSueldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaSueldoToolStripMenuItem.Click
        Dim frm2 As New CsPresentacion.Formularios.RH.Frm_Modifica_Sueldo
        frm2.Show()
    End Sub
    Private Sub TratamientoDeAnomalíasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TratamientoDeAnomalíasToolStripMenuItem.Click
        Dim Anomalia As New AnomaliaPrincipal(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso, Me.emp.Id_puesto)
        Anomalia.Show()
    End Sub

    Private Sub ActualizaRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizaRegistrosToolStripMenuItem.Click
        ActualizaTe.Show()
    End Sub

    Private Sub SalidaDeEquipoDeCómputoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeEquipoDeCómputoToolStripMenuItem.Click
        SalidaEquipoComputo.Show()
    End Sub
    Private Sub CuestionariosPreguntasYRespuestasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuestionariosPreguntasYRespuestasToolStripMenuItem.Click
        Dim crp As New Frm_CuestionariosPreguntas(Me.emp)
        crp.Show()
    End Sub
    Private Sub DiseñarCuestionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiseñarCuestionariosToolStripMenuItem.Click
        Dim dc As New Frm_DiseñadorCuestionarios()
        dc.Show()
    End Sub

    Private Sub CartaCompromisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CartaCompromisoToolStripMenuItem.Click
        CartaCompromiso.Show()
    End Sub

    Private Sub AplicaciónDeMedidaDisciplinariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicaciónDeMedidaDisciplinariaToolStripMenuItem.Click
        MedidasDisciplinarias.Show()
    End Sub

    Private Sub PlanDePersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanDePersonalToolStripMenuItem.Click
        Dim PlanPersonal As New Frm_cargaplanpersonal(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso)
        PlanPersonal.Show()
    End Sub

    Private Sub CambiosDeDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiosDeDepartamentoToolStripMenuItem.Click

        frm_cambiodepxmes.Show()


    End Sub

    Private Sub AumentoDeSueldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AumentoDeSueldoToolStripMenuItem.Click
        Dim AumentoSOperador As New AumentoSueldoOperador(Me.emp.IdEmpleado, Me.emp.IdDepartamento, Me.emp.rh_permiso)
        AumentoSOperador.Show()
    End Sub

    Private Sub CartaCompromisoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CartaCompromisoToolStripMenuItem1.Click
        CartaCompromiso.Show()
    End Sub

    Private Sub MedidasDisciplinariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedidasDisciplinariaToolStripMenuItem.Click
        MedidasDisciplinarias.Show()
    End Sub

    Private Sub ReporteDeCambioDePuestoYoDepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeCambioDePuestoYoDepartamentoToolStripMenuItem.Click
        frm_cambiodepxmes.Show()
    End Sub

#End Region
End Class