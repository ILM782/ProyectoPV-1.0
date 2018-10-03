<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajero_Agregar_Cliente
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
        Dim ID_ClienteLabel As System.Windows.Forms.Label
        Dim Nombre_ClienteLabel As System.Windows.Forms.Label
        Dim Apellido_ClienteLabel As System.Windows.Forms.Label
        Dim DNILabel As System.Windows.Forms.Label
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim Domicilio_ClienteLabel As System.Windows.Forms.Label
        Dim Telefono_ClienteLabel As System.Windows.Forms.Label
        Dim Correo_ClienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajero_Agregar_Cliente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TransaccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Guardar_Clientes = New System.Windows.Forms.Button()
        Me.ClienteTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.ID_ClienteLabel1 = New System.Windows.Forms.Label()
        Me.Nombre_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.DNITextBox = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadComboBox = New System.Windows.Forms.ComboBox()
        Me.Domicilio_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        Nombre_ClienteLabel = New System.Windows.Forms.Label()
        Apellido_ClienteLabel = New System.Windows.Forms.Label()
        DNILabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Domicilio_ClienteLabel = New System.Windows.Forms.Label()
        Telefono_ClienteLabel = New System.Windows.Forms.Label()
        Correo_ClienteLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaccionToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1198, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TransaccionToolStripMenuItem
        '
        Me.TransaccionToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransaccionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TransaccionToolStripMenuItem.Name = "TransaccionToolStripMenuItem"
        Me.TransaccionToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.TransaccionToolStripMenuItem.Text = "Transaccion"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalidadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolverToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1198, 47)
        Me.Panel1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 37)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Agregar Cliente"
        '
        'Btn_Guardar_Clientes
        '
        Me.Btn_Guardar_Clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Guardar_Clientes.FlatAppearance.BorderSize = 0
        Me.Btn_Guardar_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar_Clientes.Location = New System.Drawing.Point(46, 329)
        Me.Btn_Guardar_Clientes.Name = "Btn_Guardar_Clientes"
        Me.Btn_Guardar_Clientes.Size = New System.Drawing.Size(211, 40)
        Me.Btn_Guardar_Clientes.TabIndex = 18
        Me.Btn_Guardar_Clientes.Text = "&GUARDAR"
        Me.Btn_Guardar_Clientes.UseVisualStyleBackColor = False
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.Compra_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ventas_ClientesTableAdapter = Nothing
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Location = New System.Drawing.Point(26, 108)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(56, 13)
        ID_ClienteLabel.TabIndex = 18
        ID_ClienteLabel.Text = "ID Cliente:"
        '
        'ID_ClienteLabel1
        '
        Me.ID_ClienteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ID_Cliente", True))
        Me.ID_ClienteLabel1.Location = New System.Drawing.Point(119, 108)
        Me.ID_ClienteLabel1.Name = "ID_ClienteLabel1"
        Me.ID_ClienteLabel1.Size = New System.Drawing.Size(121, 23)
        Me.ID_ClienteLabel1.TabIndex = 19
        Me.ID_ClienteLabel1.Text = "Label1"
        '
        'Nombre_ClienteLabel
        '
        Nombre_ClienteLabel.AutoSize = True
        Nombre_ClienteLabel.Location = New System.Drawing.Point(26, 137)
        Nombre_ClienteLabel.Name = "Nombre_ClienteLabel"
        Nombre_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Nombre_ClienteLabel.TabIndex = 20
        Nombre_ClienteLabel.Text = "Nombre Cliente:"
        '
        'Nombre_ClienteTextBox
        '
        Me.Nombre_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre_Cliente", True))
        Me.Nombre_ClienteTextBox.Location = New System.Drawing.Point(119, 134)
        Me.Nombre_ClienteTextBox.Name = "Nombre_ClienteTextBox"
        Me.Nombre_ClienteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Nombre_ClienteTextBox.TabIndex = 21
        '
        'Apellido_ClienteLabel
        '
        Apellido_ClienteLabel.AutoSize = True
        Apellido_ClienteLabel.Location = New System.Drawing.Point(26, 163)
        Apellido_ClienteLabel.Name = "Apellido_ClienteLabel"
        Apellido_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Apellido_ClienteLabel.TabIndex = 22
        Apellido_ClienteLabel.Text = "Apellido Cliente:"
        '
        'Apellido_ClienteTextBox
        '
        Me.Apellido_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Apellido_Cliente", True))
        Me.Apellido_ClienteTextBox.Location = New System.Drawing.Point(119, 160)
        Me.Apellido_ClienteTextBox.Name = "Apellido_ClienteTextBox"
        Me.Apellido_ClienteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Apellido_ClienteTextBox.TabIndex = 23
        '
        'DNILabel
        '
        DNILabel.AutoSize = True
        DNILabel.Location = New System.Drawing.Point(26, 189)
        DNILabel.Name = "DNILabel"
        DNILabel.Size = New System.Drawing.Size(29, 13)
        DNILabel.TabIndex = 24
        DNILabel.Text = "DNI:"
        '
        'DNITextBox
        '
        Me.DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "DNI", True))
        Me.DNITextBox.Location = New System.Drawing.Point(119, 186)
        Me.DNITextBox.Name = "DNITextBox"
        Me.DNITextBox.Size = New System.Drawing.Size(121, 20)
        Me.DNITextBox.TabIndex = 25
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(26, 215)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 26
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'ID_LocalidadComboBox
        '
        Me.ID_LocalidadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadComboBox.FormattingEnabled = True
        Me.ID_LocalidadComboBox.Location = New System.Drawing.Point(119, 212)
        Me.ID_LocalidadComboBox.Name = "ID_LocalidadComboBox"
        Me.ID_LocalidadComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ID_LocalidadComboBox.TabIndex = 27
        '
        'Domicilio_ClienteLabel
        '
        Domicilio_ClienteLabel.AutoSize = True
        Domicilio_ClienteLabel.Location = New System.Drawing.Point(26, 242)
        Domicilio_ClienteLabel.Name = "Domicilio_ClienteLabel"
        Domicilio_ClienteLabel.Size = New System.Drawing.Size(87, 13)
        Domicilio_ClienteLabel.TabIndex = 28
        Domicilio_ClienteLabel.Text = "Domicilio Cliente:"
        '
        'Domicilio_ClienteTextBox
        '
        Me.Domicilio_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Domicilio_Cliente", True))
        Me.Domicilio_ClienteTextBox.Location = New System.Drawing.Point(119, 239)
        Me.Domicilio_ClienteTextBox.Name = "Domicilio_ClienteTextBox"
        Me.Domicilio_ClienteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Domicilio_ClienteTextBox.TabIndex = 29
        '
        'Telefono_ClienteLabel
        '
        Telefono_ClienteLabel.AutoSize = True
        Telefono_ClienteLabel.Location = New System.Drawing.Point(26, 268)
        Telefono_ClienteLabel.Name = "Telefono_ClienteLabel"
        Telefono_ClienteLabel.Size = New System.Drawing.Size(87, 13)
        Telefono_ClienteLabel.TabIndex = 30
        Telefono_ClienteLabel.Text = "Telefono Cliente:"
        '
        'Telefono_ClienteTextBox
        '
        Me.Telefono_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telefono_Cliente", True))
        Me.Telefono_ClienteTextBox.Location = New System.Drawing.Point(119, 265)
        Me.Telefono_ClienteTextBox.Name = "Telefono_ClienteTextBox"
        Me.Telefono_ClienteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Telefono_ClienteTextBox.TabIndex = 31
        '
        'Correo_ClienteLabel
        '
        Correo_ClienteLabel.AutoSize = True
        Correo_ClienteLabel.Location = New System.Drawing.Point(26, 294)
        Correo_ClienteLabel.Name = "Correo_ClienteLabel"
        Correo_ClienteLabel.Size = New System.Drawing.Size(76, 13)
        Correo_ClienteLabel.TabIndex = 32
        Correo_ClienteLabel.Text = "Correo Cliente:"
        '
        'Correo_ClienteTextBox
        '
        Me.Correo_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Correo_Cliente", True))
        Me.Correo_ClienteTextBox.Location = New System.Drawing.Point(119, 291)
        Me.Correo_ClienteTextBox.Name = "Correo_ClienteTextBox"
        Me.Correo_ClienteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Correo_ClienteTextBox.TabIndex = 33
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(302, 108)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(845, 261)
        Me.ClienteDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Domicilio_Cliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Domicilio_Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Telefono_Cliente"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefono_Cliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Correo_Cliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Correo_Cliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Cajero_Agregar_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1198, 422)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(ID_ClienteLabel)
        Me.Controls.Add(Me.ID_ClienteLabel1)
        Me.Controls.Add(Nombre_ClienteLabel)
        Me.Controls.Add(Me.Nombre_ClienteTextBox)
        Me.Controls.Add(Apellido_ClienteLabel)
        Me.Controls.Add(Me.Apellido_ClienteTextBox)
        Me.Controls.Add(DNILabel)
        Me.Controls.Add(Me.DNITextBox)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadComboBox)
        Me.Controls.Add(Domicilio_ClienteLabel)
        Me.Controls.Add(Me.Domicilio_ClienteTextBox)
        Me.Controls.Add(Telefono_ClienteLabel)
        Me.Controls.Add(Me.Telefono_ClienteTextBox)
        Me.Controls.Add(Correo_ClienteLabel)
        Me.Controls.Add(Me.Correo_ClienteTextBox)
        Me.Controls.Add(Me.Btn_Guardar_Clientes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Cajero_Agregar_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIANDO / Agregar Cliente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TransaccionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Guardar_Clientes As System.Windows.Forms.Button
    Friend WithEvents ID_ClienteLabel1 As System.Windows.Forms.Label
    Friend WithEvents Nombre_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DNITextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LocalidadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Domicilio_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
