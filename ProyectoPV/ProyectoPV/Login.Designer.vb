<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Btn_Entrar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Txt_Contrasena = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 319)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 42)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "AppComercio"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.user_13230
        Me.PictureBox3.Location = New System.Drawing.Point(40, 29)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(176, 219)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Btn_Entrar
        '
        Me.Btn_Entrar.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Entrar.Location = New System.Drawing.Point(308, 253)
        Me.Btn_Entrar.Name = "Btn_Entrar"
        Me.Btn_Entrar.Size = New System.Drawing.Size(194, 40)
        Me.Btn_Entrar.TabIndex = 4
        Me.Btn_Entrar.Text = "&ENTRAR"
        Me.Btn_Entrar.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Location = New System.Drawing.Point(527, 253)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(194, 40)
        Me.Btn_Salir.TabIndex = 5
        Me.Btn_Salir.Text = "&SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(465, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LOGIN"
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.BackColor = System.Drawing.Color.White
        Me.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Usuario.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Usuario.ForeColor = System.Drawing.Color.Black
        Me.Txt_Usuario.Location = New System.Drawing.Point(308, 65)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(413, 26)
        Me.Txt_Usuario.TabIndex = 7
        Me.Txt_Usuario.Text = "USUARIO"
        '
        'Txt_Contrasena
        '
        Me.Txt_Contrasena.BackColor = System.Drawing.Color.White
        Me.Txt_Contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Contrasena.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contrasena.ForeColor = System.Drawing.Color.Black
        Me.Txt_Contrasena.Location = New System.Drawing.Point(308, 166)
        Me.Txt_Contrasena.Name = "Txt_Contrasena"
        Me.Txt_Contrasena.Size = New System.Drawing.Size(413, 26)
        Me.Txt_Contrasena.TabIndex = 8
        Me.Txt_Contrasena.Text = "CONTRASEÑA"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(772, 319)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 308
        Me.LineShape2.X2 = 720
        Me.LineShape2.Y1 = 200
        Me.LineShape2.Y2 = 200
        '
        'LineShape1
        '
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 308
        Me.LineShape1.X2 = 720
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 319)
        Me.Controls.Add(Me.Txt_Contrasena)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Entrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Entrar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Contrasena As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
