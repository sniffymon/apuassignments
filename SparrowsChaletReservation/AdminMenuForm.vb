Public Class AdminMenuForm
    Dim adminchaletinfobool As Boolean = False
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GuestInfoEdit.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdminInfoPanel.Click
        AdminChaletInfo.TopLevel = False
        Me.pnlMainView.Controls.Add(AdminChaletInfo)
        If adminchaletinfobool = False Then
            btnAdminInfoPanel.BackColor = Color.FromArgb(50, 50, 50)
            adminchaletinfobool = True
            AdminChaletInfo.Show()
        ElseIf adminchaletinfobool = True Then
            btnAdminInfoPanel.BackColor = Color.FromArgb(64, 64, 64)
            adminchaletinfobool = False
            AdminChaletInfo.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SelectChaletForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GuestInfoEntry.ShowDialog()
    End Sub

    Private Sub AdminMenuForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GuestInfoEdit.Close()
        AdminChaletInfo.Close()
        SelectChaletForm.Close()
        GuestInfoEntry.Close()
    End Sub
End Class