Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class GuestInfoEntry
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
    Dim Sql As String
    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtGuestID.Text = "" Or txtGuestName.Text = "" Or txtGuestEmail.Text = "" Or txtGuestMobile.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Guest Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        conn.Open()
        'GUEST DETAIL SECTION START
        Sql = "INSERT INTO GuestDetail(Guest_ID_PassNum, Guest_Name, Guest_Contact_No, Guest_Email) VALUES(@guestid, @guestname, @guestmobile, @guestemail)"
        If EmailCheck(txtGuestEmail.Text) = True Then
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
            conn.Close()

        ElseIf EmailCheck(txtGuestEmail.Text) = False Then
            MessageBox.Show("Invalid Email, please try again", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuestEmail.Focus()
            txtGuestEmail.BackColor = Color.AliceBlue
            Exit Sub
        End If


    End Sub
    Function EmailCheck(ByVal emailaddress As String) As Boolean

        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            EmailCheck = True
        Else
            EmailCheck = False
        End If
    End Function
    Private Sub txtGuestID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGuestEmail.KeyDown, txtGuestEmail.KeyDown, txtGuestMobile.KeyDown, txtGuestName.KeyDown, txtGuestID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class