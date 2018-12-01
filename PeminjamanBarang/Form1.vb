Imports System.Data.OleDb

Public Class formPeminjamanBarang
    Public nomorPreview, nomorDB As Integer

    'Hapus semua text yang ada di textbox
    Sub ClearAllText()
        txtbx_NamaPeminjam.Clear()
        txtbx_Jumlah.Clear()
        txtbx_JamKeluarH.Clear()
        txtbx_JamKeluarM.Clear()
        txtbx_JamKeluarS.Clear()
        txtbx_JamMasukH.Clear()
        txtbx_JamMasukM.Clear()
        txtbx_JamMasukS.Clear()
        txtbx_NamaAlat.Clear()
        txtbx_JumlahAlat.Clear()
    End Sub

    'Menghapus semua inputan textbox di grup Peralatan
    Sub ClearToolGroupText()
        txtbx_Jumlah.Clear()
        txtbx_JamKeluarH.Clear()
        txtbx_JamKeluarM.Clear()
        txtbx_JamKeluarS.Clear()
        txtbx_JamMasukH.Clear()
        txtbx_JamMasukM.Clear()
        txtbx_JamMasukS.Clear()
        SetNullSelectedIdxComboBox()
    End Sub

    'Menghapus semua inputan textbox di grup Input Tool Baru
    Sub ClearInputToolText()
        txtbx_NamaAlat.Clear()
        txtbx_JumlahAlat.Clear()
    End Sub

    'Menghapus semua inputan textbox di grup Input
    Sub ClearInputNamaPeminjam()
        txtbx_NamaPeminjam.Clear()
    End Sub

    'Menghapus semua data textbox di grup Hasil Data Inputan
    Sub ClearDataPreview()
        txtbx_PreviewNama.Clear()
        txtbx_PreviewTanggal.Clear()
        ClearTable()
    End Sub

    'Menghapus semua inputan textbox jam masuk
    Sub ClearInputJamMasuk()
        txtbx_JamMasukH.Clear()
        txtbx_JamMasukM.Clear()
        txtbx_JamMasukS.Clear()
    End Sub

    'Menghapus semua inputan textbox jam keluar
    Sub ClearInputJamKeluar()
        txtbx_JamKeluarH.Clear()
        txtbx_JamKeluarM.Clear()
        txtbx_JamKeluarS.Clear()
    End Sub

    'Handle data dapat diinputkan user di grup Input
    Sub InputNamaPeminjamEnabled()
        grupInputNamaPeminjam.Enabled = True
    End Sub

    'Handle data tidak dapat diinputkan user di grup Input
    Sub InputNamaPeminjamDisabled()
        grupInputNamaPeminjam.Enabled = False
    End Sub

    'Handle data dapat diinputkan user di grup Peralatan
    Sub DataPinjamanEnabled()
        grupInputPeminjamanAlat.Enabled = True
    End Sub

    'Handle data tidak dapat diinputkan user di grup Peralatan
    Sub DataPinjamanDisabled()
        grupInputPeminjamanAlat.Enabled = False
    End Sub

    'Handle dapat diinputkan user di grup Hasil Data Inputan
    Sub DataPreviewEnabled()
        grupPreviewDataPeminjaman.Enabled = True
    End Sub

    'Handle data tidak dapat diinputkan user di grup Hasil Data Inputan
    Sub DataPreviewDisabled()
        grupPreviewDataPeminjaman.Enabled = False
    End Sub

    'Handle dapat diinputkan user di grup Hasil Data Inputan
    Sub InputAlatBaruEnabled()
        grupInputAlatBaru.Enabled = True
    End Sub

    'Handle tidak dapat diinputkan user di grup Hasil Data Inputan
    Sub InputAlatBaruDisabled()
        grupInputAlatBaru.Enabled = False
    End Sub

    'Handle dapat diinputkan user di grup Daftar Tool
    Sub DaftarAlatEnabled()
        grupDaftarAlat.Enabled = True
    End Sub

    'Handle dapat diinputkan user di grup Daftar Tool
    Sub DaftarAlatDisabled()
        grupDaftarAlat.Enabled = False
    End Sub

    'Mengatur fokus ke textbox nama peminjam
    Sub SetFocus()
        txtbx_NamaPeminjam.Focus()
    End Sub

    'Reset indeks combobox setelah dipilih user
    Sub SetNullSelectedIdxComboBox()
        cbbx_DaftarAlat.SelectedIndex = -1
    End Sub

    'Menghapus semua data di tabel preview
    Sub ClearTable()
        table.Clear()
    End Sub

    'Atur table Preview di data grid
    Sub SetTablePreview()
        dgvPreview.DataSource = table
        dgvPreview.Refresh()
    End Sub

    'Fungsi penaikkan 1 nomor
    Sub numPreviewIncrement()
        nomorPreview += 1
    End Sub

    'Fungsi penaikkan 1 nomor
    Sub numDBIncrement()
        nomorDB += 1
    End Sub

    'Fungsi getter untuk mendapat nilai data kode_peminjaman dari database
    Function getNumDBIncrement() As Integer
        Return nomorDB
    End Function

    'Fungsi dengan metode getter untuk mendapatkan nilai nomorPreview
    Function getNumPreviewIncrement() As Integer
        Return nomorPreview
    End Function

    'Handle pengambilan data kode_peminjaman yang terakhir diinput yang berada di database
    Sub getKodePeminjaman()
        nomorDB = 0

        cmdPeminjamanBarang = New OleDbCommand("Select kode_peminjaman From tDataPeminjamanBarang where kode_peminjaman IS NOT NULL", connPeminjamanBarang)
        drPeminjamanBarang = cmdPeminjamanBarang.ExecuteReader()

        While drPeminjamanBarang.Read()
            nomorDB = drPeminjamanBarang(0)
        End While
    End Sub

    'Handle pengambilan data-data dari database daftar peralatan
    Sub loadDataDaftarPeralatan()
        Dim tabel As DataTableCollection
        Dim sumber As New BindingSource

        dsDaftarAlat = New DataSet
        tabel = dsDaftarAlat.Tables

        Dim perintahSQL As String = "Select * From tDaftarPeralatan"
        daDaftarAlat = New OleDbDataAdapter(perintahSQL, connDaftarAlat)
        daDaftarAlat.Fill(dsDaftarAlat, "dbDaftarPeralatan")

        Dim tampilData As New DataView(tabel(0))
        sumber.DataSource = tampilData
        dgvPeralatan.DataSource = tampilData
    End Sub

    'Handle penugasan untuk mengisi item-item ke combobox dari data nama_barang di database daftar peralatan
    Sub fillComboBoxItems()
        cmdDaftarAlat = New OleDbCommand("Select nama_barang From tDaftarPeralatan", connDaftarAlat)
        drDaftarAlat = cmdDaftarAlat.ExecuteReader()

        While drDaftarAlat.Read()
            cbbx_DaftarAlat.Items.Add(drDaftarAlat(0).ToString())
        End While
    End Sub

    'Handle data tabel preview
    Sub addToTable(ByVal noAlat As Integer, ByVal alat As String, ByVal jumlahAlat As String, ByVal jamKeluar As String, ByVal jamMasuk As String)
        table.Rows.Add(noAlat, alat, jumlahAlat, jamKeluar, jamMasuk)

        SetTablePreview()
    End Sub

    'Inisialisasi awal saat program running
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call openDBPeminjamanBarang()
        Call openDBDaftarAlat()
        Call InitTable()

        SetTablePreview()
        loadDataDaftarPeralatan()

        fillComboBoxItems()

        ClearAllText()
        ClearDataPreview()
        SetFocus()

        getKodePeminjaman()
    End Sub

    'Handle ketika tombol mouse ditekan
    Private Sub btCreate_Click(sender As Object, e As EventArgs) Handles btCreate.Click
        If table.Rows.Count = 0 Then
            MsgBox("Oops... Some data are missing. Please, recheck again.")
            txtbx_NamaPeminjam.Focus()

            Exit Sub
        Else
            Call openDBPeminjamanBarang()

            For Each row As DataRow In table.Rows
                numDBIncrement()
                cmdPeminjamanBarang = New OleDbCommand("Select * From tDataPeminjamanBarang where kode_peminjaman=" & row.Field(Of Integer)(0), connPeminjamanBarang)
                drPeminjamanBarang = cmdPeminjamanBarang.ExecuteReader()
                drPeminjamanBarang.Read()
                If Not drPeminjamanBarang.HasRows Then
                    Dim saveData As String = "insert into tDataPeminjamanBarang(kode_peminjaman,nama_peminjam,tanggal_peminjaman,nama_alat,jumlah_pinjam,jam_keluar_alat,jam_masuk_alat)values" & "('" & getNumDBIncrement() & "','" & txtbx_NamaPeminjam.Text & "','" & date_Pinjam.Value.ToString() & "','" & row.Field(Of String)(1) & "','" & row.Field(Of Integer)(2) & "','" & row.Field(Of String)(3) & "','" & row.Field(Of String)(4) & "')"
                    cmdPeminjamanBarang = New OleDbCommand(saveData, connPeminjamanBarang)
                    cmdPeminjamanBarang.ExecuteNonQuery()
                End If
            Next

            MsgBox("The data are successfully saved!", MsgBoxStyle.Information, "Attention")

            ClearAllText()
            ClearDataPreview()
            SetFocus()

            Call closeDBPeminjamanBarang()

            InputNamaPeminjamEnabled()

            btCreate.Enabled = False
            btClearAll.Enabled = False
        End If
    End Sub

    Private Sub btAddNew_Click(sender As Object, e As EventArgs) Handles btAddNew.Click
        Dim keluarTime, masukTime As Date
        Dim keluarHour, keluarMinute, keluarSecond, masukHour, masukMinute, masukSecond As Integer
        Dim keluarTimeFormatted, masukTimeFormatted As String

        'Pengecekan jika ada textbox yang belum diisi
        If txtbx_NamaPeminjam.Text = "" Or cbbx_DaftarAlat.SelectedIndex = -1 Or txtbx_Jumlah.Text = "" Or txtbx_JamKeluarH.Text = "" Or txtbx_JamKeluarM.Text = "" Or txtbx_JamKeluarS.Text = "" Or txtbx_JamMasukH.Text = "" Or txtbx_JamMasukM.Text = "" Or txtbx_JamMasukS.Text = "" Then
            MsgBox("Oops... Some data are missing. Please, recheck again.")

            Exit Sub
        ElseIf (Convert.ToInt32(txtbx_JamKeluarH.Text) >= 24 Or Convert.ToInt32(txtbx_JamKeluarM.Text) >= 60 Or Convert.ToInt32(txtbx_JamKeluarS.Text) >= 60) Or (Convert.ToInt32(txtbx_JamMasukH.Text) >= 24 Or Convert.ToInt32(txtbx_JamMasukM.Text) >= 60 Or Convert.ToInt32(txtbx_JamMasukS.Text) >= 60) Then
            MsgBox("Oops... Some data must be right value. Please, recheck again.")

            Exit Sub
        Else
            'Matikan inputan pada group Input
            InputNamaPeminjamDisabled()

            'Menaikkan dengan 1 nomor setiap klik button Add New
            numPreviewIncrement()

            'Mengubah tipe data string dalam textbox ke tipe data integer
            keluarHour = Convert.ToInt32(txtbx_JamKeluarH.Text)
            keluarMinute = Convert.ToInt32(txtbx_JamKeluarM.Text)
            keluarSecond = Convert.ToInt32(txtbx_JamKeluarS.Text)
            keluarTime = TimeSerial(keluarHour, keluarMinute, keluarSecond)

            'Mengubah tipe data string dalam textbox ke tipe data integer
            masukHour = Convert.ToInt32(txtbx_JamMasukH.Text)
            masukMinute = Convert.ToInt32(txtbx_JamMasukM.Text)
            masukSecond = Convert.ToInt32(txtbx_JamMasukS.Text)
            masukTime = TimeSerial(masukHour, masukMinute, masukSecond)

            'Mengubah format tipe data date ke tipe data string
            keluarTimeFormatted = Format(keluarTime, "hh:mm:ss tt")
            masukTimeFormatted = Format(masukTime, "hh:mm:ss tt")

            'Memasukkan inputan nama dan tanggal ke data preview
            If txtbx_PreviewNama.Text = String.Empty And txtbx_PreviewTanggal.Text = String.Empty Then
                txtbx_PreviewNama.Text = txtbx_NamaPeminjam.Text
                txtbx_PreviewTanggal.Text = date_Pinjam.Value.ToString()
            End If

            'Tambahkan ke tabel bagian preview
            addToTable(getNumPreviewIncrement(), cbbx_DaftarAlat.SelectedItem.ToString(), txtbx_Jumlah.Text, keluarTimeFormatted, masukTimeFormatted)

            ClearToolGroupText()
            SetFocus()
            InputAlatBaruDisabled()
            DaftarAlatDisabled()

            btCreate.Enabled = True
            btClearAll.Enabled = True
        End If
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        ClearToolGroupText()
        InputAlatBaruDisabled()
        DaftarAlatDisabled()
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        ClearDataPreview()
        InputNamaPeminjamEnabled()
        SetNullSelectedIdxComboBox()
    End Sub

    Private Sub btClearAll_Click(sender As Object, e As EventArgs) Handles btClearAll.Click
        ClearDataPreview()
        InputNamaPeminjamEnabled()
        ClearInputNamaPeminjam()
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Dim result As Integer = MsgBox("Are you sure to exit this application?", MsgBoxStyle.OkCancel, "Attention!")

        If result = DialogResult.OK Then
            Close()
        End If
    End Sub

    Private Sub btNowJamKeluar_Click(sender As Object, e As EventArgs) Handles btNowJamKeluar.Click
        If (txtbx_NamaPeminjam.Text = "") Then
            MsgBox("Please, input Nama Peminjam first")

            Exit Sub
        Else
            ClearInputJamKeluar()

            txtbx_JamKeluarH.Text = Convert.ToString(TimeOfDay.Hour)
            txtbx_JamKeluarM.Text = Convert.ToString(TimeOfDay.Minute)
            txtbx_JamKeluarS.Text = Convert.ToString(TimeOfDay.Second)
        End If
    End Sub

    Private Sub btNowJamMasuk_Click(sender As Object, e As EventArgs) Handles btNowJamMasuk.Click
        If (txtbx_NamaPeminjam.Text = "") Then
            MsgBox("Please, input Nama Peminjam first")

            Exit Sub
        Else
            ClearInputJamMasuk()

            txtbx_JamMasukH.Text = Convert.ToString(TimeOfDay.Hour)
            txtbx_JamMasukM.Text = Convert.ToString(TimeOfDay.Minute)
            txtbx_JamMasukS.Text = Convert.ToString(TimeOfDay.Second)
        End If
    End Sub

    Private Sub btClearAlat_Click(sender As Object, e As EventArgs) Handles btClearAlat.Click
        ClearInputToolText()
        DataPinjamanDisabled()
        DataPreviewDisabled()
    End Sub

    Private Sub btSimpanAlat_Click(sender As Object, e As EventArgs) Handles btSimpanAlat.Click
        If txtbx_NamaAlat.Text = "" Or txtbx_JumlahAlat.Text = "" Then
            MsgBox("Oops... Some data are missing. Please, recheck again.")
            txtbx_NamaAlat.Focus()

            Exit Sub
        Else
            Call openDBDaftarAlat()

            cmdDaftarAlat = New OleDbCommand("Select * From tDaftarPeralatan", connDaftarAlat)
            drDaftarAlat = cmdDaftarAlat.ExecuteReader()
            drDaftarAlat.Read()
            Dim saveDataAlat As String = "insert into tDaftarPeralatan(nama_barang,jumlah_barang)values" & "('" & txtbx_NamaAlat.Text & "','" & txtbx_JumlahAlat.Text & "')"
            cmdDaftarAlat = New OleDbCommand(saveDataAlat, connDaftarAlat)
            cmdDaftarAlat.ExecuteNonQuery()

            MsgBox("The data are successfully saved!", MsgBoxStyle.Information, "Attention")

            ClearInputToolText()
            loadDataDaftarPeralatan()
            fillComboBoxItems()
            DataPinjamanDisabled()
            DataPreviewDisabled()

            Call closeDBDaftarAlat()
        End If
    End Sub
    'Batas handle event tekan mouse

    Private Sub txtbx_NamaAlat_TextChanged(sender As Object, e As EventArgs) Handles txtbx_NamaAlat.TextChanged
        If Not txtbx_NamaAlat.Text = "" Then
            InputNamaPeminjamDisabled()
        Else
            InputNamaPeminjamEnabled()
        End If
    End Sub

    Private Sub txtbx_JumlahAlat_TextChanged(sender As Object, e As EventArgs) Handles txtbx_JumlahAlat.TextChanged
        If Not txtbx_JumlahAlat.Text = "" Then
            InputNamaPeminjamDisabled()
            DataPinjamanDisabled()
            DataPreviewDisabled()
        Else
            InputNamaPeminjamEnabled()
            InputAlatBaruEnabled()
            DataPreviewEnabled()
        End If
    End Sub

    Private Sub txtbx_NamaPeminjam_TextChanged(sender As Object, e As EventArgs) Handles txtbx_NamaPeminjam.TextChanged
        If Not txtbx_NamaPeminjam.Text = "" Then
            InputAlatBaruDisabled()
            DaftarAlatDisabled()
            DataPinjamanEnabled()
            DataPreviewEnabled()
        Else
            InputAlatBaruEnabled()
            DaftarAlatEnabled()
            DataPinjamanDisabled()
            DataPreviewDisabled()
        End If
    End Sub

    Private Sub txtbx_Jumlah_TextChanged(sender As Object, e As EventArgs) Handles txtbx_Jumlah.TextChanged
        If Not txtbx_Jumlah.Text = "" Then
            InputAlatBaruDisabled()
        Else
            InputAlatBaruEnabled()
        End If
    End Sub

    Private Sub formPeminjamanBarang_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Call closeDBPeminjamanBarang()
        Call closeDBDaftarAlat()
    End Sub

    'Menghandle textbox supaya outputnya hanya nomor
    Private Sub txtbx_JamKeluarH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_JamKeluarH.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbx_JamKeluarM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_JamKeluarM.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbx_JamKeluarS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_JamKeluarS.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbx_JamMasukH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_JamMasukH.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbx_JamMasukM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_JamMasukM.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbx_JamMasukS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_JamMasukS.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbx_JumlahAlat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_JumlahAlat.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbx_Jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_Jumlah.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    'batas handle nomor
End Class
