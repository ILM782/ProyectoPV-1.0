Public Class Productos

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        Me.CategoriaBindingSource.AddNew()
        Me.MarcasBindingSource.AddNew()
        Me.ProductoBindingSource.AddNew()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim categoria As Integer
        Dim marca As Integer

        If Txt_Categoria.Text <> "" Then

            categoria = Me.CategoriaBindingSource.Find("Categoria", Txt_Categoria.Text)
            If categoria <> -1 Then
                If Txt_Marca.Text <> "" Then

                    marca = Me.MarcasBindingSource.Find("Marca", Txt_Marca.Text)
                    If marca <> -1 Then
                       
                        Me.ProductoBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
                        Me.ProductoBindingSource.MoveLast()
                        Me.ProductoBindingSource.AddNew()
                        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
                        MsgBox("EXITO")
                    Else
                        MsgBox("Marca no encontrada")
                    End If
                Else
                    MsgBox("El campo esta vacio")
                End If

            Else
                MsgBox("Categoria no encontrada")
            End If
        Else
            MsgBox("El campo esta vacio")
        End If





    End Sub

    Private Sub Txt_Categoria_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Categoria_Guardar.Click
      
        Dim Consulta As Integer
        If CategoriaTextBox.Text <> "" Then

            Consulta = Me.CategoriaBindingSource.Find("Categoria", CategoriaTextBox.Text)
            If Consulta <> -1 Then
                MsgBox("Categoria Repetida")

            Else
                Me.CategoriaBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en discoc
                Me.CategoriaBindingSource.MoveLast()
                Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
                Me.CategoriaBindingSource.AddNew()

            End If
        Else
            MsgBox("El campo esta vacio")
        End If
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Btn_Marca_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Marca_Guardar.Click
   
        Dim Consulta As Integer
        If MarcaTextBox.Text <> "" Then

            Consulta = Me.MarcasBindingSource.Find("Marca", MarcaTextBox.Text)
            If Consulta <> -1 Then

                MsgBox("Marca Repetida")
            Else
                Me.MarcasBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en discoc
                Me.MarcasBindingSource.MoveLast()
                Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)
                Me.MarcasBindingSource.AddNew()
            End If
        Else
            MsgBox("El campo esta vacio")
        End If
    End Sub


   

  
End Class