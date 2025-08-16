Imports Microsoft.Data.SqlClient

Public Class DocGia
    Dim db As New data()
    Dim isAdding As Boolean = False

    Private Sub DocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        SetViewOnly(True)
        btnXoaDG.Enabled = False
        btnSuaDG.Enabled = False
    End Sub

    Private Sub LoadData(Optional search As String = "")
        Dim sql As String = "SELECT * FROM DocGia"
        If search <> "" Then
            sql &= " WHERE MaDocGia LIKE @search OR TenDocGia LIKE @search OR DiaChi LIKE @search OR SoDienThoai LIKE @search"
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
        dgvDocGia.DataSource = dt
    End Sub

    Private Sub SetViewOnly(viewOnly As Boolean)
        txtMaDG.ReadOnly = viewOnly
        txtTenDG.ReadOnly = viewOnly
        txtDiaChi.ReadOnly = viewOnly
        txtSDT.ReadOnly = viewOnly
    End Sub

    Private Sub ClearText()
        txtMaDG.Text = ""
        txtTenDG.Text = ""
        txtDiaChi.Text = ""
        txtSDT.Text = ""
    End Sub

    Private Sub btnThemDG_Click(sender As Object, e As EventArgs) Handles btnThemDG.Click
        If Not isAdding Then
            isAdding = True
            SetViewOnly(False)
            ClearText()
            btnThemDG.Text = "Lưu"
            btnXoaDG.Enabled = False
            btnSuaDG.Enabled = False
            txtMaDG.Focus()
        Else
            If txtMaDG.Text = "" Or txtTenDG.Text = "" Then
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!")
                Return
            End If
            Dim sql As String = "INSERT INTO DocGia (MaDocGia, TenDocGia, DiaChi, SoDienThoai) VALUES (@MaDocGia, @TenDocGia, @DiaChi, @SoDienThoai)"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaDocGia", txtMaDG.Text),
                New SqlParameter("@TenDocGia", txtTenDG.Text),
                New SqlParameter("@DiaChi", txtDiaChi.Text),
                New SqlParameter("@SoDienThoai", txtSDT.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Thêm độc giả thành công!")
                LoadData()
                SetViewOnly(True)
                btnThemDG.Text = "Thêm"
                isAdding = False
            End If
        End If
    End Sub

    Private Sub dgvDocGia_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocGia.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDocGia.Rows(e.RowIndex)
            txtMaDG.Text = row.Cells("MaDocGia").Value.ToString()
            txtTenDG.Text = row.Cells("TenDocGia").Value.ToString()
            txtDiaChi.Text = row.Cells("DiaChi").Value.ToString()
            txtSDT.Text = row.Cells("SoDienThoai").Value.ToString()
            btnXoaDG.Enabled = True
            btnSuaDG.Enabled = True
            SetViewOnly(True)
            btnThemDG.Text = "Thêm"
            isAdding = False
        End If
    End Sub

    Private Sub btnXoaDG_Click(sender As Object, e As EventArgs) Handles btnXoaDG.Click
        If txtMaDG.Text = "" Then Return
        If MessageBox.Show("Bạn có chắc muốn xóa độc giả này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM DocGia WHERE MaDocGia = @MaDocGia"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@MaDocGia", txtMaDG.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Xóa độc giả thành công!")
                LoadData()
                ClearText()
                btnXoaDG.Enabled = False
                btnSuaDG.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnSuaDG_Click(sender As Object, e As EventArgs) Handles btnSuaDG.Click
        If btnSuaDG.Text = "Sửa" Then
            SetViewOnly(False)
            txtMaDG.ReadOnly = True
            btnSuaDG.Text = "Lưu"
            btnThemDG.Enabled = False
            btnXoaDG.Enabled = False
        Else
            Dim sql As String = "UPDATE DocGia SET TenDocGia=@TenDocGia, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai WHERE MaDocGia=@MaDocGia"
            Dim paramList As New List(Of SqlParameter) From {
                New SqlParameter("@TenDocGia", txtTenDG.Text),
                New SqlParameter("@DiaChi", txtDiaChi.Text),
                New SqlParameter("@SoDienThoai", txtSDT.Text),
                New SqlParameter("@MaDocGia", txtMaDG.Text)
            }
            If db.ThucHienLenh(sql, paramList) Then
                MessageBox.Show("Sửa thông tin độc giả thành công!")
                LoadData()
                SetViewOnly(True)
                btnSuaDG.Text = "Sửa"
                btnThemDG.Enabled = True
                btnXoaDG.Enabled = False
            End If
        End If
    End Sub

    Private Sub lblSDT_Click(sender As Object, e As EventArgs) Handles lblSDT.Click

    End Sub

    Private Sub dgvDocGia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocGia.CellContentClick

    End Sub
End Class