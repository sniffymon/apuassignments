Imports System.Data.SqlClient

Public Class LoginForm
    ' DECLARATION OF NEEDED VARIABLES
    '
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim sql As String

    'SUB FOR LOGGING IN 
    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn.Open()
        sql = "SELECT * FROM Users WHERE LoginUsername=@usrname AND Password=@pwd"
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@usrname", txtUsn.Text)
        cmd.Parameters.AddWithValue("@pwd", txtPwd.Text)
        dr = cmd.ExecuteReader

        'INPUT VALIDATION & ROLE CHECK
        '
        If txtUsn.Text = "" Or txtPwd.Text = "" Then
            MessageBox.Show("Please fill in the required details.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsn.Focus()
        ElseIf dr.HasRows Then
            dr.Read()
            If dr("AdminRole") = "True" Then
                AdminMenuForm.Show()
                Me.Close()
            ElseIf dr("AdminRole") = "False" Then
                StaffMenuForm.Show()
            End If
            Me.Close()
        Else
            MessageBox.Show("Incorrect Username or Password. Please check your Username or Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsn.Focus()
        End If
        conn.Close()
    End Sub

    'MASK AND UNMASK PASSWORD
    '
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPwd.UseSystemPasswordChar = Not txtPwd.UseSystemPasswordChar
    End Sub

    'ENABLE ENTER BUTTON TO LOG IN
    '
    Private Sub txtUsn_TextChanged(sender As Object, e As KeyEventArgs) Handles txtUsn.KeyDown, txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class
