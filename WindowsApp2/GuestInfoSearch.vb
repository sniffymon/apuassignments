Imports System.Data.SqlClient
Public Class GuestInfoSearch
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GuestInfoSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'Start Loading For Guest ID In Search ComboBox
        '
        conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

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
        conn.Close()
    End Sub

    Private Sub cboGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGuestID.SelectedIndexChanged
        If cboGuestID.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")


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
    End Sub
End Class