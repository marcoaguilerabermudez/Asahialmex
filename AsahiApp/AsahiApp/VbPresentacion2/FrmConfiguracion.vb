Imports Negocio
Imports Clases
Imports System.Configuration
Imports System.Windows.Forms
Imports System.IO

Public Class FrmConfiguracion
#Region "Variables de clase"
    Private cadenaConex As String
    Private cadenaConexLeal As String
    Private idSucursal As Integer = "8" 'temporal
#End Region
#Region "Constructores"
    Sub New(ByVal usuario As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        '' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex

    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
#End Region
#Region "Eventos Iniciales del Formulario"
    Private Sub FrmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FindCadena()
        RellenoSuc()
        BtnKey.Visible = False
        BtnCd.Visible = False
        RellenoConfig()
        RellenarCombVersion()
        RellenarCombPac()
        If CmbRegimen.Text = "" Then
            rellenaCmbRegimen()
        ElseIf CmbEstado.Text = "" Then
            rellenarCmbEstado()
        ElseIf CmbCiudad.Text = "" Then
            rellenarCmbCiudad()
        End If

    End Sub
    Public Sub FindCadena()
        Me.cadenaConexLeal = ConfigurationManager.ConnectionStrings("Leal").ConnectionString
    End Sub
#End Region
#Region "Rellenar Objetos"
    Private Function RellenaConfiguracion() As Configuracion
        Dim configuracion As New Configuracion
        configuracion.IVA = TxtIVA.Text
        configuracion.IEPS = TxtIEPS.Text
        configuracion.RetencionISR = TxtRetencionISR.Text
        configuracion.RetencionIVA = TxtRetencionIVA.Text
        configuracion.UrlKey = TxtNSerie.Text
        configuracion.UrlCsd = TxtCer.Text
        configuracion.VigenciaInicio = TxtVdesde.Text
        configuracion.VigenciaFin = TxtVhasta.Text
        configuracion.PasswordCSD = TxtPasswordCer.Text
        configuracion.Confirmarpassword = TxtConfirma.Text
        configuracion.VersionCFDI = CmbVersionCFDI.Text
        configuracion.CantidadFilas = TxtControlFILAS.Text
        configuracion.UrlReportes = TxtDirectReportes.Text
        configuracion.UrlPlantilla = TxtRutaPlantillas.Text
        configuracion.UrlOmision = TxtRutaOmision.Text
        configuracion.Prefijo = TxtPrefijo.Text
        configuracion.ServidorPOP3 = TxtServidorPop3.Text
        configuracion.ServidorSMTP = TxtServidorPop3.Text
        configuracion.PuertoPOP3 = TxtPuertPOP3.Text
        configuracion.PuertoSMTP = TxtPuertoSMTP.Text
        configuracion.Correo = TextUsuario.Text
        configuracion.PasswordCorreo = TextPasswordCorreo.Text
        configuracion.Asunto = TxtAsunto.Text
        configuracion.Mensaje = RichtxtMensaje.Text
        configuracion.IdConfig = TxtRazSocial.Tag
        If ChecConexionSegura.Checked = True Then
            configuracion.ConexionSegura = True
        Else
            configuracion.ConexionSegura = False
        End If
        If checkMetodoP.Checked = True Then
            configuracion.UsarMetodoPrueba = True
        Else
            configuracion.UsarMetodoPrueba = False
        End If
        If CheckEnvioAutomatico.Checked = True Then
            configuracion.EnvioAutomatico = True
        Else
            configuracion.EnvioAutomatico = False
        End If
        VerificarConfiguracion()
        Return configuracion
    End Function
    Private Function RellenaSucursal() As Sucursales
        Dim sucursal As New Sucursales
        sucursal.RazonSocial = TxtRazSocial.Text
        sucursal.RFC = TxtRFC.Text
        sucursal.LugarExpedicion = TxtLugarExpedicion.Text
        sucursal.Calle = TxtCalle.Text
        sucursal.Colonia = TextColonia.Text
        sucursal.IdRegimen = CmbRegimen.Tag
        sucursal.Municipio = TextMunicipio.Text
        sucursal.IdEstado = CmbEstado.Tag
        sucursal.IdCiudad = CmbCiudad.Tag
        sucursal.NumExt = TextNumExt.Text
        sucursal.NumInt = TextInterior.Text
        sucursal.UrlLogo = TxtLogo.Text
        sucursal.CodigoPostal = TextCP.Text
        sucursal.Tel1 = TextTEL1.Text
        sucursal.Tel2 = TextTEL2.Text
        sucursal.Tel3 = TextTEL3.Text
        sucursal.IdSuc = idSucursal

        Return sucursal
    End Function
    Private Sub RellenoConfig()
        Dim configuracion As New Configuracion
        configuracion = ObtenerConfiguracion()
        TxtIVA.Text = configuracion.IVA
        TxtIEPS.Text = configuracion.IEPS
        TxtRetencionISR.Text = configuracion.RetencionISR
        TxtRetencionIVA.Text = configuracion.RetencionIVA
        TxtNSerie.Text = configuracion.UrlKey
        TxtCer.Text = configuracion.UrlCsd
        TxtVdesde.Text = configuracion.VigenciaInicio
        TxtVhasta.Text = configuracion.VigenciaInicio
        TxtPasswordCer.Text = configuracion.PasswordCSD
        CmbVersionCFDI.Text = configuracion.VersionCFDI
        TxtControlFILAS.Text = configuracion.CantidadFilas
        TxtDirectReportes.Text = configuracion.UrlReportes
        TxtRutaPlantillas.Text = configuracion.UrlPlantilla
        TxtRutaOmision.Text = configuracion.UrlOmision
        TxtPrefijo.Text = configuracion.Prefijo
        TxtServidorPop3.Text = configuracion.ServidorPOP3
        TxtServidorSMTP.Text = configuracion.ServidorSMTP
        TxtPuertPOP3.Text = configuracion.PuertoPOP3
        TxtPuertoSMTP.Text = configuracion.PuertoSMTP
        TextUsuario.Text = configuracion.Correo
        TextPasswordCorreo.Text = configuracion.PasswordCorreo
        CmbPAC.Text = configuracion.PAC
        TextDireccionFTP.Text = configuracion.DireccionFTP
        TxtIdFTP.Text = configuracion.IdFTP
        TxtPasswordFTP.Text = configuracion.PasswordFTP
        TxtAsunto.Text = configuracion.Asunto
        RichtxtMensaje.Text = configuracion.Mensaje
    End Sub
    Private Sub RellenoSuc()
        Dim sucursal As New Sucursales
        sucursal = ObtenerSuc()
        TxtRazSocial.Tag = sucursal.IdConfig
        CmbCiudad.Tag = sucursal.IdCiudad
        CmbRegimen.Tag = sucursal.IdRegimen
        CmbEstado.Tag = sucursal.IdEstado
        TxtRazSocial.Text = sucursal.RazonSocial
        TxtLugarExpedicion.Text = sucursal.LugarExpedicion
        TxtRFC.Text = sucursal.RFC
        TextColonia.Text = sucursal.Colonia
        TxtCalle.Text = sucursal.Calle
        TextNumExt.Text = sucursal.NumExt
        TextInterior.Text = sucursal.NumInt
        CmbCiudad.Text = sucursal.Ciudad
        CmbEstado.Text = sucursal.Estado
        TextMunicipio.Text = sucursal.Municipio
        TextCP.Text = sucursal.CodigoPostal
        TextTEL1.Text = sucursal.Tel1
        TextTEL2.Text = sucursal.Tel2
        TextTEL3.Text = sucursal.Tel3
        TxtLogo.Text = sucursal.UrlLogo
        CmbRegimen.Text = sucursal.Regimen
    End Sub
    Private Sub rellenaCmbRegimen()
        Dim listRegimen As New LRegimen
        listRegimen = ObtenerRegimen()
        With CmbRegimen
            .DataSource = listRegimen
            .ValueMember = "regimen"
            .DisplayMember = "id"
        End With
    End Sub

    Private Sub rellenarCmbEstado()
        Dim listEstado As New LEstado
        Dim estado As New Estado
        listEstado = ObtenerEstado()
        With CmbEstado
            .DataSource = listEstado
            .ValueMember = "estado"
            .DisplayMember = "idEstado"
        End With
    End Sub

    Private Sub rellenarCmbCiudad()
        Dim listCiudad As New LCiudad
        listCiudad = ObtenerCiudad()
        With CmbCiudad
            .DataSource = listCiudad
            .ValueMember = "Ciudad"
            .DisplayMember = "idCiudad"
        End With
    End Sub

#End Region
#Region "TextBox Click"
    Private Sub TxtNSerie_Click(sender As Object, e As EventArgs) Handles TxtNSerie.Click
        BtnKey.Visible = True
    End Sub
    Private Sub TxtCer_Click(sender As Object, e As EventArgs) Handles TxtCer.Click
        BtnCd.Visible = True
    End Sub
#End Region
#Region "Rellenar Combobox"
    Private Sub RellenarCombVersion()
        With CmbVersionCFDI
            .Items.Add("3.3")
        End With
    End Sub
    Private Sub RellenarCombPac()
        With CmbPAC
            .Items.Add("FACTURANET")
        End With
    End Sub

#End Region
#Region "Botones"
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Valida() = True Then
            ConfiguracionInsertar()
        End If
    End Sub
    Private Sub BtnLogo_Click(sender As Object, e As EventArgs) Handles BtnLogo.Click
        Dim utilerias As New PUtilerias
        TxtLogo.Text = utilerias.BuscarRutaArchivo("Imagen|*.jpg")
    End Sub
    Private Sub BtnKey_Click(sender As Object, e As EventArgs) Handles BtnKey.Click
        Dim utilerias As New PUtilerias
        TxtNSerie.Text = utilerias.BuscarRutaArchivo("KEY|*.key")
        BtnKey.Visible = False
    End Sub
    Private Sub BtnOmision_Click(sender As Object, e As EventArgs) Handles BtnOmision.Click
        Dim utilerias As New PUtilerias
        TxtRutaOmision.Text = utilerias.BuscarRutaCarpeta
    End Sub
    Private Sub BtnPlantilla_Click(sender As Object, e As EventArgs) Handles BtnPlantilla.Click
        Dim utilerias As New PUtilerias
        TxtRutaPlantillas.Text = utilerias.BuscarRutaArchivo("XML|*.xml")
    End Sub
    Private Sub BtnCd_Click(sender As Object, e As EventArgs) Handles BtnCd.Click
        Dim utilerias As New PUtilerias
        TxtCer.Text = utilerias.BuscarRutaArchivo("Certificado|*.cer")
        BtnCd.Visible = False
    End Sub
    Private Sub BtnDirectReport_Click(sender As Object, e As EventArgs) Handles BtnDirectReport.Click
        Dim utilerias As New PUtilerias
        TxtDirectReportes.Text = utilerias.BuscarRutaCarpeta
    End Sub
#End Region
#Region "Validaciones"
    Private Function Valida()
        If TxtRazSocial.Text = "" Then
            MsgBox("Debe escribir la Razon Social")
            Return False
        ElseIf TxtLugarExpedicion.Text = "" Then
            MsgBox("Debe escribi el Lugar de expedición")
            Return False
        ElseIf TxtRFC.Text = "" Then
            MsgBox("Debe escribi el RFC")
            Return False
        ElseIf TextColonia.Text = "" Then
            MsgBox("Debe escribi la colonia")
            Return False
        ElseIf TxtCalle.Text = "" Then
            MsgBox("Debe escribi la calle")
            Return False
        ElseIf CmbCiudad.Text = "" Then
            MsgBox("Debe escribi la Ciudad")
            Return False
        ElseIf CmbEstado.Text = "" Then
            MsgBox("Debe escribi el Estado")
            If CmbEstado.Text = "" Then
                rellenaCmbRegimen()
            End If
            Return False
        ElseIf TextMunicipio.Text = "" Then
            MsgBox("Debe escribi el Municipio")
            Return False
        ElseIf TextCP.Text = "" Then
            MsgBox("Debe escribi el Codigo Postal")
            Return False
        ElseIf TextTEL1.Text = "" Then
            MsgBox("Debe escribi un numero de Telefono")
            Return False
        ElseIf CmbRegimen.Text = "" Then
            MsgBox("Debe selecciona el Regimen")
            If CmbRegimen.Text = "" Then
                rellenaCmbRegimen()
            End If
            Return False
        ElseIf TxtIVA.Text = "" Then
            MsgBox("Debe escribi el IVA")
            Return False
        ElseIf TxtIEPS.Text = "" Then
            MsgBox("Debe escribi el IEPS")
            Return False
        ElseIf TxtNSerie.Text = "" Then
            MsgBox("Debe seleccionar la LLave digital")
            Return False
        ElseIf TxtCer.Text = "" Then
            MsgBox("Debe  seleccionar el certificado Digital")
            Return False
        ElseIf TxtVdesde.Text = "" Then
            MsgBox("Debe escribi la fecha  de inicio")
            Return False
        ElseIf TxtVhasta.Text = "" Then
            MsgBox("Debe escribi la fecha de finalización")
            Return False
        ElseIf TextPasswordCorreo.Text = "" Then
            MsgBox("Debe escribir la contraseña en Certificado")
            Return False
        ElseIf TxtConfirma.Text = "" Then
            MsgBox("Debe confirma la contraseña de Certificado")
            Return False
        ElseIf CmbVersionCFDI.Text = "" Then
            MsgBox("Debe seleccionar la Version")
            Return False
        ElseIf TxtControlFILAS.Text = "" Then
            MsgBox("Debe escribir el Numero de filas")
            Return False
        ElseIf TxtDirectReportes.Text = "" Then
            MsgBox("Debe seleccionar el directorio Reportes ")
            Return False
        ElseIf TxtRutaPlantillas.Text = "" Then
            MsgBox("Debe seleccionar la Ruta de la Plantilla")
            Return False
        ElseIf TxtRutaOmision.Text = "" Then
            MsgBox("Debe seleccionar la Ruta de Archivo")
            Return False
        ElseIf TxtPrefijo.Text = "" Then
            MsgBox("Debe escribir el Nombre del Archivo")
            Return False
        ElseIf TxtServidorPop3.Text = "" Then
            MsgBox("Debe escribir el Nombre del Servidor POP3 ")
            Return False
        ElseIf TxtServidorSMTP.Text = "" Then
            MsgBox("Debe escribir  el Nombre del Servidor SMTP ")
            Return False
        ElseIf TxtPuertoSMTP.Text = "" Then
            MsgBox("Debe escribir  el Puerto POP3 ")
            Return False
        ElseIf TxtPuertoSMTP.Text = "" Then
            MsgBox("Debe escribir el Puerto SMTP ")
            Return False
        ElseIf TextUsuario.Text = "" Then
            MsgBox("Debe escribir el Correo")
            Return False
        ElseIf TextPasswordCorreo.Text = "" Then
            MsgBox("Debe escribi  el Nombre del Servidor SMTP ")
            Return False
        ElseIf CmbPAC.Text = "" Then
            MsgBox("Debe seleccionar Pac ")
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#Region "Procesos Varios"
    Private Sub VerificarConfiguracion()
        If TxtPasswordCer.Text = TxtConfirma .Text Then
        Else
            MsgBox("No coincide la contraseña")
        End If
    End Sub
    Private Sub ConfiguracionInsertar()
        Dim negocio As New NConfiguracion
        Dim configuracion As New Configuracion
        Dim sucursal As New Sucursales
        configuracion = RellenaConfiguracion()
        sucursal = RellenaSucursal()
        negocio.InsertaConfiguracion(cadenaConexLeal, configuracion, sucursal)
    End Sub
    Private Function ObtenerSuc() As Sucursales
        Dim negocio As New NSucursales
        Return negocio.ObtenerSucursal(cadenaConexLeal, "8")
    End Function
    Private Function ObtenerConfiguracion() As Configuracion
        Dim negocio As New NConfiguracion
        Dim sucursales As New Sucursales
        Return negocio.ObtenerConfig(cadenaConexLeal, TxtRazSocial.Tag)
    End Function

    Private Function ObtenerRegimen()
        Dim negocio As New NSucursales
        Dim lista As New LRegimen
        lista = negocio.ObtenerRegimen(cadenaConexLeal)
        Return lista
    End Function


    Private Function ObtenerEstado()
        Dim negocio As New NCiudad
        Dim lista As New LEstado
        lista = negocio.ObtenerEstado(cadenaConexLeal)
        Return lista
    End Function

    Private Function ObtenerCiudad()
        Dim negocio As New NCiudad
        Dim lista As New LCiudad
        Dim estado As New Estado
        estado = CmbEstado.SelectedItem
        lista = negocio.ObtenerCiudad(cadenaConex, estado.IdEdo)
        Return lista
    End Function


#End Region
End Class



