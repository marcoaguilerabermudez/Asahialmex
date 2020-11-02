Imports Clases
Imports Negocio

Public Class Frm_ConceptoEgreso
    Dim lstComp As New LCompras
    Dim conex As New conexion()
    Dim cadenaConex As String
    Dim ip As String = Strings.Left(Me.conex.getIp(), 6)
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal lstComp As LCompras)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.lstComp = lstComp
    End Sub
    Private concepto_ As String
    Public Property Concepto() As String
        Get
            Return concepto_
        End Get
        Set(ByVal value As String)
            concepto_ = value
        End Set
    End Property
    Private Sub Frm_ConceptoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim IdProveedor As Integer
        Dim proveedor As String, concepto As String
        If Me.ip = "172.16" Then
            Me.cadenaConex = Me.conex.cadenaConexExpress
        Else
            Me.cadenaConex = Me.conex.cadenaConexExpressFor
        End If
        IdProveedor = Me.lstComp.Item(0).IdProveedor
        proveedor = Me.lstComp.Item(0).Proveedor
        concepto = Me.lstComp.Item(0).Concepto.Replace("
", " ")
        Txt_IdPersona.Text = IdProveedor
        Txt_Persona.Text = proveedor
        Txt_Concepto.Text = Replace(concepto, vbLf, " ")
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Me.Concepto = Txt_Concepto.Text
        DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
    Private Sub Frm_ConceptoEgreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                Me.Concepto = Txt_Concepto.Text
                DialogResult = DialogResult.OK
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub Txt_Concepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Concepto.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                Me.Concepto = Txt_Concepto.Text
                DialogResult = DialogResult.OK
                Me.Dispose()
            End If
        End If
    End Sub
End Class