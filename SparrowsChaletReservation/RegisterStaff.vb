Imports System.Data.SqlClient

Public Class RegisterStaff
    'DECLARATIONS OF NEEDED VARIABLES
    '
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim sql As String
    Dim cmd As SqlCommand
    Dim registercheck As Integer


    'SUB FOR REGISTERING STAFF
    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'INPUT VALIDATION
        '
        If txtFullName.Text = "" Or txtCfmPwd.Text = "" Or txtPwd.Text = "" Then
            MessageBox.Show("Please fill in all needed information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullName.Focus()
            Exit Sub

        ElseIf txtPwd.Text <> txtCfmPwd.Text Then
            MessageBox.Show("Password does not match Confirm Password, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPwd.Select()
            Exit Sub
        End If

        'LOCAL VARIABLES FOR USERNAME GENERATION
        '
        Dim threeinitials As String
        threeinitials = txtFullName.Text
        threeinitials = threeinitials.Replace(" ", "")
        Dim initialarray() As String = txtFullName.Text.Split(" "c)
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer


        'USERNAME GENERATION
        '
        If initialarray.Count >= 3 Then
            lblUsrName.Text = (initialarray(0).Chars(0) + initialarray(1).Chars(0) + initialarray(2).Chars(0)).ToUpper
        ElseIf initialarray.Count = 2 Then
            lblUsrName.Text = (threeinitials.Substring(0, 2) + initialarray(1).Chars(0)).ToUpper
        ElseIf txtFullName.TextLength < 3 Then
            MessageBox.Show("Name is too short to generate Login Username. Please try again by inserting your fullname as per IC", "Name too short", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullName.Select()
            Exit Sub
        ElseIf initialarray.Count = 1 Then
            lblUsrName.Text = (initialarray(0).Chars(0) + initialarray(0).Chars(1) + initialarray(0).Chars(2)).ToUpper
        End If

        'CHECK FOR EXISTING USERNAME TO AVOID SAME USERNAME IN DATABASE
        '
        For i = 0 To 2
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            Else
                conn.Open()
            End If

            sql = "SELECT LoginUsername FROM Users"
            Dim chaletds As New DataSet
            cmd = New SqlCommand(sql, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(chaletds, "LoginUsername")
            Dim stafftable As DataTable = chaletds.Tables("LoginUsername")
            Dim row As DataRow

            'GENERATE ANOTHER USERNAME
            '
            For Each row In stafftable.Rows

                'CHECK FOR 1 WORD NAME CONDITION
                '
                If initialarray.Count = 1 Then
                    If row(0) = lblUsrName.Text And threeinitials.Length > x + 3 Then
                        lblUsrName.Text = (threeinitials.Substring(0, 2) + threeinitials.Substring(x + 3, 1)).ToUpper
                        x += 1
                        i = 0
                    ElseIf row(0) = lblUsrName.Text And threeinitials.Length = x + 3 Then
                        MessageBox.Show("System Failure, unable to generate username, please consult admin", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCfmPwd.Text = ""
                        txtFullName.Text = ""
                        lblUsrName.Text = "this field is auto generated"
                        txtPwd.Text = ""
                        threeinitials = ""
                        x = 0
                        y = 0
                        z = 0
                        conn.Close()
                        Exit Sub
                    End If
                End If

                'CHECK FOR 2 WORD NAME CONDITION
                '
                If initialarray.Count = 2 Then
                    If row(0) = lblUsrName.Text And initialarray(1).Length > y + 1 Then
                        lblUsrName.Text = (threeinitials.Substring(0, 2) + initialarray(1).Chars(y + 1)).ToUpper
                        y += 1
                        i = 0
                    ElseIf row(0) = lblUsrName.Text And initialarray(1).Length = y + 1 And initialarray(0).Length > x + 2 Then
                        lblUsrName.Text = (threeinitials.Substring(0, 2) + initialarray(0).Substring(x + 2, 1)).ToUpper
                        x += 1
                        i = 0
                    ElseIf row(0) = lblUsrName.Text And initialarray(0).Length = x + 2 Then
                        MessageBox.Show("System Failure, unable to generate username, please consult admin", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCfmPwd.Text = ""
                        txtFullName.Text = ""
                        lblUsrName.Text = "this field is auto generated"
                        txtPwd.Text = ""
                        threeinitials = ""
                        x = 0
                        y = 0
                        z = 0
                        conn.Close()
                        Exit Sub
                    End If
                End If

                'CHECK FOR 3 WORD OR ABOVE NAME CONDITION
                '
                If initialarray.Count >= 3 Then
                    If row(0) = lblUsrName.Text And initialarray(2).Length > z + 1 Then
                        lblUsrName.Text = (initialarray(0).Chars(0) + initialarray(1).Chars(0) + initialarray(2).Chars(z + 1)).ToUpper
                        z += 1
                        i = 0
                    ElseIf row(0) = lblUsrName.Text And initialarray(2).Length = z + 1 And initialarray(1).Length > y Then
                        lblUsrName.Text = (initialarray(0).Chars(0) + initialarray(0).Chars(1) + initialarray(1).Chars(y)).ToUpper
                        y += 1
                        i = 0
                    ElseIf row(0) = lblUsrName.Text And initialarray(1).Length = y And initialarray(0).Length > x + 2 Then
                        lblUsrName.Text = (threeinitials.Substring(0, 2) + initialarray(0).Substring(x + 2, 1)).ToUpper
                        x += 1
                        i = 0
                    ElseIf row(0) = lblUsrName.Text And initialarray(0).Length = x + 2 Then
                        MessageBox.Show("System Failure, unable to generate username, please consult admin", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCfmPwd.Text = ""
                        txtFullName.Text = ""
                        lblUsrName.Text = "this field is auto generated"
                        txtPwd.Text = ""
                        threeinitials = ""
                        x = 0
                        y = 0
                        z = 0
                        conn.Close()
                        Exit Sub
                    End If
                End If
            Next
            conn.Close()
        Next

        'INSERT STAFF DATA INTO DATABASE
        '
        conn.Open()
        sql = "INSERT INTO Users(UserFullName, Password, LoginUsername, AdminRole) VALUES(@staffname, @staffpwd, @staffusrname, @adminrole)"
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@staffname", txtFullName.Text)
        cmd.Parameters.AddWithValue("@staffpwd", txtPwd.Text)
        cmd.Parameters.AddWithValue("@staffusrname", lblUsrName.Text)
        cmd.Parameters.AddWithValue("@adminrole", "False")
        registercheck = cmd.ExecuteNonQuery()

        'CHECK FOR SUCCESSFULL REGISTRATION
        '
        If registercheck = 1 Then
            MessageBox.Show("Staff Info Successfully Stored", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCfmPwd.Text = ""
            txtFullName.Text = ""
            lblUsrName.Text = "this field is auto generated"
            txtPwd.Text = ""
            z = 0
        ElseIf registercheck = 0 Then
            MessageBox.Show("Unexpected error occured during registration. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
    End Sub

    'ENABLE ENTER BUTTON TO LOG IN 
    '
    Private Sub txtFullName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPwd.KeyDown, txtCfmPwd.KeyDown, txtFullName.KeyDown, CheckBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    'FOCUS POINTER TO PASSWORD TEXTBOX
    '
    Private Sub txtFullName_Leave(sender As Object, e As EventArgs) Handles txtFullName.Leave
        txtPwd.Focus()
    End Sub

    'MASK & UNMASK BOTH PASSWORD TEXTBOXES
    '
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPwd.UseSystemPasswordChar = Not txtPwd.UseSystemPasswordChar
        txtCfmPwd.UseSystemPasswordChar = Not txtCfmPwd.UseSystemPasswordChar
    End Sub
End Class
