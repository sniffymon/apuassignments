<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStaff
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCfmPwd = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsrName = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCfmPwd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPwd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsrName)
        Me.GroupBox1.Controls.Add(Me.lblGuestName)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 84)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(811, 264)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Staff Information Enter"
        '
        'txtCfmPwd
        '
        Me.txtCfmPwd.Location = New System.Drawing.Point(361, 144)
        Me.txtCfmPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCfmPwd.Name = "txtCfmPwd"
        Me.txtCfmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCfmPwd.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtCfmPwd.Size = New System.Drawing.Size(201, 21)
        Me.txtCfmPwd.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 147)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Confirm Password"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(361, 104)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtPwd.Size = New System.Drawing.Size(201, 21)
        Me.txtPwd.TabIndex = 6
        Me.txtPwd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'txtUsrName
        '
        Me.txtUsrName.Location = New System.Drawing.Point(361, 68)
        Me.txtUsrName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUsrName.Name = "txtUsrName"
        Me.txtUsrName.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtUsrName.ReadOnly = True
        Me.txtUsrName.Size = New System.Drawing.Size(201, 21)
        Me.txtUsrName.TabIndex = 4
        Me.txtUsrName.Text = "*This field is auto generated*"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.Location = New System.Drawing.Point(198, 76)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(89, 13)
        Me.lblGuestName.TabIndex = 3
        Me.lblGuestName.Text = "Login Username"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(361, 35)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFullName.Size = New System.Drawing.Size(201, 21)
        Me.txtFullName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fullname"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(369, 385)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(269, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 47)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "REGISTER STAFF"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegisterGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(867, 462)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RegisterGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GuestInfoEntry"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCfmPwd As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPwd As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsrName As MaskedTextBox
    Friend WithEvents lblGuestName As Label
    Friend WithEvents txtFullName As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
