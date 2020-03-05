Imports System.Data.SqlClient

Public Class Frm_cargaplanpersonal

    Dim a As String
    Dim b As String

    Private Sub Frm_cargaplanpersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        etiquetas()
        etiquetas2()
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
	 where de.DESCRIPCION = '" & parametro1 & "' and mes = " & parametro3 & " and año = " & parametro2 & " and id_tipo = 2
order by rh.id_puesto")
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            ds.Clear()
            da = New SqlDataAdapter(SSel, Cnn)
            da.Fill(ds)
            txt_gerente2.Text = ds.Tables(0).Rows(0).Item(1)
            txt_asistente2.Text = ds.Tables(0).Rows(1).Item(1)
            txt_supervisor2.Text = ds.Tables(0).Rows(2).Item(1)
            txt_lad2.Text = ds.Tables(0).Rows(3).Item(1)
            txt_staff2.Text = ds.Tables(0).Rows(4).Item(1)
            txt_lid2.Text = ds.Tables(0).Rows(5).Item(1)
            txt_operador2.Text = ds.Tables(0).Rows(6).Item(1)
            txt_cor2.Text = ds.Tables(0).Rows(7).Item(1)
            txt_tra2.Text = ds.Tables(0).Rows(8).Item(1)

        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un departamento válido.", "¡Aviso!")
            ''MessageBox.Show(ex.ToString)
            Panel2.Enabled = False
        End Try
    End Sub


    Sub cargar2()
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
and mes = @mes and año = @año and Id_puesto = 1 


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
and mes = @mes and año = @año and Id_puesto = 2 


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
and mes = @mes and año = @año and Id_puesto = 3 

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
and mes = @mes and año = @año and Id_puesto = 4 

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
and mes = @mes and año = @año and Id_puesto = 5 

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
and mes = @mes and año = @año and Id_puesto = 6 


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
and mes = @mes and año = @año and Id_puesto = 7 



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
and mes = @mes and año = @año and Id_puesto = 8 


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
and mes = @mes and año = @año and Id_puesto = 9 
", conexion)
        conexion.Open()

        Dim Pregunta As Integer



        Pregunta = MsgBox("Está a punto de autorizar el plan de personal para esta ,¿Desea guardar los cambios?.", vbYesNo + vbExclamation + vbDefaultButton2, "¡Va a guardar cambios!")

        If Pregunta = vbYes Then
            Try



                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@cantidad1", txt_gerente2.Text)
                cmd.Parameters.AddWithValue("@cantidad2", txt_asistente2.Text)
                cmd.Parameters.AddWithValue("@cantidad3", txt_supervisor2.Text)
                cmd.Parameters.AddWithValue("@cantidad4", txt_lad2.Text)
                cmd.Parameters.AddWithValue("@cantidad5", txt_staff2.Text)
                cmd.Parameters.AddWithValue("@cantidad6", txt_lid2.Text)
                cmd.Parameters.AddWithValue("@cantidad7", txt_operador2.Text)
                cmd.Parameters.AddWithValue("@cantidad8", txt_cor2.Text)
                cmd.Parameters.AddWithValue("@cantidad9", txt_tra2.Text)


                cmd.Parameters.AddWithValue("@año", cbx_año.Text)
                cmd.Parameters.AddWithValue("@mes", l3.Text)
                cmd.Parameters.AddWithValue("@catalogodepartamento", cbx_depto.Text)


                cmd.ExecuteNonQuery()



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


                cmd.ExecuteNonQuery()



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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cargar2()
    End Sub


End Class