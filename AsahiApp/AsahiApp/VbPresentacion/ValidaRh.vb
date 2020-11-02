Imports System.Data.SqlClient

Public Class ValidaRh
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")

    Private Sub ValidaRh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenacombodepto()
    End Sub


    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = False
        Next
    End Sub


    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells("x").Value = True
        Next
    End Sub


    Sub llenacombodepto()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        Dim parametro1 As String
        parametro1 = cbx_depto.Text

        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	
Select distinct descripcion_depto from  giro.[asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] vig
where vigencia = 'VIGENTE'
"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_depto
            .DataSource = Dt
            .DisplayMember = "descripcion_depto"

        End With


    End Sub

    Sub cargagrid()


        Cn.Close()
        Cn.Open()

        Dim da As New SqlDataAdapter("Sp_validatiempoextra", Cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
        da.SelectCommand.Parameters.AddWithValue("@depto", 0)
        da.SelectCommand.Parameters.AddWithValue("@var", 1)
        da.SelectCommand.Parameters.AddWithValue("@departamento", cbx_depto.Text)



        Dim dt As New DataTable
        da.Fill(dt)
        dtgvp.DataSource = dt
        dtgvp.Columns("Id_RhIncidenciasprincipal").Visible = False
        dtgvp.Columns("ValSuper").Visible = False
        dtgvp.Columns("ValRh").Visible = False
        dtgvp.Columns("TimeStampVal").Visible = False
        dtgvp.Columns("PlanExtra").Visible = False
        dtgvp.Columns("Departamento").Visible = False
        dtgvp.Columns("excedido").Visible = False

        Cn.Close()


        For Each row As DataGridViewRow In Me.dtgvp.Rows

            If row.Cells(“excedido”).Value = 0 Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
            ElseIf row.Cells(“excedido”).Value = 1 Then
                row.DefaultCellStyle.BackColor = Color.LightCyan
            End If

        Next
    End Sub

    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        cargagrid()
    End Sub

    Private Sub cbx_depto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_depto.SelectedIndexChanged
        cargagrid()
    End Sub



    Sub cargaIncidenciaGiro()

        Cn.Close()


        Dim command As New SqlCommand("Sp_insertaTiempoExtraGiro", Cn)
        Cn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try

            For Each fila In dtgvp.Rows


                command.Parameters.Clear()

                command.Parameters.AddWithValue("@clave", (fila.Cells("Clave").Value))
                command.Parameters.AddWithValue("@fecha", dtp1.Value.ToShortDateString)
                command.Parameters.AddWithValue("@id", (fila.Cells("Id_RhIncidenciasprincipal").Value))
                command.Parameters.AddWithValue("@te", (fila.Cells("TE").Value))
                command.Parameters.AddWithValue("@incidencia", (fila.Cells("INC").Value))


                command.ExecuteNonQuery()
            Next

            MessageBox.Show("Correcto", "¡Carga exitosa!")
            cargagrid()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            Cn.Close()
        End Try





    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        cargaIncidenciaGiro()
    End Sub
End Class