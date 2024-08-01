Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Public Class frmSearch
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\GenerallPayroll.accdb;Persist Security Info=False;"

    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        DataGridView1.DataSource = Nothing
        EmployeeName.Text = ""
    End Sub

    Private Sub button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button6.Click

        exportExcel()

    End Sub
    Sub exportExcel()
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcombo()
    End Sub

    Private Sub EmployeeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeName.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select (PlantID) as [Plant ID], (EmployeeName) as [Employee Name],(Address) as [Address],(ContactNumber) as [ContactNumber],(Email) as [Email],(BloodType) as [BloodType],(Department) as [Department],(Designation) as [Designation],(DateOfOrigin) as [Date of Origin],(Basic) as [Basic Salary] from genpayfinal where EmployeeName = '" & EmployeeName.Text & "'", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)

            Dim myDataSet As DataSet = New DataSet()

            myDA.Fill(myDataSet, "GenPayFinal")

            DataGridView1.DataSource = myDataSet.Tables("GenPayFinal").DefaultView

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillcombo()

        Try

            Dim CN As New oledbConnection(cs)

            CN.Open()
            adp = New oledbDataAdapter()
            adp.SelectCommand = New OleDbCommand("SELECT distinct  (EmployeeName) FROM genpayfinal", CN)
            ds = New DataSet("ds")

            adp.Fill(ds)
            dtable = ds.Tables(0)
            EmployeeName.Items.Clear()

            For Each drow As DataRow In dtable.Rows
                EmployeeName.Items.Add(drow(0).ToString())
                'DocName.SelectedIndex = -1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtEmployee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployee.TextChanged

    End Sub
End Class