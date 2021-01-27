Public Class Puestos
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
    Private idEstudios_ As Integer
    Public Property IdEstudios() As Integer
        Get
            Return idEstudios_
        End Get
        Set(ByVal value As Integer)
            idEstudios_ = value
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
    Private motivoRelacion_ As String
    Public Property MotivoRelacion() As String
        Get
            Return motivoRelacion_
        End Get
        Set(ByVal value As String)
            motivoRelacion_ = value
        End Set
    End Property
End Class
