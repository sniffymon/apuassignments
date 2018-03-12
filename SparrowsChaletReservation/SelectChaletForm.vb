Imports System.Data.SqlClient
Public Class SelectChaletForm
    Dim conn As SqlConnection
    Dim sql As String
    Private Sub btnCH001_Click(sender As Object, e As EventArgs) Handles btnCH001.Click, btnCH002.Click, btnCH003.Click, btnCH004.Click, btnCH005.Click, btnCH006.Click, btnCH007.Click, btnCH008.Click, btnCH009.Click, btnCH010.Click, btnCH011.Click, btnCH012.Click, btnCH013.Click, btnCH014.Click, btnCH015.Click, btnCH016.Click, btnCH017.Click, btnCH018.Click, btnCH019.Click, btnCH020.Click
        AdminChaletInfo.clickedchalet = "Chalet " & sender.text
        AdminChaletInfo.clickedchaletCH = "CH0" & sender.text
        Dim ChaletEditNEW As New ChaletEdit

        ChaletEditNEW.Text = AdminChaletInfo.clickedchalet
        ChaletEditNEW.Show()

    End Sub

    Private Sub SelectChaletForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection("Server=den1.mssql1.gear.host;Database=sparrowsresort;User Id=sparrowsresort; Password=@Ssignment123;")
        conn.Open()
        Sql = "SELECT ChaletNumber FROM Chalet WHERE ChaletStatusOccupied='True'"

        Dim chaletds As New DataSet
        Dim adptr As New SqlDataAdapter(Sql, conn)
        adptr.Fill(chaletds, "BookedCH")

        Dim exdata As DataTable = chaletds.Tables("BookedCH")
        Dim row As DataRow

        For Each row In exdata.Rows
            DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).BackColor = Color.Red
            DirectCast(tlpChaletButtons.Controls("btn" & row(0)), Button).Enabled = True
        Next

    End Sub
End Class