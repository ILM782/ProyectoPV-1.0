<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Atributos_De_Cajero
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Hora = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_Volver = New System.Windows.Forms.Button()
        Me.Btn_Agregar_Cliente = New System.Windows.Forms.Button()
        Me.Btn_Porductos = New System.Windows.Forms.Button()
        Me.Btn_Transaccion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Lbl_Hora)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Lbl_Fecha)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 33)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cajero"
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.ForeColor = System.Drawing.Color.White
        Me.Lbl_Hora.Location = New System.Drawing.Point(491, 11)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_Hora.TabIndex = 9
        Me.Lbl_Hora.Text = "00:00:00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(462, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hora:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(368, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha:"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.ForeColor = System.Drawing.Color.White
        Me.Lbl_Fecha.Location = New System.Drawing.Point(407, 11)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Fecha.TabIndex = 7
        Me.Lbl_Fecha.Text = "Label2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.simbolo_seo_local
        Me.Button1.Location = New System.Drawing.Point(197, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 157)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Localidad"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.apertura_de_puerta_abierta1
        Me.Button2.Location = New System.Drawing.Point(382, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 157)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btn_Volver
        '
        Me.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Volver.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Volver.Image = Global.WindowsApplication1.My.Resources.Resources.flecha_atras
        Me.Btn_Volver.Location = New System.Drawing.Point(382, 46)
        Me.Btn_Volver.Name = "Btn_Volver"
        Me.Btn_Volver.Size = New System.Drawing.Size(167, 153)
        Me.Btn_Volver.TabIndex = 3
        Me.Btn_Volver.Text = "Volver"
        Me.Btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Volver.UseVisualStyleBackColor = True
        '
        'Btn_Agregar_Cliente
        '
        Me.Btn_Agregar_Cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Agregar_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Agregar_Cliente.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar_Cliente.Image = Global.WindowsApplication1.My.Resources.Resources.agregar_usuario
        Me.Btn_Agregar_Cliente.Location = New System.Drawing.Point(197, 46)
        Me.Btn_Agregar_Cliente.Name = "Btn_Agregar_Cliente"
        Me.Btn_Agregar_Cliente.Size = New System.Drawing.Size(167, 153)
        Me.Btn_Agregar_Cliente.TabIndex = 2
        Me.Btn_Agregar_Cliente.Text = "Agregar Cliente"
        Me.Btn_Agregar_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Agregar_Cliente.UseVisualStyleBackColor = False
        '
        'Btn_Porductos
        '
        Me.Btn_Porductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Porductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Porductos.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Porductos.Image = Global.WindowsApplication1.My.Resources.Resources.codigo_de_barras2
        Me.Btn_Porductos.Location = New System.Drawing.Point(11, 213)
        Me.Btn_Porductos.Name = "Btn_Porductos"
        Me.Btn_Porductos.Size = New System.Drawing.Size(166, 157)
        Me.Btn_Porductos.TabIndex = 1
        Me.Btn_Porductos.Text = "Productos"
        Me.Btn_Porductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Porductos.UseVisualStyleBackColor = False
        '
        'Btn_Transaccion
        '
        Me.Btn_Transaccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Transaccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Transaccion.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Transaccion.Image = Global.WindowsApplication1.My.Resources.Resources.png21
        Me.Btn_Transaccion.Location = New System.Drawing.Point(11, 46)
        Me.Btn_Transaccion.Name = "Btn_Transaccion"
        Me.Btn_Transaccion.Size = New System.Drawing.Size(166, 153)
        Me.Btn_Transaccion.TabIndex = 0
        Me.Btn_Transaccion.Text = "Transacciones"
        Me.Btn_Transaccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Transaccion.UseVisualStyleBackColor = False
        '
        'Atributos_De_Cajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(562, 382)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_Volver)
        Me.Controls.Add(Me.Btn_Agregar_Cliente)
        Me.Controls.Add(Me.Btn_Porductos)
        Me.Controls.Add(Me.Btn_Transaccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Atributos_De_Cajero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajero"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Transaccion As System.Windows.Forms.Button
    Friend WithEvents Btn_Porductos As System.Windows.Forms.Button
    Friend WithEvents Btn_Agregar_Cliente As System.Windows.Forms.Button
    Friend WithEvents Btn_Volver As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
