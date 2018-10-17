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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Ckt_Gerente = New System.Windows.Forms.CheckBox()
        Me.Btn_Entrar = New System.Windows.Forms.Button()
        Me.Txt_Contrasena = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lbl_fecha = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lbl_FechaLogin = New System.Windows.Forms.Label()
        Me.Lbl_HoraLogin = New System.Windows.Forms.Label()
        Me.Lbl_hora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerLogin = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ckt_Gerente
        '
        Me.Ckt_Gerente.AutoSize = True
        Me.Ckt_Gerente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ckt_Gerente.Location = New System.Drawing.Point(455, 213)
        Me.Ckt_Gerente.Name = "Ckt_Gerente"
        Me.Ckt_Gerente.Size = New System.Drawing.Size(121, 19)
        Me.Ckt_Gerente.TabIndex = 1
        Me.Ckt_Gerente.Text = "Usted es Gerente"
        Me.Ckt_Gerente.UseVisualStyleBackColor = True
        '
        'Btn_Entrar
        '
        Me.Btn_Entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Entrar.FlatAppearance.BorderSize = 0
        Me.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Entrar.Location = New System.Drawing.Point(290, 248)
        Me.Btn_Entrar.Name = "Btn_Entrar"
        Me.Btn_Entrar.Size = New System.Drawing.Size(194, 40)
        Me.Btn_Entrar.TabIndex = 4
        Me.Btn_Entrar.Text = "&ENTRAR"
        Me.Btn_Entrar.UseVisualStyleBackColor = False
        '
        'Txt_Contrasena
        '
        Me.Txt_Contrasena.BackColor = System.Drawing.Color.DimGray
        Me.Txt_Contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contrasena.Location = New System.Drawing.Point(292, 167)
        Me.Txt_Contrasena.MaxLength = 20
        Me.Txt_Contrasena.Name = "Txt_Contrasena"
        Me.Txt_Contrasena.Size = New System.Drawing.Size(441, 19)
        Me.Txt_Contrasena.TabIndex = 3
        Me.Txt_Contrasena.Text = "CONTRASEÑA"
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.BackColor = System.Drawing.Color.DimGray
        Me.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Usuario.Location = New System.Drawing.Point(287, 77)
        Me.Txt_Usuario.MaxLength = 10
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(441, 19)
        Me.Txt_Usuario.TabIndex = 2
        Me.Txt_Usuario.Text = "USUARIO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 301)
        Me.Panel1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 278)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 23)
        Me.Button3.TabIndex = 14
<<<<<<< HEAD
        Me.Button3.Text = "Versión 1.1.08 (BETA)"
=======
        Me.Button3.Text = "Versión 1.2.00 (BETA)"
>>>>>>> master
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Retail_shop_icon
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 301)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 288
        Me.LineShape1.X2 = 728
        Me.LineShape1.Y1 = 99
        Me.LineShape1.Y2 = 99
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(774, 301)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 292
        Me.LineShape2.X2 = 732
        Me.LineShape2.Y1 = 189
        Me.LineShape2.Y2 = 189
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Lbl_fecha)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Lbl_FechaLogin)
        Me.Panel2.Controls.Add(Me.Lbl_HoraLogin)
        Me.Panel2.Controls.Add(Me.Lbl_hora)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(246, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 47)
        Me.Panel2.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "&2 CAJERO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lbl_fecha
        '
        Me.Lbl_fecha.AutoSize = True
        Me.Lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_fecha.ForeColor = System.Drawing.Color.Black
        Me.Lbl_fecha.Location = New System.Drawing.Point(398, 26)
        Me.Lbl_fecha.Name = "Lbl_fecha"
        Me.Lbl_fecha.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_fecha.TabIndex = 5
        Me.Lbl_fecha.Text = "Fecha:"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "&1 GERENTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lbl_FechaLogin
        '
        Me.Lbl_FechaLogin.AutoSize = True
        Me.Lbl_FechaLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FechaLogin.ForeColor = System.Drawing.Color.Black
        Me.Lbl_FechaLogin.Location = New System.Drawing.Point(442, 26)
        Me.Lbl_FechaLogin.Name = "Lbl_FechaLogin"
        Me.Lbl_FechaLogin.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_FechaLogin.TabIndex = 8
        Me.Lbl_FechaLogin.Text = "fecha"
        '
        'Lbl_HoraLogin
        '
        Me.Lbl_HoraLogin.AutoSize = True
        Me.Lbl_HoraLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_HoraLogin.ForeColor = System.Drawing.Color.Black
        Me.Lbl_HoraLogin.Location = New System.Drawing.Point(454, 9)
        Me.Lbl_HoraLogin.Name = "Lbl_HoraLogin"
        Me.Lbl_HoraLogin.Size = New System.Drawing.Size(57, 13)
        Me.Lbl_HoraLogin.TabIndex = 7
        Me.Lbl_HoraLogin.Text = "00:00:00"
        '
        'Lbl_hora
        '
        Me.Lbl_hora.AutoSize = True
        Me.Lbl_hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_hora.ForeColor = System.Drawing.Color.Black
        Me.Lbl_hora.Location = New System.Drawing.Point(406, 9)
        Me.Lbl_hora.Name = "Lbl_hora"
        Me.Lbl_hora.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_hora.TabIndex = 6
        Me.Lbl_hora.Text = "Hora:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        '
        'TimerLogin
        '
        Me.TimerLogin.Enabled = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Salir.FlatAppearance.BorderSize = 0
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Location = New System.Drawing.Point(542, 247)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(194, 40)
        Me.Btn_Salir.TabIndex = 5
        Me.Btn_Salir.Text = "&SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(774, 301)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Ckt_Gerente)
        Me.Controls.Add(Me.Txt_Contrasena)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Btn_Entrar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIANDO"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Entrar As System.Windows.Forms.Button
    Friend WithEvents Txt_Contrasena As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Ckt_Gerente As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_HoraLogin As System.Windows.Forms.Label
    Friend WithEvents Lbl_FechaLogin As System.Windows.Forms.Label
    Friend WithEvents Lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TimerLogin As System.Windows.Forms.Timer
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
