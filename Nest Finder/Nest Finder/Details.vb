Public Class Details
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub AdminDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdminDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdminDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NestFinderManagementDataSet)

    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NestFinderManagementDataSet.AdminDetails' table. You can move, or remove it, as needed.
        Me.AdminDetailsTableAdapter.Fill(Me.NestFinderManagementDataSet.AdminDetails)

    End Sub
End Class