Public Class Buyers
    Private Sub BuyersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BuyersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BuyersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NestFinderManagementDataSet)

    End Sub

    Private Sub Buyers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NestFinderManagementDataSet.Buyers' table. You can move, or remove it, as needed.
        Me.BuyersTableAdapter.Fill(Me.NestFinderManagementDataSet.Buyers)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        RegisterBuyer.Show()
    End Sub
End Class