Public Class Cajero_Producto_Para_Ventas

    Private Sub TransaccionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionToolStripMenuItem.Click
        Cajero_Transaccion_Venta.Show()
        Me.Close()
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        Cajero_Agregar_Cliente.Show()
        Me.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Atributos_De_Cajero.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Cajero_Producto_Para_Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim vista As New DataView 'creo e instancio el objeto 

        vista.Table = Me.MayoristaBaseDeDatosDataSet.Producto 'cargo objeto con la tabla stock
        'aux = "Id_articulo = " + Val(Me.TextBox2.Text) con el simbolo + tira error no concatena

        vista.RowFilter = "ID_Producto = " & Val(Me.TextBox1.Text)    'esta para numeros

        Me.ProductoDataGridView.DataSource = vista 'cargo la vista
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim vista As New DataView 'instancio el objeto
        vista.Table = Me.MayoristaBaseDeDatosDataSet.Producto 'cargo objeto
        vista.RowFilter = "Descripcion LIKE '" & Me.TextBox2.Text & "%'" 'esta para texto like
        Me.ProductoDataGridView.DataSource = vista
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim vista As New DataView 'instancio el objeto
        vista.Table = Me.MayoristaBaseDeDatosDataSet.Producto 'cargo objeto
        vista.RowFilter = "Nombre_Producto LIKE '" & Me.TextBox2.Text & "%'" 'esta para texto like
        Me.ProductoDataGridView.DataSource = vista
    End Sub
End Class