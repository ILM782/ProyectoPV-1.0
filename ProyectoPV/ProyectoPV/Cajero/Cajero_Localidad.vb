Public Class Cajero_Localidad

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

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        Cajero_Producto_Para_Ventas.Show()
        Me.Close()
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        Cajero_Agregar_Cliente.Show()
        Me.Close()
    End Sub

    Private Sub TransaccionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionToolStripMenuItem.Click
        Cajero_Transaccion_Venta.Show()
        Me.Close()
    End Sub

    Private Sub LocalidadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.LocalidadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Cajero_Localidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        Me.LocalidadBindingSource.AddNew()
    End Sub

    Private Sub Btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Buscar.Click
        Dim consulta As Integer
        If Localidad_LocalidadTextBox.Text <> "" Or CP_LocalidadTextBox.Text <> "" Or Provincia_LocalidadTextBox.Text <> "" Then
            consulta = Me.LocalidadBindingSource.Find("CP_Localidad", CP_LocalidadTextBox.Text)

            If consulta <> -1 Then
                MsgBox("Localidad Repetida", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.LocalidadBindingSource.Current("Localidad_Localidad") = Localidad_LocalidadTextBox.Text
                Me.LocalidadBindingSource.Current("CP_Localidad") = Val(CP_LocalidadTextBox.Text)
                Me.LocalidadBindingSource.Current("Provincia_Localidad") = Provincia_LocalidadTextBox.Text
                Me.LocalidadBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
                Me.LocalidadBindingSource.MoveLast()
                MsgBox("El Id de la Localidad es: " & LocalidadBindingSource.Current("ID_Localidad"), MsgBoxStyle.Information, " ID_Localidad ")

                Me.LocalidadBindingSource.AddNew()
                Localidad_LocalidadTextBox.Text = ""
                CP_LocalidadTextBox.Text = ""
                Provincia_LocalidadTextBox.Text = ""


            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.LocalidadTableAdapter.FillBy(Me.MayoristaBaseDeDatosDataSet.Localidad, TextBox1.Text)
    End Sub
End Class