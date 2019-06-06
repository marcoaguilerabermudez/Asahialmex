Public Class Incapacidad
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
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
    Private num_ As Integer
    Public Property Num() As Integer
        Get
            Return num_
        End Get
        Set(ByVal value As Integer)
            num_ = value
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
    Private numero_ As String
    Public Property Numero() As String
        Get
            Return numero_
        End Get
        Set(ByVal value As String)
            numero_ = value
        End Set
    End Property
    Private tipo_ As String
    Public Property Tipo() As String
        Get
            Return tipo_
        End Get
        Set(ByVal value As String)
            tipo_ = value
        End Set
    End Property
    Private caso_ As String
    Public Property Caso() As String
        Get
            Return caso_
        End Get
        Set(ByVal value As String)
            caso_ = value
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
    Private secuela_ As String
    Public Property Secuela() As String
        Get
            Return secuela_
        End Get
        Set(ByVal value As String)
            secuela_ = value
        End Set
    End Property
End Class
