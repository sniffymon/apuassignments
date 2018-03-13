<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMenuForm))
        Me.btnAdminInfoPanel = New System.Windows.Forms.Button()
        Me.btnEditChaletRecords = New System.Windows.Forms.Button()
        Me.btnRegisterGuest = New System.Windows.Forms.Button()
        Me.btnEditGuestRecords = New System.Windows.Forms.Button()
        Me.pnlMainView = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.indSelectedTab = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tlpMenuBtn = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlMenu.SuspendLayout()
        CType(Me.indSelectedTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMenuBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdminInfoPanel
        '
        Me.btnAdminInfoPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnAdminInfoPanel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdminInfoPanel.FlatAppearance.BorderSize = 0
        Me.btnAdminInfoPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminInfoPanel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminInfoPanel.ForeColor = System.Drawing.Color.White
        Me.btnAdminInfoPanel.Location = New System.Drawing.Point(2, 269)
        Me.btnAdminInfoPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdminInfoPanel.Name = "btnAdminInfoPanel"
        Me.btnAdminInfoPanel.Size = New System.Drawing.Size(145, 85)
        Me.btnAdminInfoPanel.TabIndex = 0
        Me.btnAdminInfoPanel.Text = "Admin Info Panel"
        Me.btnAdminInfoPanel.UseVisualStyleBackColor = False
        '
        'btnEditChaletRecords
        '
        Me.btnEditChaletRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEditChaletRecords.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditChaletRecords.FlatAppearance.BorderSize = 0
        Me.btnEditChaletRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditChaletRecords.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditChaletRecords.ForeColor = System.Drawing.Color.White
        Me.btnEditChaletRecords.Location = New System.Drawing.Point(2, 180)
        Me.btnEditChaletRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditChaletRecords.Name = "btnEditChaletRecords"
        Me.btnEditChaletRecords.Size = New System.Drawing.Size(145, 85)
        Me.btnEditChaletRecords.TabIndex = 1
        Me.btnEditChaletRecords.Text = "Edit Chalet Records"
        Me.btnEditChaletRecords.UseVisualStyleBackColor = False
        '
        'btnRegisterGuest
        '
        Me.btnRegisterGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnRegisterGuest.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRegisterGuest.FlatAppearance.BorderSize = 0
        Me.btnRegisterGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterGuest.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterGuest.ForeColor = System.Drawing.Color.White
        Me.btnRegisterGuest.Location = New System.Drawing.Point(2, 2)
        Me.btnRegisterGuest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegisterGuest.Name = "btnRegisterGuest"
        Me.btnRegisterGuest.Size = New System.Drawing.Size(145, 85)
        Me.btnRegisterGuest.TabIndex = 2
        Me.btnRegisterGuest.Text = "Register Guest"
        Me.btnRegisterGuest.UseVisualStyleBackColor = False
        '
        'btnEditGuestRecords
        '
        Me.btnEditGuestRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnEditGuestRecords.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditGuestRecords.FlatAppearance.BorderSize = 0
        Me.btnEditGuestRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditGuestRecords.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditGuestRecords.ForeColor = System.Drawing.Color.White
        Me.btnEditGuestRecords.Location = New System.Drawing.Point(2, 91)
        Me.btnEditGuestRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditGuestRecords.Name = "btnEditGuestRecords"
        Me.btnEditGuestRecords.Size = New System.Drawing.Size(145, 85)
        Me.btnEditGuestRecords.TabIndex = 3
        Me.btnEditGuestRecords.Text = "Edit Guest Records"
        Me.btnEditGuestRecords.UseVisualStyleBackColor = False
        '
        'pnlMainView
        '
        Me.pnlMainView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMainView.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMainView.BackgroundImage = CType(resources.GetObject("pnlMainView.BackgroundImage"), System.Drawing.Image)
        Me.pnlMainView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlMainView.Location = New System.Drawing.Point(153, 0)
        Me.pnlMainView.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlMainView.Name = "pnlMainView"
        Me.pnlMainView.Size = New System.Drawing.Size(795, 484)
        Me.pnlMainView.TabIndex = 4
        '
        'pnlMenu
        '
        Me.pnlMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenu.Controls.Add(Me.indSelectedTab)
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Controls.Add(Me.PictureBox1)
        Me.pnlMenu.Controls.Add(Me.tlpMenuBtn)
        Me.pnlMenu.Location = New System.Drawing.Point(2, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(152, 489)
        Me.pnlMenu.TabIndex = 5
        '
        'indSelectedTab
        '
        Me.indSelectedTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.indSelectedTab.Location = New System.Drawing.Point(142, 384)
        Me.indSelectedTab.Name = "indSelectedTab"
        Me.indSelectedTab.Size = New System.Drawing.Size(10, 87)
        Me.indSelectedTab.TabIndex = 0
        Me.indSelectedTab.TabStop = False
        Me.indSelectedTab.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(28, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-8, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'tlpMenuBtn
        '
        Me.tlpMenuBtn.ColumnCount = 1
        Me.tlpMenuBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenuBtn.Controls.Add(Me.btnAdminInfoPanel, 0, 3)
        Me.tlpMenuBtn.Controls.Add(Me.btnEditGuestRecords, 0, 1)
        Me.tlpMenuBtn.Controls.Add(Me.btnEditChaletRecords, 0, 2)
        Me.tlpMenuBtn.Controls.Add(Me.btnRegisterGuest, 0, 0)
        Me.tlpMenuBtn.Location = New System.Drawing.Point(0, 114)
        Me.tlpMenuBtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tlpMenuBtn.Name = "tlpMenuBtn"
        Me.tlpMenuBtn.RowCount = 4
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpMenuBtn.Size = New System.Drawing.Size(149, 356)
        Me.tlpMenuBtn.TabIndex = 4
        '
        'AdminMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 474)
        Me.Controls.Add(Me.pnlMainView)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "AdminMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminMenuForm"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.indSelectedTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMenuBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdminInfoPanel As Button
    Friend WithEvents btnEditChaletRecords As Button
    Friend WithEvents btnRegisterGuest As Button
    Friend WithEvents btnEditGuestRecords As Button
    Friend WithEvents pnlMainView As Panel
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents tlpMenuBtn As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents indSelectedTab As PictureBox
End Class
