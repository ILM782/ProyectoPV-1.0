Public Class TablasClientes

 
    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub TablasClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)

        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)

        ComboBox1.Items.Add("ID_Cliente")
        ComboBox1.Items.Add("Nombre_Cliente")
        ComboBox1.Items.Add("Apellido_Cliente")
        ComboBox1.Items.Add("ID_Localidad")
        ComboBox1.Items.Add("Domicilio_Cliente")
        ComboBox1.Items.Add("Telefono_Cliente")
        ComboBox1.Items.Add("Correo_Cliente")
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        ' Me.ClientesTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
        Me.LocalidadBindingSource.AddNew()
        Me.ClienteBindingSource.AddNew()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Object
        respuesta = MsgBox("¿Desea Salir?", MsgBoxStyle.YesNo, "Advertencia!")
        If respuesta = vbYes Then
            End
            Exit Sub
        End If
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Btn_Consultar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consultar_Cliente.Click
        Dim fila As Integer
        If ComboBox1.Text <> "" Then

            fila = Me.ClienteBindingSource.Find(ComboBox1.Text, Txt_Consulta_Cliente.Text)
            If fila <> -1 Then
                ClienteBindingSource.Position = fila
                MsgBox("Encontrado")
            Else
                MsgBox("El registro no encontro")
            End If
        Else
            MsgBox("El campo esta vacio")
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        ComboBox1.Text = ""
        Txt_Consulta_Cliente.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As Integer
        If ID_LocalidadTextBox.Text <> "" Then

            fila = Me.LocalidadBindingSource.Find("ID_Localidad", ID_LocalidadTextBox.Text)
            If fila <> -1 Then


                Me.ClienteBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)
                Me.ClienteTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cliente)
                Me.ClienteBindingSource.MoveLast()

                Me.ClienteBindingSource.AddNew()
                MsgBox("GUARDADO EXITOSO")
            Else
                MsgBox("Localidad no encontrada")
            End If
        Else
            MsgBox("El campo esta vacio")
        End If

        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.LocalidadBindingSource.EndEdit() ' finaliza edicion
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco 

        Me.LocalidadBindingSource.MoveLast()

        Me.LocalidadBindingSource.AddNew()
    End Sub
End Class