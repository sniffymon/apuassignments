Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class AdminChaletInfo
    Public clickedchalet As String
    Public clickedchaletCH As String
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim searchmode As Boolean = False
    Dim chaletamt, sql, guestnostorage As String
    Private Sub AdminChaletInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

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
        sql = "SELECT ChaletNumber FROM Chalet INNER JOIN Reservation ON ChaletNumber = ChaletNumber_FK
               WHERE CheckIn_Date <= @date AND CheckOut_Date >= @date AND Reservation_Status = 'True'"

        Dim chaletds As New DataSet
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@date", dtpDateSpec.Value.ToString("yyyy-MM-dd"))
        Dim adptr As New SqlDataAdapter(cmd)
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

        cboGuestID.Items.Clear()
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
        ContextMenuStrip1.Show(sender, sender.Height, 0)
        clickedchalet = "Chalet " & sender.text
        clickedchaletCH = "CH0" & sender.text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cboGuestID.Text = "" Then
            MessageBox.Show("Please enter all needed information into the textboxes", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        searchmode = True

        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")


        'GUEST DETAIL SECTION START
        '
        sql = "SELECT GuestNo, Guest_Name, Guest_Contact_No, Guest_Email FROM GuestDetail WHERE 
[Guest_ID_PassNum]=@guestid"

        'Creating 1st Instance of SQL Command
        '
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
        '
        cmd.Parameters.AddWithValue("@guestid", cboGuestID.Text)

        Dim dr As SqlDataReader = cmd.ExecuteReader

        If dr.Read() Then
            guestnostorage = dr(0)
            txtGuestName.Text = dr(1)
            txtGuestMobile.Text = dr(2)
            txtGuestEmail.Text = dr(3)
        End If
        dr.Close()
        ' Request for only specified guest chalets on that day
        '
        sql = "SELECT ChaletNumber_FK FROM Reservation WHERE GuestNo_FK=@guestno AND CheckIn_Date <= @date AND CheckOut_Date >= @date"

        Dim chaletds As New DataSet
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@guestno", guestnostorage)
        cmd.Parameters.AddWithValue("@date", dtpDateSpec.Value.ToString("yyyy-MM-dd"))
        Dim adptr As New SqlDataAdapter(cmd)
        adptr.Fill(chaletds, "SpecifiedCH")

        Dim exdata As DataTable = chaletds.Tables("SpecifiedCH")
        Dim row As DataRow

        For Each ctrl As Control In Me.tlpChaletButtons.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = False
                lblChaletSpec.Visible = True
            End If
        Next

        For Each row In exdata.Rows
            DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).Visible = True
            DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).BackColor = Color.Red
            lblChaletSpec.Visible = False
        Next
        conn.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboGuestID.SelectedIndex = -1
        txtGuestName.Text = ""
        txtGuestEmail.Text = ""
        txtGuestMobile.Text = ""
        lblChaletSpec.Visible = False
        searchmode = False

        For Each ctrl As Control In Me.tlpChaletButtons.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = True
            End If
        Next

        AdminChaletInfo_Load(e, e)
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click, btnRight.Click
        Select Case sender.Name
            Case btnLeft.Name
                dtpDateSpec.Value = dtpDateSpec.Value.AddDays(-1)
            Case btnRight.Name
                dtpDateSpec.Value = dtpDateSpec.Value.AddDays(1)
        End Select
    End Sub

    Private Sub dtpDateSpec_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateSpec.ValueChanged
        For Each ctrl As Control In Me.tlpChaletButtons.Controls
            If TypeOf ctrl Is Button Then
                With ctrl
                    .BackColor = Color.White
                    .Visible = True
                End With
            End If
        Next
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

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
        Dim chaletds As New DataSet

        If searchmode = False Then
            sql = "SELECT ChaletNumber FROM Chalet INNER JOIN Reservation ON ChaletNumber = ChaletNumber_FK
               WHERE CheckIn_Date <= @date AND CheckOut_Date >= @date AND Reservation_Status = 'True'"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@date", dtpDateSpec.Value.ToString("yyyy-MM-dd"))
            Dim adptr As New SqlDataAdapter(cmd)
            adptr.Fill(chaletds, "BookedCH")

            Dim exdata As DataTable = chaletds.Tables("BookedCH")
            Dim row As DataRow

            For Each row In exdata.Rows
                DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).BackColor = Color.Red
            Next

        ElseIf searchmode = True Then
            sql = "SELECT ChaletNumber_FK FROM Reservation WHERE GuestNo_FK=@guestno AND CheckIn_Date <= @date AND CheckOut_Date >= @date"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@date", dtpDateSpec.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@guestno", guestnostorage)
            Dim adptr As New SqlDataAdapter(cmd)
            adptr.Fill(chaletds, "BookedCH")

            Dim exdata As DataTable = chaletds.Tables("BookedCH")
            Dim row As DataRow

            For Each ctrl As Control In Me.tlpChaletButtons.Controls
                If TypeOf ctrl Is Button Then
                    ctrl.Visible = False
                    lblChaletSpec.Visible = True
                End If
            Next


            For Each row In exdata.Rows
                DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).Visible = True
                DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).BackColor = Color.Red
                lblChaletSpec.Visible = False
            Next

        End If

        conn.Close()
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