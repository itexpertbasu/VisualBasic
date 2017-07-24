Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        'concatenate the input
        lblDateString.Text = txtDayOfWeek.Text & ", " &
                             txtDayOfMonth.Text & " " & txtMonth.Text & ", " &
                             txtYear.Text


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDayOfWeek.Clear()
        txtDayOfMonth.Clear()
        txtMonth.Clear()
        txtYear.Clear()

        lblDateString.Text = String.Empty

    End Sub
End Class
