Public Class Cajero_Agregar_Cliente

    Private Sub TransaccionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionToolStripMenuItem.Click
        Cajero_Transaccion_Venta.Show()
        Me.Close()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        Cajero_Producto_Para_Ventas.Show()
        Me.Close()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Cajero_Localidad.Show()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Atributos_De_Cajero.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Cajero_Agregar_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
        Me.ClienteBindingSource.AddNew()
    End Sub

    Private Sub Btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim consulta1 As Integer
        If Txt_Nombre.Text <> "" And Txt_Apellido.Text <> "" And Txt_Dni.Text <> "" And Txt_Domicilio.Text <> "" And Txt_Telefono.Text <> "" And Txt_Correo.Text <> "" Then
            consulta1 = Me.ClienteBindingSource.Find("DNI_Cliente", Txt_Dni.Text)

            If consulta1 <> -1 Then
                MsgBox("Cliente Exixtente", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ClienteBindingSource.Current("Nombre_Cliente") = Txt_Nombre.Text
                Me.ClienteBindingSource.Current("Apellido_Cliente") = Txt_Apellido.Text
                Me.ClienteBindingSource.Current("DNI_Cliente") = Val(Txt_Dni.Text)
                Me.ClienteBindingSource.Current("Domicilio_Cliente") = Txt_Domicilio.Text
                Me.ClienteBindingSource.Current("Correo_Cliente") = Txt_Correo.Text
                Me.ClienteBindingSource.Current("Telefono_Cliente") = Txt_Telefono.Text
                Me.ClienteBindingSource.Current("ID_Localidad") = Val(ComboBox1.SelectedValue)
                Me.ClienteBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
                Me.ClienteBindingSource.MoveLast()
                MsgBox("El Id del Cliente es: " & ClienteBindingSource.Current("ID_Cliente"), MsgBoxStyle.Information, " Id Cliente ")

                Me.ClienteBindingSource.AddNew()
                Txt_Nombre.Text = ""
                Txt_Apellido.Text = ""
                Txt_Domicilio.Text = ""
                Txt_Telefono.Text = ""
                Txt_Correo.Text = ""
                Txt_Dni.Text = ""
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    'REVISAR
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila, DNIConsulta As Integer
        DNIConsulta = Val(InputBox("ingrese DNI"))
        fila = Me.ClienteBindingSource.Find("DNI_Cliente", DNIConsulta) 'me dice la posicion arranca de 0
        If fila = -1 Then
            'no se encontro ultimo registro es -1
            MsgBox("El registro no se encontro")
        Else
            ClienteBindingSource.Position = fila ' Mover el cursor a la fila obtenida con esto muestro
        End If
    End Sub

    Private Sub Txt_Telefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Telefono.KeyPress
        e.KeyChar = ChrW(solonumeros(e))
        If e.KeyChar = Chr(13) Then
            Txt_Telefono.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_Dni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Dni.KeyPress
        e.KeyChar = ChrW(solonumeros(e))
        If e.KeyChar = Chr(13) Then
            Txt_Dni.Focus()
            e.Handled = True
        End If
    End Sub
End Class
