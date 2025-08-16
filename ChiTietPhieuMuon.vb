Imports Microsoft.Data.SqlClient

Public Class ChiTietPhieuMuon
    Dim db As New data()
    Dim isAdding As Boolean = False

    Private Sub ChiTietPhieuMuon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        SetViewOnly(True)
        btnXoaCTPM.Enabled = False
        btnSuaCTPM.Enabled = False
    End Sub

    Private Sub LoadData(Optional search As String = "")
        Dim sql As String = "SELECT * FROM ChiTietPhieuMuon"
        If search <> "" Then
            sql &= " WHERE MaPhieuMuon LIKE @search OR MaSach LIKE @search OR MaNhanVien LIKE @search"
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
        dgvCTPM.DataSource = dt
    End Sub

    Private Sub SetViewOnly(viewOnly As Boolean)
        txtMaPM.ReadOnly = viewOnly
        txtMaSach.ReadOnly = viewOnly
        txtMaNV.ReadOnly = viewOnly
        txtSoLuongMuon.ReadOnly = viewOnly
    End Sub

    Private Sub ClearText()
        txtMaPM.Text = ""
        txtMaSach.Text = ""
        txtMaNV.Text = ""
        txtSoLuongMuon.Text = ""
    End Sub

    Private Sub btnThemCTPM_Click(sender As Object, e As EventArgs) Handles btnThemCTPM.Click
        If Not isAdding Then
            isAdding = True
            SetViewOnly(False)
            ClearText()
            btnThemCTPM.Text = "Lưu"
            btnXoaCTPM.Enabled = False
            btnSuaCTPM.Enabled = False
            txtMaPM.Focus()
        Else
            If txtMaPM.Text = "" Or txtMaSach.Text = "" Or txtMaNV.Text = "" Or txtSoLuongMuon.Text = "" Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
                Return
            End If
            Dim sql As String = "INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaSach, MaNhanVien, SoLuongMuon) VALUES (@MaPhieuMuon, @MaSach, @MaNhanVien, @SoLuongMuon)"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaPhieuMuon", txtMaPM.Text),
                New SqlParameter("@MaSach", txtMaSach.Text),
                New SqlParameter("@MaNhanVien", txtMaNV.Text),
                New SqlParameter("@SoLuongMuon", txtSoLuongMuon.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Thêm chi tiết phiếu mượn thành công!")
                LoadData()
                SetViewOnly(True)
                btnThemCTPM.Text = "Thêm"
                isAdding = False
            End If
        End If
    End Sub

    Private Sub dgvCTPM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTPM.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCTPM.Rows(e.RowIndex)
            txtMaPM.Text = row.Cells("MaPhieuMuon").Value.ToString()
            txtMaSach.Text = row.Cells("MaSach").Value.ToString()
            txtMaNV.Text = row.Cells("MaNhanVien").Value.ToString()
            txtSoLuongMuon.Text = row.Cells("SoLuongMuon").Value.ToString()
            btnXoaCTPM.Enabled = True
            btnSuaCTPM.Enabled = True
            SetViewOnly(True)
            btnThemCTPM.Text = "Thêm"
            isAdding = False
        End If
    End Sub

    Private Sub btnXoaCTPM_Click(sender As Object, e As EventArgs) Handles btnXoaCTPM.Click
        If txtMaPM.Text = "" Or txtMaSach.Text = "" Then Return
        If MessageBox.Show("Bạn có chắc muốn xóa chi tiết phiếu mượn này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM ChiTietPhieuMuon WHERE MaPhieuMuon = @MaPhieuMuon AND MaSach = @MaSach"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaPhieuMuon", txtMaPM.Text),
                New SqlParameter("@MaSach", txtMaSach.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Xóa chi tiết phiếu mượn thành công!")
                LoadData()
                ClearText()
                btnXoaCTPM.Enabled = False
                btnSuaCTPM.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSuaCTPM_Click(sender As Object, e As EventArgs) Handles btnSuaCTPM.Click
        If btnSuaCTPM.Text = "Sửa" Then
            SetViewOnly(False)
            txtMaPM.ReadOnly = True
            btnSuaCTPM.Text = "Lưu"
            txtMaSach.ReadOnly = False
            btnThemCTPM.Enabled = False
            btnXoaCTPM.Enabled = False
        Else
            Dim sql As String = "UPDATE ChiTietPhieuMuon SET MaNhanVien=@MaNhanVien, SoLuongMuon=@SoLuongMuon WHERE MaPhieuMuon=@MaPhieuMuon AND MaSach=@MaSach"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaNhanVien", txtMaNV.Text),
                New SqlParameter("@SoLuongMuon", txtSoLuongMuon.Text),
                New SqlParameter("@MaPhieuMuon", txtMaPM.Text),
                New SqlParameter("@MaSach", txtMaSach.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Sửa chi tiết phiếu mượn thành công!")
                LoadData()
                SetViewOnly(True)
                btnSuaCTPM.Text = "Sửa"
                btnThemCTPM.Enabled = True
                btnXoaCTPM.Enabled = False
            End If
        End If
    End Sub
End Class