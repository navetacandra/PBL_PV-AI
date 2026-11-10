<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        MenuStrip1 = New MenuStrip()
        DataMahasiswaToolStripMenuItem = New ToolStripMenuItem()
        DataPresensiToolStripMenuItem = New ToolStripMenuItem()
        DataMataKuliahToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DataMahasiswaToolStripMenuItem, DataPresensiToolStripMenuItem, DataMataKuliahToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataMahasiswaToolStripMenuItem
        ' 
        DataMahasiswaToolStripMenuItem.Name = "DataMahasiswaToolStripMenuItem"
        DataMahasiswaToolStripMenuItem.Size = New Size(156, 29)
        DataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa"
        ' 
        ' DataPresensiToolStripMenuItem
        ' 
        DataPresensiToolStripMenuItem.Name = "DataPresensiToolStripMenuItem"
        DataPresensiToolStripMenuItem.Size = New Size(134, 29)
        DataPresensiToolStripMenuItem.Text = "Data Presensi"
        ' 
        ' DataMataKuliahToolStripMenuItem
        ' 
        DataMataKuliahToolStripMenuItem.Name = "DataMataKuliahToolStripMenuItem"
        DataMataKuliahToolStripMenuItem.Size = New Size(162, 29)
        DataMataKuliahToolStripMenuItem.Text = "Data Mata Kuliah"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPresensiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataMataKuliahToolStripMenuItem As ToolStripMenuItem

End Class
