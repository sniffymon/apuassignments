<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutCart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOutCart))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlOthers = New System.Windows.Forms.Panel()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Guest Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTAmount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblDeposit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(153, 502)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 62)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculated Charges"
        '
        'lblTAmount
        '
        Me.lblTAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTAmount.Location = New System.Drawing.Point(478, 22)
        Me.lblTAmount.Name = "lblTAmount"
        Me.lblTAmount.Size = New System.Drawing.Size(140, 29)
        Me.lblTAmount.TabIndex = 3
        Me.lblTAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Amount"
        '
        'lblDeposit
        '
        Me.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeposit.Location = New System.Drawing.Point(189, 22)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(124, 29)
        Me.lblDeposit.TabIndex = 1
        Me.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deposit"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(411, 575)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 65)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Confirm Checkout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pnlOthers
        '
        Me.pnlOthers.AutoScroll = True
        Me.pnlOthers.BackgroundImage = CType(resources.GetObject("pnlOthers.BackgroundImage"), System.Drawing.Image)
        Me.pnlOthers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlOthers.Location = New System.Drawing.Point(63, 103)
        Me.pnlOthers.Name = "pnlOthers"
        Me.pnlOthers.Size = New System.Drawing.Size(864, 382)
        Me.pnlOthers.TabIndex = 9
        '
        'lblCheckIn
        '
        Me.lblCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCheckIn.Location = New System.Drawing.Point(615, 57)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(303, 29)
        Me.lblCheckIn.TabIndex = 14
        Me.lblCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(486, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Booking Dates"
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Location = New System.Drawing.Point(201, 57)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(240, 29)
        Me.lblName.TabIndex = 12
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckOutCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1002, 668)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlOthers)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CheckOutCart"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTAmount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDeposit As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlOthers As Panel
    Friend WithEvents lblCheckIn As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblName As Label
End Class
