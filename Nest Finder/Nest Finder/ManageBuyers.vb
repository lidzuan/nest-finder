Public Class ManageBuyers
    Private Sub BuyersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BuyersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NestFinderManagementDataSet)

    End Sub

    Private Sub ManageBuyers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NestFinderManagementDataSet.Buyers' table. You can move, or remove it, as needed.
        Me.BuyersTableAdapter.Fill(Me.NestFinderManagementDataSet.Buyers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuyersBindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BuyersBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BuyersBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BuyersBindingSource.MoveLast()
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
            BuyersBindingSource.AddNew()
            Button5.Text = "SAVE"
        Else
            BuyersBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(NestFinderManagementDataSet)
            BuyersBindingSource.MoveFirst()
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
            Button6.Text = "SAVE"
        Else
            BuyersBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(NestFinderManagementDataSet)
            BuyersBindingSource.MoveFirst()
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
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim user_respond As Integer

        user_respond = MessageBox.Show("Are you sure to delete the current buyer?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_respond = vbYes Then
            BuyersBindingSource.RemoveCurrent()
            TableAdapterManager.UpdateAll(NestFinderManagementDataSet)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BuyersBindingSource.Filter = "[Preferred House Type] = '" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BuyersBindingSource.RemoveFilter()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        BuyersBindingSource.Filter = "[Current Location] = '" & ComboBox2.Text & "'"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        BuyersBindingSource.Filter = "[Budget] = '" & ComboBox3.Text & "'"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        BuyersBindingSource.Filter = "[Status] = '" & ComboBox4.Text & "'"
    End Sub
End Class