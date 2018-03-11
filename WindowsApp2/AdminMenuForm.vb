Public Class AdminMenuForm
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GuestInfoEdit.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminChaletInfo.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SelectChaletForm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GuestInfoEntry.ShowDialog()
    End Sub
End Class