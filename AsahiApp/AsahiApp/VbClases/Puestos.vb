﻿Public Class Puestos
    Private idDp_ As Integer
    Public Property IdDP() As Integer
        Get
            Return idDp_
        End Get
        Set(ByVal value As Integer)
            idDp_ = value
        End Set
    End Property
    Private idPuesto_ As Integer
    Public Property IdPuesto() As Integer
        Get
            Return idPuesto_
        End Get
        Set(ByVal value As Integer)
            idPuesto_ = value
        End Set
    End Property
    Private puesto_ As String
    Public Property Puesto() As String
        Get
            Return puesto_
        End Get
        Set(ByVal value As String)
            puesto_ = value
        End Set
    End Property
    Private idDepto_ As Integer
    Public Property IdDepto() As Integer
        Get
            Return idDepto_
        End Get
        Set(ByVal value As Integer)
            idDepto_ = value
        End Set
    End Property
    Private idArea_ As Integer
    Public Property IdArea() As Integer
        Get
            Return idArea_
        End Get
        Set(ByVal value As Integer)
            idArea_ = value
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
    Private idPuestoReporta_ As Integer
    Public Property IdPuestoReporta() As Integer
        Get
            Return idPuestoReporta_
        End Get
        Set(ByVal value As Integer)
            idPuestoReporta_ = value
        End Set
    End Property
    Private tipoPuesto_ As Integer
    Public Property TipoPuesto() As Integer
        Get
            Return tipoPuesto_
        End Get
        Set(ByVal value As Integer)
            tipoPuesto_ = value
        End Set
    End Property
    Private sexo_ As Integer
    Public Property Sexo() As Integer
        Get
            Return sexo_
        End Get
        Set(ByVal value As Integer)
            sexo_ = value
        End Set
    End Property
    Private edadMin_ As Integer
    Public Property EdadMin() As Integer
        Get
            Return edadMin_
        End Get
        Set(ByVal value As Integer)
            edadMin_ = value
        End Set
    End Property
    Private edadMax_ As Integer
    Public Property EdadMax() As Integer
        Get
            Return edadMax_
        End Get
        Set(ByVal value As Integer)
            edadMax_ = value
        End Set
    End Property
    Private idRelacionEstudios_ As Integer
    Public Property IdRelacionEstudios() As Integer
        Get
            Return idRelacionEstudios_
        End Get
        Set(ByVal value As Integer)
            idRelacionEstudios_ = value
        End Set
    End Property
    Private idEstudios_ As Integer
    Public Property IdEstudios() As Integer
        Get
            Return idEstudios_
        End Get
        Set(ByVal value As Integer)
            idEstudios_ = value
        End Set
    End Property
    Private edoEscolaridad_ As Boolean
    Public Property EdoEscolaridad() As Boolean
        Get
            Return edoEscolaridad_
        End Get
        Set(ByVal value As Boolean)
            edoEscolaridad_ = value
        End Set
    End Property
    Private reqExp_ As Integer
    Public Property ReqExp() As Integer
        Get
            Return reqExp_
        End Get
        Set(ByVal value As Integer)
            reqExp_ = value
        End Set
    End Property
    Private dispViajar_ As Integer
    Public Property DispViajar() As Integer
        Get
            Return dispViajar_
        End Get
        Set(ByVal value As Integer)
            dispViajar_ = value
        End Set
    End Property
    Private tipoViaje_ As Integer
    Public Property TipoViaje() As Integer
        Get
            Return tipoViaje_
        End Get
        Set(ByVal value As Integer)
            tipoViaje_ = value
        End Set
    End Property
    Private justificacion_ As String
    Public Property Justificacion() As String
        Get
            Return justificacion_
        End Get
        Set(ByVal value As String)
            justificacion_ = value
        End Set
    End Property
    Private idIdioma_ As Integer
    Public Property IdIdioma() As Integer
        Get
            Return idIdioma_
        End Get
        Set(ByVal value As Integer)
            idIdioma_ = value
        End Set
    End Property
    Private nivel_ As Integer
    Public Property Nivel() As Integer
        Get
            Return nivel_
        End Get
        Set(ByVal value As Integer)
            nivel_ = value
        End Set
    End Property
    Private objetivoPuestoGrl_ As String
    Public Property ObjetivoPuestoGrl() As String
        Get
            Return objetivoPuestoGrl_
        End Get
        Set(ByVal value As String)
            objetivoPuestoGrl_ = value
        End Set
    End Property
    Private idAutoridad_ As Integer
    Public Property IdAutoridad() As Integer
        Get
            Return idAutoridad_
        End Get
        Set(ByVal value As Integer)
            idAutoridad_ = value
        End Set
    End Property
    Private puestCargo_NOcup_ As Integer
    Public Property PC_NOcup() As Integer
        Get
            Return puestCargo_NOcup_
        End Get
        Set(ByVal value As Integer)
            puestCargo_NOcup_ = value
        End Set
    End Property
    Private puestCargo_PuesRep_ As Integer
    Public Property PC_PuesRep() As Integer
        Get
            Return puestCargo_PuesRep_
        End Get
        Set(ByVal value As Integer)
            puestCargo_PuesRep_ = value
        End Set
    End Property
    Private puestCargo_FuncPrinc_ As String
    Public Property PC_FuncPrinc() As String
        Get
            Return puestCargo_FuncPrinc_
        End Get
        Set(ByVal value As String)
            puestCargo_FuncPrinc_ = value
        End Set
    End Property
    Private idResponsabilidades_ As Integer
    Public Property IdResponsabilidades() As Integer
        Get
            Return idResponsabilidades_
        End Get
        Set(ByVal value As Integer)
            idResponsabilidades_ = value
        End Set
    End Property
    Private responsabilidades_ As String
    Public Property Responsabilidades() As String
        Get
            Return responsabilidades_
        End Get
        Set(ByVal value As String)
            responsabilidades_ = value
        End Set
    End Property
    Private idFrecuencia_ As Integer
    Public Property IdFrecuencia() As Integer
        Get
            Return idFrecuencia_
        End Get
        Set(ByVal value As Integer)
            idFrecuencia_ = value
        End Set
    End Property
    Private frecuencia_ As String
    Public Property Frecuencia() As String
        Get
            Return frecuencia_
        End Get
        Set(ByVal value As String)
            frecuencia_ = value
        End Set
    End Property
    Private idEntregable_ As Integer
    Public Property IdEntregable() As Integer
        Get
            Return idEntregable_
        End Get
        Set(ByVal value As Integer)
            idEntregable_ = value
        End Set
    End Property
    Private entregable_ As String
    Public Property Entregable() As String
        Get
            Return entregable_
        End Get
        Set(ByVal value As String)
            entregable_ = value
        End Set
    End Property
    Private idIndicadores_ As Integer
    Public Property IdIndicadores() As Integer
        Get
            Return idIndicadores_
        End Get
        Set(ByVal value As Integer)
            idIndicadores_ = value
        End Set
    End Property
    Private indicadores_ As String
    Public Property Indicadores() As String
        Get
            Return indicadores_
        End Get
        Set(ByVal value As String)
            indicadores_ = value
        End Set
    End Property
    Private estandar_ As String
    Public Property Estandar() As String
        Get
            Return estandar_
        End Get
        Set(ByVal value As String)
            estandar_ = value
        End Set
    End Property
    Private formula_ As String
    Public Property Formula() As String
        Get
            Return formula_
        End Get
        Set(ByVal value As String)
            formula_ = value
        End Set
    End Property
    Private fuente_ As String
    Public Property Fuente() As String
        Get
            Return fuente_
        End Get
        Set(ByVal value As String)
            fuente_ = value
        End Set
    End Property
    Private idCatalogoCompe_ As Integer
    Public Property IdCatalogoCompe() As Integer
        Get
            Return idCatalogoCompe_
        End Get
        Set(ByVal value As Integer)
            idCatalogoCompe_ = value
        End Set
    End Property
    Private idCompetencia_ As Integer
    Public Property IdCompetencia() As Integer
        Get
            Return idCompetencia_
        End Get
        Set(ByVal value As Integer)
            idCompetencia_ = value
        End Set
    End Property
    Private idCompeTecnicas_ As Integer
    Public Property IdCompeTecnicas() As Integer
        Get
            Return idCompeTecnicas_
        End Get
        Set(ByVal value As Integer)
            idCompeTecnicas_ = value
        End Set
    End Property
    Private compeTecnicas_ As String
    Public Property CompeTecnicas() As String
        Get
            Return compeTecnicas_
        End Get
        Set(ByVal value As String)
            compeTecnicas_ = value
        End Set
    End Property
    Private idCompeGrl_ As Integer
    Public Property IdCompeGrl() As Integer
        Get
            Return idCompeGrl_
        End Get
        Set(ByVal value As Integer)
            idCompeGrl_ = value
        End Set
    End Property
    Private compeGrl_ As String
    Public Property CompeGrl() As String
        Get
            Return compeGrl_
        End Get
        Set(ByVal value As String)
            compeGrl_ = value
        End Set
    End Property
    Private idCompePersoMando_ As Integer
    Public Property IdCompePersoMando() As Integer
        Get
            Return idCompePersoMando_
        End Get
        Set(ByVal value As Integer)
            idCompePersoMando_ = value
        End Set
    End Property
    Private compePersoMando_ As String
    Public Property CompePersoMando() As String
        Get
            Return compePersoMando_
        End Get
        Set(ByVal value As String)
            compePersoMando_ = value
        End Set
    End Property
    Private idRelacionpuesto_ As Integer
    Public Property IdRelacionPuesto() As Integer
        Get
            Return idRelacionpuesto_
        End Get
        Set(ByVal value As Integer)
            idRelacionpuesto_ = value
        End Set
    End Property
    Private contacto_ As String
    Public Property Contacto() As String
        Get
            Return contacto_
        End Get
        Set(ByVal value As String)
            contacto_ = value
        End Set
    End Property
    Private tipoRelacion_ As Integer
    Public Property TipoRelacion() As Integer
        Get
            Return tipoRelacion_
        End Get
        Set(ByVal value As Integer)
            tipoRelacion_ = value
        End Set
    End Property
    Private tipoIndica_ As Boolean
    Public Property TipoIndica() As Boolean
        Get
            Return tipoIndica_
        End Get
        Set(ByVal value As Boolean)
            tipoIndica_ = value
        End Set
    End Property
    Private motivoRelacion_ As String
    Public Property MotivoRelacion() As String
        Get
            Return motivoRelacion_
        End Get
        Set(ByVal value As String)
            motivoRelacion_ = value
        End Set
    End Property
    Private idPuestoExp_ As Integer
    Public Property IdPuestoExp() As Integer
        Get
            Return idPuestoExp_
        End Get
        Set(ByVal value As Integer)
            idPuestoExp_ = value
        End Set
    End Property
    Private puestoExp_ As String
    Public Property PuestoExp() As String
        Get
            Return puestoExp_
        End Get
        Set(ByVal value As String)
            puestoExp_ = value
        End Set
    End Property
    Private cantidadTiempo_ As Integer
    Public Property CantidadTiempo() As Integer
        Get
            Return cantidadTiempo_
        End Get
        Set(ByVal value As Integer)
            cantidadTiempo_ = value
        End Set
    End Property
    Private tipoTiempo_ As String
    Public Property TipoTiempo() As String
        Get
            Return tipoTiempo_
        End Get
        Set(ByVal value As String)
            tipoTiempo_ = value
        End Set
    End Property
    Private idRcr_ As Integer
    Public Property IdRcr() As Integer
        Get
            Return idRcr_
        End Get
        Set(ByVal value As Integer)
            idRcr_ = value
        End Set
    End Property
    Private idCatalogoResp_ As Integer
    Public Property IdCatalogoResp() As Integer
        Get
            Return idCatalogoResp_
        End Get
        Set(ByVal value As Integer)
            idCatalogoResp_ = value
        End Set
    End Property
    Private idRci_ As Integer
    Public Property IdRci() As Integer
        Get
            Return idRci_
        End Get
        Set(ByVal value As Integer)
            idRci_ = value
        End Set
    End Property
    Private idCatalogoIndica_ As Integer
    Public Property IdCatalogoIndica() As Integer
        Get
            Return idCatalogoIndica_
        End Get
        Set(ByVal value As Integer)
            idCatalogoIndica_ = value
        End Set
    End Property
    Private puntMin_ As Double
    Public Property PuntMin() As Double
        Get
            Return puntMin_
        End Get
        Set(ByVal value As Double)
            puntMin_ = value
        End Set
    End Property
    Private puntMax_ As Double
    Public Property PuntMax() As Double
        Get
            Return puntMax_
        End Get
        Set(ByVal value As Double)
            puntMax_ = value
        End Set
    End Property
    Private porceMin_ As Double
    Public Property PorceMin() As Double
        Get
            Return porceMin_
        End Get
        Set(ByVal value As Double)
            porceMin_ = value
        End Set
    End Property
    Private porceMax_ As Double
    Public Property PorceMax() As Double
        Get
            Return porceMax_
        End Get
        Set(ByVal value As Double)
            porceMax_ = value
        End Set
    End Property
    Private idRelacionRespo_ As Integer
    Public Property IdRelacionRespo() As Integer
        Get
            Return idRelacionRespo_
        End Get
        Set(ByVal value As Integer)
            idRelacionRespo_ = value
        End Set
    End Property
    Private idRelacionIndica_ As Integer
    Public Property IdRelacionIndica() As Integer
        Get
            Return idRelacionIndica_
        End Get
        Set(ByVal value As Integer)
            idRelacionIndica_ = value
        End Set
    End Property
    Private idRelacionIdioma_ As Integer
    Public Property IdRelacionIdioma() As Integer
        Get
            Return idRelacionIdioma_
        End Get
        Set(ByVal value As Integer)
            idRelacionIdioma_ = value
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
