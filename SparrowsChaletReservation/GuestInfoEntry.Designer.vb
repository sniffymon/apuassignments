<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestInfoEntry
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
        Me.GboInfoEntry = New System.Windows.Forms.GroupBox()
        Me.txtGuestMobile = New System.Windows.Forms.TextBox()
        Me.txtGuestID = New System.Windows.Forms.TextBox()
        Me.txtGuestEmail = New System.Windows.Forms.TextBox()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.lblGuestEmail = New System.Windows.Forms.Label()
        Me.lblGuestMobile = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.lblRegisterGuest = New System.Windows.Forms.Label()
        Me.GboInfoEntry.SuspendLayout()
        Me.SuspendLayout()
        '
        'GboInfoEntry
        '
        Me.GboInfoEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GboInfoEntry.Controls.Add(Me.txtGuestMobile)
        Me.GboInfoEntry.Controls.Add(Me.txtGuestID)
        Me.GboInfoEntry.Controls.Add(Me.txtGuestEmail)
        Me.GboInfoEntry.Controls.Add(Me.txtGuestName)
        Me.GboInfoEntry.Controls.Add(Me.lblGuestEmail)
        Me.GboInfoEntry.Controls.Add(Me.lblGuestMobile)
        Me.GboInfoEntry.Controls.Add(Me.lblGuestName)
        Me.GboInfoEntry.Controls.Add(Me.lblGuestID)
        Me.GboInfoEntry.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboInfoEntry.Location = New System.Drawing.Point(24, 84)
        Me.GboInfoEntry.Margin = New System.Windows.Forms.Padding(2)
        Me.GboInfoEntry.Name = "GboInfoEntry"
        Me.GboInfoEntry.Padding = New System.Windows.Forms.Padding(2)
        Me.GboInfoEntry.Size = New System.Drawing.Size(811, 264)
        Me.GboInfoEntry.TabIndex = 1
        Me.GboInfoEntry.TabStop = False
        Me.GboInfoEntry.Text = "Guest Information Enter"
        '
        'txtGuestMobile
        '
        Me.txtGuestMobile.Location = New System.Drawing.Point(361, 112)
        Me.txtGuestMobile.Name = "txtGuestMobile"
        Me.txtGuestMobile.Size = New System.Drawing.Size(201, 21)
        Me.txtGuestMobile.TabIndex = 9
        '
        'txtGuestID
        '
        Me.txtGuestID.Location = New System.Drawing.Point(361, 38)
        Me.txtGuestID.Name = "txtGuestID"
        Me.txtGuestID.Size = New System.Drawing.Size(201, 21)
        Me.txtGuestID.TabIndex = 8
        '
        'txtGuestEmail
        '
        Me.txtGuestEmail.Location = New System.Drawing.Point(361, 147)
        Me.txtGuestEmail.Name = "txtGuestEmail"
        Me.txtGuestEmail.Size = New System.Drawing.Size(201, 21)
        Me.txtGuestEmail.TabIndex = 4
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(361, 76)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(201, 21)
        Me.txtGuestName.TabIndex = 2
        '
        'lblGuestEmail
        '
        Me.lblGuestEmail.AutoSize = True
        Me.lblGuestEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestEmail.Location = New System.Drawing.Point(198, 147)
        Me.lblGuestEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestEmail.Name = "lblGuestEmail"
        Me.lblGuestEmail.Size = New System.Drawing.Size(79, 13)
        Me.lblGuestEmail.TabIndex = 3
        Me.lblGuestEmail.Text = "Email Address"
        '
        'lblGuestMobile
        '
        Me.lblGuestMobile.AutoSize = True
        Me.lblGuestMobile.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestMobile.Location = New System.Drawing.Point(198, 112)
        Me.lblGuestMobile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestMobile.Name = "lblGuestMobile"
        Me.lblGuestMobile.Size = New System.Drawing.Size(87, 13)
        Me.lblGuestMobile.TabIndex = 1
        Me.lblGuestMobile.Text = "Mobile Number"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.Location = New System.Drawing.Point(198, 76)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(37, 13)
        Me.lblGuestName.TabIndex = 7
        Me.lblGuestName.Text = "Name"
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestID.Location = New System.Drawing.Point(198, 38)
        Me.lblGuestID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(110, 13)
        Me.lblGuestID.TabIndex = 5
        Me.lblGuestID.Text = "Passport/IC Number"
        '
        'btnRegister
        '
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(369, 385)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(101, 40)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "Enter"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'lblRegisterGuest
        '
        Me.lblRegisterGuest.AutoSize = True
        Me.lblRegisterGuest.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterGuest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblRegisterGuest.Location = New System.Drawing.Point(269, 20)
        Me.lblRegisterGuest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRegisterGuest.Name = "lblRegisterGuest"
        Me.lblRegisterGuest.Size = New System.Drawing.Size(301, 47)
        Me.lblRegisterGuest.TabIndex = 0
        Me.lblRegisterGuest.Text = "REGISTER GUEST"
        Me.lblRegisterGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GuestInfoEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 462)
        Me.Controls.Add(Me.lblRegisterGuest)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GboInfoEntry)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GuestInfoEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GuestInfoEntry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GboInfoEntry.ResumeLayout(False)
        Me.GboInfoEntry.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GboInfoEntry As GroupBox
    Friend WithEvents lblGuestEmail As Label
    Friend WithEvents lblGuestMobile As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents lblGuestID As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblRegisterGuest As Label
    Friend WithEvents txtGuestEmail As TextBox
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents txtGuestID As TextBox
    Friend WithEvents txtGuestMobile As TextBox
End Class
