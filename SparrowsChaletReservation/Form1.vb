Imports System.Data.SqlClient
Public Class CheckOutCart
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim cmd As SqlCommand
    Dim sql As String
    Dim dr As SqlDataReader
    Dim lastButtonPos, i, recordcheck As Integer
    'Public ChaletTotal, ChaletDeposit, dayduration As Double


    Private Sub CheckOutCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDeposit.Text = CheckIn.ChaletDeposit.ToString("c")
        lblTAmount.Text = CheckIn.ChaletTotal.ToString("c")
        lblName.Text = CheckIn.txtGuestName.Text
        lblCheckIn.Text = "From " & CheckOut.txtCheckIn.Text & " Until " & CheckOut.txtActualCheckOut.Text


        For Each Item In CheckOut.checkedchalet
            Dim NewSubPanel As New Button
            NewSubPanel.Location = New Point(5, lastButtonPos)
            NewSubPanel.Size = New Size(550, 100)
            NewSubPanel.Text = "Chalet = " & CheckOut.checkedchalet(i)
            NewSubPanel.TextAlign = ContentAlignment.MiddleLeft
            NewSubPanel.Font = New Drawing.Font("Segoe UI Semibold", 13.875)
            NewSubPanel.FlatStyle = FlatStyle.Flat
            NewSubPanel.FlatAppearance.BorderColor = Color.Black
            NewSubPanel.ForeColor = Color.Black
            NewSubPanel.BackColor = Color.White
            NewSubPanel.FlatAppearance.BorderSize = 1
            NewSubPanel.FlatAppearance.MouseOverBackColor = Color.White
            NewSubPanel.FlatAppearance.MouseDownBackColor = Color.White

            Dim newDurationofstay As New Label
            With newDurationofstay
                .Location = New Point(200, lastButtonPos + 10)
                .Text = CheckOut.lblNightsStay.Text & “Days”
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 10)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newlblDurationOfStay As New Label
            With newlblDurationOfStay
                .Location = New Point(100, lastButtonPos + 10)
                .Text = "Days of Stay"
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.Black
                .BackColor = Color.White

            End With

            pnlOthers.Controls.Add(newlblDurationOfStay)
            pnlOthers.Controls.Add(newDurationofstay)
            pnlOthers.Controls.Add(NewSubPanel)
            lastButtonPos = lastButtonPos + 110
            i = i + 1
        Next

        Dim n As Integer = 0
        For x = 1 To i
            sql = "SELECT CheckIn_Date, CheckOut_Date, Deposit, Total_Amount, ChaletNumber_FK, ExtraBed, GuestNo_FK, GuestNo,Guest_Name FROM Reservation INNER JOIN
                   GuestDetail on GuestDetail.GuestNo = Reservation.GuestNo_FK  WHERE Reservation.GuestNo_FK=@guestid "
            'Creating 1st Instance of SQL Command
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@guestid", CheckOut.guestnostorage)
            conn.Open()
            lblName.Text = CheckOut.txtGuestName.Text
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                lblDeposit.Text = dr(2)
                lblTAmount.Text = dr(3)
            End If

            dr.Close()
            conn.Close()
        Next
    End Sub
End Class