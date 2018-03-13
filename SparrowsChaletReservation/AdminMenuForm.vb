Public Class AdminMenuForm
    Private Sub AdminMenuForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GuestInfoEdit.Close()
        AdminChaletInfo.Close()
        SelectChaletForm.Close()
        GuestInfoEntry.Close()
    End Sub

    Private Sub btnRegisterGuest_Click(sender As Object, e As EventArgs) Handles btnRegisterGuest.Click, btnAdminInfoPanel.Click, btnEditChaletRecords.Click, btnEditGuestRecords.Click
        ' "TURN OFF" OTHER TABS
        '
        btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
        btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
        btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
        btnEditChaletRecords.BackColor = Color.FromArgb(55, 71, 79)
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
            Case btnEditChaletRecords.Name
                SelectChaletForm.TopLevel = False
                pnlMainView.Controls.Add(SelectChaletForm)
                SelectChaletForm.Show()
                SelectChaletForm.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(142, 291)
                ' EDIT GUEST RECORDS
                '
            Case btnEditGuestRecords.Name
                GuestInfoEdit.TopLevel = False
                pnlMainView.Controls.Add(GuestInfoEdit)
                GuestInfoEdit.Show()
                GuestInfoEdit.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(142, 205)
                ' ADMIN INFO PANEL
                '
            Case btnAdminInfoPanel.Name
                AdminChaletInfo.TopLevel = False
                pnlMainView.Controls.Add(AdminChaletInfo)
                AdminChaletInfo.Show()
                AdminChaletInfo.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(142, 384)
        End Select

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' "TURN OFF" ALL TABS
        '
        btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
        btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
        btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
        btnEditChaletRecords.BackColor = Color.FromArgb(55, 71, 79)
        indSelectedTab.Visible = False
        SelectChaletForm.Hide()
        GuestInfoEdit.Hide()
        GuestInfoEntry.Hide()
        AdminChaletInfo.Hide()
    End Sub
End Class