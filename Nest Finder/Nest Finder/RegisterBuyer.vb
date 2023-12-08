Public Class RegisterBuyer
    Private Sub BuyersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BuyersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BuyersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NestFinderManagementDataSet)

    End Sub

    Private Sub RegisterBuyer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NestFinderManagementDataSet.Buyers' table. You can move, or remove it, as needed.
        Me.BuyersTableAdapter.Fill(Me.NestFinderManagementDataSet.Buyers)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "ADD" Then
            Button3.Show()
            BuyersBindingSource.AddNew()
            Button1.Text = "SAVE"
        Else
            Dim respond As String

            respond = MessageBox.Show("Are you sure all your details are correct?" & vbNewLine & "This cannot be undone after clicking Yes.", "SURE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respond = vbYes Then
                Dim checkfullname As String = Full_NameTextBox.Text
                Dim checkicno As String = IC_NumberTextBox.Text
                Dim checkgender As String = GenderTextBox.Text
                Dim checkage As String = AgeTextBox.Text
                Dim checkcontactno As String = Contact_NumberTextBox.Text
                Dim checkclocation As String = Current_LocationTextBox.Text
                Dim checkhousetype As String = Preferred_House_TypeTextBox.Text
                Dim checkbudget As String = BudgetTextBox.Text

                If checkgender = "" Or checkage = "" Or checkclocation = "" Then
                    MessageBox.Show("Please Check IC first before proceeding.", "REGISTRATION INCOMPLETE!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ElseIf checkfullname = "" Or checkicno = "" Or checkcontactno = "" Or checkhousetype = "" Or checkbudget = "" Then
                    MessageBox.Show("Please fill in all your details before proceeding.", "REGISTRATION INCOMPLETE!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    BuyersBindingSource.EndEdit()
                    TableAdapterManager.UpdateAll(NestFinderManagementDataSet)
                    MessageBox.Show("Thank you for filling in your details!" & vbNewLine & "You're now registered as a customer for Nest Finder." & vbNewLine & "We'll contact you shortly :)", "YOU'RE ON OUR LIST!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim icno As String
        Dim gender As String
        Dim age As Integer
        Dim state As String

        icno = IC_NumberTextBox.Text

        If Len(icno) <> 12 Then
            MessageBox.Show("Please enter the correct IC number.", "INCORRECT IC!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            gender = Microsoft.VisualBasic.Right(icno, 1)
            If gender Mod 2 = 1 Then
                GenderTextBox.Text = "Male"
            Else
                GenderTextBox.Text = "Female"
            End If

            age = Microsoft.VisualBasic.Left(icno, 2)
            Select Case age
                Case 4 To 21
                    MessageBox.Show("You are too young to rent a house!", "UNDERAGE!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 0 To 3
                    AgeTextBox.Text = 2021 - (2000 + age)
                Case Else
                    AgeTextBox.Text = 2021 - (1900 + age)
            End Select

            state = icno.Substring(6, 2)
            Select Case state
                Case Is = "01"
                    Current_LocationTextBox.Text = "Johor"
                Case Is = "02"
                    Current_LocationTextBox.Text = "Kedah"
                Case Is = "03"
                    Current_LocationTextBox.Text = "Kelantan"
                Case Is = "04"
                    Current_LocationTextBox.Text = "Melaka"
                Case Is = "05"
                    Current_LocationTextBox.Text = "Negeri Sembilan"
                Case Is = "06"
                    Current_LocationTextBox.Text = "Pahang"
                Case Is = "07"
                    Current_LocationTextBox.Text = "Penang"
                Case Is = "08"
                    Current_LocationTextBox.Text = "Perak"
                Case Is = "09"
                    Current_LocationTextBox.Text = "Perlis"
                Case Is = "10"
                    Current_LocationTextBox.Text = "Selangor"
                Case Is = "11"
                    Current_LocationTextBox.Text = "Terengganu"
                Case Is = "12"
                    Current_LocationTextBox.Text = "Sabah"
                Case Is = "13"
                    Current_LocationTextBox.Text = "Sarawak"
                Case Is = "14"
                    Current_LocationTextBox.Text = "Kuala Lumpur"
                Case Is = "15"
                    Current_LocationTextBox.Text = "Labuan"
                Case Is = "16"
                    Current_LocationTextBox.Text = "Putrajaya"
                Case Else
                    MessageBox.Show("Please enter the correct IC number.", "INCORRECT IC!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If

    End Sub
End Class