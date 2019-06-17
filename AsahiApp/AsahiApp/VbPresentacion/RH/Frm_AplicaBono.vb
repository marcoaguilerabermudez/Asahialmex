Imports System.Data.SqlClient
Imports System.Diagnostics
Imports Clases
Imports Negocio

Public Class Frm_AplicaBono
#Region "Variables de Clase"
    Public idMotivo As String
    Dim cadConex As SqlConnection
    Dim cadenaConex As String
    Dim open As Boolean
    Dim empleado As New Empleado()
    Dim valor
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal cadConex As SqlConnection, ByVal cadenaConex As String, ByVal empleado As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadConex = cadConex
        Me.cadenaConex = cadenaConex
        Me.empleado = empleado
    End Sub
#End Region
    Private Sub Frm_AplicaBono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_IdEmpleado.Text = Me.empleado.IdEmpleado
        Lbl_NombreEmpleado.Text = Me.empleado.NombreCompleto
        Lbl_IdTurno.Text = Me.empleado.IdTurno
        Lbl_Horario.Text = Me.empleado.Turno
        Lbl_Checada.Text = Me.empleado.Horario
        RellenaCmb()
    End Sub
    Private Sub Cmb_Motivo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Motivo.SelectionChangeCommitted
        If Cmb_Motivo.Text <> "" Then
            Btn_Guardar.Visible = True
        Else
            Btn_Guardar.Visible = False
        End If
    End Sub
    Private Sub RellenaCmb()
        Dim con As New conexion()
        Dim cadConex As String
        Dim lstHr As New LHorarios()
        Dim NPren As New NPrenomina()
        cadConex = con.cadenaConexExpress

        lstHr = NPren.RecuperarMotivosRetardo(cadConex)
        With Cmb_Motivo
            .DataSource = lstHr
            .ValueMember = "IdMotivoRetardo"
            .DisplayMember = "motivoRetardo"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Me.idMotivo = Cmb_Motivo.SelectedValue
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class