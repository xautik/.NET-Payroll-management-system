Public Class frmprintinfo

    Private Sub GenPayFinalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GenPayFinalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)

    End Sub

    Private Sub frmprintinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GenerallPayrollDataSet.GenPayFinal' table. You can move, or remove it, as needed.
        Me.GenPayFinalTableAdapter.Fill(Me.GenerallPayrollDataSet.GenPayFinal)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        GenPayFinalBindingSource.MoveNext()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GenPayFinalBindingSource.MovePrevious()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt1.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox1.Image, 120, 130, PictureBox1.Width - 15, PictureBox1.Height - 25)
        e.Graphics.DrawImage(Me.PictureBox2.Image, 300, 130, PictureBox2.Width - 15, PictureBox2.Height - 25)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        BasicTextBox.Text = FormatCurrency(BasicTextBox.Text)
        txtReceipt1.Text = ""
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("Employee Name: " + vbTab & EmployeeNameTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Address: " + vbTab + vbTab & AddressTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Contact: " + vbTab + vbTab & ContactNumberTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Email: " + vbTab + vbTab + vbTab & EmailTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Blood Type: " + vbTab + vbTab & BloodTypeTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Designation: " + vbTab + vbTab & DesignationTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Position: " + vbTab + vbTab & PositionTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Basic Salary: " + vbTab + vbTab & BasicTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Date of Origin: " + vbTab + vbTab & DateofOriginTextBox.Text + vbNewLine)

        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt1.AppendText("                                             Special Thanks to BS.Info Tech IV                        " + vbNewLine)
        txtReceipt1.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)
        Me.Close()

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        Me.GenPayFinalBindingSource.Filter = "PlantID LIKE '" & TextBox14.Text & "%'"
    End Sub
End Class