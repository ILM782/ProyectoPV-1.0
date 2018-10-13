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
        Call TextBox5_TextChanged(sender, e) 'COMPLETA LA GRILLA 
        'Me.ProductoBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim consulta1 As Integer
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" Then
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
                ' Me.ProductoBindingSource.AddNew()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox1.Focus()
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Gerente_Agregar_Categoria.Show()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

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
                Cadena = ProductoBindingSource.Current("ID_Producto").ToString.Substring(0, Len(TextBox5.Text))
                'ejemplo de error descripcion valor "maria"    caja de texto "mariano" len da 7 y maria tiene solo 5 tira error
            Catch ex As Exception 'ante cualquier error
                Cadena = ""

            End Try
            'ucase para pasarlo a mayuscula

            If UCase(Cadena) = UCase(TextBox5.Text) Then
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
       

        TextBox5.Focus()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged


        If CheckBox1.Checked = True Then
            Me.ProductoBindingSource.AddNew()
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = False
          
            Else
            If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" Then

                MsgBox("Campos esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
                CheckBox1.Checked = True
                TextBox1.Focus()

            Else
                Me.ProductoBindingSource.EndEdit()
                Me.ProductoTableAdapter.Fill(MayoristaBaseDeDatosDataSet.Producto)
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = True

            End If
           
        End If
    End Sub
End Class