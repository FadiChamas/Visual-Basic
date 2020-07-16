Public Class frmDateandTime
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim time0 As String = "15:00"
        Dim time1 As String = "17:00"
        Dim time2 As String = "19:00"
        Dim time3 As String = "21:00"
        Dim time4 As String = "23:00"
        lstTime.Items.Add(time0)
        lstTime.Items.Add(time1)
        lstTime.Items.Add(time2)
        lstTime.Items.Add(time3)
        lstTime.Items.Add(time4)
    End Sub
    Private Sub lstDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDate.SelectedIndexChanged
		lstTime.Enabled = True
	End Sub
	Private Sub lstTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTime.SelectedIndexChanged
		btnContinue2.Enabled = True
	End Sub
	Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
		frmSelect.Show()
		Me.Hide()
	End Sub
	Private Sub btnContinue2_Click(sender As Object, e As EventArgs) Handles btnContinue2.Click
		frmSeat.Show()
		Me.Hide()
	End Sub
End Class