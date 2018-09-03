<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Principal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUEVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABRIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGEADO"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVOToolStripMenuItem, Me.ABRIRToolStripMenuItem1, Me.CERRARToolStripMenuItem})
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AbrirToolStripMenuItem.Text = "&ARCHIVO"
        '
        'NUEVOToolStripMenuItem
        '
        Me.NUEVOToolStripMenuItem.Name = "NUEVOToolStripMenuItem"
        Me.NUEVOToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NUEVOToolStripMenuItem.Text = "&NUEVO"
        '
        'ABRIRToolStripMenuItem1
        '
        Me.ABRIRToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Form3ToolStripMenuItem})
        Me.ABRIRToolStripMenuItem1.Name = "ABRIRToolStripMenuItem1"
        Me.ABRIRToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.ABRIRToolStripMenuItem1.Text = "A&BRIR"
        '
        'Form3ToolStripMenuItem
        '
        Me.Form3ToolStripMenuItem.Name = "Form3ToolStripMenuItem"
        Me.Form3ToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.Form3ToolStripMenuItem.Text = "Form3"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CERRARToolStripMenuItem.Text = "&CERRAR"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "&SALIR"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Location = New System.Drawing.Point(48, 183)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(194, 40)
        Me.Btn_Salir.TabIndex = 6
        Me.Btn_Salir.Text = "SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUEVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABRIRToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CERRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
