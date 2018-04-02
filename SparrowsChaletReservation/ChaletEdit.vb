Imports System.Data.SqlClient
Public Class ChaletEdit
    Dim conn As SqlConnection
    Dim sql As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim namememory As String

    Private Sub ChaletEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpCheckIn.CustomFormat = " "
        dtpCheckOut.CustomFormat = " "
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
        conn.Open()

        '
        'LOAD cboGuestNames START
        '
        sql = "SELECT Guest_Name FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)


        Dim dr2 As SqlDataReader = cmd.ExecuteReader
        Dim guestcombotb As New DataTable

        If dr2.HasRows Then
            While (dr2.Read())
                CboGuestName.Items.Add(dr2(0))
            End While
        Else
            CboGuestName.Items.Add("No Existing Guests")
        End If
        dr2.Close()
        '
        'LOAD cboGuestNames STOP
        '
        sql = "SELECT Guest_Name, GuestNo, ChaletNumber_FK, Cast(CheckIn_Date AS Varchar), Cast(CheckOut_Date AS Varchar), ExtraBed
              From GuestDetail
              Left Join Reservation on GuestDetail.GuestNo = Reservation.GuestNo_FK
              WHERE ChaletNumber_FK = @clickedchaletCH"

        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)
        dr = cmd.ExecuteReader
        lblChalet.Text = AdminChaletInfo.clickedchalet

        If dr.Read() Then
            dtpCheckIn.CustomFormat = "yyyy-MM-dd"
            dtpCheckOut.CustomFormat = "yyyy-MM-dd"
            CboGuestName.Text = dr(0)
            dtpCheckIn.Value = dr(3)
            dtpCheckOut.Value = dr(4)
            CboEB.Text = dr(5)
            namememory = CboGuestName.Text
        End If
        '
        'LOAD Existing Info on Chalet
        '
        conn.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim EditCheck As Integer
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
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
        cmd.Parameters.AddWithValue("@memguestname", namememory)
        cmd.Parameters.AddWithValue("@guestname", CboGuestName.SelectedText)
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

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged
        dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Recorddeleted As Integer
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()

        sql = " DELETE FROM Reservation WHERE ChaletNumber_FK = @clickedchaletCH"
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@clickedchaletCH", AdminChaletInfo.clickedchaletCH)

        Recorddeleted = cmd.ExecuteNonQuery()
        If Recorddeleted = 0 Then
            MessageBox.Show("Error occured when deleting data. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Recorddeleted = 1 Then
            MessageBox.Show("Record successfully deleted.", "Success")
        End If

        conn.Close()
    End Sub
    'Private Sub ChaletButtons_Click(sender As Object, e As EventArgs) Handles btnCH001.Click, btnCH002.Click, btnCH003.Click, btnCH004.Click, btnCH005.Click, btnCH006.Click, btnCH007.Click, btnCH008.Click, btnCH009.Click, btnCH010.Click, btnCH011.Click, btnCH012.Click, btnCH013.Click, btnCH014.Click, btnCH015.Click, btnCH016.Click, btnCH017.Click, btnCH018.Click, btnCH019.Click, btnCH020.Click
    '    ContextMenuStrip1.Show(sender, sender.Height, 0)
    '    clickedchalet = "Chalet " & sender.text
    '    clickedchaletCH = "CH0" & sender.text
    'End Sub
End Class