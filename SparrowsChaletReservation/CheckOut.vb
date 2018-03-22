Imports System.Data.SqlClient

Public Class CheckOut
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim cmd As SqlCommand
    Public sql, guestnostorage As String
    Public checkedchalet As New List(Of String)
    Dim dr As SqlDataReader
    Public ChaletTotal, ChaletDeposit, dayduration As Double

    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        sql = "SELECT Guest_ID_PassNum FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.HasRows Then
            While (dr.Read())
                cboGuestID.Items.Add(dr(0))
            End While
        Else
            cboGuestID.Items.Add("No Existing Guests")
        End If
        dr.Close()
        conn.Close()


    End Sub
    Private Sub cboGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGuestID.SelectedIndexChanged
        'If cboGuestID.Text = "" Then
        '    MessageBox.Show("Please enter all needed information into the textboxes", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'GUEST DETAIL SECTION START

        sql = "SELECT GuestNo,GuestDetail.Guest_Name,GuestDetail.Guest_Contact_No,GuestDetail.Guest_Email, CONVERT(Varchar, CheckIn_Date) ,CONVERT(Varchar, CheckOut_Date)  
               FROM GuestDetail  Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
                WHERE [Guest_ID_PassNum]=@guestid "


        'Creating 1st Instance of SQL Command
        cmd = New SqlCommand(sql, conn)
        conn.Open()
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@guestid", cboGuestID.Text)


        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.Read() Then
            guestnostorage = dr(0)
            txtGuestName.Text = dr(1)
            txtGuestMobile.Text = dr(2)
            txtGuestEmail.Text = dr(3)
            txtCheckIn.Text = dr(4).ToString
            txtCheckOut.Text = dr(5).ToString
        End If

        dr.Close()
        conn.Close()

        'chalet booked by guest
        sql = "SELECT ChaletNumber_FK FROM Reservation WHERE GuestNo_FK=@guestno AND @currentdate >= Checkout_Date"

        Dim chaletds As New DataSet
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@guestno", guestnostorage)
        cmd.Parameters.AddWithValue("@currentdate", Date.Today)
        Dim adptr As New SqlDataAdapter(cmd)
        adptr.Fill(chaletds, "SpecifiedCH")

        Dim exdata As DataTable = chaletds.Tables("SpecifiedCH")
        Dim row As DataRow

        For Each ctrl As Control In Me.GroupBox2.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = False
            End If
        Next

        If exdata.Rows.Count > 0 Then
            For Each row In exdata.Rows
                checkedchalet.Add("btn" & row(0))

                DirectCast(GroupBox2.Controls("btn" & row(0)), Button).Visible = True
            Next
        Else
            MsgBox("There are no checkout details today!")
        End If
        conn.Close()

        ' Get the current date.
        Dim thisDay As DateTime = DateTime.Today

        ' Display the date in the default (general) format.
        Console.WriteLine(thisDay.ToString())
        Console.WriteLine()
        txtActualCheckOut.Text = DateTime.Today.ToString("yyyy-MM-dd")

        'get the overdue days
        Dim date1 As Date = Date.Now
        Dim date2 As Date = txtCheckOut.Text
        Dim days As Integer = (date1 - date2).Days

        If (days <= 0) Then
            txtOverdue.Text = 0
        ElseIf (days >= 1) Then
            txtOverdue.Text = days
        End If

        Dim StartTime, EndTime As DateTime
        Dim TimeSpan As TimeSpan
        StartTime = txtCheckIn.Text
        EndTime = txtActualCheckOut.Text
        TimeSpan = EndTime.Subtract(StartTime)
        dayduration = TimeSpan.Days
        lblNightsStay.Text = dayduration
    End Sub

    Private Sub btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        If txtOverdue.Text = 0 Then
            CheckOutCart.ShowDialog()
        ElseIf txtOverdue.Text >= 1 Then
            MessageBox.Show("You will be charged RM 50 for Supreme Room and RM100 for Standard Room each day due to Late CheckOut ", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckOutCart.ShowDialog()
        End If
    End Sub

End Class