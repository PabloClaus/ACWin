Public Class frmPrincipal

    Private Sub menuPublicadores_Click(sender As Object, e As EventArgs) Handles menuPublicadores.Click
        frmPublicadores.MdiParent = Me
        frmPublicadores.Show()
        frmPublicadores.WindowState = FormWindowState.Maximized
    End Sub
End Class
