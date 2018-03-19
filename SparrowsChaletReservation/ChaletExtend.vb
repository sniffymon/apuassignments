Imports System.Data.SqlClient
Public Class ChaletExtend
    Dim conn As SqlConnection
    Dim sql As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim namememory As String

    Private Sub ChaletEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpCheckIn.CustomFormat = " "
        dtpCheckOut.CustomFormat = " "
        'LOAD Existing Info on Chalet
        '
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
        conn.Open()

        sql = "SELECT Guest_Name, GuestNo, ChaletNumber_FK, Cast(CheckIn_Date AS Varchar), Cast(CheckOut_Date AS Varchar), ExtraBed
              From GuestDetail
              Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
              WHERE ChaletNumber_FK = @clickedchaletCH"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        dr = cmd.ExecuteReader
        Label1.Text = AdminChaletInfo.clickedchalet

        If dr.Read() Then
            dtpCheckIn.CustomFormat = "yyyy-MM-dd"
            dtpCheckOut.CustomFormat = "yyyy-MM-dd"
            txtGuestName.Text = dr(0)
            dtpCheckIn.Value = dr(3)
            dtpCheckOut.Value = dr(4)
            txtEB.Text = dr(5)
        End If

        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EditCheck As Integer
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
        conn.Open()
        sql = "UPDATE Reservation
               SET CheckIn_Date = @checkindate, CheckOut_Date =@checkoutdate
			   FROM GuestDetail 
			   INNER JOIN
			   Reservation
               ON Reservation.GuestNo_FK = GuestDetail.GuestNo
               WHERE GuestDetail.Guest_Name = @memguestname AND ChaletNumber_FK = @clickedchaletCH;"


        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@memguestname", txtGuestName.Text)
        cmd.Parameters.AddWithValue("@checkindate", dtpCheckIn.Text)
        cmd.Parameters.AddWithValue("@checkoutdate", dtpCheckOut.Text)

        EditCheck = cmd.ExecuteNonQuery()

        If EditCheck = 0 Then
            MsgBox("No Similar Data Found")
        ElseIf EditCheck = 1 Then
            MsgBox("Stay Successfully Extended")
        End If

    End Sub

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged, dtpCheckOut.ValueChanged
        sender.CustomFormat = "yyyy-MM-dd"
    End Sub
End Class