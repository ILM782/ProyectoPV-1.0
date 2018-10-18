<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Agregar_Cajero
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
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim Nombre_CajeroLabel As System.Windows.Forms.Label
        Dim Apellido_CajeroLabel As System.Windows.Forms.Label
        Dim Domicilio_CajeroLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Correo_CajeroLabel As System.Windows.Forms.Label
        Dim DNI_CajeroLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Agregar_Cajero))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrasaccionDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ID_LocalidadComboBox = New System.Windows.Forms.ComboBox()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajeroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CajeroTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter()
        Me.Nombre_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.Domicilio_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.DNI_CajeroTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Nombre_CajeroLabel = New System.Windows.Forms.Label()
        Apellido_CajeroLabel = New System.Windows.Forms.Label()
        Domicilio_CajeroLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Correo_CajeroLabel = New System.Windows.Forms.Label()
        DNI_CajeroLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_LocalidadLabel.Location = New System.Drawing.Point(15, 104)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(84, 17)
        ID_LocalidadLabel.TabIndex = 30
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Nombre_CajeroLabel
        '
        Nombre_CajeroLabel.AutoSize = True
        Nombre_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_CajeroLabel.Location = New System.Drawing.Point(15, 51)
        Nombre_CajeroLabel.Name = "Nombre_CajeroLabel"
        Nombre_CajeroLabel.Size = New System.Drawing.Size(102, 17)
        Nombre_CajeroLabel.TabIndex = 57
        Nombre_CajeroLabel.Text = "Nombre Cajero:"
        '
        'Apellido_CajeroLabel
        '
        Apellido_CajeroLabel.AutoSize = True
        Apellido_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Apellido_CajeroLabel.Location = New System.Drawing.Point(15, 77)
        Apellido_CajeroLabel.Name = "Apellido_CajeroLabel"
        Apellido_CajeroLabel.Size = New System.Drawing.Size(101, 17)
        Apellido_CajeroLabel.TabIndex = 59
        Apellido_CajeroLabel.Text = "Apellido Cajero:"
        '
        'Domicilio_CajeroLabel
        '
        Domicilio_CajeroLabel.AutoSize = True
        Domicilio_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Domicilio_CajeroLabel.Location = New System.Drawing.Point(17, 132)
        Domicilio_CajeroLabel.Name = "Domicilio_CajeroLabel"
        Domicilio_CajeroLabel.Size = New System.Drawing.Size(107, 17)
        Domicilio_CajeroLabel.TabIndex = 61
        Domicilio_CajeroLabel.Text = "Domicilio Cajero:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(17, 158)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(62, 17)
        TelefonoLabel.TabIndex = 63
        TelefonoLabel.Text = "Telefono:"
        '
        'Correo_CajeroLabel
        '
        Correo_CajeroLabel.AutoSize = True
        Correo_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo_CajeroLabel.Location = New System.Drawing.Point(17, 184)
        Correo_CajeroLabel.Name = "Correo_CajeroLabel"
        Correo_CajeroLabel.Size = New System.Drawing.Size(94, 17)
        Correo_CajeroLabel.TabIndex = 65
        Correo_CajeroLabel.Text = "Correo Cajero:"
        '
        'DNI_CajeroLabel
        '
        DNI_CajeroLabel.AutoSize = True
        DNI_CajeroLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DNI_CajeroLabel.Location = New System.Drawing.Point(15, 25)
        DNI_CajeroLabel.Name = "DNI_CajeroLabel"
        DNI_CajeroLabel.Size = New System.Drawing.Size(76, 17)
        DNI_CajeroLabel.TabIndex = 67
        DNI_CajeroLabel.Text = "DNI Cajero:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.TrasaccionDeComprasToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.AgregarClientesToolStripMenuItem, Me.VentasRealizadasToolStripMenuItem, Me.ComprasRealizadasToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'TrasaccionDeComprasToolStripMenuItem
        '
        Me.TrasaccionDeComprasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrasaccionDeComprasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TrasaccionDeComprasToolStripMenuItem.Name = "TrasaccionDeComprasToolStripMenuItem"
        Me.TrasaccionDeComprasToolStripMenuItem.Size = New System.Drawing.Size(151, 20)
        Me.TrasaccionDeComprasToolStripMenuItem.Text = "Transaccion de Compras"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalidadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'AgregarClientesToolStripMenuItem
        '
        Me.AgregarClientesToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarClientesToolStripMenuItem.Name = "AgregarClientesToolStripMenuItem"
        Me.AgregarClientesToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.AgregarClientesToolStripMenuItem.Text = "Agregar Clientes"
        '
        'VentasRealizadasToolStripMenuItem
        '
        Me.VentasRealizadasToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.VentasRealizadasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasRealizadasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VentasRealizadasToolStripMenuItem.Name = "VentasRealizadasToolStripMenuItem"
        Me.VentasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.VentasRealizadasToolStripMenuItem.Text = "Ventas Realizadas"
        '
        'ComprasRealizadasToolStripMenuItem
        '
        Me.ComprasRealizadasToolStripMenuItem.Enabled = False
        Me.ComprasRealizadasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComprasRealizadasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ComprasRealizadasToolStripMenuItem.Name = "ComprasRealizadasToolStripMenuItem"
        Me.ComprasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.ComprasRealizadasToolStripMenuItem.Text = "Compras Realizadas"
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
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Guardar.FlatAppearance.BorderSize = 0
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.Location = New System.Drawing.Point(400, 264)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(217, 50)
        Me.Btn_Guardar.TabIndex = 8
        Me.Btn_Guardar.Text = "&GUARDAR"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Localidad_Localidad"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Localidad_Localidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CP_Localidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CP_Localidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Provincia_Localidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Provincia_Localidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(832, 10)
        Me.Panel2.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 60)
        Me.Panel1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 42)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Agregar Cajero"
        '
        'ID_LocalidadComboBox
        '
        Me.ID_LocalidadComboBox.DataSource = Me.LocalidadBindingSource
        Me.ID_LocalidadComboBox.DisplayMember = "Localidad_Localidad"
        Me.ID_LocalidadComboBox.FormattingEnabled = True
        Me.ID_LocalidadComboBox.Location = New System.Drawing.Point(123, 103)
        Me.ID_LocalidadComboBox.Name = "ID_LocalidadComboBox"
        Me.ID_LocalidadComboBox.Size = New System.Drawing.Size(121, 25)
        Me.ID_LocalidadComboBox.TabIndex = 4
        Me.ID_LocalidadComboBox.ValueMember = "ID_Localidad"
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
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
        Me.TableAdapterManager.VentaVistaTableAdapter = Nothing
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'Nombre_CajeroTextBox
        '
        Me.Nombre_CajeroTextBox.Location = New System.Drawing.Point(123, 50)
        Me.Nombre_CajeroTextBox.MaxLength = 15
        Me.Nombre_CajeroTextBox.Name = "Nombre_CajeroTextBox"
        Me.Nombre_CajeroTextBox.Size = New System.Drawing.Size(121, 23)
        Me.Nombre_CajeroTextBox.TabIndex = 2
        '
        'Apellido_CajeroTextBox
        '
        Me.Apellido_CajeroTextBox.Location = New System.Drawing.Point(123, 76)
        Me.Apellido_CajeroTextBox.MaxLength = 15
        Me.Apellido_CajeroTextBox.Name = "Apellido_CajeroTextBox"
        Me.Apellido_CajeroTextBox.Size = New System.Drawing.Size(121, 23)
        Me.Apellido_CajeroTextBox.TabIndex = 3
        '
        'Domicilio_CajeroTextBox
        '
        Me.Domicilio_CajeroTextBox.Location = New System.Drawing.Point(123, 131)
        Me.Domicilio_CajeroTextBox.MaxLength = 50
        Me.Domicilio_CajeroTextBox.Name = "Domicilio_CajeroTextBox"
        Me.Domicilio_CajeroTextBox.Size = New System.Drawing.Size(121, 23)
        Me.Domicilio_CajeroTextBox.TabIndex = 5
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(123, 157)
        Me.TelefonoTextBox.MaxLength = 10
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(121, 23)
        Me.TelefonoTextBox.TabIndex = 6
        '
        'Correo_CajeroTextBox
        '
        Me.Correo_CajeroTextBox.Location = New System.Drawing.Point(123, 183)
        Me.Correo_CajeroTextBox.MaxLength = 50
        Me.Correo_CajeroTextBox.Name = "Correo_CajeroTextBox"
        Me.Correo_CajeroTextBox.Size = New System.Drawing.Size(121, 23)
        Me.Correo_CajeroTextBox.TabIndex = 7
        '
        'DNI_CajeroTextBox
        '
        Me.DNI_CajeroTextBox.Location = New System.Drawing.Point(123, 24)
        Me.DNI_CajeroTextBox.MaxLength = 8
        Me.DNI_CajeroTextBox.Name = "DNI_CajeroTextBox"
        Me.DNI_CajeroTextBox.Size = New System.Drawing.Size(121, 23)
        Me.DNI_CajeroTextBox.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.carpeta1
        Me.Button4.Location = New System.Drawing.Point(400, 100)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(217, 158)
        Me.Button4.TabIndex = 69
        Me.Button4.Text = "Tablas de Cajeros"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Nombre_CajeroLabel)
        Me.GroupBox1.Controls.Add(Me.ID_LocalidadComboBox)
        Me.GroupBox1.Controls.Add(Me.Nombre_CajeroTextBox)
        Me.GroupBox1.Controls.Add(ID_LocalidadLabel)
        Me.GroupBox1.Controls.Add(Apellido_CajeroLabel)
        Me.GroupBox1.Controls.Add(Me.DNI_CajeroTextBox)
        Me.GroupBox1.Controls.Add(Me.Apellido_CajeroTextBox)
        Me.GroupBox1.Controls.Add(DNI_CajeroLabel)
        Me.GroupBox1.Controls.Add(Domicilio_CajeroLabel)
        Me.GroupBox1.Controls.Add(Me.Correo_CajeroTextBox)
        Me.GroupBox1.Controls.Add(Me.Domicilio_CajeroTextBox)
        Me.GroupBox1.Controls.Add(Correo_CajeroLabel)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(108, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 214)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Cajero"
        '
        'Gerente_Agregar_Cajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(832, 326)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Gerente_Agregar_Cajero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIO / Agregar Cajero"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CajeroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ID_LocalidadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CajeroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CajeroTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CajeroTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocalidadTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nombre_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Domicilio_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DNI_CajeroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrasaccionDeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
