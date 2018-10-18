<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Tablas_Producto
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
        Dim ID_ProductoLabel As System.Windows.Forms.Label
        Dim ID_MarcaLabel As System.Windows.Forms.Label
        Dim ID_CategoriaLabel As System.Windows.Forms.Label
        Dim Nombre_ProductoLabel As System.Windows.Forms.Label
        Dim StrockLabel As System.Windows.Forms.Label
        Dim Precio_UnitarioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Tablas_Producto))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProductoTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.CategoriaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter()
        Me.MarcasTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ID_MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ID_CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.StrockTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ID_ProductoLabel = New System.Windows.Forms.Label()
        ID_MarcaLabel = New System.Windows.Forms.Label()
        ID_CategoriaLabel = New System.Windows.Forms.Label()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        StrockLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcasToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 65)
        Me.Panel1.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 42)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = " Productos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 11)
        Me.Panel2.TabIndex = 58
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        Me.TableAdapterManager.VentaVistaTableAdapter = Nothing
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MarcasToolStripMenuItem
        '
        Me.MarcasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem"
        Me.MarcasToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.MarcasToolStripMenuItem.Text = "Marcas"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AllowUserToDeleteRows = False
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.GridColor = System.Drawing.Color.Black
        Me.ProductoDataGridView.Location = New System.Drawing.Point(19, 120)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.ReadOnly = True
        Me.ProductoDataGridView.Size = New System.Drawing.Size(743, 220)
        Me.ProductoDataGridView.TabIndex = 58
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_ProductoLabel.Location = New System.Drawing.Point(6, 34)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(81, 17)
        ID_ProductoLabel.TabIndex = 58
        ID_ProductoLabel.Text = "ID Producto:"
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ID_Producto", True))
        Me.ID_ProductoTextBox.Enabled = False
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(124, 33)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ID_ProductoTextBox.TabIndex = 59
        '
        'ID_MarcaLabel
        '
        ID_MarcaLabel.AutoSize = True
        ID_MarcaLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_MarcaLabel.Location = New System.Drawing.Point(6, 60)
        ID_MarcaLabel.Name = "ID_MarcaLabel"
        ID_MarcaLabel.Size = New System.Drawing.Size(65, 17)
        ID_MarcaLabel.TabIndex = 60
        ID_MarcaLabel.Text = "ID Marca:"
        '
        'ID_MarcaTextBox
        '
        Me.ID_MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ID_Marca", True))
        Me.ID_MarcaTextBox.Location = New System.Drawing.Point(124, 59)
        Me.ID_MarcaTextBox.Name = "ID_MarcaTextBox"
        Me.ID_MarcaTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ID_MarcaTextBox.TabIndex = 61
        '
        'ID_CategoriaLabel
        '
        ID_CategoriaLabel.AutoSize = True
        ID_CategoriaLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_CategoriaLabel.Location = New System.Drawing.Point(6, 87)
        ID_CategoriaLabel.Name = "ID_CategoriaLabel"
        ID_CategoriaLabel.Size = New System.Drawing.Size(85, 17)
        ID_CategoriaLabel.TabIndex = 62
        ID_CategoriaLabel.Text = "ID Categoria:"
        '
        'ID_CategoriaTextBox
        '
        Me.ID_CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ID_Categoria", True))
        Me.ID_CategoriaTextBox.Location = New System.Drawing.Point(124, 86)
        Me.ID_CategoriaTextBox.Name = "ID_CategoriaTextBox"
        Me.ID_CategoriaTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ID_CategoriaTextBox.TabIndex = 63
        '
        'Nombre_ProductoLabel
        '
        Nombre_ProductoLabel.AutoSize = True
        Nombre_ProductoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_ProductoLabel.Location = New System.Drawing.Point(230, 36)
        Nombre_ProductoLabel.Name = "Nombre_ProductoLabel"
        Nombre_ProductoLabel.Size = New System.Drawing.Size(117, 17)
        Nombre_ProductoLabel.TabIndex = 64
        Nombre_ProductoLabel.Text = "Nombre Producto:"
        '
        'Nombre_ProductoTextBox
        '
        Me.Nombre_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre_Producto", True))
        Me.Nombre_ProductoTextBox.Location = New System.Drawing.Point(348, 35)
        Me.Nombre_ProductoTextBox.Name = "Nombre_ProductoTextBox"
        Me.Nombre_ProductoTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Nombre_ProductoTextBox.TabIndex = 65
        '
        'StrockLabel
        '
        StrockLabel.AutoSize = True
        StrockLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StrockLabel.Location = New System.Drawing.Point(230, 62)
        StrockLabel.Name = "StrockLabel"
        StrockLabel.Size = New System.Drawing.Size(43, 17)
        StrockLabel.TabIndex = 66
        StrockLabel.Text = "Stock:"
        '
        'StrockTextBox
        '
        Me.StrockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Strock", True))
        Me.StrockTextBox.Location = New System.Drawing.Point(348, 61)
        Me.StrockTextBox.Name = "StrockTextBox"
        Me.StrockTextBox.Size = New System.Drawing.Size(100, 23)
        Me.StrockTextBox.TabIndex = 67
        '
        'Precio_UnitarioLabel
        '
        Precio_UnitarioLabel.AutoSize = True
        Precio_UnitarioLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Precio_UnitarioLabel.Location = New System.Drawing.Point(230, 89)
        Precio_UnitarioLabel.Name = "Precio_UnitarioLabel"
        Precio_UnitarioLabel.Size = New System.Drawing.Size(97, 17)
        Precio_UnitarioLabel.TabIndex = 68
        Precio_UnitarioLabel.Text = "Precio Unitario:"
        '
        'Precio_UnitarioTextBox
        '
        Me.Precio_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Precio_Unitario", True))
        Me.Precio_UnitarioTextBox.Location = New System.Drawing.Point(348, 88)
        Me.Precio_UnitarioTextBox.Name = "Precio_UnitarioTextBox"
        Me.Precio_UnitarioTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Precio_UnitarioTextBox.TabIndex = 69
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(454, 38)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(79, 17)
        DescripcionLabel.TabIndex = 70
        DescripcionLabel.Text = "Descripcion:"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(539, 36)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 23)
        Me.DescripcionTextBox.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 346)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 67)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(DescripcionLabel)
        Me.GroupBox2.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox2.Controls.Add(StrockLabel)
        Me.GroupBox2.Controls.Add(Me.StrockTextBox)
        Me.GroupBox2.Controls.Add(ID_CategoriaLabel)
        Me.GroupBox2.Controls.Add(Precio_UnitarioLabel)
        Me.GroupBox2.Controls.Add(Me.ID_CategoriaTextBox)
        Me.GroupBox2.Controls.Add(Me.Precio_UnitarioTextBox)
        Me.GroupBox2.Controls.Add(ID_ProductoLabel)
        Me.GroupBox2.Controls.Add(Nombre_ProductoLabel)
        Me.GroupBox2.Controls.Add(Me.ID_ProductoTextBox)
        Me.GroupBox2.Controls.Add(Me.Nombre_ProductoTextBox)
        Me.GroupBox2.Controls.Add(Me.ID_MarcaTextBox)
        Me.GroupBox2.Controls.Add(ID_MarcaLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 433)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 126)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificar Datos (Seleccione fila de tabla)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(204, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(562, 580)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 40)
        Me.Button3.TabIndex = 128
        Me.Button3.Text = "&ELIMINAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(430, 580)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 40)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "&MODIFICAR"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.DataGridViewTextBoxColumn5.HeaderText = "Stock"
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
        'Gerente_Tablas_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(782, 632)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Gerente_Tablas_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIO/Tabla de Producto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_UnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
