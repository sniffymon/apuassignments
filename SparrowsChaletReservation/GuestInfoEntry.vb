Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class GuestInfoEntry
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
    Dim Sql As String
    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If String.IsNullOrWhiteSpace(txtGuestName.Text) Or txtGuestID.Text = "" Or txtGuestEmail.Text = "" Or txtGuestMobile.Text = "" Then
            MessageBox.Show("Please check that you've entered all needed and valid information into the textboxes", "Guest Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub txtGuestID_KeyDown(sender As Object, e As KeyEventArgs) Handles  txtGuestEmail.KeyDown, txtGuestMobile.KeyDown, txtGuestID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnRegister.PerformClick()
        End If
    End Sub


    Private Sub txtGuestID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuestID.KeyPress, txtGuestEmail.KeyPress, txtGuestMobile.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class