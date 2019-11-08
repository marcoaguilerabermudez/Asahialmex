Imports System.Data.SqlClient

Public Class SubventanaOee
    Dim valor As Integer
    Dim valor2 As String
    Dim subproceso As Integer
    Dim id_error As Integer


    Private Sub SubventanaOee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_fecha.Text = Modulo_detalle.parametro
        lbl_hora.Text = Modulo_detalle.parametro2
        lbl_turno.Text = Modulo_detalle.parametro3
        lbl_piezas.Text = Modulo_detalle.parametro4
        lbl_proceso.Text = Modulo_detalle.parametro5

        If lbl_proceso.Text = "FUNDICION" Then
            GroupBox3.Enabled = False
            rbtn_0.Checked = True
            subproceso = 0

        ElseIf lbl_proceso.Text = "MAQUINADO" OrElse lbl_proceso.Text = "LEAKTEST" OrElse lbl_proceso.Text = "ENSAMBLE" Then
            GroupBox3.Enabled = True
            rbtn_0.Checked = False
            rbtn_0.Enabled = False
            subproceso = 1


        ElseIf lbl_proceso.Text = "ACABADO" Then
            GroupBox3.Enabled = True
            rbtn_0.Checked = False
            rbtn_0.Enabled = False
            RadioButton2.Text = "Acabado"
            subproceso = 1
        End If

        valor = 1
        llenacombodefectog()

    End Sub

    Private Sub txtIdPaciente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub rbt_cantidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_cantidad.CheckedChanged
        If lbl_proceso.Text = "FUNDICION" Then
            GroupBox3.Enabled = False
            rbtn_0.Checked = True
        ElseIf lbl_proceso.Text = "MAQUINADO" OrElse lbl_proceso.Text = "LEAKTEST" OrElse lbl_proceso.Text = "ENSAMBLE" Then


            GroupBox3.Enabled = True
            rbtn_0.Checked = False
            rbtn_0.Enabled = False
            rbtn_fundi.Checked = True

        ElseIf lbl_proceso.Text = "ACABADO" Then
            GroupBox3.Enabled = True
            rbtn_0.Checked = False
            rbtn_0.Enabled = False



        End If

        valor = 1

        llenacombodefectog()

    End Sub

    Private Sub rbt_tiempo_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_tiempo.CheckedChanged
        If lbl_proceso.Text = "FUNDICION" Then
            GroupBox3.Enabled = False
            rbtn_0.Checked = True
        ElseIf lbl_proceso.Text = "MAQUINADO" OrElse lbl_proceso.Text = "LEAKTEST" OrElse lbl_proceso.Text = "ENSAMBLE" Then
            GroupBox3.Enabled = False
            rbtn_0.Checked = True
            rbtn_0.Enabled = True
        ElseIf lbl_proceso.Text = "ACABADO" Then
            GroupBox3.Enabled = False
            rbtn_0.Checked = True
            rbtn_0.Enabled = True

        End If
        valor = 2

        llenacombodefectog()

    End Sub

    Sub llenacombodefectog()
        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "
declare @var as varchar(25)
set @var = '" & lbl_proceso.Text & "'



if @var = 'FUNDICION'
BEGIN
SELECT DISTINCT DEFECTOG FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & "  AND FUNDICION = 1
END
ELSE if @var = 'MAQUINADO'
BEGIN
SELECT DISTINCT DEFECTOG FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & "  AND MAQUINADO = 1
END
ELSE if @var = 'LEAKTEST'
BEGIN
SELECT DISTINCT DEFECTOG FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & " AND LEAK = 1
END
ELSE if @var = 'ENSAMBLE'
BEGIN
SELECT DISTINCT DEFECTOG FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & " AND ENSAMBLE = 1
END
ELSE if @var = 'ACABADO'
BEGIN
SELECT DISTINCT DEFECTOG FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & " AND ACABADO = 1
END"
            .Connection = CapturaOEE.Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_errorg
            .DataSource = Dt
            .DisplayMember = "DEFECTOG"
            '.ValueMember = "id"
        End With
        'totales()
        llenacombodefectod()
    End Sub


    Sub llenacombodefectod()
        Dim Dt As DataTable

        Dim Da As New SqlDataAdapter
        Dim Cmd As New SqlCommand
        With Cmd
            .CommandType = CommandType.Text
            .CommandText = "
declare @var as varchar(25)
set @var = '" & lbl_proceso.Text & "'



if @var = 'FUNDICION'
BEGIN
SELECT DISTINCT DefectoD FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & "  AND FUNDICION = 1 and DefectoG = N'" & cbx_errorg.Text & "'
END
ELSE if @var = 'MAQUINADO'
BEGIN
SELECT DISTINCT DefectoD FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & "  AND MAQUINADO = 1 and DefectoG = N'" & cbx_errorg.Text & "'
END
ELSE if @var = 'LEAKTEST'
BEGIN
SELECT DISTINCT DefectoD FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & " AND LEAK = 1 and DefectoG = N'" & cbx_errorg.Text & "'
END
ELSE if @var = 'ENSAMBLE'
BEGIN
SELECT DISTINCT DefectoD FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & " AND ENSAMBLE = 1 and DefectoG = N'" & cbx_errorg.Text & "'
END
ELSE if @var = 'ACABADO'
BEGIN
SELECT DISTINCT DefectoD FROM [SistemaAAM].[dbo].[Pro_Cat_DefectosE] WHERE VALOR = " & valor & " AND SUBPROCESO = " & subproceso & " AND ACABADO = 1 and DefectoG = N'" & cbx_errorg.Text & "'
END"
            .Connection = CapturaOEE.Cn
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With cbx_error
            .DataSource = Dt
            .DisplayMember = "DefectoD"
            '.ValueMember = "id"
        End With
        'totales()
    End Sub



    Private Sub rbtn_fundi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_fundi.CheckedChanged
        subproceso = 1
        llenacombodefectog()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If lbl_proceso.Text = "MAQUINADO" OrElse lbl_proceso.Text = "LEAKTEST" OrElse lbl_proceso.Text = "ENSAMBLE" Then
            subproceso = 2
        ElseIf lbl_proceso.Text = "ACABADO" Then
            subproceso = 3
        End If
        llenacombodefectog()

    End Sub

    Private Sub rbtn_0_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_0.CheckedChanged
        subproceso = 0
        llenacombodefectog()

    End Sub

    Private Sub cbx_errorg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_errorg.SelectedIndexChanged
        llenacombodefectod()
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click

        'Try
        Dim SQL As String

        Dim Rs As SqlDataReader
        Dim Com As New SqlCommand


        Com.Connection = CapturaOEE.Cn
        CapturaOEE.Cn.Open()

        SQL = "

         select id_defecto FROM  [SistemaAAM].[dbo].[Pro_Cat_DefectosE] 
         where DefectoD = N'" & cbx_error.Text & "'
         and DefectoG = N'" & cbx_errorg.Text & "' 
         AND Valor = " & valor & " AND Subproceso = " & subproceso & "
        "

        Com = New SqlCommand(SQL, CapturaOEE.Cn)

        Rs = Com.ExecuteReader()

        Rs.Read()
        id_error = Rs(0).ToString

        Rs.Close()
        CapturaOEE.Cn.Close()
        'Catch
        'End Try

        If valor = 1 Then
            valor2 = "Pza"
            CapturaOEE.dtgvp.Rows.Add(New String() {cbx_error.Text, valor, valor2, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, id_error, lbl_piezas.Text})
            CapturaOEE.ngxhora()
            CapturaOEE.etiquetaspieza()

        ElseIf valor = 2 Then
            valor2 = "Tiempo"
            CapturaOEE.dtgvp.Rows.Add(New String() {cbx_error.Text, valor, valor2, txt_cantidad.Text, lbl_hora.Text, CapturaOEE.idh, id_error, lbl_piezas.Text})
            CapturaOEE.calculotppxhora()
            CapturaOEE.etiquetastiempo()

        End If



    End Sub
End Class