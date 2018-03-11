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
        Me.GroupBox1.Location = New System.Drawing.Point(73, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(818, 340)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Information Search"
        '
        'cboGuestID
        '
        Me.cboGuestID.FormattingEnabled = True
        Me.cboGuestID.Location = New System.Drawing.Point(353, 70)
        Me.cboGuestID.Name = "cboGuestID"
        Me.cboGuestID.Size = New System.Drawing.Size(342, 33)
        Me.cboGuestID.TabIndex = 11
        '
        'txtGuestEmail
        '
        Me.txtGuestEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestEmail.Location = New System.Drawing.Point(353, 238)
        Me.txtGuestEmail.Name = "txtGuestEmail"
        Me.txtGuestEmail.Size = New System.Drawing.Size(342, 33)
        Me.txtGuestEmail.TabIndex = 10
        '
        'txtGuestName
        '
        Me.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestName.Location = New System.Drawing.Point(353, 129)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(342, 33)
        Me.txtGuestName.TabIndex = 9
        '
        'txtGuestMobile
        '
        Me.txtGuestMobile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestMobile.Location = New System.Drawing.Point(353, 183)
        Me.txtGuestMobile.Name = "txtGuestMobile"
        Me.txtGuestMobile.Size = New System.Drawing.Size(342, 33)
        Me.txtGuestMobile.TabIndex = 8
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
        'GuestInfoSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 431)
        Me.Controls.Add(Me.GroupBox1)
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
