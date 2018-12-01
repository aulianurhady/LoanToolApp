<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formPeminjamanBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvPreview = New System.Windows.Forms.DataGridView()
        Me.btAddNew = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.txtbx_PreviewTanggal = New System.Windows.Forms.TextBox()
        Me.txtbx_PreviewNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btClear = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grupInputNamaPeminjam = New System.Windows.Forms.GroupBox()
        Me.date_Pinjam = New System.Windows.Forms.DateTimePicker()
        Me.txtbx_NamaPeminjam = New System.Windows.Forms.TextBox()
        Me.grupInputPeminjamanAlat = New System.Windows.Forms.GroupBox()
        Me.btNowJamMasuk = New System.Windows.Forms.Button()
        Me.cbbx_DaftarAlat = New System.Windows.Forms.ComboBox()
        Me.btNowJamKeluar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbx_JamMasukS = New System.Windows.Forms.TextBox()
        Me.txtbx_JamMasukM = New System.Windows.Forms.TextBox()
        Me.txtbx_JamMasukH = New System.Windows.Forms.TextBox()
        Me.txtbx_JamKeluarS = New System.Windows.Forms.TextBox()
        Me.txtbx_JamKeluarM = New System.Windows.Forms.TextBox()
        Me.txtbx_JamKeluarH = New System.Windows.Forms.TextBox()
        Me.txtbx_Jumlah = New System.Windows.Forms.TextBox()
        Me.grupPreviewDataPeminjaman = New System.Windows.Forms.GroupBox()
        Me.btCreate = New System.Windows.Forms.Button()
        Me.btClearAll = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.dgvPeralatan = New System.Windows.Forms.DataGridView()
        Me.grupDaftarAlat = New System.Windows.Forms.GroupBox()
        Me.grupInputAlatBaru = New System.Windows.Forms.GroupBox()
        Me.btClearAlat = New System.Windows.Forms.Button()
        Me.btSimpanAlat = New System.Windows.Forms.Button()
        Me.txtbx_JumlahAlat = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbx_NamaAlat = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgvPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupInputNamaPeminjam.SuspendLayout()
        Me.grupInputPeminjamanAlat.SuspendLayout()
        Me.grupPreviewDataPeminjaman.SuspendLayout()
        CType(Me.dgvPeralatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupDaftarAlat.SuspendLayout()
        Me.grupInputAlatBaru.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Alat"
        '
        'dgvPreview
        '
        Me.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPreview.Enabled = False
        Me.dgvPreview.Location = New System.Drawing.Point(0, 75)
        Me.dgvPreview.Name = "dgvPreview"
        Me.dgvPreview.Size = New System.Drawing.Size(536, 128)
        Me.dgvPreview.TabIndex = 20
        '
        'btAddNew
        '
        Me.btAddNew.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddNew.Location = New System.Drawing.Point(24, 158)
        Me.btAddNew.Name = "btAddNew"
        Me.btAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btAddNew.TabIndex = 13
        Me.btAddNew.Text = "Tambah"
        Me.btAddNew.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelete.Location = New System.Drawing.Point(274, 158)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 23)
        Me.btDelete.TabIndex = 15
        Me.btDelete.Text = "Hapus"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'txtbx_PreviewTanggal
        '
        Me.txtbx_PreviewTanggal.Enabled = False
        Me.txtbx_PreviewTanggal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_PreviewTanggal.Location = New System.Drawing.Point(149, 47)
        Me.txtbx_PreviewTanggal.Name = "txtbx_PreviewTanggal"
        Me.txtbx_PreviewTanggal.Size = New System.Drawing.Size(211, 21)
        Me.txtbx_PreviewTanggal.TabIndex = 19
        '
        'txtbx_PreviewNama
        '
        Me.txtbx_PreviewNama.Enabled = False
        Me.txtbx_PreviewNama.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_PreviewNama.Location = New System.Drawing.Point(149, 17)
        Me.txtbx_PreviewNama.Name = "txtbx_PreviewNama"
        Me.txtbx_PreviewNama.Size = New System.Drawing.Size(211, 21)
        Me.txtbx_PreviewNama.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 14)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Jumlah"
        '
        'btClear
        '
        Me.btClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClear.Location = New System.Drawing.Point(149, 158)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(75, 23)
        Me.btClear.TabIndex = 14
        Me.btClear.Text = "Bersihkan"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 14)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Jam Keluar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 14)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Jam Masuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Peminjam"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 12)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Tanggal Pinjam"
        '
        'grupInputNamaPeminjam
        '
        Me.grupInputNamaPeminjam.BackColor = System.Drawing.Color.Transparent
        Me.grupInputNamaPeminjam.Controls.Add(Me.date_Pinjam)
        Me.grupInputNamaPeminjam.Controls.Add(Me.txtbx_NamaPeminjam)
        Me.grupInputNamaPeminjam.Controls.Add(Me.Label11)
        Me.grupInputNamaPeminjam.Controls.Add(Me.Label3)
        Me.grupInputNamaPeminjam.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupInputNamaPeminjam.Location = New System.Drawing.Point(12, 132)
        Me.grupInputNamaPeminjam.Name = "grupInputNamaPeminjam"
        Me.grupInputNamaPeminjam.Size = New System.Drawing.Size(376, 92)
        Me.grupInputNamaPeminjam.TabIndex = 18
        Me.grupInputNamaPeminjam.TabStop = False
        Me.grupInputNamaPeminjam.Text = "INPUT"
        '
        'date_Pinjam
        '
        Me.date_Pinjam.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_Pinjam.Location = New System.Drawing.Point(149, 58)
        Me.date_Pinjam.Name = "date_Pinjam"
        Me.date_Pinjam.Size = New System.Drawing.Size(200, 21)
        Me.date_Pinjam.TabIndex = 2
        '
        'txtbx_NamaPeminjam
        '
        Me.txtbx_NamaPeminjam.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_NamaPeminjam.Location = New System.Drawing.Point(149, 32)
        Me.txtbx_NamaPeminjam.Name = "txtbx_NamaPeminjam"
        Me.txtbx_NamaPeminjam.Size = New System.Drawing.Size(201, 21)
        Me.txtbx_NamaPeminjam.TabIndex = 1
        '
        'grupInputPeminjamanAlat
        '
        Me.grupInputPeminjamanAlat.BackColor = System.Drawing.Color.Transparent
        Me.grupInputPeminjamanAlat.Controls.Add(Me.btNowJamMasuk)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.cbbx_DaftarAlat)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.btNowJamKeluar)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.Label12)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.Label5)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.Label2)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.Label1)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.txtbx_JamMasukS)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.txtbx_JamMasukM)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.txtbx_JamMasukH)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.txtbx_JamKeluarS)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.txtbx_JamKeluarM)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.txtbx_JamKeluarH)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.txtbx_Jumlah)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.Label4)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.Label8)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.Label10)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.btClear)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.btDelete)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.btAddNew)
        Me.grupInputPeminjamanAlat.Controls.Add(Me.Label9)
        Me.grupInputPeminjamanAlat.Enabled = False
        Me.grupInputPeminjamanAlat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupInputPeminjamanAlat.Location = New System.Drawing.Point(12, 230)
        Me.grupInputPeminjamanAlat.Name = "grupInputPeminjamanAlat"
        Me.grupInputPeminjamanAlat.Size = New System.Drawing.Size(376, 192)
        Me.grupInputPeminjamanAlat.TabIndex = 19
        Me.grupInputPeminjamanAlat.TabStop = False
        Me.grupInputPeminjamanAlat.Text = "PERALATAN"
        '
        'btNowJamMasuk
        '
        Me.btNowJamMasuk.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNowJamMasuk.Location = New System.Drawing.Point(298, 118)
        Me.btNowJamMasuk.Name = "btNowJamMasuk"
        Me.btNowJamMasuk.Size = New System.Drawing.Size(72, 21)
        Me.btNowJamMasuk.TabIndex = 12
        Me.btNowJamMasuk.Text = "Sekarang"
        Me.btNowJamMasuk.UseVisualStyleBackColor = True
        '
        'cbbx_DaftarAlat
        '
        Me.cbbx_DaftarAlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbx_DaftarAlat.FormattingEnabled = True
        Me.cbbx_DaftarAlat.Location = New System.Drawing.Point(149, 36)
        Me.cbbx_DaftarAlat.Name = "cbbx_DaftarAlat"
        Me.cbbx_DaftarAlat.Size = New System.Drawing.Size(121, 23)
        Me.cbbx_DaftarAlat.TabIndex = 3
        '
        'btNowJamKeluar
        '
        Me.btNowJamKeluar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNowJamKeluar.Location = New System.Drawing.Point(298, 91)
        Me.btNowJamKeluar.Name = "btNowJamKeluar"
        Me.btNowJamKeluar.Size = New System.Drawing.Size(72, 21)
        Me.btNowJamKeluar.TabIndex = 8
        Me.btNowJamKeluar.Text = "Sekarang"
        Me.btNowJamKeluar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(242, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = ":"
        '
        'txtbx_JamMasukS
        '
        Me.txtbx_JamMasukS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_JamMasukS.Location = New System.Drawing.Point(258, 117)
        Me.txtbx_JamMasukS.MaxLength = 2
        Me.txtbx_JamMasukS.Name = "txtbx_JamMasukS"
        Me.txtbx_JamMasukS.Size = New System.Drawing.Size(34, 21)
        Me.txtbx_JamMasukS.TabIndex = 11
        '
        'txtbx_JamMasukM
        '
        Me.txtbx_JamMasukM.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_JamMasukM.Location = New System.Drawing.Point(205, 117)
        Me.txtbx_JamMasukM.MaxLength = 2
        Me.txtbx_JamMasukM.Name = "txtbx_JamMasukM"
        Me.txtbx_JamMasukM.Size = New System.Drawing.Size(33, 21)
        Me.txtbx_JamMasukM.TabIndex = 10
        '
        'txtbx_JamMasukH
        '
        Me.txtbx_JamMasukH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_JamMasukH.Location = New System.Drawing.Point(149, 117)
        Me.txtbx_JamMasukH.MaxLength = 2
        Me.txtbx_JamMasukH.Name = "txtbx_JamMasukH"
        Me.txtbx_JamMasukH.Size = New System.Drawing.Size(34, 21)
        Me.txtbx_JamMasukH.TabIndex = 9
        '
        'txtbx_JamKeluarS
        '
        Me.txtbx_JamKeluarS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_JamKeluarS.Location = New System.Drawing.Point(258, 91)
        Me.txtbx_JamKeluarS.MaxLength = 2
        Me.txtbx_JamKeluarS.Name = "txtbx_JamKeluarS"
        Me.txtbx_JamKeluarS.Size = New System.Drawing.Size(34, 21)
        Me.txtbx_JamKeluarS.TabIndex = 7
        '
        'txtbx_JamKeluarM
        '
        Me.txtbx_JamKeluarM.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_JamKeluarM.Location = New System.Drawing.Point(204, 91)
        Me.txtbx_JamKeluarM.MaxLength = 2
        Me.txtbx_JamKeluarM.Name = "txtbx_JamKeluarM"
        Me.txtbx_JamKeluarM.Size = New System.Drawing.Size(34, 21)
        Me.txtbx_JamKeluarM.TabIndex = 6
        '
        'txtbx_JamKeluarH
        '
        Me.txtbx_JamKeluarH.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_JamKeluarH.Location = New System.Drawing.Point(149, 91)
        Me.txtbx_JamKeluarH.MaxLength = 2
        Me.txtbx_JamKeluarH.Name = "txtbx_JamKeluarH"
        Me.txtbx_JamKeluarH.Size = New System.Drawing.Size(34, 21)
        Me.txtbx_JamKeluarH.TabIndex = 5
        '
        'txtbx_Jumlah
        '
        Me.txtbx_Jumlah.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_Jumlah.Location = New System.Drawing.Point(149, 65)
        Me.txtbx_Jumlah.Name = "txtbx_Jumlah"
        Me.txtbx_Jumlah.Size = New System.Drawing.Size(34, 21)
        Me.txtbx_Jumlah.TabIndex = 4
        '
        'grupPreviewDataPeminjaman
        '
        Me.grupPreviewDataPeminjaman.BackColor = System.Drawing.Color.Transparent
        Me.grupPreviewDataPeminjaman.Controls.Add(Me.dgvPreview)
        Me.grupPreviewDataPeminjaman.Controls.Add(Me.txtbx_PreviewTanggal)
        Me.grupPreviewDataPeminjaman.Controls.Add(Me.Label6)
        Me.grupPreviewDataPeminjaman.Controls.Add(Me.Label7)
        Me.grupPreviewDataPeminjaman.Controls.Add(Me.txtbx_PreviewNama)
        Me.grupPreviewDataPeminjaman.Enabled = False
        Me.grupPreviewDataPeminjaman.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupPreviewDataPeminjaman.Location = New System.Drawing.Point(12, 428)
        Me.grupPreviewDataPeminjaman.Name = "grupPreviewDataPeminjaman"
        Me.grupPreviewDataPeminjaman.Size = New System.Drawing.Size(536, 203)
        Me.grupPreviewDataPeminjaman.TabIndex = 20
        Me.grupPreviewDataPeminjaman.TabStop = False
        Me.grupPreviewDataPeminjaman.Text = "HASIL DATA INPUTAN"
        '
        'btCreate
        '
        Me.btCreate.Enabled = False
        Me.btCreate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCreate.Location = New System.Drawing.Point(394, 139)
        Me.btCreate.Name = "btCreate"
        Me.btCreate.Size = New System.Drawing.Size(152, 72)
        Me.btCreate.TabIndex = 16
        Me.btCreate.Text = "Simpan ke database"
        Me.btCreate.UseVisualStyleBackColor = True
        '
        'btClearAll
        '
        Me.btClearAll.Enabled = False
        Me.btClearAll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClearAll.Location = New System.Drawing.Point(394, 244)
        Me.btClearAll.Name = "btClearAll"
        Me.btClearAll.Size = New System.Drawing.Size(152, 72)
        Me.btClearAll.TabIndex = 17
        Me.btClearAll.Text = "Bersihkan Semua"
        Me.btClearAll.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.Location = New System.Drawing.Point(394, 350)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(152, 72)
        Me.btExit.TabIndex = 18
        Me.btExit.Text = "Keluar"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'dgvPeralatan
        '
        Me.dgvPeralatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeralatan.Enabled = False
        Me.dgvPeralatan.Location = New System.Drawing.Point(0, 28)
        Me.dgvPeralatan.Name = "dgvPeralatan"
        Me.dgvPeralatan.Size = New System.Drawing.Size(373, 337)
        Me.dgvPeralatan.TabIndex = 21
        '
        'grupDaftarAlat
        '
        Me.grupDaftarAlat.BackColor = System.Drawing.Color.Transparent
        Me.grupDaftarAlat.Controls.Add(Me.dgvPeralatan)
        Me.grupDaftarAlat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupDaftarAlat.Location = New System.Drawing.Point(615, 266)
        Me.grupDaftarAlat.Name = "grupDaftarAlat"
        Me.grupDaftarAlat.Size = New System.Drawing.Size(373, 365)
        Me.grupDaftarAlat.TabIndex = 22
        Me.grupDaftarAlat.TabStop = False
        Me.grupDaftarAlat.Text = "Daftar Tools / Alat - Alat"
        '
        'grupInputAlatBaru
        '
        Me.grupInputAlatBaru.BackColor = System.Drawing.Color.Transparent
        Me.grupInputAlatBaru.Controls.Add(Me.btClearAlat)
        Me.grupInputAlatBaru.Controls.Add(Me.btSimpanAlat)
        Me.grupInputAlatBaru.Controls.Add(Me.txtbx_JumlahAlat)
        Me.grupInputAlatBaru.Controls.Add(Me.Label14)
        Me.grupInputAlatBaru.Controls.Add(Me.txtbx_NamaAlat)
        Me.grupInputAlatBaru.Controls.Add(Me.Label13)
        Me.grupInputAlatBaru.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupInputAlatBaru.Location = New System.Drawing.Point(615, 132)
        Me.grupInputAlatBaru.Name = "grupInputAlatBaru"
        Me.grupInputAlatBaru.Size = New System.Drawing.Size(373, 128)
        Me.grupInputAlatBaru.TabIndex = 23
        Me.grupInputAlatBaru.TabStop = False
        Me.grupInputAlatBaru.Text = "Input Tool Baru"
        '
        'btClearAlat
        '
        Me.btClearAlat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClearAlat.Location = New System.Drawing.Point(216, 98)
        Me.btClearAlat.Name = "btClearAlat"
        Me.btClearAlat.Size = New System.Drawing.Size(75, 23)
        Me.btClearAlat.TabIndex = 4
        Me.btClearAlat.Text = "Bersihkan"
        Me.btClearAlat.UseVisualStyleBackColor = True
        '
        'btSimpanAlat
        '
        Me.btSimpanAlat.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSimpanAlat.Location = New System.Drawing.Point(88, 98)
        Me.btSimpanAlat.Name = "btSimpanAlat"
        Me.btSimpanAlat.Size = New System.Drawing.Size(75, 23)
        Me.btSimpanAlat.TabIndex = 3
        Me.btSimpanAlat.Text = "Simpan"
        Me.btSimpanAlat.UseVisualStyleBackColor = True
        '
        'txtbx_JumlahAlat
        '
        Me.txtbx_JumlahAlat.Location = New System.Drawing.Point(133, 60)
        Me.txtbx_JumlahAlat.Name = "txtbx_JumlahAlat"
        Me.txtbx_JumlahAlat.Size = New System.Drawing.Size(50, 23)
        Me.txtbx_JumlahAlat.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 12)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Jumlah"
        '
        'txtbx_NamaAlat
        '
        Me.txtbx_NamaAlat.Location = New System.Drawing.Point(133, 31)
        Me.txtbx_NamaAlat.Name = "txtbx_NamaAlat"
        Me.txtbx_NamaAlat.Size = New System.Drawing.Size(215, 23)
        Me.txtbx_NamaAlat.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 12)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Nama Barang"
        '
        'formPeminjamanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PeminjamanBarang.My.Resources.Resources.BACKGROUND_APP
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 642)
        Me.Controls.Add(Me.grupInputAlatBaru)
        Me.Controls.Add(Me.grupDaftarAlat)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btClearAll)
        Me.Controls.Add(Me.btCreate)
        Me.Controls.Add(Me.grupPreviewDataPeminjaman)
        Me.Controls.Add(Me.grupInputPeminjamanAlat)
        Me.Controls.Add(Me.grupInputNamaPeminjam)
        Me.Name = "formPeminjamanBarang"
        Me.Text = "Aplikasi Peminjaman Alat"
        CType(Me.dgvPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupInputNamaPeminjam.ResumeLayout(False)
        Me.grupInputNamaPeminjam.PerformLayout()
        Me.grupInputPeminjamanAlat.ResumeLayout(False)
        Me.grupInputPeminjamanAlat.PerformLayout()
        Me.grupPreviewDataPeminjaman.ResumeLayout(False)
        Me.grupPreviewDataPeminjaman.PerformLayout()
        CType(Me.dgvPeralatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupDaftarAlat.ResumeLayout(False)
        Me.grupInputAlatBaru.ResumeLayout(False)
        Me.grupInputAlatBaru.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvPreview As DataGridView
    Friend WithEvents btAddNew As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents txtbx_PreviewTanggal As TextBox
    Friend WithEvents txtbx_PreviewNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btClear As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents grupInputNamaPeminjam As GroupBox
    Friend WithEvents grupInputPeminjamanAlat As GroupBox
    Friend WithEvents grupPreviewDataPeminjaman As GroupBox
    Friend WithEvents txtbx_NamaPeminjam As TextBox
    Friend WithEvents txtbx_Jumlah As TextBox
    Friend WithEvents btCreate As Button
    Friend WithEvents btClearAll As Button
    Friend WithEvents btExit As Button
    Friend WithEvents date_Pinjam As DateTimePicker
    Friend WithEvents txtbx_JamKeluarS As TextBox
    Friend WithEvents txtbx_JamKeluarM As TextBox
    Friend WithEvents txtbx_JamKeluarH As TextBox
    Friend WithEvents txtbx_JamMasukS As TextBox
    Friend WithEvents txtbx_JamMasukM As TextBox
    Friend WithEvents txtbx_JamMasukH As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btNowJamKeluar As Button
    Friend WithEvents cbbx_DaftarAlat As ComboBox
    Friend WithEvents dgvPeralatan As DataGridView
    Friend WithEvents btNowJamMasuk As Button
    Friend WithEvents grupDaftarAlat As GroupBox
    Friend WithEvents grupInputAlatBaru As GroupBox
    Friend WithEvents btClearAlat As Button
    Friend WithEvents btSimpanAlat As Button
    Friend WithEvents txtbx_JumlahAlat As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbx_NamaAlat As TextBox
    Friend WithEvents Label13 As Label
End Class
