Imports Clases
Imports Datos
Imports System.Data.SqlClient
Public Class NImpuestos
    Public Function RecuperarIsr(ByVal cadenaConex As String, ByVal sueldo As Double) As Impuestos
        Dim DImp As New DImpuestos()
        Return DImp.RecuperarIsr(cadenaConex, sueldo)
    End Function
    Public Sub GeneralOee(ByVal cadenaConex As String, ByVal fecha As Date, ByVal id_proceso As String, ByVal maquina As String, ByVal pieza As String, ByVal molde As String,
                        ByVal cavidad As Integer, ByVal turno As Integer, ByVal tpok As Integer, ByVal tpo As Integer, ByVal tpp As Integer, ByVal ct As Double, ByVal cantidadtotal As Integer,
                        ByVal inypru As Integer, ByVal dfundicion As Integer, ByVal dmaquinado As Integer, ByVal insmuestra As Integer, ByVal pconforme As Integer, ByVal ttotal As Integer, ByVal cjig As Integer,
                        ByVal tmmolde As Integer, ByVal tmmaquina As Integer, ByVal loosf As Integer, ByVal toperacion As Integer)
        Dim DImp As New DImpuestos()
        DImp.GeneralOee(cadenaConex, fecha, id_proceso, maquina, pieza, molde, cavidad, turno, tpok, tpo, tpp, ct, cantidadtotal,
                         inypru, dfundicion, dmaquinado, insmuestra, pconforme, ttotal, cjig, tmmolde, tmmaquina, loosf, toperacion)
    End Sub
End Class
