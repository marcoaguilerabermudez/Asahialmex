Imports Clases
Public Class FrmFirma
    Public firmaGral As New Firma
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub BtnAceptado_Click(sender As Object, e As EventArgs) Handles BtnAceptado.Click
        If TxtPassFirma.Text = "" Then
            MsgBox("No ha escrito el contraseña")
        Else
            firmaGral.Password = TxtPassFirma.Text
            firmaGral.Comentario = TxtComenFirma.Text
            firmaGral.Firma = True
            firmaGral.Fecha = Format(DateTime.Now, "dd/MM/yyyy")
            firmaGral.Hora = Now.ToString("HH:mm:ss.fff")
            DialogResult = DialogResult.OK
            Me.Dispose()
        End If
    End Sub
    Private Sub BtnRechazado_Click(sender As Object, e As EventArgs) Handles BtnRechazado.Click
        If TxtPassFirma.Text = "" Then
            MsgBox("No ha escrito el contraseña")
        Else
            firmaGral.Password = TxtPassFirma.Text
            firmaGral.Comentario = TxtComenFirma.Text
            firmaGral.Firma = False
            firmaGral.Fecha = Format(DateTime.Now, "dd/MM/yyyy")
            firmaGral.Hora = Now.ToString("HH:mm:ss.fff")
            DialogResult = DialogResult.OK
            Me.Dispose()
        End If
    End Sub
End Class