Imports System.Data.SqlClient

Public Class Requerimientos_principal
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer


    Public cnn As SqlConnection
    Public cnn2 As SqlConnection
    Public cadenaConex As String
    Public cadenaCExpress As String

    Dim a As String



    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub
    Private Sub Requerimientos_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        dtp1.Value = DateAdd(DateInterval.Day, -10, dtp2.Value)



        Select Case depto
            Case "03"
                cbx_area.Text = "ASEGURAMIENTO DE CALIDAD F1"
            Case "04"
                cbx_area.Text = "ASUNTOS GENERALES"
            Case "05"
                cbx_area.Text = "ATENCIÓN AL CLIENTE"
            Case "06"
                cbx_area.Text = "COMPRAS"
            Case "07"
                cbx_area.Text = "CONTABILIDAD"
            Case "08"
                cbx_area.Text = "CONTROL DE MANUFACTURA"
            Case "09"
                cbx_area.Text = "CONTROL DE PRODUCCION"
            Case "16"
                cbx_area.Text = "MOLDES"
            Case "18"
                cbx_area.Text = "SEGURIDAD"
            Case "19"
                cbx_area.Text = "SISTEMAS IT"
            Case "27"
                cbx_area.Text = "INGENIERÍA MAQUINADO"
            Case "28"
                cbx_area.Text = "INGENIERÍA FUNDICIÓN"
            Case "31"
                cbx_area.Text = "INSPECCION PRODUCCION"
            Case "32"
                cbx_area.Text = "FUNDICION 1"
            Case "33"
                cbx_area.Text = "FUNDICION 2"
            Case "34"
                cbx_area.Text = "ACABADO"
            Case "35"
                cbx_area.Text = "ACABADO 2"
            Case "36"
                cbx_area.Text = "CONTROL DE CLIENTES"
            Case "37"
                cbx_area.Text = "MANTENIMIENTO DE PLANTA"
            Case "38"
                cbx_area.Text = "MANTENIMIENTO FUNDICION"
            Case "39"
                cbx_area.Text = "MANTENIMIENTO MAQUINADO"
            Case "40"
                cbx_area.Text = "MAQUINADO F2"
            Case "41"
                cbx_area.Text = "INSPECCIÓN FUNDICION"
            Case "42"
                cbx_area.Text = "INSPECCIÓN MAQUINADO"
            Case "43"
                cbx_area.Text = "MANTENIMIENTO FUNDICION"
            Case "44"
                cbx_area.Text = "FUSION"
            Case "46"
                cbx_area.Text = "ASEGURAMIENTO DE CALIDAD F2"
            Case "47"
                cbx_area.Text = "REPARACION DE MOLDES"
            Case "48"
                cbx_area.Text = "PRODUCCIÓN"
        End Select



        If p_vales = 0 Then

            Me.Text = "Mis requerimientos"
            cbx_area.Enabled = False
            lbl_area.Enabled = False
            cargagrid()

        ElseIf p_vales = 1 Then

            Me.Text = "Requerimientos"
            cbx_area.Enabled = True
            lbl_area.Enabled = True

        End If


    End Sub



    Sub cargagrid()

        cnn.Close()

        cnn.Open()

        Dim da As New SqlDataAdapter("Sp_MuestraRequerimientosPrincipal", cnn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure

        If p_vales = 0 Then
            da.SelectCommand.Parameters.AddWithValue("@depto", depto)
        Else
            da.SelectCommand.Parameters.AddWithValue("@depto", a)
        End If

        da.SelectCommand.Parameters.AddWithValue("@inicial", dtp1.Value.ToShortDateString)
        da.SelectCommand.Parameters.AddWithValue("@final", dtp2.Value.ToShortDateString)


        Dim dt As New DataTable
        da.Fill(dt)
        dtgvp.DataSource = dt
        dtgvp.Columns("Area_usuario").Visible = False
        dtgvp.Columns("centro_costo").Visible = False
        dtgvp.Columns("Comentarios").Visible = False
        dtgvp.Columns("Estado").Visible = False
        dtgvp.Columns("Usuario").Visible = False
        dtgvp.Columns("Documentos").Visible = False
        dtgvp.Columns("Requerimiento").ReadOnly = True
        dtgvp.Columns("Empleado").ReadOnly = True
        dtgvp.Columns("Departamento").ReadOnly = True
        dtgvp.Columns("Fecha").ReadOnly = True



        dtgvp.Columns("Empleado").Width = 320
        dtgvp.Columns("Departamento").Width = 170
        dtgvp.Columns("Fecha").Width = 60
        cnn.Close()

        colores()


    End Sub

    Private Sub btn_solicitar_Click(sender As Object, e As EventArgs) Handles btn_solicitar.Click
        cargagrid()
    End Sub


    Private Sub dtgvp_CellContentClick0(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellClick

        If e.ColumnIndex = 0 Then
            Try
                System.Diagnostics.Process.Start(Me.dtgvp.Rows(e.RowIndex).Cells("Documentos").Value.ToString())
            Catch ex As Exception
                MessageBox.Show("No tiene ningún documento anexado", "¡Aviso!")
            End Try
        Else
            Try
                lbl_req.Text = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
                colores()
            Catch
            End Try

        End If
    End Sub

    Private Sub dtgvp_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.RowEnter
        lbl_req.Text = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
        colores()
    End Sub

    Private Sub dtgvp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvp.CellDoubleClick
        Modulo_Req_principal.e_id = Me.dtgvp.Rows(e.RowIndex).Cells(1).Value.ToString()
        Dim Req_mov As New Requerimientos_movimientos(id, depto, permiso, nombre, p_vales)
        Req_mov.Show()
    End Sub

    Private Sub cbx_area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_area.SelectedIndexChanged
        Select Case cbx_area.Text
            Case "ASEGURAMIENTO DE CALIDAD F1"
                a = "03"
            Case "ASUNTOS GENERALES"
                a = "04"
            Case "ATENCIÓN AL CLIENTE"
                a = "05"
            Case "COMPRAS"
                a = "06"
            Case "CONTABILIDAD"
                a = "07"
            Case "CONTROL DE MANUFACTURA"
                a = "08"
            Case "CONTROL DE PRODUCCION"
                a = "09"
            Case "MOLDES"
                a = "16"
            Case "SEGURIDAD"
                a = "18"
            Case "SISTEMAS IT"
                a = "19"
            Case "INGENIERÍA MAQUINADO"
                a = "27"
            Case "INGENIERÍA FUNDICIÓN"
                a = "28"
            Case "INSPECCION PRODUCCION"
                a = "31"
            Case "FUNDICION 1"
                a = "32"
            Case "FUNDICION 2"
                a = "33"
            Case "ACABADO"
                a = "34"
            Case "ACABADO 2"
                a = "35"
            Case "CONTROL DE CLIENTES"
                a = "36"
            Case "MANTENIMIENTO DE PLANTA"
                a = "37"
            Case "MANTENIMIENTO FUNDICION"
                a = "38"
            Case "MANTENIMIENTO MAQUINADO"
                a = "39"
            Case "MAQUINADO F2"
                a = "40"
            Case "INSPECCIÓN FUNDICION"
                a = "41"
            Case "INSPECCIÓN MAQUINADO"
                a = "42"
            Case "MANTENIMIENTO FUNDICION"
                a = "43"
            Case "FUSION"
                a = "44"
            Case "ASEGURAMIENTO DE CALIDAD F2"
                a = "46"
            Case "REPARACION DE MOLDES"
                a = "47"
            Case "PRODUCCIÓN"
                a = "48"
        End Select

    End Sub


    Sub colores()

        Try
            For Each row As DataGridViewRow In Me.dtgvp.Rows

                If row.Cells(“Estado”).Value = 0 Then
                    row.DefaultCellStyle.BackColor = Color.White
                ElseIf row.Cells(“Estado”).Value = 1 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next
        Catch
        End Try
    End Sub

End Class

Module Modulo_Req_principal

    Public e_id As Integer




End Module

