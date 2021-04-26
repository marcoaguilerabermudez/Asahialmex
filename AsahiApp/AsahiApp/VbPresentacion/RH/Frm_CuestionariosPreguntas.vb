Imports Clases
Imports Negocio
Public Class Frm_CuestionariosPreguntas
    Dim Emp As New Empleado()
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal emp As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Emp = emp
    End Sub
    Private Sub Frm_CuestionariosPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dgv_OpcionMultiple.Columns("respuesta").DataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
End Class