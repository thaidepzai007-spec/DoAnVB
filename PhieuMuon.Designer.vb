<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhieuMuon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhieuMuon))
        txtMaNV = New TextBox()
        lblMaNV = New Label()
        btnXoaPM = New Button()
        btnSuaPM = New Button()
        btnThemPM = New Button()
        dgvPhieuMuon = New DataGridView()
        txtNgayTra = New TextBox()
        txtNgayMuon = New TextBox()
        txtMaDG2 = New TextBox()
        txtMaPM = New TextBox()
        lblNgayTra = New Label()
        lblNgayMuon = New Label()
        lblTenDG2 = New Label()
        lblMaPM = New Label()
        label1 = New Label()
        CType(dgvPhieuMuon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtMaNV
        ' 
        txtMaNV.Location = New Point(545, 93)
        txtMaNV.Name = "txtMaNV"
        txtMaNV.Size = New Size(192, 23)
        txtMaNV.TabIndex = 67
        ' 
        ' lblMaNV
        ' 
        lblMaNV.AutoSize = True
        lblMaNV.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMaNV.Location = New Point(410, 96)
        lblMaNV.Name = "lblMaNV"
        lblMaNV.Size = New Size(111, 20)
        lblMaNV.TabIndex = 66
        lblMaNV.Text = "Mã nhân viên :"
        ' 
        ' btnXoaPM
        ' 
        btnXoaPM.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnXoaPM.Location = New Point(662, 379)
        btnXoaPM.Name = "btnXoaPM"
        btnXoaPM.Size = New Size(75, 23)
        btnXoaPM.TabIndex = 63
        btnXoaPM.Text = "Xóa"
        btnXoaPM.UseVisualStyleBackColor = False
        ' 
        ' btnSuaPM
        ' 
        btnSuaPM.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnSuaPM.Location = New Point(662, 302)
        btnSuaPM.Name = "btnSuaPM"
        btnSuaPM.Size = New Size(75, 23)
        btnSuaPM.TabIndex = 62
        btnSuaPM.Text = "Sửa"
        btnSuaPM.UseVisualStyleBackColor = False
        ' 
        ' btnThemPM
        ' 
        btnThemPM.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnThemPM.Location = New Point(662, 225)
        btnThemPM.Name = "btnThemPM"
        btnThemPM.Size = New Size(75, 23)
        btnThemPM.TabIndex = 61
        btnThemPM.Text = "Thêm"
        btnThemPM.UseVisualStyleBackColor = False
        ' 
        ' dgvPhieuMuon
        ' 
        dgvPhieuMuon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPhieuMuon.Location = New Point(60, 180)
        dgvPhieuMuon.Name = "dgvPhieuMuon"
        dgvPhieuMuon.RowHeadersWidth = 51
        dgvPhieuMuon.Size = New Size(556, 253)
        dgvPhieuMuon.TabIndex = 60
        ' 
        ' txtNgayTra
        ' 
        txtNgayTra.Location = New Point(545, 55)
        txtNgayTra.Name = "txtNgayTra"
        txtNgayTra.Size = New Size(192, 23)
        txtNgayTra.TabIndex = 59
        ' 
        ' txtNgayMuon
        ' 
        txtNgayMuon.Location = New Point(165, 138)
        txtNgayMuon.Name = "txtNgayMuon"
        txtNgayMuon.Size = New Size(192, 23)
        txtNgayMuon.TabIndex = 58
        ' 
        ' txtMaDG2
        ' 
        txtMaDG2.Location = New Point(168, 96)
        txtMaDG2.Name = "txtMaDG2"
        txtMaDG2.Size = New Size(192, 23)
        txtMaDG2.TabIndex = 57
        ' 
        ' txtMaPM
        ' 
        txtMaPM.Location = New Point(168, 55)
        txtMaPM.Name = "txtMaPM"
        txtMaPM.Size = New Size(189, 23)
        txtMaPM.TabIndex = 56
        ' 
        ' lblNgayTra
        ' 
        lblNgayTra.AutoSize = True
        lblNgayTra.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblNgayTra.Location = New Point(443, 58)
        lblNgayTra.Name = "lblNgayTra"
        lblNgayTra.Size = New Size(78, 20)
        lblNgayTra.TabIndex = 55
        lblNgayTra.Text = "Ngày trả :"
        ' 
        ' lblNgayMuon
        ' 
        lblNgayMuon.AutoSize = True
        lblNgayMuon.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblNgayMuon.Location = New Point(60, 141)
        lblNgayMuon.Name = "lblNgayMuon"
        lblNgayMuon.Size = New Size(100, 20)
        lblNgayMuon.TabIndex = 54
        lblNgayMuon.Text = "Ngày mượn :"
        ' 
        ' lblTenDG2
        ' 
        lblTenDG2.AutoSize = True
        lblTenDG2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblTenDG2.Location = New Point(71, 99)
        lblTenDG2.Name = "lblTenDG2"
        lblTenDG2.Size = New Size(89, 20)
        lblTenDG2.TabIndex = 53
        lblTenDG2.Text = "Mã độc giả:"
        ' 
        ' lblMaPM
        ' 
        lblMaPM.AutoSize = True
        lblMaPM.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMaPM.Location = New Point(32, 58)
        lblMaPM.Name = "lblMaPM"
        lblMaPM.Size = New Size(128, 20)
        lblMaPM.TabIndex = 52
        lblMaPM.Text = "Mã phiếu mượn :"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = SystemColors.ControlText
        label1.Location = New Point(261, 7)
        label1.Name = "label1"
        label1.Size = New Size(241, 45)
        label1.TabIndex = 51
        label1.Text = "PHIẾU MƯỢN"
        ' 
        ' PhieuMuon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(792, 471)
        Controls.Add(txtMaNV)
        Controls.Add(lblMaNV)
        Controls.Add(btnXoaPM)
        Controls.Add(btnSuaPM)
        Controls.Add(btnThemPM)
        Controls.Add(dgvPhieuMuon)
        Controls.Add(txtNgayTra)
        Controls.Add(txtNgayMuon)
        Controls.Add(txtMaDG2)
        Controls.Add(txtMaPM)
        Controls.Add(lblNgayTra)
        Controls.Add(lblNgayMuon)
        Controls.Add(lblTenDG2)
        Controls.Add(lblMaPM)
        Controls.Add(label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "PhieuMuon"
        Text = "Phiếu Mượn"
        CType(dgvPhieuMuon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents txtMaNV As TextBox
    Private WithEvents lblMaNV As Label
    Private WithEvents btnXoaPM As Button
    Private WithEvents btnSuaPM As Button
    Private WithEvents btnThemPM As Button
    Private WithEvents dgvPhieuMuon As DataGridView
    Private WithEvents txtNgayTra As TextBox
    Private WithEvents txtNgayMuon As TextBox
    Private WithEvents txtMaDG2 As TextBox
    Private WithEvents txtMaPM As TextBox
    Private WithEvents lblNgayTra As Label
    Private WithEvents lblNgayMuon As Label
    Private WithEvents lblTenDG2 As Label
    Private WithEvents lblMaPM As Label
    Private WithEvents label1 As Label
End Class
