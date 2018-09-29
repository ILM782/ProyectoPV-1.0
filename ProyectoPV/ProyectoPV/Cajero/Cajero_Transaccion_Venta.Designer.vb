<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajero_Transaccion_Venta
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
        Dim ID_OperadorLabel As System.Windows.Forms.Label
        Dim ID_ProductoLabel As System.Windows.Forms.Label
        Dim ID_ClienteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ItemsLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim Tipo_De_FacturacionLabel As System.Windows.Forms.Label
        Dim ID_MarcaLabel As System.Windows.Forms.Label
        Dim ID_CategoriaLabel As System.Windows.Forms.Label
        Dim Nombre_ProductoLabel As System.Windows.Forms.Label
        Dim StrockLabel As System.Windows.Forms.Label
        Dim Precio_UnitarioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ID_CategoriaLabel1 As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim ID_MarcaLabel1 As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ventas_ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ventas_ClientesTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.Ventas_ClientesTableAdapter()
        Me.ID_OperadorTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ItemsTextBox = New System.Windows.Forms.TextBox()
        Me.MontoTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_De_FacturacionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter()
        Me.ID_MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.StrockTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter()
        Me.ID_CategoriaTextBox1 = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.ID_MarcaTextBox1 = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.Txt_Categoria = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        ID_OperadorLabel = New System.Windows.Forms.Label()
        ID_ProductoLabel = New System.Windows.Forms.Label()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ItemsLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        Tipo_De_FacturacionLabel = New System.Windows.Forms.Label()
        ID_MarcaLabel = New System.Windows.Forms.Label()
        ID_CategoriaLabel = New System.Windows.Forms.Label()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        StrockLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ID_CategoriaLabel1 = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        ID_MarcaLabel1 = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Ventas_ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_OperadorLabel
        '
        ID_OperadorLabel.AutoSize = True
        ID_OperadorLabel.Location = New System.Drawing.Point(14, 101)
        ID_OperadorLabel.Name = "ID_OperadorLabel"
        ID_OperadorLabel.Size = New System.Drawing.Size(75, 16)
        ID_OperadorLabel.TabIndex = 3
        ID_OperadorLabel.Text = "ID Operador:"
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.Location = New System.Drawing.Point(14, 133)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(74, 16)
        ID_ProductoLabel.TabIndex = 5
        ID_ProductoLabel.Text = "ID Producto:"
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Location = New System.Drawing.Point(261, 101)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(62, 16)
        ID_ClienteLabel.TabIndex = 7
        ID_ClienteLabel.Text = "ID Cliente:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(859, 101)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(42, 16)
        FechaLabel.TabIndex = 9
        FechaLabel.Text = "Fecha:"
        '
        'ItemsLabel
        '
        ItemsLabel.AutoSize = True
        ItemsLabel.Location = New System.Drawing.Point(261, 133)
        ItemsLabel.Name = "ItemsLabel"
        ItemsLabel.Size = New System.Drawing.Size(40, 16)
        ItemsLabel.TabIndex = 11
        ItemsLabel.Text = "Items:"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(505, 101)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(47, 16)
        MontoLabel.TabIndex = 13
        MontoLabel.Text = "Monto:"
        '
        'Tipo_De_FacturacionLabel
        '
        Tipo_De_FacturacionLabel.AutoSize = True
        Tipo_De_FacturacionLabel.Location = New System.Drawing.Point(505, 133)
        Tipo_De_FacturacionLabel.Name = "Tipo_De_FacturacionLabel"
        Tipo_De_FacturacionLabel.Size = New System.Drawing.Size(117, 16)
        Tipo_De_FacturacionLabel.TabIndex = 15
        Tipo_De_FacturacionLabel.Text = "Tipo De Facturacion:"
        '
        'ID_MarcaLabel
        '
        ID_MarcaLabel.AutoSize = True
        ID_MarcaLabel.Location = New System.Drawing.Point(14, 241)
        ID_MarcaLabel.Name = "ID_MarcaLabel"
        ID_MarcaLabel.Size = New System.Drawing.Size(58, 16)
        ID_MarcaLabel.TabIndex = 2
        ID_MarcaLabel.Text = "ID Marca:"
        '
        'ID_CategoriaLabel
        '
        ID_CategoriaLabel.AutoSize = True
        ID_CategoriaLabel.Location = New System.Drawing.Point(261, 241)
        ID_CategoriaLabel.Name = "ID_CategoriaLabel"
        ID_CategoriaLabel.Size = New System.Drawing.Size(59, 16)
        ID_CategoriaLabel.TabIndex = 4
        ID_CategoriaLabel.Text = "Categoria"
        '
        'Nombre_ProductoLabel
        '
        Nombre_ProductoLabel.AutoSize = True
        Nombre_ProductoLabel.Location = New System.Drawing.Point(261, 273)
        Nombre_ProductoLabel.Name = "Nombre_ProductoLabel"
        Nombre_ProductoLabel.Size = New System.Drawing.Size(107, 16)
        Nombre_ProductoLabel.TabIndex = 6
        Nombre_ProductoLabel.Text = "Nombre Producto:"
        '
        'StrockLabel
        '
        StrockLabel.AutoSize = True
        StrockLabel.Location = New System.Drawing.Point(505, 241)
        StrockLabel.Name = "StrockLabel"
        StrockLabel.Size = New System.Drawing.Size(44, 16)
        StrockLabel.TabIndex = 8
        StrockLabel.Text = "Strock:"
        '
        'Precio_UnitarioLabel
        '
        Precio_UnitarioLabel.AutoSize = True
        Precio_UnitarioLabel.Location = New System.Drawing.Point(505, 273)
        Precio_UnitarioLabel.Name = "Precio_UnitarioLabel"
        Precio_UnitarioLabel.Size = New System.Drawing.Size(89, 16)
        Precio_UnitarioLabel.TabIndex = 10
        Precio_UnitarioLabel.Text = "Precio Unitario:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(13, 337)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(73, 16)
        DescripcionLabel.TabIndex = 12
        DescripcionLabel.Text = "Descripcion:"
        '
        'ID_CategoriaLabel1
        '
        ID_CategoriaLabel1.AutoSize = True
        ID_CategoriaLabel1.Location = New System.Drawing.Point(13, 273)
        ID_CategoriaLabel1.Name = "ID_CategoriaLabel1"
        ID_CategoriaLabel1.Size = New System.Drawing.Size(76, 16)
        ID_CategoriaLabel1.TabIndex = 0
        ID_CategoriaLabel1.Text = "ID Categoria:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(13, 305)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(62, 16)
        CategoriaLabel.TabIndex = 2
        CategoriaLabel.Text = "Categoria:"
        '
        'ID_MarcaLabel1
        '
        ID_MarcaLabel1.AutoSize = True
        ID_MarcaLabel1.Location = New System.Drawing.Point(261, 305)
        ID_MarcaLabel1.Name = "ID_MarcaLabel1"
        ID_MarcaLabel1.Size = New System.Drawing.Size(58, 16)
        ID_MarcaLabel1.TabIndex = 4
        ID_MarcaLabel1.Text = "ID Marca:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(261, 337)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(44, 16)
        MarcaLabel.TabIndex = 6
        MarcaLabel.Text = "Marca:"
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
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
        Me.TableAdapterManager.OperadorTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ventas_ClientesTableAdapter = Nothing
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.AgregarLocalidadToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1147, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar Cliente"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'AgregarLocalidadToolStripMenuItem
        '
        Me.AgregarLocalidadToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarLocalidadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarLocalidadToolStripMenuItem.Name = "AgregarLocalidadToolStripMenuItem"
        Me.AgregarLocalidadToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AgregarLocalidadToolStripMenuItem.Text = "Localidad"
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
        'Ventas_ClientesBindingSource
        '
        Me.Ventas_ClientesBindingSource.DataMember = "Ventas_Clientes"
        Me.Ventas_ClientesBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'Ventas_ClientesTableAdapter
        '
        Me.Ventas_ClientesTableAdapter.ClearBeforeFill = True
        '
        'ID_OperadorTextBox
        '
        Me.ID_OperadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "ID_Operador", True))
        Me.ID_OperadorTextBox.Location = New System.Drawing.Point(100, 92)
        Me.ID_OperadorTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ID_OperadorTextBox.Name = "ID_OperadorTextBox"
        Me.ID_OperadorTextBox.Size = New System.Drawing.Size(149, 23)
        Me.ID_OperadorTextBox.TabIndex = 4
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "ID_Producto", True))
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(100, 124)
        Me.ID_ProductoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(149, 23)
        Me.ID_ProductoTextBox.TabIndex = 6
        '
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "ID_Cliente", True))
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(334, 92)
        Me.ID_ClienteTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(149, 23)
        Me.ID_ClienteTextBox.TabIndex = 8
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ventas_ClientesBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(862, 121)
        Me.FechaDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(149, 23)
        Me.FechaDateTimePicker.TabIndex = 10
        '
        'ItemsTextBox
        '
        Me.ItemsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "Items", True))
        Me.ItemsTextBox.Location = New System.Drawing.Point(334, 124)
        Me.ItemsTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItemsTextBox.Name = "ItemsTextBox"
        Me.ItemsTextBox.Size = New System.Drawing.Size(149, 23)
        Me.ItemsTextBox.TabIndex = 12
        '
        'MontoTextBox
        '
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "Monto", True))
        Me.MontoTextBox.Location = New System.Drawing.Point(637, 92)
        Me.MontoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(149, 23)
        Me.MontoTextBox.TabIndex = 14
        '
        'Tipo_De_FacturacionTextBox
        '
        Me.Tipo_De_FacturacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "Tipo_De_Facturacion", True))
        Me.Tipo_De_FacturacionTextBox.Location = New System.Drawing.Point(637, 124)
        Me.Tipo_De_FacturacionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tipo_De_FacturacionTextBox.Name = "Tipo_De_FacturacionTextBox"
        Me.Tipo_De_FacturacionTextBox.Size = New System.Drawing.Size(149, 23)
        Me.Tipo_De_FacturacionTextBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 26)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Datos de Transaccion"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1147, 524)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 7
        Me.LineShape2.X2 = 878
        Me.LineShape2.Y1 = 173
        Me.LineShape2.Y2 = 173
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 217
        Me.LineShape1.X2 = 1094
        Me.LineShape1.Y1 = 22
        Me.LineShape1.Y2 = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 26)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Datos de Producto"
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
        'ID_MarcaTextBox
        '
        Me.ID_MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ID_Marca", True))
        Me.ID_MarcaTextBox.Location = New System.Drawing.Point(129, 238)
        Me.ID_MarcaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ID_MarcaTextBox.Name = "ID_MarcaTextBox"
        Me.ID_MarcaTextBox.Size = New System.Drawing.Size(116, 23)
        Me.ID_MarcaTextBox.TabIndex = 3
        '
        'Nombre_ProductoTextBox
        '
        Me.Nombre_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre_Producto", True))
        Me.Nombre_ProductoTextBox.Location = New System.Drawing.Point(377, 270)
        Me.Nombre_ProductoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Nombre_ProductoTextBox.Name = "Nombre_ProductoTextBox"
        Me.Nombre_ProductoTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Nombre_ProductoTextBox.TabIndex = 7
        '
        'StrockTextBox
        '
        Me.StrockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Strock", True))
        Me.StrockTextBox.Location = New System.Drawing.Point(621, 238)
        Me.StrockTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StrockTextBox.Name = "StrockTextBox"
        Me.StrockTextBox.Size = New System.Drawing.Size(116, 23)
        Me.StrockTextBox.TabIndex = 9
        '
        'Precio_UnitarioTextBox
        '
        Me.Precio_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Precio_Unitario", True))
        Me.Precio_UnitarioTextBox.Location = New System.Drawing.Point(621, 270)
        Me.Precio_UnitarioTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Precio_UnitarioTextBox.Name = "Precio_UnitarioTextBox"
        Me.Precio_UnitarioTextBox.Size = New System.Drawing.Size(116, 23)
        Me.Precio_UnitarioTextBox.TabIndex = 11
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(128, 334)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(116, 23)
        Me.DescripcionTextBox.TabIndex = 13
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'ID_CategoriaTextBox1
        '
        Me.ID_CategoriaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "ID_Categoria", True))
        Me.ID_CategoriaTextBox1.Location = New System.Drawing.Point(129, 270)
        Me.ID_CategoriaTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ID_CategoriaTextBox1.Name = "ID_CategoriaTextBox1"
        Me.ID_CategoriaTextBox1.Size = New System.Drawing.Size(116, 23)
        Me.ID_CategoriaTextBox1.TabIndex = 1
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "Categoria", True))
        Me.CategoriaTextBox.Location = New System.Drawing.Point(129, 302)
        Me.CategoriaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(116, 23)
        Me.CategoriaTextBox.TabIndex = 3
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'ID_MarcaTextBox1
        '
        Me.ID_MarcaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "ID_Marca", True))
        Me.ID_MarcaTextBox1.Location = New System.Drawing.Point(377, 302)
        Me.ID_MarcaTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ID_MarcaTextBox1.Name = "ID_MarcaTextBox1"
        Me.ID_MarcaTextBox1.Size = New System.Drawing.Size(116, 23)
        Me.ID_MarcaTextBox1.TabIndex = 5
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(377, 334)
        Me.MarcaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(116, 23)
        Me.MarcaTextBox.TabIndex = 7
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Location = New System.Drawing.Point(862, 352)
        Me.Btn_Finalizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(87, 28)
        Me.Btn_Finalizar.TabIndex = 20
        Me.Btn_Finalizar.Text = "Finalizar "
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
        '
        'Txt_Categoria
        '
        Me.Txt_Categoria.Location = New System.Drawing.Point(377, 238)
        Me.Txt_Categoria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Categoria.Name = "Txt_Categoria"
        Me.Txt_Categoria.Size = New System.Drawing.Size(116, 23)
        Me.Txt_Categoria.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1147, 40)
        Me.Panel1.TabIndex = 22
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1147, 40)
        Me.ShapeContainer2.TabIndex = 18
        Me.ShapeContainer2.TabStop = False
        '
        'Cajero_Transaccion_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1147, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txt_Categoria)
        Me.Controls.Add(Me.Btn_Finalizar)
        Me.Controls.Add(ID_MarcaLabel1)
        Me.Controls.Add(Me.ID_MarcaTextBox1)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(ID_CategoriaLabel1)
        Me.Controls.Add(Me.ID_CategoriaTextBox1)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(ID_MarcaLabel)
        Me.Controls.Add(Me.ID_MarcaTextBox)
        Me.Controls.Add(ID_CategoriaLabel)
        Me.Controls.Add(Nombre_ProductoLabel)
        Me.Controls.Add(Me.Nombre_ProductoTextBox)
        Me.Controls.Add(StrockLabel)
        Me.Controls.Add(Me.StrockTextBox)
        Me.Controls.Add(Precio_UnitarioLabel)
        Me.Controls.Add(Me.Precio_UnitarioTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(ID_OperadorLabel)
        Me.Controls.Add(Me.ID_OperadorTextBox)
        Me.Controls.Add(ID_ProductoLabel)
        Me.Controls.Add(Me.ID_ProductoTextBox)
        Me.Controls.Add(ID_ClienteLabel)
        Me.Controls.Add(Me.ID_ClienteTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(ItemsLabel)
        Me.Controls.Add(Me.ItemsTextBox)
        Me.Controls.Add(MontoLabel)
        Me.Controls.Add(Me.MontoTextBox)
        Me.Controls.Add(Tipo_De_FacturacionLabel)
        Me.Controls.Add(Me.Tipo_De_FacturacionTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Cajero_Transaccion_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaccion"
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Ventas_ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarLocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ventas_ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ventas_ClientesTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.Ventas_ClientesTableAdapter
    Friend WithEvents ID_OperadorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ItemsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MontoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tipo_De_FacturacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents ID_MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_UnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents ID_CategoriaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents ID_MarcaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
    Friend WithEvents Txt_Categoria As System.Windows.Forms.TextBox
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
