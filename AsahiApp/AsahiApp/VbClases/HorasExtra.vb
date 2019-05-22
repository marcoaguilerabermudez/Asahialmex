Public Class HorasExtra
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
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
    Private tipoPermiso_ As String
    Public Property TipoPermiso() As String
        Get
            Return tipoPermiso_
        End Get
        Set(ByVal value As String)
            tipoPermiso_ = value
        End Set
    End Property
End Class
