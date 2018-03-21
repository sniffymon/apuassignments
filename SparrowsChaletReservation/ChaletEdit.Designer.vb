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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(79, 256)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Extra Beds"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(56, 223)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Check-Out Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(62, 187)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Check-In Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(76, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Guest Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(141, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(59, 321)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 40)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Update Records"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.CustomFormat = "yyyy-MM-dd"
        Me.dtpCheckIn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckIn.Location = New System.Drawing.Point(154, 184)
        Me.dtpCheckIn.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpCheckIn.MinDate = New Date(1998, 1, 1, 0, 0, 0, 0)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(145, 22)
        Me.dtpCheckIn.TabIndex = 22
        Me.dtpCheckIn.Value = New Date(2018, 3, 20, 22, 35, 34, 0)
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.CustomFormat = "yyyy-MM-dd"
        Me.dtpCheckOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckOut.Location = New System.Drawing.Point(154, 219)
        Me.dtpCheckOut.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(145, 22)
        Me.dtpCheckOut.TabIndex = 23
        '
        'ddmGuestName
        '
        Me.ddmGuestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddmGuestName.FormattingEnabled = True
        Me.ddmGuestName.Location = New System.Drawing.Point(154, 151)
        Me.ddmGuestName.Margin = New System.Windows.Forms.Padding(2)
        Me.ddmGuestName.Name = "ddmGuestName"
        Me.ddmGuestName.Size = New System.Drawing.Size(145, 21)
        Me.ddmGuestName.TabIndex = 24
        '
        'cboEB
        '
        Me.cboEB.AutoCompleteCustomSource.AddRange(New String() {"None", "1", "2"})
        Me.cboEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEB.FormattingEnabled = True
        Me.cboEB.Items.AddRange(New Object() {"No Extra Beds", "1", "2"})
        Me.cboEB.Location = New System.Drawing.Point(154, 254)
        Me.cboEB.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEB.Name = "cboEB"
        Me.cboEB.Size = New System.Drawing.Size(145, 21)
        Me.cboEB.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(203, 321)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 40)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Records"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ChaletEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(375, 396)
        Me.Controls.Add(Me.Button2)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
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
    Friend WithEvents Button2 As Button
End Class
