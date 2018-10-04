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
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
        Me.ClienteBindingSource.AddNew()
    End Sub

    Private Sub Btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Entrar.Click
        Me.ClienteBindingSource.Current("Nombre_Cliente") = Nombre_ClienteTextBox.Text
        Me.ClienteBindingSource.Current("Apellido_Cliente") = Apellido_ClienteTextBox.Text
        Me.ClienteBindingSource.Current("DNI_Cliente") = DniTextBox.Text
        Me.ClienteBindingSource.Current("ID_Localidad") = Val(ID_LocalidadComboBox.SelectedValue)
        Me.ClienteBindingSource.Current("Domicilio_Cliente") = Domicilio_ClienteTextBox.Text
        Me.ClienteBindingSource.Current("Telefono_Cliente") = Val(Telefono_ClienteTextBox.Text)
        Me.ClienteBindingSource.Current("Correo_Cliente") = Correo_ClienteTextBox.Text
        Me.ClienteBindingSource.EndEdit() 'Cierra la edicion
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
        'Cajero_Transaccion_Venta.ClienteTableAdapter.Fill(Cajero_Transaccion_Venta.MayoristaBaseDeDatosDataSet.Cliente) 'actualizo la base 
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente) 'actualizo la base
        Me.ClienteBindingSource.AddNew()
    End Sub
End Class