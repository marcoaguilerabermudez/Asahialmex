Public Class Frm_RepPlanHrsExtra5
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
    Private Sub Frm_RepPlanHrsExtra5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dts_PlanHrsExt5.Rh_RptPlanHrsExtraMensual5' Puede moverla o quitarla según sea necesario.
        Me.Rh_RptPlanHrsExtraMensual5TableAdapter.Fill(Me.Dts_PlanHrsExt5.Rh_RptPlanHrsExtraMensual5, Me.mes, Me.depto, Me.año)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class