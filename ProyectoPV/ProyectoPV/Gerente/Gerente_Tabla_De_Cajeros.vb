Public Class Gerente_Tabla_De_Cajeros

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        Gerente_Agregar_Cajero.Show()
        Me.Close()
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
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Localidad' Puede moverla o quitarla según sea necesario.
        Me.LocalidadTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Localidad)
        'TODO: esta línea de código carga datos en la tabla 'MayoristaBaseDeDatosDataSet.Cajero' Puede moverla o quitarla según sea necesario.
        Me.CajeroTableAdapter.Fill(Me.MayoristaBaseDeDatosDataSet.Cajero)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim vista As New DataView 'creo e instancio el objeto 

        vista.Table = Me.MayoristaBaseDeDatosDataSet.Cajero 'cargo objeto con la tabla stock
        'aux = "Id_articulo = " + Val(Me.TextBox2.Text) con el simbolo + tira error no concatena

        vista.RowFilter = " DNI_Cajero = ' " & Me.TextBox1.Text & " % ' "   'esta para numeros

        Me.CajeroDataGridView.DataSource = vista 'cargo la vista
    End Sub
End Class