Public Class Gerente_Proveedores

    Private Sub ProveedorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet)

    End Sub

    Private Sub Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Proveedor)
        Me.ProveedorBindingSource.AddNew()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Gerente_Producto.Show()
        Me.Close()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Gerente_TablasClientes.Show()
        Me.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
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

    Private Sub TransaccionesDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaccionesDeCompraToolStripMenuItem.Click
        Gerente_Transacciones_de_Compras.Show()
        Me.Close()
    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Gerente_Localidad.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Guardar.Click
        Dim consulta1 As Integer
        If Txt_Nombre_Empresa.Text <> "" And Txt_Correo.Text <> "" And Txt_Domicilio.Text <> "" And Txt_Telefono.Text <> "" Then
            consulta1 = Me.ProveedorBindingSource.Find("Nombre_Empresa", Txt_Nombre_Empresa.Text)

            If consulta1 <> -1 Then
                MsgBox("Nombre de empresa repetida", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ProveedorBindingSource.Current("Nombre_Empresa") = Txt_Nombre_Empresa.Text()
                Me.ProveedorBindingSource.Current("Telefono_Proveedor") = Val(Txt_Telefono.Text)
                Me.ProveedorBindingSource.Current("Domicilio_Proveedor") = Txt_Domicilio.Text
                Me.ProveedorBindingSource.Current("Correo_Proveedor") = Txt_Correo.Text
                Me.ProveedorBindingSource.Current("ID_Localidad") = Val(ComboBox1.SelectedValue)
                Me.ProveedorBindingSource.EndEdit() ' finaliza edicion
                Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en discoc
                Me.ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Proveedor)
                Me.ProveedorBindingSource.MoveLast()
                MsgBox("El Id de la Proveedor es: " & ProveedorBindingSource.Current("ID_Proveedor"), MsgBoxStyle.Information, " Id Localidad ")
                Me.ProveedorBindingSource.AddNew()
                Txt_Correo.Text = ""
                Txt_Domicilio.Text = ""
                Txt_Nombre_Empresa.Text = ""
                Txt_Telefono.Text = ""
            End If
        Else
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'arranco con una grilla sin enlazar, traigo las dos grilla enlazada, edito la grilla con las columnas
        'case para elejir atributo con un combobox
        Dim fila, contador, Total, filaConsulta, art As Integer
        Dim Cadena As String
        fila = 0 'ir bajando lineas en el datagrill
        Total = 0 'sumo los subtotales
        filaConsulta = 0 'para hacer la consulta de la otra tabla
        DataGridView1.Rows.Clear() 'limpio la grilla cada ves que ingreso un dato 
        ProveedorBindingSource.MoveFirst() 'muevo al primer registro de la tabla

        Do
            Try
                Cadena = ProveedorBindingSource.Current("Id_articulo").ToString.Substring(0, Len(TextBox1.Text))
                'ejemplo de error descripcion valor "maria"    caja de texto "mariano" len da 7 y maria tiene solo 5 tira error
            Catch ex As Exception 'ante cualquier error

                Cadena = ""

            End Try
            'ucase para pasarlo a mayuscula

            If UCase(Cadena) = UCase(TextBox1.Text) Then
                DataGridView1.Rows.Add() 'columna
                DataGridView1.Item(0, fila).Value = ProveedorBindingSource.Current("ID_Proveedor")
                DataGridView1.Item(1, fila).Value = ProveedorBindingSource.Current("Nombre_Empresa")
                art = ProveedorBindingSource.Current("ID_Proveedor")

                'busco la cantidad apartir del id en la tabla blister
                filaConsulta = Me.LocalidadBindingSource.Find("ID_Localidad", ProveedorBindingSource.Current("Localidad")) 'busco relacion id-descripcion blister
                Me.LocalidadBindingSource.Position = filaConsulta
                DataGridView1.Item(2, fila).Value = Me.LocalidadBindingSource.Current("Localidad_Localidad") 'pego la descripcion no el id

                'continuo pegando datos de la tabla stock
                DataGridView1.Item(3, fila).Value = ProveedorBindingSource.Current("Provincia_Localidad")
                DataGridView1.Item(4, fila).Value = ProveedorBindingSource.Current("CP_Localidad")
                'pego en la grilla la multiplicacion de cantidad por precio
                DataGridView1.Item(5, fila).Value = ProveedorBindingSource.Current("Domicilio_Proveedor")
                DataGridView1.Item(6, fila).Value = ProveedorBindingSource.Current("Telefono_Proveedor")
                DataGridView1.Item(6, fila).Value = ProveedorBindingSource.Current("Correo_Proveedor")

            End If
            contador = contador + 1
            ProveedorBindingSource.MoveNext()
        Loop Until contador = ProveedorBindingSource.Count


        'creo una fila final con el total a facturar
        DataGridView1.Item(4, fila).Value = "Total a facturar"
        DataGridView1.Item(5, fila).Value = Total

        TextBox1.Focus()
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        Dim fila As Integer
        Dim CodConsulta As String
        Dim aux As Object
        If TextBox1.Text = "" Then
            MsgBox("El campo esta vacio", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            CodConsulta = TextBox1.Text
            fila = Me.ProveedorBindingSource.Find("Nombre_Empresa", CodConsulta)
            If fila = -1 Then
                MsgBox("Nombre de empresa no encontrada", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Me.ProveedorBindingSource.Position = fila
                aux = MsgBox("¿Seguro que quiere eliminar la empresa: " & CodConsulta & " ? ", MsgBoxStyle.YesNoCancel, "¿Seguro?")
                If aux = vbYes Then
                    Me.ProveedorBindingSource.RemoveCurrent() ' borro el registro donde estoy parado
                    Me.ProveedorBindingSource.EndEdit() 'cierro base de datos
                    Me.TableAdapterManager.UpdateAll(Me.MayoristaBaseDeDatosDataSet) 'guardo en disco
                    Me.ProveedorTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Proveedor)
                    Me.ProveedorBindingSource.AddNew()
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

End Class