Imports System.Windows.Forms
Imports Clases
Imports Negocio
Public Class FrmCodigos
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

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    ''' <summary>
    ''' evento que se dispara cuando se abre el formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CmbIva.Items.Add("SI")
        Me.CmbIva.Items.Add("NO")
        CmbMarca.Text = ""
        CmbTipo.Text = ""
        CmbClase.Text = ""
        CmbUnidad.Text = ""
        InhabilitaBotones()
    End Sub
    ''' <summary>
    ''' Rellena combox de marca
    ''' </summary>
    Private Sub RellenaCmbMarca()
        Dim listaMarcas As New LMarca
        listaMarcas = ObtenerMarcas()
        With CmbMarca
            .DataSource = listaMarcas
            .DisplayMember = "Nombre"
            .ValueMember = "Id"
        End With
    End Sub
    Private Function ObtenerMarcas()
        Dim marcas As New NProducto
        Dim listaMarcas As New LMarca
        listaMarcas = marcas.ObtenerMarcaSql(cadenaConex)
        Return listaMarcas
    End Function
    Private Function ObtenerClases()
        Dim clases As New NProducto
        Dim listaClase As New LClase
        listaClase = clases.ObtenerClaseSql(cadenaConex)
        Return listaClase
    End Function
    ''' <summary>
    ''' Rellena combox de clase
    ''' </summary>
    Private Sub RellenaCmbClase()
        Dim listaClase As New LClase
        listaClase = ObtenerClases()
        With CmbClase
            .DataSource = listaClase
            .DisplayMember = "Nombre"
            .ValueMember = "Id"
        End With
    End Sub
    Private Function ObtenerUnidad()
        Dim unidad As New NProducto
        Dim listaUnidad As New LUnidad
        listaUnidad = unidad.ObtenerUnidadSql(cadenaConex)
        Return listaUnidad
    End Function
    ''' <summary>
    ''' Rellena combox de unidad de medida
    ''' </summary>
    Private Sub RellenaCmbUnidad()
        Dim listaUnidad As New LUnidad
        listaUnidad = ObtenerUnidad()
        With CmbUnidad
            .DataSource = listaUnidad
            .DisplayMember = "Nombre"
            .ValueMember = "CodigoUnidad"
        End With
    End Sub
    Private Sub InsertaNuevoCod()
        Dim RellenaCodigo As New Producto
        Dim codigo As New NProducto

        RellenaCodigo = RellenaTxtGeneral()
        codigo.ObtenerInfoCod(cadenaConex, RellenaCodigo)
    End Sub
    ''' <summary>
    ''' Rellena el objeto "Rellenacodigo" con los textbox y combox del formulario
    ''' </summary>
    ''' <returns></returns>
    Public Function RellenaTxtGeneral()
        Dim Producto As New Producto
        Producto.Codigo = TxtCodigo.Text
        Producto.Descripcion = TxtDescripcion.Text
        Producto.Descorta = TxtdesCorta.Text
        If CmbMarca.Items.Count > 1 Then 'si el combox ya se le dio click una vez (insertar)
            Producto.IdMarca = CmbMarca.SelectedItem.id
        Else '(modificar)
            Producto.IdMarca = CmbMarca.Tag
        End If
        Producto.FAalta = Format(Date.Now, "dd/MM/yyyy")
        Producto.FVenta = Format(Date.Now, "dd/MM/yyyy")

        If CmbTipo.Items.Count > 1 Then 'tipo
            Producto.IdTipo = CmbTipo.SelectedItem.id
        Else
            Producto.IdTipo = CmbTipo.Tag
        End If

        If TxtClaveSat.Text = "" Then
            Producto.IdCodigoSat = 0
        Else
            Producto.IdCodigoSat = TxtClaveSat.Text
        End If

        If CmbClase.Items.Count > 1 Then 'clase
            Producto.IdClase = CmbClase.SelectedItem.id
        Else
            Producto.IdClase = CmbClase.Tag
        End If

        Producto.IdUnidad = CmbUnidad.Text
        If TxtCosto.Text = "" Then
            Producto.Costo = 0.0000
        Else
            Producto.Costo = TxtCosto.Text
        End If
        If TxtCostodls.Text = "" Then
            Producto.CostoDollar = 0.0000
        Else
            Producto.CostoDollar = TxtCostodls.Text
        End If
        If Txtpldls.Text = "" Then
            Producto.PlDollar = 0.0000
        Else
            Producto.PlDollar = Txtpldls.Text
        End If
        If Txtplpesos.Text = "" Then
            Producto.PlPesos = 0.0000
        Else
            Producto.PlPesos = Txtplpesos.Text
        End If
        If CmbIva.Text = "SI" Then
            Producto.IvaSN = 1
        Else
            Producto.IvaSN = 0
        End If
        Producto.Formula1 = Txtprecio1.Text
        Producto.Formula2 = Txtprecio2.Text
        Producto.Formula3 = Txtprecio3.Text
        Producto.Formula4 = Txtprecio4.Text
        Producto.Formula5 = Txtprecio5.Text
        Producto.Formula6 = Txtprecio6.Text
        Producto.Formula7 = Txtprecio7.Text
        Producto.Formula8 = Txtprecio8.Text
        Producto.Existencia = 0
        Producto.Consignacion = 0
        Producto.Exhibicion = 0
        Producto.Cantidad = 0.0000
        Producto.ActivoSN = 1
        Return Producto
    End Function

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If Verifica(2) = 1 Then
            InsertaNuevoCod()
            LimpiarTextBox(Me)
            LimpiarComboBox(Me)
            TxtConsigLeo.ReadOnly = True
        End If
    End Sub
    Private Sub ModificaCodigo()
        Dim RellenaCodigo As New Producto
        Dim codigo As New NProducto
        RellenaCodigo = RellenaTxtGeneral()
        codigo.ModificaCodigoSql(cadenaConex, RellenaCodigo)
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim resultado As String
        resultado = MsgBox("¿Seguro que deseas modificar?", vbYesNo + vbQuestion, "Advertencia")
        If resultado = vbYes Then
            ModificaCodigo()
            LimpiarComboBox(Me)
            LimpiarTextBox(Me)
        End If
    End Sub
    Private Sub RecuperaInfoCodigo()
        Dim Codigo As New Producto
        Dim obtenerCodigo As New NProducto
        Codigo.Codigo = TxtCodigo.Text
        obtenerCodigo.ObtenerInfoXCodigo(cadenaConex, Codigo)
        RellenaInforCodigo(Codigo)
    End Sub
    ''' <summary>
    ''' Rellena el formulario con el objeto "codigo", en caso de que no haya informacion acerca de ese producto arroja informacion
    ''' se habilitan los tetxtbox's de las precios y pone el formato en pesos
    ''' </summary>
    ''' <param name="codigo"></param>
    Private Sub RellenaInforCodigo(codigo As Producto)
        If codigo.Descripcion Is Nothing Then
            MsgBox("Codigo no existente")
        Else
            TxtDescripcion.Text = codigo.Descripcion
            TxtdesCorta.Text = codigo.Descorta
            CmbUnidad.Text = codigo.IdUnidad
            CmbMarca.Text = codigo.Marca
            CmbClase.Text = codigo.Clase
            CmbTipo.Text = codigo.Tipo
            CmbMarca.Tag = codigo.IdMarca 'recupera el id
            CmbClase.Tag = codigo.IdClase 'recupera el id
            CmbTipo.Tag = codigo.IdTipo
            If codigo.IdCodigoSat = "" Then
                TxtClaveSat.Text = ""
            Else
                TxtClaveSat.Text = codigo.IdCodigoSat
            End If
            TxtDescriSat.Text = codigo.CodigoSat
            If codigo.CostoDollar = 0 Then 'costo dollar
                TxtCostodls.Text = ""
            Else
                TxtCostodls.Text = Format(CType(codigo.CostoDollar, Decimal), "$ #,##0.00")
            End If
            If codigo.Costo = 0 Then 'costo
                TxtCosto.Text = ""
            Else
                TxtCosto.Text = Format(CType(codigo.Costo, Decimal), "$ #,##0.00")
            End If
            If codigo.PlDollar = 0 Then 'pldollar
                Txtpldls.Text = ""
            Else
                Txtpldls.Text = Format(CType(codigo.PlDollar, Decimal), "$ #,##0.00")
            End If
            If codigo.PlPesos = 0 Then 'plpesos
                Txtplpesos.Text = ""
            Else
                Txtplpesos.Text = Format(CType(codigo.PlPesos, Decimal), "$ #,##0.00")
            End If
            If codigo.IvaSN = True Then
                CmbIva.Text = "Si"
            Else
                CmbIva.Text = "No"
            End If
            Txtprecio1.Enabled = True
            Txtprecio2.Enabled = True
            Txtprecio3.Enabled = True
            Txtprecio4.Enabled = True
            Txtprecio5.Enabled = True
            Txtprecio6.Enabled = True
            Txtprecio7.Enabled = True
            Txtprecio8.Enabled = True
            If codigo.Formula1 = "" Then
                Txtprecio1.Text = ""
            Else
                Txtprecio1.Text = Format(CType(codigo.Formula1, Decimal), "$ #,##0.00")
            End If
            If codigo.Formula2 = "" Then
                Txtprecio2.Text = ""
            Else
                Txtprecio2.Text = Format(CType(codigo.Formula2, Decimal), "$ #,##0.00")
            End If
            If codigo.Formula3 = "" Then
                Txtprecio3.Text = ""
            Else
                Txtprecio3.Text = Format(CType(codigo.Formula3, Decimal), "$ #,##0.00")
            End If
            If codigo.Formula4 = "" Then
                Txtprecio4.Text = ""
            Else
                Txtprecio4.Text = Format(CType(codigo.Formula4, Decimal), "$ #,##0.00")
            End If

            If codigo.Formula5 = "" Then
                Txtprecio5.Text = ""
            Else
                Txtprecio5.Text = Format(CType(codigo.Formula5, Decimal), "$ #,##0.00")
            End If
            If codigo.Formula6 = "" Then
                Txtprecio6.Text = ""
            Else
                Txtprecio6.Text = Format(CType(codigo.Formula6, Decimal), "$ #,##0.00")
            End If
            If codigo.Formula6 = "" Then
                Txtprecio7.Text = ""
            Else
                Txtprecio7.Text = Format(CType(codigo.Formula7, Decimal), "$ #,##0.00")
            End If
            If codigo.Formula8 = "" Then
                Txtprecio8.Text = ""
            Else
                Txtprecio8.Text = Format(CType(codigo.Formula8, Decimal), "$ #,##0.00")
            End If
            DeshabilitaTextBox()
        End If
    End Sub
    Private Sub EliminaInfoCodigo()
        Dim Codigo As New Producto
        Dim eliminaCodigo As New NProducto
        Codigo.Codigo = TxtCodigo.Text
        eliminaCodigo.EliminaCodigo(cadenaConex, Codigo)
    End Sub
    ''' <summary>
    ''' proceso que elimina ña informacion de un codigo y la ubicacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnElimi_Click(sender As Object, e As EventArgs) Handles BtnElimi.Click
        Dim resultado As String
        resultado = MsgBox("¿Seguro que deseas Eliminar?", vbYesNo + vbQuestion, "Advertencia")
        If resultado = vbYes Then
            EliminaUbicacionCod()
            EliminaInfoCodigo()
            LimpiarComboBox(Me)
            LimpiarTextBox(Me)
            Me.BtnElimi.Enabled = False
            Me.BtnModificar.Enabled = False
            Me.BtnNuevo.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' evento que inhabilita botones y textbox del formulario
    ''' </summary>
    Private Sub InhabilitaBotones()
        Me.BtnElimi.Enabled = False
        Me.BtnModificar.Enabled = False
        Me.Txtprecio1.Enabled = False
        Me.Txtprecio2.Enabled = False
        Me.Txtprecio3.Enabled = False
        Me.Txtprecio4.Enabled = False
        Me.Txtprecio5.Enabled = False
        Me.Txtprecio6.Enabled = False
        Me.Txtprecio7.Enabled = False
        Me.Txtprecio8.Enabled = False
        Me.txtconsigmty.Enabled = False
        Me.TxtExhimty.Enabled = False
        Me.TxtDispoMty.Enabled = False
        Me.TxtTotalmty.Enabled = False
        Me.Txtconsigalex.Enabled = False
        Me.TxtExhiAlex.Enabled = False
        Me.TxtDispoAlex.Enabled = False
        Me.TxtTotalAlex.Enabled = False
        Me.TxtConsigGdl.Enabled = False
        Me.TxtExhiGdl.Enabled = False
        Me.TxtDispoGdl.Enabled = False
        Me.TxtTotalGdl.Enabled = False
        Me.TxtConsigMex.Enabled = False
        Me.TxtExhimex.Enabled = False
        Me.TxtDispomex.Enabled = False
        Me.TxtTotalMex.Enabled = False
        Me.TxtExhiGdl.Enabled = False
        Me.TxtDispoGdl.Enabled = False
        Me.TxtTotalGdl.Enabled = False
        Me.TxtConsigLeo.Enabled = False
        Me.TxtExhiLeo.Enabled = False
        Me.TxtDispoLeo.Enabled = False
        Me.TxtTotalLeo.Enabled = False
        Me.Txtconsigver.Enabled = False
        Me.TxtExhiVer.Enabled = False
        Me.TxtDispoVer.Enabled = False
        Me.TxtTotalVer.Enabled = False
        TxtDescriSat.Enabled = False
        Me.TxtConsigCul.Enabled = False
        Me.TxtExhiCul.Enabled = False
        Me.TxtDispoCul.Enabled = False
        Me.TxtTotalCul.Enabled = False
    End Sub
    ''' <summary>
    ''' funcion que revisa los campos antes de insertar un codigo 
    ''' </summary>
    ''' <returns>Regresa variable si es 1(aceptado) y 0(Rechazado)</returns>
    Private Function Verifica(ori As Byte)
        Verifica = 1
        If TxtCodigo.Text = "" Then
            MsgBox("Falta escribir el codigo")
            Verifica = 0
            GoTo Finalize
        Else
            If TxtdesCorta.Text = "" Then
                MsgBox("Falta Descripcion")
                Verifica = 0
                GoTo Finalize
            Else
                If TxtdesCorta.Text = "" Then
                    MsgBox("Falta la descripcion corta")
                    Verifica = 0
                    GoTo Finalize
                Else
                    If CmbUnidad.Text = "" Then
                        MsgBox("Falta la unidad de Medida")
                        Verifica = 0
                        GoTo Finalize
                    Else
                        If CmbMarca.Text = "" Then
                            MsgBox("Falta la Marca")
                            Verifica = 0
                            GoTo Finalize
                        Else
                            If CmbTipo.Text = "" Then
                                MsgBox("Falta el Tipo del producto")
                                Verifica = 0
                                GoTo Finalize
                            Else
                                If TxtClaveSat.Text = "" Then
                                    MsgBox("Falta la clave del sat")
                                    Verifica = 0
                                    GoTo Finalize
                                Else
                                    If TxtCosto.Text = "" And TxtCostodls.Text = "" And Txtpldls.Text = "" And Txtplpesos.Text = "" Then
                                        MsgBox("Faltan los costos del producto")
                                        Verifica = 0
                                        GoTo Finalize
                                    Else
                                        If CmbUbicacion.Text = "" Then
                                            MsgBox("Falta agregar la ubicacion")
                                            Verifica = 0
                                            GoTo Finalize
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        End If
                End If
            End If
        End If
        Exit Function
Finalize:
        Return Verifica
    End Function

    Private Sub LimpiarTextBox(ByVal container As Control)
        'Aborto procedimiento
        If container Is Nothing Then
            Return
        ElseIf Not container.HasChildren Then
            Return
        End If

        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If

            'Si es un control contenedor
            If ctrl.HasChildren Then
                'Reinvoco procedimiento con este control
                LimpiarTextBox(ctrl)
            End If
        Next
    End Sub
    Private Sub LimpiarComboBox(ByVal container As Control)
        'Aborto procedimiento
        If container Is Nothing Then
            Return
        ElseIf Not container.HasChildren Then
            Return
        End If

        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).DataSource = Nothing
                CType(ctrl, ComboBox).ValueMember = Nothing
                CType(ctrl, ComboBox).DisplayMember = Nothing
                CType(ctrl, ComboBox).DropDownWidth = 1
                CType(ctrl, ComboBox).SelectedValue = Nothing
                CType(ctrl, ComboBox).Text = Nothing
            End If

            'Si es un control contenedor
            If ctrl.HasChildren Then
                'Reinvoco procedimiento con este control
                LimpiarComboBox(ctrl)
            End If
        Next
    End Sub
    ''' <summary>
    ''' limpia formulario
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        LimpiarComboBox(Me)
        LimpiarTextBox(Me)
        BloquearTextBox()
        Me.BtnNuevo.Enabled = True
        Me.BtnModificar.Enabled = False
        Me.BtnElimi.Enabled = False
        Me.TxtDescriSat.Enabled = False
    End Sub
    ''' <summary>
    ''' habilita los textbox's y combox's del formulario, cuando se le da al boton de limpiar
    ''' </summary>
    Private Sub DeshabilitaTextBox()
        txtconsigmty.Enabled = True
        TxtExhimty.Enabled = True
        TxtDispoMty.Enabled = True
        TxtTotalmty.Enabled = True
        Txtconsigalex.Enabled = True
        TxtExhiAlex.Enabled = True
        TxtDispoAlex.Enabled = True
        TxtTotalAlex.Enabled = True
        TxtConsigGdl.Enabled = True
        TxtExhiGdl.Enabled = True
        TxtDispoGdl.Enabled = True
        TxtTotalGdl.Enabled = True
        TxtConsigMex.Enabled = True
        TxtExhimex.Enabled = True
        TxtDispomex.Enabled = True
        TxtTotalMex.Enabled = True
        TxtConsigLeo.Enabled = True
        TxtExhiLeo.Enabled = True
        TxtDispoLeo.Enabled = True
        TxtTotalLeo.Enabled = True
        Txtconsigver.Enabled = True
        TxtExhiVer.Enabled = True
        TxtDispoVer.Enabled = True
        TxtTotalVer.Enabled = True
        TxtDescriSat.Enabled = True
        TxtConsigCul.Enabled = True
        TxtExhiCul.Enabled = True
        TxtDispoCul.Enabled = True
        TxtTotalCul.Enabled = True
    End Sub
    ''' <summary>
    ''' deshabilita los textbox's y combox's del formulario, cuando se le da al boton de limpiar
    ''' </summary>
    Private Sub BloquearTextBox()
        txtconsigmty.Enabled = False
        TxtExhimty.Enabled = False
        TxtDispoMty.Enabled = False
        TxtTotalmty.Enabled = False
        Txtconsigalex.Enabled = False
        TxtExhiAlex.Enabled = False
        TxtDispoAlex.Enabled = False
        TxtTotalAlex.Enabled = False
        TxtConsigGdl.Enabled = False
        TxtExhiGdl.Enabled = False
        TxtDispoGdl.Enabled = False
        TxtTotalGdl.Enabled = False
        TxtConsigMex.Enabled = False
        TxtExhimex.Enabled = False
        TxtDispomex.Enabled = False
        TxtTotalMex.Enabled = False
        TxtConsigLeo.Enabled = False
        TxtExhiLeo.Enabled = False
        TxtDispoLeo.Enabled = False
        TxtTotalLeo.Enabled = False
        Txtconsigver.Enabled = False
        TxtExhiVer.Enabled = False
        TxtDispoVer.Enabled = False
        TxtTotalVer.Enabled = False
        Me.Txtprecio1.Enabled = False
        Me.Txtprecio2.Enabled = False
        Me.Txtprecio3.Enabled = False
        Me.Txtprecio4.Enabled = False
        Me.Txtprecio5.Enabled = False
        Me.Txtprecio6.Enabled = False
        Me.Txtprecio7.Enabled = False
        Me.Txtprecio8.Enabled = False
    End Sub
    ''' <summary>
    ''' evento que se dispara cuando le das enter al textcodigo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            RecuperaInfoCodigo()
            Me.BtnNuevo.Enabled = False
            If Me.TxtDescripcion.Text = "" Then 'Descripcion no tiene informacion, deshabilita botones
                Me.BtnElimi.Enabled = False
                Me.BtnModificar.Enabled = False
            Else 'descripcion si tiene informacion habilita botones
                Me.BtnElimi.Enabled = True
                Me.BtnModificar.Enabled = True
            End If
        End If
    End Sub

    Private Sub CmbMarca_Click(sender As Object, e As EventArgs) Handles CmbMarca.Click
        RellenaCmbMarca()
    End Sub

    Private Sub CmbClase_Click(sender As Object, e As EventArgs) Handles CmbClase.Click
        RellenaCmbClase()
    End Sub

    Private Sub CmbUnidad_Click(sender As Object, e As EventArgs) Handles CmbUnidad.Click
        RellenaCmbUnidad()
    End Sub
    ''' <summary>
    ''' proceso para inserta una ubicacion x codigo
    ''' </summary>
    Private Sub InsertaUbicacion()
        Dim codigo As New Producto
        Dim ubicacion As New Producto
        Dim codigoUbi As New NProducto
        codigo.Codigo = TxtCodigo.Text
        ubicacion.Ubicacion = CmbUbicacion.Text
        codigoUbi.InsertaUbicacion(cadenaConex, codigo, ubicacion)
    End Sub

    Private Sub CmbUbicacion_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbUbicacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            InsertaUbicacion()
        End If
    End Sub
    ''' <summary>
    ''' evento que se acciona cuando se le da click al CmbUbicacion
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CmbUbicacion_Click(sender As Object, e As EventArgs) Handles CmbUbicacion.Click
        RellenaCmbUbicacion()
        Me.CmbUbicacion.Text = ""
    End Sub
    ''' <summary>
    ''' proceso para obtener todas las ubicaciones x codigo pero en forma de lista
    ''' </summary>
    Private Sub RellenaCmbUbicacion()
        Dim listaUbicaciones As New LUbicacion
        listaUbicaciones = ObtenerUbicaciones()
        With CmbUbicacion
            .DataSource = listaUbicaciones
            .DisplayMember = "Ubicacion"
            .ValueMember = "IdUbicacion"
        End With
    End Sub
    Private Function ObtenerUbicaciones()
        Dim ubicacion As New NProducto
        Dim codigo As New Producto
        Dim listaUbicaciones As New LUbicacion
        codigo.Codigo = TxtCodigo.Text
        listaUbicaciones = ubicacion.ObtenerUbicaciones(cadenaConex, codigo)
        Return listaUbicaciones
    End Function
    Private Sub EliminaUbicacionCod()
        Dim Codigo As New Producto
        Dim eliminaUbicacion As New NProducto
        Codigo.Codigo = TxtCodigo.Text
        eliminaUbicacion.EliminaUbicacionCodigo(cadenaConex, Codigo)
    End Sub

    Private Sub CmbTipo_Click(sender As Object, e As EventArgs) Handles CmbTipo.Click
        RellenaCmbTipo()
    End Sub
    Private Sub RellenaCmbTipo()
        Dim listaTipo As New LTipo
        listaTipo = ObtenerTipo()
        With CmbTipo
            .DataSource = listaTipo
            .DisplayMember = "Nombre"
            .ValueMember = "Id"
        End With
    End Sub
    Private Function ObtenerTipo()
        Dim tipo As New NTipo
        Dim listaTipo As New LTipo
        listaTipo = tipo.ObtenerTipos(cadenaConex)
        Return listaTipo
    End Function
End Class


