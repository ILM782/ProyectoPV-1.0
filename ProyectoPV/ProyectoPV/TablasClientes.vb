Public Class TablasClientes

 
    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub TablasClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Clientes)
        Me.ClientesBindingSource.AddNew()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Me.ClientesTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Clientes)
        Nombre_ClienteTextBox.Text = ""
        Apellido_ClienteTextBox.Text = ""
        ID_LocalidadTextBox.Text = ""
        Domicilio_ClienteTextBox.Text = ""
        Telefono_ClienteTextBox.Text = ""
        Correo_ClienteTextBox.Text = ""
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        Ventana_Principal.Show()
        Me.Close()
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarToolStripMenuItem.Click
        Me.ClientesTableAdapter.Borrar(Txt_Borrar.Text)
        Me.ClientesTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Clientes)
        Txt_Borrar.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
        MsgBox("GUARDADO EXITOSO", MsgBoxStyle.Exclamation, "PREFECTO")
        DNITextBox.Text = ""
        Nombre_ClienteTextBox.Text = ""
        Apellido_ClienteTextBox.Text = ""
        ID_LocalidadTextBox.Text = ""
        Domicilio_ClienteTextBox.Text = ""
        Telefono_ClienteTextBox.Text = ""
        Correo_ClienteTextBox.Text = ""
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.ClientesBindingSource.AddNew() ' preparo la base para ingresar nuevos datos
        DNITextBox.Focus()
        DNITextBox.Text = ""
        Nombre_ClienteTextBox.Text = ""
        Apellido_ClienteTextBox.Text = ""
        ID_LocalidadTextBox.Text = ""
        Domicilio_ClienteTextBox.Text = ""
        Telefono_ClienteTextBox.Text = ""
        Correo_ClienteTextBox.Text = ""
    End Sub
End Class