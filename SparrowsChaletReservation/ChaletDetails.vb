Imports System.Data.SqlClient
Public Class ChaletDetails
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String
    Private Sub ChaletDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()
        sql = "SELECT GuestDetail.Guest_Name FROM GuestDetail INNER JOIN Reservation ON GuestDetail.GuestNo=Reservation.GuestNo_FK
               WHERE ChaletNumber_FK = @clickedchaletCH"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        dr = cmd.ExecuteReader

        Label1.Text = AdminChaletInfo.clickedchalet
        If dr.Read() Then
            txtGuestName.Text = dr(0).ToString
        End If
        conn.Close()
    End Sub
End Class