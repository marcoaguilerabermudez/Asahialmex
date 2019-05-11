Imports System.Windows.Forms
Imports System.Configuration
Imports Negocio
Imports Clases

Public Class FrmProspecto
#Region "Variables"
    Private CadenaConex As String
    Private idRec As String
    Private usuario As Usuario
#End Region
#Region "Constructores"

    Sub New(ByVal CadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.CadenaConex = CadenaConex
    End Sub

    Sub New(ByVal usuario As Usuario, ByVal cadenaConex As String)


        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.usuario = usuario
        Me.CadenaConex = cadenaConex

    End Sub
#End Region
#Region "Acciones del Formulario"

    Private Sub FrmProspecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFechalta.Text = Format(Now, “yyyy-mm-dd”)
        formaPago()
        Vendedores()
        RellenaDiasCredito()
        RellenaCmbEstado()
        BttModificar.Enabled = False
        BttnEliminar.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If validar() = True Then
            If TextIDprospecto.Text = "" Then
                insertarCotizacion()
                LimpiarProspectos()
            End If
        End If

    End Sub
    Private Sub BttnLimpiar_Click(sender As Object, e As EventArgs) Handles BttnLimpiar.Click
        LimpiarProspectos()
    End Sub
    Private Sub BttModificar_Click(sender As Object, e As EventArgs) Handles BttModificar.Click
        Dim confirmacion As Integer
        confirmacion = MsgBox("Desea modificar el Prospecto  " & idRec & "", vbYesNo + vbQuestion + vbDefaultButton2, "Modificar")
        If confirmacion = vbYes Then
            ModificarCotizacion()
        End If
        LimpiarProspectos()
    End Sub
    Private Sub BttnEliminar_Click(sender As Object, e As EventArgs) Handles BttnEliminar.Click
        Dim confirmacion As Integer
        confirmacion = MsgBox("Desea eliminar el Prospecto  " & idRec & "", vbYesNo + vbQuestion + vbDefaultButton2, "Eliminar")
        If confirmacion = vbYes Then
            EliminarCotizacion()
        End If
        LimpiarProspectos()
    End Sub
    Private Sub BtnF3_Click(sender As Object, e As EventArgs) Handles BtnF3.Click
        Dim frmBuscador As New FrmBuscador(4, 1, CadenaConex)
        If frmBuscador.ShowDialog() = DialogResult.OK Then
            idRec = frmBuscador.Id
            If idRec <> Nothing Then
                rellenaFrmProspectos()
                BttnEliminar.Enabled = True
                BttModificar.Enabled = True
            End If

        End If
    End Sub

    Private Sub TextIDprospecto_Click(sender As Object, e As EventArgs) Handles TextIDprospecto.Click
        BtnF3.Visible = True
    End Sub
#End Region
#Region "Rellenar"
    Private Function rellenaCotizacion()
        Dim prospecto As New Prospecto
        prospecto.Nombre = TextNombre.Text
        prospecto.Alia = TxtAlias.Text
        prospecto.GiroComercial = TxtGiroComercial.Text
        prospecto.FormaPagos = CmbFormaPago.SelectedItem.idFormaPago
        prospecto.DiasCredito = CmbDiasCred.Text
        prospecto.Observaciones = RichTxtObservaciones.Text
        prospecto.Direccion = TxtDomicilio.Text
        prospecto.Colonia = TxtColonia.Text
        prospecto.IdCiudad = CmbCiudad.SelectedItem.id
        prospecto.IdEstado = CmbEstado.SelectedItem.fol
        prospecto.Contacto1 = TxtContacto.Text
        prospecto.Correo = TxtCorreo.Text
        prospecto.Telefono = TxtTelefono.Text
        prospecto.IdAgente = CmbVendedor.SelectedItem.idAgente
        prospecto.CP = TxtCP.Text
        If TxtNInterior.Text <> "" Then prospecto.NInterior = TxtNInterior.Text
        If TxtNExt.Text <> "" Then prospecto.NExterior = TxtNExt.Text
        If idRec <> Not Nothing Then prospecto.FechaAlta = Format(Now, "dd/MM/yyyy")
        prospecto.UltimoMovimiento = Format(Now, "dd/MM/yyyy")
        Return prospecto
    End Function
    Private Sub LimpiarProspectos()
        TextIDprospecto.Text = ""
        TextNombre.Text = ""
        TxtAlias.Text = ""
        TxtGiroComercial.Text = ""
        CmbVendedor.Text = Nothing
        CmbFormaPago.Text = Nothing
        CmbDiasCred.Text = Nothing
        RichTxtObservaciones.Text = ""
        TxtDomicilio.Text = ""
        TxtColonia.Text = ""
        CmbCiudad.Text = Nothing
        CmbEstado.Text = Nothing
        TxtContacto.Text = ""
        TxtCorreo.Text = ""
        TxtTelefono.Text = ""

    End Sub

    Private Sub rellenaFrmProspectos()
        Dim objprospecto As New Prospecto
        objprospecto = recuperarProspecto()
        TextIDprospecto.Text = objprospecto.IdProspecto
        TextNombre.Text = objprospecto.Nombre
        TxtAlias.Text = objprospecto.Alia
        TxtGiroComercial.Text = objprospecto.GiroComercial
        CmbVendedor.SelectedValue = objprospecto.IdAgente
        CmbFormaPago.SelectedValue = objprospecto.FormaPagos
        CmbDiasCred.Text = objprospecto.DiasCredito
        RichTxtObservaciones.Text = objprospecto.Observaciones
        TxtDomicilio.Text = objprospecto.Direccion
        TxtColonia.Text = objprospecto.Colonia
        CmbEstado.SelectedValue = objprospecto.IdEstado
        TxtCorreo.Text = objprospecto.Correo
        TxtContacto.Text = objprospecto.Contacto1
        TxtTelefono.Text = objprospecto.Telefono
        TxtNExt.Text = objprospecto.NExterior
        TxtNInterior.Text = objprospecto.NInterior
        TxtCP.Text = objprospecto.CP
        If idRec <> Nothing Then
            Dim estado As New Estado
            estado.Fol = objprospecto.IdEstado
            RellenaCmbCiudad(estado)
            CmbCiudad.SelectedValue = objprospecto.IdCiudad
        End If

    End Sub

#End Region
#Region "Relenar combo"
    Private Sub Vendedores()
        Dim negocio As New NAgente
        Dim lst As New LAgente
        lst = negocio.ObtenerAgentes(CadenaConex)
        With CmbVendedor
            .DataSource = lst
            .DisplayMember = "nombreAgente"
            .ValueMember = "idAgente"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub formaPago()
        Dim NSat As New NSat()
        Dim lst As New LSat()

        lst = NSat.ObtenerFormaPagoLista(CadenaConex)
        With CmbFormaPago
            .DataSource = lst
            .DisplayMember = "FormaPago"
            .ValueMember = "idFormaPago"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaDiasCredito()
        CmbDiasCred.Items.Add("2")
        CmbDiasCred.Items.Add("15")
        CmbDiasCred.Items.Add("30")
        CmbDiasCred.Items.Add("45")
        CmbDiasCred.Items.Add("60")
        CmbDiasCred.Items.Add("90")
    End Sub
    Private Sub RellenaCmbEstado()
        Dim objEstados As New NEstado()
        Dim lstEstados As New LEstado()
        lstEstados = objEstados.ObtenerEstadosClien(CadenaConex)
        With CmbEstado
            .DataSource = lstEstados
            .DisplayMember = "Estado"
            .ValueMember = "fol"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaCmbCiudad(objEdo As Estado)
        Dim objCiudad As New NCiudad()
        Dim lstCiudad As New LCiudad()
        lstCiudad = objCiudad.ObtenerCiudadesClien(CadenaConex, objEdo)
        With CmbCiudad
            .DataSource = lstCiudad
            .DisplayMember = "Nombre"
            .ValueMember = "id"
            .SelectedValue = ""
        End With
    End Sub
#End Region
#Region "Procesos"
    Private Sub insertarCotizacion()
        Dim negocio As New NProspectos
        Dim objprospecto As New Prospecto
        objprospecto = rellenaCotizacion()
        negocio.InsertaProspecto(CadenaConex, objprospecto)
    End Sub


    Private Sub ModificarCotizacion()
        Dim negocio As New NProspectos
        Dim objprospecto As New Prospecto
        objprospecto = rellenaCotizacion()
        objprospecto.IdProspecto = idRec
        negocio.ModificarProspecto(CadenaConex, objprospecto)
    End Sub

    Private Sub EliminarCotizacion()
        Dim negocio As New NProspectos
        Dim objprospecto As New Prospecto
        objprospecto.IdProspecto = idRec
        negocio.EliminarProspecto(CadenaConex, objprospecto)
    End Sub
    Private Function recuperarProspecto()
        Dim negocio As New NProspectos
        Dim objprospecto As New Prospecto
        objprospecto.IdProspecto = idRec
        Return negocio.ProspectorRecuperar(CadenaConex, objprospecto)
    End Function

    Private Function validar()
        If TextNombre.Text = "" Then
            MsgBox("Debe escribir el Nombre del Prospecto")
            Return False
        ElseIf TxtAlias.Text = "" Then
            MsgBox("Debe escribir el Nombre corto del Prospecto")
            Return False
        ElseIf CmbVendedor.Text = Nothing Then
            MsgBox("Debes  seleccionar el Agente")
            Return False
        ElseIf CmbFormaPago.Text = Nothing Then
            MsgBox("Debes  seleccionar la Forma de Pago")
            Return False
        ElseIf CmbDiasCred.Text = Nothing Then
            MsgBox("Debes  seleccionar los Días de credito")
            Return False
        ElseIf TxtDomicilio.Text = "" Then
            MsgBox("Debes escribir el Domicilio")
            Return False
        ElseIf TxtColonia.Text = "" Then
            MsgBox("Debes  escribir la colonia")
            Return False
        ElseIf CmbCiudad.Text = Nothing Then
            MsgBox("Debes  seleccionar la  Ciudad")
            Return False
        ElseIf CmbEstado.Text = Nothing Then
            MsgBox("Debes  seleccionar el Estado")
            Return False
            If TxtContacto.Text = "" And TxtCorreo.Text = "" And TxtTelefono.Text = "" Then
                MsgBox("Debes escribir el contacto del Prospecto")
                Return vbFalse
            End If
        Else
            Return True
        End If

    End Function
    Private Sub CmbEstado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbEstado.SelectionChangeCommitted
        Dim objEdo As New Estado
        CmbCiudad.Text = Nothing
        objEdo.Fol = CmbEstado.SelectedValue
        RellenaCmbCiudad(objEdo)
    End Sub



#End Region

End Class