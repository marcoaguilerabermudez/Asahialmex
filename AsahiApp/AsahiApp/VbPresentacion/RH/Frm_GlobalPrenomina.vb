Imports System.Data.SqlClient
Imports Negocio
Imports Clases
Public Class Frm_GlobalPrenomina
#Region "Variables de clase"
    Dim cadConex As SqlConnection
    Dim cadenaConex As String
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal cadConex As SqlConnection, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadConex = cadConex
        Me.cadenaConex = cadenaConex
    End Sub
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_GlobalPrenomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")

        RellenaCmbSemanas()
        ModificarDiaInicio()
    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click

    End Sub
#End Region
#Region "Rellena cmb"
    Private Sub RellenaCmbSemanas()
        For i = 1 To 52
            CmbSemanas.Items.Add(i)
        Next
    End Sub
#End Region
#Region "Procesos Varios"
    Private Sub ModificarDiaInicio()
        Dim fecha As Date
        Dim res As Integer
        Dim dia As String

        dia = WeekdayName(Weekday(Format(DateTime.Now(), "dd/MM/yyyy")))

        Select Case dia
            Case "lunes" : res = -7
            Case "martes" : res = -8
            Case "miércoles" : res = -9
            Case "jueves" : res = -10
            Case "viernes" : res = -11
            Case "sábado" : res = -12
            Case "domingo" : res = -13
        End Select

        fecha = Format(DateAdd(DateInterval.Day, res, DateTime.Now()), "dd/MM/yyyy")

        Dtp_FechaInicioSemana.Value = fecha
    End Sub
#End Region
End Class