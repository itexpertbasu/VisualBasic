Public Class MainForm

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtCompany.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtState.Clear()
        txtZip.Clear()

        lblTotal.Text = String.Empty

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        lblTotal.Text = String.Empty

        Dim frmConfOptions As New ConferenceOptions


        frmConfOptions.ShowDialog()

        If frmConfOptions.decTotal > 0 Then
            lblTotal.Text = frmConfOptions.decTotal.ToString("c")
        End If

    End Sub
End Class
