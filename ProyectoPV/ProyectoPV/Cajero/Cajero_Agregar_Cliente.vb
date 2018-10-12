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
        Dim consulta As Integer
        If Nombre_ClienteTextBox.Text <> "" And Apellido_ClienteTextBox.Text <> "" And DNI_ClienteTextBox.Text <> "" And Telefono_ClienteTextBox.Text <> "" Then
            consulta = Me.ClienteBindingSource.Find("DNI_Cliente", DNI_ClienteTextBox.Text)

            If consulta <> -1 Then
                MsgBox("Cliente Repetido", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ClienteBindingSource.Current("Nombre_Cliente") = Nombre_ClienteTextBox.Text
                Me.ClienteBindingSource.Current("Apellido_Cliente") = Apellido_ClienteTextBox.Text
                Me.ClienteBindingSource.Current("DNI_Cliente") = Val(DNI_ClienteTextBox.Text)
                Me.ClienteBindingSource.Current("Domicilio_Cliente") = Domicilio_ClienteTextBox.Text
                Me.ClienteBindingSource.Current("Correo_Cliente") = Correo_ClienteTextBox.Text
                Me.ClienteBindingSource.Current("Telefono_Cliente") = Telefono_ClienteTextBox.Text
                Me.ClienteBindingSource.Current("ID_Localidad") = Val(ID_LocalidadComboBox.SelectedValue)
                Me.ClienteBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
                Me.ClienteBindingSource.MoveLast()
                MsgBox("El Id del Cliente es: " & ClienteBindingSource.Current("ID_Cliente"), MsgBoxStyle.Information, " Id Cliente ")

                Me.ClienteBindingSource.AddNew()
                Nombre_ClienteTextBox.Text = ""
                Apellido_ClienteTextBox.Text = ""
                DNI_ClienteTextBox.Text = ""
                ID_LocalidadComboBox.Text = "Seleccionar"
                Domicilio_ClienteTextBox.Text = ""
                Correo_ClienteTextBox.Text = ""
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    'REVISAR
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim vista As New DataView 'instancio el objeto
        vista.Table = Me.MayoristaBaseDeDatosDataSet.Cliente
        vista.RowFilter = "DNI_Cliente = " & Val(Me.TextBox1.Text)
        Me.ClienteDataGridView.DataSource = vista
    End Sub

    Private Sub DNI_ClienteTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DNI_ClienteTextBox.KeyPress
        e.KeyChar = ChrW(solonumeros(e))
        If e.KeyChar = Chr(13) Then
            DNI_ClienteTextBox.Focus()
            e.Handled = True
        End If
    End Sub
End Class