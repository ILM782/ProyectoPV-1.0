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
                If TextBox1.Text = "" Then
                Else
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
        'TextBox1.Text = "Buscar"
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

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
End Class