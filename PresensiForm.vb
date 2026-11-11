
Public Class PresensiForm

    ' Saat Form dibuka
    Private Sub PresensiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With dataPresensiGrid
            .Columns.Clear()
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True

            .Columns.Add("NIM", "NIM")
            .Columns.Add("Nama", "Nama")
            .Columns.Add("Telat", "Telat")
            .Columns.Add("Alfa", "Alfa")
            .Columns.Add("Sakit", "Sakit")
            .Columns.Add("Izin", "Izin")
        End With

    End Sub

    ' Tombol Simpan
    Private Sub simpanPresensiButton_Click(sender As Object, e As EventArgs) Handles simpanPresensiButton.Click

        If nimPresensiInput.Text = "" Or namaPresensiInput.Text = "" Then
            MessageBox.Show("NIM dan Nama harus diisi!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return
        End If

        dataPresensiGrid.Rows.Add(
            nimPresensiInput.Text,
            namaPresensiInput.Text,
            telatPresensiInput.Value,
            alfaPresensiInput.Value,
            sakitPresensiInput.Value,
            izinPresensiInput.Value
        )

        MessageBox.Show("Data presensi berhasil disimpan!")

    End Sub

    ' Tombol Hapus
    Private Sub hapusPresensiButton_Click(sender As Object, e As EventArgs) Handles hapusPresensiButton.Click

        If dataPresensiGrid.SelectedRows.Count > 0 Then

            Dim konfirmasi As DialogResult

            konfirmasi = MessageBox.Show(
                "Apakah kamu yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If konfirmasi = DialogResult.Yes Then

                dataPresensiGrid.Rows.RemoveAt(
                    dataPresensiGrid.SelectedRows(0).Index
                )

                MessageBox.Show("Data berhasil dihapus!")

            End If

        Else

            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!")

        End If

    End Sub


End Class
