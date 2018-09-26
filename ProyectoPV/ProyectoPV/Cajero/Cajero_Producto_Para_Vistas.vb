Public Class Cajero_Producto_Para_Vistas

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
End Class