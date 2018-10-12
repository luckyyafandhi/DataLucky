Imports System.Data.SqlClient
Public Class Login
    Sub bersih()
        CBID.Text = ""
        TBPassword.Text = ""
        CBID.Focus()
    End Sub
    Sub login()
        Call OpenKoneksi()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If CBID.Text = "" And TBPassword.Text = "" Then
            MsgBox("Silahkan Ente Isi Username dan passwordnya!", vbInformation, "pesan")
        Else
            sql = "select * from Login where ID='" & CBID.Text & "'and Password='" & TBPassword.Text & "'"
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()
                Me.Hide()
                Home.Show()

            Else
                MsgBox("Harap Input Dengan Benar", vbCritical, "Pesan")
            End If
        End If
    End Sub
    Sub panggil_id()
        OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String = "select * from Login"
        cmd = New SqlCommand(strsql, conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            CBID.Items.Add(dr("ID"))
        Loop
        dr.Close()
        Call CloseKoneksi()
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panggil_id()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class