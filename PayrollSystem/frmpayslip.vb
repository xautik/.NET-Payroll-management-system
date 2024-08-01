Public Class frmpayslip

    Private Sub GenPayFinalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GenPayFinalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)

    End Sub

    Private Sub frmpayslip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GenerallPayrollDataSet.GenPayFinal' table. You can move, or remove it, as needed.
        Me.GenPayFinalTableAdapter.Fill(Me.GenerallPayrollDataSet.GenPayFinal)

    End Sub

    Private Sub FacultyUnionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TuitionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Validate()
        Me.GenPayFinalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)
        MessageBox.Show("Successfully Added")
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnDeleteJHS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteJHS.Click
        Try
            If PlantIDTextBox.Text = "" Then
                MessageBox.Show("Please select employee id", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If PlantIDTextBox.Text.Count > 0 Then
                If MessageBox.Show("Do you really want to delete the record?" & vbCrLf & "You can not restore the record" & vbCrLf & "It will delete record permanently" & vbCrLf & "related to selected employee", "Warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    GenPayFinalBindingSource.RemoveCurrent()
                    Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtReceipt.Text = ""
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)

        txtReceipt.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab + vbTab & "PAY-SLIP" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Plantilla Number: " + vbTab & PlantIDTextBox.Text + vbTab + vbTab + vbTab + vbNewLine)
        txtReceipt.AppendText("Employee Name: " + vbTab & EmployeeNameTextBox.Text + vbTab + vbTab + vbNewLine)
        txtReceipt.AppendText("Number: " + vbTab + vbTab & NoTextBox.Text + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)

        txtReceipt.AppendText("Basic Salary: " + vbTab & BasicTextBox.Text + vbNewLine)
        txtReceipt.AppendText("Pera: " + vbTab + vbTab & PERATextBox.Text + vbNewLine)
        txtReceipt.AppendText("Gross Amount: " + vbTab & GrossAmountTextBox.Text + vbNewLine)

        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)

        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab & "Deductions" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("W/ Tax: " + vbTab + vbTab + vbTab & WtaxTextBox.Text + vbNewLine)
        txtReceipt.AppendText("GSIS Premium: " + vbTab + vbTab & GSISPremiumTextBox.Text + vbNewLine)
        txtReceipt.AppendText("GSIS Salary Loan: " + vbTab & GSISSalaryLoanTextBox.Text + vbNewLine)
        txtReceipt.AppendText("GSIS EL: " + vbTab + vbTab & GSISELTextBox.Text + vbNewLine)
        txtReceipt.AppendText("GSIS EMRGL: " + vbTab + vbTab & GSISEMRGLTextBox.Text + vbNewLine)
        txtReceipt.AppendText("GSIS PL: " + vbTab + vbTab & GSISPLTextBox.Text + vbNewLine)
        txtReceipt.AppendText("Pag-Ibig Premium: " + vbTab & PagIbigPremTextBox.Text + vbNewLine)
        txtReceipt.AppendText("Pag-Ibig ML: " + vbTab + vbTab & PagIbigMLTextBox.Text + vbNewLine)
        txtReceipt.AppendText("Pag-Ibig 2: " + vbTab + vbTab & PagIbig2TextBox.Text + vbNewLine)
        txtReceipt.AppendText("Phil Health Premium:  " + vbTab & PhilHealthPremiunTextBox.Text + vbNewLine)
        txtReceipt.AppendText("LEAP: " + vbTab + vbTab + vbTab & LEAPTextBox.Text + vbNewLine)
        txtReceipt.AppendText("IGP: " + vbTab + vbTab + vbTab & IGPTextBox.Text + vbNewLine)
        txtReceipt.AppendText("Faculty Union: " + vbTab + vbTab & FacultyUnionTextBox.Text + vbNewLine)
        txtReceipt.AppendText("Refund Disallow: " + vbTab & RefundDisallowTextBox.Text + vbNewLine)
        txtReceipt.AppendText("Tuition: " + vbTab + vbTab + vbTab & TuitionTextBox.Text + vbNewLine)
        txtReceipt.AppendText("LBP Payment: " + vbTab + vbTab & LBPPaymentTextBox.Text + vbNewLine)
        txtReceipt.AppendText("City Savings: " + vbTab + vbTab & CitySavingsTextBox.Text + vbNewLine)

        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("Total Deductions: " + vbTab & TotalDeductionTextBox.Text + vbTab + vbTab & "Net Amount: " + vbTab & NetAmountTextBox.Text + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText(vbTab & "Due Date: " + Today & vbTab + vbTab + vbTab + vbTab + vbTab + vbTab & "Time: " & TimeOfDay + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText(vbTab + "Recieve by:" + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + vbTab + "___________________" + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + vbTab + EmployeeNameTextBox.Text + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + vbTab + "          Employee" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("" + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText("                                       Need Help?            Contact Us: 09096510899                                        " + vbNewLine)
        txtReceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt.AppendText(vbTab + vbTab + vbTab + PictureBox1.Text + vbNewLine)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox1.Image, 120, 130, PictureBox1.Width - 15, PictureBox1.Height - 25)
        e.Graphics.DrawImage(Me.PictureBox2.Image, 300, 130, PictureBox2.Width - 15, PictureBox2.Height - 25)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TotalDeductionTextBox.Text = Val(WtaxTextBox.Text) + Val(GSISPremiumTextBox.Text) + Val(GSISSalaryLoanTextBox.Text) + Val(GSISELTextBox.Text) + Val(GSISEMRGLTextBox.Text) + Val(GSISPLTextBox.Text) + Val(PagIbigPremTextBox.Text) + Val(PagIbigMLTextBox.Text) + Val(PagIbig2TextBox.Text) + Val(PhilHealthPremiunTextBox.Text) + Val(LEAPTextBox.Text) + Val(IGPTextBox.Text) + Val(FacultyUnionTextBox.Text) + Val(RefundDisallowTextBox.Text) + Val(TuitionTextBox.Text) + Val(LBPPaymentTextBox.Text) + Val(CitySavingsTextBox.Text)
        GrossAmountTextBox.Text = Val(BasicTextBox.Text) + Val(PERATextBox.Text)
        NetAmountTextBox.Text = Val(GrossAmountTextBox.Text) - Val(TotalDeductionTextBox.Text)

        NetAmountTextBox.Text = FormatCurrency(NetAmountTextBox.Text)
        TotalDeductionTextBox.Text = FormatCurrency(TotalDeductionTextBox.Text)
        GrossAmountTextBox.Text = FormatCurrency(GrossAmountTextBox.Text)
        MessageBox.Show("Successfully Computed")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)
        Me.Close()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GenPayFinalBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        GenPayFinalBindingSource.MoveNext()
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        Me.GenPayFinalBindingSource.Filter = "PlantID LIKE '" & TextBox14.Text & "%'"
    End Sub
End Class