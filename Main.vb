Public Class Main
    Private Sub đăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles đăngXuấtToolStripMenuItem.Click
        Dim dangNhapForm As New DangNhap()
        dangNhapForm.Show()
        Me.Hide()
    End Sub

    Private Sub thoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles thoátToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub quảnLíSáchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles quảnLíSáchToolStripMenuItem1.Click
        Dim frm As New QuanLySach()
        frm.ShowDialog()
    End Sub

    Private Sub độcGiảToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles độcGiảToolStripMenuItem1.Click
        Dim frm As New DocGia()
        frm.ShowDialog()
    End Sub

    Private Sub nhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles nhânViênToolStripMenuItem.Click
        Dim frm As New NhanVien()
        frm.ShowDialog()
    End Sub

    Private Sub phiếuMượnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles phiếuMượnToolStripMenuItem.Click
        Dim frm As New PhieuMuon()
        frm.ShowDialog()
    End Sub

    Private Sub chiTiếtPhiếuMượnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles chiTiếtPhiếuMượnToolStripMenuItem.Click
        Dim frm As New ChiTietPhieuMuon()
        frm.ShowDialog()
    End Sub
End Class