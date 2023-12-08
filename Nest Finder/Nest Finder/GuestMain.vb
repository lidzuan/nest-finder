﻿Public Class GuestMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user_respond As Integer

        user_respond = MessageBox.Show("Are you sure to log out?", "LOG OUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            Me.Close()
            Login.Show()
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Details.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RegisterBuyer.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Properties.Show()
    End Sub
End Class