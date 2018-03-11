Imports System.Data.SqlClient
Public Class Cart
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim sql As String
    Dim lastButtonPos, i, recordcheck As Integer
    Private Sub Trolley_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = RegisterChalet.ChaletDeposit.ToString("c")
        Label3.Text = RegisterChalet.ChaletTotal.ToString("c")
        Label5.Text = RegisterChalet.txtGuestName.Text
        Label7.Text = "From " & RegisterChalet.dtpCheckIn.Text & " Until " & RegisterChalet.dtpCheckOut.Text


        For Each Item In RegisterChalet.checkedchalet
            Dim NewSubPanel As New Button
            NewSubPanel.Location = New Point(5, lastButtonPos)
            NewSubPanel.Size = New Size(550, 100)
            NewSubPanel.Text = "Chalet = " & RegisterChalet.checkedchalet(i)
            NewSubPanel.TextAlign = ContentAlignment.MiddleLeft
            NewSubPanel.Font = New Drawing.Font("Segoe UI Semibold", 13.875)
            NewSubPanel.FlatStyle = FlatStyle.Flat
            NewSubPanel.FlatAppearance.BorderColor = Color.Black
            NewSubPanel.ForeColor = Color.Black
            NewSubPanel.BackColor = Color.White
            NewSubPanel.FlatAppearance.BorderSize = 1
            NewSubPanel.FlatAppearance.MouseOverBackColor = Color.White
            NewSubPanel.FlatAppearance.MouseDownBackColor = Color.White


            Dim NewEBDropDown As New ComboBox
            NewEBDropDown.Items.Add("0")
            NewEBDropDown.Items.Add("1")
            NewEBDropDown.Items.Add("2")
            NewEBDropDown.SelectedIndex = 0
            NewEBDropDown.DropDownStyle = ComboBoxStyle.DropDownList
            NewEBDropDown.Location = New Point(400, lastButtonPos + 45)
            NewEBDropDown.Name = "Dropdown" & i.ToString

            Dim NewEBLabel As New Label
            NewEBLabel.Text = "Extra Portable Beds"
            NewEBLabel.BackColor = Color.White
            NewEBLabel.Location = New Point(300, lastButtonPos + 50)

            pnlOthers.Controls.Add(NewEBLabel)
            pnlOthers.Controls.Add(NewEBDropDown)
            pnlOthers.Controls.Add(NewSubPanel)
            lastButtonPos = lastButtonPos + 110
            i = i + 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
        conn.Open()
        Dim n As Integer = 0
        For x = 1 To i

            sql = "INSERT INTO Reservation (CheckIn_Date, CheckOut_Date, Deposit, Total_Amount, ChaletNumber_FK, ExtraBed, GuestNo_FK)
               SELECT @checkindate, @checkoutdate, @deposit, @totalamt, @chaletnumber, @extrab, (SELECT GuestNo FROM GuestDetail WHERE Guest_Name = @memguestname)
               WHERE NOT EXISTS (SELECT * FROM Reservation WHERE (@checkindate >= CheckIn_Date AND ChaletNumber_FK = @chaletnumber) OR (@checkindate <= CheckIn_Date AND @checkoutdate >= CheckIn_Date AND ChaletNumber_FK = @chaletnumber))"

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@checkindate", RegisterChalet.dtpCheckIn.Text)
            cmd.Parameters.AddWithValue("@checkoutdate", RegisterChalet.dtpCheckOut.Text)
            cmd.Parameters.AddWithValue("@deposit", RegisterChalet.ChaletDeposit)
            cmd.Parameters.AddWithValue("@totalamt", RegisterChalet.ChaletTotal)
            cmd.Parameters.AddWithValue("@memguestname", RegisterChalet.txtGuestName.Text)
            cmd.Parameters.AddWithValue("@chaletnumber", RegisterChalet.checkedchalet(n))
            cmd.Parameters.AddWithValue("@extrab", DirectCast(pnlOthers.Controls("Dropdown" & n.ToString), ComboBox).Text)

            recordcheck = cmd.ExecuteNonQuery

            sql = "UPDATE Chalet
               SET ChaletStatusOccupied = 'True'
			   FROM Reservation
			   INNER JOIN
			   Chalet
               ON Reservation.ChaletNumber_FK = Chalet.ChaletNumber
               WHERE ChaletNumber_FK = @chaletnumber;"

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@chaletnumber", RegisterChalet.checkedchalet(n))
            cmd.ExecuteNonQuery()

            n += 1
        Next
        conn.Close()
        If recordcheck = 1 Then
            MessageBox.Show("Chalet/Chalets Successfully Booked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("There was an unexpected error. Please check your booking details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub

    Private Sub Cart_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        RegisterChalet.Close()
    End Sub
End Class