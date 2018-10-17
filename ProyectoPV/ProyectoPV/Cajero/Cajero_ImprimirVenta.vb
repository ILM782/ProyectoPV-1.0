Public Class Cajero_ImprimirVenta

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub

    Private Sub Cajero_ImprimirVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturasVentaDataSet.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.FacturasVentaDataSet.Venta)
        'TODO: esta línea de código carga datos en la tabla 'FacturasVentaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.FacturasVentaDataSet.Producto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class