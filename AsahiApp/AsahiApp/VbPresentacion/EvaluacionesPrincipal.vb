Imports System.Data.SqlClient

Public Class EvaluacionesPrincipal
    Dim id As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim a As String
    Dim mes As Integer
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")



    Sub New(id As Integer, depto As String, permiso As Integer)
        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso

    End Sub

    Private Sub EvaluacionesPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        a = Today.Month
        Select Case a
            Case 1
                cbx_mes.Text = "Enero"
                mes = 1
            Case 2
                cbx_mes.Text = "Febrero"
                mes = 2
            Case 3
                cbx_mes.Text = "Marzo"
                mes = 3
            Case 4
                cbx_mes.Text = "Abril"
                mes = 4
            Case 5
                cbx_mes.Text = "Mayo"
                mes = 5
            Case 6
                cbx_mes.Text = "Junio"
                mes = 6
            Case 7
                cbx_mes.Text = "Julio"
                mes = 7
            Case 8
                cbx_mes.Text = "Agosto"
                mes = 8
            Case 9
                cbx_mes.Text = "Septiembre"
                mes = 9
            Case 10
                cbx_mes.Text = "Octubre"
                mes = 10
            Case 11
                cbx_mes.Text = "Noviembre"
                mes = 11
            Case 12
                cbx_mes.Text = "Diciembre"
                mes = 12
        End Select







        cbx_año.Text = Today.Year()

        llenacombodepto()

        If depto = "04" OrElse depto = "19" Then
            Label1.Visible = True
            cbx_depto.Visible = True
            btn_solicitar.Visible = True

        End If

        cbx_tipoeva.Text = "--Todas--"
        cbx_depto.DropDownStyle = ComboBoxStyle.DropDown
        cbx_depto.Text = "--Todos--"





    End Sub

    Private Sub cbx_mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mes.SelectedIndexChanged
        a = cbx_mes.Text
        Select Case a
            Case "Enero"
                mes = 1
            Case "Febrero"
                mes = 2
            Case "Marzo"
                mes = 3
            Case "Abril"
                mes = 4
            Case "Mayo"
                mes = 5
            Case "Junio"
                mes = 6
            Case "Julio"
                mes = 7
            Case "Agosto"
                mes = 8
            Case "Septiembre"
                mes = 9
            Case "Octubre"
                mes = 10
            Case "Noviembre"
                mes = 11
            Case "Diciembre"
                mes = 12
        End Select

    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        cbx_depto.DropDownStyle = ComboBoxStyle.DropDown
        cbx_depto.Text = "--Todos--"

    End Sub

    Private Sub cbx_depto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_depto.SelectedIndexChanged
        cbx_depto.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub



    Sub llenacombodepto()

        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand



        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "	
select descripcion, clave from giro.[asahi16].[Supervisor_giro].[DEPTO] where CENTRO_COSTO not in ('16')
"
            .Connection = Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_depto
            .DataSource = Dt
            .DisplayMember = "descripcion"


        End With
    End Sub


    Sub Muestragrid()

        Try
            Cn.Close()
            Cn.Open()

            Dim da As New SqlDataAdapter("Sp_muestraEvaluaciones", Cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@depto", depto)
            da.SelectCommand.Parameters.AddWithValue("@descripcion_depto", cbx_depto.Text)
            da.SelectCommand.Parameters.AddWithValue("@mes", mes)
            da.SelectCommand.Parameters.AddWithValue("@año", cbx_año.Text)
            da.SelectCommand.Parameters.AddWithValue("@tipoeva", cbx_tipoeva.Text)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt

            Cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        dtgvp.Columns("Pues").Visible = False
        dtgvp.Columns("Dep").Visible = False
        dtgvp.Columns("Estado").Visible = False

        For Each row As DataGridViewRow In Me.dtgvp.Rows

            If row.Cells(“Estado”).Value = 0 Then
                row.DefaultCellStyle.BackColor = Color.White
            ElseIf row.Cells(“Estado”).Value = 1 Then
                row.DefaultCellStyle.BackColor = Color.Gold
            ElseIf row.Cells(“Estado”).Value = 2 Then
                row.DefaultCellStyle.BackColor = Color.LightBlue
            ElseIf row.Cells(“Estado”).Value = 3 Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Muestragrid()
    End Sub


End Class