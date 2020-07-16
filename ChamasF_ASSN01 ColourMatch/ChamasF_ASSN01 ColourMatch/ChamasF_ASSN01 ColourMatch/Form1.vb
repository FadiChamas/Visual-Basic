'*******************************************************
' PROGRAMME	: ASSN01 ColourMatch
'  
' OUTLINE : This programme asks the user to input the 					
'			colour that matches the text colour of the 
' 			word and awards 10 points if they get it 
'			correct. There are 3 rounds with 10 chances
'			each round to make a total maximum score of 
'			300
' 
' PROGRAMMER :	Fadi Chamas
'
'  DATE	:	March 8th, 2019
' *****************************************************
Public Class frmColourMatch
	Private iRound As Integer = 1, iItemsLeft As Integer = 9, numword As Integer = Nothing, numfore As Integer = Nothing, numback As Integer = Nothing, numScore1 As Integer, numScore2 As Integer, numScore3 As Integer
	Private rand As New Random
	Private strColour As String
	Private retry As DialogResult
	Private Sub frmColourMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim rand As New Random
		Dim iVerification As Integer = Nothing
		Dim strVerification As String
		Dim strApples As String = "apples"
		Dim numTimer As Integer = 3
		MessageBox.Show("Press OK to Start!", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Information)
		If iVerification = 0 Then
Verification:
			strVerification = InputBox("Please type in 'apples' to verify you are not a robot,", "Verification Check",)
			If strVerification = strApples Then
				iVerification = 1
			ElseIf strVerification = "" Then
				Me.Close()
			Else
				GoTo Verification
			End If
		End If
		Select Case iRound
			Case 1
				lblTime.Text = 8
				tmrRound1.Enabled = True
			Case 2
				lblTime.Text = 6
			Case 3
				lblTime.Text = 4
			Case Else
				MessageBox.Show("I don't know how you did this, but you broke the game! The application shall now end.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
				End
		End Select
		Call NewFore()
		Call NewBack()
		Call NewLetter()
		Call Check()
	End Sub
	Private Sub tmrRound1_Tick(sender As Object, e As EventArgs) Handles tmrRound1.Tick
		lblTime.Text = Val(lblTime.Text) - 1
		If Val(lblTime.Text) = 0 Then
			MessageBox.Show("Ran out of time!", "No Time Remaining!", MessageBoxButtons.OK, MessageBoxIcon.Error)
			MessageBox.Show("Thanks for playing!" & vbNewLine & "Final Score: " & numScore1 + numScore2 + numScore3, "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information)
			retry = MessageBox.Show("Would you like to play again?", "Retry?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
			If retry = DialogResult.Yes Then
				Application.Restart()
			Else
				Application.Exit()
			End If
		End If
	End Sub
	Private Sub NewFore()
		numfore = rand.Next(0, 8)
		Select Case numfore
			Case 0
				lblDisplay.ForeColor = Color.Red
				strColour = "RED"
			Case 1
				lblDisplay.ForeColor = Color.Orange
				strColour = "ORANGE"
			Case 2
				lblDisplay.ForeColor = Color.Yellow
				strColour = "YELLOW"
			Case 3
				lblDisplay.ForeColor = Color.Green
				strColour = "GREEN"
			Case 4
				lblDisplay.ForeColor = Color.Aquamarine
				strColour = "AQUAMARINE"
			Case 5
				lblDisplay.ForeColor = Color.Blue
				strColour = "BLUE"
			Case 6
				lblDisplay.ForeColor = Color.Fuchsia
				strColour = "FUSCHIA"
			Case 7
				lblDisplay.ForeColor = Color.Black
				strColour = "BLACK"
		End Select
	End Sub
	Private Sub NewBack()
		numback = rand.Next(0, 8)
		Select Case numback
			Case 0
				lblDisplay.BackColor = Color.Red
			Case 1
				lblDisplay.BackColor = Color.Orange
			Case 2
				lblDisplay.BackColor = Color.Yellow
			Case 3
				lblDisplay.BackColor = Color.Green
			Case 4
				lblDisplay.BackColor = Color.Aquamarine
			Case 5
				lblDisplay.BackColor = Color.Blue
			Case 6
				lblDisplay.BackColor = Color.Fuchsia
			Case 7
				lblDisplay.BackColor = Color.Black
		End Select
	End Sub
	Private Sub NewLetter()
		numword = rand.Next(0, 8)
		Select Case numword
			Case 0
				lblDisplay.Text = "RED"
			Case 1
				lblDisplay.Text = "ORANGE"
			Case 2
				lblDisplay.Text = "YELLOW"
			Case 3
				lblDisplay.Text = "GREEN"
			Case 4
				lblDisplay.Text = "AQUAMARINE"
			Case 5
				lblDisplay.Text = "BLUE"
			Case 6
				lblDisplay.Text = "FUSCHIA"
			Case 7
				lblDisplay.Text = "BLACK"
		End Select
	End Sub
	Private Sub txtColour_KeyDown(sender As Object, e As KeyEventArgs) Handles txtColour.KeyDown
		If e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			If txtColour.Text = strColour Then
				If iRound = 1 Then
					lblTime.Text = "8"
					txtColour.Text = Nothing
					iItemsLeft = iItemsLeft - 1
					lblItems.Text = iItemsLeft
					numScore1 = numScore1 + 10
					lblScoreNum.Text = numScore1
					Call NewFore()
					Call NewBack()
					Call NewLetter()
					Call Check()
					Call NoItemsLeft()
				End If
				If iRound = 2 Then
					lblTime.Text = "6"
					txtColour.Text = Nothing
					iItemsLeft = iItemsLeft - 1
					lblItems.Text = iItemsLeft
					numScore2 = numScore2 + 10
					lblScoreNum.Text = numScore2
					Call NewFore()
					Call NewBack()
					Call NewLetter()
					Call Check()
					Call NoItemsLeft()
				End If
				If iRound = 3 Then
					lblTime.Text = "4"
					txtColour.Text = Nothing
					iItemsLeft = iItemsLeft - 1
					lblItems.Text = iItemsLeft
					numScore3 = numScore3 + 10
					lblScoreNum.Text = numScore3
					Call NewFore()
					Call NewBack()
					Call NewLetter()
					Call Check()
					Call NoItemsLeft()
				End If
			Else
				txtColour.Text = Nothing
			End If
		End If
	End Sub
	Private Sub Check()
		If lblDisplay.ForeColor = lblDisplay.BackColor Then
			Call NewFore()
			Call NewBack()
		End If
	End Sub
	Private Sub NoItemsLeft()
		If iItemsLeft = -1 Then
			tmrRound1.Stop()
			Me.Hide()
			iRound += 1
			MessageBox.Show("Round 1: " & numScore1 & vbNewLine & "Round 2: " & numScore2 & vbNewLine & "Round 3: " & numScore3, "Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
			iItemsLeft = 9
			lblItems.Text = iItemsLeft
			lblRound.Text = "Round = " & iRound
			If iRound >= 4 Then
				MessageBox.Show("Thanks for playing!" & vbNewLine & "Final Score: " & numScore1 + numScore2 + numScore3, "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information)
				retry = MessageBox.Show("Would you like to play again?", "Retry?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
				If retry = DialogResult.Yes Then
					Application.Restart()
				Else
					Application.Exit()
				End If
			End If
			Me.Show()
			tmrRound1.Start()
		End If
	End Sub
End Class