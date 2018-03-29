<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestInfoEdit
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
        Me.GboGuestEdit = New System.Windows.Forms.GroupBox()
        Me.txtGuestMobile = New System.Windows.Forms.MaskedTextBox()
        Me.txtGuestEmail = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.CboGuestID = New System.Windows.Forms.ComboBox()
        Me.lblGuestEmail = New System.Windows.Forms.Label()
        Me.lblGuestMobile = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.lblGuestEdit = New System.Windows.Forms.Label()
        Me.GboGuestEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'GboGuestEdit
        '
        Me.GboGuestEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GboGuestEdit.Controls.Add(Me.txtGuestMobile)
        Me.GboGuestEdit.Controls.Add(Me.txtGuestEmail)
        Me.GboGuestEdit.Controls.Add(Me.btnUpdate)
        Me.GboGuestEdit.Controls.Add(Me.txtGuestName)
        Me.GboGuestEdit.Controls.Add(Me.CboGuestID)
        Me.GboGuestEdit.Controls.Add(Me.lblGuestEmail)
        Me.GboGuestEdit.Controls.Add(Me.lblGuestMobile)
        Me.GboGuestEdit.Controls.Add(Me.lblGuestName)
        Me.GboGuestEdit.Controls.Add(Me.lblGuestID)
        Me.GboGuestEdit.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GboGuestEdit.Location = New System.Drawing.Point(11, 65)
        Me.GboGuestEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.GboGuestEdit.Name = "GboGuestEdit"
        Me.GboGuestEdit.Padding = New System.Windows.Forms.Padding(2)
        Me.GboGuestEdit.Size = New System.Drawing.Size(900, 410)
        Me.GboGuestEdit.TabIndex = 3
        Me.GboGuestEdit.TabStop = False
        Me.GboGuestEdit.Text = "Guest Information Search && Edit"
        '
        'txtGuestMobile
        '
        Me.txtGuestMobile.AllowPromptAsInput = False
        Me.txtGuestMobile.HidePromptOnLeave = True
        Me.txtGuestMobile.Location = New System.Drawing.Point(427, 181)
        Me.txtGuestMobile.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGuestMobile.Mask = "+9999-00000000"
        Me.txtGuestMobile.Name = "txtGuestMobile"
        Me.txtGuestMobile.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtGuestMobile.Size = New System.Drawing.Size(173, 21)
        Me.txtGuestMobile.TabIndex = 15
        Me.txtGuestMobile.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtGuestEmail
        '
        Me.txtGuestEmail.Location = New System.Drawing.Point(427, 237)
        Me.txtGuestEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGuestEmail.Name = "txtGuestEmail"
        Me.txtGuestEmail.Size = New System.Drawing.Size(173, 21)
        Me.txtGuestEmail.TabIndex = 14
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(384, 318)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(427, 127)
        Me.txtGuestName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(173, 21)
        Me.txtGuestName.TabIndex = 12
        '
        'CboGuestID
        '
        Me.CboGuestID.FormattingEnabled = True
        Me.CboGuestID.Location = New System.Drawing.Point(427, 71)
        Me.CboGuestID.Margin = New System.Windows.Forms.Padding(2)
        Me.CboGuestID.Name = "CboGuestID"
        Me.CboGuestID.Size = New System.Drawing.Size(173, 20)
        Me.CboGuestID.TabIndex = 11
        '
        'lblGuestEmail
        '
        Me.lblGuestEmail.AutoSize = True
        Me.lblGuestEmail.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestEmail.Location = New System.Drawing.Point(307, 239)
        Me.lblGuestEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestEmail.Name = "lblGuestEmail"
        Me.lblGuestEmail.Size = New System.Drawing.Size(79, 13)
        Me.lblGuestEmail.TabIndex = 7
        Me.lblGuestEmail.Text = "Email Address"
        '
        'lblGuestMobile
        '
        Me.lblGuestMobile.AutoSize = True
        Me.lblGuestMobile.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestMobile.Location = New System.Drawing.Point(307, 186)
        Me.lblGuestMobile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestMobile.Name = "lblGuestMobile"
        Me.lblGuestMobile.Size = New System.Drawing.Size(87, 13)
        Me.lblGuestMobile.TabIndex = 5
        Me.lblGuestMobile.Text = "Mobile Number"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.Location = New System.Drawing.Point(307, 131)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(37, 13)
        Me.lblGuestName.TabIndex = 3
        Me.lblGuestName.Text = "Name"
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestID.Location = New System.Drawing.Point(307, 76)
        Me.lblGuestID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(110, 13)
        Me.lblGuestID.TabIndex = 1
        Me.lblGuestID.Text = "Passport/IC Number"
        '
        'lblGuestEdit
        '
        Me.lblGuestEdit.AutoSize = True
        Me.lblGuestEdit.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblGuestEdit.Location = New System.Drawing.Point(319, 16)
        Me.lblGuestEdit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestEdit.Name = "lblGuestEdit"
        Me.lblGuestEdit.Size = New System.Drawing.Size(311, 47)
        Me.lblGuestEdit.TabIndex = 10
        Me.lblGuestEdit.Text = "EDIT GUEST INFO"
        Me.lblGuestEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GuestInfoEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(922, 493)
        Me.Controls.Add(Me.lblGuestEdit)
        Me.Controls.Add(Me.GboGuestEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GuestInfoEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GuestInfoEdit"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GboGuestEdit.ResumeLayout(False)
        Me.GboGuestEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GboGuestEdit As GroupBox
    Friend WithEvents txtGuestEmail As TextBox
    Friend WithEvents CboGuestID As ComboBox
    Friend WithEvents lblGuestEmail As Label
    Friend WithEvents lblGuestMobile As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents lblGuestID As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblGuestEdit As Label
    Friend WithEvents txtGuestMobile As MaskedTextBox
    Friend WithEvents txtGuestName As TextBox
End Class
