Imports Microsoft.Data.SqlClient

Public Class PhieuMuon
    Dim db As New data()
    Dim isAdding As Boolean = False

    Private Sub PhieuMuon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        SetViewOnly(True)
        btnXoaPM.Enabled = False
        btnSuaPM.Enabled = False
    End Sub

    Private Sub LoadData(Optional search As String = "")
        Dim sql As String = "SELECT * FROM PhieuMuon"
        If search <> "" Then
            sql &= " WHERE MaPhieuMuon LIKE @search OR MaDocGia LIKE @search OR MaNhanVien LIKE @search"
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
        dgvPhieuMuon.DataSource = dt
    End Sub

    Private Sub SetViewOnly(viewOnly As Boolean)
        txtMaPM.ReadOnly = viewOnly
        txtMaDG2.ReadOnly = viewOnly
        txtNgayMuon.ReadOnly = viewOnly
        txtNgayTra.ReadOnly = viewOnly
        txtMaNV.ReadOnly = viewOnly
    End Sub

    Private Sub ClearText()
        txtMaPM.Text = ""
        txtMaDG2.Text = ""
        txtNgayMuon.Text = ""
        txtNgayTra.Text = ""
        txtMaNV.Text = ""
    End Sub

    Private Function DocGiaExists(maDG As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM DocGia WHERE MaDocGia = @MaDocGia"
        Using conn As New SqlConnection(db.conn.ConnectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaDocGia", maDG)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                conn.Close()
                Return count > 0
            End Using
        End Using
    End Function

    Private Function AddDocGia(maDG As String) As Boolean
        Dim sql As String = "INSERT INTO DocGia (MaDocGia, TenDocGia, DiaChi, SoDienThoai) VALUES (@MaDocGia, N'', N'', N'')"
        Dim paramList As New List(Of SqlParameter) From {
            New SqlParameter("@MaDocGia", maDG)
        }
        Return db.ThucHienLenh(sql, paramList)
    End Function

    Private Sub btnThemPM_Click(sender As Object, e As EventArgs) Handles btnThemPM.Click
        If Not isAdding Then
            isAdding = True
            SetViewOnly(False)
            ClearText()
            btnThemPM.Text = "Lưu"
            btnXoaPM.Enabled = False
            btnSuaPM.Enabled = False
            txtMaPM.Focus()
        Else
            If txtMaPM.Text = "" Or txtMaDG2.Text = "" Or txtMaNV.Text = "" Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
                Return
            End If

            ' Kiểm tra mã độc giả
            If Not DocGiaExists(txtMaDG2.Text) Then
                Dim result = MessageBox.Show("Mã độc giả chưa tồn tại. Bạn có muốn thêm mới không?", "Thêm độc giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    If Not AddDocGia(txtMaDG2.Text) Then
                        MessageBox.Show("Không thể thêm độc giả mới.")
                        Return
                    End If
                Else
                    Return
                End If
            End If

            Dim sql As String = "INSERT INTO PhieuMuon (MaPhieuMuon, MaDocGia, NgayMuon, NgayTra, MaNhanVien) VALUES (@MaPhieuMuon, @MaDocGia, @NgayMuon, @NgayTra, @MaNhanVien)"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaPhieuMuon", txtMaPM.Text),
                New SqlParameter("@MaDocGia", txtMaDG2.Text),
                New SqlParameter("@NgayMuon", txtNgayMuon.Text),
                New SqlParameter("@NgayTra", txtNgayTra.Text),
                New SqlParameter("@MaNhanVien", txtMaNV.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Thêm phiếu mượn thành công!")
                LoadData()
                SetViewOnly(True)
                btnThemPM.Text = "Thêm"
                isAdding = False
            End If
        End If
    End Sub

    Private Sub dgvPhieuMuon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhieuMuon.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPhieuMuon.Rows(e.RowIndex)
            txtMaPM.Text = row.Cells("MaPhieuMuon").Value.ToString()
            txtMaDG2.Text = row.Cells("MaDocGia").Value.ToString()
            txtNgayMuon.Text = row.Cells("NgayMuon").Value.ToString()
            txtNgayTra.Text = row.Cells("NgayTra").Value.ToString()
            txtMaNV.Text = row.Cells("MaNhanVien").Value.ToString()
            btnXoaPM.Enabled = True
            btnSuaPM.Enabled = True
            SetViewOnly(True)
            btnThemPM.Text = "Thêm"
            isAdding = False
        End If
    End Sub

    Private Sub btnXoaPM_Click(sender As Object, e As EventArgs) Handles btnXoaPM.Click
        If txtMaPM.Text = "" Then Return
        If MessageBox.Show("Bạn có chắc muốn xóa phiếu mượn này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM PhieuMuon WHERE MaPhieuMuon = @MaPhieuMuon"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaPhieuMuon", txtMaPM.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Xóa phiếu mượn thành công!")
                LoadData()
                ClearText()
                btnXoaPM.Enabled = False
                btnSuaPM.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSuaPM_Click(sender As Object, e As EventArgs) Handles btnSuaPM.Click
        If btnSuaPM.Text = "Sửa" Then
            SetViewOnly(False)
            txtMaPM.ReadOnly = True
            btnSuaPM.Text = "Lưu"
            btnThemPM.Enabled = False
            btnXoaPM.Enabled = False
        Else
            ' Chuyển đổi ngày mượn và ngày trả sang kiểu Date
            Dim ngayMuonValue As Date
            Dim ngayTraValue As Date
            If Not Date.TryParse(txtNgayMuon.Text, ngayMuonValue) Then
                MessageBox.Show("Ngày mượn không hợp lệ. Vui lòng nhập đúng định dạng ngày (vd: 2024-05-28).")
                txtNgayMuon.Focus()
                Return
            End If
            If Not Date.TryParse(txtNgayTra.Text, ngayTraValue) Then
                MessageBox.Show("Ngày trả không hợp lệ. Vui lòng nhập đúng định dạng ngày (vd: 2024-06-10).")
                txtNgayTra.Focus()
                Return
            End If

            Dim sql As String = "UPDATE PhieuMuon SET MaDocGia=@MaDocGia, NgayMuon=@NgayMuon, NgayTra=@NgayTra, MaNhanVien=@MaNhanVien WHERE MaPhieuMuon=@MaPhieuMuon"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaDocGia", txtMaDG2.Text),
                New SqlParameter("@NgayMuon", SqlDbType.Date) With {.Value = ngayMuonValue},
                New SqlParameter("@NgayTra", SqlDbType.Date) With {.Value = ngayTraValue},
                New SqlParameter("@MaNhanVien", txtMaNV.Text),
                New SqlParameter("@MaPhieuMuon", txtMaPM.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Sửa thông tin phiếu mượn thành công!")
                LoadData()
                SetViewOnly(True)
                btnSuaPM.Text = "Sửa"
                btnThemPM.Enabled = True
                btnXoaPM.Enabled = False
            End If
        End If
    End Sub
End Class