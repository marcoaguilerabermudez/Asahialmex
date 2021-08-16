Imports System.Data.SqlClient

Public Class ReimprimeMedida


    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection

    Public cadenagi As String
    Public cadenaCgiro As String
    Public cnn2 As SqlConnection

    Dim variableaccion As Integer


    Private Sub ReimprimeMedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        txt_folio.Text = Modulo_reimprimedisciplinaria.id
        muestraetiqueta()
    End Sub


    Sub muestraetiqueta()
        Try
            Dim lista As New List(Of String)
            cnn.Close()
            cnn.Open()
            Dim SSel As String



            SSel = ("


declare @id as int
set @id = " & txt_folio.Text & "




 select top 1 vig.CLAVE, RTRIM(LTRIM(NOMBREN)) + ' ' + RTRIM(LTRIM(NOMBREP)) + ' ' + RTRIM(LTRIM(NOMBREM)) AS Empleado
,descripcion_depto
,DESCRIPCION_PUESTO
,Turno = CASE (select TOP 1 ETT.CATALOGO  from giro.[asahi16].[Supervisor_giro].[Empturno] ETT
  where ett.clave = vig.CLAVE and ett.FECHA_ENTRADA <= GETDATE()
  order by ETT.FECHA_ENTRADA desc)/1 /*EM.TURNO*/
   when 1 then 'Matutino'
   when 2 then 'Vespertino'
   when 3 then 'Nocturno'
   when 4 then 'Administrativo'
   when 5 then 'Mazda día'
   when 6 then 'Mazda noche'
   when 7 then '12 M'
   when 8 then '12 N'
   when 9 then 'Descanso'
   else 'Error'
   end
   ,INGRESO
   ,rh.Id_medida as 'id'
   ,rh.Fecha_Aplicacion 
   ,amon.Nombre as 'Amonestacion'
   ,Comentarios as 'FaltaCometida'
   ,rh.Clave_disciplinaria as 'Articulo'
   ,dis.Nombre as 'Infraccion'
   ,case
   when dis.Termino = 0 then 'Obligación'
   when dis.Termino = 1 then 'Prohibición'
   end as 'Reglamento'
   ,rh.antecedentes
from giro.asahi16.Supervisor_giro.VistaEmpleadosVigenciaYPuesto vig
join [AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] rh
on rh.id_empleado = vig.clave
join [AsahiSystem].[dbo].[Rh_TipoAmonestacion]  amon
on amon.Id_tipo = rh.Id_tipoAmonestacion
join [AsahiSystem].[dbo].[Rh_TiposDisciplinaria] dis
on dis.Clave = rh.Clave_disciplinaria and dis.Termino = rh.Tipo_disciplinaria
where 
--[Fecha_Aplicacion] > INGRESO and DATEPART(year,[Fecha_Aplicacion]) = @año and 
 Id_medida = @id
order by id_medida desc")

            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, cnn)
            da.Fill(ds)


            txt_clave.Text = ds.Tables(0).Rows(0).Item(0)
            txt_nombre.Text = ds.Tables(0).Rows(0).Item(1)
            cbx_tipo.Text = ds.Tables(0).Rows(0).Item(8)
            txt_articulo.Text = ds.Tables(0).Rows(0).Item(10)
            txt_articuloinfracionado.Text = ds.Tables(0).Rows(0).Item(11)
            txt_faltacometida.Text = ds.Tables(0).Rows(0).Item(9)
            txt_antecedente.Text = ds.Tables(0).Rows(0).Item(13)

            cnn.Close()

        Catch ex As Exception
            '  MessageBox.Show(ex.ToString)

        End Try
    End Sub


    Sub procesa()


        cnn.Close()
        cnn.Open()

        Dim procesa As SqlCommand = New SqlCommand("
if @variable = 0
update [AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] set Aplica = 1 , fecha_aplicacion = getdate()
where Id_medida = @id

else if @variable = 1
update [AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] set Aplica = 2
where Id_medida = @id

else if @variable = 2

update [AsahiSystem].[dbo].[Rh_MedidasDisciplinarias] set antecedentes = @antecedentes
where Id_medida = @id


", cnn)



        Try


            procesa.Parameters.Clear()
            procesa.Parameters.Add("@id", SqlDbType.Int).Value = txt_folio.Text
            procesa.Parameters.Add("@variable", SqlDbType.Int).Value = variableaccion
            procesa.Parameters.Add("@antecedentes", SqlDbType.Text).Value = txt_antecedente.Text
            procesa.ExecuteNonQuery()

            If variableaccion = 0 Then
                MessageBox.Show("Correcto, Medida Disciplinaria aplicada", "¡Aviso!")
            ElseIf variableaccion = 1 Then
                MessageBox.Show("Correcto, Medida Disciplinaria eliminada", "¡Aviso!")
            ElseIf variableaccion = 2 Then
                MessageBox.Show("Correcto, Medida Disciplinaria editada", "¡Aviso!")

            End If

            Dim ownerForm As MedidasDisciplinarias = Me.Owner
            ownerForm.cargagrid()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar registro, consulte al administrador")
            MessageBox.Show(ex.ToString)
            cnn.Close()
        Finally
            cnn.Close()
        End Try



    End Sub

    Private Sub btn_aplicar_Click(sender As Object, e As EventArgs) Handles btn_aplicar.Click
        variableaccion = 0
        procesa()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        variableaccion = 1
        procesa()
    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        ContenedorReporteMedidaDisciplinaria.clave = txt_clave.Text
        ContenedorReporteMedidaDisciplinaria.id = txt_folio.Text
        ContenedorReporteMedidaDisciplinaria.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        variableaccion = 2
        procesa()
    End Sub




End Class