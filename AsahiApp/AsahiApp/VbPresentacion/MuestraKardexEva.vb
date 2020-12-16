Imports System.Data.SqlClient

Public Class MuestraKardexEva
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")
    Private Sub MuestraKardexEva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_clave.Text = EvaluacionPersonal.lbl_clave.Text
        lbl_nombre.Text = EvaluacionPersonal.lbl_nombre.Text

        muestragrid()
    End Sub

    Sub muestragrid()


        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestraincidencias", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@tipo", "")

            da.SelectCommand.Parameters.AddWithValue("@clave", EvaluacionPersonal.lbl_clave.Text)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt

            Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        dtgvp.Columns("CLAVE").Visible = False
        'dtgvp.Columns("id_evacrit").Visible = False
        'dtgvp.Columns("Puntos Mínimos").Visible = False





        'Me.dtgvp.Columns("Puntos Máximos").ReadOnly = True
        'Me.dtgvp.Columns("Criterio").ReadOnly = True
        'Me.dtgvp.Columns("Puntos Máximos").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight
        'Me.dtgvp.Columns("Puntaje").DefaultCellStyle.Alignment = ContentAlignment.MiddleRight

        'dtgvp.Rows(9).ReadOnly = True

    End Sub



End Class