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
        Dim StrockLabel As System.Windows.Forms.Label
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_de_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MayoristaBaseDeDatosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter()
        Me.Nombre_ProductoTextBox1 = New System.Windows.Forms.TextBox()
        Me.StrockTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        MarcaLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        StrockLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'StrockLabel
        '
        StrockLabel.AutoSize = True
        StrockLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StrockLabel.Location = New System.Drawing.Point(13, 80)
        StrockLabel.Name = "StrockLabel"
        StrockLabel.Size = New System.Drawing.Size(42, 14)
        StrockLabel.TabIndex = 17
        StrockLabel.Text = "Strock:"
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1035, 24)
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
        Me.TableAdapterManager.CategoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Compra_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.OperadorTableAdapter = Nothing
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Nombre, Me.Nombre_de_Producto, Me.Stock, Me.Precio_Unitario, Me.Descripcion, Me.Categoria, Me.Marca})
        Me.DataGridView1.DataSource = Me.MayoristaBaseDeDatosDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(292, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 74)
        Me.DataGridView1.TabIndex = 26
        '
        'ID_Nombre
        '
        Me.ID_Nombre.Frozen = True
        Me.ID_Nombre.HeaderText = "ID_Nombre"
        Me.ID_Nombre.Name = "ID_Nombre"
        '
        'Nombre_de_Producto
        '
        Me.Nombre_de_Producto.Frozen = True
        Me.Nombre_de_Producto.HeaderText = "Nombre de Producto"
        Me.Nombre_de_Producto.Name = "Nombre_de_Producto"
        '
        'Stock
        '
        Me.Stock.Frozen = True
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        '
        'Precio_Unitario
        '
        Me.Precio_Unitario.Frozen = True
        Me.Precio_Unitario.HeaderText = "Precio unitario"
        Me.Precio_Unitario.Name = "Precio_Unitario"
        '
        'Descripcion
        '
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Categoria
        '
        Me.Categoria.Frozen = True
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'MayoristaBaseDeDatosDataSetBindingSource
        '
        Me.MayoristaBaseDeDatosDataSetBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        Me.MayoristaBaseDeDatosDataSetBindingSource.Position = 0
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProductoDataGridView.Location = New System.Drawing.Point(292, 107)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(743, 237)
        Me.ProductoDataGridView.TabIndex = 26
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
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID_Categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID_Categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Nombre_Producto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre_Producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Strock"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Strock"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Precio_Unitario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio_Unitario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'MarcasBindingSource1
        '
        Me.MarcasBindingSource1.DataMember = "Marcas"
        Me.MarcasBindingSource1.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MarcaComboBox
        '
        Me.MarcaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource1, "Marca", True))
        Me.MarcaComboBox.DataSource = Me.MarcasBindingSource1
        Me.MarcaComboBox.DisplayMember = "Marca"
        Me.MarcaComboBox.FormattingEnabled = True
        Me.MarcaComboBox.Location = New System.Drawing.Point(119, 186)
        Me.MarcaComboBox.Name = "MarcaComboBox"
        Me.MarcaComboBox.Size = New System.Drawing.Size(121, 22)
        Me.MarcaComboBox.TabIndex = 40
        '
        'CategoriaBindingSource1
        '
        Me.CategoriaBindingSource1.DataMember = "Categoria"
        Me.CategoriaBindingSource1.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource1, "Categoria", True))
        Me.CategoriaComboBox.DataSource = Me.CategoriaBindingSource1
        Me.CategoriaComboBox.DisplayMember = "Categoria"
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(119, 158)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(121, 22)
        Me.CategoriaComboBox.TabIndex = 41
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'Nombre_ProductoTextBox1
        '
        Me.Nombre_ProductoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre_Producto", True))
        Me.Nombre_ProductoTextBox1.Location = New System.Drawing.Point(119, 50)
        Me.Nombre_ProductoTextBox1.Name = "Nombre_ProductoTextBox1"
        Me.Nombre_ProductoTextBox1.Size = New System.Drawing.Size(121, 21)
        Me.Nombre_ProductoTextBox1.TabIndex = 48
        '
        'StrockTextBox
        '
        Me.StrockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Strock", True))
        Me.StrockTextBox.Location = New System.Drawing.Point(119, 77)
        Me.StrockTextBox.Name = "StrockTextBox"
        Me.StrockTextBox.Size = New System.Drawing.Size(121, 21)
        Me.StrockTextBox.TabIndex = 50
        '
        'Precio_UnitarioTextBox
        '
        Me.Precio_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Precio_Unitario", True))
        Me.Precio_UnitarioTextBox.Location = New System.Drawing.Point(119, 104)
        Me.Precio_UnitarioTextBox.Name = "Precio_UnitarioTextBox"
        Me.Precio_UnitarioTextBox.Size = New System.Drawing.Size(121, 21)
        Me.Precio_UnitarioTextBox.TabIndex = 52
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(119, 131)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(121, 21)
        Me.DescripcionTextBox.TabIndex = 54
        '
        'Gerente_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1035, 368)
        Me.Controls.Add(Me.Nombre_ProductoTextBox1)
        Me.Controls.Add(Me.StrockTextBox)
        Me.Controls.Add(Me.Precio_UnitarioTextBox)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.CategoriaComboBox)
        Me.Controls.Add(Me.MarcaComboBox)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Nombre_ProductoLabel)
        Me.Controls.Add(StrockLabel)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MayoristaBaseDeDatosDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID_Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_de_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_Unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MarcaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents Nombre_ProductoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents StrockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_UnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
