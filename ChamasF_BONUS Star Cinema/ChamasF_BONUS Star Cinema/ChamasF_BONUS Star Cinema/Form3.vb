Public Class frmSeat
    Private Sub txtSeats_TextChanged(sender As Object, e As EventArgs) Handles txtSeats.TextChanged
        btnContinue3.Enabled = True
    End Sub
    Private Sub btnFront_Click(sender As Object, e As EventArgs) Handles btnFront.Click
        If btnMiddle.BackColor = Color.PaleGreen Then
            btnMiddle.BackColor = Color.White
        Else
        End If
        If btnRear.BackColor = Color.PaleGreen Then
            btnRear.BackColor = Color.White
        End If
        btnFront.BackColor = Color.PaleGreen
        lblSType.Text = "Front"
        lblFrontalPrice.Text = "8"
    End Sub
    Private Sub btnMiddle_Click(sender As Object, e As EventArgs) Handles btnMiddle.Click
        If btnFront.BackColor = Color.PaleGreen Then
            btnFront.BackColor = Color.White
        Else
        End If
        If btnRear.BackColor = Color.PaleGreen Then
            btnRear.BackColor = Color.White
        End If
        btnMiddle.BackColor = Color.PaleGreen
        lblSType.Text = "Middle"
        lblFrontalPrice.Text = "10"
    End Sub
    Private Sub btnRear_Click(sender As Object, e As EventArgs) Handles btnRear.Click
        If btnFront.BackColor = Color.PaleGreen Then
            btnFront.BackColor = Color.White
        Else
        End If
        If btnMiddle.BackColor = Color.PaleGreen Then
            btnMiddle.BackColor = Color.White
        End If
        btnRear.BackColor = Color.PaleGreen
        lblSType.Text = "Rear"
        lblFrontalPrice.Text = "12"
    End Sub
    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        frmDateandTime.Show()
        Me.Hide()
    End Sub
    Private Sub btnContinue3_Click(sender As Object, e As EventArgs) Handles btnContinue3.Click
        If Not IsNumeric(txtSeats.Text) Then
            MessageBox.Show("Please use numbers to select the number of seats!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Me.Hide()
            frmPrint.Show()
        End If
    End Sub
End Class