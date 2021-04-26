Imports System.Data.SqlClient
Imports Negocio
Imports Clases

Public Class Frm_OpcionesReportes
#Region "Variables de clase"
    Dim idDepto As Integer, mes As Integer, año As Integer, semana As Integer, origen As Integer
    'El origen es de que formulario viene, esto es por que se puede reutilizar el mismo formulario
    Dim cadConex As String
    Dim conexConta As String
#End Region
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal idDepto As Integer, ByVal mes As Integer, ByVal año As Integer, ByVal semana As Integer, ByVal origen As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idDepto = idDepto
        Me.mes = mes
        Me.año = año
        Me.semana = semana
        Me.origen = origen '1 = tiempo extra
    End Sub
    Private Sub Frm_OpcionesReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion
        Me.cadConex = conex.conexion2008
        Me.conexConta = conex.conexionCont
        If Me.origen = 1 Then
            Lbl_Titulo.Text = "REPORTES PLAN TIEMPO EXTRA"
            Btn_RepMensual.Visible = True
            Btn_RepSemanal.Visible = True
            Btn_RepSemanal.Enabled = False
        End If
    End Sub
    Private Sub Btn_RepMensual_Click(sender As Object, e As EventArgs) Handles Btn_RepMensual.Click
        Dim tSemanas As Integer
        Dim NHrsEx As New NHorasExtra()

        tSemanas = NHrsEx.RecuperarTotalSemanas(Me.conexConta, mes, año)
        If tSemanas = 4 Then
            Dim Rep4 As New Frm_RepPlanHrsExtra4(mes, idDepto, año)
            Rep4.Show()
        ElseIf tSemanas = 5 Then
            Dim Rep5 As New Frm_RepPlanHrsExtra5(mes, idDepto, año)
            Rep5.Show()
        End If
    End Sub
End Class