<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChaletExtend
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
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.txtEB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.CustomFormat = "yyyy-MM-dd"
        Me.dtpCheckOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckOut.Location = New System.Drawing.Point(166, 213)
        Me.dtpCheckOut.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(145, 22)
        Me.dtpCheckOut.TabIndex = 33
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.CustomFormat = "yyyy-MM-dd"
        Me.dtpCheckIn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckIn.Location = New System.Drawing.Point(166, 178)
        Me.dtpCheckIn.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(145, 22)
        Me.dtpCheckIn.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(160, 315)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 40)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Extend Booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(91, 250)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Extra Beds"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(68, 217)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Check-Out Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(74, 181)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Check-In Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Guest Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(153, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 37)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Label1"
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(166, 142)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(145, 20)
        Me.txtGuestName.TabIndex = 34
        '
        'txtEB
        '
        Me.txtEB.Location = New System.Drawing.Point(166, 247)
        Me.txtEB.Name = "txtEB"
        Me.txtEB.ReadOnly = True
        Me.txtEB.Size = New System.Drawing.Size(145, 20)
        Me.txtEB.TabIndex = 35
        '
        'ChaletExtend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 392)
        Me.Controls.Add(Me.txtEB)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.dtpCheckOut)
        Me.Controls.Add(Me.dtpCheckIn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChaletExtend"
        Me.Text = "ChaletExtend"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents txtEB As TextBox
End Class
