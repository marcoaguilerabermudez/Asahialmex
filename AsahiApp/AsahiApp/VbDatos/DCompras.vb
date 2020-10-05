Imports Clases
Imports System.Collections.Concurrent
Imports System.Data.SqlClient

Public Class DCompras
    Public Function RecuperarLstCompras(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date, Optional ByVal subsi As String = "") As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_previopoliza", oCon)
            query.Parameters.AddWithValue("@fechai", fi)
            query.Parameters.AddWithValue("@fechaf", ff)
            query.Parameters.AddWithValue("@subsi", subsi)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.IdProvision = Convert.ToInt32(dr("Id_provision").ToString)
                comp.IdCompra = dr("Compra").ToString
                comp.IdOrdenCompra = Convert.ToInt32(dr("Oc").ToString)
                comp.Serie = dr("Serie").ToString
                comp.Factura = dr("Factura").ToString
                comp.Proveedor = dr("Proveedor").ToString
                comp.MontoOC = Convert.ToDouble(dr("MontoOc").ToString)
                comp.MontoFact = Convert.ToDouble(dr("MontoFact").ToString)
                comp.MontoPagar = Convert.ToDouble(dr("MontoaPagar").ToString)
                comp.MontoCompra = Convert.ToDouble(dr("MontoCompra").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("FechaFactura").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaPagoFact").ToString)
                comp.FechaPagoReal = Convert.ToDateTime(dr("FechaPagoReal").ToString)
                comp.Moneda = dr("Moneda").ToString
                comp.Empresa = dr("Empresa").ToString
                comp.FechaCompra = Convert.ToDateTime(dr("FechaCompra").ToString)
                comp.UUID = dr("idfact").ToString
                comp.TazaCambio = dr("tc").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function VistaPoliza(ByVal cadenaConex As String, ByVal moneda As String, ByVal idFac As String, ByVal tc As Double, Optional subsi As String = "") As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_vistaPrincipalPolizaPrueba", oCon)
            query.Parameters.AddWithValue("@variable", moneda)
            query.Parameters.AddWithValue("@uuid", idFac)
            query.Parameters.AddWithValue("@tc", tc)
            query.Parameters.AddWithValue("@subsid", subsi)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.Pivote = Convert.ToInt32(dr("Pivote").ToString)
                comp.IdOrdenCompra = Convert.ToInt32(dr("OC").ToString)
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.Serie = (dr("Serie").ToString)
                comp.Factura = (dr("Factura").ToString)
                comp.Proveedor = (dr("Proveedor").ToString)
                comp.Rfc = (dr("RFC").ToString)
                comp.TotalFactura = Convert.ToDouble(dr("Total_Factura").ToString)
                comp.CompraTotal = Convert.ToDouble(dr("CompraTotal").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("Fecha_Factura").ToString)
                comp.Moneda = (dr("Moneda").ToString)
                comp.Empresa = (dr("Empresa").ToString)
                comp.RfcEmisor = (dr("RFCEmisor").ToString)
                comp.NombreEmisor = (dr("NombreEmisor").ToString)
                comp.UUID = (dr("UUID").ToString)
                comp.Total = Convert.ToDouble(dr("Total").ToString)
                comp.Area = (dr("Área").ToString)
                comp.Familia = (dr("Familia").ToString)
                comp.Cuenta = (dr("Cuenta").ToString)
                comp.Neto = Convert.ToDouble(dr("Neto").ToString)
                comp.CuentaIva = (dr("Cuenta_iva").ToString)
                comp.IvaT = Convert.ToDouble(dr("Iva_t").ToString)
                comp.CuentaP = (dr("CuentaP").ToString)
                comp.Impuesto = Convert.ToDouble(dr("Impuesto").ToString)
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarEgreso(ByVal cadenaConex As String, ByVal moneda As String, ByVal idFac As String, Optional subsi As String = "") As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("PolizaEgresoRecuperar", oCon)
            query.Parameters.AddWithValue("@uuid", idFac)
            query.Parameters.AddWithValue("@moneda", moneda)
            query.Parameters.AddWithValue("@subsid", subsi)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120

            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.Pivote = Convert.ToInt32(dr("Pivot").ToString)
                comp.FechaFactura = Convert.ToDateTime(dr("Fecha").ToString)
                comp.Ejercicio = Convert.ToInt32(dr("Ejercicio").ToString)
                comp.Periodo = Convert.ToInt32(dr("Periodo").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaAplicacion").ToString)
                comp.EjercicioPago = Convert.ToInt32(dr("EjercicioAp").ToString)
                comp.PeriodoPago = Convert.ToInt32(dr("PeriodoAp").ToString)
                comp.IdProveedor = Convert.ToInt32(dr("CodPersona").ToString)
                comp.Proveedor = (dr("Persona").ToString)
                comp.Moneda = Convert.ToInt32(dr("Moneda").ToString)
                comp.TazaCambio = Convert.ToDouble(dr("TC").ToString)
                comp.TotalFactura = Convert.ToDouble(dr("Total").ToString)
                comp.IdOrdenCompra = Convert.ToInt32(dr("OC").ToString)
                comp.Concepto = dr("Concepto").ToString
                comp.CuentaClabe = dr("Clabe").ToString
                comp.Area = dr("SC").ToString
                comp.Cuenta = (dr("Cuenta").ToString)
                comp.UUID = dr("Uuid").ToString
                lstComp.Add(comp)
#Region "Comentados"
                'comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                'comp.Serie = (dr("Serie").ToString)
                'comp.Factura = (dr("Factura").ToString)
                'comp.Rfc = (dr("RFC").ToString)
                'comp.TotalFactura = Convert.ToDouble(dr("Total_Factura").ToString)
                'comp.CompraTotal = Convert.ToDouble(dr("CompraTotal").ToString)
                'comp.Empresa = (dr("Empresa").ToString)
                'comp.RfcEmisor = (dr("RFCEmisor").ToString)
                'comp.NombreEmisor = (dr("NombreEmisor").ToString)
                'comp.UUID = (dr("UUID").ToString)
                'comp.Area = (dr("Área").ToString)
                'comp.Familia = (dr("Familia").ToString)
                'comp.Neto = Convert.ToDouble(dr("Neto").ToString)
                'comp.CuentaIva = (dr("Cuenta_iva").ToString)
                'comp.IvaT = Convert.ToDouble(dr("Iva_t").ToString)
                'comp.CuentaP = (dr("CuentaP").ToString)
                'comp.Impuesto = Convert.ToDouble(dr("Impuesto").ToString)
#End Region
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaProveedores(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date, Optional subsi As String = "") As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Dim querytxt As String = ""
        If subsi = "MEX" Then
            querytxt = "SELECT Proveedor FROM AsahiSystem.dbo.Provisiones_compras where (FechaFactura between '" & fi & "' and '" & ff & "') AND StatusConta = 1	AND (Serie = 'A' or Serie = 'N') and Empresa = 'AAM' group by Proveedor"
        ElseIf subsi = "SERV" Then
            querytxt = "SELECT Proveedor FROM AsahiSystem.dbo.Provisiones_compras where (FechaFactura between '" & fi & "' and '" & ff & "') AND StatusConta = 1	AND (Serie = 'A' or Serie = 'N') and Empresa = 'AAMS' group by Proveedor"
        End If
        Try
            oCon.Open()
            Dim query As New SqlCommand(querytxt, oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Proveedor = dr("Proveedor").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaFamilia(ByVal cadenaConex As String, ByVal uuid As String) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Familia FROM conta.[Asahi].[dbo].[VistaPolizaMx] where UUID = '" & uuid & "' group by Familia", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Familia = dr("Familia").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarListaSegNeg(ByVal cadenaConex As String, ByVal uuid As String) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Área FROM conta.[Asahi].[dbo].[VistaPolizaMx] where UUID = '" & uuid & "' group by Área", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim comp As New Compras
                comp.Area = dr("Área").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarLstPorProvisionar(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_muestraprovisionescomprasPrueba", oCon)
            query.Parameters.AddWithValue("@fecha", fi)
            query.Parameters.AddWithValue("@fecha2", ff)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.IdProvision = Convert.ToInt32(dr("Id_provision").ToString)
                comp.Oc = dr("Oc").ToString
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.Factura = dr("Factura").ToString
                comp.Proveedor = dr("Proveedor").ToString
                comp.Rfc = dr("RFC").ToString
                comp.RfcEmisor = dr("RFCEmisor").ToString
                comp.Moneda = dr("Moneda").ToString
                comp.MontoOC = Convert.ToDouble(dr("MontoOc").ToString)
                comp.MontoCompra = Convert.ToDouble(dr("MontoCompra").ToString)
                comp.MontoFact = Convert.ToDouble(dr("MontoFact").ToString)
                comp.MontoPagar = Convert.ToDouble(dr("MontoaPagar").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("FechaFactura").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaPagoFact").ToString)
                comp.FechaPagoReal = Convert.ToDateTime(dr("FechaPagoReal").ToString)
                comp.Status = dr("Status").ToString
                comp.ObservaCompra = dr("ObservaCompra").ToString
                comp.ObservaConta = dr("ObservaConta").ToString
                comp.Empresa = dr("Empresa").ToString
                comp.NombreEmisor = dr("NombreEmisor").ToString
                comp.Add = dr("Add").ToString
                comp.StatusConta = dr("StatusConta").ToString
                comp.Val1 = Convert.ToInt32(dr("Val1").ToString)
                comp.Val2 = Convert.ToInt32(dr("Val2").ToString)
                comp.Val3 = Convert.ToInt32(dr("Val3").ToString)
                comp.Val4 = Convert.ToInt32(dr("Val4").ToString)
                comp.Ruta = dr("Ruta").ToString
                comp.IdOrdenCompra = Convert.ToInt32(dr("o").ToString)
                comp.Serie = dr("Serie").ToString
                comp.FechaCompra = Convert.ToDateTime(dr("FechaCompra").ToString)
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarLstProvisionadas(ByVal cadenaConex As String, ByVal fi As Date, ByVal ff As Date) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_muestraprovisionescomprasvalidadasPruebas", oCon)
            query.Parameters.AddWithValue("@inicio", fi)
            query.Parameters.AddWithValue("@fin", ff)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.IdProvision = Convert.ToInt32(dr("Id_provision").ToString)
                comp.StatusConta = dr("SC").ToString
                comp.Oc = dr("Oc").ToString
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.Factura = dr("Factura").ToString
                comp.Proveedor = dr("Proveedor").ToString
                comp.Rfc = dr("RFC").ToString
                comp.RfcEmisor = dr("RFCEmisor").ToString
                comp.Moneda = dr("Moneda").ToString
                comp.MontoOC = Convert.ToDouble(dr("MontoOc").ToString)
                comp.MontoCompra = Convert.ToDouble(dr("MontoCompra").ToString)
                comp.MontoFact = Convert.ToDouble(dr("MontoFact").ToString)
                comp.MontoPagar = Convert.ToDouble(dr("MontoaPagar").ToString)
                comp.FP = Convert.ToDateTime(dr("FP").ToString)
                comp.FechaFact = Convert.ToDateTime(dr("FechaFactura").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaPagoFact").ToString)
                comp.StatusPago = dr("StatusPago").ToString
                comp.Status = dr("Status").ToString
                comp.ObservaCompra = dr("ObservaCompra").ToString
                comp.ObservaConta = dr("ObservaConta").ToString
                comp.Empresa = dr("Empresa").ToString
                comp.NombreEmisor = dr("NombreEmisor").ToString
                comp.Add = dr("Add").ToString
                comp.Val1 = Convert.ToInt32(dr("Val1").ToString)
                comp.Val2 = Convert.ToInt32(dr("Val2").ToString)
                comp.Val3 = Convert.ToInt32(dr("Val3").ToString)
                comp.Val4 = Convert.ToInt32(dr("Val4").ToString)
                comp.Ruta = dr("Ruta").ToString
                comp.FechaPagoReal = Convert.ToDateTime(dr("FDP").ToString)
                comp.IdOrdenCompra = Convert.ToInt32(dr("o").ToString)
                comp.Serie = dr("Serie").ToString
                comp.UUID = dr("idfact").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function RecuperarProvValidadas(ByVal cadenaConex As String) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_muestraprovisionescontabilidadvalidadas", oCon)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras()
                comp.FechaValidado = Convert.ToDateTime(dr("FechaVal").ToString)
                comp.IdProvision = Convert.ToInt32(dr("Id_Provision").ToString)
                comp.Oc = dr("Oc").ToString
                comp.IdCompra = Convert.ToInt32(dr("Compra").ToString)
                comp.Factura = Convert.ToInt32(dr("Factura").ToString)
                comp.Proveedor = dr("Proveedor").ToString
                comp.Rfc = dr("RFC").ToString
                comp.RfcEmisor = dr("RFCEmisor").ToString
                comp.MontoCompra = dr("MontoCompra").ToString
                comp.MontoFact = Convert.ToDouble(dr("MontoFact").ToString)
                comp.MontoPagar = Convert.ToDouble(dr("MontoPagar").ToString)
                comp.MontoOC = Convert.ToDouble(dr("MontoOC").ToString)
                comp.FechaFactura = Convert.ToDateTime(dr("FechaFactura").ToString)
                comp.FechaPagoFact = Convert.ToDateTime(dr("FechaPagoFact").ToString)
                comp.ObservaCompra = dr("ObservaCompra").ToString
                comp.Moneda = dr("Moneda").ToString
                comp.FechaPagoReal = Convert.ToDateTime(dr("FechaPagoReal").ToString)
                comp.Status = dr("Status").ToString
                comp.StatusConta = dr("Statusconta").ToString
                comp.StatusPago = dr("StatusPago").ToString
                comp.ObservaConta = dr("ObservaConta").ToString
                comp.Empresa = dr("Empresa").ToString
                comp.NombreEmisor = dr("NombreEmisor").ToString
                comp.Add = dr("Add").ToString
                comp.Val1 = dr("Val1").ToString
                comp.Val2 = dr("Val2").ToString
                comp.Val3 = dr("Val3").ToString
                comp.Val4 = dr("Val4").ToString
                comp.Ruta = dr("Ruta").ToString
                comp.IdCompra = Convert.ToInt32(dr("o").ToString)
                comp.Serie = dr("Serie").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Sub ActualizarXml(ByVal cadenaConex As String)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_actualizaxml", oCon)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteNonQuery()
            MsgBox("¡Actualizado con éxito!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Sub ProcesoProviciones(ByVal cadenaConex As String, ByVal comp As Compras)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Sp_actualizaxml", oCon)
            query.Parameters.AddWithValue("@id_provision", comp.IdProvision)
            query.Parameters.AddWithValue("@factura", comp.Factura)
            query.Parameters.AddWithValue("@fecha", Date.Now())
            query.Parameters.AddWithValue("@montofact", comp.MontoFact)
            query.Parameters.AddWithValue("@fechapago", comp.FechaPagoFact)
            query.Parameters.AddWithValue("@empresa", comp.Empresa)
            query.Parameters.AddWithValue("@Oc", comp.Oc)
            query.Parameters.AddWithValue("@Proveedor", comp.Proveedor)
            query.Parameters.AddWithValue("@Serie", comp.Serie)
            query.Parameters.AddWithValue("@Estado", comp.Status)
            query.Parameters.AddWithValue("@rfcemisor", comp.Rfc)
            query.Parameters.AddWithValue("@observa", comp.IdProvision)
            query.Parameters.AddWithValue("@COMPRA", comp.IdProvision)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteNonQuery()
            MsgBox("¡Proceso realizado con éxito!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Sub InsertarRuta(ByVal cadenaConex As String, ByVal comp As Compras)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Prov_InsertarRuta", oCon)
            query.Parameters.AddWithValue("@xml", comp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

            MsgBox("Se insertó correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Function FacturasRecuperarUUID(ByVal cadenaConex As String, ByVal factura As String) As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim lstComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Asahi.dbo.RecuperarFacturas", oCon)
            query.Parameters.AddWithValue("@folio", factura)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras
                comp.Factura = dr("folio").ToString
                comp.RfcEmisor = dr("RFCEmisor").ToString
                comp.NombreEmisor = dr("NombreEmisor").ToString
                comp.TotalFactura = dr("total").ToString
                comp.GuidDocument = dr("GuidDocument").ToString
                comp.UUID = dr("UUID").ToString
                lstComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstComp
    End Function
    Public Function ConsultarImpuestosExtra(ByVal cadenaConex As String, ByVal uuid As String, Optional subsi As String = "") As LCompras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim LComp As New LCompras()
        Try
            oCon.Open()
            Dim query As New SqlCommand("Asahi.dbo.ImpuestosExtraRecuperar", oCon)
            query.Parameters.AddWithValue("@uuid", uuid)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                Dim comp As New Compras
                comp.ImpExtNombre = dr("Tipo").ToString
                comp.ImpExtTasaOCuota = Convert.ToDouble(dr("TasaOCuota").ToString)
                comp.ImpExtImporte = Convert.ToDouble(dr("Importe").ToString)
                LComp.Add(comp)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return LComp
    End Function
    Public Function RecuperaSubCategorias(ByVal cadenaConex As String, ByVal lstCompras As LCompras, ByVal cta As String, ByVal segneg As String) As String
        Dim oCon As New SqlConnection(cadenaConex)
        Dim cd As String = "0"
        Try
            oCon.Open()
            Dim query As New SqlCommand("SELECT Top 1 Codigo FROM Conta.ctAAM.dbo.Categorias where CodigoCuenta = '" & cta & "' and IdSegNeg = (SELECT Id FROM Conta.ctAAM.dbo.SegmentosNegocio where Codigo = " & segneg & ") and CodigoMoneda = " & lstCompras(0).Moneda & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                cd = dr("Codigo").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return cd
    End Function
    Public Function RecuperaCategorias(ByVal cadenaConex As String, ByVal moneda As Integer) As String
        Dim oCon As New SqlConnection(cadenaConex)
        Dim cd As String = "0"
        Try
            oCon.Open()
            Dim query As New SqlCommand("Select Codigo from conta.ctAAM.dbo.Categorias where IdSegNeg = 0 and Nivel = 'C' and Tipo = 'E' and CodigoMoneda =  " & moneda & "", oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                cd = dr("Codigo").ToString
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return cd
    End Function
    Public Function RecuperarBancos(ByVal cadenaConex As String, Optional ByVal subsi As String = "") As LBancos
        Dim lstBanc As New LBancos()
        Dim oCon As New SqlConnection(cadenaConex)
        Dim cd As String = "0"
        Dim querytxt As String = ""
        If subsi = "MEX" Then
            querytxt = "Select Nombre, Codigo from conta.ctAAM.dbo.CuentasCheques"
        ElseIf subsi = "SERV" Then
            querytxt = "Select Nombre, Codigo from conta.ctAAMS.dbo.CuentasCheques"
        End If
        Try
            oCon.Open()
            Dim query As New SqlCommand(querytxt, oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                Dim banc As New Bancos()
                banc.NombreBanco = dr("Nombre").ToString
                banc.Codigo = dr("Codigo").ToString
                lstBanc.Add(banc)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return lstBanc
    End Function
    Public Function RecuperarIdBanco(ByVal cadenaConex As String, ByVal codigo As String, Optional ByVal subsi As String = "") As Integer
        Dim idBanco As Integer
        Dim oCon As New SqlConnection(cadenaConex)
        Dim querytxt As String = ""
        If subsi = "MEX" Then
            querytxt = "Select IdBanco from conta.ctAAM.dbo.CuentasCheques where Codigo = '" & codigo & "'"
        ElseIf subsi = "SERV" Then
            querytxt = "Select IdBanco from conta.ctAAMS.dbo.CuentasCheques where Codigo = '" & codigo & "'"
        End If
        Try
            oCon.Open()
            Dim query As New SqlCommand(querytxt, oCon)
            query.CommandTimeout = 60
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read())
                idBanco = Convert.ToInt32(dr("IdBanco").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return idBanco
    End Function
    Public Sub AgregarBitacora(ByVal cadenaConex As String, ByVal comp As Compras)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Asahi.dbo.AgregarBitacora", oCon)
            query.Parameters.AddWithValue("@xml", comp.Xml)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

            'MsgBox("Se insertó correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
    Public Function ConsultaBitacoraCreados(ByVal cadenaConex As String, ByVal comp As Compras) As Compras
        Dim oCon As New SqlConnection(cadenaConex)
        Dim com As New Compras
        Try
            oCon.Open()
            Dim query As New SqlCommand("Asahi.dbo.BitacoraCreados", oCon)
            query.Parameters.AddWithValue("@oc", comp.IdOrdenCompra)
            query.Parameters.AddWithValue("@monto", comp.MontoFact)
            query.Parameters.AddWithValue("@provi", comp.IdProvision)
            query.Parameters.AddWithValue("@subsi", comp.Empresa)
            query.Parameters.AddWithValue("@tipo", comp.Tipo)
            query.CommandType = CommandType.StoredProcedure
            query.CommandTimeout = 120
            Dim dr As SqlDataReader
            dr = query.ExecuteReader
            While (dr.Read)
                com.TxtCreado = Convert.ToBoolean(dr("creaTxt").ToString)
                com.DocContableCrea = Convert.ToBoolean(dr("creaDoc").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
        Return com
    End Function
    Public Sub EmpatarDocumentosContablesBitacora(ByVal cadenaConex As String, ByVal subsid As String)
        Dim oCon As New SqlConnection(cadenaConex)
        Try
            oCon.Open()
            Dim query As New SqlCommand("Asahi.dbo.AgregaPolizaProyeccionesBitacora", oCon)
            query.Parameters.AddWithValue("@subsid", subsid)
            query.CommandType = CommandType.StoredProcedure
            query.ExecuteScalar()

            'MsgBox("Se insertó correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If (oCon.State = ConnectionState.Open) Then
                oCon.Close()
            End If
            oCon.Dispose()
        End Try
    End Sub
End Class