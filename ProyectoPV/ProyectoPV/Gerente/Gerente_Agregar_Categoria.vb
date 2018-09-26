Public Class Gerente_Agregar_Categoria

    Private Sub CategoriaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
    End Sub

    Private Sub Agregar_Categoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
        Me.CategoriaBindingSource.AddNew()
    End Sub

    Private Sub VolveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolveToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
        End If
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Hora.Text = TimeOfDay
        Fecha.Text = DateString
    End Sub

    Private Sub Txt_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Buscar.TextChanged
        Me.CategoriaTableAdapter.FillByName(Me.MayoristaBaseDeDatosDataSet.Categoria, Txt_Buscar.Text)
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim Consulta As Integer
        If CategoriaTextBox.Text <> "" Then

            Consulta = Me.CategoriaBindingSource.Find("Categoria", CategoriaTextBox.Text)
            If Consulta <> -1 Then
                MsgBox("Categoria Repetida", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.CategoriaBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en discoc
                Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
                Gerente_Productos.CategoriaTableAdapter.Fill(Gerente_Productos.MayoristaBaseDeDatosDataSet.Categoria)
                Me.CategoriaBindingSource.MoveLast()
                MsgBox("El Id de la categoria es: " & CategoriaBindingSource.Current("ID_Categoria"), MsgBoxStyle.Information, " Id Categoria ")
                Me.CategoriaBindingSource.AddNew()
                CategoriaTextBox.Text = ""
                CategoriaTextBox.Focus()
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If Txt_Buscar.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = Txt_Buscar.Text
            fila = Me.CategoriaBindingSource.Find("Categoria", CodConsulta)
            If fila = -1 Then
                MsgBox("Marca no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.CategoriaBindingSource.Position = fila '
                aux = MsgBox("¿Seguro que quiere eliminar a " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.CategoriaBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.CategoriaBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
                    Gerente_Productos.MarcasTableAdapter.Fill(Gerente_Productos.MayoristaBaseDeDatosDataSet.Marcas)
                    Me.CategoriaBindingSource.MoveLast()
                    CategoriaTextBox.Text = ""
                    Txt_Buscar.Text = ""
                    Txt_Buscar.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub CategoriaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CategoriaTextBox.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call VolveToolStripMenuItem_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Guardar_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_Buscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Buscar.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call VolveToolStripMenuItem_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call Btn_Eliminar_Click(sender, e)
        End If
    End Sub
End Class