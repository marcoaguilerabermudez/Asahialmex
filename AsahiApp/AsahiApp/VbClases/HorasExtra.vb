Public Class HorasExtra
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private tipo_ As String
    Public Property Tipo() As String
        Get
            Return tipo_
        End Get
        Set(ByVal value As String)
            tipo_ = value
        End Set
    End Property
    Private monto_ As Integer
    Public Property Monto() As Integer
        Get
            Return monto_
        End Get
        Set(ByVal value As Integer)
            monto_ = value
        End Set
    End Property
    Private autorizado_ As Integer
    Public Property Autorizado() As Integer
        Get
            Return autorizado_
        End Get
        Set(ByVal value As Integer)
            autorizado_ = value
        End Set
    End Property
    Private fecha_ As Date
    Public Property Fecha() As Date
        Get
            Return fecha_
        End Get
        Set(ByVal value As Date)
            fecha_ = value
        End Set
    End Property
    Private tipoPermiso_ As String
    Public Property TipoPermiso() As String
        Get
            Return tipoPermiso_
        End Get
        Set(ByVal value As String)
            tipoPermiso_ = value
        End Set
    End Property
    Private horas_ As DateTime
    Public Property Horas() As DateTime
        Get
            Return horas_
        End Get
        Set(ByVal value As DateTime)
            horas_ = value
        End Set
    End Property
    Private semanas_ As Integer
    Public Property Semanas() As Integer
        Get
            Return semanas_
        End Get
        Set(ByVal value As Integer)
            semanas_ = value
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
    Private mes_ As Integer
    Public Property Mes() As Integer
        Get
            Return mes_
        End Get
        Set(ByVal value As Integer)
            mes_ = value
        End Set
    End Property
    Private lunes_ As Double
    Public Property Lunes() As Double
        Get
            Return lunes_
        End Get
        Set(ByVal value As Double)
            lunes_ = value
        End Set
    End Property
    Private martes_ As Double
    Public Property Martes() As Double
        Get
            Return martes_
        End Get
        Set(ByVal value As Double)
            martes_ = value
        End Set
    End Property
    Private miercoles_ As Double
    Public Property Miercoles() As Double
        Get
            Return miercoles_
        End Get
        Set(ByVal value As Double)
            miercoles_ = value
        End Set
    End Property
    Private jueves_ As Double
    Public Property Jueves() As Double
        Get
            Return jueves_
        End Get
        Set(ByVal value As Double)
            jueves_ = value
        End Set
    End Property
    Private viernes_ As Double
    Public Property Viernes() As Double
        Get
            Return viernes_
        End Get
        Set(ByVal value As Double)
            viernes_ = value
        End Set
    End Property
    Private sabado_ As Double
    Public Property Sabado() As Double
        Get
            Return sabado_
        End Get
        Set(ByVal value As Double)
            sabado_ = value
        End Set
    End Property
    Private domingo_ As Double
    Public Property Domingo() As Double
        Get
            Return domingo_
        End Get
        Set(ByVal value As Double)
            domingo_ = value
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
    Private año_ As Integer
    Public Property Año() As Integer
        Get
            Return año_
        End Get
        Set(ByVal value As Integer)
            año_ = value
        End Set
    End Property
    Private totalDobles_ As Double
    Public Property TotalDobles() As Double
        Get
            Return totalDobles_
        End Get
        Set(ByVal value As Double)
            totalDobles_ = value
        End Set
    End Property
    Private totalTriples_ As Double
    Public Property TotalTriples() As Double
        Get
            Return totalTriples_
        End Get
        Set(ByVal value As Double)
            totalTriples_ = value
        End Set
    End Property
    Private totalDescLab_ As Double
    Public Property TotalDescLab() As Double
        Get
            Return totalDescLab_
        End Get
        Set(ByVal value As Double)
            totalDescLab_ = value
        End Set
    End Property
    Private bruto_ As Double
    Public Property Bruto() As Double
        Get
            Return bruto_
        End Get
        Set(ByVal value As Double)
            bruto_ = value
        End Set
    End Property
    Private neto_ As Double
    Public Property Neto() As Double
        Get
            Return neto_
        End Get
        Set(ByVal value As Double)
            neto_ = value
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
