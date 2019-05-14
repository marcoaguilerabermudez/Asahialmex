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
    Private Sub BtnPreNomina_Click(sender As Object, e As EventArgs) Handles Btn_Rh.Click
        Dim rh As New Frm_RecursosHumanos(cadenaConex)
        rh.Show()
    End Sub

    Private Sub BtnControlProduc_Click(sender As Object, e As EventArgs) Handles Btn_ControlProduc.Click
        Dim Control As New Frm_Produccion()
        Control.Show()
    End Sub
#End Region
End Class

