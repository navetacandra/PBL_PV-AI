Public Class Form1
    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        Dim frm As New MhsListView()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
