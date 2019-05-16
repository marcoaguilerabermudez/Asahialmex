Public Class Empleado
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private nombreCompleto_ As String
    Public Property NombreCompleto() As String
        Get
            Return nombreCompleto_
        End Get
        Set(ByVal value As String)
            nombreCompleto_ = value
        End Set
    End Property
    Private nombres_ As String
    Public Property Nombres() As String
        Get
            Return nombres_
        End Get
        Set(ByVal value As String)
            nombres_ = value
        End Set
    End Property
    Private apellidoPaterno_ As String
    Public Property ApellidoPaterno() As String
        Get
            Return apellidoPaterno_
        End Get
        Set(ByVal value As String)
            apellidoPaterno_ = value
        End Set
    End Property
    Private apellidoMaterno_ As String
    Public Property ApellidoMaterno() As String
        Get
            Return apellidoMaterno_
        End Get
        Set(ByVal value As String)
            apellidoMaterno_ = value
        End Set
    End Property
    Private horario_ As String
    Public Property Horario() As String
        Get
            Return horario_
        End Get
        Set(ByVal value As String)
            horario_ = value
        End Set
    End Property
    Private departamento_ As String
    Public Property Departamento() As String
        Get
            Return departamento_
        End Get
        Set(ByVal value As String)
            departamento_ = value
        End Set
    End Property
    Private bono_ As Boolean
    Public Property Bono() As Boolean
        Get
            Return bono_
        End Get
        Set(ByVal value As Boolean)
            bono_ = value
        End Set
    End Property
End Class
