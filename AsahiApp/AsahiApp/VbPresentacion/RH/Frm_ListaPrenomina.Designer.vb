<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ListaPrenomina
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Lbl_Semana = New System.Windows.Forms.Label()
        Me.Lbl_año = New System.Windows.Forms.Label()
        Me.Dgv_ListaPrenomina = New System.Windows.Forms.DataGridView()
        Me.Lbl_Dia1 = New System.Windows.Forms.Label()
        Me.Lbl_Dia2 = New System.Windows.Forms.Label()
        Me.Lbl_Dia4 = New System.Windows.Forms.Label()
        Me.Lbl_Dia3 = New System.Windows.Forms.Label()
        Me.lbl_Dia7 = New System.Windows.Forms.Label()
        Me.lbl_Dia6 = New System.Windows.Forms.Label()
        Me.Lbl_Dia5 = New System.Windows.Forms.Label()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horarioEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamentoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entrada7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salida7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bonoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_ListaPrenomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(87, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Lbl_Semana
        '
        Me.Lbl_Semana.AutoSize = True
        Me.Lbl_Semana.Location = New System.Drawing.Point(13, 44)
        Me.Lbl_Semana.Name = "Lbl_Semana"
        Me.Lbl_Semana.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Semana.TabIndex = 2
        Me.Lbl_Semana.Text = "Semana"
        '
        'Lbl_año
        '
        Me.Lbl_año.AutoSize = True
        Me.Lbl_año.Location = New System.Drawing.Point(106, 67)
        Me.Lbl_año.Name = "Lbl_año"
        Me.Lbl_año.Size = New System.Drawing.Size(25, 13)
        Me.Lbl_año.TabIndex = 3
        Me.Lbl_año.Text = "año"
        '
        'Dgv_ListaPrenomina
        '
        Me.Dgv_ListaPrenomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ListaPrenomina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombreEmpleado, Me.horarioEmpleado, Me.departamentoEmpleado, Me.entrada1, Me.salida1, Me.entrada2, Me.salida2, Me.entrada3, Me.salida3, Me.entrada4, Me.salida4, Me.entrada5, Me.salida5, Me.entrada6, Me.salida6, Me.entrada7, Me.salida7, Me.comentarios, Me.bonoEmpleado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListaPrenomina.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListaPrenomina.Location = New System.Drawing.Point(4, 100)
        Me.Dgv_ListaPrenomina.Name = "Dgv_ListaPrenomina"
        Me.Dgv_ListaPrenomina.RowHeadersWidth = 20
        Me.Dgv_ListaPrenomina.Size = New System.Drawing.Size(1155, 398)
        Me.Dgv_ListaPrenomina.TabIndex = 0
        '
        'Lbl_Dia1
        '
        Me.Lbl_Dia1.AutoSize = True
        Me.Lbl_Dia1.Location = New System.Drawing.Point(499, 84)
        Me.Lbl_Dia1.Name = "Lbl_Dia1"
        Me.Lbl_Dia1.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Dia1.TabIndex = 4
        Me.Lbl_Dia1.Text = "día1"
        '
        'Lbl_Dia2
        '
        Me.Lbl_Dia2.AutoSize = True
        Me.Lbl_Dia2.Location = New System.Drawing.Point(569, 84)
        Me.Lbl_Dia2.Name = "Lbl_Dia2"
        Me.Lbl_Dia2.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Dia2.TabIndex = 5
        Me.Lbl_Dia2.Text = "día2"
        '
        'Lbl_Dia4
        '
        Me.Lbl_Dia4.AutoSize = True
        Me.Lbl_Dia4.Location = New System.Drawing.Point(709, 84)
        Me.Lbl_Dia4.Name = "Lbl_Dia4"
        Me.Lbl_Dia4.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Dia4.TabIndex = 7
        Me.Lbl_Dia4.Text = "día4"
        '
        'Lbl_Dia3
        '
        Me.Lbl_Dia3.AutoSize = True
        Me.Lbl_Dia3.Location = New System.Drawing.Point(639, 84)
        Me.Lbl_Dia3.Name = "Lbl_Dia3"
        Me.Lbl_Dia3.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Dia3.TabIndex = 6
        Me.Lbl_Dia3.Text = "día3"
        '
        'lbl_Dia7
        '
        Me.lbl_Dia7.AutoSize = True
        Me.lbl_Dia7.Location = New System.Drawing.Point(917, 84)
        Me.lbl_Dia7.Name = "lbl_Dia7"
        Me.lbl_Dia7.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Dia7.TabIndex = 10
        Me.lbl_Dia7.Text = "día7"
        '
        'lbl_Dia6
        '
        Me.lbl_Dia6.AutoSize = True
        Me.lbl_Dia6.Location = New System.Drawing.Point(848, 84)
        Me.lbl_Dia6.Name = "lbl_Dia6"
        Me.lbl_Dia6.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Dia6.TabIndex = 9
        Me.lbl_Dia6.Text = "día6"
        '
        'Lbl_Dia5
        '
        Me.Lbl_Dia5.AutoSize = True
        Me.Lbl_Dia5.Location = New System.Drawing.Point(779, 84)
        Me.Lbl_Dia5.Name = "Lbl_Dia5"
        Me.Lbl_Dia5.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Dia5.TabIndex = 8
        Me.Lbl_Dia5.Text = "día5"
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "Id"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Width = 50
        '
        'nombreEmpleado
        '
        Me.nombreEmpleado.HeaderText = "Nombre"
        Me.nombreEmpleado.Name = "nombreEmpleado"
        Me.nombreEmpleado.ReadOnly = True
        Me.nombreEmpleado.Width = 200
        '
        'horarioEmpleado
        '
        Me.horarioEmpleado.HeaderText = "Horario"
        Me.horarioEmpleado.Name = "horarioEmpleado"
        Me.horarioEmpleado.ReadOnly = True
        '
        'departamentoEmpleado
        '
        Me.departamentoEmpleado.HeaderText = "Departamento"
        Me.departamentoEmpleado.Name = "departamentoEmpleado"
        Me.departamentoEmpleado.ReadOnly = True
        '
        'entrada1
        '
        Me.entrada1.HeaderText = "E1"
        Me.entrada1.Name = "entrada1"
        Me.entrada1.Width = 35
        '
        'salida1
        '
        Me.salida1.HeaderText = "S1"
        Me.salida1.Name = "salida1"
        Me.salida1.Width = 35
        '
        'entrada2
        '
        Me.entrada2.HeaderText = "E2"
        Me.entrada2.Name = "entrada2"
        Me.entrada2.Width = 35
        '
        'salida2
        '
        Me.salida2.HeaderText = "S2"
        Me.salida2.Name = "salida2"
        Me.salida2.Width = 35
        '
        'entrada3
        '
        Me.entrada3.HeaderText = "E3"
        Me.entrada3.Name = "entrada3"
        Me.entrada3.Width = 35
        '
        'salida3
        '
        Me.salida3.HeaderText = "S3"
        Me.salida3.Name = "salida3"
        Me.salida3.Width = 35
        '
        'entrada4
        '
        Me.entrada4.HeaderText = "E4"
        Me.entrada4.Name = "entrada4"
        Me.entrada4.Width = 35
        '
        'salida4
        '
        Me.salida4.HeaderText = "S4"
        Me.salida4.Name = "salida4"
        Me.salida4.Width = 35
        '
        'entrada5
        '
        Me.entrada5.HeaderText = "E5"
        Me.entrada5.Name = "entrada5"
        Me.entrada5.Width = 35
        '
        'salida5
        '
        Me.salida5.HeaderText = "S5"
        Me.salida5.Name = "salida5"
        Me.salida5.Width = 35
        '
        'entrada6
        '
        Me.entrada6.HeaderText = "E6"
        Me.entrada6.Name = "entrada6"
        Me.entrada6.Width = 35
        '
        'salida6
        '
        Me.salida6.HeaderText = "S6"
        Me.salida6.Name = "salida6"
        Me.salida6.Width = 35
        '
        'entrada7
        '
        Me.entrada7.HeaderText = "E7"
        Me.entrada7.Name = "entrada7"
        Me.entrada7.Width = 35
        '
        'salida7
        '
        Me.salida7.HeaderText = "S7"
        Me.salida7.Name = "salida7"
        Me.salida7.Width = 35
        '
        'comentarios
        '
        Me.comentarios.HeaderText = "Comentarios"
        Me.comentarios.Name = "comentarios"
        Me.comentarios.Width = 150
        '
        'bonoEmpleado
        '
        Me.bonoEmpleado.HeaderText = "Bono"
        Me.bonoEmpleado.Name = "bonoEmpleado"
        Me.bonoEmpleado.Width = 40
        '
        'Frm_ListaPrenomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 503)
        Me.Controls.Add(Me.lbl_Dia7)
        Me.Controls.Add(Me.lbl_Dia6)
        Me.Controls.Add(Me.Lbl_Dia5)
        Me.Controls.Add(Me.Lbl_Dia4)
        Me.Controls.Add(Me.Lbl_Dia3)
        Me.Controls.Add(Me.Lbl_Dia2)
        Me.Controls.Add(Me.Lbl_Dia1)
        Me.Controls.Add(Me.Lbl_año)
        Me.Controls.Add(Me.Lbl_Semana)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Dgv_ListaPrenomina)
        Me.Name = "Frm_ListaPrenomina"
        Me.Text = "Lista Prenomina"
        CType(Me.Dgv_ListaPrenomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Lbl_Semana As Label
    Friend WithEvents Lbl_año As Label
    Friend WithEvents Dgv_ListaPrenomina As DataGridView
    Friend WithEvents Lbl_Dia1 As Label
    Friend WithEvents Lbl_Dia2 As Label
    Friend WithEvents Lbl_Dia4 As Label
    Friend WithEvents Lbl_Dia3 As Label
    Friend WithEvents lbl_Dia7 As Label
    Friend WithEvents lbl_Dia6 As Label
    Friend WithEvents Lbl_Dia5 As Label
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents horarioEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents departamentoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents entrada1 As DataGridViewTextBoxColumn
    Friend WithEvents salida1 As DataGridViewTextBoxColumn
    Friend WithEvents entrada2 As DataGridViewTextBoxColumn
    Friend WithEvents salida2 As DataGridViewTextBoxColumn
    Friend WithEvents entrada3 As DataGridViewTextBoxColumn
    Friend WithEvents salida3 As DataGridViewTextBoxColumn
    Friend WithEvents entrada4 As DataGridViewTextBoxColumn
    Friend WithEvents salida4 As DataGridViewTextBoxColumn
    Friend WithEvents entrada5 As DataGridViewTextBoxColumn
    Friend WithEvents salida5 As DataGridViewTextBoxColumn
    Friend WithEvents entrada6 As DataGridViewTextBoxColumn
    Friend WithEvents salida6 As DataGridViewTextBoxColumn
    Friend WithEvents entrada7 As DataGridViewTextBoxColumn
    Friend WithEvents salida7 As DataGridViewTextBoxColumn
    Friend WithEvents comentarios As DataGridViewTextBoxColumn
    Friend WithEvents bonoEmpleado As DataGridViewTextBoxColumn
End Class
