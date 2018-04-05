Imports System.Data.SqlClient
Public Class ChaletDetails
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String
    Private Sub ChaletDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
        Try
            conn.Open()
        Catch sqlEx As SqlException
            Select Case sqlEx.Number
                Case -1, 2, 53, 40
                    MessageBox.Show("Please check if the connection is available!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("An unexpected error occured! Please contact your system administrator!", "Undefined Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Try
        sql = "SELECT Guest_Name, GuestNo, ChaletNumber_FK, Cast(CheckIn_Date AS Varchar), Cast(CheckOut_Date AS Varchar), ExtraBed
              From GuestDetail
              Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
              WHERE ChaletNumber_FK = @clickedchaletCH AND (@date >= CheckIn_Date AND @date < CheckOut_Date) AND Reservation_Status = 'True'"
        ' secondsql = "SELECT Cast(CheckIn_Date AS Varchar), Cast(CheckOut_Date AS Varchar), ExtraBed FROM Reservation WHERE ChaletNumber_FK = @clickedchaletCH"

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