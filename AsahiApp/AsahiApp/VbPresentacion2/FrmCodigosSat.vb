Imports Negocio
Imports Clases
Public Class FrmCodigosSat
    Dim usuario As String
    Private cadenaConex As String
    Sub New(ByVal usuario As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.usuario = usuario
        Me.cadenaConex = cadenaConex
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub FrmCodigosSat_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim CodigoSat As New CodigoSat()

        RellenaCmbDivision()
        RellenaCmbSubDivision()

        CodigoSat.Id_Sub = CmbSubDivision.SelectedItem.Id_Sub
        ObtenerListaCodigosFiltro(CodigoSat)
    End Sub

    Private Sub RellenaCmbDivision()
        Dim NCodigoSat As New NCodigoSat()
        Dim lst As New LCodigoSat()
        lst = NCodigoSat.CodigosSatDivObtener(cadenaConex)
        With CmbDivision
            .DataSource = lst
            .DisplayMember = "NombreDiv"
            .ValueMember = "Id_Div"
            .SelectedValue = 2 'para seleccionar Equipos y Maquinaria por default
        End With

    End Sub
    Private Sub RellenaCmbSubDivision()
        Dim NCodigoSat As New NCodigoSat()
        Dim lst As New LCodigoSat()
        Dim CodigoSat As New CodigoSat()

        CodigoSat.Id_Div = CmbDivision.SelectedItem.Id_Div
        lst = NCodigoSat.CodigoSatSubObtener(cadenaConex, CodigoSat)
        With CmbSubDivision
            .DataSource = lst
            .DisplayMember = "NombreSub"
            .ValueMember = "Id_Sub"
        End With
    End Sub
    Private Sub ObtenerListaCodigosFiltro(ByVal CodigoSat As CodigoSat)
        Dim lst As New LCodigoSat()
        Dim NCodigoSat As New NCodigoSat()

        lst = NCodigoSat.CodigoSatObtenerFiltro(cadenaConex, CodigoSat)
        RellenaDgvCodigoSat(lst)
    End Sub
    Private Sub CmbDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbDivision.SelectionChangeCommitted
        RellenaCmbSubDivision()
    End Sub
    Private Sub RellenaDgvCodigoSat(ByVal lst As LCodigoSat)

        With DgvCodigoSat
            .DataSource = Nothing
            .DataSource = lst
        End With
        DgvCodigoSat.Columns("Id_Div").Visible = False
        DgvCodigoSat.Columns("NombreDiv").Visible = False
        DgvCodigoSat.Columns("Id_Sub").Visible = False
        DgvCodigoSat.Columns("NombreSub").Visible = False
    End Sub

    Private Sub CmbSubDivision_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbSubDivision.SelectionChangeCommitted
        Dim CodigoSat As New CodigoSat()
        CodigoSat.Id_Sub = CmbSubDivision.SelectedItem.Id_Sub
        ObtenerListaCodigosFiltro(CodigoSat)

        txtBuscar.Text = Nothing
        RbCodigo.Checked = False
        RbDescripcion.Checked = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim CodigoSat As New CodigoSat()

        If RbCodigo.Checked = True Then
            CodigoSat.IdCodSat = txtBuscar.Text
        ElseIf RbDescripcion.Checked = True Then
            CodigoSat.Descripcion = txtBuscar.Text
        End If
        ObtenerListaCodigosFiltro(CodigoSat)
    End Sub

    Private Sub CmbSubDivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSubDivision.SelectedIndexChanged

    End Sub
End Class