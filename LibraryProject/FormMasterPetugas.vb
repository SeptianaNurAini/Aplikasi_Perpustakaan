Imports System.Data.SqlClient
Public Class FormMasterPetugas
    Sub KondisiAwal()
        Call Koneksi()
        Da = New SqlDataAdapter("select KodePetugas, NamaPetugas, LevelPetugas from tbl_petugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_petugas")
        DataGridView1.DataSource = (Ds.Tables("tbl_petugas"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
    End Sub
    Private Sub FormMasterPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class