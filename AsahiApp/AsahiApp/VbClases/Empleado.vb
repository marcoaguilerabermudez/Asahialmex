Public Class Empleado
    Private idEmpleado_ As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return idEmpleado_
        End Get
        Set(ByVal value As Integer)
            idEmpleado_ = value
        End Set
    End Property
    Private usuario_ As String
    Public Property Usuario() As String
        Get
            Return usuario_
        End Get
        Set(ByVal value As String)
            usuario_ = value
        End Set
    End Property
    Private contraseña_ As String
    Public Property Contraseña() As String
        Get
            Return contraseña_
        End Get
        Set(ByVal value As String)
            contraseña_ = value
        End Set
    End Property
    Private nombreCompleto_ As String
    Public Property NombreCompleto() As String
        Get
            Return nombreCompleto_
        End Get
        Set(ByVal value As String)
            nombreCompleto_ = value
        End Set
    End Property
    Private nombres_ As String
    Public Property Nombres() As String
        Get
            Return nombres_
        End Get
        Set(ByVal value As String)
            nombres_ = value
        End Set
    End Property
    Private apellidoPaterno_ As String
    Public Property ApellidoPaterno() As String
        Get
            Return apellidoPaterno_
        End Get
        Set(ByVal value As String)
            apellidoPaterno_ = value
        End Set
    End Property
    Private apellidoMaterno_ As String
    Public Property ApellidoMaterno() As String
        Get
            Return apellidoMaterno_
        End Get
        Set(ByVal value As String)
            apellidoMaterno_ = value
        End Set
    End Property
    Private horario_ As String
    Public Property Horario() As String
        Get
            Return horario_
        End Get
        Set(ByVal value As String)
            horario_ = value
        End Set
    End Property
    Private idDepartamento_ As String
    Public Property IdDepartamento() As String
        Get
            Return idDepartamento_
        End Get
        Set(ByVal value As String)
            idDepartamento_ = value
        End Set
    End Property
    Private departamento_ As String
    Public Property Departamento() As String
        Get
            Return departamento_
        End Get
        Set(ByVal value As String)
            departamento_ = value
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
    Private bono_ As Boolean
    Public Property Bono() As Boolean
        Get
            Return bono_
        End Get
        Set(ByVal value As Boolean)
            bono_ = value
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
    Private fechaIngreso_ As Date
    Public Property FechaIngreso() As Date
        Get
            Return fechaIngreso_
        End Get
        Set(ByVal value As Date)
            fechaIngreso_ = value
        End Set
    End Property
    Private fechaBaja_ As Date
    Public Property FechaBaja() As Date
        Get
            Return fechaBaja_
        End Get
        Set(ByVal value As Date)
            fechaBaja_ = value
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
    Private sueldoNeto_ As Double
    Public Property SueldoNeto() As Double
        Get
            Return sueldoNeto_
        End Get
        Set(ByVal value As Double)
            sueldoNeto_ = value
        End Set
    End Property
    Private sueldoBruto_ As Double
    Public Property SueldoBruto() As Double
        Get
            Return sueldoBruto_
        End Get
        Set(ByVal value As Double)
            sueldoBruto_ = value
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
#End Region
#Region "Fechas Semanas"
    Private fecha1_ As Date
    Public Property Fecha1() As Date
        Get
            Return fecha1_
        End Get
        Set(ByVal value As Date)
            fecha1_ = value
        End Set
    End Property
    Private fecha2_ As Date
    Public Property Fecha2() As Date
        Get
            Return fecha2_
        End Get
        Set(ByVal value As Date)
            fecha2_ = value
        End Set
    End Property
    Private fecha3_ As Date
    Public Property Fecha3() As Date
        Get
            Return fecha3_
        End Get
        Set(ByVal value As Date)
            fecha3_ = value
        End Set
    End Property
    Private fecha4_ As Date
    Public Property Fecha4() As Date
        Get
            Return fecha4_
        End Get
        Set(ByVal value As Date)
            fecha4_ = value
        End Set
    End Property
    Private fecha5_ As Date
    Public Property Fecha5() As Date
        Get
            Return fecha5_
        End Get
        Set(ByVal value As Date)
            fecha5_ = value
        End Set
    End Property
    Private fecha6_ As Date
    Public Property Fecha6() As Date
        Get
            Return fecha6_
        End Get
        Set(ByVal value As Date)
            fecha6_ = value
        End Set
    End Property
    Private fecha7_ As Date
    Public Property Fecha7() As Date
        Get
            Return fecha7_
        End Get
        Set(ByVal value As Date)
            fecha7_ = value
        End Set
    End Property
#End Region
    Private incidencia1_ As Object
    Public Property Incidencia1() As Object
        Get
            Return incidencia1_
        End Get
        Set(ByVal value As Object)
            incidencia1_ = value
        End Set
    End Property
    Private incidencia2_ As Object
    Public Property Incidencia2() As Object
        Get
            Return incidencia2_
        End Get
        Set(ByVal value As Object)
            incidencia2_ = value
        End Set
    End Property
    Private tipoIncidencia1_ As Object
    Public Property TipoIncidencia1() As Object
        Get
            Return tipoIncidencia1_
        End Get
        Set(ByVal value As Object)
            tipoIncidencia1_ = value
        End Set
    End Property
    Private tipoIncidencia2_ As Object
    Public Property TipoIncidencia2() As Object
        Get
            Return tipoIncidencia2_
        End Get
        Set(ByVal value As Object)
            tipoIncidencia2_ = value
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
    Private err_ As Boolean
    Public Property Err() As Boolean
        Get
            Return err_
        End Get
        Set(ByVal value As Boolean)
            err_ = value
        End Set
    End Property
    Private xml_ As Object
    Public Property Xml() As Object
        Get
            Return xml_
        End Get
        Set(ByVal value As Object)
            xml_ = value
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
    Private respuesta_ As Integer
    Public Property Respuesta() As Integer
        Get
            Return respuesta_
        End Get
        Set(ByVal value As Integer)
            respuesta_ = value
        End Set
    End Property
    Private tipoUsuario_ As Integer
    Public Property TipoUsuario() As Integer
        Get
            Return tipoUsuario_
        End Get
        Set(ByVal value As Integer)
            tipoUsuario_ = value
        End Set
    End Property
End Class
