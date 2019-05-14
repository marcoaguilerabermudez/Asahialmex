Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Clases
Imports CsPresentacion
Public Class Frm_Principal
#Region "Variables de clase"
    Dim cadenaConex As SqlConnection
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal cadenaConex As SqlConnection)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
    End Sub
#End Region
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#Region "Botónes"
    Private Sub PreNominaListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreNominaListadoToolStripMenuItem.Click
        Dim lista As New Frm_ListaPrenomina(cadenaConex)
        lista.Show()
    End Sub
    Private Sub ControlDeProducciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeProducciónToolStripMenuItem.Click
        Dim Control As New Frm_Produccion()
        Control.Show()
    End Sub
#End Region
End Class

