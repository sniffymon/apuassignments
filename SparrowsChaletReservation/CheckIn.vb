Imports System.Data.SqlClient
Public Class CheckIn
    Dim conn As New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Public sql, guestnomem As String
    Public checkedchalet As New List(Of String)
    Dim addedchalets, standardchalets, supremechalets, n, unavaich As Integer
    Public ChaletTotal, ChaletDeposit, dayduration As Double


    Private Sub ChaletButtons_Click(sender As Object, e As EventArgs) Handles btnCH001.Click, btnCH002.Click, btnCH003.Click, btnCH004.Click, btnCH005.Click, btnCH006.Click, btnCH007.Click, btnCH008.Click, btnCH009.Click, btnCH010.Click, btnCH011.Click, btnCH012.Click, btnCH013.Click, btnCH014.Click, btnCH015.Click, btnCH016.Click, btnCH017.Click, btnCH018.Click, btnCH019.Click, btnCH020.Click
        ' CHALET SELECTION COLORS AND SELECTION COUNT
        '
        Select Case sender.Text
            Case sender.Text < 11
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
            Case sender.Text > 10
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
        End Select
    End Sub

    Private Sub dtpCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckIn.ValueChanged, dtpCheckOut.ValueChanged
        ' SET MINIMUM DATE FOR CHECKOUT DTP TO BE 1 DAY MORE THEN CHECKIN DTP
        '
        If dtpCheckIn.Value <> dtpCheckIn.MinDate Then
            dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1)
        End If

        ' RESET VARIABLES TO AVOID MISCALCULATION
        '
        For Each ctrl As Control In Me.GboChalet.Controls
            If TypeOf ctrl Is Button Then
                With ctrl
                    .BackColor = Color.White
                End With
            End If
        Next
        addedchalets = 0
        standardchalets = 0
        supremechalets = 0
        checkedchalet.Clear()
        unavaich = 0

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
        ' QUERY TO VIEW WHICH CHALETS ARE BOOK IN DTP RANGE
        '
        Dim chaletds As New DataSet
        sql = "SELECT ChaletNumber_FK FROM Reservation WHERE (CheckIn_Date <= @cidate AND CheckOut_Date >= @cidate) OR (CheckIn_Date < @codate AND CheckOut_Date >= @codate) OR (@cidate < CheckIn_Date AND @codate > CheckOut_Date) OR (CheckOut_Date <= @cidate AND Reservation_Status = 'True' AND CheckOut_Date <= CONVERT(Date,GetDate()))"
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@cidate", dtpCheckIn.Value.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@codate", dtpCheckOut.Value.ToString("yyyy-MM-dd"))
        Dim adptr As New SqlDataAdapter(cmd)
        adptr.Fill(chaletds, "BookedCH")

        Dim exdata As DataTable = chaletds.Tables("BookedCH")
        Dim row As DataRow

        For Each row In exdata.Rows
            DirectCast(GboChalet.Controls("btn" & row(0)), Button).BackColor = Color.Red
            unavaich += 1
        Next
        conn.Close()
    End Sub
    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ' QUERY TO VIEW CHALETS BOOKED ON SYSTEM DATE (TODAY)
        '
        sql = "SELECT ChaletNumber_FK FROM Reservation WHERE (CheckIn_Date <= @date AND CheckOut_Date >= @date AND Reservation_Status = 'True') OR (CheckOut_Date <= @date AND Reservation_Status = 'True' AND GetDate() <= @date)"

        Dim chaletds As New DataSet
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@date", Date.Today)
        Dim adptr As New SqlDataAdapter(cmd)
        adptr.Fill(chaletds, "BookedCH")

        Dim exdata As DataTable = chaletds.Tables("BookedCH")
        Dim row As DataRow

        For Each row In exdata.Rows
            DirectCast(GboChalet.Controls("btn" & row(0)), Button).BackColor = Color.Red
            unavaich += 1
        Next


        'Start Loading For Guest ID In Search ComboBox
        '

        sql = "SELECT Guest_ID_PassNum FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)


        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.HasRows Then
            While (dr.Read())
                CboGuestID.Items.Add(dr(0))
            End While
        Else
            CboGuestID.Items.Add("No Existing Guests")
        End If
        conn.Close()

        dtpCheckIn.MinDate = Date.Today
        dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1)
    End Sub

    Private Sub cboGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGuestID.SelectedIndexChanged
        If CboGuestID.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'GUEST DETAIL SECTION START

        sql = "SELECT Guest_Name, Guest_Contact_No, Guest_Email, GuestNo FROM GuestDetail WHERE 
[Guest_ID_PassNum]=@guestid"

        'Creating 1st Instance of SQL Command
        cmd = New SqlCommand(sql, conn)
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
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        cmd.Parameters.AddWithValue("@guestid", CboGuestID.Text)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.Read() Then
            txtGuestName.Text = dr(0)
            txtGuestMobile.Text = dr(1)
            txtGuestEmail.Text = dr(2)
            guestnomem = dr(3)
        End If
        conn.Close()
    End Sub
    Private Sub txtPax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPax.KeyPress
        ' INPUT VALIDATION FOR GUEST COUNT
        '
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        '
        'INPUT VALIDATION & OCCUPANCY SPACE CHECK
        '
        If txtPax.Text = "0" Then
            MessageBox.Show("Please specify number of adults again!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtGuestName.Text) Then
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
            Exit Sub
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

        Dim TrolleyNew As New CartCheckIn
        TrolleyNew.ShowDialog()
    End Sub

    Public Sub RefreshForm(e As EventArgs)
        'CUSTOM SUB TO REFRESH FORM WHEN CALLED
        '
        Me.Controls.Clear()
        InitializeComponent()
        CheckIn_Load(e, e)
    End Sub
End Class