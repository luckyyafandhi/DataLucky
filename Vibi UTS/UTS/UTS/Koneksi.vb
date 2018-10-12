Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module Koneksi
    Public comSQl As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection

    Public str As String = "Data Source=USER-PC\SQLEXPRESS;" & _
                            "Initial Catalog=DbUTS;" & _
                            "Persist Security Info=True;" & _
                            "UID=sa;PWD=admin"
    Public Sub OpenKoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Koneksi Gagal Pak Eko!: " & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub CloseKoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Eror Pak Eko! " & ex.ToString)
            End Try
        End If
    End Sub
End Module
