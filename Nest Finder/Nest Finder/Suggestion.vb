Public Class Suggestion
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MessageBox.Show("You might be interested to have a look at Bahagia Flats." & vbNewLine & "Check out the cute property no. 6!", "We got you!")
        Me.Close()
        Properties.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBox.Show("You might be interested to have a look at Jasmine Block." & vbNewLine & "Check out our cozy apartment property no. 7!", "We got you!")
        Me.Close()
        Properties.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MessageBox.Show("You might be interested in a terrace." & vbNewLine & "Check out our budget-friendly property no. 1!", "We got you!")
        Me.Close()
        Properties.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MessageBox.Show("You might be interested to have a look at Taman Villa." & vbNewLine & "Check out our beautiful property no. 5!", "We got you!")
        Me.Close()
        Properties.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MessageBox.Show("You might be interested in a bungalow." & vbNewLine & "Check out our nature-based property no. 3!", "We got you!")
        Me.Close()
        Properties.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        MessageBox.Show("You might be interested in our townhouse." & vbNewLine & "Check out our wonderful property no. 8!", "We got you!")
        Me.Close()
        Properties.Show()
    End Sub
End Class