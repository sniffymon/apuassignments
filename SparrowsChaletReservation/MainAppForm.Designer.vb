<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainAppForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainAppForm))
        Me.btnRegisterGuest = New System.Windows.Forms.Button()
        Me.btnSearchGuest = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpMenuBtn = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlMainView = New System.Windows.Forms.Panel()
        Me.indSelectedTab = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.tlpMenuBtn.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.indSelectedTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegisterGuest
        '
        Me.btnRegisterGuest.BackColor = System.Drawing.Color.Transparent
        Me.btnRegisterGuest.FlatAppearance.BorderSize = 0
        Me.btnRegisterGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterGuest.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterGuest.ForeColor = System.Drawing.Color.White
        Me.btnRegisterGuest.Location = New System.Drawing.Point(2, 2)
        Me.btnRegisterGuest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegisterGuest.Name = "btnRegisterGuest"
        Me.btnRegisterGuest.Size = New System.Drawing.Size(142, 88)
        Me.btnRegisterGuest.TabIndex = 1
        Me.btnRegisterGuest.Text = "Register Guest"
        Me.btnRegisterGuest.UseVisualStyleBackColor = False
        '
        'btnSearchGuest
        '
        Me.btnSearchGuest.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchGuest.FlatAppearance.BorderSize = 0
        Me.btnSearchGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchGuest.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchGuest.ForeColor = System.Drawing.Color.White
        Me.btnSearchGuest.Location = New System.Drawing.Point(2, 186)
        Me.btnSearchGuest.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearchGuest.Name = "btnSearchGuest"
        Me.btnSearchGuest.Size = New System.Drawing.Size(142, 88)
        Me.btnSearchGuest.TabIndex = 2
        Me.btnSearchGuest.Text = "Search Guest"
        Me.btnSearchGuest.UseVisualStyleBackColor = False
        '
        'btnCheckIn
        '
        Me.btnCheckIn.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckIn.FlatAppearance.BorderSize = 0
        Me.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckIn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.ForeColor = System.Drawing.Color.White
        Me.btnCheckIn.Location = New System.Drawing.Point(2, 94)
        Me.btnCheckIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(142, 88)
        Me.btnCheckIn.TabIndex = 4
        Me.btnCheckIn.Text = "Check-In"
        Me.btnCheckIn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.indSelectedTab)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tlpMenuBtn)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 474)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(31, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Staff Menu"
        '
        'tlpMenuBtn
        '
        Me.tlpMenuBtn.ColumnCount = 1
        Me.tlpMenuBtn.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenuBtn.Controls.Add(Me.btnCheckOut, 0, 3)
        Me.tlpMenuBtn.Controls.Add(Me.btnRegisterGuest, 0, 0)
        Me.tlpMenuBtn.Controls.Add(Me.btnCheckIn, 0, 1)
        Me.tlpMenuBtn.Controls.Add(Me.btnSearchGuest, 0, 2)
        Me.tlpMenuBtn.Location = New System.Drawing.Point(3, 100)
        Me.tlpMenuBtn.Name = "tlpMenuBtn"
        Me.tlpMenuBtn.RowCount = 4
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpMenuBtn.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMenuBtn.Size = New System.Drawing.Size(146, 371)
        Me.tlpMenuBtn.TabIndex = 6
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Location = New System.Drawing.Point(2, 278)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(142, 91)
        Me.btnCheckOut.TabIndex = 5
        Me.btnCheckOut.Text = "Check-Out"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnlMainView
        '
        Me.pnlMainView.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMainView.BackgroundImage = CType(resources.GetObject("pnlMainView.BackgroundImage"), System.Drawing.Image)
        Me.pnlMainView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlMainView.Location = New System.Drawing.Point(152, 0)
        Me.pnlMainView.Name = "pnlMainView"
        Me.pnlMainView.Size = New System.Drawing.Size(795, 474)
        Me.pnlMainView.TabIndex = 6
        '
        'indSelectedTab
        '
        Me.indSelectedTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.indSelectedTab.Location = New System.Drawing.Point(142, 103)
        Me.indSelectedTab.Name = "indSelectedTab"
        Me.indSelectedTab.Size = New System.Drawing.Size(10, 87)
        Me.indSelectedTab.TabIndex = 8
        Me.indSelectedTab.TabStop = False
        Me.indSelectedTab.Visible = False
        '
        'MainAppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 474)
        Me.Controls.Add(Me.pnlMainView)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "MainAppForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sparrow's Resort"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tlpMenuBtn.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.indSelectedTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegisterGuest As Button
    Friend WithEvents btnSearchGuest As Button
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tlpMenuBtn As TableLayoutPanel
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlMainView As Panel
    Friend WithEvents indSelectedTab As PictureBox
End Class
