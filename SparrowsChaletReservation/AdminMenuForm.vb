Public Class AdminMenuForm
    Dim adminchaletinfobool As Boolean = False
    Dim selectchaletformbool As Boolean = False
    Dim guestinfoeditbool As Boolean = False
    Dim guestinfoentrybool As Boolean = False
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnEditGuestRecords.Click
        GuestInfoEdit.TopLevel = False
        Me.pnlMainView.Controls.Add(GuestInfoEdit)
        'Check for other tabs
        If selectchaletformbool = True Or adminchaletinfobool = True Or guestinfoentrybool = True Then
            'Code to turn off other tabs
            '
            selectchaletformbool = False
            adminchaletinfobool = False
            guestinfoentrybool = False
            btnEditChaletRecords.BackColor = Color.FromArgb(55, 71, 79)
            btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
            btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
            SelectChaletForm.Close()
            AdminChaletInfo.Close()
            GuestInfoEntry.Close()
            'Code to turn on clicked tab
            '
            btnEditGuestRecords.BackColor = Color.FromArgb(50, 50, 50)
            guestinfoeditbool = True
            GuestInfoEdit.Show()
        ElseIf guestinfoeditbool = False Then
            'Turn on clicked tab when operation is fresh
            '
            btnEditGuestRecords.BackColor = Color.FromArgb(50, 50, 50)
            guestinfoeditbool = True
            GuestInfoEdit.Show()
        ElseIf guestinfoeditbool = True Then
            'Turn off clicked tab
            '
            btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
            guestinfoeditbool = False
            GuestInfoEdit.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdminInfoPanel.Click
        AdminChaletInfo.TopLevel = False
        Me.pnlMainView.Controls.Add(AdminChaletInfo)
        'Check for other tabs
        If selectchaletformbool = True Or guestinfoeditbool = True Or guestinfoentrybool = True Then
            'Code to turn off other tabs
            '
            selectchaletformbool = False
            guestinfoeditbool = False
            guestinfoentrybool = False
            btnEditChaletRecords.BackColor = Color.FromArgb(55, 71, 79)
            btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
            btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
            SelectChaletForm.Close()
            GuestInfoEdit.Close()
            GuestInfoEntry.Close()
            'Code to turn on clicked tab
            '
            btnAdminInfoPanel.BackColor = Color.FromArgb(50, 50, 50)
            adminchaletinfobool = True
            AdminChaletInfo.Show()
        ElseIf adminchaletinfobool = False Then
            'Turn on clicked tab when operation is fresh
            '
            btnAdminInfoPanel.BackColor = Color.FromArgb(50, 50, 50)
            adminchaletinfobool = True
            AdminChaletInfo.Show()
        ElseIf adminchaletinfobool = True Then
            'Turn off clicked tab
            '
            btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
            adminchaletinfobool = False
            AdminChaletInfo.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEditChaletRecords.Click
        SelectChaletForm.TopLevel = False
        Me.pnlMainView.Controls.Add(SelectChaletForm)
        If adminchaletinfobool = True Or guestinfoeditbool = True Or guestinfoentrybool = True Then
            'Code to turn off other tabs
            '
            adminchaletinfobool = False
            guestinfoeditbool = False
            guestinfoentrybool = False
            btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
            btnRegisterGuest.BackColor = Color.FromArgb(55, 71, 79)
            btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
            AdminChaletInfo.Close()
            GuestInfoEdit.Close()
            GuestInfoEntry.Close()
            'Code to turn on clicked tab
            '
            btnEditChaletRecords.BackColor = Color.FromArgb(50, 50, 50)
            selectchaletformbool = True
            SelectChaletForm.Show()
        ElseIf selectchaletformbool = False Then
            btnEditChaletRecords.BackColor = Color.FromArgb(50, 50, 50)
            selectchaletformbool = True
            SelectChaletForm.Show()
        ElseIf selectchaletformbool = True Then
            btnEditChaletRecords.BackColor = Color.FromArgb(55, 71, 79)
            selectchaletformbool = False
            SelectChaletForm.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRegisterGuest.Click
        GuestInfoEntry.TopLevel = False
        Me.pnlMainView.Controls.Add(GuestInfoEntry)
        'Check for other tabs
        If selectchaletformbool = True Or guestinfoeditbool = True Or adminchaletinfobool = True Then
            'Code to turn off other tabs
            '
            selectchaletformbool = False
            guestinfoeditbool = False
            adminchaletinfobool = False
            btnEditChaletRecords.BackColor = Color.FromArgb(55, 71, 79)
            btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
            btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
            SelectChaletForm.Close()
            GuestInfoEdit.Close()
            AdminChaletInfo.Close()
            'Code to turn on clicked tab
            '
            btnRegisterGuest.BackColor = Color.FromArgb(50, 50, 50)
            guestinfoentrybool = True
            GuestInfoEntry.Show()
        ElseIf guestinfoentrybool = False Then
            'Turn on clicked tab when operation is fresh
            '
            btnRegisterGuest.BackColor = Color.FromArgb(50, 50, 50)
            guestinfoentrybool = True
            GuestInfoEntry.Show()
        ElseIf guestinfoentrybool = True Then
            'Turn off clicked tab
            '
            btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
            guestinfoentrybool = False
            GuestInfoEntry.Close()
        End If
    End Sub

    Private Sub AdminMenuForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GuestInfoEdit.Close()
        AdminChaletInfo.Close()
        SelectChaletForm.Close()
        GuestInfoEntry.Close()
    End Sub
End Class