Imports Negocio
Imports Clases
Imports System.Windows.Forms

Public Class FrmAgentes
    Dim usuario As Integer
    Dim cadenaConex As String
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
    ''' Metodo para rellenar mi objeto RellenaAgente con un TextBox
    ''' </summary>
    ''' <returns>Regresa un valor de tipo Agente</returns>
    Public Function RellenaAgente()
        Dim ObjRellenaAgente As New Agente
        ObjRellenaAgente.NombreAgente = TxtAgente.Text
        Return ObjRellenaAgente
    End Function
    ''' <summary>
    ''' metodo para llenar el objeto con una funcion
    ''' </summary>
    Private Sub InsertaAgente()
        Dim nombreAge As New Agente
        Dim agente As New NAgente
        nombreAge = RellenaAgente()
        agente.InsertaAgente(cadenaConex, nombreAge)
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        If TxtAgente.Text = "" Then
            MsgBox("No ha escrito el nombre del agente")
        Else
            InsertaAgente()
            MuestraAgentesDgv()
        End If
    End Sub
    ''' <summary>
    ''' Metodo para mostrar la lista de agentes en el datagridview
    ''' </summary>
    Public Sub MuestraAgentesDgv()
        Dim muestra As New LAgente
        muestra = ObtenerListAgen()
        DgvAgentes.DataSource = muestra
    End Sub
    Public Function ObtenerListAgen()
        Dim listaAgent As New NAgente
        Dim lista As New LAgente
        'lista = listaAgent.ObtenerAgente(cadenaConex)
        Return lista
    End Function
    ''' <summary>
    ''' 'pone la columna(0)solo lectura(no modificar)
    ''' 'pone la columna(1)solo lectura(no modificar)
    ''' 'inhabilita los botones
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmAgentes_Load(sender As Object, e As EventArgs) Handles Me.Load
        MuestraAgentesDgv()
        MedidasColumDgv()
        Me.DgvAgentes.Columns(0).ReadOnly = True
        Me.DgvAgentes.Columns(1).ReadOnly = True

        Me.BtnEliminar.Enabled = False
        Me.BtnModificar.Enabled = False
    End Sub
    ''' <summary>
    ''' 'medidas de las columnas del DataDrigView
    ''' </summary>
    Private Sub MedidasColumDgv()
        DgvAgentes.Columns(0).Width = 62
        DgvAgentes.Columns(1).Width = 169
    End Sub
    Private Sub ModificaAgente()
        Dim ModAgente As New Agente
        Dim agente As New NAgente
        ModAgente = RellenaAgenteSql()
        agente.ModificarAgente(cadenaConex, ModAgente)
    End Sub
    ''' <summary>
    ''' 'metodo para rellenar el objeto
    ''' </summary>
    ''' <returns></returns>
    Public Function RellenaAgenteSql()
        Dim RellenaObjAgente As New Agente
        RellenaObjAgente.IdAgente = TxtAgente.Tag
        RellenaObjAgente.NombreAgente = TxtAgente.Text
        Return RellenaObjAgente
    End Function
    ''' <summary>
    ''' 'function para seleccion lo de una columna del Dgv con el objeto agente
    ''' </summary>
    ''' <param name="agente"></param>
    ''' <returns>regresa una variable de tipo Agente</returns>
    Private Function RellenaTxtAgente(agente As Agente) As Agente
        agente.IdAgente = DgvAgentes.CurrentRow.Cells("IdAgente").Value
        agente.NombreAgente = DgvAgentes.CurrentRow.Cells("Nombre").Value
        Return agente
    End Function
    ''' <summary>
    ''' metodo para lllenar el objeto agente
    ''' </summary>
    Private Sub RellenaTxtDgvAgent()
        Dim agente As New Agente
        agente = RellenaTxtAgente(agente)
        TxtAgente.Text = agente.NombreAgente
        TxtAgente.Tag = agente.IdAgente
    End Sub
    ''' <summary>
    ''' cuando se da click a una celda del Dgv se pasa al proceso "RellenaTxtDgvAgent"
    ''' los botones se habilitan
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvAgentes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAgentes.CellClick
        RellenaTxtDgvAgent()
        Me.BtnModificar.Enabled = True
        Me.BtnEliminar.Enabled = True
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim result As String
        result = MessageBox.Show("¿Desea modificar este agente?", "Modificar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ModificaAgente()
            MuestraAgentesDgv()
        End If
    End Sub
    Private Sub EliminacionAgente()
        Dim eliminaAgenId As New Agente
        Dim agente As New NAgente
        eliminaAgenId = RellenaAgenElimina()
        agente.EliminaAgente(cadenaConex, eliminaAgenId)
    End Sub
    Private Function RellenaAgenElimina()
        Dim elimAgentId As New Agente
        elimAgentId.IdAgente = TxtAgente.Tag
        Return elimAgentId
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim result As String
        result = MessageBox.Show("¿Desea eliminar este agente?", "Eliminar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            EliminacionAgente()
            MuestraAgentesDgv()
        End If
    End Sub
End Class