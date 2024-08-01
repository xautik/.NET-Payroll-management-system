Public Class Frmchoose
    Dim Admin As New ArrayList
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Admin.Add("Admin")
        Admin.Add("User")
        ComboBox1.DataSource = Admin
        ComboBox1.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Admin" Then
            frmloginA.Show()
            Me.Hide()
        Else
            ComboBox1.Text = "User"
            frmloginU.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Do you want to exit application?", vbYesNo + vbQuestion) = vbYes Then
            Application.Exit()

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
