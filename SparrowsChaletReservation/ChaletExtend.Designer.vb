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
        Me.btnExtendBooking = New System.Windows.Forms.Button()
        Me.lblEB = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.lblChalet = New System.Windows.Forms.Label()
        Me.txtGuestName = New System.Windows.Forms.Label()
        Me.txtCheckIn = New System.Windows.Forms.Label()
        Me.txtEB = New System.Windows.Forms.Label()
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
        'btnExtendBooking
        '
        Me.btnExtendBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtendBooking.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtendBooking.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnExtendBooking.Location = New System.Drawing.Point(160, 315)
        Me.btnExtendBooking.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExtendBooking.Name = "btnExtendBooking"
        Me.btnExtendBooking.Size = New System.Drawing.Size(96, 40)
        Me.btnExtendBooking.TabIndex = 31
        Me.btnExtendBooking.Text = "Extend Booking"
        Me.btnExtendBooking.UseVisualStyleBackColor = True
        '
        'lblEB
        '
        Me.lblEB.AutoSize = True
        Me.lblEB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEB.ForeColor = System.Drawing.Color.White
        Me.lblEB.Location = New System.Drawing.Point(91, 250)
        Me.lblEB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEB.Name = "lblEB"
        Me.lblEB.Size = New System.Drawing.Size(60, 13)
        Me.lblEB.TabIndex = 30
        Me.lblEB.Text = "Extra Beds"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOut.ForeColor = System.Drawing.Color.White
        Me.lblCheckOut.Location = New System.Drawing.Point(68, 217)
        Me.lblCheckOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(89, 13)
        Me.lblCheckOut.TabIndex = 29
        Me.lblCheckOut.Text = "Check-Out Date"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckIn.ForeColor = System.Drawing.Color.White
        Me.lblCheckIn.Location = New System.Drawing.Point(74, 181)
        Me.lblCheckIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(79, 13)
        Me.lblCheckIn.TabIndex = 28
        Me.lblCheckIn.Text = "Check-In Date"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.ForeColor = System.Drawing.Color.White
        Me.lblGuestName.Location = New System.Drawing.Point(88, 145)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(69, 13)
        Me.lblGuestName.TabIndex = 27
        Me.lblGuestName.Text = "Guest Name"
        '
        'lblChalet
        '
        Me.lblChalet.AutoSize = True
        Me.lblChalet.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChalet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblChalet.Location = New System.Drawing.Point(153, 38)
        Me.lblChalet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChalet.Name = "lblChalet"
        Me.lblChalet.Size = New System.Drawing.Size(102, 37)
        Me.lblChalet.TabIndex = 26
        Me.lblChalet.Text = "Label1"
        '
        'txtGuestName
        '
        Me.txtGuestName.BackColor = System.Drawing.Color.White
        Me.txtGuestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGuestName.Location = New System.Drawing.Point(166, 145)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(145, 23)
        Me.txtGuestName.TabIndex = 37
        '
        'txtCheckIn
        '
        Me.txtCheckIn.BackColor = System.Drawing.Color.White
        Me.txtCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCheckIn.Location = New System.Drawing.Point(166, 180)
        Me.txtCheckIn.Name = "txtCheckIn"
        Me.txtCheckIn.Size = New System.Drawing.Size(145, 23)
        Me.txtCheckIn.TabIndex = 38
        '
        'txtEB
        '
        Me.txtEB.BackColor = System.Drawing.Color.White
        Me.txtEB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEB.Location = New System.Drawing.Point(166, 249)
        Me.txtEB.Name = "txtEB"
        Me.txtEB.Size = New System.Drawing.Size(145, 23)
        Me.txtEB.TabIndex = 39
        '
        'ChaletExtend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(379, 392)
        Me.Controls.Add(Me.txtEB)
        Me.Controls.Add(Me.txtCheckIn)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.dtpCheckOut)
        Me.Controls.Add(Me.btnExtendBooking)
        Me.Controls.Add(Me.lblEB)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.lblGuestName)
        Me.Controls.Add(Me.lblChalet)
        Me.Name = "ChaletExtend"
        Me.Text = "ChaletExtend"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents btnExtendBooking As Button
    Friend WithEvents lblEB As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents lblChalet As Label
    Friend WithEvents txtGuestName As Label
    Friend WithEvents txtCheckIn As Label
    Friend WithEvents txtEB As Label
End Class
