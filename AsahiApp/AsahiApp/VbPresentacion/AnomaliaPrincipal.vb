Public Class AnomaliaPrincipal

    Dim id As Integer
    Dim permiso As Integer
    Dim depto As String
    Dim puesto As Integer


    Sub New(id As Integer, depto As String, permiso As Integer, puesto As Integer)

        InitializeComponent()

        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.puesto = puesto

    End Sub



    Private Sub AnomaliaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AnomaliaDetalle.Show()
    End Sub



End Class