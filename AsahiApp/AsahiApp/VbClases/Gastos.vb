﻿Public Class Gastos
    Private cuenta_ As String
    Public Property Cuenta() As String
        Get
            Return cuenta_
        End Get
        Set(ByVal value As String)
            cuenta_ = value
        End Set
    End Property
    Private nombreCuenta_ As String
    Public Property NombreCuenta() As String
        Get
            Return nombreCuenta_
        End Get
        Set(ByVal value As String)
            nombreCuenta_ = value
        End Set
    End Property
    Private masterP_ As Double
    Public Property MasterP() As Double
        Get
            Return masterP_
        End Get
        Set(ByVal value As Double)
            masterP_ = value
        End Set
    End Property
    Private segmNegocio_ As String
    Public Property SegmNegocio() As String
        Get
            Return segmNegocio_
        End Get
        Set(ByVal value As String)
            segmNegocio_ = value
        End Set
    End Property
    Private actual_ As Double
    Public Property Actual() As Double
        Get
            Return actual_
        End Get
        Set(ByVal value As Double)
            actual_ = value
        End Set
    End Property
    Private actualMonto_ As Double
    Public Property ActualMonto() As Double
        Get
            Return actualMonto_
        End Get
        Set(ByVal value As Double)
            actualMonto_ = value
        End Set
    End Property
    Private plan_ As Double
    Public Property Plan() As Double
        Get
            Return plan_
        End Get
        Set(ByVal value As Double)
            plan_ = value
        End Set
    End Property
    Private planMonto_ As Double
    Public Property PlanMonto() As Double
        Get
            Return planMonto_
        End Get
        Set(ByVal value As Double)
            planMonto_ = value
        End Set
    End Property
    Private cotizacion_ As Double
    Public Property Cotizacion() As Double
        Get
            Return cotizacion_
        End Get
        Set(ByVal value As Double)
            cotizacion_ = value
        End Set
    End Property
    Private oc_ As Double
    Public Property OC() As Double
        Get
            Return oc_
        End Get
        Set(ByVal value As Double)
            oc_ = value
        End Set
    End Property
    Private compras_ As Double
    Public Property Compras() As Double
        Get
            Return compras_
        End Get
        Set(ByVal value As Double)
            compras_ = value
        End Set
    End Property
    Private poliza_ As Double
    Public Property Poliza() As Double
        Get
            Return poliza_
        End Get
        Set(ByVal value As Double)
            poliza_ = value
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
    Private idPoliza_ As Integer
    Public Property IdPoliza() As Integer
        Get
            Return idPoliza_
        End Get
        Set(ByVal value As Integer)
            idPoliza_ = value
        End Set
    End Property
    Private cantCompra_ As Double
    Public Property CantCompra() As Double
        Get
            Return cantCompra_
        End Get
        Set(ByVal value As Double)
            cantCompra_ = value
        End Set
    End Property
    Private cantPoliza_ As Double
    Public Property CantPoliza() As Double
        Get
            Return cantPoliza_
        End Get
        Set(ByVal value As Double)
            cantPoliza_ = value
        End Set
    End Property
End Class