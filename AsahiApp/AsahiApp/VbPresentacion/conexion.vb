Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Net


Public Class conexion


    Public conexion As SqlConnection = New SqlConnection("Data Source=GIRO\SQLEX2014;Initial Catalog=SistemaAAM;Uid=sa; Pwd=Pa55word;")
    Public conexionContpaq As SqlConnection = New SqlConnection("Data Source=SERV-CONTA\SQLEX2014;Initial Catalog=ctAsahi_Aluminium;Uid=sa; Pwd=Me*1can;")
    Public cadenaConexExpress As String = "Data Source=GIRO\SQLEXPRESS;Initial Catalog=AsahiSystem;Uid=sa; Pwd=Pa55word;"
    Public cadenaConexExpress1 As SqlConnection = New SqlConnection("Data Source=GIRO\SQLEXPRESS;Initial Catalog=AsahiSystem;Uid=sa; Pwd=Pa55word;")

    Public cadenaConex As String = "Data Source=GIRO\SQLEX2014;Initial Catalog=SistemaAAM;Uid=sa; Pwd=Pa55word;"
    Public conexion2008 As String = "Data Source=GIRO\SQL2008;Initial Catalog=asahi16;Uid=sa; Pwd=Pa55word;"
    Public conexionCont As String = "Data Source=SERV-CONTA\SQLEX2014;Initial Catalog=ctAsahi_Aluminium;Uid=sa; Pwd=Me*1can;"

    Public conexionFor As SqlConnection = New SqlConnection("Data Source=148.244.76.149,64332\SQLEX2014;Initial Catalog=SistemaAAM;Uid=sa; Pwd=Pa55word;")
    Public conexionContpaqFor As SqlConnection = New SqlConnection("Data Source=148.244.76.149,65332\SQLEX2014;Initial Catalog=ctAsahi_Aluminium;Uid=sa; Pwd=Me*1can;")
    Public conexionExpressFor As SqlConnection = New SqlConnection("Data Source=148.244.76.149,64333\SQLEXPRESS;Initial Catalog=AsahiSystem;Uid=sa; Pwd=Pa55word;")
    Public conexion2008For As String = "Data Source=148.244.76.149,64330\SQL2008;Initial Catalog=asahi16;Uid=sa; Pwd=Pa55word;"
    Public cadenaConexFor As String = "Data Source=148.244.76.149,64332\SQLEX2014;Initial Catalog=SistemaAAM;Uid=sa; Pwd=Pa55word;"
    Public cadenaConexExpressFor As String = "Data Source=148.244.76.149,64333\SQLEXPRESS;Initial Catalog=AsahiSystem;Uid=sa; Pwd=Pa55word" 'Usuario; Pwd=Rey_S01_*20;"
    Public conexionContFor As String = "Data Source=148.244.76.149,65332\SQLEX2014;Initial Catalog=ctAsahi_Aluminium;Uid=sa; Pwd=Me*1can;"

    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub Conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

        Catch ex As Exception
            MessageBox.Show("Error al conectar: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Function ConvertirMinutosAHoras(ByVal paramMinutos) As String
        Return paramMinutos \ 60 & ":" & IIf(paramMinutos Mod 60 < 10, "0" & paramMinutos Mod 60, paramMinutos Mod 60) & ""
    End Function
    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        conexion.Close()
    End Sub
    Function Busca(ByVal sql) As Boolean
        Dim resultado As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand(sql, conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True

            End If
            dr.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    'Function Insertar(ByVal sql)
    '    Try
    '        conexion.Open()
    '        comando = New SqlCommand(sql, conexion)
    '        Dim i As Integer = comando.ExecuteNonQuery()
    '        conexion.Close()
    '        If (i > 0) Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error al agregar: " + ex.ToString)
    '    End Try


    'End Function
    Public Sub Consulta_join(ByVal sql As String, ByVal tb1 As String, ByVal tb2 As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tb1 + tb2)
        conexion.Close()
    End Sub
    Function Eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function Actualizar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim actualiza As String = "update " + tabla + "set " + campos + " where " + condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function getIp() As String

        Dim valorIp As String

        valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()

        Return valorIp

    End Function
End Class


