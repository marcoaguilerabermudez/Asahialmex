Imports System.Data.SqlClient

Public Class MuestraOeeCompleto
    Private Sub MuestraOeeCompleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        muestragrid()
        medidasgrid()
        muestragrid2()
        medidasgrid2()
    End Sub


    Sub muestragrid()
        Try
            CapturaOEE.Cn.Open()


            Dim da As New SqlDataAdapter("Sp_reportegeneraloee", CapturaOEE.Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@var", 1)

            Dim dt As New DataTable
            da.Fill(dt)

            dtgv.DataSource = dt

            'dtgv.Columns("CIDDOCUMENTO").Visible = False
            'dtgv.Columns("CIDMOVIMIENTO").Visible = False
            'dtgv.Columns("Total").Visible = False
            'dtgv.Columns("Nombre").Width = 310
            'dtgv.Columns("PO").Width = 50
            'dtgv.Columns("UMedida").Width = 130
            'colores()
            'pROIVEEDOR()

            CapturaOEE.Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CapturaOEE.Cn.Close()
        End Try

    End Sub


    Sub muestragrid2()
        Try
            CapturaOEE.Cn.Open()


            Dim da As New SqlDataAdapter("Sp_reportegeneraloee", CapturaOEE.Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@var", 2)

            Dim dt As New DataTable
            da.Fill(dt)

            dtgv2.DataSource = dt

            'dtgv.Columns("CIDDOCUMENTO").Visible = False
            'dtgv.Columns("CIDMOVIMIENTO").Visible = False
            'dtgv.Columns("Total").Visible = False
            'dtgv.Columns("Nombre").Width = 310
            'dtgv.Columns("PO").Width = 50
            'dtgv.Columns("UMedida").Width = 130
            'colores()
            'pROIVEEDOR()

            CapturaOEE.Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CapturaOEE.Cn.Close()
        End Try

    End Sub


    Sub medidasgrid()




        dtgv.Columns("Proceso").Width = 75
        dtgv.Columns("Máquina").Width = 70
        dtgv.Columns("Pieza").Width = 100
        dtgv.Columns("Molde").Width = 55
        dtgv.Columns("Turno").Width = 40
        dtgv.Columns("Utilización").Width = 74
        dtgv.Columns("Rendimiento").Width = 76
        dtgv.Columns("Calidad").Width = 74
        dtgv.Columns("OEE").Width = 74


        dtgv.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
    End Sub

    Sub medidasgrid2()




        dtgv2.Columns("Proceso").Width = 75
        dtgv2.Columns("Máquina").Width = 70
        dtgv2.Columns("Pieza").Width = 100
        dtgv2.Columns("Molde").Width = 55
        dtgv2.Columns("Turno").Width = 40
        dtgv2.Columns("Utilización").Width = 74
        dtgv2.Columns("Rendimiento").Width = 76
        dtgv2.Columns("Calidad").Width = 74
        dtgv2.Columns("OEE").Width = 74


        dtgv2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtgv2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
    End Sub



End Class