Imports System.Data.SqlClient
Public Class StaffMenuForm
    Dim conn As New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String
    Public contracheck As Integer = 0
    Public contrachalet, contraguestno As String
    Private Sub AdminMenuForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GuestInfoEdit.Close()
        CheckOut.Close()
        ExtendBooking.Close()
        CheckIn.Close()
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
                CheckIn.TopLevel = False
                pnlMainView.Controls.Add(CheckIn)
                CheckIn.Show()
                CheckIn.BringToFront()
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
        btnCheckOut.BackColor = Color.FromArgb(55, 71, 79)
        indSelectedTab.Visible = False
        GuestInfoEntry.Hide()
        GuestInfoEdit.Hide()
        CheckOut.Hide()
        CheckIn.Hide()
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

        sql = "SELECT DISTINCT r.GuestNo_FK, r.ChaletNumber_FK, r.CheckOut_Date FROM Reservation r, Reservation r2 WHERE (r.ChaletNumber_FK = r2.ChaletNumber_FK AND (r.CheckOut_Date = r2.CheckIn_Date) AND r.Reservation_Status = 'True' AND CONVERT(Date, GetDate()) = r.CheckOut_Date) OR (r.CheckOut_Date <= r2.CheckIn_Date AND r.Reservation_Status = 'True' AND CONVERT(Date,GetDate()) = r.CheckOut_Date)"
        conn.Open()

        cmd = New SqlCommand(sql, conn)

        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            btnCheckOut.ForeColor = Color.Red
            contracheck += 1
            contraguestno = (dr("GuestNo_FK"))
            contrachalet = (dr("ChaletNumber_FK"))
        End If
        conn.Close()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim answer As MsgBoxResult
        answer = MessageBox.Show("Logout?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = MsgBoxResult.Yes Then
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Public Sub RefreshForm(e As EventArgs)
        Me.Controls.Clear()
        InitializeComponent()
        StaffMenuForm_Load(e, e)
    End Sub
End Class