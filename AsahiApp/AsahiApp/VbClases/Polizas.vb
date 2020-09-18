Public Class Polizas
    Private folioPoliza_ As Integer
    Public Property FolioPoliza() As Integer
        Get
            Return folioPoliza_
        End Get
        Set(ByVal value As Integer)
            folioPoliza_ = value
        End Set
    End Property
    Private folioPolizaEgreso_ As Long
    Public Property FolioPolizaEgreso() As Long
        Get
            Return folioPolizaEgreso_
        End Get
        Set(ByVal value As Long)
            folioPolizaEgreso_ = value
        End Set
    End Property
    Private fechaFactura_ As Date
    Public Property FechaFactura() As Date
        Get
            Return fechaFactura_
        End Get
        Set(ByVal value As Date)
            fechaFactura_ = value
        End Set
    End Property
End Class