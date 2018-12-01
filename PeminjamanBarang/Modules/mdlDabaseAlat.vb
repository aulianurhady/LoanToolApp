Imports System.Data.OleDb

Module mdlDatabaseDaftarAlat
    Public connDaftarAlat As OleDbConnection
    Public cmdDaftarAlat As OleDbCommand
    Public daDaftarAlat As OleDbDataAdapter
    Public drDaftarAlat As OleDbDataReader
    Public dsDaftarAlat As DataSet
    Public strDaftarAlat As String

    Public Sub openDBDaftarAlat()
        strDaftarAlat = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\database\dbDaftarPeralatan.mdb"
        connDaftarAlat = New OleDbConnection(strDaftarAlat)
        If connDaftarAlat.State = ConnectionState.Closed Then
            connDaftarAlat.Open()
        Else
            MsgBox("Error when connecting to database. Please contact Auliando for repairing it.", MsgBoxStyle.Information, "Attention")
            Exit Sub
        End If
    End Sub

    Public Sub closeDBDaftarAlat()
        If connDaftarAlat.State = ConnectionState.Open Then
            connDaftarAlat.Close()
        End If
    End Sub
End Module
