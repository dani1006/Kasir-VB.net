Public Class pilihan
    Private Sub pay_Click(sender As Object, e As EventArgs) Handles pay.Click
        kasir.Show()
        Me.Hide()
    End Sub

    Private Sub tmbh_Click(sender As Object, e As EventArgs) Handles tmbh.Click
        databarang.Show()
        Me.Hide()
    End Sub

    Private Sub metu_Click(sender As Object, e As EventArgs) Handles metu.Click
        awal.Show()
        Me.Hide()
    End Sub
End Class