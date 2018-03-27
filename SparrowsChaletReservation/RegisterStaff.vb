Imports System.Data.SqlClient

Public Class RegisterStaff
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
    Dim sql As String
    Dim cmd As SqlCommand
    Dim registercheck As Integer
    Dim threeinitials As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtFullName.Text = "" Or txtCfmPwd.Text = "" Or txtPwd.Text = "" Then
            MessageBox.Show("Please fill in all needed information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullName.Focus()
            Exit Sub

        ElseIf txtPwd.Text <> txtCfmPwd.Text Then
            MessageBox.Show("Password does not match Confirm Password, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPwd.Select()
            Exit Sub
        End If

        If txtFullName.TextLength >= 3 Then
            Dim initialarray() As String = txtFullName.Text.Split(" "c)
            lblUsrName.Text = String.Join("", Array.ConvertAll(initialarray, Function(n) n.Substring(0, 1).ToUpper))

            conn.Open()

            sql = "SELECT LoginUsername FROM Users"
            Dim chaletds As New DataSet
            cmd = New SqlCommand(sql, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(chaletds, "Username")

            Dim stafftable As DataTable = chaletds.Tables("Username")
            Dim row As DataRow
            For Each row In stafftable.Rows
                If row(0) = lblUsrName.Text Then
                    MessageBox.Show("Username already taken. New Username will be generated.", "Username already taken", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    threeinitials = txtFullName.Text
                    threeinitials = threeinitials.Replace(" ", "")
                    lblUsrName.Text = (threeinitials.Substring(0, 3)).ToUpper
                End If
            Next
            conn.Close()

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
        cmd.Parameters.AddWithValue("@staffusrname", lblUsrName.Text)
        cmd.Parameters.AddWithValue("@adminrole", "False")
        'Execute SQL Query above and expecting no return
        registercheck = cmd.ExecuteNonQuery()

        If registercheck = 1 Then
            MessageBox.Show("Guest Info Successfully Stored", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf registercheck = 0 Then
            MessageBox.Show("Unexpected error occured during registration. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
    End Sub

    Private Sub txtFullName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPwd.KeyDown, txtCfmPwd.KeyDown, txtFullName.KeyDown, CheckBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub txtFullName_Leave(sender As Object, e As EventArgs) Handles txtFullName.Leave
        txtPwd.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPwd.UseSystemPasswordChar = Not txtPwd.UseSystemPasswordChar
        txtCfmPwd.UseSystemPasswordChar = Not txtCfmPwd.UseSystemPasswordChar
    End Sub
End Class