Public Class Gerente_Productos

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        Me.ProductoBindingSource.AddNew()

    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        Gerente_Ventas_Realizadas.Show()
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Gerente_Agregar_Marca.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Gerente_Agregar_Categoria.Show()
    End Sub

    Private Sub MarcasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MarcasBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim categoria As Integer
        ' Dim marca As Integer
        'If CategoriaTextBox.Text <> "" Then

        'categoria = Me.CategoriaBindingSource.Find("Categoria", CategoriaTextBox.Text)
        'If categoria <> -1 Then
        'If MarcaTextBox.Text <> "" Then

        'marca = Me.MarcasBindingSource.Find("Marca", MarcaTextBox.Text)
        '  If marca <> -1 Then

        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        Me.ProductoBindingSource.MoveLast()
        Me.ProductoBindingSource.AddNew()
        MsgBox("EXITO")
        ' Else
        ' MsgBox("Marca no encontrada")
        'End If
        ' Else
        'MsgBox("El campo esta vacio")
        'End If

        ' Else
        ' MsgBox("Categoria no encontrada")
        ' End If
        ' Else
        ' MsgBox("El campo esta vacio")
        '  End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila2 As Integer
        If CategoriaComboBox.Text <> "" Then

            fila2 = Me.CategoriaBindingSource1.Find("Categoria", CategoriaComboBox.Text)
            If fila2 <> -1 Then

                Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)

            End If
        End If
        Dim fila3 As Integer
        If MarcaComboBox.Text <> "" Then

            fila3 = Me.MarcasBindingSource1.Find("Marca", MarcaComboBox.Text)
            If fila3 <> -1 Then

                Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)

            End If
        End If
    End Sub
    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        Gerente_Transacciones_de_Compras.Show()
        Me.Close()
    End Sub

    Private Sub ComprasRealizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasRealizadasToolStripMenuItem.Click
        Gerente_Compras_Realizadas.Show()
        Me.Close()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Gerente_Localidad.Show()
        Me.Close()
    End Sub
End Class