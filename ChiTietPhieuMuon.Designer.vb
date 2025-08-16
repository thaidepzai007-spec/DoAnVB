<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChiTietPhieuMuon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChiTietPhieuMuon))
        btnXoaCTPM = New Button()
        btnSuaCTPM = New Button()
        btnThemCTPM = New Button()
        dgvCTPM = New DataGridView()
        txtSoLuongMuon = New TextBox()
        txtMaNV = New TextBox()
        txtMaSach = New TextBox()
        txtMaPM = New TextBox()
        lblSLMuon = New Label()
        lblMaSV = New Label()
        lblMaSach = New Label()
        lblMaPM = New Label()
        label1 = New Label()
        CType(dgvCTPM, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnXoaCTPM
        ' 
        btnXoaCTPM.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnXoaCTPM.Location = New Point(552, 427)
        btnXoaCTPM.Name = "btnXoaCTPM"
        btnXoaCTPM.Size = New Size(75, 23)
        btnXoaCTPM.TabIndex = 61
        btnXoaCTPM.Text = "Xóa"
        btnXoaCTPM.UseVisualStyleBackColor = False
        ' 
        ' btnSuaCTPM
        ' 
        btnSuaCTPM.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnSuaCTPM.Location = New Point(552, 335)
        btnSuaCTPM.Name = "btnSuaCTPM"
        btnSuaCTPM.Size = New Size(75, 23)
        btnSuaCTPM.TabIndex = 60
        btnSuaCTPM.Text = "Sửa"
        btnSuaCTPM.UseVisualStyleBackColor = False
        ' 
        ' btnThemCTPM
        ' 
        btnThemCTPM.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnThemCTPM.Location = New Point(552, 249)
        btnThemCTPM.Name = "btnThemCTPM"
        btnThemCTPM.Size = New Size(75, 23)
        btnThemCTPM.TabIndex = 59
        btnThemCTPM.Text = "Thêm"
        btnThemCTPM.UseVisualStyleBackColor = False
        ' 
        ' dgvCTPM
        ' 
        dgvCTPM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCTPM.Location = New Point(62, 231)
        dgvCTPM.Name = "dgvCTPM"
        dgvCTPM.RowHeadersWidth = 51
        dgvCTPM.Size = New Size(451, 262)
        dgvCTPM.TabIndex = 58
        ' 
        ' txtSoLuongMuon
        ' 
        txtSoLuongMuon.Location = New Point(509, 173)
        txtSoLuongMuon.Name = "txtSoLuongMuon"
        txtSoLuongMuon.Size = New Size(141, 23)
        txtSoLuongMuon.TabIndex = 57
        ' 
        ' txtMaNV
        ' 
        txtMaNV.Location = New Point(509, 115)
        txtMaNV.Name = "txtMaNV"
        txtMaNV.Size = New Size(141, 23)
        txtMaNV.TabIndex = 56
        ' 
        ' txtMaSach
        ' 
        txtMaSach.Location = New Point(176, 173)
        txtMaSach.Name = "txtMaSach"
        txtMaSach.Size = New Size(141, 23)
        txtMaSach.TabIndex = 55
        ' 
        ' txtMaPM
        ' 
        txtMaPM.Location = New Point(176, 115)
        txtMaPM.Name = "txtMaPM"
        txtMaPM.Size = New Size(141, 23)
        txtMaPM.TabIndex = 54
        ' 
        ' lblSLMuon
        ' 
        lblSLMuon.AutoSize = True
        lblSLMuon.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSLMuon.Location = New Point(368, 176)
        lblSLMuon.Name = "lblSLMuon"
        lblSLMuon.Size = New Size(125, 20)
        lblSLMuon.TabIndex = 53
        lblSLMuon.Text = "Số lượng mượn :"
        ' 
        ' lblMaSV
        ' 
        lblMaSV.AutoSize = True
        lblMaSV.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMaSV.Location = New Point(368, 118)
        lblMaSV.Name = "lblMaSV"
        lblMaSV.Size = New Size(111, 20)
        lblMaSV.TabIndex = 52
        lblMaSV.Text = "Mã nhân viên :"
        ' 
        ' lblMaSach
        ' 
        lblMaSach.AutoSize = True
        lblMaSach.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMaSach.Location = New Point(72, 176)
        lblMaSach.Name = "lblMaSach"
        lblMaSach.Size = New Size(74, 20)
        lblMaSach.TabIndex = 51
        lblMaSach.Text = "Mã sách :"
        ' 
        ' lblMaPM
        ' 
        lblMaPM.AutoSize = True
        lblMaPM.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMaPM.Location = New Point(35, 118)
        lblMaPM.Name = "lblMaPM"
        lblMaPM.Size = New Size(128, 20)
        lblMaPM.TabIndex = 50
        lblMaPM.Text = "Mã phiếu mượn :"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = SystemColors.ControlText
        label1.Location = New Point(206, 22)
        label1.Name = "label1"
        label1.Size = New Size(385, 45)
        label1.TabIndex = 49
        label1.Text = "CHI TIẾT PHIẾU MƯỢN"
        ' 
        ' ChiTietPhieuMuon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(684, 550)
        Controls.Add(btnXoaCTPM)
        Controls.Add(btnSuaCTPM)
        Controls.Add(btnThemCTPM)
        Controls.Add(dgvCTPM)
        Controls.Add(txtSoLuongMuon)
        Controls.Add(txtMaNV)
        Controls.Add(txtMaSach)
        Controls.Add(txtMaPM)
        Controls.Add(lblSLMuon)
        Controls.Add(lblMaSV)
        Controls.Add(lblMaSach)
        Controls.Add(lblMaPM)
        Controls.Add(label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ChiTietPhieuMuon"
        Text = "Chi tiết phiếu mượn"
        CType(dgvCTPM, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents btnXoaCTPM As Button
    Private WithEvents btnSuaCTPM As Button
    Private WithEvents btnThemCTPM As Button
    Private WithEvents dgvCTPM As DataGridView
    Private WithEvents txtSoLuongMuon As TextBox
    Private WithEvents txtMaNV As TextBox
    Private WithEvents txtMaSach As TextBox
    Private WithEvents txtMaPM As TextBox
    Private WithEvents lblSLMuon As Label
    Private WithEvents lblMaSV As Label
    Private WithEvents lblMaSach As Label
    Private WithEvents lblMaPM As Label
    Private WithEvents label1 As Label
End Class
