Public Class Productos
    Private idProducto_ As Integer
    Public Property IdProducto() As Integer
        Get
            Return idProducto_
        End Get
        Set(ByVal value As Integer)
            idProducto_ = value
        End Set
    End Property
End Class
