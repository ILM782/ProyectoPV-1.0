Public Class Gerente_Transacciones_de_Compras

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Gerente_Producto.Show()
        Me.Close()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Gerente_Proveedores.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Gerente_TablasClientes.Show()
        Me.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
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

    Private Sub Gerente_Transacciones_de_Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Compra_Proveedor' Puede moverla o quitarla según sea necesario.
        Me.Compra_ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Compra_Proveedor)

    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim consulta1 As Integer
        If ItemsTextBox.Text <> "" And MontoTextBox.Text <> "" And Tipo_De_FacturacionTextBox.Text <> "" Then
            consulta1 = Me.ProductoBindingSource.Find("Nombre_Producto", ComboBox1.Text)

            If consulta1 <> -1 Then
                MsgBox("Producto Repetido", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ProductoBindingSource.Current("Nombre_Producto") = TextBox1.Text
                Me.ProductoBindingSource.Current("Strock") = Val(TextBox2.Text)
                Me.ProductoBindingSource.Current("Precio_Unitario") = Val(TextBox3.Text)
                Me.ProductoBindingSource.Current("Descripcion") = TextBox4.Text
                Me.ProductoBindingSource.Current("ID_Categoria") = Val(ComboBox1.SelectedValue)
                Me.ProductoBindingSource.Current("ID_Marca") = Val(ComboBox2.SelectedValue)
                Me.ProductoBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en discoc
                Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
                Me.ProductoBindingSource.MoveLast()
                MsgBox("El Id del Producto es: " & ProductoBindingSource.Current("ID_Producto"), MsgBoxStyle.Information, " Id Producto ")
                Me.ProductoBindingSource.AddNew()
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub
End Class