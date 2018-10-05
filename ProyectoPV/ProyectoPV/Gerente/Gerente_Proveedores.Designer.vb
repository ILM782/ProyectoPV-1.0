<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Proveedores
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
        Dim Nombre_EmpresaLabel As System.Windows.Forms.Label
        Dim Domicilio_ProveedorLabel As System.Windows.Forms.Label
        Dim Telefono_ProveedorLabel As System.Windows.Forms.Label
        Dim Correo_ProveedorLabel As System.Windows.Forms.Label
        Dim ID_LocalidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Proveedores))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasOComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProveedorTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LocalidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter()
        Me.Txt_Nombre_Empresa = New System.Windows.Forms.TextBox()
        Me.Txt_Domicilio = New System.Windows.Forms.TextBox()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Txt_Correo = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Nombre_EmpresaLabel = New System.Windows.Forms.Label()
        Domicilio_ProveedorLabel = New System.Windows.Forms.Label()
        Telefono_ProveedorLabel = New System.Windows.Forms.Label()
        Correo_ProveedorLabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre_EmpresaLabel
        '
        Nombre_EmpresaLabel.AutoSize = True
        Nombre_EmpresaLabel.Location = New System.Drawing.Point(12, 49)
        Nombre_EmpresaLabel.Name = "Nombre_EmpresaLabel"
        Nombre_EmpresaLabel.Size = New System.Drawing.Size(91, 13)
        Nombre_EmpresaLabel.TabIndex = 4
        Nombre_EmpresaLabel.Text = "Nombre Empresa:"
        '
        'Domicilio_ProveedorLabel
        '
        Domicilio_ProveedorLabel.AutoSize = True
        Domicilio_ProveedorLabel.Location = New System.Drawing.Point(12, 101)
        Domicilio_ProveedorLabel.Name = "Domicilio_ProveedorLabel"
        Domicilio_ProveedorLabel.Size = New System.Drawing.Size(104, 13)
        Domicilio_ProveedorLabel.TabIndex = 8
        Domicilio_ProveedorLabel.Text = "Domicilio Proveedor:"
        '
        'Telefono_ProveedorLabel
        '
        Telefono_ProveedorLabel.AutoSize = True
        Telefono_ProveedorLabel.Location = New System.Drawing.Point(12, 127)
        Telefono_ProveedorLabel.Name = "Telefono_ProveedorLabel"
        Telefono_ProveedorLabel.Size = New System.Drawing.Size(104, 13)
        Telefono_ProveedorLabel.TabIndex = 10
        Telefono_ProveedorLabel.Text = "Telefono Proveedor:"
        '
        'Correo_ProveedorLabel
        '
        Correo_ProveedorLabel.AutoSize = True
        Correo_ProveedorLabel.Location = New System.Drawing.Point(12, 153)
        Correo_ProveedorLabel.Name = "Correo_ProveedorLabel"
        Correo_ProveedorLabel.Size = New System.Drawing.Size(93, 13)
        Correo_ProveedorLabel.TabIndex = 12
        Correo_ProveedorLabel.Text = "Correo Proveedor:"
        '
        'ID_LocalidadLabel
        '
        ID_LocalidadLabel.AutoSize = True
        ID_LocalidadLabel.Location = New System.Drawing.Point(12, 75)
        ID_LocalidadLabel.Name = "ID_LocalidadLabel"
        ID_LocalidadLabel.Size = New System.Drawing.Size(56, 13)
        ID_LocalidadLabel.TabIndex = 6
        ID_LocalidadLabel.Text = "Localidad:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.TransaccionesDeCompraToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VentasOComprasToolStripMenuItem, Me.ComprasRealizadasToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.NuevoToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.NuevoToolStripMenuItem.Text = "Productos"
        '
        'TransaccionesDeCompraToolStripMenuItem
        '
        Me.TransaccionesDeCompraToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TransaccionesDeCompraToolStripMenuItem.Name = "TransaccionesDeCompraToolStripMenuItem"
        Me.TransaccionesDeCompraToolStripMenuItem.Size = New System.Drawing.Size(155, 20)
        Me.TransaccionesDeCompraToolStripMenuItem.Text = "Transacciones de compra"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VentasOComprasToolStripMenuItem
        '
        Me.VentasOComprasToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.VentasOComprasToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasOComprasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VentasOComprasToolStripMenuItem.Name = "VentasOComprasToolStripMenuItem"
        Me.VentasOComprasToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.VentasOComprasToolStripMenuItem.Text = "Ventas Realizadas"
        '
        'ComprasRealizadasToolStripMenuItem
        '
        Me.ComprasRealizadasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ComprasRealizadasToolStripMenuItem.Name = "ComprasRealizadasToolStripMenuItem"
        Me.ComprasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.ComprasRealizadasToolStripMenuItem.Text = "Compras Realizadas"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.VolverToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolverToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Compra_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ventas_ClientesTableAdapter = Nothing
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(147, 176)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 14
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.LocalidadBindingSource
        Me.ComboBox1.DisplayMember = "Localidad_Localidad"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(122, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.ValueMember = "ID_Localidad"
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
        'Txt_Nombre_Empresa
        '
        Me.Txt_Nombre_Empresa.Location = New System.Drawing.Point(122, 46)
        Me.Txt_Nombre_Empresa.Name = "Txt_Nombre_Empresa"
        Me.Txt_Nombre_Empresa.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Nombre_Empresa.TabIndex = 16
        '
        'Txt_Domicilio
        '
        Me.Txt_Domicilio.Location = New System.Drawing.Point(122, 98)
        Me.Txt_Domicilio.Name = "Txt_Domicilio"
        Me.Txt_Domicilio.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Domicilio.TabIndex = 17
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(122, 124)
        Me.Txt_Telefono.MaxLength = 11
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Telefono.TabIndex = 18
        '
        'Txt_Correo
        '
        Me.Txt_Correo.Location = New System.Drawing.Point(122, 150)
        Me.Txt_Correo.Name = "Txt_Correo"
        Me.Txt_Correo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Correo.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(366, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Buscar Proveedor:"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(391, 76)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 22
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(46, 224)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(843, 250)
        Me.DataGridView1.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id Proveedor"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre de Empresa "
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Localidad "
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Provincia"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Codigo Postal"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Domicilio"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Telefono"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Correo"
        Me.Column8.Name = "Column8"
        '
        'Gerente_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 486)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Txt_Correo)
        Me.Controls.Add(Me.Txt_Telefono)
        Me.Controls.Add(Me.Txt_Domicilio)
        Me.Controls.Add(Me.Txt_Nombre_Empresa)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Nombre_EmpresaLabel)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Domicilio_ProveedorLabel)
        Me.Controls.Add(Telefono_ProveedorLabel)
        Me.Controls.Add(Correo_ProveedorLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Gerente_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasOComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.ProveedorTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComprasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionesDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LocalidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LocalidadTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.LocalidadTableAdapter
    Friend WithEvents Txt_Nombre_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Domicilio As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Correo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
