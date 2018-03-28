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
        Me.lblEB = New System.Windows.Forms.Label()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.lblGuestName = New System.Windows.Forms.Label()
        Me.lblChalet = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.CboGuestName = New System.Windows.Forms.ComboBox()
        Me.CboEB = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEB
        '
        Me.lblEB.AutoSize = True
        Me.lblEB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEB.ForeColor = System.Drawing.Color.White
        Me.lblEB.Location = New System.Drawing.Point(79, 256)
        Me.lblEB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEB.Name = "lblEB"
        Me.lblEB.Size = New System.Drawing.Size(60, 13)
        Me.lblEB.TabIndex = 16
        Me.lblEB.Text = "Extra Beds"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOut.ForeColor = System.Drawing.Color.White
        Me.lblCheckOut.Location = New System.Drawing.Point(56, 223)
        Me.lblCheckOut.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(89, 13)
        Me.lblCheckOut.TabIndex = 14
        Me.lblCheckOut.Text = "Check-Out Date"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckIn.ForeColor = System.Drawing.Color.White
        Me.lblCheckIn.Location = New System.Drawing.Point(62, 187)
        Me.lblCheckIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(79, 13)
        Me.lblCheckIn.TabIndex = 12
        Me.lblCheckIn.Text = "Check-In Date"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.ForeColor = System.Drawing.Color.White
        Me.lblGuestName.Location = New System.Drawing.Point(76, 151)
        Me.lblGuestName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(69, 13)
        Me.lblGuestName.TabIndex = 10
        Me.lblGuestName.Text = "Guest Name"
        '
        'lblChalet
        '
        Me.lblChalet.AutoSize = True
        Me.lblChalet.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChalet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblChalet.Location = New System.Drawing.Point(141, 44)
        Me.lblChalet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChalet.Name = "lblChalet"
        Me.lblChalet.Size = New System.Drawing.Size(102, 37)
        Me.lblChalet.TabIndex = 9
        Me.lblChalet.Text = "Label1"
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(59, 321)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 40)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Update Records"
        Me.btnUpdate.UseVisualStyleBackColor = True
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
        'CboGuestName
        '
        Me.CboGuestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGuestName.FormattingEnabled = True
        Me.CboGuestName.Location = New System.Drawing.Point(154, 151)
        Me.CboGuestName.Margin = New System.Windows.Forms.Padding(2)
        Me.CboGuestName.Name = "CboGuestName"
        Me.CboGuestName.Size = New System.Drawing.Size(145, 21)
        Me.CboGuestName.TabIndex = 24
        '
        'CboEB
        '
        Me.CboEB.AutoCompleteCustomSource.AddRange(New String() {"None", "1", "2"})
        Me.CboEB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEB.FormattingEnabled = True
        Me.CboEB.Items.AddRange(New Object() {"No Extra Beds", "1", "2"})
        Me.CboEB.Location = New System.Drawing.Point(154, 254)
        Me.CboEB.Margin = New System.Windows.Forms.Padding(2)
        Me.CboEB.Name = "CboEB"
        Me.CboEB.Size = New System.Drawing.Size(145, 21)
        Me.CboEB.TabIndex = 25
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(203, 321)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 40)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Records"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ChaletEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(375, 396)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.CboEB)
        Me.Controls.Add(Me.CboGuestName)
        Me.Controls.Add(Me.dtpCheckOut)
        Me.Controls.Add(Me.dtpCheckIn)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblEB)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.lblGuestName)
        Me.Controls.Add(Me.lblChalet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "ChaletEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChaletEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEB As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents lblGuestName As Label
    Friend WithEvents lblChalet As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents CboGuestName As ComboBox
    Friend WithEvents CboEB As ComboBox
    Friend WithEvents btnDelete As Button
End Class
