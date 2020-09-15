Public Class Bancos
    Private idBanco_ As Integer
    Public Property IdBanco() As Integer
        Get
            Return idBanco_
        End Get
        Set(ByVal value As Integer)
            idBanco_ = value
        End Set
    End Property
    Private nombreBanco_ As String
    Public Property NombreBanco() As String
        Get
            Return nombreBanco_
        End Get
        Set(ByVal value As String)
            nombreBanco_ = value
        End Set
    End Property
    Private codigo_ As String
    Public Property Codigo() As String
        Get
            Return codigo_
        End Get
        Set(ByVal value As String)
            codigo_ = value
        End Set
    End Property
End Class
