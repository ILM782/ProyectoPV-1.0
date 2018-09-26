Public Class LoginGerente

    Private Sub Btn_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ingresar.Click
        If Txt_Usuario.Text = "" Or Txt_Contraseña.Text = "" Then
            MsgBox("Campo vacio ", MsgBoxStyle.Information, "Cuidado")
        Else
            If Txt_Usuario.Text = "Admin" And Txt_Contraseña.Text = "1234" Then
                Atributos_De_Gerente.Show()
                Me.Close()
                Ventana_Principal.Close()
            Else
                MsgBox("Usuario o Contraseña Incorrecta", MsgBoxStyle.Exclamation, "Verificar")
            End If
        End If
    End Sub

    Private Sub Txt_Contraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Contraseña.TextChanged
        Txt_Contraseña.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Txt_Usuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Usuario.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Button2_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Ingresar_Click(sender, e)
        End If

    End Sub

    Private Sub Txt_Contraseña_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Contraseña.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Button2_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Ingresar_Click(sender, e)
        End If
    End Sub
End Class