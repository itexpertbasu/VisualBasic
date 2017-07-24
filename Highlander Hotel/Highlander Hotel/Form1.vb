Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNightlyCharge.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'get today's date from the system and display it
        lblDateToday.Text = Now.ToString("D")

        'get current time from the system and display it
        lblTimeToday.Text = Now.ToString("T")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblDateToday.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decRoomCharges As Decimal       'room charges total
        Dim decAddCharges As Decimal        'additional charges
        Dim decSubtotal As Decimal          'subtotal
        Dim decTax As Decimal               'tax
        Dim decTotal As Decimal             'total of all charges
        Const decTAX_RATE As Decimal = 0.08D     'tax rate

        Try
            'calculate and display room charges
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            'calculate and display additional charges
            decAddCharges = CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("C")

            'calculate and display subtotal
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            'calculate and display tax
            decTax = decSubtotal * decTAX_RATE
            lblTax.Text = decTax.ToString("C")

            'calculate and display total charges
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")

            'change the colors of the total charges
            lblTotal.BackColor = Color.Blue
            lblTotal.ForeColor = Color.White

        Catch
            'error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try

    End Sub

    Private Sub lblAddCharges_Click(sender As Object, e As EventArgs) Handles lblAddCharges.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear room info, additional charges and total charges field
        txtNights.Clear()
        txtNightlyCharge.Clear()

        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        'get current system time and date from the operating system and display them
        lblDateToday.Text = Now.ToString("D")
        lblTimeToday.Text = Now.ToString("T")

        'reset focus to the first field
        txtNights.Focus()

    End Sub
End Class
