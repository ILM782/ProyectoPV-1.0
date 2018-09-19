Public Class LoginCajero

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Txt_Contraseña1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Contraseña1.TextChanged
        Txt_Contraseña1.UseSystemPasswordChar = True
    End Sub

    Private Sub Btn_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ingresar.Click
        If Txt_Usuario1.Text = "" Or Txt_Contraseña1.Text = "" Then
            MsgBox("Campo vacio ", MsgBoxStyle.Information, "Cuidado")
        Else
            If Txt_Usuario1.Text = "Admin" And Txt_Contraseña1.Text = "1234" Then
                Atributos_De_Cajero.Show()
                Me.Close()
                Ventana_Principal.Close()
            Else
                MsgBox("Usuario o Contraseña Incorrecta", MsgBoxStyle.Exclamation, "Verificar")
            End If
        End If
    End Sub


    Private Sub Txt_Usuario1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Usuario1.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Button3_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Ingresar_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_Contraseña1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Contraseña1.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Button3_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Ingresar_Click(sender, e)
        End If
    End Sub
End Class