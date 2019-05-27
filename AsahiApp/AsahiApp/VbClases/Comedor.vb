Public Class Comedor
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private fechaComedor_ As Date
    Public Property FechaComedor() As Date
        Get
            Return fechaComedor_
        End Get
        Set(ByVal value As Date)
            fechaComedor_ = value
        End Set
    End Property
    Private horaComedor_ As Date
    Public Property HoraComedor() As Date
        Get
            Return horaComedor_
        End Get
        Set(ByVal value As Date)
            horaComedor_ = value
        End Set
    End Property
    Private tipoComida_ As Integer
    Public Property TipoComida() As Integer
        Get
            Return tipoComida_
        End Get
        Set(ByVal value As Integer)
            tipoComida_ = value
        End Set
    End Property
End Class
