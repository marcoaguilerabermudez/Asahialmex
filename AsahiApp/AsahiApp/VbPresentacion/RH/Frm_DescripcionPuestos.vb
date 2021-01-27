Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Negocio
Imports Clases

Public Class Frm_DescripcionPuestos
#Region "Variables de clase"
    Dim conex As New conexion()
    Dim cadenaConex As String
    Dim cadConex As String
    Dim cadConexCont As String
    Dim userName As String
    Dim ip As String = Strings.Left(Me.conex.getIp(), 6)
    Dim emp As New Empleado()
    Dim idDp As Integer, idPue As Integer, idDep As Integer, idArea As Integer
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal emp As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.emp = emp
    End Sub

#End Region
#Region "Acciones del formulario"
    Private Sub Frm_DescripcionPuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.ip = "172.16" Then
            Me.cadenaConex = Me.conex.cadenaConexExpress
            Me.cadConex = Me.conex.conexion2008
            Me.cadConexCont = Me.conex.conexionCont
        Else
            Me.cadenaConex = Me.conex.cadenaConexExpressFor
            Me.cadConex = Me.conex.conexion2008For
            Me.cadConexCont = Me.conex.conexionContFor
        End If
        CmbPuestoRellenar()
        CmbPuestoReportaRellenar()
        CmbDptoRellenar()
        CmbAreaRellenar()
        CmbPuestoDgv()
        CmbPuestoDgvRelaciones()
        CmbResponsabilidadDgv()
        CmbFrecuenciaDgv()
        CmbEntregableDgv()
        CmbIndicadoresDgv()
        CmbFrecuenciaDgvIndicadores()
        CmbCompeTecnica()
        CmbCompeGrl()
        CmbCompeMando()
    End Sub
    Private Sub Cmb_Area_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Area.SelectionChangeCommitted
        If Cmb_Area.SelectedValue <> 0 Then
            Cmb_Dpto.Enabled = True
        Else
            Cmb_Dpto.Enabled = False
        End If
    End Sub
    Private Sub Cmb_Dpto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Dpto.SelectionChangeCommitted
        If Cmb_Dpto.SelectedValue <> 0 Then
            Cmb_Puesto.Enabled = True
        Else
            Cmb_Puesto.Enabled = False
        End If
    End Sub
    Private Sub Cmb_Puesto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Puesto.SelectionChangeCommitted
        If Cmb_Puesto.SelectedValue <> 0 Then
            Dim NPues As New NPuestos
            Dim Pues As New Puestos
            Tbc_Origen.Enabled = True
            Me.idPue = Cmb_Puesto.SelectedValue
            Me.idDep = Cmb_Dpto.SelectedValue
            Me.idArea = Cmb_Area.SelectedValue
            Pues.IdPuesto = Me.idPue
            Pues.IdDepto = Me.idDep
            Pues.IdArea = Me.idArea
            Pues = NPues.ObtenerDpInfoGral(Me.cadenaConex, Pues)
            Me.idDp = Pues.IdDP
            RellenaInfoGral(Pues)
        Else
            Tbc_Origen.Enabled = False
        End If
    End Sub
    Private Sub Chk_Japo_CheckStateChanged(sender As Object, e As EventArgs) Handles Chk_Japo.CheckStateChanged
        If Chk_Japo.Checked = True Then
            Gpb_NivelJapon.Enabled = True
        Else
            Gpb_NivelJapon.Enabled = False
            Rdb_NivelIntJap.Checked = False
            Rdb_NivelAvJap.Checked = False
        End If
    End Sub
    Private Sub Chk_Ingles_CheckStateChanged(sender As Object, e As EventArgs) Handles Chk_Ingles.CheckStateChanged
        If Chk_Ingles.Checked = True Then
            Gpb_NivelIngles.Enabled = True
        Else
            Gpb_NivelIngles.Enabled = False
            Rdb_NivelIntIng.Checked = False
            Rdb_NivelAvIng.Checked = False
        End If
    End Sub
    Private Sub Rdb_ExpLabSi_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ExpLabSi.CheckedChanged
        If Rdb_ExpLabSi.Checked = True Then
            Gpb_ExpLab.Enabled = True
        End If
    End Sub
    Private Sub Rdb_ExpLabNo_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ExpLabNo.CheckedChanged
        If Rdb_ExpLabNo.Checked = True Then
            Gpb_ExpLab.Enabled = False
        End If
    End Sub
    Private Sub Rdb_ReqViajeSi_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ReqViajeSi.CheckedChanged
        If Rdb_ReqViajeSi.Checked = True Then
            Gpb_TipoViaje.Enabled = True
            Gpb_Justifica.Enabled = True
        End If
    End Sub
    Private Sub Rdb_ReqViajeNo_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ReqViajeNo.CheckedChanged
        If Rdb_ReqViajeNo.Checked = True Then
            Gpb_TipoViaje.Enabled = False
            Gpb_Justifica.Enabled = False
        End If
    End Sub
#End Region
#Region "Rellena Formulario"
    Private Sub RellenaInfoGral(ByVal Puesto As Puestos)
        Dim lstPues As New LPuestos()
        Dim NPues As New NPuestos()
        Cmb_PuestoRep.SelectedValue = Puesto.IdPuestoReporta
        If Puesto.TipoPuesto = 1 Then
            Rdb_Admin.Checked = True
        ElseIf Puesto.TipoPuesto = 2 Then
            Rdb_Operativo.Checked = True
        End If
        If Puesto.Sexo = 1 Then
            Rdb_Hombre.Checked = True
        ElseIf Puesto.Sexo = 2 Then
            Rdb_Mujer.Checked = True
        ElseIf Puesto.Sexo = 3 Then
            Rdb_Indist.Checked = True
        End If
        Txt_EdadMin.Text = Puesto.EdadMin
        Txt_EdadMax.Text = Puesto.EdadMax
        If Puesto.ReqExp = True Then Rdb_ExpLabSi.Checked = True
        If Puesto.ReqExp = False Then Rdb_ExpLabNo.Checked = True
        If Puesto.DispViajar = True Then
            Rdb_ReqViajeSi.Checked = True
            If Puesto.TipoViaje = 1 Then
                Rdb_TipoViajNac.Checked = True
            ElseIf Puesto.TipoViaje = 2 Then
                Rdb_TipoViajInt.Checked = True
            End If
            Txt_Justifica.Text = Puesto.Justificacion
        End If
        If Puesto.DispViajar = False Then Rdb_ReqViajeNo.Checked = True
        Txt_ObjGrl.Text = Puesto.ObjetivoPuestoGrl
        lstPues = NPues.ObtenerListas(Me.cadenaConex, Me.idDp)
        For Each item In lstPues
            Select Case item.IdEstudios
                Case 2 : Chk_Secu.Checked = True
                Case 3 : Chk_Prepa.Checked = True
                Case 4 : Chk_Universidad.Checked = True
                Case 6 : Chk_TSU.Checked = True
                Case 7 : Chk_EduOtro.Checked = True
                Case Else : MsgBox("Falta agregar Nivel de Estudios")
            End Select
            Select Case item.IdIdioma
                Case 2
                    Chk_Japo.Checked = True
                    Select Case item.Nivel
                        Case 1 : Rdb_NivelIntJap.Checked = True
                        Case 2 : Rdb_NivelAvJap.Checked = True
                    End Select
                Case 3
                    Chk_Ingles.Checked = True
                    Select Case item.Nivel
                        Case 1 : Rdb_NivelIntIng.Checked = True
                        Case 2 : Rdb_NivelAvIng.Checked = True
                    End Select
            End Select
        Next
        lstPues = NPues.ObtenerAutoridades(Me.cadenaConex, Me.idDp)
        RellenarAutoridades(lstPues)
    End Sub
    Private Sub RellenarAutoridades(ByVal lstPuesto As LPuestos)
        Dim fila As Integer = 0
        Dim NPues As New NPuestos()
        Dgv_PuestosCargo.DataSource = Nothing
        Dgv_PuestosCargo.Rows.Clear()

        For Each item In lstPuesto
            Dgv_PuestosCargo.Rows.Add()
            With Dgv_PuestosCargo.Rows(fila)
                .Cells("ocupantes").Value = item.PC_NOcup
                .Cells("puestosReportan").Value = item.PC_PuesRep
                .Cells("funcion").Value = item.PC_FuncPrinc
            End With
            fila += 1
        Next
        lstPuesto = NPues.obtenerLstRelaciones(Me.cadenaConex, Me.idDp)
        RellenarRelaciones(lstPuesto)
    End Sub
    Private Sub RellenarRelaciones(ByVal lstPuesto As LPuestos)
        Dim fila As Integer = 0, filaExt As Integer = 0
        Dim NPues As New NPuestos()
        Dgv_RelacionInter.DataSource = Nothing
        Dgv_RelacionInter.Rows.Clear()
        Dgv_RelacionExter.DataSource = Nothing
        Dgv_RelacionExter.Rows.Clear()

        For Each item In lstPuesto
            If item.TipoRelacion = 1 Then
                Dgv_RelacionInter.Rows.Add()
                With Dgv_RelacionInter.Rows(fila)
                    .Cells("puestosArea").Value = item.IdPuesto
                    .Cells("motivos").Value = item.MotivoRelacion
                End With
                fila += 1
            End If
            If item.TipoRelacion = 2 Then
                Dgv_RelacionExter.Rows.Add()
                With Dgv_RelacionExter.Rows(filaExt)
                    .Cells("contactoEmpresa").Value = item.Contacto
                    .Cells("motivosExt").Value = item.MotivoRelacion
                End With
                filaExt += 1
            End If
        Next
        lstPuesto = NPues.obtenerLstResponsabilidades(Me.cadenaConex, Me.idDp, Me.idPue, Me.idDep)
        RellenaResponsabilidades(lstPuesto)
    End Sub
    Private Sub RellenaResponsabilidades(ByVal lstPuesto As LPuestos)
        Dim fila As Integer = 0
        Dim cmbRow As New DataGrid
        Dim NPues As New NPuestos()
        Dgv_Responsabilidades.DataSource = Nothing
        Dgv_Responsabilidades.Rows.Clear()

        For Each item In lstPuesto
            Dgv_Responsabilidades.Rows.Add()
            With Dgv_Responsabilidades.Rows(fila)
                .Cells("numero").Value = fila + 1
                .Cells("actividades").Value = item.IdResponsabilidades
                .Cells("frecuencia").Value = item.IdFrecuencia
                .Cells("entregable").Value = item.IdEntregable
            End With
            fila += 1
        Next
        lstPuesto = NPues.obtenerLstIndicadores(Me.cadenaConex, Me.idDp, Me.idPue, Me.idDep)
        RellenaIndicadores(lstPuesto)
    End Sub
    Private Sub RellenaIndicadores(ByVal lstPuesto As LPuestos)
        Dim fila As Integer = 0
        Dim cmbRow As New DataGrid
        Dim NPues As New NPuestos()
        Dgv_Indicadores.DataSource = Nothing
        Dgv_Indicadores.Rows.Clear()

        For Each item In lstPuesto
            Dgv_Indicadores.Rows.Add()
            With Dgv_Indicadores.Rows(fila)
                .Cells("nombreIndicador").Value = item.IdIndicadores
                .Cells("estandar").Value = item.Estandar
                .Cells("formula").Value = item.Formula
                .Cells("frecuenciaIndica").Value = item.IdFrecuencia
                .Cells("fuenteInfo").Value = item.Fuente
            End With
            fila += 1
        Next
        lstPuesto = NPues.obtenerLstCompetencias(Me.cadenaConex, Me.idDp)
        RellenaCompetencias(lstPuesto)
    End Sub
    Private Sub RellenaCompetencias(ByVal lstPuesto As LPuestos)
        Dim fila As Integer = 0, filagrl As Integer = 0, filamando As Integer = 0
        Dim cmbRow As New DataGrid
        Dim NPues As New NPuestos()
        Dgv_Competencias.DataSource = Nothing
        Dgv_Competencias.Rows.Clear()

        For Each item In lstPuesto
            If item.IdCompeTecnicas <> 0 Then
                Dgv_Competencias.Rows.Add()
                With Dgv_Competencias.Rows(fila)
                    .Cells("compeTecnicas").Value = item.IdCompeTecnicas
                End With
                fila += 1
            End If
            If item.IdCompeGrl <> 0 Then
                If fila - 1 < filagrl Then Dgv_Competencias.Rows.Add()
                With Dgv_Competencias.Rows(filagrl)
                    .Cells("compeGenerales").Value = item.IdCompeGrl
                End With
                filagrl += 1
            End If
            If item.IdCompePersoMando <> 0 Then
                If (fila - 1 < filamando) And (filagrl - 1 < filamando) Then Dgv_Competencias.Rows.Add()
                With Dgv_Competencias.Rows(filamando)
                    .Cells("compeMando").Value = item.IdCompePersoMando
                End With
                filamando += 1
            End If
        Next
    End Sub
#End Region
#Region "Rellenar cmb"
    Private Sub CmbPuestoRellenar()
        Dim lstEmp As New LEmpleado()
        Dim Emp As New Empleado()
        lstEmp = PuestoRecuperar()

        Emp.IdPuesto = 0
        Emp.Puesto = ""
        lstEmp.Add(Emp)

        With Cmb_Puesto
            .DataSource = lstEmp
            .DisplayMember = "Puesto"
            .ValueMember = "IdPuesto"
            .SelectedValue = 0
        End With
    End Sub
    Private Sub CmbPuestoReportaRellenar()
        Dim lstEmp As New LEmpleado()
        lstEmp = PuestoRecuperar()

        emp.IdPuesto = 0
        emp.Puesto = ""
        lstEmp.Add(emp)

        With Cmb_PuestoRep
            .DataSource = lstEmp
            .DisplayMember = "Puesto"
            .ValueMember = "IdPuesto"
            .SelectedValue = 0
        End With
    End Sub
    Private Sub CmbDptoRellenar()
        Dim lstEmp As New LEmpleado()
        Dim Emp As New Empleado()
        lstEmp = DeptoRecuperar()

        Emp.IdDepartamento = 0
        Emp.Departamento = ""
        lstEmp.Add(Emp)

        With Cmb_Dpto
            .DataSource = lstEmp
            .DisplayMember = "Departamento"
            .ValueMember = "IdDepartamento"
            .SelectedValue = 0
        End With
    End Sub
    Private Sub CmbAreaRellenar()
        Dim lstEmp As New LEmpleado()
        Dim Emp As New Empleado()
        lstEmp = AreaRecuperar()

        Emp.IdArea = 0
        Emp.Area = ""
        lstEmp.Add(Emp)

        With Cmb_Area
            .DataSource = lstEmp
            .DisplayMember = "Area"
            .ValueMember = "IdArea"
            .SelectedValue = 0
        End With
    End Sub
    Private Sub CmbPuestoDgv()
        Dim lstEmp As New LEmpleado()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim emp As New Empleado()
        lstEmp = PuestoRecuperar()

        emp.IdPuesto = 0
        emp.Puesto = ""
        lstEmp.Add(emp)

        With CCmbDGV
            .DataSource = lstEmp
            .Name = "puestosReportan"
            .HeaderText = "Puestos que le reportan 直属部下の役職"
            .Width = 135
            .DisplayMember = "Puesto"
            .ValueMember = "IdPuesto"
        End With
        Dgv_PuestosCargo.Columns.RemoveAt(1)
        Dgv_PuestosCargo.Columns.Insert(1, CCmbDGV)
    End Sub
    Private Sub CmbResponsabilidadDgv()
        Dim lstPues As New LPuestos()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim pue As New Puestos()
        lstPues = CatRespRecuperar()

        pue.IdResponsabilidades = 0
        pue.Responsabilidades = ""
        lstPues.Add(pue)

        With CCmbDGV
            .DataSource = lstPues
            .Name = "actividades"
            .HeaderText = "Detalle de Actividades 主要目的"
            .Width = 400
            .DisplayMember = "Responsabilidades"
            .ValueMember = "IdResponsabilidades"
        End With
        Dgv_Responsabilidades.Columns.RemoveAt(1)
        Dgv_Responsabilidades.Columns.Insert(1, CCmbDGV)
    End Sub
    Private Sub CmbFrecuenciaDgv()
        Dim lstPues As New LPuestos()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim pue As New Puestos()
        lstPues = FrecuenciaRecuperar()

        pue.IdFrecuencia = 0
        pue.Frecuencia = ""
        lstPues.Add(pue)

        With CCmbDGV
            .DataSource = lstPues
            .Name = "frecuencia"
            .HeaderText = "Frecuencia 報告頻度"
            .Width = 120
            .DisplayMember = "Frecuencia"
            .ValueMember = "IdFrecuencia"
        End With
        Dgv_Responsabilidades.Columns.RemoveAt(2)
        Dgv_Responsabilidades.Columns.Insert(2, CCmbDGV)
    End Sub
    Private Sub CmbEntregableDgv()
        Dim lstPues As New LPuestos()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim pue As New Puestos()
        lstPues = EntregablesRecuperar()

        pue.IdEntregable = 0
        pue.Entregable = ""
        lstPues.Add(pue)

        With CCmbDGV
            .DataSource = lstPues
            .Name = "entregable"
            .HeaderText = "Entregable"
            .Width = 150
            .DisplayMember = "Entregable"
            .ValueMember = "IdEntregable"
        End With
        Dgv_Responsabilidades.Columns.RemoveAt(3)
        Dgv_Responsabilidades.Columns.Insert(3, CCmbDGV)
    End Sub
    Private Sub CmbIndicadoresDgv()
        Dim lstPues As New LPuestos()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim pue As New Puestos()
        lstPues = CatIndicadoresRecuperar()

        pue.IdIndicadores = 0
        pue.Indicadores = ""
        lstPues.Add(pue)

        With CCmbDGV
            .DataSource = lstPues
            .Name = "nombreIndicador"
            .HeaderText = "Nombre de indicador 指数"
            .Width = 150
            .DisplayMember = "Indicadores"
            .ValueMember = "IdIndicadores"
        End With
        Dgv_Indicadores.Columns.RemoveAt(0)
        Dgv_Indicadores.Columns.Insert(0, CCmbDGV)
    End Sub
    Private Sub CmbFrecuenciaDgvIndicadores()
        Dim lstPues As New LPuestos()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim pue As New Puestos()
        lstPues = FrecuenciaRecuperar()

        pue.IdFrecuencia = 0
        pue.Frecuencia = ""
        lstPues.Add(pue)

        With CCmbDGV
            .DataSource = lstPues
            .Name = "frecuenciaIndica"
            .HeaderText = "Frecuencia 報告頻度"
            .Width = 120
            .DisplayMember = "Frecuencia"
            .ValueMember = "IdFrecuencia"
        End With
        Dgv_Indicadores.Columns.RemoveAt(3)
        Dgv_Indicadores.Columns.Insert(3, CCmbDGV)
    End Sub
    Private Sub CmbCompeTecnica()
        Dim lstPues As New LPuestos()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim pue As New Puestos()
        lstPues = CatCompeTecnicaRecuperar()

        pue.IdCompeTecnicas = 0
        pue.CompeTecnicas = ""
        lstPues.Add(pue)

        With CCmbDGV
            .DataSource = lstPues
            .Name = "compeTecnicas"
            .HeaderText = "Competencias Técnicas"
            .Width = 235
            .DisplayMember = "CompeTecnicas"
            .ValueMember = "IdCompeTecnicas"
        End With
        Dgv_Competencias.Columns.RemoveAt(0)
        Dgv_Competencias.Columns.Insert(0, CCmbDGV)
    End Sub
    Private Sub CmbCompeGrl()
        Dim lstPues As New LPuestos()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim pue As New Puestos()
        lstPues = CatCompeGrlRecuperar()

        pue.IdCompeGrl = 0
        pue.CompeGrl = ""
        lstPues.Add(pue)

        With CCmbDGV
            .DataSource = lstPues
            .Name = "compeGenerales"
            .HeaderText = "Competencias Generales"
            .Width = 235
            .DisplayMember = "CompeGrl"
            .ValueMember = "IdCompeGrl"
        End With
        Dgv_Competencias.Columns.RemoveAt(1)
        Dgv_Competencias.Columns.Insert(1, CCmbDGV)
    End Sub
    Private Sub CmbCompeMando()
        Dim lstPues As New LPuestos()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim pue As New Puestos()
        lstPues = CatCompeMandoRecuperar()

        pue.IdCompePersoMando = 0
        pue.CompePersoMando = ""
        lstPues.Add(pue)

        With CCmbDGV
            .DataSource = lstPues
            .Name = "compeMando"
            .HeaderText = "Competencias CON personal a mando"
            .Width = 235
            .DisplayMember = "CompePersoMando"
            .ValueMember = "IdCompePersoMando"
        End With
        Dgv_Competencias.Columns.RemoveAt(2)
        Dgv_Competencias.Columns.Insert(2, CCmbDGV)
    End Sub
    Private Sub CmbPuestoDgvRelaciones()
        Dim lstEmp As New LEmpleado()
        Dim CCmbDGV As New DataGridViewComboBoxColumn
        Dim emp As New Empleado()
        lstEmp = PuestoRecuperar()

        emp.IdPuesto = 0
        emp.Puesto = ""
        lstEmp.Add(emp)

        With CCmbDGV
            .DataSource = lstEmp
            .Name = "puestosArea"
            .HeaderText = "Puestos o Área 役職・エリア"
            .Width = 135
            .DisplayMember = "Puesto"
            .ValueMember = "IdPuesto"
        End With
        Dgv_RelacionInter.Columns.RemoveAt(0)
        Dgv_RelacionInter.Columns.Insert(0, CCmbDGV)
    End Sub
#End Region
#Region "Recuperar Datos"
    Private Function PuestoRecuperar() As LEmpleado
        Dim NEmp As New NEmpleado()

        Return NEmp.RecuperarPuestos(Me.cadConex)
    End Function
    Private Function DeptoRecuperar() As LEmpleado
        Dim NEmp As New NEmpleado()

        Return NEmp.RecuperarDepto(Me.cadConex)
    End Function
    Private Function AreaRecuperar() As LEmpleado
        Dim NEmp As New NEmpleado()

        Return NEmp.RecuperarArea(Me.cadConex)
    End Function
    Private Function CatRespRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.ObtenerCatResponsabilidades(Me.cadenaConex)
    End Function
    Private Function FrecuenciaRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.ObtenerFrecuencia(Me.cadenaConex)
    End Function
    Private Function EntregablesRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.obtenerEntregables(Me.cadenaConex)
    End Function
    Private Function CatIndicadoresRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.obtenerCatIndicadores(Me.cadenaConex)
    End Function
    Private Function CatCompeTecnicaRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.obtenerCompetenciasTecnicas(Me.cadenaConex)
    End Function
    Private Function CatCompeGrlRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.obtenerCompetenciasGrl(Me.cadenaConex)
    End Function
    Private Function CatCompeMandoRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.obtenerCompetenciasMando(Me.cadenaConex)
    End Function
#End Region
End Class