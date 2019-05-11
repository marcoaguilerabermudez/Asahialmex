Imports Clases
Imports Negocio

Public Class FrmAcercaDe
    Private usuario As String
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
    Private Sub FrmAcercaDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objPc As New Pc()
        objPc = RecuperaInfoPC(objPc)
        RellenaInformacionPC(objPc)
    End Sub
    Private Function RecuperaInfoPC(ByVal objPc As Pc) As Pc
        Dim objN As New NPc()
        Return objN.InformacionPC(objPc)
    End Function
    Private Sub RellenaInformacionPC(ByVal objPc As Pc)
        LblUsuario.Text = usuario
        LblNombreEquipo.Text = objPc.Nombre
        LblSO.Text = objPc.So
        LblArquitectura.Text = objPc.Arquitectura
        LblRam.Text = objPc.Ram
        LblSerieHdd.Text = objPc.SerieHdd
        LblSerieBoard.Text = objPc.SerieBoard
        LblBoard.Text = objPc.MotherBoard
        LblSerieProcesador.Text = objPc.SerieProcesador
        LblProcesador.Text = objPc.Procesador
    End Sub
End Class