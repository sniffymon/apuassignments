<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChaletDetails
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
        Me.lblChalet = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.Label()
        Me.txtCheckIn = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.txtCheckOut = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.txtEB = New System.Windows.Forms.Label()
        Me.lblEB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblChalet
        '
        Me.lblChalet.AutoSize = True
        Me.lblChalet.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChalet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblChalet.Location = New System.Drawing.Point(128, 5)
        Me.lblChalet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChalet.Name = "lblChalet"
        Me.lblChalet.Size = New System.Drawing.Size(102, 37)
        Me.lblChalet.TabIndex = 0
        Me.lblChalet.Text = "Label1"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.ForeColor = System.Drawing.Color.White
        Me.lblGuestName.Location = New System.Drawing.Point(45, 131)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(69, 13)
        Me.lblGuestName.TabIndex = 1
        Me.lblGuestName.Text = "Guest Name"
        '
        'txtGuestName
        '
        Me.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGuestName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.ForeColor = System.Drawing.Color.White
        Me.txtGuestName.Location = New System.Drawing.Point(114, 127)
        Me.txtGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(184, 21)
        Me.txtGuestName.TabIndex = 2
        Me.txtGuestName.Text = "Not Available Yet"
        '
        'txtCheckIn
        '
        Me.txtCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCheckIn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckIn.ForeColor = System.Drawing.Color.White
        Me.txtCheckIn.Location = New System.Drawing.Point(114, 163)
        Me.txtCheckIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtCheckIn.Name = "txtCheckIn"
        Me.txtCheckIn.Size = New System.Drawing.Size(184, 21)
        Me.txtCheckIn.TabIndex = 4
        Me.txtCheckIn.Text = "Not Available Yet"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckIn.ForeColor = System.Drawing.Color.White
        Me.lblCheckIn.Location = New System.Drawing.Point(32, 166)
        Me.lblCheckIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(79, 13)
        Me.lblCheckIn.TabIndex = 3
        Me.lblCheckIn.Text = "Check-In Date"
        '
        'txtCheckOut
        '
        Me.txtCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCheckOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckOut.ForeColor = System.Drawing.Color.White
        Me.txtCheckOut.Location = New System.Drawing.Point(114, 199)
        Me.txtCheckOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtCheckOut.Name = "txtCheckOut"
        Me.txtCheckOut.Size = New System.Drawing.Size(184, 21)
        Me.txtCheckOut.TabIndex = 6
        Me.txtCheckOut.Text = "Not Available Yet"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOut.ForeColor = System.Drawing.Color.White
        Me.lblCheckOut.Location = New System.Drawing.Point(25, 202)
        Me.lblCheckOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(89, 13)
        Me.lblCheckOut.TabIndex = 5
        Me.lblCheckOut.Text = "Check-Out Date"
        '
        'txtEB
        '
        Me.txtEB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtEB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEB.ForeColor = System.Drawing.Color.White
        Me.txtEB.Location = New System.Drawing.Point(114, 232)
        Me.txtEB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtEB.Name = "txtEB"
        Me.txtEB.Size = New System.Drawing.Size(184, 21)
        Me.txtEB.TabIndex = 8
        Me.txtEB.Text = "Not Available Yet"
        '
        'lblEB
        '
        Me.lblEB.AutoSize = True
        Me.lblEB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEB.ForeColor = System.Drawing.Color.White
        Me.lblEB.Location = New System.Drawing.Point(48, 235)
        Me.lblEB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEB.Name = "lblEB"
        Me.lblEB.Size = New System.Drawing.Size(60, 13)
        Me.lblEB.TabIndex = 7
        Me.lblEB.Text = "Extra Beds"
        '
        'ChaletDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 335)
        Me.Controls.Add(Me.txtEB)
        Me.Controls.Add(Me.lblEB)
        Me.Controls.Add(Me.txtCheckOut)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.txtCheckIn)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.lblGuestName)
        Me.Controls.Add(Me.lblChalet)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ChaletDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChaletDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChalet As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents txtGuestName As Label
    Friend WithEvents txtCheckIn As Label
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents txtCheckOut As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents txtEB As Label
    Friend WithEvents lblEB As Label
End Class
