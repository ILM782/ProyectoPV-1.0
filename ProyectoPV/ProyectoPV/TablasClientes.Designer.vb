<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TablasClientes
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
        Dim Correo_ClienteLabel As System.Windows.Forms.Label
        Dim Correo_ClienteLabel1 As System.Windows.Forms.Label
        Dim Telefono_ClienteLabel As System.Windows.Forms.Label
        Dim Domicilio_ClienteLabel As System.Windows.Forms.Label
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim Apellido_ClienteLabel As System.Windows.Forms.Label
        Dim Nombre_ClienteLabel As System.Windows.Forms.Label
        Dim Localidad_LocalidadLabel As System.Windows.Forms.Label
        Dim CP_LocalidadLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Correo_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter()
        Me.LocalidadTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Txt_Consulta_Cliente = New System.Windows.Forms.TextBox()
        Me.Btn_Consultar_Cliente = New System.Windows.Forms.Button()
        Me.Correo_ClienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.Telefono_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Domicilio_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Localidad_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CP_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.MayoristaBaseDeDatosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Correo_ClienteLabel = New System.Windows.Forms.Label()
        Correo_ClienteLabel1 = New System.Windows.Forms.Label()
        Telefono_ClienteLabel = New System.Windows.Forms.Label()
        Domicilio_ClienteLabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Apellido_ClienteLabel = New System.Windows.Forms.Label()
        Nombre_ClienteLabel = New System.Windows.Forms.Label()
        Localidad_LocalidadLabel = New System.Windows.Forms.Label()
        CP_LocalidadLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Correo_ClienteLabel
        '
        Correo_ClienteLabel.AutoSize = True
        Correo_ClienteLabel.Location = New System.Drawing.Point(173, 319)
        Correo_ClienteLabel.Name = "Correo_ClienteLabel"
        Correo_ClienteLabel.Size = New System.Drawing.Size(76, 13)
        Correo_ClienteLabel.TabIndex = 31
        Correo_ClienteLabel.Text = "Correo Cliente:"
        '
        'Correo_ClienteLabel1
        '
        Correo_ClienteLabel1.AutoSize = True
        Correo_ClienteLabel1.ForeColor = System.Drawing.Color.White
        Correo_ClienteLabel1.Location = New System.Drawing.Point(419, 452)
        Correo_ClienteLabel1.Name = "Correo_ClienteLabel1"
        Correo_ClienteLabel1.Size = New System.Drawing.Size(76, 13)
        Correo_ClienteLabel1.TabIndex = 48
        Correo_ClienteLabel1.Text = "Correo Cliente:"
        '
        'Telefono_ClienteLabel
        '
        Telefono_ClienteLabel.AutoSize = True
        Telefono_ClienteLabel.ForeColor = System.Drawing.Color.White
        Telefono_ClienteLabel.Location = New System.Drawing.Point(419, 426)
        Telefono_ClienteLabel.Name = "Telefono_ClienteLabel"
        Telefono_ClienteLabel.Size = New System.Drawing.Size(87, 13)
        Telefono_ClienteLabel.TabIndex = 46
        Telefono_ClienteLabel.Text = "Telefono Cliente:"
        '
        'Domicilio_ClienteLabel
        '
        Domicilio_ClienteLabel.AutoSize = True
        Domicilio_ClienteLabel.ForeColor = System.Drawing.Color.White
        Domicilio_ClienteLabel.Location = New System.Drawing.Point(211, 452)
        Domicilio_ClienteLabel.Name = "Domicilio_ClienteLabel"
        Domicilio_ClienteLabel.Size = New System.Drawing.Size(87, 13)
        Domicilio_ClienteLabel.TabIndex = 44
        Domicilio_ClienteLabel.Text = "Domicilio Cliente:"
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.ForeColor = System.Drawing.Color.White
        ID_LocalidadLabel.Location = New System.Drawing.Point(211, 426)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 42
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Apellido_ClienteLabel
        '
        Apellido_ClienteLabel.AutoSize = True
        Apellido_ClienteLabel.ForeColor = System.Drawing.Color.White
        Apellido_ClienteLabel.Location = New System.Drawing.Point(12, 452)
        Apellido_ClienteLabel.Name = "Apellido_ClienteLabel"
        Apellido_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Apellido_ClienteLabel.TabIndex = 40
        Apellido_ClienteLabel.Text = "Apellido Cliente:"
        '
        'Nombre_ClienteLabel
        '
        Nombre_ClienteLabel.AutoSize = True
        Nombre_ClienteLabel.ForeColor = System.Drawing.Color.White
        Nombre_ClienteLabel.Location = New System.Drawing.Point(12, 426)
        Nombre_ClienteLabel.Name = "Nombre_ClienteLabel"
        Nombre_ClienteLabel.Size = New System.Drawing.Size(82, 13)
        Nombre_ClienteLabel.TabIndex = 38
        Nombre_ClienteLabel.Text = "Nombre Cliente:"
        '
        'Localidad_LocalidadLabel
        '
        Localidad_LocalidadLabel.AutoSize = True
        Localidad_LocalidadLabel.ForeColor = System.Drawing.Color.White
        Localidad_LocalidadLabel.Location = New System.Drawing.Point(449, 522)
        Localidad_LocalidadLabel.Name = "Localidad_LocalidadLabel"
        Localidad_LocalidadLabel.Size = New System.Drawing.Size(105, 13)
        Localidad_LocalidadLabel.TabIndex = 59
        Localidad_LocalidadLabel.Text = "Localidad Localidad:"
        '
        'CP_LocalidadLabel
        '
        CP_LocalidadLabel.AutoSize = True
        CP_LocalidadLabel.ForeColor = System.Drawing.Color.White
        CP_LocalidadLabel.Location = New System.Drawing.Point(449, 548)
        CP_LocalidadLabel.Name = "CP_LocalidadLabel"
        CP_LocalidadLabel.Size = New System.Drawing.Size(73, 13)
        CP_LocalidadLabel.TabIndex = 61
        CP_LocalidadLabel.Text = "CP Localidad:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.ForeColor = System.Drawing.Color.White
        ProvinciaLabel.Location = New System.Drawing.Point(449, 574)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(54, 13)
        ProvinciaLabel.TabIndex = 63
        ProvinciaLabel.Text = "Provincia:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.AtrasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.NuevoToolStripMenuItem.Text = "Nueva Busqueda"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'AtrasToolStripMenuItem
        '
        Me.AtrasToolStripMenuItem.Name = "AtrasToolStripMenuItem"
        Me.AtrasToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AtrasToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(644, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Guardado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Correo_ClienteTextBox
        '
        Me.Correo_ClienteTextBox.Location = New System.Drawing.Point(266, 316)
        Me.Correo_ClienteTextBox.Name = "Correo_ClienteTextBox"
        Me.Correo_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Correo_ClienteTextBox.TabIndex = 32
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 33
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.Compra_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Me.LocalidadTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.OperadorTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ventas_ClientesTableAdapter = Nothing
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'LocalidadTableAdapter
        '
        Me.LocalidadTableAdapter.ClearBeforeFill = True
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(0, 76)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(741, 335)
        Me.ClienteDataGridView.TabIndex = 34
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'Txt_Consulta_Cliente
        '
        Me.Txt_Consulta_Cliente.Location = New System.Drawing.Point(149, 38)
        Me.Txt_Consulta_Cliente.Name = "Txt_Consulta_Cliente"
        Me.Txt_Consulta_Cliente.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Consulta_Cliente.TabIndex = 35
        '
        'Btn_Consultar_Cliente
        '
        Me.Btn_Consultar_Cliente.Location = New System.Drawing.Point(266, 38)
        Me.Btn_Consultar_Cliente.Name = "Btn_Consultar_Cliente"
        Me.Btn_Consultar_Cliente.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Consultar_Cliente.TabIndex = 36
        Me.Btn_Consultar_Cliente.Text = "Buscar"
        Me.Btn_Consultar_Cliente.UseVisualStyleBackColor = True
        '
        'Correo_ClienteTextBox1
        '
        Me.Correo_ClienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Correo_Cliente", True))
        Me.Correo_ClienteTextBox1.Location = New System.Drawing.Point(512, 449)
        Me.Correo_ClienteTextBox1.Name = "Correo_ClienteTextBox1"
        Me.Correo_ClienteTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Correo_ClienteTextBox1.TabIndex = 49
        '
        'Telefono_ClienteTextBox
        '
        Me.Telefono_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telefono_Cliente", True))
        Me.Telefono_ClienteTextBox.Location = New System.Drawing.Point(512, 423)
        Me.Telefono_ClienteTextBox.Name = "Telefono_ClienteTextBox"
        Me.Telefono_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono_ClienteTextBox.TabIndex = 47
        '
        'Domicilio_ClienteTextBox
        '
        Me.Domicilio_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Domicilio_Cliente", True))
        Me.Domicilio_ClienteTextBox.Location = New System.Drawing.Point(304, 449)
        Me.Domicilio_ClienteTextBox.Name = "Domicilio_ClienteTextBox"
        Me.Domicilio_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Domicilio_ClienteTextBox.TabIndex = 45
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(304, 423)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 43
        '
        'Apellido_ClienteTextBox
        '
        Me.Apellido_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Apellido_Cliente", True))
        Me.Apellido_ClienteTextBox.Location = New System.Drawing.Point(105, 449)
        Me.Apellido_ClienteTextBox.Name = "Apellido_ClienteTextBox"
        Me.Apellido_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Apellido_ClienteTextBox.TabIndex = 41
        '
        'Nombre_ClienteTextBox
        '
        Me.Nombre_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Nombre_Cliente", True))
        Me.Nombre_ClienteTextBox.Location = New System.Drawing.Point(105, 423)
        Me.Nombre_ClienteTextBox.Name = "Nombre_ClienteTextBox"
        Me.Nombre_ClienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_ClienteTextBox.TabIndex = 39
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'LocalidadDataGridView
        '
        Me.LocalidadDataGridView.AutoGenerateColumns = False
        Me.LocalidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LocalidadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.LocalidadDataGridView.DataSource = Me.LocalidadBindingSource
        Me.LocalidadDataGridView.Location = New System.Drawing.Point(0, 475)
        Me.LocalidadDataGridView.Name = "LocalidadDataGridView"
        Me.LocalidadDataGridView.Size = New System.Drawing.Size(443, 220)
        Me.LocalidadDataGridView.TabIndex = 49
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Localidad_Localidad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Localidad_Localidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CP_Localidad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CP_Localidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Provincia"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(644, 601)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Localidad_LocalidadTextBox
        '
        Me.Localidad_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Localidad_Localidad", True))
        Me.Localidad_LocalidadTextBox.Location = New System.Drawing.Point(560, 519)
        Me.Localidad_LocalidadTextBox.Name = "Localidad_LocalidadTextBox"
        Me.Localidad_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Localidad_LocalidadTextBox.TabIndex = 60
        '
        'CP_LocalidadTextBox
        '
        Me.CP_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "CP_Localidad", True))
        Me.CP_LocalidadTextBox.Location = New System.Drawing.Point(560, 545)
        Me.CP_LocalidadTextBox.Name = "CP_LocalidadTextBox"
        Me.CP_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CP_LocalidadTextBox.TabIndex = 62
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(560, 571)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProvinciaTextBox.TabIndex = 64
        '
        'MayoristaBaseDeDatosDataSetBindingSource
        '
        Me.MayoristaBaseDeDatosDataSetBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        Me.MayoristaBaseDeDatosDataSetBindingSource.Position = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Correo_Cliente"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Correo_Cliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Telefono_Cliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono_Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Domicilio_Cliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Domicilio_Cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_Localidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID_Localidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido_Cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido_Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre_Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TablasClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(782, 759)
        Me.Controls.Add(Localidad_LocalidadLabel)
        Me.Controls.Add(Me.Localidad_LocalidadTextBox)
        Me.Controls.Add(CP_LocalidadLabel)
        Me.Controls.Add(Me.CP_LocalidadTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LocalidadDataGridView)
        Me.Controls.Add(Nombre_ClienteLabel)
        Me.Controls.Add(Me.Nombre_ClienteTextBox)
        Me.Controls.Add(Apellido_ClienteLabel)
        Me.Controls.Add(Me.Apellido_ClienteTextBox)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadTextBox)
        Me.Controls.Add(Domicilio_ClienteLabel)
        Me.Controls.Add(Me.Domicilio_ClienteTextBox)
        Me.Controls.Add(Telefono_ClienteLabel)
        Me.Controls.Add(Me.Telefono_ClienteTextBox)
        Me.Controls.Add(Correo_ClienteLabel1)
        Me.Controls.Add(Me.Correo_ClienteTextBox1)
        Me.Controls.Add(Me.Btn_Consultar_Cliente)
        Me.Controls.Add(Me.Txt_Consulta_Cliente)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Correo_ClienteLabel)
        Me.Controls.Add(Me.Correo_ClienteTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TablasClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Correo_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_Consulta_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Consultar_Cliente As System.Windows.Forms.Button
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Correo_ClienteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Domicilio_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClienteTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents LocalidadDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Localidad_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CP_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MayoristaBaseDeDatosDataSetBindingSource As System.Windows.Forms.BindingSource
End Class
