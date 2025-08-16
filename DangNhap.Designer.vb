<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DangNhap))
        btnThoat = New Button()
        btnDangNhap = New Button()
        txtMatKhau = New TextBox()
        txtTaiKhoan = New TextBox()
        lblMatKhau = New Label()
        lblTaiKhoan = New Label()
        lblDangNhap = New Label()
        SuspendLayout()
        ' 
        ' btnThoat
        ' 
        btnThoat.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnThoat.Location = New Point(157, 168)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(75, 23)
        btnThoat.TabIndex = 13
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = False
        ' 
        ' btnDangNhap
        ' 
        btnDangNhap.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnDangNhap.Location = New Point(29, 168)
        btnDangNhap.Name = "btnDangNhap"
        btnDangNhap.Size = New Size(75, 23)
        btnDangNhap.TabIndex = 12
        btnDangNhap.Text = "Đăng nhập"
        btnDangNhap.UseVisualStyleBackColor = False
        ' 
        ' txtMatKhau
        ' 
        txtMatKhau.Location = New Point(112, 127)
        txtMatKhau.Name = "txtMatKhau"
        txtMatKhau.PasswordChar = "●"c
        txtMatKhau.Size = New Size(120, 23)
        txtMatKhau.TabIndex = 11
        txtMatKhau.UseSystemPasswordChar = True
        ' 
        ' txtTaiKhoan
        ' 
        txtTaiKhoan.Location = New Point(112, 71)
        txtTaiKhoan.Name = "txtTaiKhoan"
        txtTaiKhoan.Size = New Size(120, 23)
        txtTaiKhoan.TabIndex = 10
        ' 
        ' lblMatKhau
        ' 
        lblMatKhau.AutoSize = True
        lblMatKhau.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblMatKhau.Location = New Point(12, 125)
        lblMatKhau.Name = "lblMatKhau"
        lblMatKhau.Size = New Size(90, 21)
        lblMatKhau.TabIndex = 9
        lblMatKhau.Text = "Mật khẩu :"
        ' 
        ' lblTaiKhoan
        ' 
        lblTaiKhoan.AutoSize = True
        lblTaiKhoan.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTaiKhoan.Location = New Point(12, 73)
        lblTaiKhoan.Name = "lblTaiKhoan"
        lblTaiKhoan.Size = New Size(92, 21)
        lblTaiKhoan.TabIndex = 8
        lblTaiKhoan.Text = "Tài khoản :"
        ' 
        ' lblDangNhap
        ' 
        lblDangNhap.AutoSize = True
        lblDangNhap.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDangNhap.Location = New Point(42, 9)
        lblDangNhap.Name = "lblDangNhap"
        lblDangNhap.Size = New Size(181, 37)
        lblDangNhap.TabIndex = 7
        lblDangNhap.Text = "ĐĂNG NHẬP"
        ' 
        ' DangNhap
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(256, 207)
        Controls.Add(btnThoat)
        Controls.Add(btnDangNhap)
        Controls.Add(txtMatKhau)
        Controls.Add(txtTaiKhoan)
        Controls.Add(lblMatKhau)
        Controls.Add(lblTaiKhoan)
        Controls.Add(lblDangNhap)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "DangNhap"
        Text = "Đăng nhập"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents btnThoat As Button
    Private WithEvents btnDangNhap As Button
    Private WithEvents txtMatKhau As TextBox
    Private WithEvents txtTaiKhoan As TextBox
    Private WithEvents lblMatKhau As Label
    Private WithEvents lblTaiKhoan As Label
    Private WithEvents lblDangNhap As Label

End Class
