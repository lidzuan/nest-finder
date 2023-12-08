Public Class ManageDetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "EDIT" Then
            Button1.Text = "SAVE"
        Else
            AdminDetailsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(NestFinderManagementDataSet)
            AdminDetailsBindingSource.MoveFirst()
            Button1.Text = "EDIT"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ManageDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NestFinderManagementDataSet.AdminDetails' table. You can move, or remove it, as needed.
        Me.AdminDetailsTableAdapter.Fill(Me.NestFinderManagementDataSet.AdminDetails)
    End Sub
End Class