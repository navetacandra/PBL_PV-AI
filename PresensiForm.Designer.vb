<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresensiForm
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
        PresensiLblJudul = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        telatPresensiInput = New NumericUpDown()
        sakitPresensiInput = New NumericUpDown()
        izinPresensiInput = New NumericUpDown()
        alfaPresensiInput = New NumericUpDown()
        nimPresensiInput = New TextBox()
        namaPresensiInput = New TextBox()
        hapusPresensiButton = New Button()
        simpanPresensiButton = New Button()
        dataPresensiGrid = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        inputPresensiGroup = New GroupBox()
        CType(telatPresensiInput, ComponentModel.ISupportInitialize).BeginInit()
        CType(sakitPresensiInput, ComponentModel.ISupportInitialize).BeginInit()
        CType(izinPresensiInput, ComponentModel.ISupportInitialize).BeginInit()
        CType(alfaPresensiInput, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataPresensiGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PresensiLblJudul
        ' 
        PresensiLblJudul.AutoSize = True
        PresensiLblJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PresensiLblJudul.Location = New Point(427, 9)
        PresensiLblJudul.Name = "PresensiLblJudul"
        PresensiLblJudul.Size = New Size(266, 25)
        PresensiLblJudul.TabIndex = 0
        PresensiLblJudul.Text = "DATA PRESENSI MAHASISWA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 25)
        Label2.TabIndex = 2
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 25)
        Label3.TabIndex = 3
        Label3.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(44, 256)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 25)
        Label4.TabIndex = 4
        Label4.Text = "Sakit"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(274, 365)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 25)
        Label5.TabIndex = 5
        Label5.Text = "Telat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 365)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 25)
        Label6.TabIndex = 6
        Label6.Text = "Alfa"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(274, 256)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 25)
        Label7.TabIndex = 7
        Label7.Text = "Izin"
        ' 
        ' telatPresensiInput
        ' 
        telatPresensiInput.Location = New Point(274, 396)
        telatPresensiInput.Name = "telatPresensiInput"
        telatPresensiInput.Size = New Size(180, 31)
        telatPresensiInput.TabIndex = 8
        ' 
        ' sakitPresensiInput
        ' 
        sakitPresensiInput.Location = New Point(46, 292)
        sakitPresensiInput.Name = "sakitPresensiInput"
        sakitPresensiInput.Size = New Size(180, 31)
        sakitPresensiInput.TabIndex = 9
        ' 
        ' izinPresensiInput
        ' 
        izinPresensiInput.Location = New Point(274, 289)
        izinPresensiInput.Name = "izinPresensiInput"
        izinPresensiInput.Size = New Size(180, 31)
        izinPresensiInput.TabIndex = 10
        ' 
        ' alfaPresensiInput
        ' 
        alfaPresensiInput.Location = New Point(46, 396)
        alfaPresensiInput.Name = "alfaPresensiInput"
        alfaPresensiInput.Size = New Size(180, 31)
        alfaPresensiInput.TabIndex = 11
        ' 
        ' nimPresensiInput
        ' 
        nimPresensiInput.Location = New Point(113, 103)
        nimPresensiInput.Name = "nimPresensiInput"
        nimPresensiInput.Size = New Size(341, 31)
        nimPresensiInput.TabIndex = 12
        ' 
        ' namaPresensiInput
        ' 
        namaPresensiInput.Location = New Point(113, 182)
        namaPresensiInput.Name = "namaPresensiInput"
        namaPresensiInput.Size = New Size(341, 31)
        namaPresensiInput.TabIndex = 13
        ' 
        ' hapusPresensiButton
        ' 
        hapusPresensiButton.Location = New Point(45, 469)
        hapusPresensiButton.Name = "hapusPresensiButton"
        hapusPresensiButton.Size = New Size(112, 34)
        hapusPresensiButton.TabIndex = 14
        hapusPresensiButton.Text = "Hapus"
        hapusPresensiButton.UseVisualStyleBackColor = True
        ' 
        ' simpanPresensiButton
        ' 
        simpanPresensiButton.Location = New Point(342, 469)
        simpanPresensiButton.Name = "simpanPresensiButton"
        simpanPresensiButton.Size = New Size(112, 34)
        simpanPresensiButton.TabIndex = 15
        simpanPresensiButton.Text = "Simpan"
        simpanPresensiButton.UseVisualStyleBackColor = True
        ' 
        ' dataPresensiGrid
        ' 
        dataPresensiGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataPresensiGrid.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        dataPresensiGrid.Location = New Point(35, 567)
        dataPresensiGrid.Name = "dataPresensiGrid"
        dataPresensiGrid.RowHeadersWidth = 62
        dataPresensiGrid.Size = New Size(964, 225)
        dataPresensiGrid.TabIndex = 16
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NIM"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Telat"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Alfa"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Sakit"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Izin"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.Width = 150
        ' 
        ' inputPresensiGroup
        ' 
        inputPresensiGroup.Location = New Point(16, 55)
        inputPresensiGroup.Name = "inputPresensiGroup"
        inputPresensiGroup.Size = New Size(506, 494)
        inputPresensiGroup.TabIndex = 1
        inputPresensiGroup.TabStop = False
        inputPresensiGroup.Text = "GroupBox1"
        ' 
        ' PresensiForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1047, 836)
        Controls.Add(dataPresensiGrid)
        Controls.Add(simpanPresensiButton)
        Controls.Add(hapusPresensiButton)
        Controls.Add(namaPresensiInput)
        Controls.Add(nimPresensiInput)
        Controls.Add(alfaPresensiInput)
        Controls.Add(izinPresensiInput)
        Controls.Add(sakitPresensiInput)
        Controls.Add(telatPresensiInput)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(inputPresensiGroup)
        Controls.Add(PresensiLblJudul)
        Name = "PresensiForm"
        Text = "PresensiForm"
        CType(telatPresensiInput, ComponentModel.ISupportInitialize).EndInit()
        CType(sakitPresensiInput, ComponentModel.ISupportInitialize).EndInit()
        CType(izinPresensiInput, ComponentModel.ISupportInitialize).EndInit()
        CType(alfaPresensiInput, ComponentModel.ISupportInitialize).EndInit()
        CType(dataPresensiGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PresensiLblJudul As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents telatPresensiInput As NumericUpDown
    Friend WithEvents sakitPresensiInput As NumericUpDown
    Friend WithEvents izinPresensiInput As NumericUpDown
    Friend WithEvents alfaPresensiInput As NumericUpDown
    Friend WithEvents nimPresensiInput As TextBox
    Friend WithEvents namaPresensiInput As TextBox
    Friend WithEvents hapusPresensiButton As Button
    Friend WithEvents simpanPresensiButton As Button
    Friend WithEvents dataPresensiGrid As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents inputPresensiGroup As GroupBox
End Class
