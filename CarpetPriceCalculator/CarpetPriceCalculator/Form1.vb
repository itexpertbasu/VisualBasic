Imports System.IO

Public Class Form1

    'the getCarpetData gets data from the text boxes 
    'and stores it in the object referenced by the Carpet
    Private Sub getCarpetData(ByVal objCarpet As Carpet)
        Try
            'assign values from the form to the object properties
            objCarpet.CarpetColor = txtColor.Text
            objCarpet.CarpetStyle = txtStyle.Text
            objCarpet.pricePerFoot = CDbl(txtPricePerFoot.Text)

        Catch ex As Exception
            'display error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'the getRectangleData gets data from the text boxes 
    'and stores it in the object referenced by the Rectangle
    Private Sub getRectangleData(ByVal objRect As Rectangle)
        Try
            'assign values from the form to the object properties
            objRect.Width = CDbl(txtWidth.Text)
            objRect.Length = CDbl(txtLength.Text)

        Catch ex As Exception
            'display error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtColor.Clear()
        txtStyle.Clear()
        txtPricePerFoot.Clear()

        txtWidth.Clear()
        txtLength.Clear()

        lblArea.Text = String.Empty
        lblTotalCost.Text = String.Empty

        txtColor.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'create an instance of the Carpet class
        Dim objCarpet As New Carpet

        'create an instance of the Rectangle class
        Dim objRectangle As New Rectangle

        'get Data from the forms
        getCarpetData(objCarpet)
        getRectangleData(objRectangle)

        'display the area
        lblArea.Text = objRectangle.Area

        lblTotalCost.Text = (objRectangle.Area * objCarpet.pricePerFoot).ToString("C")


    End Sub
End Class
