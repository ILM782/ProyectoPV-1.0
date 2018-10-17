Public Class Gerente_Producto

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Gerente_Localidad.Show()
        Me.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Atributos_De_Gerente.Show()
        Me.Close()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem.Click
        Gerente_Proveedores.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Gerente_TablasClientes.Show()
        Me.Close()
    End Sub

    Private Sub TransaccionesDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionesDeCompraToolStripMenuItem.Click
        Gerente_Transacciones_de_Compras.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Gerente_Agregar_Marca.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        e.KeyChar = ChrW(solonumeros(e))
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        e.KeyChar = ChrW(Coma(e))
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        ComboBox1.Text = "Seleccionar"
        ComboBox2.Text = "Seleccionar"
        Me.ProductoBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim consulta1 As Integer
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And ComboBox1.Text <> "Seleccionar" And ComboBox2.Text <> "Seleccionar" Then
            consulta1 = Me.ProductoBindingSource.Find("Nombre_Producto", TextBox1.Text)

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
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox1.Focus()
                ComboBox1.Text = "Seleccionar"
                ComboBox2.Text = "Seleccionar"
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Gerente_Agregar_Categoria.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Gerente_Tablas_Producto.Show()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = ChrW(sin_letras(e))
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.KeyChar = ChrW(sin_letras(e))
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub VentasRealizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasRealizadasToolStripMenuItem.Click
        Gerente_Ventas_Realizadas.Show()
        Me.Close()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Gerente_Transacciones_de_Compras.Show()
        Me.Close()
    End Sub

    Private Sub AgregarCajeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCajeroToolStripMenuItem.Click
        Gerente_Agregar_Cajero.Show()
        Me.Close()
    End Sub

End Class