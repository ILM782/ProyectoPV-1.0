Public Class Logeo

    Private Sub Btn_Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Ingresar.Click



        If Txt_Usuario1.Text = "" Or Txt_Contraseña1.Text = "" Then
            MsgBox("Campo vacio ", MsgBoxStyle.Information, "Cuidado")
        Else
            If Ckt_Gerente.Checked Then

                If Txt_Usuario1.Text = "Admin" And Txt_Contraseña1.Text = "1234" Then
                    Atributos_De_Gerente.Show()
                    Me.Close()
                End If
            Else
                Atributos_De_Cajero.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Txt_Contraseña1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Contraseña1.TextChanged
        Txt_Contraseña1.UseSystemPasswordChar = True
    End Sub

End Class