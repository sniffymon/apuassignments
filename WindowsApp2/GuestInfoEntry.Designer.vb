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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGuestEmail = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuestMobile = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.MaskedTextBox()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.txtGuestID = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGuestEmail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtGuestMobile)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGuestName)
        Me.GroupBox1.Controls.Add(Me.lblGuestName)
        Me.GroupBox1.Controls.Add(Me.txtGuestID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 298)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Information Enter"
        '
        'txtGuestEmail
        '
        Me.txtGuestEmail.Location = New System.Drawing.Point(262, 210)
        Me.txtGuestEmail.Name = "txtGuestEmail"
        Me.txtGuestEmail.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtGuestEmail.Size = New System.Drawing.Size(342, 31)
        Me.txtGuestEmail.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Email Address"
        '
        'txtGuestMobile
        '
        Me.txtGuestMobile.Location = New System.Drawing.Point(262, 158)
        Me.txtGuestMobile.Mask = "0000000000"
        Me.txtGuestMobile.Name = "txtGuestMobile"
        Me.txtGuestMobile.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtGuestMobile.Size = New System.Drawing.Size(342, 31)
        Me.txtGuestMobile.TabIndex = 6
        Me.txtGuestMobile.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mobile Number"
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(262, 104)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtGuestName.Size = New System.Drawing.Size(342, 31)
        Me.txtGuestName.TabIndex = 4
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Location = New System.Drawing.Point(22, 104)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(68, 25)
        Me.lblGuestName.TabIndex = 3
        Me.lblGuestName.Text = "Name"
        '
        'txtGuestID
        '
        Me.txtGuestID.Location = New System.Drawing.Point(262, 46)
        Me.txtGuestID.Mask = "000000009"
        Me.txtGuestID.Name = "txtGuestID"
        Me.txtGuestID.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtGuestID.Size = New System.Drawing.Size(342, 31)
        Me.txtGuestID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Passport/IC Number"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GuestInfoEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 589)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GuestInfoEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GuestInfoEntry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGuestEmail As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGuestMobile As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGuestName As MaskedTextBox
    Friend WithEvents lblGuestName As Label
    Friend WithEvents txtGuestID As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
