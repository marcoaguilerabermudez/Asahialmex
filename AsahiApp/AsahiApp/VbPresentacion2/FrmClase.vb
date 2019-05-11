Imports Clases
Imports Negocio
Imports System.Configuration
Imports System.Windows.Forms
Public Class FrmClase
    Dim usuario As Integer
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
    End Sub

    Private Sub Insertar()
        Dim objclase As New Clase
        Dim clase As New NClase
        objclase = RellenaClase()
        clase.InsertaClase(cadenaConex, objclase)
    End Sub
    Public Function RellenaClase()
        Dim objClase As New Clase
        objClase.Nombre = TxtClase.Text
        Return objClase
    End Function

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If TxtClase.Text = "" Then
            MsgBox("Falta poner el nombre de la clase")
        Else
            Insertar()
            MuestraDgvClases()
        End If
    End Sub
    Public Sub MuestraDgvClases()
        Dim objMuestra As New LClase
        objMuestra = obtenerClases()
        DgvClases.DataSource = objMuestra
    End Sub
    Private Function obtenerClases()
        Dim listaClases As New NClase
        Dim lista As New LClase
        lista = listaClases.ObtenerClase(cadenaConex)
        Return lista
    End Function
    ''' <summary>
    ''' evento que se muestra al momento de abrir el formulario
    ''' </summary>
    Private Sub FrmClase_Load(sender As Object, e As EventArgs) Handles Me.Load
        MuestraDgvClases()
        TamañoColumnDgv()
        Me.BtnModificar.Enabled = False 'inhabilita boton modificar
        Me.BtnEliminar.Enabled = False 'inhabilita boton eliminar
        Me.DgvClases.Columns(0).ReadOnly = True 'pone solo lectura la columna del datagrieview
        Me.DgvClases.Columns(1).ReadOnly = True
    End Sub
    Private Sub ModificaClase()
        Dim objClase As New Clase
        Dim clase As New NClase
        objClase = RellenaObjClase()
        clase.ModificaClase(cadenaConex, objClase)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function RellenaObjClase()
        Dim objClase As New Clase
        objClase.Id = TxtClase.Tag 'la variable .Tag se usa para guardar un valor que no queremos que se muestre
        objClase.Nombre = TxtClase.Text
        Return objClase
    End Function

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim x As Byte
        x = MsgBox("¿Esta seguro que desea modificar?", vbOKCancel, "Modificacion")
        If x = 1 Then
            ModificaClase()
            MuestraDgvClases()
        End If
    End Sub
    ''' <summary>
    ''' Evento cuando seleccionas algo de tu DatagridView, lo pone en TextBox, habilita los botones
    ''' </summary>
    Private Sub DgvClases_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvClases.CellClick
        RellenaTxtClases()
        Me.BtnModificar.Enabled = True 'habilita boton modificar
        Me.BtnEliminar.Enabled = True 'habilita boton eliminar
    End Sub
    Private Sub RellenaTxtClases()
        Dim objClase As New Clase
        objClase = RellenaObjClaseTxt(objClase)
        TxtClase.Text = objClase.Nombre 'rellena el text cuando se selecciona un dato del DGV
        TxtClase.Tag = objClase.Id
    End Sub
    ''' <summary>
    ''' Rellena el objclase, de las columnas datagrieview
    ''' </summary>
    ''' <param name="objClase"></param>
    ''' <returns></returns>
    Private Function RellenaObjClaseTxt(objClase As Clase) As Clase
        objClase.Nombre = DgvClases.CurrentRow.Cells("Nombre").Value
        objClase.Id = DgvClases.CurrentRow.Cells("Id").Value
        Return objClase
    End Function
    Private Sub EliminaClase()
        Dim objclase As New Clase
        Dim clase As New NClase
        objclase = RellenaObjElimina()
        clase.EliminaClase(cadenaConex, objclase)
    End Sub
    Private Function RellenaObjElimina()
        Dim objClaseElimina As New Clase
        objClaseElimina.Id = TxtClase.Tag
        Return objClaseElimina
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim result As String
        result = MessageBox.Show("¿Esta seguro que desea eliminar?", "Eliminacion", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            EliminaClase()
            MuestraDgvClases()
        End If
    End Sub
    ''' <summary>
    ''' tamaño de las columnas que tiene el Datagrieview
    ''' </summary>
    Private Sub TamañoColumnDgv()
        DgvClases.Columns(0).Width = 35 'id
        DgvClases.Columns(1).Width = 134 'nombre clase
    End Sub

End Class