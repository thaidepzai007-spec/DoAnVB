<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NhanVien))
        txtSDT2 = New TextBox()
        lblSDTNV = New Label()
        btnXoaNV = New Button()
        btnSuaNV = New Button()
        btnThemNV = New Button()
        dgvNhanVien = New DataGridView()
        txtDiaChi = New TextBox()
        txtChucVu = New TextBox()
        txtTenNV = New TextBox()
        txtMaNV = New TextBox()
        lblDiaChi = New Label()
        lblChucVu = New Label()
        lblTenNV = New Label()
        lblMaNV = New Label()
        label1 = New Label()
        CType(dgvNhanVien, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSDT2
        ' 
        txtSDT2.Location = New Point(449, 132)
        txtSDT2.Name = "txtSDT2"
        txtSDT2.Size = New Size(143, 23)
        txtSDT2.TabIndex = 67
        ' 
        ' lblSDTNV
        ' 
        lblSDTNV.AutoSize = True
        lblSDTNV.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSDTNV.Location = New Point(335, 136)
        lblSDTNV.Name = "lblSDTNV"
        lblSDTNV.Size = New Size(108, 20)
        lblSDTNV.TabIndex = 66
        lblSDTNV.Text = "Số điện thoại :"
        ' 
        ' btnXoaNV
        ' 
        btnXoaNV.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnXoaNV.Location = New Point(433, 492)
        btnXoaNV.Name = "btnXoaNV"
        btnXoaNV.Size = New Size(75, 23)
        btnXoaNV.TabIndex = 63
        btnXoaNV.Text = "Xóa"
        btnXoaNV.UseVisualStyleBackColor = False
        ' 
        ' btnSuaNV
        ' 
        btnSuaNV.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnSuaNV.Location = New Point(260, 492)
        btnSuaNV.Name = "btnSuaNV"
        btnSuaNV.Size = New Size(75, 23)
        btnSuaNV.TabIndex = 62
        btnSuaNV.Text = "Sửa"
        btnSuaNV.UseVisualStyleBackColor = False
        ' 
        ' btnThemNV
        ' 
        btnThemNV.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnThemNV.Location = New Point(91, 492)
        btnThemNV.Name = "btnThemNV"
        btnThemNV.Size = New Size(75, 23)
        btnThemNV.TabIndex = 61
        btnThemNV.Text = "Thêm"
        btnThemNV.UseVisualStyleBackColor = False
        ' 
        ' dgvNhanVien
        ' 
        dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNhanVien.Location = New Point(40, 204)
        dgvNhanVien.Name = "dgvNhanVien"
        dgvNhanVien.RowHeadersWidth = 51
        dgvNhanVien.Size = New Size(552, 273)
        dgvNhanVien.TabIndex = 60
        ' 
        ' txtDiaChi
        ' 
        txtDiaChi.Location = New Point(449, 77)
        txtDiaChi.Name = "txtDiaChi"
        txtDiaChi.Size = New Size(143, 23)
        txtDiaChi.TabIndex = 59
        ' 
        ' txtChucVu
        ' 
        txtChucVu.Location = New Point(173, 150)
        txtChucVu.Name = "txtChucVu"
        txtChucVu.Size = New Size(143, 23)
        txtChucVu.TabIndex = 58
        ' 
        ' txtTenNV
        ' 
        txtTenNV.Location = New Point(173, 110)
        txtTenNV.Name = "txtTenNV"
        txtTenNV.Size = New Size(143, 23)
        txtTenNV.TabIndex = 57
        ' 
        ' txtMaNV
        ' 
        txtMaNV.Location = New Point(173, 69)
        txtMaNV.Name = "txtMaNV"
        txtMaNV.Size = New Size(143, 23)
        txtMaNV.TabIndex = 56
        ' 
        ' lblDiaChi
        ' 
        lblDiaChi.AutoSize = True
        lblDiaChi.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblDiaChi.Location = New Point(379, 80)
        lblDiaChi.Name = "lblDiaChi"
        lblDiaChi.Size = New Size(64, 20)
        lblDiaChi.TabIndex = 55
        lblDiaChi.Text = "Địa chỉ :"
        ' 
        ' lblChucVu
        ' 
        lblChucVu.AutoSize = True
        lblChucVu.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblChucVu.Location = New Point(80, 153)
        lblChucVu.Name = "lblChucVu"
        lblChucVu.Size = New Size(73, 20)
        lblChucVu.TabIndex = 54
        lblChucVu.Text = "Chức vụ :"
        ' 
        ' lblTenNV
        ' 
        lblTenNV.AutoSize = True
        lblTenNV.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblTenNV.Location = New Point(39, 113)
        lblTenNV.Name = "lblTenNV"
        lblTenNV.Size = New Size(114, 20)
        lblTenNV.TabIndex = 53
        lblTenNV.Text = "Tên nhân viên :"
        ' 
        ' lblMaNV
        ' 
        lblMaNV.AutoSize = True
        lblMaNV.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMaNV.Location = New Point(42, 69)
        lblMaNV.Name = "lblMaNV"
        lblMaNV.Size = New Size(111, 20)
        lblMaNV.TabIndex = 52
        lblMaNV.Text = "Mã nhân viên :"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = SystemColors.ControlText
        label1.Location = New Point(144, 9)
        label1.Name = "label1"
        label1.Size = New Size(402, 45)
        label1.TabIndex = 51
        label1.Text = "THÔNG TIN NHÂN VIÊN"
        ' 
        ' NhanVien
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(638, 534)
        Controls.Add(txtSDT2)
        Controls.Add(lblSDTNV)
        Controls.Add(btnXoaNV)
        Controls.Add(btnSuaNV)
        Controls.Add(btnThemNV)
        Controls.Add(dgvNhanVien)
        Controls.Add(txtDiaChi)
        Controls.Add(txtChucVu)
        Controls.Add(txtTenNV)
        Controls.Add(txtMaNV)
        Controls.Add(lblDiaChi)
        Controls.Add(lblChucVu)
        Controls.Add(lblTenNV)
        Controls.Add(lblMaNV)
        Controls.Add(label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "NhanVien"
        Text = "Nhân viên"
        CType(dgvNhanVien, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents txtSDT2 As TextBox
    Private WithEvents lblSDTNV As Label
    Private WithEvents btnXoaNV As Button
    Private WithEvents btnSuaNV As Button
    Private WithEvents btnThemNV As Button
    Private WithEvents dgvNhanVien As DataGridView
    Private WithEvents txtDiaChi As TextBox
    Private WithEvents txtChucVu As TextBox
    Private WithEvents txtTenNV As TextBox
    Private WithEvents txtMaNV As TextBox
    Private WithEvents lblDiaChi As Label
    Private WithEvents lblChucVu As Label
    Private WithEvents lblTenNV As Label
    Private WithEvents lblMaNV As Label
    Private WithEvents label1 As Label
End Class
