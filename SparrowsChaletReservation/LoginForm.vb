Imports System.Data.SqlClient
Public Class LoginForm
    Dim conn As SqlConnection
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    '
    ' LOGIN FUNCTIONS
    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sql As String

        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

        conn.Open()
        sql = "SELECT * FROM Users WHERE LoginUsername=@usrname AND Password=@pwd"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@usrname", txtUsn.Text)
        cmd.Parameters.AddWithValue("@pwd", txtPwd.Text)

        dr = cmd.ExecuteReader


        If dr.HasRows Then
            dr.Read()
            If dr("AdminRole") = "True" Then
                AdminMenuForm.Show()
            ElseIf dr("AdminRole") = "False" Then
                StaffMenuForm.Show()
            End If
            Me.Close()
        Else
            MessageBox.Show("Incorrect Username or Password. Please check your Username or Password")
        End If
        conn.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPwd.UseSystemPasswordChar = Not txtPwd.UseSystemPasswordChar
    End Sub

    Private Sub txtUsn_TextChanged(sender As Object, e As KeyEventArgs) Handles txtUsn.KeyDown, txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class
