
Imports Clases
Imports System
Imports System.Configuration
Imports Negocio


Public Class FrmStatusSoporte
#Region "Variables"
    Private usuario As Usuario
    Private cadenaConex As String
#End Region
#Region "Constructor"
    Sub New(ByVal usuario As Usuario, ByVal cadenaConex As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.usuario = usuario
        Me.cadenaConex = cadenaConex
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
#End Region
#Region "Acciones del Formulario"
    ''' <summary>
    ''' Al  abrir el  formulario se carga 
    ''' La lista de tickets 
    ''' limpiara los campos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmStatusSoporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenaDgvTicket()
        cleanTicket()
    End Sub
    ''' <summary>
    ''' Este proceso es un seleccionador del datagridview 
    ''' para obtener la información seleccionada
    '''  llama al proceso rellenarCampos
    '''  llama al proceso rellenarListSoporte
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvStatuSoporte_SelectionChanged(sender As Object, e As EventArgs) Handles DgvStatuSoporte.SelectionChanged
        rellenarCampos()
        rellenarListSoporte()
        RellenaPictureBox()
        BtnMessenger.Enabled = True
    End Sub
    ''' <summary>
    ''' Proceso Inserta los Mensajes en el status de tickets
    ''' declara dos objetos
    ''' uno donde llama al clase Negocios para realizar la conexion
    ''' el segundo para obtener información de la funcion RellenaMessSoport
    ''' hace conexion y envia los información
    ''' </summary>
    Private Sub InsertaMensajeEStatus()
        Dim negocio As New NSoporte
        Dim soporte As New Soporte()
        soporte = RellenaMensajesSoporte(soporte)
        negocio.InsertarMess(cadenaConex, soporte)

    End Sub
    ''' <summary>
    '''  al dar clic llamara al 2 procesos
    '''  uno para llamar al proceso y  ser la insercion del mensaje
    '''  segundo para llamar al proceso y actualizar la información del datagridview 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnMessenger_Click(sender As Object, e As EventArgs) Handles BtnMessenger.Click
        If validar() = True Then
            If RichTxtMessenger.Tag = "En espera" Then
                RevisaTicket()
                RellenaDgvTicket()
                InsertaMensajeEStatus()
                rellenarListSoporte()
                RellenaDgvTicket()
            ElseIf RichTxtMessenger.Tag = "Revisado" Then
                InsertaMensajeEStatus()
                rellenarListSoporte()
            ElseIf RichTxtMessenger.Tag = "Finalizado" Then
                MsgBox("EL Ticket  " & LblMessenger.Tag & "  ya esta Finalizado ")
            Else
                MsgBox("Error 52, No puede ser REVISADO")
            End If
        End If
    End Sub
    ''' <summary>
    ''' proceso para revisar
    ''' declara dos objetos
    ''' un para llamar al clase negocio y hacer conexión
    ''' segundo para llamar al proceso RellenaMenssSoport 
    ''' carga información y lo envia
    ''' </summary>
    Private Sub RevisaTicket()
        Dim negocio As New NSoporte
        Dim soporte As New Soporte
        soporte = RellenaMensajesSoporte(soporte)
        negocio.RevisarTicket(cadenaConex, soporte)
    End Sub
    Private Sub RadImagen2_CheckedChanged(sender As Object, e As EventArgs) Handles RadImagen2.CheckedChanged
        Dim soporte As New Soporte
        soporte = obtenerImagen(soporte)
        PictEstatusSoporte.Image = soporte.Imagen2
    End Sub
    Private Sub RadiImagen3_CheckedChanged(sender As Object, e As EventArgs) Handles RadiImagen3.CheckedChanged
        Dim soporte As New Soporte
        soporte = obtenerImagen(soporte)
        PictEstatusSoporte.Image = soporte.Imagen3
    End Sub
    Private Sub PictEstatusSoporte_Click(sender As Object, e As EventArgs) Handles PictEstatusSoporte.Click
        Dim frmCaptura As New FrmImagen(PictEstatusSoporte.Image)
        frmCaptura.Show()
    End Sub
    Private Sub RadImagen_CheckedChanged(sender As Object, e As EventArgs) Handles RadImagen.CheckedChanged
        Dim soporte As New Soporte
        soporte = obtenerImagen(soporte)
        PictEstatusSoporte.Image = soporte.Imagen
    End Sub
    ''' <summary>
    ''' Deja los campos en vacio
    ''' </summary>
    Private Sub cleanTicket()
        LblMessenger.Tag = ""
        ListMessenger.Text = ""
        ListMessenger.Items.Clear()
        BtnMessenger.Enabled = False
    End Sub
    ''' <summary>
    ''' verifica si describio la solución
    ''' de lo contrario envia un mensaje
    ''' </summary>
    ''' <returns></returns>
    Private Function validar() As Boolean
        If RichTxtMessenger.Text = "" Then
            MsgBox("Debes Describir la Solución del ticket " & LblMessenger.Tag)
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#Region "OBTENER"
    ''' <summary>
    '''  Esta función carga la lista de tickets
    '''  llama a la funcion Obtenerticket 
    '''  hace conexión
    ''' </summary>
    ''' <returns></returns>
    Private Function ObtenerTicket() As LSoporte
        Dim negocio As New NSoporte
        Return negocio.ObtnerTicket(cadenaConex)
    End Function
    ''' <summary>
    ''' Esta función se encarga de enviar el id del ticket
    ''' para si traer los mensajes de ticket especifico
    ''' llama al función ObtenerMess y hace la conexion
    ''' </summary>
    ''' <returns></returns>
    Private Function ObtenerComentario()
        Dim objNegocio As New NSoporte
        Return objNegocio.ObtenerMessegerStatus(cadenaConex, LblMessenger.Tag)
    End Function

    Private Function ObtenerImagen(soporte As Soporte) As Soporte
        Dim negocio As New NSoporte
        Return negocio.obteneImagen(cadenaConex, LblMessenger.Tag, soporte)
    End Function
#End Region
#Region "RELLENAR"

    ''' <summary>
    ''' Este proceso llena el datagridview
    ''' llama al proceso obtenerTicket para obtener la información
    ''' y asi mostrarla
    ''' se oculta columnas y se muestra las necesarias
    ''' </summary>
    Private Sub RellenaDgvTicket()
        Dim listTicket As New LSoporte
        listTicket = ObtenerTicket() 'OBTINE INFORMACIÓN 
        DgvStatuSoporte.DataSource = listTicket  'LLENA EL DATAGRIDVIEW

        For i = 0 To DgvStatuSoporte.Columns.Count - 1
            DgvStatuSoporte.Columns(i).Visible = False
        Next

        DgvStatuSoporte.Columns(0).Width = 50
        DgvStatuSoporte.Columns(4).Width = 73
        DgvStatuSoporte.Columns(0).Visible = True
        DgvStatuSoporte.Columns(1).Visible = True
        DgvStatuSoporte.Columns(4).Visible = True
        DgvStatuSoporte.Columns(5).Visible = True
        DgvStatuSoporte.Columns(6).Visible = True
        DgvStatuSoporte.Columns(7).Visible = True
        DgvStatuSoporte.Columns(8).Visible = True
        DgvStatuSoporte.Columns(9).Visible = True
        DgvStatuSoporte.Columns(10).Visible = True
    End Sub

    ''' <summary>
    ''' Esta Función envia la propiedades 
    ''' con su contenido
    ''' </summary>
    ''' <param name="Soporte"></param>
    ''' <returns></returns>
    Private Function RellenaMensajesSoporte(ByVal Soporte As Soporte)
        If LblMessenger.Tag <> Nothing Then
            Soporte.idTicket = LblMessenger.Tag
        End If
        Soporte.Id_Usuario = usuario.Id
        Soporte.idSucursal = usuario.Suc
        Soporte.Descripcion = RichTxtMessenger.Text
        Return Soporte
    End Function
    ''' <summary>
    '''Este proceso obtiene  la información 
    '''y llena la información en una listView 
    ''' </summary>
    Private Sub RellenarListSoporte()
        Dim listSoporte As New LSoporte
        listSoporte = ObtenerComentario()
        ListMessenger.Items.Clear()

        For Each dato As Soporte In listSoporte
            With ListMessenger
                '.Columns.Add("usuario")
                '.Columns.Add("comentario")
                .Items.Add(dato.TipoComentario & "-------------")
                .Items.Add(dato.Descripcion)
            End With
        Next
    End Sub
    ''' <summary>
    ''' Llena los campos con los datos especificados
    ''' al selecciona el datagridview
    ''' </summary>
    Private Sub RellenarCampos()
        LblMessenger.Tag = DgvStatuSoporte.CurrentRow.Cells("idTicket").Value
        RichTxtMessenger.Tag = DgvStatuSoporte.CurrentRow.Cells("Estado").Value
    End Sub
    Private Sub RellenaPictureBox()
        Dim soporte As New Soporte
        soporte = ObtenerImagen(soporte)
        PictEstatusSoporte.Image = soporte.Imagen
    End Sub


#End Region
End Class