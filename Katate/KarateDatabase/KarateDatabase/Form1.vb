Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Karate_DatabaseDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.Karate_DatabaseDataSet.Members)

    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged

        Dim UserInputDate As DateTime
        UserInputDate = DateTimePicker.Value
        Me.MembersTableAdapter.FillByDate(Me.Karate_DatabaseDataSet.Members, UserInputDate)
    End Sub
End Class
