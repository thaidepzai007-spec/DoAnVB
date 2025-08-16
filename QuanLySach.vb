Imports Microsoft.Data.SqlClient

Public Class QuanLySach
    Dim db As New data()
    Dim isAdding As Boolean = False

    Private Sub QuanLySach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        SetViewOnly(True)
        btnXoaSach.Enabled = False
        btnSuaSach.Enabled = False
    End Sub

    Private Sub LoadData(Optional search As String = "")
        Dim sql As String = "SELECT * FROM Sach"
        If search <> "" Then
            sql &= " WHERE MaSach LIKE @search OR TenSach LIKE @search OR TenTacGia LIKE @search OR TheLoai LIKE @search"
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
        dgvDanhSS.DataSource = dt
    End Sub

    Private Sub SetViewOnly(viewOnly As Boolean)
        txtMaSach.ReadOnly = viewOnly
        txtTenSach.ReadOnly = viewOnly
        txtTacGia.ReadOnly = viewOnly
        txtTheLoai.ReadOnly = viewOnly
        txtSoLuong.ReadOnly = viewOnly
        txtNamXB.ReadOnly = viewOnly
    End Sub

    Private Sub ClearText()
        txtMaSach.Text = ""
        txtTenSach.Text = ""
        txtTacGia.Text = ""
        txtTheLoai.Text = ""
        txtSoLuong.Text = ""
        txtNamXB.Text = ""
    End Sub

    Private Sub btnThemSach_Click(sender As Object, e As EventArgs) Handles btnThemSach.Click
        If Not isAdding Then
            isAdding = True
            SetViewOnly(False)
            ClearText()
            btnThemSach.Text = "Lưu"
            btnXoaSach.Enabled = False
            btnSuaSach.Enabled = False
            txtMaSach.Focus()
        Else
            ' Thêm sách vào CSDL
            If txtMaSach.Text = "" Or txtTenSach.Text = "" Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
                Return
            End If
            Dim sql As String = "INSERT INTO Sach (MaSach, TenSach, TenTacGia, TheLoai, SoLuong, NamXuatBan) VALUES (@MaSach, @TenSach, @TenTacGia, @TheLoai, @SoLuong, @NamXuatBan)"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaSach", txtMaSach.Text),
                New SqlParameter("@TenSach", txtTenSach.Text),
                New SqlParameter("@TenTacGia", txtTacGia.Text),
                New SqlParameter("@TheLoai", txtTheLoai.Text),
                New SqlParameter("@SoLuong", txtSoLuong.Text),
                New SqlParameter("@NamXuatBan", txtNamXB.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Thêm sách thành công!")
                LoadData()
                SetViewOnly(True)
                btnThemSach.Text = "Thêm"
                isAdding = False
            End If
        End If
    End Sub

    Private Sub dgvDanhSS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSS.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDanhSS.Rows(e.RowIndex)
            txtMaSach.Text = row.Cells("MaSach").Value.ToString()
            txtTenSach.Text = row.Cells("TenSach").Value.ToString()
            txtTacGia.Text = row.Cells("TenTacGia").Value.ToString()
            txtTheLoai.Text = row.Cells("TheLoai").Value.ToString()
            txtSoLuong.Text = row.Cells("SoLuong").Value.ToString()
            txtNamXB.Text = row.Cells("NamXuatBan").Value.ToString()
            btnXoaSach.Enabled = True
            btnSuaSach.Enabled = True
            SetViewOnly(True)
            btnThemSach.Text = "Thêm"
            isAdding = False
        End If
    End Sub

    Private Sub btnXoaSach_Click(sender As Object, e As EventArgs) Handles btnXoaSach.Click
        If txtMaSach.Text = "" Then Return
        If MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM Sach WHERE MaSach = @MaSach"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaSach", txtMaSach.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Xóa sách thành công!")
                LoadData()
                ClearText()
                btnXoaSach.Enabled = False
                btnSuaSach.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSuaSach_Click(sender As Object, e As EventArgs) Handles btnSuaSach.Click
        If btnSuaSach.Text = "Sửa" Then
            SetViewOnly(False)
            txtMaSach.ReadOnly = True ' Không cho sửa mã sách
            btnSuaSach.Text = "Lưu"
            btnThemSach.Enabled = False
            btnXoaSach.Enabled = False
        Else
            ' Lưu sửa
            Dim sql As String = "UPDATE Sach SET TenSach=@TenSach, TenTacGia=@TenTacGia, TheLoai=@TheLoai, SoLuong=@SoLuong, NamXuatBan=@NamXuatBan WHERE MaSach=@MaSach"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@TenSach", txtTenSach.Text),
                New SqlParameter("@TenTacGia", txtTacGia.Text),
                New SqlParameter("@TheLoai", txtTheLoai.Text),
                New SqlParameter("@SoLuong", txtSoLuong.Text),
                New SqlParameter("@NamXuatBan", txtNamXB.Text),
                New SqlParameter("@MaSach", txtMaSach.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Sửa thông tin sách thành công!")
                LoadData()
                SetViewOnly(True)
                btnSuaSach.Text = "Sửa"
                btnThemSach.Enabled = True
                btnXoaSach.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        LoadData(txtTimKiemSach.Text.Trim())
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub
End Class