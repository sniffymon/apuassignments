Imports System.Data.SqlClient

'DECLARATION OF NEEDED DECLARATIONS
'
Public Class ChaletExtend
    Dim conn As SqlConnection
    Dim sql As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim namememory As String

    'LOAD DATA FROM DATABASE
    '
    Private Sub ChaletEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()
        sql = "SELECT Cast(CheckIn_Date AS varchar), Cast(CheckOut_Date AS Varchar), ExtraBed
              From Reservation
              INNER Join GuestDetail on GuestDetail.GuestNo = GuestNo_FK
              WHERE ChaletNumber_FK = @clickedchaletCH AND GuestDetail.Guest_Name = @guestname"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@guestname", ExtendBooking.txtGuestName.Text)
        dr = cmd.ExecuteReader
        lblChalet.Text = AdminChaletInfo.clickedchalet

        If dr.Read() Then
            dtpCheckOut.CustomFormat = "yyyy-MM-dd"
            txtGuestName.Text = ExtendBooking.txtGuestName.Text
            txtCheckIn.Text = dr(0).ToString
            dtpCheckOut.Value = dr(1)
            txtEB.Text = dr(2)
        End If

        conn.Close()
        dtpCheckOut.MinDate = dtpCheckOut.Value.ToString("yyyy-MM-dd")
    End Sub

    'EXTEND CHECKOUT DATE 
    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExtendBooking.Click
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
               WHERE GuestDetail.Guest_Name = @memguestname AND ChaletNumber_FK = @clickedchaletCH AND NOT EXISTS (SELECT * FROM Reservation INNER JOIN GuestDetail ON GuestNo_FK = GuestDetail.GuestNo WHERE Guest_Name <> @memguestname AND NOT (CheckIn_Date < @checkoutdate AND CheckOut_Date > @checkoutdate) AND (CheckIn_Date <@checkoutdate AND CheckOut_Date >= @checkoutdate)
               AND (CheckIn_Date < @checkoutdate AND CheckOut_Date > @checkoutdate) OR (CheckIn_Date < @checkoutdate AND CheckOut_Date >= @checkoutdate)AND ChaletNumber_FK = @clickedchaletCH)"


        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@memguestname", txtGuestName.Text)
        cmd.Parameters.AddWithValue("@checkoutdate", dtpCheckOut.Value.ToString("yyyy-MM-dd"))

        EditCheck = cmd.ExecuteNonQuery()

        If EditCheck = 0 Then
            MessageBox.Show("This chalet has already been booked on that day. Try an earlier date or another chalet.", "Extend Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf EditCheck = 1 Then
            MsgBox("Stay Successfully Extended")
            Me.Close()
        End If

    End Sub

    'SET CUSTOM FORMAT OF CHECKOUT DATE
    '
    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        sender.CustomFormat = "yyyy-MM-dd"
    End Sub
End Class