Imports MySql.Data.MySqlClient
Public Class databarang
    Sub tampil()
        koneksi()
        adpt = New MySqlDataAdapter("select * from databarang", con)
        dst = New DataSet
        adpt.Fill(dst)
        DataGridView1.DataSource = dst.Tables(0)
    End Sub
    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        koneksi()
        Dim cmd = New MySqlCommand("insert into databarang values ('" & produk.Text & "','" & harga.Text & "','" & stok.Text & "')", con)
        drd = cmd.ExecuteReader
        produk.Text = ""
        harga.Text = ""
        stok.Text = ""
        tampil()
    End Sub
    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        pilihan.Show()
        Me.Close()
    End Sub


    Dim p As Double
    Private Sub harga_TextChanged(sender As Object, e As EventArgs) Handles harga.TextChanged
        Try
            p = harga.Text
            harga.Text = Format(Val(p), "###,###")
            harga.SelectionStart = Len(harga.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles harga.KeyPress
        harga.MaxLength = 7
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
    Private Sub databarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub
End Class