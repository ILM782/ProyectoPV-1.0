<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajero_Localidad
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
        Dim Localidad_LocalidadLabel As System.Windows.Forms.Label
        Dim CP_LocalidadLabel As System.Windows.Forms.Label
        Dim Provincia_LocalidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cajero_Localidad))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TransaccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.LocalidadDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Localidad_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.CP_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Provincia_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Localidad_LocalidadLabel = New System.Windows.Forms.Label()
        CP_LocalidadLabel = New System.Windows.Forms.Label()
        Provincia_LocalidadLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(40, 125)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 9
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'Localidad_LocalidadLabel
        '
        Localidad_LocalidadLabel.AutoSize = True
        Localidad_LocalidadLabel.Location = New System.Drawing.Point(40, 151)
        Localidad_LocalidadLabel.Name = "Localidad_LocalidadLabel"
        Localidad_LocalidadLabel.Size = New System.Drawing.Size(105, 13)
        Localidad_LocalidadLabel.TabIndex = 11
        Localidad_LocalidadLabel.Text = "Localidad Localidad:"
        '
        'CP_LocalidadLabel
        '
        CP_LocalidadLabel.AutoSize = True
        CP_LocalidadLabel.Location = New System.Drawing.Point(40, 177)
        CP_LocalidadLabel.Name = "CP_LocalidadLabel"
        CP_LocalidadLabel.Size = New System.Drawing.Size(73, 13)
        CP_LocalidadLabel.TabIndex = 13
        CP_LocalidadLabel.Text = "CP Localidad:"
        '
        'Provincia_LocalidadLabel
        '
        Provincia_LocalidadLabel.AutoSize = True
        Provincia_LocalidadLabel.Location = New System.Drawing.Point(40, 203)
        Provincia_LocalidadLabel.Name = "Provincia_LocalidadLabel"
        Provincia_LocalidadLabel.Size = New System.Drawing.Size(103, 13)
        Provincia_LocalidadLabel.TabIndex = 15
        Provincia_LocalidadLabel.Text = "Provincia Localidad:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransaccionToolStripMenuItem, Me.AgregarClienteToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TransaccionToolStripMenuItem
        '
        Me.TransaccionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TransaccionToolStripMenuItem.Name = "TransaccionToolStripMenuItem"
        Me.TransaccionToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.TransaccionToolStripMenuItem.Text = "Transaccion"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar Cliente"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.BackColor = System.Drawing.Color.Black
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 66)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 42)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Localidades"
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocalidadBindingSource
        '
        Me.LocalidadBindingSource.DataMember = "Localidad"
        Me.LocalidadBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
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
        Me.TableAdapterManager.Compra_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Me.LocalidadTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ventas_ClientesTableAdapter = Nothing
        '
        'LocalidadDataGridView
        '
        Me.LocalidadDataGridView.AutoGenerateColumns = False
        Me.LocalidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LocalidadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.LocalidadDataGridView.DataSource = Me.LocalidadBindingSource
        Me.LocalidadDataGridView.Location = New System.Drawing.Point(289, 122)
        Me.LocalidadDataGridView.Name = "LocalidadDataGridView"
        Me.LocalidadDataGridView.Size = New System.Drawing.Size(444, 161)
        Me.LocalidadDataGridView.TabIndex = 8
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
        Me.DataGridViewTextBoxColumn2.HeaderText = "Localidad_Localidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CP_Localidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CP_Localidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Provincia_Localidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Provincia_Localidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(151, 122)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 10
        '
        'Localidad_LocalidadTextBox
        '
        Me.Localidad_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Localidad_Localidad", True))
        Me.Localidad_LocalidadTextBox.Location = New System.Drawing.Point(151, 148)
        Me.Localidad_LocalidadTextBox.Name = "Localidad_LocalidadTextBox"
        Me.Localidad_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Localidad_LocalidadTextBox.TabIndex = 12
        '
        'CP_LocalidadTextBox
        '
        Me.CP_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "CP_Localidad", True))
        Me.CP_LocalidadTextBox.Location = New System.Drawing.Point(151, 174)
        Me.CP_LocalidadTextBox.Name = "CP_LocalidadTextBox"
        Me.CP_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CP_LocalidadTextBox.TabIndex = 14
        '
        'Provincia_LocalidadTextBox
        '
        Me.Provincia_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LocalidadBindingSource, "Provincia_Localidad", True))
        Me.Provincia_LocalidadTextBox.Location = New System.Drawing.Point(151, 200)
        Me.Provincia_LocalidadTextBox.Name = "Provincia_LocalidadTextBox"
        Me.Provincia_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Provincia_LocalidadTextBox.TabIndex = 16
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Buscar.FlatAppearance.BorderSize = 0
        Me.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Buscar.Location = New System.Drawing.Point(43, 243)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(208, 40)
        Me.Btn_Buscar.TabIndex = 26
        Me.Btn_Buscar.Text = "&BUSCAR"
        Me.Btn_Buscar.UseVisualStyleBackColor = False
        '
        'Cajero_Localidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(774, 319)
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadTextBox)
        Me.Controls.Add(Localidad_LocalidadLabel)
        Me.Controls.Add(Me.Localidad_LocalidadTextBox)
        Me.Controls.Add(CP_LocalidadLabel)
        Me.Controls.Add(Me.CP_LocalidadTextBox)
        Me.Controls.Add(Provincia_LocalidadLabel)
        Me.Controls.Add(Me.Provincia_LocalidadTextBox)
        Me.Controls.Add(Me.LocalidadDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Cajero_Localidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIANDO / Localidades"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LocalidadDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Localidad_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CP_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Provincia_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
End Class
