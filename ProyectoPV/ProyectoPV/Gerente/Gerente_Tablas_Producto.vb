Public Class Gerente_Tablas_Producto

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Gerente_Agregar_Categoria.Close()
        Gerente_Agregar_Marca.Close()
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_Tablas_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        'TextBox1.Text = "Buscar"
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If TextBox1.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = TextBox1.Text
            fila = Me.ProductoBindingSource.Find("ID_Producto", CodConsulta)
            If fila = -1 Then
                MsgBox("Producto no encontrado", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ProductoBindingSource.Position = fila
                aux = MsgBox("¿Seguro que quiere eliminar el ID: " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.ProductoBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
                    TextBox1.Text = ""
                    TextBox1.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim aux As Object

        If TextBox1.Text = "" Then
            MsgBox("Primero busque localidad", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            If Nombre_ProductoTextBox.Text <> "" And StrockTextBox.Text <> "" And Precio_UnitarioTextBox.Text <> "" And DescripcionTextBox.Text <> "" And ID_MarcaTextBox.Text <> "" And ID_CategoriaTextBox.Text <> "" Then

                aux = MsgBox("¿Seguro que quiere Modificar ?", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.Validate()
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                    Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
                    Me.ProductoBindingSource.MoveLast()
                    TextBox1.Text = ""
                    TextBox1.Focus()
                    Nombre_ProductoTextBox.Text = ""
                    StrockTextBox.Text = ""
                    Precio_UnitarioTextBox.Text = ""
                    DescripcionTextBox.Text = ""
                    ID_MarcaTextBox.Text = ""
                    ID_CategoriaTextBox.Text = ""
                End If
            Else
                MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim aux As Object

        If Nombre_ProductoTextBox.Text <> "" And StrockTextBox.Text <> "" And Precio_UnitarioTextBox.Text <> "" And DescripcionTextBox.Text <> "" Then

            aux = MsgBox("¿Seguro que quiere Modificar ?", MsgBoxStyle.YesNoCancel, "¿Seguro?")
            If aux = vbYes Then
                Me.Validate()
                Me.ProductoBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
                Me.ProductoBindingSource.MoveLast()
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If ID_ProductoTextBox.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = ID_ProductoTextBox.Text
            fila = Me.ProductoBindingSource.Find("ID_Producto", CodConsulta)
            If fila = -1 Then
                MsgBox("Cliente no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ProductoBindingSource.Position = fila
                aux = MsgBox("¿Seguro que quiere eliminar el id: " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.ProductoBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.ProductoBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
                End If
            End If
        End If
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasToolStripMenuItem.Click

        Gerente_Agregar_Marca.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaToolStripMenuItem.Click
        Gerente_Agregar_Categoria.Show()
    End Sub
End Class