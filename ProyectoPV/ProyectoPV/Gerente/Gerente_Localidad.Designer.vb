<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Localidad
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
        Dim Localidad_LocalidadLabel As System.Windows.Forms.Label
        Dim CP_LocalidadLabel As System.Windows.Forms.Label
        Dim Provincia_LocalidadLabel As System.Windows.Forms.Label
        Dim LocalidadDataGridView As System.Windows.Forms.DataGridView
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim Localidad_LocalidadLabel1 As System.Windows.Forms.Label
        Dim CP_LocalidadLabel1 As System.Windows.Forms.Label
        Dim Provincia_LocalidadLabel1 As System.Windows.Forms.Label
        Dim ID_LocalidadLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Localidad))
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarCajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Txt_Localidad = New System.Windows.Forms.TextBox()
        Me.Txt_CP = New System.Windows.Forms.TextBox()
        Me.Txt_Provincia = New System.Windows.Forms.TextBox()
        Me.LocalidadTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Localidad_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CP_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Provincia_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Localidad_LocalidadLabel = New System.Windows.Forms.Label()
        CP_LocalidadLabel = New System.Windows.Forms.Label()
        Provincia_LocalidadLabel = New System.Windows.Forms.Label()
        LocalidadDataGridView = New System.Windows.Forms.DataGridView()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Localidad_LocalidadLabel1 = New System.Windows.Forms.Label()
        CP_LocalidadLabel1 = New System.Windows.Forms.Label()
        Provincia_LocalidadLabel1 = New System.Windows.Forms.Label()
        ID_LocalidadLabel1 = New System.Windows.Forms.Label()
        CType(LocalidadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Localidad_LocalidadLabel
        '
        Localidad_LocalidadLabel.AutoSize = True
        Localidad_LocalidadLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Localidad_LocalidadLabel.Location = New System.Drawing.Point(42, 126)
        Localidad_LocalidadLabel.Name = "Localidad_LocalidadLabel"
        Localidad_LocalidadLabel.Size = New System.Drawing.Size(67, 17)
        Localidad_LocalidadLabel.TabIndex = 6
        Localidad_LocalidadLabel.Text = "Localidad:"
        '
        'CP_LocalidadLabel
        '
        CP_LocalidadLabel.AutoSize = True
        CP_LocalidadLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CP_LocalidadLabel.Location = New System.Drawing.Point(42, 152)
        CP_LocalidadLabel.Name = "CP_LocalidadLabel"
        CP_LocalidadLabel.Size = New System.Drawing.Size(93, 17)
        CP_LocalidadLabel.TabIndex = 8
        CP_LocalidadLabel.Text = "Codigo Postal:"
        '
        'Provincia_LocalidadLabel
        '
        Provincia_LocalidadLabel.AutoSize = True
        Provincia_LocalidadLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Provincia_LocalidadLabel.Location = New System.Drawing.Point(42, 177)
        Provincia_LocalidadLabel.Name = "Provincia_LocalidadLabel"
        Provincia_LocalidadLabel.Size = New System.Drawing.Size(63, 17)
        Provincia_LocalidadLabel.TabIndex = 10
        Provincia_LocalidadLabel.Text = "Provincia:"
        '
        'LocalidadDataGridView
        '
        LocalidadDataGridView.AllowUserToDeleteRows = False
        LocalidadDataGridView.AllowUserToResizeColumns = False
        LocalidadDataGridView.AllowUserToResizeRows = False
        LocalidadDataGridView.AutoGenerateColumns = False
        LocalidadDataGridView.BackgroundColor = System.Drawing.Color.White
        LocalidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LocalidadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        LocalidadDataGridView.DataSource = Me.LocalidadBindingSource
        LocalidadDataGridView.Enabled = False
        LocalidadDataGridView.EnableHeadersVisualStyles = False
        LocalidadDataGridView.GridColor = System.Drawing.Color.Black
        LocalidadDataGridView.Location = New System.Drawing.Point(274, 119)
        LocalidadDataGridView.MultiSelect = False
        LocalidadDataGridView.Name = "LocalidadDataGridView"
        LocalidadDataGridView.ReadOnly = True
        LocalidadDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        LocalidadDataGridView.ShowCellErrors = False
        LocalidadDataGridView.ShowCellToolTips = False
        LocalidadDataGridView.ShowEditingIcon = False
        LocalidadDataGridView.ShowRowErrors = False
        LocalidadDataGridView.Size = New System.Drawing.Size(443, 444)
        LocalidadDataGridView.TabIndex = 11
        LocalidadDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Localidad_Localidad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Localidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CP_Localidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo Postal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Provincia_Localidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(68, 265)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 0
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Localidad_LocalidadLabel1
        '
        Localidad_LocalidadLabel1.AutoSize = True
        Localidad_LocalidadLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Localidad_LocalidadLabel1.Location = New System.Drawing.Point(36, 447)
        Localidad_LocalidadLabel1.Name = "Localidad_LocalidadLabel1"
        Localidad_LocalidadLabel1.Size = New System.Drawing.Size(67, 17)
        Localidad_LocalidadLabel1.TabIndex = 2
        Localidad_LocalidadLabel1.Text = "Localidad:"
        '
        'CP_LocalidadLabel1
        '
        CP_LocalidadLabel1.AutoSize = True
        CP_LocalidadLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CP_LocalidadLabel1.Location = New System.Drawing.Point(36, 473)
        CP_LocalidadLabel1.Name = "CP_LocalidadLabel1"
        CP_LocalidadLabel1.Size = New System.Drawing.Size(93, 17)
        CP_LocalidadLabel1.TabIndex = 4
        CP_LocalidadLabel1.Text = "Codigo Postal:"
        '
        'Provincia_LocalidadLabel1
        '
        Provincia_LocalidadLabel1.AutoSize = True
        Provincia_LocalidadLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Provincia_LocalidadLabel1.Location = New System.Drawing.Point(36, 499)
        Provincia_LocalidadLabel1.Name = "Provincia_LocalidadLabel1"
        Provincia_LocalidadLabel1.Size = New System.Drawing.Size(63, 17)
        Provincia_LocalidadLabel1.TabIndex = 6
        Provincia_LocalidadLabel1.Text = "Provincia:"
        '
        'ID_LocalidadLabel1
        '
        ID_LocalidadLabel1.AutoSize = True
        ID_LocalidadLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_LocalidadLabel1.Location = New System.Drawing.Point(36, 271)
        ID_LocalidadLabel1.Name = "ID_LocalidadLabel1"
        ID_LocalidadLabel1.Size = New System.Drawing.Size(89, 17)
        ID_LocalidadLabel1.TabIndex = 0
        ID_LocalidadLabel1.Text = "Seleccione ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.AgregarCajeroToolStripMenuItem, Me.VentasRealizadasToolStripMenuItem, Me.ToolStripMenuItem3, Me.ComprasRealizadasToolStripMenuItem, Me.AtrasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(865, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.NuevoToolStripMenuItem.Text = "Productos"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.BorrarToolStripMenuItem.Text = "Proveedores"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActualizarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(162, 20)
        Me.ActualizarToolStripMenuItem.Text = "Transacciones de Compras"
        '
        'AgregarCajeroToolStripMenuItem
        '
        Me.AgregarCajeroToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarCajeroToolStripMenuItem.Name = "AgregarCajeroToolStripMenuItem"
        Me.AgregarCajeroToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.AgregarCajeroToolStripMenuItem.Text = "Agregar Cajero"
        '
        'VentasRealizadasToolStripMenuItem
        '
        Me.VentasRealizadasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VentasRealizadasToolStripMenuItem.Name = "VentasRealizadasToolStripMenuItem"
        Me.VentasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.VentasRealizadasToolStripMenuItem.Text = "Agregar Clientes"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(112, 20)
        Me.ToolStripMenuItem3.Text = "Ventas Realizadas"
        '
        'ComprasRealizadasToolStripMenuItem
        '
        Me.ComprasRealizadasToolStripMenuItem.Enabled = False
        Me.ComprasRealizadasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ComprasRealizadasToolStripMenuItem.Name = "ComprasRealizadasToolStripMenuItem"
        Me.ComprasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.ComprasRealizadasToolStripMenuItem.Text = "Compras Realizadas"
        '
        'AtrasToolStripMenuItem
        '
        Me.AtrasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtrasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AtrasToolStripMenuItem.Name = "AtrasToolStripMenuItem"
        Me.AtrasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AtrasToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(865, 586)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 39
        Me.LineShape1.X2 = 259
        Me.LineShape1.Y1 = 251
        Me.LineShape1.Y2 = 251
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar Localidad:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(150, 296)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(144, 262)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 1
        '
        'Txt_Localidad
        '
        Me.Txt_Localidad.Location = New System.Drawing.Point(148, 123)
        Me.Txt_Localidad.MaxLength = 80
        Me.Txt_Localidad.Name = "Txt_Localidad"
        Me.Txt_Localidad.Size = New System.Drawing.Size(108, 20)
        Me.Txt_Localidad.TabIndex = 1
        '
        'Txt_CP
        '
        Me.Txt_CP.Location = New System.Drawing.Point(148, 148)
        Me.Txt_CP.MaxLength = 10
        Me.Txt_CP.Name = "Txt_CP"
        Me.Txt_CP.Size = New System.Drawing.Size(108, 20)
        Me.Txt_CP.TabIndex = 2
        '
        'Txt_Provincia
        '
        Me.Txt_Provincia.Location = New System.Drawing.Point(148, 174)
        Me.Txt_Provincia.MaxLength = 50
        Me.Txt_Provincia.Name = "Txt_Provincia"
        Me.Txt_Provincia.Size = New System.Drawing.Size(108, 20)
        Me.Txt_Provincia.TabIndex = 3
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Nothing
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 47)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eliminar"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(122, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Provincia"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(32, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Localidad"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(865, 10)
        Me.Panel2.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(865, 60)
        Me.Panel1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 42)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Localidad"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Guardar.FlatAppearance.BorderSize = 0
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.Location = New System.Drawing.Point(39, 200)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(211, 40)
        Me.Btn_Guardar.TabIndex = 4
        Me.Btn_Guardar.Text = "&GUARDAR"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Location = New System.Drawing.Point(39, 384)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(211, 40)
        Me.Btn_Eliminar.TabIndex = 7
        Me.Btn_Eliminar.Text = "&ELIMINAR"
        Me.Btn_Eliminar.UseVisualStyleBackColor = False
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Modificar.FlatAppearance.BorderSize = 0
        Me.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Location = New System.Drawing.Point(39, 534)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(211, 40)
        Me.Btn_Modificar.TabIndex = 11
        Me.Btn_Modificar.Text = "&MODIFICAR"
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'Localidad_LocalidadTextBox
        '
        Me.Localidad_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Localidad_Localidad", True))
        Me.Localidad_LocalidadTextBox.Location = New System.Drawing.Point(147, 444)
        Me.Localidad_LocalidadTextBox.Name = "Localidad_LocalidadTextBox"
        Me.Localidad_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Localidad_LocalidadTextBox.TabIndex = 8
        '
        'CP_LocalidadTextBox
        '
        Me.CP_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "CP_Localidad", True))
        Me.CP_LocalidadTextBox.Location = New System.Drawing.Point(147, 470)
        Me.CP_LocalidadTextBox.Name = "CP_LocalidadTextBox"
        Me.CP_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CP_LocalidadTextBox.TabIndex = 9
        '
        'Provincia_LocalidadTextBox
        '
        Me.Provincia_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Provincia_Localidad", True))
        Me.Provincia_LocalidadTextBox.Location = New System.Drawing.Point(147, 496)
        Me.Provincia_LocalidadTextBox.Name = "Provincia_LocalidadTextBox"
        Me.Provincia_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Provincia_LocalidadTextBox.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(150, 268)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 57
        '
        'Gerente_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(865, 586)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Localidad_LocalidadLabel1)
        Me.Controls.Add(Me.Localidad_LocalidadTextBox)
        Me.Controls.Add(CP_LocalidadLabel1)
        Me.Controls.Add(Me.CP_LocalidadTextBox)
        Me.Controls.Add(Provincia_LocalidadLabel1)
        Me.Controls.Add(Me.Provincia_LocalidadTextBox)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(ID_LocalidadLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Txt_Provincia)
        Me.Controls.Add(Me.Txt_CP)
        Me.Controls.Add(Me.Txt_Localidad)
        Me.Controls.Add(LocalidadDataGridView)
        Me.Controls.Add(Localidad_LocalidadLabel)
        Me.Controls.Add(CP_LocalidadLabel)
        Me.Controls.Add(Provincia_LocalidadLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Gerente_Localidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIO/Localidades"
        CType(LocalidadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Localidad As System.Windows.Forms.TextBox
    Friend WithEvents Txt_CP As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Provincia As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Localidad_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CP_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Provincia_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents AgregarCajeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
