Public Class ManageProperties
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub PropertiesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PropertiesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PropertiesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NestFinderManagementDataSet)

    End Sub

    Private Sub ManageProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NestFinderManagementDataSet.Properties' table. You can move, or remove it, as needed.
        Me.PropertiesTableAdapter.Fill(Me.NestFinderManagementDataSet.Properties)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PropertiesBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PropertiesBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PropertiesBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PropertiesBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.Text = "ADD" Then
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button6.Hide()
            Button7.Hide()
            Button8.Hide()
            Button9.Hide()
            Button10.Hide()
            Button11.Hide()
            Button12.Hide()
            Button13.Hide()
            Button15.Hide()
            PropertiesBindingSource.AddNew()
            Button5.Text = "SAVE NEW"
        Else
            PropertiesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(NestFinderManagementDataSet)
            PropertiesBindingSource.MoveFirst()
            Button5.Text = "ADD"
            Button1.Show()
            Button2.Show()
            Button3.Show()
            Button4.Show()
            Button6.Show()
            Button7.Show()
            Button8.Show()
            Button9.Show()
            Button10.Show()
            Button11.Show()
            Button12.Show()
            Button13.Show()
            Button15.Show()
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.Text = "EDIT" Then
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Button7.Hide()
            Button8.Hide()
            Button9.Hide()
            Button10.Hide()
            Button11.Hide()
            Button12.Hide()
            Button13.Hide()
            Button15.Hide()
            Button6.Text = "SAVE"
        Else
            PropertiesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(NestFinderManagementDataSet)
            PropertiesBindingSource.MoveFirst()
            Button6.Text = "EDIT"
            Button1.Show()
            Button2.Show()
            Button3.Show()
            Button4.Show()
            Button5.Show()
            Button7.Show()
            Button8.Show()
            Button9.Show()
            Button10.Show()
            Button11.Show()
            Button12.Show()
            Button13.Show()
            Button15.Show()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim user_respond As Integer

        user_respond = MessageBox.Show("Are you sure to delete this property? Reminder that this cannot be undone once deleted.", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            PropertiesBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(NestFinderManagementDataSet)
        End If

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
End Class