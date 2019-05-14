Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Clases
Imports CsPresentacion

Public Class Frm_RecursosHumanos
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
    Private Sub Frm_RecursosHumanos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#Region "Botones"
    Private Sub Btn_Prenomina_Click(sender As Object, e As EventArgs) Handles Btn_Prenomina.Click
        Dim prenomina As New Frm_Prenomina()
        prenomina.Show()
        Me.Close()
    End Sub
#End Region
End Class