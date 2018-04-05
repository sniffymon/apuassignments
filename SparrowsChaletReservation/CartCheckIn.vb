Imports System.Data.SqlClient
Public Class CartCheckIn
    Dim conn As SqlConnection = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
    Dim cmd As SqlCommand
    Dim sql As String
    Dim lastButtonPos, i, recordcheck As Integer
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = CheckIn.ChaletDeposit.ToString("c")
        Label3.Text = CheckIn.ChaletTotal.ToString("c")
        Label5.Text = CheckIn.txtGuestName.Text
        Label7.Text = "From " & CheckIn.dtpCheckIn.Text & " Until " & CheckIn.dtpCheckOut.Text


        For Each Item In CheckIn.checkedchalet
            Dim NewSubPanel As New Button
            NewSubPanel.Location = New Point(5, lastButtonPos)
            NewSubPanel.Size = New Size(550, 100)
            NewSubPanel.Text = "Chalet = " & CheckIn.checkedchalet(i)
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
            NewEBDropDown.Items.Add("No Extra Beds")
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
        Dim n As Integer = 0
        For x = 1 To i

            sql = "INSERT INTO Reservation (CheckIn_Date, CheckOut_Date, Deposit, ChaletNumber_FK, ExtraBed, GuestNo_FK)
               SELECT @checkindate, @checkoutdate, @deposit, @chaletnumber, @extrab, (SELECT GuestNo FROM GuestDetail WHERE Guest_Name = @memguestname)"
            'WHERE NOT EXISTS (SELECT * FROM Reservation WHERE (@checkindate >= CheckIn_Date AND ChaletNumber_FK = @chaletnumber) OR (@checkindate <= CheckIn_Date AND @checkoutdate >= CheckIn_Date AND ChaletNumber_FK = @chaletnumber))"

            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@checkindate", CheckIn.dtpCheckIn.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@checkoutdate", CheckIn.dtpCheckOut.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@deposit", CheckIn.ChaletDeposit)
            'cmd.Parameters.AddWithValue("@totalamt", CheckIn.ChaletTotal)
            cmd.Parameters.AddWithValue("@memguestname", CheckIn.txtGuestName.Text)
            cmd.Parameters.AddWithValue("@chaletnumber", CheckIn.checkedchalet(x - 1))
            cmd.Parameters.AddWithValue("@extrab", DirectCast(pnlOthers.Controls("Dropdown" & (x - 1).ToString), ComboBox).Text)

            recordcheck = cmd.ExecuteNonQuery
            n += 1
        Next
        conn.Close()
        If recordcheck = 1 Then
            MessageBox.Show("Chalet/Chalets Successfully Booked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckIn.RefreshForm(e)
            Me.Close()
        Else
            MessageBox.Show("There was an unexpected error. Please check your booking details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub
End Class