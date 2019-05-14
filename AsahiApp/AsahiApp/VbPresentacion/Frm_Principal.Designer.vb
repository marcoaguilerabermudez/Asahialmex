<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Men_Principal = New System.Windows.Forms.MenuStrip()
        Me.RecursosHumanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreNominaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreNominaListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreNominaGlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChecadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDePruducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Men_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Men_Principal
        '
        Me.Men_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecursosHumanosToolStripMenuItem, Me.ControlDePruducciónToolStripMenuItem})
        Me.Men_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Men_Principal.Name = "Men_Principal"
        Me.Men_Principal.Size = New System.Drawing.Size(743, 24)
        Me.Men_Principal.TabIndex = 2
        Me.Men_Principal.Text = "MenuStrip1"
        '
        'RecursosHumanosToolStripMenuItem
        '
        Me.RecursosHumanosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreNominaToolStripMenuItem})
        Me.RecursosHumanosToolStripMenuItem.Name = "RecursosHumanosToolStripMenuItem"
        Me.RecursosHumanosToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.RecursosHumanosToolStripMenuItem.Text = "Recursos Humanos"
        '
        'PreNominaToolStripMenuItem
        '
        Me.PreNominaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreNominaListadoToolStripMenuItem, Me.PreNominaGlobalToolStripMenuItem, Me.ChecadasToolStripMenuItem, Me.ComidasToolStripMenuItem})
        Me.PreNominaToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.PreNominaToolStripMenuItem.Name = "PreNominaToolStripMenuItem"
        Me.PreNominaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreNominaToolStripMenuItem.Text = "Pre nomina"
        '
        'PreNominaListadoToolStripMenuItem
        '
        Me.PreNominaListadoToolStripMenuItem.Name = "PreNominaListadoToolStripMenuItem"
        Me.PreNominaListadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreNominaListadoToolStripMenuItem.Text = "Pre nomina Listado"
        '
        'PreNominaGlobalToolStripMenuItem
        '
        Me.PreNominaGlobalToolStripMenuItem.Name = "PreNominaGlobalToolStripMenuItem"
        Me.PreNominaGlobalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreNominaGlobalToolStripMenuItem.Text = "Pre nomina Global"
        '
        'ChecadasToolStripMenuItem
        '
        Me.ChecadasToolStripMenuItem.Name = "ChecadasToolStripMenuItem"
        Me.ChecadasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChecadasToolStripMenuItem.Text = "Checadas"
        '
        'ComidasToolStripMenuItem
        '
        Me.ComidasToolStripMenuItem.Name = "ComidasToolStripMenuItem"
        Me.ComidasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComidasToolStripMenuItem.Text = "Comedor"
        '
        'ControlDePruducciónToolStripMenuItem
        '
        Me.ControlDePruducciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeProducciónToolStripMenuItem})
        Me.ControlDePruducciónToolStripMenuItem.Name = "ControlDePruducciónToolStripMenuItem"
        Me.ControlDePruducciónToolStripMenuItem.Size = New System.Drawing.Size(139, 20)
        Me.ControlDePruducciónToolStripMenuItem.Text = "Control de Producción"
        '
        'ControlDeProducciónToolStripMenuItem
        '
        Me.ControlDeProducciónToolStripMenuItem.Name = "ControlDeProducciónToolStripMenuItem"
        Me.ControlDeProducciónToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ControlDeProducciónToolStripMenuItem.Text = "Control de Producción"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 440)
        Me.Controls.Add(Me.Men_Principal)
        Me.MainMenuStrip = Me.Men_Principal
        Me.Name = "Frm_Principal"
        Me.Text = "AsahiApp"
        Me.Men_Principal.ResumeLayout(False)
        Me.Men_Principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Men_Principal As MenuStrip
    Friend WithEvents RecursosHumanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreNominaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDePruducciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreNominaListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreNominaGlobalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChecadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeProducciónToolStripMenuItem As ToolStripMenuItem
End Class
