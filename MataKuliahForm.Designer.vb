<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MataKuliahForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtKode = New TextBox()
        Label2 = New Label()
        txtNama = New TextBox()
        cmbSemester = New ComboBox()
        Label3 = New Label()
        cmbStatus = New ComboBox()
        Label4 = New Label()
        dgvMataKuliah = New DataGridView()
        Kode = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        Semester = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        btnEdit = New Button()
        btnSimpan = New Button()
        btnHapus = New Button()
        CType(dgvMataKuliah, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 0
        Label1.Text = "Kode:"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(76, 9)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(121, 23)
        txtKode.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nama:"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(76, 38)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(121, 23)
        txtNama.TabIndex = 3
        ' 
        ' cmbSemester
        ' 
        cmbSemester.FormattingEnabled = True
        cmbSemester.Items.AddRange(New Object() {"Semester 1", "Semester 2", "Semester 3", "Semester 4", "Semester 5", "Semester 6", "Semester 7", "Semester 8"})
        cmbSemester.Location = New Point(76, 67)
        cmbSemester.Name = "cmbSemester"
        cmbSemester.Size = New Size(121, 23)
        cmbSemester.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 5
        Label3.Text = "Semester:"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"MPK", "MKKU"})
        cmbStatus.Location = New Point(76, 96)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(121, 23)
        cmbStatus.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 7
        Label4.Text = "Status:"
        ' 
        ' dgvMataKuliah
        ' 
        dgvMataKuliah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMataKuliah.Columns.AddRange(New DataGridViewColumn() {Kode, Nama, Semester, Status})
        dgvMataKuliah.Location = New Point(226, 12)
        dgvMataKuliah.Name = "dgvMataKuliah"
        dgvMataKuliah.Size = New Size(444, 187)
        dgvMataKuliah.TabIndex = 8
        ' 
        ' Kode
        ' 
        Kode.HeaderText = "Kode"
        Kode.Name = "Kode"
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama"
        Nama.Name = "Nama"
        ' 
        ' Semester
        ' 
        Semester.HeaderText = "Semester"
        Semester.Name = "Semester"
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(12, 147)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(93, 147)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "SImpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(49, 176)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' MataKuliahForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(693, 223)
        Controls.Add(btnHapus)
        Controls.Add(btnSimpan)
        Controls.Add(btnEdit)
        Controls.Add(dgvMataKuliah)
        Controls.Add(Label4)
        Controls.Add(cmbStatus)
        Controls.Add(Label3)
        Controls.Add(cmbSemester)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(txtKode)
        Controls.Add(Label1)
        Name = "MataKuliahForm"
        Text = "MataKuliahForm"
        CType(dgvMataKuliah, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvMataKuliah As DataGridView
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
End Class
