Public Class TxtNominas
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private idExt_ As Integer
    Public Property IdExt() As Integer
        Get
            Return idExt_
        End Get
        Set(ByVal value As Integer)
            idExt_ = value
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
    Private monto_ As Integer
    Public Property Monto() As Integer
        Get
            Return monto_
        End Get
        Set(ByVal value As Integer)
            monto_ = value
        End Set
    End Property
    Private autorizado_ As Integer
    Public Property Autorizado() As Integer
        Get
            Return autorizado_
        End Get
        Set(ByVal value As Integer)
            autorizado_ = value
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
    Private turno_ As Integer
    Public Property Turno() As Integer
        Get
            Return turno_
        End Get
        Set(ByVal value As Integer)
            turno_ = value
        End Set
    End Property
    Private tabla_ As Integer
    Public Property Tabla() As Integer
        Get
            Return tabla_
        End Get
        Set(ByVal value As Integer)
            tabla_ = value
        End Set
    End Property
End Class
