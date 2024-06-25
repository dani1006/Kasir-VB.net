Imports MySql.Data.MySqlClient
Public Class buatakun
    Private Sub crt_Click(sender As Object, e As EventArgs) Handles crt.Click
        koneksi()
        cmd = New MySqlCommand("select * from login where Password = '" & crt_psd.Text & "'", con)
        drd = cmd.ExecuteReader
        drd.Read()
        If drd.HasRows Then
            MsgBox("Maaf Password Suadah Digunakan Silakan Ganti!")
        Else
            koneksi()
            Dim cmd = New MySqlCommand("insert into login values ('" & crt_usr.Text & "','" & crt_psd.Text & "')", con)
            cmd.ExecuteNonQuery()
            If crt_usr.Text = "" Or crt_psd.Text = "" Then
                MessageBox.Show("Perikas Username dan Password anda!!", "Upps!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim berhasil
                berhasil = MessageBox.Show("Akun berhasil dibuat! Mau langsung Login?", "Succes!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If berhasil = vbYes Then
                    crt_usr.Text = ""
                    crt_psd.Text = ""
                    awal.Show()
                    Me.Hide()
                Else
                End If
            End If
        End If
    End Sub

    Private Sub crt_psd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles crt_psd.KeyPress
        crt_psd.MaxLength = 7
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mbalek_Click(sender As Object, e As EventArgs) Handles mbalek.Click
        crt_usr.Text = ""
        crt_psd.Text = ""
        awal.Show()
        Me.Hide()
    End Sub
End Class