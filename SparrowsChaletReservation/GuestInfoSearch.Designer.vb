<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GuestInfoSearch
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboGuestID = New System.Windows.Forms.ComboBox()
        Me.txtGuestEmail = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.Label()
        Me.txtGuestMobile = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboGuestID)
        Me.GroupBox1.Controls.Add(Me.txtGuestEmail)
        Me.GroupBox1.Controls.Add(Me.txtGuestName)
        Me.GroupBox1.Controls.Add(Me.txtGuestMobile)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblGuestName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(614, 272)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Information Search"
        '
        'cboGuestID
        '
        Me.cboGuestID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboGuestID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGuestID.FormattingEnabled = True
        Me.cboGuestID.Location = New System.Drawing.Point(265, 56)
        Me.cboGuestID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboGuestID.Name = "cboGuestID"
        Me.cboGuestID.Size = New System.Drawing.Size(258, 28)
        Me.cboGuestID.TabIndex = 11
        '
        'txtGuestEmail
        '
        Me.txtGuestEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestEmail.Location = New System.Drawing.Point(265, 190)
        Me.txtGuestEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtGuestEmail.Name = "txtGuestEmail"
        Me.txtGuestEmail.Size = New System.Drawing.Size(256, 26)
        Me.txtGuestEmail.TabIndex = 10
        '
        'txtGuestName
        '
        Me.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestName.Location = New System.Drawing.Point(265, 103)
        Me.txtGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(256, 26)
        Me.txtGuestName.TabIndex = 9
        '
        'txtGuestMobile
        '
        Me.txtGuestMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestMobile.Location = New System.Drawing.Point(265, 146)
        Me.txtGuestMobile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtGuestMobile.Name = "txtGuestMobile"
        Me.txtGuestMobile.Size = New System.Drawing.Size(256, 26)
        Me.txtGuestMobile.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mobile Number"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Location = New System.Drawing.Point(85, 107)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(51, 20)
        Me.lblGuestName.TabIndex = 3
        Me.lblGuestName.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Passport/IC Number"
        '
        'GuestInfoSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 345)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GuestInfoSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GuestInfoSearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboGuestID As ComboBox
    Friend WithEvents txtGuestEmail As Label
    Friend WithEvents txtGuestName As Label
    Friend WithEvents txtGuestMobile As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents Label1 As Label
End Class
