Imports Clases
Imports Negocio
Public Class Frm_ConsultaXml
#Region "Variables de Clase"
    Dim cadenaConex As String, cadConex As String
    Dim empleado As New Empleado
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal empleado As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.empleado = empleado
    End Sub
#End Region
    Private Sub Frm_ConsultaXml_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion()
        Me.cadenaConex = conex.conexionCont

    End Sub
    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        RecuperarFacturas()
    End Sub
    Private Sub RecuperarFacturas()
        Dim NComp As New NCompras()
        Dim lstComp As New LCompras()
        Dim folio As String = Txt_Fact.Text
        lstComp = NComp.FacturasRecuperarUUID(Me.cadenaConex, folio)
        RellenarDgvFacturas(lstComp)
    End Sub
    Private Sub RellenarDgvFacturas(ByVal lstComp As LCompras)
        Dim fila As Integer = 0
        Dgv_Facturas.DataSource = Nothing
        Dgv_Facturas.Rows.Clear()

        For Each item In lstComp
            Dgv_Facturas.Rows.Add()
            'Dgv_Compras.Columns("acum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            With Dgv_Facturas.Rows(fila)
                .Cells("folio").Value = item.Factura
                .Cells("rfc").Value = item.RfcEmisor
                .Cells("nombre").Value = item.NombreEmisor
                .Cells("total").Value = Format(item.TotalFactura, "$ #,###,##0.0000")
                .Cells("xml").Value = item.GuidDocument
                .Cells("UUID").Value = item.UUID
            End With
            fila += 1
        Next
    End Sub
    Private Sub Txt_Fact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Fact.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                RecuperarFacturas()
            End If
        End If
    End Sub
End Class