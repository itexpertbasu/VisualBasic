Public Class Form1
    Const dblPRICE As Double = 75.0

    Const intMAX_ROWS As Integer = 2
    Const intMAX_COLS As Integer = 9
    Dim intSeats(intMAX_ROWS, intMAX_COLS) As Integer

    Dim intCancellation As Integer = 0
    Dim dblTotal As Double = 0.0
    

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTotal.Text = String.Empty
        lblCancel.Text = String.Empty

        btn11.BackColor = Color.White
        btn12.BackColor = Color.White
        btn13.BackColor = Color.White
        btn14.BackColor = Color.White
        btn15.BackColor = Color.White
        btn16.BackColor = Color.White
        btn17.BackColor = Color.White
        btn18.BackColor = Color.White
        btn19.BackColor = Color.White
        btn110.BackColor = Color.White

        btn21.BackColor = Color.White
        btn22.BackColor = Color.White
        btn23.BackColor = Color.White
        btn24.BackColor = Color.White
        btn25.BackColor = Color.White
        btn26.BackColor = Color.White
        btn27.BackColor = Color.White
        btn28.BackColor = Color.White
        btn29.BackColor = Color.White
        btn210.BackColor = Color.White

        btn31.BackColor = Color.White
        btn32.BackColor = Color.White
        btn33.BackColor = Color.White
        btn34.BackColor = Color.White
        btn35.BackColor = Color.White
        btn36.BackColor = Color.White
        btn37.BackColor = Color.White
        btn38.BackColor = Color.White
        btn39.BackColor = Color.White
        btn310.BackColor = Color.White


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        Dim i As Integer
        Dim j As Integer

        For i = 0 To intMAX_ROWS
            For j = 0 To intMAX_COLS
                intSeats(i, j) = 0.0
            Next
        Next


    End Sub

    
    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        If btn11.BackColor = Color.White Then
            btn11.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn11.BackColor = Color.Red Then
            btn11.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        If btn12.BackColor = Color.White Then
            btn12.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn12.BackColor = Color.Red Then
            btn12.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        If btn13.BackColor = Color.White Then
            btn13.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn13.BackColor = Color.Red Then
            btn13.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        If btn14.BackColor = Color.White Then
            btn14.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn14.BackColor = Color.Red Then
            btn14.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        If btn15.BackColor = Color.White Then
            btn15.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn15.BackColor = Color.Red Then
            btn15.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        If btn16.BackColor = Color.White Then
            btn16.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn16.BackColor = Color.Red Then
            btn16.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        If btn17.BackColor = Color.White Then
            btn17.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn17.BackColor = Color.Red Then
            btn17.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        If btn18.BackColor = Color.White Then
            btn18.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn18.BackColor = Color.Red Then
            btn18.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        If btn19.BackColor = Color.White Then
            btn19.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn19.BackColor = Color.Red Then
            btn19.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn110_Click(sender As Object, e As EventArgs) Handles btn110.Click
        If btn110.BackColor = Color.White Then
            btn110.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn110.BackColor = Color.Red Then
            btn110.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        If btn21.BackColor = Color.White Then
            btn21.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn21.BackColor = Color.Red Then
            btn21.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        If btn22.BackColor = Color.White Then
            btn22.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn22.BackColor = Color.Red Then
            btn22.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        If btn23.BackColor = Color.White Then
            btn23.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn23.BackColor = Color.Red Then
            btn23.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        If btn24.BackColor = Color.White Then
            btn24.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn24.BackColor = Color.Red Then
            btn24.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        If btn25.BackColor = Color.White Then
            btn25.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn25.BackColor = Color.Red Then
            btn25.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        If btn26.BackColor = Color.White Then
            btn26.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn26.BackColor = Color.Red Then
            btn26.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        If btn27.BackColor = Color.White Then
            btn27.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn27.BackColor = Color.Red Then
            btn27.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        If btn28.BackColor = Color.White Then
            btn28.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn28.BackColor = Color.Red Then
            btn28.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        If btn29.BackColor = Color.White Then
            btn29.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn29.BackColor = Color.Red Then
            btn29.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn210_Click(sender As Object, e As EventArgs) Handles btn210.Click
        If btn210.BackColor = Color.White Then
            btn210.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn210.BackColor = Color.Red Then
            btn210.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        If btn31.BackColor = Color.White Then
            btn31.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn31.BackColor = Color.Red Then
            btn31.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        If btn32.BackColor = Color.White Then
            btn32.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn32.BackColor = Color.Red Then
            btn32.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        If btn33.BackColor = Color.White Then
            btn33.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn33.BackColor = Color.Red Then
            btn33.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        If btn34.BackColor = Color.White Then
            btn34.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn34.BackColor = Color.Red Then
            btn34.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        If btn35.BackColor = Color.White Then
            btn35.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn35.BackColor = Color.Red Then
            btn35.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        If btn36.BackColor = Color.White Then
            btn36.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn36.BackColor = Color.Red Then
            btn36.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
        If btn37.BackColor = Color.White Then
            btn37.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn37.BackColor = Color.Red Then
            btn37.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
        If btn38.BackColor = Color.White Then
            btn38.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn38.BackColor = Color.Red Then
            btn38.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click
        If btn39.BackColor = Color.White Then
            btn39.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn39.BackColor = Color.Red Then
            btn39.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub

    Private Sub btn310_Click(sender As Object, e As EventArgs) Handles btn310.Click
        If btn310.BackColor = Color.White Then
            btn310.BackColor = Color.Red
            dblTotal = dblTotal + dblPRICE
            lblTotal.Text = dblTotal.ToString("C")

        ElseIf btn310.BackColor = Color.Red Then
            btn310.BackColor = Color.White
            dblTotal = dblTotal - dblPRICE
            intCancellation = intCancellation + 1
            lblTotal.Text = dblTotal.ToString("C")
            lblCancel.Text = intCancellation.ToString()
        End If
    End Sub




End Class
