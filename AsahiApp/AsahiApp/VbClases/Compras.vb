Public Class Compras
    Private idProvision_ As Integer
    Public Property IdProvision() As Integer
        Get
            Return idProvision_
        End Get
        Set(ByVal value As Integer)
            idProvision_ = value
        End Set
    End Property
    Private idCompra_ As Integer
    Public Property IdCompra() As Integer
        Get
            Return idCompra_
        End Get
        Set(ByVal value As Integer)
            idCompra_ = value
        End Set
    End Property
    Private oc_ As String
    Public Property Oc() As String
        Get
            Return oc_
        End Get
        Set(ByVal value As String)
            oc_ = value
        End Set
    End Property
    Private idOc_ As Integer
    Public Property IdOC() As Integer
        Get
            Return IdOC
        End Get
        Set(ByVal value As Integer)
            idOc_ = value
        End Set
    End Property
    Private idOrdenCompra_ As Integer
    Public Property IdOrdenCompra() As Integer
        Get
            Return idOrdenCompra_
        End Get
        Set(ByVal value As Integer)
            idOrdenCompra_ = value
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
    Private factura_ As String
    Public Property Factura() As String
        Get
            Return factura_
        End Get
        Set(ByVal value As String)
            factura_ = value
        End Set
    End Property
    Private proveedor_ As String
    Public Property Proveedor() As String
        Get
            Return proveedor_
        End Get
        Set(ByVal value As String)
            proveedor_ = value
        End Set
    End Property
    Private rfc_ As String
    Public Property Rfc() As String
        Get
            Return rfc_
        End Get
        Set(ByVal value As String)
            rfc_ = value
        End Set
    End Property
    Private montoOc_ As Double
    Public Property MontoOC() As Double
        Get
            Return montoOc_
        End Get
        Set(ByVal value As Double)
            montoOc_ = value
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
    Private montoPagar_ As Double
    Public Property MontoPagar() As Double
        Get
            Return montoPagar_
        End Get
        Set(ByVal value As Double)
            montoPagar_ = value
        End Set
    End Property
    Private montoCompra_ As Double
    Public Property MontoCompra() As Double
        Get
            Return montoCompra_
        End Get
        Set(ByVal value As Double)
            montoCompra_ = value
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
    Private fechaPagoFact_ As Date
    Public Property FechaPagoFact() As Date
        Get
            Return fechaPagoFact_
        End Get
        Set(ByVal value As Date)
            fechaPagoFact_ = value
        End Set
    End Property
    Private fechaPagoReal_ As Date
    Public Property FechaPagoReal() As Date
        Get
            Return fechaPagoReal_
        End Get
        Set(ByVal value As Date)
            fechaPagoReal_ = value
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
    Private fechaCompra_ As Date
    Public Property FechaCompra() As Date
        Get
            Return fechaCompra_
        End Get
        Set(ByVal value As Date)
            fechaCompra_ = value
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
    Private tazaCambio_ As Double
    Public Property TazaCambio() As Double
        Get
            Return tazaCambio_
        End Get
        Set(ByVal value As Double)
            tazaCambio_ = value
        End Set
    End Property
    Private pivote_ As Integer
    Public Property Pivote() As Integer
        Get
            Return pivote_
        End Get
        Set(ByVal value As Integer)
            pivote_ = value
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
    Private compraTotal_ As Double
    Public Property CompraTotal() As Double
        Get
            Return compraTotal_
        End Get
        Set(ByVal value As Double)
            compraTotal_ = value
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
    Private impuesto_ As Double
    Public Property Impuesto() As Double
        Get
            Return impuesto_
        End Get
        Set(ByVal value As Double)
            impuesto_ = value
        End Set
    End Property
    Private status_ As String
    Public Property Status() As String
        Get
            Return status_
        End Get
        Set(ByVal value As String)
            status_ = value
        End Set
    End Property
    Private statusConta_ As Integer
    Public Property StatusConta() As Integer
        Get
            Return statusConta_
        End Get
        Set(ByVal value As Integer)
            statusConta_ = value
        End Set
    End Property
    Private observaCompra_ As String
    Public Property ObservaCompra() As String
        Get
            Return observaCompra_
        End Get
        Set(ByVal value As String)
            observaCompra_ = value
        End Set
    End Property
    Private observaConta_ As String
    Public Property ObservaConta() As String
        Get
            Return observaConta_
        End Get
        Set(ByVal value As String)
            observaConta_ = value
        End Set
    End Property
    Private add_ As String
    Public Property Add() As String
        Get
            Return add_
        End Get
        Set(ByVal value As String)
            add_ = value
        End Set
    End Property
    Private val1_ As Integer
    Public Property Val1() As Integer
        Get
            Return val1_
        End Get
        Set(ByVal value As Integer)
            val1_ = value
        End Set
    End Property
    Private val2_ As Integer
    Public Property Val2() As Integer
        Get
            Return val2_
        End Get
        Set(ByVal value As Integer)
            val2_ = value
        End Set
    End Property
    Private val3_ As Integer
    Public Property Val3() As Integer
        Get
            Return val3_
        End Get
        Set(ByVal value As Integer)
            val3_ = value
        End Set
    End Property
    Private val4_ As Integer
    Public Property Val4() As Integer
        Get
            Return val4_
        End Get
        Set(ByVal value As Integer)
            val4_ = value
        End Set
    End Property
    Private ruta_ As String
    Public Property Ruta() As String
        Get
            Return ruta_
        End Get
        Set(ByVal value As String)
            ruta_ = value
        End Set
    End Property
End Class