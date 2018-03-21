Imports System.Data.SqlClient
Public Class ChaletDetails
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim firstsql As String
    Dim secondsql As String
    Private Sub ChaletDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
        conn.Open()
        firstsql = "SELECT Guest_Name FROM GuestDetail INNER JOIN Reservation ON GuestDetail.GuestNo=Reservation.GuestNo_FK
               WHERE ChaletNumber_FK = @clickedchaletCH"
        secondsql = "SELECT Cast(CheckIn_Date AS Varchar), Cast(CheckOut_Date AS Varchar), ExtraBed FROM Reservation WHERE ChaletNumber_FK = @clickedchaletCH"

        cmd = New SqlCommand(firstsql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        dr = cmd.ExecuteReader

        Label1.Text = AdminChaletInfo.clickedchalet
        If dr.Read() Then
            txtGuestName.Text = dr(0).ToString
            conn.Close()
        End If

        cmd = New SqlCommand(secondsql, conn)
        conn.Open()
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        dr = cmd.ExecuteReader

        If dr.Read() Then

            txtCheckIn.Text = dr(0).ToString
            txtCheckOut.Text = dr(1).ToString
            txtEB.Text = dr(2).ToString
            conn.Close()
        End If
    End Sub
End Class