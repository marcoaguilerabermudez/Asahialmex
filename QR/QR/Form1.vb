Imports System.Media
Public Class Form1
    Dim conexion As conexion = New conexion()
    Dim cont_ok As Integer = 0
    Dim cont_dup As Integer = 0
    Dim DB_ok As String = "ccd"
    Dim DB_dup As String = "ccd_duplicado"
    Dim modotest As Integer = 0
    Dim grabadomanual As Integer = 0
    Dim msg_modo As String = ""
    Dim msg_manual As String = ""


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Mostrardatos() 'Actualiza el grid 
        'Mostrar_duplicador()

        txt_Id.Select()
        txt_captura.Enabled = False
        lbl_contdup.Text = 0
        lbl_estado.Text = msg_modo + msg_manual
    End Sub

    Public Sub Mostrardatos() 'Procedimiento para traer la infromacion capturada del la base de datos y llenar el grid
        conexion.Consulta("Select top (80) [ccd_id] ID, [ccd_fecha] [FECHA LECTURA], [ccd_date] [DATE], [ccd_Machine] MACHINE, [ccd_die] DIE, [ccd_shot] SHOT, [ccd_cadena] CODIGO, ccd_user Usuario, ccd_count Contador from " + DB_ok + " order by 1 DESC", DB_ok)
        dgv_Muestra.DataSource = conexion.ds.Tables(DB_ok)
        lbl_count.Text = cont_ok
        Label2.Text = DateTime.Now.ToLongDateString() & " " & DateTime.Now.ToLongTimeString 'inserta fecha y hora de la maquina

    End Sub

    Public Sub Mostrar_duplicador() 'Procedimiento pra traer la informacion duplicada y llenar el grid secundario
        'conexion.Consulta("Select top (15) [ccd_id] ID, [ccd_fecha] [FECHA LECTURA], [ccd_date] [DATE], [ccd_Machine] MACHINE, [ccd_die] DIE, [ccd_shot] SHOT, [ccd_cadena] CODIGO, ccd_ref referancia   from " + DB_dup + " order by 1 DESC", DB_dup)
        conexion.Consulta("SELECT  top(25) D.ccd_id ID, CO.ccd_fecha [Primera  Lectura],D.ccd_fecha [Segunda Lectura],D.ccd_date [Date],D.Ccd_Machine Machine,D.ccd_die Die,D.ccd_shot Shot,D.ccd_cadena Cadena,Razon = case D.[ccd_razon] when 1 then 'Cadena duplicada' when 5 then 'Codigo HAL duplicado'  end ,D.ccd_user [ID Usuario]
        FROM " + DB_dup + " D 
                          INNER JOIN " + DB_ok + " CO     
                          ON D.ccd_ref=CO.ccd_id order by 1 DESC", DB_dup + DB_ok)
        dgv_duplicados.DataSource = conexion.ds.Tables(DB_dup + DB_ok)
        lbl_contdup.Text = cont_dup
        Label2.Text = DateTime.Now.ToLongDateString() & " " & DateTime.Now.ToLongTimeString 'inserta fecha y hora de la maquina
    End Sub
    Public Sub opciones()
        If chkb_manual.Checked = True Then
            modotest = 1
        Else
            modotest = 0
        End If
        If chkb_prueba.Checked = True Then
            grabadomanual = 1
        Else
            grabadomanual = 0
        End If
    End Sub


    Private Sub txt_captura_keyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_captura.KeyPress

        If Asc(e.KeyChar) = 13 Then ' Detecta si se preciona la tecla enter
            Dim buscar_cadena As String = "Select ccd_id from " + DB_ok + " where ccd_cadena = '" + txt_captura.Text + "'"
            Dim buscar_die_shot As String = "Select ccd_id from " + DB_ok + " where ccd_die + ccd_shot ='" + Strings.Right(txt_captura.Text, 8) + "'"
            Dim buscar_machine_die_shot As String = "Select ccd_id from " + DB_ok + " where ccd_Machine + ccd_die + ccd_shot ='" + Strings.Right(txt_captura.Text, 10) + "'"

            Dim agregar As String


            If (conexion.Busca(buscar_cadena)) Then ' compara la cadena
                Panel2.BackColor = Color.Tomato
                BEEP()
                MessageBox.Show("Cadena Duplicada: " + txt_captura.Text)
                cont_dup += 1
                agregar = "insert into " + DB_dup + "  values (getdate() ,'" + Strings.Left(txt_captura.Text, 5) + "','" + Strings.Mid(txt_captura.Text, 6, 2) + "','" + Strings.Mid(txt_captura.Text, 8, 2) + "','" + Strings.Right(txt_captura.Text, 6) + "', '" + txt_captura.Text + "',(select ccd_id from " + DB_ok + " where ccd_cadena = '" + txt_captura.Text + "') ,1,'" & txt_Id.Text & "'," & cont_dup & " )"

                If (conexion.Insertar(agregar)) Then
                    Mostrar_duplicador()
                Else
                    MessageBox.Show("Error al agregar") ' comapara maquina + die + shot
                End If
                Panel2.BackColor = Color.LightSteelBlue
                '**********************
            ElseIf (conexion.Busca(buscar_machine_die_shot)) Then ' comapara maquina + die + shot
                Panel2.BackColor = Color.Tomato
                BEEP()
                cont_dup = cont_dup + 1
                'agregar = "insert into " + DB_ok + "  values ( getdate() ,'" + Strings.Left(txt_captura.Text, 5) + "','" + Strings.Mid(txt_captura.Text, 6, 2) + "','" + Strings.Mid(txt_captura.Text, 8, 2) + "','" + Strings.Right(txt_captura.Text, 6) + "', '" + txt_captura.Text + "','" & txt_Id.Text & "'," & cont_ok & " )"
                'If (conexion.Insertar(agregar)) Then
                '    Mostrardatos()
                'Else
                '    MessageBox.Show("Error al agregar")
                'End If

                '**********************
                agregar = "insert into " + DB_dup + " values (getdate() ,'" + Strings.Left(txt_captura.Text, 5) + "','" + Strings.Mid(txt_captura.Text, 6, 2) + "','" + Strings.Mid(txt_captura.Text, 8, 2) + "','" + Strings.Right(txt_captura.Text, 6) + "', '" + txt_captura.Text + "', (Select top 1 ccd_id from " + DB_ok + " where ccd_Machine + ccd_die + ccd_shot='" + Strings.Right(txt_captura.Text, 10) + "'),5 ,'" & txt_Id.Text & "'," & cont_dup & " )"
                If (conexion.Insertar(agregar)) Then
                    MessageBox.Show("Key HAL Duplicada: " + Strings.Right(txt_captura.Text, 10))
                    Mostrar_duplicador()
                Else
                    MessageBox.Show("Error al agregar")
                End If
                Panel2.BackColor = Color.LightSteelBlue
                '**********************
                'ElseIf (conexion.Busca(buscar_die_shot)) Then ' comapara  die + shot
                '    Panel2.BackColor = Color.Red

                '    MessageBox.Show("Key HAL Duplicada: " + Strings.Right(txt_captura.Text, 8))
                '    cont_dup = cont_dup + 1
                '    agregar = "insert into " + DB_ok + "  values ( getdate() ,'" + Strings.Left(txt_captura.Text, 5) + "','" + Strings.Mid(txt_captura.Text, 6, 2) + "','" + Strings.Mid(txt_captura.Text, 8, 2) + "','" + Strings.Right(txt_captura.Text, 6) + "', '" + txt_captura.Text + "','" & txt_Id.Text & "'," & cont_ok & " )"
                '    '    agregar = "insert into " + DB_dup + " values (getdate() ,'" + Strings.Left(txt_captura.Text, 5) + "','" + Strings.Mid(txt_captura.Text, 6, 2) + "','" + Strings.Mid(txt_captura.Text, 8, 2) + "','" + Strings.Right(txt_captura.Text, 6) + "', '" + txt_captura.Text + "',(Select ccd_id from " + DB_ok + " where ccd_shot='" + Strings.Right(txt_captura.Text, 6) + "'),2 ,'" & txt_Id.Text & "'," & cont_dup & " )"
                '    If (conexion.Insertar(agregar)) Then
                '        Mostrardatos()
                '    Else
                '        MessageBox.Show("Error al agregar")
                '    End If

                '    '**********************
                '    agregar = "insert into " + DB_dup + " values (getdate() ,'" + Strings.Left(txt_captura.Text, 5) + "','" + Strings.Mid(txt_captura.Text, 6, 2) + "','" + Strings.Mid(txt_captura.Text, 8, 2) + "','" + Strings.Right(txt_captura.Text, 6) + "', '" + txt_captura.Text + "',(Select top 1 ccd_id from " + DB_ok + " where ccd_die + ccd_shot='" + Strings.Right(txt_captura.Text, 8) + "'),9 ,'" & txt_Id.Text & "'," & cont_dup & " )"
                '    If (conexion.Insertar(agregar)) Then
                '        Mostrar_duplicador()
                '    Else
                '        MessageBox.Show("Error al agregar")
                '    End If
                '    Panel2.BackColor = Color.LightSteelBlue
            Else
                Panel2.BackColor = Color.GreenYellow
                cont_ok = cont_ok + 1
                agregar = "insert into " + DB_ok + "  values ( getdate() ,'" + Strings.Left(txt_captura.Text, 5) + "','" + Strings.Mid(txt_captura.Text, 6, 2) + "','" + Strings.Mid(txt_captura.Text, 8, 2) + "','" + Strings.Right(txt_captura.Text, 6) + "', '" + txt_captura.Text + "','" & txt_Id.Text & "'," & cont_ok & "," & grabadomanual & "," & modotest & ",0," & Strings.Right(txt_captura.Text, 10) & " )"
                If (conexion.Insertar(agregar)) Then

                    Mostrardatos()
                Else
                    MessageBox.Show("Error al agregar")
                End If
            End If
            Panel2.BackColor = Color.LightSteelBlue
            txt_captura.Text = ""
            txt_captura.Select()
        End If

    End Sub

    Private Sub txt_id_keyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Id.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then

            e.Handled = False
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Tab) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then


                If txt_Id.Text > 0 And txt_Id.Text < 9000 Then
                    txt_Id.Enabled = False
                    txt_captura.Enabled = True
                    chkb_manual.Enabled = False
                    chkb_prueba.Enabled = False
                    txt_captura.Select()
                Else
                    MessageBox.Show("Ingrese su numero de empleado")
                    txt_Id.Select()
                End If
            End If
            'ElseIf Char.IsControl(e.KeyChar) Then
            '    e.Handled = False
        Else

            e.Handled = True
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'System.Console.Beep(1000, 1000)
        'System.Console.Beep(900, 1000)
        'System.Console.Beep(1500, 1000)
        'System.Console.Beep(2000, 1000)
        MessageBox.Show("Recuerda tomar nota de las Piezas OK")
        Me.Close()
    End Sub

    Private Sub chkb_manual_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_manual.CheckedChanged
        If chkb_manual.Checked = True Then
            grabadomanual = 1
            msg_manual = "Piezas grabadas Manualmente"
            lbl_estado.Text = msg_modo + msg_manual
        Else
            grabadomanual = 0
            msg_manual = ""
            lbl_estado.Text = msg_modo + msg_manual
        End If

    End Sub

    Private Sub chkb_prueba_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_prueba.CheckedChanged
        If chkb_prueba.Checked = True Then
            modotest = 1
            msg_modo = "Modo de Prueba"
            lbl_estado.Text = msg_modo + msg_manual


        Else
            modotest = 0
            msg_modo = ""
            lbl_estado.Text = msg_modo + msg_manual
        End If

    End Sub
    Private Sub BEEP()
        Dim i As Integer
        For i = 1 To 5

            System.Console.Beep(1000, 100)
            System.Console.Beep(2000, 100)
            System.Console.Beep(3000, 100)

        Next
    End Sub

    Private Sub txt_captura_TextChanged(sender As Object, e As EventArgs) Handles txt_captura.TextChanged

    End Sub
End Class

