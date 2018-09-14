<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja
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
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ClienteTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ventas_ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ventas_ClientesTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.Ventas_ClientesTableAdapter()
        Me.ID_OperadorTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ItemsTextBox = New System.Windows.Forms.TextBox()
        Me.MontoTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_De_FacturacionTextBox = New System.Windows.Forms.TextBox()
        ID_OperadorLabel = New System.Windows.Forms.Label()
        ID_ProductoLabel = New System.Windows.Forms.Label()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ItemsLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        Tipo_De_FacturacionLabel = New System.Windows.Forms.Label()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Ventas_ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.AgregarLocalidadToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar Cliente"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AgregarLocalidadToolStripMenuItem
        '
        Me.AgregarLocalidadToolStripMenuItem.Name = "AgregarLocalidadToolStripMenuItem"
        Me.AgregarLocalidadToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.AgregarLocalidadToolStripMenuItem.Text = "Agregar Localidad"
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
        'ID_OperadorLabel
        '
        ID_OperadorLabel.AutoSize = True
        ID_OperadorLabel.Location = New System.Drawing.Point(12, 54)
        ID_OperadorLabel.Name = "ID_OperadorLabel"
        ID_OperadorLabel.Size = New System.Drawing.Size(68, 13)
        ID_OperadorLabel.TabIndex = 3
        ID_OperadorLabel.Text = "ID Operador:"
        '
        'ID_OperadorTextBox
        '
        Me.ID_OperadorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "ID_Operador", True))
        Me.ID_OperadorTextBox.Location = New System.Drawing.Point(136, 51)
        Me.ID_OperadorTextBox.Name = "ID_OperadorTextBox"
        Me.ID_OperadorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_OperadorTextBox.TabIndex = 4
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.Location = New System.Drawing.Point(12, 80)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(67, 13)
        ID_ProductoLabel.TabIndex = 5
        ID_ProductoLabel.Text = "ID Producto:"
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "ID_Producto", True))
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(136, 77)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_ProductoTextBox.TabIndex = 6
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.Location = New System.Drawing.Point(12, 106)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(56, 13)
        ID_ClienteLabel.TabIndex = 7
        ID_ClienteLabel.Text = "ID Cliente:"
        '
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "ID_Cliente", True))
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(136, 103)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_ClienteTextBox.TabIndex = 8
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(12, 133)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 9
        FechaLabel.Text = "Fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ventas_ClientesBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(136, 129)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 10
        '
        'ItemsLabel
        '
        ItemsLabel.AutoSize = True
        ItemsLabel.Location = New System.Drawing.Point(12, 158)
        ItemsLabel.Name = "ItemsLabel"
        ItemsLabel.Size = New System.Drawing.Size(35, 13)
        ItemsLabel.TabIndex = 11
        ItemsLabel.Text = "Items:"
        '
        'ItemsTextBox
        '
        Me.ItemsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "Items", True))
        Me.ItemsTextBox.Location = New System.Drawing.Point(136, 155)
        Me.ItemsTextBox.Name = "ItemsTextBox"
        Me.ItemsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ItemsTextBox.TabIndex = 12
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Location = New System.Drawing.Point(12, 184)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(40, 13)
        MontoLabel.TabIndex = 13
        MontoLabel.Text = "Monto:"
        '
        'MontoTextBox
        '
        Me.MontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "Monto", True))
        Me.MontoTextBox.Location = New System.Drawing.Point(136, 181)
        Me.MontoTextBox.Name = "MontoTextBox"
        Me.MontoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MontoTextBox.TabIndex = 14
        '
        'Tipo_De_FacturacionLabel
        '
        Tipo_De_FacturacionLabel.AutoSize = True
        Tipo_De_FacturacionLabel.Location = New System.Drawing.Point(12, 210)
        Tipo_De_FacturacionLabel.Name = "Tipo_De_FacturacionLabel"
        Tipo_De_FacturacionLabel.Size = New System.Drawing.Size(107, 13)
        Tipo_De_FacturacionLabel.TabIndex = 15
        Tipo_De_FacturacionLabel.Text = "Tipo De Facturacion:"
        '
        'Tipo_De_FacturacionTextBox
        '
        Me.Tipo_De_FacturacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ventas_ClientesBindingSource, "Tipo_De_Facturacion", True))
        Me.Tipo_De_FacturacionTextBox.Location = New System.Drawing.Point(136, 207)
        Me.Tipo_De_FacturacionTextBox.Name = "Tipo_De_FacturacionTextBox"
        Me.Tipo_De_FacturacionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Tipo_De_FacturacionTextBox.TabIndex = 16
        '
        'Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 342)
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
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Caja"
        Me.Text = "Caja"
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Ventas_ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
