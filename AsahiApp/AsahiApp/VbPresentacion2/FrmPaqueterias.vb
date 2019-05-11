Imports Clases
Imports System.Configuration
Imports Negocio
Imports System.Windows.Forms

Public Class FrmPaqueterias
    Private usuario As String
    Private cadenaConex As String
    Sub New(ByVal usuario As Integer, ByVal cadenaConex As String)

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
    ''' <summary>
    ''' HACE CONEXIO Y RECIBE LA LISTA DE PAQUETERIA DE LA CLASE NEGOCIO 
    ''' </summary>
    ''' <returns></returns>
    Public Function ObtenerPaq() As LPaqueteria
        Dim objNegocio As New NPaqueteria
        Return objNegocio.ObtenerPaqid(cadenaConex)
    End Function
    ''' <summary>
    ''' LLENA EL DATAGRIDVIEW DE LA INFORMACIÓN OBTENIDA Y ESTABLECE LAS MEDIDAS DE LAS COLUMNAS
    ''' ''' </summary>
    Private Sub LlenaDgvPaq()
        Dim listPaq As New LPaqueteria
        listPaq = ObtenerPaq()
        DgvPaqueteria.DataSource = listPaq
        DgvPaqueteria.Columns(0).ReadOnly = True
        DgvPaqueteria.Columns(1).ReadOnly = True
        DgvPaqueteria.Columns(2).ReadOnly = True
        DgvPaqueteria.Columns(0).Width = 30
        DgvPaqueteria.Columns(1).Width = 80
        DgvPaqueteria.Columns(2).Width = 250
        DgvPaqueteria.Columns(3).Visible = False
        DgvPaqueteria.Columns(4).Visible = False
        DgvPaqueteria.Columns(5).Visible = False
        DgvPaqueteria.Columns(6).Visible = False


    End Sub
    ''' <summary>
    '''  CARGA INFORMACIÓN EN EL DATAGRIDVIEW AL MOMENTO DE INICIAR EL FORMULARIO
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub FrmPaqueterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaDgvPaq()
        cleanPaq()
    End Sub
    ''' <summary>
    ''' LIMPIA LOS CAMPOS 
    ''' </summary>
    Private Sub cleanPaq()
        TextNombre.Text = ""
        TextNombreC.Text = ""
        TexTelf1.Text = ""
        TexTelf2.Text = ""
        TextContac.Text = ""
        TextConvenio.Text = ""
        BtnEliminar.Enabled = False
        BtnModifica.Enabled = False

    End Sub
    ''' <summary>
    ''' RELLENA LOS CAMPOS PARA INSERTAR
    ''' </summary>
    ''' <returns></returns>
    Private Function rellenaInsertPaq()
        Dim objPaq As New Paqueteria
        objPaq.Nombre = TextNombre.Text
        objPaq.NombreCorto = TextNombreC.Text
        objPaq.TelPaq1 = TexTelf1.Text
        objPaq.TelPaq2 = TexTelf2.Text
        objPaq.ContactoPaq = TextContac.Text
        objPaq.NoConvenio = TextConvenio.Text

        If TextNombre.Tag <> Nothing Then ' SI ID CONTIENE INFORMACIÓN, LO LLENA
            objPaq.IdPaq = TextNombre.Tag
        End If
        Return objPaq
    End Function
    ''' <summary>
    ''' PROCESO DE INSERTAR
    ''' RELLENA EL OBJETOPAQUETERIA
    ''' ENVIA LA INFORMACION A PROCESO INSERTARPAQ
    ''' E INSERTA
    ''' </summary>

    Private Sub InsertPaq()
        Dim objNegocio As New NPaqueteria
        Dim objPaq As New Paqueteria
        objPaq = rellenaInsertPaq()
        objNegocio.InsertarPaq(cadenaConex, objPaq)

    End Sub
    ''' <summary>
    ''' RECIBE TRUE SI CONTIENE INFORMACION
    ''' LLAMA AL PROCESO INSERTAR
    ''' DE LO CONTRARIO  SE CIERRA
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If validar() = True Then
            InsertPaq()
            LlenaDgvPaq()
        End If

    End Sub
    ''' <summary>
    ''' 'VALIDA SI NOMBRE, EL NOMBRE CORTE CONTIENE INFORMACIÓN 
    ''' ENVIA TRUE
    ''' DE LO CONTRARIO ENVIA FALSE Y UN MENSAJE
    ''' </summary>
    ''' <returns></returns>
    Private Function validar() As Boolean
        If TextNombre.Text = "" Then
            MsgBox("Para dar de alta una paquetería, es necesario escribir el NOMBRE")
            Return False
        ElseIf TextNombreC.Text = "" Then
            MsgBox("Para dar de alta una paquetería, es necesario escribir el NOMBRE CORTO")
            Return False
        Else
            Return True
        End If

    End Function
    ''' <summary>
    ''' PROCESO DE MODFICAR
    ''' RELLENA EL OBJETO PAQUETERIA
    ''' HACE CONEXION
    '''  ENVIA AL PROCESO MODIFICAPAQ
    ''' </summary>
    ''' <returns></returns>
    Private Function ModificarPaq()
        Dim obNegocio As New NPaqueteria
        Dim objPaq As New Paqueteria
        objPaq = rellenaInsertPaq()
        obNegocio.ModificaPaq(cadenaConex, objPaq)
        Return objPaq
    End Function
    ''' <summary>
    ''' ENVIA MENSAJE PARA CORROBORAR Y ES ASI
    ''' LLAMA AL PROCESO Y MUESTRA EL CAMBIO
    ''' DE LO CONTRARIO SE CIERRa
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnModifica_Click(sender As Object, e As EventArgs) Handles BtnModifica.Click
        Dim result As String
        result = MsgBox("¿Deseas permitir que  este programa realice cambios en la paquetería seleccionada?", vbYesNo + vbQuestion, "Advertencia")
        If result = vbYes Then
            ModificarPaq()
            LlenaDgvPaq()
        End If

    End Sub
    ''' <summary>
    ''' RELLENA LOS CAMPOS DE TEXTOS LO SELECCIONADO
    ''' </summary>
    Private Sub rellenaInfPaq()
        TextNombre.Text = DgvPaqueteria.CurrentRow.Cells("Nombre").Value
        TextNombre.Tag = DgvPaqueteria.CurrentRow.Cells("IdPaq").Value
        TextNombreC.Text = DgvPaqueteria.CurrentRow.Cells("NombreCorto").Value
        TexTelf1.Text = DgvPaqueteria.CurrentRow.Cells("TelPaq1").Value
        TexTelf2.Text = DgvPaqueteria.CurrentRow.Cells("TelPaq2").Value
        TextContac.Text = DgvPaqueteria.CurrentRow.Cells("ContactoPaq").Value
        TextConvenio.Text = DgvPaqueteria.CurrentRow.Cells("NoConvenio").Value


    End Sub
    ''' <summary>
    ''' LLAMA AL PROCESO PARA LLENAR LOS CAMPOS
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvPaqueteria_SelectionChanged(sender As Object, e As EventArgs) Handles DgvPaqueteria.SelectionChanged
        rellenaInfPaq()
        BtnEliminar.Enabled = True ' HABILITA EL BOTÓN ELIMINAR
        BtnModifica.Enabled = True ' HABILITA EL BOTÓN MODIFICAR
    End Sub
    ''' <summary>
    ''' PROCESO DE ELIMINACIÓN
    ''' RELLENA LA INFORMACIÓN EN UN OBJETOPAQ
    ''' Y LO ENVIA AL PROCESO RELLENAINSERTPAQ
    ''' ELIMINA
    ''' </summary>
    ''' <returns></returns>
    Private Function EliminarPaq()
        Dim obNegocio As New NPaqueteria
        Dim objPaq As New Paqueteria
        objPaq = rellenaInsertPaq()
        obNegocio.EliminaPaq(cadenaConex, objPaq)
        Return objPaq
    End Function
    ''' <summary>
    ''' ENVIA UN MENSAJE PARA CORROBORAR
    ''' LLAMA AL PROCESO PARA SER ELIMINADO
    ''' MUESTRA MODIFICACIONES
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim result As String
        result = MsgBox("¿Esta seguro que desea Eliminar permanentemente el elemento especificado de la base de datos?", vbYesNo + vbQuestion, "Advertencia")
        If result = vbYes Then
            EliminarPaq()
            LlenaDgvPaq()
        End If
    End Sub


End Class