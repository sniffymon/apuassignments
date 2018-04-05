Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class GuestInfoEdit
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
    Dim sql As String
    Dim cmd As SqlCommand
    Dim idmemory As String
    Dim dr As SqlDataReader
    Dim updatechecker As Integer
    Private Sub GuestInfoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load guest into combobox
        conn.Open()
        sql = "SELECT Guest_ID_PassNum FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While (dr.Read())
                CboGuestID.Items.Add(dr(0))
            End While
        Else
            CboGuestID.Items.Add("No Existing Guests")
            CboGuestID.SelectedIndex = 0
        End If
        conn.Close()
    End Sub

    Private Sub CboGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGuestID.SelectedIndexChanged
        'If cboGuestID.Text = "" Then
        '    MessageBox.Show("Please select a guest information to edit", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        'GUEST DETAIL SECTION START
        sql = "SELECT GuestNo, Guest_Name, Guest_Contact_No, Guest_Email FROM GuestDetail WHERE 
[Guest_ID_PassNum]=@guestid"

        'Creating 1st Instance of SQL Command
        cmd = New SqlCommand(sql, conn)
        conn.Open()
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@guestid", CboGuestID.Text)
        dr = cmd.ExecuteReader

        If dr.Read() Then
            idmemory = dr(0)
            txtGuestName.Text = dr(1)
            txtGuestMobile.Text = dr(2)
            txtGuestEmail.Text = dr(3)
        End If
        conn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'update guestdetail

        sql = "UPDATE GuestDetail
               SET Guest_ID_PassNum = @ICnum, Guest_Name = @guestname, Guest_Contact_No = @contactnum, Guest_Email = @email
               WHERE GuestNo = @idmemory"
        'determine parameters
        If EmailCheck(txtGuestEmail.Text) = True Then
            cmd = New SqlCommand(sql, conn)
            conn.Open()
            cmd.Parameters.AddWithValue("@ICnum", CboGuestID.Text)
            cmd.Parameters.AddWithValue("@guestname", txtGuestName.Text)
            cmd.Parameters.AddWithValue("@contactnum", txtGuestMobile.Text)
            cmd.Parameters.AddWithValue("@email", txtGuestEmail.Text)
            cmd.Parameters.AddWithValue("@idmemory", idmemory)

            updatechecker = cmd.ExecuteNonQuery()
            If updatechecker = 1 Then
                MessageBox.Show("Guest record have been updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf updatechecker = 0 Then
                MessageBox.Show("error occured during update, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()
            'message box for invalid email
        ElseIf EmailCheck(txtGuestEmail.Text) = False Then
            MessageBox.Show("Invalid Email, please try again", "Invalid Email or GuestID", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGuestEmail.Focus()
            txtGuestEmail.BackColor = Color.AliceBlue
            Exit Sub
        End If
    End Sub

    Private Sub CboGuestID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboGuestID.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Function EmailCheck(ByVal emailaddress As String) As Boolean
        'email validation
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            EmailCheck = True
        Else
            EmailCheck = False
        End If
    End Function
End Class
