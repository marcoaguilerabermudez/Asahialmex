Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Clases
Imports CsPresentacion
Public Class FrmPrincipal
    Dim cadenaConex As SqlConnection
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
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnPreNomina_Click(sender As Object, e As EventArgs) Handles BtnPreNomina.Click
        Dim prenomina As New FrmPrenomina()
        prenomina.Show()
    End Sub

    Private Sub BtnControlProduc_Click(sender As Object, e As EventArgs) Handles BtnControlProduc.Click
        Dim Control As New FrmProduccion()
        Control.Show()
    End Sub
End Class

