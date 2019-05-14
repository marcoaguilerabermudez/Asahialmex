Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Clases
Imports CsPresentacion
Public Class Frm_ListaPrenomina
#Region "Variables de Clase"
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
    Private Sub Frm_Prenomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
    End Sub

End Class