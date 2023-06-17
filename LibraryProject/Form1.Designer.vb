<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        PetugasToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        AnggotaToolStripMenuItem = New ToolStripMenuItem()
        BukuToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        PeminjamanToolStripMenuItem = New ToolStripMenuItem()
        PengembalianToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        UtilityToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem, UtilityToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenuItem, LogoutToolStripMenuItem, ToolStripMenuItem1, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(112, 22)
        LoginToolStripMenuItem.Text = "Login"' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(112, 22)
        LogoutToolStripMenuItem.Text = "Logout"' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(109, 6)
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(112, 22)
        KeluarToolStripMenuItem.Text = "Keluar"' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PetugasToolStripMenuItem, ToolStripMenuItem2, AnggotaToolStripMenuItem, BukuToolStripMenuItem})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(55, 20)
        MasterToolStripMenuItem.Text = "Master"' 
        ' PetugasToolStripMenuItem
        ' 
        PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        PetugasToolStripMenuItem.Size = New Size(120, 22)
        PetugasToolStripMenuItem.Text = "Petugas"' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(117, 6)
        ' 
        ' AnggotaToolStripMenuItem
        ' 
        AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        AnggotaToolStripMenuItem.Size = New Size(120, 22)
        AnggotaToolStripMenuItem.Text = "Anggota"' 
        ' BukuToolStripMenuItem
        ' 
        BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        BukuToolStripMenuItem.Size = New Size(120, 22)
        BukuToolStripMenuItem.Text = "Buku"' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PeminjamanToolStripMenuItem, PengembalianToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(66, 20)
        TransaksiToolStripMenuItem.Text = "Transaksi"' 
        ' PeminjamanToolStripMenuItem
        ' 
        PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        PeminjamanToolStripMenuItem.Size = New Size(150, 22)
        PeminjamanToolStripMenuItem.Text = "Peminjaman"' 
        ' PengembalianToolStripMenuItem
        ' 
        PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        PengembalianToolStripMenuItem.Size = New Size(150, 22)
        PengembalianToolStripMenuItem.Text = "Pengembalian"' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(62, 20)
        LaporanToolStripMenuItem.Text = "Laporan"' 
        ' UtilityToolStripMenuItem
        ' 
        UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        UtilityToolStripMenuItem.Size = New Size(50, 20)
        UtilityToolStripMenuItem.Text = "Utility"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Untitled
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form Menu Utama Aplikasi Perpustakaan"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilityToolStripMenuItem As ToolStripMenuItem
End Class
