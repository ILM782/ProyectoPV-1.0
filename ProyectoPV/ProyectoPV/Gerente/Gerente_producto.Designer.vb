<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Producto
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
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim Nombre_ProductoLabel As System.Windows.Forms.Label
        Dim StrockLabel As System.Windows.Forms.Label
        Dim Precio_UnitarioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Producto))
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarCajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.CategoriaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter()
        Me.MarcasTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CategoriaLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        StrockLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.ForeColor = System.Drawing.Color.Black
        CategoriaLabel.Location = New System.Drawing.Point(71, 231)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(68, 17)
        CategoriaLabel.TabIndex = 40
        CategoriaLabel.Text = "Categoria:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.ForeColor = System.Drawing.Color.Black
        MarcaLabel.Location = New System.Drawing.Point(71, 260)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(48, 17)
        MarcaLabel.TabIndex = 39
        MarcaLabel.Text = "Marca:"
        '
        'Nombre_ProductoLabel
        '
        Nombre_ProductoLabel.AutoSize = True
        Nombre_ProductoLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_ProductoLabel.ForeColor = System.Drawing.Color.Black
        Nombre_ProductoLabel.Location = New System.Drawing.Point(70, 118)
        Nombre_ProductoLabel.Name = "Nombre_ProductoLabel"
        Nombre_ProductoLabel.Size = New System.Drawing.Size(117, 17)
        Nombre_ProductoLabel.TabIndex = 35
        Nombre_ProductoLabel.Text = "Nombre Producto:"
        '
        'StrockLabel
        '
        StrockLabel.AutoSize = True
        StrockLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StrockLabel.ForeColor = System.Drawing.Color.Black
        StrockLabel.Location = New System.Drawing.Point(70, 147)
        StrockLabel.Name = "StrockLabel"
        StrockLabel.Size = New System.Drawing.Size(43, 17)
        StrockLabel.TabIndex = 36
        StrockLabel.Text = "Stock:"
        '
        'Precio_UnitarioLabel
        '
        Precio_UnitarioLabel.AutoSize = True
        Precio_UnitarioLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Precio_UnitarioLabel.ForeColor = System.Drawing.Color.Black
        Precio_UnitarioLabel.Location = New System.Drawing.Point(70, 175)
        Precio_UnitarioLabel.Name = "Precio_UnitarioLabel"
        Precio_UnitarioLabel.Size = New System.Drawing.Size(97, 17)
        Precio_UnitarioLabel.TabIndex = 37
        Precio_UnitarioLabel.Text = "Precio Unitario:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.ForeColor = System.Drawing.Color.Black
        DescripcionLabel.Location = New System.Drawing.Point(70, 203)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(79, 17)
        DescripcionLabel.TabIndex = 38
        DescripcionLabel.Text = "Descripcion:"
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
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(193, 202)
        Me.TextBox4.MaxLength = 110
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 21)
        Me.TextBox4.TabIndex = 50
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(193, 174)
        Me.TextBox3.MaxLength = 30000
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 21)
        Me.TextBox3.TabIndex = 48
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(193, 146)
        Me.TextBox2.MaxLength = 30000
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 21)
        Me.TextBox2.TabIndex = 47
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(193, 117)
        Me.TextBox1.MaxLength = 60
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 21)
        Me.TextBox1.TabIndex = 46
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.MarcasBindingSource
        Me.ComboBox2.DisplayMember = "Marca"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(193, 259)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox2.TabIndex = 45
        Me.ComboBox2.ValueMember = "ID_Marca"
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategoriaBindingSource
        Me.ComboBox1.DisplayMember = "Categoria"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(193, 230)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 44
        Me.ComboBox1.ValueMember = "ID_Categoria"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.carpeta_simbolo_de_agregar
        Me.Button3.Location = New System.Drawing.Point(320, 230)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 22)
        Me.Button3.TabIndex = 43
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.carpeta_simbolo_de_agregar
        Me.Button2.Location = New System.Drawing.Point(320, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 22)
        Me.Button2.TabIndex = 42
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedorToolStripMenuItem, Me.TransaccionesDeCompraToolStripMenuItem, Me.AgregarCajeroToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VentasRealizadasToolStripMenuItem, Me.ComprasRealizadasToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(856, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProveedorToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ProveedorToolStripMenuItem.Text = "Proveedores"
        '
        'TransaccionesDeCompraToolStripMenuItem
        '
        Me.TransaccionesDeCompraToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransaccionesDeCompraToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TransaccionesDeCompraToolStripMenuItem.Name = "TransaccionesDeCompraToolStripMenuItem"
        Me.TransaccionesDeCompraToolStripMenuItem.Size = New System.Drawing.Size(144, 20)
        Me.TransaccionesDeCompraToolStripMenuItem.Text = "Transaccion de compra"
        '
        'AgregarCajeroToolStripMenuItem
        '
        Me.AgregarCajeroToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarCajeroToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AgregarCajeroToolStripMenuItem.Name = "AgregarCajeroToolStripMenuItem"
        Me.AgregarCajeroToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.AgregarCajeroToolStripMenuItem.Text = "Agregar Cajero"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ClientesToolStripMenuItem.Text = "Agregar Clientes"
        '
        'VentasRealizadasToolStripMenuItem
        '
        Me.VentasRealizadasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VentasRealizadasToolStripMenuItem.Name = "VentasRealizadasToolStripMenuItem"
        Me.VentasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.VentasRealizadasToolStripMenuItem.Text = "Ventas Realizadas"
        '
        'ComprasRealizadasToolStripMenuItem
        '
        Me.ComprasRealizadasToolStripMenuItem.Enabled = False
        Me.ComprasRealizadasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ComprasRealizadasToolStripMenuItem.Name = "ComprasRealizadasToolStripMenuItem"
        Me.ComprasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.ComprasRealizadasToolStripMenuItem.Text = "Compras Realizadas"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 65)
        Me.Panel1.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 42)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Agregar Producto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(856, 11)
        Me.Panel2.TabIndex = 52
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(407, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 43)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "&GUARDAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.carpeta2
        Me.Button4.Location = New System.Drawing.Point(407, 117)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(217, 115)
        Me.Button4.TabIndex = 57
        Me.Button4.Text = "Tablas de Productos"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Gerente_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(856, 301)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Nombre_ProductoLabel)
        Me.Controls.Add(StrockLabel)
        Me.Controls.Add(Precio_UnitarioLabel)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Gerente_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIO/Productos"
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionesDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MarcasTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents AgregarCajeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
