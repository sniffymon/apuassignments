Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class AdminChaletInfo
    Public clickedchalet As String
    Public clickedchaletCH As String
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim chaletamt As String
    Dim sql As String
    Dim passportregex As Regex = New Regex("^ (?!^ 0 +$)[a-zA-Z0-9]{3,20}$")
    Private Sub ChaletBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")

        conn.Open()
        sql = "SELECT ChaletNumber FROM Chalet WHERE ChaletStatusOccupied='True'"

        Dim chaletds As New DataSet
        Dim adptr As New SqlDataAdapter(sql, conn)
        adptr.Fill(chaletds, "BookedCH")

        Dim exdata As DataTable = chaletds.Tables("BookedCH")
        Dim row As DataRow

        For Each row In exdata.Rows
            DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).BackColor = Color.Red
        Next

        '
        'Start Loading For Guest ID In Search ComboBox
        '
        sql = "SELECT Guest_ID_PassNum FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)


        Dim dr As SqlDataReader = cmd.ExecuteReader
        Dim guestcombotb As New DataTable

        If dr.HasRows Then
            While (dr.Read())
                cboGuestID.Items.Add(dr(0))
            End While
        Else
            cboGuestID.Items.Add("No Existing Guests")
        End If
        conn.Close()
    End Sub
    Private Sub ChaletButtons_Click(sender As Object, e As EventArgs) Handles btnCH001.Click, btnCH002.Click, btnCH003.Click, btnCH004.Click, btnCH005.Click, btnCH006.Click, btnCH007.Click, btnCH008.Click, btnCH009.Click, btnCH010.Click, btnCH011.Click, btnCH012.Click, btnCH013.Click, btnCH014.Click, btnCH015.Click, btnCH016.Click, btnCH017.Click, btnCH018.Click, btnCH019.Click, btnCH020.Click
        'If sender.BackColor = Color.White Then
        '    DirectCast(sender, Button).BackColor = Color.FromArgb(128, 128, 255)
        'ElseIf DirectCast(sender, Button).BackColor = Color.FromArgb(128, 128, 255) Then
        '    DirectCast(sender, Button).BackColor = Color.White
        'End If
        'checkedchalet.Add("CH0" & sender.text)
        ContextMenuStrip1.Show(sender, sender.Height, 0)
        clickedchalet = "Chalet " & sender.text
        clickedchaletCH = "CH0" & sender.text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboGuestID.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")


        'GUEST DETAIL SECTION START

        sql = "SELECT Guest_Name, Guest_Contact_No, Guest_Email FROM GuestDetail WHERE 
[Guest_ID_PassNum]=@guestid"

        'Creating 1st Instance of SQL Command
        cmd = New SqlCommand(sql, conn)
        conn.Open()
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@guestid", cboGuestID.Text)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.Read() Then
            txtGuestName.Text = dr(0)
            txtGuestMobile.Text = dr(1)
            txtGuestEmail.Text = dr(2)
        End If


        'GUEST DETAIL SECTION END
        ''CHALET BOOKING INFO START
        'chaletamt = String.Join(",", checkedchalet.ToArray)
        ''Creating 2nd Instance of SQL Command
        'sql = "UPDATE Chalet SET ChaletStatusOccupied = 'True' WHERE ChaletNumber IN (" & chaletamt & ")"
        'cmd = New SqlCommand(sql, conn)

        ''Execute SQL Query above and expecting no return
        'cmd.ExecuteNonQuery()
        ''CHALET BOOKING INFO END
        'conn.Close()
        'MessageBox.Show("Booking Details Stored", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        Dim ChaletDetailsNEW As New ChaletDetails
        ChaletDetailsNEW.Text = clickedchalet & " Details"
        ChaletDetailsNEW.Show()
    End Sub

    Private Sub EditDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditDetailsToolStripMenuItem.Click
        Dim ChaletEditNEW As New ChaletEdit
        ChaletEditNEW.Text = "Edit " & clickedchalet
        ChaletEditNEW.Show()
    End Sub
End Class