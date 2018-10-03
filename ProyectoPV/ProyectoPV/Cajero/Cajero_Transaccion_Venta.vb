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
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)

    End Sub
End Class