Public Class Gerente_Localidad

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Gerente_Productos.Show()
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

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Gerente_Ventas_Realizadas.Show()
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
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en discoc
                Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
                Gerente_Productos.CategoriaTableAdapter.Fill(Gerente_Productos.MayoristaBaseDeDatosDataSet.Categoria)
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
        If ID_LocalidadTextBox1.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = ID_LocalidadTextBox1.Text
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
                    Me.LocalidadBindingSource.MoveLast()
                    Me.LocalidadBindingSource.AddNew()

                    TextBox1.Text = ""
                    TextBox1.Focus()
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
End Class