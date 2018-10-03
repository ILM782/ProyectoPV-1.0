<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Productos
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
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim Nombre_ProductoLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Precio_UnitarioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.CategoriaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter()
        Me.MarcasTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.MayoristaBaseDeDatosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter()
        Me.MayoristaBaseDeDatosDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.StrockTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        MarcaLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(13, 189)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(42, 14)
        MarcaLabel.TabIndex = 3
        MarcaLabel.Text = "Marca:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(12, 161)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(60, 14)
        CategoriaLabel.TabIndex = 7
        CategoriaLabel.Text = "Categoria:"
        '
        'Nombre_ProductoLabel
        '
        Nombre_ProductoLabel.AutoSize = True
        Nombre_ProductoLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_ProductoLabel.Location = New System.Drawing.Point(13, 53)
        Nombre_ProductoLabel.Name = "Nombre_ProductoLabel"
        Nombre_ProductoLabel.Size = New System.Drawing.Size(104, 14)
        Nombre_ProductoLabel.TabIndex = 15
        Nombre_ProductoLabel.Text = "Nombre Producto:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(13, 80)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 14)
        StockLabel.TabIndex = 17
        StockLabel.Text = "Stock:"
        '
        'Precio_UnitarioLabel
        '
        Precio_UnitarioLabel.AutoSize = True
        Precio_UnitarioLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Precio_UnitarioLabel.Location = New System.Drawing.Point(13, 107)
        Precio_UnitarioLabel.Name = "Precio_UnitarioLabel"
        Precio_UnitarioLabel.Size = New System.Drawing.Size(87, 14)
        Precio_UnitarioLabel.TabIndex = 19
        Precio_UnitarioLabel.Text = "Precio Unitario:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(13, 134)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(70, 14)
        DescripcionLabel.TabIndex = 21
        DescripcionLabel.Text = "Descripcion:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasRealizadasToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1055, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComprasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(151, 20)
        Me.ComprasToolStripMenuItem.Text = "Transaccion de Compras"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas Realizadas"
        '
        'ComprasRealizadasToolStripMenuItem
        '
        Me.ComprasRealizadasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ComprasRealizadasToolStripMenuItem.Name = "ComprasRealizadasToolStripMenuItem"
        Me.ComprasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.ComprasRealizadasToolStripMenuItem.Text = "Compras Realizadas"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.carpeta_simbolo_de_agregar
        Me.Button1.Location = New System.Drawing.Point(246, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 22)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.carpeta_simbolo_de_agregar
        Me.Button2.Location = New System.Drawing.Point(246, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 22)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(197, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 25)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Compra_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ventas_ClientesTableAdapter = Nothing
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MayoristaBaseDeDatosDataSetBindingSource
        '
        Me.MayoristaBaseDeDatosDataSetBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        Me.MayoristaBaseDeDatosDataSetBindingSource.Position = 0
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MarcasBindingSource1
        '
        Me.MarcasBindingSource1.DataMember = "Marcas"
        Me.MarcasBindingSource1.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'CategoriaBindingSource1
        '
        Me.CategoriaBindingSource1.DataMember = "Categoria"
        Me.CategoriaBindingSource1.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'MayoristaBaseDeDatosDataSetBindingSource1
        '
        Me.MayoristaBaseDeDatosDataSetBindingSource1.DataSource = Me.MayoristaBaseDeDatosDataSet
        Me.MayoristaBaseDeDatosDataSetBindingSource1.Position = 0
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AllowUserToDeleteRows = False
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(278, 30)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.ReadOnly = True
        Me.ProductoDataGridView.Size = New System.Drawing.Size(734, 220)
        Me.ProductoDataGridView.TabIndex = 54
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID_Marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID_Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID_Categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre_Producto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre_Producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Strock"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Strock"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Precio_Unitario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio_Unitario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Nombre_ProductoTextBox
        '
        Me.Nombre_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre_Producto", True))
        Me.Nombre_ProductoTextBox.Location = New System.Drawing.Point(124, 50)
        Me.Nombre_ProductoTextBox.Name = "Nombre_ProductoTextBox"
        Me.Nombre_ProductoTextBox.Size = New System.Drawing.Size(121, 21)
        Me.Nombre_ProductoTextBox.TabIndex = 67
        '
        'StrockTextBox
        '
        Me.StrockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Strock", True))
        Me.StrockTextBox.Location = New System.Drawing.Point(124, 77)
        Me.StrockTextBox.Name = "StrockTextBox"
        Me.StrockTextBox.Size = New System.Drawing.Size(121, 21)
        Me.StrockTextBox.TabIndex = 69
        '
        'Precio_UnitarioTextBox
        '
        Me.Precio_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Precio_Unitario", True))
        Me.Precio_UnitarioTextBox.Location = New System.Drawing.Point(124, 104)
        Me.Precio_UnitarioTextBox.Name = "Precio_UnitarioTextBox"
        Me.Precio_UnitarioTextBox.Size = New System.Drawing.Size(121, 21)
        Me.Precio_UnitarioTextBox.TabIndex = 71
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(124, 131)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(121, 21)
        Me.DescripcionTextBox.TabIndex = 73
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategoriaBindingSource1
        Me.ComboBox1.DisplayMember = "Categoria"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(124, 158)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 74
        Me.ComboBox1.ValueMember = "Categoria"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.MarcasBindingSource1
        Me.ComboBox2.DisplayMember = "Marca"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(124, 186)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox2.TabIndex = 75
        Me.ComboBox2.ValueMember = "ID_Marca"
        '
        'Gerente_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1055, 302)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Nombre_ProductoTextBox)
        Me.Controls.Add(Me.StrockTextBox)
        Me.Controls.Add(Me.Precio_UnitarioTextBox)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Nombre_ProductoLabel)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Precio_UnitarioLabel)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Gerente_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents MarcasTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents MayoristaBaseDeDatosDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayoristaBaseDeDatosDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_UnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
