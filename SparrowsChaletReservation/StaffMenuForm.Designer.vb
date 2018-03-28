<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffMenuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffMenuForm))
        Me.btnExtendBooking = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnRegisterGuest = New System.Windows.Forms.Button()
        Me.btnEditGuestRecords = New System.Windows.Forms.Button()
        Me.pnlMainView = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.indSelectedTab = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tlpMenuBtn = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.pnlMenuStatic = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pnlMenu.SuspendLayout()
        CType(Me.indSelectedTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMenuBtn.SuspendLayout()
        Me.pnlMenuStatic.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExtendBooking
        '
        Me.btnExtendBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnExtendBooking.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExtendBooking.FlatAppearance.BorderSize = 0
        Me.btnExtendBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtendBooking.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtendBooking.ForeColor = System.Drawing.Color.White
        Me.btnExtendBooking.Location = New System.Drawing.Point(2, 306)
        Me.btnExtendBooking.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExtendBooking.Name = "btnExtendBooking"
        Me.btnExtendBooking.Size = New System.Drawing.Size(145, 73)
        Me.btnExtendBooking.TabIndex = 0
        Me.btnExtendBooking.Text = "Extend Booking"
        Me.btnExtendBooking.UseVisualStyleBackColor = False
        '
        'btnCheckIn
        '
        Me.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCheckIn.FlatAppearance.BorderSize = 0
        Me.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckIn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.ForeColor = System.Drawing.Color.White
        Me.btnCheckIn.Location = New System.Drawing.Point(2, 154)
        Me.btnCheckIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(145, 72)
        Me.btnCheckIn.TabIndex = 1
        Me.btnCheckIn.Text = "Check In"
        Me.btnCheckIn.UseVisualStyleBackColor = False
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
        Me.btnRegisterGuest.Size = New System.Drawing.Size(145, 72)
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
        Me.btnEditGuestRecords.Location = New System.Drawing.Point(2, 78)
        Me.btnEditGuestRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditGuestRecords.Name = "btnEditGuestRecords"
        Me.btnEditGuestRecords.Size = New System.Drawing.Size(145, 72)
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
        Me.pnlMainView.Location = New System.Drawing.Point(44, -4)
        Me.pnlMainView.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlMainView.Name = "pnlMainView"
        Me.pnlMainView.Size = New System.Drawing.Size(903, 478)
        Me.pnlMainView.TabIndex = 4
        '
        'pnlMenu
        '
        Me.pnlMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.indSelectedTab)
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Controls.Add(Me.PictureBox1)
        Me.pnlMenu.Controls.Add(Me.tlpMenuBtn)
        Me.pnlMenu.Location = New System.Drawing.Point(-155, 2)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(202, 481)
        Me.pnlMenu.TabIndex = 5
        '
        'indSelectedTab
        '
        Me.indSelectedTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.indSelectedTab.Location = New System.Drawing.Point(192, 91)
        Me.indSelectedTab.Name = "indSelectedTab"
        Me.indSelectedTab.Size = New System.Drawing.Size(10, 76)
        Me.indSelectedTab.TabIndex = 0
        Me.indSelectedTab.TabStop = False
        Me.indSelectedTab.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(77, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'tlpMenuBtn
        '
        Me.tlpMenuBtn.ColumnCount = 1
        Me.tlpMenuBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenuBtn.Controls.Add(Me.btnCheckOut, 0, 3)
        Me.tlpMenuBtn.Controls.Add(Me.btnEditGuestRecords, 0, 1)
        Me.tlpMenuBtn.Controls.Add(Me.btnCheckIn, 0, 2)
        Me.tlpMenuBtn.Controls.Add(Me.btnRegisterGuest, 0, 0)
        Me.tlpMenuBtn.Controls.Add(Me.btnExtendBooking, 0, 4)
        Me.tlpMenuBtn.Location = New System.Drawing.Point(43, 89)
        Me.tlpMenuBtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tlpMenuBtn.Name = "tlpMenuBtn"
        Me.tlpMenuBtn.RowCount = 5
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMenuBtn.Size = New System.Drawing.Size(149, 381)
        Me.tlpMenuBtn.TabIndex = 4
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Location = New System.Drawing.Point(2, 230)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(145, 72)
        Me.btnCheckOut.TabIndex = 4
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'pnlMenuStatic
        '
        Me.pnlMenuStatic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenuStatic.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.pnlMenuStatic.Controls.Add(Me.PictureBox2)
        Me.pnlMenuStatic.Controls.Add(Me.lblYear)
        Me.pnlMenuStatic.Controls.Add(Me.lblMonth)
        Me.pnlMenuStatic.Controls.Add(Me.lblDay)
        Me.pnlMenuStatic.Controls.Add(Me.PictureBox3)
        Me.pnlMenuStatic.Location = New System.Drawing.Point(-7, -4)
        Me.pnlMenuStatic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlMenuStatic.Name = "pnlMenuStatic"
        Me.pnlMenuStatic.Size = New System.Drawing.Size(50, 481)
        Me.pnlMenuStatic.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 438)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblYear.Location = New System.Drawing.Point(9, 259)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(40, 17)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "2020"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.lblMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblMonth.Location = New System.Drawing.Point(9, 240)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(38, 19)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "NOV"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Segoe UI Light", 20.0!)
        Me.lblDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblDay.Location = New System.Drawing.Point(9, 208)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(41, 37)
        Me.lblDay.TabIndex = 3
        Me.lblDay.Text = "31"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'StaffMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 474)
        Me.Controls.Add(Me.pnlMenuStatic)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlMainView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "StaffMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffMenuForm"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.indSelectedTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMenuBtn.ResumeLayout(False)
        Me.pnlMenuStatic.ResumeLayout(False)
        Me.pnlMenuStatic.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExtendBooking As Button
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnRegisterGuest As Button
    Friend WithEvents btnEditGuestRecords As Button
    Friend WithEvents pnlMainView As Panel
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents tlpMenuBtn As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents indSelectedTab As PictureBox
    Friend WithEvents pnlMenuStatic As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
