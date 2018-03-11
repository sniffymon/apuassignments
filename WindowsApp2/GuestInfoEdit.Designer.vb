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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGuestEmail = New System.Windows.Forms.TextBox()
        Me.txtGuestMobile = New System.Windows.Forms.TextBox()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.cboGuestID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGuestEmail)
        Me.GroupBox1.Controls.Add(Me.txtGuestMobile)
        Me.GroupBox1.Controls.Add(Me.txtGuestName)
        Me.GroupBox1.Controls.Add(Me.cboGuestID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblGuestName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(818, 352)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Information Search"
        '
        'txtGuestEmail
        '
        Me.txtGuestEmail.Location = New System.Drawing.Point(353, 237)
        Me.txtGuestEmail.Name = "txtGuestEmail"
        Me.txtGuestEmail.Size = New System.Drawing.Size(342, 31)
        Me.txtGuestEmail.TabIndex = 14
        '
        'txtGuestMobile
        '
        Me.txtGuestMobile.Location = New System.Drawing.Point(353, 182)
        Me.txtGuestMobile.Name = "txtGuestMobile"
        Me.txtGuestMobile.Size = New System.Drawing.Size(342, 31)
        Me.txtGuestMobile.TabIndex = 13
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(353, 127)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(342, 31)
        Me.txtGuestName.TabIndex = 12
        '
        'cboGuestID
        '
        Me.cboGuestID.FormattingEnabled = True
        Me.cboGuestID.Location = New System.Drawing.Point(353, 70)
        Me.cboGuestID.Name = "cboGuestID"
        Me.cboGuestID.Size = New System.Drawing.Size(342, 33)
        Me.cboGuestID.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mobile Number"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Location = New System.Drawing.Point(113, 134)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(68, 25)
        Me.lblGuestName.TabIndex = 3
        Me.lblGuestName.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Passport/IC Number"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(573, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GuestInfoEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 419)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "GuestInfoEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GuestInfoEdit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGuestEmail As TextBox
    Friend WithEvents txtGuestMobile As TextBox
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents cboGuestID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
