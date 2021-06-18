Imports System.Data.SqlClient

Public Class ImprimirAnteriores
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Dim folio As Integer
    Dim vpermiso As Integer

    Private Sub dtp_cuando_ValueChanged(sender As Object, e As EventArgs) Handles dtp_cuando.ValueChanged
        cargagrid()
    End Sub

    Sub cargagrid()

        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_reimprimeincidencias", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@fecha", dtp_cuando.Value.ToShortDateString)

            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("Motivo").Visible = False
            dtgvp.Columns("Validado").Visible = False
            Cn.Close()
        Catch
        End Try

        For Each row As DataGridViewRow In Me.dtgvp.Rows
            If row.Cells(“Validado”).Value = 0 Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
            ElseIf row.Cells(“Validado”).Value = 1 Then
                row.DefaultCellStyle.BackColor = Color.ForestGreen
            End If
        Next

    End Sub




    Private Sub ImprimirAnteriores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargagrid()
    End Sub


    Private Sub dtgvp_CellContentClick3(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellContentClick

        Try
            folio = Me.dtgvp.Rows(e.RowIndex).Cells("Folio").Value.ToString()
            vpermiso = Me.dtgvp.Rows(e.RowIndex).Cells("Motivo").Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub dtgvp_CellContentClick2(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter

        Try
            folio = Me.dtgvp.Rows(e.RowIndex).Cells("Folio").Value.ToString()
            vpermiso = Me.dtgvp.Rows(e.RowIndex).Cells("Motivo").Value.ToString()
        Catch
        End Try

    End Sub

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellContentDoubleClick

        Try
            generarreporte()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub




    Sub generarreporte()

        If vpermiso = 1 OrElse vpermiso = 2 Then
            F_reportePCSGoce.id = folio
            F_reportePCSGoce.Tipo = 0
            F_reportePCSGoce.motivo = 0
            F_reportePCSGoce.retardo = 0
            F_reportePCSGoce.Show()
        ElseIf vpermiso = 3 OrElse vpermiso = 4 Then
            Fr_reportefaltajusinj.id = folio
            Fr_reportefaltajusinj.Tipo = 0
            Fr_reportefaltajusinj.motivo = 0
            Fr_reportefaltajusinj.retardo = 0
            Fr_reportefaltajusinj.Show()
        ElseIf vpermiso = 5 Then
            ContenedorReporteVacacionesRH.id = folio
            ContenedorReporteVacacionesRH.Tipo = 0
            ContenedorReporteVacacionesRH.motivo = 0
            ContenedorReporteVacacionesRH.retardo = 0
            ContenedorReporteVacacionesRH.Show()
        ElseIf vpermiso = 6 Then
            ContenedorReporteChecadas.id = folio
            ContenedorReporteChecadas.Tipo = 0
            ContenedorReporteChecadas.motivo = 0
            ContenedorReporteChecadas.retardo = 0
            ContenedorReporteChecadas.Show()

        ElseIf vpermiso = 7 Then
            ContenedorReporteDeptoN.id = folio
            ContenedorReporteDeptoN.Tipo = 0
            ContenedorReporteDeptoN.motivo = 0
            ContenedorReporteDeptoN.retardo = 0
            ContenedorReporteDeptoN.Show()


        ElseIf vpermiso = 8 And Convert.ToString(dtgvp.CurrentRow.Cells("Tipo de incidencia").Value) = "Cambio de puesto" Then
            ContenedorReporteNuevoPuesto.id = folio
            ContenedorReporteNuevoPuesto.Tipo = 0
            ContenedorReporteNuevoPuesto.motivo = 0
            ContenedorReporteNuevoPuesto.retardo = 0
            ContenedorReporteNuevoPuesto.Show()


        ElseIf vpermiso = 8 And Convert.ToString(dtgvp.CurrentRow.Cells("Tipo de incidencia").Value) = "Cambio de puesto y departamento" Then
            ContenedorReporteDeptoPuesto.id = folio
            ContenedorReporteDeptoPuesto.Tipo = 0
            ContenedorReporteDeptoPuesto.motivo = 0
            ContenedorReporteDeptoPuesto.retardo = 0
            ContenedorReporteDeptoPuesto.Show()





        ElseIf vpermiso = 9 Then
            ContenedorReporteSuspension.id = folio
            ContenedorReporteSuspension.Tipo = 0
            ContenedorReporteSuspension.motivo = 0
            ContenedorReporteSuspension.retardo = 0
            ContenedorReporteSuspension.Show()


        ElseIf vpermiso = 10 Then
            ContenedorReporteEntradaSalidaTE.id = folio
            ContenedorReporteEntradaSalidaTE.Tipo = 0
            ContenedorReporteEntradaSalidaTE.motivo = 0
            ContenedorReporteEntradaSalidaTE.retardo = 0
            ContenedorReporteEntradaSalidaTE.Show()

        ElseIf vpermiso = 11 Then
            ContenedorReporteComision.id = folio
            ContenedorReporteComision.Tipo = 0
            ContenedorReporteComision.motivo = 0
            ContenedorReporteComision.retardo = 0
            ContenedorReporteComision.Show()

        End If


    End Sub


End Class