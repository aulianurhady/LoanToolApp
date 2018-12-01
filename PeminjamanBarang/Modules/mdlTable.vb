Module mdlTable
    Public table As DataTable

    Sub InitTable()
        table = New DataTable

        table.Columns.Add("No", GetType(Integer))
        table.Columns.Add("Alat", GetType(String))
        table.Columns.Add("Jumlah", GetType(Integer))
        table.Columns.Add("Jam Keluar", GetType(String))
        table.Columns.Add("Jam Masuk", GetType(String))
    End Sub

End Module
