<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLySach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuanLySach))
        btnSuaSach = New Button()
        btnXoaSach = New Button()
        btnThemSach = New Button()
        dgvDanhSS = New DataGridView()
        label1 = New Label()
        groupBox2 = New GroupBox()
        txtTimKiemSach = New TextBox()
        lblTimkiem = New Label()
        btnTimKiem = New Button()
        groupBox1 = New GroupBox()
        txtNamXB = New TextBox()
        txtSoLuong = New TextBox()
        txtTheLoai = New TextBox()
        txtTacGia = New TextBox()
        txtTenSach = New TextBox()
        txtMaSach = New TextBox()
        lblNamXB = New Label()
        lblSoLuong = New Label()
        lblTheLoai = New Label()
        lblTacGia = New Label()
        lblTenSach = New Label()
        lblMaSach = New Label()
        CType(dgvDanhSS, ComponentModel.ISupportInitialize).BeginInit()
        groupBox2.SuspendLayout()
        groupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSuaSach
        ' 
        btnSuaSach.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnSuaSach.Location = New Point(727, 337)
        btnSuaSach.Name = "btnSuaSach"
        btnSuaSach.Size = New Size(75, 23)
        btnSuaSach.TabIndex = 25
        btnSuaSach.Text = "Sửa"
        btnSuaSach.UseVisualStyleBackColor = False
        ' 
        ' btnXoaSach
        ' 
        btnXoaSach.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnXoaSach.Location = New Point(727, 245)
        btnXoaSach.Name = "btnXoaSach"
        btnXoaSach.Size = New Size(75, 23)
        btnXoaSach.TabIndex = 24
        btnXoaSach.Text = "Xóa"
        btnXoaSach.UseVisualStyleBackColor = False
        ' 
        ' btnThemSach
        ' 
        btnThemSach.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnThemSach.Location = New Point(727, 146)
        btnThemSach.Name = "btnThemSach"
        btnThemSach.Size = New Size(75, 23)
        btnThemSach.TabIndex = 23
        btnThemSach.Text = "Thêm"
        btnThemSach.UseVisualStyleBackColor = False
        ' 
        ' dgvDanhSS
        ' 
        dgvDanhSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDanhSS.Location = New Point(48, 305)
        dgvDanhSS.Name = "dgvDanhSS"
        dgvDanhSS.Size = New Size(658, 161)
        dgvDanhSS.TabIndex = 22
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.BackColor = Color.Transparent
        label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(256, 9)
        label1.Name = "label1"
        label1.Size = New Size(253, 45)
        label1.TabIndex = 21
        label1.Text = "QUẢN LÝ SÁCH"
        ' 
        ' groupBox2
        ' 
        groupBox2.Controls.Add(txtTimKiemSach)
        groupBox2.Controls.Add(lblTimkiem)
        groupBox2.Controls.Add(btnTimKiem)
        groupBox2.Location = New Point(140, 245)
        groupBox2.Name = "groupBox2"
        groupBox2.Size = New Size(488, 54)
        groupBox2.TabIndex = 20
        groupBox2.TabStop = False
        groupBox2.Text = "Tìm kiếm"
        ' 
        ' txtTimKiemSach
        ' 
        txtTimKiemSach.Location = New Point(142, 16)
        txtTimKiemSach.Name = "txtTimKiemSach"
        txtTimKiemSach.Size = New Size(220, 23)
        txtTimKiemSach.TabIndex = 15
        ' 
        ' lblTimkiem
        ' 
        lblTimkiem.AutoSize = True
        lblTimkiem.BackColor = SystemColors.ControlDark
        lblTimkiem.BorderStyle = BorderStyle.FixedSingle
        lblTimkiem.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblTimkiem.Location = New Point(16, 19)
        lblTimkiem.Name = "lblTimkiem"
        lblTimkiem.Size = New Size(76, 22)
        lblTimkiem.TabIndex = 9
        lblTimkiem.Text = "Tìm kiếm"
        ' 
        ' btnTimKiem
        ' 
        btnTimKiem.Location = New Point(387, 16)
        btnTimKiem.Name = "btnTimKiem"
        btnTimKiem.Size = New Size(75, 23)
        btnTimKiem.TabIndex = 4
        btnTimKiem.Text = "Tìm kiếm"
        btnTimKiem.UseVisualStyleBackColor = True
        ' 
        ' groupBox1
        ' 
        groupBox1.Controls.Add(txtNamXB)
        groupBox1.Controls.Add(txtSoLuong)
        groupBox1.Controls.Add(txtTheLoai)
        groupBox1.Controls.Add(txtTacGia)
        groupBox1.Controls.Add(txtTenSach)
        groupBox1.Controls.Add(txtMaSach)
        groupBox1.Controls.Add(lblNamXB)
        groupBox1.Controls.Add(lblTacGia)
        groupBox1.Controls.Add(lblTenSach)
        groupBox1.Controls.Add(lblSoLuong)
        groupBox1.Controls.Add(lblMaSach)
        groupBox1.Controls.Add(lblTheLoai)
        groupBox1.Location = New Point(48, 67)
        groupBox1.Name = "groupBox1"
        groupBox1.Size = New Size(658, 172)
        groupBox1.TabIndex = 19
        groupBox1.TabStop = False
        groupBox1.Text = "Thông tin sách"
        ' 
        ' txtNamXB
        ' 
        txtNamXB.Location = New Point(443, 125)
        txtNamXB.Name = "txtNamXB"
        txtNamXB.Size = New Size(163, 23)
        txtNamXB.TabIndex = 14
        ' 
        ' txtSoLuong
        ' 
        txtSoLuong.Location = New Point(443, 79)
        txtSoLuong.Name = "txtSoLuong"
        txtSoLuong.Size = New Size(163, 23)
        txtSoLuong.TabIndex = 13
        ' 
        ' txtTheLoai
        ' 
        txtTheLoai.Location = New Point(443, 34)
        txtTheLoai.Name = "txtTheLoai"
        txtTheLoai.Size = New Size(163, 23)
        txtTheLoai.TabIndex = 12
        ' 
        ' txtTacGia
        ' 
        txtTacGia.Location = New Point(151, 124)
        txtTacGia.Name = "txtTacGia"
        txtTacGia.Size = New Size(163, 23)
        txtTacGia.TabIndex = 11
        ' 
        ' txtTenSach
        ' 
        txtTenSach.Location = New Point(151, 79)
        txtTenSach.Name = "txtTenSach"
        txtTenSach.Size = New Size(163, 23)
        txtTenSach.TabIndex = 10
        ' 
        ' txtMaSach
        ' 
        txtMaSach.Location = New Point(151, 34)
        txtMaSach.Name = "txtMaSach"
        txtMaSach.Size = New Size(163, 23)
        txtMaSach.TabIndex = 9
        ' 
        ' lblNamXB
        ' 
        lblNamXB.AutoSize = True
        lblNamXB.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblNamXB.Location = New Point(321, 123)
        lblNamXB.Name = "lblNamXB"
        lblNamXB.Size = New Size(116, 20)
        lblNamXB.TabIndex = 8
        lblNamXB.Text = "Năm xuất bản :"
        ' 
        ' lblSoLuong
        ' 
        lblSoLuong.AutoSize = True
        lblSoLuong.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSoLuong.Location = New Point(349, 82)
        lblSoLuong.Name = "lblSoLuong"
        lblSoLuong.Size = New Size(79, 20)
        lblSoLuong.TabIndex = 7
        lblSoLuong.Text = "Số lượng :"
        ' 
        ' lblTheLoai
        ' 
        lblTheLoai.AutoSize = True
        lblTheLoai.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblTheLoai.Location = New Point(349, 37)
        lblTheLoai.Name = "lblTheLoai"
        lblTheLoai.Size = New Size(72, 20)
        lblTheLoai.TabIndex = 6
        lblTheLoai.Text = "Thể loại :"
        ' 
        ' lblTacGia
        ' 
        lblTacGia.AutoSize = True
        lblTacGia.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblTacGia.Location = New Point(47, 128)
        lblTacGia.Name = "lblTacGia"
        lblTacGia.Size = New Size(65, 20)
        lblTacGia.TabIndex = 5
        lblTacGia.Text = "Tác giả :"
        ' 
        ' lblTenSach
        ' 
        lblTenSach.AutoSize = True
        lblTenSach.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblTenSach.Location = New Point(47, 82)
        lblTenSach.Name = "lblTenSach"
        lblTenSach.Size = New Size(77, 20)
        lblTenSach.TabIndex = 4
        lblTenSach.Text = "Tên sách :"
        ' 
        ' lblMaSach
        ' 
        lblMaSach.AutoSize = True
        lblMaSach.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMaSach.Location = New Point(47, 37)
        lblMaSach.Name = "lblMaSach"
        lblMaSach.Size = New Size(74, 20)
        lblMaSach.TabIndex = 3
        lblMaSach.Text = "Mã sách :"
        ' 
        ' QuanLySach
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(850, 504)
        Controls.Add(btnSuaSach)
        Controls.Add(btnXoaSach)
        Controls.Add(btnThemSach)
        Controls.Add(dgvDanhSS)
        Controls.Add(label1)
        Controls.Add(groupBox2)
        Controls.Add(groupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "QuanLySach"
        Text = "Quản ly sách"
        CType(dgvDanhSS, ComponentModel.ISupportInitialize).EndInit()
        groupBox2.ResumeLayout(False)
        groupBox2.PerformLayout()
        groupBox1.ResumeLayout(False)
        groupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents btnSuaSach As Button
    Private WithEvents btnXoaSach As Button
    Private WithEvents btnThemSach As Button
    Private WithEvents dgvDanhSS As DataGridView
    Private WithEvents label1 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtTimKiemSach As TextBox
    Private WithEvents lblTimkiem As Label
    Private WithEvents btnTimKiem As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtNamXB As TextBox
    Private WithEvents txtSoLuong As TextBox
    Private WithEvents txtTheLoai As TextBox
    Private WithEvents txtTacGia As TextBox
    Private WithEvents txtTenSach As TextBox
    Private WithEvents txtMaSach As TextBox
    Private WithEvents lblNamXB As Label
    Private WithEvents lblSoLuong As Label
    Private WithEvents lblTheLoai As Label
    Private WithEvents lblTacGia As Label
    Private WithEvents lblTenSach As Label
    Private WithEvents lblMaSach As Label
End Class
