<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChaletDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.Label()
        Me.txtCheckIn = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCheckOut = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEB = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Guest Name"
        '
        'txtGuestName
        '
        Me.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestName.Location = New System.Drawing.Point(227, 244)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(367, 41)
        Me.txtGuestName.TabIndex = 2
        Me.txtGuestName.Text = "Not Available Yet"
        '
        'txtCheckIn
        '
        Me.txtCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCheckIn.Location = New System.Drawing.Point(227, 314)
        Me.txtCheckIn.Name = "txtCheckIn"
        Me.txtCheckIn.Size = New System.Drawing.Size(367, 41)
        Me.txtCheckIn.TabIndex = 4
        Me.txtCheckIn.Text = "Not Available Yet"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Check-In Date"
        '
        'txtCheckOut
        '
        Me.txtCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCheckOut.Location = New System.Drawing.Point(227, 382)
        Me.txtCheckOut.Name = "txtCheckOut"
        Me.txtCheckOut.Size = New System.Drawing.Size(367, 41)
        Me.txtCheckOut.TabIndex = 6
        Me.txtCheckOut.Text = "Not Available Yet"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Check-Out Date"
        '
        'txtEB
        '
        Me.txtEB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtEB.Location = New System.Drawing.Point(227, 446)
        Me.txtEB.Name = "txtEB"
        Me.txtEB.Size = New System.Drawing.Size(367, 41)
        Me.txtEB.TabIndex = 8
        Me.txtEB.Text = "Not Available Yet"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(95, 452)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Extra Beds"
        '
        'ChaletDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 645)
        Me.Controls.Add(Me.txtEB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCheckOut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCheckIn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChaletDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChaletDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGuestName As Label
    Friend WithEvents txtCheckIn As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCheckOut As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEB As Label
    Friend WithEvents Label9 As Label
End Class
