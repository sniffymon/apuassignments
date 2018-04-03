Imports System.Data.SqlClient
Public Class CheckOutCart
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim cmd, cmdupdate As SqlCommand
    Dim sql As String
    Dim dr As SqlDataReader
    Dim spadd As Boolean = False
    Dim stadd As Boolean = False
    Dim lastButtonPos, i, recordcheck, addedchalets, standardchalets, supremechalets As Integer
    Public ChaletTotal, ChaletDeposit, dayduration As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'change chalet status
        conn.Open()
        Dim n As Integer = 0
        For x = 1 To i
            'Dim n as integer =1
            'for x=1 to i
            sql = "UPDATE Reservation
               SET Reservation_Status = 'False'
               WHERE ChaletNumber_FK = @chaletnumber;"

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@chaletnumber", CheckOut.checkedchalet(x - 1).Remove(0, 3))
            'cmd.Parameters.AddWithValue("@chaletnumber", CheckOut.checkedchalet(x + 1))
            cmd.ExecuteNonQuery()
            n += 1
            'n-=1
        Next
        MessageBox.Show("Please click on the print button to print the receipt!", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ReceiptForm.ShowDialog()
        If StaffMenuForm.contracheck > 0 Then
            StaffMenuForm.btnCheckOut.ForeColor = Color.White
            StaffMenuForm.RefreshForm(e)
            CheckOut.Close()
        End If
        CheckOut.checkedchalet.Clear()
        i = 0


        conn.Close()
    End Sub
    Private Sub CheckOutCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTAmount.Text = CheckOut.overalltotal.ToString("c")
        lblName.Text = CheckOut.txtGuestName.Text
        lblCheckIn.Text = "From " & CheckOut.txtCheckIn.Text & " Until " & CheckOut.txtActualCheckOut.Text


        For Each Item In CheckOut.checkedchalet
            Dim NewSubPanel As New Button
            With NewSubPanel
                .Location = New Point(5, lastButtonPos)
                .Size = New Size(550, 100)
                .Text = "Chalet = " & CheckOut.checkedchalet(i).Remove(0, 3)
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 13.875)
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderColor = Color.Black
                .ForeColor = Color.Black
                .BackColor = Color.White
                .FlatAppearance.BorderSize = 1
                .FlatAppearance.MouseOverBackColor = Color.White
                .FlatAppearance.MouseDownBackColor = Color.White
            End With
            Dim newDurationofstay As New Label
            With newDurationofstay
                .Location = New Point(300, lastButtonPos + 10)
                .Text = CheckOut.txtDuration.Text & “Days”
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 9)
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
                .Text = CheckOut.txtOverdue.Text & “Day”
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 9)
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
                .Font = New Drawing.Font("Segoe UI Semibold", 9)
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
                .Location = New Point(450, lastButtonPos + 43)

                If CDbl((CheckOut.checkedchalet(i).ToString).Remove(0, 6)) >= 11 Then
                    .Text = CheckOut.oversupreme.ToString("c")
                ElseIf CDbl((CheckOut.checkedchalet(i).ToString).Remove(0, 6)) <= 10 Then
                    .Text = CheckOut.overstandard.ToString("c")
                End If

                .Font = New Drawing.Font("Segoe UI Semibold", 9)
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
                .Font = New Drawing.Font("Segoe UI Semibold", 11)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            Dim newlblTotalamount As New Label
            With newlblTotalamount
                .Location = New Point(350, lastButtonPos + 70)
                .Text = "Total"
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Drawing.Font("Segoe UI Semibold", 11)
                .ForeColor = Color.Black
                .BackColor = Color.White
            End With

            With pnlOthers.Controls
                .Add(newTotalamount)
                .Add(newlblTotalamount)
                .Add(newlbloverstayamount)
                .Add(newoverstayamount)
                .Add(newlblroomamount)
                .Add(newroomamount)
                .Add(newDurationofOverstay)
                .Add(newlblDurationOfOverStay)
                .Add(newlblDurationOfStay)
                .Add(newDurationofstay)
                .Add(NewSubPanel)
            End With

            lastButtonPos = lastButtonPos + 110
            i += 1
        Next

        Dim n As Integer = 0
        For x = 1 To i
            sql = "SELECT Deposit FROM Reservation WHERE GuestNo_FK=@guestid "
            'Creating 1st Instance of SQL Command
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@guestid", CheckOut.guestnostorage)
            conn.Open()
            lblName.Text = CheckOut.txtGuestName.Text
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                ChaletDeposit = dr(0)
                lblDeposit.Text = ChaletDeposit.ToString("c")
            End If
            dr.Close()
            conn.Close()
        Next
        lblBalance.Text = (CheckOut.overalltotal - CDbl(lblDeposit.Text)).ToString("c")
    End Sub

    Private Sub CheckOutCart_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        i = 0
        CheckOut.checkedchalet.Clear()
    End Sub
End Class