Imports System.Data.SqlClient
Public Class GuestInfoEntry
    Dim conn As SqlConnection
    Dim Sql As String
    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtGuestID.Text = "" Or txtGuestName.Text = "" Or txtGuestEmail.Text = "" Or txtGuestMobile.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")

        conn.Open()
        'GUEST DETAIL SECTION START
        Sql = "INSERT INTO GuestDetail(Guest_ID_PassNum, Guest_Name, Guest_Contact_No, Guest_Email) VALUES(@guestid, @guestname, @guestmobile, @guestemail)"

        'Creating 1st Instance of SQL Command
        cmd = New SqlCommand(Sql, conn)
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@guestid", txtGuestID.Text)
        cmd.Parameters.AddWithValue("@guestemail", txtGuestEmail.Text)
        cmd.Parameters.AddWithValue("@guestmobile", txtGuestMobile.Text)
        cmd.Parameters.AddWithValue("@guestname", txtGuestName.Text)
        'Execute SQL Query above and expecting no return
        cmd.ExecuteNonQuery()
        MsgBox("Guest Info Successfully Stored")
        'GUEST DETAIL SECTION END
    End Sub
End Class