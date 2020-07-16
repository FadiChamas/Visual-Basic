Public Class frmTestScores
	Private grade1, grade2, grade3, average, dropaverage As Integer
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtScore1.Text = Nothing
		txtScore2.Text = Nothing
		txtScore3.Text = Nothing
		grade1 = 0
		grade2 = 0
		grade3 = 0
		average = 0
		lblAverageScore.Text = ""
		lblGradeLetter.Text = ""
		txtScore1.Focus()
	End Sub
	Private Sub btnDrop_Click(sender As Object, e As EventArgs) Handles btnDrop.Click
		GetScores()
		Call DisplayGrade(dropaverage)
		lblAverageScore.Text = dropaverage
	End Sub
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Application.Exit()
	End Sub
	Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
		GetScores()
		Call DisplayGrade(average)
		lblAverageScore.Text = average
	End Sub
	Private Sub GetScores()
		grade1 = CInt(txtScore1.Text)
		grade2 = CInt(txtScore2.Text)
		grade3 = CInt(txtScore3.Text)
		average = (grade1 + grade2 + grade3) / 3
		If grade1 >= grade2 And grade2 >= grade3 Then
			dropaverage = (grade1 + grade2) / 2
		End If
		If grade1 >= grade3 And grade3 >= grade2 Then
			dropaverage = (grade1 + grade3) / 2
		End If
		If grade2 >= grade3 And grade3 >= grade1 Then
			dropaverage = (grade2 + grade3) / 2
		End If
		If grade2 >= grade1 And grade1 >= grade3 Then
			dropaverage = (grade1 + grade2) / 2
		End If
		If grade3 >= grade1 And grade1 >= grade2 Then
			dropaverage = (grade1 + grade3) / 2
		End If
		If grade3 >= grade2 And grade2 >= grade1 Then
			dropaverage = (grade2 + grade3) / 2
		End If
	End Sub
	Private Sub DisplayGrade(avg As Integer)
		If avg <= 49 Then
			lblGradeLetter.Text = "F"
			Exit Sub
		End If
		If avg <= 59 Then
			lblGradeLetter.Text = "D"
			Exit Sub
		End If
		If avg <= 69 Then
			lblGradeLetter.Text = "C"
			Exit Sub
		End If
		If avg <= 79 Then
			lblGradeLetter.Text = "B"
			Exit Sub
		End If
		If avg <= 100 Then
			lblGradeLetter.Text = "A"
			Exit Sub
		End If
	End Sub
End Class