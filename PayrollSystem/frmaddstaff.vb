Imports System.Data.OleDb
Public Class frmaddstaff

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\datastorage.mdb;")
            Dim insert As String = "Insert into staff values('" & TextBox1.Text & "','" & TextBox2.Text & "');"
            Dim cmd As New OleDbCommand(insert, con)
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("create success")
            TextBox1.Clear()
            TextBox2.Clear()
            Me.Hide()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
End Class