Public Class Gerente_TablasClientes

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
            Exit Sub
        End If
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        Atributos_De_Gerente.Show()
        Me.Close()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Gerente_Producto.Show()
        Me.Close()
    End Sub

    Private Sub BorrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarToolStripMenuItem.Click
        Gerente_Proveedores.Show()
        Me.Close()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Gerente_Transacciones_de_Compras.Show()
        Me.Close()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Gerente_Localidad.Show()
        Me.Close()
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_TablasClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
        Me.ClienteBindingSource.AddNew()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
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

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If TextBox2.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = TextBox2.Text
            fila = Me.ClienteBindingSource.Find("DNI_Cliente", CodConsulta)
            If fila = -1 Then
                MsgBox("Localidad no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ClienteBindingSource.Position = fila
                aux = MsgBox("¿Seguro que quiere eliminar el Dni: " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.ClienteBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.ClienteBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
                    TextBox1.Text = ""
                    TextBox1.Focus()
                End If
            End If
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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim vista As New DataView 'instancio el objeto
        vista.Table = Me.MayoristaBaseDeDatosDataSet.Cliente
        vista.RowFilter = " ID_Cliente =" & Val(Me.TextBox1.Text)
        Me.ClienteDataGridView.DataSource = vista
    End Sub


    Private Sub VentasRealizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasRealizadasToolStripMenuItem.Click
        Gerente_Ventas_Realizadas.Show()
        Me.Close()
    End Sub

    Private Sub AgregarCajeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCajeroToolStripMenuItem.Click
        Gerente_Agregar_Cajero.Show()
        Me.Close()
    End Sub

End Class