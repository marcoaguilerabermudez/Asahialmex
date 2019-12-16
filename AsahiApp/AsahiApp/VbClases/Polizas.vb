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