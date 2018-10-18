Public Class Cajero_Transaccion_Venta

    Dim Resultado As Integer
    Dim A As Double
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
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter1.Fill(Me.MayoristaBaseDeDatosDataSet.Venta)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cajero' Puede moverla o quitarla según sea necesario.
        Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter1.Fill(Me.MayoristaBaseDeDatosDataSet.Venta)

    End Sub

    Private Sub VentaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    'Private Sub VentaDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VentaDataGridView.CellEndEdit
    '    Dim Resultado As Integer = Val(VentaDataGridView.Rows(e.RowIndex).Cells(2).Value) * Val(ProductoDataGridView.Rows(e.RowIndex).Cells(6).Value)

    '    Me.VentaDataGridView.Rows(e.RowIndex).Cells(3).Value = Resultado.ToString

    'End Sub

    Private Sub Btn_Vender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Vender.Click

        Dim fila, CodConsulta, aux, importe, Total As Integer
        CodConsulta = Val(ID_ProductoTextBox.Text)
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
                    Total += Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio_Unitario")
                    Me.VentaBindingSource.AddNew()
                    Me.VentaBindingSource.Current("ID_Producto") = ProductoBindingSource.Current("ID_Producto")
                    Me.VentaBindingSource.Current("Cantidad_Venta") = Val(Cantidad_VentaTextBox.Text)
                    ' --------------------------------------- Me.VentaBindingSource.Current("precio") = Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio")
                    Me.VentaBindingSource.Current("ID_Cliente") = Val(ID_ClienteTextBox.Text)
                    Me.VentaBindingSource.Current("ID_Cajero") = Val(ID_CajeroComboBox.SelectedValue)
                    Me.VentaBindingSource.Current("NroFactura") = Val(NroFacturaTextBox.Text)
                    Me.VentaBindingSource.Current("Fecha_Venta") = DateTime.Now.ToString("dd/MM/yyyy hh:mm")
                    Me.VentaBindingSource.Current("TipoDeFactura_Venta") = Val(TipoDeFactura_VentaComboBox.SelectedValue)
                    'Me.VentaDataGridView.Rows(3).Cells(3).Value = Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio_Unitario")
                    'Me.VentaDataGridView.Item(3, fila).Value = Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio_Unitario")
                    Me.VentaBindingSource.Current("SubTotal") = Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio_Unitario")
                    Resultado += Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio_Unitario")
                    Me.VentaBindingSource.EndEdit()
                    Me.VentaTableAdapter1.Update(Me.MayoristaBaseDeDatosDataSet.Venta)
                    'Me.TableAdapterManager.UpdateAll(Me.FarmaciaDataSet) 'grabo en disco las dos tablas
                    'esta sentencia no va sino corro el puntero de lugar
                    '------------------------------------------

                    'aca trabajo sobre la tabla VENTA descuento la cantidad vendida
                    Me.ProductoBindingSource.Current("Strock") = ProductoBindingSource.Current("Strock") - Val(Cantidad_VentaTextBox.Text)
                    importe = Val(Cantidad_VentaTextBox.Text) * Me.ProductoBindingSource.Current("Precio_Unitario")
                    MsgBox("La venta a sido realizada con exito el importe es:" & importe & " Pesos")

                    'ahora si cierro y guardo
                    Me.ProductoBindingSource.EndEdit() 'cierro bd
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'grabo en disco las dos tablas
                    Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto) 'Para actualizar en el otro formulario la grilla
                    Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto) 'Actualizo la grilla stock
                    Me.VentaTableAdapter1.Fill(Me.MayoristaBaseDeDatosDataSet.Venta) 'actualizo la grilla ventas


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

    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Cajero_Agregar_Cliente.Show()
    End Sub

    Private Sub Btn_Imprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Imprimir.Click
        Cajero_ImprimirVenta.Show()

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    '    Dim fila1, contador, Total, filaConsulta, art, CodConsulta1, aux As Integer
    '    CodConsulta1 = Val(ID_ProductoTextBox.Text)
    '    fila1 = Me.ProductoBindingSource.Find("ID_Producto", CodConsulta1) 'me dice la posicion arranca de 0
    '    Total = 0 'sumo los subtotales
    '    filaConsulta = 0 'para hacer la consulta de la otra tabla
    '    DataGridView1.Rows.Clear() 'limpio la grilla cada ves que ingreso un dato 
    '    ProductoBindingSource.MoveFirst() 'muevo al primer registro de la tabla






    '    If fila1 = -1 Then
    '        'no se encontro ultimo registro es -1
    '        MsgBox("El registro no se encontro")
    '    Else
    '        'Se encontro
    '        ProductoBindingSource.Position = fila1 ' Mover el cursor a la fila obtenida con esto muestro
    '        aux = MsgBox("Quiere realizar esta venta Cod_articulo: " & CodConsulta1, 32 + 1, "Vender")
    '        If aux = 1 Then
    '            If ProductoBindingSource.Current("Strock") >= Val(Cantidad_VentaTextBox.Text) Then 'si true puedo vender
    '                'guardo la transaccion en la tabla venta-----------------------------------------------
    '                '---------------------------------------------------------------
    '                'Do
    '                '    Try
    '                '        Cadena = ProductoBindingSource.Current("ID_Producto").ToString.Substring(0, Len(TextBox2.Text))
    '                '        'ejemplo de error descripcion valor "maria"    caja de texto "mariano" len da 7 y maria tiene solo 5 tira error
    '                '    Catch ex As Exception 'ante cualquier error
    '                '        Cadena = ""

    '                '    End Try
    '                'ucase para pasarlo a mayuscula

    '                'If UCase(Cadena) = UCase(TextBox2.Text) Then
    '                '----------------------------------------------------------

    '                DataGridView1.Rows.Add() 'columna
    '                DataGridView1.Item(0, fila1).Value = ProductoBindingSource.Current("ID_Producto")
    '                DataGridView1.Item(1, fila1).Value = ProductoBindingSource.Current("Nombre_Producto")
    '                DataGridView1.Item(2, fila1).Value = ProductoBindingSource.Current("Descripcion")
    '                art = ProductoBindingSource.Current("ID_Producto")

    '                'busco la cantidad apartir del id en la tabla blister
    '                filaConsulta = Me.VentaBindingSource.Find("ID_Venta", VentaBindingSource.Current("Venta")) 'busco relacion id-descripcion blister
    '                Me.VentaBindingSource.Position = filaConsulta
    '                DataGridView1.Item(3, fila1).Value = Me.VentaBindingSource.Current("Cantidad_Venta") 'pego la CANTIDAD no el id

    '                'pego en la grilla la multiplicacion de cantidad por precio
    '                DataGridView1.Item(4, fila1).Value = VentaBindingSource.Current("Cantidad_Venta") * ProductoBindingSource.Current("Precio_Unitario")
    '                'voy sumando los subtotales
    '                Total = Total + (VentaBindingSource.Current("Cantidad_Venta") * ProductoBindingSource.Current("Precio_Unitario"))
    '                fila1 = fila1 + 1 'para ir bajando lineas en la grilla

    '            End If
    '            '        contador = contador + 1
    '            '        StockBindingSource.MoveNext()
    '            'Loop Until contador = StockBindingSource.Count


    '            'creo una fila final con el total a facturar
    '            DataGridView1.Item(5, fila1).Value = "Total a facturar"
    '            DataGridView1.Item(6, fila1).Value = Total
    '        End If
    '    End If
    'End Sub

    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click

        Me.lbl_Totalventas.Text = Resultado.ToString
        A = A + 1
        Me.NroFacturaTextBox.Text = A
        VentaDataGridView.DataSource = Nothing
        'For i As Integer = 0 To Me.VentaDataGridView.RowCount - 1
        '    Me.DataGridView1.Rows.Remove(Me.VentaDataGridView.CurrentRow)
        'Next
    End Sub
End Class