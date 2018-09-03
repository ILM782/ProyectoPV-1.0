Public Class Form2

    'PARA HACER LA BARRA DE NAVEGACION(http://codigofacilito.com/videos/visual_basic_net_parte_menustrip_curso_vbnet)
    Private Sub Form3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form3ToolStripMenuItem.Click

        Form3.ShowDialog()

    End Sub

    Private Sub NUEVOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUEVOToolStripMenuItem.Click

        MsgBox("Ha dado click en nuevo")

    End Sub

    Private Sub CERRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERRARToolStripMenuItem.Click

        MsgBox("Ha dado click en cerrar")

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click

        Me.Close()
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized 'PARA MAXIMIZAR LA VENTANA A LA MEDIDA DE LA PANTALLA(http://www.forosdelweb.com/f69/colocar-formulario-pantalla-completa-518379/)

    End Sub

    Private Sub Btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Salir.Click
        End
        Stop
    End Sub
End Class