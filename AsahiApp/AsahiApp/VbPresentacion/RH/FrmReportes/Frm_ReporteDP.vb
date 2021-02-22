Public Class Frm_ReporteDP
    Dim IdDp As Integer
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal idDp As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.IdDp = idDp
    End Sub
    Private Sub Frm_ReporteDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Dp_Rpt_InfoGrlTableAdapter.Fill(Me.Dts_DPInfoGrl_Rpt.Dp_Rpt_InfoGrl, Me.IdDp)
        Me.Dp_RptEscolaridadTableAdapter.Fill(Me.Dts_DpEstudios_Rpt.Dp_RptEscolaridad, Me.IdDp)
        Me.Dp_RptExpLaboralTableAdapter.Fill(Me.Dts_DpExpLab_Rpt.Dp_RptExpLaboral, Me.IdDp)
        Me.Dp_RptIdiomasTableAdapter.Fill(Me.Dts_DpIdiomas_Rpt.Dp_RptIdiomas, Me.IdDp)
        Me.Dp_RptAutoridadesTableAdapter.Fill(Me.Dts_DpAutoridad_Rpt.Dp_RptAutoridades, Me.IdDp)
        Me.Dp_RptRelacionesPuestoIntTableAdapter.Fill(Me.Dts_DpRelPuestInt_Rpt.Dp_RptRelacionesPuestoInt, Me.IdDp)
        Me.Dp_RptRelacionesPuestoExtTableAdapter.Fill(Me.Dts_DpRelPuestExt_Rpt.Dp_RptRelacionesPuestoExt, Me.IdDp)
        Me.Dp_RptResponsabilidadesTableAdapter.Fill(Me.Dts_DpReponsabilidades_Rpt.Dp_RptResponsabilidades, Me.IdDp)
        Me.Dp_RptIndicadoresTableAdapter.Fill(Me.Dts_DpIndicadores_Rpt.Dp_RptIndicadores, Me.IdDp)
        Me.Dp_RptCompetenciasTableAdapter.Fill(Me.Dts_DpCompetencias_Rpt.Dp_RptCompetencias, Me.IdDp)
        Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class