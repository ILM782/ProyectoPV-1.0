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
        Dim ID_MarcaLabel As System.Windows.Forms.Label
        Dim ID_CategoriaLabel As System.Windows.Forms.Label
        Dim Nombre_ProductoLabel As System.Windows.Forms.Label
        Dim StrockLabel As System.Windows.Forms.Label
        Dim Precio_UnitarioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ID_ProductoLabel As System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Uniatrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Strock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProductoTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.CategoriaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter()
        Me.MarcasTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.ID_MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.ID_CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nombre_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StrockTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        ID_MarcaLabel = New System.Windows.Forms.Label()
        ID_CategoriaLabel = New System.Windows.Forms.Label()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        StrockLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ID_ProductoLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_MarcaLabel
        '
        ID_MarcaLabel.AutoSize = True
        ID_MarcaLabel.Location = New System.Drawing.Point(25, 346)
        ID_MarcaLabel.Name = "ID_MarcaLabel"
        ID_MarcaLabel.Size = New System.Drawing.Size(40, 13)
        ID_MarcaLabel.TabIndex = 63
        ID_MarcaLabel.Text = "Marca:"
        '
        'ID_CategoriaLabel
        '
        ID_CategoriaLabel.AutoSize = True
        ID_CategoriaLabel.Location = New System.Drawing.Point(25, 372)
        ID_CategoriaLabel.Name = "ID_CategoriaLabel"
        ID_CategoriaLabel.Size = New System.Drawing.Size(55, 13)
        ID_CategoriaLabel.TabIndex = 65
        ID_CategoriaLabel.Text = "Categoria:"
        '
        'Nombre_ProductoLabel
        '
        Nombre_ProductoLabel.AutoSize = True
        Nombre_ProductoLabel.Location = New System.Drawing.Point(25, 242)
        Nombre_ProductoLabel.Name = "Nombre_ProductoLabel"
        Nombre_ProductoLabel.Size = New System.Drawing.Size(93, 13)
        Nombre_ProductoLabel.TabIndex = 67
        Nombre_ProductoLabel.Text = "Nombre Producto:"
        '
        'StrockLabel
        '
        StrockLabel.AutoSize = True
        StrockLabel.Location = New System.Drawing.Point(25, 268)
        StrockLabel.Name = "StrockLabel"
        StrockLabel.Size = New System.Drawing.Size(38, 13)
        StrockLabel.TabIndex = 69
        StrockLabel.Text = "Stock:"
        '
        'Precio_UnitarioLabel
        '
        Precio_UnitarioLabel.AutoSize = True
        Precio_UnitarioLabel.Location = New System.Drawing.Point(25, 294)
        Precio_UnitarioLabel.Name = "Precio_UnitarioLabel"
        Precio_UnitarioLabel.Size = New System.Drawing.Size(79, 13)
        Precio_UnitarioLabel.TabIndex = 71
        Precio_UnitarioLabel.Text = "Precio Unitario:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(25, 320)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 73
        DescripcionLabel.Text = "Descripcion:"
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.Location = New System.Drawing.Point(25, 216)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(67, 13)
        ID_ProductoLabel.TabIndex = 75
        ID_ProductoLabel.Text = "ID Producto:"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Precio_Uniatrio
        '
        Me.Precio_Uniatrio.HeaderText = "Precio Unitario"
        Me.Precio_Uniatrio.Name = "Precio_Uniatrio"
        Me.Precio_Uniatrio.ReadOnly = True
        '
        'Strock
        '
        Me.Strock.HeaderText = "Stock"
        Me.Strock.Name = "Strock"
        Me.Strock.ReadOnly = True
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.HeaderText = "Nombre Producto"
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.ReadOnly = True
        '
        'ID_Categoria
        '
        Me.ID_Categoria.HeaderText = "Categoria"
        Me.ID_Categoria.Name = "ID_Categoria"
        Me.ID_Categoria.ReadOnly = True
        '
        'ID_Marca
        '
        Me.ID_Marca.HeaderText = "Marca"
        Me.ID_Marca.Name = "ID_Marca"
        Me.ID_Marca.ReadOnly = True
        '
        'ID_Producto
        '
        Me.ID_Producto.HeaderText = "Id Producto "
        Me.ID_Producto.Name = "ID_Producto"
        Me.ID_Producto.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Producto, Me.ID_Marca, Me.ID_Categoria, Me.Nombre_Producto, Me.Strock, Me.Precio_Uniatrio, Me.Descripcion})
        Me.DataGridView1.Location = New System.Drawing.Point(308, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(744, 227)
        Me.DataGridView1.TabIndex = 55
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1072, 24)
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
        Me.Panel1.Size = New System.Drawing.Size(1072, 65)
        Me.Panel1.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 10)
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
        Me.Panel2.Size = New System.Drawing.Size(1072, 11)
        Me.Panel2.TabIndex = 58
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 59
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Buscar Producto:"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Location = New System.Drawing.Point(124, 162)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(136, 32)
        Me.Btn_Eliminar.TabIndex = 61
        Me.Btn_Eliminar.Text = "&Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = False
        '
        'ID_MarcaTextBox
        '
        Me.ID_MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "Marca", True))
        Me.ID_MarcaTextBox.Location = New System.Drawing.Point(124, 343)
        Me.ID_MarcaTextBox.Name = "ID_MarcaTextBox"
        Me.ID_MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_MarcaTextBox.TabIndex = 64
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
        'ID_CategoriaTextBox
        '
        Me.ID_CategoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "Categoria", True))
        Me.ID_CategoriaTextBox.Location = New System.Drawing.Point(124, 369)
        Me.ID_CategoriaTextBox.Name = "ID_CategoriaTextBox"
        Me.ID_CategoriaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_CategoriaTextBox.TabIndex = 66
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'Nombre_ProductoTextBox
        '
        Me.Nombre_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Nombre_Producto", True))
        Me.Nombre_ProductoTextBox.Location = New System.Drawing.Point(124, 239)
        Me.Nombre_ProductoTextBox.Name = "Nombre_ProductoTextBox"
        Me.Nombre_ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_ProductoTextBox.TabIndex = 68
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'StrockTextBox
        '
        Me.StrockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Strock", True))
        Me.StrockTextBox.Location = New System.Drawing.Point(124, 265)
        Me.StrockTextBox.Name = "StrockTextBox"
        Me.StrockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StrockTextBox.TabIndex = 70
        '
        'Precio_UnitarioTextBox
        '
        Me.Precio_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Precio_Unitario", True))
        Me.Precio_UnitarioTextBox.Location = New System.Drawing.Point(124, 291)
        Me.Precio_UnitarioTextBox.Name = "Precio_UnitarioTextBox"
        Me.Precio_UnitarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Precio_UnitarioTextBox.TabIndex = 72
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(124, 317)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 74
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(124, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 32)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "&Modificar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "ID_Producto", True))
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(124, 213)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_ProductoTextBox.TabIndex = 76
        '
        'Gerente_Tablas_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1072, 447)
        Me.Controls.Add(ID_ProductoLabel)
        Me.Controls.Add(Me.ID_ProductoTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ID_MarcaLabel)
        Me.Controls.Add(Me.ID_MarcaTextBox)
        Me.Controls.Add(ID_CategoriaLabel)
        Me.Controls.Add(Me.ID_CategoriaTextBox)
        Me.Controls.Add(Nombre_ProductoLabel)
        Me.Controls.Add(Me.Nombre_ProductoTextBox)
        Me.Controls.Add(StrockLabel)
        Me.Controls.Add(Me.StrockTextBox)
        Me.Controls.Add(Precio_UnitarioLabel)
        Me.Controls.Add(Me.Precio_UnitarioTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Gerente_Tablas_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de Producto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_Uniatrio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Strock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents ID_MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_CategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StrockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_UnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
End Class
