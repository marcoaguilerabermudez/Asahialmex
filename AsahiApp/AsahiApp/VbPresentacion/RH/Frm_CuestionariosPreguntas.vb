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
    Private Sub Btn_Adjuntar_Click(sender As Object, e As EventArgs) Handles Btn_Adjuntar.Click
        Try
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                Txt_Ruta.Text = OpenFileDialog1.FileName
                Pcb_Image.ImageLocation = Txt_Ruta.Text
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Btn_BuscarElementos_Click(sender As Object, e As EventArgs) Handles Btn_BuscarElementos.Click
        If Tbc_Principal.SelectedIndex = 0 Then

        ElseIf Tbc_Principal.SelectedIndex = 1 Then

        ElseIf Tbc_Principal.SelectedIndex = 2 Then

        End If
    End Sub
    Private Sub Btn_DiseñarCuestionario_Click(sender As Object, e As EventArgs)
        Dim Dis As New Frm_CreadorCuestionarios()
        Dis.Show()
        Me.Close()
    End Sub
    Private Sub Cmb_TipoRespuesta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_TipoRespuesta.SelectionChangeCommitted
        If Cmb_TipoRespuesta.SelectedItem <> "" Then
            If Cmb_TipoRespuesta.SelectedItem = "MULTIPLE" Then
                Dgv_OpcionMultiple.Visible = True

            End If
        End If
    End Sub
End Class