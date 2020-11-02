﻿Public Class Compras
    Private idProvision_ As Integer
    Public Property IdProvision() As Integer
        Get
            Return idProvision_
        End Get
        Set(ByVal value As Integer)
            idProvision_ = value
        End Set
    End Property
    Private idCompra_ As String
    Public Property IdCompra() As String
        Get
            Return idCompra_
        End Get
        Set(ByVal value As String)
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
    Private serieC_ As String
    Public Property SerieC() As String
        Get
            Return serieC_
        End Get
        Set(ByVal value As String)
            serieC_ = value
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
    Private guidDocument_ As String
    Public Property GuidDocument() As String
        Get
            Return guidDocument_
        End Get
        Set(ByVal value As String)
            guidDocument_ = value
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
    Private statusPago_ As String
    Public Property StatusPago() As String
        Get
            Return statusPago_
        End Get
        Set(ByVal value As String)
            statusPago_ = value
        End Set
    End Property
    Private statusConta_ As String
    Public Property StatusConta() As String
        Get
            Return statusConta_
        End Get
        Set(ByVal value As String)
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
    Private fp_ As Date
    Public Property FP() As Date
        Get
            Return fp_
        End Get
        Set(ByVal value As Date)
            fp_ = value
        End Set
    End Property
    Private fechaProv_ As Date
    Public Property FechaProv() As Date
        Get
            Return fechaProv_
        End Get
        Set(ByVal value As Date)
            fechaProv_ = value
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
    Private fechaValidado_ As Date
    Public Property FechaValidado() As Date
        Get
            Return fechaValidado_
        End Get
        Set(ByVal value As Date)
            fechaValidado_ = value
        End Set
    End Property
    Private impExtNombre_ As String
    Public Property ImpExtNombre() As String
        Get
            Return impExtNombre_
        End Get
        Set(ByVal value As String)
            impExtNombre_ = value
        End Set
    End Property
    Private impExtTasaOCuota_ As Double
    Public Property ImpExtTasaOCuota() As Double
        Get
            Return impExtTasaOCuota_
        End Get
        Set(ByVal value As Double)
            impExtTasaOCuota_ = value
        End Set
    End Property
    Private impExtImporte_ As Double
    Public Property ImpExtImporte() As Double
        Get
            Return impExtImporte_
        End Get
        Set(ByVal value As Double)
            impExtImporte_ = value
        End Set
    End Property
    Private ejercicio_ As Integer
    Public Property Ejercicio() As Integer
        Get
            Return ejercicio_
        End Get
        Set(ByVal value As Integer)
            ejercicio_ = value
        End Set
    End Property
    Private periodo_ As Integer
    Public Property Periodo() As Integer
        Get
            Return periodo_
        End Get
        Set(ByVal value As Integer)
            periodo_ = value
        End Set
    End Property
    Private ejercicioPago_ As Integer
    Public Property EjercicioPago() As Integer
        Get
            Return ejercicioPago_
        End Get
        Set(ByVal value As Integer)
            ejercicioPago_ = value
        End Set
    End Property
    Private periodoPago_ As Integer
    Public Property PeriodoPago() As Integer
        Get
            Return periodoPago_
        End Get
        Set(ByVal value As Integer)
            periodoPago_ = value
        End Set
    End Property
    Private idProveedor_ As Integer
    Public Property IdProveedor() As Integer
        Get
            Return idProveedor_
        End Get
        Set(ByVal value As Integer)
            idProveedor_ = value
        End Set
    End Property
    Private concepto_ As String
    Public Property Concepto() As String
        Get
            Return concepto_
        End Get
        Set(ByVal value As String)
            concepto_ = value
        End Set
    End Property
    Private cuentaClabe_ As String
    Public Property CuentaClabe() As String
        Get
            Return cuentaClabe_
        End Get
        Set(ByVal value As String)
            cuentaClabe_ = value
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
    Private codigoBanco_ As String
    Public Property CodigoBanco() As String
        Get
            Return codigoBanco_
        End Get
        Set(ByVal value As String)
            codigoBanco_ = value
        End Set
    End Property
    Private folioDocCont_ As Long
    Public Property FolioDocCont() As Long
        Get
            Return folioDocCont_
        End Get
        Set(ByVal value As Long)
            folioDocCont_ = value
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
    Private tipo_ As Integer
    Public Property Tipo() As Integer
        Get
            Return tipo_
        End Get
        Set(ByVal value As Integer)
            tipo_ = value
        End Set
    End Property
End Class