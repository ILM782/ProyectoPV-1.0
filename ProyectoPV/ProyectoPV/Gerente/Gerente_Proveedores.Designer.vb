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
        Me.Nombre_EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.Domicilio_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.Telefono_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.ID_LocalidadTextBox = New System.Windows.Forms.TextBox()
        Nombre_EmpresaLabel = New System.Windows.Forms.Label()
        Domicilio_ProveedorLabel = New System.Windows.Forms.Label()
        Telefono_ProveedorLabel = New System.Windows.Forms.Label()
        Correo_ProveedorLabel = New System.Windows.Forms.Label()
        ID_LocalidadLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        ID_LocalidadLabel.Size = New System.Drawing.Size(70, 13)
        ID_LocalidadLabel.TabIndex = 6
        ID_LocalidadLabel.Text = "ID Localidad:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.TransaccionesDeCompraToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VentasOComprasToolStripMenuItem, Me.ComprasRealizadasToolStripMenuItem, Me.LocalidadToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(760, 24)
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
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Compra_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.CajeroTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ventas_ClientesTableAdapter = Nothing
        '
        'Nombre_EmpresaTextBox
        '
        Me.Nombre_EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Nombre_Empresa", True))
        Me.Nombre_EmpresaTextBox.Location = New System.Drawing.Point(122, 46)
        Me.Nombre_EmpresaTextBox.Name = "Nombre_EmpresaTextBox"
        Me.Nombre_EmpresaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_EmpresaTextBox.TabIndex = 5
        '
        'Domicilio_ProveedorTextBox
        '
        Me.Domicilio_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Domicilio_Proveedor", True))
        Me.Domicilio_ProveedorTextBox.Location = New System.Drawing.Point(122, 98)
        Me.Domicilio_ProveedorTextBox.Name = "Domicilio_ProveedorTextBox"
        Me.Domicilio_ProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Domicilio_ProveedorTextBox.TabIndex = 9
        '
        'Telefono_ProveedorTextBox
        '
        Me.Telefono_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Telefono_Proveedor", True))
        Me.Telefono_ProveedorTextBox.Location = New System.Drawing.Point(122, 124)
        Me.Telefono_ProveedorTextBox.Name = "Telefono_ProveedorTextBox"
        Me.Telefono_ProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Telefono_ProveedorTextBox.TabIndex = 11
        '
        'Correo_ProveedorTextBox
        '
        Me.Correo_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "Correo_Proveedor", True))
        Me.Correo_ProveedorTextBox.Location = New System.Drawing.Point(122, 150)
        Me.Correo_ProveedorTextBox.Name = "Correo_ProveedorTextBox"
        Me.Correo_ProveedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Correo_ProveedorTextBox.TabIndex = 13
        '
        'ID_LocalidadTextBox
        '
        Me.ID_LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "ID_Localidad", True))
        Me.ID_LocalidadTextBox.Location = New System.Drawing.Point(122, 72)
        Me.ID_LocalidadTextBox.Name = "ID_LocalidadTextBox"
        Me.ID_LocalidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_LocalidadTextBox.TabIndex = 7
        '
        'Gerente_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(760, 261)
        Me.Controls.Add(Nombre_EmpresaLabel)
        Me.Controls.Add(Me.Nombre_EmpresaTextBox)
        Me.Controls.Add(ID_LocalidadLabel)
        Me.Controls.Add(Me.ID_LocalidadTextBox)
        Me.Controls.Add(Domicilio_ProveedorLabel)
        Me.Controls.Add(Me.Domicilio_ProveedorTextBox)
        Me.Controls.Add(Telefono_ProveedorLabel)
        Me.Controls.Add(Me.Telefono_ProveedorTextBox)
        Me.Controls.Add(Correo_ProveedorLabel)
        Me.Controls.Add(Me.Correo_ProveedorTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Gerente_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Nombre_EmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Domicilio_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Telefono_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComprasRealizadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaccionesDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
