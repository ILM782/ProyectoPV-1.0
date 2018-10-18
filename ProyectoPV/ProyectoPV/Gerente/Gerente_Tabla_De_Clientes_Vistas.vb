Public Class Gerente_Tabla_De_Clientes_Vistas

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_Tabla_De_Clientes_Vistas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Apellido")
        ComboBox1.Items.Add("Dni")
        ComboBox1.Items.Add("Domicilio")
        ComboBox1.Text = "Seleccionar"
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Cajero_Localidad_De_Vista.Show()
    End Sub

    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click

        Dim aux As Object

        If ID_ClienteTextBox.Text <> "" And Nombre_ClienteTextBox.Text <> "" And Apellido_ClienteTextBox.Text <> "" And DNI_ClienteTextBox.Text <> "" And ID_LocalidadTextBox.Text <> "" And Domicilio_ClienteTextBox.Text <> "" And Telefono_ClienteTextBox.Text <> "" And Correo_ClienteTextBox.Text <> "" Then

            aux = MsgBox("¿Seguro que quiere Modificar ?", MsgBoxStyle.YesNoCancel, "¿Seguro?")
            If aux = vbYes Then
                Me.Validate()
                Me.ClienteBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
                Me.ClienteBindingSource.MoveLast()
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If ID_ClienteTextBox.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = ID_ClienteTextBox.Text
            fila = Me.ClienteBindingSource.Find("ID_Cliente", CodConsulta)
            If fila = -1 Then
                MsgBox("Cliente no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ClienteBindingSource.Position = fila
                aux = MsgBox("¿Seguro que quiere eliminar el id: " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.ClienteBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.ClienteBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = ChrW(sin_letras(e))
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        Close()
        Cajero_Localidad_De_Vista.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub

  
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "Nombre" Then
            Me.ClienteTableAdapter.FillByNombre(Me.MayoristaBaseDeDatosDataSet.Cliente, TextBox1.Text)
        Else
            If ComboBox1.Text = "Apellido" Then
                Me.ClienteTableAdapter.FillByApellido(Me.MayoristaBaseDeDatosDataSet.Cliente, TextBox1.Text)
            Else
                If ComboBox1.Text = "Domicilio" Then
                    Me.ClienteTableAdapter.FillByDomicilio(Me.MayoristaBaseDeDatosDataSet.Cliente, TextBox1.Text)
                Else
                    If ComboBox1.Text = "Dni" Then
                        Me.ClienteTableAdapter.FillByDni(Me.MayoristaBaseDeDatosDataSet.Cliente, TextBox1.Text)
                    End If
                End If
            End If
        End If
    End Sub
End Class