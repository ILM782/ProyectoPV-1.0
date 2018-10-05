<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gerente_Agregar_Marca
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
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerente_Agregar_Marca))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MayoristaBaseDeDatosDataSet = New WindowsApplication1.MayoristaBaseDeDatosDataSet()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasTableAdapter = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.MarcasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        MarcaLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(35, 38)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(44, 16)
        MarcaLabel.TabIndex = 4
        MarcaLabel.Text = "Marca:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(319, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.VolverToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MayoristaBaseDeDatosDataSet
        '
        Me.MayoristaBaseDeDatosDataSet.DataSetName = "MayoristaBaseDeDatosDataSet"
        Me.MayoristaBaseDeDatosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.MayoristaBaseDeDatosDataSet
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CajeroTableAdapter = Nothing
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Compra_ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.LocalidadTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.ProveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Ventas_ClientesTableAdapter = Nothing
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "Marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(87, 36)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MarcaTextBox.TabIndex = 5
        '
        'MarcasDataGridView
        '
        Me.MarcasDataGridView.AllowUserToAddRows = False
        Me.MarcasDataGridView.AllowUserToDeleteRows = False
        Me.MarcasDataGridView.AutoGenerateColumns = False
        Me.MarcasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MarcasDataGridView.CausesValidation = False
        Me.MarcasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarcasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.MarcasDataGridView.DataSource = Me.MarcasBindingSource
        Me.MarcasDataGridView.Enabled = False
        Me.MarcasDataGridView.EnableHeadersVisualStyles = False
        Me.MarcasDataGridView.Location = New System.Drawing.Point(38, 88)
        Me.MarcasDataGridView.Name = "MarcasDataGridView"
        Me.MarcasDataGridView.ReadOnly = True
        Me.MarcasDataGridView.Size = New System.Drawing.Size(244, 232)
        Me.MarcasDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Marca"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Marca"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 101
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.Location = New System.Drawing.Point(207, 33)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Guardar.TabIndex = 6
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(113, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha:"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.Black
        Me.Fecha.Location = New System.Drawing.Point(149, 323)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(42, 16)
        Me.Fecha.TabIndex = 8
        Me.Fecha.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(224, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hora:"
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Hora.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.ForeColor = System.Drawing.Color.Black
        Me.Hora.Location = New System.Drawing.Point(253, 323)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(50, 16)
        Me.Hora.TabIndex = 10
        Me.Hora.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Buscar:"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Location = New System.Drawing.Point(207, 61)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Eliminar.TabIndex = 14
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Gerente_Agregar_Marca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(319, 347)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.MarcasDataGridView)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Gerente_Agregar_Marca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcas"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MayoristaBaseDeDatosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MayoristaBaseDeDatosDataSet As WindowsApplication1.MayoristaBaseDeDatosDataSet
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.MayoristaBaseDeDatosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fecha As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Hora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
