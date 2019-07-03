Public Class Horarios
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private descripcionHorario_ As String
    Public Property DescripcionHorario() As String
        Get
            Return descripcionHorario_
        End Get
        Set(ByVal value As String)
            descripcionHorario_ = value
        End Set
    End Property
    Private idHorario_ As Integer
    Public Property IdHorario() As Integer
        Get
            Return idHorario_
        End Get
        Set(ByVal value As Integer)
            idHorario_ = value
        End Set
    End Property
    Private horaEntrada_ As String
    Public Property HoraEntrada() As String
        Get
            Return horaEntrada_
        End Get
        Set(ByVal value As String)
            horaEntrada_ = value
        End Set
    End Property
    Private horaSalida_ As String
    Public Property HoraSalida() As String
        Get
            Return horaSalida_
        End Get
        Set(ByVal value As String)
            horaSalida_ = value
        End Set
    End Property
    Private lector_ As String
    Public Property Lector() As String
        Get
            Return lector_
        End Get
        Set(ByVal value As String)
            lector_ = value
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
    Private año_ As Integer
    Public Property Año() As String
        Get
            Return año_
        End Get
        Set(ByVal value As String)
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
    Private idMotivoRetardo_ As String
    Public Property IdMotivoRetardo() As String
        Get
            Return idMotivoRetardo_
        End Get
        Set(ByVal value As String)
            idMotivoRetardo_ = value
        End Set
    End Property
    Private motivoRetardo_ As String
    Public Property MotivoRetardo() As String
        Get
            Return motivoRetardo_
        End Get
        Set(ByVal value As String)
            motivoRetardo_ = value
        End Set
    End Property
    Private idTurno_ As Integer
    Public Property IdTurno() As Integer
        Get
            Return idTurno_
        End Get
        Set(ByVal value As Integer)
            idTurno_ = value
        End Set
    End Property
    Private turno_ As String
    Public Property Turno() As String
        Get
            Return turno_
        End Get
        Set(ByVal value As String)
            turno_ = value
        End Set
    End Property
    Private tp_ As String
    Public Property TP() As String
        Get
            Return tp_
        End Get
        Set(ByVal value As String)
            tp_ = value
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
#Region "Checadas"
    Private horaEntradaReal0_ As Date
    Public Property HoraEntradaReal0() As Date
        Get
            Return horaEntradaReal0_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal0_ = value
        End Set
    End Property
    Private horaSalidaReal0_ As Date
    Public Property HoraSalidaReal0() As Date
        Get
            Return horaSalidaReal0_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal0_ = value
        End Set
    End Property
    Private tipoRegistro0_ As String
    Public Property TipoRegistro0() As String
        Get
            Return tipoRegistro0_
        End Get
        Set(ByVal value As String)
            tipoRegistro0_ = value
        End Set
    End Property
    Private nota0_ As String
    Public Property Nota0() As String
        Get
            Return nota0_
        End Get
        Set(ByVal value As String)
            nota0_ = value
        End Set
    End Property
    Private horaEntradaReal1_ As Date
    Public Property HoraEntradaReal1() As Date
        Get
            Return horaEntradaReal1_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal1_ = value
        End Set
    End Property
    Private horaSalidaReal1_ As Date
    Public Property HoraSalidaReal1() As Date
        Get
            Return horaSalidaReal1_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal1_ = value
        End Set
    End Property
    Private tipoRegistro1_ As String
    Public Property TipoRegistro1() As String
        Get
            Return tipoRegistro1_
        End Get
        Set(ByVal value As String)
            tipoRegistro1_ = value
        End Set
    End Property
    Private nota1_ As String
    Public Property Nota1() As String
        Get
            Return nota1_
        End Get
        Set(ByVal value As String)
            nota1_ = value
        End Set
    End Property
    Private horaEntradaReal2_ As Date
    Public Property HoraEntradaReal2() As Date
        Get
            Return horaEntradaReal2_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal2_ = value
        End Set
    End Property
    Private horaSalidaReal2_ As Date
    Public Property HoraSalidaReal2() As Date
        Get
            Return horaSalidaReal2_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal2_ = value
        End Set
    End Property
    Private tipoRegistro2_ As String
    Public Property TipoRegistro2() As String
        Get
            Return tipoRegistro2_
        End Get
        Set(ByVal value As String)
            tipoRegistro2_ = value
        End Set
    End Property
    Private nota2_ As String
    Public Property Nota2() As String
        Get
            Return nota2_
        End Get
        Set(ByVal value As String)
            nota2_ = value
        End Set
    End Property
    Private horaEntradaReal3_ As Date
    Public Property HoraEntradaReal3() As Date
        Get
            Return horaEntradaReal3_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal3_ = value
        End Set
    End Property
    Private horaSalidaReal3_ As Date
    Public Property HoraSalidaReal3() As Date
        Get
            Return horaSalidaReal3_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal3_ = value
        End Set
    End Property
    Private tipoRegistro3_ As String
    Public Property TipoRegistro3() As String
        Get
            Return tipoRegistro3_
        End Get
        Set(ByVal value As String)
            tipoRegistro3_ = value
        End Set
    End Property
    Private nota3_ As String
    Public Property Nota3() As String
        Get
            Return nota3_
        End Get
        Set(ByVal value As String)
            nota3_ = value
        End Set
    End Property
    Private horaEntradaReal4_ As Date
    Public Property HoraEntradaReal4() As Date
        Get
            Return horaEntradaReal4_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal4_ = value
        End Set
    End Property
    Private horaSalidaReal4_ As Date
    Public Property HoraSalidaReal4() As Date
        Get
            Return horaSalidaReal4_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal4_ = value
        End Set
    End Property
    Private tipoRegistro4_ As String
    Public Property TipoRegistro4() As String
        Get
            Return tipoRegistro4_
        End Get
        Set(ByVal value As String)
            tipoRegistro4_ = value
        End Set
    End Property
    Private nota4_ As String
    Public Property Nota4() As String
        Get
            Return nota4_
        End Get
        Set(ByVal value As String)
            nota4_ = value
        End Set
    End Property
    Private horaEntradaReal5_ As Date
    Public Property HoraEntradaReal5() As Date
        Get
            Return horaEntradaReal5_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal5_ = value
        End Set
    End Property
    Private horaSalidaReal5_ As Date
    Public Property HoraSalidaReal5() As Date
        Get
            Return horaSalidaReal5_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal5_ = value
        End Set
    End Property
    Private tipoRegistro5_ As String
    Public Property TipoRegistro5() As String
        Get
            Return tipoRegistro5_
        End Get
        Set(ByVal value As String)
            tipoRegistro5_ = value
        End Set
    End Property
    Private nota5_ As String
    Public Property Nota5() As String
        Get
            Return nota5_
        End Get
        Set(ByVal value As String)
            nota5_ = value
        End Set
    End Property
    Private horaEntradaReal6_ As Date
    Public Property HoraEntradaReal6() As Date
        Get
            Return horaEntradaReal6_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal6_ = value
        End Set
    End Property
    Private horaSalidaReal6_ As Date
    Public Property HoraSalidaReal6() As Date
        Get
            Return horaSalidaReal6_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal6_ = value
        End Set
    End Property
    Private tipoRegistro6_ As String
    Public Property TipoRegistro6() As String
        Get
            Return tipoRegistro6_
        End Get
        Set(ByVal value As String)
            tipoRegistro6_ = value
        End Set
    End Property
    Private nota6_ As String
    Public Property Nota6() As String
        Get
            Return nota6_
        End Get
        Set(ByVal value As String)
            nota6_ = value
        End Set
    End Property
    Private horaEntradaReal7_ As Date
    Public Property HoraEntradaReal7() As Date
        Get
            Return horaEntradaReal7_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal7_ = value
        End Set
    End Property
    Private horaSalidaReal7_ As Date
    Public Property HoraSalidaReal7() As Date
        Get
            Return horaSalidaReal7_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal7_ = value
        End Set
    End Property
    Private tipoRegistro7_ As String
    Public Property TipoRegistro7() As String
        Get
            Return tipoRegistro7_
        End Get
        Set(ByVal value As String)
            tipoRegistro7_ = value
        End Set
    End Property
    Private nota7_ As String
    Public Property Nota7() As String
        Get
            Return nota7_
        End Get
        Set(ByVal value As String)
            nota7_ = value
        End Set
    End Property
    Private horaEntradaReal8_ As Date
    Public Property HoraEntradaReal8() As Date
        Get
            Return horaEntradaReal8_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal8_ = value
        End Set
    End Property
    Private horaSalidaReal8_ As Date
    Public Property HoraSalidaReal8() As Date
        Get
            Return horaSalidaReal8_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal8_ = value
        End Set
    End Property
    Private tipoRegistro8_ As String
    Public Property TipoRegistro8() As String
        Get
            Return tipoRegistro8_
        End Get
        Set(ByVal value As String)
            tipoRegistro8_ = value
        End Set
    End Property
    Private nota8_ As String
    Public Property Nota8() As String
        Get
            Return nota8_
        End Get
        Set(ByVal value As String)
            nota8_ = value
        End Set
    End Property
    Private horaEntradaReal9_ As Date
    Public Property HoraEntradaReal9() As Date
        Get
            Return horaEntradaReal9_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal9_ = value
        End Set
    End Property
    Private horaSalidaReal9_ As Date
    Public Property HoraSalidaReal9() As Date
        Get
            Return horaSalidaReal9_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal9_ = value
        End Set
    End Property
    Private tipoRegistro9_ As String
    Public Property TipoRegistro9() As String
        Get
            Return tipoRegistro9_
        End Get
        Set(ByVal value As String)
            tipoRegistro9_ = value
        End Set
    End Property
    Private nota9_ As String
    Public Property Nota9() As String
        Get
            Return nota9_
        End Get
        Set(ByVal value As String)
            nota9_ = value
        End Set
    End Property
    Private horaEntradaReal10_ As Date
    Public Property HoraEntradaReal10() As Date
        Get
            Return horaEntradaReal10_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal10_ = value
        End Set
    End Property
    Private horaSalidaReal10_ As Date
    Public Property HoraSalidaReal10() As Date
        Get
            Return horaSalidaReal10_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal10_ = value
        End Set
    End Property
    Private tipoRegistro10_ As String
    Public Property TipoRegistro10() As String
        Get
            Return tipoRegistro10_
        End Get
        Set(ByVal value As String)
            tipoRegistro10_ = value
        End Set
    End Property
    Private nota10_ As String
    Public Property Nota10() As String
        Get
            Return nota10_
        End Get
        Set(ByVal value As String)
            nota10_ = value
        End Set
    End Property
    Private horaEntradaReal11_ As Date
    Public Property HoraEntradaReal11() As Date
        Get
            Return horaEntradaReal11_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal11_ = value
        End Set
    End Property
    Private horaSalidaReal11_ As Date
    Public Property HoraSalidaReal11() As Date
        Get
            Return horaSalidaReal11_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal11_ = value
        End Set
    End Property
    Private tipoRegistro11_ As String
    Public Property TipoRegistro11() As String
        Get
            Return tipoRegistro11_
        End Get
        Set(ByVal value As String)
            tipoRegistro11_ = value
        End Set
    End Property
    Private nota11_ As String
    Public Property Nota11() As String
        Get
            Return nota11_
        End Get
        Set(ByVal value As String)
            nota11_ = value
        End Set
    End Property
    Private horaEntradaReal12_ As Date
    Public Property HoraEntradaReal12() As Date
        Get
            Return horaEntradaReal12_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal12_ = value
        End Set
    End Property
    Private horaSalidaReal12_ As Date
    Public Property HoraSalidaReal12() As Date
        Get
            Return horaSalidaReal12_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal12_ = value
        End Set
    End Property
    Private tipoRegistro12_ As String
    Public Property TipoRegistro12() As String
        Get
            Return tipoRegistro12_
        End Get
        Set(ByVal value As String)
            tipoRegistro12_ = value
        End Set
    End Property
    Private nota12_ As String
    Public Property Nota12() As String
        Get
            Return nota12_
        End Get
        Set(ByVal value As String)
            nota12_ = value
        End Set
    End Property
    Private horaEntradaReal13_ As Date
    Public Property HoraEntradaReal13() As Date
        Get
            Return horaEntradaReal13_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal13_ = value
        End Set
    End Property
    Private horaSalidaReal13_ As Date
    Public Property HoraSalidaReal13() As Date
        Get
            Return horaSalidaReal13_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal13_ = value
        End Set
    End Property
    Private tipoRegistro13_ As String
    Public Property TipoRegistro13() As String
        Get
            Return tipoRegistro13_
        End Get
        Set(ByVal value As String)
            tipoRegistro13_ = value
        End Set
    End Property
    Private nota13_ As String
    Public Property Nota13() As String
        Get
            Return nota13_
        End Get
        Set(ByVal value As String)
            nota13_ = value
        End Set
    End Property
    Private horaEntradaReal14_ As Date
    Public Property HoraEntradaReal14() As Date
        Get
            Return horaEntradaReal14_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal14_ = value
        End Set
    End Property
    Private horaSalidaReal14_ As Date
    Public Property HoraSalidaReal14() As Date
        Get
            Return horaSalidaReal14_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal14_ = value
        End Set
    End Property
    Private tipoRegistro14_ As String
    Public Property TipoRegistro14() As String
        Get
            Return tipoRegistro14_
        End Get
        Set(ByVal value As String)
            tipoRegistro14_ = value
        End Set
    End Property
    Private nota14_ As String
    Public Property Nota14() As String
        Get
            Return nota14_
        End Get
        Set(ByVal value As String)
            nota14_ = value
        End Set
    End Property
    Private horaEntradaReal15_ As Date
    Public Property HoraEntradaReal15() As Date
        Get
            Return horaEntradaReal15_
        End Get
        Set(ByVal value As Date)
            horaEntradaReal15_ = value
        End Set
    End Property
    Private horaSalidaReal15_ As Date
    Public Property HoraSalidaReal15() As Date
        Get
            Return horaSalidaReal15_
        End Get
        Set(ByVal value As Date)
            horaSalidaReal15_ = value
        End Set
    End Property
    Private tipoRegistro15_ As String
    Public Property TipoRegistro15() As String
        Get
            Return tipoRegistro15_
        End Get
        Set(ByVal value As String)
            tipoRegistro15_ = value
        End Set
    End Property
    Private nota15_ As String
    Public Property Nota15() As String
        Get
            Return nota15_
        End Get
        Set(ByVal value As String)
            nota15_ = value
        End Set
    End Property
#End Region
End Class
