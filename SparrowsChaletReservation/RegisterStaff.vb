Imports System.Data.SqlClient

Public Class RegisterStaff
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
    Dim sql As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim registercheck As Integer
    Dim threeinitials As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If txtFullName.Text = "" Or txtUsrName.Text = "" Or txtCfmPwd.Text = "" Or txtPwd.Text = "" Then
            MessageBox.Show("Please fill in all needed information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullName.Focus()
            Exit Sub

        ElseIf txtPwd.Text <> txtCfmPwd.Text Then
            MessageBox.Show("Password does not match Confirm Password, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPwd.Select()
            Exit Sub
        ElseIf txtFullName.TextLength < 3 Then
            MessageBox.Show("Name is too short to generate Login Username. Please try again by inserting your fullname as per IC", "Name too short", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullName.Select()
            Exit Sub
        End If

        conn.Open()
        sql = "INSERT INTO Users(UserFullName, Password, LoginUsername, AdminRole) VALUES(@staffname, @staffpwd, @staffusrname, @adminrole)"
        cmd = New SqlCommand(sql, conn)
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@staffname", txtFullName.Text)
        cmd.Parameters.AddWithValue("@staffpwd", txtPwd.Text)
        cmd.Parameters.AddWithValue("@staffusrname", txtUsrName.Text)
        cmd.Parameters.AddWithValue("@adminrole", "False")
        'Execute SQL Query above and expecting no return
        registercheck = cmd.ExecuteNonQuery()

        If registercheck = 1 Then
            MessageBox.Show("Guest Info Successfully Stored", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsrName.Text = "*This field is auto generated*"
        ElseIf registercheck = 0 Then
            MessageBox.Show("Unexpected error occured during registration. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
    End Sub

    Private Sub txtFullName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPwd.KeyDown, txtCfmPwd.KeyDown, txtFullName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        If txtFullName.TextLength < 3 Then Exit Sub
        Dim i As Integer = 3
        threeinitials = txtFullName.Text
        txtUsrName.Text = threeinitials.Substring(0, 3)

        conn.Open()
        sql = "SELECT * FROM Users WHERE LoginUsername = @staffusername"
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@staffusername", txtUsrName.Text)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            txtUsrName.Text = threeinitials.Substring(0, 2) & threeinitials.Substring(i, 1)
            MsgBox("Stupid")
        End If
        dr.Close()
        conn.Close()

    End Sub
End Class