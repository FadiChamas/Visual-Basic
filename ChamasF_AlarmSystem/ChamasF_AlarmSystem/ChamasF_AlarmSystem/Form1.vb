Public Class frmAlarmSystem
	Private strCode As String
	Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
		msktxtCode.Text = msktxtCode.Text & "1"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
		msktxtCode.Text = msktxtCode.Text & "2"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
		msktxtCode.Text = msktxtCode.Text & "3"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
		msktxtCode.Text = msktxtCode.Text & "4"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
		msktxtCode.Text = msktxtCode.Text & "5"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
		msktxtCode.Text = msktxtCode.Text & "6"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
		msktxtCode.Text = msktxtCode.Text & "7"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
		msktxtCode.Text = msktxtCode.Text & "8"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
		msktxtCode.Text = msktxtCode.Text & "9"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
		msktxtCode.Text = msktxtCode.Text & "0"
		strCode = msktxtCode.Text
	End Sub
	Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
		Call ValidCode(strCode)
	End Sub
	Private Function ValidCode(code As String) As Boolean
		If code = 62498 Then
			MessageBox.Show("ACCESS GRANTED", "Alarm System", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Application.Exit()
		Else
			MessageBox.Show("ACCESS DENIED!", "Alarm System", MessageBoxButtons.OK, MessageBoxIcon.Error)
			msktxtCode.Text = ""
		End If
	End Function
End Class