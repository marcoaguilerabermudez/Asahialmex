Imports System
Imports System.Net
Imports System.Net.Mail
Imports Negocio
Imports Clases
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Configuration


Public Class FrmSoporte
#Region "Variables de clase"
    Private usuario As Usuario
    Private cadenaConex As String
    Private imagen As Image
    Private imagen2 As Image
    Private imagen3 As Image

#End Region
#Region "Contructores"
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
#Region "Accionnes de Formulario"
    ''' <summary>
    ''' Al Abrir el Formulario
    ''' y manda a llamar los siguientes procedimientos
    ''' carga la lista de prioridades
    ''' el tipo de conexiones
    ''' el tipo de programa
    ''' el datagridview carga los tickets creados 
    ''' limpia los campos
    '''     ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmSoporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarPrioridad()
        RellenaConexion()
        RellenaPrograma()
        RellenaDvgSoporte()
        CleanSoporte()

    End Sub
    ''' <summary>
    ''' Este botón su funcion 
    '''  llama al funcion  validar y recibe true si cumple con los requerimientos y false  manda un mensaje
    '''   en caso de true manda a llamar al proceso insertaMess  
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If TextId.Tag <> Nothing Then
            InsertaMess()
        Else
            If validar() = True Then
                InsertaSoporte()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Proceso para insertar imagen
    ''' Boton manda llama a la galeria de imagenes
    ''' lo guarda en una lista de imagenes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes GIF|*.gif"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each url As String In dlg.FileNames
                ImageList1.Images.Add(Image.FromFile(url))
                If imagen Is Nothing Then
                    imagen = Image.FromFile(url)
                ElseIf imagen2 Is Nothing Then
                    imagen2 = Image.FromFile(url)
                ElseIf imagen3 Is Nothing Then
                    imagen3 = Image.FromFile(url)
                End If
                PictPrincipal.Image = Image.FromFile(url)
            Next
        End If
    End Sub

    ' Dim i As Integer
    ''' <summary>
    ''' Boton Elimina imagen seleccionada 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If RdImagen2.Checked Then
            ImageList1.Images.RemoveAt(Rdimagen.Checked)
            PictPrincipal.Image = Nothing
            '  My.Computer.FileSystem.DeleteFile("C:\Imagen.jpeg")
        ElseIf RdImagen3.Checked Then
            ImageList1.Images.RemoveAt(RdImagen2.Checked)
            PictPrincipal.Image = Nothing
        ElseIf Rdimagen.Checked Then
            ImageList1.Images.RemoveAt(RdImagen3.Checked)
            PictPrincipal.Image = Nothing
        End If

    End Sub
    ''' <summary>
    ''' boton de  Finalizar
    ''' verifica que el ticket seleccionado su estado sea "Revisado" para finalizar
    ''' y de lo contrario manda un mensaje
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs) Handles BtnFinalizar.Click
        If TextContraseña.Tag = "Revisado" Then
            FinTicket()
            MsgBox("Ticket  " & TextId.Tag & "  Finalizo con exito")
            RellenaDvgSoporte()
        Else
            MsgBox("Requiere Atención del Personal de Sistemas")
        End If
    End Sub
    ''' <summary>
    ''' Limita los digitos de texto id 
    ''' máximo 9 digitos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextId_TextChanged(sender As Object, e As EventArgs) Handles TextId.TextChanged
        TextId.MaxLength = 9
    End Sub
    ''' <summary>
    ''' Limita los digitos de texto contraseña del id
    ''' máximo 6 digitos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextContraseña_TextChanged(sender As Object, e As EventArgs) Handles TextContraseña.TextChanged
        TextContraseña.MaxLength = 6
    End Sub
    ''' <summary>
    ''' Botón Limpiar
    ''' llama al proceso CLeanSoporte
    ''' Vacia todo los campos del formulario
    ''' excepto datagridview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        CleanSoporte()
    End Sub

    Private Sub RellenaPicturBox()
        Dim soporte As New Soporte
        soporte = ObtenerImagenes(soporte)
        PictPrincipal.Image = soporte.Imagen
    End Sub
    Private Sub RadImagen_CheckedChanged(sender As Object, e As EventArgs) Handles Rdimagen.CheckedChanged
        Dim soporte As New Soporte
        If TextId.Tag <> Nothing Then
            soporte = ObtenerImagenes(soporte)
            PictPrincipal.Image = soporte.Imagen
        Else
            If ImageList1.Images.Count <> Nothing Then
                PictPrincipal.Image = ImageList1.Images(0)
            End If
        End If
    End Sub
    Private Sub RadImagen2_CheckedChanged(sender As Object, e As EventArgs) Handles RdImagen2.CheckedChanged
        Dim soporte As New Soporte
        If TextId.Tag <> Nothing Then
            soporte = ObtenerImagenes(soporte)
            PictPrincipal.Image = soporte.Imagen2
        Else
            If ImageList1.Images.Count <> Nothing Then
                PictPrincipal.Image = ImageList1.Images(0)
            End If
        End If
    End Sub
    Private Sub RadiImagen3_CheckedChanged(sender As Object, e As EventArgs) Handles RdImagen3.CheckedChanged
        Dim soporte As New Soporte
        If TextId.Tag <> Nothing Then
            soporte = ObtenerImagenes(soporte)
            PictPrincipal.Image = soporte.Imagen3
        Else
            If ImageList1.Images.Count <> Nothing Then
                PictPrincipal.Image = ImageList1.Images(0)
            End If
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvSoport_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvSoport.CellMouseClick
        BtnFinalizar.Enabled = True
        rellenarCampos()
        rellenarListSoporte()
        RellenaPicturBox()
    End Sub
    ''' <summary>
    ''' deja los  campos en vacio
    ''' </summary>
    Private Sub CleanSoporte()
        CombPrioridad.Text = ""
        CombConexion.Text = ""
        CombPrograma.Text = ""
        TextId.Text = ""
        TextId.Tag = ""
        TextContraseña.Text = ""
        RichTxtDescripción.Text = ""
        BtnFinalizar.Enabled = False
        ListView1.Items.Clear()
        PictBxCaptura1.Visible = False
        PictureBxCaptura2.Visible = False
        PictBxCaptura3.Visible = False
        PictPrincipal.Image = Nothing
        Label7.Text = ""
    End Sub
    ''' <summary>
    ''' Proceso para finalizar el ticket
    ''' declara dos objetos
    ''' un para rellenar el objeto soporte
    ''' y otro para llamar a la funcion y enviar los datos
    ''' </summary>
    Private Sub FinTicket()
        Dim negocio As New NSoporte
        Dim soporte As New Soporte
        soporte = RellenaInsertSoporte(soporte)
        negocio.FinalizaTicket(cadenaConex, soporte)
    End Sub
    ''' <summary>
    ''' Verifica que los campos no esten vacios al momento de insertar
    ''' </summary>
    ''' <returns></returns>
    Private Function validar() As Boolean
        If CombPrograma.Text = "" Then
            MsgBox("Debe seleccionar el Programa")
            Return False
        ElseIf CombPrioridad.Text = "" Then
            MsgBox("Debe seleccionar la prioridad del Ticket")
            Return False
        ElseIf CombConexion.Text = "" Then
            MsgBox("Debe seleccionar la  Conexión del Ticket")
            Return False
        ElseIf IsNumeric(TextId.Text) And TextId.Text = "" Then
            MsgBox("Debe escribir  el id del" & CombConexion.Text)
            Return False
        ElseIf RichTxtDescripción.Text = "" Then
            MsgBox("Debe  describir el problema")
            Return False
        Else
            Return True
        End If
    End Function
#End Region
#Region "Rellena "

    Private Sub rellenarListSoporte()
        Dim listSoporte As New LSoporte
        listSoporte = ObtenerComentario()
        ListView1.Items.Clear()

        For Each dato As Soporte In listSoporte
            With ListView1
                '.Columns.Add("usuario")
                '.Columns.Add("comentario")
                .Items.Add(dato.TipoComentario & "-------------")
                .Items.Add(dato.Descripcion)
            End With
        Next
    End Sub
    Private Sub rellenarCampos()
        CombPrograma.Text = DgvSoport.CurrentRow.Cells("Problema").Value
        CombPrioridad.Text = DgvSoport.CurrentRow.Cells("Prioridad").Value
        CombConexion.Text = DgvSoport.CurrentRow.Cells("Conexion").Value
        TextId.Tag = DgvSoport.CurrentRow.Cells("idTicket").Value
        TextId.Text = DgvSoport.CurrentRow.Cells("IdRemoto").Value
        TextContraseña.Text = DgvSoport.CurrentRow.Cells("contraseñaRemota").Value
        TextContraseña.Tag = DgvSoport.CurrentRow.Cells("Estado").Value
    End Sub

    ''' <summary>
    ''' llena el datagridview con la información recibida
    ''' se ocultan algunas columnas y se muestran las necesarias
    ''' </summary>
    Private Sub RellenaDvgSoporte()
        Dim listSoporte As New LSoporte
        listSoporte = ObtenerCorreo()
        DgvSoport.DataSource = listSoporte
        'oculta todas las columnas
        For i = 0 To DgvSoport.Columns.Count - 1
            DgvSoport.Columns(i).Visible = False
        Next
        '' Tamaño de la columna
        DgvSoport.Columns(0).Width = 50
        DgvSoport.Columns(1).Width = 90
        DgvSoport.Columns(5).Width = 120
        DgvSoport.Columns(9).Width = 78

        ' columnas que solo se muestran
        DgvSoport.Columns(0).Visible = True
        DgvSoport.Columns(1).Visible = True
        DgvSoport.Columns(5).Visible = True
        DgvSoport.Columns(9).Visible = True

    End Sub
    ''' <summary>
    ''' Le da Valores al combo llamdo prioridad
    ''' </summary>
    Private Sub RellenarPrioridad()
        With CombPrioridad
            .Items.Add("Alta")
            .Items.Add("Medio")
            .Items.Add("Bajo")
        End With
    End Sub
    ''' <summary>
    ''' le da valores al combo conexion
    ''' </summary>
    Private Sub RellenaConexion()
        With CombConexion
            .Items.Add("Team Viewer")
            .Items.Add("AnyDesk")
        End With
    End Sub
    ''' <summary>
    ''' Le da valores al combo Programa
    ''' </summary>
    Private Sub RellenaPrograma()
        With CombPrograma
            .Items.Add("SIA")
            .Items.Add("AdminPaq")
            .Items.Add("Office")
            .Items.Add("Pedidos")
            .Items.Add("Traspasos")
            .Items.Add("STatus de Ventas")
            .Items.Add("STatus de Almacen")
            .Items.Add("Correo Abasleal")
            .Items.Add("Instalación de Impresora")
        End With
    End Sub
    ''' <summary>
    '''  Recupera la sucursal del usuario 
    '''  Recupera si es admin 
    '''  Le da  valor a cada propiedades
    ''' </summary>
    ''' <returns></returns>
    Private Function RellenaInsertSoporte(ByVal Soporte As Soporte)
        Soporte.Prioridad = CombPrioridad.Text
        Soporte.Conexion = CombConexion.Text
        Soporte.IdRemoto = TextId.Text
        Soporte.ContraseñaRemota = TextContraseña.Text
        Soporte.Problema = CombPrograma.Text
        Soporte.fecha = DateTime.Now
        Soporte.Hora = Soporte.fecha.ToString("hh:mm:ss.fff")
        Soporte.Id_Usuario = usuario.Id
        Soporte.idSucursal = usuario.Suc
        Soporte.Estado = ""
        Soporte.TipoComentario = "Usuario"
        Soporte.Descripcion = RichTxtDescripción.Text
        Soporte.Atendio = ""
        Soporte.Imagen = imagen
        Soporte.Imagen2 = imagen2
        Soporte.Imagen3 = imagen3
        If TextId.Tag <> Nothing Then
            Soporte.idTicket = TextId.Tag
        End If
        Return Soporte
    End Function
#End Region
#Region "Obtener"

    ''' <summary>
    ''' Esta funcion recibe la informacion de la lista 
    ''' envia el Id del usario
    ''' </summary>
    ''' <returns></returns>
    Private Function ObtenerCorreo()
        Dim objNegocio As New NSoporte
        Dim objDato As New Soporte
        Return objNegocio.ObtenerListaTicket(cadenaConex, usuario.Id)
    End Function

    ''' <summary>
    ''' Esta funcion  obtiene los mensajes de cada ticket
    ''' envia el id del ticket al proceso ObtenerMess
    ''' hace conexion
    ''' </summary>
    ''' <returns></returns>
    Private Function ObtenerComentario()
        Dim objNegocio As New NSoporte
        Dim objDato As New Soporte
        Return objNegocio.ObtnerMesse(cadenaConex, TextId.Tag)
    End Function

    Private Function ObtenerImagenes(soporte As Soporte)
        Dim negocio As New NSoporte
        Return negocio.obteneImagen(cadenaConex, TextId.Tag, soporte)

    End Function
#End Region
#Region "Insertar"
    ''' <summary>
    ''' Proceso de Inserción de un ticket
    ''' declara dos variables 
    ''' una para llamar la funcion y hacer conexion
    ''' la segunda para cargar los datos que seran insertados
    '''  </summary>
    Private Sub InsertaSoporte()
        Dim objNegocio As New NSoporte
        Dim Soporte As New Soporte
        Soporte = RellenaInsertSoporte(Soporte)
        objNegocio.InsertSuport(cadenaConex, Soporte)
        CleanSoporte()
        RellenaDvgSoporte()

    End Sub

    ''' <summary>
    ''' Proceso de Insertar Mensajes al ticket correspondiente
    ''' llama a la funcion rellena el objeto con datos
    '''  hace conexión
    '''  envia la informacion a la funcion InsertarMess 
    ''' </summary>
    Private Sub InsertaMess()
        Dim Negocio As New NSoporte
        Dim soporte As New Soporte()
        soporte = RellenaInsertSoporte(soporte)
        Negocio.InsertarMess(cadenaConex, soporte)
        rellenarListSoporte()
    End Sub
#End Region
End Class
