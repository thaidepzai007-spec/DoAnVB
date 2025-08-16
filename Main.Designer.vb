<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        menuStrip1 = New MenuStrip()
        hệThốngToolStripMenuItem = New ToolStripMenuItem()
        đăngXuấtToolStripMenuItem = New ToolStripMenuItem()
        thoátToolStripMenuItem = New ToolStripMenuItem()
        danhMụcToolStripMenuItem1 = New ToolStripMenuItem()
        quảnLíSáchToolStripMenuItem1 = New ToolStripMenuItem()
        độcGiảToolStripMenuItem1 = New ToolStripMenuItem()
        nhânViênToolStripMenuItem = New ToolStripMenuItem()
        phiếuMượnToolStripMenuItem = New ToolStripMenuItem()
        chiTiếtPhiếuMượnToolStripMenuItem = New ToolStripMenuItem()
        trợGiúpToolStripMenuItem = New ToolStripMenuItem()
        LiênHệToolStripMenuItem = New ToolStripMenuItem()
        menuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' menuStrip1
        ' 
        menuStrip1.BackColor = SystemColors.InactiveCaption
        menuStrip1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        menuStrip1.ImageScalingSize = New Size(20, 20)
        menuStrip1.Items.AddRange(New ToolStripItem() {hệThốngToolStripMenuItem, danhMụcToolStripMenuItem1, trợGiúpToolStripMenuItem})
        menuStrip1.Location = New Point(0, 0)
        menuStrip1.Name = "menuStrip1"
        menuStrip1.Size = New Size(821, 33)
        menuStrip1.TabIndex = 3
        menuStrip1.Text = "menuStrip1"
        ' 
        ' hệThốngToolStripMenuItem
        ' 
        hệThốngToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {đăngXuấtToolStripMenuItem, thoátToolStripMenuItem})
        hệThốngToolStripMenuItem.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(163))
        hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem"
        hệThốngToolStripMenuItem.Size = New Size(113, 29)
        hệThốngToolStripMenuItem.Text = "Hệ  thống"
        ' 
        ' đăngXuấtToolStripMenuItem
        ' 
        đăngXuấtToolStripMenuItem.Image = My.Resources.Resources.Screenshot_2025_05_31_084314
        đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem"
        đăngXuấtToolStripMenuItem.Size = New Size(184, 30)
        đăngXuấtToolStripMenuItem.Text = "Đăng xuất"
        ' 
        ' thoátToolStripMenuItem
        ' 
        thoátToolStripMenuItem.Image = My.Resources.Resources.Screenshot_2025_05_31_084517
        thoátToolStripMenuItem.Name = "thoátToolStripMenuItem"
        thoátToolStripMenuItem.Size = New Size(184, 30)
        thoátToolStripMenuItem.Text = "Thoát"
        ' 
        ' danhMụcToolStripMenuItem1
        ' 
        danhMụcToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {quảnLíSáchToolStripMenuItem1, độcGiảToolStripMenuItem1, nhânViênToolStripMenuItem, phiếuMượnToolStripMenuItem, chiTiếtPhiếuMượnToolStripMenuItem})
        danhMụcToolStripMenuItem1.Name = "danhMụcToolStripMenuItem1"
        danhMụcToolStripMenuItem1.Size = New Size(114, 29)
        danhMụcToolStripMenuItem1.Text = "Danh mục"
        ' 
        ' quảnLíSáchToolStripMenuItem1
        ' 
        quảnLíSáchToolStripMenuItem1.Image = My.Resources.Resources.Screenshot_2025_05_31_084621
        quảnLíSáchToolStripMenuItem1.Name = "quảnLíSáchToolStripMenuItem1"
        quảnLíSáchToolStripMenuItem1.Size = New Size(264, 30)
        quảnLíSáchToolStripMenuItem1.Text = "Quản lí sách"
        ' 
        ' độcGiảToolStripMenuItem1
        ' 
        độcGiảToolStripMenuItem1.Image = My.Resources.Resources.Screenshot_2025_05_31_084657
        độcGiảToolStripMenuItem1.Name = "độcGiảToolStripMenuItem1"
        độcGiảToolStripMenuItem1.Size = New Size(264, 30)
        độcGiảToolStripMenuItem1.Text = "Độc giả"
        ' 
        ' nhânViênToolStripMenuItem
        ' 
        nhânViênToolStripMenuItem.Image = My.Resources.Resources.Screenshot_2025_05_31_084818
        nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem"
        nhânViênToolStripMenuItem.Size = New Size(264, 30)
        nhânViênToolStripMenuItem.Text = "Nhân viên"
        ' 
        ' phiếuMượnToolStripMenuItem
        ' 
        phiếuMượnToolStripMenuItem.Image = CType(resources.GetObject("phiếuMượnToolStripMenuItem.Image"), Image)
        phiếuMượnToolStripMenuItem.Name = "phiếuMượnToolStripMenuItem"
        phiếuMượnToolStripMenuItem.Size = New Size(264, 30)
        phiếuMượnToolStripMenuItem.Text = "Phiếu mượn"
        ' 
        ' chiTiếtPhiếuMượnToolStripMenuItem
        ' 
        chiTiếtPhiếuMượnToolStripMenuItem.Image = My.Resources.Resources.Screenshot_2025_05_31_085127
        chiTiếtPhiếuMượnToolStripMenuItem.Name = "chiTiếtPhiếuMượnToolStripMenuItem"
        chiTiếtPhiếuMượnToolStripMenuItem.Size = New Size(264, 30)
        chiTiếtPhiếuMượnToolStripMenuItem.Text = "Chi tiết phiếu mượn"
        ' 
        ' trợGiúpToolStripMenuItem
        ' 
        trợGiúpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LiênHệToolStripMenuItem})
        trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem"
        trợGiúpToolStripMenuItem.Size = New Size(100, 29)
        trợGiúpToolStripMenuItem.Text = "Trợ giúp"
        ' 
        ' LiênHệToolStripMenuItem
        ' 
        LiênHệToolStripMenuItem.Image = My.Resources.Resources.Screenshot_2025_05_31_085308
        LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        LiênHệToolStripMenuItem.Size = New Size(184, 30)
        LiênHệToolStripMenuItem.Text = "Liên hệ "
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2025_08_16_2130301
        ClientSize = New Size(821, 452)
        Controls.Add(menuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Main"
        Text = "Main"
        menuStrip1.ResumeLayout(False)
        menuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents hệThốngToolStripMenuItem As ToolStripMenuItem
    Private WithEvents đăngXuấtToolStripMenuItem As ToolStripMenuItem
    Private WithEvents thoátToolStripMenuItem As ToolStripMenuItem
    Private WithEvents danhMụcToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents quảnLíSáchToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents độcGiảToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents nhânViênToolStripMenuItem As ToolStripMenuItem
    Private WithEvents phiếuMượnToolStripMenuItem As ToolStripMenuItem
    Private WithEvents chiTiếtPhiếuMượnToolStripMenuItem As ToolStripMenuItem
    Private WithEvents trợGiúpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As ToolStripMenuItem
End Class
