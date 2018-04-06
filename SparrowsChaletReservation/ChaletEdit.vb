Imports System.Data.SqlClient

'DECLARATION OF NEEDED VARIABLES
'
Public Class ChaletEdit
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim sql As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    'DISPLAY DATA FROM DATABASE
    '
    Private Sub ChaletEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpCheckIn.CustomFormat = " "
        dtpCheckOut.CustomFormat = " "

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
            dtpCheckIn.CustomFormat = "yyyy-MM-dd"
            dtpCheckOut.CustomFormat = "yyyy-MM-dd"
            txtGuestID.Text = dr(0)
            dtpCheckIn.Value = dr(3)
            dtpCheckOut.Value = dr(4)
            CboEB.Text = dr(5)
        End If

        conn.Close()
    End Sub

    'UPDATE DISPLAYED DATA 
    '
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim EditCheck As Integer
        conn.Open()
        sql = "UPDATE Reservation
               SET GuestNo_FK = GuestDetail.GuestNo, CheckIn_Date = @checkindate, CheckOut_Date =@checkoutdate, ExtraBed = @eb
			   FROM GuestDetail 
			   INNER JOIN
			   Reservation
               ON Reservation.GuestNo_FK = GuestDetail.GuestNo
               WHERE GuestDetail.Guest_Name = @memguestname AND ChaletNumber_FK = @clickedchaletCH;"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@memguestname", txtGuestID.Text)
        cmd.Parameters.AddWithValue("@checkindate", dtpCheckIn.Text)
        cmd.Parameters.AddWithValue("@checkoutdate", dtpCheckOut.Text)
        cmd.Parameters.AddWithValue("@eb", CboEB.Text)

        EditCheck = cmd.ExecuteNonQuery()

        If EditCheck = 0 Then
            MsgBox("No Similar Data Found")
        ElseIf EditCheck = 1 Then
            MsgBox("Data Successfully Edited")
        End If

    End Sub

    'LIMIT CHECKOUT DATE TO BE 1 DAY AFTER CHECKIN DATE
    '
    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged
        dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1)
    End Sub

    'DELETE SELECTED DATA FROM DATABASE
    '
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Recorddeleted As Integer
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()

        sql = " DELETE FROM Reservation WHERE ChaletNumber_FK = @clickedchaletCH AND CheckIn_Date = @checkindate AND CheckOut_Date = @checkoutdate"
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        cmd.Parameters.AddWithValue("@checkindate", dtpCheckIn.Value.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@checkoutdate", dtpCheckOut.Value.ToString("yyyy-MM-dd"))

        Recorddeleted = cmd.ExecuteNonQuery()
        If Recorddeleted = 0 Then
            MessageBox.Show("Error occured when deleting data. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Recorddeleted = 1 Then
            MessageBox.Show("Record successfully deleted.", "Success")
            Me.Close()
            AdminChaletInfo.Close()
            AdminChaletInfo.TopLevel = False
            Adminmenuform.pnlMainView.Controls.Add(AdminChaletInfo)
            AdminChaletInfo.Show()
            AdminChaletInfo.BringToFront()

        End If

        conn.Close()
    End Sub
End Class