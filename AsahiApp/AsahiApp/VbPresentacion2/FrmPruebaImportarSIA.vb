Imports System
Imports System.Windows.Forms
Imports System.Data

Public Class FrmPruebaImportarSIA
    Private Sub btnExaminar_Click(ByVal sender As Object,
                                  ByVal e As EventArgs) _
                                  Handles btnExaminar.Click
        Dim oFD As New OpenFileDialog
        With oFD
            .Filter = "Ficheros DBF (*.dbf)|*.dbf|Todos (*.*)|*.*"
            .FileName = txtFic.Text
            If .ShowDialog = DialogResult.OK Then
                txtFic.Text = .FileName
                ' El nombre del fichero
                txtSelect.Text = System.IO.Path.GetFileNameWithoutExtension(txtFic.Text)
                btnAbrir_Click(Nothing, Nothing)
            End If
        End With
    End Sub

    Private Sub btnAbrir_Click(ByVal sender As Object,
                               ByVal e As EventArgs) _
                               Handles btnAbrir.Click
        Dim sBase As String = txtFic.Text
        Dim sSelect As String = "SELECT * FROM " & txtSelect.Text
        Dim sConn As String

        sConn = "Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" &
        System.IO.Path.GetDirectoryName(sBase) & ";"

        'sConn = "Driver={Microsoft dBASE Driver (*.dbf)};DriverID=277;Dbq=" &
        'System.IO.Path.GetDirectoryName(sBase) & ";"

        'sConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        'System.IO.Path.GetDirectoryName(sBase) &
        '";Extended Properties=dBASE IV;"

        'Using dbConn As New System.Data.OleDb.OleDbConnection("Provider=VFPOLEDB.1;Data Source=" & sBase)

        Using dbConn As New System.Data.Odbc.OdbcConnection(sConn)
            'Using dbConn As New System.Data.OleDb.OleDbConnection(sConn)
            Try
                dbConn.Open()

                Dim da As New System.Data.Odbc.OdbcDataAdapter(sSelect, dbConn)
                'Dim da As New System.Data.OleDb.OleDbDataAdapter(sSelect, dbConn)
                Dim dt As New DataTable

                da.Fill(dt)

                dgvDiarios.DataSource = dt

                dbConn.Close()

            Catch ex As Exception
                MessageBox.Show("Error al abrir la base de datos" & vbCrLf & ex.Message)
                Exit Sub
            End Try
        End Using

    End Sub

    Private Sub Form1_DragDrop(ByVal sender As Object,
                               ByVal e As DragEventArgs) _
                               Handles Me.DragDrop, txtFic.DragDrop
        ' Drag & Drop, aceptar el primer fichero
        If e.Data.GetDataPresent("FileDrop") Then
            txtFic.Text = CType(e.Data.GetData("FileDrop", True), String())(0)
            txtSelect.Text = System.IO.Path.GetFileNameWithoutExtension(txtFic.Text)
        End If
    End Sub

    Private Sub Form1_DragEnter(ByVal sender As Object,
                                ByVal e As DragEventArgs) _
                                Handles Me.DragEnter, txtFic.DragEnter
        ' Drag & Drop, comprobar con DataFormats
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class