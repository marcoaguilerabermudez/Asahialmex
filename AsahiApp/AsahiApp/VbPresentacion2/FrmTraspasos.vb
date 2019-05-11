Imports System.Windows.Forms
Imports Clases
Imports Negocio

Public Class FrmTraspasos
#Region "Variables de clase"
    Dim cadenaConex As String
    Dim usuario As New Usuario
    Dim idTraspaso As Integer
    Dim idSuc As Integer
    Dim sucSolicitaEstatus As String
    Dim sucSurteEstatus As String
    Private idRecuperado As String
    Private tabla As SByte 'clientes=1, productos=2
#End Region
#Region "Constructores"
    Sub New(ByVal usuario As Usuario, ByVal idSuc As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.usuario = usuario
        Me.cadenaConex = cadenaConex
        Me.idSuc = idSuc
    End Sub
    Sub New(ByVal objUsuario As Usuario, ByVal idSuc As Integer, ByVal idTraspaso As Integer, ByVal sucSolicitaEstatus As String, ByVal sucSurteEstatus As String, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.usuario = objUsuario
        Me.cadenaConex = cadenaConex
        Me.idTraspaso = idTraspaso
        Me.idSuc = idSuc
        Me.sucSolicitaEstatus = sucSolicitaEstatus
        Me.sucSurteEstatus = sucSurteEstatus
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
#End Region
#Region "Rellena Cmb's"
    Private Sub RellenaCmbEstado()
        Dim objEstados As New NEstado()
        Dim lstEstados As New LEstado()
        lstEstados = objEstados.ObtenerEstadosClien(cadenaConex)
        With CmbEdo
            .DataSource = lstEstados
            .DisplayMember = "Estado"
            .ValueMember = "fol"
            .SelectedValue = ""
        End With
    End Sub
    Private Sub RellenaCmbCiudad(objEdo As Estado)
        Dim objCiudad As New NCiudad()
        Dim lstCiudad As New LCiudad()
        lstCiudad = objCiudad.ObtenerCiudadesClien(cadenaConex, objEdo)
        With CmbCiudad
            .DataSource = lstCiudad
            .DisplayMember = "Nombre"
            .ValueMember = "id"
            .SelectedValue = ""
        End With
    End Sub
    Private Sub RellenaCmbPaqueteria()
        Dim objPaqueteria As New NPaqueteria()
        Dim lstPaqueteria As New LPaqueteria()
        lstPaqueteria = objPaqueteria.ObtenerPaqueterias(cadenaConex)
        With CmbPaqueteria
            .DataSource = lstPaqueteria
            .DisplayMember = "Nombre"
            .ValueMember = "IdPaq"
            .SelectedValue = ""
        End With
    End Sub
    Private Sub RellenaCmbSucSolicitar(ByVal idSuc As Integer)
        Dim objSuc As New NSucursales()
        Dim lstSuc As New LSucursales()
        Dim idSucursal As Integer

        idSucursal = idSuc
        If idSuc = 0 Then idSucursal = 5
        lstSuc = objSuc.MostrarSucursales(cadenaConex, idSucursal)
        With CmbSucSolicitar
            .DataSource = lstSuc
            .DisplayMember = "Sucursal"
            .ValueMember = "IdSuc"
            .SelectedValue = ""
        End With
    End Sub
    Private Sub RellenaCmbFormaPago()
        With CmbFormaPago
            .Items.Add("X Cobrar")
            .Items.Add("Pagado")
            .SelectedValue = ""
        End With
    End Sub
    Private Sub RellenaCmbFormaEntrega()
        With CmbFormaEntrega
            .Items.Add("A Domicilio")
            .Items.Add("Ocurre")
            .SelectedValue = ""
        End With
    End Sub
    Private Sub RellenaCmbAliasDir(objCliente As Cliente)
        Dim objLDir As New LDireccion()
        Dim objNDir As New NDireccion()
        Dim Direccion As New Direccion()
        If sucSolicitaEstatus = Nothing Then sucSolicitaEstatus = RevisarSucRec(LblSucursalLocal.Text)
        objLDir = objNDir.ObtenerAliasTraspaso(cadenaConex, objCliente, sucSolicitaEstatus)
        With CmbAlias
            .DataSource = objLDir
            .DisplayMember = "Aliass"
            .ValueMember = "IdDireccion"
        End With
    End Sub
#End Region
#Region "Sucursales"
    Private Sub RevisarSuc(ByVal suc As Integer)
        Select Case suc
            Case 1
                LblSucursalLocal.Text = "Monterrey"
            Case 2
                LblSucursalLocal.Text = "Alexander Monterrey"
            Case 3
                LblSucursalLocal.Text = "Guadalajara"
            Case 4
                LblSucursalLocal.Text = "México"
            Case 5
                LblSucursalLocal.Text = "León"
            Case 6
                LblSucursalLocal.Text = "Veracruz"
            Case 7
                LblSucursalLocal.Text = "Culiacan"
            Case 7
                LblSucursalLocal.Text = "Alexander San Luis"
            Case 0
                LblSucursalLocal.Text = "León Copy"
        End Select
    End Sub
    Private Sub InformacionSucursal(ByVal suc As Integer)
        Dim objEdo As New Estado
        Select Case suc
            Case 1
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (Matriz)"
                TxtDireccion.Text = "José Maria Coss"
                TxtNoExt.Text = "3330"
                TxtNoInt.Text = ""
                TxtColonia.Text = "Del Nte."
                CmbEdo.SelectedValue = 19
                objEdo.Fol = 19
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 948
                TxtCp.Text = "64500"
                TxtTelefono.Text = "83511091"
                TxtContacto.Text = "Ing. Alfonso Leal Cantú"
            Case 2
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Comercializadora Alexander S.A. de C.V. (Monterrey)"
                TxtDireccion.Text = "Zuazua"
                TxtNoExt.Text = "3331"
                TxtNoInt.Text = ""
                TxtColonia.Text = "Del Nte."
                CmbEdo.SelectedValue = 19
                objEdo.Fol = 19
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 948
                TxtCp.Text = "64500 "
                TxtTelefono.Text = "8183315908"
                TxtContacto.Text = "Ruven Rivera"
            Case 3
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (Guadalajara)"
                TxtDireccion.Text = "Igualdad"
                TxtNoExt.Text = "477"
                TxtNoInt.Text = ""
                TxtColonia.Text = "La Esperanza (La Federacha)"
                CmbEdo.SelectedValue = 14
                objEdo.Fol = 14
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 532
                TxtCp.Text = "44300 "
                TxtTelefono.Text = "3336039604"
                TxtContacto.Text = "Ricardo Curiel"
            Case 4
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (México)"
                TxtDireccion.Text = "Carretera Cuautitlán - Tlanepantla km 15.5"
                TxtNoExt.Text = "15"
                TxtNoInt.Text = ""
                TxtColonia.Text = " La Concepción"
                CmbEdo.SelectedValue = 15
                objEdo.Fol = 15
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 738
                TxtCp.Text = "54900"
                TxtTelefono.Text = "5522250610"
                TxtContacto.Text = "Guillermo Balderas"
            Case 5
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (León)"
                TxtDireccion.Text = "Av. la merced"
                TxtNoExt.Text = "1902"
                TxtNoInt.Text = ""
                TxtColonia.Text = "Santa Rita"
                CmbEdo.SelectedValue = 11
                objEdo.Fol = 11
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 334
                TxtCp.Text = "37450"
                TxtTelefono.Text = "4777151631"
                TxtContacto.Text = "Daniel Gonzalez"
            Case 6
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (Veracruz)"
                TxtDireccion.Text = "Hernán Cortés"
                TxtNoExt.Text = "1036"
                TxtNoInt.Text = ""
                TxtColonia.Text = "Zona Centro"
                CmbEdo.SelectedValue = 30
                objEdo.Fol = 30
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 2113
                TxtCp.Text = "91700"
                TxtTelefono.Text = "8442779339"
                TxtContacto.Text = "Uriel Lima"
            Case 7
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (Culiacán)"
                TxtDireccion.Text = "Isabel de Tovar"
                TxtNoExt.Text = "5144"
                TxtNoInt.Text = ""
                TxtColonia.Text = "San Rafael"
                CmbEdo.SelectedValue = 25
                objEdo.Fol = 25
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 1872
                TxtCp.Text = "80150"
                TxtTelefono.Text = "6671704333"
                TxtContacto.Text = "Marcos Lara"
            Case 11
                TxtCodCteSuc.Text = suc
                TxtCteSuc.Text = "Comercializadora Alexander S.A. de C.V. (San Luis)"
                TxtDireccion.Text = ""
                TxtNoExt.Text = ""
                TxtNoInt.Text = ""
                TxtColonia.Text = ""
                CmbEdo.SelectedValue = 24
                objEdo.Fol = 24
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 1814
                TxtCp.Text = ""
                TxtTelefono.Text = ""
                TxtContacto.Text = "Rogelio Gasca"
            Case 0
                TxtCodCteSuc.Text = 5
                TxtCteSuc.Text = "Abastecedora Leal S.A. de C.V. (León)"
                TxtDireccion.Text = "Av. la merced"
                TxtNoExt.Text = "1902"
                TxtNoInt.Text = ""
                TxtColonia.Text = "Santa Rita"
                CmbEdo.SelectedValue = 11
                objEdo.Fol = 11
                RellenaCmbCiudad(objEdo)
                CmbCiudad.SelectedValue = 334
                TxtCp.Text = "37450"
                TxtTelefono.Text = "4777151631"
                TxtContacto.Text = "Daniel Gonzalez"
        End Select
    End Sub
    Private Function RevisarSucRec(ByVal sucEstatus As String) As String
        Dim suc As String
        suc = ""
        Select Case sucEstatus
            Case "Monterrey"
                suc = "mty"
            Case "Alexander M"
                suc = "ale"
            Case "Guadalajara"
                suc = "gdl"
            Case "México"
                suc = "mex"
            Case "León"
                suc = "leo"
            Case "Veracruz"
                suc = "ver"
            Case "Culiacan"
                suc = "cul"
            Case "Alexander SL"
                suc = "snl"
            Case "León_Copy"
                suc = "leo_copy"
            Case "León Copy"
                suc = "leo_copy"
        End Select
        Return suc
    End Function
    Private Function RevisarSucRecInt(ByVal sucEstatus As String, ByVal frm As String) As Integer
        Dim suc As Integer
        suc = 0
        If frm = 1 Then
            Select Case sucEstatus
                Case "Monterrey"
                    suc = 1
                Case "Alexander M"
                    suc = 2
                Case "Guadalajara"
                    suc = 3
                Case "México"
                    suc = 4
                Case "León"
                    suc = 5
                Case "Veracruz"
                    suc = 6
                Case "Culiacan"
                    suc = 7
                Case "Alexander SL"
                    suc = 11
                Case "León_Copy"
                    suc = 0
                Case "leoCopy"
                    suc = 0
            End Select
        Else
            Select Case sucEstatus
                Case "mty"
                    suc = 1
                Case "ale"
                    suc = 2
                Case "gdl"
                    suc = 3
                Case "mex"
                    suc = 4
                Case "leo"
                    suc = 5
                Case "ver"
                    suc = 6
                Case "cul"
                    suc = 7
                Case "snl"
                    suc = 11
                Case "leo_copy"
                    suc = 0
            End Select
        End If
        Return suc
    End Function
    Private Function ubicacionArchivo(ByVal suc As Integer, ByVal btn As Byte)
        If btn = 1 Then
            Select Case suc
                Case 1
                    Return "F:\Emp01\AG_ENXTR.DBF"
                Case 2
                    Return "F:\Emp02\AG_ENXTR.DBF"
                Case 3
                    Return "F:\Emp03\AG_ENXTR.DBF"
                Case 4
                    Return "F:\Emp04\AG_ENXTR.DBF"
                Case 5
                    Return "F:\Emp05\AG_ENXTR.DBF"
                Case 6
                    Return "F:\Emp06\AG_ENXTR.DBF"
                Case 7
                    Return "F:\Emp07\AG_ENXTR.DBF"
                Case 11
                    Return "F:\Emp11\AG_ENXTR.DBF"
                Case 0
                    Return "F:\Emp05\AG_ENXTR.DBF"
                Case Else
                    Return "F:\Emp05\AG_ENXTR.DBF"
            End Select
        Else
            Select Case suc
                Case 1
                    Return "F:\Emp01\AG_TRASP.DBF"
                Case 2
                    Return "F:\Emp02\AG_TRASP.DBF"
                Case 3
                    Return "F:\Emp03\AG_TRASP.DBF"
                Case 4
                    Return "F:\Emp04\AG_TRASP.DBF"
                Case 5
                    Return "F:\Emp05\AG_TRASP.DBF"
                Case 6
                    Return "F:\Emp06\AG_TRASP.DBF"
                Case 7
                    Return "F:\Emp07\AG_TRASP.DBF"
                Case 11
                    Return "F:\Emp11\AG_TRASP.DBF"
                Case 0
                    Return "F:\Emp05\AG_TRASP.DBF"
                Case Else
                    Return "F:\Emp05\AG_TRASP.DBF"
            End Select
        End If
    End Function
#End Region
#Region "Relacionado con Limpiar"
    Private Sub LimpiarCEnvio()
        TxtCodCteSuc.Text = Nothing
        TxtCteSuc.Text = Nothing
        TxtDireccion.Text = Nothing
        TxtNoExt.Text = Nothing
        TxtNoInt.Text = Nothing
        TxtColonia.Text = Nothing
        CmbEdo.Text = Nothing
        CmbCiudad.Text = Nothing
        TxtCp.Text = Nothing
        TxtTelefono.Text = Nothing
        TxtContacto.Text = Nothing
    End Sub
    Private Sub LimpiarInfoAd()
        LblCreaModificaUsuario.Text = Nothing
        LblCreaModificaComentario.Text = Nothing
        LblAutorizaEnvioUsuario.Text = Nothing
        LblAutorizaEnvioComentario.Text = Nothing
        LblSurteUsuario.Text = Nothing
        LblSurteComentario.Text = Nothing
        LblRecibeUsuario.Text = Nothing
        LblRecibeComentario.Text = Nothing
        TxtFolioSalidaSia.Text = Nothing
        TxtFolioSalidaSia.Text = Nothing
    End Sub
    Private Sub Limpiar()
        Dim Utilerias As New PUtilerias
        Utilerias.LimpiarComboBox(Me, False, False, False, True, True, False)
        Utilerias.LimpiarTextBox(Me)
        DgvTraspaso.Rows.Clear()
        RbnACliente.Checked = True
        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        If BtnAutorizar.Enabled = True Then BtnAutorizar.Enabled = False
        If BtnSurtir.Enabled = True Then BtnSurtir.Enabled = False
        If BtnCrearModificar.Enabled = False Then BtnCrearModificar.Enabled = True
        If BtnRecibirTrasp.Enabled = True Then BtnRecibirTrasp.Enabled = False
    End Sub
#End Region
#Region "Acciones de formulario"
    Private Sub BtnBackOrder_Click(sender As Object, e As EventArgs) Handles BtnBackOrder.Click
    End Sub
    Private Sub RbnACliente_CheckedChanged(sender As Object, e As EventArgs) Handles RbnACliente.CheckedChanged
        LblCteSuc.Text = "Cliente"
        LblAlias.Visible = True
        CmbAlias.Visible = True
        LimpiarCEnvio()
    End Sub
    Private Sub RbnASucursal_CheckedChanged(sender As Object, e As EventArgs) Handles RbnASucursal.CheckedChanged
        LblCteSuc.Text = "Sucursal"
        LblAlias.Visible = False
        CmbAlias.Visible = False
        BtnF3.Visible = False
        InformacionSucursal(idSuc)
    End Sub
    Private Sub CmbEdo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbEdo.SelectionChangeCommitted
        Dim objEdo As New Estado

        CmbCiudad.Text = Nothing
        objEdo.Fol = CmbEdo.SelectedValue

        RellenaCmbCiudad(objEdo)
    End Sub
    Private Sub TxtCteSuc_GotFocus(sender As Object, e As EventArgs) Handles TxtCteSuc.GotFocus
        BtnF3.Visible = False
    End Sub
    Private Sub TxtCodCteSuc_GotFocus(sender As Object, e As EventArgs) Handles TxtCodCteSuc.GotFocus
        BtnF3.Visible = False
        If RbnACliente.Checked = True Then
            BtnF3.Visible = True
            BtnF3.SetBounds(113, 13, 28, 21) 'y=113, x=13
        End If
    End Sub
    Private Sub DgvTraspaso_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTraspaso.CellEnter
        Dim x As Integer, y As Integer, fila As Byte

        If DgvTraspaso.CurrentCell.ColumnIndex = 0 Or DgvTraspaso.CurrentCell.ColumnIndex = 13 Then
            fila = DgvTraspaso.CurrentCell.RowIndex
            y = 115 + (fila * 22) 'poscion

            Select Case DgvTraspaso.CurrentCell.ColumnIndex
                Case 0 : x = 115'codigo
                Case 13 : x = 965 'precio
            End Select

            BtnF3.SetBounds(x, y, 28, 21) ' x, y)
            BtnF3.Visible = True
        Else
            If BtnF3.Visible = True Then BtnF3.Visible = False
        End If
    End Sub
    Private Sub BtnF3_Click(sender As Object, e As EventArgs) Handles BtnF3.Click
        Select Case BtnF3.Location.X
            Case 113
                Dim frm As New FrmBuscador(1, 1, cadenaConex)
                If frm.ShowDialog() = DialogResult.OK Then
                    idRecuperado = frm.Id
                    tabla = 1 'cliente
                    CargaId()
                End If

            Case 115
                If CmbSucSolicitar.Text <> Nothing Then
                    Dim frm As New FrmBuscador(2, 1, cadenaConex) 'codigo
                    If frm.ShowDialog() = DialogResult.OK Then
                        idRecuperado = frm.Id
                        tabla = 2
                        CargaId()
                    End If
                Else
                    MsgBox("Debe seleccionar la sucursal a donde se solicitará la mercancia")
                End If
            Case 965
                If DgvTraspaso.CurrentRow.Cells("Codigo").Value <> "" Then 'precios
                    Dim frm As New FrmBuscador(3, DgvTraspaso.CurrentRow.Cells("Codigo").Value, 1, cadenaConex)
                    If frm.ShowDialog() = DialogResult.OK Then
                        idRecuperado = frm.Id
                        RellenarPrecio()
                        DgvTraspaso.Columns("PrecioUnit").DefaultCellStyle.Format = "$ ##,##0.00"
                    End If
                End If
        End Select
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
        LimpiarInfoAd()
        RevisarSuc(Me.idSuc)
        RevisarCmbSucSolicitar()
    End Sub
    Private Sub CmbAlias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbAlias.SelectionChangeCommitted
        RecuperarDireccion(CmbAlias.SelectedItem.Aliass)
    End Sub
    Private Sub DgvTraspaso_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTraspaso.CellEndEdit
        Dim row As DataGridViewRow = DgvTraspaso.Rows(e.RowIndex)
        If DgvTraspaso.Columns(e.ColumnIndex).Name = "Codigo" Then
            If CmbSucSolicitar.Text <> Nothing Then
                Dim Producto As New ProductosTraspaso()
                idRecuperado = DgvTraspaso.Rows(e.RowIndex).Cells("Codigo").Value
                Producto = RecuperarProductoTrasp()
                RellenarProducto(Producto)
            Else
                MsgBox("Debe seleccionar la sucursal a donde se solicitará la mercancia")
            End If
        ElseIf DgvTraspaso.Columns(e.ColumnIndex).Name = "MciaVta" Or DgvTraspaso.Columns(e.ColumnIndex).Name = "MciaStock" Or DgvTraspaso.Columns(e.ColumnIndex).Name = "MciaTaller" Then
            CalculaCantidadSolicitada(row)
            CalculaNumeros(row)
        ElseIf DgvTraspaso.Columns(e.ColumnIndex).Name = "PrecioUnit" Then 'DgvTraspaso.Columns(e.ColumnIndex).Name = "MciaVta" Or 
            CalculaNumeros(row)
        End If
    End Sub
    Private Sub DgvTraspaso_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvTraspaso.EditingControlShowing
        If CmbSucSolicitar.Text = Nothing Then
            MsgBox("Debe seleccionar la sucursal a donde se solicitará la mercancia")
        Else
            If TypeOf e.Control Is TextBox Then
                DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
            End If
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        ' Si el control DataGridView no tiene el foco, y
        ' si la celda actual no está siendo editada,
        ' abandonamos el procedimiento.
        '
        If ((Not DgvTraspaso.Focused) AndAlso
            (Not DgvTraspaso.IsCurrentCellInEditMode)) Then _
             Return MyBase.ProcessCmdKey(msg, keyData)

        ' Si la tecla presionada es distinta de la tecla Enter,
        ' abandonamos el procedimiento.
        '
        If (keyData <> Keys.Return) Then _
           Return MyBase.ProcessCmdKey(msg, keyData)

        ' Obtenemos la celda actual
        '
        Dim cell As DataGridViewCell = DgvTraspaso.CurrentCell

        ' Índice de la columna.
        '
        Dim columnIndex As Int32 = cell.ColumnIndex

        ' Índice de la fila.
        '
        Dim rowIndex As Int32 = cell.RowIndex

        If (columnIndex = DgvTraspaso.Columns.Count - 1) Then
            If (rowIndex = DgvTraspaso.Rows.Count - 1) Then
                ' Seleccionamos la primera columna de la primera fila.
                '
                cell = DgvTraspaso.Rows(0).Cells(0)
            Else
                ' Selecionamos la primera columna de la siguiente fila.
                '
                cell = DgvTraspaso.Rows(rowIndex + 1).Cells(0)
            End If

        Else
            ' Seleccionamos la celda de la derecha de la celda actual.
            '
            If DgvTraspaso.CurrentCell.ColumnIndex = 0 Then
                cell = DgvTraspaso.Rows(rowIndex).Cells(columnIndex + 6)
            ElseIf DgvTraspaso.CurrentCell.ColumnIndex = 8 Then
                cell = DgvTraspaso.Rows(rowIndex).Cells(columnIndex + 5)
            ElseIf DgvTraspaso.CurrentCell.ColumnIndex = 13 Then
                cell = DgvTraspaso.Rows(rowIndex).Cells(columnIndex + 4)
            ElseIf DgvTraspaso.CurrentCell.ColumnIndex = 17 Then
                cell = DgvTraspaso.Rows(rowIndex + 1).Cells(0)
            ElseIf DgvTraspaso.CurrentCell.ColumnIndex = 10 Then
                cell = DgvTraspaso.Rows(rowIndex + 1).Cells(10)
            ElseIf DgvTraspaso.CurrentCell.ColumnIndex = 5 Then
                cell = DgvTraspaso.Rows(rowIndex + 1).Cells(5)
            Else
                cell = DgvTraspaso.Rows(rowIndex).Cells(columnIndex + 1)
            End If

        End If

        DgvTraspaso.CurrentCell = cell

        Return True

    End Function
    Private Sub BtnCrearModificar_Click(sender As Object, e As EventArgs) Handles BtnCrearModificar.Click
        Dim frm As New FrmFirma(usuario, 3)
        Dim NFirma As New NFirma
        Dim objTraspaso As New Traspaso
        Dim lstPT As New LProductosTraspaso
        Dim objNTraspaso As New NTraspaso
        Dim condEnvio As New CondicionesEnvio
        Dim objCiente As New Cliente
        Dim resultado As String

        If TxtIdTraspaso.Text = "" Then
            If ValidarEncabezado() = True Then
                If ValidarDetalle() = True Then
                    If frm.ShowDialog() = DialogResult.OK Then
                        If ValidarFirma(frm) = True Then
                            objTraspaso = RellenaObjetoTraspaso(objTraspaso, frm)
                            lstPT = RellenaListaProductos(lstPT)
                            condEnvio = RellenaObjetoCondEnvio(condEnvio)
                            objNTraspaso.InsertarTraspaso(cadenaConex, objTraspaso, lstPT, condEnvio)
                            Limpiar()
                            LimpiarInfoAd()
                            RevisarCmbSucSolicitar()
                        Else
                            MsgBox("La contraseña es incorrecta")
                        End If
                    End If
                    Exit Sub
                End If
            End If
        Else
            resultado = MsgBox("¿Desea Modificar el traspaso?", vbYesNo + vbQuestion, "Advertencia")
            If resultado = vbYes Then
                If frm.ShowDialog() = DialogResult.OK Then
                    If ValidarFirma(frm) = True Then
                        objTraspaso = RellenaObjetoTraspaso(objTraspaso, frm)
                        lstPT = RellenaListaProductos(lstPT)
                        condEnvio = RellenaObjetoCondEnvio(condEnvio)
                        objNTraspaso.ModificarTraspaso(cadenaConex, objTraspaso, lstPT, condEnvio)
                        Limpiar()
                        LimpiarInfoAd()
                        RevisarCmbSucSolicitar()
                    Else
                        MsgBox("La contraseña es incorrecta")
                    End If
                End If
                Exit Sub
            End If
        End If
Finalize:
    End Sub
    Private Sub CmbSucSolicitar_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbSucSolicitar.SelectionChangeCommitted
        RevisarCmbSucSolicitar()
    End Sub
    Private Sub TxtIdTraspaso_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtIdTraspaso.KeyDown
        If e.KeyCode = Keys.Enter And TxtIdTraspaso.Text <> "" Then
            Dim sucSolicita As String, sucSurte As String, SucSur As Integer
            sucSolicita = RecuperaSucursal(2)
            sucSurte = ResuperarSucDestino(sucSolicita)
            SucSur = RevisarSucRecInt(sucSurte, 2)
            CmbSucSolicitar.SelectedValue = SucSur
            RevisarCmbSucSolicitar()
            RecuperarTraspaso(sucSolicita, sucSurte)
            ComprobarIdTraspaso()
        End If
    End Sub
    Private Sub BtnAutorizar_Click(sender As Object, e As EventArgs) Handles BtnAutorizar.Click
        Dim frm As New FrmFirma(usuario, 3)
        Dim NFirma As New NFirma
        Dim objTraspaso As New Traspaso
        Dim objNTraspaso As New NTraspaso
        Dim sucSol As String

        If frm.ShowDialog() = DialogResult.OK Then
            If ValidarFirma(frm) = True Then
                objTraspaso.IdAutorizaSurte = Me.usuario.Id
                objTraspaso.ComentaAutorizaSurte = frm.firmaGral.Comentario
                objTraspaso.Rechazado = False
                objTraspaso.IdTraspaso = TxtIdTraspaso.Text
                sucSol = RevisarSucRec(LblSucursalLocal.Text)
                objNTraspaso.FirmaAutorizaSurte(cadenaConex, objTraspaso, sucSol)
                LblAutorizaEnvioUsuario.Text = Me.usuario.Nombre
                LblAutorizaEnvioComentario.Text = frm.firmaGral.Comentario
                BtnAutorizar.Enabled = False
                BtnSurtir.Enabled = True
            Else
                MsgBox("La contraseña es incorrecta")
            End If
        Else
            If ValidarFirma(frm) = True Then
                objTraspaso.IdAutorizaSurte = Me.usuario.Id
                objTraspaso.ComentaAutorizaSurte = "Rechazado: " & frm.firmaGral.Comentario & ""
                objTraspaso.Rechazado = True
                objTraspaso.IdTraspaso = TxtIdTraspaso.Text
                sucSol = RevisarSucRec(LblSucursalLocal.Text)
                objNTraspaso.FirmaAutorizaSurte(cadenaConex, objTraspaso, sucSol)
                LblAutorizaEnvioUsuario.Text = Me.usuario.Nombre
                LblAutorizaEnvioComentario.Text = "Rechazado: " & frm.firmaGral.Comentario & ""
                BtnAutorizar.Enabled = False
            Else
                MsgBox("La contraseña es incorrecta")
            End If
        End If
        Exit Sub
    End Sub
    Private Sub BtnSurtir_Click(sender As Object, e As EventArgs) Handles BtnSurtir.Click
        Dim frm As New FrmFirma(usuario, 4)
        Dim objTraspaso As New Traspaso
        Dim lst As New LProductosTraspaso
        Dim objNTraspaso As New NTraspaso
        Dim sucSol As String
        Dim ceros As Byte, resultado As Byte

        resultado = 1
        For i = 0 To DgvTraspaso.Rows.Count - 1 'ciclo para omitir los "0"
            With DgvTraspaso.Rows(i)
                If .Cells("Codigo").Value <> "" Then
                    If .Cells("CantEnviada").Value Is Nothing Or .Cells("CantEnviada").Value = 0 Then
                        ceros = ceros + 1 'suma todos los "0"
                    End If
                End If
            End With
        Next

        If ceros > 0 Then
            resultado = MsgBox("Tienes articulos en ""0""" & Chr(13) & "¿Estas seguro que quieres firmar?", vbOKCancel, "Confirmacion")
        End If

        If resultado = 2 Then
            Exit Sub
        Else
            If frm.ShowDialog() = DialogResult.OK Then
                If ValidarFirma(frm) = True Then
                    sucSol = RevisarSucRec(LblSucursalLocal.Text)
                    objTraspaso = RellenaObjetoTraspasoFirmas(objTraspaso, frm, 1)
                    lst = RellenaListaProductosFirmas(lst, 1)
                    objNTraspaso.FirmaSurte(cadenaConex, objTraspaso, lst, sucSol)
                    LblSurteUsuario.Text = Me.usuario.Nombre
                    LblSurteComentario.Text = frm.firmaGral.Comentario
                    BtnSurtir.Enabled = False
                    BtnFolioSalidaSia.Visible = True
                    TxtFolioSalidaSia.Visible = True
                Else
                    MsgBox("La contraseña es incorrecta")
                End If
            End If
            Exit Sub
        End If
Finalize:
    End Sub
    Private Sub BtnRecibirTrasp_Click(sender As Object, e As EventArgs) Handles BtnRecibirTrasp.Click
        Dim frm As New FrmFirma(usuario, 4)
        Dim objTraspaso As New Traspaso
        Dim lst As New LProductosTraspaso
        Dim objNTraspaso As New NTraspaso
        Dim sucSur As String
        Dim ceros As Byte, resultado As Byte

        resultado = 1
        For i = 0 To DgvTraspaso.Rows.Count - 1 'ciclo para omitir los "0"
            With DgvTraspaso.Rows(i)
                If .Cells("Codigo").Value <> "" Then
                    If .Cells("CantRecib").Value Is Nothing Or .Cells("CantRecib").Value = 0 Then
                        ceros = ceros + 1 'suma todos los "0"
                    End If
                End If
            End With
        Next

        If ceros > 0 Then
            resultado = MsgBox("Tienes articulos en ""0""" & Chr(13) & "¿Estas seguro que quieres firmar?", vbOKCancel, "Confirmacion")
        End If

        If resultado = 2 Then
            Exit Sub
        Else
            If frm.ShowDialog() = DialogResult.OK Then
                If ValidarFirma(frm) = True Then
                    sucSur = RecuperaSucursal(1)
                    objTraspaso = RellenaObjetoTraspasoFirmas(objTraspaso, frm, 2)
                    lst = RellenaListaProductosFirmas(lst, 2)
                    objNTraspaso.FirmaRecibe(cadenaConex, objTraspaso, lst, sucSur)
                    LblRecibeUsuario.Text = Me.usuario.Nombre
                    LblRecibeComentario.Text = frm.firmaGral.Comentario
                    BtnRecibirTrasp.Enabled = False
                    BtnFolioEntradaSia.Visible = True
                    TxtFolioEntradaSia.Visible = True
                Else
                    MsgBox("La contraseña es incorrecta")
                End If
            End If
            Exit Sub
        End If
Finalize:
    End Sub
    Private Sub BtnFolioSalidaSia_Click(sender As Object, e As EventArgs) Handles BtnFolioSalidaSia.Click
        Dim resultado As Byte
        Dim sucSol = RevisarSucRecInt(LblSucursalLocal.Text, 1)
        Dim sucSur = ubicacionArchivo(Me.idSuc, 2)
        Dim lst As New LProductosTraspaso
        Dim objTrasp As New Traspaso
        Dim objNTrasp As New NTraspaso
        Dim lstcount As Byte, omitir As Byte, i As Byte, partidas As Byte, coinciden As Byte
        Dim codigo As String
        Dim cantidad As Long
        MsgBox("Recuerde que para hacer este proceso debe estár conectado a la unidad F")
        If TxtFolioSalidaSia.Text = "" Then
            MsgBox("Debe poner el folio de salida", vbCritical, "Sin folio")
            Exit Sub
        Else
            resultado = MsgBox("¿Estas Seguro que este es el folio a Ingresar?", vbOKCancel, "Confirmacion")
        End If

        If resultado = 2 Then
            Exit Sub
        Else
            If Me.idSuc = sucSol Then
                Exit Sub
            Else
                partidas = DgvTraspaso.Rows.Count - 1
                lst = FolioVerificaPartidas(TxtFolioSalidaSia.Text, sucSur, "AG_TRASP")
                lstcount = lst.Count

                For i = 0 To DgvTraspaso.Rows.Count - 1 'ciclo para omitir los "0"
                    With DgvTraspaso.Rows(i)
                        If .Cells("Codigo").Value <> "" Then
                            If .Cells("CantEnviada").Value Is Nothing Or .Cells("CantEnviada").Value = 0 Then
                                omitir = omitir + 1 'suma todos los "0"
                            End If
                        End If
                    End With
                Next
                partidas = partidas - omitir
                If lstcount = partidas Then
                    For i = 1 To lstcount
                        codigo = DgvTraspaso.Rows(i - 1).Cells("Codigo").Value
                        cantidad = DgvTraspaso.Rows(i - 1).Cells("CantEnviada").Value
                        For Each item In lst 'compara los codigos del traspaso con el sia
                            If item.Codigo = codigo Then
                                coinciden = coinciden + 1
                                If item.CantidadEnviada = cantidad Then 'compara las cantidades enviadas con las cantidades del sia
                                    GoTo sigCod
                                Else
                                    MsgBox("Las cantidades enviadas del traspaso en el codigo(" & codigo & ")" & Chr(13) & "no son iguales a las del SIA", vbCritical, "Error de Cantidades")
                                    Exit Sub
                                End If
                            End If
sigCod:
                        Next
                    Next i
                    If coinciden = partidas Then 'SI coinciden las partidas
                        sucSur = RecuperaSucursal(1)
                        objTrasp.IdTraspasoSalida = LblIdTraspasoSalida.Text
                        objTrasp.FolioSiaSalida = TxtFolioSalidaSia.Text
                        objNTrasp.FolioSalidaSia(cadenaConex, objTrasp, sucSur)
                        BtnFolioSalidaSia.Enabled = False
                        TxtFolioSalidaSia.ReadOnly = True
                    Else 'si NO coinciden las partidas
                        MsgBox("Los codigos del traspaso, no coinciden con el traspaso del SIA", vbCritical, "Error de codigos")
                        TxtFolioSalidaSia.Text = Nothing
                        Exit Sub
                    End If
                Else
                    MsgBox("Las cantidades de codigos son diferentes." & Chr(13) & Chr(13) &
                    "La cantidad de codigos del traspaso (" & TxtIdTraspaso.Text & ") son: " & partidas & Chr(13) &
                    " y la cantidad del folio de salida (" & TxtFolioSalidaSia.Text & ") son: " & lstcount, vbCritical, "Error de cantidades")
                    TxtFolioSalidaSia.Text = Nothing
                    Exit Sub
                End If
            End If
        End If
Finalize:
    End Sub
    Private Sub BtnFolioEntradaSia_Click(sender As Object, e As EventArgs) Handles BtnFolioEntradaSia.Click
        Dim resultado As Byte
        Dim sucSur = RevisarSucRecInt(CmbSucSolicitar.Text, 1)
        Dim sucSol = ubicacionArchivo(Me.idSuc, 1)
        Dim lst As New LProductosTraspaso
        Dim objTrasp As New Traspaso
        Dim objNTrasp As New NTraspaso
        Dim lstcount As Byte, omitir As Byte, i As Byte, partidas As Byte, coinciden As Byte
        Dim codigo As String
        Dim cantidad As Long
        MsgBox("Recuerde que para hacer este proceso debe estár conectado a la unidad F")
        If TxtFolioEntradaSia.Text = "" Then
            MsgBox("Debe poner el folio de entrada", vbCritical, "Sin folio")
            Exit Sub
        Else
            resultado = MsgBox("¿Estas Seguro que este es el folio a Ingresar?", vbOKCancel, "Confirmacion")
        End If

        If resultado = 2 Then
            Exit Sub
        Else
            If Me.idSuc = sucSur Then
                Exit Sub
            Else
                partidas = DgvTraspaso.Rows.Count - 1
                lst = FolioVerificaPartidas(TxtFolioEntradaSia.Text, sucSol, "AG_ENXTR")
                lstcount = lst.Count

                For i = 0 To DgvTraspaso.Rows.Count - 1 'ciclo para omitir los "0"
                    With DgvTraspaso.Rows(i)
                        If .Cells("Codigo").Value <> "" Then
                            If .Cells("CantRecib").Value Is Nothing Or .Cells("CantRecib").Value = 0 Then
                                omitir = omitir + 1 'suma todos los "0"
                            End If
                        End If
                    End With
                Next
                partidas = partidas - omitir
                If lstcount = partidas Then
                    For i = 1 To lstcount
                        codigo = DgvTraspaso.Rows(i - 1).Cells("Codigo").Value
                        cantidad = DgvTraspaso.Rows(i - 1).Cells("CantRecib").Value
                        For Each item In lst 'compara los codigos del traspaso con el sia
                            If item.Codigo = codigo Then
                                coinciden = coinciden + 1
                                If item.CantRecibida = cantidad Then 'compara las cantidades enviadas con las cantidades del sia
                                    GoTo sigCod
                                Else
                                    MsgBox("Las cantidades recibidas del traspaso en el codigo(" & codigo & ")" & Chr(13) & "no son iguales a las del SIA", vbCritical, "Error de Cantidades")
                                    Exit Sub
                                End If
                            End If
sigCod:
                        Next
                    Next i
                    If coinciden = partidas Then 'SI coinciden las partidas
                        sucSol = RecuperaSucursal(2)
                        objTrasp.IdTraspaso = TxtIdTraspaso.Text
                        objTrasp.FolioSiaEntrada = TxtFolioEntradaSia.Text
                        objNTrasp.FolioEntradaSia(cadenaConex, objTrasp, sucSol)
                        BtnFolioEntradaSia.Enabled = False
                        TxtFolioEntradaSia.ReadOnly = True
                    Else 'si NO coinciden las partidas
                        MsgBox("Los codigos del traspaso, no coinciden con el traspaso del SIA", vbCritical, "Error de codigos")
                        TxtFolioSalidaSia.Text = Nothing
                        Exit Sub
                    End If
                Else
                    MsgBox("Las cantidades de codigos son diferentes." & Chr(13) & Chr(13) &
                    "La cantidad de codigos del traspaso (" & TxtIdTraspaso.Text & ") son: " & partidas & Chr(13) &
                    " y la cantidad del folio de entrada (" & TxtFolioEntradaSia.Text & ") son: " & lstcount, vbCritical, "Error de cantidades")
                    TxtFolioEntradaSia.Text = Nothing
                    Exit Sub
                End If
            End If
        End If
Finalize:
    End Sub
    Private Sub FrmTraspasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        If Me.idTraspaso = 0 Then
            RevisarSuc(Me.idSuc)
            RellenaCmbEstado()
            RellenaCmbPaqueteria()
            RellenaCmbSucSolicitar(Me.idSuc)
            RellenaCmbFormaPago()
            RellenaCmbFormaEntrega()
            ComprobarIdTraspaso()
            RevisarCmbSucSolicitar()
            BtnRecibirTrasp.Enabled = False
            BtnAutorizar.Enabled = False
            BtnSurtir.Enabled = False
            BtnFolioSalidaSia.Visible = False
            TxtFolioSalidaSia.Visible = False
        Else
            Dim SucSol As Integer
            Dim SucSur As Integer
            SucSol = RevisarSucRecInt(sucSolicitaEstatus, 1)
            SucSur = RevisarSucRecInt(sucSurteEstatus, 1)
            sucSolicitaEstatus = RevisarSucRec(sucSolicitaEstatus)
            sucSurteEstatus = RevisarSucRec(sucSurteEstatus)
            RevisarSuc(SucSol)
            RellenaCmbEstado()
            RellenaCmbPaqueteria()
            RellenaCmbSucSolicitar(SucSol)
            CmbSucSolicitar.SelectedValue = SucSur
            TxtIdTraspaso.Text = Me.idTraspaso
            RellenaCmbFormaPago()
            RellenaCmbFormaEntrega()
            ComprobarIdTraspaso()
            RevisarCmbSucSolicitar()
            RecuperarTraspaso(sucSolicitaEstatus, sucSurteEstatus)
        End If
    End Sub
#End Region
#Region "Recuperar"
    Private Sub RecuperarDireccion(ByVal aliass As String)
        Dim objCliente As New Cliente
        Dim objNDir As New NDireccion
        Dim objDir As New Direccion
        Dim objEdo As New Estado
        objCliente.IdCliente = TxtCodCteSuc.Text
        objCliente.Aliass = aliass
        If sucSolicitaEstatus = Nothing Then sucSolicitaEstatus = RevisarSucRec(LblSucursalLocal.Text)
        objDir = objNDir.ObtenerDireccionTraspaso(cadenaConex, objCliente, sucSolicitaEstatus)
        objEdo.Fol = objDir.IdEstado
        RellenaCmbCiudad(objEdo)
        RellenaDireccion(objDir)
    End Sub
    Private Sub RecuperarContacto()
        Dim objCliente As New Cliente
        Dim objNContacto As New NContacto
        Dim objContacto As New Contacto
        Dim sucSol As String
        objCliente.IdCliente = TxtCodCteSuc.Text
        sucSol = RecuperaSucursal(2)
        objContacto = objNContacto.ObtenerContactoTrasp(cadenaConex, objCliente, sucSol)
        RellenaContacto(objContacto)
    End Sub
    Private Sub ObtenerContacto(objCliente As Cliente, objTraspaso As Traspaso)
        Dim objNContacto As New NContacto
        Dim objContacto As New Contacto
        objCliente.IdCliente = objCliente.IdCliente
        If sucSolicitaEstatus = Nothing Then sucSolicitaEstatus = objTraspaso.SucSolicita
        objContacto = objNContacto.ObtenerContactoTrasp(cadenaConex, objCliente, sucSolicitaEstatus)
        RellenaContacto(objContacto)
    End Sub
    Private Function RecuperarCliente() As Cliente
        Dim objCliente As New Cliente()
        Dim objN As New NCliente()

        objCliente.IdCliente = idRecuperado
        Return objN.ObtenerClientePedidos(cadenaConex, objCliente)
    End Function
    Private Function RecuperarProductoTrasp() As ProductosTraspaso
        Dim objProducto As New ProductosTraspaso()
        Dim objN As New NProductosTraspaso
        Dim suc As String

        objProducto.Codigo = idRecuperado
        suc = RecuperaSucursal(1)
        Return objN.ObtenerProductoPedidos(cadenaConex, objProducto, suc)
    End Function
    Private Function RecuperaSucursal(ByVal funcion As Integer) As String
        Dim suc As String
        If funcion = 1 Then
            Select Case CmbSucSolicitar.SelectedValue
                Case 1
                    suc = "mty"
                Case 2
                    suc = "ale"
                Case 3
                    suc = "gdl"
                Case 4
                    suc = "mex"
                Case 5
                    suc = "leo"
                Case 6
                    suc = "ver"
                Case 7
                    suc = "cul"
                Case 11
                    suc = "asl"
                Case 0
                    suc = "leo_copy"
                Case Else
                    suc = ""
            End Select
        Else
            Select Case Me.idSuc
                Case 1
                    suc = "mty"
                Case 2
                    suc = "ale"
                Case 3
                    suc = "gdl"
                Case 4
                    suc = "mex"
                Case 5
                    suc = "leo"
                Case 6
                    suc = "ver"
                Case 7
                    suc = "cul"
                Case 11
                    suc = "snl"
                Case 0
                    suc = "leo_copy"
                Case Else
                    suc = ""
            End Select
        End If
        Return suc
    End Function
    Private Function ResuperarSucDestino(ByVal sucOrigen As String) As String
        Dim objNTraspaso As New NTraspaso()
        Dim Traspaso As New Traspaso

        Traspaso.IdTraspaso = TxtIdTraspaso.Text
        Traspaso.SucSolicita = sucOrigen
        Traspaso = objNTraspaso.ResuperarsucDestino(cadenaConex, Traspaso)
        Return Traspaso.SucSurte
    End Function
    Private Sub RecuperarTraspaso(ByVal sucSolicita As String, ByVal sucSurte As String)
        Dim Cabecera As New Traspaso()
        Dim Cliente As New Cliente()
        Dim NTraspaso As New NTraspaso()
        Dim NCliente As New NCliente()
        Dim Detalle As New LProductosTraspaso()
        Dim CondEnv As New CondicionesEnvio()
        Dim NCondEnv As New NCondicionesEnvio()
        Dim ObtenerCondEnvio As New NTraspaso()

        Cabecera.IdTraspaso = TxtIdTraspaso.Text
        Cabecera.SucSolicita = sucSolicita
        Cabecera.SucSurte = sucSurte
        Cabecera = NTraspaso.TraspasoRecuperarEncabezado(cadenaConex, Cabecera)
        Detalle = NTraspaso.TraspasoRecuperarDetalles(cadenaConex, Cabecera)
        If Cabecera.TipoTraspaso = False Then
            Cliente.IdCliente = Cabecera.IdCliente
            Cliente = NCliente.ObtenerClienteTraspaso(cadenaConex, Cliente, sucSolicita)
        End If
        CondEnv.IdCondEnvio = Cabecera.IdCondicionesEnv
        CondEnv = ObtenerCondEnvio.RecuperaCondEnvio(cadenaConex, CondEnv, sucSolicita)

        RellenaTraspaso(Cabecera, Cliente, CondEnv)
        RellenaDgvDetalle(Detalle)
        ComprobarTraspaso(Cabecera)
    End Sub
#End Region
#Region "Rellenar"
    Private Sub RellenarPrecio()
        Dim fila As Byte
        fila = DgvTraspaso.CurrentCell.RowIndex
        DgvTraspaso.Rows(fila).Cells("PrecioUnit").Value = idRecuperado
        CalculaNumeros(DgvTraspaso.CurrentRow)
    End Sub
    Private Sub RellenaCliente(ByVal objCliente As Cliente)
        TxtCodCteSuc.Text = objCliente.IdCliente
        TxtCteSuc.Text = objCliente.Nombre
        RellenaCmbAliasDir(objCliente)
        RecuperarContacto()
    End Sub
    Private Sub RellenaContacto(ByVal objContacto As Contacto)
        TxtTelefono.Text = objContacto.Telefono
        TxtContacto.Text = objContacto.Nombre
    End Sub
    Private Sub RellenaDireccion(objDir As Direccion)
        TxtDireccion.Text = objDir.Calle
        TxtNoExt.Text = objDir.NoExt
        TxtNoInt.Text = objDir.NoInt
        TxtCp.Text = objDir.Cp
        TxtColonia.Text = objDir.Colonia
        CmbCiudad.SelectedValue = objDir.IdMunicipio
        CmbEdo.SelectedValue = objDir.IdEstado
    End Sub
    Private Sub RellenarProducto(objProducto As ProductosTraspaso)
        Dim fila As Byte

        fila = DgvTraspaso.CurrentCell.RowIndex
        DgvTraspaso.Rows(fila).Cells("Codigo").Value = objProducto.Codigo
        DgvTraspaso.Rows(fila).Cells("ExisDestino").Value = objProducto.ExistenciaSS 'existDestino
        DgvTraspaso.Rows(fila).Cells("Descripcion").Value = objProducto.Descripcion
        DgvTraspaso.Rows(fila).Cells("Ubicacion").Value = objProducto.Ubicacion
        DgvTraspaso.Rows(fila).Cells("vta12m").Value = objProducto.Vta12Meses
        DgvTraspaso.Rows(fila).Cells("Vta6m").Value = objProducto.Vta6Meses
        DgvTraspaso.Rows(fila).Cells("Costo").Value = objProducto.Costo 'costo
        DgvTraspaso.Columns("Costo").DefaultCellStyle.Format = "$ ##,##0.00"
        DgvTraspaso.Rows(fila).Cells("ExisOrig").Value = objProducto.ExistenciaSL 'existLocal
    End Sub
    Private Function RellenaObjetoTraspaso(ByVal ObjTraspaso As Traspaso, ByVal frm As FrmFirma)
        Dim sucS As String
        sucS = RecuperaSucursal(1)

        With ObjTraspaso
            If TxtIdTraspaso.Text <> "" Then
                .IdTraspaso = TxtIdTraspaso.Text
                .IdTraspasoSalida = LblIdTraspasoSalida.Text
            End If
            .Fecha = TxtFecha.Text
            .Hora = Now.ToString("HH:mm:ss.fff")
            .SucDestino = sucS
            .SucOrigen = RecuperaSucursal(2)
            .Atencion = TxtAtencion.Text
            .IdCliente = TxtCodCteSuc.Text
            .TipoTraspaso = RbnASucursal.Checked
            If LblIdCondEnv.Text <> "" Then
                .IdCondicionesEnv = LblIdCondEnv.Text
            Else
                .IdCondicionesEnv = 0
            End If
            .IdAutoriza = Me.usuario.Id
            .ComentaAutoriza = frm.firmaGral.Comentario
            '.IdSurte = ""
            '.ComentaSurte = ""
            '.IdRecibe = ""
            '.ComentaRecibe = ""
            '.FolioSiaEntrada = ""
            '.FolioSiaSalida = ""
        End With
        Return ObjTraspaso
    End Function
    Private Function RellenaObjetoCondEnvio(ByVal objCE As CondicionesEnvio)
        With objCE
            If LblIdCondEnv.Text = "" Then
                .IdCondEnvio = 0
            Else
                .IdCondEnvio = LblIdCondEnv.Text
            End If

            .Fecha = TxtFecha.Text
            .Hora = Now.ToString("HH:mm:ss.fff")
            .IdPaqueteria = CmbPaqueteria.SelectedItem.idPaq
            If CmbFormaPago.Text = "X Cobrar" Then 'forma de pago
                .FormaPago = "Por Cobrar"
            Else
                .FormaPago = "Pagado"
            End If
            If CmbFormaEntrega.Text = "Ocurre" Then
                .FormaEntrega = "Ocurre"
            Else
                .FormaEntrega = "A Domicilio"
            End If
            If TxtMontoAsegurado.Text = "" Then 'valor asegurado
                .ValorAsegurado = 0.00
            Else
                .ValorAsegurado = TxtMontoAsegurado.Text
            End If
            .IdCliente = TxtCodCteSuc.Text
            .AliasCond = CmbAlias.Text
            .IdGuia = 0
            .TipoCondi = 3

        End With
        Return objCE
    End Function
    Private Function RellenaListaProductos(lstPT As LProductosTraspaso) As LProductosTraspaso
        Dim i As Byte

        For i = 0 To DgvTraspaso.Rows.Count - 1
            With DgvTraspaso.Rows(i)
                If .Cells("MciaVta").Value IsNot Nothing And .Cells("Codigo").Value <> "" Then
                    Dim ObjProd As New ProductosTraspaso()
                    If TxtIdTraspaso.Text <> "" Then 'si es modificacion
                        ObjProd.IdTraspaso = TxtIdTraspaso.Text
                        ObjProd.IdTraspasoSalida = LblIdTraspasoSalida.Text
                    End If
                    ObjProd.IdTraspasoDetalle = .Cells("IdDetalle").Value
                    ObjProd.Codigo = .Cells("Codigo").Value
                    ObjProd.VtasSurtido = .Cells("vta12m").Value
                    ObjProd.CantRecibida = .Cells("CantRecib").Value
                    ObjProd.MciaVta = .Cells("MciaVta").Value
                    ObjProd.MciaStock = .Cells("MciaStock").Value
                    ObjProd.MciaTaller = .Cells("MciaTaller").Value
                    ObjProd.CantidadEnviada = .Cells("CantEnviada").Value
                    ObjProd.VtaSol = .Cells("Vta6m").Value
                    ObjProd.Costo = .Cells("Costo").Value
                    ObjProd.Precio = .Cells("PrecioUnit").Value
                    ObjProd.Agente = .Cells("Vendedor").Value
                    ObjProd.IdTraspasoSalidaDetalle = .Cells("IdDetalleSalida").Value
                    lstPT.Add(ObjProd)
                End If
            End With
        Next
        Return lstPT
    End Function
    Private Sub RellenaTraspaso(ByVal objTraspaso As Traspaso, ByVal objCliente As Cliente, ByVal objCondEnv As CondicionesEnvio)
        TxtFecha.Text = objTraspaso.Fecha
        LblIdTraspasoSalida.Text = objTraspaso.IdTraspasoSalida
        TxtAtencion.Text = objTraspaso.Atencion
        LblCreaModificaUsuario.Text = objTraspaso.UsuarioCrea
        LblCreaModificaComentario.Text = objTraspaso.ComentaAutoriza
        LblAutorizaEnvioUsuario.Text = objTraspaso.UsuarioAutorizaSurte
        LblAutorizaEnvioComentario.Text = objTraspaso.ComentaAutorizaSurte
        LblSurteUsuario.Text = objTraspaso.UsuarioSurte
        LblSurteComentario.Text = objTraspaso.ComentaSurte
        LblRecibeUsuario.Text = objTraspaso.UsuarioRecibe
        LblRecibeComentario.Text = objTraspaso.ComentaRecibe
        If objTraspaso.FolioSiaSalida = 0 Or objTraspaso.FolioSiaSalida = Nothing Then
            TxtFolioSalidaSia.Text = Nothing
            BtnFolioEntradaSia.Visible = False
            TxtFolioEntradaSia.Visible = False
        ElseIf objTraspaso.FolioSiaSalida <> 0 Then
            TxtFolioSalidaSia.Text = objTraspaso.FolioSiaSalida
            BtnFolioSalidaSia.Enabled = False
            TxtFolioSalidaSia.ReadOnly = True
            If objTraspaso.FolioSiaEntrada = 0 Or objTraspaso.FolioSiaEntrada = Nothing Then
                TxtFolioEntradaSia.Text = Nothing
            Else
                TxtFolioEntradaSia.Text = objTraspaso.FolioSiaEntrada
                BtnFolioEntradaSia.Enabled = False
                TxtFolioEntradaSia.ReadOnly = True
            End If
        End If
        If objTraspaso.TipoTraspaso = False Then
            TxtCodCteSuc.Text = objCliente.IdCliente
            TxtCteSuc.Text = objCliente.Nombre
            ObtenerContacto(objCliente, objTraspaso)
            RellenaCmbAliasDir(objCliente)
            RellenaCondEnv(objCondEnv)
            CmbAlias.Text = objCondEnv.AliasCond
            RecuperarDireccion(objCondEnv.AliasCond)
        Else
            RellenaCondEnv(objCondEnv)
            RbnASucursal.Checked = True
            InformacionSucursal(objTraspaso.IdCliente)
        End If
    End Sub
    Private Sub RellenaCondEnv(ByVal objCondEnv As CondicionesEnvio)
        LblIdCondEnv.Text = objCondEnv.IdCondEnvio
        CmbPaqueteria.SelectedValue = objCondEnv.IdPaqueteria
        If objCondEnv.FormaPago = "Por Cobrar" Then
            CmbFormaPago.Text = "X Cobrar"
        Else
            CmbFormaPago.Text = "Pagado"
        End If
        If objCondEnv.FormaEntrega = "Ocurre" Then
            CmbFormaEntrega.Text = "Ocurre"
        Else
            CmbFormaEntrega.Text = "A Domicilio"
        End If
        TxtMontoAsegurado.Text = objCondEnv.ValorAsegurado
    End Sub
    Private Sub RellenaDgvDetalle(ByVal objProdTrasp As LProductosTraspaso)
        Dim fila As Byte = 0 'contador para fila del DGV

        For Each item In objProdTrasp
            DgvTraspaso.Rows.Add()
            DgvTraspaso.Rows(fila).Cells("idDetalle").Value = item.IdTraspasoDetalle
            DgvTraspaso.Rows(fila).Cells("Codigo").Value = item.Codigo
            DgvTraspaso.Rows(fila).Cells("ExisDestino").Value = item.ExistenciaSS
            DgvTraspaso.Rows(fila).Cells("Descripcion").Value = item.Descripcion
            DgvTraspaso.Rows(fila).Cells("Ubicacion").Value = item.Ubicacion
            DgvTraspaso.Rows(fila).Cells("vta12m").Value = item.Vta12Meses
            DgvTraspaso.Rows(fila).Cells("MciaVta").Value = item.MciaVta
            DgvTraspaso.Rows(fila).Cells("MciaStock").Value = item.MciaStock
            DgvTraspaso.Rows(fila).Cells("MciaTaller").Value = item.MciaTaller
            DgvTraspaso.Rows(fila).Cells("CantRecib").Value = item.CantRecibida
            DgvTraspaso.Rows(fila).Cells("Vta6m").Value = item.Vta6Meses
            DgvTraspaso.Rows(fila).Cells("Costo").Value = item.Costo
            DgvTraspaso.Rows(fila).Cells("PrecioUnit").Value = item.Precio
            DgvTraspaso.Rows(fila).Cells("Vendedor").Value = item.Agente
            DgvTraspaso.Rows(fila).Cells("CantEnviada").Value = item.CantidadEnviada
            DgvTraspaso.Rows(fila).Cells("ExisOrig").Value = item.ExistenciaSL
            DgvTraspaso.Rows(fila).Cells("IdDetalleSalida").Value = item.IdTraspasoSalidaDetalle
            CalculaCantidadSolicitada(DgvTraspaso.Rows(fila))
            CalculaNumeros(DgvTraspaso.Rows(fila))
            fila += 1
        Next

    End Sub
    Private Function RellenaObjetoTraspasoFirmas(ByVal ObjTraspaso As Traspaso, ByVal frm As FrmFirma, ByVal btn As Integer) As Traspaso
        Dim sucS As String
        sucS = RecuperaSucursal(1)

        With ObjTraspaso
            .IdTraspaso = TxtIdTraspaso.Text
            If btn = 1 Then
                .IdSurte = Me.usuario.Id
                .ComentaSurte = frm.firmaGral.Comentario
            ElseIf btn = 2 Then
                .IdRecibe = Me.usuario.Id
                .ComentaRecibe = frm.firmaGral.Comentario
            End If
        End With

        Return ObjTraspaso
    End Function
    Private Function RellenaListaProductosFirmas(lstPT As LProductosTraspaso, ByVal btn As Integer) As LProductosTraspaso
        Dim i As Byte

        For i = 0 To DgvTraspaso.Rows.Count - 1
            With DgvTraspaso.Rows(i)
                If .Cells("MciaVta").Value IsNot Nothing And .Cells("Codigo").Value <> "" Then
                    Dim ObjProd As New ProductosTraspaso()
                    ObjProd.IdTraspasoDetalle = .Cells("IdDetalle").Value
                    ObjProd.IdTraspasoSalidaDetalle = .Cells("IdDetalleSalida").Value
                    If btn = 1 Then
                        ObjProd.CantidadEnviada = .Cells("CantEnviada").Value
                    End If
                    If btn = 2 Then
                        ObjProd.CantRecibida = .Cells("CantRecib").Value
                    End If
                    lstPT.Add(ObjProd)
                End If
            End With
        Next
        Return lstPT
    End Function
#End Region
#Region "Calculos"
    Private Sub CalculaNumeros(ByVal row As DataGridViewRow)
        CalculaPrecioTotal(row)
        'CalculaSubtotal(row)
        CalcularTotalCosto(row)
        CalcularUtilidad(row)
    End Sub
    Private Sub CalculaPrecioTotal(row As DataGridViewRow)
        If row.Cells("Codigo").Value IsNot Nothing Then
            row.Cells("TotVta").Value = row.Cells("PrecioUnit").Value * row.Cells("MciaVta").Value
            DgvTraspaso.Columns("PrecioUnit").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvTraspaso.Columns("Costo").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvTraspaso.Columns("TotVta").DefaultCellStyle.Format = "$ ##,##0.00"
        End If
    End Sub
    Private Sub CalculaCantidadSolicitada(row As DataGridViewRow)
        Dim Vta As Integer, Stock As Integer, Taller As Integer
        If row.Cells("MciaVta").Value = Nothing Then row.Cells("MciaVta").Value = 0
        If row.Cells("MciaStock").Value = Nothing Then row.Cells("MciaStock").Value = 0
        If row.Cells("MciaTaller").Value = Nothing Then row.Cells("MciaTaller").Value = 0
        If row.Cells("Codigo").Value IsNot Nothing Then
            Vta = row.Cells("MciaVta").Value
            Stock = row.Cells("MciaStock").Value
            Taller = row.Cells("MciaTaller").Value
            row.Cells("CantSol").Value = Vta + Stock + Taller
        End If
    End Sub
    Private Sub CalcularUtilidad(row)
        Dim tprecio As Double, tcosto As Double ', util As Double

        tprecio = row.Cells("TotVta").Value
        tcosto = row.Cells("TotalCosto").Value
        If tcosto <> 0 And tprecio <> 0 Then
            row.Cells("UtilMoneda").Value = (tprecio - tcosto)
            row.Cells("UtilidadPorcentaje").Value = ((tprecio - tcosto) / tprecio) '* 100
            DgvTraspaso.Columns("UtilMoneda").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvTraspaso.Columns("UtilidadPorcentaje").DefaultCellStyle.Format = "##.00%" 'formato en utilidad
            'DgvTraspaso.Text = Format(CType(util, Decimal), "#,##0.00")
        End If
    End Sub
    Private Sub CalcularTotalCosto(row As DataGridViewRow)
        If row.Cells("Codigo").Value IsNot Nothing Then
            row.Cells("TotalCosto").Value = row.Cells("Costo").Value * row.Cells("MciaVta").Value
            DgvTraspaso.Columns("TotalCosto").DefaultCellStyle.Format = "$ ##,##0.00"
        End If
    End Sub
#End Region
#Region "Referente a Validar"
    Private Function ValidarEncabezado() As Boolean
        If TxtCodCteSuc.Text = Nothing Then
            MsgBox("Debe proporcionar un nombre de cliente o sucursal")
            Return False
        ElseIf TxtAtencion.Text = Nothing Then
            MsgBox("Debe poner a quien va dirigido el traspaso")
            Return False
        ElseIf CmbPaqueteria.Text = Nothing Then
            MsgBox("Debe poner la paqueteria")
            Return False
        ElseIf CmbFormaPago.Text = Nothing Then
            MsgBox("Debe seleccionar una forma de pago")
            Return False
        ElseIf CmbFormaEntrega.Text = Nothing Then
            MsgBox("Debe seleccionar una forma de entrega")
            Return False
        ElseIf TxtDireccion.Text = Nothing Then
            MsgBox("Debe poner una dirección de envío")
            Return False
        End If
        Return True
    End Function
    Private Function ValidarDetalle() As Boolean
        Dim i As Byte

        For i = 0 To DgvTraspaso.Rows.Count - 1
            With DgvTraspaso.Rows(i)
                If .Cells("Codigo").Value = "" And DgvTraspaso.Rows.Count - 1 = 0 Then
                    MsgBox("Debe tener por lo menos un articulo")
                    Return False
                End If
                If DgvTraspaso.Rows.Count - 1 > 0 And .Cells("Codigo").Value <> "" Then
                    If .Cells("CantSol").Value = Nothing Then
                        MsgBox("Debe ingresar la cantidad de mercancia del codigo " & .Cells("Codigo").Value & "")
                        Return False
                    End If
                    If .Cells("PrecioUnit").Value = Nothing Then
                        MsgBox("Debe ingresar el precio del codigo " & .Cells("Codigo").Value & "")
                        Return False
                    End If
                    If .Cells("Vendedor").Value = "" Or .Cells("Vendedor").Value = Nothing Then
                        MsgBox("Debe ingresar el nombre del vendedor para el codigo " & .Cells("Codigo").Value & "")
                        Return False
                    End If
                End If
            End With
        Next
        Return True
    End Function
    Private Function ValidarFirma(ByVal frm As FrmFirma) As Boolean
        Dim objNTraspaso As New NTraspaso()
        Me.usuario.Pass = frm.firmaGral.Password
        Return objNTraspaso.ConfirmarFirma(cadenaConex, Me.usuario)
    End Function
    Private Function FolioVerificaPartidas(ByVal folio As Integer, ByVal suc As String, ByVal archivo As String) As LProductosTraspaso
        Dim lst As New LProductosTraspaso
        Dim OUtil As New NUtilerias
        Dim sConn As String
        Dim sSelect As String = "SELECT C_ARTICULO, N_CANTIDAD FROM " & archivo & " WHERE (C_TRASPASO='" & folio & "')"

        sConn = "Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" &
                System.IO.Path.GetDirectoryName(suc) & ";"

        Using dbConn As New System.Data.Odbc.OdbcConnection(sConn)
            'Using dbConn As New System.Data.OleDb.OleDbConnection(sConn)
            Try
                dbConn.Open()

                Dim da As New System.Data.Odbc.OdbcCommand(sSelect, dbConn)
                'Dim da As New System.Data.OleDb.OleDbDataAdapter(sSelect, dbConn)
                Dim dr As System.Data.Odbc.OdbcDataReader
                dr = da.ExecuteReader()

                While (dr.Read)
                    Dim ProdTraspaso As New ProductosTraspaso()
                    ProdTraspaso.Codigo = OUtil.CadenaSinCeros(dr("C_ARTICULO").ToString())
                    ProdTraspaso.CantidadEnviada = Convert.ToInt32(dr("N_CANTIDAD").ToString())
                    ProdTraspaso.CantRecibida = Convert.ToInt32(dr("N_CANTIDAD").ToString())
                    lst.Add(ProdTraspaso)
                End While

            Catch ex As Exception
                MessageBox.Show("Error al abrir la base de datos" & vbCrLf & ex.Message)
            End Try
            dbConn.Close()
        End Using

        Return lst
    End Function
#End Region
    Private Sub CargaId()
        Select Case tabla
            Case 1 'cliente
                Dim objCliente As New Cliente()
                Dim objDireccion As New Direccion
                LimpiarCEnvio()
                DgvTraspaso.Rows.Clear()
                objCliente = RecuperarCliente()
                RellenaCliente(objCliente) 'rellena info cliente
            Case 2
                Dim objProducto As New ProductosTraspaso()
                objProducto = RecuperarProductoTrasp()
                RellenarProducto(objProducto)
        End Select
    End Sub
    Private Sub ComprobarIdTraspaso()
        If Me.idTraspaso = Nothing Or TxtIdTraspaso.Text = Nothing Then
            DgvTraspaso.Columns("CantEnviada").ReadOnly = True
            DgvTraspaso.Columns("CantRecib").ReadOnly = True
        End If
    End Sub
    Private Sub RevisarCmbSucSolicitar()
        If CmbSucSolicitar.Text = Nothing Then
            TabCondEnvio.Enabled = False
            TabPrincipal.Enabled = False
            TabInfoAdicional.Enabled = False
            RbnACliente.Enabled = False
            RbnASucursal.Enabled = False
            TxtAtencion.ReadOnly = True
        ElseIf CmbSucSolicitar.Text IsNot Nothing Then
            If TabCondEnvio.Enabled = False Then TabCondEnvio.Enabled = True
            If TabPrincipal.Enabled = False Then TabPrincipal.Enabled = True
            If TabInfoAdicional.Enabled = False Then TabInfoAdicional.Enabled = True
            If RbnACliente.Enabled = False Then RbnACliente.Enabled = True
            If RbnASucursal.Enabled = False Then RbnASucursal.Enabled = True
            If TxtAtencion.ReadOnly = True Then TxtAtencion.ReadOnly = False
        End If
    End Sub
    Private Sub ComprobarTraspaso(ByVal objTraspaso As Traspaso)
        Dim idSucSol As Integer
        idSucSol = RevisarSucRecInt(objTraspaso.SucSolicita, 2)

        If idSucSol = Me.idSuc Then
            If objTraspaso.Rechazado = False And objTraspaso.UsuarioAutorizaSurte <> "" Then
                BtnCrearModificar.Enabled = False
            End If
            BtnAutorizar.Enabled = False
            BtnSurtir.Enabled = False
            If objTraspaso.UsuarioSurte = "" Or objTraspaso.UsuarioRecibe <> "" Or objTraspaso.FolioSiaSalida = 0 Then '
                BtnRecibirTrasp.Enabled = False
            End If
            If objTraspaso.FolioSiaSalida <> 0 Or objTraspaso.UsuarioSurte <> "" Then
                BtnFolioSalidaSia.Visible = True
                BtnFolioSalidaSia.Enabled = False
                TxtFolioSalidaSia.Visible = True
                TxtFolioSalidaSia.ReadOnly = True
            End If
            If objTraspaso.UsuarioRecibe <> "" Then
                If objTraspaso.FolioSiaEntrada <> 0 Then
                    BtnFolioEntradaSia.Enabled = False
                    TxtFolioEntradaSia.ReadOnly = True
                    TabCondEnvio.Enabled = False
                    TabPrincipal.Enabled = False
                    TabInfoAdicional.Enabled = False
                    RbnACliente.Enabled = False
                    RbnASucursal.Enabled = False
                    TxtAtencion.ReadOnly = True
                    MsgBox("El proceso del traspaso " & objTraspaso.IdTraspaso & " ha sido terminado no podrá editarlo")
                End If
            Else
                BtnFolioEntradaSia.Visible = False
                TxtFolioEntradaSia.Visible = False
            End If
        Else
            BtnCrearModificar.Enabled = False
            BtnRecibirTrasp.Enabled = False
            If objTraspaso.UsuarioAutorizaSurte = "" Then
                BtnSurtir.Enabled = False
            Else
                BtnAutorizar.Enabled = False
                If objTraspaso.UsuarioSurte <> "" Then
                    BtnSurtir.Enabled = False
                    BtnFolioSalidaSia.Visible = True
                    TxtFolioSalidaSia.Visible = True
                    If objTraspaso.FolioSiaSalida <> 0 Then
                        BtnFolioSalidaSia.Visible = True
                        BtnFolioSalidaSia.Enabled = False
                        TxtFolioSalidaSia.Visible = True
                        TxtFolioSalidaSia.ReadOnly = True
                    End If
                    If objTraspaso.UsuarioRecibe <> "" Then
                        BtnFolioEntradaSia.Visible = True
                        BtnFolioEntradaSia.Enabled = False
                        TxtFolioEntradaSia.Visible = True
                        TxtFolioEntradaSia.ReadOnly = True
                        If objTraspaso.FolioSiaEntrada <> 0 Then
                            TabCondEnvio.Enabled = False
                            TabPrincipal.Enabled = False
                            TabInfoAdicional.Enabled = False
                            RbnACliente.Enabled = False
                            RbnASucursal.Enabled = False
                            TxtAtencion.ReadOnly = True
                            MsgBox("El proceso del traspaso " & objTraspaso.IdTraspaso & " ha sido terminado no podrá editarlo")
                        End If
                    Else
                        BtnFolioEntradaSia.Visible = False
                        TxtFolioEntradaSia.Visible = False
                    End If
                End If
            End If
        End If
    End Sub
End Class