Public Class Impuestos
    Private limiteInf_ As Double
    Public Property LimiteInf() As Double
        Get
            Return limiteInf_
        End Get
        Set(ByVal value As Double)
            limiteInf_ = value
        End Set
    End Property
    Private cuotaFija_ As Double
    Public Property CuotaFija() As Double
        Get
            Return cuotaFija_
        End Get
        Set(ByVal value As Double)
            cuotaFija_ = value
        End Set
    End Property
    Private porcentajeEx_ As Double
    Public Property PorcentajeEx() As Double
        Get
            Return porcentajeEx_
        End Get
        Set(ByVal value As Double)
            porcentajeEx_ = value
        End Set
    End Property
End Class
