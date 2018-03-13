Public Class MainAppForm

    Private Sub MainAppForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GuestInfoEdit.Close()
        AdminChaletInfo.Close()
        SelectChaletForm.Close()
        GuestInfoEntry.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        btnCheckIn.BackColor = Color.FromArgb(55, 71, 79)
        btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
        btnCheckOut.BackColor = Color.FromArgb(55, 71, 79)
        btnSearchGuest.BackColor = Color.FromArgb(55, 71, 79)
        SelectChaletForm.Hide()
        GuestInfoEdit.Hide()
        GuestInfoEntry.Hide()
        AdminChaletInfo.Hide()
    End Sub

    Private Sub btnRegisterGuest_Click(sender As Object, e As EventArgs) Handles btnRegisterGuest.Click, btnCheckIn.Click, btnCheckOut.Click, btnSearchGuest.Click
        ' "TURN OFF" OTHER TABS
        '
        btnCheckIn.BackColor = Color.FromArgb(55, 71, 79)
        btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
        btnCheckOut.BackColor = Color.FromArgb(55, 71, 79)
        btnSearchGuest.BackColor = Color.FromArgb(55, 71, 79)
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
                indSelectedTab.Location = New Point(142, 116)
                ' EDIT CHALET RECORDS
                '
            Case btnSearchGuest.Name
                GuestInfoSearch.TopLevel = False
                pnlMainView.Controls.Add(GuestInfoSearch)
                GuestInfoSearch.Show()
                GuestInfoSearch.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(142, 291)
                ' EDIT GUEST RECORDS
                '
            Case btnCheckIn.Name
                CheckIn.TopLevel = False
                pnlMainView.Controls.Add(CheckIn)
                CheckIn.Show()
                CheckIn.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(142, 205)
                ' ADMIN INFO PANEL
                '
            Case btnCheckOut.Name
                CheckOut.TopLevel = False
                pnlMainView.Controls.Add(AdminChaletInfo)
                AdminChaletInfo.Show()
                AdminChaletInfo.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(142, 384)
        End Select
    End Sub
End Class