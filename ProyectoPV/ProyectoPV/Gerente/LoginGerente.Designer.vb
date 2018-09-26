<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginGerente
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Btn_Ingresar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Txt_Contraseña
        '
        Me.Txt_Contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contraseña.Location = New System.Drawing.Point(49, 104)
        Me.Txt_Contraseña.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Contraseña.Name = "Txt_Contraseña"
        Me.Txt_Contraseña.Size = New System.Drawing.Size(158, 20)
        Me.Txt_Contraseña.TabIndex = 2
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Location = New System.Drawing.Point(49, 52)
        Me.Txt_Usuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(158, 21)
        Me.Txt_Usuario.TabIndex = 1
        '
        'Btn_Ingresar
        '
        Me.Btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Ingresar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ingresar.Location = New System.Drawing.Point(26, 143)
        Me.Btn_Ingresar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.Size = New System.Drawing.Size(181, 26)
        Me.Btn_Ingresar.TabIndex = 3
        Me.Btn_Ingresar.Text = "Ingresar"
        Me.Btn_Ingresar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Txt_Contraseña)
        Me.Panel1.Controls.Add(Me.Txt_Usuario)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Btn_Ingresar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 186)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gerente"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.flecha_atras1
        Me.Button2.Location = New System.Drawing.Point(208, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 22)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.candado_cerrado
        Me.PictureBox2.Location = New System.Drawing.Point(26, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.usuario_hombre
        Me.PictureBox1.Location = New System.Drawing.Point(26, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LoginGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(258, 209)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "LoginGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Ingresar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
