Imports System.Data.SqlClient

Public Class AumentoSueldoOperador

    Dim a As String
    Dim b As String
    Dim x As String
    Dim y As String
    Dim mes As Integer


    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection

    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer


    Sub New(id As Integer, depto As String, permiso As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso

    End Sub

    Private Sub AumentoSueldoOperador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cnn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress
            Me.cnn2 = conexion.cadenagiro
        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cnn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor
            Me.cnn2 = conexion.cadenagirofor
        End If


        cbx_año.Text = Today.Year.ToString()
        mes = Today.Month.ToString()
        a = mes
        Select Case a
            Case "1"
                b = "ENERO      1 月"
            Case "2"
                b = "FEBRERO    2 月"
            Case "3"
                b = "MARZO      3 月"
            Case "4"
                b = "ABRIL      4 月"
            Case "5"
                b = "MAYO       5 月"
            Case "6"
                b = "JUNIO      6 月"
            Case "7"
                b = "JULIO      7 月"
            Case "8"
                b = "AGOSTO     8 月"
            Case "9"
                b = "SEPTIEMBRE 9 月"
            Case "10"
                b = "OCTUBRE   10 月"
            Case "11"
                b = "NOVIEMBRE 11 月"
            Case "12"
                b = "DICIEMBRE 12 月"
        End Select

        cbx_mes.Text = b


        Muestragrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = cbx_mes.Text
        Select Case a
            Case "ENERO      1 月"
                b = 1
            Case "FEBRERO    2 月"
                b = 2
            Case "MARZO      3 月"
                b = 3
            Case "ABRIL      4 月"
                b = 4
            Case "MAYO       5 月"
                b = 5
            Case "JUNIO      6 月"
                b = 6
            Case "JULIO      7 月"
                b = 7
            Case "AGOSTO     8 月"
                b = 8
            Case "SEPTIEMBRE 9 月"
                b = 9
            Case "OCTUBRE   10 月"
                b = 10
            Case "NOVIEMBRE 11 月"
                b = 11
            Case "DICIEMBRE 12 月"
                b = 12
        End Select
        mes = b
    End Sub



    Sub Muestragrid()

        Try
            '    Using cnn2
            cnn2.Close()
            cnn2.Open()

            Dim da As New SqlDataAdapter("Sp_AumentoSueldoOperadoresMensual", cnn2)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@mes", mes)
            da.SelectCommand.Parameters.AddWithValue("@año", cbx_año.Text)


            Dim dt As New DataTable
            da.Fill(dt)
            dtgvp.DataSource = dt
            dtgvp.Columns("t").Visible = False
            dtgvp.Columns("estatus").Visible = False
            dtgvp.Columns("id_AumentoOperador").Visible = False
            dtgvp.Columns("Puesto").Visible = False
            dtgvp.Columns("Clave").Width = 80
            dtgvp.Columns("Clave").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dtgvp.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells(“estatus”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.White
                ElseIf row.Cells(“estatus”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next
            ' End Using
            cnn2.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cnn2.Close()
        End Try
    End Sub


    Sub liberar()
        Try
            cnn2.Close()
            cnn2.Open()

            Dim auto As SqlCommand = New SqlCommand(" update [asahi16].[dbo].[Rh_AumentoSueldoOperador] set estatus = 1
where Id_AumentoOperador = @id
", cnn2)

            Dim fila As DataGridViewRow = New DataGridViewRow()
            Dim RI As String



            For Each fila In dtgvp.Rows
                If fila.Cells(0).Value = True Then
                    auto.Parameters.Clear()
                    auto.Parameters.Add("@id", SqlDbType.Int).Value = (fila.Cells("Id_AumentoOperador").Value)


                    auto.ExecuteNonQuery()

                    RI = "¡Registro(s) Liberado(s)!"

                End If

            Next

            MessageBox.Show(RI, "¡Aviso!")
            Muestragrid()


        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn2.Close()
        Finally
            cnn2.Close()

        End Try


    End Sub


    Private Sub btn_selec_Click(sender As Object, e As EventArgs) Handles btn_selec.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells(0).Value = True
        Next
    End Sub

    Private Sub btn_desma_Click(sender As Object, e As EventArgs) Handles btn_desma.Click
        For Each fila As DataGridViewRow In dtgvp.Rows
            fila.Cells(0).Value = False
        Next
    End Sub

    Private Sub btn_liberar_Click(sender As Object, e As EventArgs) Handles btn_liberar.Click
        liberar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ContenedorReporteAumentoSueldoOperador.mes = mes
        ContenedorReporteAumentoSueldoOperador.año = cbx_año.Text
        ContenedorReporteAumentoSueldoOperador.Show()
    End Sub
End Class