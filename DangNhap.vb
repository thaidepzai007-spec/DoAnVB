Public Class DangNhap
    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMatKhau.PasswordChar = "●"c
        txtMatKhau.UseSystemPasswordChar = True
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim taiKhoan As String = txtTaiKhoan.Text.Trim()
        Dim matKhau As String = txtMatKhau.Text

        If taiKhoan = "admin" AndAlso matKhau = "12345" Then
            Dim mainForm As New Main()
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMatKhau.Clear()
            txtMatKhau.Focus()
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub
End Class