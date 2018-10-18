Public Class Gerente_Ventas_Realizadas

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Gerente_Producto.Show()
        Me.Close()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Gerente_Proveedores.Show()
        Me.Close()
    End Sub

    Private Sub TransaccionesDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionesDeCompraToolStripMenuItem.Click
        Gerente_Transacciones_de_Compras.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Gerente_TablasClientes.Show()
        Me.Close()
    End Sub

    Private Sub ComprasRealizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasRealizadasToolStripMenuItem.Click

    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Gerente_Localidad.Show()
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

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Gerente_Agregar_Cajero.Show()
        Me.Close()
    End Sub

    Private Sub VentaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_Ventas_Realizadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cajero' Puede moverla o quitarla según sea necesario.
        Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Venta)

    End Sub

End Class