Public Class Horarios
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private descripcionHorario_ As String
    Public Property DescripcionHorario() As String
        Get
            Return descripcionHorario_
        End Get
        Set(ByVal value As String)
            descripcionHorario_ = value
        End Set
    End Property
    Private horaEntradaReal_ As String
    Public Property HoraEntradaReal() As String
        Get
            Return horaEntradaReal_
        End Get
        Set(ByVal value As String)
            horaEntradaReal_ = value
        End Set
    End Property
    Private horaSalidaReal_ As String
    Public Property HoraSalidaReal() As String
        Get
            Return horaSalidaReal_
        End Get
        Set(ByVal value As String)
            horaSalidaReal_ = value
        End Set
    End Property
    Private idHorario_ As Integer
    Public Property IdHorario() As Integer
        Get
            Return idHorario_
        End Get
        Set(ByVal value As Integer)
            idHorario_ = value
        End Set
    End Property
    Private horaEntrada_ As String
    Public Property HoraEntrada() As String
        Get
            Return horaEntradaReal_
        End Get
        Set(ByVal value As String)
            horaEntradaReal_ = value
        End Set
    End Property
    Private horaSalida_ As String
    Public Property HoraSalida() As String
        Get
            Return horaSalidaReal_
        End Get
        Set(ByVal value As String)
            horaSalidaReal_ = value
        End Set
    End Property
    Private lector_ As String
    Public Property Lector() As String
        Get
            Return lector_
        End Get
        Set(ByVal value As String)
            lector_ = value
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
End Class
