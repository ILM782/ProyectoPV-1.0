<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana_Principal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CAJAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicializacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APERTURADeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CIERREDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTADISTICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaPorUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarEntradaDeMercaderiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERSIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContenidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.Btn_Salir2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGEADO"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CAJAToolStripMenuItem, Me.VENTASToolStripMenuItem, Me.CLIENTEToolStripMenuItem, Me.ESTADISTICAToolStripMenuItem, Me.PROVEEDORESToolStripMenuItem, Me.SALIRToolStripMenuItem, Me.ToolStripMenuItem1, Me.VERSIONToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CAJAToolStripMenuItem
        '
        Me.CAJAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicializacionToolStripMenuItem})
        Me.CAJAToolStripMenuItem.Name = "CAJAToolStripMenuItem"
        Me.CAJAToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CAJAToolStripMenuItem.Text = "CAJA"
        '
        'InicializacionToolStripMenuItem
        '
        Me.InicializacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.APERTURADeCajaToolStripMenuItem, Me.CIERREDeCajaToolStripMenuItem})
        Me.InicializacionToolStripMenuItem.Name = "InicializacionToolStripMenuItem"
        Me.InicializacionToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.InicializacionToolStripMenuItem.Text = "Inicializacion"
        '
        'APERTURADeCajaToolStripMenuItem
        '
        Me.APERTURADeCajaToolStripMenuItem.Name = "APERTURADeCajaToolStripMenuItem"
        Me.APERTURADeCajaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.APERTURADeCajaToolStripMenuItem.Text = "APERTURA de caja"
        '
        'CIERREDeCajaToolStripMenuItem
        '
        Me.CIERREDeCajaToolStripMenuItem.Name = "CIERREDeCajaToolStripMenuItem"
        Me.CIERREDeCajaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CIERREDeCajaToolStripMenuItem.Text = "CIERRE de caja"
        '
        'VENTASToolStripMenuItem
        '
        Me.VENTASToolStripMenuItem.Checked = True
        Me.VENTASToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VENTASToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.VENTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.BusquedaDeComprobantesToolStripMenuItem})
        Me.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        Me.VENTASToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VENTASToolStripMenuItem.Text = "VENTAS"
        Me.VENTASToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva Venta"
        '
        'BusquedaDeComprobantesToolStripMenuItem
        '
        Me.BusquedaDeComprobantesToolStripMenuItem.Name = "BusquedaDeComprobantesToolStripMenuItem"
        Me.BusquedaDeComprobantesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.BusquedaDeComprobantesToolStripMenuItem.Text = "Busqueda de comprobantes"
        '
        'CLIENTEToolStripMenuItem
        '
        Me.CLIENTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaDeClienteToolStripMenuItem})
        Me.CLIENTEToolStripMenuItem.Name = "CLIENTEToolStripMenuItem"
        Me.CLIENTEToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CLIENTEToolStripMenuItem.Text = "CLIENTE"
        '
        'BusquedaDeClienteToolStripMenuItem
        '
        Me.BusquedaDeClienteToolStripMenuItem.Name = "BusquedaDeClienteToolStripMenuItem"
        Me.BusquedaDeClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BusquedaDeClienteToolStripMenuItem.Text = "Tabla Cliente"
        '
        'ESTADISTICAToolStripMenuItem
        '
        Me.ESTADISTICAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaPorUsuarioToolStripMenuItem, Me.ArticulosVendidosToolStripMenuItem})
        Me.ESTADISTICAToolStripMenuItem.Name = "ESTADISTICAToolStripMenuItem"
        Me.ESTADISTICAToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.ESTADISTICAToolStripMenuItem.Text = "ESTADISTICA"
        '
        'VentaPorUsuarioToolStripMenuItem
        '
        Me.VentaPorUsuarioToolStripMenuItem.Name = "VentaPorUsuarioToolStripMenuItem"
        Me.VentaPorUsuarioToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.VentaPorUsuarioToolStripMenuItem.Text = "Venta por Usuario"
        '
        'ArticulosVendidosToolStripMenuItem
        '
        Me.ArticulosVendidosToolStripMenuItem.Name = "ArticulosVendidosToolStripMenuItem"
        Me.ArticulosVendidosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ArticulosVendidosToolStripMenuItem.Text = "Articulos vendidos"
        '
        'PROVEEDORESToolStripMenuItem
        '
        Me.PROVEEDORESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BuscarEntradaDeMercaderiaToolStripMenuItem})
        Me.PROVEEDORESToolStripMenuItem.Name = "PROVEEDORESToolStripMenuItem"
        Me.PROVEEDORESToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.PROVEEDORESToolStripMenuItem.Text = "PROVEEDORES"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AltaToolStripMenuItem.Text = "Alta entrade de mercaderia"
        '
        'BuscarEntradaDeMercaderiaToolStripMenuItem
        '
        Me.BuscarEntradaDeMercaderiaToolStripMenuItem.Name = "BuscarEntradaDeMercaderiaToolStripMenuItem"
        Me.BuscarEntradaDeMercaderiaToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.BuscarEntradaDeMercaderiaToolStripMenuItem.Text = "Buscar entrada de mercaderia"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.SALIRToolStripMenuItem.Text = "&IR A LOGIN"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'VERSIONToolStripMenuItem
        '
        Me.VERSIONToolStripMenuItem.Name = "VERSIONToolStripMenuItem"
        Me.VERSIONToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.VERSIONToolStripMenuItem.Text = "Versión"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContenidoToolStripMenuItem, Me.ÍndiceToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.toolStripSeparator5, Me.AcercadeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'ContenidoToolStripMenuItem
        '
        Me.ContenidoToolStripMenuItem.Name = "ContenidoToolStripMenuItem"
        Me.ContenidoToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ContenidoToolStripMenuItem.Text = "&Contenido"
        '
        'ÍndiceToolStripMenuItem
        '
        Me.ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ÍndiceToolStripMenuItem.Text = "Índic&e"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.BuscarToolStripMenuItem.Text = "&Buscar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(132, 6)
        '
        'AcercadeToolStripMenuItem
        '
        Me.AcercadeToolStripMenuItem.Name = "AcercadeToolStripMenuItem"
        Me.AcercadeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercadeToolStripMenuItem.Text = "&Acerca de..."
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizarToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'PersonalizarToolStripMenuItem
        '
        Me.PersonalizarToolStripMenuItem.Name = "PersonalizarToolStripMenuItem"
        Me.PersonalizarToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.PersonalizarToolStripMenuItem.Text = "&Personalizar"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Location = New System.Drawing.Point(56, 183)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(226, 40)
        Me.Btn_Salir.TabIndex = 6
        Me.Btn_Salir.Text = "SALIR"
        Me.Btn_Salir.UseVisualStyleBackColor = False
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(175, 150)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(9, 8)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(175, 175)
        Me.ToolStripContainer1.TabIndex = 7
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.BackColor = System.Drawing.Color.DarkGray
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.Btn_Salir2)
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.PictureBox1)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(848, 315)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(848, 339)
        Me.ToolStripContainer2.TabIndex = 8
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'Btn_Salir2
        '
        Me.Btn_Salir2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir2.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Salir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir2.Location = New System.Drawing.Point(619, 243)
        Me.Btn_Salir2.Name = "Btn_Salir2"
        Me.Btn_Salir2.Size = New System.Drawing.Size(194, 40)
        Me.Btn_Salir2.TabIndex = 7
        Me.Btn_Salir2.Text = "&SALIR"
        Me.Btn_Salir2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._32841
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(848, 315)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(848, 339)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ventana_Principal"
        Me.Text = "AppComercio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents VENTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaDeComprobantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAJAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InicializacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APERTURADeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CIERREDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLIENTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusquedaDeClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContenidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROVEEDORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTADISTICAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaPorUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosVendidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarEntradaDeMercaderiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERSIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Salir2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
