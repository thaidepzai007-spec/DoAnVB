Imports Microsoft.Data.SqlClient

Public Class NhanVien
    Dim db As New data()
    Dim isAdding As Boolean = False

    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        SetViewOnly(True)
        btnXoaNV.Enabled = False
        btnSuaNV.Enabled = False
    End Sub

    Private Sub LoadData(Optional search As String = "")
        Dim sql As String = "SELECT * FROM NhanVien"
        If search <> "" Then
            sql &= " WHERE MaNhanVien LIKE @search OR TenNhanVien LIKE @search OR ChucVu LIKE @search OR DiaChi LIKE @search OR SoDienThoai LIKE @search"
        End If

        Dim dt As New DataTable()
        Using conn As New SqlConnection(db.conn.ConnectionString)
            Using da As New SqlDataAdapter(sql, conn)
                If search <> "" Then
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" & search & "%")
                End If
                da.Fill(dt)
            End Using
        End Using
        dgvNhanVien.DataSource = dt
    End Sub

    Private Sub SetViewOnly(viewOnly As Boolean)
        txtMaNV.ReadOnly = viewOnly
        txtTenNV.ReadOnly = viewOnly
        txtChucVu.ReadOnly = viewOnly
        txtDiaChi.ReadOnly = viewOnly
        txtSDT2.ReadOnly = viewOnly
    End Sub

    Private Sub ClearText()
        txtMaNV.Text = ""
        txtTenNV.Text = ""
        txtChucVu.Text = ""
        txtDiaChi.Text = ""
        txtSDT2.Text = ""
    End Sub

    Private Sub btnThemNV_Click(sender As Object, e As EventArgs) Handles btnThemNV.Click
        If Not isAdding Then
            isAdding = True
            SetViewOnly(False)
            ClearText()
            btnThemNV.Text = "Lưu"
            btnXoaNV.Enabled = False
            btnSuaNV.Enabled = False
            txtMaNV.Focus()
        Else
            If txtMaNV.Text = "" Or txtTenNV.Text = "" Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
                Return
            End If
            Dim sql As String = "INSERT INTO NhanVien (MaNhanVien, TenNhanVien, ChucVu, DiaChi, SoDienThoai) VALUES (@MaNhanVien, @TenNhanVien, @ChucVu, @DiaChi, @SoDienThoai)"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaNhanVien", txtMaNV.Text),
                New SqlParameter("@TenNhanVien", txtTenNV.Text),
                New SqlParameter("@ChucVu", txtChucVu.Text),
                New SqlParameter("@DiaChi", txtDiaChi.Text),
                New SqlParameter("@SoDienThoai", txtSDT2.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Thêm nhân viên thành công!")
                LoadData()
                SetViewOnly(True)
                btnThemNV.Text = "Thêm"
                isAdding = False
            End If
        End If
    End Sub

    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvNhanVien.Rows(e.RowIndex)
            txtMaNV.Text = row.Cells("MaNhanVien").Value.ToString()
            txtTenNV.Text = row.Cells("TenNhanVien").Value.ToString()
            txtChucVu.Text = row.Cells("ChucVu").Value.ToString()
            txtDiaChi.Text = row.Cells("DiaChi").Value.ToString()
            txtSDT2.Text = row.Cells("SoDienThoai").Value.ToString()
            btnXoaNV.Enabled = True
            btnSuaNV.Enabled = True
            SetViewOnly(True)
            btnThemNV.Text = "Thêm"
            isAdding = False
        End If
    End Sub

    Private Sub btnXoaNV_Click(sender As Object, e As EventArgs) Handles btnXoaNV.Click
        If txtMaNV.Text = "" Then Return
        If MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaNhanVien", txtMaNV.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Xóa nhân viên thành công!")
                LoadData()
                ClearText()
                btnXoaNV.Enabled = False
                btnSuaNV.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSuaNV_Click(sender As Object, e As EventArgs) Handles btnSuaNV.Click
        If btnSuaNV.Text = "Sửa" Then
            SetViewOnly(False)
            txtMaNV.ReadOnly = True
            btnSuaNV.Text = "Lưu"
            btnThemNV.Enabled = False
            btnXoaNV.Enabled = False
        Else
            Dim sql As String = "UPDATE NhanVien SET TenNhanVien=@TenNhanVien, ChucVu=@ChucVu, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai WHERE MaNhanVien=@MaNhanVien"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@TenNhanVien", txtTenNV.Text),
                New SqlParameter("@ChucVu", txtChucVu.Text),
                New SqlParameter("@DiaChi", txtDiaChi.Text),
                New SqlParameter("@SoDienThoai", txtSDT2.Text),
                New SqlParameter("@MaNhanVien", txtMaNV.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Sửa thông tin nhân viên thành công!")
                LoadData()
                SetViewOnly(True)
                btnSuaNV.Text = "Sửa"
                btnThemNV.Enabled = True
                btnXoaNV.Enabled = False
            End If
        End If
    End Sub
End Class