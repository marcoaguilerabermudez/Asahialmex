Public Class Ventas
    Private pivot_ As Integer
    Public Property Pivot() As Integer
        Get
            Return pivot_
        End Get
        Set(ByVal value As Integer)
            pivot_ = value
        End Set
    End Property
    Private idDoc_ As Integer
    Public Property IdDoc() As Integer
        Get
            Return idDoc_
        End Get
        Set(ByVal value As Integer)
            idDoc_ = value
        End Set
    End Property
    Private venta_ As String
    Public Property Venta() As String
        Get
            Return venta_
        End Get
        Set(ByVal value As String)
            venta_ = value
        End Set
    End Property
    Private pedido_ As Integer
    Public Property Pedido() As Integer
        Get
            Return pedido_
        End Get
        Set(ByVal value As Integer)
            pedido_ = value
        End Set
    End Property
    Private serie_ As String
    Public Property Serie() As String
        Get
            Return serie_
        End Get
        Set(ByVal value As String)
            serie_ = value
        End Set
    End Property
    Private factura_ As Integer
    Public Property Factura() As Integer
        Get
            Return factura_
        End Get
        Set(ByVal value As Integer)
            factura_ = value
        End Set
    End Property
    Private cliente_ As String
    Public Property Cliente() As String
        Get
            Return cliente_
        End Get
        Set(ByVal value As String)
            cliente_ = value
        End Set
    End Property
    Private rfc_ As String
    Public Property RFC() As String
        Get
            Return rfc_
        End Get
        Set(ByVal value As String)
            rfc_ = value
        End Set
    End Property
    Private montoPed_ As Double
    Public Property MontoPed() As Double
        Get
            Return montoPed_
        End Get
        Set(ByVal value As Double)
            montoPed_ = value
        End Set
    End Property
    Private montoFact_ As Double
    Public Property MontoFact() As Double
        Get
            Return montoFact_
        End Get
        Set(ByVal value As Double)
            montoFact_ = value
        End Set
    End Property
    Private fechaFact_ As Date
    Public Property FechaFact() As Date
        Get
            Return fechaFact_
        End Get
        Set(ByVal value As Date)
            fechaFact_ = value
        End Set
    End Property
    Private moneda_ As String
    Public Property Moneda() As String
        Get
            Return moneda_
        End Get
        Set(ByVal value As String)
            moneda_ = value
        End Set
    End Property
    Private empresa_ As String
    Public Property Empresa() As String
        Get
            Return empresa_
        End Get
        Set(ByVal value As String)
            empresa_ = value
        End Set
    End Property
    Private uuid_ As String
    Public Property UUID() As String
        Get
            Return uuid_
        End Get
        Set(ByVal value As String)
            uuid_ = value
        End Set
    End Property
    Private tipoCambio_ As Double
    Public Property TipoCambio() As Double
        Get
            Return tipoCambio_
        End Get
        Set(ByVal value As Double)
            tipoCambio_ = value
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
    Private txtCreado_ As Boolean
    Public Property TxtCreado() As Boolean
        Get
            Return txtCreado_
        End Get
        Set(ByVal value As Boolean)
            txtCreado_ = value
        End Set
    End Property
    Private docContableCrea_ As Boolean
    Public Property DocContableCrea() As Boolean
        Get
            Return docContableCrea_
        End Get
        Set(ByVal value As Boolean)
            docContableCrea_ = value
        End Set
    End Property
    Private totalFactura_ As Double
    Public Property TotalFactura() As Double
        Get
            Return totalFactura_
        End Get
        Set(ByVal value As Double)
            totalFactura_ = value
        End Set
    End Property
    Private totalVenta_ As Double
    Public Property TotalVenta() As Double
        Get
            Return totalVenta_
        End Get
        Set(ByVal value As Double)
            totalVenta_ = value
        End Set
    End Property
    Private rfcEmisor_ As String
    Public Property RfcEmisor() As String
        Get
            Return rfcEmisor_
        End Get
        Set(ByVal value As String)
            rfcEmisor_ = value
        End Set
    End Property
    Private nombreEmisor_ As String
    Public Property NombreEmisor() As String
        Get
            Return nombreEmisor_
        End Get
        Set(ByVal value As String)
            nombreEmisor_ = value
        End Set
    End Property
    Private total_ As Double
    Public Property Total() As Double
        Get
            Return total_
        End Get
        Set(ByVal value As Double)
            total_ = value
        End Set
    End Property
    Private area_ As String
    Public Property Area() As String
        Get
            Return area_
        End Get
        Set(ByVal value As String)
            area_ = value
        End Set
    End Property
    Private familia_ As String
    Public Property Familia() As String
        Get
            Return familia_
        End Get
        Set(ByVal value As String)
            familia_ = value
        End Set
    End Property
    Private cuenta_ As String
    Public Property Cuenta() As String
        Get
            Return cuenta_
        End Get
        Set(ByVal value As String)
            cuenta_ = value
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
    Private cuentaIva_ As String
    Public Property CuentaIva() As String
        Get
            Return cuentaIva_
        End Get
        Set(ByVal value As String)
            cuentaIva_ = value
        End Set
    End Property
    Private ivaT_ As Double
    Public Property IvaT() As Double
        Get
            Return ivaT_
        End Get
        Set(ByVal value As Double)
            ivaT_ = value
        End Set
    End Property
    Private cuentaP_ As String
    Public Property CuentaP() As String
        Get
            Return cuentaP_
        End Get
        Set(ByVal value As String)
            cuentaP_ = value
        End Set
    End Property
    Private impuesto_ As String
    Public Property Impuesto() As String
        Get
            Return impuesto_
        End Get
        Set(ByVal value As String)
            impuesto_ = value
        End Set
    End Property
End Class
