<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Agregar_Categoria
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
        Dim CategoriaLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Agregar_Categoria))
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Buscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.CategoriaTextBox1 = New System.Windows.Forms.TextBox()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CategoriaLabel = New System.Windows.Forms.Label()
        CategoriaLabel1 = New System.Windows.Forms.Label()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CategoriaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.BackColor = System.Drawing.Color.Transparent
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.ForeColor = System.Drawing.Color.Black
        CategoriaLabel.Location = New System.Drawing.Point(25, 128)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(62, 16)
        CategoriaLabel.TabIndex = 3
        CategoriaLabel.Text = "Categoria:"
        '
        'CategoriaLabel1
        '
        CategoriaLabel1.AutoSize = True
        CategoriaLabel1.Location = New System.Drawing.Point(25, 313)
        CategoriaLabel1.Name = "CategoriaLabel1"
        CategoriaLabel1.Size = New System.Drawing.Size(55, 13)
        CategoriaLabel1.TabIndex = 58
        CategoriaLabel1.Text = "Categoria:"
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Me.CategoriaTableAdapter
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        Me.TableAdapterManager.VentaVistaTableAdapter = Nothing
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolveToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VolveToolStripMenuItem
        '
        Me.VolveToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VolveToolStripMenuItem.Name = "VolveToolStripMenuItem"
        Me.VolveToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolveToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CategoriaDataGridView
        '
        Me.CategoriaDataGridView.AllowUserToAddRows = False
        Me.CategoriaDataGridView.AllowUserToDeleteRows = False
        Me.CategoriaDataGridView.AutoGenerateColumns = False
        Me.CategoriaDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoriaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.CategoriaDataGridView.DataSource = Me.CategoriaBindingSource
        Me.CategoriaDataGridView.Enabled = False
        Me.CategoriaDataGridView.EnableHeadersVisualStyles = False
        Me.CategoriaDataGridView.GridColor = System.Drawing.Color.Black
        Me.CategoriaDataGridView.Location = New System.Drawing.Point(283, 123)
        Me.CategoriaDataGridView.Name = "CategoriaDataGridView"
        Me.CategoriaDataGridView.Size = New System.Drawing.Size(243, 262)
        Me.CategoriaDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Categoria"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Categoria"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Buscar Categoria:"
        '
        'Txt_Buscar
        '
        Me.Txt_Buscar.Location = New System.Drawing.Point(131, 219)
        Me.Txt_Buscar.Name = "Txt_Buscar"
        Me.Txt_Buscar.Size = New System.Drawing.Size(131, 20)
        Me.Txt_Buscar.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(549, 10)
        Me.Panel2.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 60)
        Me.Panel1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 42)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Categorias"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Guardar.FlatAppearance.BorderSize = 0
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.Location = New System.Drawing.Point(25, 162)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(237, 40)
        Me.Btn_Guardar.TabIndex = 2
        Me.Btn_Guardar.Text = "&GUARDAR"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Location = New System.Drawing.Point(25, 255)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(237, 40)
        Me.Btn_Eliminar.TabIndex = 4
        Me.Btn_Eliminar.Text = "&ELIMINAR"
        Me.Btn_Eliminar.UseVisualStyleBackColor = False
        '
        'CategoriaTextBox1
        '
        Me.CategoriaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriaBindingSource, "Categoria", True))
        Me.CategoriaTextBox1.Location = New System.Drawing.Point(131, 310)
        Me.CategoriaTextBox1.Name = "CategoriaTextBox1"
        Me.CategoriaTextBox1.Size = New System.Drawing.Size(131, 20)
        Me.CategoriaTextBox1.TabIndex = 5
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Modificar.FlatAppearance.BorderSize = 0
        Me.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Location = New System.Drawing.Point(25, 345)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(237, 40)
        Me.Btn_Modificar.TabIndex = 6
        Me.Btn_Modificar.Text = "&MODIFICAR"
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 123)
        Me.TextBox1.MaxLength = 60
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Gerente_Agregar_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(549, 410)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(CategoriaLabel1)
        Me.Controls.Add(Me.CategoriaTextBox1)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txt_Buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CategoriaDataGridView)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Gerente_Agregar_Categoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMERCIO / Categorias"
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CategoriaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents CategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriaTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VolveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents CategoriaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
