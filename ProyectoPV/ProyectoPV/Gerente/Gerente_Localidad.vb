Public Class Gerente_Localidad

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

    Private Sub VentasRealizadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasRealizadasToolStripMenuItem.Click
        Gerente_TablasClientes.Show()
        Me.Close()
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
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

    Private Sub LocalidadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LocalidadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_Localidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        Me.LocalidadBindingSource.AddNew()

    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim consulta1 As Integer
        If Txt_Localidad.Text <> "" Or Txt_CP.Text <> "" Or Txt_Provincia.Text <> "" Then
            consulta1 = Me.LocalidadBindingSource.Find("CP_Localidad", Txt_CP.Text)

            If consulta1 <> -1 Then
                MsgBox("Localidad Repetida", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.LocalidadBindingSource.Current("Localidad_Localidad") = Txt_Localidad.Text
                Me.LocalidadBindingSource.Current("CP_Localidad") = Val(Txt_CP.Text)
                Me.LocalidadBindingSource.Current("Provincia_Localidad") = Txt_Provincia.Text
                Me.LocalidadBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
                Me.LocalidadBindingSource.MoveLast()
                MsgBox("El Id de la Localidad es: " & LocalidadBindingSource.Current("ID_Localidad"), MsgBoxStyle.Information, " Id Localidad ")

                Me.LocalidadBindingSource.AddNew()
                Txt_CP.Text = ""
                Txt_Localidad.Text = ""
                Txt_Provincia.Text = ""


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
            fila = Me.LocalidadBindingSource.Find("ID_Localidad", CodConsulta)
            If fila = -1 Then
                MsgBox("Localidad no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.LocalidadBindingSource.Position = fila
                aux = MsgBox("¿Seguro que quiere eliminar el ID: " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.LocalidadBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.LocalidadBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
                    Me.LocalidadBindingSource.AddNew()
                    TextBox2.Text = ""
                    TextBox2.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If RadioButton1.Checked = True Then
            Me.LocalidadTableAdapter.FillByprovincia(Me.MayoristaBaseDeDatosDataSet.Localidad, TextBox1.Text)
        Else
            Me.LocalidadTableAdapter.FillBy(Me.MayoristaBaseDeDatosDataSet.Localidad, TextBox1.Text)
        End If
    End Sub

    Private Sub Txt_CP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CP.KeyPress
        e.KeyChar = ChrW(solonumeros(e))
        If e.KeyChar = Chr(13) Then
            Txt_CP.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click

        Dim aux As Object

        If TextBox2.Text = "" Then
            MsgBox("Primero busque localidad", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            If Localidad_LocalidadTextBox.Text <> "" And CP_LocalidadTextBox.Text <> "" And Provincia_LocalidadTextBox.Text <> "" Then

                aux = MsgBox("¿Seguro que quiere Modificar ?", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.Validate()
                    Me.LocalidadBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                    Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
                    Me.LocalidadBindingSource.MoveLast()
                    TextBox1.Text = ""
                    Me.LocalidadBindingSource.AddNew()
                    TextBox2.Text = ""
                    Txt_Localidad.Focus()
                    Localidad_LocalidadTextBox.Text = ""
                    CP_LocalidadTextBox.Text = ""
                    Provincia_LocalidadTextBox.Text = ""
                End If
            Else
                MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub Txt_Localidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Localidad.KeyPress
        TextBox1.Text = ""
        TextBox2.Text = ""
        e.KeyChar = ChrW(solo_letras(e))
        If e.KeyChar = Chr(13) Then
            Txt_Localidad.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub CP_LocalidadTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CP_LocalidadTextBox.KeyPress
        e.KeyChar = ChrW(solonumeros(e))
        If e.KeyChar = Chr(13) Then
            CP_LocalidadTextBox.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Gerente_Ventas_Realizadas.Show()
        Me.Close()
    End Sub

    Private Sub AgregarCajeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarCajeroToolStripMenuItem.Click
        Gerente_Agregar_Cajero.Show()
        Me.Close()
    End Sub

    Private Sub Txt_Provincia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Provincia.KeyPress
        e.KeyChar = ChrW(solo_letras(e))
        If e.KeyChar = Chr(13) Then
            Txt_Provincia.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub Localidad_LocalidadTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Localidad_LocalidadTextBox.KeyPress
        e.KeyChar = ChrW(solo_letras(e))
        If e.KeyChar = Chr(13) Then
            Localidad_LocalidadTextBox.Focus()
            e.Handled = True
        End If
    End Sub

    Private Sub Provincia_LocalidadTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Provincia_LocalidadTextBox.KeyPress
        e.KeyChar = ChrW(solo_letras(e))
        If e.KeyChar = Chr(13) Then
            Provincia_LocalidadTextBox.Focus()
            e.Handled = True
        End If
    End Sub

End Class