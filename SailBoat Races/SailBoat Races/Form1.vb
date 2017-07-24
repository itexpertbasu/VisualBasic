Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    ' End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblB1Rank.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all text boxes and labels
        txtB1R1.Clear()
        txtB1R2.Clear()
        txtB1R3.Clear()
        txtB1R4.Clear()

        txtB2R1.Clear()
        txtB2R2.Clear()
        txtB2R3.Clear()
        txtB2R4.Clear()

        txtB3R1.Clear()
        txtB3R2.Clear()
        txtB3R3.Clear()
        txtB3R4.Clear()

        lblB1Total.Text = String.Empty
        lblB2Total.Text = String.Empty
        lblB3Total.Text = String.Empty
        lblB1Rank.Text = String.Empty
        lblB2Rank.Text = String.Empty
        lblB3Rank.Text = String.Empty

        lblStatus.Text = String.Empty

        'shift focus to the first text box
        txtB1R1.Focus()


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'declare integer variables to hold all the values for text boxes
        'name convention - boat 1 race 1 is B1R1, boat 2 race 1 is B2R1, etc as in a matrix notation

        Dim intB1R1 As Integer
        Dim intB1R2 As Integer
        Dim intB1R3 As Integer
        Dim intB1R4 As Integer

        Dim intB2R1 As Integer
        Dim intB2R2 As Integer
        Dim intB2R3 As Integer
        Dim intB2R4 As Integer

        Dim intB3R1 As Integer
        Dim intB3R2 As Integer
        Dim intB3R3 As Integer
        Dim intB3R4 As Integer

        Dim intColTotal1 As Integer
        Dim intColTotal2 As Integer
        Dim intColTotal3 As Integer
        Dim intColTotal4 As Integer

        Dim intRowTotal1 As Integer
        Dim intRowTotal2 As Integer
        Dim intRowTotal3 As Integer
        '  Dim intRowTotal4 As Integer

        'for the first column get input and calculate total
        Try
            intB1R1 = CInt(txtB1R1.Text)
            intB2R1 = CInt(txtB2R1.Text)
            intB3R1 = CInt(txtB3R1.Text)

            intColTotal1 = intB1R1 + intB2R1 + intB3R1
          


            'for the first column get input and calculate total
            intB1R2 = CInt(txtB1R2.Text)
            intB2R2 = CInt(txtB2R2.Text)
            intB3R2 = CInt(txtB3R2.Text)

            intColTotal2 = intB1R2 + intB2R2 + intB3R2
           

            'for the first column get input and calculate total
            intB1R3 = CInt(txtB1R3.Text)
            intB2R3 = CInt(txtB2R3.Text)
            intB3R3 = CInt(txtB3R3.Text)

            intColTotal3 = intB1R3 + intB2R3 + intB3R3

            'for the first column get input and calculate total

            intB1R4 = CInt(txtB1R4.Text)
            intB2R4 = CInt(txtB2R4.Text)
            intB3R4 = CInt(txtB3R4.Text)

            intColTotal4 = intB1R4 + intB2R4 + intB3R4

            'check the total of all columns are equal to 6. if not display an error message
            'if all row totals are are all right then calculate and display the total points for each row

            If intColTotal1 <> 6 Or intColTotal2 <> 6 Or intColTotal3 <> 6 Or intColTotal4 <> 6 Then
                lblStatus.Text = "Enter 1, 2, and 3 only for each race. Do not enter duplicate values."
            Else
                intRowTotal1 = intB1R1 + intB1R2 + intB1R3 + intB1R4
                intRowTotal2 = intB2R1 + intB2R2 + intB2R3 + intB2R4
                intRowTotal3 = intB3R1 + intB3R2 + intB3R3 + intB3R4

                lblB1Total.Text = intRowTotal1
                lblB2Total.Text = intRowTotal2
                lblB3Total.Text = intRowTotal3

                'check for ties
                'if there is no tie then calculate then comapre the row totals and rank the boats
                If intRowTotal1 = intRowTotal2 Or intRowTotal2 = intRowTotal3 Or intRowTotal3 = intRowTotal1 Then
                    lblStatus.Text = "TIE"
                    lblB1Total.ForeColor = Color.Red
                    lblB2Total.ForeColor = Color.Red
                    lblB3Total.ForeColor = Color.Red
                ElseIf intRowTotal1 < intRowTotal2 And intRowTotal2 < intRowTotal3 Then
                    lblB1Rank.Text = "1"
                    lblB2Rank.Text = "2"
                    lblB3Rank.Text = "3"
                ElseIf intRowTotal1 < intRowTotal2 And intRowTotal2 > intRowTotal3 Then
                    lblB1Rank.Text = "1"
                    lblB2Rank.Text = "3"
                    lblB3Rank.Text = "2"
                ElseIf intRowTotal1 > intRowTotal2 And intRowTotal2 < intRowTotal3 Then
                    lblB1Rank.Text = "2"
                    lblB2Rank.Text = "1"
                    lblB3Rank.Text = "3"
                ElseIf intRowTotal1 < intRowTotal2 And intRowTotal2 > intRowTotal3 Then
                    lblB1Rank.Text = "2"
                    lblB2Rank.Text = "3"
                    lblB3Rank.Text = "1"
                ElseIf intRowTotal1 > intRowTotal2 And intRowTotal2 < intRowTotal3 Then
                    lblB1Rank.Text = "3"
                    lblB2Rank.Text = "1"
                    lblB3Rank.Text = "2"
                ElseIf intRowTotal1 > intRowTotal2 And intRowTotal2 > intRowTotal3 Then
                    lblB1Rank.Text = "3"
                    lblB2Rank.Text = "2"
                    lblB3Rank.Text = "1"

                End If

            End If


        Catch ex As Exception
            'display error message and clear all text fields and shift focus to the first text box
            lblStatus.Text = "Please enter a valid integer"

            txtB1R1.Clear()
            txtB1R2.Clear()
            txtB1R3.Clear()
            txtB1R4.Clear()

            txtB2R1.Clear()
            txtB2R2.Clear()
            txtB2R3.Clear()
            txtB2R4.Clear()

            txtB3R1.Clear()
            txtB3R2.Clear()
            txtB3R3.Clear()
            txtB3R4.Clear()

            txtB1R1.Focus()

            lblStatus.Text = String.Empty
          

        End Try


    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub
End Class
