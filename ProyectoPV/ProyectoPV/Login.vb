Public Class Login


    Private Sub Btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Entrar.Click
        If Txt_Usuario.Text = "Admin" And Txt_Contrasena.Text = "1234" Then
            Ventana_Principal.Show()
            Me.Close()
        Else
            If Txt_Usuario.Text = "USUARIO" And Txt_Contrasena.Text = "CONTRASEÑA" Then
                MsgBox("Campos vacios", MsgBoxStyle.Information, "Error")
            Else
                MsgBox("La contraseña o usuario son incorrectos", MsgBoxStyle.Exclamation, "Reintente")
            End If
        End If
        'Private Sub Btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Entrar.Click
        'If Txt_Usuario.Text = "Admin" And Txt_Contrasena.Text = "1234" Then
        'MsgBox("Se a logeado con exito", MsgBoxStyle.OkOnly, "FELICITACIONES")
        'Form2.Show()
        'Me.Hide()
        'Else
        'If Txt_Usuario.Text = "" And Txt_Contrasena.Text = "" Then
        'MsgBox("No a ingresado nada vuelva a intentar", MsgBoxStyle.Exclamation, "ERROR")
        'Else
        'If Txt_Usuario.Text = "" Then
        'MsgBox("No a ingresado USUARIO", MsgBoxStyle.Exclamation, "ERROR")
        'Else
        'If Txt_Contrasena.Text = "" Then
        'MsgBox("No a ingresado CONTRASEÑA", MsgBoxStyle.Exclamation, "ERROR")

        'End If
        'End If
        'End If
        'End If
        'End Sub
    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
        Stop
    End Sub

    Private Sub Txt_Usuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Usuario.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Salir_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 13(ENTER) LLAME AL BOTON ENTRAR
            Call Btn_Entrar_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_Contrasena_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Contrasena.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Salir_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 13(ENTER) LLAME AL BOTON ENTRAR
            Call Btn_Entrar_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_Usuario_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Usuario.Enter
        If (Txt_Usuario.Text = "USUARIO") Then
            Txt_Usuario.Text = ""
            'Txt_Usuario.ForeColor = Color.LightGray ESTO ES PARA DENOMINAR DISTINTOS COLORES COMO CUANDO USAS UN LINK
        End If
    End Sub

    Private Sub Txt_Usuario_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Usuario.Leave
        If (Txt_Usuario.Text = "") Then
            Txt_Usuario.Text = "USUARIO"
            'Txt_Usuario.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Txt_Contrasena_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Contrasena.Enter
        If (Txt_Contrasena.Text = "CONTRASEÑA") Then
            Txt_Contrasena.Text = ""
            Txt_Contrasena.UseSystemPasswordChar = True 'ES PARA USAR LOS OCULTADORES DE CONTRASEÑAS

        End If
    End Sub

    Private Sub Txt_Contrasena_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Contrasena.Leave
        If (Txt_Contrasena.Text = "") Then
            Txt_Contrasena.Text = "CONTRASEÑA"
            Txt_Contrasena.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Btn_Entrar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Btn_Entrar.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Salir_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_Salir_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Btn_Salir.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Salir_Click(sender, e)
        End If
    End Sub
End Class