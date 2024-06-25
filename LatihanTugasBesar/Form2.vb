Imports MySql.Data.MySqlClient
Public Class awal
    Private Sub masuk_Click(sender As Object, e As EventArgs) Handles masuk.Click
        If usr.Text = "" Or psd.Text = "" Then
            MessageBox.Show("Perikas Username dan Password anda!!", "Upps!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            koneksi()
            cmd = New MySqlCommand("select * from login where username = '" & usr.Text & "' and Password = '" & psd.Text & "'", con)
            drd = cmd.ExecuteReader
            drd.Read()
            If drd.HasRows Then
                usr.Text = ""
                psd.Text = ""
                pilihan.Show()
                Me.Hide()
            Else
                MessageBox.Show("Maaf Username atau Password SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub buat_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles buat.LinkClicked
        buatakun.Show()
        Me.Hide()
    End Sub
    Private Sub psd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles psd.KeyPress
        psd.MaxLength = 7
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub see_CheckedChanged(sender As Object, e As EventArgs) Handles see.CheckedChanged
        If see.Checked Then
            psd.UseSystemPasswordChar = False
        Else
            psd.UseSystemPasswordChar = True
        End If
    End Sub
End Class