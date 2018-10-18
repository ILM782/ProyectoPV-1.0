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
        Dim ID_CajeroLabel As System.Windows.Forms.Label
        Dim Nombre_CajeroLabel As System.Windows.Forms.Label
        Dim Apellido_CajeroLabel As System.Windows.Forms.Label
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim Domicilio_CajeroLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Correo_CajeroLabel As System.Windows.Forms.Label
        Dim DNI_CajeroLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Tabla_De_Cajeros))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.ID_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.CajeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.Nombre_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Domicilio_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.DNI_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajeroTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter()
        Me.CajeroTableAdapter1 = New WindowsApplication1.FacturasVentaDataSetTableAdapters.CajeroTableAdapter()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New WindowsApplication1.FacturasVentaDataSetTableAdapters.TableAdapterManager()
        Me.CajeroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajeroBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasVentaDataSet = New WindowsApplication1.FacturasVentaDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        ID_CajeroLabel = New System.Windows.Forms.Label()
        Nombre_CajeroLabel = New System.Windows.Forms.Label()
        Apellido_CajeroLabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Domicilio_CajeroLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Correo_CajeroLabel = New System.Windows.Forms.Label()
        DNI_CajeroLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Buscar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasVentaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_CajeroLabel
        '
        ID_CajeroLabel.AutoSize = True
        ID_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_CajeroLabel.Location = New System.Drawing.Point(6, 28)
        ID_CajeroLabel.Name = "ID_CajeroLabel"
        ID_CajeroLabel.Size = New System.Drawing.Size(66, 17)
        ID_CajeroLabel.TabIndex = 104
        ID_CajeroLabel.Text = "ID Cajero:"
        '
        'Nombre_CajeroLabel
        '
        Nombre_CajeroLabel.AutoSize = True
        Nombre_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_CajeroLabel.Location = New System.Drawing.Point(6, 54)
        Nombre_CajeroLabel.Name = "Nombre_CajeroLabel"
        Nombre_CajeroLabel.Size = New System.Drawing.Size(102, 17)
        Nombre_CajeroLabel.TabIndex = 106
        Nombre_CajeroLabel.Text = "Nombre Cajero:"
        '
        'Apellido_CajeroLabel
        '
        Apellido_CajeroLabel.AutoSize = True
        Apellido_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Apellido_CajeroLabel.Location = New System.Drawing.Point(220, 28)
        Apellido_CajeroLabel.Name = "Apellido_CajeroLabel"
        Apellido_CajeroLabel.Size = New System.Drawing.Size(101, 17)
        Apellido_CajeroLabel.TabIndex = 108
        Apellido_CajeroLabel.Text = "Apellido Cajero:"
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_LocalidadLabel.Location = New System.Drawing.Point(220, 54)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(84, 17)
        ID_LocalidadLabel.TabIndex = 110
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Domicilio_CajeroLabel
        '
        Domicilio_CajeroLabel.AutoSize = True
        Domicilio_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Domicilio_CajeroLabel.Location = New System.Drawing.Point(433, 28)
        Domicilio_CajeroLabel.Name = "Domicilio_CajeroLabel"
        Domicilio_CajeroLabel.Size = New System.Drawing.Size(107, 17)
        Domicilio_CajeroLabel.TabIndex = 112
        Domicilio_CajeroLabel.Text = "Domicilio Cajero:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(433, 54)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(62, 17)
        TelefonoLabel.TabIndex = 114
        TelefonoLabel.Text = "Telefono:"
        '
        'Correo_CajeroLabel
        '
        Correo_CajeroLabel.AutoSize = True
        Correo_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo_CajeroLabel.Location = New System.Drawing.Point(652, 26)
        Correo_CajeroLabel.Name = "Correo_CajeroLabel"
        Correo_CajeroLabel.Size = New System.Drawing.Size(94, 17)
        Correo_CajeroLabel.TabIndex = 115
        Correo_CajeroLabel.Text = "Correo Cajero:"
        '
        'DNI_CajeroLabel
        '
        DNI_CajeroLabel.AutoSize = True
        DNI_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DNI_CajeroLabel.Location = New System.Drawing.Point(652, 54)
        DNI_CajeroLabel.Name = "DNI_CajeroLabel"
        DNI_CajeroLabel.Size = New System.Drawing.Size(76, 17)
        DNI_CajeroLabel.TabIndex = 117
        DNI_CajeroLabel.Text = "DNI Cajero:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 60)
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
        Me.Panel2.Size = New System.Drawing.Size(941, 10)
        Me.Panel2.TabIndex = 57
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Modificar.FlatAppearance.BorderSize = 0
        Me.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Location = New System.Drawing.Point(633, 489)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(126, 40)
        Me.Btn_Modificar.TabIndex = 119
        Me.Btn_Modificar.Text = "&MODIFICAR"
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'ID_CajeroTextBox
        '
        Me.ID_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "ID_Cajero", True))
        Me.ID_CajeroTextBox.Enabled = False
        Me.ID_CajeroTextBox.Location = New System.Drawing.Point(114, 23)
        Me.ID_CajeroTextBox.Name = "ID_CajeroTextBox"
        Me.ID_CajeroTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ID_CajeroTextBox.TabIndex = 105
        '
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
        'Nombre_CajeroTextBox
        '
        Me.Nombre_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Nombre_Cajero", True))
        Me.Nombre_CajeroTextBox.Location = New System.Drawing.Point(114, 51)
        Me.Nombre_CajeroTextBox.Name = "Nombre_CajeroTextBox"
        Me.Nombre_CajeroTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Nombre_CajeroTextBox.TabIndex = 107
        '
        'Apellido_CajeroTextBox
        '
        Me.Apellido_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Apellido_Cajero", True))
        Me.Apellido_CajeroTextBox.Location = New System.Drawing.Point(327, 25)
        Me.Apellido_CajeroTextBox.Name = "Apellido_CajeroTextBox"
        Me.Apellido_CajeroTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Apellido_CajeroTextBox.TabIndex = 109
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(327, 51)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ID_LocalidadTextBox.TabIndex = 111
        '
        'Domicilio_CajeroTextBox
        '
        Me.Domicilio_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Domicilio_Cajero", True))
        Me.Domicilio_CajeroTextBox.Location = New System.Drawing.Point(546, 27)
        Me.Domicilio_CajeroTextBox.Name = "Domicilio_CajeroTextBox"
        Me.Domicilio_CajeroTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Domicilio_CajeroTextBox.TabIndex = 113
        '
        'Correo_CajeroTextBox
        '
        Me.Correo_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Correo_Cajero", True))
        Me.Correo_CajeroTextBox.Location = New System.Drawing.Point(752, 25)
        Me.Correo_CajeroTextBox.Name = "Correo_CajeroTextBox"
        Me.Correo_CajeroTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Correo_CajeroTextBox.TabIndex = 116
        '
        'DNI_CajeroTextBox
        '
        Me.DNI_CajeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "DNI_Cajero", True))
        Me.DNI_CajeroTextBox.Location = New System.Drawing.Point(752, 51)
        Me.DNI_CajeroTextBox.Name = "DNI_CajeroTextBox"
        Me.DNI_CajeroTextBox.Size = New System.Drawing.Size(100, 23)
        Me.DNI_CajeroTextBox.TabIndex = 118
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(150, 352)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 103
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(256, 354)
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Buscar.TabIndex = 102
        '
        'Buscar
        '
        Me.Buscar.Controls.Add(Me.Label1)
        Me.Buscar.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.Location = New System.Drawing.Point(31, 330)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(337, 59)
        Me.Buscar.TabIndex = 120
        Me.Buscar.TabStop = False
        Me.Buscar.Text = "Buscar"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(ID_CajeroLabel)
        Me.GroupBox1.Controls.Add(Me.DNI_CajeroTextBox)
        Me.GroupBox1.Controls.Add(Me.ID_CajeroTextBox)
        Me.GroupBox1.Controls.Add(DNI_CajeroLabel)
        Me.GroupBox1.Controls.Add(Nombre_CajeroLabel)
        Me.GroupBox1.Controls.Add(Me.Correo_CajeroTextBox)
        Me.GroupBox1.Controls.Add(Me.Nombre_CajeroTextBox)
        Me.GroupBox1.Controls.Add(Correo_CajeroLabel)
        Me.GroupBox1.Controls.Add(Apellido_CajeroLabel)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.Apellido_CajeroTextBox)
        Me.GroupBox1.Controls.Add(Me.Domicilio_CajeroTextBox)
        Me.GroupBox1.Controls.Add(ID_LocalidadLabel)
        Me.GroupBox1.Controls.Add(Domicilio_CajeroLabel)
        Me.GroupBox1.Controls.Add(Me.ID_LocalidadTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 394)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 89)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar Datos (Seleccione fila de la tabla)"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CajeroBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(546, 56)
        Me.TelefonoTextBox.Multiline = True
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 72
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalidadToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalidadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
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
        'CajeroTableAdapter1
        '
        Me.CajeroTableAdapter1.ClearBeforeFill = True
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CajeroTableAdapter = Me.CajeroTableAdapter1
        Me.TableAdapterManager1.ClienteTableAdapter = Nothing
        Me.TableAdapterManager1.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager1.ProductoTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.FacturasVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.VentaTableAdapter = Nothing
        '
        'CajeroDataGridView
        '
        Me.CajeroDataGridView.AllowUserToDeleteRows = False
        Me.CajeroDataGridView.AutoGenerateColumns = False
        Me.CajeroDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CajeroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CajeroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CajeroDataGridView.DataSource = Me.CajeroBindingSource
        Me.CajeroDataGridView.GridColor = System.Drawing.Color.Black
        Me.CajeroDataGridView.Location = New System.Drawing.Point(47, 104)
        Me.CajeroDataGridView.Name = "CajeroDataGridView"
        Me.CajeroDataGridView.ReadOnly = True
        Me.CajeroDataGridView.Size = New System.Drawing.Size(844, 220)
        Me.CajeroDataGridView.TabIndex = 122
        '
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(765, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 40)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "&ELIMINAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Gerente_Tabla_De_Cajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(941, 552)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Txt_Buscar)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.CajeroDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Gerente_Tabla_De_Cajeros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIO/Tabla de Cajeros"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Buscar.ResumeLayout(False)
        Me.Buscar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasVentaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents ID_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Domicilio_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DNI_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Buscar As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CajeroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajeroTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocalidadTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents CajeroTableAdapter1 As WindowsApplication1.FacturasVentaDataSetTableAdapters.CajeroTableAdapter
    Friend WithEvents CajeroBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FacturasVentaDataSet As WindowsApplication1.FacturasVentaDataSet
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.FacturasVentaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CajeroDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
