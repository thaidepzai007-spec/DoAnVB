<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocGia))
        btnXoaDG = New Button()
        btnSuaDG = New Button()
        btnThemDG = New Button()
        dgvDocGia = New DataGridView()
        txtSDT = New TextBox()
        txtDiaChi = New TextBox()
        txtTenDG = New TextBox()
        txtMaDG = New TextBox()
        lblSDT = New Label()
        lblDiaChi = New Label()
        lblTenDG = New Label()
        lblMaDG = New Label()
        label1 = New Label()
        CType(dgvDocGia, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnXoaDG
        ' 
        btnXoaDG.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnXoaDG.Location = New Point(508, 382)
        btnXoaDG.Name = "btnXoaDG"
        btnXoaDG.Size = New Size(75, 23)
        btnXoaDG.TabIndex = 72
        btnXoaDG.Text = "Xóa"
        btnXoaDG.UseVisualStyleBackColor = False
        ' 
        ' btnSuaDG
        ' 
        btnSuaDG.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnSuaDG.Location = New Point(508, 301)
        btnSuaDG.Name = "btnSuaDG"
        btnSuaDG.Size = New Size(75, 23)
        btnSuaDG.TabIndex = 71
        btnSuaDG.Text = "Sửa"
        btnSuaDG.UseVisualStyleBackColor = False
        ' 
        ' btnThemDG
        ' 
        btnThemDG.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnThemDG.Location = New Point(508, 222)
        btnThemDG.Name = "btnThemDG"
        btnThemDG.Size = New Size(75, 23)
        btnThemDG.TabIndex = 70
        btnThemDG.Text = "Thêm"
        btnThemDG.UseVisualStyleBackColor = False
        ' 
        ' dgvDocGia
        ' 
        dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDocGia.Location = New Point(33, 193)
        dgvDocGia.Name = "dgvDocGia"
        dgvDocGia.RowHeadersWidth = 51
        dgvDocGia.Size = New Size(460, 254)
        dgvDocGia.TabIndex = 69
        ' 
        ' txtSDT
        ' 
        txtSDT.Location = New Point(438, 145)
        txtSDT.Name = "txtSDT"
        txtSDT.Size = New Size(145, 23)
        txtSDT.TabIndex = 68
        ' 
        ' txtDiaChi
        ' 
        txtDiaChi.Location = New Point(438, 93)
        txtDiaChi.Name = "txtDiaChi"
        txtDiaChi.Size = New Size(145, 23)
        txtDiaChi.TabIndex = 67
        ' 
        ' txtTenDG
        ' 
        txtTenDG.Location = New Point(147, 145)
        txtTenDG.Name = "txtTenDG"
        txtTenDG.Size = New Size(145, 23)
        txtTenDG.TabIndex = 66
        ' 
        ' txtMaDG
        ' 
        txtMaDG.Location = New Point(147, 93)
        txtMaDG.Name = "txtMaDG"
        txtMaDG.Size = New Size(145, 23)
        txtMaDG.TabIndex = 65
        ' 
        ' lblSDT
        ' 
        lblSDT.AutoSize = True
        lblSDT.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSDT.Location = New Point(317, 148)
        lblSDT.Name = "lblSDT"
        lblSDT.Size = New Size(108, 20)
        lblSDT.TabIndex = 64
        lblSDT.Text = "Số điện thoại :"
        ' 
        ' lblDiaChi
        ' 
        lblDiaChi.AutoSize = True
        lblDiaChi.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblDiaChi.Location = New Point(317, 96)
        lblDiaChi.Name = "lblDiaChi"
        lblDiaChi.Size = New Size(64, 20)
        lblDiaChi.TabIndex = 63
        lblDiaChi.Text = "Địa chỉ :"
        ' 
        ' lblTenDG
        ' 
        lblTenDG.AutoSize = True
        lblTenDG.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblTenDG.Location = New Point(33, 148)
        lblTenDG.Name = "lblTenDG"
        lblTenDG.Size = New Size(96, 20)
        lblTenDG.TabIndex = 62
        lblTenDG.Text = "Tên độc giả :"
        ' 
        ' lblMaDG
        ' 
        lblMaDG.AutoSize = True
        lblMaDG.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMaDG.Location = New Point(33, 96)
        lblMaDG.Name = "lblMaDG"
        lblMaDG.Size = New Size(93, 20)
        lblMaDG.TabIndex = 61
        lblMaDG.Text = "Mã độc giả :"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = SystemColors.ControlText
        label1.Location = New Point(216, 10)
        label1.Name = "label1"
        label1.Size = New Size(156, 45)
        label1.TabIndex = 60
        label1.Text = "ĐỘC GIẢ"
        ' 
        ' DocGia
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(615, 482)
        Controls.Add(btnXoaDG)
        Controls.Add(btnSuaDG)
        Controls.Add(btnThemDG)
        Controls.Add(dgvDocGia)
        Controls.Add(txtSDT)
        Controls.Add(txtDiaChi)
        Controls.Add(txtTenDG)
        Controls.Add(txtMaDG)
        Controls.Add(lblSDT)
        Controls.Add(lblDiaChi)
        Controls.Add(lblTenDG)
        Controls.Add(lblMaDG)
        Controls.Add(label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "DocGia"
        Text = "Độc Giả"
        CType(dgvDocGia, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents btnXoaDG As Button
    Private WithEvents btnSuaDG As Button
    Private WithEvents btnThemDG As Button
    Private WithEvents dgvDocGia As DataGridView
    Private WithEvents txtSDT As TextBox
    Private WithEvents txtDiaChi As TextBox
    Private WithEvents txtTenDG As TextBox
    Private WithEvents txtMaDG As TextBox
    Private WithEvents lblSDT As Label
    Private WithEvents lblDiaChi As Label
    Private WithEvents lblTenDG As Label
    Private WithEvents lblMaDG As Label
    Private WithEvents label1 As Label
End Class
