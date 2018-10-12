Imports System.Data.SqlClient
Public Class Form1
    Private Sub ListView()
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
    Private Sub bersih()
        TbNama.Text = ""
        TBID.Text = ""
        TbUnit.Text = ""
        DateTimePicker1.Value = Now
        TBdestinasi.Text = ""
        TBReg.Text = ""
        CBtransportasi.Text = ""
        TBnophone.Text = ""
        TBintruksi.Text = ""
        BTsave.Text = "Save"
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView()
        TBIDD.Visible = False
        TextBox1.Visible = False
        
    End Sub

    Private Sub BTsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTsave.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim query As String = ""
        If BTsave.Text = "Save" Then
            Try
                Call OpenKoneksi()
                Dim query_id As String = "select MAX(RequestId)+1 AS MXID From Permintaan"
                cmd = New SqlCommand(query_id, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                uid = dr("MXID")
                dr.Close()
                If CBtransportasi.Text = "Other" Then
                    query = "insert into Permintaan (RequestId,NameRequestor,RequestorId,Unit,DateIssue,UnitDestination,AcRegic,Transportation,Phone,Instruction) values (" & uid & ",'" & TbNama.Text & "','" & TBID.Text & "','" & TbUnit.Text & "','" & DateTimePicker1.Value & "','" & TBdestinasi.Text & "','" & TBReg.Text & "','" & TextBox1.Text & "','" & TBnophone.Text & "','" & TBintruksi.Text & "')"
                End If
                query = "insert into Permintaan (RequestId,NameRequestor,RequestorId,Unit,DateIssue,UnitDestination,AcRegic,Transportation,Phone,Instruction) values (" & uid & ",'" & TbNama.Text & "','" & TBID.Text & "','" & TbUnit.Text & "','" & DateTimePicker1.Value & "','" & TBdestinasi.Text & "','" & TBReg.Text & "','" & CBtransportasi.Text & "','" & TBnophone.Text & "','" & TBintruksi.Text & "')"
                MsgBox("Data '" + TbNama.Text + "' Save!")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
           

        ElseIf BTsave.Text = "Update" Then
            Try
                Call OpenKoneksi()
                query = "Update Permintaan Set NameRequestor='" & TbNama.Text & "',Unit='" & TbUnit.Text & "',UnitDestination='" & TBdestinasi.Text & "',Transportation='" & CBtransportasi.Text & "',RequestorId='" & TBID.Text & "',AcRegic='" & TBReg.Text & "', Phone= '" & TbNama.Text & "', Instruction= '" & TBintruksi.Text & "' Where RequestId= '" & TBIDD.Text & "'"
                MsgBox("Data '" + TbNama.Text + "' Has Been Update")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Try
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            Call CloseKoneksi()
            bersih()
            LV.Clear()
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
            id = LV.SelectedItems(0).Text
            Call OpenKoneksi()
            query = "select * from Permintaan Where RequestId='" + id + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            TbNama.Text = dr("NameRequestor")
            TbUnit.Text = dr("Unit")
            TBdestinasi.Text = dr("UnitDestination")
            CBtransportasi.Text = dr("Transportation")
            TBID.Text = dr("RequestorId")
            TBReg.Text = dr("AcRegic")
            TBnophone.Text = dr("Phone")
            TBintruksi.Text = dr("Instruction")
            TBIDD.Text = dr("RequestId")
            BTsave.Text = "Update"
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BTdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTdelete.Click
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

    Private Sub CBtransportasi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBtransportasi.SelectedIndexChanged
        If CBtransportasi.Text = "Other" Then
            TextBox1.Visible = True
        End If
    End Sub

    Private Sub BTcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTcancel.Click
        bersih()
    End Sub
    Private Sub LV_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LV.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
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
            TbNama.Text = dr("NameRequestor")
            TbUnit.Text = dr("Unit")
            TBdestinasi.Text = dr("UnitDestination")
            CBtransportasi.Text = dr("Transportation")
            TBID.Text = dr("RequestorId")
            TBReg.Text = dr("AcRegic")
            TBnophone.Text = dr("Phone")
            TBintruksi.Text = dr("Instruction")
            TBIDD.Text = dr("RequestId")
            BTsave.Text = "Update"
            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem.Click
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
End Class
