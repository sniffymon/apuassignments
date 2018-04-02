Imports System.Data.SqlClient
Public Class ExtendBooking
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql, guestnostorage As String
    Private Sub ExtendStay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

        conn.Open()
        sql = "SELECT ChaletNumber_FK FROM Reservation WHERE Reservation_Status ='True'"

        Dim chaletds As New DataSet
        Dim adptr As New SqlDataAdapter(sql, conn)
        adptr.Fill(chaletds, "BookedCH")

        Dim exdata As DataTable = chaletds.Tables("BookedCH")
        Dim row As DataRow

        For Each row In exdata.Rows
            DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).BackColor = Color.Red
        Next
        ' HIDE ALL EXISTING CHALET BUTTONS
        '
        For Each ctrl As Control In Me.tlpChaletButtons.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = False
            End If
        Next
        'Start Loading For Guest ID In Search ComboBox
        '

        sql = "SELECT Guest_ID_PassNum FROM GuestDetail"
        cmd = New SqlCommand(sql, conn)


        dr = cmd.ExecuteReader

        If dr.HasRows Then
            While (dr.Read())
                CboGuestID.Items.Add(dr(0))
            End While
        Else
            CboGuestID.Items.Add("No Existing Guests")
        End If
        dr.Close()
        conn.Close()
    End Sub

    Private Sub cboGuestID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGuestID.SelectedIndexChanged

        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        'conn = New SqlConnection("Server=ASLEYTAN38A5\SQLEXPRESS;Database=SparrowsResort;Trusted_Connection=True;")

        conn.Open()
        'GUEST DETAIL SECTION START
        '
        sql = "SELECT GuestNo, Guest_Name, Guest_Contact_No, Guest_Email FROM GuestDetail WHERE 
[Guest_ID_PassNum]=@guestid"

        'Creating 1st Instance of SQL Command
        '
        cmd = New SqlCommand(sql, conn)
        'Determining Parameters (NEEDED TO AVOID SQL INJECTION)
        '
        cmd.Parameters.AddWithValue("@guestid", CboGuestID.Text)

        dr = cmd.ExecuteReader

        If dr.Read() Then
            guestnostorage = dr(0)
            txtGuestName.Text = dr(1)
            txtGuestMobile.Text = dr(2)
            txtGuestEmail.Text = dr(3)
        End If

        dr.Close()
        ' Select specific guests chalet from database 
        '
        sql = "SELECT ChaletNumber_FK FROM Reservation WHERE GuestNo_FK=@guestno AND Reservation_Status = 'True'"

        Dim chaletds As New DataSet
        cmd = New SqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@guestno", guestnostorage)
        Dim adptr As New SqlDataAdapter(cmd)
        adptr.Fill(chaletds, "SpecifiedCH")

        Dim exdata As DataTable = chaletds.Tables("SpecifiedCH")
        Dim row As DataRow

        lblChaletSpec.Visible = True
        For Each ctrl As Control In Me.tlpChaletButtons.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Visible = False
            End If
        Next

        For Each row In exdata.Rows
            DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).Visible = True
            lblChaletSpec.Visible = False
        Next
        conn.Close()
    End Sub

    Private Sub ChaletButtons_Click(sender As Object, e As EventArgs) Handles btnCH001.Click, btnCH002.Click, btnCH003.Click, btnCH004.Click, btnCH005.Click, btnCH006.Click, btnCH007.Click, btnCH008.Click, btnCH009.Click, btnCH010.Click, btnCH011.Click, btnCH012.Click, btnCH013.Click, btnCH014.Click, btnCH015.Click, btnCH016.Click, btnCH017.Click, btnCH018.Click, btnCH019.Click, btnCH020.Click
        AdminChaletInfo.clickedchalet = "Chalet " & sender.text
        AdminChaletInfo.clickedchaletCH = "CH0" & sender.text
        ChaletExtend.Show()
    End Sub
End Class