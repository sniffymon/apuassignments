Imports System.Data.SqlClient

'DECLARATION ON NEEDED VARIABLES
'
Public Class ChaletDetails
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    'GET DATA FROM DATABASE TO DISPLAY ON FORM
    '
    Private Sub ChaletDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()
        sql = "SELECT Guest_Name, GuestNo, ChaletNumber_FK, Cast(CheckIn_Date AS Varchar), Cast(CheckOut_Date AS Varchar), ExtraBed
              From GuestDetail
              Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
              WHERE ChaletNumber_FK = @clickedchaletCH AND (@date >= CheckIn_Date AND @date < CheckOut_Date) AND Reservation_Status = 'True'"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@date", AdminChaletInfo.dtpDateSpec.Value.ToString("yyyy-MM-dd"))
        dr = cmd.ExecuteReader

        lblChalet.Text = AdminChaletInfo.clickedchalet
        If dr.Read() Then
            txtGuestName.Text = dr(0).ToString
            txtCheckIn.Text = dr(3)
            txtCheckOut.Text = dr(4)
            txtEB.Text = dr(5)
        End If
        conn.Close()
    End Sub
End Class