Imports MySql.Data.MySqlClient
Public Class kasir
    Private Sub baru_Click(sender As Object, e As EventArgs) Handles baru.Click
        If totalsemua.Text = "0" Then
            MsgBox("Belum ada barang yang Dibeli")
        ElseIf b < totalsemua.Text Or dibyr.Text = "" Then
            MsgBox("Uang yang dibayarkan Kurang")
        Else
            koneksi()
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                cmd = New MySqlCommand("select * from databarang where barang ='" & DataGridView1.Rows(i).Cells(0).Value & "'", con)
                drd = cmd.ExecuteReader
                drd.Read()
                If drd.HasRows Then
                    cmd = New MySqlCommand("Update databarang set Stok = '" & drd.Item("Stok") - DataGridView1.Rows(i).Cells(2).Value & "'where barang= '" & DataGridView1.Rows(i).Cells(0).Value & "'", con)
                    drd.Close()
                    cmd.ExecuteNonQuery()
                End If
            Next
            DataGridView1.Rows.Clear()
            dibyr.Text = ""
            totalsemua.Text = "0"
        End If
    End Sub
    Private Sub mbalek_Click(sender As Object, e As EventArgs) Handles mbalek.Click
        pilihan.Show()
        Me.Close()
    End Sub


    Private Sub produk_TextChanged(sender As Object, e As EventArgs) Handles produk.TextChanged
        koneksi()
        cmd = New MySqlCommand("select barang,harga from databarang where barang = '" & produk.Text & "'", con)
        drd = cmd.ExecuteReader
        drd.Read()
        If drd.HasRows = True Then
            hrg.Text = drd.Item("harga")
            h = hrg.Text
            hrg.Text = Format(Val(h), "##,###")
        End If
    End Sub
    Dim b, h As Double
    Private Sub bnyk_TextChanged(sender As Object, e As EventArgs) Handles bnyk.TextChanged
        ttlbyr.Text = Val(h) * Val(bnyk.Text)
        ttlbyr.Text = Format(Val(ttlbyr.Text), "###,###")
    End Sub
    Private Sub bnyk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bnyk.KeyPress
        If e.KeyChar = Chr(13) Then
            koneksi()
            DataGridView1.Rows.Add(produk.Text, hrg.Text, bnyk.Text, ttlbyr.Text)
            total()
            bersih()
        End If
    End Sub
    Sub total()
        Dim jumlah As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            jumlah = jumlah + DataGridView1.Rows(i).Cells(3).Value
            totalsemua.Text = jumlah
            totalsemua.Text = Format(Val(totalsemua.Text), "###,###")
        Next
    End Sub
    Private Sub dibyr_TextChanged(sender As Object, e As EventArgs) Handles dibyr.TextChanged
        Try
            b = dibyr.Text
            dibyr.Text = Format(Val(b), "###,###")
            dibyr.SelectionStart = Len(dibyr.Text)
            sisa.Text = b - totalsemua.Text
            sisa.Text = Format(Val(sisa.Text), "###,###")
        Catch ex As Exception
            sisa.Text = "0"
        End Try
    End Sub
    Sub tampil()
        koneksi()
        cmd = New MySqlCommand("select barang from databarang ", con)
        adpt = New MySqlDataAdapter(cmd)
        dt = New DataTable
        adpt.Fill(dt)

        Dim a As New AutoCompleteStringCollection
        For i As Integer = 0 To dt.Rows.Count - 1
            a.Add(dt.Rows(i)("barang"))
        Next
        produk.AutoCompleteSource = AutoCompleteSource.CustomSource
        produk.AutoCompleteCustomSource = a
        produk.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    Private Sub kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = Chr(27) Then
            Dim i As Integer
            i = DataGridView1.CurrentCell.RowIndex
            Try
                DataGridView1.Rows.RemoveAt(i)
                total()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Sub bersih()
        produk.Text = ""
        bnyk.Text = ""
        hrg.Text = ""
    End Sub
End Class