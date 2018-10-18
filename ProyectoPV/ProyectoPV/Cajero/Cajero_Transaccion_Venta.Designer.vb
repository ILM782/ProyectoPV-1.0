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
        Dim ID_ClienteLabel As System.Windows.Forms.Label
        Dim ID_CajeroLabel As System.Windows.Forms.Label
        Dim NroFacturaLabel As System.Windows.Forms.Label
        Dim Cantidad_VentaLabel As System.Windows.Forms.Label
        Dim ID_ProductoLabel As System.Windows.Forms.Label
        Dim TipoDeFactura_VentaLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajero_Transaccion_Venta))
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TipoDeFactura_VentaComboBox = New System.Windows.Forms.ComboBox()
        Me.ID_CajeroComboBox = New System.Windows.Forms.ComboBox()
        Me.NroFacturaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_VentaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Btn_Vender = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.CajeroTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter()
        Me.ClienteTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter()
        Me.ProductoTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter()
        Me.VentaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.VentaTableAdapter()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaVistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaVistaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.VentaVistaTableAdapter()
        Me.VentaVistaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID_Prodcuto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        ID_CajeroLabel = New System.Windows.Forms.Label()
        NroFacturaLabel = New System.Windows.Forms.Label()
        Cantidad_VentaLabel = New System.Windows.Forms.Label()
        ID_ProductoLabel = New System.Windows.Forms.Label()
        TipoDeFactura_VentaLabel1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NroFacturaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaVistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaVistaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Location = New System.Drawing.Point(20, 135)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(62, 16)
        ID_ClienteLabel.TabIndex = 0
        ID_ClienteLabel.Text = "ID Cliente:"
        '
        'ID_CajeroLabel
        '
        ID_CajeroLabel.AutoSize = True
        ID_CajeroLabel.Location = New System.Drawing.Point(713, 7)
        ID_CajeroLabel.Name = "ID_CajeroLabel"
        ID_CajeroLabel.Size = New System.Drawing.Size(59, 16)
        ID_CajeroLabel.TabIndex = 2
        ID_CajeroLabel.Text = "ID Cajero:"
        '
        'NroFacturaLabel
        '
        NroFacturaLabel.AutoSize = True
        NroFacturaLabel.Location = New System.Drawing.Point(713, 34)
        NroFacturaLabel.Name = "NroFacturaLabel"
        NroFacturaLabel.Size = New System.Drawing.Size(73, 16)
        NroFacturaLabel.TabIndex = 4
        NroFacturaLabel.Text = "Nro Factura:"
        '
        'Cantidad_VentaLabel
        '
        Cantidad_VentaLabel.AutoSize = True
        Cantidad_VentaLabel.Location = New System.Drawing.Point(13, 292)
        Cantidad_VentaLabel.Name = "Cantidad_VentaLabel"
        Cantidad_VentaLabel.Size = New System.Drawing.Size(92, 16)
        Cantidad_VentaLabel.TabIndex = 6
        Cantidad_VentaLabel.Text = "Cantidad Venta:"
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.Location = New System.Drawing.Point(13, 263)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(74, 16)
        ID_ProductoLabel.TabIndex = 8
        ID_ProductoLabel.Text = "ID Producto:"
        '
        'TipoDeFactura_VentaLabel1
        '
        TipoDeFactura_VentaLabel1.AutoSize = True
        TipoDeFactura_VentaLabel1.Location = New System.Drawing.Point(226, 29)
        TipoDeFactura_VentaLabel1.Name = "TipoDeFactura_VentaLabel1"
        TipoDeFactura_VentaLabel1.Size = New System.Drawing.Size(127, 16)
        TipoDeFactura_VentaLabel1.TabIndex = 0
        TipoDeFactura_VentaLabel1.Text = "Tipo De Factura Venta:"
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.AgregarLocalidadToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1152, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1152, 10)
        Me.Panel2.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(TipoDeFactura_VentaLabel1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(ID_CajeroLabel)
        Me.Panel1.Controls.Add(Me.TipoDeFactura_VentaComboBox)
        Me.Panel1.Controls.Add(Me.ID_CajeroComboBox)
        Me.Panel1.Controls.Add(Me.NroFacturaNumericUpDown)
        Me.Panel1.Controls.Add(NroFacturaLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1152, 60)
        Me.Panel1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 42)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Venta"
        '
        'TipoDeFactura_VentaComboBox
        '
        Me.TipoDeFactura_VentaComboBox.FormattingEnabled = True
        Me.TipoDeFactura_VentaComboBox.Location = New System.Drawing.Point(359, 26)
        Me.TipoDeFactura_VentaComboBox.Name = "TipoDeFactura_VentaComboBox"
        Me.TipoDeFactura_VentaComboBox.Size = New System.Drawing.Size(121, 24)
        Me.TipoDeFactura_VentaComboBox.TabIndex = 1
        '
        'ID_CajeroComboBox
        '
        Me.ID_CajeroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "ID_Cajero", True))
        Me.ID_CajeroComboBox.DataSource = Me.CajeroBindingSource
        Me.ID_CajeroComboBox.DisplayMember = "ID_Cajero"
        Me.ID_CajeroComboBox.FormattingEnabled = True
        Me.ID_CajeroComboBox.Location = New System.Drawing.Point(846, 4)
        Me.ID_CajeroComboBox.Name = "ID_CajeroComboBox"
        Me.ID_CajeroComboBox.Size = New System.Drawing.Size(200, 24)
        Me.ID_CajeroComboBox.TabIndex = 3
        Me.ID_CajeroComboBox.ValueMember = "ID_Cajero"
        '
        'NroFacturaNumericUpDown
        '
        Me.NroFacturaNumericUpDown.Location = New System.Drawing.Point(846, 34)
        Me.NroFacturaNumericUpDown.Name = "NroFacturaNumericUpDown"
        Me.NroFacturaNumericUpDown.Size = New System.Drawing.Size(200, 23)
        Me.NroFacturaNumericUpDown.TabIndex = 5
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Buscar.FlatAppearance.BorderSize = 0
        Me.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Location = New System.Drawing.Point(88, 174)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(208, 40)
        Me.Btn_Buscar.TabIndex = 73
        Me.Btn_Buscar.Text = "&Buscar Cliente"
        Me.Btn_Buscar.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1152, 579)
        Me.ShapeContainer1.TabIndex = 74
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 13
        Me.LineShape1.X2 = 296
        Me.LineShape1.Y1 = 232
        Me.LineShape1.Y2 = 234
        '
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(88, 132)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ID_ClienteTextBox.TabIndex = 1
        '
        'Cantidad_VentaTextBox
        '
        Me.Cantidad_VentaTextBox.Location = New System.Drawing.Point(111, 289)
        Me.Cantidad_VentaTextBox.Name = "Cantidad_VentaTextBox"
        Me.Cantidad_VentaTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Cantidad_VentaTextBox.TabIndex = 7
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(111, 260)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ID_ProductoTextBox.TabIndex = 9
        '
        'Btn_Vender
        '
        Me.Btn_Vender.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Vender.FlatAppearance.BorderSize = 0
        Me.Btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Vender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Vender.Location = New System.Drawing.Point(3, 318)
        Me.Btn_Vender.Name = "Btn_Vender"
        Me.Btn_Vender.Size = New System.Drawing.Size(181, 40)
        Me.Btn_Vender.TabIndex = 76
        Me.Btn_Vender.Text = "AÑADIR A GRILLA"
        Me.Btn_Vender.UseVisualStyleBackColor = False
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Imprimir.FlatAppearance.BorderSize = 0
        Me.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.Location = New System.Drawing.Point(28, 408)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(208, 40)
        Me.Btn_Imprimir.TabIndex = 77
        Me.Btn_Imprimir.Text = "IMPRIMIR"
        Me.Btn_Imprimir.UseVisualStyleBackColor = False
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(359, 111)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(743, 103)
        Me.ProductoDataGridView.TabIndex = 0
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
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Me.CajeroTableAdapter
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        Me.TableAdapterManager.VentaVistaTableAdapter = Nothing
        '
        'CajeroTableAdapter
        '
        Me.CajeroTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'CajeroBindingSource
        '
        Me.CajeroBindingSource.DataMember = "Cajero"
        Me.CajeroBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'VentaVistaBindingSource
        '
        Me.VentaVistaBindingSource.DataMember = "VentaVista"
        Me.VentaVistaBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'VentaVistaTableAdapter
        '
        Me.VentaVistaTableAdapter.ClearBeforeFill = True
        '
        'VentaVistaDataGridView
        '
        Me.VentaVistaDataGridView.AutoGenerateColumns = False
        Me.VentaVistaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaVistaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.VentaVistaDataGridView.DataSource = Me.VentaVistaBindingSource
        Me.VentaVistaDataGridView.Location = New System.Drawing.Point(359, 250)
        Me.VentaVistaDataGridView.Name = "VentaVistaDataGridView"
        Me.VentaVistaDataGridView.Size = New System.Drawing.Size(644, 126)
        Me.VentaVistaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID_Producto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID_Producto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nombre_Producto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre_Producto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Descripcion_Producto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Descripcion_Producto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Cantidad_Venta"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Cantidad_Venta"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Precio_Unitario"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Precio_Unitario"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(190, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 40)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "TERMINAR "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Prodcuto, Me.Nombre_Producto, Me.Descripcion, Me.Precio_unitario, Me.Cantidad})
        Me.DataGridView1.Location = New System.Drawing.Point(389, 408)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(545, 150)
        Me.DataGridView1.TabIndex = 81
        '
        'ID_Prodcuto
        '
        Me.ID_Prodcuto.HeaderText = "ID_Prodcuto"
        Me.ID_Prodcuto.Name = "ID_Prodcuto"
        Me.ID_Prodcuto.ReadOnly = True
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.HeaderText = "Nombre Producto"
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Precio_unitario
        '
        Me.Precio_unitario.HeaderText = "Precio"
        Me.Precio_unitario.Name = "Precio_unitario"
        Me.Precio_unitario.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Cajero_Transaccion_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1152, 579)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.VentaVistaDataGridView)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.Btn_Vender)
        Me.Controls.Add(ID_ClienteLabel)
        Me.Controls.Add(Me.ID_ClienteTextBox)
        Me.Controls.Add(Cantidad_VentaLabel)
        Me.Controls.Add(Me.Cantidad_VentaTextBox)
        Me.Controls.Add(ID_ProductoLabel)
        Me.Controls.Add(Me.ID_ProductoTextBox)
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Cajero_Transaccion_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIANDO / Venta"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NroFacturaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaVistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaVistaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AgregarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarLocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajeroTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter
    Friend WithEvents CajeroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TipoDeFactura_VentaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_CajeroComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NroFacturaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad_VentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Vender As System.Windows.Forms.Button
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents ProductoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaVistaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentaVistaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.VentaVistaTableAdapter
    Friend WithEvents VentaVistaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID_Prodcuto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
