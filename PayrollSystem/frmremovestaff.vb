Imports System.Data.OleDb
Imports System.Data
Imports System.Data.DataTable
Public Class frmremovestaff
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim ds As DataSet = New DataSet
    Dim tables As DataTableCollection = ds.Tables
    Dim con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\datastorage.mdb;")
    
    Sub fill()
        Dim dt As New DataTable
        Dim str As String = "Select Username as [Staff Username], Password as [Staff Password] from staff ORDER By Username "
        Dim da As New OleDb.OleDbDataAdapter(str, con)
        da.Fill(dt)
        da.Dispose()
        source1.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.Columns(1).Width = 90
    End Sub
    Public Sub delterminated()
        Try
            Dim str1 As String = "Delete * from staff where [Staff.Username]= '" & DataGridView1.SelectedCells(0).Value.ToString & "'"
            Dim cmd1 As New OleDbCommand(str1, con)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
            fill()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub
    Private Sub deleteuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim dr As New DialogResult
        dr = MessageBox.Show("Are you sure you want to permanently delete " & DataGridView1.SelectedCells(0).Value & "?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If dr = Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show("Action aborted!", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DataGridView1.ClearSelection()
            Exit Sub
        Else
            delterminated()
            fill()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class