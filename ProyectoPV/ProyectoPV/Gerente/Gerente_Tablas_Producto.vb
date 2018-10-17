Public Class Gerente_Tablas_Producto

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        'arranco con una grilla sin enlazar, traigo las dos grilla enlazada, edito la grilla con las columnas
        'case para elejir atributo con un combobox


        Dim fila, contador, Total, filaConsulta, art, filaConsulta1 As Integer
        Dim Cadena As String
        fila = 0 'ir bajando lineas en el datagrill
        Total = 0 'sumo los subtotales
        filaConsulta = 0
        filaConsulta1 = 0
        DataGridView1.Rows.Clear() 'limpio la grilla cada ves que ingreso un dato 
        ProductoBindingSource.MoveFirst() 'muevo al primer registro de la tabla

        Do
            Try
                Cadena = ProductoBindingSource.Current("ID_Producto").ToString.Substring(0, Len(TextBox1.Text))
                'ejemplo de error descripcion valor "maria"    caja de texto "mariano" len da 7 y maria tiene solo 5 tira error
            Catch ex As Exception 'ante cualquier error
                Cadena = ""

            End Try
            'ucase para pasarlo a mayuscula

            If UCase(Cadena) = UCase(TextBox1.Text) Then
                DataGridView1.Rows.Add() 'columna
                DataGridView1.Item(0, fila).Value = ProductoBindingSource.Current("ID_Producto")
                art = ProductoBindingSource.Current("ID_Producto")


                filaConsulta = Me.MarcasBindingSource.Find("ID_Marca", ProductoBindingSource.Current("ID_Marca")) 'busco relacion id-descripcion blister
                Me.MarcasBindingSource.Position = filaConsulta
                DataGridView1.Item(1, fila).Value = Me.MarcasBindingSource.Current("Marca") 'pego la descripcion no el id

                filaConsulta1 = Me.CategoriaBindingSource.Find("ID_Categoria", ProductoBindingSource.Current("ID_Categoria")) 'busco relacion id-descripcion blister
                Me.CategoriaBindingSource.Position = filaConsulta1
                DataGridView1.Item(2, fila).Value = Me.CategoriaBindingSource.Current("Categoria")

                'continuo pegando datos de la tabla stock
                DataGridView1.Item(3, fila).Value = ProductoBindingSource.Current("Nombre_Producto")
                DataGridView1.Item(4, fila).Value = ProductoBindingSource.Current("Strock")
                DataGridView1.Item(5, fila).Value = ProductoBindingSource.Current("Precio_unitario")
                DataGridView1.Item(6, fila).Value = ProductoBindingSource.Current("Descripcion")
                'pego en la grilla la multiplicacion de cantidad por precio

                fila = fila + 1 'para ir bajando lineas en la grilla

            End If
            contador = contador + 1
            ProductoBindingSource.MoveNext()
        Loop Until contador = ProductoBindingSource.Count


        'creo una fila final con el total a facturar


        TextBox1.Focus()
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
        Call TextBox1_TextChanged(sender, e) 'COMPLETA LA GRILLA 
    End Sub
End Class