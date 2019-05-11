Imports System.Drawing

Public Class FrmImagen
    Private captura As Image
    Sub New(ByVal imagen As Image)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.captura = imagen
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictCaptura.Image = Me.captura
    End Sub
End Class