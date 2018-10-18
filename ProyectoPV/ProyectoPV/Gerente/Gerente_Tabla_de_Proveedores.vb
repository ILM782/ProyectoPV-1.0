Public Class Gerente_Tabla_de_Proveedores

    Private Sub ProveedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_Tabla_de_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Proveedor)
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Domicilio")
        ComboBox1.Text = "Seleccionar"
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Cajero_Localidad_De_Vista.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Cajero_Localidad_De_Vista.Show()
    End Sub

    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click, Button4.Click, Button2.Click

        Dim aux As Object

        If Nombre_EmpresaTextBox.Text <> "" And ID_LocalidadTextBox.Text <> "" And Domicilio_ProveedorTextBox.Text <> "" And Telefono_ProveedorTextBox.Text <> "" And Correo_ProveedorTextBox.Text <> "" Then

            aux = MsgBox("¿Seguro que quiere Modificar ?", MsgBoxStyle.YesNoCancel, "¿Seguro?")
            If aux = vbYes Then
                Me.Validate()
                Me.ProveedorBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                Me.ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Proveedor)
                Me.ProveedorBindingSource.MoveLast()
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ""
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = ChrW(sin_letras(e))
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "Nombre" Then
            Me.ProveedorTableAdapter.FillByProveedor(Me.MayoristaBaseDeDatosDataSet.Proveedor, TextBox1.Text)
        Else
            If ComboBox1.Text = "Domicilio" Then
                Me.ProveedorTableAdapter.FillByDireccion(Me.MayoristaBaseDeDatosDataSet.Proveedor, TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button5.Click, Button3.Click
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If ID_ProveedorTextBox.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = ID_ProveedorTextBox.Text
            fila = Me.ProveedorBindingSource.Find("ID_Proveedor", CodConsulta)
            If fila = -1 Then
                MsgBox("Proveedor no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ProveedorBindingSource.Position = fila
                aux = MsgBox("¿Seguro que quiere eliminar el id: " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.ProveedorBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.ProveedorBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Proveedor)
                End If
            End If
        End If
    End Sub
End Class