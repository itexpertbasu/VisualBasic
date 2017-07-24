Public Class Form1

    'declare constants
    Const decMEAL_CH_PER_DAY = 37.0
    Const decPARK_FEE_PER_DAY = 10.0
    Const decTAXI_CH_PER_DAY = 20.0
    Const decLODGE_CH_PER_DAY = 95.0
    Const decCH_PER_MILE = 0.27


    ' Private Function inputValidate()



    'function calcMeals returns the amount reimbursed for meals
    Function calcMeals(ByVal intDays As Integer) As Decimal
        Dim decMealsCost As Decimal
        decMealsCost = decMEAL_CH_PER_DAY * intDays
        Return decMealsCost

    End Function

    'function calcMileage returns the amount reimbursed for mileage
    Function calcMileage(ByVal decMiles As Decimal) As Decimal
        Dim decMilesCost As Decimal
        decMilesCost = decCH_PER_MILE * decMiles
        Return decMilesCost

    End Function

    'function calcParkingFees  returns the amount reimbursed for parking Fees
    Function calcParkingFees(ByVal intDays As Integer) As Decimal
        Dim decParkingFees As Decimal
        decParkingFees = decPARK_FEE_PER_DAY * intDays
        Return decParkingFees

    End Function

    'function calcTaxiFees returns the amount reimbursed for taxi Fees
    Function calcTaxiFees(ByVal intDays As Integer) As Decimal
        Dim decTaxiFees As Decimal
        decTaxiFees = decTAXI_CH_PER_DAY * intDays
        Return decTaxiFees

    End Function

    'function calcLodging returns the amount reimbursed for lodging
    Function calcLodging(ByVal intDays As Integer) As Decimal
        Dim declodgingFees As Decimal
        declodgingFees = decLODGE_CH_PER_DAY * intDays
        Return declodgingFees

    End Function

    'function CalcTotalReimbursement returns total reimbursement
    Function calcTotalReimbursement(ByVal chrg1 As Decimal, ByVal chrg2 As Decimal, ByVal chrg3 As Decimal, ByVal chrg4 As Decimal, ByVal chrg5 As Decimal) As Decimal
        Dim decTotalReimbursement As Decimal
        decTotalReimbursement = chrg1 + chrg2 + chrg3 + chrg4 + chrg5
        Return decTotalReimbursement

    End Function


    'function CalcUnallowed returns amount of expenses that are not allowed
    Function CalcUnallowed(ByVal cost As Decimal, ByVal reimbuersement As Decimal) As Decimal
        Dim decUnallowed As Decimal
        decUnallowed = cost - reimbuersement
        Return decUnallowed

    End Function

    'function CalcSaved returns amount of savings the business person incurred
    Function CalcSaved(ByVal cost As Decimal, ByVal reimbuersement As Decimal) As Decimal
        Dim savings As Decimal
        savings = reimbuersement - cost
        Return savings

    End Function


    'Procedure clearFields clears all fields
    Sub clearFields()
        txtNumDays.Clear()
        txtAirfare.Clear()
        txtMeals.Clear()
        txtRentals.Clear()
        txtMiles.Clear()
        txtParking.Clear()
        txtTaxi.Clear()
        txtRegistration.Clear()
        txtLodging.Clear()

        lblTotalExpenses.Text = String.Empty
        lblAllowableExpenses.Text = String.Empty
        lblExcessToBePaid.Text = String.Empty
        lblAmountSaved.Text = String.Empty


    End Sub



    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'to hold user input
        Dim intDays As Integer
        Dim decAirFare As Decimal
        Dim decMeals As Decimal
        Dim decCarRental As Decimal
        Dim decMiles As Decimal
        Dim decParking As Decimal
        Dim decTaxi As Decimal
        Dim decRegistration As Decimal
        Dim decLodgingPerNight As Decimal


        'to hold allowed amounts reimbursed for each category
        Dim decMealAmount As Decimal
        Dim decMileageAmount As Decimal
        Dim decParkingAmount As Decimal
        Dim decTaxiFeesAmount As Decimal
        Dim decLodgingAmount As Decimal

        'total amount reimbursd for meal, milage, parking, taxifees, lodging
        Dim decTotalReimbursed As Decimal

        'total charges incurred by the business person
        Dim decCostIncurred As Decimal

        'amount of difference between the allowed amount and the incurred amount
        Dim diff As Decimal


        'validate number of days
        Try
            intDays = CInt(txtNumDays.Text)
            If intDays < 1 Then
                MessageBox.Show("The number of days must be greater than or equal to 1")
                clearFields()
            Else
                intDays = CInt(txtNumDays.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try



        'validate airfare
        Try
            decAirFare = CDec(txtAirfare.Text)
            If decAirFare < 0 Then
                MessageBox.Show("Dollar values must be non-negative.")
                clearFields()
            Else
                decAirFare = CDec(txtAirfare.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try



        'validate amount for meals
        Try
            decMeals = CDec(txtMeals.Text)
            If decMeals < 0 Then
                MessageBox.Show("Dollar values must be non-negative.")
                clearFields()
            Else
                decMeals = CDec(txtMeals.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try



        'validate car rental
        Try
            decCarRental = CDec(txtRentals.Text)
            If decCarRental < 0 Then
                MessageBox.Show("Dollar values must be non-negative.")
                clearFields()
            Else
                decCarRental = CDec(txtRentals.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try




        'validate number of miles
        Try
            decMiles = CDec(txtMiles.Text)
            If decMiles < 0 Then
                MessageBox.Show("Miles must be non-negative.")
                clearFields()
            Else
                decMiles = CDec(txtMiles.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try



        'validate parking fees
        Try
            decParking = CDec(txtParking.Text)
            If decParking < 0 Then
                MessageBox.Show("Dollars values must be non-negative.")
                clearFields()
            Else
                decParking = CDec(txtParking.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try



        'validate taxi charges
        Try
            decTaxi = CDec(txtTaxi.Text)
            If decTaxi < 0 Then
                MessageBox.Show("Dollars values must be non-negative.")
                clearFields()
            Else
                decTaxi = CDec(txtTaxi.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try



        'validate registration fees
        Try
            decRegistration = CDec(txtRegistration.Text)
            If decRegistration < 0 Then
                MessageBox.Show("Dollars values must be non-negative.")
                clearFields()
            Else
                decRegistration = CDec(txtRegistration.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try



        'validate lodging per night fees
        Try
            decLodgingPerNight = CDec(txtLodging.Text)
            If decLodgingPerNight < 0 Then
                MessageBox.Show("Dollars values must be non-negative.")
                clearFields()
            Else
                decLodgingPerNight = CDec(txtLodging.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value.")
            clearFields()
        End Try

        'calculate total charges incurred by the business person and print it

        decCostIncurred = decAirFare + decMeals + decCarRental + decParking + decTaxi + decRegistration + (intDays * decLodgingPerNight)
        lblTotalExpenses.Text = decCostIncurred.ToString("c")



        'calculate total amount alllowable for each category and calculate total reimbursement amount
        decMealAmount = calcMeals(intDays)
        decMileageAmount = calcMileage(decMiles)
        decParkingAmount = calcParkingFees(intDays)
        decTaxiFeesAmount = calcTaxiFees(intDays)
        decLodgingAmount = calcLodging(intDays)

        decTotalReimbursed = calcTotalReimbursement(decMealAmount, decMileageAmount, decParkingAmount, decTaxiFeesAmount, decLodgingAmount)

        lblAllowableExpenses.Text = decTotalReimbursed.ToString("c")


        'calculate the unallowed expenses
        If decCostIncurred >= decTotalReimbursed Then
            diff = CalcUnallowed(decCostIncurred, decTotalReimbursed)
            lblExcessToBePaid.Text = diff.ToString("c")
        ElseIf decCostIncurred <= decTotalReimbursed Then
            diff = CalcSaved(decCostIncurred, decTotalReimbursed)
            lblAmountSaved.Text = diff.ToString("c")

        End If



    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearFields()
    End Sub


End Class
