Imports System.Windows.Forms
Imports Clases
Imports Negocio
Public Class FrmExportar
    Dim Usuario As New Usuario
    Dim IdSuc As New Integer
    Dim cadenaConex As String
    Dim lst As New LFactura()
    Dim LCte As New LCliente()
    Dim lstProd As New LProducto()
    Dim LstFDetalle As New LFactura()

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal Usuario As Usuario, ByVal IdSuc As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Usuario = Usuario
        Me.IdSuc = IdSuc
        Me.cadenaConex = cadenaConex
    End Sub
    Private Sub FrmExportar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenaCmbSucursal()
    End Sub
    Private Sub RellenaCmbSucursal()
        Dim DSuc As New NSucursales()
        Dim lst As New LSucursales

        lst = DSuc.ObtenerListSucSia(cadenaConex)

        With CmbSucursal
            .DataSource = lst
            .ValueMember = "CarpetaSia"
            .DisplayMember = "Sucursal"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub BtnRecuperar_Click(sender As Object, e As EventArgs) Handles BtnRecuperar.Click
        Dim NExportar As New NExportar()
        Dim Factura As New Factura()
        Dim Cte As New Cliente()
        Dim DCte As New NCliente()

        Factura.Fecha = DtpFecha.Value
        lst = NExportar.RecuperarFacturas(cadenaConex, Factura)
        LCte = NExportar.RecuperarClientes(cadenaConex, Factura)
        LstFDetalle = NExportar.RecuperarFacturaDetalle(cadenaConex, Factura)
        lstProd = NExportar.RecuperarProductosDetalle(cadenaConex, Factura)

        RellenaDgvExportar()
        RellenaDgvDetalle()

    End Sub
    Private Sub RellenaDgvExportar()
        Dim fila As Integer = 0
        With DgvExportar
            For Each item In lst
                .Rows.Add()
                .Rows(fila).Cells("idFactura").Value = item.IdFactura
                '.Rows(fila).Cells("fechaEmision").Value = Format("dd/MM/YY", item.Fecha)
                .Rows(fila).Cells("idCliente").Value = item.IdCliente
                .Rows(fila).Cells("rfc").Value = LCte.Item(fila).Rfc
                .Rows(fila).Cells("nombreCliente").Value = item.Cliente
                .Rows(fila).Cells("diasCredito").Value = item.DiasCredito
                .Rows(fila).Cells("subtotal").Value = item.Subtotal
                .Rows(fila).Cells("iva").Value = item.Iva
                .Rows(fila).Cells("total").Value = item.Total
                fila += 1
            Next
        End With
    End Sub
    Private Sub RellenaDgvDetalle()
        Dim fila As Integer = 0
        With DgvDetalle
            For Each item In lstProd
                .Rows.Add()
                .Rows(fila).Cells("idDetalle").Value = item.IdDetalle
                .Rows(fila).Cells("idFacturaDetalle").Value = LstFDetalle.Item(fila).IdFactura
                .Rows(fila).Cells("codigo").Value = item.Codigo
                .Rows(fila).Cells("cantidad").Value = item.Cantidad
                .Rows(fila).Cells("precio").Value = item.Precio
                .Rows(fila).Cells("precioTotal").Value = item.PrecioTotal
                .Rows(fila).Cells("ivaTotal").Value = item.IvaTotal
                .Rows(fila).Cells("subtotalD").Value = item.Subtotal
                fila += 1
            Next
        End With
    End Sub
    Private Sub PruebaImportaSia()
        Dim NExportar As New NExportar()
        Dim dt As New DataTable()

        dt = NExportar.PruebaImportaSia()
        DgvExportar.DataSource = dt
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim result As String
        result = MessageBox.Show("Para este proceso es necesario estar conectado al servidor" & vbCrLf &
                                 "Si no está conectado hagalo en este momento" & vbCrLf &
                                 "¿Desea Continuar?", "Conexion al Servidor", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            If lst.Count > 0 Then
                If CmbSucursal.SelectedValue <> "" Then
                    Dim NExportar As New NExportar()
                    Dim Factura As New Factura
                    Dim suc As New Sucursales

                    Factura.Fecha = DtpFecha.Value

                    'Factura = NExportar.UltimaFactura_TOVEN()
                    'Factura.IdFaturaSia += 1 'Sig folio GS_TOVEN

                    'Factura.IdFaturaSia = 1 'Sig folio GS_TOVEN
                    'Factura.IdDetalleFacturaSia = 1 'sig Folio GS_VENTA
                    suc.CarpetaSia = CmbSucursal.SelectedValue
                    NExportar.EscribeDBF_TOVEN(Factura, lst, LCte, suc)
                    NExportar.EscribeDBF_VENTA(Factura, lstProd, LstFDetalle, suc)
                    MsgBox("Proceso Terminado")
                Else
                    MsgBox("Es necesario seleccionar una sucursal de destino")
                End If
            Else
                MsgBox("No hay informacion que Exportar" & vbCrLf & "Selecciona una fecha diferente y presione el boton Recuperar")
            End If
        End If

    End Sub
End Class