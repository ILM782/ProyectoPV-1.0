Public Class Ventana_Principal

    'PARA HACER LA BARRA DE NAVEGACION(http://codigofacilito.com/videos/visual_basic_net_parte_menustrip_curso_vbnet)
    Private Sub Form3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Form3.ShowDialog()

    End Sub

    Private Sub NUEVOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgBox("Ha dado click en nuevo")

    End Sub

    Private Sub CERRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgBox("Ha dado click en cerrar")

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click

        Me.Close()
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized 'PARA MAXIMIZAR LA VENTANA A LA MEDIDA DE LA PANTALLA(http://www.forosdelweb.com/f69/colocar-formulario-pantalla-completa-518379/)

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click

        End
        Stop

    End Sub


    Private Sub Btn_Salir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir2.Click

        End
        Stop

    End Sub

    Private Sub VERSIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VERSIONToolStripMenuItem.Click

        Version.Show()

    End Sub
End Class