Public Class Bono
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private acumulaMes_ As Double
    Public Property AcumulaMes() As Double
        Get
            Return acumulaMes_
        End Get
        Set(ByVal value As Double)
            acumulaMes_ = value
        End Set
    End Property
    Private año_ As Integer
    Public Property Año() As Integer
        Get
            Return año_
        End Get
        Set(ByVal value As Integer)
            año_ = value
        End Set
    End Property
    Private semana_ As Integer
    Public Property Semana() As Integer
        Get
            Return semana_
        End Get
        Set(ByVal value As Integer)
            semana_ = value
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
    Private idModif_ As String
    Public Property IdModif() As String
        Get
            Return idModif_
        End Get
        Set(ByVal value As String)
            idModif_ = value
        End Set
    End Property
    Private xml_ As String
    Public Property XML() As String
        Get
            Return xml_
        End Get
        Set(ByVal value As String)
            xml_ = value
        End Set
    End Property
End Class