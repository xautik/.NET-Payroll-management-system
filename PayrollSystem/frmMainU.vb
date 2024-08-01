Public Class frmmainU

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("MMMM  dd  yyyy")
    End Sub

    Private Sub frmmainuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = frmloginU.TextBox1.Text
        Timer1.Start()
    End Sub

    Private Sub btnMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaintenance.Click
        frmgeneratepayroll.Show()
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
        About.Show()

    End Sub

    Private Sub btnCataloging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCataloging.Click
        frmprintinfo.Show()

    End Sub

    Private Sub btnCirculation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCirculation.Click
        frmprintpay.Show()


    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EmployeeToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
End Class