Imports Negocio
Imports Clases
Imports System.IO

Public Class FrmConfiguracionGral
    Private cadenaConex As String
    Private idUsuario As Integer
    Private idSuc As Integer
    Sub New(ByVal usuario As Integer, ByVal idSuc As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.idSuc = idSuc
        Me.idUsuario = usuario
    End Sub
    Private Sub FrmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Suc As New Sucursales()
        Dim Config As New Configuracion()
        Dim Estado As New Estado()


        Suc.IdSuc = Me.idSuc
        Suc = RecuperaSucursal(Suc)
        Config.IdConfig = Suc.IdConfig
        Config = RecuperaConfiguracion(Config)

        Estado.Fol = Suc.IdEstado
        RellenaComboBox(Estado)

        RellenaControlesConfiguracion(Config)
        RellenaControlesSucursal(Suc)

    End Sub
    Private Function RecuperaSucursal(Suc As Sucursales) As Sucursales
        Dim NSuc As New NSucursales()
        Suc = NSuc.ObtenerSucursal(cadenaConex, Suc.IdSuc)
        Return Suc
    End Function
    Private Function RecuperaConfiguracion(ByVal Config As Configuracion) As Configuracion
        Dim NConfig As New NConfiguracion()
        Config = NConfig.ObtenerConfig(cadenaConex, Config.IdConfig)
        Return Config
    End Function

    Private Sub RellenaControlesConfiguracion(Config As Configuracion)
        CmbVersionCFDI.SelectedItem = Config.VersionCFDI
        CmbPac.SelectedItem = Config.PAC
        TxtUrlCSD.Text = Config.UrlCsd
        TxtUrlKey.Text = Config.UrlKey
        TxtNserie.Text = Config.SerieCFDI
        TxtVInicio.Text = Config.VigenciaInicio
        TxtVFin.Text = Config.VigenciaFin
        TxtIVA.Text = Config.IVA
        TxtIEPS.Text = Config.IEPS
        TxtReteIVA.Text = Config.RetencionIVA
        TxtReteISR.Text = Config.RetencionISR
        TxtRutaOmision.Text = Config.UrlOmision
        TxtUrlReportes.Text = Config.UrlReportes
        TxtUrlPlantilla.Text = Config.UrlPlantilla
        TxtCorreo.Text = Config.Correo
        TxtServidorpop3.Text = Config.ServidorPOP3
        TxtServidorSMTP.Text = Config.ServidorSMTP
        TxtPOP3.Text = Config.PuertoPOP3
        TxtSMTP.Text = Config.PuertoSMTP
        If Config.ConexionSegura Then ChkSegura.Checked = True
        TxtAsunto.Text = Config.Asunto
        TxtMensaje.Text = Config.Mensaje

    End Sub
    Private Sub RellenaControlesSucursal(ByVal Suc As Sucursales)
        TxtRazoSocial.Text = Suc.RazonSocial
        TxtRFC.Text = Suc.RFC
        TxtCalle.Text = Suc.Calle
        TxtNumExt.Text = Suc.NumEXT
        TxtNumInt.Text = Suc.NumInt
        TxtCp.Text = Suc.CodigoPostal
        TxtColonia.Text = Suc.Colonia
        CmbEstado.SelectedValue = Convert.ToInt32(Suc.IdEstado)
        CmbCiudad.SelectedValue = Convert.ToInt32(Suc.IdCiudad)

        TxtTel1.Text = Suc.Tel1
        TxtTel2.Text = Suc.Tel2
        TxtTel3.Text = Suc.Tel3
        TxtLugarExpedicion.Text = Suc.LugarExpedicion
        CmbRegimen.SelectedValue = Suc.IdRegimen
        TxtLogo.Text = Suc.UrlLogo
        'TxtCreditos.Text = Suc.Creditos
        'TxtVCreditos.Text = Suc.VencimientoCreditos

    End Sub
#Region "Rellena Objetos"
    Private Function RellenaConfiguracion()
        Dim Config As New Configuracion()

        'CFDI
        Config.VersionCFDI = CmbVersionCFDI.Text
        Config.PAC = CmbVersionCFDI.Text
        'Certificados
        Config.UrlCsd = TxtUrlCSD.Text
        Config.UrlKey = TxtUrlKey.Text
        Config.PasswordCSD = TxtPassCSD.Text
        Config.SerieCFDI = TxtNserie.Text
        Config.VigenciaInicio = TxtVInicio.Text
        Config.VigenciaFin = TxtVFin.Text
        'Impuestos
        Config.IVA = TxtIVA.Text
        Config.IEPS = TxtIEPS.Text
        Config.RetencionIVA = TxtReteIVA.Text
        Config.RetencionISR = TxtReteISR.Text
        'Directorios
        Config.UrlOmision = TxtRutaOmision.Text
        Config.UrlReportes = TxtUrlReportes.Text
        Config.UrlPlantilla = TxtUrlPlantilla.Text
        'Correo
        Config.Correo = TxtCorreo.Text
        Config.PasswordCorreo = TxtPassCSD.Text
        Config.ServidorPOP3 = TxtServidorpop3.Text
        Config.ServidorSMTP = TxtSMTP.Text
        Config.PuertoPOP3 = TxtPOP3.Text
        Config.PuertoSMTP = TxtSMTP.Text
        If ChkSegura.CheckState = True Then Config.ConexionSegura = True
        Config.Asunto = TxtAsunto.Text
        Config.Mensaje = TxtMensaje.Text

        Return Config
    End Function
    Private Function RellenaSucursales()
        Dim Suc As New Sucursales()
        Suc.RazonSocial = TxtRazoSocial.Text
        Suc.RFC = TxtRFC.Text
        Suc.Calle = TxtCalle.Text
        Suc.NumEXT = TxtNumExt.Text
        Suc.NumInt = TxtNumInt.Text
        Suc.CodigoPostal = TxtCp.Text
        Suc.Colonia = TxtColonia.Text
        Suc.Ciudad = CmbCiudad.SelectedItem.id
        Suc.Estado = CmbEstado.SelectedItem.id
        Suc.Tel1 = TxtTel1.Text
        Suc.Tel2 = TxtTel2.Text
        Suc.Tel3 = TxtTel3.Text
        Suc.LugarExpedicion = TxtLugarExpedicion.Text
        Suc.IdRegimen = CmbRegimen.SelectedItem.id
        Suc.UrlLogo = TxtLogo.Text
        Return Suc
    End Function
#End Region

    ''' <summary>
    ''' Inserta Configuracion y Sucursales al mismo tiempo
    ''' por medio de un XML
    ''' </summary>
    Private Sub InsertaConfiguracion()
        Dim Config As New Configuracion()
        Dim Suc As New Sucursales()
        Dim NConfig As New NConfiguracion
        Config = RellenaConfiguracion()
        Suc = RellenaSucursales()

        NConfig.InsertaConfiguracion(cadenaConex, Config, Suc)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        If Validar() = True Then
            InsertaConfiguracion()
        End If
    End Sub
    Private Function Validar() As Boolean

        If TxtIVA.Text = "" Then
            MsgBox("Es necesario el IVA")
            Return False
        ElseIf TxtRazoSocial.Text = "" Then
            MsgBox("Es necesario crear una contraseña")
            Return False
        ElseIf TxtRFC.Text = "" Then
            MsgBox("Debe de confirmar la contraseña")
            Return False
        Else
            Return True
        End If

    End Function


#Region "Rellena ComboBox"
    Private Sub RellenaComboBox(Estado As Estado)
        RellenaCmbEstado()
        RellenaCmbCiudad(Estado)
        RellenaCmbRegimenFiscal()
        RellenaCmbVersionCFDI()
        RellenaCmbPAC()

    End Sub
    Private Sub RellenaCmbVersionCFDI()
        CmbVersionCFDI.Items.Add("3.3")
    End Sub
    Private Sub RellenaCmbPAC()
        CmbPac.Items.Add("SIFEI")
    End Sub
    Private Sub RellenaCmbEstado()
        Dim objEstados As New NEstado()
        Dim lstEstados As New LEstado()
        lstEstados = objEstados.ObtenerEstadosClien(cadenaConex)
        With CmbEstado
            .DataSource = lstEstados
            .DisplayMember = "Estado"
            .ValueMember = "fol"
            .SelectedValue = ""
        End With
    End Sub
    Private Sub RellenaCmbCiudad(objEdo As Estado)
        Dim objCiudad As New NCiudad()
        Dim lstCiudad As New LCiudad()
        lstCiudad = objCiudad.ObtenerCiudadesClien(cadenaConex, objEdo)
        With CmbCiudad
            .DataSource = lstCiudad
            .DisplayMember = "Nombre"
            .ValueMember = "id"
            .SelectedValue = ""
        End With
    End Sub
    Private Sub RellenaCmbRegimenFiscal()
        Dim NSuc As New NSucursales()
        Dim lst As New LSucursales()
        lst = NSuc.ObtenerRegimen(cadenaConex)
        With CmbRegimen
            .DataSource = lst
            .DisplayMember = "Regimen"
            .ValueMember = "IdRegimen"
            .SelectedValue = ""
        End With

    End Sub
#End Region

#Region "Click BtnF3"
    Private Sub BtnF3_Click(sender As Object, e As EventArgs) Handles BtnF3.Click
        Dim Util As New PUtilerias()
        TxtLogo.Text = Util.BuscarRutaArchivo("GIF|*.gif|JPG|*.jpg")
    End Sub
    Private Sub BtnF3_1_Click(sender As Object, e As EventArgs) Handles BtnF3_1.Click
        Dim Util As New PUtilerias()
        If BtnF3_1.Location.Y + 1 = TxtUrlCSD.Location.Y Then
            TxtUrlCSD.Text = Util.BuscarRutaArchivo("CER|*.cer")
        ElseIf BtnF3_1.Location.Y + 1 = TxtUrlkey.Location.Y Then
            TxtUrlKey.Text = Util.BuscarRutaArchivo("KEY|*.key")
        End If
    End Sub
    Private Sub BtnF3_2_Click(sender As Object, e As EventArgs) Handles BtnF3_2.Click
        Dim Util As New PUtilerias()
        If BtnF3_2.Location.Y + 1 = TxtRutaOmision.Location.Y Then
            TxtRutaOmision.Text = Util.BuscarRutaCarpeta
        ElseIf BtnF3_2.Location.Y + 1 = TxtUrlReportes.Location.Y Then
            TxtUrlReportes.Text = Util.BuscarRutaCarpeta
        ElseIf BtnF3_2.Location.Y + 1 = TxtUrlPlantilla.Location.Y Then
            TxtUrlPlantilla.Text = Util.BuscarRutaCarpeta
        End If
    End Sub
#End Region

#Region "Mover BotonF3"
    Private Sub TxtLogo_Click(sender As Object, e As EventArgs) Handles TxtLogo.Click
        Dim Util As New PUtilerias()
        Util.UbicaBtnF3(TxtLogo, BtnF3)
    End Sub
    Private Sub TxtUrlCSD_Click(sender As Object, e As EventArgs) Handles TxtUrlCSD.Click
        Dim Util As New PUtilerias()
        Util.UbicaBtnF3(TxtUrlCSD, BtnF3_1)
    End Sub
    Private Sub TxtUrlKey_Click(sender As Object, e As EventArgs) Handles TxtUrlKey.Click
        Dim Util As New PUtilerias()
        Util.UbicaBtnF3(TxtUrlKey, BtnF3_1)
    End Sub
    Private Sub TxtRutaOmision_Click(sender As Object, e As EventArgs) Handles TxtRutaOmision.Click
        Dim Util As New PUtilerias()
        Util.UbicaBtnF3(TxtRutaOmision, BtnF3_2)
    End Sub
    Private Sub TxtUrlReportes_Click(sender As Object, e As EventArgs) Handles TxtUrlReportes.Click
        Dim Util As New PUtilerias()
        Util.UbicaBtnF3(TxtUrlReportes, BtnF3_2)
    End Sub
    Private Sub TxtUrlPlantilla_Click(sender As Object, e As EventArgs) Handles TxtUrlPlantilla.Click
        Dim Util As New PUtilerias()
        Util.UbicaBtnF3(TxtUrlPlantilla, BtnF3_2)
    End Sub
#End Region
    Private Sub CmbEstado_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbEstado.SelectionChangeCommitted
        Dim objEdo As New Estado

        CmbCiudad.Text = Nothing
        objEdo.Fol = CmbEstado.SelectedValue

        RellenaCmbCiudad(objEdo)
    End Sub
End Class