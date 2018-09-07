<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TablasClientes
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
        Dim DNILabel As System.Windows.Forms.Label
        Dim Correo_ClienteLabel As System.Windows.Forms.Label
        Dim Telefono_ClienteLabel As System.Windows.Forms.Label
        Dim Domicilio_ClienteLabel As System.Windows.Forms.Label
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim Apellido_ClienteLabel As System.Windows.Forms.Label
        Dim Nombre_ClienteLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_Borrar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.Correo_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Domicilio_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        DNILabel = New System.Windows.Forms.Label()
        Correo_ClienteLabel = New System.Windows.Forms.Label()
        Telefono_ClienteLabel = New System.Windows.Forms.Label()
        Domicilio_ClienteLabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Apellido_ClienteLabel = New System.Windows.Forms.Label()
        Nombre_ClienteLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(201, 326)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 4
        DNILabel.Text = "DNI:"
        '
        'Correo_ClienteLabel
        '
        Correo_ClienteLabel.AutoSize = True
        Correo_ClienteLabel.Location = New System.Drawing.Point(201, 482)
        Correo_ClienteLabel.Name = "Correo_ClienteLabel"
        Correo_ClienteLabel.Size = New System.Drawing.Size(76, 13)
        Correo_ClienteLabel.TabIndex = 16
        Correo_ClienteLabel.Text = "Correo Cliente:"
        '
        'Telefono_ClienteLabel
        '
        Telefono_ClienteLabel.AutoSize = True
        Telefono_ClienteLabel.Location = New System.Drawing.Point(201, 456)
        Telefono_ClienteLabel.Name = "Telefono_ClienteLabel"
        Telefono_ClienteLabel.Size = New System.Drawing.Size(87, 13)
        Telefono_ClienteLabel.TabIndex = 14
        Telefono_ClienteLabel.Text = "Telefono Cliente:"
        '
        'Domicilio_ClienteLabel
        '
        Domicilio_ClienteLabel.AutoSize = True
        Domicilio_ClienteLabel.Location = New System.Drawing.Point(201, 430)
        Domicilio_ClienteLabel.Name = "Domicilio_ClienteLabel"
        Domicilio_ClienteLabel.Size = New System.Drawing.Size(87, 13)
        Domicilio_ClienteLabel.TabIndex = 12
        Domicilio_ClienteLabel.Text = "Domicilio Cliente:"
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(201, 404)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 10
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Apellido_ClienteLabel
        '
        Apellido_ClienteLabel.AutoSize = True
        Apellido_ClienteLabel.Location = New System.Drawing.Point(201, 378)
        Apellido_ClienteLabel.Name = "Apellido_ClienteLabel"
        Apellido_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Apellido_ClienteLabel.TabIndex = 8
        Apellido_ClienteLabel.Text = "Apellido Cliente:"
        '
        'Nombre_ClienteLabel
        '
        Nombre_ClienteLabel.AutoSize = True
        Nombre_ClienteLabel.Location = New System.Drawing.Point(201, 352)
        Nombre_ClienteLabel.Name = "Nombre_ClienteLabel"
        Nombre_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Nombre_ClienteLabel.TabIndex = 6
        Nombre_ClienteLabel.Text = "Nombre Cliente:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.AtrasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'AtrasToolStripMenuItem
        '
        Me.AtrasToolStripMenuItem.Name = "AtrasToolStripMenuItem"
        Me.AtrasToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.AtrasToolStripMenuItem.Text = "Atras"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(744, 289)
        Me.ClientesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre_Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido_Cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido_Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Domicilio_Cliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Domicilio_Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telefono_Cliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono_Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Correo_Cliente"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Correo_Cliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Txt_Borrar
        '
        Me.Txt_Borrar.Location = New System.Drawing.Point(41, 322)
        Me.Txt_Borrar.Name = "Txt_Borrar"
        Me.Txt_Borrar.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Borrar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dni"
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(294, 323)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNITextBox.TabIndex = 5
        '
        'Correo_ClienteTextBox
        '
        Me.Correo_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Correo_Cliente", True))
        Me.Correo_ClienteTextBox.Location = New System.Drawing.Point(294, 479)
        Me.Correo_ClienteTextBox.Name = "Correo_ClienteTextBox"
        Me.Correo_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Correo_ClienteTextBox.TabIndex = 17
        '
        'Telefono_ClienteTextBox
        '
        Me.Telefono_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telefono_Cliente", True))
        Me.Telefono_ClienteTextBox.Location = New System.Drawing.Point(294, 453)
        Me.Telefono_ClienteTextBox.Name = "Telefono_ClienteTextBox"
        Me.Telefono_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono_ClienteTextBox.TabIndex = 15
        '
        'Domicilio_ClienteTextBox
        '
        Me.Domicilio_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Domicilio_Cliente", True))
        Me.Domicilio_ClienteTextBox.Location = New System.Drawing.Point(294, 427)
        Me.Domicilio_ClienteTextBox.Name = "Domicilio_ClienteTextBox"
        Me.Domicilio_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Domicilio_ClienteTextBox.TabIndex = 13
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(294, 401)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 11
        '
        'Apellido_ClienteTextBox
        '
        Me.Apellido_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Apellido_Cliente", True))
        Me.Apellido_ClienteTextBox.Location = New System.Drawing.Point(294, 375)
        Me.Apellido_ClienteTextBox.Name = "Apellido_ClienteTextBox"
        Me.Apellido_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apellido_ClienteTextBox.TabIndex = 9
        '
        'Nombre_ClienteTextBox
        '
        Me.Nombre_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre_Cliente", True))
        Me.Nombre_ClienteTextBox.Location = New System.Drawing.Point(294, 349)
        Me.Nombre_ClienteTextBox.Name = "Nombre_ClienteTextBox"
        Me.Nombre_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_ClienteTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(512, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Guardado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TablasClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 553)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(Me.DNITextBox)
        Me.Controls.Add(Nombre_ClienteLabel)
        Me.Controls.Add(Me.Nombre_ClienteTextBox)
        Me.Controls.Add(Apellido_ClienteLabel)
        Me.Controls.Add(Me.Apellido_ClienteTextBox)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadTextBox)
        Me.Controls.Add(Domicilio_ClienteLabel)
        Me.Controls.Add(Me.Domicilio_ClienteTextBox)
        Me.Controls.Add(Telefono_ClienteLabel)
        Me.Controls.Add(Me.Telefono_ClienteTextBox)
        Me.Controls.Add(Correo_ClienteLabel)
        Me.Controls.Add(Me.Correo_ClienteTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Borrar)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TablasClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txt_Borrar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DNITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Domicilio_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
