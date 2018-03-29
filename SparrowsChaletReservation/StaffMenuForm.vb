Public Class StaffMenuForm
    Private Sub AdminMenuForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GuestInfoEdit.Close()
        CheckOut.Close()
        ExtendBooking.Close()
        GboChaletMap.Close()
        GuestInfoEntry.Close()
    End Sub
    Private Sub btnRegisterGuest_Click(sender As Object, e As EventArgs) Handles btnRegisterGuest.Click, btnExtendBooking.Click, btnCheckIn.Click, btnEditGuestRecords.Click, btnCheckOut.Click
        ' "TURN OFF" OTHER TABS
        '
        btnExtendBooking.BackColor = Color.FromArgb(55, 71, 79)
        btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
        btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
        btnCheckOut.BackColor = Color.FromArgb(55, 71, 79)
        btnCheckIn.BackColor = Color.FromArgb(55, 71, 79)
        ' Tabs Switches
        '
        Select Case DirectCast(sender, Button).Name
                ' REGISTER GUEST
                '
            Case btnRegisterGuest.Name
                GuestInfoEntry.TopLevel = False
                pnlMainView.Controls.Add(GuestInfoEntry)
                GuestInfoEntry.Show()
                GuestInfoEntry.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 91)
                ' EDIT GUEST RECORDS
                '
            Case btnEditGuestRecords.Name
                GuestInfoEdit.TopLevel = False
                pnlMainView.Controls.Add(GuestInfoEdit)
                GuestInfoEdit.Show()
                GuestInfoEdit.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 167)
                ' CHECK IN
                '
            Case btnCheckIn.Name
                GboChaletMap.TopLevel = False
                pnlMainView.Controls.Add(GboChaletMap)
                GboChaletMap.Show()
                GboChaletMap.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 243)
                ' CHECK OUT
                '
            Case btnCheckOut.Name
                CheckOut.TopLevel = False
                pnlMainView.Controls.Add(CheckOut)
                CheckOut.Show()
                CheckOut.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 319)
                ' ADMIN INFO PANEL
                '
            Case btnExtendBooking.Name
                ExtendBooking.TopLevel = False
                pnlMainView.Controls.Add(ExtendBooking)
                ExtendBooking.Show()
                ExtendBooking.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 395)
        End Select
        pnlMenuStatic.BringToFront()
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' "TURN OFF" ALL TABS
        '
        btnExtendBooking.BackColor = Color.FromArgb(55, 71, 79)
        btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
        btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
        btnCheckIn.BackColor = Color.FromArgb(55, 71, 79)
        indSelectedTab.Visible = False
        GuestInfoEntry.Hide()
        GuestInfoEdit.Hide()
        CheckOut.Hide()
        GboChaletMap.Hide()
        ExtendBooking.Hide()
        pnlMenuStatic.BringToFront()
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If pnlMenu.Location = New Point(-155, 2) Then
            Do Until pnlMenu.Location.X = 0
                pnlMenu.Location = New Point(pnlMenu.Location.X + 1, 2)
            Loop
            'pnlMenu.Size = New Size(153, 481)
        ElseIf pnlMenu.Location = New Point(0, 2) Then
            'pnlMenu.Size = New Size(194, 481)
            Do Until pnlMenu.Location.X = -155
                pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
            Loop
        End If
    End Sub
    Private Sub pnlMenu_MouseLeave(sender As Object, e As EventArgs) Handles pnlMenu.MouseLeave
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub
    Private Sub StaffMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim regDate As Date = Date.Now()
        lblDay.Text = regDate.ToString("dd")
        lblMonth.Text = regDate.ToString("MMM").ToUpper
        lblYear.Text = regDate.ToString("yyyy")
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim answer As MsgBoxResult
        answer = MessageBox.Show("Logout?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = MsgBoxResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class