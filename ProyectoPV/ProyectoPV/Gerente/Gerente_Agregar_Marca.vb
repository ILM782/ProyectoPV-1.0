Public Class Gerente_Agregar_Marca


    Private Sub MarcasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MarcasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Agregar_Marca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)
        Me.MarcasBindingSource.AddNew()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia")
        If respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim Consulta As Integer
        If TextBox2.Text <> "" Then

            Consulta = Me.MarcasBindingSource.Find("Marca", TextBox2.Text)
            If Consulta <> -1 Then
                MsgBox("Marca Repetida", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.MarcasBindingSource.Current("Marca") = TextBox2.Text
                Me.MarcasBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en discoc
                Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)
                Gerente_Producto.MarcasTableAdapter.Fill(Gerente_Producto.MayoristaBaseDeDatosDataSet.Marcas)
                Me.MarcasBindingSource.MoveLast()
                MsgBox("El Id de la marca es: " & MarcasBindingSource.Current("ID_Marca"), MsgBoxStyle.Information, " Id Marca ")
                Me.MarcasBindingSource.AddNew()
                TextBox2.Text = ""
                TextBox2.Focus()

                Gerente_Producto.ComboBox2.Text = "Seleccionar"
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Me.MarcasTableAdapter.FillByName(Me.MayoristaBaseDeDatosDataSet.Marcas, TextBox1.Text)
        If TextBox1.Text = "" Then
            Me.MarcasBindingSource.AddNew()
        End If
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If TextBox1.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = TextBox1.Text
            fila = Me.MarcasBindingSource.Find("Marca", CodConsulta)
            If fila = -1 Then
                MsgBox("Marca no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.MarcasBindingSource.Position = fila '
                aux = MsgBox("¿Seguro que quiere eliminar a " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.MarcasBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.MarcasBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.MarcasTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Marcas)
                    Gerente_Producto.MarcasTableAdapter.Fill(Gerente_Producto.MayoristaBaseDeDatosDataSet.Marcas)
                    Me.MarcasBindingSource.MoveLast()

                    TextBox1.Text = ""
                    TextBox1.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Consulta As Integer
        Dim aux As Object

        If TextBox1.Text = "" Then
            MsgBox("Primero busque Marca", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            If MarcaTextBox1.Text <> "" Then

                Consulta = Me.MarcasBindingSource.Find("Marca", MarcaTextBox1.Text)

                If Consulta <> -1 Then
                    MsgBox("Marca Repetida", MsgBoxStyle.Exclamation, "Advertencia")
                Else
                    aux = MsgBox("¿Seguro que quiere Modificar a " & TextBox1.Text & " Por " & MarcaTextBox1.Text & "?", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                    If aux = vbYes Then
                        Me.Validate()
                        Me.MarcasBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                        Gerente_Producto.MarcasTableAdapter.Fill(Gerente_Producto.MayoristaBaseDeDatosDataSet.Marcas)
                        Me.MarcasBindingSource.AddNew()
                        TextBox1.Text = ""
                        TextBox1.Focus()
                    End If
                End If
            Else
                MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox1.Text = ""
        MarcaTextBox1.Text = ""
    End Sub

   
    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 27 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON SALIR
            Call VolverToolStripMenuItem_Click(sender, e)
        End If
        If Asc(e.KeyChar) = 13 Then  'CON ESTE IF LE DIGO QUE AL PRECIONAR 27(ESC) LLAME AL BOTON ENTER
            Call Btn_Eliminar_Click(sender, e)
        End If
    End Sub
End Class