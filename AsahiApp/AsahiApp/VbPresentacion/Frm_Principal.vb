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

    Private Sub Men_Principal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Men_Principal.ItemClicked

    End Sub

    Private Sub BajaEmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BajaEmpleadosToolStripMenuItem1.Click
        Dim Bajas As New Frm_Listado_Bajas()
        Bajas.ShowDialog()
        Bajas.Hide()

    End Sub

    Private Sub BajaEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaEmpleadosToolStripMenuItem.Click
        Dim Altas As New Frm_Listado_Altas()
        Altas.ShowDialog()
        Altas.Hide()

    End Sub

    Private Sub ACercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACercaDeToolStripMenuItem.Click
        Dim Soporte As New Frm_Soporte()
        Soporte.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click

    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        Dim Acerca As New Frm_Acerca()
        Acerca.ShowDialog()
    End Sub

    Private Sub InformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónToolStripMenuItem.Click
        Dim Detalle As New Frm_Empleados_Detalle()
        Detalle.ShowDialog()
    End Sub
#End Region
End Class

