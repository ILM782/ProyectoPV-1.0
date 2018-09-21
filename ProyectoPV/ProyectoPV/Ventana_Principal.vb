Public Class Ventana_Principal

    'PARA HACER LA BARRA DE NAVEGACION(http://codigofacilito.com/videos/visual_basic_net_parte_menustrip_curso_vbnet)
  
    Private Sub Ventana_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Salir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir2.Click

        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginGerente.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lbl_hora_2.Text = TimeOfDay 'hora
        Lbl_Fecha_2.Text = DateString 'fecha
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoginCajero.Show()
    End Sub
End Class