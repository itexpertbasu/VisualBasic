Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radAdult.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles radChild.CheckedChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        radAdult.Checked = True

        chkYoga.Checked = True
        chkKarate.Checked = True
        chkTrainer.Checked = True

        txtMonths.Clear()

        lblMonthlyFee.Text = String.Empty
        lblTotalFee.Text = String.Empty
        ' lblStatusFee.Text = String.Empty

        txtMonths.Focus()


    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles lblStatus.ItemClicked

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

    End Sub
End Class
