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

    Private Sub Txt_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Buscar.TextChanged
        Me.CategoriaTableAdapter.FillByName(Me.MayoristaBaseDeDatosDataSet.Categoria, Txt_Buscar.Text)
        If Txt_Buscar.Text = "" Then
            Me.CategoriaBindingSource.AddNew()
        End If

    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim Consulta As Integer
        If TextBox1.Text <> "" Then

            Consulta = Me.CategoriaBindingSource.Find("Categoria", TextBox1.Text)
            If Consulta <> -1 Then
                MsgBox("Categoria Repetida", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.CategoriaBindingSource.Current("Categoria") = TextBox1.Text
                Me.CategoriaBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en discoc
                Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
                Gerente_Producto.CategoriaTableAdapter.Fill(Gerente_Producto.MayoristaBaseDeDatosDataSet.Categoria)
                Me.CategoriaBindingSource.MoveLast()
                MsgBox("El Id de la categoria es: " & CategoriaBindingSource.Current("ID_Categoria"), MsgBoxStyle.Information, " Id Categoria ")
                Me.CategoriaBindingSource.AddNew()
                TextBox1.Text = ""
                TextBox1.Focus()

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
                MsgBox("Categoria no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.CategoriaBindingSource.Position = fila '
                aux = MsgBox("¿Seguro que quiere eliminar a " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.CategoriaBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.CategoriaBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.CategoriaTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Categoria)
                    Gerente_Producto.CategoriaTableAdapter.Fill(Gerente_Producto.MayoristaBaseDeDatosDataSet.Categoria)
                    Me.CategoriaBindingSource.MoveLast()
                    TextBox1.Text = ""
                    Txt_Buscar.Text = ""
                    Txt_Buscar.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        Dim Consulta As Integer
        Dim aux As Object

        If Txt_Buscar.Text = "" Then
            MsgBox("Primero busque categoria", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            If CategoriaTextBox1.Text <> "" Then

                Consulta = Me.CategoriaBindingSource.Find("Categoria", CategoriaTextBox1.Text)

                If Consulta <> -1 Then
                    MsgBox("Categoria Repetida", MsgBoxStyle.Exclamation, "Advertencia")
                Else
                    aux = MsgBox("¿Seguro que quiere Modificar a " & Txt_Buscar.Text & " Por " & CategoriaTextBox1.Text & "?", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                    If aux = vbYes Then
                        Me.Validate()
                        Me.CategoriaBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                        Gerente_Producto.CategoriaTableAdapter.Fill(Gerente_Producto.MayoristaBaseDeDatosDataSet.Categoria)
                        Me.CategoriaBindingSource.AddNew()
                        Txt_Buscar.Text = ""
                        Txt_Buscar.Focus()
                    End If
                End If
            Else
                MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Txt_Buscar.Text = ""
        CategoriaTextBox1.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call VolveToolStripMenuItem_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON ENTER
            Call Btn_Guardar_Click(sender, e)
        End If
    End Sub
End Class