Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class GuestInfoEdit
    Dim conn As SqlConnection
    Dim sql As String
    Dim cmd As SqlCommand
    Dim idmemory As String
    Private Sub GuestInfoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'Start Loading For Guest ID In Search ComboBox
        '
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

        conn.Open()

        sql = "SELECT Guest_ID_PassNum FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)


        Dim dr As SqlDataReader = cmd.ExecuteReader
        Dim guestcombotb As New DataTable

        If dr.HasRows Then
            While (dr.Read())
                cboGuestID.Items.Add(dr(0))
            End While
        Else
            cboGuestID.Items.Add("No Existing Guests")
        End If
        conn.Close()
    End Sub

    Private Sub cboGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGuestID.SelectedIndexChanged
        If cboGuestID.Text = "" Then
            MessageBox.Show("Please select a guest information to edit", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        idmemory = cboGuestID.Text
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")


        'GUEST DETAIL SECTION START

        sql = "SELECT Guest_Name, Guest_Contact_No, Guest_Email FROM GuestDetail WHERE 
[Guest_ID_PassNum]=@guestid"

        'Creating 1st Instance of SQL Command
        cmd = New SqlCommand(sql, conn)
        conn.Open()
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@guestid", cboGuestID.Text)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.Read() Then
            txtGuestName.Text = dr(0)
            txtGuestMobile.Text = dr(1)
            txtGuestEmail.Text = dr(2)
        End If
        conn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If EmailCheck(txtGuestEmail.Text) = False Then
            MessageBox.Show("Invalid Email")
            txtGuestEmail.Focus()
            txtGuestEmail.BackColor = Color.AliceBlue
            Exit Sub
        ElseIf txtGuestEmail.Text = "" Or txtGuestMobile.Text = "" Or txtGuestName.Text = "" Then
            MessageBox.Show("Please complete all the field.")
            Exit Sub
        End If

        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

        conn.Open()
        'GUEST DETAIL SECTION START
        sql = "UPDATE INTO GuestDetail(Guest_Name, Guest_Contact_No, Guest_Email) VALUES(@guestname, @guestmobile, @guestemail)"

        'Creating 1st Instance of SQL Command
        cmd = New SqlCommand(sql, conn)
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@guestemail", txtGuestEmail.Text)
        cmd.Parameters.AddWithValue("@guestmobile", txtGuestMobile.Text)
        cmd.Parameters.AddWithValue("@guestname", txtGuestName.Text)
        'Execute SQL Query above and expecting no return
        cmd.ExecuteNonQuery()

        MessageBox.Show("Update Successfully", "Guest Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

       Function EmailCheck(ByVal emailaddress As String) As Boolean

        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailcheck = True
        Else
            emailcheck = False
        End If
    End Function



    Private Sub TxtGuestName_KeyDown(sender As Object, e As KeyEventArgs) Handles cboGuestID.KeyDown, txtGuestName.KeyDown, txtGuestEmail.KeyDown

        If e.KeyCode = Keys.Enter Then

            Button1.PerformClick()
        End If
    End Sub
End Class