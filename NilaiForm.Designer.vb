<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NilaiForm
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
        DataGridView1 = New DataGridView()
        Kode_MK = New DataGridViewTextBoxColumn()
        Nama_Matkul = New DataGridViewTextBoxColumn()
        Nilai1 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Kode_MK, Nama_Matkul, Nilai1})
        DataGridView1.Location = New Point(488, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(428, 430)
        DataGridView1.TabIndex = 0
        ' 
        ' Kode_MK
        ' 
        Kode_MK.HeaderText = "Kode MK"
        Kode_MK.MinimumWidth = 6
        Kode_MK.Name = "Kode_MK"
        Kode_MK.Width = 125
        ' 
        ' Nama_Matkul
        ' 
        Nama_Matkul.HeaderText = "Nama Mata Kuliah"
        Nama_Matkul.MinimumWidth = 6
        Nama_Matkul.Name = "Nama_Matkul"
        Nama_Matkul.Width = 125
        ' 
        ' Nilai1
        ' 
        Nilai1.HeaderText = "Nilai"
        Nilai1.MinimumWidth = 6
        Nilai1.Name = "Nilai1"
        Nilai1.Width = 125
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Window
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(73, 89)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(319, 287)
        Panel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(122, 234)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 31)
        Button2.TabIndex = 4
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.ForeColor = Color.White
        Button1.Location = New Point(20, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 31)
        Button1.TabIndex = 4
        Button1.Text = "Tambah"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(20, 191)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(83, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(20, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(262, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 2
        Label3.Text = "Nilai (Angka)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nama Mata Kuliah"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"TIK300", "TIK301", "TIK302", "TIK303", "TIK304", "TIK305"})
        ComboBox1.Location = New Point(20, 37)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(262, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 20)
        Label1.TabIndex = 0
        Label1.Text = "Kode Mata Kuliah"
        ' 
        ' nilai
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(994, 647)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Name = "nilai"
        Text = "nilai"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Kode_MK As DataGridViewTextBoxColumn
    Friend WithEvents Nama_Matkul As DataGridViewTextBoxColumn
    Friend WithEvents Nilai1 As DataGridViewTextBoxColumn
End Class
