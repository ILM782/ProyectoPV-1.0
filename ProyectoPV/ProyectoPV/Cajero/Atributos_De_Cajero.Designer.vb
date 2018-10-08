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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Atributos_De_Cajero))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Fecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Localidades = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Volver = New System.Windows.Forms.Button()
        Me.Btn_Agregar_Cliente = New System.Windows.Forms.Button()
        Me.Btn_Productos = New System.Windows.Forms.Button()
        Me.Btn_Transacciones = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Lbl_Fecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Lbl_Hora)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1226, 66)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1070, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 47)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cajero"
        '
        'Lbl_Fecha
        '
        Me.Lbl_Fecha.AutoSize = True
        Me.Lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fecha.ForeColor = System.Drawing.Color.White
        Me.Lbl_Fecha.Location = New System.Drawing.Point(1122, 32)
        Me.Lbl_Fecha.Name = "Lbl_Fecha"
        Me.Lbl_Fecha.Size = New System.Drawing.Size(46, 16)
        Me.Lbl_Fecha.TabIndex = 14
        Me.Lbl_Fecha.Text = "fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1079, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hora:"
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Hora.ForeColor = System.Drawing.Color.White
        Me.Lbl_Hora.Location = New System.Drawing.Point(1134, 15)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(72, 16)
        Me.Lbl_Hora.TabIndex = 13
        Me.Lbl_Hora.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Btn_Localidades)
        Me.Panel2.Controls.Add(Me.Btn_Salir)
        Me.Panel2.Controls.Add(Me.Btn_Volver)
        Me.Panel2.Controls.Add(Me.Btn_Agregar_Cliente)
        Me.Panel2.Controls.Add(Me.Btn_Productos)
        Me.Panel2.Controls.Add(Me.Btn_Transacciones)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1226, 513)
        Me.Panel2.TabIndex = 9
        '
        'Btn_Localidades
        '
        Me.Btn_Localidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Localidades.FlatAppearance.BorderSize = 0
        Me.Btn_Localidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Localidades.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Localidades.Image = Global.WindowsApplication1.My.Resources.Resources.simbolo_seo_local
        Me.Btn_Localidades.Location = New System.Drawing.Point(495, 265)
        Me.Btn_Localidades.Name = "Btn_Localidades"
        Me.Btn_Localidades.Size = New System.Drawing.Size(244, 201)
        Me.Btn_Localidades.TabIndex = 5
        Me.Btn_Localidades.Text = "Localidades"
        Me.Btn_Localidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Localidades.UseVisualStyleBackColor = False
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Salir.FlatAppearance.BorderSize = 0
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Image = Global.WindowsApplication1.My.Resources.Resources.apertura_de_puerta_abierta1
        Me.Btn_Salir.Location = New System.Drawing.Point(770, 265)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(244, 201)
        Me.Btn_Salir.TabIndex = 6
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'Btn_Volver
        '
        Me.Btn_Volver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Volver.FlatAppearance.BorderSize = 0
        Me.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Volver.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Volver.Image = Global.WindowsApplication1.My.Resources.Resources.flecha_atras
        Me.Btn_Volver.Location = New System.Drawing.Point(772, 40)
        Me.Btn_Volver.Name = "Btn_Volver"
        Me.Btn_Volver.Size = New System.Drawing.Size(244, 197)
        Me.Btn_Volver.TabIndex = 3
        Me.Btn_Volver.Text = "Volver"
        Me.Btn_Volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Volver.UseVisualStyleBackColor = False
        '
        'Btn_Agregar_Cliente
        '
        Me.Btn_Agregar_Cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Agregar_Cliente.FlatAppearance.BorderSize = 0
        Me.Btn_Agregar_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Agregar_Cliente.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Agregar_Cliente.Image = Global.WindowsApplication1.My.Resources.Resources.agregar_usuario
        Me.Btn_Agregar_Cliente.Location = New System.Drawing.Point(495, 40)
        Me.Btn_Agregar_Cliente.Name = "Btn_Agregar_Cliente"
        Me.Btn_Agregar_Cliente.Size = New System.Drawing.Size(244, 197)
        Me.Btn_Agregar_Cliente.TabIndex = 2
        Me.Btn_Agregar_Cliente.Text = "Agregar Cliente"
        Me.Btn_Agregar_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Agregar_Cliente.UseVisualStyleBackColor = False
        '
        'Btn_Productos
        '
        Me.Btn_Productos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Productos.FlatAppearance.BorderSize = 0
        Me.Btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Productos.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Productos.Image = Global.WindowsApplication1.My.Resources.Resources.codigo_de_barras2
        Me.Btn_Productos.Location = New System.Drawing.Point(223, 265)
        Me.Btn_Productos.Name = "Btn_Productos"
        Me.Btn_Productos.Size = New System.Drawing.Size(243, 201)
        Me.Btn_Productos.TabIndex = 4
        Me.Btn_Productos.Text = "Productos"
        Me.Btn_Productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Productos.UseVisualStyleBackColor = False
        '
        'Btn_Transacciones
        '
        Me.Btn_Transacciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Transacciones.FlatAppearance.BorderSize = 0
        Me.Btn_Transacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Transacciones.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Transacciones.Image = Global.WindowsApplication1.My.Resources.Resources.png21
        Me.Btn_Transacciones.Location = New System.Drawing.Point(223, 40)
        Me.Btn_Transacciones.Name = "Btn_Transacciones"
        Me.Btn_Transacciones.Size = New System.Drawing.Size(243, 197)
        Me.Btn_Transacciones.TabIndex = 1
        Me.Btn_Transacciones.Text = "Transacciones"
        Me.Btn_Transacciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Transacciones.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1226, 10)
        Me.Panel3.TabIndex = 58
        '
        'Atributos_De_Cajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1226, 579)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Atributos_De_Cajero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIANDO / Cajero"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Localidades As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Btn_Volver As System.Windows.Forms.Button
    Friend WithEvents Btn_Agregar_Cliente As System.Windows.Forms.Button
    Friend WithEvents Btn_Productos As System.Windows.Forms.Button
    Friend WithEvents Btn_Transacciones As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
