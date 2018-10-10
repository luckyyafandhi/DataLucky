Imports System.Data.SqlClient

Public Class Form1
    Dim bentuk As string

    Private Sub ListView()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LVpengajuan.View = View.Details
        LVpengajuan.Columns.Add("No", 50)
        LVpengajuan.Columns.Add("Nama Pelaksana", 150)
        LVpengajuan.Columns.Add("Bidang", 100)
        LVpengajuan.Columns.Add("Jml Permintaan", 150)
        LVpengajuan.Columns.Add("Bentuk Dana", 100)
        LVpengajuan.Columns.Add("Keperluan", 200)

        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from Pengajuan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                LVpengajuan.Items.Add(dr("IDPengajuan"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("NamaPengajuan"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("Bidang"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("JmlPermintaan"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("BentukDana"))
                LVpengajuan.Items(LVpengajuan.Items.Count - 1).SubItems.Add(dr("Keperluan"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Bersih()
        TbNama.Text = ""
        CBbidang.Text = ""
        TBpermintaan.Text = ""
        TBkeperluan.Text = ""
        RBcekbank.Checked = False
        RBgiro.Checked = False
        RBtunai.Checked = False
        TBID.Text = ""
        BTsave.Text = "save"

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now
        Call ListView()
        TBID.Visible = False
    End Sub

    Private Sub BTsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTsave.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim query As String = ""
        If BTsave.Text = "save" Then
            Try
                Call OpenKoneksi()
                Dim query_id As String = "select MAX(IDPengajuan)+1 AS MXID from Pengajuan"
                cmd = New SqlCommand(query_id, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                uid = dr("MXID")
                dr.Close()

                If RBcekbank.Checked = True Then
                    bentuk = RBcekbank.Text
                ElseIf RBtunai.Checked = True Then
                    bentuk = RBtunai.Text
                ElseIf RBgiro.Checked = True Then
                    bentuk = RBgiro.Text
                End If

                query = "Insert into Pengajuan (IDPengajuan,NamaPengajuan,Bidang,JmlPermintaan,BentukDana,keperluan,Tanggal) Values(" & uid & ",'" & TbNama.Text & "','" & CBbidang.Text & "','" & TBpermintaan.Text & "','" & bentuk & "','" & TBkeperluan.Text & "','" & DateTimePicker1.Value & "')"
                MsgBox("Selamat '" + TbNama.Text + "' Telah kualat sama aki aki!!!!")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf BTsave.Text = "Update" Then
            Call OpenKoneksi()
            If RBcekbank.Checked = True Then
                bentuk = RBcekbank.Text
            ElseIf RBtunai.Checked = True Then
                bentuk = RBtunai.Text
            ElseIf RBgiro.Checked = True Then
                bentuk = RBgiro.Text
            End If
            query = "Update Pengajuan Set NamaPengajuan='" & TbNama.Text & "',Bidang='" & CBbidang.Text & "',JmlPermintaan='" & TBpermintaan.Text & "',BentukDana='" & bentuk & "',keperluan='" & TBkeperluan.Text & "'Where IDPengajuan='" & TBID.Text & "'"
            MsgBox("Selamat '" + TbNama.Text + "' Telah Berhasil Di Update Anjayyyyy")
        End If
        Try
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()
            Bersih()
            LVpengajuan.Clear()
            ListView()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub BTEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTEdit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String
        Try
            id = LVpengajuan.SelectedItems(0).Text
            Call OpenKoneksi()
            query = "Select * from Pengajuan Where IDPengajuan='" + id + "'"

            If bentuk = RBtunai.Text Then
                RBtunai.Checked = True
            ElseIf bentuk = RBcekbank.Text Then
                RBcekbank.Checked = True
            ElseIf bentuk = RBgiro.Text Then
                RBgiro.Checked = True
            End If
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            TbNama.Text = dr("NamaPengajuan")
            CBbidang.Text = dr("Bidang")
            TBpermintaan.Text = dr("JmlPermintaan")
            bentuk = dr("BentukDana")
            TBkeperluan.Text = dr("Keperluan")
            TBID.Text = dr("IDPengajuan")
            BTsave.Text = "Update"
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub BTDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDelete.Click
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If MsgBox("Apakah Anda Yakin Ingin Menghapusnya?", vbYesNo) = MsgBoxResult.Yes Then
            Try
                id = LVpengajuan.SelectedItems(0).Text
                Call OpenKoneksi()
                Dim query As String = "Delete from Pengajuan Where IDPengajuan='" + id + "'"

                cmd = New SqlCommand(query, conn)
                dr = cmd.ExecuteReader
                Call CloseKoneksi()
                dr.Close()
                LVpengajuan.Clear()
                ListView()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub BTcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTcancel.Click
        Bersih()
    End Sub
End Class
