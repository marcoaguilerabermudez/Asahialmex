Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CargaPrecios

    Dim DireccionArchivo As String
    Dim VentanaArchivo As New OpenFileDialog

    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer
    Dim Cantidad_Requerida As Double
    Dim Ruta As String

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection

    Dim y As Integer


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()

        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub

    Private Sub CargaPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        AddHandler VentanaArchivo.FileOk, AddressOf ObtenerArchivo

    End Sub

    Private Sub btn_archivo_Click(sender As Object, e As EventArgs) Handles btn_archivo.Click
        VentanaArchivo.ShowDialog()
    End Sub

    Public Sub ExportarExcelADGV(Lista As DataGridView, ArchivoExcel As String)

        Dim ConexionExcel As OleDbConnection
        Dim AdaptadorExcel As OleDbDataAdapter
        Dim ds As DataSet

        Try
            'Se crea la conexión OLEDB para el archivo de Excel 
            Dim CadenadeConexionExcel As String = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=" & ArchivoExcel & ";Extended Properties=""Excel 12.0;HDR=YES;IMEX=1"""
            ConexionExcel = New OleDbConnection(CadenadeConexionExcel)
            AdaptadorExcel = New OleDbDataAdapter("select * from [Hoja1$]", ConexionExcel)
            ds = New DataSet()
            'Fill the Data Set 
            AdaptadorExcel.Fill(ds)
            'Set DataSource of DataGridView 
            Lista.DataSource = ds.Tables(0).Copy
            ds.Dispose()
            AdaptadorExcel.Dispose()
            ConexionExcel.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dtgvp.Visible = False
            btn_ajustar.Enabled = False
        End Try

    End Sub

    Private Sub ObtenerArchivo(sender As Object, e As System.ComponentModel.CancelEventArgs)

        DireccionArchivo = VentanaArchivo.FileName
        txt_ruta.Text = DireccionArchivo
        ExportarExcelADGV(dtgvp, DireccionArchivo)

        For i As Integer = dtgvp.Rows.Count - 1 To 0 Step -1

            Dim row As DataGridViewRow = dtgvp.Rows(i)

            If (row.Cells(1).Value Is DBNull.Value) Then
                dtgvp.Rows.Remove(row)
            End If
        Next
        dtgvp.Visible = True
        btn_ajustar.Enabled = True

    End Sub



    Sub insertamovimientos()


        cnn.Close()


        Dim command As New SqlCommand("Sp_AjustaInventarioMov", cnn)
        cnn.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        command.CommandType = CommandType.StoredProcedure

        Try

            For Each fila In dtgvp.Rows


                command.Parameters.Clear()


                command.Parameters.AddWithValue("@Codigo", (fila.Cells(0).Value))
                command.Parameters.AddWithValue("@Cantidad", (fila.Cells(1).Value))

                command.Parameters.AddWithValue("@variable", 1)


                command.ExecuteNonQuery()

            Next

            MessageBox.Show("Precios cargados y actualizados", "¡Correcto!", MessageBoxButtons.OK)

            dtgvp.Visible = False
            btn_ajustar.Enabled = False
            txt_ruta.Clear()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
            dtgvp.Visible = False
            btn_ajustar.Enabled = False
            txt_ruta.Clear()

        Finally
            ' MessageBox.Show("Ocurrió un problema, contacte al área de sistemas.", "Aviso")
            cnn.Close()

        End Try
    End Sub

    Private Sub btn_ajustar_Click(sender As Object, e As EventArgs) Handles btn_ajustar.Click

        insertamovimientos()
    End Sub

End Class