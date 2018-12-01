Imports System.Data.OleDb

Module mdlDatabasePeminjamanBarang
    Public connPeminjamanBarang As OleDbConnection
    Public cmdPeminjamanBarang As OleDbCommand
    Public daPeminjamanBarang As OleDbDataAdapter
    Public drPeminjamanBarang As OleDbDataReader
    Public dsPeminjamanBarang As DataSet
    Public strPeminjamanBarang As String

    Public Sub openDBPeminjamanBarang()
        strPeminjamanBarang = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\database\dbPeminjamanAlat.mdb"
        connPeminjamanBarang = New OleDbConnection(strPeminjamanBarang)
        If connPeminjamanBarang.State = ConnectionState.Closed Then
            connPeminjamanBarang.Open()
        Else
            MsgBox("Error when connecting to database. Please contact Auliando for repairing it.", MsgBoxStyle.Information, "Attention")
            Exit Sub
        End If
    End Sub

    Public Sub closeDBPeminjamanBarang()
        If connPeminjamanBarang.State = ConnectionState.Open Then
            connPeminjamanBarang.Close()
        End If
    End Sub
End Module
