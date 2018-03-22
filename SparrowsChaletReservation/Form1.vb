Imports System.Data.SqlClient
Public Class CheckOutCart
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim cmd As SqlCommand
    Dim sql As String
    Dim dr As SqlDataReader
    Dim lastButtonPos, i, recordcheck As Integer
    Dim addedchalets, standardchalets, supremechalets As Integer
    Public ChaletTotal, ChaletDeposit, dayduration As Double

    Private Sub CheckOutCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTAmount.Text = CheckOut.overalltotal.ToString("c")
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
                .Location = New Point(300, lastButtonPos + 10)
                .Text = CheckOut.lblNightsStay.Text & “Days”
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 8)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newlblDurationOfStay As New Label
            With newlblDurationOfStay
                .Location = New Point(190, lastButtonPos + 10)
                .Text = "Days of Stay"
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 10)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newDurationofOverstay As New Label
            With newDurationofOverstay
                .Location = New Point(300, lastButtonPos + 40)
                .Text = CheckOut.txtOverdue.Text & “Days”
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 8)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newlblDurationOfOverStay As New Label
            With newlblDurationOfOverStay
                .Location = New Point(190, lastButtonPos + 40)
                .Text = "Overdue Days"
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 10)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newroomamount As New Label
            With newroomamount
                .Location = New Point(450, lastButtonPos + 10)

                If CDbl((CheckOut.checkedchalet(i).ToString).Remove(0, 6)) >= 11 Then
                    .Text = CheckOut.supremeprice.ToString("c")
                ElseIf CDbl((CheckOut.checkedchalet(i).ToString).Remove(0, 6)) <= 10 Then
                    .Text = CheckOut.standardprice.ToString("c")
                End If

                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 8)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newlblroomamount As New Label
            With newlblroomamount
                .Location = New Point(350, lastButtonPos + 10)
                .Text = "Price of Room"
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 10)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newoverstayamount As New Label
            With newoverstayamount
                .Location = New Point(450, lastButtonPos + 40)

                If CDbl((CheckOut.checkedchalet(i).ToString).Remove(0, 6)) >= 11 Then
                    .Text = CheckOut.oversupreme.ToString("c")
                ElseIf CDbl((CheckOut.checkedchalet(i).ToString).Remove(0, 6)) <= 10 Then
                    .Text = CheckOut.overstandard.ToString("c")
                End If

                .Font = New Drawing.Font("Segoe UI Semibold", 8)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newlbloverstayamount As New Label
            With newlbloverstayamount
                .Location = New Point(350, lastButtonPos + 40)
                .Text = "Overstay Charged"
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 10)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With


            Dim newTotalamount As New Label
            With newTotalamount
                .Location = New Point(450, lastButtonPos + 70)
                If CDbl((CheckOut.checkedchalet(i).ToString).Remove(0, 6)) >= 11 Then
                    .Text = CheckOut.totalsupreme.ToString("c")
                ElseIf CDbl((CheckOut.checkedchalet(i).ToString).Remove(0, 6)) <= 10 Then
                    .Text = CheckOut.totalstandard.ToString("c")
                End If
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 8)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newlblTotalamount As New Label
            With newlblTotalamount
                .Location = New Point(350, lastButtonPos + 70)
                .Text = "Total"
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 10)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            pnlOthers.Controls.Add(newTotalamount)
            pnlOthers.Controls.Add(newlblTotalamount)
            pnlOthers.Controls.Add(newlbloverstayamount)
            pnlOthers.Controls.Add(newoverstayamount)
            pnlOthers.Controls.Add(newlblroomamount)
            pnlOthers.Controls.Add(newroomamount)
            pnlOthers.Controls.Add(newDurationofOverstay)
            pnlOthers.Controls.Add(newlblDurationOfOverStay)
            pnlOthers.Controls.Add(newlblDurationOfStay)
            pnlOthers.Controls.Add(newDurationofstay)
            pnlOthers.Controls.Add(NewSubPanel)
            lastButtonPos = lastButtonPos + 110
            i = i + 1
        Next

        Dim n As Integer = 0
        For x = 1 To i
            sql = "SELECT CheckIn_Date, CheckOut_Date, Deposit, ChaletNumber_FK, ExtraBed, GuestNo_FK, GuestNo,Guest_Name FROM Reservation INNER JOIN
                   GuestDetail on GuestDetail.GuestNo = Reservation.GuestNo_FK  WHERE Reservation.GuestNo_FK=@guestid "
            'Creating 1st Instance of SQL Command
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@guestid", CheckOut.guestnostorage)
            conn.Open()
            lblName.Text = CheckOut.txtGuestName.Text
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                lblDeposit.Text = CInt(dr(2)).ToString("c")
            End If
            dr.Close()
            conn.Close()
        Next
        lblBalance.Text = (CheckOut.overalltotal - CDbl(lblDeposit.Text)).ToString("c")
    End Sub
End Class