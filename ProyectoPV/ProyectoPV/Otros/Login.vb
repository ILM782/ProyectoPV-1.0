Public Class Login
    Private Sub Btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Entrar.Click
        If Txt_Usuario.Text = "USUARIO" And Txt_Contrasena.Text = "CONTRASEÑA" Then
            MsgBox("Campos vacios", MsgBoxStyle.Information, "Error")
        ElseIf Txt_Usuario.Text = "Cajero" And Txt_Contrasena.Text = "1234" Then
            Atributos_De_Cajero.Show()
            Me.Close()

        ElseIf Txt_Usuario.Text = "Gerente" And Txt_Contrasena.Text = "1234" And Ckt_Gerente.Checked Then
            Atributos_De_Gerente.Show()
            Me.Close()
        Else
            MsgBox("La contraseña o usuario son incorrectos", MsgBoxStyle.Exclamation, "Reintente")
        End If
    End Sub

    Private Sub TimerLogin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLogin.Tick
        'ESTO SIRVE PARA EL HORARIO Y FECHA CON UN COSO LLAMADO TIMER (https://www.youtube.com/watch?v=I_MloQplNfY)
        Lbl_HoraLogin.Text = TimeOfDay 'HORA
        Lbl_FechaLogin.Text = DateString 'FECHA
    End Sub

    Private Sub Txt_Usuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Usuario.KeyPress
        'If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
        'Call Btn_Salir_Click(sender, e)
        'End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 13(ENTER) LLAME AL BOTON ENTRAR
            Call Btn_Entrar_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_Contrasena_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Contrasena.KeyPress
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

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Version.Show()
    End Sub

    'BORRAR ES SOLO PARA EL DEBUG
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Atributos_De_Gerente.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Atributos_De_Cajero.Show()
    End Sub

End Class