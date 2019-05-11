Imports System.Windows.Forms

Public Class PUtilerias
    ''' <summary>
    ''' Herramienta para todos los combobox de un formulario,
    ''' se pueden limpiar solo algunos elementos o todo
    ''' </summary>
    ''' <param name="container"></param>
    ''' <param name="ds">DataSource</param>
    ''' <param name="vm">ValueMember</param>
    ''' <param name="dm">DisplayMember</param>
    ''' <param name="sv">SelectedValue</param>
    ''' <param name="si">SelectedItem</param>
    ''' <param name="tx">Text</param>
    ''' <param name="ex1">Excepcion 1</param>
    ''' <param name="ex2">Excepcion 2</param>
    Public Sub LimpiarComboBox(ByVal container As Control, ByVal ds As Boolean, ByVal vm As Boolean, ByVal dm As Boolean, ByVal sv As Boolean, ByVal si As Boolean, ByVal tx As Boolean, Optional ByVal ex1 As String = "", Optional ByVal ex2 As String = "")
        'Aborto procedimiento
        If container Is Nothing Then
            Return
        ElseIf Not container.HasChildren Then
            Return
        End If

        For Each ctrl As Control In container.Controls
            If ctrl.Name <> ex1 And ctrl.Name <> ex2 Then 'excepciones
                If TypeOf ctrl Is ComboBox Then
                    If ds Then CType(ctrl, ComboBox).DataSource = Nothing
                    If vm Then CType(ctrl, ComboBox).ValueMember = Nothing
                    If dm Then CType(ctrl, ComboBox).DisplayMember = Nothing
                    CType(ctrl, ComboBox).DropDownWidth = 1
                    If sv Then CType(ctrl, ComboBox).SelectedValue = ""
                    If si Then CType(ctrl, ComboBox).SelectedItem = Nothing
                    If tx Then CType(ctrl, ComboBox).Text = Nothing
                End If
            End If
            'Si es un control contenedor
            If ctrl.HasChildren Then
                'Reinvoco procedimiento con este control
                LimpiarComboBox(ctrl, ds, vm, dm, sv, si, tx)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Herramienta para sólo un combobox de un formulario,
    ''' se pueden limpiar solo algunos elementos o todo
    ''' </summary>
    ''' <param name="container">formulario</param>
    ''' <param name="nombre">Nombre del Combobox</param>
    ''' <param name="ds">DataSource</param>
    ''' <param name="vm">ValueMember</param>
    ''' <param name="dm">DisplayMember</param>
    ''' <param name="sv">SelectedValue</param>
    ''' <param name="si">SelectedItem</param>
    ''' <param name="tx">Text</param>
    Public Sub LimpiarUnComboBox(ByVal container As Control, ByVal nombre As String, ByVal ds As Boolean, ByVal vm As Boolean, ByVal dm As Boolean, ByVal sv As Boolean, ByVal si As Boolean, ByVal tx As Boolean)
        'Aborto procedimiento
        If container Is Nothing Then
            Return
        ElseIf Not container.HasChildren Then
            Return
        End If

        For Each ctrl As Control In container.Controls

            If TypeOf ctrl Is ComboBox And ctrl.Name = nombre Then
                If ds Then CType(ctrl, ComboBox).DataSource = Nothing
                If vm Then CType(ctrl, ComboBox).ValueMember = Nothing
                If dm Then CType(ctrl, ComboBox).DisplayMember = Nothing
                CType(ctrl, ComboBox).DropDownWidth = 1
                If sv Then CType(ctrl, ComboBox).SelectedValue = ""
                If si Then CType(ctrl, ComboBox).SelectedItem = Nothing
                If tx Then CType(ctrl, ComboBox).Text = Nothing

            End If
            'Si es un control contenedor
            If ctrl.HasChildren Then
                'Reinvoco procedimiento con este control
                LimpiarUnComboBox(ctrl, nombre, ds, vm, dm, sv, si, tx)
            End If
        Next
    End Sub
    Public Sub LimpiarTextBox(ByVal container As Control)
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
    ''' <summary>
    ''' Se agrega un Evento que involucra el cambio en todos los controles de un formulario
    ''' </summary>
    ''' <param name="container">contenedor con los controles correspondientes</param>
    Public Sub AgregarEventoCambiosFormulario(container As Control, Optional excepto As String = "")
        'Aborto procedimiento
        If container Is Nothing Then
            Return
        ElseIf Not container.HasChildren Then
            Return
        End If

        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Name <> excepto Then
                    AddHandler ctrl.TextChanged, AddressOf FrmFactura.Cambios_Formulario
                End If
            End If

            'Si es un control contenedor
            If ctrl.HasChildren Then
                'Reinvoco procedimiento con este control
                AgregarEventoCambiosFormulario(ctrl)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Habilitar todos los botones de un Formulario
    ''' </summary>
    ''' <param name="container"></param>
    Public Sub HabilitarBotones(ByVal container As Control)
        'Aborto procedimiento
        If container Is Nothing Then
            Return
        ElseIf Not container.HasChildren Then
            Return
        End If

        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is Button Then
                CType(ctrl, Button).Enabled = True
            End If

            'Si es un control contenedor
            If ctrl.HasChildren Then
                'Reinvoco procedimiento con este control
                LimpiarTextBox(ctrl)
            End If
        Next
    End Sub
    ''' <summary>
    ''' Regresa la ruta de un archivo seleccionado con el Explorador de Windows
    ''' </summary>
    ''' <param name="tipo">tipo de archivo ejemplo: "XML|*.xml" </param>
    ''' <returns>ruta completa del archivo</returns>
    Public Function BuscarRutaArchivo(tipo As String) As String
        Dim dlg As New OpenFileDialog
        dlg.Filter = tipo


        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ext As String = System.IO.Path.GetFileName(dlg.FileName)
            Dim extension As String = System.IO.Path.GetDirectoryName(dlg.FileName)
            Return extension & "\" & ext
        End If
        Return Nothing
    End Function
    Public Function BuscarRutaCarpeta() As String
        Dim dlg As New FolderBrowserDialog

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return dlg.SelectedPath()
        End If
        Return Nothing
    End Function
    ''' <summary>
    ''' Mueve y muestra el boton F3 a la posicion del textbox que se deseee
    ''' </summary>
    ''' <param name="control">textbox</param>
    ''' <param name="btn">nombre del boton a mover</param>
    Public Sub UbicaBtnF3(control As Object, btn As Object)
        Dim x As Integer = control.Location.X
        Dim w As Integer = control.Size.Width - 1
        Dim y As Integer = control.Location.Y - 1

        btn.Location = New Drawing.Point(x + w, y)
        btn.Visible = True
    End Sub
End Class
