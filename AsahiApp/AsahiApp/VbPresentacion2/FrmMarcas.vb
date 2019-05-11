Imports System.Configuration
Imports Clases ' IMPORTA CLASE PARA TRAER ATRIBUTOS
Imports Negocio ' IMPORTA NEGOCIO PARA HACER CONEXIÓN

Public Class FrmMarcas
    Private cadenaConex As String
    Sub New(ByVal usuario As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    ''' <summary>
    ''' Carga LA INFORMACIÓN al abrir el FORMULARIO MARCAS
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmMarcas_Load(sender As Object, e As EventArgs) Handles Me.Load
        RellenoDgvMarcas() ' LLAMA AL PROCESO PARA LLENAR EL DATAGRIDVIEW
        CleanMarca() 'LLAMA EL PROCESO PARA LIMPIAR LOS CAMPOS
    End Sub
    ''' <summary>
    ''' VACIA LA INFORMACION DEL TEXTMARCA  E ID
    ''' </summary>
    Private Sub CleanMarca()
        TextMarca.Text = ""
        TextMarca.Tag = ""
        BtnEliminar.Enabled = False ' DESHABILITA EL BOTÓN ELIMINAR
        BtnModifica.Enabled = False ' DESHABILITA EL BOTÓN MODIFICA

    End Sub
    ''' <summary>
    ''' RECIBE INFORMACION  
    ''' </summary>
    ''' <returns></returns>
    Private Function ObtenerMarcar() As LMarca
        Dim objNegocio As New NMarca  ' DECLARA OBJETO PARA HACER CONEXIÓN
        Return objNegocio.ObtenerMarcaId(cadenaConex) ' RECIBE INFORMACIÓN Y HACE CONEXIÓN
    End Function

    ''' <summary>
    ''' RELLENA EL DATAGRIDVIEW  PARA MOSTRAR
    ''' </summary>
    Private Sub RellenoDgvMarcas()
        Dim lisMarcas As New LMarca
        lisMarcas = ObtenerMarcar() 'OBTINE INFORMACIÓN 
        DgvMarcas.DataSource = lisMarcas 'LLENA EL DATAGRIDVIEW
        DgvMarcas.Columns(0).Width = 30 ' MEDIDA DE LA COLUMNA 0
        DgvMarcas.Columns(1).Width = 200 'MEDIDA DE LA COLUMNA 1

    End Sub

    ''' <summary>
    ''' RELLENA LA INFORMACIÓN PARA INSERTAR
    ''' </summary>
    ''' <returns></returns>
    Private Function RellenaInsertMarca()
        Dim objMarca As New Marca
        objMarca.Nombre = TextMarca.Text

        If TextMarca.Tag <> Nothing Then ' SI EN EL CAMPO TEXTMARCA CONTIENE INFORMACION, LO LLENA 
            objMarca.Id = TextMarca.Tag
        End If
        Return objMarca 'ENVIA LA INFORMACIÓN QUE CONTIENE OBJMARCA
    End Function
    ''' <summary>
    ''' PROCESO  PARA INSERTAR
    ''' </summary>
    Private Sub InsertMarca()
        Dim objNegocio As New NMarca ' DECLARA UN OBJETO PARA HACER CONEXIÓN 
        Dim objMarca As New Marca 'DECALRA UN OBJETO  PARA RELLENAR EL OBJETO
        objMarca = RellenaInsertMarca() ' RELLANA EL OBJETO
        objNegocio.InsertMarcaId(cadenaConex, objMarca) ' ENVIA LA INFORMACIÓN A LA FUNCIÓN
    End Sub

    ''' <summary>
    '''REALIZA LA FUNCIÓN DE INSERTAR
    ''' </summary>
    Private Sub BtnInserta_Click(sender As Object, e As EventArgs) Handles BtnInserta.Click
        If Validar() = True Then ' RECIBE TRUE, SI CONTIENE INFORMACIÓN ENTRA Y FALSE  ACABA PROCESO
            InsertMarca() ' LLAMA AL PROCESO
            RellenoDgvMarcas() 'MUESTRA LA INFORMACIÓN OBTENIDA
        End If
    End Sub
    ''' <summary>
    ''' VALIDA SI EL CAMPO TEXTMARCA CONTIENE INFORMACIÓN SI ES DE LO CONTRARIO  ENVIA MENSAJE 
    ''' </summary>
    ''' <returns></returns>

    Private Function Validar() As Boolean
        If TextMarca.Text = "" Then
            MsgBox("Teclea la Marca")
            Return False
        Else
            Return True
        End If
    End Function
    ''' <summary>
    ''' RELLENA EN LOS CAMPOS LO SELECCIONADO  
    ''' </summary>
    Private Sub RellenaObjMarca()
        TextMarca.Text = DgvMarcas.CurrentRow.Cells("Nombre").Value
        TextMarca.Tag = DgvMarcas.CurrentRow.Cells("Id").Value
    End Sub
    ''' <summary>
    ''' MUESTRA LO SELECCIONADO
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvMarcas_SelectionChanged(sender As Object, e As EventArgs) Handles DgvMarcas.SelectionChanged
        RellenaObjMarca() ' LLAMA AL PROCESO
        BtnEliminar.Enabled = True ' HABILITA EL BOTÓN ELIMINAR
        BtnModifica.Enabled = True 'HABILITA'EL BOTÓN MODIFICA

    End Sub
    ''' <summary>
    ''' PROCESO DE MODIFICACIÓN
    ''' </summary>
    Private Sub ModifiMarca()
        Dim objNegocio As New NMarca 'DECLARA OBJETO PARA HACER CONEXIÓN
        Dim objMarca As New Marca 'DECLARA UN OBJETO PARA RELLENA  EL OBJETO
        objMarca = RellenaInsertMarca() 'RELLENA EL OBJETO
        objNegocio.ModifMarcaId(cadenaConex, objMarca) '  ENVIA  INFORMACIÓN  AL PROCESO MODIFICAMARCAid  Y HACE CONEXIÓN
    End Sub
    ''' <summary>
    ''' 'REALIZA LA FUNCIÓN DE MODIFICAR
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnModifica_Click(sender As Object, e As EventArgs) Handles BtnModifica.Click
        Dim resulta As String
        resulta = MsgBox("Deseas Modificar", vbYesNo + vbQuestion, "Advertencia") ' ENVIA UN MENSAJE ANTES DE ENTRAR AL PROCESO DE MODIFICACIÓN

        If resulta = vbYes Then 'SI RESULTA ES SI ENTRA Y MODIFICA DE LO CONTRARIO TERMINA EL PROCESO
            ModifiMarca() 'LLAMA AL PROCESO
            RellenoDgvMarcas() 'LLAMA AL PROCESO  PARA MOSTRAR LA INFORMACION MODIFICADA
        End If

    End Sub
    ''' <summary>
    ''' REALIZA LA FUNCIÓN ELIMINAR
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim resulta As String 'DECLARA VARIABLE PARA RESULTADO DEL MENSAJE
        resulta = MsgBox("Esta seguro que desea ELIMINAR", vbYesNo + vbQuestion, "Advertencia") ' ENVIA UN MENSAJE ANTES DE ENTRAR AL PROCESO DE ELIMINACIÓN

        If resulta = vbYes Then 'SI RESULTA ES SI ENTRA Y ELIMINAR DE LO CONTRARIO TERMINA EL PROCESO
            EliminaMarca() 'LLAMA AL PROCESO
            RellenoDgvMarcas() ' 'LLAMA AL PROCESO  PARA MOSTRAR LA INFORMACION ELIMINADA 
        End If

    End Sub
    ''' <summary>
    ''' ENVIA EL ID 
    ''' </summary>
    ''' <returns></returns>
    Private Function RellenaElimMarca()
        Dim objMarca As New Marca ' DECLARA UN OBJETO PARA TRAER ID DE CLASE MARCA
        objMarca.Id = TextMarca.Tag ' LLENA EL ID CON LO QUE CONTIENE EL TEXTMARCA
        Return objMarca 'ENVIA EL ID 
    End Function
    ''' <summary>
    ''' PROCESO DE ELIMINACIÓN
    ''' </summary>
    Private Sub EliminaMarca()
        Dim objNegocio As New NMarca 'DECLARA OBJETO PARA HACER CONEXIÓN
        Dim objMarca As New Marca 'DECARA OBJETO PARA RELLENAER EL OBJETO
        objMarca = RellenaElimMarca() 'RELLENA EL OBJETO
        objNegocio.EliminaMarcaId(cadenaConex, objMarca) ' ENVIA INFORMACIÓN   Y HACE CONEXIÓN
    End Sub

End Class