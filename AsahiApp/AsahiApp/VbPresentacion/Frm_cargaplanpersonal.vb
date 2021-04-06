Imports System.Data.SqlClient

Public Class Frm_cargaplanpersonal

    Dim a As String
    Dim b As String

    Dim x As String
    Dim y As Integer

    Dim semana As Integer
    Dim inicio As String
    Dim fin As String

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cn As SqlConnection
    Public cnn As SqlConnection


    Private Sub Frm_cargaplanpersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress
            Me.cnn = conexion.cadenagiro
        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor
            Me.cnn = conexion.cadenagirofor
        End If



        cbx_año.Text = Today.Year.ToString()
        l3.Text = Today.Month.ToString()
        a = l3.Text
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
        llenacombodepto()
        fechas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Enabled = True
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
        l3.Text = b

        Dim Frmespera As New Frmwait
        Frmespera.Show()
        Frmespera.BringToFront()
        Frmespera.WindowState = FormWindowState.Normal
        etiquetas()
        etiquetas2()
        diferencia()
        Frmespera.Close()

    End Sub

    Sub etiquetas()
        Try
            Dim Cnn As New SqlConnection("data source =GIRO\SQL2008 ;initial catalog=asahi16 ;user id=sa;password=Pa55word")
            Cnn.Open()
            Dim SSel As String
            Dim parametro1 As String
            parametro1 = cbx_depto.Text
            Dim parametro2 As Integer
            parametro2 = cbx_año.Text
            Dim parametro3 As Integer
            parametro3 = b
            SSel = ("  select  rh.id_puesto , rh.cantidad , de.DESCRIPCION
     FROM [asahi16].[dbo].[Rh_totalpuestos] rh
	 join [asahi16].[Supervisor_giro].[DEPTO] de
	 on de.CLAVE = rh.Id_area
	 where de.DESCRIPCION = '" & parametro1 & "' and mes = " & parametro3 & " and año = " & parametro2 & " and id_tipo = 0
order by rh.id_puesto")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, Cnn)
            da.Fill(ds)
            txt_gerente.Text = ds.Tables(0).Rows(0).Item(1)
            txt_asistente.Text = ds.Tables(0).Rows(1).Item(1)
            txt_supervisor.Text = ds.Tables(0).Rows(2).Item(1)
            txt_lad.Text = ds.Tables(0).Rows(3).Item(1)
            txt_staff.Text = ds.Tables(0).Rows(4).Item(1)
            txt_lid.Text = ds.Tables(0).Rows(5).Item(1)
            txt_operador.Text = ds.Tables(0).Rows(6).Item(1)
            txt_cor.Text = ds.Tables(0).Rows(7).Item(1)
            txt_tra.Text = ds.Tables(0).Rows(8).Item(1)

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un departamento válido.", "¡Aviso!")
            ''   MessageBox.Show(ex.ToString)
            Panel1.Enabled = False
        End Try
    End Sub


    Sub etiquetas2()


        Try
            Dim Cnn As New SqlConnection("data source =GIRO\SQL2008 ;initial catalog=asahi16 ;user id=sa;password=Pa55word")
            Cnn.Open()
            Dim SSel As String

            SSel = ("  
     
     declare @depto as int
set @depto = " & y & "


if @depto = 101
begin

	  select
 (select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 4  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Gerente'

  ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 2  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Coordinador'


  ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 11  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Traductor'


   ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 1  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Asistente de Gerente'

   ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 9  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Supervisor'


   ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 16  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Líder Admin'


   ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 8  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Staff'


    ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 5  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Líder'


	,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 6  AND departamento in (19,20) and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Operador'

	end
	else 
	begin
		  select
 (select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 4  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0) ) as 'Gerente'

  ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 2  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Coordinador'


  ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 11  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Traductor'


   ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 1  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Asistente de Gerente'

   ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 9  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Supervisor'


   ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 16  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Líder Admin'


   ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 8  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Staff'


    ,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 5  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Líder'


	,(select count(clave) from  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] where PUESTO = 6  AND departamento = @depto and vigencia = 'VIGENTE' AND (AVISO IS NULL OR AVISO = 0)) as 'Operador'

	end
     
     ")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, Cnn)
            da.Fill(ds)
            txt_gerente2.Text = ds.Tables(0).Rows(0).Item(0)
            txt_asistente2.Text = ds.Tables(0).Rows(0).Item(3)
            txt_supervisor2.Text = ds.Tables(0).Rows(0).Item(4)
            txt_lad2.Text = ds.Tables(0).Rows(0).Item(5)
            txt_staff2.Text = ds.Tables(0).Rows(0).Item(6)
            txt_lid2.Text = ds.Tables(0).Rows(0).Item(7)
            txt_operador2.Text = ds.Tables(0).Rows(0).Item(8)
            txt_cor2.Text = ds.Tables(0).Rows(0).Item(1)
            txt_tra2.Text = ds.Tables(0).Rows(0).Item(2)

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un departamento válido.", "¡Aviso!")
            MessageBox.Show(ex.ToString)
            Panel2.Enabled = False
        End Try
    End Sub



    Sub cargar()
        Dim conexion As SqlConnection = New SqlConnection("data source =GIRO\SQL2008 ;initial catalog=asahi16 ;user id=sa;password=Pa55word")
        Dim cmd As New SqlCommand("update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad1 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end
and mes = @mes and año = @año and Id_puesto = 1 and id_tipo = 0


update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad2 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end
and mes = @mes and año = @año and Id_puesto = 2 and id_tipo = 0


update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad3 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end
and mes = @mes and año = @año and Id_puesto = 3 and id_tipo = 0

update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad4 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end
and mes = @mes and año = @año and Id_puesto = 4 and id_tipo = 0

update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad5 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end
and mes = @mes and año = @año and Id_puesto = 5 and id_tipo = 0

update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad6 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end
and mes = @mes and año = @año and Id_puesto = 6 and id_tipo = 0


update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad7 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end 
and mes = @mes and año = @año and Id_puesto = 7 and id_tipo = 0



update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad8 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end
and mes = @mes and año = @año and Id_puesto = 8 and id_tipo = 0


update [asahi16].[dbo].[Rh_totalpuestos] set cantidad = @cantidad9 where
Id_area = 
case 
when @catalogodepartamento = 'ATENCIÓN AL CLIENTE' then '05'
when @catalogodepartamento = 'MOLDES' then '16'
when @catalogodepartamento = 'CONTROL DE MANUFACTURA'then '08'
when @catalogodepartamento = 'GERENCIA' then '11'
when @catalogodepartamento = 'FUNDICIÓN' then '10'
when @catalogodepartamento = 'ALMACÉN' then '02'
when @catalogodepartamento = 'COMPRAS' then '06'
when @catalogodepartamento = 'SISTEMAS IT' then '19'
when @catalogodepartamento = 'AAJ-CALIDAD' then '23'
when @catalogodepartamento = 'CONTABILIDAD' then '07'
when @catalogodepartamento = 'SEGURIDAD' then '18'
when @catalogodepartamento = 'AAJ-FUNDICIÓN' then '02'
when @catalogodepartamento = 'CONTROL DE PRODUCCION' then '09'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F1' then '03'
when @catalogodepartamento = 'ASEGURAMIENTO DE CALIDAD F2' then '46'
when @catalogodepartamento = 'MANTENIMIENTO' then '14'
when @catalogodepartamento = 'MAQUINADO' then '15'
when @catalogodepartamento = 'INGENIERÍA-MAQUINADO' then '27'
when @catalogodepartamento = 'ASUNTOS GENERALES' then '04'
when @catalogodepartamento = 'ADMINISTRACIÓN' then '01'
when @catalogodepartamento = 'PRESIDENCIA' then '17'
when @catalogodepartamento = 'INGENIERÍA-FUNDICIÓN' then '28'
when @catalogodepartamento = 'INSPECCION PRODUCCION' then '31'
when @catalogodepartamento = 'FUNDICION 1' then '32'
when @catalogodepartamento = 'FUNDICION 2' then '33'
when @catalogodepartamento = 'ACABADO 1' then '34'
when @catalogodepartamento = 'ACABADO 2' then '35'
when @catalogodepartamento = 'CONTROL DE CLIENTES' then '36'
when @catalogodepartamento = 'MANTENIMIENTO DE PLANTA' then '37'
when @catalogodepartamento = 'MANTENIMIENTO FUNDICION' then '38'
when @catalogodepartamento = 'MANTENIMIENTO MAQUINADO' then '39'
when @catalogodepartamento = 'MAQUINADO F2' then '40'
when @catalogodepartamento = 'INSPECCIÓN FUNDICION' then '41'
when @catalogodepartamento = 'INSPECCIÓN MAQUINADO' then '42'
when @catalogodepartamento = 'MAQUINADO F1' then '43'
when @catalogodepartamento = 'FUSION F1' then '44'
when @catalogodepartamento = 'FUSION F2' then '45'
end
and mes = @mes and año = @año and Id_puesto = 9 and id_tipo = 0
", conexion)
        conexion.Open()

        Dim Pregunta As Integer



        Pregunta = MsgBox("¿Desea guardar los cambios?.", vbYesNo + vbExclamation + vbDefaultButton2, "¡Va a guardar cambios!")

        If Pregunta = vbYes Then
            Try



                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@cantidad1", txt_gerente.Text)
                cmd.Parameters.AddWithValue("@cantidad2", txt_asistente.Text)
                cmd.Parameters.AddWithValue("@cantidad3", txt_supervisor.Text)
                cmd.Parameters.AddWithValue("@cantidad4", txt_lad.Text)
                cmd.Parameters.AddWithValue("@cantidad5", txt_staff.Text)
                cmd.Parameters.AddWithValue("@cantidad6", txt_lid.Text)
                cmd.Parameters.AddWithValue("@cantidad7", txt_operador.Text)
                cmd.Parameters.AddWithValue("@cantidad8", txt_cor.Text)
                cmd.Parameters.AddWithValue("@cantidad9", txt_tra.Text)
                cmd.Parameters.AddWithValue("@año", cbx_año.Text)
                cmd.Parameters.AddWithValue("@mes", l3.Text)
                cmd.Parameters.AddWithValue("@catalogodepartamento", cbx_depto.Text)



                Dim Frmespera As New Frmwait
                Frmespera.Show()
                Frmespera.BringToFront()
                Frmespera.WindowState = FormWindowState.Normal
                cmd.ExecuteNonQuery()
                etiquetas()
                etiquetas2()
                diferencia()

                Frmespera.Close()




                MsgBox("¡Cambios Guardados!", vbInformation, "¡Correcto!")
            Catch ex As Exception
                MessageBox.Show("Error en el sistema, cierre la ventana e intente de nuevo")
                MessageBox.Show(ex.ToString)
                conexion.Close()

            Finally
                conexion.Close()
            End Try
        Else
            conexion.Close()
        End If
    End Sub


    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click


        cargar()


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub cbx_depto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_depto.SelectedIndexChanged
        x = cbx_depto.Text
        Select Case x
            Case "ATENCIÓN AL CLIENTE"
                y = 5
            Case "MOLDES"
                y = 16
            Case "CONTROL DE MANUFACTURA"
                y = 8
            Case "ASEGURAMIENTO DE CALIDAD F1"
                y = 3
            Case "ASUNTOS GENERALES"
                y = 4
            Case "COMPRAS"
                y = 6
            Case "CONTABILIDAD"
                y = 7
            Case "CONTROL DE PRODUCCION"
                y = 9
            Case "SEGURIDAD"
                y = 18
            Case "SISTEMAS IT"
                y = 19
            Case "INGENIERÍA-MAQUINADO"
                y = 27
            Case "INGENIERÍA-FUNDICIÓN"
                y = 28
            Case "INSPECCION PRODUCCION"
                y = 31
            Case "FUNDICION 1"
                y = 32
            Case "FUNDICION 2"
                y = 33
            Case "ACABADO 1"
                y = 34
            Case "ACABADO 2"
                y = 35
            Case "CONTROL DE CLIENTES"
                y = 36
            Case "MANTENIMIENTO DE PLANTA"
                y = 37
            Case "MANTENIMIENTO FUNDICION"
                y = 38
            Case "MANTENIMIENTO MAQUINADO"
                y = 39
            Case "MAQUINADO F2"
                y = 40
            Case "INSPECCIÓN FUNDICION"
                y = 41
            Case "INSPECCIÓN MAQUINADO"
                y = 42
            Case "MAQUINADO F1"
                y = 43
        End Select




    End Sub

    Sub llenacombodepto()
        Try


            Dim Dt As DataTable

            Dim Da As New SqlDataAdapter
            Dim Cmd As New SqlCommand


            With Cmd

                .CommandType = CommandType.Text
                .CommandText = "	
SELECT 
      CONVERT(VARCHAR,DESCRIPCION) as 'Depto'
  FROM [asahi16].[Supervisor_giro].[DEPTO]
  where CENTRO_COSTO not in (16) and clave not in (36,44,46,47)
  union
  select 'X' as 'Depto'
"
                .Connection = cnn

            End With

            Da.SelectCommand = Cmd

            Dt = New DataTable

            Da.Fill(Dt)

            With cbx_depto
                .DataSource = Dt
                .DisplayMember = "Depto"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Sub diferencia()
        txt_rgerente.Text = CInt(txt_gerente.Text - txt_gerente2.Text)
        txt_rcoordinador.Text = CInt(txt_cor.Text - txt_cor2.Text)
        txt_rtraductor.Text = CInt(txt_tra.Text - txt_tra2.Text)
        txt_rasistente.Text = CInt(txt_asistente.Text - txt_asistente2.Text)
        txt_rsuper.Text = CInt(txt_supervisor.Text - txt_supervisor2.Text)
        txt_rlideradm.Text = CInt(txt_lad.Text - txt_lad2.Text)
        txt_rstaff.Text = CInt(txt_staff.Text - txt_staff2.Text)
        txt_rlider.Text = CInt(txt_lid.Text - txt_lid2.Text)
        txt_roperador.Text = CInt(txt_operador.Text - txt_operador2.Text)
    End Sub

    Sub fechas()

        semana = (DateDiff(DateInterval.WeekOfYear, New DateTime(Date.Now.Year, 1, 1), Date.Now) + 1)
        Dim fecha As Date = Today.ToShortDateString
        Dim pivote As Integer = Today.DayOfWeek

        Select Case pivote

            Case 1

                inicio = Format(Today.Date, "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 6, fecha), "dd/MM/yyyy")

            Case 2

                inicio = Format(DateAdd(DateInterval.Day, -1, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 5, fecha), "dd/MM/yyyy")

            Case 3

                inicio = Format(DateAdd(DateInterval.Day, -2, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 4, fecha), "dd/MM/yyyy")

            Case 4

                inicio = Format(DateAdd(DateInterval.Day, -3, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 3, fecha), "dd/MM/yyyy")

            Case 5

                inicio = Format(DateAdd(DateInterval.Day, -4, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 2, fecha), "dd/MM/yyyy")

            Case 6

                inicio = Format(DateAdd(DateInterval.Day, -5, fecha), "dd/MM/yyyy")
                fin = Format(DateAdd(DateInterval.Day, 1, fecha), "dd/MM/yyyy")

            Case 0

                inicio = Format(DateAdd(DateInterval.Day, -6, fecha), "dd/MM/yyyy")
                fin = Format(fecha, "dd/MM/yyyy")

        End Select
        '  MessageBox.Show(semana)
    End Sub

    Private Sub btn_principal_Click(sender As Object, e As EventArgs) Handles btn_principal.Click
        ContenedorReporteSemanalPrincipal.mes = l3.Text
        ContenedorReporteSemanalPrincipal.año = cbx_año.Text
        ContenedorReporteSemanalPrincipal.inicio = inicio
        ContenedorReporteSemanalPrincipal.fin = fin
        ContenedorReporteSemanalPrincipal.semana = semana
        ContenedorReporteSemanalPrincipal.Show()
    End Sub
End Class