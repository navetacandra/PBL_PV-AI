Public Class MataKuliahForm

    ' Variabel untuk menandai baris yang sedang diedit
    Private rowIndexToEdit As Integer = -1

    Private Sub MataKuliahForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi Kolom pada DataGridView
        dgvMataKuliah.Columns.Add("Kode", "Kode")
        dgvMataKuliah.Columns.Add("Nama", "Nama Mata Kuliah")
        dgvMataKuliah.Columns.Add("Semester", "Semester")
        dgvMataKuliah.Columns.Add("Status", "Status")

        ' Mengatur pilihan item pada ComboBox Status (MPK, MKKU)
        cmbStatus.Items.Add("MPK")
        cmbStatus.Items.Add("MKKU")

        ' Mengatur pilihan item pada ComboBox Semester (1 sampai 8)
        For i As Integer = 1 To 8
            cmbSemester.Items.Add(i.ToString())
        Next
    End Sub

    ' TOMBOL EDIT: Klik baris di tabel, lalu klik tombol ini untuk memanggil data ke kotak input
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvMataKuliah.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvMataKuliah.SelectedRows(0)

            If Not selectedRow.IsNewRow Then
                rowIndexToEdit = selectedRow.Index

                ' Masukkan data dari tabel kembali ke kotak input di atas
                txtKode.Text = selectedRow.Cells("Kode").Value.ToString()
                txtNama.Text = selectedRow.Cells("Nama").Value.ToString()
                cmbSemester.SelectedItem = selectedRow.Cells("Semester").Value.ToString()
                cmbStatus.SelectedItem = selectedRow.Cells("Status").Value.ToString()
            End If
        Else
            MessageBox.Show("Pilih baris tabel yang ingin diedit terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' TOMBOL SIMPAN: Berfungsi untuk menambah data baru ATAU menyimpan hasil editan
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi input agar tidak ada yang kosong
        If txtKode.Text.Trim() = "" OrElse txtNama.Text.Trim() = "" OrElse cmbSemester.SelectedIndex = -1 OrElse cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Semua kolom data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rowIndexToEdit >= 0 Then
            ' Jika sedang mode edit, perbarui data pada baris tersebut
            dgvMataKuliah.Rows(rowIndexToEdit).Cells("Kode").Value = txtKode.Text
            dgvMataKuliah.Rows(rowIndexToEdit).Cells("Nama").Value = txtNama.Text
            dgvMataKuliah.Rows(rowIndexToEdit).Cells("Semester").Value = cmbSemester.SelectedItem.ToString()
            dgvMataKuliah.Rows(rowIndexToEdit).Cells("Status").Value = cmbStatus.SelectedItem.ToString()

            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Kembalikan penanda edit ke posisi awal (-1)
            rowIndexToEdit = -1
        Else
            ' Jika bukan mode edit, tambahkan data baru sebagai baris ke bawah
            dgvMataKuliah.Rows.Add(txtKode.Text, txtNama.Text, cmbSemester.SelectedItem.ToString(), cmbStatus.SelectedItem.ToString())
            MessageBox.Show("Data baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Bersihkan kotak input setelah disimpan
        ClearForm()
    End Sub

    ' TOMBOL HAPUS: Menghapus baris yang dipilih dari tabel
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvMataKuliah.SelectedRows.Count > 0 Then
            If Not dgvMataKuliah.SelectedRows(0).IsNewRow Then
                dgvMataKuliah.Rows.RemoveAt(dgvMataKuliah.SelectedRows(0).Index)
                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                rowIndexToEdit = -1
            End If
        Else
            MessageBox.Show("Pilih baris tabel yang ingin dihapus terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Fungsi untuk mengosongkan kotak input
    Private Sub ClearForm()
        txtKode.Clear()
        txtNama.Clear()
        cmbSemester.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1
        txtKode.Focus()
    End Sub

End Class