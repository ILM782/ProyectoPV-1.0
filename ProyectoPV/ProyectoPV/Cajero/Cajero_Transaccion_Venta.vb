Public Class Cajero_Transaccion_Venta

    'Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
    'Dim fila As Integer
    'If Txt_Categoria.Text <> "" Then

    'fila = Me.CategoriaBindingSource.Find("Categoria", Txt_Categoria.Text)
    'If fila <> -1 Then
    'Else
    'MsgBox("Categoria no encontrada")
    'End If
    'Else
    'MsgBox("El campo esta vacio")
    'End If
    'End Sub

    'BARRA SUPERIOR
    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Atributos_De_Cajero.Show()
        Me.Close()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Cajero_Producto_Para_Ventas.Show()
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        Cajero_Agregar_Cliente.Show()
    End Sub

    Private Sub AgregarLocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarLocalidadToolStripMenuItem.Click
        Cajero_Localidad.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
            Exit Sub
        End If
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Cajero_Transaccion_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cajero' Puede moverla o quitarla según sea necesario.
        Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Venta)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)

    End Sub

    Private Sub VentaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub ID_ProductoTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ID_ProductoTextBox.LostFocus
        'este evento se ejecuta cuando pierdo el foco
        Dim vista As New DataView 'creo e instancio el objeto
        vista.Table = Me.MayoristaBaseDeDatosDataSet.Producto
        vista.RowFilter = "ID_Producto = " & Val(Me.ID_ProductoTextBox.Text)
        Me.ProductoDataGridView.DataSource = vista
    End Sub

    Private Sub ID_ProductoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_ProductoTextBox.TextChanged
        'este evento se ejcuta cuando hay un cambio en el texbox
        Dim vista As New DataView
        vista.Table = Me.MayoristaBaseDeDatosDataSet.Producto
        vista.RowFilter = "ID_Producto = " & Val(Me.ID_ProductoTextBox.Text)
        Me.ProductoDataGridView.DataSource = vista 'ACTUALIZO LA GRILLA
    End Sub

    Private Sub Btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Vender.Click
        Dim fila, CodConsulta, aux, importe As Integer
        CodConsulta = Val(ID_ProductoTextBox.Text) '
        fila = Me.ProductoBindingSource.Find("ID_Producto", CodConsulta) 'me dice la posicion arranca de 0
        If fila = -1 Then
            'no se encontro ultimo registro es -1
            MsgBox("El registro no se encontro")
        Else
            'Se encontro
            ProductoBindingSource.Position = fila ' Mover el cursor a la fila obtenida con esto muestro
            aux = MsgBox("Quiere realizar esta venta Cod_articulo: " & CodConsulta, 32 + 1, "Vender")
            If aux = 1 Then
                If ProductoBindingSource.Current("Strock") >= Val(Cantidad_VentaTextBox.Text) Then 'si true puedo vender
                    'guardo la transaccion en la tabla venta-----------------------------------------------

                    Me.VentaBindingSource.AddNew()
                    Me.VentaBindingSource.Current("ID_Producto") = ProductoBindingSource.Current("ID_Producto")
                    Me.VentaBindingSource.Current("Cantidad_Venta") = Val(Cantidad_VentaTextBox.Text)
                    ' --------------------------------------- Me.VentaBindingSource.Current("precio") = Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio")
                    Me.VentaBindingSource.Current("ID_Cliente") = Val(ID_ClienteTextBox.Text)
                    Me.VentaBindingSource.Current("ID_Cajero") = Val(ID_CajeroComboBox.SelectedValue)
                    Me.VentaBindingSource.Current("NroFactura") = Val(NroFacturaNumericUpDown.Text)
                    Me.VentaBindingSource.Current("Fecha_Venta") = DateTime.Now.ToString("dd/MM/yyyy hh:mm")
                    Me.VentaBindingSource.Current("TipoDeFactura_Venta") = Val(TipoDeFactura_VentaComboBox.SelectedValue)
                    Me.VentaBindingSource.EndEdit()
                    Me.VentaTableAdapter.Update(Me.MayoristaBaseDeDatosDataSet.Venta)
                    'Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet) 'grabo en disco las dos tablas
                    'esta sentencia no va sino corro el puntero de lugar
                    '------------------------------------------

                    'aca trabajo sobre la tabla PRODUCTO descuento la cantidad vendida
                    Me.ProductoBindingSource.Current("Strock") = ProductoBindingSource.Current("Strock") - Val(Cantidad_VentaTextBox.Text)
                    importe = Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio_Unitario")
                    MsgBox("La venta a sido realizada con exito el importe es:" & importe & " Pesos")

                    'ahora si cierro y guardo
                    Me.ProductoBindingSource.EndEdit() 'cierro bd
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'grabo en disco las dos tablas
                    Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto) 'Para actualizar en el otro formulario la grilla
                    Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto) 'Actualizo la grilla stock
                    Me.VentaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Venta) 'actualizo la grilla ventas


                Else
                    MsgBox("El stock es insuficiente, el stock actual es de: " & ProductoBindingSource.Current("Strock") & " unidades")
                    'limpiar(Me) 'funcion limpiar textbox
                    ID_ProductoTextBox.Text = ""
                    Cantidad_VentaTextBox.Text = ""
                    ID_ProductoTextBox.Focus()

                End If
            End If
        End If
        'Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet)

    End Sub

End Class