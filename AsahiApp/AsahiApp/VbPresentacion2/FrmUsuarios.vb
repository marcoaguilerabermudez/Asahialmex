Imports System.Windows.Forms
Imports Clases
Imports Negocio
Public Class FrmUsuarios
    Private usuario As Integer
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
    End Sub
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        RellenaSucursales(RecuperaSucursales())
        RellenaAcciones()
        PreparaFormulario("Inicio")
    End Sub
    Private Sub CmbSucursal_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbSucursal.SelectionChangeCommitted
        PreparaFormulario("Sucursal")
    End Sub
    Private Sub CmbAccion_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbAccion.SelectedValueChanged
        If CmbAccion.Text = "Modificar Permisos" Then
            PreparaFormulario("Modificar Permisos")
            RellenaCmbUsuarios(RecuperaUsuarios())
            'RellenaAgentes()
        ElseIf CmbAccion.Text = "Nuevo Usuario" Then
            PreparaFormulario("Nuevo Usuario")
        End If
    End Sub
    Private Sub PreparaFormulario(ByVal accion As String)
        If accion = "Inicio" Then
            LimpiarTextBox()
            LimpiarCombobox()
            LimpiarCheckBox(Me)
            TxtUsuario.Enabled = False
            TxtPassword.Enabled = False
            CmbUsuarios.Enabled = False
            CmbAgente.SelectedValue = Nothing
            CmbAgente.Enabled = False
            CmbAccion.Enabled = False
            TabPermisos.Enabled = False
            TxtEmail.Enabled = False
        ElseIf accion = "Modificar Permisos" Then
            LimpiarTextBox()
            TxtUsuario.Enabled = False
            TxtPassword.Enabled = False
            CmbUsuarios.Enabled = True
            CmbAgente.SelectedValue = Nothing
            CmbAgente.Enabled = True
            TabPermisos.Enabled = True
            TxtEmail.Enabled = True
        ElseIf accion = "Nuevo Usuario" Then
            LimpiarTextBox()
            TxtUsuario.Enabled = True
            TxtPassword.Enabled = True
            CmbUsuarios.Enabled = False
            CmbAgente.SelectedValue = Nothing
            CmbAgente.Enabled = True
            TabPermisos.Enabled = True
            TxtEmail.Enabled = True
        ElseIf accion = "Sucursal" Then
            LimpiarCombobox()
            LimpiarTextBox()
            LimpiarCheckBox(Me)
            CmbAccion.Enabled = True
            TxtUsuario.Enabled = False
            TxtPassword.Enabled = False
            TxtEmail.Enabled = False
            CmbUsuarios.Enabled = False
            CmbAgente.Enabled = False
            TabPermisos.Enabled = False
        End If
    End Sub
    Private Sub CmbUsuarios_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbUsuarios.SelectionChangeCommitted
        RellenaFormulario()
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If CmbAccion.Text = "Nuevo Usuario" Then
            InsertaUsuario()
        ElseIf CmbAccion.Text = "Modificar Permisos" Then
            ModificaUsuario()
        End If
    End Sub
    Private Function RecuperaAgentes(Usuario As Usuario) As Usuario
        Return Usuario
    End Function
    Private Function RecuperaPermisos(ByVal Usuario As Usuario) As Usuario
        Dim NUsuario As New NUsuario()
        Usuario = NUsuario.ObtenerPermisos(cadenaConex, Usuario)
        Return Usuario
    End Function
    Private Sub RellenaFormulario()
        Dim Usuario As New Usuario
        Usuario.Id = CmbUsuarios.SelectedItem.Id
        Usuario = RecuperaPermisos(Usuario)
        If Usuario.Admin Then ChkAdmin.CheckState = CheckState.Checked
        If Usuario.Vtas Then ChkVtas.CheckState = CheckState.Checked
        If Usuario.Cxc Then ChkCxc.CheckState = CheckState.Checked
        If Usuario.CxcPlus Then ChkCxcPlus.CheckState = CheckState.Checked
        If Usuario.Almacen Then ChkAlmacen.CheckState = CheckState.Checked
        If Usuario.Taller Then ChkTaller.CheckState = CheckState.Checked
        If Usuario.TallerPlus Then ChkTallerPlus.CheckState = CheckState.Checked
        If Usuario.Traspasos Then ChkTraspasos.CheckState = CheckState.Checked
        If Usuario.TraspasosPlus Then ChkTraspasosPlus.CheckState = CheckState.Checked
        If Usuario.Mostrador Then ChkMostrador.CheckState = CheckState.Checked
        If Usuario.RepVtasPlus Then ChkRepVtasPlus.CheckState = CheckState.Checked
        TxtEmail.Text = Usuario.Email

        With CmbAgente
            .Text = Usuario.NombreAgente
            .ValueMember = Usuario.IdAgente
        End With
    End Sub
    Private Function RecuperaSucursales() As LUtilerias
        Dim objN As New NUtilerias()
        Dim lst As New LUtilerias()

        lst = objN.RecuperaSucursales(cadenaConex)
        Return lst
    End Function
    Private Sub RellenaSucursales(lst As LUtilerias)
        With CmbSucursal
            .DataSource = lst
            .DisplayMember = "Sucursal"
            .ValueMember = "IdSuc"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaAcciones()
        With CmbAccion
            .Items.Add("Nuevo Usuario")
            .Items.Add("Modificar Permisos")
        End With
    End Sub
    Private Function RecuperaUsuarios() As LUsuario
        Dim objN As New NUsuario()
        Dim lst As New LUsuario()
        Dim objUtil As New Utilerias()

        objUtil.IdSuc = CmbSucursal.SelectedItem.idsuc
        lst = objN.ObtenerUsuarios(cadenaConex, objUtil)

        Return lst
    End Function
    Private Sub RellenaCmbUsuarios(lst As LUsuario)
        With CmbUsuarios
            .DataSource = lst
            .DisplayMember = "Nombre"
            .ValueMember = "Id"
            .Text = ""
        End With
    End Sub
    Private Function Permisos(Usuario As Usuario) As Usuario
        With Usuario
            If ChkAdmin.Checked Then .Admin = True
            If ChkVtas.Checked Then .Vtas = True
            If ChkCxc.Checked Then .Cxc = True
            If ChkCxcPlus.Checked Then .CxcPlus = True
            If ChkAlmacen.Checked Then .Almacen = True
            If ChkTaller.Checked Then .Taller = True
            If ChkTallerPlus.Checked Then .TallerPlus = True
            If ChkTraspasos.Checked Then .Traspasos = True
            If ChkTraspasosPlus.Checked Then .TraspasosPlus = True
            If ChkMostrador.Checked Then .Mostrador = True
            'If chkventasplus.Checked Then .VentasPlus = True
        End With
        Return Usuario
    End Function
    Private Function AgenteVentas(Usuario As Usuario) As Usuario
        If CmbAgente.Text <> "" Then
            If CmbAgente.Items.Count > 0 Then
                Usuario.IdAgente = CmbAgente.SelectedItem.idAgente
            Else
                Usuario.IdAgente = CmbAgente.ValueMember
            End If
        End If
        Return Usuario
    End Function
    Private Sub InsertaUsuario()
        Dim Usuario As New Usuario
        Dim NUsuario As New NUsuario
        If TxtUsuario.Text <> "" Then
            If TxtPassword.Text <> "" Then
                Usuario = RellenaUsuario(Usuario)
                NUsuario.InsertaUsuario(cadenaConex, Usuario)
            Else
                MsgBox("Es necesario indicar el password", MsgBoxStyle.Exclamation, "Llenar campos")
            End If
        Else
            MsgBox("Es necesario indicar el nombre del usuario", MsgBoxStyle.Exclamation, "Llenar campos")
        End If
    End Sub
    Private Function RellenaUsuario(Usuario As Usuario) As Usuario
        Usuario = Permisos(Usuario)
        Usuario = AgenteVentas(Usuario)
        Usuario.IdSucursal = CmbSucursal.SelectedItem.IdSuc
        If TxtUsuario.Enabled = True Then
            Usuario.Nombre = TxtUsuario.Text
        Else
            Usuario.Nombre = CmbUsuarios.Text
        End If
        Usuario.Pass = TxtPassword.Text
        Usuario.Email = TxtEmail.Text
        If CmbUsuarios.Text <> "" Then Usuario.Id = CmbUsuarios.SelectedItem.id

        Return Usuario
    End Function
    Private Sub ModificaUsuario()
        Dim Usuario As New Usuario
        Dim NUsuario As New NUsuario
        Usuario = RellenaUsuario(Usuario)

        NUsuario.ModificaUsuario(cadenaConex, Usuario)
    End Sub
    ''' <summary>
    ''' Limpiar combobox. Si le mandas el nombre de un cmb sólo limpiará ese, 
    ''' si no limpiará todos excepto cmbSucursal
    ''' </summary>
    ''' <param name="nombre">Parametro que indica que cmb Limpiar</param>
    Private Sub LimpiarCombobox(Optional ByVal nombre As String = Nothing)
        For Each ctrl As Control In Me.Controls
            If IsNothing(nombre) Then
                If TypeOf ctrl Is ComboBox And ctrl.Name <> "CmbSucursal" Then
                    CType(ctrl, ComboBox).DataSource = Nothing
                    CType(ctrl, ComboBox).ValueMember = Nothing
                    CType(ctrl, ComboBox).DisplayMember = Nothing
                    CType(ctrl, ComboBox).DropDownWidth = 1
                    CType(ctrl, ComboBox).SelectedValue = Nothing
                    CType(ctrl, ComboBox).Text = Nothing
                End If
            Else
                If TypeOf ctrl Is ComboBox And ctrl.Name = nombre Then
                    CType(ctrl, ComboBox).DataSource = Nothing
                    CType(ctrl, ComboBox).ValueMember = Nothing
                    CType(ctrl, ComboBox).DisplayMember = Nothing
                    CType(ctrl, ComboBox).DropDownWidth = 1
                    CType(ctrl, ComboBox).SelectedValue = Nothing
                    CType(ctrl, ComboBox).Text = Nothing
                End If
            End If
        Next
    End Sub
    Private Sub LimpiarTextBox()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub
    Private Sub LimpiarCheckBox(ByVal container As Control)
        'Aborto procedimiento
        If container Is Nothing Then
            Return
        ElseIf Not container.HasChildren Then
            Return
        End If

        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).CheckState = CheckState.Unchecked
            End If

            'Si es un control contenedor
            If ctrl.HasChildren Then
                'Reinvoco procedimiento con este control
                LimpiarCheckBox(ctrl)
            End If
        Next
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        PreparaFormulario("Inicio")
        CmbSucursal.SelectedItem = Nothing
    End Sub

    Private Sub CmbAgente_Click(sender As Object, e As EventArgs) Handles CmbAgente.Click
        If CmbAgente.Items.Count < 2 Then
            'RellenaAgente()
        End If
    End Sub
End Class