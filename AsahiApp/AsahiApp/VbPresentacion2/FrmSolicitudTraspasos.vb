Imports System.Windows.Forms
Imports Clases
Imports Negocio
Public Class FrmSolicitudTraspasos
#Region "Variables de clase"
    Dim cadenaConex As String
    Dim usuario As New Usuario
    Dim idSuc As Integer
    Private idRecuperado As String
#End Region
#Region "Constructores"
    Sub New(ByVal usuario As Usuario, ByVal idSuc As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.usuario = usuario
        Me.cadenaConex = cadenaConex
        Me.idSuc = idSuc
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
#End Region
#Region "Acciones del Formulario"
    Private Sub FrmSolicitudTraspasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenaCmbSucSolicitar(Me.idSuc)
        RevisarCmbSucSolicitar()
    End Sub
    Private Sub TxtCteSuc_GotFocus(sender As Object, e As EventArgs) Handles TxtCteSuc.GotFocus
        BtnF3.Visible = False
    End Sub
    Private Sub TxtCodCteSuc_GotFocus(sender As Object, e As EventArgs) Handles TxtCodCteSuc.GotFocus
        BtnF3.Visible = False
        If RbnACliente.Checked = True Then
            BtnF3.Visible = True
            BtnF3.SetBounds(128, 92, 28, 21) 'y=128, x=92
        End If
    End Sub
    Private Sub DgvProdSolicitud_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProdSolicitud.CellEnter
        Dim x As Integer, y As Integer, fila As Byte

        If DgvProdSolicitud.CurrentCell.ColumnIndex = 4 Then
            fila = DgvProdSolicitud.CurrentCell.RowIndex
            y = 160 + (fila * 22) 'poscion

            Select Case DgvProdSolicitud.CurrentCell.ColumnIndex
                Case 4 : x = 502 'precio
            End Select

            BtnF3.SetBounds(x, y, 28, 21) ' x, y)
            BtnF3.Visible = True
        Else
            If BtnF3.Visible = True Then BtnF3.Visible = False
        End If
    End Sub
    Private Sub CmbSucSolicitar_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbSucSolicitar.SelectionChangeCommitted
        RevisarCmbSucSolicitar()
    End Sub
    Private Sub RbnACliente_CheckedChanged(sender As Object, e As EventArgs) Handles RbnACliente.CheckedChanged
        LblCteSuc.Text = "Cliente"
        TxtCodCteSuc.Text = Nothing
        TxtCteSuc.Text = Nothing
    End Sub
    Private Sub RbnASucursal_CheckedChanged(sender As Object, e As EventArgs) Handles RbnASucursal.CheckedChanged
        LblCteSuc.Text = "Sucursal"
        BtnF3.Visible = False
        InformacionSucursal(idSuc)
    End Sub
    Private Sub TxtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFolio.KeyDown
        If e.KeyCode = Keys.Enter And TxtFolio.Text <> "" Then
            Dim objNSolicitudTrasp As New NSolicitudTraspasos
            Dim lst As New LSolicitudTraspasos
            If RbnFactura.Checked = True Then
                lst = objNSolicitudTrasp.ObtenerDetalleFacturas(cadenaConex, TxtFolio.Text)
            ElseIf RbnPedido.Checked = True Then
                lst = objNSolicitudTrasp.ObtenerDetallePedido(cadenaConex, TxtFolio.Text)
            End If
            RellenarDgvConFactura(lst)
        End If
    End Sub
    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Dim objNSolicitudTrasp As New NSolicitudTraspasos
        Dim lst As New LSolicitudTraspasos
        If RbnFactura.Checked = True Then
            lst = objNSolicitudTrasp.ObtenerDetalleFacturas(cadenaConex, TxtFolio.Text)
        ElseIf RbnPedido.Checked = True Then
            lst = objNSolicitudTrasp.ObtenerDetallePedido(cadenaConex, TxtFolio.Text)
        End If
        RellenarDgvConFactura(lst)
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
        RevisarCmbSucSolicitar()
    End Sub
    Private Sub BtnSolicitar_Click(sender As Object, e As EventArgs) Handles BtnSolicitar.Click
        Limpiar()
        RevisarCmbSucSolicitar()
    End Sub
#End Region
#Region "Rellenar Cmb's"
    Private Sub RellenaCmbSucSolicitar(ByVal idSuc As Integer)
        Dim objSuc As New NSucursales()
        Dim lstSuc As New LSucursales()
        Dim idSucursal As Integer

        idSucursal = idSuc
        If idSuc = 0 Then idSucursal = 5
        lstSuc = objSuc.MostrarSucursales(cadenaConex, idSucursal)
        With CmbSucSolicitar
            .DataSource = lstSuc
            .DisplayMember = "Sucursal"
            .ValueMember = "IdSuc"
            .SelectedValue = ""
        End With
    End Sub
#End Region
    Private Sub RellenarDgvConFactura(ByVal lst As LSolicitudTraspasos)
        Dim fila As Byte = 0 'contador para fila del DGV
        If RbnFactura.Checked = True Then
            For Each item In lst
                DgvProdSolicitud.Rows.Add()
                DgvProdSolicitud.Rows(fila).Cells("Codigo").Value = item.Codigo
                DgvProdSolicitud.Rows(fila).Cells("Descripcion").Value = item.Descripcion
                DgvProdSolicitud.Rows(fila).Cells("Cantidad").Value = item.Cantidad
                DgvProdSolicitud.Rows(fila).Cells("Costo").Value = item.Costo
                DgvProdSolicitud.Rows(fila).Cells("Precio").Value = item.Precio
                DgvProdSolicitud.Rows(fila).Cells("IdPedidoFactura").Value = item.IdFactura
                fila += 1
            Next
        ElseIf RbnPedido.Checked = True Then
            For Each item In lst
                DgvProdSolicitud.Rows.Add()
                DgvProdSolicitud.Rows(fila).Cells("Codigo").Value = item.Codigo
                DgvProdSolicitud.Rows(fila).Cells("Descripcion").Value = item.Descripcion
                DgvProdSolicitud.Rows(fila).Cells("Cantidad").Value = item.Cantidad
                DgvProdSolicitud.Rows(fila).Cells("Costo").Value = item.Costo
                DgvProdSolicitud.Rows(fila).Cells("Precio").Value = item.Precio
                DgvProdSolicitud.Rows(fila).Cells("IdPedidoFactura").Value = item.IdPedido
                fila += 1
            Next
        End If
    End Sub
    Private Sub RevisarCmbSucSolicitar()
        If CmbSucSolicitar.Text = Nothing Then
            RbnACliente.Enabled = False
            RbnASucursal.Enabled = False
            DgvProdSolicitud.Enabled = False
            RbnFactura.Enabled = False
            RbnPedido.Enabled = False
            TxtFolio.Enabled = False
            BtnF3.Enabled = False
            BtnSolicitar.Enabled = False
            BtnImportar.Enabled = False
        ElseIf CmbSucSolicitar.Text IsNot Nothing Then
            If RbnACliente.Enabled = False Then RbnACliente.Enabled = True
            If RbnASucursal.Enabled = False Then RbnASucursal.Enabled = True
            If DgvProdSolicitud.Enabled = False Then DgvProdSolicitud.Enabled = True
            If RbnFactura.Enabled = False Then RbnFactura.Enabled = True
            If RbnPedido.Enabled = False Then RbnPedido.Enabled = True
            If TxtFolio.Enabled = False Then TxtFolio.Enabled = True
            If BtnF3.Enabled = False Then BtnF3.Enabled = True
            If BtnSolicitar.Enabled = False Then BtnSolicitar.Enabled = True
            If BtnImportar.Enabled = False Then BtnImportar.Enabled = True
        End If
    End Sub
    Private Sub InformacionSucursal(ByVal suc As Integer)
        Dim objEdo As New Estado
        Select Case suc
            Case 1
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (Matriz)"
            Case 2
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Comercializadora Alexander S.A. de C.V. (Monterrey)"
            Case 3
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (Guadalajara)"
            Case 4
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (México)"
            Case 5
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (León)"
            Case 6
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (Veracruz)"
            Case 7
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (Culiacán)"
            Case 11
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Comercializadora Alexander S.A. de C.V. (San Luis)"
            Case 0
                TxtCodCteSuc.Text = 5
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (León)"
        End Select
    End Sub
    Private Sub BtnF3_Click(sender As Object, e As EventArgs) Handles BtnF3.Click
        Select Case BtnF3.Location.X
            Case 128
                Dim frm As New FrmBuscador(1, 1, cadenaConex)
                If frm.ShowDialog() = DialogResult.OK Then
                    idRecuperado = frm.Id
                    CargaId()
                End If
            Case 502
                If DgvProdSolicitud.CurrentRow.Cells("Codigo").Value <> "" Then 'precios
                    Dim frm As New FrmBuscador(3, DgvProdSolicitud.CurrentRow.Cells("Codigo").Value, 1, cadenaConex)
                    If frm.ShowDialog() = DialogResult.OK Then
                        idRecuperado = frm.Id
                        RellenarPrecio()
                        DgvProdSolicitud.Columns("Precio").DefaultCellStyle.Format = "$ ##,##0.00"
                    End If
                End If
        End Select
    End Sub
    Private Sub CargaId()
        Dim objCliente As New Cliente()
        Dim objDireccion As New Direccion
        'DgvProdSolicitud.Rows.Clear()
        objCliente = RecuperarCliente()
        RellenaCliente(objCliente) 'rellena info cliente
    End Sub
    Private Sub RellenarPrecio()
        Dim fila As Byte
        fila = DgvProdSolicitud.CurrentCell.RowIndex
        DgvProdSolicitud.Rows(fila).Cells("Precio").Value = idRecuperado
    End Sub
    Private Function RecuperarCliente() As Cliente
        Dim objCliente As New Cliente()
        Dim objN As New NCliente()

        objCliente.IdCliente = idRecuperado
        Return objN.ObtenerClientePedidos(cadenaConex, objCliente)
    End Function
    Private Sub RellenaCliente(ByVal objCliente As Cliente)
        TxtCodCteSuc.Text = objCliente.IdCliente
        TxtCteSuc.Text = objCliente.Nombre
    End Sub
    Private Sub Limpiar()
        TxtFolio.Text = Nothing
        RbnACliente.Checked = True
        RbnPedido.Checked = True
        CmbSucSolicitar.Text = Nothing
        TxtCodCteSuc.Text = Nothing
        TxtCteSuc.Text = Nothing
        DgvProdSolicitud.Rows.Clear()
    End Sub
End Class