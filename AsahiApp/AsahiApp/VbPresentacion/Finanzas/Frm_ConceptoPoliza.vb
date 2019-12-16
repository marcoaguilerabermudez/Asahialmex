Public Class Frm_ConceptoPoliza
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal text As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Txt_Concepto.Text = text
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
    Private Sub Frm_ConceptoPoliza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Me.Concepto = Txt_Concepto.Text
        DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
    Private Sub Txt_Concepto_TextChanged(sender As Object, e As EventArgs) Handles Txt_Concepto.TextChanged
        If Len(Txt_Concepto.Text) > 45 And Len(Txt_Concepto.Text) < 101 Then
            Btn_Guardar.Enabled = True
        Else
            Btn_Guardar.Enabled = False
        End If
    End Sub
End Class