Imports System.Threading
Public Class frmMatchingSquares
	Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
		Dim blueSquares As Integer
		Dim num As Integer
		Dim limit As Integer
		Dim rand As New Random
		Dim tracker As Integer
		Dim code As String = Nothing

		tracker = 0
		blueSquares = 0
		pbFirst.BackColor = Color.White
		pbSecond.BackColor = Color.White
		pbThird.BackColor = Color.White
		pbFourth.BackColor = Color.White
		pbFifth.BackColor = Color.White
		pbSixth.BackColor = Color.White
		pbSeventh.BackColor = Color.White
		pbEighth.BackColor = Color.White
		pbNinth.BackColor = Color.White

code:
		While blueSquares < 3
			Do Until blueSquares = 3
				Thread.Sleep(400)
				num = rand.Next(1, 5)
				If num = 1 Then
					If limit = 1 Then
						If pbFirst.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFirst.BackColor = Color.Blue
						blueSquares = blueSquares + 1
					ElseIf limit = 2 Then
						If pbSecond.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSecond.BackColor = Color.Blue
						blueSquares = blueSquares + 1
					ElseIf limit = 3 Then
						If pbThird.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbThird.BackColor = Color.Blue
						blueSquares = blueSquares + 1
					ElseIf limit = 4 Then
						If pbFourth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFourth.BackColor = Color.Blue
						blueSquares = blueSquares + 1
					ElseIf limit = 5 Then
						If pbFifth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFifth.BackColor = Color.Blue
						blueSquares = blueSquares + 1
					ElseIf limit = 6 Then
						If pbSixth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSixth.BackColor = Color.Blue
						blueSquares = blueSquares + 1
					ElseIf limit = 7 Then
						If pbSeventh.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSeventh.BackColor = Color.Blue
						blueSquares = blueSquares + 1
					ElseIf limit = 8 Then
						If pbEighth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbEighth.BackColor = Color.Blue
						blueSquares = blueSquares + 1
					ElseIf limit = 9 Then
						If pbNinth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbNinth.BackColor = Color.Blue
						blueSquares = blueSquares + 1
						If blueSquares = 3 Then
							MessageBox.Show("Three Blues have been detected!", "Blue Squares", MessageBoxButtons.OK, MessageBoxIcon.Information)
							GoTo code
						End If
						limit = 0
					End If
				ElseIf num = 2 Then
					If limit = 1 Then
						If pbFirst.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFirst.BackColor = Color.Red
					ElseIf limit = 2 Then
						If pbSecond.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSecond.BackColor = Color.Red
					ElseIf limit = 3 Then
						If pbThird.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbThird.BackColor = Color.Red
					ElseIf limit = 4 Then
						If pbFourth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFourth.BackColor = Color.Red
					ElseIf limit = 5 Then
						If pbFifth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFifth.BackColor = Color.Red
					ElseIf limit = 6 Then
						If pbSixth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSixth.BackColor = Color.Red
					ElseIf limit = 7 Then
						If pbSeventh.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSeventh.BackColor = Color.Red
					ElseIf limit = 8 Then
						If pbEighth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbEighth.BackColor = Color.Red
					ElseIf limit = 9 Then
						pbNinth.BackColor = Color.Red
						If blueSquares = 3 Then
							MessageBox.Show("Three Blues have been detected!", "Blue Squares", MessageBoxButtons.OK, MessageBoxIcon.Information)
							GoTo code
						End If
						limit = 0
					Else
					End If
				ElseIf num = 3 Then
					If limit = 1 Then
						If pbFirst.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFirst.BackColor = Color.Yellow
					ElseIf limit = 2 Then
						If pbSecond.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSecond.BackColor = Color.Yellow
					ElseIf limit = 3 Then
						If pbThird.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbThird.BackColor = Color.Yellow
					ElseIf limit = 4 Then
						If pbFourth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFourth.BackColor = Color.Yellow
					ElseIf limit = 5 Then
						If pbFifth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFifth.BackColor = Color.Yellow
					ElseIf limit = 6 Then
						If pbSixth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSixth.BackColor = Color.Yellow
					ElseIf limit = 7 Then
						If pbSeventh.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSeventh.BackColor = Color.Yellow
					ElseIf limit = 8 Then
						If pbEighth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbEighth.BackColor = Color.Yellow
					ElseIf limit = 9 Then
						pbNinth.BackColor = Color.Yellow
						If blueSquares = 3 Then
							MessageBox.Show("Three Blues have been detected!", "Blue Squares", MessageBoxButtons.OK, MessageBoxIcon.Information)
							GoTo code
						End If
						limit = 0
					Else
					End If
				ElseIf num = 4 Then
					If limit = 1 Then
						If pbFirst.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFirst.BackColor = Color.Green
					ElseIf limit = 2 Then
						If pbSecond.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSecond.BackColor = Color.Green
					ElseIf limit = 3 Then
						If pbThird.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbThird.BackColor = Color.Green
					ElseIf limit = 4 Then
						If pbFourth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFourth.BackColor = Color.Green
					ElseIf limit = 5 Then
						If pbFifth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbFifth.BackColor = Color.Green
					ElseIf limit = 6 Then
						If pbSixth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSixth.BackColor = Color.Green
					ElseIf limit = 7 Then
						If pbSeventh.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbSeventh.BackColor = Color.Green
					ElseIf limit = 8 Then
						If pbEighth.BackColor = Color.Blue Then
							limit += 1
							GoTo code
						End If
						pbEighth.BackColor = Color.Green
					ElseIf limit = 9 Then
						pbNinth.BackColor = Color.Green
						If blueSquares = 3 Then
							MessageBox.Show("Three Blues have been detected!", "Blue Squares", MessageBoxButtons.OK, MessageBoxIcon.Information)
							GoTo code
						End If
						limit = 0
					End If
				End If
				If blueSquares = 3 Then
					MessageBox.Show("Three Blues have been detected!", "Blue Squares", MessageBoxButtons.OK, MessageBoxIcon.Information)
					GoTo code
				End If
				limit = limit + 1
				tracker = tracker + 1
				Me.Refresh()
				lblTracked.Text = "Repeats:" & tracker
			Loop
		End While
	End Sub
	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

	Private Sub frmMatchingSquares_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class