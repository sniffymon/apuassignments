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

        ' LOOP TO CREATE "PANELS" FOR "SHOPPING ITEMS"
        '
        For Each Item In CheckIn.checkedchalet
            Dim NewSubPanel As New Button
            With NewSubPanel
                .Location = New Point(5, lastButtonPos)
                .Size = New Size(550, 100)
                .Text = "Chalet = " & CheckIn.checkedchalet(i)
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

            Dim NewEBDropDown As New ComboBox
            With NewEBDropDown
                .Items.Add("No Extra Beds")
                .Items.Add("1")
                .Items.Add("2")
                .SelectedIndex = 0
                .DropDownStyle = ComboBoxStyle.DropDownList
                .Location = New Point(400, lastButtonPos + 45)
                .Name = "Dropdown" & i.ToString
            End With

            Dim NewEBLabel As New Label
            With NewEBLabel
                .Text = "Extra Portable Beds"
                .BackColor = Color.White
                .Location = New Point(300, lastButtonPos + 50)
            End With
            ' ADD "PANELS" TO CART "LIST"
            '
            With pnlOthers
                .Controls.Add(NewEBLabel)
                .Controls.Add(NewEBDropDown)
                .Controls.Add(NewSubPanel)
            End With
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
        ' QUERY TO INSERT RESERVATION/CHECKIN
        '
        Dim n As Integer = 0
        For x = 1 To i

            sql = "INSERT INTO Reservation (CheckIn_Date, CheckOut_Date, Deposit, ChaletNumber_FK, ExtraBed, GuestNo_FK)
               SELECT @checkindate, @checkoutdate, @deposit, @chaletnumber, @extrab, @guestno"

            cmd = New SqlCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@checkindate", CheckIn.dtpCheckIn.Value.ToString("yyyy-MM-dd"))
                .AddWithValue("@checkoutdate", CheckIn.dtpCheckOut.Value.ToString("yyyy-MM-dd"))
                .AddWithValue("@deposit", CheckIn.ChaletDeposit)
                .AddWithValue("@guestno", CheckIn.guestnomem)
                .AddWithValue("@memguestname", CheckIn.txtGuestName.Text)
                .AddWithValue("@chaletnumber", CheckIn.checkedchalet(x - 1))
                .AddWithValue("@extrab", DirectCast(pnlOthers.Controls("Dropdown" & (x - 1).ToString), ComboBox).Text)
            End With

            recordcheck = cmd.ExecuteNonQuery
            n += 1
        Next
        conn.Close()
        ' CHECK IF DATA ENTRY WAS SUCCESSFUL
        '
        If recordcheck = 1 Then
            MessageBox.Show("Chalet/Chalets Successfully Booked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckIn.RefreshForm(e)
            Me.Close()
            ' FORCE REFRESH BY CLOSING
            '
            ExtendBooking.Close()
        Else
            MessageBox.Show("There was an unexpected error. Please check your booking details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

    End Sub
End Class