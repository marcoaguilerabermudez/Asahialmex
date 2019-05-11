Imports Negocio
Imports Clases
Public Class FrmCuentaBancaria
    Dim cadenaConex As String
    Dim idRecuperado As Integer
    Private tabla As SByte
    Dim cliente As String
    Dim idCliente As Integer
    Public cuentaCliente As String
    Dim numero As Byte
    Sub New(ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.cuentaCliente = cuentaCliente
    End Sub

    Private Sub FrmCuentaBancaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtFechaRegistro.Text = Format(DateTime.Now, "dd/MM/yyyy")
        BtnF3Cuenta.Visible = False
        BtnF3Banco.Visible = False
        LblBanco.Visible = False
        LblDescripcionBanco.Visible = False
        BtnModificar.Enabled = False
        TxtCodCliente.Visible = False
        TxtCliente.Visible = False
        LblCliente.Visible = False
        GbpDatos.Enabled = False
        GpbBanco.Enabled = False
        BtnCuentasCliente.Visible = False
        BtnCliente.Visible = False
        txtCodCte.Visible = False
    End Sub
    ''' <summary>
    ''' evento que activa el boton F3Cuenta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtNoCuenta_GotFocus(sender As Object, e As EventArgs) Handles TxtNoCuenta.GotFocus
        BtnF3Banco.Visible = False
    End Sub
    ''' <summary>
    ''' evento cuando se la clikc al textbox quita el boton F3 de TxtCuenta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtNombre_Click(sender As Object, e As EventArgs)
        BtnF3Cuenta.Visible = False
        BtnF3Banco.Visible = False
    End Sub
    ''' <summary>
    ''' evento que activa el boton F3Banco
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtCodBanco_GotFocus(sender As Object, e As EventArgs) Handles TxtCodBanco.GotFocus
        BtnF3Banco.Visible = True
        BtnF3Cuenta.Visible = False
    End Sub
    Private Sub TxtRfcBanco_Click(sender As Object, e As EventArgs) Handles TxtRfcBanco.Click
        BtnF3Cuenta.Visible = False
        BtnF3Banco.Visible = False
    End Sub
    ''' <summary>
    ''' rellena la informacion del banco
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnF3Banco_Click(sender As Object, e As EventArgs) Handles BtnF3Banco.Click
        Dim FrmBancos As New FrmBuscadorBancos(cadenaConex)
        If FrmBancos.ShowDialog() = DialogResult.OK Then
            TxtCodBanco.Text = FrmBancos.claveBanco
            TxtRfcBanco.Text = FrmBancos.rfcBanco
            LblBanco.Text = FrmBancos.nombreBanco
            LblDescripcionBanco.Text = FrmBancos.razonSocialBanco
            LblBanco.Visible = True
            LblDescripcionBanco.Visible = True
            TxtCodBanco.Tag = FrmBancos.idBancoPrincipal
        End If
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNoCuenta.Text = Nothing
        TxtCodBanco.Text = Nothing
        TxtRfcBanco.Text = Nothing
        LblBanco.Text = Nothing
        LblDescripcionBanco.Text = Nothing
        BtnF3Cuenta.Visible = False
        BtnF3Banco.Visible = False
        TxtCodCliente.Visible = False
        TxtCliente.Visible = False
        TxtCliente.Text = Nothing
        LblCliente.Visible = False
        GbpDatos.Enabled = False
        GpbBanco.Enabled = False
        BtnCuentasCliente.Visible = False
        TxtReferencia.Text = Nothing
        TxtClabe.Text = Nothing
        txtCodCte.Visible = False
        txtCodCte.Text = Nothing
        TxtCodCliente.Text = Nothing
        BtnModificar.Enabled = False
        BtnNuevo.Enabled = True
        RbtPrede.Visible = False
        RbtNoPredeterminada.Visible = False
        RbtCuentasBancarias.Checked = False
        RbtCuentaSuc.Checked = False
        RbtVerCuentasClientes.Checked = False
        RbtVerCuentasClientes.Checked = False
    End Sub

    Private Sub RbtCuentasBancarias_CheckedChanged(sender As Object, e As EventArgs) Handles RbtCuentasBancarias.CheckedChanged
        If RbtCuentasBancarias.Checked = True Then
            BtnF3Cuenta.Visible = True
            GbpDatos.Enabled = False
            GpbBanco.Enabled = False
        Else
            BtnF3Cuenta.Visible = False
        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If RbtCuentaSuc.Checked = True Then 'cuenta sucursal
            If TxtNoCuenta.Text = "" Then
                MsgBox("Falta capturar el numero de cuenta")
                GoTo Finalize
            Else
                If TxtClabe.Text = "" Then
                    MsgBox("Falta capturar la clabe")
                    GoTo Finalize
                Else
                    If TxtCodBanco.Text = "" Then
                        MsgBox("Falta la informacion del banco")
                    End If
                End If
            End If
            If TxtNoCuenta.Text.Trim.Length < 7 Then 'para que el usuario escriba completo el numero de cuenta
                MsgBox("Es necesario capturar completo el numero de cuenta")
            Else
                If TxtClabe.Text.Trim.Length < 7 Then 'para que el usuario escriba completo la clabe
                    MsgBox("Es necesario capturar completo la clabe")
                Else
                    idCliente = 0
                    InsertaCuentaBancaria()
                End If
            End If
        Else 'cuenta cliente
            If RbtCuentaCliente.Checked = True Then
                If TxtNoCuenta.Text = "" Then
                    MsgBox("Falta capturar el numero de cuenta")
                    GoTo Finalize
                Else
                    If TxtCodCliente.Text = "" Then
                        MsgBox("Falta agregar el nombre del cliente")
                        GoTo Finalize
                    Else
                        If TxtClabe.Text = "" Then
                            MsgBox("Falta capturar la clabe")
                            GoTo Finalize
                        Else
                            If TxtCodBanco.Text = "" Then
                                MsgBox("Falta la informacion del banco")
                            End If
                        End If
                End If
            End If
                If TxtNoCuenta.Text.Trim.Length < 7 Then 'para que el usuario escriba completo el numero de cuenta
                    MsgBox("Es necesario completo el numero de cuenta")
                Else
                    If TxtClabe.Text.Trim.Length < 7 Then 'para que el usuario escriba completo la clabe
                        MsgBox("Es necesario capturar completo la clabe")
                    Else
                        idCliente = 1
                        InsertaCuentaBancaria()
                    End If

                End If
            End If
        End If
        Exit Sub
Finalize:
    End Sub
    Private Sub InsertaCuentaBancaria()
        Dim objCuenta As New NBanco
        Dim cuenta As New Banco
        numero = 1
        cuenta = RellenaInfoCuenta()
        objCuenta.InsertaCuenta(cadenaConex, cuenta, numero)
        LimpiarFormulario()
    End Sub
    Public Function RellenaInfoCuenta()
        Dim ObjCuenta As New Banco
        Dim frm As New FrmBuscadorBancos(cadenaConex)
        If idCliente = 0 Then 'cuenta suc
            ObjCuenta.NoCuentaBanco = TxtNoCuenta.Text
            If numero = 1 Then 'nueva cuenta
                ObjCuenta.IdBanco = TxtCodBanco.Tag
            Else 'cuenta modificada
                ObjCuenta.IdBanco = LblIdbanco.Text
                ObjCuenta.IdCuentaBancaria = LblCuentaBanco.Text
            End If
            ObjCuenta.Clabe = TxtClabe.Text
            ObjCuenta.Referencia = TxtReferencia.Text
            ObjCuenta.IdCliente = 0
        Else ' cuenta cliente
            ObjCuenta.NoCuentaBanco = TxtNoCuenta.Text
            If numero = 1 Then
                ObjCuenta.IdBanco = TxtCodBanco.Tag
            Else
                ObjCuenta.IdBanco = LblIdbanco.Text
                ObjCuenta.IdCuentaBancaria = LblCuentaBanco.Text
            End If
            ObjCuenta.Clabe = TxtClabe.Text
            ObjCuenta.Referencia = TxtReferencia.Text
            If numero = 1 Then 'cuenta nueva
                ObjCuenta.IdCliente = TxtCodCliente.Text
            Else 'cuenta modificada
                ObjCuenta.IdCliente = txtCodCte.Text
            End If
        End If

        Return ObjCuenta
    End Function
    Private Sub LimpiarFormulario()
        TxtNoCuenta.Text = Nothing
        TxtCodBanco.Text = Nothing
        TxtRfcBanco.Text = Nothing
        LblBanco.Text = Nothing
        LblDescripcionBanco.Text = Nothing
        BtnF3Cuenta.Visible = False
        BtnF3Banco.Visible = False
        TxtCodCliente.Visible = False
        TxtCliente.Visible = False
        LblCliente.Visible = False
        GbpDatos.Enabled = False
        GpbBanco.Enabled = False
        BtnCuentasCliente.Visible = False
        TxtReferencia.Text = Nothing
        TxtClabe.Text = Nothing
        BtnModificar.Enabled = False
        BtnNuevo.Enabled = True
        txtCodCte.Text = Nothing
        TxtCodCliente.Text = Nothing
        RbtPrede.Visible = False
        RbtNoPredeterminada.Visible = False
        RbtCuentasBancarias.Checked = False
        RbtCuentaSuc.Checked = False
        RbtVerCuentasClientes.Checked = False
        RbtVerCuentasClientes.Checked = False
    End Sub
    ''' <summary>
    ''' recupera las cuentas x sucursal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnF3Cuenta_Click(sender As Object, e As EventArgs) Handles BtnF3Cuenta.Click
        Dim FrmCuentas As New FrmBuscadorCuenta(cadenaConex, cuentaCliente, idCliente, cliente)
        If FrmCuentas.ShowDialog() = DialogResult.OK Then
            TxtNoCuenta.Text = FrmCuentas.cuenta
            TxtReferencia.Text = FrmCuentas.refer
            TxtClabe.Text = FrmCuentas.clab
            TxtCodBanco.Text = FrmCuentas.clav
            TxtRfcBanco.Text = FrmCuentas.rfcBanco
            LblBanco.Text = FrmCuentas.nom
            LblBanco.Visible = True
            LblDescripcionBanco.Text = FrmCuentas.razonSoc
            LblDescripcionBanco.Visible = True
            BtnModificar.Enabled = True 'habilita boton
            BtnNuevo.Enabled = False 'deshabilita boton
            LblIdbanco.Text = FrmCuentas.idBan
            LblCuentaBanco.Text = FrmCuentas.idCuentaBanco
            If FrmCuentas.prede <> 0 Then 'cuenta predeterminada
                RbtPrede.Checked = True
                RbtPrede.Visible = True
                RbtNoPredeterminada.Visible = True
            Else
                RbtPrede.Visible = False
                RbtNoPredeterminada.Visible = False
            End If
            If FrmCuentas.prede = 0 Then 'cuenta NO Predeterminada
                RbtPrede.Visible = True
                RbtPrede.Checked = False
                RbtNoPredeterminada.Visible = False
            End If
            If FrmCuentas.cuentaInactiva = True Then
                    MsgBox("Esta cuenta esta inactiva")
                    GbpDatos.Enabled = False
                    GpbBanco.Enabled = False
                RbtPrede.Visible = False
                BtnModificar.Enabled = False
            Else
                    GbpDatos.Enabled = True
                    GpbBanco.Enabled = True
                End If
            End If
    End Sub

    Private Sub RbtCuentaCliente_CheckedChanged(sender As Object, e As EventArgs) Handles RbtCuentaCliente.CheckedChanged
        If RbtCuentaCliente.Checked = True Then
            LblCliente.Visible = True
            TxtCodCliente.Visible = True
            TxtCliente.Visible = True
            GbpDatos.Enabled = True
            GpbBanco.Enabled = True
        Else
            LblCliente.Visible = False
            TxtCodCliente.Visible = False
            TxtCliente.Visible = False
            BtnCliente.Visible = False
        End If
    End Sub
    Private Sub RbtCuentaSuc_CheckedChanged(sender As Object, e As EventArgs) Handles RbtCuentaSuc.CheckedChanged
        GbpDatos.Enabled = True
        GpbBanco.Enabled = True
    End Sub

    Private Sub RbtVerCuentasClientes_CheckedChanged(sender As Object, e As EventArgs) Handles RbtVerCuentasClientes.CheckedChanged
        If RbtVerCuentasClientes.Checked = True Then 'click en cuentas x cliente
            GbpDatos.Enabled = False
            GpbBanco.Enabled = False
            BtnCuentasCliente.Visible = True
            txtCodCte.Visible = True
        Else
            BtnCuentasCliente.Visible = False
            txtCodCte.Visible = False
        End If

    End Sub
    Private Sub TxtCodCliente_GotFocus(sender As Object, e As EventArgs) Handles TxtCodCliente.GotFocus
        BtnCliente.Visible = True
    End Sub
    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        Dim frm As New FrmBuscador(1, 1, cadenaConex)
        If frm.ShowDialog() = DialogResult.OK Then
            TxtCodCliente.Text = frm.Id
            TxtCliente.Text = frm.Agente
            BtnCliente.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' para que primero busque el cliente y despues la informacion del banco
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCuentasCliente_Click(sender As Object, e As EventArgs) Handles BtnCuentasCliente.Click
        Dim frm As New FrmBuscador(1, 1, cadenaConex)
        If frm.ShowDialog() = DialogResult.OK Then
            txtCodCte.Text = frm.Id
            TxtCliente.Text = frm.Agente
            cuentaCliente = "cliente"
            RellenaInfoCuentaCliente()
        End If
    End Sub
    ''' <summary>
    ''' rellena el formulario de bancos de cliente
    ''' </summary>
    Private Sub RellenaInfoCuentaCliente()
        Dim frmCuentaCliente As New FrmBuscadorCuenta(cadenaConex, cuentaCliente, txtCodCte.Text, TxtCliente.Text)
        If frmCuentaCliente.ShowDialog() = DialogResult.OK Then
            TxtNoCuenta.Text = frmCuentaCliente.cuenta
            TxtReferencia.Text = frmCuentaCliente.refer
            TxtClabe.Text = frmCuentaCliente.clab
            TxtCodBanco.Text = frmCuentaCliente.clav
            TxtRfcBanco.Text = frmCuentaCliente.rfcBanco
            LblBanco.Text = frmCuentaCliente.nom
            LblBanco.Visible = True
            LblDescripcionBanco.Text = frmCuentaCliente.razonSoc
            LblDescripcionBanco.Visible = True
            TxtCliente.Text = frmCuentaCliente.nomCliente
            LblIdbanco.Text = frmCuentaCliente.idBan
            LblCuentaBanco.Text = frmCuentaCliente.idCuentaBanco
            TxtCliente.Visible = True
            If frmCuentaCliente.prede <> 0 Then 'cuenta predeterminada
                RbtPrede.Checked = True
                RbtPrede.Visible = True
                RbtNoPredeterminada.Visible = True
            Else
                RbtPrede.Visible = True
                RbtNoPredeterminada.Visible = True
            End If
            If frmCuentaCliente.prede = 0 Then 'cuenta NO predeterminada
                RbtPrede.Visible = True
                RbtPrede.Checked = False
                RbtNoPredeterminada.Visible = False
            End If
            If frmCuentaCliente.cuentaInactiva = True Then
                MsgBox("Esta cuenta esta inactiva")
                GbpDatos.Enabled = False
                GpbBanco.Enabled = False
                BtnModificar.Enabled = False
            Else
                GbpDatos.Enabled = True
                GpbBanco.Enabled = True
                BtnModificar.Enabled = True
            End If
            BtnNuevo.Enabled = False 'inhabilita boton
        End If
    End Sub
    ''' <summary>
    ''' proceso que inactiva cuenta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RbtInactiva_CheckedChanged(sender As Object, e As EventArgs) Handles RbtInactiva.CheckedChanged
        Dim resultado As Byte
        Dim objBanco As New Banco
        Dim inactivo As Boolean
        Dim inactiva As New NBanco

        If TxtNoCuenta.Text <> "" Then
            resultado = MsgBox("¿Desea inactivar la cuenta?", vbYesNo + vbQuestion, "Advertencia")
            If resultado = vbYes Then
                inactivo = 1
                objBanco.IdCuentaBancaria = LblIdbanco.Text
                inactiva.EstadoCuenta(cadenaConex, objBanco, inactivo)
                LimpiarFormulario()
            Else
                LimpiarFormulario()
            End If
        End If

    End Sub
    ''' <summary>
    ''' proceso que activa cuenta 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RbtActivar_CheckedChanged(sender As Object, e As EventArgs) Handles RbtActivar.CheckedChanged
        Dim objBanco As New Banco
        Dim activa As Boolean
        Dim activada As New NBanco
        If TxtNoCuenta.Text <> "" Then
            activa = 0
            objBanco.IdCuentaBancaria = LblIdbanco.Text
            activada.EstadoCuenta(cadenaConex, objBanco, activa)
            GbpDatos.Enabled = True
            GpbBanco.Enabled = True
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim resultado As Byte
        resultado = MsgBox("¿Desea Modificar la Informacion?", vbYesNo + vbQuestion, "Advertencia")
        If resultado = vbYes Then
            If RbtCuentasBancarias.Checked = True Then 'cuentas sucursal
                idCliente = 0
                ModificaCuentaBancaria()
            Else 'cuentas x cliente
                idCliente = 1
                ModificaCuentaBancaria()
            End If
        End If
    End Sub
    Private Sub ModificaCuentaBancaria()
        Dim objCuenta As New NBanco
        Dim cuenta As New Banco
        numero = 2
        cuenta = RellenaInfoCuenta()
        objCuenta.InsertaCuenta(cadenaConex, cuenta, numero)
        LimpiarFormulario()
    End Sub

    Private Sub RbtPrede_CheckedChanged(sender As Object, e As EventArgs) Handles RbtPrede.CheckedChanged
        Dim objBanco As New Banco
        Dim CuentaPrederter As New NBanco
        objBanco.IdBanco = LblIdbanco.Text
        objBanco.Predeterminada = 1
        CuentaPrederter.InsertaCuentaPrederterminado(cadenaConex, objBanco)
    End Sub

    Private Sub RbtNoPredeterminada_CheckedChanged(sender As Object, e As EventArgs) Handles RbtNoPredeterminada.CheckedChanged
        Dim objBanco As New Banco
        Dim CuentaPrederter As New NBanco
        objBanco.IdBanco = LblIdbanco.Text
        objBanco.Predeterminada = 0
        CuentaPrederter.InsertaCuentaPrederterminado(cadenaConex, objBanco)
    End Sub
End Class