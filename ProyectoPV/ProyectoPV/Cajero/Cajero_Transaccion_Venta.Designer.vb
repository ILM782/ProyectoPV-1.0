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
<<<<<<< HEAD
        Dim TipoDeFacturacion_VentaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajero_Transaccion_Venta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Fecha_VentaLabel As System.Windows.Forms.Label
=======
        Dim TipoDeFactura_VentaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajero_Transaccion_Venta))
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
        Me.Btn_Finalizar = New System.Windows.Forms.Button()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
<<<<<<< HEAD
=======
        Me.ID_CajeroComboBox = New System.Windows.Forms.ComboBox()
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.NroFacturaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TipoDeFactura_VentaComboBox = New System.Windows.Forms.ComboBox()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.CajeroTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter()
        Me.ClienteTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter()
        Me.ProductoTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter()
        Me.VentaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.VentaTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.VentaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VentaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Cantidad_VentaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Btn_Vender = New System.Windows.Forms.Button()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
<<<<<<< HEAD
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroTransaccion_VentaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Unidades_VentaNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Fecha_VentaDateTimePicker = New System.Windows.Forms.DateTimePicker()
=======
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
        ID_ClienteLabel = New System.Windows.Forms.Label()
        ID_CajeroLabel = New System.Windows.Forms.Label()
        NroFacturaLabel = New System.Windows.Forms.Label()
        Cantidad_VentaLabel = New System.Windows.Forms.Label()
        ID_ProductoLabel = New System.Windows.Forms.Label()
<<<<<<< HEAD
        TipoDeFacturacion_VentaLabel = New System.Windows.Forms.Label()
        Fecha_VentaLabel = New System.Windows.Forms.Label()
=======
        TipoDeFactura_VentaLabel = New System.Windows.Forms.Label()
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NroFacturaNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VentaBindingNavigator.SuspendLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Location = New System.Drawing.Point(33, 130)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(62, 16)
        ID_ClienteLabel.TabIndex = 0
        ID_ClienteLabel.Text = "ID Cliente:"
        '
        'ID_CajeroLabel
        '
        ID_CajeroLabel.AutoSize = True
        ID_CajeroLabel.Location = New System.Drawing.Point(524, 28)
        ID_CajeroLabel.Name = "ID_CajeroLabel"
        ID_CajeroLabel.Size = New System.Drawing.Size(59, 16)
        ID_CajeroLabel.TabIndex = 2
        ID_CajeroLabel.Text = "ID Cajero:"
        '
        'NroFacturaLabel
        '
        NroFacturaLabel.AutoSize = True
        NroFacturaLabel.Location = New System.Drawing.Point(819, 28)
        NroFacturaLabel.Name = "NroFacturaLabel"
        NroFacturaLabel.Size = New System.Drawing.Size(73, 16)
        NroFacturaLabel.TabIndex = 4
        NroFacturaLabel.Text = "Nro Factura:"
        '
        'Cantidad_VentaLabel
        '
        Cantidad_VentaLabel.AutoSize = True
        Cantidad_VentaLabel.Location = New System.Drawing.Point(15, 332)
        Cantidad_VentaLabel.Name = "Cantidad_VentaLabel"
        Cantidad_VentaLabel.Size = New System.Drawing.Size(92, 16)
        Cantidad_VentaLabel.TabIndex = 6
        Cantidad_VentaLabel.Text = "Cantidad Venta:"
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.Location = New System.Drawing.Point(33, 288)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(74, 16)
        ID_ProductoLabel.TabIndex = 8
        ID_ProductoLabel.Text = "ID Producto:"
        '
<<<<<<< HEAD
        'TipoDeFacturacion_VentaLabel
        '
        TipoDeFacturacion_VentaLabel.AutoSize = True
        TipoDeFacturacion_VentaLabel.Location = New System.Drawing.Point(165, 27)
        TipoDeFacturacion_VentaLabel.Name = "TipoDeFacturacion_VentaLabel"
        TipoDeFacturacion_VentaLabel.Size = New System.Drawing.Size(117, 16)
        TipoDeFacturacion_VentaLabel.TabIndex = 70
        TipoDeFacturacion_VentaLabel.Text = "Tipo De Facturacion:"
=======
        'TipoDeFactura_VentaLabel
        '
        TipoDeFactura_VentaLabel.AutoSize = True
        TipoDeFactura_VentaLabel.Location = New System.Drawing.Point(174, 28)
        TipoDeFactura_VentaLabel.Name = "TipoDeFactura_VentaLabel"
        TipoDeFactura_VentaLabel.Size = New System.Drawing.Size(127, 16)
        TipoDeFactura_VentaLabel.TabIndex = 12
        TipoDeFactura_VentaLabel.Text = "Tipo De Factura Venta:"
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
        '
        'Btn_Finalizar
        '
        Me.Btn_Finalizar.Location = New System.Drawing.Point(1040, 626)
        Me.Btn_Finalizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Finalizar.Name = "Btn_Finalizar"
        Me.Btn_Finalizar.Size = New System.Drawing.Size(87, 28)
        Me.Btn_Finalizar.TabIndex = 20
        Me.Btn_Finalizar.Text = "Finalizar "
        Me.Btn_Finalizar.UseVisualStyleBackColor = True
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1157, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1157, 10)
        Me.Panel2.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ID_CajeroComboBox)
        Me.Panel1.Controls.Add(NroFacturaLabel)
        Me.Panel1.Controls.Add(ID_CajeroLabel)
        Me.Panel1.Controls.Add(Me.NroFacturaNumericUpDown)
        Me.Panel1.Controls.Add(Me.TipoDeFactura_VentaComboBox)
        Me.Panel1.Controls.Add(TipoDeFactura_VentaLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 60)
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
<<<<<<< HEAD
=======
        'ID_CajeroComboBox
        '
        Me.ID_CajeroComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "ID_Cajero", True))
        Me.ID_CajeroComboBox.FormattingEnabled = True
        Me.ID_CajeroComboBox.Location = New System.Drawing.Point(589, 20)
        Me.ID_CajeroComboBox.Name = "ID_CajeroComboBox"
        Me.ID_CajeroComboBox.Size = New System.Drawing.Size(200, 24)
        Me.ID_CajeroComboBox.TabIndex = 3
        '
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NroFacturaNumericUpDown
        '
        Me.NroFacturaNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentaBindingSource, "NroFactura", True))
        Me.NroFacturaNumericUpDown.Location = New System.Drawing.Point(898, 21)
        Me.NroFacturaNumericUpDown.Name = "NroFacturaNumericUpDown"
        Me.NroFacturaNumericUpDown.Size = New System.Drawing.Size(200, 23)
        Me.NroFacturaNumericUpDown.TabIndex = 5
        '
        'TipoDeFactura_VentaComboBox
        '
        Me.TipoDeFactura_VentaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "TipoDeFactura_Venta", True))
        Me.TipoDeFactura_VentaComboBox.FormattingEnabled = True
        Me.TipoDeFactura_VentaComboBox.Location = New System.Drawing.Point(307, 20)
        Me.TipoDeFactura_VentaComboBox.Name = "TipoDeFactura_VentaComboBox"
        Me.TipoDeFactura_VentaComboBox.Size = New System.Drawing.Size(200, 24)
        Me.TipoDeFactura_VentaComboBox.TabIndex = 13
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
        Me.TableAdapterManager.VentaTableAdapter = Me.VentaTableAdapter
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(357, 368)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(745, 241)
        Me.DataGridView1.TabIndex = 58
        '
        'Column1
        '
        Me.Column1.HeaderText = "Producto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 400
        '
        'Column2
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1157, 676)
        Me.ShapeContainer1.TabIndex = 74
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 26
        Me.LineShape1.X2 = 334
        Me.LineShape1.Y1 = 246
        Me.LineShape1.Y2 = 248
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Buscar.FlatAppearance.BorderSize = 0
        Me.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Location = New System.Drawing.Point(105, 174)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(208, 40)
        Me.Btn_Buscar.TabIndex = 73
        Me.Btn_Buscar.Text = "&Buscar Cliente"
        Me.Btn_Buscar.UseVisualStyleBackColor = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'VentaBindingNavigatorSaveItem
        '
        Me.VentaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VentaBindingNavigatorSaveItem.Image = CType(resources.GetObject("VentaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VentaBindingNavigatorSaveItem.Name = "VentaBindingNavigatorSaveItem"
        Me.VentaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VentaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VentaBindingNavigator
        '
<<<<<<< HEAD
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 269)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(741, 241)
        Me.DataGridView1.TabIndex = 58
=======
        Me.VentaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VentaBindingNavigator.BindingSource = Me.VentaBindingSource
        Me.VentaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VentaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VentaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.VentaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VentaBindingNavigatorSaveItem})
        Me.VentaBindingNavigator.Location = New System.Drawing.Point(36, 434)
        Me.VentaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VentaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VentaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VentaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VentaBindingNavigator.Name = "VentaBindingNavigator"
        Me.VentaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VentaBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.VentaBindingNavigator.TabIndex = 57
        Me.VentaBindingNavigator.Text = "BindingNavigator1"
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
        '
        'Column1
        '
        Me.Column1.HeaderText = "Producto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 400
        '
        'Column2
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "ID_Cliente", True))
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(113, 126)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ID_ClienteTextBox.TabIndex = 1
        '
        'Cantidad_VentaTextBox
        '
        Me.Cantidad_VentaTextBox.Location = New System.Drawing.Point(113, 329)
        Me.Cantidad_VentaTextBox.Name = "Cantidad_VentaTextBox"
        Me.Cantidad_VentaTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Cantidad_VentaTextBox.TabIndex = 7
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(113, 281)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ID_ProductoTextBox.TabIndex = 9
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(357, 115)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(741, 220)
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
<<<<<<< HEAD
        'Fecha_VentaLabel
        '
        Fecha_VentaLabel.AutoSize = True
        Fecha_VentaLabel.Location = New System.Drawing.Point(732, 29)
        Fecha_VentaLabel.Name = "Fecha_VentaLabel"
        Fecha_VentaLabel.Size = New System.Drawing.Size(75, 16)
        Fecha_VentaLabel.TabIndex = 68
        Fecha_VentaLabel.Text = "Fecha Venta:"
        '
        'Fecha_VentaDateTimePicker
        '
        Me.Fecha_VentaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentaBindingSource, "Fecha_Venta", True))
        Me.Fecha_VentaDateTimePicker.Location = New System.Drawing.Point(813, 22)
        Me.Fecha_VentaDateTimePicker.Name = "Fecha_VentaDateTimePicker"
        Me.Fecha_VentaDateTimePicker.Size = New System.Drawing.Size(212, 23)
        Me.Fecha_VentaDateTimePicker.TabIndex = 69
=======
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
        'Btn_Vender
        '
        Me.Btn_Vender.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Vender.FlatAppearance.BorderSize = 0
        Me.Btn_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Vender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Vender.Location = New System.Drawing.Point(105, 368)
        Me.Btn_Vender.Name = "Btn_Vender"
        Me.Btn_Vender.Size = New System.Drawing.Size(208, 40)
        Me.Btn_Vender.TabIndex = 75
        Me.Btn_Vender.Text = "VENDER"
        Me.Btn_Vender.UseVisualStyleBackColor = False
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
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Imprimir.FlatAppearance.BorderSize = 0
        Me.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.Location = New System.Drawing.Point(105, 485)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(208, 40)
        Me.Btn_Imprimir.TabIndex = 76
        Me.Btn_Imprimir.Text = "IMPRIMIR"
        Me.Btn_Imprimir.UseVisualStyleBackColor = False
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
        '
        'Cajero_Transaccion_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1157, 676)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.Btn_Vender)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(ID_ClienteLabel)
        Me.Controls.Add(Me.ID_ClienteTextBox)
        Me.Controls.Add(Cantidad_VentaLabel)
        Me.Controls.Add(Me.Cantidad_VentaTextBox)
        Me.Controls.Add(ID_ProductoLabel)
        Me.Controls.Add(Me.ID_ProductoTextBox)
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.VentaBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Finalizar)
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
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NroFacturaNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VentaBindingNavigator.ResumeLayout(False)
        Me.VentaBindingNavigator.PerformLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Finalizar As System.Windows.Forms.Button
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
<<<<<<< HEAD
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumeroTransaccion_VentaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoDeFacturacion_VentaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
=======
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
<<<<<<< HEAD
    Friend WithEvents Fecha_VentaDateTimePicker As System.Windows.Forms.DateTimePicker
=======
    Friend WithEvents ID_CajeroComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NroFacturaNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TipoDeFactura_VentaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VentaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VentaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VentaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad_VentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_Vender As System.Windows.Forms.Button
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.Button
>>>>>>> 58891744eabb18e695d258c4872131b7406ceedc
End Class
