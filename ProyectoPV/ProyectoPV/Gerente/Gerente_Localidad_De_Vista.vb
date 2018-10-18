Public Class Gerente_Localidad_De_Vista

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
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

    Private Sub Gerente_Localidad_De_Vista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        ComboBox1.Items.Add("Localidad")
        ComboBox1.Items.Add("Provincia")
        ComboBox1.Text = "Seleccionar"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "Localidad" Then
            Me.LocalidadTableAdapter.FillBy(Me.MayoristaBaseDeDatosDataSet.Localidad, TextBox1.Text)
        Else
            If ComboBox1.Text = "Provincia" Then
                Me.LocalidadTableAdapter.FillByprovincia(Me.MayoristaBaseDeDatosDataSet.Localidad, TextBox1.Text)
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ""
    End Sub
End Class