Public Class Baja
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private fecha_ As Date
    Public Property Fecha() As Date
        Get
            Return fecha_
        End Get
        Set(ByVal value As Date)
            fecha_ = value
        End Set
    End Property
    Private tipoBaja_ As String
    Public Property TipoBaja() As String
        Get
            Return tipoBaja_
        End Get
        Set(ByVal value As String)
            tipoBaja_ = value
        End Set
    End Property
    Private causaBaja_ As String
    Public Property CausaBaja() As String
        Get
            Return causaBaja_
        End Get
        Set(ByVal value As String)
            causaBaja_ = value
        End Set
    End Property
End Class
