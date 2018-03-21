Imports System.Data.SqlClient
Public Class CheckIn
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String
    Public checkedchalet As New List(Of String)
    Dim addedchalets, standardchalets, supremechalets, n, unavaich As Integer
    Public ChaletTotal, ChaletDeposit, dayduration As Double


    Private Sub ChaletButtons_Click(sender As Object, e As EventArgs) Handles btnCH001.Click, btnCH002.Click, btnCH003.Click, btnCH004.Click, btnCH005.Click, btnCH006.Click, btnCH007.Click, btnCH008.Click, btnCH009.Click, btnCH010.Click
        If sender.BackColor = Color.White Then
            DirectCast(sender, Button).BackColor = Color.FromArgb(128, 128, 255)
            addedchalets += 1
            standardchalets += 1
            checkedchalet.Add("CH0" & sender.text)
        ElseIf DirectCast(sender, Button).BackColor = Color.FromArgb(128, 128, 255) Then
            DirectCast(sender, Button).BackColor = Color.White
            addedchalets -= 1
            standardchalets -= 1
            checkedchalet.Remove("CH0" & sender.text)
        End If
    End Sub

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")
        For Each ctrl As Control In Me.GroupBox2.Controls
            If TypeOf ctrl Is Button Then
                With ctrl
                    .BackColor = Color.White
                    .Visible = True
                End With
            End If
        Next
        conn.Open()
        Dim chaletds As New DataSet
        sql = "SELECT ChaletNumber FROM Chalet INNER JOIN Reservation ON ChaletNumber = ChaletNumber_FK
               WHERE ChaletStatusOccupied='True' AND CheckIn_Date <= @date AND CheckOut_Date >= @date"
            cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@date", dtpCheckIn.Text)
        Dim adptr As New SqlDataAdapter(cmd)
            adptr.Fill(chaletds, "BookedCH")

            Dim exdata As DataTable = chaletds.Tables("BookedCH")
            Dim row As DataRow

            For Each row In exdata.Rows
            DirectCast(GroupBox2.Controls("btn" & row(0)), Button).BackColor = Color.Red
        Next
    End Sub

    Private Sub btnCH011_Click(sender As Object, e As EventArgs) Handles btnCH011.Click, btnCH012.Click, btnCH013.Click, btnCH014.Click, btnCH015.Click, btnCH016.Click, btnCH017.Click, btnCH018.Click, btnCH019.Click, btnCH020.Click
        If sender.BackColor = Color.White Then
            DirectCast(sender, Button).BackColor = Color.FromArgb(128, 128, 255)
            addedchalets += 1
            supremechalets += 1
            checkedchalet.Add("CH0" & sender.text)
        ElseIf DirectCast(sender, Button).BackColor = Color.FromArgb(128, 128, 255) Then
            DirectCast(sender, Button).BackColor = Color.White
            addedchalets -= 1
            supremechalets -= 1
            checkedchalet.Remove("CH0" & sender.text)
        End If
    End Sub
    Private Sub RegisterChalet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

        conn.Open()
        sql = "SELECT ChaletNumber FROM Chalet INNER JOIN Reservation ON ChaletNumber = ChaletNumber_FK
               WHERE ChaletStatusOccupied='True' AND CheckIn_Date <= @date AND CheckOut_Date >= @date"

        Dim chaletds As New DataSet
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@date", Date.Today)
        Dim adptr As New SqlDataAdapter(cmd)
        adptr.Fill(chaletds, "BookedCH")

        Dim exdata As DataTable = chaletds.Tables("BookedCH")
        Dim row As DataRow

        For Each row In exdata.Rows
            DirectCast(GroupBox2.Controls("btn" & row(0)), Button).BackColor = Color.Red
            unavaich += 1
        Next


        'Start Loading For Guest ID In Search ComboBox
        '

        sql = "SELECT Guest_ID_PassNum FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)


        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.HasRows Then
            While (dr.Read())
                cboGuestID.Items.Add(dr(0))
            End While
        Else
            cboGuestID.Items.Add("No Existing Guests")
        End If
        conn.Close()
    End Sub

    Private Sub cboGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGuestID.SelectedIndexChanged
        If cboGuestID.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")


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
    End Sub
    Private Sub txtPax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPax.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        '
        'INPUT VALIDATION & OCCUPANCY SPACE CHECK
        '
        If txtGuestName.Text = "" Then
            MessageBox.Show("Please select a guest that is booking the chalet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf dtpCheckIn.Text = dtpCheckOut.Text Or dtpCheckIn.Value > dtpCheckOut.Value Then
            MessageBox.Show("Please check the booking date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtPax.Text = "" Then
            MessageBox.Show("Please specify the amount of adults staying!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf txtPax.Text > 80 - (unavaich * 4) Then
            MessageBox.Show("There aren't enough chalets to accomodate amount of guests!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        '
        ' OCCUPANCY MINIMUM CHECK
        '
        Dim paxvalue As Integer
        paxvalue = txtPax.Text
        Dim result As Double
        result = paxvalue / 4
        Dim minimum As Integer
        minimum = Math.Ceiling(result)

        If addedchalets < minimum Then
            MessageBox.Show("Chalets selected not enough to accomodate guests!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ''
        '' AVAILABILITY CHECK
        ''
        'n = 0
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

        conn.Open()

        For x = 1 To addedchalets
            sql = "SELECT * FROM Reservation WHERE (@checkindate >= CheckIn_Date AND ChaletNumber_FK = @chaletnumber) OR (@checkindate <= CheckIn_Date AND @checkoutdate >= CheckIn_Date AND ChaletNumber_FK = @chaletnumber)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@checkindate", dtpCheckIn.Text)
            cmd.Parameters.AddWithValue("@checkoutdate", dtpCheckOut.Text)
            cmd.Parameters.AddWithValue("@chaletnumber", checkedchalet(n))

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                MsgBox("Chalets selected are unavailable on specified date!")
                Exit Sub
            End If
            dr.Close()
            n += 1
        Next
        '
        ' PRICE CALCULATION
        '
        Dim StartTime, EndTime As DateTime
        Dim TimeSpan As TimeSpan
        StartTime = dtpCheckIn.Text
        EndTime = dtpCheckOut.Text
        TimeSpan = EndTime.Subtract(StartTime)
        dayduration = TimeSpan.Days

        ChaletTotal = (standardchalets * dayduration * 150) + (supremechalets * dayduration * 250)
        ChaletDeposit = (standardchalets * dayduration * 150 * 0.4) + (supremechalets * dayduration * 250 * 0.4)

        Dim TrolleyNew As New Cart
        TrolleyNew.ShowDialog()
    End Sub
End Class