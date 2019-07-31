Public Class Permisos
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private nombreModulo_ As String
    Public Property NombreModulo() As String
        Get
            Return nombreModulo_
        End Get
        Set(ByVal value As String)
            nombreModulo_ = value
        End Set
    End Property
    Private rangoPermiso_ As Integer
    Public Property RangoPermiso() As Integer
        Get
            Return rangoPermiso_
        End Get
        Set(ByVal value As Integer)
            rangoPermiso_ = value
        End Set
    End Property
End Class
