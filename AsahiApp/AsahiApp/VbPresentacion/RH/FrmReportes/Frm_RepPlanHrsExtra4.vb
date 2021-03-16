Public Class Frm_RepPlanHrsExtra4
    Dim mes As Integer, depto As Integer, año As Integer
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal mes As Integer, ByVal depto As Integer, ByVal año As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.mes = mes
        Me.depto = depto
        Me.año = año
    End Sub
    Private Sub Frm_PlanHrsExtra4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dts_PlanHrsExt4.Rh_RptPlanHrsExtraMensual4' Puede moverla o quitarla según sea necesario.
        Me.Rh_RptPlanHrsExtraMensual4TableAdapter.Fill(Me.Dts_PlanHrsExt4.Rh_RptPlanHrsExtraMensual4, Me.mes, Me.depto, Me.año)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class