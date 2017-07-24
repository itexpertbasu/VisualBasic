Public Class ConferenceOptions

    'declare constant variables to store the values of the prices for each type of registration
    Const decREGISTRATION As Decimal = 895D
    Const decDINNER As Decimal = 30D
    Const decE_COMMERCE As Decimal = 295D
    Const decWEB As Decimal = 295D
    Const decVB As Decimal = 395D
    Const decNETWORK As Decimal = 395D

    'declare the public variable to store the total of all registration costs
    Public decTotal As Decimal = 0D



    Private Sub lstPreconf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPreconf.SelectedIndexChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click


        If chkRegistration.Checked = False Then
            MessageBox.Show("Must select the $895 registration before selecting other optional items.")
        Else
            decTotal += decREGISTRATION


            If chkDinner.Checked = True Then
                decTotal += decDINNER
            End If

            If lstPreconf.SelectedIndex = 0 Then
                decTotal += decE_COMMERCE
            End If

            If lstPreconf.SelectedIndex = 1 Then
                decTotal = decTotal + decWEB
            End If

            If lstPreconf.SelectedIndex = 2 Then
                decTotal = decTotal + decVB
            End If

            If lstPreconf.SelectedIndex = 3 Then
                decTotal = decTotal + decNETWORK
            End If
        End If


        Me.Close()




    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        chkDinner.Checked = False
        chkRegistration.Checked = False

        lstPreconf.SelectedIndex = -1

    End Sub
End Class