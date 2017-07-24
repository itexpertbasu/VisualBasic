Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strName As String              'to hold the name from the names list
        Dim intTotal As Integer            'to hold  number of items in the members list

        'if user has selected an item within the valid index of the names list 
        'we get the string and add it to the members list
        'if the string already exists in the members list then prompt the user to select another name
        'if no item is selected from the list, then promt the user with appropriate message

        If lstNames.SelectedIndex >= 0 And lstNames.SelectedIndex < lstNames.Items.Count Then
            strName = lstNames.SelectedItem
            If lstMembers.Items.Contains(strName) Then
                MessageBox.Show("You cannot select a name twice. Please select another name.")
            Else
                lstMembers.Items.Add(strName)
                intTotal = lstMembers.Items.Count
                lblMemberNum.Text = intTotal & " Members"

            End If

        Else
            MessageBox.Show("Please select an item before adding it.")

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim intIndex As Integer     'index of the item selected
        Dim IntTotal As Integer     'to hold total number items in the members list

        IntTotal = lstMembers.Items.Count  'current total of the items in the members list

        'check if the item is selected then get its index
        'then remove the item at that particular index

        If lstMembers.SelectedIndex >= 0 And lstMembers.SelectedIndex < IntTotal Then
            intIndex = lstMembers.SelectedIndex
            lstMembers.Items.RemoveAt(intIndex)

            'decrement number of items and print current items in the label
            IntTotal -= 1
            lblMemberNum.Text = IntTotal & " Members"
        Else
            MessageBox.Show("Please select a name before removing it.")

        End If
    End Sub
End Class
