Imports System.IO
Public Class frmMainA

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("MMMM  dd  yyyy")
    End Sub

    Private Sub frmmainuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = frmloginA.TextBox1.Text
        Timer1.Start()
    End Sub

    Private Sub btnMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintenance.Click
        Try
            Dim fbd As New FolderBrowserDialog
            If fbd.ShowDialog() = vbOK Then
                File.Copy("GenerallPayroll.accdb", fbd.SelectedPath & "\GenerallPayroll.accdb")
                MsgBox("Done...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        btnLogout.BackColor = Color.White
        btnLogout.ForeColor = Color.Black
        If MsgBox("Do you want to switch user?", vbYesNo + vbQuestion) = vbYes Then
            Me.Hide()
            Frmchoose.Show()
        End If

    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemInfoToolStripMenuItem.Click

    End Sub

    Private Sub btnCataloging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCataloging.Click
        frmregister.Show()

    End Sub

    Private Sub btnCirculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCirculation.Click
        frmpayslip.Show()

    End Sub

    Private Sub AddStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStaffToolStripMenuItem.Click
        frmaddstaff.Show()

    End Sub

    Private Sub RemoveStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveStaffToolStripMenuItem.Click
        frmremovestaff.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        About.Show()

    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub SearchRecordsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class