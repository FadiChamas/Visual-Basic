Public Class frmPrint
    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName2.Text = iname
        lblDate2.Text = day
        lblFilm2.Text = film
        lblTime2.Text = time
        lblSeats2.Text = iSeats & " " & strSeat & " Seat(s)"
        lblPrice2.Text = 1.13 * (iSeats * iSeatPrice)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        frmSeat.Show()
        Me.Hide()
    End Sub
End Class