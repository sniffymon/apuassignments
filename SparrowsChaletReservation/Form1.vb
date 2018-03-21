Imports System.Data.SqlClient
Public Class CheckOutCart
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim cmd As SqlCommand
    Dim sql As String
    Dim dr As SqlDataReader
    Private Sub CheckOutCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()

        sql = "SELECT Guest_Name, GuestNo, ChaletNumber_FK, Cast(CheckIn_Date AS Varchar), Cast(CheckOut_Date AS Varchar), ExtraBed
              From GuestDetail
              Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK"


        cmd = New SqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        If dr.Read() Then

        End If




    End Sub
End Class