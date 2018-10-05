Public Class Gerente_Compras_Realizadas

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Gerente_Producto.Show()
        Me.Close()
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarToolStripMenuItem.Click
        Gerente_Proveedores.Show()
        Me.Close()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Gerente_Transacciones_de_Compras.Show()
        Me.Close()
    End Sub

    Private Sub VentasRealizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasRealizadasToolStripMenuItem.Click
        Gerente_TablasClientes.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Gerente_Ventas_Realizadas.Show()
        Me.Close()
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        Atributos_De_Gerente.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Gerente_Localidad.Show()
        Me.Close()
    End Sub

    Private Sub Compra_ProveedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Compra_ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_Compras_Realizadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Compra_Proveedor' Puede moverla o quitarla según sea necesario.
        Me.Compra_ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Compra_Proveedor)
        Me.Compra_ProveedorBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ItemsTextBox.Text = "" Or MontoTextBox.Text = "" Or Tipo_De_FacturacionTextBox.Text = "" Then
            MsgBox("Algun campo vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            ' Me.ProductoBindingSource.Current("Nombre_Producto") = Nombre_ProductoTextBox.Text
            ' Me.ProductoBindingSource.Current("Strock") = Val(StrockTextBox.Text)
            ' Me.ProductoBindingSource.Current("Precio_Unitario") = Val(Precio_UnitarioTextBox.Text)
            'Me.ProductoBindingSource.Current("Descripcion") = DescripcionTextBox.Text
            Me.Compra_ProveedorBindingSource.Current("ID_Producto") = Val(ComboBox1.SelectedValue)

            Me.Compra_ProveedorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disc
            Me.Compra_ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Compra_Proveedor) 'actualizo la base
            Me.Compra_ProveedorBindingSource.AddNew()

        End If
    End Sub
End Class