<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChaletEdit
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.ddmGuestName = New System.Windows.Forms.ComboBox()
        Me.cboEB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(158, 492)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Extra Beds"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Check-Out Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(125, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Check-In Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Guest Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 61)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 618)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 77)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Update Records"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.CustomFormat = "yyyy-MM-dd"
        Me.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckIn.Location = New System.Drawing.Point(307, 353)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(286, 31)
        Me.dtpCheckIn.TabIndex = 22
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.CustomFormat = "yyyy-MM-dd"
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckOut.Location = New System.Drawing.Point(307, 421)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(286, 31)
        Me.dtpCheckOut.TabIndex = 23
        '
        'ddmGuestName
        '
        Me.ddmGuestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddmGuestName.FormattingEnabled = True
        Me.ddmGuestName.Location = New System.Drawing.Point(307, 291)
        Me.ddmGuestName.Name = "ddmGuestName"
        Me.ddmGuestName.Size = New System.Drawing.Size(286, 33)
        Me.ddmGuestName.TabIndex = 24
        '
        'cboEB
        '
        Me.cboEB.AutoCompleteCustomSource.AddRange(New String() {"None", "1", "2"})
        Me.cboEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEB.FormattingEnabled = True
        Me.cboEB.Location = New System.Drawing.Point(307, 489)
        Me.cboEB.Name = "cboEB"
        Me.cboEB.Size = New System.Drawing.Size(286, 33)
        Me.cboEB.TabIndex = 25
        '
        'ChaletEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 761)
        Me.Controls.Add(Me.cboEB)
        Me.Controls.Add(Me.ddmGuestName)
        Me.Controls.Add(Me.dtpCheckOut)
        Me.Controls.Add(Me.dtpCheckIn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ChaletEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChaletEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents ddmGuestName As ComboBox
    Friend WithEvents cboEB As ComboBox
End Class
