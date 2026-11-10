Public Class nilai

    Private Sub nilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tidak perlu Columns.Add karena kolom sudah dibuat via Designer
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Validasi input kosong
        If ComboBox1.Text = "" OrElse TextBox1.Text = "" OrElse TextBox2.Text = "" Then
            MessageBox.Show("Harap isi semua data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Validasi input Nilai harus berupa angka
        Dim nilaiAngka As Double
        If Not Double.TryParse(TextBox2.Text, nilaiAngka) Then
            MessageBox.Show("Nilai harus berupa angka!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Return
        End If

        ' 3. Masukkan data ke DataGridView (Gunakan nama kontrol input: ComboBox1, TextBox1, nilaiAngka)
        DataGridView1.Rows.Add(ComboBox1.Text, TextBox1.Text, nilaiAngka)

        ' 4. Reset form input untuk entry berikutnya
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Focus()
    End Sub

End Class