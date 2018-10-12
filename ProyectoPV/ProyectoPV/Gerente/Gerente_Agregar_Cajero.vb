Public Class Gerente_Agregar_Cajero

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        Gerente_Producto.Show()
        Me.Close()
    End Sub
End Class