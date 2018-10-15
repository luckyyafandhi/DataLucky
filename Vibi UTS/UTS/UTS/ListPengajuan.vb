Imports System.Data.SqlClient
Public Class ListPengajuan
    Sub ListView()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        LV.View = View.Details
        LV.Columns.Add("No", 50)
        LV.Columns.Add("Name Of Requestor", 150)
        LV.Columns.Add("Unit From", 100)
        LV.Columns.Add("Unit To", 100)
        LV.Columns.Add("Request Date", 150)
        LV.Columns.Add("Transportation", 150)
        Try
            Call OpenKoneksi()
            Dim query_id As String = "select * from Permintaan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            Do While dr.Read
                LV.Items.Add(dr("RequestId"))
                LV.Items(LV.Items.Count - 1).SubItems.Add(dr("NameRequestor"))
                LV.Items(LV.Items.Count - 1).SubItems.Add(dr("Unit"))
                LV.Items(LV.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
                LV.Items(LV.Items.Count - 1).SubItems.Add(dr("DateIssue"))
                LV.Items(LV.Items.Count - 1).SubItems.Add(dr("Transportation"))
            Loop
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ListPengajuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView()
        RefreshToolStripMenuItem.Visible = False
    End Sub

    Private Sub LV_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LV.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub
    Sub edit()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String
        Dim id As String

        Try
            id = LV.SelectedItems(0).Text
            Call OpenKoneksi()
            query = "select * from Permintaan Where RequestId='" + id + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            Form1.TbNama.Text = dr("NameRequestor")
            Form1.TbUnit.Text = dr("Unit")
            Form1.TBdestinasi.Text = dr("UnitDestination")
            Form1.CBtransportasi.Text = dr("Transportation")
            Form1.TBID.Text = dr("RequestorId")
            Form1.TBReg.Text = dr("AcRegic")
            Form1.TBnophone.Text = dr("Phone")
            Form1.TBintruksi.Text = dr("Instruction")
            Form1.TBIDD.Text = dr("RequestId")
            Form1.BTsave.Text = "Update"
            dr.Close()
            Call Form1.Show()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub delete()
        Dim id As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        If MsgBox("Are You Sure Delete?", vbYesNo) = MsgBoxResult.Yes Then
            Try
                id = LV.SelectedItems(0).Text
                Call OpenKoneksi()
                Dim query As String = "delete  from Permintaan Where RequestId='" + id + "'"
                cmd = New SqlCommand(query, conn)
                dr = cmd.ExecuteReader
                bersih()
                Call CloseKoneksi()
                dr.Close()
                LV.Clear()
                ListView()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub bersih()
        Form1.TbNama.Text = ""
        Form1.TBID.Text = ""
        Form1.TbUnit.Text = ""
        Form1.DateTimePicker1.Value = Now
        Form1.TBdestinasi.Text = ""
        Form1.TBReg.Text = ""
        Form1.CBtransportasi.Text = ""
        Form1.TBnophone.Text = ""
        Form1.TBintruksi.Text = ""
        Form1.BTsave.Text = "Save"
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        edit()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem2.Click
        edit()
        Form1.LV.Clear()
        Form1.ListView()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        delete()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        Form1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        LV.Clear()
        ListView()
        LV.Refresh()
    End Sub
End Class