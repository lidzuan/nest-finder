Public Class Properties
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub PropertiesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PropertiesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PropertiesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NestFinderManagementDataSet)

    End Sub

    Private Sub Properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NestFinderManagementDataSet.Properties' table. You can move, or remove it, as needed.
        Me.PropertiesTableAdapter.Fill(Me.NestFinderManagementDataSet.Properties)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PropertiesBindingSource.Filter = "[House Type] ='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        PropertiesBindingSource.Filter = "[Price] ='" & ComboBox2.Text & "'"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PropertiesBindingSource.Filter = "[Rooms] ='" & ComboBox3.Text & "'"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PropertiesBindingSource.Filter = "[Toilets] ='" & ComboBox4.Text & "'"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PropertiesBindingSource.Filter = "[State] ='" & ComboBox5.Text & "'"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        PropertiesBindingSource.RemoveFilter()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Suggestion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox6.Text = "1" Then
            PictureBox1.Image = My.Resources._1
        ElseIf ComboBox6.Text = "2" Then
            PictureBox1.Image = My.Resources._2
        ElseIf ComboBox6.Text = "3" Then
            PictureBox1.Image = My.Resources._3
        ElseIf ComboBox6.Text = "4" Then
            PictureBox1.Image = My.Resources._4
        ElseIf ComboBox6.Text = "5" Then
            PictureBox1.Image = My.Resources._5
        ElseIf ComboBox6.Text = "6" Then
            PictureBox1.Image = My.Resources._6
        ElseIf ComboBox6.Text = "7" Then
            PictureBox1.Image = My.Resources._7
        ElseIf ComboBox6.Text = "8" Then
            PictureBox1.Image = My.Resources._8
        ElseIf ComboBox6.Text = "9" Then
            PictureBox1.Image = My.Resources._9
        Else
        End If
    End Sub
End Class