Public Class AdminMenuForm
    Private Sub AdminMenuForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' FORCE CLOSE OTHER FORMS TO ENSURE THAT IT WILL NOT CONTINUE TO RUN IN BACKGROUND
        '
        GuestInfoEdit.Close()
        AdminChaletInfo.Close()
        OccupancyReportForm.Close()
        RegisterStaff.Close()
    End Sub
    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click, btnAdminInfoPanel.Click, btnEditGuestRecords.Click, btnOccupancyReport.Click
        ' "TURN OFF" OTHER TABS
        '
        btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
        btnAddStaff.BackColor = Color.FromArgb(55, 71, 79)
        btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
        btnOccupancyReport.BackColor = Color.FromArgb(55, 71, 79)
        ' Tabs Switches
        '
        Select Case DirectCast(sender, Button).Name
            ' REGISTER GUEST
            '
            Case btnAddStaff.Name
                RegisterStaff.TopLevel = False
                pnlMainView.Controls.Add(RegisterStaff)
                RegisterStaff.Show()
                RegisterStaff.BringToFront()
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
                indSelectedTab.Location = New Point(192, 185)
                ' ADMIN INFO PANEL
                '
            Case btnAdminInfoPanel.Name
                AdminChaletInfo.TopLevel = False
                pnlMainView.Controls.Add(AdminChaletInfo)
                AdminChaletInfo.Show()
                AdminChaletInfo.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 281)
                ' OCCUPANCY REPORT
                '
            Case btnOccupancyReport.Name
                OccupancyReportForm.TopLevel = False
                pnlMainView.Controls.Add(OccupancyReportForm)
                OccupancyReportForm.Show()
                OccupancyReportForm.BringToFront()
                sender.BackColor = Color.FromArgb(50, 50, 50)
                indSelectedTab.Visible = True
                indSelectedTab.Location = New Point(192, 377)
        End Select
        pnlMenuStatic.BringToFront()
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' "TURN OFF" ALL TABS
        '
        btnAdminInfoPanel.BackColor = Color.FromArgb(55, 71, 79)
        btnAddStaff.BackColor = Color.FromArgb(55, 71, 79)
        btnEditGuestRecords.BackColor = Color.FromArgb(55, 71, 79)
        btnOccupancyReport.BackColor = Color.FromArgb(55, 71, 79)
        indSelectedTab.Visible = False
        OccupancyReportForm.Hide()
        GuestInfoEdit.Hide()
        RegisterStaff.Hide()
        AdminChaletInfo.Hide()
        pnlMenuStatic.BringToFront()
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox3.Click
        ' ANIMATE PANEL SLIDING BY INCREMENTING OR DECREMENTING PANEL X-COORDINATES BY 1
        '
        If pnlMenu.Location = New Point(-155, 2) Then
            Do Until pnlMenu.Location.X = 0
                pnlMenu.Location = New Point(pnlMenu.Location.X + 1, 2)
            Loop
        ElseIf pnlMenu.Location = New Point(0, 2) Then
            Do Until pnlMenu.Location.X = -155
                pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
            Loop
        End If
    End Sub
    Private Sub pnlMenu_MouseLeave(sender As Object, e As EventArgs) Handles pnlMenu.MouseLeave
        ' ENSURE PANEL CLOSING WHEN MOUSE LEAVE
        '
        Do Until pnlMenu.Location.X = -155
            pnlMenu.Location = New Point(pnlMenu.Location.X - 1, 2)
        Loop
    End Sub

    Private Sub AdminMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LOAD SYSTEM DATE INTO SYSTEM CALENDAR
        '
        Dim regDate As Date = Date.Now()
        lblDay.Text = regDate.ToString("dd")
        lblMonth.Text = regDate.ToString("MMM").ToUpper
        lblYear.Text = regDate.ToString("yyyy")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'LOGOUT
        '
        Dim answer As MsgBoxResult
        answer = MessageBox.Show("Logout?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = MsgBoxResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class