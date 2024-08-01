Imports System.Data.OleDb
Public Class frmloginA

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New System.Data.OleDb.OleDbConnection("Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\datastorage.mdb;")
        Dim cmd As OleDbCommand = New OleDbCommand( _
                   "SELECT * FROM logininfo WHERE Username = '" & _
                   TextBox1.Text & "' AND [Password] = '" & txtPassword.Text & "' ", con)
        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            MessageBox.Show("You are Now Logged In")
            frmMainA.Show()
            TextBox1.Focus()
            TextBox1.Clear()
            txtPassword.Clear()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Do you want to switch user?", vbYesNo + vbQuestion) = vbYes Then
            Me.Hide()
            TextBox1.Clear()
            txtPassword.Clear()
            Frmchoose.Show()
        End If
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class