Public Class Atributos_De_Cajero


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lbl_Hora.Text = TimeOfDay
        Lbl_Fecha.Text = DateString

    End Sub

    Private Sub Btn_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Volver.Click
        Ventana_Principal.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub Btn_Transaccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Transaccion.Click
        Cajero_Transaccion_Venta.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Agregar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar_Cliente.Click
        Cajero_Agregar_Cliente.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Porductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Porductos.Click
        Cajero_Producto_Para_Vistas.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cajero_Localidad.Show()
        Me.Close()
    End Sub
End Class