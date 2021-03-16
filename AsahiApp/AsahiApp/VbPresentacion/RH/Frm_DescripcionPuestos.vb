Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic
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
    Dim idDp As Integer = 0, idPue As Integer, idDep As Integer, idArea As Integer
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
        Dgv_PuestosCargo.Columns("funcion").DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Dgv_RelacionInter.Columns("motivos").DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Dgv_RelacionExter.Columns("motivosExt").DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        CmbAreaRellenar()
        CmbDptoRellenar()
        CmbPuestoRellenar()
        CmbPuestoReportaRellenar()
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
            Cmb_Puesto.SelectedValue = 0
        Else
            Cmb_Dpto.Enabled = False
        End If
    End Sub
    Private Sub Cmb_Dpto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Dpto.SelectionChangeCommitted
        If Cmb_Dpto.SelectedValue <> 0 Then
            Cmb_Puesto.Enabled = True
            Cmb_Puesto.SelectedValue = 0
        Else
            Cmb_Puesto.Enabled = False
        End If
    End Sub
    Private Sub Cmb_Puesto_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Puesto.SelectionChangeCommitted
        Limpiar()
        If Cmb_Puesto.SelectedValue <> 0 Then
            Dim NPues As New NPuestos
            Dim Pues As New Puestos
            Btn_GuardarModificar.Enabled = True
            Btn_Reporte.Enabled = True
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
            Btn_GuardarModificar.Enabled = False
            Btn_Reporte.Enabled = False
        End If
    End Sub
    Private Sub Cmb_Puesto_TextChanged(sender As Object, e As EventArgs) Handles Cmb_Puesto.TextChanged
        If Cmb_Puesto.Text = "" Then
            Limpiar()
            Btn_GuardarModificar.Enabled = False
            Btn_Reporte.Enabled = False
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
            RellenaPuestosExp()
        End If
    End Sub
    Private Sub Rdb_ExpLabNo_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_ExpLabNo.CheckedChanged
        If Rdb_ExpLabNo.Checked = True Then
            Gpb_ExpLab.Enabled = False
            Txt_PuestoE1.Text = ""
            Txt_Cantidad1.Text = ""
            Txt_Tipo1.Text = ""
            Txt_PuestoE2.Text = ""
            Txt_Cantidad2.Text = ""
            Txt_Tipo2.Text = ""
            Txt_PuestoE3.Text = ""
            Txt_Cantidad3.Text = ""
            Txt_Tipo3.Text = ""
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
    Private Sub Btn_GuardarModificar_Click(sender As Object, e As EventArgs) Handles Btn_GuardarModificar.Click
        InsertaModifica()
    End Sub
    Private Sub Btn_Reporte_Click(sender As Object, e As EventArgs) Handles Btn_Reporte.Click
        Dim RepGrl As New Frm_ReporteDP(Me.idDp)
        RepGrl.Show()
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
                Chk_Nacional.Checked = True
            ElseIf Puesto.TipoViaje = 2 Then
                Chk_Internacional.Checked = True
            ElseIf Puesto.TipoViaje = 3 Then
                Chk_Nacional.Checked = True
                Chk_Internacional.Checked = True
            End If
            Txt_Justifica.Text = Puesto.Justificacion
        End If
        If Puesto.DispViajar = False Then Rdb_ReqViajeNo.Checked = True
        Txt_ObjGrl.Text = Puesto.ObjetivoPuestoGrl
        lstPues = NPues.ObtenerListas(Me.cadenaConex, Me.idDp)
        For Each item In lstPues
            Select Case item.IdEstudios
                Case 2
                    If item.EdoEscolaridad = True Then
                        Chk_Secu.Checked = True
                    End If
                    Chk_Secu.Tag = item.IdRelacionEstudios
                Case 3
                    If item.EdoEscolaridad = True Then
                        Chk_Prepa.Checked = True
                    End If
                    Chk_Prepa.Tag = item.IdRelacionEstudios
                Case 4
                    If item.EdoEscolaridad = True Then
                        Chk_Universidad.Checked = True
                    End If
                    Chk_Universidad.Tag = item.IdRelacionEstudios
                Case 6
                    If item.EdoEscolaridad = True Then
                        Chk_TSU.Checked = True
                    End If
                    Chk_TSU.Tag = item.IdRelacionEstudios
                Case 7
                    If item.EdoEscolaridad = True Then
                        Chk_EduOtro.Checked = True
                    End If
                    Chk_EduOtro.Tag = item.IdRelacionEstudios
                Case Else : MsgBox("Falta agregar Nivel de Estudios")
            End Select
            Select Case item.IdIdioma
                Case 2
                    Chk_Japo.Checked = True
                    Select Case item.Nivel
                        Case 1 : Rdb_NivelIntJap.Checked = True
                        Case 2 : Rdb_NivelAvJap.Checked = True
                    End Select
                    Chk_Japo.Tag = item.IdRelacionIdioma
                Case 3
                    Chk_Ingles.Checked = True
                    Select Case item.Nivel
                        Case 1 : Rdb_NivelIntIng.Checked = True
                        Case 2 : Rdb_NivelAvIng.Checked = True
                    End Select
                    Chk_Ingles.Tag = item.IdRelacionIdioma
            End Select
        Next
        lstPues = NPues.ObtenerAutoridades(Me.cadenaConex, Me.idDp)
        RellenarAutoridades(lstPues)
    End Sub
    Private Sub RellenaPuestosExp()
        Dim lstPues As New LPuestos
        Dim NPues As New NPuestos
        Dim v As Integer = 1

        lstPues = NPues.obtenerLstPuestosExp(Me.cadenaConex, Me.idDp)

        For Each item In lstPues
            If v = 1 Then
                Txt_PuestoE1.Tag = item.IdPuestoExp
                Txt_PuestoE1.Text = item.PuestoExp
                Txt_Cantidad1.Text = item.CantidadTiempo
                Txt_Tipo1.Text = item.TipoTiempo
            End If
            If v = 2 Then
                Txt_PuestoE2.Tag = item.IdPuestoExp
                Txt_PuestoE2.Text = item.PuestoExp
                Txt_Cantidad2.Text = item.CantidadTiempo
                Txt_Tipo2.Text = item.TipoTiempo
            End If
            If v = 3 Then
                Txt_PuestoE3.Tag = item.IdPuestoExp
                Txt_PuestoE3.Text = item.PuestoExp
                Txt_Cantidad3.Text = item.CantidadTiempo
                Txt_Tipo3.Text = item.TipoTiempo
            End If
            v += 1
        Next
    End Sub
    Private Sub RellenarAutoridades(ByVal lstPuesto As LPuestos)
        Dim fila As Integer = 0
        Dim NPues As New NPuestos()
        Dgv_PuestosCargo.DataSource = Nothing
        Dgv_PuestosCargo.Rows.Clear()

        For Each item In lstPuesto
            Dgv_PuestosCargo.Rows.Add()
            With Dgv_PuestosCargo.Rows(fila)
                .Cells("IdAutoridad").Value = item.IdAutoridad
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
                    .Cells("idRpI").Value = item.IdRelacionPuesto
                    If item.IdPuesto <> 0 Then .Cells("puestosArea").Value = "a" + Convert.ToString(item.IdPuesto)
                    If item.IdDepto <> 0 Then .Cells("puestosArea").Value = "b" + Convert.ToString(item.IdDepto)
                    .Cells("motivos").Value = item.MotivoRelacion
                End With
                fila += 1
            End If
            If item.TipoRelacion = 2 Then
                Dgv_RelacionExter.Rows.Add()
                With Dgv_RelacionExter.Rows(filaExt)
                    .Cells("idRpE").Value = item.IdRelacionPuesto
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
                .Cells("actividades").Value = item.IdCatalogoResp
                .Cells("frecuencia").Value = item.IdFrecuencia
                .Cells("entregable").Value = item.IdEntregable
                .Cells("idResp").Value = item.IdResponsabilidades
                .Cells("idRelaCatResp").Value = item.IdRelacionRespo
                .Cells("evaluable").Value = item.TipoRelacion
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
                .Cells("idIndicador").Value = item.IdIndicadores
                .Cells("idRelaIndica").Value = item.IdRelacionIndica
                .Cells("nombreIndicador").Value = item.IdCatalogoIndica
                .Cells("estandar").Value = item.Estandar
                .Cells("formula").Value = item.Formula
                .Cells("frecuenciaIndica").Value = item.IdFrecuencia
                .Cells("fuenteInfo").Value = item.Fuente
                .Cells("evaluableIn").Value = item.TipoIndica
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
                    .Cells("idCompeA").Value = item.IdCompetencia
                    .Cells("compeTecnicas").Value = item.IdCompeTecnicas
                End With
                fila += 1
            End If
            If item.IdCompeGrl <> 0 Then
                If fila - 1 < filagrl Then Dgv_Competencias.Rows.Add()
                With Dgv_Competencias.Rows(filagrl)
                    .Cells("idCompeB").Value = item.IdCompetencia
                    .Cells("compeGenerales").Value = item.IdCompeGrl
                End With
                filagrl += 1
            End If
            If item.IdCompePersoMando <> 0 Then
                If (fila - 1 < filamando) And (filagrl - 1 < filamando) Then Dgv_Competencias.Rows.Add()
                With Dgv_Competencias.Rows(filamando)
                    .Cells("idCompeC").Value = item.IdCompetencia
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
        Dim lstPues As New LPuestos()
        Dim Pues As New Puestos()
        lstPues = AreaRecuperar()

        Emp.IdArea = 0
        Emp.Area = ""
        lstPues.Add(Pues)

        With Cmb_Area
            .DataSource = lstPues
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
        Dgv_PuestosCargo.Columns.RemoveAt(2)
        Dgv_PuestosCargo.Columns.Insert(2, CCmbDGV)
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
        lstEmp = RecuperarPuestosRelaciones()

        emp.IdPuesto = 0
        emp.ConcatPuesto = 0
        emp.Puesto = ""
        lstEmp.Add(emp)

        With CCmbDGV
            .DataSource = lstEmp
            .Name = "puestosArea"
            .HeaderText = "Puestos o Área 役職・エリア"
            .Width = 135
            .DisplayMember = "Puesto"
            .ValueMember = "ConcatPuesto"
        End With
        Dgv_RelacionInter.Columns.RemoveAt(1)
        Dgv_RelacionInter.Columns.Insert(1, CCmbDGV)
    End Sub
#End Region
#Region "Rellena Objetos"
    Private Function RellenaObjPuestos() As Puestos
        Dim puest As New Puestos()
        puest.IdDP = Me.idDp
        puest.IdPuesto = Cmb_Puesto.SelectedValue
        puest.Puesto = Cmb_Puesto.Text
        puest.IdDepto = Cmb_Dpto.SelectedValue
        puest.IdArea = Cmb_Area.SelectedValue
        puest.IdPuestoReporta = Cmb_PuestoRep.SelectedValue
        If Rdb_Admin.Checked = True Then
            puest.TipoPuesto = 1
        ElseIf Rdb_Operativo.Checked = True Then
            puest.TipoPuesto = 2
        End If
        If Rdb_Hombre.Checked = True Then
            puest.Sexo = 1
        ElseIf Rdb_Mujer.Checked = True Then
            puest.Sexo = 2
        ElseIf Rdb_Indist.Checked = True Then
            puest.Sexo = 3
        End If
        puest.EdadMin = Txt_EdadMin.Text
        puest.EdadMax = Txt_EdadMax.Text
        If Rdb_ExpLabSi.Checked = True Then
            puest.ReqExp = 1
        ElseIf Rdb_ExpLabNo.Checked = True Then
            puest.ReqExp = 0
        End If
        If Rdb_ReqViajeSi.Checked = True Then
            puest.DispViajar = 1
        ElseIf Rdb_ReqViajeNo.Checked = True Then
            puest.DispViajar = 0
        End If
        If Chk_Nacional.Checked = True And Chk_Internacional.Checked = False Then
            puest.TipoViaje = 1
        ElseIf Chk_Internacional.Checked = True And Chk_Nacional.Checked = False Then
            puest.TipoViaje = 2
        ElseIf Chk_Nacional.Checked = True And Chk_Internacional.Checked = True Then
            puest.TipoViaje = 3
        End If
        puest.Justificacion = Txt_Justifica.Text

        Return puest
    End Function
    Private Function RellenaLstEstudios() As LPuestos
        Dim i As Integer
        Dim lstPues As New LPuestos()

        For i = 1 To 5
            Dim puest As New Puestos()
            Select Case i
                Case 1
                    If Chk_Universidad.Checked = True Or Chk_Universidad.Tag <> 0 Then
                        puest.IdRelacionEstudios = Chk_Universidad.Tag
                        puest.IdDP = Me.idDp
                        puest.IdEstudios = 4
                        If Chk_Universidad.Checked = True Then
                            puest.EdoEscolaridad = 1
                        Else
                            puest.EdoEscolaridad = 0
                        End If
                        lstPues.Add(puest)
                    End If
                Case 2
                    If Chk_TSU.Checked = True Or Chk_TSU.Tag <> 0 Then
                        puest.IdRelacionEstudios = Chk_TSU.Tag
                        puest.IdDP = Me.idDp
                        puest.IdEstudios = 6
                        If Chk_TSU.Checked = True Then
                            puest.EdoEscolaridad = 1
                        Else
                            puest.EdoEscolaridad = 0
                        End If
                        lstPues.Add(puest)
                    End If
                Case 3
                    If Chk_Prepa.Checked = True Or Chk_Prepa.Tag <> 0 Then
                        puest.IdRelacionEstudios = Chk_Prepa.Tag
                        puest.IdDP = Me.idDp
                        puest.IdEstudios = 3
                        If Chk_Prepa.Checked = True Then
                            puest.EdoEscolaridad = 1
                        Else
                            puest.EdoEscolaridad = 0
                        End If
                        lstPues.Add(puest)
                    End If
                Case 4
                    If Chk_Secu.Checked = True Or Chk_Secu.Tag <> 0 Then
                        puest.IdRelacionEstudios = Chk_Secu.Tag
                        puest.IdDP = Me.idDp
                        puest.IdEstudios = 2
                        If Chk_Secu.Checked = True Then
                            puest.EdoEscolaridad = 1
                        Else
                            puest.EdoEscolaridad = 0
                        End If
                        lstPues.Add(puest)
                    End If
                Case 5
                    If Chk_EduOtro.Checked = True Or Chk_EduOtro.Tag <> 0 Then
                        puest.IdRelacionEstudios = Chk_EduOtro.Tag
                        puest.IdDP = Me.idDp
                        puest.IdEstudios = 7
                        If Chk_EduOtro.Checked = True Then
                            puest.EdoEscolaridad = 1
                        Else
                            puest.EdoEscolaridad = 0
                        End If
                        lstPues.Add(puest)
                    End If
            End Select
        Next

        Return lstPues
    End Function
    Private Function RellenaLstIdiomas() As LPuestos
        Dim lstPues As New LPuestos()

        If Chk_Ingles.Checked = True Then
            Dim obj As New Puestos()
            obj.IdDP = Me.idDp
            obj.IdIdioma = 3
            obj.IdRelacionIdioma = Chk_Ingles.Tag
            If Rdb_NivelIntIng.Checked = True Then obj.Nivel = 1
            If Rdb_NivelAvIng.Checked = True Then obj.Nivel = 2
            lstPues.Add(obj)
        End If

        If Chk_Japo.Checked = True Then
            Dim obj As New Puestos()
            obj.IdDP = Me.idDp
            obj.IdIdioma = 2
            obj.IdRelacionIdioma = Chk_Japo.Tag
            If Rdb_NivelIntJap.Checked = True Then obj.Nivel = 1
            If Rdb_NivelAvJap.Checked = True Then obj.Nivel = 2
            lstPues.Add(obj)
        End If

        Return lstPues
    End Function
    Private Function RellenaLstPuestosExp() As LPuestos
        Dim i As Integer
        Dim lstPues As New LPuestos()

        For i = 1 To 3
            Dim puest As New Puestos()
            Select Case i
                Case 1
                    If Txt_PuestoE1.Text <> "" Or Txt_PuestoE1.Tag <> 0 Then
                        puest.IdPuestoExp = Txt_PuestoE1.Tag
                        puest.IdDP = Me.idDp
                        puest.PuestoExp = Txt_PuestoE1.Text
                        puest.CantidadTiempo = Txt_Cantidad1.Text
                        puest.TipoTiempo = Txt_Tipo1.Text
                        lstPues.Add(puest)
                    End If
                Case 2
                    If Txt_PuestoE2.Text <> "" Or Txt_PuestoE2.Tag <> 0 Then
                        puest.IdPuestoExp = Txt_PuestoE2.Tag
                        puest.IdDP = Me.idDp
                        puest.PuestoExp = Txt_PuestoE2.Text
                        puest.CantidadTiempo = Txt_Cantidad2.Text
                        puest.TipoTiempo = Txt_Tipo2.Text
                        lstPues.Add(puest)
                    End If
                Case 3
                    If Txt_PuestoE3.Text <> "" Or Txt_PuestoE3.Tag <> 0 Then
                        puest.IdPuestoExp = Txt_PuestoE3.Tag
                        puest.IdDP = Me.idDp
                        puest.PuestoExp = Txt_PuestoE3.Text
                        puest.CantidadTiempo = Txt_Cantidad3.Text
                        puest.TipoTiempo = Txt_Tipo3.Text
                        lstPues.Add(puest)
                    End If
            End Select
        Next
        Return lstPues
    End Function
    Private Function RellenaLstAutoridad() As LPuestos
        Dim lstPues As New LPuestos()
        Dim fila As Integer, totalfilas As Integer = Dgv_PuestosCargo.Rows.Count()
        For fila = 0 To totalfilas - 2
            With Dgv_PuestosCargo.Rows(fila)
                Dim objPuesto As New Puestos()
                objPuesto.IdAutoridad = .Cells("IdAutoridad").Value
                objPuesto.IdDP = Me.idDp
                objPuesto.PC_NOcup = .Cells("ocupantes").Value
                objPuesto.PC_PuesRep = .Cells("puestosReportan").Value
                objPuesto.PC_FuncPrinc = .Cells("funcion").Value
                lstPues.Add(objPuesto)
            End With
        Next
        Return lstPues
    End Function
    Private Function RellenaLstRelacionesPuesto() As LPuestos
        Dim lstPues As New LPuestos()
        Dim filaI As Integer, totalfilasI As Integer = Dgv_RelacionInter.Rows.Count()
        For filaI = 0 To totalfilasI - 2
            With Dgv_RelacionInter.Rows(filaI)
                Dim objPuesto As New Puestos()
                Dim slice1 As String, slice2 As Integer
                slice1 = Microsoft.VisualBasic.Left(.Cells("puestosArea").Value, 1)
                slice2 = Mid(.Cells("puestosArea").Value, 2, 2)
                objPuesto.IdRelacionPuesto = .Cells("idRpI").Value
                objPuesto.IdDP = Me.idDp
                If slice1 = "a" Then objPuesto.IdPuesto = slice2
                If slice1 = "b" Then objPuesto.IdDepto = slice2
                objPuesto.TipoRelacion = 1
                objPuesto.MotivoRelacion = .Cells("motivos").Value
                lstPues.Add(objPuesto)
            End With
        Next
        Dim filaE As Integer, totalfilasE As Integer = Dgv_RelacionExter.Rows.Count()
        For filaE = 0 To totalfilasE - 2
            With Dgv_RelacionExter.Rows(filaE)
                Dim objPuesto As New Puestos()
                objPuesto.IdRelacionPuesto = .Cells("idRpE").Value
                objPuesto.IdDP = Me.idDp
                objPuesto.Contacto = .Cells("contactoEmpresa").Value
                objPuesto.TipoRelacion = 2
                objPuesto.MotivoRelacion = .Cells("motivosExt").Value
                lstPues.Add(objPuesto)
            End With
        Next
        Return lstPues
    End Function
    Private Function RellenaLstRelacionCatalogoResp() As LPuestos
        Dim lstPues As New LPuestos()
        Dim fila As Integer, totalfilas As Integer = Dgv_Responsabilidades.Rows.Count()
        For fila = 0 To totalfilas - 2
            With Dgv_Responsabilidades.Rows(fila)
                Dim objPuesto As New Puestos()
                objPuesto.IdRcr = .Cells("idRelaCatResp").Value
                objPuesto.IdCatalogoResp = .Cells("actividades").Value
                objPuesto.IdPuesto = Me.idPue
                objPuesto.IdDepto = Me.idDep
                objPuesto.TipoRelacion = .Cells("evaluable").Value
                objPuesto.IdFrecuencia = .Cells("frecuencia").Value
                objPuesto.PuntMin = 0
                objPuesto.PuntMax = 5
                objPuesto.PorceMin = 0
                objPuesto.PorceMax = 5
                lstPues.Add(objPuesto)
            End With
        Next
        Return lstPues
    End Function
    Private Function RellenaLstResponsabilidades() As LPuestos
        Dim lstPues As New LPuestos()
        Dim fila As Integer, totalfilas As Integer = Dgv_Responsabilidades.Rows.Count()
        For fila = 0 To totalfilas - 2
            With Dgv_Responsabilidades.Rows(fila)
                Dim objPuesto As New Puestos()
                objPuesto.IdResponsabilidades = .Cells("idResp").Value
                objPuesto.IdDP = Me.idDp
                objPuesto.IdRelacionRespo = .Cells("idRelaCatResp").Value
                objPuesto.IdFrecuencia = .Cells("frecuencia").Value 'frecuencia
                objPuesto.IdEntregable = .Cells("entregable").Value
                lstPues.Add(objPuesto)
            End With
        Next
        Return lstPues
    End Function
    Private Function RellenaLstRelacionCatalogoIndic() As LPuestos
        Dim lstPues As New LPuestos()
        Dim fila As Integer, totalfilas As Integer = Dgv_Indicadores.Rows.Count()
        For fila = 0 To totalfilas - 2
            With Dgv_Indicadores.Rows(fila)
                Dim objPuesto As New Puestos()
                objPuesto.IdRci = .Cells("idRelaIndica").Value
                objPuesto.IdCatalogoIndica = .Cells("nombreIndicador").Value
                objPuesto.IdPuesto = Me.idPue
                objPuesto.IdDepto = Me.idDep
                objPuesto.Estandar = .Cells("estandar").Value
                objPuesto.Formula = .Cells("formula").Value
                objPuesto.Fuente = .Cells("fuenteInfo").Value
                objPuesto.IdFrecuencia = .Cells("frecuenciaIndica").Value
                objPuesto.PuntMin = 0
                objPuesto.PuntMax = 5
                objPuesto.PorceMin = 0
                objPuesto.PorceMax = 5
                objPuesto.TipoIndica = .Cells("evaluableIn").Value
                lstPues.Add(objPuesto)
            End With
        Next
        Return lstPues
    End Function
    Private Function RellenaLstIndicadores() As LPuestos
        Dim lstPues As New LPuestos()
        Dim fila As Integer, totalfilas As Integer = Dgv_Indicadores.Rows.Count()
        For fila = 0 To totalfilas - 2
            With Dgv_Indicadores.Rows(fila)
                Dim objPuesto As New Puestos()
                objPuesto.IdIndicadores = .Cells("idIndicador").Value
                objPuesto.IdDP = Me.idDp
                objPuesto.IdRelacionIndica = .Cells("idRelaIndica").Value
                objPuesto.Estandar = .Cells("estandar").Value 'estandar
                objPuesto.Formula = .Cells("formula").Value 'formula
                objPuesto.IdFrecuencia = .Cells("frecuenciaIndica").Value 'frecuencia
                lstPues.Add(objPuesto)
            End With
        Next
        Return lstPues
    End Function
    Private Function RellenaLstCompetenecias() As LPuestos
        Dim lstPues As New LPuestos()
        Dim fila As Integer, totalfilas As Integer = Dgv_Competencias.Rows.Count()
        For fila = 0 To totalfilas - 2
            With Dgv_Competencias.Rows(fila)
                If .Cells("compeTecnicas").Value <> 0 Then
                    Dim objPuesto As New Puestos()
                    objPuesto.IdCompetencia = .Cells("idCompeA").Value
                    objPuesto.IdCatalogoCompe = .Cells("compeTecnicas").Value
                    objPuesto.IdDP = Me.idDp
                    lstPues.Add(objPuesto)
                End If
                If .Cells("compeGenerales").Value <> 0 Then
                    Dim objPuesto As New Puestos()
                    objPuesto.IdCompetencia = .Cells("idCompeB").Value
                    objPuesto.IdCatalogoCompe = .Cells("compeGenerales").Value
                    objPuesto.IdDP = Me.idDp
                    lstPues.Add(objPuesto)
                End If
                If .Cells("compeMando").Value <> 0 Then
                    Dim objPuesto As New Puestos()
                    objPuesto.IdCompetencia = .Cells("idCompeC").Value
                    objPuesto.IdCatalogoCompe = .Cells("compeMando").Value
                    objPuesto.IdDP = Me.idDp
                    lstPues.Add(objPuesto)
                End If
            End With
        Next
        Return lstPues
    End Function
#End Region
#Region "Recuperar Datos"
    Private Function PuestoRecuperar() As LEmpleado
        Dim NEmp As New NEmpleado()

        Return NEmp.RecuperarPuestos(Me.cadConex)
    End Function
    Private Function RecuperarPuestosRelaciones() As LEmpleado
        Dim NEmp As New NEmpleado()

        Return NEmp.RecuperarPuestosRelaciones(Me.cadConex)
    End Function
    Private Function DeptoRecuperar() As LEmpleado
        Dim NEmp As New NEmpleado()

        Return NEmp.RecuperarDepto(Me.cadConex)
    End Function
    Private Function AreaRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.ObtenerArea(Me.cadenaConex)
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

        Return NPues.ObtenerCompetenciasGrl(Me.cadenaConex)
    End Function
    Private Function CatCompeMandoRecuperar() As LPuestos
        Dim NPues As New NPuestos()

        Return NPues.obtenerCompetenciasMando(Me.cadenaConex)
    End Function
    Private Sub RellenarIdRelacionResponsabilidades(ByVal lstPues As LPuestos)
        For Each item In lstPues
            Dim fila As Integer = 0, totalfilas As Integer = Dgv_Responsabilidades.Rows.Count()
            For fila = 0 To totalfilas - 2
                With Dgv_Responsabilidades.Rows(fila)
                    If item.IdCatalogoResp = .Cells("actividades").Value Then
                        .Cells("idRelaCatResp").Value = item.IdRelacionRespo
                    End If
                End With
            Next
        Next
    End Sub
    Private Sub RellenarIdRelacionIndicadores(ByVal lstPues As LPuestos)
        For Each item In lstPues
            Dim fila As Integer = 0, totalfilas As Integer = Dgv_Indicadores.Rows.Count()
            For fila = 0 To totalfilas - 2
                With Dgv_Indicadores.Rows(fila)
                    If item.IdCatalogoIndica = .Cells("nombreIndicador").Value Then
                        .Cells("idRelaIndica").Value = item.IdRelacionIndica
                    End If
                End With
            Next
        Next
    End Sub
#End Region
#Region "Inserts, Modificaciones y Limpieza"
    Private Sub InsertaModifica()
        Dim puest As New Puestos()
        Dim lstPues As New LPuestos()
        Dim NPuest As New NPuestos()
        puest = RellenaObjPuestos()
        puest = NPuest.InsertModifDP(Me.cadenaConex, puest)
        Me.idDp = puest.IdDP
        lstPues = RellenaLstEstudios()
        NPuest.InsertModifEscolaridad(Me.cadenaConex, lstPues)
        lstPues = RellenaLstIdiomas()
        NPuest.InsertModifIdioma(Me.cadenaConex, lstPues)
        lstPues = RellenaLstPuestosExp()
        NPuest.InsertModifPuestoExp(Me.cadenaConex, lstPues)
        puest.IdDP = Me.idDp
        puest.ObjetivoPuestoGrl = Txt_ObjGrl.Text
        NPuest.InsertModifObjetivo(Me.cadenaConex, puest)
        lstPues = RellenaLstAutoridad()
        NPuest.InsertModifAutoridad(Me.cadenaConex, lstPues)
        lstPues = RellenaLstRelacionesPuesto()
        NPuest.InsertModifRelacionesPuesto(Me.cadenaConex, lstPues)
        lstPues = RellenaLstRelacionCatalogoResp()
        lstPues = NPuest.InsertModifRelacionResponsaDp(Me.cadenaConex, lstPues)
        RellenarIdRelacionResponsabilidades(lstPues)
        lstPues = RellenaLstResponsabilidades()
        NPuest.InsertModifResponsabilidades(Me.cadenaConex, lstPues)
        lstPues = RellenaLstRelacionCatalogoIndic()
        lstPues = NPuest.InsertModifRelacionIndicadores(Me.cadenaConex, lstPues)
        RellenarIdRelacionIndicadores(lstPues)
        lstPues = RellenaLstIndicadores()
        NPuest.InsertModifIndicadores(Me.cadenaConex, lstPues)
        lstPues = RellenaLstCompetenecias()
        NPuest.InsertModifCompetencias(Me.cadenaConex, lstPues)


        Limpiar()
        puest.IdPuesto = Me.idPue
        puest.IdDepto = Me.idDep
        puest.IdArea = Me.idArea
        puest = NPuest.ObtenerDpInfoGral(Me.cadenaConex, puest)
        Me.idDp = puest.IdDP
        RellenaInfoGral(puest)
    End Sub
    Private Sub Limpiar()
        Cmb_PuestoRep.SelectedValue = 0
        Rdb_Admin.Checked = False
        Rdb_Operativo.Checked = False
        Rdb_Mujer.Checked = False
        Rdb_Hombre.Checked = False
        Rdb_Indist.Checked = False
        Txt_EdadMin.Text = ""
        Txt_EdadMax.Text = ""
        Chk_Universidad.Checked = False
        Chk_TSU.Checked = False
        Chk_Prepa.Checked = False
        Chk_Secu.Checked = False
        Chk_EduOtro.Checked = False
        Rdb_ExpLabSi.Checked = False
        Rdb_ExpLabNo.Checked = False
        Txt_PuestoE1.Text = ""
        Txt_Cantidad1.Text = ""
        Txt_Tipo1.Text = ""
        Txt_PuestoE2.Text = ""
        Txt_Cantidad2.Text = ""
        Txt_Tipo2.Text = ""
        Txt_PuestoE3.Text = ""
        Txt_Cantidad3.Text = ""
        Txt_Tipo3.Text = ""
        Chk_Ingles.Checked = False
        Chk_Japo.Checked = False
        Rdb_NivelIntIng.Checked = False
        Rdb_NivelAvIng.Checked = False
        Rdb_NivelIntJap.Checked = False
        Rdb_NivelAvJap.Checked = False
        Rdb_ReqViajeSi.Checked = False
        Rdb_ReqViajeNo.Checked = False
        Chk_Nacional.Checked = False
        Chk_Internacional.Checked = False
        Txt_Justifica.Text = ""
        Txt_ObjGrl.Text = ""
        Dgv_PuestosCargo.DataSource = Nothing
        Dgv_PuestosCargo.Rows.Clear()
        Dgv_RelacionInter.DataSource = Nothing
        Dgv_RelacionInter.Rows.Clear()
        Dgv_RelacionExter.DataSource = Nothing
        Dgv_RelacionExter.Rows.Clear()
        Dgv_Responsabilidades.DataSource = Nothing
        Dgv_Responsabilidades.Rows.Clear()
        Dgv_Indicadores.DataSource = Nothing
        Dgv_Indicadores.Rows.Clear()
        Dgv_Competencias.DataSource = Nothing
        Dgv_Competencias.Rows.Clear()
    End Sub
#End Region
End Class