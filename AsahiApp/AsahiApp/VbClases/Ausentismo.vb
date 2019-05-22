Public Class Ausentismo
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private duracion_ As Integer
    Public Property Duracion() As Integer
        Get
            Return duracion_
        End Get
        Set(ByVal value As Integer)
            duracion_ = value
        End Set
    End Property
    Private fechaI_ As Date
    Public Property FechaI() As Date
        Get
            Return fechaI_
        End Get
        Set(ByVal value As Date)
            fechaI_ = value
        End Set
    End Property
    Private fechaF_ As Date
    Public Property FechaF() As Date
        Get
            Return fechaF_
        End Get
        Set(ByVal value As Date)
            fechaF_ = value
        End Set
    End Property
    Private tipoAusentismo_ As String
    Public Property TipoAusentismo() As String
        Get
            Return tipoAusentismo_
        End Get
        Set(ByVal value As String)
            tipoAusentismo_ = value
        End Set
    End Property
End Class
