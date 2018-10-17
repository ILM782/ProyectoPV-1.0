<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Tabla_De_Cajeros
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
<<<<<<< HEAD
        Dim ID_CajeroLabel As System.Windows.Forms.Label
        Dim Nombre_CajeroLabel As System.Windows.Forms.Label
        Dim Apellido_CajeroLabel As System.Windows.Forms.Label
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim Domicilio_CajeroLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Correo_CajeroLabel As System.Windows.Forms.Label
        Dim DNI_CajeroLabel As System.Windows.Forms.Label
=======
>>>>>>> master
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
<<<<<<< HEAD
        Me.CajeroDataGridView = New System.Windows.Forms.DataGridView()
=======
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.CajeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajeroTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.CajeroDataGridView = New System.Windows.Forms.DataGridView()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter()
>>>>>>> master
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
<<<<<<< HEAD
        Me.CajeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CajeroTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajeroTableAdapter1 = New WindowsApplication1.FacturasVentaDataSetTableAdapters.CajeroTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.FacturasVentaDataSetTableAdapters.TableAdapterManager()
        Me.ID_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.CajeroBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasVentaDataSet = New WindowsApplication1.FacturasVentaDataSet()
        Me.Nombre_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Domicilio_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.DNI_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ID_CajeroTextBox1 = New System.Windows.Forms.TextBox()
        ID_CajeroLabel = New System.Windows.Forms.Label()
        Nombre_CajeroLabel = New System.Windows.Forms.Label()
        Apellido_CajeroLabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Domicilio_CajeroLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Correo_CajeroLabel = New System.Windows.Forms.Label()
        DNI_CajeroLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CajeroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasVentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Buscar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_CajeroLabel
        '
        ID_CajeroLabel.AutoSize = True
        ID_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_CajeroLabel.Location = New System.Drawing.Point(23, 465)
        ID_CajeroLabel.Name = "ID_CajeroLabel"
        ID_CajeroLabel.Size = New System.Drawing.Size(66, 17)
        ID_CajeroLabel.TabIndex = 61
        ID_CajeroLabel.Text = "ID Cajero:"
        '
        'Nombre_CajeroLabel
        '
        Nombre_CajeroLabel.AutoSize = True
        Nombre_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_CajeroLabel.Location = New System.Drawing.Point(23, 491)
        Nombre_CajeroLabel.Name = "Nombre_CajeroLabel"
        Nombre_CajeroLabel.Size = New System.Drawing.Size(102, 17)
        Nombre_CajeroLabel.TabIndex = 63
        Nombre_CajeroLabel.Text = "Nombre Cajero:"
        '
        'Apellido_CajeroLabel
        '
        Apellido_CajeroLabel.AutoSize = True
        Apellido_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Apellido_CajeroLabel.Location = New System.Drawing.Point(237, 465)
        Apellido_CajeroLabel.Name = "Apellido_CajeroLabel"
        Apellido_CajeroLabel.Size = New System.Drawing.Size(101, 17)
        Apellido_CajeroLabel.TabIndex = 65
        Apellido_CajeroLabel.Text = "Apellido Cajero:"
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_LocalidadLabel.Location = New System.Drawing.Point(237, 491)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(84, 17)
        ID_LocalidadLabel.TabIndex = 67
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Domicilio_CajeroLabel
        '
        Domicilio_CajeroLabel.AutoSize = True
        Domicilio_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Domicilio_CajeroLabel.Location = New System.Drawing.Point(450, 465)
        Domicilio_CajeroLabel.Name = "Domicilio_CajeroLabel"
        Domicilio_CajeroLabel.Size = New System.Drawing.Size(107, 17)
        Domicilio_CajeroLabel.TabIndex = 69
        Domicilio_CajeroLabel.Text = "Domicilio Cajero:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(450, 491)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(62, 17)
        TelefonoLabel.TabIndex = 71
        TelefonoLabel.Text = "Telefono:"
        '
        'Correo_CajeroLabel
        '
        Correo_CajeroLabel.AutoSize = True
        Correo_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo_CajeroLabel.Location = New System.Drawing.Point(669, 463)
        Correo_CajeroLabel.Name = "Correo_CajeroLabel"
        Correo_CajeroLabel.Size = New System.Drawing.Size(94, 17)
        Correo_CajeroLabel.TabIndex = 73
        Correo_CajeroLabel.Text = "Correo Cajero:"
        '
        'DNI_CajeroLabel
        '
        DNI_CajeroLabel.AutoSize = True
        DNI_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DNI_CajeroLabel.Location = New System.Drawing.Point(669, 491)
        DNI_CajeroLabel.Name = "DNI_CajeroLabel"
        DNI_CajeroLabel.Size = New System.Drawing.Size(76, 17)
        DNI_CajeroLabel.TabIndex = 75
        DNI_CajeroLabel.Text = "DNI Cajero:"
        '
=======
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
>>>>>>> master
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(918, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 60)
        Me.Panel1.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 42)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cajeros"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(918, 10)
        Me.Panel2.TabIndex = 57
        '
<<<<<<< HEAD
=======
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CajeroBindingSource
        '
        Me.CajeroBindingSource.DataMember = "Cajero"
        Me.CajeroBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'CajeroTableAdapter
        '
        Me.CajeroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Me.CajeroTableAdapter
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Me.LocalidadTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
>>>>>>> master
        'CajeroDataGridView
        '
        Me.CajeroDataGridView.AllowUserToDeleteRows = False
        Me.CajeroDataGridView.AutoGenerateColumns = False
<<<<<<< HEAD
        Me.CajeroDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CajeroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajeroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CajeroDataGridView.DataSource = Me.CajeroBindingSource
        Me.CajeroDataGridView.GridColor = System.Drawing.Color.Black
=======
        Me.CajeroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajeroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CajeroDataGridView.DataSource = Me.CajeroBindingSource
>>>>>>> master
        Me.CajeroDataGridView.Location = New System.Drawing.Point(28, 100)
        Me.CajeroDataGridView.Name = "CajeroDataGridView"
        Me.CajeroDataGridView.ReadOnly = True
        Me.CajeroDataGridView.Size = New System.Drawing.Size(844, 220)
        Me.CajeroDataGridView.TabIndex = 58
        '
<<<<<<< HEAD
=======
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
>>>>>>> master
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Cajero"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Cajero"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DNI_Cajero"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DNI_Cajero"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Cajero"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre_Cajero"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido_Cajero"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido_Cajero"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Domicilio_Cajero"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Domicilio_Cajero"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Correo_Cajero"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Correo_Cajero"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
<<<<<<< HEAD
        'CajeroBindingSource
        '
        Me.CajeroBindingSource.DataMember = "Cajero"
        Me.CajeroBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(237, 370)
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Buscar.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Buscar:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(131, 368)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 61
        '
        'CajeroTableAdapter
        '
        Me.CajeroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Me.CajeroTableAdapter
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Me.LocalidadTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'CajeroTableAdapter1
        '
        Me.CajeroTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CajeroTableAdapter = Me.CajeroTableAdapter1
        Me.TableAdapterManager1.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager1.ClienteTableAdapter = Nothing
        Me.TableAdapterManager1.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager1.MarcasTableAdapter = Nothing
        Me.TableAdapterManager1.ProductoTableAdapter = Nothing
        Me.TableAdapterManager1.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.FacturasVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.VentaTableAdapter = Nothing
        '
        'ID_CajeroTextBox
        '
        Me.ID_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "ID_Cajero", True))
        Me.ID_CajeroTextBox.Enabled = False
        Me.ID_CajeroTextBox.Location = New System.Drawing.Point(131, 460)
        Me.ID_CajeroTextBox.Name = "ID_CajeroTextBox"
        Me.ID_CajeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_CajeroTextBox.TabIndex = 62
        '
        'CajeroBindingSource1
        '
        Me.CajeroBindingSource1.DataMember = "Cajero"
        Me.CajeroBindingSource1.DataSource = Me.FacturasVentaDataSet
        '
        'FacturasVentaDataSet
        '
        Me.FacturasVentaDataSet.DataSetName = "FacturasVentaDataSet"
        Me.FacturasVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nombre_CajeroTextBox
        '
        Me.Nombre_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Nombre_Cajero", True))
        Me.Nombre_CajeroTextBox.Location = New System.Drawing.Point(131, 488)
        Me.Nombre_CajeroTextBox.Name = "Nombre_CajeroTextBox"
        Me.Nombre_CajeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_CajeroTextBox.TabIndex = 64
        '
        'Apellido_CajeroTextBox
        '
        Me.Apellido_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Apellido_Cajero", True))
        Me.Apellido_CajeroTextBox.Location = New System.Drawing.Point(344, 462)
        Me.Apellido_CajeroTextBox.Name = "Apellido_CajeroTextBox"
        Me.Apellido_CajeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apellido_CajeroTextBox.TabIndex = 66
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(344, 488)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 68
        '
        'Domicilio_CajeroTextBox
        '
        Me.Domicilio_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Domicilio_Cajero", True))
        Me.Domicilio_CajeroTextBox.Location = New System.Drawing.Point(563, 464)
        Me.Domicilio_CajeroTextBox.Name = "Domicilio_CajeroTextBox"
        Me.Domicilio_CajeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Domicilio_CajeroTextBox.TabIndex = 70
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(551, 77)
        Me.TelefonoTextBox.Multiline = True
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 72
        '
        'Correo_CajeroTextBox
        '
        Me.Correo_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Correo_Cajero", True))
        Me.Correo_CajeroTextBox.Location = New System.Drawing.Point(769, 462)
        Me.Correo_CajeroTextBox.Name = "Correo_CajeroTextBox"
        Me.Correo_CajeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Correo_CajeroTextBox.TabIndex = 74
        '
        'DNI_CajeroTextBox
        '
        Me.DNI_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "DNI_Cajero", True))
        Me.DNI_CajeroTextBox.Location = New System.Drawing.Point(769, 488)
        Me.DNI_CajeroTextBox.Name = "DNI_CajeroTextBox"
        Me.DNI_CajeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DNI_CajeroTextBox.TabIndex = 76
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Modificar.FlatAppearance.BorderSize = 0
        Me.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Location = New System.Drawing.Point(661, 534)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(211, 40)
        Me.Btn_Modificar.TabIndex = 77
        Me.Btn_Modificar.Text = "&MODIFICAR"
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Seleecione ID:"
        '
        'Buscar
        '
        Me.Buscar.Controls.Add(Me.Label1)
        Me.Buscar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Location = New System.Drawing.Point(12, 346)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(337, 59)
        Me.Buscar.TabIndex = 80
        Me.Buscar.TabStop = False
        Me.Buscar.Text = "Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ID_CajeroTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 411)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 117)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar Datos"
        '
        'ID_CajeroTextBox1
        '
        Me.ID_CajeroTextBox1.Location = New System.Drawing.Point(119, 17)
        Me.ID_CajeroTextBox1.Multiline = True
        Me.ID_CajeroTextBox1.Name = "ID_CajeroTextBox1"
        Me.ID_CajeroTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ID_CajeroTextBox1.TabIndex = 79
=======
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 355)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 59
>>>>>>> master
        '
        'Gerente_Tabla_De_Cajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(918, 611)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(ID_CajeroLabel)
        Me.Controls.Add(Me.ID_CajeroTextBox)
        Me.Controls.Add(Nombre_CajeroLabel)
        Me.Controls.Add(Me.Nombre_CajeroTextBox)
        Me.Controls.Add(Apellido_CajeroLabel)
        Me.Controls.Add(Me.Apellido_CajeroTextBox)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadTextBox)
        Me.Controls.Add(Domicilio_CajeroLabel)
        Me.Controls.Add(Me.Domicilio_CajeroTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Correo_CajeroLabel)
        Me.Controls.Add(Me.Correo_CajeroTextBox)
        Me.Controls.Add(DNI_CajeroLabel)
        Me.Controls.Add(Me.DNI_CajeroTextBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Txt_Buscar)
=======
        Me.ClientSize = New System.Drawing.Size(918, 478)
        Me.Controls.Add(Me.TextBox1)
>>>>>>> master
        Me.Controls.Add(Me.CajeroDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
<<<<<<< HEAD
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.GroupBox1)
=======
>>>>>>> master
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Gerente_Tabla_De_Cajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de Cajeros"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
<<<<<<< HEAD
        CType(Me.CajeroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasVentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Buscar.ResumeLayout(False)
        Me.Buscar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
=======
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> master
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents CajeroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajeroTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocalidadTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents CajeroDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
<<<<<<< HEAD
    Friend WithEvents Txt_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents FacturasVentaDataSet As WindowsApplication1.FacturasVentaDataSet
    Friend WithEvents CajeroBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CajeroTableAdapter1 As WindowsApplication1.FacturasVentaDataSetTableAdapters.CajeroTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.FacturasVentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Domicilio_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DNI_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ID_CajeroTextBox1 As System.Windows.Forms.TextBox
=======
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
>>>>>>> master
End Class
