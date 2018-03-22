Imports System.Data.SqlClient
Public Class ChaletExtend
    Dim conn As SqlConnection
    Dim sql As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim namememory As String

    Private Sub ChaletEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpCheckOut.CustomFormat = " "
        dtpCheckOut.MinDate = dtpCheckOut.Value

        'LOAD Existing Info on Chalet
        '
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
        conn.Open()

        sql = "SELECT Guest_Name, GuestNo, ChaletNumber_FK, Cast(CheckIn_Date AS varchar), Cast(CheckOut_Date AS Varchar), ExtraBed
              From GuestDetail
              Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
              WHERE ChaletNumber_FK = @clickedchaletCH"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        dr = cmd.ExecuteReader
        Label1.Text = AdminChaletInfo.clickedchalet

        If dr.Read() Then
            dtpCheckOut.CustomFormat = "yyyy-MM-dd"
            txtGuestName.Text = dr(0)
            txtCheckIn.text = dr(3).ToString
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
               SET CheckOut_Date =@checkoutdate
			   FROM GuestDetail 
			   INNER JOIN
			   Reservation
               ON Reservation.GuestNo_FK = GuestDetail.GuestNo
               WHERE GuestDetail.Guest_Name = @memguestname AND ChaletNumber_FK = @clickedchaletCH;"


        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@memguestname", txtGuestName.Text)
        cmd.Parameters.AddWithValue("@checkoutdate", dtpCheckOut.Text)

        EditCheck = cmd.ExecuteNonQuery()

        If EditCheck = 0 Then
            MsgBox("No Similar Data Found")
        ElseIf EditCheck = 1 Then
            MsgBox("Stay Successfully Extended")
        End If

    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        sender.CustomFormat = "yyyy-MM-dd"
    End Sub
End Class