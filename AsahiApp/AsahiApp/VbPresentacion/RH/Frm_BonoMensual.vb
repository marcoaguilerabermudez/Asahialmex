Imports System.Data.SqlClient
Imports Negocio
Imports Clases
Public Class Frm_BonoMensual
#Region "Variables de clase"
    Dim cadConex As SqlConnection
    Dim cadenaConex As String
    Dim open As Boolean
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_BonoMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
        Dgv_BonoMensual.Columns("totalBono").Frozen = True
        ModificarDiaInicio()
    End Sub
    Private Sub Dtp_FechaInicioSemana_TextChanged(sender As Object, e As EventArgs) Handles Dtp_FechaInicioSemana.TextChanged
        If Dtp_FechaInicioSemana.Value < DateTime.Now Or Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyy") = Format(DateTime.Now, "dd/MM/yyy") Then

            Dim conex As New conexion
            Dim cadenaConexContpaq = conex.conexionContpaq 'Conexion a la BD de contpaq solo se va a usar para traer las fechas que corresponden la semana que se manda
            Dim fechaI As Date = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            Dim NPrenomina As New NPrenomina()
            Dim hrs As New Horarios()

            Lbl_año.Text = Format(fechaI, "yyyy")

            hrs = NPrenomina.RecuperarDiasSemana(cadenaConexContpaq, fechaI)

        Else
            MsgBox("Tienes que ingresar una fecha menor a la actual")
            ModificarDiaInicio()
            Dgv_BonoMensual.DataSource = Nothing
            Dgv_BonoMensual.Refresh()
        End If
    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        If open = True Then
            Dim fecha As Date
            Dim lstEmp As New LEmpleado

            fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            ProcesoBonoMensual(lstEmp, fecha)
        End If
    End Sub
#End Region
#Region "Recuperar"
    Private Function RecuperarEmpleados(ByVal fecha As Date) As LEmpleado
        Dim NPre As New NPrenomina()
        Dim conex As New conexion
        Dim cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008

        Return NPre.EmpleadoGlobalRecuperar(cadConex, fecha)
    End Function
#End Region
#Region "Procesos Varios"
    Private Sub ProcesoBonoMensual(ByVal lstEmp As LEmpleado, ByVal fecha As Date)
        lstEmp = RecuperarEmpleados(fecha)
        If lstEmp(0).Err = False Then

        End If
    End Sub
    Private Sub ModificarDiaInicio()
        Dim fecha As Date
        Dim dia As String

        dia = DateTime.Now

        fecha = Format(DateSerial(Year(dia), Month(dia) + 0, 0), "dd/MM/yyyy") 'Format(DateAdd(DateInterval.Day, res, DateTime.Now()), "dd/MM/yyyy")

        Dtp_FechaInicioSemana.Value = fecha
    End Sub
#End Region
End Class