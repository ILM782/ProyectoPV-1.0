Public Class Atributos_De_Cajero


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lbl_Hora.Text = TimeOfDay
        Lbl_Fecha.Text = DateString

    End Sub

    Private Sub Btn_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Volver.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub Btn_Transacciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Transacciones.Click
        Cajero_Transaccion_Venta.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Agregar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar_Cliente.Click
        Cajero_Agregar_Cliente.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Productos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Productos.Click
        Cajero_Producto_Para_Ventas.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Localidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Localidades.Click
        Cajero_Localidad.Show()
        Me.Close()
    End Sub

    'Private Sub Atributos_De_Cajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Me.WindowState = FormWindowState.Maximized 'PARA MAXIMIZAR LA VENTANA A LA MEDIDA DE LA PANTALLA(http://www.forosdelweb.com/f69/colocar-formulario-pantalla-completa-518379/)
    'End Sub
End Class