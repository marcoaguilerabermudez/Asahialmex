Public Class Incidencias
    Private semana_ As Integer
    Public Property Semana() As Integer
        Get
            Return semana_
        End Get
        Set(ByVal value As Integer)
            semana_ = value
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
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private incidencia_ As Integer
    Public Property Incidencia() As Integer
        Get
            Return incidencia_
        End Get
        Set(ByVal value As Integer)
            incidencia_ = value
        End Set
    End Property
    Private fechaInc_ As Date
    Public Property FechaInc() As Date
        Get
            Return fechaInc_
        End Get
        Set(ByVal value As Date)
            fechaInc_ = value
        End Set
    End Property
    Private valor_ As Double
    Public Property Valor() As Double
        Get
            Return valor_
        End Get
        Set(ByVal value As Double)
            valor_ = value
        End Set
    End Property
    Private fechaActual_ As Date
    Public Property FechaActual() As Date
        Get
            Return fechaActual_
        End Get
        Set(ByVal value As Date)
            fechaActual_ = value
        End Set
    End Property
    Private tipo_ As Integer
    Public Property Tipo() As Integer
        Get
            Return tipo_
        End Get
        Set(ByVal value As Integer)
            tipo_ = value
        End Set
    End Property
    Private xml_ As String
    Public Property Xml() As String
        Get
            Return xml_
        End Get
        Set(ByVal value As String)
            xml_ = value
        End Set
    End Property
End Class
