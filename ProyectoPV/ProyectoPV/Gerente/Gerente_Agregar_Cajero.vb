Public Class Gerente_Agregar_Cajero

    Private Sub CajeroBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajeroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
    End Sub

    Private Sub Cajero_Agregar_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cajero' Puede moverla o quitarla según sea necesario.
        Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cajero' Puede moverla o quitarla según sea necesario.
        Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
        ID_LocalidadComboBox.Text = "Seleccionar"
        Me.CajeroBindingSource.AddNew()

    End Sub

    Private Sub Btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim consulta As Integer
        If Nombre_CajeroTextBox.Text <> "" And Apellido_CajeroTextBox.Text <> "" And DNI_CajeroTextBox.Text <> "" And TelefonoTextBox.Text <> "" Then
            consulta = Me.CajeroBindingSource.Find("DNI_Cajero", DNI_CajeroTextBox.Text)

            If consulta <> -1 Then
                MsgBox("Cliente Repetido", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.CajeroBindingSource.Current("Nombre_Cajero") = Nombre_CajeroTextBox.Text
                Me.CajeroBindingSource.Current("Apellido_Cajero") = Apellido_CajeroTextBox.Text
                Me.CajeroBindingSource.Current("DNI_Cajero") = Val(DNI_CajeroTextBox.Text)
                Me.CajeroBindingSource.Current("Domicilio_Cajero") = Domicilio_CajeroTextBox.Text
                Me.CajeroBindingSource.Current("Correo_Cajero") = Correo_CajeroTextBox.Text
                Me.CajeroBindingSource.Current("Telefono") = Val(TelefonoTextBox.Text)
                Me.CajeroBindingSource.Current("ID_Localidad") = Val(ID_LocalidadComboBox.SelectedValue)
                Me.CajeroBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
                Me.CajeroBindingSource.MoveLast()
                MsgBox("El Id del Cliente es: " & CajeroBindingSource.Current("ID_Cajero"), MsgBoxStyle.Information, " Id Cajero ")

                Me.CajeroBindingSource.AddNew()
                Nombre_CajeroTextBox.Text = ""
                Apellido_CajeroTextBox.Text = ""
                DNI_CajeroTextBox.Text = ""
                TelefonoTextBox.Text = ""
                ID_LocalidadComboBox.Text = "Seleccionar"
                Domicilio_CajeroTextBox.Text = ""
                Correo_CajeroTextBox.Text = ""
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub TelefonoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        e.KeyChar = ChrW(solonumeros(e))
        If e.KeyChar = Chr(13) Then
            DNI_CajeroTextBox.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub DNI_CajeroTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DNI_CajeroTextBox.KeyPress
        e.KeyChar = ChrW(solonumeros(e))
        If e.KeyChar = Chr(13) Then
            DNI_CajeroTextBox.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        Gerente_Producto.Show()
        Me.Close()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Gerente_Localidad.Show()
        Me.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Atributos_De_Gerente.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Gerente_Proveedores.Show()
        Me.Close()
    End Sub

    Private Sub TrasaccionDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrasaccionDeComprasToolStripMenuItem.Click
        Gerente_Transacciones_de_Compras.Show()
        Me.Close()
    End Sub

    Private Sub AgregarClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarClientesToolStripMenuItem.Click
        Gerente_TablasClientes.Show()
        Me.Close()
    End Sub

    Private Sub VentasRealizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasRealizadasToolStripMenuItem.Click
        Gerente_Ventas_Realizadas.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Gerente_Localidad.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Gerente_Tabla_De_Cajeros.Show()
<<<<<<< HEAD
        Me.Close()
=======
>>>>>>> master
    End Sub

    Private Sub Nombre_CajeroTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nombre_CajeroTextBox.KeyPress
        e.KeyChar = ChrW(solo_letras(e))
        If e.KeyChar = Chr(13) Then
            Nombre_CajeroTextBox.Focus()
            e.Handled = True
        End If
    End Sub

 
    Private Sub Apellido_CajeroTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Apellido_CajeroTextBox.KeyPress
        e.KeyChar = ChrW(solo_letras(e))
        If e.KeyChar = Chr(13) Then
            Apellido_CajeroTextBox.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ID_LocalidadComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ID_LocalidadComboBox.KeyPress
        e.KeyChar = ChrW(sin_letras(e))
        If e.KeyChar = Chr(13) Then
            ID_LocalidadComboBox.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub Domicilio_CajeroTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Domicilio_CajeroTextBox.KeyPress
        e.KeyChar = ChrW(solo_letras(e))
        If e.KeyChar = Chr(13) Then
            Domicilio_CajeroTextBox.Focus()
            e.Handled = True
        End If
    End Sub
End Class