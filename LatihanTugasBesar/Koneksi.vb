Imports MySql.Data.MySqlClient
Module mdlkoneksi
    Public con As New MySqlConnection
    Public cmd As MySqlCommand
    Public adpt As MySqlDataAdapter
    Public dst As DataSet
    Public dt As DataTable
    Public drd As MySqlDataReader
    Public MyOb As String
    Public Sub koneksi()
        MyOb = "server=localhost;user id=root;" & "password=;database=loginkasir"
        con = New MySqlConnection(MyOb)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

End Module