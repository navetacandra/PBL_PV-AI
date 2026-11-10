<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MhsListView
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
        Label1 = New Label()
        NameMhsInput = New TextBox()
        Label2 = New Label()
        NimMhsInput = New TextBox()
        JurusanMhsInput = New ComboBox()
        Label = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SemesterMhsInput = New TextBox()
        KelasMhsInput = New TextBox()
        SimpanMhs = New Button()
        DetailsMhs = New Button()
        DataGridView1 = New DataGridView()
        NIM = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        Jurusan = New DataGridViewTextBoxColumn()
        Prodi = New DataGridViewTextBoxColumn()
        Semester = New DataGridViewTextBoxColumn()
        Kelas = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        ProdiMhsInput = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' NameMhsInput
        ' 
        NameMhsInput.Location = New Point(123, 100)
        NameMhsInput.Name = "NameMhsInput"
        NameMhsInput.Size = New Size(249, 31)
        NameMhsInput.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 25)
        Label2.TabIndex = 2
        Label2.Text = "NIM"
        ' 
        ' NimMhsInput
        ' 
        NimMhsInput.Location = New Point(123, 54)
        NimMhsInput.Name = "NimMhsInput"
        NimMhsInput.Size = New Size(249, 31)
        NimMhsInput.TabIndex = 3
        ' 
        ' JurusanMhsInput
        ' 
        JurusanMhsInput.DropDownStyle = ComboBoxStyle.DropDownList
        JurusanMhsInput.FormattingEnabled = True
        JurusanMhsInput.Items.AddRange(New Object() {"TIK"})
        JurusanMhsInput.Location = New Point(123, 152)
        JurusanMhsInput.Name = "JurusanMhsInput"
        JurusanMhsInput.Size = New Size(249, 33)
        JurusanMhsInput.TabIndex = 4
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(27, 160)
        Label.Name = "Label"
        Label.Size = New Size(71, 25)
        Label.TabIndex = 5
        Label.Text = "Jurusan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 25)
        Label3.TabIndex = 6
        Label3.Text = "Prodi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 344)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 25)
        Label4.TabIndex = 8
        Label4.Text = "Semester"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 394)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 25)
        Label5.TabIndex = 9
        Label5.Text = "Kelas"
        ' 
        ' SemesterMhsInput
        ' 
        SemesterMhsInput.Location = New Point(126, 338)
        SemesterMhsInput.Name = "SemesterMhsInput"
        SemesterMhsInput.Size = New Size(246, 31)
        SemesterMhsInput.TabIndex = 10
        ' 
        ' KelasMhsInput
        ' 
        KelasMhsInput.Location = New Point(126, 388)
        KelasMhsInput.Name = "KelasMhsInput"
        KelasMhsInput.Size = New Size(246, 31)
        KelasMhsInput.TabIndex = 11
        ' 
        ' SimpanMhs
        ' 
        SimpanMhs.Location = New Point(126, 438)
        SimpanMhs.Name = "SimpanMhs"
        SimpanMhs.Size = New Size(112, 34)
        SimpanMhs.TabIndex = 12
        SimpanMhs.Text = "Simpan"
        SimpanMhs.UseVisualStyleBackColor = True
        ' 
        ' DetailsMhs
        ' 
        DetailsMhs.Location = New Point(260, 438)
        DetailsMhs.Name = "DetailsMhs"
        DetailsMhs.Size = New Size(112, 34)
        DetailsMhs.TabIndex = 13
        DetailsMhs.Text = "Details"
        DetailsMhs.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {NIM, colNama, Jurusan, Prodi, Semester, Kelas})
        DataGridView1.Location = New Point(397, 54)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(929, 365)
        DataGridView1.TabIndex = 14
        ' 
        ' NIM
        ' 
        NIM.HeaderText = "NIM"
        NIM.MinimumWidth = 8
        NIM.Name = "NIM"
        NIM.Width = 150
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama"
        colNama.MinimumWidth = 8
        colNama.Name = "colNama"
        colNama.Width = 150
        ' 
        ' Jurusan
        ' 
        Jurusan.HeaderText = "Jurusan"
        Jurusan.MinimumWidth = 8
        Jurusan.Name = "Jurusan"
        Jurusan.Width = 150
        ' 
        ' Prodi
        ' 
        Prodi.HeaderText = "Prodi"
        Prodi.MinimumWidth = 8
        Prodi.Name = "Prodi"
        Prodi.Width = 150
        ' 
        ' Semester
        ' 
        Semester.HeaderText = "Semester"
        Semester.MinimumWidth = 8
        Semester.Name = "Semester"
        Semester.Width = 150
        ' 
        ' Kelas
        ' 
        Kelas.HeaderText = "Kelas"
        Kelas.MinimumWidth = 8
        Kelas.Name = "Kelas"
        Kelas.Width = 150
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(628, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(182, 30)
        Label6.TabIndex = 15
        Label6.Text = "Data Mahasiswa"
        ' 
        ' ProdiMhsInput
        ' 
        ProdiMhsInput.FormattingEnabled = True
        ProdiMhsInput.Items.AddRange(New Object() {"Teknik Informatika", "Teknik Multimedia Digital", "Teknik Multimedia Jaringan"})
        ProdiMhsInput.Location = New Point(126, 244)
        ProdiMhsInput.Name = "ProdiMhsInput"
        ProdiMhsInput.Size = New Size(246, 33)
        ProdiMhsInput.TabIndex = 16
        ' 
        ' MhsListView
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1358, 485)
        Controls.Add(ProdiMhsInput)
        Controls.Add(Label6)
        Controls.Add(DataGridView1)
        Controls.Add(DetailsMhs)
        Controls.Add(SimpanMhs)
        Controls.Add(KelasMhsInput)
        Controls.Add(SemesterMhsInput)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label)
        Controls.Add(JurusanMhsInput)
        Controls.Add(NimMhsInput)
        Controls.Add(Label2)
        Controls.Add(NameMhsInput)
        Controls.Add(Label1)
        Name = "MhsListView"
        Text = "FormDataMahasiswa"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameMhsInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NimMhsInput As TextBox
    Friend WithEvents JurusanMhsInput As ComboBox
    Friend WithEvents Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SemesterMhsInput As TextBox
    Friend WithEvents KelasMhsInput As TextBox
    Friend WithEvents SimpanMhs As Button
    Friend WithEvents DetailsMhs As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NIM As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents Jurusan As DataGridViewTextBoxColumn
    Friend WithEvents Prodi As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents Kelas As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label

    ' Event saat tombol Simpan diklik
    Private Sub SimpanMhs_Click(sender As Object, e As EventArgs) Handles SimpanMhs.Click
        If NimMhsInput.Text = "" Or NameMhsInput.Text = "" Or JurusanMhsInput.Text = "" Or ProdiMhsInput.Text = "" Or SemesterMhsInput.Text = "" Or KelasMhsInput.Text = "" Then
            MessageBox.Show("Harap isi semua bidang inputan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        DataGridView1.Rows.Add(NimMhsInput.Text, NameMhsInput.Text, JurusanMhsInput.Text, ProdiMhsInput.Text, SemesterMhsInput.Text, KelasMhsInput.Text)

        MessageBox.Show("Data Mahasiswa berhasil disimpan ke tabel!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        NimMhsInput.Clear()
        NameMhsInput.Clear()
        JurusanMhsInput.SelectedIndex = -1
        ProdiMhsInput.SelectedIndex = -1
        SemesterMhsInput.Clear()
        KelasMhsInput.Clear()
        NimMhsInput.Focus()
    End Sub

    Friend WithEvents ProdiMhsInput As ComboBox
End Class