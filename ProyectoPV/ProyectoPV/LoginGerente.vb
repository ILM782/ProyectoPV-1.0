Public Class LoginGerente

    Private Sub Btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Entrar.Click
        If Txt_Usuario.Text = "Admin" And Txt_Contraseña.Text = "1234" Then
            TablasClientes.Show()
            Me.Close()
        Else
            If Txt_Usuario.Text = "USUARIO" And Txt_Contraseña.Text = "CONTRASEÑA" Then
                MsgBox("Campos vacios", MsgBoxStyle.Information, "Error")
            Else
                MsgBox("La contraseña o usuario son incorrectos", MsgBoxStyle.Exclamation, "Reintente")
            End If
        End If
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            Close()
        End If
    End Sub
End Class