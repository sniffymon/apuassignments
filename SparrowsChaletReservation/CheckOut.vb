Imports System.Data.SqlClient

Public Class CheckOut
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim cmd As SqlCommand
    Dim sql, guestnostorage As String
    Dim dr As SqlDataReader

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
        If cboGuestID.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'GUEST DETAIL SECTION START

        sql = "SELECT GuestNo,GuestDetail.Guest_Name,GuestDetail.Guest_Contact_No,GuestDetail.Guest_Email, CheckIn_Date , CheckOut_Date  
               FROM GuestDetail  Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
                WHERE [Guest_ID_PassNum]=@guestid"

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
        sql = "SELECT ChaletNumber_FK FROM Reservation WHERE GuestNo_FK=@guestno"

        Dim chaletds As New DataSet
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@guestno", guestnostorage)
        Dim adptr As New SqlDataAdapter(cmd)
        adptr.Fill(chaletds, "SpecifiedCH")

        Dim exdata As DataTable = chaletds.Tables("SpecifiedCH")
        Dim row As DataRow

        For Each ctrl As Control In Me.GroupBox2.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = False
            End If
        Next

        For Each row In exdata.Rows
            DirectCast(GroupBox2.Controls("btn" & row(0)), Button).Visible = True
        Next
        conn.Close()

        ' Get the current date.
        Dim thisDay As DateTime = DateTime.Today

        ' Display the date in the default (general) format.
        Console.WriteLine(thisDay.ToString())
        Console.WriteLine()
        txtActualCheckOut.Text = DateTime.Today

        'get the overdue days
        Dim date1 As Date = Date.Now
        Dim date2 As Date = txtCheckOut.Text
        Dim days As Integer = (date1 - date2).Days

        If (days <= 0) Then
            txtOverdue.Text = 0
        ElseIf (days >= 1) Then
            txtOverdue.Text = days
        End If
    End Sub

    Private Sub btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        If txtOverdue.Text = 0 Then
            CheckOutCart.ShowDialog()
        ElseIf txtOverdue.Text >= 1 Then
            MessageBox.Show("You will be charged RM XX each day due to .... ", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class