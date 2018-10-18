Public Class Gerente_Tabla_De_Cajeros

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

    Private Sub CajeroBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CajeroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Gerente_Tabla_De_Cajeros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FacturasVentaDataSet.Cajero' Puede moverla o quitarla según sea necesario.
        Me.CajeroTableAdapter1.Fill(Me.FacturasVentaDataSet.Cajero)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cajero' Puede moverla o quitarla según sea necesario.
        Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
        ComboBox1.Text = "Seleccionar"
        ComboBox1.Items.Add("DNI")
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Apellido")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Buscar.TextChanged
        If ComboBox1.Text = "DNI" Then
            Me.CajeroTableAdapter.FillByDNI(Me.MayoristaBaseDeDatosDataSet.Cajero, Txt_Buscar.Text)
        Else
            If ComboBox1.Text = "Nombre" Then
                Me.CajeroTableAdapter.FillByNombre(Me.MayoristaBaseDeDatosDataSet.Cajero, Txt_Buscar.Text)
            Else
                If ComboBox1.Text = "Apellido" Then
                    Me.CajeroTableAdapter.FillByApellido(Me.MayoristaBaseDeDatosDataSet.Cajero, Txt_Buscar.Text)
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Txt_Buscar.Text = ""
    End Sub

    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click

        Dim aux As Object

        If Nombre_CajeroTextBox.Text <> "" And Apellido_CajeroTextBox.Text <> "" And ID_LocalidadTextBox.Text <> "" And Domicilio_CajeroTextBox.Text <> "" And Correo_CajeroTextBox.Text <> "" And DNI_CajeroTextBox.Text <> "" Then

            aux = MsgBox("¿Seguro que quiere Modificar ?", MsgBoxStyle.YesNoCancel, "¿Seguro?")
            If aux = vbYes Then
                Me.Validate()
                Me.CajeroBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
                Me.CajeroBindingSource.MoveLast()
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Cajero_Localidad_De_Vista.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If ID_CajeroTextBox.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = ID_CajeroTextBox.Text
            fila = Me.CajeroBindingSource.Find("ID_Cajero", CodConsulta)
            If fila = -1 Then
                MsgBox("Cliente no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.CajeroBindingSource.Position = fila
                aux = MsgBox("¿Seguro que quiere eliminar el id: " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.CajeroBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.CajeroBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)
                End If
            End If
        End If
    End Sub
End Class