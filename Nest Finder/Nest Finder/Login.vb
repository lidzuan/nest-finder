Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password As String

        password = TextBox1.Text

        If password = "1111" And ComboBox1.Text = "Admin" Then
            Me.Close()
            Main.Show()
            MessageBox.Show("Login success!" & vbNewLine & "Welcome back.", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf password = "guest" And ComboBox1.Text = "Guest" Then
            Me.Close()
            GuestMain.Show()
            MessageBox.Show("Login success!" & vbNewLine & "Welcome to Nest Finder.", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Login failed!" & vbNewLine & "Please enter the correct password.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim user_respond As Integer

        user_respond = MessageBox.Show("Are you sure to exit the application?", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            MessageBox.Show("Thank you. Do visit us again :)", "GOODBYE", MessageBoxButtons.OK)
            Application.Exit()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        Welcome.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.UseSystemPasswordChar = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub
End Class