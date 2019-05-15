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
#Region "Eventos del fomulario"
    Private Sub Frm_Prenomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
        RellenaCmbSemanas()
    End Sub
    Private Sub Dtp_FechaInicioSemana_TextChanged(sender As Object, e As EventArgs) Handles Dtp_FechaInicioSemana.TextChanged
        If Dtp_FechaInicioSemana.Value < DateTime.Now Or Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyy") = Format(DateTime.Now, "dd/MM/yyy") Then
            Dim fechaI As Date = Dtp_FechaInicioSemana.Value
            Dim fechaF As Date = DateAdd(DateInterval.Day, 6, fechaI)

            Lbl_Dia1.Text = Format(fechaI, "dd/MM")
            Lbl_Dia2.Text = Format(DateAdd(DateInterval.Day, 1, fechaI), "dd/MM")
            Lbl_Dia3.Text = Format(DateAdd(DateInterval.Day, 2, fechaI), "dd/MM")
            Lbl_Dia4.Text = Format(DateAdd(DateInterval.Day, 3, fechaI), "dd/MM")
            Lbl_Dia5.Text = Format(DateAdd(DateInterval.Day, 4, fechaI), "dd/MM")
            lbl_Dia6.Text = Format(DateAdd(DateInterval.Day, 5, fechaI), "dd/MM")
            lbl_Dia7.Text = Format(fechaF, "dd/MM")

            Dim nWeek As Integer
            nWeek = CInt(DatePart(DateInterval.WeekOfYear, fechaI, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)) + 1

            CmbSemanas.SelectedItem = nWeek
            Dgv_ListaPrenomina.Enabled = True
        Else
            Dgv_ListaPrenomina.Enabled = False
            MsgBox("Tienes que ingresar una fecha menor a la actual")
        End If
    End Sub
#End Region
#Region "Rellena cmb"
    Private Sub RellenaCmbSemanas()
        For i = 1 To 52
            CmbSemanas.Items.Add(i)
        Next
    End Sub
#End Region
End Class
