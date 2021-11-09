Imports System.Data.SqlClient

Public Class Provisiones
    Dim var_filtro As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer

    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String

    Dim Cantidad_Requerida As Double
    Dim filtro As Integer
    Dim y As Integer
    Dim id_po As Integer
    Private Sub Provisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New conexion()


        If Strings.Left(conexion.getIp(), 6) = "172.16" Then

            Me.cadenaConex = conexion.conexionCont
            Me.cnn = conexion.conexionContpaq2
            Me.cnn2 = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress

        Else

            Me.cadenaConex = conexion.cadenaConexFor
            Me.cnn = conexion.conexionContpaqFor2
            Me.cnn2 = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor

        End If
        var_filtro = 0
    End Sub

    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub


    Sub cargagrid()


        cnn.Close()
        cnn.Open()
        '   MessageBox.Show(cnn.ToString)
        Try



            Dim da As New SqlDataAdapter("Sp_muestragridmodificaRecepcionconPO", cnn)

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@codigo", dtp1.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@serie", dtp2.Value.ToShortDateString)
            da.SelectCommand.Parameters.AddWithValue("@var", var_filtro)

            'MessageBox.Show(txt_no.Text)
            'MessageBox.Show(cbx_serie.Text)

            Dim dt As New DataTable
            da.Fill(dt)
            dtgv.DataSource = dt
            dtgv.Columns("Id_provision").Visible = False
            dtgv.Columns("Add").Visible = False
            dtgv.Columns("Val1").Visible = False
            dtgv.Columns("Val2").Visible = False
            dtgv.Columns("Val3").Visible = False
            dtgv.Columns("Val4").Visible = False
            dtgv.Columns("Ruta").Visible = False
            dtgv.Columns("StatusConta").Visible = False
            dtgv.Columns("ObservaConta").Visible = False
            dtgv.Columns("FechaPagoReal").Visible = False
            dtgv.Columns("o").Visible = False
            dtgv.Columns("serie").Visible = False
            dtgv.Columns("Oc").Width = 65
            dtgv.Columns("Compra").Width = 65
            dtgv.Columns("Factura").Width = 75
            dtgv.Columns("Proveedor").Width = 150
            dtgv.Columns("Moneda").Width = 60


            If dtgv.RowCount < 1 Then
                MessageBox.Show("No hay ningún registro con los criterios de búsqueda seleccionados", "¡Alerta!")

            End If


            colores()




            'If (depto <> 19 Or depto <> 7) Then
            '    dtgvp.Columns.Remove("X")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub


    Sub colores()

        Try
            For Each row As DataGridViewRow In Me.dtgv.Rows

                If row.Cells(“Edo_prov”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                ElseIf row.Cells(“Edo_prov”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.Pink
                ElseIf row.Cells(“Edo_prov”).Value = 2 Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf row.Cells(“Edo_prov”).Value = 20 Then
                    row.DefaultCellStyle.BackColor = Color.Gold
                ElseIf row.Cells(“Edo_prov”).Value = 88 Then
                    row.DefaultCellStyle.BackColor = Color.Red
                End If
            Next
        Catch
        End Try

    End Sub

End Class