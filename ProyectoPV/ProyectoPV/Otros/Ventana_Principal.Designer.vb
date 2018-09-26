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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Principal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.Btn_Salir2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Fecha_2 = New System.Windows.Forms.Label()
        Me.Lbl_hora_2 = New System.Windows.Forms.Label()
        Me.Lbl_hora = New System.Windows.Forms.Label()
        Me.Lbl_fecha = New System.Windows.Forms.Label()
        Me.Inicio = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGEADO"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Location = New System.Drawing.Point(56, 183)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(226, 40)
        Me.Btn_Salir.TabIndex = 6
        Me.Btn_Salir.Text = "SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(175, 150)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(9, 8)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(175, 175)
        Me.ToolStripContainer1.TabIndex = 7
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer2
        '
        Me.ToolStripContainer2.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.BackColor = System.Drawing.Color.White
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Btn_Salir2)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Panel1)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Button2)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Button1)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(586, 339)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.LeftToolStripPanelVisible = False
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.RightToolStripPanelVisible = False
        Me.ToolStripContainer2.Size = New System.Drawing.Size(586, 339)
        Me.ToolStripContainer2.TabIndex = 8
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        Me.ToolStripContainer2.TopToolStripPanelVisible = False
        '
        'Btn_Salir2
        '
        Me.Btn_Salir2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Salir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir2.Location = New System.Drawing.Point(409, 293)
        Me.Btn_Salir2.Name = "Btn_Salir2"
        Me.Btn_Salir2.Size = New System.Drawing.Size(165, 34)
        Me.Btn_Salir2.TabIndex = 7
        Me.Btn_Salir2.Text = "&SALIR"
        Me.Btn_Salir2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Lbl_Fecha_2)
        Me.Panel1.Controls.Add(Me.Lbl_hora_2)
        Me.Panel1.Controls.Add(Me.Lbl_hora)
        Me.Panel1.Controls.Add(Me.Lbl_fecha)
        Me.Panel1.Controls.Add(Me.Inicio)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 38)
        Me.Panel1.TabIndex = 10
        '
        'Lbl_Fecha_2
        '
        Me.Lbl_Fecha_2.AutoSize = True
        Me.Lbl_Fecha_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha_2.ForeColor = System.Drawing.Color.White
        Me.Lbl_Fecha_2.Location = New System.Drawing.Point(288, 13)
        Me.Lbl_Fecha_2.Name = "Lbl_Fecha_2"
        Me.Lbl_Fecha_2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_Fecha_2.TabIndex = 4
        Me.Lbl_Fecha_2.Text = "Label3"
        '
        'Lbl_hora_2
        '
        Me.Lbl_hora_2.AutoSize = True
        Me.Lbl_hora_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_hora_2.ForeColor = System.Drawing.Color.White
        Me.Lbl_hora_2.Location = New System.Drawing.Point(478, 13)
        Me.Lbl_hora_2.Name = "Lbl_hora_2"
        Me.Lbl_hora_2.Size = New System.Drawing.Size(57, 13)
        Me.Lbl_hora_2.TabIndex = 3
        Me.Lbl_hora_2.Text = "00:00:00"
        '
        'Lbl_hora
        '
        Me.Lbl_hora.AutoSize = True
        Me.Lbl_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_hora.ForeColor = System.Drawing.Color.White
        Me.Lbl_hora.Location = New System.Drawing.Point(434, 13)
        Me.Lbl_hora.Name = "Lbl_hora"
        Me.Lbl_hora.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_hora.TabIndex = 2
        Me.Lbl_hora.Text = "Hora:"
        '
        'Lbl_fecha
        '
        Me.Lbl_fecha.AutoSize = True
        Me.Lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_fecha.ForeColor = System.Drawing.Color.White
        Me.Lbl_fecha.Location = New System.Drawing.Point(236, 13)
        Me.Lbl_fecha.Name = "Lbl_fecha"
        Me.Lbl_fecha.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_fecha.TabIndex = 1
        Me.Lbl_fecha.Text = "Fecha:"
        '
        'Inicio
        '
        Me.Inicio.AutoSize = True
        Me.Inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.Location = New System.Drawing.Point(5, 8)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(52, 20)
        Me.Inicio.TabIndex = 0
        Me.Inicio.Text = "Inicio"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.cajero
        Me.Button2.Location = New System.Drawing.Point(79, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 163)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cajero"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.png4
        Me.Button1.Location = New System.Drawing.Point(320, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 163)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Gerente"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(586, 339)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Ventana_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppComercio"
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents Inicio As System.Windows.Forms.Label
    Friend WithEvents Lbl_Fecha_2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_hora_2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Btn_Salir2 As System.Windows.Forms.Button
End Class
