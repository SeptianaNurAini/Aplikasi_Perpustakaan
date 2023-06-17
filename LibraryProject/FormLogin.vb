Imports System.Data.SqlClient

Public Class FormLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New SqlCommand("select * from TBL_PETUGAS where KodePetugas='" & TextBox1.Text & "' and PasswordPetugas='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call BukaKunci()
        Else
            MsgBox("Kode Petugas atau Pssword Salah!")
        End If

    End Sub
    Sub BukaKunci()
        Form1.LoginToolStripMenuItem.Enabled = False
        Form1.LogoutToolStripMenuItem.Enabled = True
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.TransaksiToolStripMenuItem.Enabled = True
        Form1.UtilityToolStripMenuItem.Enabled = True
        Form1.LaporanToolStripMenuItem.Enabled = True
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub
End Class