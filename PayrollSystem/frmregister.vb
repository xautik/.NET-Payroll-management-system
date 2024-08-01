Public Class frmregister

    Private Sub GenPayFinalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GenPayFinalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)

    End Sub

    Private Sub frmregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GenerallPayrollDataSet.GenPayFinal' table. You can move, or remove it, as needed.
        Me.GenPayFinalTableAdapter.Fill(Me.GenerallPayrollDataSet.GenPayFinal)
        'TODO: This line of code loads data into the 'GenerallPayrollDataSet.GenPayFinal' table. You can move, or remove it, as needed.
        Me.GenPayFinalTableAdapter.Fill(Me.GenerallPayrollDataSet.GenPayFinal)

    End Sub

    Private Sub GenPayFinalBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.GenPayFinalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Len(Trim(PlantIDTextBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Plant ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PlantIDTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(EmployeeNameTextBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmployeeNameTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(AddressTextBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddressTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(ContactNumberTextBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Contact Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ContactNumberTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(EmailTextBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmailTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(BloodTypeComboBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Blood Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BloodTypeComboBox.Focus()
            Exit Sub
        End If

        If Len(Trim(DepartmentComboBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DepartmentComboBox.Focus()
            Exit Sub
        End If

        If Len(Trim(DesignationComboBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Designation", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DesignationComboBox.Focus()
            Exit Sub
        End If

        If Len(Trim(PositionComboBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PositionComboBox.Focus()
            Exit Sub
        End If

        If Len(Trim(DateofOriginDateTimePicker.Text)) = 0 Then
            MessageBox.Show("Please enter employee Date of Origin", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateofOriginDateTimePicker.Focus()
            Exit Sub
        End If

        If Len(Trim(BasicTextBox.Text)) = 0 Then
            MessageBox.Show("Please enter employee Basic Salary", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BasicTextBox.Focus()
            Exit Sub
        End If

        Try
            Me.Validate()
            Me.GenPayFinalBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)
            MessageBox.Show("Successfully Added")
            EmployeeNameTextBox.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        

            If Len(Trim(PlantIDTextBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Plant ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PlantIDTextBox.Focus()
                Exit Sub
            End If

            If Len(Trim(EmployeeNameTextBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmployeeNameTextBox.Focus()
                Exit Sub
            End If

            If Len(Trim(AddressTextBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AddressTextBox.Focus()
                Exit Sub
            End If

            If Len(Trim(ContactNumberTextBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Contact Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ContactNumberTextBox.Focus()
                Exit Sub
            End If

            If Len(Trim(EmailTextBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmailTextBox.Focus()
                Exit Sub
            End If

            If Len(Trim(BloodTypeComboBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Blood Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BloodTypeComboBox.Focus()
                Exit Sub
            End If

            If Len(Trim(DepartmentComboBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Department", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DepartmentComboBox.Focus()
                Exit Sub
            End If

            If Len(Trim(DesignationComboBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Designation", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DesignationComboBox.Focus()
                Exit Sub
            End If

            If Len(Trim(PositionComboBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Position", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PositionComboBox.Focus()
                Exit Sub
            End If

            If Len(Trim(DateofOriginDateTimePicker.Text)) = 0 Then
                MessageBox.Show("Please enter employee Date of Origin", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DateofOriginDateTimePicker.Focus()
                Exit Sub
            End If

            If Len(Trim(BasicTextBox.Text)) = 0 Then
                MessageBox.Show("Please enter employee Basic Salary", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BasicTextBox.Focus()
                Exit Sub
            End If

            Try
                If MsgBox("Do you want to add new employee?", vbYesNo + vbQuestion) = vbYes Then
                    GenPayFinalBindingSource.AddNew()
                    Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)
                    MessageBox.Show("You can now input...")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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
        txtReceipt1.AppendText("Blood Type: " + vbTab + vbTab & BloodTypeComboBox.Text + vbNewLine)
        txtReceipt1.AppendText("Designation: " + vbTab + vbTab & DesignationComboBox.Text + vbNewLine)
        txtReceipt1.AppendText("Position: " + vbTab + vbTab & PositionComboBox.Text + vbNewLine)
        txtReceipt1.AppendText("Basic Salary: " + vbTab + vbTab & BasicTextBox.Text + vbNewLine)
        txtReceipt1.AppendText("Date of Origin: " + vbTab + vbTab & DateofOriginDateTimePicker.Text + vbNewLine)

        txtReceipt1.AppendText("" + vbNewLine)
        txtReceipt1.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtReceipt1.AppendText("                                             Special Thanks to BS.Info Tech IV                        " + vbNewLine)
        txtReceipt1.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtReceipt1.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox1.Image, 120, 130, PictureBox1.Width - 15, PictureBox1.Height - 25)
        e.Graphics.DrawImage(Me.PictureBox2.Image, 300, 130, PictureBox2.Width - 15, PictureBox2.Height - 25)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        

       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TableAdapterManager.UpdateAll(Me.GenerallPayrollDataSet)
        Me.Close()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        GenPayFinalBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        GenPayFinalBindingSource.MoveNext()
    End Sub

    Private Sub Email_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles EmailTextBox.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If EmailTextBox.Text.Length > 0 Then
            If Not rEMail.IsMatch(EmailTextBox.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                EmailTextBox.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        Me.GenPayFinalBindingSource.Filter = "PlantID LIKE '" & TextBox14.Text & "%'"
    End Sub
End Class