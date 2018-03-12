Public Class MainAppForm
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        GuestInfoEdit.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GuestInfoEntry.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RegisterChalet.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GuestInfoSearch.ShowDialog()
    End Sub
End Class